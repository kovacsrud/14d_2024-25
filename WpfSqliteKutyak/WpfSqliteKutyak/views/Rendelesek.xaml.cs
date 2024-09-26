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
using WpfSqliteKutyak.Model;

namespace WpfSqliteKutyak.views
{
    /// <summary>
    /// Interaction logic for Rendelesek.xaml
    /// </summary>
    public partial class Rendelesek : Window
    {
        public Rendelesek()
        {
            InitializeComponent();
            datagridRendelesek.ItemsSource = DbRepo.GetRendelesiAdatok();
        }

        private void buttonUjRendeles_Click(object sender, RoutedEventArgs e)
        {
            EditRendeles editRendeles = new EditRendeles();
            editRendeles.ShowDialog();
        }

        private void datagridRendelesek_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var aktRendeles=datagridRendelesek.SelectedItem as Rendeles;
            EditRendeles editRendeles=new EditRendeles(aktRendeles);
            editRendeles.ShowDialog();
        }
    }
}
