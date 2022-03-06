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
        //public List<Szinesz> szineszek { get; set; }  //nem fog kelleni
        //public List<int> SzineszId { get; set; }= new List<int>();
        //public Terem? Terem { get; set; } //meg csak 1 terem, nem fog kelleni
        public int TeremId { get; set; }
    }
}
