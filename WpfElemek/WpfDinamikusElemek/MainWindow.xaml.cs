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
        public MainWindow()
        {
            InitializeComponent();
            var gombDb = 300;
            this.Title = $"{gombDb} darab button";
            Gombok(gombDb);
            
            
        }

        private void Gombok(int db)
        {
            for (int i = 0; i < db; i++)
            {
                Button btn= new Button();
                btn.Content = i + 1;
                btn.Width = 70;
                btn.Foreground = Brushes.Blue;
                btn.Background = Brushes.Red;
                btn.Margin = new Thickness(5);
                
                wrapGombok.Children.Add(btn);
                
            }
        }
    }
}