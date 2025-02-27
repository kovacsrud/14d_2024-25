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

namespace WpfHomersekletTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonKonvertalas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (celsiusKivalaszt.IsChecked==true)
                {
                    konvertaltHomerseklet.Text = HomersekletConverter.FahrenheitToCelsius(Convert.ToDouble(textboxHomerseklet.Text)).ToString();
                    
                } else
                {
                    konvertaltHomerseklet.Text = HomersekletConverter.CelsiusToFahrenheit(Convert.ToDouble(textboxHomerseklet.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");                
            }
        }
    }
}