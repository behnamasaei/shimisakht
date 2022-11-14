using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Blog
{
    public class BlogChildCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public bool Active { get; set; }

        public Guid ParentId { get; set; }
        public virtual BlogParentCategory ParentCategory { get; set; }

        public virtual ICollection<BlogPost> Posts { get; set; }
    }
}
