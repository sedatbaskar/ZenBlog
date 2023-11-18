using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Entities.Concrete;
using ZenBlog.Entities.Dtos;
using ZenBlog.Shared.Utilities.Result.Abstract;

namespace ZenBlog.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<Category>> Get(int categorId);
        Task<IDataResult<IList<Category>>> GetAll();
        Task<IDataResult<IList<Category>>> GetAllByNoneDeleted();
        Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName);
        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        Task<IResult> Delete(int categoryId, string modifiedByName);
        Task<IResult> HardDelete(int categoryId);



    }
}
