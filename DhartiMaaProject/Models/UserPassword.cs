using System;
using System.Collections.Generic;

namespace DhartiMaaProject.Models
{
    public partial class UserPassword
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? Password { get; set; }

        public virtual User? User { get; set; }
    }
}
