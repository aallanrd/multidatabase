using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWEB.Modelo
{
    public class table
    {

        public string table_name { get; set; }
        public string database { get; set; }


        public table() { }

        public table(string database, string table_name)
        {
            this.database = database;
            this.table_name = table_name;

        }


    }
}