using MauiJegyzetV2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace MauiJegyzetV2.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : TableData, new()
    {
        SQLiteConnection connection;
        public string StatusMsg { get; set; }

        public BaseRepository()
        {
            connection = new SQLiteConnection(DbConfig.DatabasePath, DbConfig.Flags);
            connection.CreateTable<T>();
        }

        public void NewItem(T item)
        {
            int result = 0;
            try
            {
                result = connection.Insert(item);
                StatusMsg = $"{result} elem hozzáadva";
            }
            catch (Exception ex)
            {
                StatusMsg = $"Hiba:{ex.Message}";                
            }
        }

        public void UpdateItem(T item)
        {
            int result = 0;
            try
            {
                result = connection.Update(item);
                StatusMsg = $"{result} elem módosítva";
            }
            catch (Exception ex)
            {
                StatusMsg = $"Hiba:{ex.Message}";
            }
        }

        public void DeleteItem(T item)
        {
            int result = 0;
            try
            {
                result = connection.Delete(item);
                StatusMsg = $"{result} elem törölve";
            }
            catch (Exception ex)
            {
                StatusMsg = $"Hiba:{ex.Message}";
            }
        }

        public List<T> GetItems()
        {
            try
            {
                return connection.Table<T>().ToList();
            }
            catch (Exception ex)
            {
                StatusMsg = $"Hiba:{ex.Message}";                
            }
            return null;
        }

        public void Dispose()
        {
            connection.Close();
        }

        public List<T> GetItemsWithChildren()
        {
            try
            {
                return connection.GetAllWithChildren<T>().ToList();
            }
            catch (Exception ex)
            {
                StatusMsg = $"Hiba:{ex.Message}";                
            }
            return null;
        }
    }
}
