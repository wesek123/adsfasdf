using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_Przychodnia
{
    class Lekarz : Osoba
    {
        private string specjalnosc;

        public Lekarz(string imie, string nazwisko, string specjalnosc) 
            : base(imie, nazwisko)
        {
            this.specjalnosc = specjalnosc;
        }

        public override string ToString()
        {
            string wynik = String.Format(
                $"Lekarz: {imie} {nazwisko}, specjalnosc: {specjalnosc}");
            return wynik;
        }
    }
}
