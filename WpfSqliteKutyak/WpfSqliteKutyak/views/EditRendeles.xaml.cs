using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for EditRendeles.xaml
    /// </summary>
    public partial class EditRendeles : Window
    {
        bool modosit=false;
        int modositId;
        Rendelesek rendelesWin;
        public EditRendeles(Rendelesek rendelesWin)
        {
            InitializeComponent();
            comboKutyanev.ItemsSource = DbRepo.GetKutyanevek();
            comboKutyanev.SelectedIndex = 0;
            comboKutyafajta.ItemsSource = DbRepo.GetKutyafajtak();
            comboKutyafajta.SelectedIndex = 0;
            this.rendelesWin = rendelesWin;
        }

        public EditRendeles(Rendeles rendeles,Rendelesek rendelesWin)
        {
            InitializeComponent();
            modosit = true;
            textboxFelirat.Text = "Rendelési adat módosítása";
            this.Title = "Rendelési adat módosítása";
            modositId = rendeles.Id;
            comboKutyanev.ItemsSource = DbRepo.GetKutyanevek();
            comboKutyanev.SelectedValue=rendeles.NevId;      
            
            comboKutyafajta.ItemsSource = DbRepo.GetKutyafajtak();
            comboKutyafajta.SelectedValue = rendeles.FajtaId;

            textblockEletkor.Text=rendeles.Eletkor.ToString();
            textblockUtolsoEll.Text = rendeles.UtolsoEll;
            this.rendelesWin = rendelesWin;

        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (modosit)
                {
                    //Todo: módosítás megvalósítása
                    Rendeles rendeles = new Rendeles();
                    rendeles.Id = modositId; ;
                    rendeles.NevId = (int)comboKutyanev.SelectedValue;
                    rendeles.FajtaId = (int)comboKutyafajta.SelectedValue;
                    rendeles.Eletkor = Convert.ToInt32(textblockEletkor.Text);
                    rendeles.UtolsoEll = textblockUtolsoEll.Text; ;

                    DbRepo.ModositRendelesiAdat(rendeles);
                    rendelesWin.datagridRendelesek.ItemsSource=DbRepo.GetRendelesiAdatok();

                }
                else
                {
                    Rendeles rendeles = new Rendeles();
                    rendeles.NevId = (int)comboKutyanev.SelectedValue;
                    rendeles.FajtaId = (int)comboKutyafajta.SelectedValue;
                    rendeles.Eletkor = Convert.ToInt32(textblockEletkor.Text);
                    rendeles.UtolsoEll = textblockUtolsoEll.Text; ;

                    DbRepo.UjRendelesiAdat(rendeles);
                    rendelesWin.datagridRendelesek.ItemsSource = DbRepo.GetRendelesiAdatok();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            

            
        }

        private void comboKutyanev_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboKutyanev.SelectedValue!=null)
            {
                var selected = comboKutyanev.SelectedValue;
                Debug.WriteLine(selected);
            }
            
        }
    }
}
