﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaGallery.Data
{
    public class Video : MediaFile
    {

        public override string Tumbnail
        {
            get { return FileName; }
            set { }
        }
    }
}
