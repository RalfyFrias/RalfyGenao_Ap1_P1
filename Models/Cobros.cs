using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RalfyGenao_Ap1_P1.Models
{
    public class Cobros
    {
        [Key]
        public int CobroId { get; set; }
        [Required(ErrorMessage = "Intentar Nuevamente la Fecha")]
        public DateTime? Fecha { get; set; }

        public int DeudorId { get; set; }
        [ForeignKey("DeudorId")]
        public Deudor? Deudor { get; set; }
        [Required(ErrorMessage = "Intentar Nuevamente el Deudor")]
        public decimal Monto { get; set; }
        public ICollection<CobroDetalle> CobroDetalles { get; set; } = new List<CobroDetalle>();

    }
}
