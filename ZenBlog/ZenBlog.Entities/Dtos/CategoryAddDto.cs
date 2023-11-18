using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenBlog.Entities.Dtos
{
    public class CategoryAddDto
    {

        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} adı boş geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır..")]
        [MinLength(3, ErrorMessage = "{0} {1} karaktern küçük olmamalıdır")]
        public string Name { get; set; }

        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} {1} karaktern küçük olmamalıdır")]
        public string Description { get; set; }

        [DisplayName("Kategori Özel Not Alanı")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} {1} karaktern küçük olmamalıdır")]
        public string Note { get; set; }

        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} adı boş geçilmemelidir")]
        public bool IsActive { get; set; }


    }
}
