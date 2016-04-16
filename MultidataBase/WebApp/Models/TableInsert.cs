using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class TableInsert
    {
        public string database { get; set; }
        public string table { get; set; }
        public string data { get; set; }

        public TableInsert() { }

        public TableInsert(string database,string table, string data)
        {
            this.database = database;
            this.table = table;
            this.data = data;
        }
    }
}