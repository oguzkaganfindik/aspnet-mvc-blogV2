using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.DTOs.UserDTOs
{
    public class UserDto
    {
        public int Id { get; set; }


        [StringLength(30, ErrorMessage = "{0} en fazla {1} harf olmali")]
        [MinLength(3, ErrorMessage = "{0} en az {1} harf olmali")]
        public string? Name { get; set; }


        [StringLength(30, ErrorMessage = "{0} en fazla {1} harf olmali")]
        [MinLength(3, ErrorMessage = "{0} en az {1} harf olmali")]
        public string? Surname { get; set; }

        [EmailAddress]
        [StringLength(30, ErrorMessage = "{0} en fazla {1} harf olmali")]
        [MinLength(3, ErrorMessage = "{0} en az {1} harf olmali")]
        public string? Email { get; set; }

        [StringLength(30, ErrorMessage = "{0} en fazla {1} harf olmali")]

        //[PasswordPropertyText]
        //[DataType(DataType.Password)]
        public string? Password { get; set; }

        [StringLength(100, ErrorMessage = "{0} en fazla {1} harf olmali")]

        public string? ProfilePictureURL { get; set; }
        //[ScaffoldColumn(false)]
    }
}
