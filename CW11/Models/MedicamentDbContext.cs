using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW11.Models
{
    public class MedicamentDbContext : DbContext 
    {
        public DbSet<Medicament> Medicament { get; set; }

        public MedicamentDbContext() { }

        public MedicamentDbContext(DbContextOptions<MedicamentDbContext> options)
        :base(options) {

        }
    }
}
