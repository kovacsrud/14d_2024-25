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

namespace WpfJegyzettomb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuitemNevjegy_Click(object sender, RoutedEventArgs e)
        {
            Nevjegy nevjegy = new Nevjegy();
            nevjegy.ShowDialog();
        }

        private void menuitemKilepes_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void menuitemMegnyitas_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            dialog.Filter = "szöveg (*.txt)|*.txt|csv fájlok|*.csv|weblap|*.html|minden fájl|*.*";
            if (dialog.ShowDialog()==true)
            {
                try
                {
                    textboxSzoveg.Text=File.ReadAllText(dialog.FileName,Encoding.UTF7);
                    this.Title = dialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
            }
        }

        private void menuitemMentes_Click(object sender, RoutedEventArgs e)
        {
            if (this.Title=="Jegyzettömb")
            {
                MentesMaskent();

            } else
            {
                try
                {
                    File.WriteAllText(this.Title, textboxSzoveg.Text, Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
        }

        private void MentesMaskent()
        {
            SaveFileDialog dialog= new SaveFileDialog();
            dialog.Filter = "szöveg (*.txt)|*.txt|csv fájlok|*.csv|weblap|*.html|minden fájl|*.*";

            if (dialog.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllText(dialog.FileName, textboxSzoveg.Text, Encoding.Default);
                    this.Title=dialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }

        private void menuitemMentesMaskent_Click(object sender, RoutedEventArgs e)
        {
            MentesMaskent();
        }

        private void menuitemKivagas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuitemMasolas_Click(object sender, RoutedEventArgs e)
        {
            if (textboxSzoveg.SelectedText.Length > 0)
            {
                Clipboard.SetText(textboxSzoveg.SelectedText);
            }
        }

        private void menuitemBeillesztes_Click(object sender, RoutedEventArgs e)
        {
            var vagolapSzoveg=Clipboard.GetText();
            textboxSzoveg.Text = textboxSzoveg.Text.Insert(textboxSzoveg.CaretIndex,vagolapSzoveg);
        }
    }
}