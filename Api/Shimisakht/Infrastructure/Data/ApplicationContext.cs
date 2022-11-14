using Domain.Blog;
using Domain.Identity;
using Domain.Shop;
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

    public DbSet<ShopParentCategory> ShopParentCategories { get; set; }
    public DbSet<ShopChildCategory> ShopChildCategories { get; set; }
    public DbSet<ShopProduct> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

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

