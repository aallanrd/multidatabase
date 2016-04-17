using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWEB.Modelo
{
    public class table
    {

        public int cID { get; set; }

        public string table_name { get; set; }
      
        public string columnas { get; set; }

        public table() { }

        public table(int cID,string nombre, string columnas)
        {
            this.table_name = nombre;
            this.columnas = columnas;
        }

        
    }
}