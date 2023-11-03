using App.Persistence.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.DTOs.CategoryDTOs
{
    public class CreateOrEditCategoryDto
    {
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Kategori Adı")]
        [StringLength(40, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
        [MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir!")]
        public string CategoryName { get; set; }
    }
}
