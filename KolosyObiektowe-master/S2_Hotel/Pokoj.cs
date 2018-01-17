using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_Hotel
{
    class Pokoj : IComparable<Pokoj>
    {
        private int nrPokoju;
        private double cenaZaDzien;

        public Pokoj(int nrPokoju, double cenaZaDzien)
        {
            this.nrPokoju = nrPokoju;
            this.cenaZaDzien = cenaZaDzien;
        }

        public override string ToString()
        {
            return String.Format($"Pokoj, nr: {nrPokoju}, cena za dzien: {cenaZaDzien}");
        }

        public int PobierzNrPokoju()
        {
            return nrPokoju;
        }

        public double PobierzCene()
        {
            return cenaZaDzien;
        }

        // stortuj od najmniejszej do najwiekszej
        public int CompareTo(Pokoj other)
        {
            return this.nrPokoju.CompareTo(other.nrPokoju);
        }
    }
}
