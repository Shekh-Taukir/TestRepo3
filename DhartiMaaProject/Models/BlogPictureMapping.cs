using System;
using System.Collections.Generic;

namespace DhartiMaaProject.Models
{
    public partial class BlogPictureMapping
    {
        public int Id { get; set; }
        public int? BlogpostId { get; set; }
        public int? PictureId { get; set; }

        public virtual Blogpost? Blogpost { get; set; }
        public virtual Picture? Picture { get; set; }
    }
}
