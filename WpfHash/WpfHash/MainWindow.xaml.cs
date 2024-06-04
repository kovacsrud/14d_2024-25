using Microsoft.Win32;
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

namespace WpfHash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hash hash=new Hash();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textboxSzoveg_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                textboxHash.Text = hash.Md5Hash(textboxSzoveg.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonTallozas_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            try
            {
                if (dialog.ShowDialog()==true)
                {
                    textboxFileHash.Text = hash.Md5Hash(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}