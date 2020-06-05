using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW11.Models
{
    public class PatientDbContext : DbContext
    {
        public DbSet<Patient> Patient { get; set; }

        public PatientDbContext() { }

        public PatientDbContext(DbContextOptions<PatientDbContext> options)
        :base(options) {

        }
    }
}
