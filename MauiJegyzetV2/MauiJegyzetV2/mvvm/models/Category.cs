using MauiJegyzetV2.interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiJegyzetV2.mvvm.models
{
    public class Category:TableData
    {
        [NotNull,Unique]
        public string CategoryName { get; set; }
    }
}
