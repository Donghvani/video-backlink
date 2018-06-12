using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExtractor;

namespace YoutubeHelper
{
    public class Downloader
    {
        public List<MyVideo> MyVideos { get; set; }
        public string SavePath { get; set; }

        //TODO: move to config file
        private string VideoBaseUrl => "https://www.youtube.com/watch?v=";

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
            foreach (var myVideo in MyVideos)
            {
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(VideoBaseUrl + myVideo.Id);


                VideoInfo video = videoInfos
                    .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);


                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }

                var videoDownloader = new VideoDownloader(video, Path.Combine("C:/TEMP", video.Title + video.VideoExtension));

                videoDownloader.DownloadProgressChanged += (sender, args) =>
                {
                    OnDownload?.Invoke(myVideo.Id, args.ProgressPercentage);
                };

                videoDownloader.Execute();
            }
        }
    }
}
