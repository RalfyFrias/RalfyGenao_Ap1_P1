using System.ComponentModel.DataAnnotations;

namespace RalfyGenao_Ap1_P1.Models
{
	public class Prestamo
	{
		[Key]

		public int PrestamoId { get; set; }
		[Required(ErrorMessage = "Campo obligatorio")]
		public string? Deudor { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string? Concepto { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public decimal? Monto { get; set; }

	}
}
