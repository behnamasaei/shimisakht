using Domain.Blog;
using Infrastructure.Data;
using Infrastructure.Repositoreis.Interface;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositoreis;

public class BlogParentCatRepository : GenericRepository<BlogParentCategory>, IBlogParentCatRepository
{
    public BlogParentCatRepository(ApplicationContext context, ILogger logger) : base(context, logger)
    {
        
    }
}


public class BlogChildCatRepository : GenericRepository<BlogChildCategory>, IBlogChildCatRepository
{
    public BlogChildCatRepository(ApplicationContext context, ILogger logger) : base(context, logger)
    {

    }
}


public class BlogPostRepository : GenericRepository<BlogPost>, IBlogPostRepository
{
    public BlogPostRepository(ApplicationContext context, ILogger logger) : base(context, logger)
    {

    }
}

