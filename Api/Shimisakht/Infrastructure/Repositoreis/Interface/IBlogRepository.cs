using Domain.Blog;

namespace Infrastructure.Repositoreis.Interface
{
    public interface IBlogParentCatRepository : IGenericRepository<BlogParentCategory>
    {
    }

    public interface IBlogChildCatRepository : IGenericRepository<BlogChildCategory>
    {
    }

    public interface IBlogPostRepository : IGenericRepository<BlogPost>
    {
    }

    public interface IBlogTagRepository : IGenericRepository<BlogTag>
    {
    }

    public interface IBlogPostTagRepository : IGenericRepository<BlogPostTag>
    {
    }
}
