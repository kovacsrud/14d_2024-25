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

namespace WpfKepMultiselect
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

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog=new OpenFileDialog();
            dialog.Multiselect = true;
            if (dialog.ShowDialog()==true)
            {
                if (dialog.FileNames.Length >= 4)
                {
                    kep1.Source=new BitmapImage(new Uri(dialog.FileNames[0]));
                    kep2.Source = new BitmapImage(new Uri(dialog.FileNames[1]));
                    kep3.Source = new BitmapImage(new Uri(dialog.FileNames[2]));
                    kep4.Source = new BitmapImage(new Uri(dialog.FileNames[3]));
                }
            }
        }
    }
}