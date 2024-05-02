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
using WpfKinekMit.mvvm.model;
using WpfKinekMit.mvvm.viewmodel;
using System.IO;
using WpfKinekMit.mvvm.view;

namespace WpfKinekMit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ItemsViewModel();

            var vm = DataContext as ItemsViewModel;

            Item item1 = new Item {
                Targy = "kenyér",
                DarabSzam = 2,
                TargyKepe = new BitmapImage(new Uri(System.IO.Path.Combine(System.Environment.CurrentDirectory,"testpics/bread.png"))),
                Kinek="Ubul",
                KinekKep=new BitmapImage(new Uri(System.IO.Path.Combine(System.Environment.CurrentDirectory,"testpics/apple.png")))
            };

            Item item2 = new Item
            {
                Targy = "banán",
                DarabSzam = 6,
                TargyKepe = new BitmapImage(new Uri(System.IO.Path.Combine(System.Environment.CurrentDirectory, "testpics/banana.png"))),
                Kinek = "Ubul",
                KinekKep = new BitmapImage(new Uri(System.IO.Path.Combine(System.Environment.CurrentDirectory, "testpics/fish.png")))
            };

            vm.AddItem(item1);
            vm.AddItem(item2);
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var vm = DataContext as ItemsViewModel;
            ModWin modWin = new ModWin(vm);
            modWin.ShowDialog();
        }

        private void buttonUj_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as ItemsViewModel;
            ModWin modWin = new ModWin(vm,true);
            modWin.ShowDialog();
        }
    }
}