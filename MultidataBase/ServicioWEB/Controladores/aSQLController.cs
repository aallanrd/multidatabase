﻿using Modelo.ServicioWEB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServicioWEB.Controladores
{
    public class aSQLController 
    {

        SQLConnect conexion;
        public aSQLController()
        {
            conexion = new SQLConnect("root", "Ard2592allan", "DESKTOP-6Q1Q92A", 1433, "aallanrd");
        }
        public aSQLController(string uid, string pass, string server, int port, string database)
        {
            conexion = new SQLConnect( uid,  pass,  server,  port,  database);
        }


       
        public string consultDB()
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {

                try
                {
                    // mariaDB.Insert(db);
                 //   string Query = "select * from  metadatadb.servidores";

                   // SqlCommand cmd = new SqlCommand(Query);
                   // cmd.ExecuteNonQuery();

                    //conexion.CloseConnection();
                    return "Correcto SQL";
                }
                catch (Exception e)
                {
                    return "Error leyendo" + e;
                }
            }

            else
            {
                return ("No hay conexion con la base de datos");
            }
        }

        public string createDB(String database_name)
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {
                try
                {
                    string Query = "CREATE DATABASE " + database_name + "";

                    SqlCommand cmd = new SqlCommand(Query,conexion.connection);

                    cmd.ExecuteNonQuery();
                    //conexion.CloseConnection();
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

        internal string check(dbModel model)
        {
            SQLConnect conexion = new SQLConnect(model.getUser(), model.getPass(), model.getServer(), model.getPort(), model.getAllias());
            try
            {
                if (conexion.OpenConnection().Equals("Connected"))
                {
                    return "Connected";
                }
                else
                {
                    return "Cant- connect";
                }
            }
            catch(Exception e)
            {
                return "Cant- connect";
            }
        }
    }
}