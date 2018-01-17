using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1Pop_Biblioteka
{
    class Pozycja
    {
        protected string Tytul { get; set; }
        protected int Id { get; set; }
        protected string Wydawnictwo { get; set; }
        protected int RokWydania { get; set; }

        public Pozycja()
        {
        }

        public Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.Tytul = tytul;
            this.Id = id;
            this.Wydawnictwo = wydawnictwo;
            this.RokWydania = rokWydania;
        }

        public virtual string Opis()
        {
            return $"#{Id} \"{Tytul}\" {Environment.NewLine} " +
                $"Wydane przez: {Wydawnictwo} w {RokWydania}";
        }

        public string PobierzTytul()
        {
            return Tytul;
        }

        public int PobierzId()
        {
            return Id;
        }




    }
}
