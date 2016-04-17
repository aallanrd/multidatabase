using Modelo.ServicioWEB;
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
            conexion = new SQLConnect("root", "CAAC89", "DESKTOP-FV57AJ9", 1433, "CAAC89");
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

        //el crear no funciona todavia
        public string createDB(string database_name)
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {
                try
                {
                    string Query = "CREATE DATABASE [dbo.] " + database_name;

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
            SQLConnect conexion = new SQLConnect(model.username, model.pass, model.server, model.port, model.alias);
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

        public string createTable(string database_name, string table_name, string atributos)
        {


            string sCnn = "Server=" + "DESKTOP-FV57AJ9" + "; database=" + database_name + "; integrated security=yes";

           

            string sCmd = "CREATE TABLE [dbo]." + table_name +"(" +atributos+")";

            SqlConnection cnn = null;


            try
            {
                cnn = new SqlConnection(sCnn);
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sCmd, cnn);

                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                return "Error creando la tabla" + ex;

            }
            return "la tabla ha sido creado---";
        }


        public string deleteTable(string database_name, string table_name)
        {


            string sCnn = "Server=" + "DESKTOP-FV57AJ9" + "; database=" + database_name + "; integrated security=yes";
            string sCmd = "DROP TABLE [dbo]." + table_name;
            SqlConnection cnn = null;
            try
            {
                cnn = new SqlConnection(sCnn);
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sCmd, cnn);

                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                return "Error borrando la tabla" + ex;

            }
            return "la base de datos ha sido borrada---";
        }


        public string insertValuesTable(string database, string table, string data)
        {
            string sCnn = "Server=" + "DESKTOP-FV57AJ9" + "; database=" + database + "; integrated security=yes";



            string sCmd = "INSERT [dbo]." + table + "VALUES" +"(" + data + ")";

            SqlConnection cnn = null;


            try
            {
                cnn = new SqlConnection(sCnn);
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sCmd, cnn);

                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                return "Error creando la tabla" + ex;

            }
            return "la tabla ha sido creado---";

        }


    }
}