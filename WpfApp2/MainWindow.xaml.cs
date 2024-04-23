using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using WpfApp2.Slozka;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Potravina> Potraviny { get; set; }
        public MainWindow()
        {
            Potraviny = new();
            InitializeComponent();
            seznam.ItemsSource = Potraviny;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Add dialog = new(Potraviny);
            dialog.Closing += Close;
            dialog.ShowDialog();
        }

        private void Close(object? sender, EventArgs e)
        {
            seznam.ItemsSource = null;
            seznam.ItemsSource = Potraviny;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Potravina? info = seznam?.SelectedItem as Potravina ?? new Potravina(-1, "Neznámý", "Nenalezen");
            MessageBox.Show($"{info.Id} {info.Nazev} {info.Pocet}");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Potravina? hledany = seznam?.SelectedItem as Potravina;
            if (hledany != null)
            {
                Edit edit = new Edit(hledany);
                edit.Closing += Close;
                edit.ShowDialog();
            }


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Potravina? hledany = seznam?.SelectedItem as Potravina;
            MessageBoxResult volba = MessageBox.Show($"Odebrat {hledany.Nazev}?", "Odebrat", MessageBoxButton.YesNo);
            if (volba == MessageBoxResult.Yes)
            {
                Potraviny.Remove(hledany);
                seznam.ItemsSource = null;
                seznam.ItemsSource = Potraviny;
            }
        }
    }
}