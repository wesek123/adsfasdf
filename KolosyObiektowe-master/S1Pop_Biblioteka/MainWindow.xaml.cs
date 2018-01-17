using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace S1Pop_Biblioteka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // brak walidacji danych
        Katalog katalog1;
        public MainWindow()
        {
            InitializeComponent();
            katalog1 = new Katalog("Zbior ksiazek");
            katalog1.Test();
            txtBlockZawartosc.Text = katalog1.WypiszWszystko();
        }

        private void btnDodajCzasopismo_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(txtBoxId.Text);
            int rok = Convert.ToInt32(txtBoxRokWydania.Text);
            int numer = Convert.ToInt32(txtBoxNumer.Text);
            katalog1.DodajPozycje(txtBoxTytul.Text, id, txtBoxWydawnictwo.Text, rok, numer);
            txtBlockZawartosc.Text = katalog1.WypiszWszystko();
        }

        private void btnDodajKsiazke_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(txtBoxId.Text);
            int rok = Convert.ToInt32(txtBoxRokWydania.Text);
            int liczbaStron = Convert.ToInt32(txtBoxLiczbaStron.Text);
            katalog1.DodajPozycje(txtBoxTytul.Text, id, txtBoxWydawnictwo.Text, rok, liczbaStron, txtBoxImie.Text, txtBoxNazwisko.Text);
            txtBlockZawartosc.Text = katalog1.WypiszWszystko();
        }

        private void btnSzukajPoId_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(txtBoxSzukaneId.Text);
            txtBlockWynikSzukania.Text = katalog1.WyszukajPoId(id);
        }

        private void btnSzukajPoTytule_Click(object sender, RoutedEventArgs e)
        {
            txtBlockWynikSzukania.Text = katalog1.WyszukajPoTytule(txtBoxSzukanyTytul.Text);
        }


    }
}
