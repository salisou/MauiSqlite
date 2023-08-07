using MauiSqlite.Data.Abstractions;
using MauiSqlite.MVVM.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MauiSqlite.Data.Repositories
{
    public class BaseRepository<T> : IbaseRepository<T> where T : TableData, new()
    {
        SQLiteConnection _connection;
        public string StatusMesage { get; set; }

        public BaseRepository()
        {
            _connection = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
            _connection.CreateTable<T>();
        }
        public void DeleteItem(T item)
        {
            try
            {
                //_connection.Delete(item);
                _connection.Delete(item, true);
            }
            catch (Exception ex)
            {
                StatusMesage = $"Error: {ex.Message}";
            }
        }

        public void Dispose()
        {
            _connection.Close();
        }

        public T GetItem(int id)
        {
            try
            {
                return _connection.Table<T>()
                    .FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                StatusMesage = $"Error: {ex.Message}";
            }
            return null;
        }

        public T GetItem(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return _connection.Table<T>()
                    .Where(predicate).FirstOrDefault();
            }
            catch (Exception ex)
            {
                StatusMesage = $"Error: {ex.Message}";
            }
            return null;
        }

        public List<T> GetItems()
        {
            try
            {
                return _connection.Table<T>().ToList();
            }
            catch (Exception ex)
            {
                StatusMesage = $"Error: {ex.Message}";
            }
            return null;
        }

        public List<T> GetItems(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return _connection.Table<T>().Where(predicate).ToList();
            }
            catch (Exception ex)
            {
                StatusMesage = $"Error: {ex.Message}";
            }
            return null;
        }

        public void SaveItemWhitChildern(T item)
        {
            int resulet = 0;

            try
            {
                if (item.Id != 0)
                {
                    resulet = _connection.Update(item);
                    StatusMesage = $"{resulet} row(s) updated";
                }
                else
                {
                    resulet = _connection.Insert(item);
                    StatusMesage = $"{resulet} row(s) added";
                }

            }
            catch (Exception ex)
            {
                StatusMesage = $"Error: {ex.Message}";
            }
        }

        public void SaveItemChidren(T item, bool recursive)
        {
            _connection.InsertWithChildren(item, recursive);
        }

        public List<T> GetItemsWihtChildern()
        {
            try
            {
                return _connection.GetAllWithChildren<T>().ToList();
            }
            catch (Exception ex)
            {
                StatusMesage = $"Error: {ex.Message}";
            }
            return null;
        }
    }
}
