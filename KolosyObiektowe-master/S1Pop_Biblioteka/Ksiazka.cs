using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1Pop_Biblioteka
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        private Autor autor;

        public Ksiazka()
        {
        }

        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, string imie, string nazwisko)
            : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.liczbaStron = liczbaStron;
            this.autor = new Autor(imie, nazwisko);
        }

        public override string Opis()
        {
            return $"#{Id} \"{Tytul}\" {autor.Imie} {autor.Nazwisko} stron {liczbaStron} (wydawca: {Wydawnictwo} w {RokWydania})";
        }
    }
}
