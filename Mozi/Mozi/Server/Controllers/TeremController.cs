using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mozi.Shared;

namespace Mozi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeremController : ControllerBase
    {
        public static List<Terem> Termek = new List<Terem>
        {
            new Terem{ Id = 1, TeremNev="elso", /*Szekek=new List<Szek> {
                new Szek{ Id = 1, Szam=1, TeremId=1, Foglalt= false },
                new Szek{ Id = 2, Szam=2, TeremId=1, Foglalt= false },
                new Szek{ Id = 3, Szam=3, TeremId=1, Foglalt= false },
                new Szek{ Id = 4, Szam=4, TeremId=1, Foglalt= true },
                new Szek{ Id = 5, Szam=5, TeremId=1, Foglalt= true },
                new Szek{ Id = 6, Szam=6, TeremId=1, Foglalt= true },
                new Szek{ Id = 7, Szam=7, TeremId=1, Foglalt= false } },*/
            },

            new Terem{ Id = 2, TeremNev="masodik", /*Szekek=new List<Szek> {
                new Szek{ Id = 11, Szam=1, TeremId=2, Foglalt= false },
                new Szek{ Id = 12, Szam=2, TeremId=2, Foglalt= true },
                new Szek{ Id = 13, Szam=3, TeremId=2, Foglalt= false },
                new Szek{ Id = 14, Szam=4, TeremId=2, Foglalt= true },
                new Szek{ Id = 15, Szam=5, TeremId=2, Foglalt= false },
                new Szek{ Id = 16, Szam=6, TeremId=2, Foglalt= true },
                new Szek{ Id = 17, Szam=7, TeremId=2, Foglalt= false } },*/
            }
        };
        [HttpGet]
        public async Task<ActionResult<List<Terem>>> GetTermek()
        {
            return Ok(Termek);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Terem>> GetSingleTerem(int id)
        {
            var terem = Termek.FirstOrDefault(h => h.Id == id);
            if (terem == null)
            {
                return NotFound("Bocsi, nincs itt terem");
            }
            return Ok(terem);
        }


    }
}
