using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RalfyGenao_Ap1_P1.Models
{
    public class CobroDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int CobroId { get; set; }
        [ForeignKey("CobroId")]
        public Cobros cobros { get; set; }
        [Required(ErrorMessage = "Intentar Nuevamente el PrestamoId")]
        public int PrestamoId { get; set; }
        [ForeignKey("PrestamoId")]
        public Prestamos Prestamo { get; set; }
        [Required(ErrorMessage = "Intentar Nuevamente el valorCobrado")]
        public decimal? ValorCobrado { get; set; }

    }
}
