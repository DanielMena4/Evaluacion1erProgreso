using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Evaluacion1erProgreso.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime FechaDeInicio { get; set; }
        public DateTime FechaDeFin { get; set; }
        public int Monto { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente cliente { get; set; }

    }
}
