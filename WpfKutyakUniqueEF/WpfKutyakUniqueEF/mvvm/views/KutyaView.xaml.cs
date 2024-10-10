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
using WpfKutyakUniqueEF.mvvm.viewmodels;

namespace WpfKutyakUniqueEF.mvvm.views
{
    /// <summary>
    /// Interaction logic for KutyaView.xaml
    /// </summary>
    public partial class KutyaView : Window
    {
        public KutyaView(KutyaViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void buttonMentes_Click(object sender, RoutedEventArgs e)
        {
            var vm=DataContext as KutyaViewModel;
            vm.DbMentes();
        }

        private void buttonUj_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as KutyaViewModel;
            UjRendelesiAdatView ujRendelesiAdat = new UjRendelesiAdatView(vm);
            ujRendelesiAdat.ShowDialog();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var vm = DataContext as KutyaViewModel;
            UjRendelesiAdatView modositRendelesiAdat = new UjRendelesiAdatView(vm, true);
            modositRendelesiAdat.ShowDialog();
        }

        private void buttonTorles_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as KutyaViewModel;
            var valasz = MessageBox.Show("Biztosan törli?", "Törlés", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (valasz == MessageBoxResult.OK && vm.SelectedKutya!=null)
            {
                
                vm.Kutyak.Remove(vm.SelectedKutya);
                vm.DbMentes();
            }
        }
    }
}
