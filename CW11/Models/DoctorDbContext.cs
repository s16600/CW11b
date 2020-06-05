using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW11.Models
{
    public class DoctorDbContext : DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }
        public DoctorDbContext() { }
        public DoctorDbContext(DbContextOptions<DoctorDbContext> options)
        :base(options) {

        }
    }
}
