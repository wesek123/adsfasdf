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

namespace S3_Przychodnia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Przychodnia przych = new Przychodnia();
        public MainWindow()
        {
            InitializeComponent();
            //przych.UstawLekarza("Janusz", "Wonsacz", "twoja_stara");
            //przych.DodajDoKolejki("michał", "kowalski", 93, "grypa");
            //przych.DodajDoKolejki("ewa", "wielka", 26, "musk");

            //przych.GenerujRaport();

        }

        private void btnUstawLekarza_Click(object sender, RoutedEventArgs e)
        {
            // sprawdzamy czy pola nie sa puste
            string imie = txtBoxImieLekarz.Text.Trim();
            string nazwisko = txtBoxNazwiskoLekarz.Text.Trim();
            string specjalnosc = txtBoxSpecjalnosc.Text.Trim();
            if (String.IsNullOrEmpty(imie) || String.IsNullOrEmpty(nazwisko) || String.IsNullOrEmpty(specjalnosc))
                MessageBox.Show("Pola imie, nazwisko i specjalnosc nie moga byc puste");
            else
            {
                przych.UstawLekarza(imie, nazwisko, specjalnosc);
                txtBlockWynik.Text = przych.ToString();
            }
            
        }

        private void txtBoxImie_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnPokazDodajDoKolejki_Click(object sender, RoutedEventArgs e)
        {
            bool blad = false;
            string imie = txtBoxImiePacjent.Text;
            string nazwisko = txtBoxNazwiskoPacjent.Text;
            string wiekString = txtBoxWiek.Text;
            string choroba = txtBoxChoroba.Text;
            int wiekInt = 130;

            // jesli nie ustawiono lekarza
            if (!przych.CzyLekarz())
            {
                blad = true;
                MessageBox.Show("Najpierw ustaw lekarza.");
            }

            // nie ma bledu, a sa puste pola
            if (!blad && (String.IsNullOrEmpty(imie) || String.IsNullOrEmpty(nazwisko) || String.IsNullOrEmpty(wiekString)
                || String.IsNullOrEmpty(choroba)))
            {
                blad = true;
                MessageBox.Show("Zadne pole nie moze byc puste.");
            }

            // czy wiek to int
            if(!blad && (!int.TryParse(wiekString, out wiekInt) || wiekInt > 120))
            {
                blad = true;
                MessageBox.Show("Wiek musi byc liczba, do tego mniejsza niz 120.");
            }

            // jesli nie ma zadnego bledu
            if(!blad)
            {
                przych.DodajDoKolejki(imie, nazwisko, wiekInt, choroba);
                txtBlockWynik.Text = przych.ToString();
            }

        }

        private void btnWykonajPorade_Click(object sender, RoutedEventArgs e)
        {
            // wylapuje jesli nie ma zadnego pacjenta
            try
            {
                MessageBox.Show(przych.WykonajPorade());
                txtBlockWynik.Text = przych.ToString();
            }
            catch
            {
                MessageBox.Show("Nie ma pacjentow.");
            }
        }

        private void btnWykonajBadanie_Click(object sender, RoutedEventArgs e)
        {
            // wylapuje jesli nie ma zadnego pacjenta
            try
            {
                MessageBox.Show(przych.WykonajBadanie());
            }
            catch
            {
                MessageBox.Show("Nie ma pacjentow.");
            }
        }

        private void btnGenerujRaport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                przych.GenerujRaport();
                MessageBox.Show("Wygenerowano raport");
            }
            catch
            {
                MessageBox.Show("Nie ma pacjentow.");
            }
            
        }
    }
}
