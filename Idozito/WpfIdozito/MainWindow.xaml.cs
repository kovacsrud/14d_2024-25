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
using System.Windows.Threading;

namespace WpfIdozito
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int szamlalo = 0;
        DispatcherTimer timer;
        string[] kepfajlok;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer(TimeSpan.FromMilliseconds(1000),DispatcherPriority.Normal,Csere,Dispatcher.CurrentDispatcher);
            timer.Stop();
        }

        private void Csere(object sender, EventArgs e)
        {
            imageKep.Source = new BitmapImage(new Uri(kepfajlok[szamlalo]));
            szamlalo++;
            if(szamlalo>=kepfajlok.Length)
            {
                szamlalo = 0;
            }
        }

        private void buttonTolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == true)
            {
                kepfajlok = dialog.FileNames;
                timer.Start();
                buttonStartStop.Content = "Stop";
                buttonStartStop.IsEnabled = true;
            }
        }



        private void buttonStartStop_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = !timer.IsEnabled;
            if (timer.IsEnabled)
            {
                buttonStartStop.Content = "Stop";
            } else
            {
                buttonStartStop.Content = "Start";
            }
        }
    }
}