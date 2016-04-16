using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWEB.Modelo
{
    public class tableA
    {
        public string table_name { get; set; }
        public string database { get; set; }
        public string atributos { get; set; }


        public tableA() { }

        public tableA(string database, string table_name,string atributos)
        {
            this.database = database;
            this.table_name = table_name;
            this.atributos = atributos;

        }
    }
}