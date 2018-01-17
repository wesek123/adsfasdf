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

namespace S4_Warsztat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public enum Marka { Opel, Skoda, Ford, Fiat }
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            Samochod s1 = Samochod.StworzSamochod(Marka.Fiat, "B420", "rysa");

            Warsztat.DodajDoListy(Marka.Fiat, "B420", "XDDDD");
            Warsztat.DodajDoListy(Marka.Opel, "B12432", "XDDDD");
            Warsztat.DodajDoListy(Marka.Skoda, "B420", "XXDDD");
            Warsztat.DodajDoListy(Marka.Fiat, "39999", "XDDDD");
            Warsztat.DodajDoListy(Marka.Skoda, "00003", "XD");

            Warsztat.WykonajNaprawe("B420");
            Warsztat.DrugaUsterka("39999", "heheehszki");

        }
    }
}
