using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW11.Models
{
    public class Prescription_MedicamentDbContext : DbContext
    {
        public DbSet<Prescription_Medicament> Prescription_Medicament { get; set; }
        public Prescription_MedicamentDbContext() { }
        public Prescription_MedicamentDbContext(DbContextOptions<Prescription_MedicamentDbContext> options)
        :base(options){

        }
    }
}
