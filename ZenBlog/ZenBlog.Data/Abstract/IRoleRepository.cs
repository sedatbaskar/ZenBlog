using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Entities.Concrete;
using ZenBlog.Shared.Abstract;

namespace ZenBlog.Data.Abstract
{
    public interface IRoleRepository : IEntityRepository<Role>
    {
    }
}
