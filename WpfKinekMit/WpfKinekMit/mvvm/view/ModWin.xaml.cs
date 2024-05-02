using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfKinekMit.mvvm.model;
using WpfKinekMit.mvvm.viewmodel;

namespace WpfKinekMit.mvvm.view
{
    /// <summary>
    /// Interaction logic for ModWin.xaml
    /// </summary>
    public partial class ModWin : Window
    {
        public ModWin(ItemsViewModel vm,bool newItem=false)
        {
            InitializeComponent();
            DataContext = vm;
            if(newItem==true)
            {
                vm.SelectedItem = new Item
                {
                    Targy="",
                    DarabSzam=0,
                    TargyKepe = new BitmapImage(new Uri(System.IO.Path.Combine(System.Environment.CurrentDirectory, "testpics/notfound.png"))),
                    Kinek = "",
                    KinekKep = new BitmapImage(new Uri(System.IO.Path.Combine(System.Environment.CurrentDirectory, "testpics/notfound.png")))
                };

                buttonRogzit.Visibility= Visibility.Visible;

            }
        }

        private void Image_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image image = (Image)sender;
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == true)
            {
                image.Source=new BitmapImage(new Uri(dialog.FileName));
            }
        }

        private void buttonRogzit_Click(object sender, RoutedEventArgs e)
        {
            var vm=DataContext as ItemsViewModel;
            vm.AddItem(vm.SelectedItem);
        }
    }
}
