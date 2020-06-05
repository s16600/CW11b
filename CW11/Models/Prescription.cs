using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW11.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        [ForeignKey("IdPatient")]
        public int IdPatient { get; set; }
        [ForeignKey("IdDoctor")]
        public int IdDoctor { get; set; }
    }
}
