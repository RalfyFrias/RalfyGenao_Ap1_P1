using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RalfyGenao_Ap1_P1.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        [Required(ErrorMessage = "Intentar Nuevamente el Deudor")]
        public int DeudorId { get; set; }
        [ForeignKey("DeudorId")]
        public Deudor? Deudor { get; set; }
        [Required(ErrorMessage = "Intentar Nuevamente el Concepto")]
        public string? Concepto { get; set; }
        [Required(ErrorMessage = "Intentar Nuevamente el Monto")]
        public decimal? Monto { get; set; }
        [Required(ErrorMessage = "Intentar Nuevamente el Balance")]
        public decimal? Balance { get; set; }

        [ForeignKey("PrestamoId")]
        public ICollection<Deudor> Deudores { get; set; } = new List<Deudor>();

    }
}
