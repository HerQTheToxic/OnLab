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

        //Letrehoz
        [HttpPost]
        public async Task<ActionResult<List<Szinesz>>> CreateSzinesz(Szinesz szinesz)
        {
            _context.Szineszek.Add(szinesz);
            await _context.SaveChangesAsync();

            return Ok(await GetDbSzinesz());
        }

        //Frissit
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Szinesz>>> UpdateSzinesz(Szinesz szinesz, int id)
        {
            var dbSzinesz = await _context.Szineszek.FirstOrDefaultAsync(h => h.Id == id);
            if (dbSzinesz == null)
                return NotFound("Bocsi, nincs ilyen szinesz");
            dbSzinesz.Ertekeles = szinesz.Ertekeles;
            dbSzinesz.Nev = szinesz.Nev;
            dbSzinesz.Kor = szinesz.Kor;
            dbSzinesz.FilmId = szinesz.FilmId;


            await _context.SaveChangesAsync();

            return Ok(await GetDbSzinesz());
        }

        //Torol
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Szinesz>>> DeleteSzinesz(int id)
        {
            var dbSzinesz = await _context.Szineszek.FirstOrDefaultAsync(h => h.Id == id);
            if (dbSzinesz == null)
                return NotFound("Bocsi, nincs ilyen szinesz");

            _context.Szineszek.Remove(dbSzinesz);
            await _context.SaveChangesAsync();

            return Ok(await GetDbSzinesz());
        }

        private async Task<List<Szinesz>> GetDbSzinesz()
        {
            return await _context.Szineszek.ToListAsync();
        }

    }
}
