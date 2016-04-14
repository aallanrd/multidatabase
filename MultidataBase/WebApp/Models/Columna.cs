using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Columna
    {
        public string nombreColumna { get; set; }
        public string typeColumna { get; set; }
        public int valorColumna { get; set; }


        public Columna() { }

        public Columna(string nombreColumna, string typeColumna, int valorColumna)
        {
            this.nombreColumna = nombreColumna;
            this.typeColumna = typeColumna;
            this.valorColumna = valorColumna;
        }
    }
}