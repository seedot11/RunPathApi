﻿using System;

namespace RunPathApi.Core.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AlbumId { get; set; }
        public Uri Url { get; set; }
        public Uri ThumbnailUrl { get; set; }
    }
}
