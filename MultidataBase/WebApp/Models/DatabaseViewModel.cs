using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class DatabaseViewModel
    {
        public int idC { get; set; }

        public string db_name { get; set; }

        public DatabaseViewModel() { }

        public DatabaseViewModel(int idC, string db_name)
        {
            this.db_name = db_name;
            this.idC = idC;
        }
    }
}