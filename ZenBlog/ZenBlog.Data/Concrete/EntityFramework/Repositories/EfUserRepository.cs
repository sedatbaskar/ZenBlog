using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Data.Abstract;
using ZenBlog.Entities.Concrete;
using ZenBlog.Shared.Abstract.Concrete.EnttiyFramework;

namespace ZenBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfUserRepository : EfEntityRepositoryBase<User>, IUserRepository
    {
        public EfUserRepository(DbContext context) : base(context)
        {

        }
    }
}
