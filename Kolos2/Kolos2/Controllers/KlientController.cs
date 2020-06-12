using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolos2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kolos2.Controllers
{
    [Route("api/klients")]
    [ApiController]
    public class KlientController : ControllerBase
    {
        private readonly KolosDbContext _context;
        public KlientController(KolosDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult getIndex()
        {
            List<Klient> lista = _context.Klients.ToList();
            return Ok(lista);
        }
    }
}