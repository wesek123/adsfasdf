using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Przychodnia
{
    class Przychodnia: IPrzychodnia
    {
        private Lekarz lekarz;
        Queue<Pacjent> pacjenci = new Queue<Pacjent>();

        public int CzasOczekiwania()
        {
            return Convert.ToInt32(pacjenci.Count()/4);
        }

        public bool CzyLekarz()
        {
            if (lekarz != null)
                return true;
            else
                return false;
        }

       // public void DodajDoKolejki(string imie, string nazwisko, int wiek ,string choroba)
       // {
       //     pacjenci.Enqueue(new Pacjent(imie, nazwisko, wiek, choroba));
       // }

        public void GenerujRaport()
        {

        }

        public override string ToString()
        {
            return lekarz.ToString() + Environment.NewLine + "Pacjenci w kolejce " + Environment.NewLine;
        }

        public void UstawLekarza(string imie, string nazwisko, string specjalnosc)
        {
            this.lekarz = new Lekarz(imie.Trim(), nazwisko.Trim(), specjalnosc.Trim());
        }

        public string WykonajBadanie()
        {
            return "Wykonano porade!" + pacjenci.Dequeue().ToString();
        }

        public string WykonajPorade()
        {
            return "Wykonano badanie!" + pacjenci.Peek().ToString();
        }
    }
}
