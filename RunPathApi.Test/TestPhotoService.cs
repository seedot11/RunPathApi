using RunPathApi.Core.Interfaces;
using RunPathApi.Core.Services;

namespace RunPathApi.Test
{
    public class TestPhotoService : PhotoService
    {
        private TestPhotoService(IPhotoFeed photoFeed) : base(photoFeed) 
        { 
        }

        public new static TestPhotoService Create()
        {
            return new TestPhotoService(new TestPhotoFeed());
        }
    }
}
