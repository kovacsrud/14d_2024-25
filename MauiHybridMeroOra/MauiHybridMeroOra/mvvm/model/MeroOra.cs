using MauiHybridMeroOra.interfaces;
using PropertyChanged;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHybridMeroOra.mvvm.model
{
    [AddINotifyPropertyChangedInterface]
    [System.ComponentModel.DataAnnotations.Schema.Table("meroadatok")]
    public class MeroOra:TableData
    {
        [NotNull]
        public int Termeles { get; set; }
        [NotNull]
        public int Fogyasztas { get; set; }
        [NotNull]
        public DateTime Datum { get; set; } = DateTime.Now;
    }
}
