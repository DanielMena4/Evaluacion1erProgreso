using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace Evaluacion1erProgreso.Models
{
    public class PlanDeRecompensas
    {
        [Key]
        public int PlanDeRecompensasId { get; set; }
        public string Nombre { get; set; }
        public DateOnly FechaCreacion { get; set; }
        public int puntos { get; set; } 
        public string TipoDeRecompensa { get; set; } 
    }
}
