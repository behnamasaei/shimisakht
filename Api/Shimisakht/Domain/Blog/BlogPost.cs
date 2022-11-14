using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Blog
{
    public class BlogPost : BaseEntity
    {
        
        public string Title { get; set; }
        public string Content { get; set; }

        public Guid ParentCategoryId { get; set; }
        public BlogChildCategory BlogChildCategory { get; set; }
    }
}
