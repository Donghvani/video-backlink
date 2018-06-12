using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace YoutubeHelper
{
    public class Search
    {
        public async Task<List<MyVideo>> Run(string apiKey, string searchTerm, int maxResults)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = apiKey,
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = searchTerm;
            searchListRequest.MaxResults = maxResults;

            // Call the search.list method to retrieve results matching the specified query term.
            SearchListResponse searchListResponse = await searchListRequest.ExecuteAsync();

            var videos = new List<MyVideo>();
            //List<string> channels = new List<string>();
            //List<string> playlists = new List<string>();

            // Add each result to the appropriate list, and then display the lists of
            // matching videos, channels, and playlists.
            foreach (SearchResult searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":
                        var stats = GetVideoStats(youtubeService, searchResult.Id.VideoId);
                        MyVideo myVideo = new MyVideo
                        {
                            Id = searchResult.Id.VideoId,
                            ChannelTitle = searchResult.Snippet.ChannelTitle,
                            Description = searchResult.Snippet.Description,
                            PublishedAtRaw = searchResult.Snippet.PublishedAtRaw,
                            PublishedAt = searchResult.Snippet.PublishedAt,
                            Title = searchResult.Snippet.Title,

                            CommentCount = stats.CommentCount,
                            DislikeCount = stats.DislikeCount,
                            FavoriteCount = stats.FavoriteCount,
                            LikeCount = stats.LikeCount,
                            ViewCount = stats.ViewCount
                        };

                        videos.Add(myVideo);
                        break;

                    //case "youtube#channel":
                    //    channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
                    //    break;

                    //case "youtube#playlist":
                    //    playlists.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.PlaylistId));
                    //    break;
                }
            }

            return videos.OrderByDescending(vd => vd.ViewCount).ToList();
        }

        public VideoStatistics GetVideoStats(YouTubeService youtubeService, string videoId)
        {
            VideosResource.ListRequest listRequest = youtubeService.Videos.List("statistics");
            listRequest.Id = videoId;
            VideoListResponse videoListResponse = listRequest.Execute();
            IList<Video> items = videoListResponse.Items;
            if (items.Count > 0)
            {
                return items[0].Statistics;
            }

            return null;
        }
    }
}
