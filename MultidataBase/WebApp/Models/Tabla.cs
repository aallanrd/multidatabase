using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Tabla
    {
        public string database { get; set; }
        public string table_name { get; set; }

        public Tabla() { }

        public Tabla(string database, string table_name)
        {
            this.database = database;
            this.table_name = table_name;
        }
    }
}