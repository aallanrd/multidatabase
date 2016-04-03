using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicioWEB.Controladores;
using Modelo.ServicioWEB;


namespace ServicioWEB.Controladores
{
    public class aMongoController
    {
        MongoConnect conexion;

        public aMongoController()
        {
            conexion = new MongoConnect();
            
        } 
        public string includeDB(dbModel m)
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {

                return "Connected";

            }

            else

            {
                
                conexion.CloseConnection();
                return "No hay conexion con la base de datos : metadata";
            }
           
        }

        public string consultDB()
        {
            try {
                conexion.start();
                return conexion.users.ToString();
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }

        public string createDB(String database_name)
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {
                try
                {
                    string Query = "CREATE DATABASE " + database_name + "";

                    //MySqlCommand cmd = new MySqlCommand(Query, conexion.connection);

                   // cmd.ExecuteNonQuery();
                    return "Insertada correctamente";
                }
                catch (Exception e)
                {
                    return "Error creando base de datos" + e;
                }


            }
            else
            {
                return "Error conectando a la BD";
            }

        }
    }



}