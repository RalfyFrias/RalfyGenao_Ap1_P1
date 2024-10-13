using System.ComponentModel.DataAnnotations;

namespace RalfyGenao_Ap1_P1.Models
{
    public class Deudor
    {
        [Key]
        public int DeudorId { get; set; }
        [Required(ErrorMessage = "Intentar Nuevamente el Nombre")]
        public string? Nombres { get; set; }
    }
}
