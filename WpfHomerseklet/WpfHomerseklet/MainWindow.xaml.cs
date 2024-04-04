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

namespace WpfHomerseklet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textblockEredmeny.Text = "";
            textblockFelirat.Text = "Celsius fok:";
        }

        private void buttonSzamol_Click(object sender, RoutedEventArgs e)
        {
            if (radioCelsius.IsChecked==true)
            {

                try
                {
                    var celsiusfok = Convert.ToDouble(textboxInput.Text);
                    var fahrenheitfok = (celsiusfok * 1.8) + 32;
                    textblockEredmeny.Text = fahrenheitfok.ToString() + " F";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
                
            } else
            {
                try
                {
                    var fahrenheitfok = Convert.ToDouble(textboxInput.Text);
                    var celsiusfok = (fahrenheitfok - 32) / 1.8;
                    textblockEredmeny.Text = celsiusfok.ToString() + " C";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void radioFahrenheit_Checked(object sender, RoutedEventArgs e)
        {
            textblockFelirat.Text = "Fahrenheit fok:";
            textblockEredmeny.Text = "";
            textboxInput.Text = "";
        }

        private void radioCelsius_Checked(object sender, RoutedEventArgs e)
        {
            textblockFelirat.Text = "Celsius fok:";

            if(textblockEredmeny != null)
            {
                textblockEredmeny.Text = "";
            }
            

            
            textboxInput.Text = "";
        }
    }
}