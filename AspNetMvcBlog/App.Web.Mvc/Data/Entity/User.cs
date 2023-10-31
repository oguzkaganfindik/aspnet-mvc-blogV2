using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace App.Web.Mvc.Data.Entity
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Kullanıcı Adı")]
        [StringLength(50, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
        [MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Kullanıcı Soyadı")]
        [StringLength(50, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
        [MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir!")]
        public string UserSurname { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Kullanıcı Takma Adı")]
        [StringLength(50, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
        [MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir!")]
        public string UserNick { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Kullanıcı E-Mail")]
        [EmailAddress(ErrorMessage = "Yanlış bir mail girdiniz.")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Kullanıcı E-Mail")]
        [PasswordPropertyText]
        public string UserPassword { get; set; }
    }
}
