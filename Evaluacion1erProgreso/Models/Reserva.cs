using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Evaluacion1erProgreso.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        public DateOnly FechaDeCreacion { get; set; }
        public DateOnly FechaDeInicio { get; set; }
        public DateOnly FechaDeFin { get; set; }
        public int Monto { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente cliente { get; set; }

    }
}
