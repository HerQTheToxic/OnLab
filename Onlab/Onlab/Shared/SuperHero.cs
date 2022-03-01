using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlab.Shared
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string HeroName { get; set; } = String.Empty;

        //itt rendelem hozza a comicot
        public Comic? Comic { get; set; }

        //comic nezeshez jo
        public int ComicId { get; set; }
    }
}
