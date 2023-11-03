using System.ComponentModel.DataAnnotations;

namespace App.Persistence.DTOs
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "{0} bos gecilemez")]
        [EmailAddress]
        [StringLength(30, ErrorMessage = "{0} en fazla {1} harf olmali")]
        [MinLength(3, ErrorMessage = "{0} en az {1} harf olmali")]
        public string UserEmail { get; set; }

        [StringLength(30, ErrorMessage = "{0} en fazla {1} harf olmali")]
        [Required(ErrorMessage = "{0} bos gecilemez")]
        public string UserPassword { get; set; }
    }
}
