using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_Warsztat
{
    public static class Warsztat
    {
        private static List<Samochod> lista = new List<Samochod>();

        public static void DodajDoListy(Marka marka, string rej, string usterka)
        {
            // zabezpiecza przed roznymi markami, przy tej samej rejestracji
            if(!lista.Any(s => s.PobierzRejestracje() == rej && s.PobierzMarke() != marka))
                lista.Add(Samochod.StworzSamochod(marka, rej, usterka));
        }

        public static void WykonajNaprawe(int ile)
        {
            int iloscElementow = lista.Count;
            // nie usuwa, jesli ile > lista.count
            if (ile <= iloscElementow)
                lista.RemoveRange(iloscElementow - ile, ile);
        }

        public static void WykonajNaprawe(string rej)
        {
            lista.RemoveAll(samochod => samochod.PobierzRejestracje() == rej);
        }

        public static void DrugaUsterka(string rej, string nowaUsterka)
        {
            Samochod szukany = lista.Find(s => s.PobierzRejestracje() == rej);
            Samochod szukanyKopia = szukany.SkopiujSamochod();
            szukanyKopia.ZmienUsterke(nowaUsterka);
            lista.Add(szukanyKopia); // zamiast odajDoListy (bo marka jest private)
        }
    }
}
