using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozi.Shared
{
    public class Terem
    {
        public int Id { get; set; }
        public string TeremNev { get; set; } = string.Empty;
        public int FilmId { get; set; }
        public ICollection<Szek> Szekek { get; } = new List<Szek>();

    }
}
