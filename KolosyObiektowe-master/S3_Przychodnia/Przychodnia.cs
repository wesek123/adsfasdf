using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_Przychodnia
{
    class Przychodnia : IPrzychodnia
    {
        private Lekarz lekarz;
        private Queue<Pacjent> pacjenci;

        public Przychodnia()
        {
            lekarz = null;
            pacjenci = new Queue<Pacjent>();
        }

        public int CzasOczekiwania()
        {
            return pacjenci.Count() / 4;
        }

        public void DodajDoKolejki(string imie, string nazwisko, int wiek, string choroba)
        {
            pacjenci.Enqueue(new Pacjent(imie, nazwisko, wiek, choroba));
        }

        public void GenerujRaport()
        {
            string fileName = $"Raport{DateTime.Now:HHmmddMMyyyy}.txt";
            using (var writer = new StreamWriter(fileName))
            {
                writer.Write(this.ToString());
            }
        }

        public override string ToString()
        {
            string wynik = lekarz.ToString() + Environment.NewLine;
            foreach (var pacjent in pacjenci)
            {
                wynik += pacjent.ToString() + Environment.NewLine;
            }
            wynik += $"Czas oczekiwania: {CzasOczekiwania()}";
            return wynik;
        }

        public void UstawLekarza(string imie, string nazwisko, string specjalnosc)
        {
            lekarz = new Lekarz(imie, nazwisko, specjalnosc);
        }

        public string WykonajBadanie()
        {
            return $"Wykonano badanie! {pacjenci.First().ToString()}";
        }

        public string WykonajPorade()
        {
            string wynik = $"Wykonano porade! {pacjenci.First().ToString()}";
            pacjenci.Dequeue();
            return wynik;
        }

        public bool CzyLekarz()
        {
            return (lekarz != null);
        }

    }
}
