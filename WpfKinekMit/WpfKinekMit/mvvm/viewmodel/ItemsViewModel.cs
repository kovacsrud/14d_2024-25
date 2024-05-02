using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfKinekMit.mvvm.model;

namespace WpfKinekMit.mvvm.viewmodel
{
    public class ItemsViewModel
    {
        public ObservableCollection<Item> Items { get; set; }=new ObservableCollection<Item>();
        public Item SelectedItem { get; set; } = new Item();

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}
