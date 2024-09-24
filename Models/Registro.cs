using System.ComponentModel.DataAnnotations;

namespace RalfyGenao_Ap1_P1.Models
{
	public class Registro
	{
		[Key]

		public int Id { get; set; }
		public string? Nombre { get; set; }
	}
}
