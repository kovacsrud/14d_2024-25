
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiJegyzetV2.interfaces;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MauiJegyzetV2.mvvm.models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("notes")]

    public class Note:TableData
    {
        //A TableData osztályba áthelyeztük az Id-t!!!
        //[PrimaryKey,AutoIncrement]
        //public int Id { get; set; }
        [NotNull]
        public string Title { get; set; }
        [NotNull]
        public string NoteText { get; set; }
        [NotNull]
        public DateTime Date { get; set; } = DateTime.Now;

        [SQLiteNetExtensions.Attributes.ForeignKey(typeof(Category))]
        public int CategoryId { get; set; }

        [SQLiteNetExtensions.Attributes.OneToOne(CascadeOperations =CascadeOperation.CascadeRead)]
        public Category Category { get; set; }

    }
}
