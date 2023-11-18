using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Entities.Concrete;
using ZenBlog.Shared.Abstract;
using ZenBlog.Shared.Utilities.Result.ComplexTypes;

namespace ZenBlog.Entities.Dtos
{
    public class ArticleDto : DtoGetBase
    {
        public Article Article { get; set; }

        public override ResultStatus ResultStatus { get; set; } = ResultStatus.Success;
    }
}
