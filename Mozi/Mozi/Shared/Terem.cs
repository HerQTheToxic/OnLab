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
        public int FilmId { get; set; }
        public string TeremNev { get; set; } = string.Empty;
        //public List<Szek> Szekek { get; set; }
        //public List<int> SzekId { get; set; }= new List<int>();
    }
}
