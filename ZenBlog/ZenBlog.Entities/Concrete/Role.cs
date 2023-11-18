using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Shared.Entities.Abstract;

namespace ZenBlog.Entities.Concrete
{
    public class Role:EntityBase,IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
