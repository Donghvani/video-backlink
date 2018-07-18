using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using YoutubeExtractor;

namespace YoutubeHelper
{
    public class Downloader
    {
        public List<MyVideo> MyVideos { get; set; }
        public string SavePath { get; set; }
        
        private static string VideoBaseUrl => ConfigurationManager.AppSettings["youtubeBaseUrl"];
        private static string VideoDownloadDir => ConfigurationManager.AppSettings["videoDownloadDir"];

        public delegate void DownloadHandler(string id, double percentage);
        public event DownloadHandler OnDownload;

        public delegate void DownloadProgressChangedHandler(double percentage);

        public Downloader(List<MyVideo> myVideos, string savePath)
        {
            MyVideos = myVideos;
            SavePath = savePath;
        }

        public void Get()
        {
            var tdNow = DateTime.Now;
            string nowFolder = $"{tdNow.Year}-{tdNow.Month:00}-{tdNow.Day:00}-{tdNow.Hour:00}-{tdNow.Minute:00}";

            foreach (var myVideo in MyVideos)
            {
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(VideoBaseUrl + myVideo.Id);
            
                VideoInfo video = videoInfos
                    .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }

                var videoDownloader = new VideoDownloader(video, Path.Combine(VideoDownloadDir, nowFolder, video.Title + video.VideoExtension));

                videoDownloader.DownloadProgressChanged += (sender, args) =>
                {
                    OnDownload?.Invoke(myVideo.Id, args.ProgressPercentage);
                };

                videoDownloader.Execute();
            }
        }
    }
}
