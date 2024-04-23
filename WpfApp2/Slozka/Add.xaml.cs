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
using System.Windows.Shapes;

namespace WpfApp2.Slozka
{
    /// <summary>
    /// Interakční logika pro Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        List<Potravina> _potraviny; 
        public Add(List<Potravina> potraviny)
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private int VytvorId() => _potraviny.Count + 1;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nazev = ProNazev.Text;
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


            Potravina Novy = new Potravina(VytvorId(), nazev, pocet, cena);
            _potraviny.Add(Novy);

            Close();
        }
    }
}
