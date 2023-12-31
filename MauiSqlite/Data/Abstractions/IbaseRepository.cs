﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MauiSqlite.Data.Abstractions
{
    public interface IbaseRepository<T> : IDisposable where T : TableData, new()
    {
        void SaveItemWhitChildern(T item);
        void SaveItemChidren(T item, bool recursive = false);
        T GetItem(int id);
        T GetItem(Expression<Func<T, bool>> predicate);
        List<T> GetItems();
        List<T> GetItems(Expression<Func<T, bool>> predicate);
        List<T> GetItemsWihtChildern();
        void DeleteItem(T item);
    }
}
