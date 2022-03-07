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
            var filmek= await _context.Filmek.ToListAsync();
            return Ok(filmek);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Film>> GetSingleFilm(int id)
        {
            var film=await _context.Filmek.FirstOrDefaultAsync(h=>h.Id==id);
            if (film == null)
            {
                return NotFound("Bocsi, nincs itt film");
            }
            return Ok(film);
        }

    }
}
