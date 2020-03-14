using RunPathApi.Core.Models;
using System.Collections.Generic;

namespace RunPathApi.Core.Interfaces
{
    public interface IPhotoFeed
    {
        string GetFeed(string location);
    }
}
