using Microsoft.Win32;
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
using WpfDatagrid.Model;

namespace WpfDatagridWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Auto> Autok { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuitemNevjegy_Click(object sender, RoutedEventArgs e)
        {
            NevjegyWin nevjegy = new NevjegyWin();
            nevjegy.ShowDialog();
            
        }

        private void menuitemAutoadat_Click(object sender, RoutedEventArgs e)
        {
            AutoadatWin autoadat = new AutoadatWin();
            autoadat.ShowDialog();
        }

        private void menuitemMegnyitas_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".csv|*.csv|minden fájl|*.*";
            if (dialog.ShowDialog()==true)
            {
                try
                {
                    AutoLista autoLista = new AutoLista(dialog.FileName, ';');
                    Autok = autoLista.Autok;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);                    
                }
            }
        }
    }
}