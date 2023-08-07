﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiSqlite.Data.Abstractions;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MauiSqlite.MVVM.Models
{
    [Table("Customers")]
    public class Customer: TableData
    {
        //[PrimaryKey, AutoIncrement]
        //public int Id { get; set; }
        [Column("name"), Indexed, NotNull]
        public string Name { get; set; }
        [Unique]
        public string Phone { get; set; }
        public int Age { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [Ignore]
        public bool IsYoung => Age > 50 ? true : false;

        //[ForeignKey(typeof(Passport))]
        //public int PassportId { get; set; }

        [ManyToMany(typeof(Passport), CascadeOperations = CascadeOperation.All)]
        public List<Passport> Passport { get; set; }
    }
}
