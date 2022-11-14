using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shop
{
    public class ShopParentCategory : BaseEntity
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<ShopChildCategory> ChildCategories { get; set; }
    }
}
