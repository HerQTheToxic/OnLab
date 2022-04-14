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

        //Letrehoz
        [HttpPost]
        public async Task<ActionResult<List<Szek>>> CreateSzek(Szek Szek)
        {
            _context.Szekek.Add(Szek);
            await _context.SaveChangesAsync();

            return Ok(await GetDbSzek());
        }
        //Frissit
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Szek>>> UpdateSzek(Szek Szek, int id)
        {
            var dbSzek = await _context.Szekek.FirstOrDefaultAsync(h => h.Id == id);
            if (dbSzek == null)
                return NotFound("Bocsi, nincs ilyen Szek");
            dbSzek.Szam = Szek.Szam;
            dbSzek.Foglalt = Szek.Foglalt;
            dbSzek.TeremId = Szek.TeremId;

            await _context.SaveChangesAsync();

            return Ok(await GetDbSzek());
        }

        //Torol
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Szek>>> DeleteSzek(int id)
        {
            var dbSzek = await _context.Szekek.FirstOrDefaultAsync(h => h.Id == id);
            if (dbSzek == null)
                return NotFound("Bocsi, nincs ilyen Szek");

            _context.Szekek.Remove(dbSzek);
            await _context.SaveChangesAsync();

            return Ok(await GetDbSzek());
        }


        private async Task<List<Szek>> GetDbSzek()
        {
            return await _context.Szekek.ToListAsync();
        }

    }
}
