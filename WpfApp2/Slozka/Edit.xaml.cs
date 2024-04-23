using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace WpfApp2.Slozka
{
    /// <summary>
    /// Interakční logika pro Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Potravina X { get; set; }
        public Edit(Potravina x)
        {
            X = x;
            InitializeComponent();
            DataContext = X;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            X.Nazev = ProNazev.Text;
            if (int.TryParse(ProPocet.Text, out int pocet))
            {

            }
            else
            {
                return;
            }
            if (int.TryParse(ProCena.Text, out int cena))
            {

            }
            else
            {
                return;
            }


            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }   
    }
}
