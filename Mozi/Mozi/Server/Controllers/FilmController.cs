using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Mozi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        public static List<Szinesz> Szineszek = new List<Szinesz> { 
            new Szinesz{ Id = 1, Nev= "Szinesz1", Ertekeles= 9.0, Kor=24},
            new Szinesz{ Id = 2, Nev= "Szinesz2", Ertekeles= 4.0, Kor=54},
            new Szinesz{ Id = 3, Nev= "Szinesz3", Ertekeles= 1.0, Kor=28}
        };

        public static List<Terem> Termek = new List<Terem>
        {
            new Terem{ Id = 1, TeremNev="elso", /*Szekek=new List<Szek> {
                new Szek{ Id = 1, Szam=1, TeremId=1, Foglalt= false },
                new Szek{ Id = 2, Szam=2, TeremId=1, Foglalt= false },
                new Szek{ Id = 3, Szam=3, TeremId=1, Foglalt= false },
                new Szek{ Id = 4, Szam=4, TeremId=1, Foglalt= true },
                new Szek{ Id = 5, Szam=5, TeremId=1, Foglalt= true },
                new Szek{ Id = 6, Szam=6, TeremId=1, Foglalt= true },
                new Szek{ Id = 7, Szam=7, TeremId=1, Foglalt= false } }*/ 
            },

            new Terem{ Id = 2, TeremNev="masodik", /*Szekek=new List<Szek> {
                new Szek{ Id = 11, Szam=1, TeremId=2, Foglalt= false },
                new Szek{ Id = 12, Szam=2, TeremId=2, Foglalt= true },
                new Szek{ Id = 13, Szam=3, TeremId=2, Foglalt= false },
                new Szek{ Id = 14, Szam=4, TeremId=2, Foglalt= true },
                new Szek{ Id = 15, Szam=5, TeremId=2, Foglalt= false },
                new Szek{ Id = 16, Szam=6, TeremId=2, Foglalt= true },
                new Szek{ Id = 17, Szam=7, TeremId=2, Foglalt= false } }*/
            }
        };

        public static List<Film> Filmek = new List<Film> { 
            new Film{ Id=1, Ertekeles=6.0, Gyarto="ASD",  TeremId=1, Nev="elso nevu", },
            new Film{ Id=2, Ertekeles=8.0, Gyarto="ASDASD",  TeremId=2, Nev="masodik nevu", }     
        };

        [HttpGet]
        public async Task<ActionResult<List<Film>>> GetFilmek()
        {
            return Ok(Filmek);
        }

        [HttpGet("szineszek")]
        public async Task<ActionResult<List<Szinesz>>> GetSzineszek()
        {
            return Ok(Szineszek);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Film>> GetSingleFilm(int id)
        {
            var film=Filmek.FirstOrDefault(h=>h.Id==id);
            if (film == null)
            {
                return NotFound("Bocsi, nincs itt film");
            }
            return Ok(film);
        }

    }
}
