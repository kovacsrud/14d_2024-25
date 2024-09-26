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
    /// Interaction logic for EditKutyanev.xaml
    /// </summary>
    public partial class EditKutyanev : Window
    {
        bool modosit = false;
        //private string connectionString = "Data Source=kutyak.db";
        Kutyanevek kutyanevekWin;

        //Dependency injection
        public EditKutyanev(Kutyanevek kutynevekWin)
        {
            InitializeComponent();
            this.kutyanevekWin = kutynevekWin;
        }

        public EditKutyanev(Kutyanev kutyanev,Kutyanevek kutynevekWin)
        {
            InitializeComponent();
            this.kutyanevekWin = kutynevekWin;
            textblockCim.Text = "Módosítás";
            textboxId.Text = kutyanev.Id.ToString();
            textboxKutyanev.Text = kutyanev.KutyaNev;
            modosit = true;

        }

       

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            if (modosit)
            {
                Kutyanev kutyanev = new Kutyanev();
                kutyanev.Id = Convert.ToInt32(textboxId.Text); ;
                kutyanev.KutyaNev = textboxKutyanev.Text;

                DbRepo.ModositKutyanev(kutyanev);
                
                kutyanevekWin.datagridKutyanevek.ItemsSource=DbRepo.GetKutyanevek();

            } else
            {

                DbRepo.UjKutyanev(new Kutyanev { KutyaNev=textboxKutyanev.Text });
                kutyanevekWin.datagridKutyanevek.ItemsSource = DbRepo.GetKutyanevek();
            }
        }
    }
}
