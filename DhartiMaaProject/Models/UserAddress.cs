using System;
using System.Collections.Generic;

namespace DhartiMaaProject.Models
{
    public partial class UserAddress
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public int? Postcode { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }

        public virtual User? User { get; set; }
    }
}
