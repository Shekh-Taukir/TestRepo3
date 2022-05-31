using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DhartiMaaProject.Models
{
    public partial class DMDBContext : DbContext
    {
        public DMDBContext()
        {
        }

        public DMDBContext(DbContextOptions<DMDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BlogCommentLike> BlogCommentLikes { get; set; } = null!;
        public virtual DbSet<BlogPictureMapping> BlogPictureMappings { get; set; } = null!;
        public virtual DbSet<Blogpost> Blogposts { get; set; } = null!;
        public virtual DbSet<CartItem> CartItems { get; set; } = null!;
        public virtual DbSet<Discount> Discounts { get; set; } = null!;
        public virtual DbSet<Dmservice> Dmservices { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<OrderItem> OrderItems { get; set; } = null!;
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; } = null!;
        public virtual DbSet<Picture> Pictures { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public virtual DbSet<ProductInventory> ProductInventories { get; set; } = null!;
        public virtual DbSet<ProductPictureMapping> ProductPictureMappings { get; set; } = null!;
        public virtual DbSet<ServicePictureMapping> ServicePictureMappings { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserAddress> UserAddresses { get; set; } = null!;
        public virtual DbSet<UserPassword> UserPasswords { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=database-1.cymks6wpmcwm.ap-south-1.rds.amazonaws.com;Database=DMDB;Username=postgres;Password=gcS12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogCommentLike>(entity =>
            {
                entity.ToTable("blog_comment_likes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.BlogpostId).HasColumnName("blogpost_id");

                entity.Property(e => e.CommnetText).HasColumnName("commnetText");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modified_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserLike).HasColumnName("user_like");

                entity.HasOne(d => d.Blogpost)
                    .WithMany(p => p.BlogCommentLikes)
                    .HasForeignKey(d => d.BlogpostId)
                    .HasConstraintName("blog_comment_likes_blogpost_id_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BlogCommentLikes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("blog_comment_likes_user_id_fkey");
            });

            modelBuilder.Entity<BlogPictureMapping>(entity =>
            {
                entity.ToTable("blog_picture_mapping");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.BlogpostId).HasColumnName("blogpost_id");

                entity.Property(e => e.PictureId).HasColumnName("picture_id");

                entity.HasOne(d => d.Blogpost)
                    .WithMany(p => p.BlogPictureMappings)
                    .HasForeignKey(d => d.BlogpostId)
                    .HasConstraintName("blog_picture_mapping_blogpost_id_fkey");

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.BlogPictureMappings)
                    .HasForeignKey(d => d.PictureId)
                    .HasConstraintName("blog_picture_mapping_picture_id_fkey");
            });

            modelBuilder.Entity<Blogpost>(entity =>
            {
                entity.ToTable("blogpost");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Allowcomments).HasColumnName("allowcomments");

                entity.Property(e => e.BlogBody).HasColumnName("blog_body");

                entity.Property(e => e.BlogTitle).HasColumnName("blog_title");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.Language).HasColumnName("language");
            });

            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.ToTable("cart_items");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modified_at");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("cart_items_product_id_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("cart_items_user_id_fkey");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("discount");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.DiscountDesc).HasColumnName("discount_desc");

                entity.Property(e => e.DiscountName).HasColumnName("discount_name");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modified_at");
            });

            modelBuilder.Entity<Dmservice>(entity =>
            {
                entity.ToTable("dmservices");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Language).HasColumnName("language");

                entity.Property(e => e.ServiceTitle).HasColumnName("serviceTitle");

                entity.Property(e => e.Servicebody).HasColumnName("servicebody");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("order_details");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modified_at");

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("userid_foreginKey");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("order_item");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modified_at");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("order_item_order_id_fkey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("order_item_product_id_fkey");
            });

            modelBuilder.Entity<PaymentDetail>(entity =>
            {
                entity.ToTable("payment_details");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modified_at");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.PaymentApiId).HasColumnName("payment_api_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PaymentDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("payment_details_order_id_fkey");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.ToTable("picture");

                entity.Property(e => e.Id).UseIdentityAlwaysColumn();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.DiscountId).HasColumnName("discount_id");

                entity.Property(e => e.InventoryId).HasColumnName("inventory_id");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modified_at");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductDesc).HasColumnName("product_desc");

                entity.Property(e => e.ProductSku).HasColumnName("product_sku");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("product_category_id_fkey");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("product_discount_id_fkey");

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.InventoryId)
                    .HasConstraintName("product_inventory_id_fkey");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("product_category");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CategoryDesc).HasColumnName("category_desc");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modified_at");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<ProductInventory>(entity =>
            {
                entity.ToTable("product_inventory");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modified_at");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<ProductPictureMapping>(entity =>
            {
                entity.ToTable("product_picture_mapping");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.PictureId).HasColumnName("picture_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.ProductPictureMappings)
                    .HasForeignKey(d => d.PictureId)
                    .HasConstraintName("product_picture_mapping_picture_id_fkey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPictureMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("product_picture_mapping_product_id_fkey");
            });

            modelBuilder.Entity<ServicePictureMapping>(entity =>
            {
                entity.ToTable("service_picture_mapping");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.PictureId).HasColumnName("picture_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.ServicePictureMappings)
                    .HasForeignKey(d => d.PictureId)
                    .HasConstraintName("service_picture_mapping_picture_id_fkey");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServicePictureMappings)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("service_picture_mapping_service_id_fkey");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("createdOnUtc");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Firstname).HasColumnName("firstname");

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.LastLoginDateUtc)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lastLoginDateUtc");

                entity.Property(e => e.Lastname).HasColumnName("lastname");

                entity.Property(e => e.Mobilenumber).HasColumnName("mobilenumber");

                entity.Property(e => e.UpdatedOnUtc)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updatedOnUtc");

                entity.Property(e => e.Verifyemailcode).HasColumnName("verifyemailcode");
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.ToTable("user_address");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.AddressLine1).HasColumnName("address_line1");

                entity.Property(e => e.AddressLine2).HasColumnName("address_line2");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Country).HasColumnName("country");

                entity.Property(e => e.Postcode).HasColumnName("postcode");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAddresses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("user_address_user_id_fkey");
            });

            modelBuilder.Entity<UserPassword>(entity =>
            {
                entity.ToTable("user_password");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPasswords)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("user_password_user_id_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
