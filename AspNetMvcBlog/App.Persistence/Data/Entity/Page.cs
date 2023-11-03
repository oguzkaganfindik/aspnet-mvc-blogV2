using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace App.Persistence.Data.Entity
{
	public class Page
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public int PostId { get; set; }
		public Post Post { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez.")]
		[DisplayName("Sayfa Başlığı")]
		[StringLength(50, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
		[MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir!")]
		public string PageTitle { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez.")]
		[DisplayName("Sayfa İçeriği")]
		[StringLength(1000, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
		[MinLength(10, ErrorMessage = "{0} en az {1} karakter olabilir!")]
		public string PageContext { get; set; }

	}
}
