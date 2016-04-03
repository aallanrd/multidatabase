using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWEB.Modelo
{
    public class User
    {
        string name;
        string id;

        public User()
        {

        }
        public User(string name , string id)
        {
            this.name = name;
            this.id = id;
        }
    }
}