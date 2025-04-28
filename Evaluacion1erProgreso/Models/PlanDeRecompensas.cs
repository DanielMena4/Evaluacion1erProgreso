using Microsoft.EntityFrameworkCore;
namespace Evaluacion1erProgreso.Models
{
    public class PlanDeRecompensas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int puntos { get; set; } 
        public string TipoDeRecompensa { get; set; } 
    }
}
