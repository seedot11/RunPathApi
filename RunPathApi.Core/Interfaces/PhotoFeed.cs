using System.Net;

namespace RunPathApi.Core.Interfaces
{
    public class PhotoFeed : IPhotoFeed
    {
        public string GetFeed(string location)
        {
            string json;
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(AppSettings.PhotosUrl() + location);
            }
            return json;
        }
    }
}
