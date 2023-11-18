using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Entities.Concrete;
using ZenBlog.Shared.Abstract;
using ZenBlog.Shared.Entities.Abstract;

namespace ZenBlog.Data.Abstract
{
    public interface IUserRepository:IEntityRepository<User>
    {
    }
}
