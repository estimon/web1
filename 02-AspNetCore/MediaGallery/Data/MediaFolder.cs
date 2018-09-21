using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaGallery.Data
{
    public class MediaFolder : MediaItem 
    {
        public IList<MediaItem> Items { get; set; }
        public override string Tumbnail
        {
            get
            {
                //if(Items.Count() > 0)
                //{
                //    return Items[0].Tumbnail;
                //}
                return "folder.png";

            }
            set { }
        }
        

        public MediaFolder()
        {
            Items = new List<MediaItem>();
        }
    }
}
