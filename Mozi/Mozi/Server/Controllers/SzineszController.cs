using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mozi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SzineszController : ControllerBase
    {
        private readonly DataContext _context;

        public SzineszController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Szinesz>>> GetSzineszek()
        {
            var szineszek = await _context.Szineszek.ToListAsync();
            return Ok(szineszek);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Szinesz>> GetSingleSzinesz(int id)
        {
            var szinesz = await _context.Szineszek.FirstOrDefaultAsync(h => h.Id == id);
            if (szinesz == null)
            {
                return NotFound("Bocsi, nincs itt szinesz");
            }
            return Ok(szinesz);
        }

    }
}
