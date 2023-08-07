using MauiSqlite.MVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MauiSqlite.Data.Repositories
{
    public class CustomerRepository
    {
        //SQLiteConnection _connection;
        //public string StatusMesage { get; set; }

        //public CustomerRepository()
        //{
        //    _connection = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);

        //    _connection.CreateTable<Customer>();
        //}

        //public void AddOrUpdate(Customer _customer)
        //{
        //    int resulet = 0;

        //    try
        //    {
        //        if (_customer.Id != 0)
        //        {
        //            resulet = _connection.Update(_customer);
        //            StatusMesage = $"{resulet} row(s) updated";
        //        }
        //        else
        //        {
        //            resulet = _connection.Insert(_customer);
        //            StatusMesage = $"{resulet} row(s) added";
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        StatusMesage = $"Error: {ex.Message}";
        //    }
        //}

       
        //public List<Customer> GetAll()
        //{
        //    try
        //    {
        //        return _connection.Table<Customer>().ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        StatusMesage = $"Error: {ex.Message}";
        //    }
        //    return null;
        //}

        //public List<Customer> GetAll(Expression<Func<Customer, bool>> predicate)
        //{
        //    try
        //    {
        //        return _connection.Table<Customer>().Where(predicate).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        StatusMesage = $"Error: {ex.Message}";
        //    }
        //    return null;
        //}

        //public List<Customer> GetAll2()
        //{
        //    try
        //    {
        //        return _connection.Query<Customer>("SELECYT * FROM Customers").ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        StatusMesage = $"Error: {ex.Message}";
        //    }
        //    return null;
        //}

        //public Customer Get(int id)
        //{
        //    try
        //    {
        //        return _connection.Table<Customer>().FirstOrDefault(x => x.Id == id);
        //    }
        //    catch (Exception ex)
        //    {
        //        StatusMesage = $"Error: {ex.Message}";
        //    }
        //    return null;
        //}

        //public void Delete(int customerId)
        //{
        //    try
        //    {
        //        var customer = Get(customerId);
        //        _connection.Delete(customer);
        //    }
        //    catch(Exception ex)
        //    {
        //        StatusMesage = $"Error: {ex.Message}";
        //    }
        //}
    }
}
