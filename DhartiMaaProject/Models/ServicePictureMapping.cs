using System;
using System.Collections.Generic;

namespace DhartiMaaProject.Models
{
    public partial class ServicePictureMapping
    {
        public int Id { get; set; }
        public int? PictureId { get; set; }
        public int? ServiceId { get; set; }

        public virtual Picture? Picture { get; set; }
        public virtual Dmservice? Service { get; set; }
    }
}
