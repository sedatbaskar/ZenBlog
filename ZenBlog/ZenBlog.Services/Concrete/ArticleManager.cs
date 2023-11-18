using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Data.Abstract;
using ZenBlog.Entities.Dtos;
using ZenBlog.Services.Abstract;
using ZenBlog.Shared.Utilities.Result.Abstract;
using ZenBlog.Shared.Utilities.Result.ComplexTypes;
using ZenBlog.Shared.Utilities.Result.Concrete;

namespace ZenBlog.Services.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArticleManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IResult> Add(ArticleAddDto articleAddDto, string createdByName)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int articleId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ArticleDto>> Get(int articleId)
        {
            var article=await _unitOfWork.Articles.GetAsync(a=>a.Id==articleId,a=>a.User,a=>a.Category);
            if (article!=null)
            {
                return new DataResult<ArticleDto>(ResultStatus.Success, new ArticleDto
                {
                    Article = article,
                    ResultStatus = ResultStatus.Success,

                });
            }

            return new DataResult<ArticleDto>(ResultStatus.Error, "Böyle bir makalale bulunmadı", null);
        }

        public Task<IDataResult<IList<ArticleListDto>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<ArticleListDto>>> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<ArticleListDto>>> GetAllByNonDeletedAndActive()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<ArticleListDto>>> GetAllByNoneDeleted()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int articleId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }
    }
}
