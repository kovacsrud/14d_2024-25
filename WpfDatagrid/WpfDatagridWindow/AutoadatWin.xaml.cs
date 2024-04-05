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
using WpfDatagrid.Model;

namespace WpfDatagridWindow
{
    /// <summary>
    /// Interaction logic for AutoadatWin.xaml
    /// </summary>
    public partial class AutoadatWin : Window
    {
        //Dependency injection
        public List<Auto> Autok { get; set; }
        public AutoadatWin(List<Auto> autok)
        {
            InitializeComponent();
            Autok = autok;
            datagridAutoadat.ItemsSource = Autok;
        }
    }
}
