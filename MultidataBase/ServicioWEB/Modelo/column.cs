using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWEB.Modelo
{
   

    public class column
    {
        public string name { get; set; }
        public string type { get; set; }

        public int length { get; set; }

        public column()
        {

        }

        public column(string name, string type, int length)
        {
            this.name = name;
            this.type = type;
            this.length = length;
        }
    }
}