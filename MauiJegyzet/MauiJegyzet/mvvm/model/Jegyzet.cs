using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MauiJegyzet.mvvm.model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("jegyzetek")]
    public class Jegyzet
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public string Cim { get; set; }
        [NotNull]
        public string Szoveg { get; set; }
        [NotNull]
        public DateTime Datum { get; set; } = DateTime.Now;

        
    }
}
