using App.Persistence.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.DTOs.PostDTOs
{
    public class PostDto
    {
        public int Id { get; set; }


        [StringLength(25, ErrorMessage = "{0} en fazla {1} harf olmali")]
        [MinLength(3, ErrorMessage = "{0} en az {1} harf olmali")]
        public string? Title { get; set; }


        [StringLength(500, ErrorMessage = "{0} en fazla {1} harf olmali")]
        [MinLength(5, ErrorMessage = "{0} en az {1} harf olmali")]
        public string? Content { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? PublishedAt { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedAt { get; set; }

        // Relationship
        public ICollection<CategoryPost>? CategoryPosts { get; set; }
        public ICollection<PostComment>? Comments { get; set; }
        public ICollection<PostImage>? Images { get; set; }
    }
}
