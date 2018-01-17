using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_Hotel
{
    class Hotel : IHotel, IData
    {
        private double zysk;
        private DateTime data;
        private SortedDictionary<Pokoj, Gosc> rezerwacje;

        public Hotel()
        {
            zysk = -80;
            rezerwacje = new SortedDictionary<Pokoj, Gosc>();
        }

        public void DodajRezerwacje(string imie, string nazwisko, int nrPokoju, double cenaZaDzien)
        {
            rezerwacje.Add(new Pokoj(nrPokoju, cenaZaDzien), new Gosc(imie, nazwisko));
            zysk += cenaZaDzien;
        }

        public void OdwolajRezerwacje()
        {
            rezerwacje.Remove(rezerwacje.Last().Key);
        }

        public bool SprawdzDate()
        {
            return (data > DateTime.Now);
        }

        public void UstawDate(DateTime data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            string wynik = $"Rezerwacje: {Environment.NewLine}";
            foreach (var rezerwacje in rezerwacje)
            {
                wynik += String.Format($"{rezerwacje.Key.ToString()}; {rezerwacje.Value.ToString()} {Environment.NewLine}");
            }
            wynik += String.Format($"Zysk: {zysk}");
            return wynik;
        }
    }
}
