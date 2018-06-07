using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeHelper
{
    public class MyVideo
    {
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
