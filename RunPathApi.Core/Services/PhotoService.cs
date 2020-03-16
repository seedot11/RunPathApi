using Newtonsoft.Json;
using RunPathApi.Core.Interfaces;
using RunPathApi.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace RunPathApi.Core.Services
{
    public class PhotoService
    {
        protected PhotoService(IPhotoFeed feed)
        {
            photoFeed = feed;
        }

        public static PhotoService Create()
        {
            return new PhotoService(new PhotoFeed());
        }

        public IEnumerable<Album> GetPhotosAndAlbums()
        {
            foreach (var photo in Photos)
            {
                var album = Albums.First(a => a.Id == photo.AlbumId);
                album.Photos.Add(photo);
            }
            return Albums;
        }

        public IEnumerable<Album> GetPhotosAndAlbums(int userId)
        {
            return GetPhotosAndAlbums().Where(u => u.UserId == userId);
        }

        public IEnumerable<Photo> Photos
        {
            get
            {
                if (photos == null || !photos.Any())
                {
                    var json = photoFeed.GetFeed("photos");
                    photos = JsonConvert.DeserializeObject<List<Photo>>(json);
                }
                return photos;
            }
            protected set
            {
                photos = value;
            }
        }

        public IEnumerable<Album> Albums
        {
            get
            {
                if (albums == null || !albums.Any())
                {
                    var json = photoFeed.GetFeed("albums");
                    albums = JsonConvert.DeserializeObject<List<Album>>(json);
                }
                return albums;
            }
            protected set
            {
                albums = value;
            }
        }

        private IPhotoFeed photoFeed;
        private IEnumerable<Photo> photos;
        private IEnumerable<Album> albums;
    }
}
