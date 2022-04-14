using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozi.Shared
{
    public class Film
    {
        public int Id { get; set; }
        public string Nev { get; set; } = string.Empty;
        public double Ertekeles { get; set; } = 5.0;
        public string Gyarto { get; set; } = "Nincs adat";

        public ICollection<Terem> Termek { get; } = new List<Terem>();
        public ICollection<Szinesz> Szineszek { get; } = new List<Szinesz>();
    }
}
