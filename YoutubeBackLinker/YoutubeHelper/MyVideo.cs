using System;

namespace YoutubeHelper
{
    public class MyVideo
    {
        public bool Selected { get; set; }
        public string Id { get; set; }
        public string ChannelTitle { get; set; }
        public string Description { get; set; }
        public string PublishedAtRaw { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string Title { get; set; }

        public ulong? CommentCount { get; set; }
        public ulong? DislikeCount { get; set; }
        public ulong? FavoriteCount { get; set; }
        public ulong? LikeCount { get; set; }
        public ulong? ViewCount { get; set; }
    }
}
