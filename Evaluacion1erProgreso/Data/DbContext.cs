using Evaluacion1erProgreso.Models;
using Microsoft.EntityFrameworkCore;

namespace Evaluacion1erProgreso.Data
{
    public class DbContext
    {
        public DbContext() { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<PlanDeRecompensas> PlanesDeRecompensas { get; set; }
    }
}
