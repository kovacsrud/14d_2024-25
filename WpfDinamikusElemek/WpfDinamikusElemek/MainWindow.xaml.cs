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

namespace WpfDinamikusElemek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> elemek=new List<int>();
        public MainWindow()
        {
            InitializeComponent();
            elemek.Add(50);
            elemek.Add(100);
            elemek.Add(150);
            elemek.Add(200);

            comboDarab.ItemsSource = elemek;

            //comboDarab.Items.Add(50);
            //comboDarab.Items.Add(100);
            //comboDarab.Items.Add(150);
            //comboDarab.Items.Add(200);

            comboDarab.SelectedIndex = 0;
            //Gombok(200);
        }

        public void Gombok(int darab)
        {
            for (int i = 0; i < darab; i++)
            {
                Button button = new Button();
                button.Content = i + 1;
                button.Margin=new Thickness(5);
                button.Width = 50;
                button.Click += GombClick;
                wrapGombok.Children.Add(button);
            }
        }

        private void GombClick(object sender, RoutedEventArgs e)
        {
            //Button button=sender as Button;

            //Referencia létrehozása a gombra
            Button button=(Button)sender;
            textblockButton.Text=button.Content.ToString();
            wrapGombok.Children.Remove(button);
        }

        private void comboDarab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            wrapGombok.Children.Clear();
            var darab = (int)comboDarab.SelectedItem;
            Gombok(darab);
        }
    }
}