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
        public SzuresEv(MovieList movies)
        {
            InitializeComponent();
            DataContext = movies;
        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as MovieList;

            datagridImdbData.ItemsSource = null;

            var result = dc.Movies.FindAll(x=>x.ReleaseYear==Convert.ToInt32(textboxEv.Text));

            if (result.Count<1)
            {
                MessageBox.Show("Nincs a feltételnek megfelelő adat!");
            } else
            {
                datagridImdbData.ItemsSource= result;
            }


        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as MovieList;
            datagridImdbData.ItemsSource = dc.Movies;
        }
    }
}
