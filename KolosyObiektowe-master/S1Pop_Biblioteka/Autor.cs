using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1Pop_Biblioteka
{
    class Autor
    {
        protected internal string Imie { get; set; } // current assembly or deriving classes
        protected internal string Nazwisko { get; set; }

        public Autor()
        {
        }

        public Autor(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        
        
    }
}
