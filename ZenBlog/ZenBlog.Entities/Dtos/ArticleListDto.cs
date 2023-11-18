using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Entities.Concrete;
using ZenBlog.Shared.Utilities.Result.ComplexTypes;

namespace ZenBlog.Entities.Dtos
{
    public class ArticleListDto
    {
        public IList<Article> Articles { get; set; }
       
    }
}
