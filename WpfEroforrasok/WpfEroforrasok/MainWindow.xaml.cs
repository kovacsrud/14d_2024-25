using System.IO;
using System.Reflection;
using System.Resources;
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

namespace WpfEroforrasok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResourceManager rm=new ResourceManager("WpfEroforrasok.eroforrasok",Assembly.GetExecutingAssembly());
            textblockFocim.Text = rm.GetString("Focim");

            //byte[] kepadat1 = (byte[])rm.GetObject("apple");

            //using (MemoryStream ms=new MemoryStream(kepadat1))
            //{
            //    var image = new BitmapImage();
            //    image.BeginInit();
            //    image.CacheOption = BitmapCacheOption.OnLoad;
            //    image.StreamSource= ms;
            //    image.EndInit();
            //    kep1.Source = image;
            //}

            kep1.Source = GetKep(rm.GetObject("apple") as byte[]);
            kep2.Source = GetKep(rm.GetObject("banana") as byte[]);
            kep3.Source = GetKep(rm.GetObject("alcohol") as byte[]);
            kep4.Source = GetKep(rm.GetObject("bread") as byte[]);

            string elemek = (string)rm.GetObject("elemek");
            string[] listaelemek = elemek.Split('\n');
            listboxElemek.ItemsSource= listaelemek;
            this.Icon = GetKep(rm.GetObject("favicon_notebook") as byte[]);

        }

        private BitmapImage GetKep(byte[] kepadat) 
        {
            using (MemoryStream ms=new MemoryStream(kepadat))
            {
                var image=new BitmapImage();
                image.BeginInit();
                image.CacheOption= BitmapCacheOption.OnLoad;
                image.StreamSource= ms;
                image.EndInit();
                return image;
            }
        }
    }
}