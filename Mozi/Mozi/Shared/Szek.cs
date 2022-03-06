using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozi.Shared
{
    public class Szek
    {
        public int Id { get; set; }
        public int Szam { get; set; }
        public bool Foglalt { get; set; }
        public int TeremId { get; set; }
    }
}
