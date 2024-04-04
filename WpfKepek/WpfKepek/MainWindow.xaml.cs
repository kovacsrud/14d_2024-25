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

namespace WpfKepek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            imageMasodik.Source = new BitmapImage(new Uri(@"d:\testpics\fish.png"));
        }

        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
                        
            dialog.Filter = ".jpg|*.jpg|.png|*.png|összes fájl|*.*"; ;


            if (dialog.ShowDialog()==true)
            {
               
                imageHarmadik.Source = new BitmapImage(new Uri(dialog.FileName));
                imageHarmadik.Stretch = Stretch.Uniform;
            }
        }


    }
}