using System;
using System.Collections.Generic;

namespace DhartiMaaProject.Models
{
    public partial class User
    {
        public User()
        {
            BlogCommentLikes = new HashSet<BlogCommentLike>();
            CartItems = new HashSet<CartItem>();
            OrderDetails = new HashSet<OrderDetail>();
            UserAddresses = new HashSet<UserAddress>();
            UserPasswords = new HashSet<UserPassword>();
        }

        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string Email { get; set; } = null!;
        public string? Verifyemailcode { get; set; }
        public bool? Active { get; set; }
        public bool? IsAdmin { get; set; }
        public decimal? Mobilenumber { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? LastLoginDateUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        public virtual ICollection<BlogCommentLike> BlogCommentLikes { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<UserPassword> UserPasswords { get; set; }
    }
}
