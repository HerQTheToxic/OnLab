using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozi.Shared
{
    public class Szinesz
    {
        public int FilmId { get; set; }
        public int Id { get; set; }
        public string Nev { get; set; } = String.Empty;
        public int Kor { get; set; } = 20;
        public double Ertekeles { get; set; } = 5.0;


    }
}
