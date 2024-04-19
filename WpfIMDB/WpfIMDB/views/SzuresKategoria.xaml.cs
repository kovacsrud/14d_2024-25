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
    /// Interaction logic for SzuresKategoria.xaml
    /// </summary>
    public partial class SzuresKategoria : Window
    {
        List<Movie> result = new List<Movie>();
        public SzuresKategoria(MovieList movies)
        {
            InitializeComponent();
            DataContext = movies;

            //var katlookup = movies.Movies.ToLookup(x => x.Genre);
            //List<string> kategoriak=new List<string>();

            //foreach (var i in katlookup)
            //{
            //    kategoriak.Add(i.Key);
            //}

            //comboKategoria.ItemsSource = kategoriak;
            //comboKategoria.SelectedIndex = 0;
        }

        private void comboKategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var kivalasztottKat = comboKategoria.SelectedItem.ToString();
            var dc = DataContext as MovieList;

            result = dc.Movies.FindAll(x => x.Genre == kivalasztottKat);

            datagridKategoria.ItemsSource= result;

        }
    }
}
