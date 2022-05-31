using System;
using System.Collections.Generic;

namespace DhartiMaaProject.Models
{
    public partial class BlogCommentLike
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? BlogpostId { get; set; }
        public string? CommnetText { get; set; }
        public int? UserLike { get; set; }
        public bool? IsApproved { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual Blogpost? Blogpost { get; set; }
        public virtual User? User { get; set; }
    }
}
