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
                json = wc.DownloadString($@"http://jsonplaceholder.typicode.com/{location}");
            }
            return json;
        }
    }
}
