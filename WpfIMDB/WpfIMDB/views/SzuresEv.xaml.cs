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
using WpfIMDB.model;

namespace WpfIMDB.views
{
    /// <summary>
    /// Interaction logic for SzuresEv.xaml
    /// </summary>
    public partial class SzuresEv : Window
    {
        public SzuresEv(List<Movie> movies)
        {
            InitializeComponent();
            DataContext = movies;
        }
    }
}
