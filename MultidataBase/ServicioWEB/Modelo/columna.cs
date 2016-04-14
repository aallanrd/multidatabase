using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWEB.Modelo
{
    public class columna
    {
        public string nombreColumna { get; set; }
        public string typeColumna { get; set; }
        public int valorColumna { get; set; }


        public columna() { }

        public columna(string nombreColumna, string typeColumna, int valorColumna)
        {
            this.nombreColumna = nombreColumna;
            this.typeColumna = typeColumna;
            this.valorColumna = valorColumna;
        }
    }
}