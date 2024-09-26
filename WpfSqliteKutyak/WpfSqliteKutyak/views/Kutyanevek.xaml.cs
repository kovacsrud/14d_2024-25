using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
    /// Interaction logic for Kutyanevek.xaml
    /// </summary>
    public partial class Kutyanevek : Window
    {
        //private string connectionString = "Data Source=kutyak.db";
        public Kutyanevek()
        {
            InitializeComponent();
            datagridKutyanevek.ItemsSource = DbRepo.GetKutyanevek();
        }



        private void buttonUjKutyanev_Click(object sender, RoutedEventArgs e)
        {
            EditKutyanev editKutyanev= new EditKutyanev(this);
            editKutyanev.ShowDialog();
        }

        private void datagridKutyanevek_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var aktKutyanev=datagridKutyanevek.SelectedItem as Kutyanev;
            EditKutyanev editKutyanev = new EditKutyanev(aktKutyanev,this);
            editKutyanev.ShowDialog();
        }

        private void buttonTorolKutyanev_Click(object sender, RoutedEventArgs e)
        {
            var aktKutyanev = datagridKutyanevek.SelectedItem as Kutyanev;

            var valasz = MessageBox.Show("Biztosan törli?", "Törlés", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if(valasz == MessageBoxResult.OK)
            {
                DbRepo.TorolKutyanev(aktKutyanev);
                datagridKutyanevek.ItemsSource = DbRepo.GetKutyanevek();
            }


        }
    }
}
