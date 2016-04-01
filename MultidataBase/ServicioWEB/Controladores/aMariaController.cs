using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicioWEB.Controladores;
using Modelo.ServicioWEB;

namespace ServicioWEB.Controladores
{
    public class aMariaController
    {
        MariaDBConnect conexion = new MariaDBConnect("root", "Ard2592allan", "localhost", 3306, "allandb");

        public string includeDB(dbModel m)
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {
                MariaDBConnect mariaDB = new MariaDBConnect(m.getUser(), m.getPass(), m.getServer(), m.getPort(), m.getAllias());
                mariaDB.OpenConnection();
                String x = mariaDB.Select();
                // mariaDB.Insert(db);

                 mariaDB.CloseConnection();
                return "Correctamente Insertado:" + x;
            }

            else
            {
                conexion.CloseConnection();
                return "InCorrectamente Insertado";
            }
           
        }

    }
}