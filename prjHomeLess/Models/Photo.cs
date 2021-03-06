using System;
using System.Collections.Generic;

#nullable disable

namespace prjHomeLess.Models
{
    public partial class Photo
    {
        public int PictureId { get; set; }
        public int? ProductId { get; set; }
        public byte[] Picture { get; set; }
        public string PictureName { get; set; }

        public virtual Product Product { get; set; }
    }
}
