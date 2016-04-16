using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWEB.Modelo
{
    public class tableInsert
    {
        public string database { get; set; }
        public string table { get; set; }
        public string data { get; set; }

        public tableInsert() { }

        public tableInsert(string database, string table, string data)
        {
            this.database = database;
            this.table = table;
            this.data = data;
        }
    }
}