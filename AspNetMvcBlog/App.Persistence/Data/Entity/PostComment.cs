﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace App.Persistence.Data.Entity
{
    public class PostComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Yorum")]
        [StringLength(500, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
        [MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir!")]
        public string Comment { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
    }
}
