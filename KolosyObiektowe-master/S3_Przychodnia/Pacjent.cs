using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_Przychodnia
{
    public class Pacjent : Osoba
    {
        private string choroba;
        private int wiek;

        public Pacjent(string imie, string nazwisko, int wiek, string choroba) 
            : base(imie, nazwisko)
        {
            this.wiek = wiek;
            this.choroba = choroba;
        }

        public override string ToString()
        {
            string wynik = String.Format(
                $"Pacjent: {imie} {nazwisko}, wiek {wiek}, choroba: {choroba}");
            return wynik;
        }
    }
}
