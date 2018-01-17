using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    class Pacjent : Osoba
    {
        private string choroba;
        private int wiek;

        public Pacjent()
        {

        }

        public Pacjent(string imie, string nazwisko, int wiek, string choroba)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.choroba = choroba;
        }

        override public string ToString()
        {
            return "Pacjent. Imie i nazwisko " +imie + nazwisko +" wiek: "+ wiek +" choroba: " +choroba;
        }
    }
}
