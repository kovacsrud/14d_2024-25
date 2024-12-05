using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiJegyzetV2.interfaces
{
    public interface IBaseRepository<T>:IDisposable where T:TableData,new()
    {
        void NewItem(T item);
        void UpdateItem(T item);
        void DeleteItem(T item);
        List<T> GetItems();
        List<T> GetItemsWithChildren();
    }
}
