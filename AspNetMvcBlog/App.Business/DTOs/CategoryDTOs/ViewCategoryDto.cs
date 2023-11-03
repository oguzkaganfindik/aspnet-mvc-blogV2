using App.Persistence.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.DTOs.CategoryDTOs
{
    public class ViewCategoryDto
    {
        public int Id { get; set; }


        [StringLength(25, ErrorMessage = "{0} en fazla {1} harf olmali")]
        [MinLength(3, ErrorMessage = "{0} en az {1} harf olmali")]
        public string? Name { get; set; }

        //Relationship
        public ICollection<CategoryPost>? CategoryPosts { get; set; }
    }
}
