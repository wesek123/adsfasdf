using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace S2_Hotel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hotel hotel1;
        public MainWindow()
        {
            InitializeComponent();
            hotel1 = new Hotel();
        }
        
        // sprawdza format datu podczas jej wpisywania
        private void txtBoxData_TextChanged(object sender, TextChangedEventArgs e)
        {
            string inputString = txtBoxData.Text;
            string formatDaty = "d.MM.yyyy";
            DateTime data;

            if (!DateTime.TryParseExact(inputString, formatDaty, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
            {
                labelDataError.Content = "Nieprawidlowy format daty";
                btnDodajRezerwacje.IsEnabled = false;
            }
            else
            {
                // jesli poprawny format, to uzywa Hotel.Sprawdz()
                // ale najpierw musi ją ustawic, zeby miec dostep do bezargumentowej metody Sprawdz()
                hotel1.UstawDate(data);
                if (hotel1.SprawdzDate())
                {
                    labelDataError.Content = "Ustawiono date!";
                    btnDodajRezerwacje.IsEnabled = true;
                }
                else
                {
                    labelDataError.Content = "Data musi byc > od aktualnej";
                    btnDodajRezerwacje.IsEnabled = false;
                }
            }
                
        }

        private void btnDodajRezerwacje_Click(object sender, RoutedEventArgs e)
        {
            bool blad = false; // czy jest jakis problem z polami
            int numer;
            double cena = -1;

            // na poczatku sprawdzamy czy pola nie sa puste
            if (String.IsNullOrEmpty(txtBoxImie.Text) || String.IsNullOrEmpty(txtBoxNazwisko.Text)
                || String.IsNullOrEmpty(txtBoxNumerPokoju.Text) || String.IsNullOrEmpty(txtBoxCenaZaDobe.Text))
                blad = true;

            // sprawdza czy podano liczby
            if (!int.TryParse(txtBoxNumerPokoju.Text, out numer) || !Double.TryParse(txtBoxCenaZaDobe.Text, out cena))
                blad = true;

            // sprawdzamy czy numer i cena sa dodatnie
            if (cena < 0 || numer < 0)
                blad = true;

            // jesli nie ma bledow, dodaje rezerwacje
            if(!blad)
            {
                try
                {
                    hotel1.DodajRezerwacje(txtBoxImie.Text, txtBoxNazwisko.Text, numer, cena);
                    txtBlockRezerwacje.Text = hotel1.ToString();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Nie mozna dodac rezerwacji na ten sam pokoj (klucz)");
                }
                
            }
            else
            {
                MessageBox.Show("Upewnij sie, ze: /nzadne pole nie jest puste/nnumer pokoju i cena za dobe to nieujemne wartosci liczbowe");
            }
        }

        private void btnUsunRezerwacje_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                hotel1.OdwolajRezerwacje();
                txtBlockRezerwacje.Text = hotel1.ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Nie mozna usunac rezerwacji z pustej listy.");
            }
        }
    }
}
