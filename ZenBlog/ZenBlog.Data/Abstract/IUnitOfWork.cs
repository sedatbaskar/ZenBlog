using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenBlog.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IArticleRepository Articles { get; }
        ICategoryRepository Categorys { get; }
        ICommentRepository Comments { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }//_UnitofWork.Categories.AddAsync


        //_UnitofWork.Categories.AddAsync(category)
        //unitofwork.users.AddAsync(user)
        //UnitofWork.SaveAsync();
        Task<int> SaveAsync();








    }
}
