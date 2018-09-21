using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaGallery.Data;

namespace MediaGallery.Models
{
    public class FrontPageModel
    {
        public IList<MediaItem> NewPhotos { get; set; }
        public IList<MediaItem> PopularPhotos { get; set; }
    }
}
