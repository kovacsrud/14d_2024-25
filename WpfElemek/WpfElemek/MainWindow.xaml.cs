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

namespace WpfElemek
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

        private void buttonSzamol_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textboxSzoveg1.Text.Length>0 && textboxSzoveg2.Text.Length>0)
                {
                    var szam1 = Convert.ToDouble(textboxSzoveg1.Text);
                    var szam2 = Convert.ToDouble(textboxSzoveg2.Text);
                    var eredmeny = szam1 / szam2;
                    textblockEredmeny.Text = eredmeny.ToString();
                } else
                {
                    MessageBox.Show("Egyik mező sem lehet üres!", "Információ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show("A mezőkbe számot kell írni!","Hiba!",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }

        }
    }
}