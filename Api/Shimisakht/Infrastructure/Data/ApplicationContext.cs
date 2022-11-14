using Domain.Blog;
using Domain.Identity;
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
    }
}

