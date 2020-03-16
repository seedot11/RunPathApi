using Microsoft.Extensions.Configuration;

namespace RunPathApi.Core
{
    public static class AppSettings
    {
        private static IConfigurationRoot configuration;
        private static void Initialise()
        {
            configuration = new ConfigurationBuilder()
                              .AddJsonFile("appsettings.json")
                              .Build();
        }

        /// <summary>
        /// The URL which serves the JSON for photos.
        /// </summary>
        /// <returns></returns>
        public static string PhotosUrl()
        {
            if (configuration == null)
                Initialise();
            return configuration["appSettings:photosUrl"];
        }
    }
}
