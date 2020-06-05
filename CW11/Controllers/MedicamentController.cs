using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CW11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CW11.Controllers
{
    [Route("api/medicament")]
    [ApiController]
    public class MedicamentController : ControllerBase
    {
        private readonly MedicamentDbContext _context;

        public MedicamentController(MedicamentDbContext context)
        {
            _context = context;
        }

        public IActionResult GetMedicament()
        {
            return Ok(_context.Medicament.ToList());
        }
    }
}