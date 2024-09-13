using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Capitulo01.Models.Infra
{
	public class AcessarViewModel
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Senha { get; set; }
		//deve ter ao menos uma letra maíscula e ao menos um número

		[Display(Name = "Lembrar de mim?")]
		public bool LembrarDeMim {  get; set; }

	}
}
