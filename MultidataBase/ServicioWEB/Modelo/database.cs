using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWEB.Modelo
{
    public class database
    {

        public int idC { get; set; }

        public string db_name { get; set; }
       
        public database() { }

        public database(int idC , string db_name)
        {
            this.db_name = db_name;
            this.idC = idC;
        }

    }
}