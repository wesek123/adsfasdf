using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_Warsztat
{
    class Samochod
    {
        private Marka marka;
        private string rejestracja;
        private string usterka;

        private Samochod(Marka marka, string rejestracja, string usterka)
        {
            this.marka = marka;
            this.rejestracja = rejestracja;
            this.usterka = usterka;
        }

        public static Samochod StworzSamochod(Marka marka, string rejestracja, string usterka)
        {
            return new Samochod(marka, rejestracja, usterka);
        }

        public string PobierzRejestracje()
        {
            return rejestracja;
        }

        public Marka PobierzMarke()
        {
            return marka;
        }

        public Samochod SkopiujSamochod()
        {
            return StworzSamochod(marka, rejestracja, usterka);
        }

        public void ZmienUsterke(string usterka)
        {
            this.usterka = usterka;
        }
    }
}
