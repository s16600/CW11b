using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CW11.Models
{
    public class Prescription_Medicament
    {
        [Key, ForeignKey("IdMedicament")]
        [Column(Order = 1)]
        public int IdMedicament { get; set; }
        [Key, ForeignKey("IdPrescription")]
        [Column(Order = 2)]
        public int IdPrescription { get; set; }
        public int Dose { get; set; }
        [MaxLength(100)]
        public string Details { get; set; }
    }
}
