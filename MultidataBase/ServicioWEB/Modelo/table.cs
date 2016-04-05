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
      
        public IList<string> columnas { get; set; }

        public table() { }

        public table(String nombre, IList<string> columnas)
        {
            this.table_name = nombre;
            this.columnas = columnas;
        }

        
    }
}