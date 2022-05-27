using System;
using System.Collections.Generic;

namespace DhartiMaaProject.Models
{
    public partial class Picture
    {
        public Picture()
        {
            BlogPictureMappings = new HashSet<BlogPictureMapping>();
            ProductPictureMappings = new HashSet<ProductPictureMapping>();
            ServicePictureMappings = new HashSet<ServicePictureMapping>();
        }

        public int Id { get; set; }
        public string MimeType { get; set; } = null!;
        public string? SeoFilename { get; set; }
        public string? AltAttribute { get; set; }
        public string? TitleAttribute { get; set; }
        public bool IsNew { get; set; }
        public string? VirtualPath { get; set; }

        public virtual ICollection<BlogPictureMapping> BlogPictureMappings { get; set; }
        public virtual ICollection<ProductPictureMapping> ProductPictureMappings { get; set; }
        public virtual ICollection<ServicePictureMapping> ServicePictureMappings { get; set; }
    }
}
