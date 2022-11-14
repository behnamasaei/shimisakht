using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shop
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Price { get; set; }
        public string Slug { get; set; }
        public bool Active { get; set; }


        public Guid ShopChildId { get; set; }
        public virtual ShopChildCategory ShopChildCategory { get; set; }

    }
}
