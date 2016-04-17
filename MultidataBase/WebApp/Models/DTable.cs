using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class DTable
    {
        public int cID { get; set; }

        public string table_name { get; set; }

       
        public DTable() { }

        public DTable(int cID, string nombre)
        {
            this.cID = cID;
            this.table_name = nombre;
           
        }
    }
}