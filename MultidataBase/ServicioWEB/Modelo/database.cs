using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWEB.Modelo
{
    public class database
    {
        public string db_name { get; set; }
        public string db_type { get; set; }

        public database() { }

        public database(String nombre, string tipo)
        {
            this.db_name = nombre;
            this.db_type = tipo;
        }

    }
}