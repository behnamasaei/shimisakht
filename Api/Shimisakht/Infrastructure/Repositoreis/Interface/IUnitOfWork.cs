using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositoreis.Interface
{
    public interface IUnitOfWork
    { 
        IBlogParentCatRepository BlogParentCatRepository { get; }
        IBlogChildCatRepository BlogChildCatRepository { get; }
        IBlogPostRepository BlogPostRepository { get; }
        IShopParentCatRepository ShopParentCatRepository { get; }
        IShopChildCatRepository ShopChildCatRepository { get; }
        IShopProductRepository ShopProductRepository { get; } 
        

        Task CompleteAsync();
        void Dispose();
    }
}
