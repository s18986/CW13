using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolos2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kolos2.Controllers
{
    [Route("api/zamowienie")]
    [ApiController]
    public class ZamowienieController : ControllerBase
    {
        private readonly KolosDbContext _context;
        public ZamowienieController(KolosDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult getIndex()
        {
            IEnumerable<Zamowienie> lista = _context.Zamowienies.ToList();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public IActionResult getData(int id)
         {
             IEnumerable<Zamowienie> lista =_context.Zamowienies.ToList().Where(x => x.IdKlient.Equals(id))  ;
             
                return Ok(lista);
         
         }
         
    }
}