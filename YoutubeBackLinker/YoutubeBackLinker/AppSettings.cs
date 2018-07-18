using System.Configuration;

namespace YoutubeBackLinker
{
    public static class AppSettings
    {
        public static string VideoBaseUrl => ConfigurationManager.AppSettings["youtubeBaseUrl"];
        public static string VideoDownloadDir => ConfigurationManager.AppSettings["videoDownloadDir"];
    }
}
