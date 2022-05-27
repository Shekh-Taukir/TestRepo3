using System;
using System.Collections.Generic;

namespace DhartiMaaProject.Models
{
    public partial class Blogpost
    {
        public Blogpost()
        {
            BlogCommentLikes = new HashSet<BlogCommentLike>();
            BlogPictureMappings = new HashSet<BlogPictureMapping>();
        }

        public int Id { get; set; }
        public string? BlogTitle { get; set; }
        public string? BlogBody { get; set; }
        public string? Language { get; set; }
        public bool? Allowcomments { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<BlogCommentLike> BlogCommentLikes { get; set; }
        public virtual ICollection<BlogPictureMapping> BlogPictureMappings { get; set; }
    }
}
