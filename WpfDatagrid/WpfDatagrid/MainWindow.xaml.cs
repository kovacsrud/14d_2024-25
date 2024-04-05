using Microsoft.Win32;
using System.IO;
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
using WpfDatagrid.Model;

namespace WpfDatagrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Auto> Autok { get; set; }
        List<Auto> result = new List<Auto>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonBetoltes_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".csv|*.csv";
            if (dialog.ShowDialog()==true)
            {
                try
                {
                    AutoLista autolista = new AutoLista(dialog.FileName, ';');
                    
                    //Így tudjuk az egész osztályban használni az adatokat
                    Autok = autolista.Autok;

                    datagridAutok.ItemsSource = Autok;
                    tabitemGrid.IsEnabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
            }
        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            datagridAutok.ItemsSource = null;

            

            if (textboxKereses.Text.Length>0 && textboxTipus.Text.Length==0)
            {
                result = Autok.FindAll(x => x.Marka.ToLower().Trim() == textboxKereses.Text.ToLower().Trim());
            }

            if (textboxKereses.Text.Length == 0 && textboxTipus.Text.Length > 0)
            {
                result = Autok.FindAll(x => x.Tipus.ToLower().Trim().Contains(textboxTipus.Text.ToLower().Trim()));
            }

            if (textboxKereses.Text.Length > 0 && textboxTipus.Text.Length > 0)
            {
                result = Autok.FindAll(x => x.Marka.ToLower().Trim() == textboxKereses.Text.ToLower().Trim() && x.Tipus.ToLower().Trim().Contains(textboxTipus.Text.ToLower().Trim()));
            }

            

            if (result.Count>0)
            {
                datagridAutok.ItemsSource = result;

            } else
            {
                MessageBox.Show("Nincs találat!");
            }
        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            datagridAutok.ItemsSource = Autok;
        }

        private void buttonMentes_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = ".csv|*.csv";

            var valasz = MessageBox.Show("Biztosan menti?","Mentés",MessageBoxButton.YesNo,MessageBoxImage.Question);

            if(valasz == MessageBoxResult.Yes)
            {
                //Mentés végrehajtása
                if (dialog.ShowDialog() == true)
                {
                    try
                    {
                        FileStream file = new FileStream(dialog.FileName,FileMode.Create);

                        using (StreamWriter writer = new StreamWriter(file, Encoding.UTF8))
                        {
                            writer.WriteLine($"id;marka;tipus;evjarat;uzem;hengerurtartalom;teljesitmeny;futottkm;ar");

                            foreach (var i in result)
                            {
                                writer.WriteLine($"{i.Id};{i.Marka};{i.Tipus};{i.Evjarat};{i.Uzem};{i.Hengerurtartalom};{i.Teljesitmeny};{i.FutottKm};{i.Ar}");
                            }
                        }
                        MessageBox.Show("Adatok fájlba írva!");
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);                        
                    } 
                }
            }
        }
    }
}