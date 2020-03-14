using System.Collections.Generic;

namespace RunPathApi.Core.Models
{
    public class Album
    {
        public Album()
        {
            Photos = new List<Photo>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public IList<Photo> Photos { get; set; }
    }
}
