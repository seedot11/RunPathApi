using NUnit.Framework;
using System.Linq;

namespace RunPathApi.Test
{
    public class Tests
    {
        private TestPhotoService service;

        [SetUp]
        public void Setup()
        {
            service = TestPhotoService.Create();
        }

        [TestCase(0, 6)]
        [TestCase(1, 5)]
        [TestCase(2, 4)]
        public void GetAllPhotos(int element, int count)
        {
            var albums = service.GetPhotosAndAlbums();
            Assert.AreEqual(albums.Count(), 3);
            Assert.AreEqual(count, albums.ElementAt(element).Photos.Count());
        }

        [TestCase(1, 2)]
        [TestCase(2, 1)]
        public void GetUsersPhotos(int userId, int count)
        {
            Assert.AreEqual(count, service.GetPhotosAndAlbums(userId).Count());
        }
    }
}