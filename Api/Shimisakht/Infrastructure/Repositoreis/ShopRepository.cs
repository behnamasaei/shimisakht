using Domain.Shop;
using Infrastructure.Data;
using Infrastructure.Repositoreis.Interface;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositoreis;

public class ShopParentCatRepository : GenericRepository<ShopParentCategory>, IShopParentCatRepository
{
    public ShopParentCatRepository(ApplicationContext context, ILogger logger) : base(context, logger)
    {

    }
}


public class ShopChildCatRepository : GenericRepository<ShopChildCategory>, IShopChildCatRepository
{
    public ShopChildCatRepository(ApplicationContext context, ILogger logger) : base(context, logger)
    {

    }
}


public class ShopProductRepository : GenericRepository<ShopProduct>, IShopProductRepository
{
    public ShopProductRepository(ApplicationContext context, ILogger logger) : base(context, logger)
    {

    }
}

