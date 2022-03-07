using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mozi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SzekController : ControllerBase
    {

        private readonly DataContext _context;

        public SzekController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Szek>>> GetSzekek()
        {
            var szekek = await _context.Szekek.ToListAsync();
            return Ok(szekek);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Szek>> GetSingleSzek(int id)
        {
            var szekek = await _context.Szekek.FirstOrDefaultAsync(h => h.Id == id);
            if (szekek == null)
            {
                return NotFound("Bocsi, nincs itt szek");
            }
            return Ok(szekek);
        }

    }
}
