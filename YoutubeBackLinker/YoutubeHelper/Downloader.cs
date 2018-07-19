﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using YoutubeExtractor;

namespace YoutubeHelper
{
    public class Downloader
    {
        public List<MyVideo> MyVideos { get; set; }
        public string VideoDownloadDir { get; set; }
        public string VideoBaseUrl { get; set; }

        public delegate void DownloadHandler(string id, double percentage);
        public event DownloadHandler OnDownload;

        public delegate void DownloadProgressChangedHandler(double percentage);

        public Downloader(List<MyVideo> myVideos, string savePath, string videoBaseUrl)
        {
            MyVideos = myVideos;
            VideoDownloadDir = savePath;
            VideoBaseUrl = videoBaseUrl;
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

                var savePath = Path.Combine(VideoDownloadDir, nowFolder);
                if (!Directory.Exists(savePath))
                {
                    Directory.CreateDirectory(savePath);
                }

                var videoDownloader = new VideoDownloader(video,
                    Path.Combine(savePath, GetValidDirectoryName(video.Title + video.VideoExtension)));

                videoDownloader.DownloadProgressChanged += (sender, args) =>
                {
                    OnDownload?.Invoke(myVideo.Id, args.ProgressPercentage);
                };

                videoDownloader.Execute();
            }
        }

        public string GetValidDirectoryName(string directoryName)
        {
            return Path.GetInvalidFileNameChars().Aggregate(directoryName, (current, c) => current.Replace(char.ToString(c), ""));
        }
    }
}
