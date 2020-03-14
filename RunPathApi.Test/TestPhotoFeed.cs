using RunPathApi.Core.Interfaces;
using System.IO;

namespace RunPathApi.Test
{
    internal class TestPhotoFeed : IPhotoFeed
    {
        public string GetFeed(string location)
        {
            string json;
            using (StreamReader r = new StreamReader($@"..\..\..\Json\{location}.json"))
            {
                json = r.ReadToEnd();
            }
            return json;
        }
    }
}
