using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class TablaA
    {
        public string database { get; set; }
        public string table_name { get; set; }
        public string atributos { get; set; }

        public TablaA() { }

        public TablaA(string database, string table_name,string atributos)
        {
            this.database = database;
            this.table_name = table_name;
            this.atributos = atributos;
        }
    }
}