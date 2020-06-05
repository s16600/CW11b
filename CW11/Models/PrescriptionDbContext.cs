using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW11.Models
{
    public class PrescriptionDbContext : DbContext
    {
        public DbSet<Prescription> Prescription { get; set; }
        public PrescriptionDbContext() { }
        public PrescriptionDbContext(DbContextOptions<PrescriptionDbContext> options)
        : base(options)
        {

        }
    }
}

