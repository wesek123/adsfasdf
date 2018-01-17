using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1Pop_Biblioteka
{
    interface IZarzadzanie
    {
        string WypiszWszystko();
        string WyszukajPoTytule(string tytul);
        string WyszukajPoId(int id);
    }
}
