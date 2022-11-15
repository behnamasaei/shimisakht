using Infrastructure.Data;
using Infrastructure.Repositoreis.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositoreis
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public IBlogParentCatRepository BlogParentCatRepository { get; private set; }

        public IBlogChildCatRepository BlogChildCatRepository { get; private set; }

        public IBlogPostRepository BlogPostRepository { get; private set; }
        public IBlogTagRepository BlogTagRepository { get; private set; }
        public IBlogPostTagRepository BlogPostTagRepository { get; private set; }

        public IShopParentCatRepository ShopParentCatRepository { get; private set; }

        public IShopChildCatRepository ShopChildCatRepository { get; private set; }

        public IShopProductRepository ShopProductRepository { get; private set; }


        private readonly ApplicationContext _context;
        private readonly ILogger _logger;

        public UnitOfWork(ApplicationContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

            BlogParentCatRepository = new BlogParentCatRepository(context, _logger);
            BlogChildCatRepository = new BlogChildCatRepository(context, _logger);
            BlogPostRepository = new BlogPostRepository(context, _logger);
            BlogTagRepository = new BlogTagRepository(context, _logger);
            BlogPostTagRepository = new BlogPostTagRepository(context, _logger);

            ShopParentCatRepository = new ShopParentCatRepository(context, _logger);
            ShopChildCatRepository = new ShopChildCatRepository(context, _logger);
            ShopProductRepository = new ShopProductRepository(context, _logger);
        }





        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
