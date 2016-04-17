using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicioWEB.Controladores;
using ServicioWEB.Modelo;
using MongoDB.Driver;

namespace ServicioWEB.Controladores
{
    public class aMongoController
    {
        MongoConnect conexion;

        public aMongoController()
        {
           
            
        } 
        public string includeDB(dbModel m)
        {
            conexion = new MongoConnect(m.port,m.server);
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


        public  string createDB(dbModel m, string database_name)
        {
            conexion = new MongoConnect(m.port,m.server);
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

        public string check(dbModel model)
        {
            try
            {
               return consultDB(model);
   
               
            }
            catch(Exception e){
                return "Cant Connect";
            }
        }

        public string consultDB(dbModel m)
        {
            conexion = new MongoConnect(m.port, m.server);
            try
            {
               string x =  conexion.OpenConnection();
                if (x.Equals("Connected"))
                {
                    conexion.CloseConnection();
                }
                return x;

            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        internal string createTable(dbModel m, string table_name, List<column> cll)
        {
            conexion = new MongoConnect(m.port, m.server);
            try
            {
                string x = conexion.OpenConnection();
                if (x.Equals("Connected"))
                {
                    conexion.CloseConnection();
                }
                return x;

            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }



}