﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Persistence.Data.Entity
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Kategori Adı")]
        [StringLength(40, ErrorMessage ="{0} {1} karakterden fazla olamaz!")]
        [MinLength(10, ErrorMessage ="{0} en az {1} karakter olabilir!")]

        public string CategoryName { get; set; }

        public List<CategoryPost> CategoryPosts { get; set; }
    }
}
