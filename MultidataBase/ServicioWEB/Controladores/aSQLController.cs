using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicioWEB.Controladores;
using Modelo.ServicioWEB;
using System.Data.SqlClient;

namespace ServicioWEB.Controladores
{
    public class aSQLController
    {
        SQLConnect conexion = new SQLConnect("root", "Ard2592allan", "localhost", 3306, "metadatadb");

        public string includeDB(dbModel m)
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {
                
                SQLConnect mariaDB = new SQLConnect(m.getUser(), m.getPass(), m.getServer(), m.getPort(), m.getAllias());
                if (conexion.OpenConnection().Equals("Connected"))
                {

                    // mariaDB.Insert(db);
                    string Query = "insert into metadatadb.servidores(database_type,user,pass,server,protocol,port,alias) values('"
                    + m.getDBType() + "','" + m.getUser() + "','" + m.getPass() + "','" + m.getServer() + "','" + m.getProtocol() + "','" +
                    m.getPort() + "','" + m.getAllias() + "');";

                    SqlCommand cmd = new SqlCommand(Query);
                    cmd.ExecuteNonQuery();
                    try { 
                    SqlDataReader Reader = cmd.ExecuteReader();
                    int loopReading = 0;
                    string citationstexter = "";
                    while (Reader.Read()) // this part is wrong somehow
                    {
                        citationstexter += Reader.GetString(loopReading); // this works
                        loopReading++; // this works
                    }
                    Reader.Close();

                    conexion.CloseConnection();
                    return citationstexter;
                    }
                    catch(Exception e){
                        return "Error insertando" + e;
                    }
                }
                else
                {
                    return( "No hay conexion con la base de datos" + m.getAllias());
                }

            }

            else

            {

                
                conexion.CloseConnection();
                return "No hay conexion con la base de datos : metadata";
            }
           
        }

        public string consultDB()
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {

                try { 
                    // mariaDB.Insert(db);
                    string Query = "select * from  metadatadb.servidores";

                    SqlCommand cmd = new SqlCommand(Query);
                    cmd.ExecuteNonQuery();

                        conexion.CloseConnection();
                        return "Correcto";
                    }
                    catch (Exception e)
                    {
                        return "Error leyendo" + e;
                    }
                }

          else
                {
                    return ("No hay conexion con la base de datos" );
                }
        }

        public string createDB(String database_name)
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {
                try
                {
                    string Query = "CREATE DATABASE " + database_name + "";

                    SqlCommand cmd = new SqlCommand(Query);

                    cmd.ExecuteNonQuery();
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