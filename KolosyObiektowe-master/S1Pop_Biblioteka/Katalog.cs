using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1Pop_Biblioteka
{
    class Katalog : IZarzadzanie
    {
        private string dzialTematyczny;
        private List<Pozycja> pozycje;

        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
            pozycje = new List<Pozycja>();
        }

        // dodaje czasopismo
        public void DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, int numer)
        {
            pozycje.Add(new Czasopismo(tytul, id, wydawnictwo, rokWydania, numer));
        }

        // dodaje ksiazke
        public void DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, string imie, string nazwisko)
        {
            pozycje.Add(new Ksiazka(tytul, id, wydawnictwo, rokWydania, liczbaStron, imie, nazwisko));
        }

        public string WypiszWszystko()
        {
            string wszystko = dzialTematyczny.ToUpper() + Environment.NewLine;
            foreach (var pozycja in pozycje)
            {
                wszystko += pozycja.Opis() + Environment.NewLine;
            }
            return wszystko;
        }

        public void Test()
        {
            DodajPozycje("Gazeta Olsztyńska", 200, "Edytor", 1992, 7);
            DodajPozycje("Gazeta Wyborcza", 123, "Agora", 2010, 23);
            DodajPozycje("Krzyżacy", 220, "Znak", 2010, 300, "Henryk", "Sienkiewicz");
            DodajPozycje("Krzyżacy", 221, "Znak", 2011, 298, "Henryk", "Sienkiewicz");
        }

        public string WyszukajPoTytule(string tytul)
        {
            string wynik = "Nie ma takiej pozycji";
            foreach (var pozycja in pozycje)
            {
                if (pozycja.PobierzTytul() == tytul)
                    wynik = pozycja.Opis();
            }
            return wynik;
        }

        public string WyszukajPoId(int id)
        {
            string wynik = "Nie ma takiej pozycji";
            foreach (var pozycja in pozycje)
            {
                if (pozycja.PobierzId() == id)
                    wynik = pozycja.Opis();
            }
            return wynik;
        }
    }
}
