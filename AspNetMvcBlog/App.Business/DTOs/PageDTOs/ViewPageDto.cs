using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.DTOs.PageDTOs
{
    public class ViewPageDto
    {
        public int Id { get; set; }


        [StringLength(30, ErrorMessage = "{0} en fazla {1} harf olmali")]
        [MinLength(5, ErrorMessage = "{0} en az {1} harf olmali")]
        public string? Title { get; set; }

        [StringLength(1500, ErrorMessage = "{0} en fazla {1} harf olmali")]
        [MinLength(3, ErrorMessage = "{0} en az {1} harf olmali")]
        public string? Content { get; set; }
    }
}
