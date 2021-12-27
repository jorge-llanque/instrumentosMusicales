using instrumentosMusicales.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace instrumentosMusicales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentosMusicalesController : ControllerBase
    {
        private readonly InstrumentosMusicalesContext _context;

        public InstrumentosMusicalesController(InstrumentosMusicalesContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllInstrumentos()
        {
            IQueryable<Instrumento> instrumentos = _context.Instrumentos;
            return Ok(await instrumentos.ToArrayAsync());
        }
    }
}
