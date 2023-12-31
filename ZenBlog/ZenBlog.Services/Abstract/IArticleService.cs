﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Entities.Concrete;
using ZenBlog.Entities.Dtos;
using ZenBlog.Shared.Utilities.Result.Abstract;

namespace ZenBlog.Services.Abstract
{
    public interface IArticleService
    {
        Task<IDataResult<ArticleDto>> Get(int articleId);
        Task<IDataResult<IList<ArticleListDto>>> GetAll();
        Task<IDataResult<IList<ArticleListDto>>> GetAllByNoneDeleted();
        Task<IDataResult<IList<ArticleListDto>>> GetAllByNonDeletedAndActive();
        Task<IDataResult<IList<ArticleListDto>>> GetAllByCategory(int categoryId);
        Task<IResult> Add(ArticleAddDto articleAddDto, string createdByName);
        Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName);
        Task<IResult> Delete(int articleId, string modifiedByName);
        Task<IResult> HardDelete(int articleId);



    }
}
