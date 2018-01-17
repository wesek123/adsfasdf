using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    class Lekarz:Osoba
    {
        private string specjalnosc;

        public Lekarz()
        {

        }

        public Lekarz(string imie, string nazwisko, string specjalnosc)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.specjalnosc = specjalnosc;
        }
        override public string ToString()
        {
            return "Lekarz. Imie i nazwisko: "+imie + nazwisko + " Specjalnosc: " + specjalnosc;
        }
    }
}
