using MauiSqlite.Data.Abstractions;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSqlite.MVVM.Models
{
    public class Passport: TableData
    {
        public DateTime ExpirationDate { get; set; }
        //[ForeignKey(typeof(Customer))]
        [ManyToMany(typeof(Customer))]
        public int CustomerId { get; set;}
    }
}
