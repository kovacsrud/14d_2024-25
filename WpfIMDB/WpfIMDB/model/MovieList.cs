using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIMDB.model
{
    public class MovieList
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public MovieList(string fajl,char hatarolo,int start=1)
        {
            var sorok=File.ReadAllLines(fajl,Encoding.Default);

            for(int i = start; i < sorok.Length; i++)
            {
                Movies.Add(new Movie(sorok[i], hatarolo));
            }
        }
    }
}
