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
using WpfKutyakUniqueEF.mvvm.models;
using WpfKutyakUniqueEF.mvvm.viewmodels;

namespace WpfKutyakUniqueEF.mvvm.views
{
    /// <summary>
    /// Interaction logic for UjRendelesiAdatView.xaml
    /// </summary>
    /// 
    //
    public partial class UjRendelesiAdatView : Window
    {
        public Kutya AktKutya { get; set; } = new Kutya();
        public KutyaViewModel KutyaViewModel { get; set; }
        public UjRendelesiAdatView(KutyaViewModel vm)
        {
            InitializeComponent();
            KutyaViewModel = vm;
            DataContext = this;
        }

        private void buttonUj_Click(object sender, RoutedEventArgs e)
        {
            KutyaViewModel.Kutyak.Add(AktKutya);
            KutyaViewModel.DbMentes();
        }
    }
}
