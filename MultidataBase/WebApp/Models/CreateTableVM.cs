using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class CreateTableVM

    {
        
        public int cID { get; set; }

        public string table_name { get; set; }

        public string columnas { get; set; }

        public CreateTableVM() { }

        public CreateTableVM(int cID, string nombre, string columnas)
        {
            this.cID = cID;
            this.table_name = nombre;
            this.columnas = columnas;
        }

    }
}