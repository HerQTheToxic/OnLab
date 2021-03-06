using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Mozi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly DataContext _context;

        public FilmController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Film>>> GetFilmek()
        {
            var filmek= await _context.Filmek.Include(h => h.Termek).ThenInclude(ho => ho.Szekek).Include(h => h.Szineszek).ToListAsync();
            return Ok(filmek);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Film>> GetSingleFilm(int id)
        {
            var film=await _context.Filmek.Include(h=>h.Termek).ThenInclude(ho => ho.Szekek).Include(h=>h.Szineszek).FirstOrDefaultAsync(h=>h.Id==id);
            if (film == null)
            {
                return NotFound("Bocsi, nincs itt film");
            }
            return Ok(film);
        }

        [HttpGet("{id}/termek")]
        public async Task<ActionResult<Terem>> GetFilmTermek(int id)
        {
            var film = await _context.Filmek.Include(h => h.Termek).ThenInclude(ho => ho.Szekek).Include(h => h.Szineszek).FirstOrDefaultAsync(h => h.Id == id);
            if (film == null)
            {
                return NotFound("Bocsi, nincs itt film");
            }

            var termek =film.Termek;
            return Ok(termek);
        }

        [HttpGet("{id}/szineszek")]
        public async Task<ActionResult<Szinesz>> GetFilmSzineszek(int id)
        {
            var film = await _context.Filmek.Include(h => h.Termek).Include(h => h.Szineszek).FirstOrDefaultAsync(h => h.Id == id);
            if (film == null)
            {
                return NotFound("Bocsi, nincs itt film");
            }
            var termek = film.Szineszek;
            return Ok(termek);
        }



        //Letrehoz
        [HttpPost]
        public async Task<ActionResult<List<Film>>> CreateFilm(Film film)
        {
            _context.Filmek.Add(film);
            await _context.SaveChangesAsync();

            return Ok(await GetDbFilm());
        }

        //Frissit
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Film>>> UpdateFilm(Film film, int id)
        {
            var dbFilm = await _context.Filmek.FirstOrDefaultAsync(h => h.Id == id);
            if (dbFilm == null)
                return NotFound("Bocsi, nincs ilyen film");
            dbFilm.Nev = film.Nev;
            dbFilm.Ertekeles = film.Ertekeles;
            dbFilm.Gyarto = film.Gyarto;


            await _context.SaveChangesAsync();

            return Ok(await GetDbFilm());
        }

        //Torol
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Film>>> DeleteFilm(int id)
        {
            var dbFilm = await _context.Filmek.FirstOrDefaultAsync(h => h.Id == id);
            if (dbFilm == null)
                return NotFound("Bocsi, nincs ilyen film");

            _context.Filmek.Remove(dbFilm);
            await _context.SaveChangesAsync();

            return Ok(await GetDbFilm());
        }

        private async Task<List<Film>> GetDbFilm()
        {
            return await _context.Filmek.ToListAsync();
        }
    }
}