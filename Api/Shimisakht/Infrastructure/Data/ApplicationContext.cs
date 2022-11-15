using Domain.Blog;
using Domain.Identity;
using Domain.Shop;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ApplicationContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }

    public DbSet<BlogParentCategory> BlogParentCategories { get; set; }
    public DbSet<BlogChildCategory> blogChildCategories { get; set; }
    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<BlogTag> BlogTags { get; set; }
    public DbSet<BlogPostTag> BlogPostTags { get; set; }

    public DbSet<ShopParentCategory> ShopParentCategories { get; set; }
    public DbSet<ShopChildCategory> ShopChildCategories { get; set; }
    public DbSet<ShopProduct> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();
        base.OnModelCreating(builder);

        #region Identity

        builder.Entity<ApplicationUser>()
            .HasData(
                new ApplicationUser
                {
                    Id = new Guid("b74ddd14-6340-4840-95c2-db12554843e1"),
                    UserName = "behnamAdmin",
                    NormalizedUserName = "behnamAdmin".ToUpper(),
                    Email = "behnamAdmin@gmail.com",
                    NormalizedEmail = "behnamAdmin@gmail.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "58125812")
                },
                new ApplicationUser
                {
                    Id = new Guid("b74ddd14-6340-4840-95c2-db12554843e2"),
                    UserName = "behnamAuthor",
                    NormalizedUserName = "behnamAuthor".ToUpper(),
                    Email = "behnamAuthor@gmail.com",
                    NormalizedEmail = "behnamAuthor@gmail.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "58125812")
                },
                new ApplicationUser
                {
                    Id = new Guid("b74ddd14-6340-4840-95c2-db12554843e3"),
                    UserName = "behnamBasic",
                    NormalizedUserName = "behnamBasic".ToUpper(),
                    Email = "behnamBasic@gmail.com",
                    NormalizedEmail = "behnamBasic@gmail.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "58125812")
                });

        builder.Entity<ApplicationRole>()
            .HasData(
                new ApplicationRole
                {
                    Id = new Guid("b74ddd14-6340-4840-95c2-db12554843e4"),
                    Name = UserRolesData.Admin,
                    NormalizedName = UserRolesData.Admin.ToUpper()
                },
                new ApplicationRole
                {
                    Id = new Guid("b74ddd14-6340-4840-95c2-db12554843e5"),
                    Name = UserRolesData.Author,
                    NormalizedName = UserRolesData.Author.ToUpper()
                }, new ApplicationRole
                {
                    Id = new Guid("b74ddd14-6340-4840-95c2-db12554843e6"),
                    Name = UserRolesData.BasicUser,
                    NormalizedName = UserRolesData.BasicUser.ToUpper()
                }
            );

        builder.Entity<IdentityUserRole<Guid>>()
            .HasData(
                // Admin
                new IdentityUserRole<Guid>
                {
                    UserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e1"),
                    RoleId = new Guid("b74ddd14-6340-4840-95c2-db12554843e4")
                },
                new IdentityUserRole<Guid>
                {
                    UserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e1"),
                    RoleId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5")
                },
                new IdentityUserRole<Guid>
                {
                    UserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e1"),
                    RoleId = new Guid("b74ddd14-6340-4840-95c2-db12554843e6")
                },
                // Author
                new IdentityUserRole<Guid>
                {
                    UserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e2"),
                    RoleId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5")
                },
                new IdentityUserRole<Guid>
                {
                    UserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e2"),
                    RoleId = new Guid("b74ddd14-6340-4840-95c2-db12554843e6")
                },
                // Basic
                new IdentityUserRole<Guid>
                {
                    UserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e3"),
                    RoleId = new Guid("b74ddd14-6340-4840-95c2-db12554843e6")
                }
            );


        #endregion





        #region Blog

        builder.Entity<BlogChildCategory>()
            .HasOne(b => b.ParentCategory)
            .WithMany(b => b.ChildCategories)
            .HasForeignKey(f => f.ParentId);

        builder.Entity<BlogParentCategory>()
            .HasMany(b => b.ChildCategories)
            .WithOne(b => b.ParentCategory)
            .HasForeignKey(f => f.ParentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<BlogPost>()
            .HasOne(b => b.BlogChildCategory)
            .WithMany(b => b.Posts)
            .HasForeignKey(f => f.ParentCategoryId);

        builder.Entity<BlogChildCategory>()
            .HasMany(b => b.Posts)
            .WithOne(b => b.BlogChildCategory)
            .HasForeignKey(f => f.ParentCategoryId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<BlogPostTag>()
            .HasKey(k => new { k.BlogPostId, k.BlogTagId });

        builder.Entity<BlogPostTag>()
            .HasOne(b => b.BlogPost)
            .WithMany(b => b.BlogPostTags)
            .HasForeignKey(f => f.BlogPostId);

        builder.Entity<BlogPostTag>()
            .HasOne(b => b.BlogTag)
            .WithMany(b => b.BlogPostTags)
            .HasForeignKey(f => f.BlogTagId);


        #endregion

        #region Shop

        builder.Entity<ShopChildCategory>()
            .HasOne(s => s.ParentCategory)
            .WithMany(s => s.ChildCategories)
            .HasForeignKey(f => f.ParentId);

        builder.Entity<ShopChildCategory>()
            .HasMany(s => s.Products)
            .WithOne(s => s.ShopChildCategory)
            .HasForeignKey(f => f.ShopChildId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<ShopParentCategory>()
            .HasMany(s => s.ChildCategories)
            .WithOne(s => s.ParentCategory)
            .HasForeignKey(f => f.ParentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<ShopProduct>()
            .HasOne(s => s.ShopChildCategory)
            .WithMany(s => s.Products)
            .HasForeignKey(f => f.ShopChildId);

        #endregion
    }
}

