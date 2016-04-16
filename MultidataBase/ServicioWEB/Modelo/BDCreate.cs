using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWEB.Modelo
{
    public class BDCreate
    {
        public string db_name { get; set; }
      

        public BDCreate() { }

        public BDCreate(string nombre)
        {
            this.db_name = nombre;
           
        }

    }
}