using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolos2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kolos2.Controllers
{
    [Route("api/pracowniks")]
    [ApiController]
    public class PracownikController : ControllerBase
    {
        private readonly KolosDbContext _context;
        public PracownikController(KolosDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult getIndex()
        {
            List<Pracownik> lista = _context.Pracowniks.ToList();
            return Ok(lista);
        }
    }
}