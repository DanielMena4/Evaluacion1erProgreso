using System.ComponentModel.DataAnnotations;

namespace Evaluacion1erProgreso.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public decimal Saldo { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<Reserva> reservas { get; set; }
        public PlanDeRecompensas PlanDeRecompensas;
    }
}
