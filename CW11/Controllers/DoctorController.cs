﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CW11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CW11.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DoctorDbContext _context;

        public DoctorController(DoctorDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoctor()
        {
            return Ok(_context.Doctor.ToList());
        }
    }
}