using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mozi.Shared;

namespace Mozi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeremController : ControllerBase
    {
        private readonly DataContext _context;

        public TeremController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Terem>>> GetTermek()
        {
            var termek= await _context.Termek.ToListAsync();
            return Ok(termek);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Terem>> GetSingleTerem(int id)
        {
            var terem = await _context.Termek.FirstOrDefaultAsync(h => h.Id == id);
            if (terem == null)
            {
                return NotFound("Bocsi, nincs itt terem");
            }
            return Ok(terem);
        }


    }
}
