using System.ComponentModel.DataAnnotations;

namespace Evaluacion1erProgreso.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Range(-500, 500)]
        public decimal Saldo { get; set; }
        [Required]
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public IEnumerable<Reserva> Reservas { get; set; }
        public PlanDeRecompensas PlanDeRecompensas;
    }
}
