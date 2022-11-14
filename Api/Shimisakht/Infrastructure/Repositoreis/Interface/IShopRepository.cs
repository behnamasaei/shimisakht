using Domain.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositoreis.Interface
{
    public interface IShopParentCatRepository : IGenericRepository<ShopParentCategory>
    {
    }

    public interface IShopChildCatRepository : IGenericRepository<ShopChildCategory>
    {
    }


    public interface IShopProductRepository : IGenericRepository<ShopProduct>
    {
    }
}
