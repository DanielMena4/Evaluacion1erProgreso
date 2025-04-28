using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [DataType(DataType.Date)]
        [Required]
        [Display(Name ="Fecha de creación")]
        public DateOnly FechaCreacion { get; set; }
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
        
        [Display(Name = "Plan de recompensas")]
        public int PlanDeRecompensasId { get; set; }

        [ForeignKey("PlanDeRecompensasId")]
        public PlanDeRecompensas PlanDeRecompensas { get; set; }

    }
}
