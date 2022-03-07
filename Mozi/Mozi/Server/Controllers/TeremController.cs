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
        //Letrehoz
        [HttpPost]
        public async Task<ActionResult<List<Terem>>> CreateTerem(Terem terem)
        {
            _context.Termek.Add(terem);
            await _context.SaveChangesAsync();

            return Ok(await GetDbTermek());
        }
        //Frissit
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Terem>>> UpdateTerem(Terem terem, int id)
        {
            var dbTerem = await _context.Termek.FirstOrDefaultAsync(h => h.Id == id);
            if (dbTerem == null)
                return NotFound("Bocsi, nincs ilyen terem");
            dbTerem.TeremNev = terem.TeremNev;
            dbTerem.FilmId = terem.FilmId;

            await _context.SaveChangesAsync();

            return Ok(await GetDbTermek());
        }

        //Torol
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Terem>>> DeleteTerem(int id)
        {
            var dbTerem = await _context.Termek.FirstOrDefaultAsync(h => h.Id == id);
            if (dbTerem == null)
                return NotFound("Bocsi, nincs ilyen terem");

            _context.Termek.Remove(dbTerem);
            await _context.SaveChangesAsync();

            return Ok(await GetDbTermek());
        }

        private async Task<List<Terem>> GetDbTermek()
        {
            return await _context.Termek.ToListAsync();
        }

    }
}
