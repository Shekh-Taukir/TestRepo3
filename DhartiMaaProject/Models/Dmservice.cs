using System;
using System.Collections.Generic;

namespace DhartiMaaProject.Models
{
    public partial class Dmservice
    {
        public Dmservice()
        {
            ServicePictureMappings = new HashSet<ServicePictureMapping>();
        }

        public int Id { get; set; }
        public string? ServiceTitle { get; set; }
        public string? Servicebody { get; set; }
        public string? Language { get; set; }

        public virtual ICollection<ServicePictureMapping> ServicePictureMappings { get; set; }
    }
}
