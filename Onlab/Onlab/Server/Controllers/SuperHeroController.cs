using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Onlab.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //Itt szamit a nev
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;

        public SuperHeroController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
        {
            var heroes = await _context.SuperHeroes.Include(sh=>sh.Comic).ToListAsync();
            return Ok(heroes);
        }

        [HttpGet("comics")]
        public async Task<ActionResult<List<Comic>>> GetComics()
        {
            var comics = await _context.Comics.ToListAsync();
            return Ok(comics);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {
            var hero= await _context.SuperHeroes
                .Include(h =>h.Comic) //kell, vagy null lenne a comic
                .FirstOrDefaultAsync(h => h.Id == id);
            if(hero == null)
            {
                return NotFound("Sorry, no hero here. :/");
            }
            return Ok(hero);
        }
    }
}