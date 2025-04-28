using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Evaluacion1erProgreso.Models;

namespace Evaluacion1erProgreso.Data
{
    public class Evaluacion1erProgresoContext : DbContext
    {
        public Evaluacion1erProgresoContext (DbContextOptions<Evaluacion1erProgresoContext> options)
            : base(options)
        {
        }

        public DbSet<Evaluacion1erProgreso.Models.Cliente> Cliente { get; set; } = default!;
    }
}
