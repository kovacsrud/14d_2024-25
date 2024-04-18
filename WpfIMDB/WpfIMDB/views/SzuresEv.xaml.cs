using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
        List<Movie> result=new List<Movie>();
        public SzuresEv(MovieList movies)
        {
            InitializeComponent();
            DataContext = movies;
        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as MovieList;

            datagridImdbData.ItemsSource = null;

            result = dc.Movies.FindAll(x=>x.ReleaseYear==Convert.ToInt32(textboxEv.Text));

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

        private void buttonKiir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (result.Count>0)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = ".csv|*.csv|*.*|*.*";

                    if (saveFileDialog.ShowDialog() == true)
                    {
                        FileStream fajl=new FileStream(saveFileDialog.FileName, FileMode.Create);
                        using(StreamWriter writer=new StreamWriter(fajl,Encoding.Default))
                        {
                            writer.WriteLine($"movie_name,release_year;imdb_rating;genre") ;
                            foreach(var r in result)
                            {
                                writer.WriteLine($"{r.MovieName};{r.ReleaseYear};{r.ImdbRating};{r.Genre}") ;
                            }
                        }
                        MessageBox.Show("Adatok mentve!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
    }
}
