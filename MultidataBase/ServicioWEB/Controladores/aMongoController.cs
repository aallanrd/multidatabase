using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicioWEB.Controladores;
using Modelo.ServicioWEB;
using MongoDB.Driver;

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
               return  conexion.OpenConnection();
              //  return conexion.users.ToString();
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }

        public  string createDB(String database_name)
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {
                try
                {

                    return conexion.createDB(database_name);
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

        internal string check(dbModel model)
        {
            try
            {
                var connectionString = "mongodb://"+model.username+":"+model.pass+"@"+model.server+"/"+model.alias;

                MongoClient mongoClient = new MongoClient(connectionString);
   
                return "Connected";
            }
            catch(Exception e){
                return "Cant Connect";
            }
        }
    }



}