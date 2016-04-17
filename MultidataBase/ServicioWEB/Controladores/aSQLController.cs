using ServicioWEB.Modelo;
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

        public string createDB(dbModel db,string database_name)
        {
            conexion = new SQLConnect(db.username, db.pass, db.server, db.port, db.alias);
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

        //Crear una nueva tabla en una instancia de MariaDB
        public string createTable(dbModel db, string table_name, List<Modelo.column> array)
        {

            SQLConnect newConnection = new SQLConnect(db.username, db.pass, db.server, db.port, db.alias);
            if (newConnection.OpenConnection().Equals("Connected"))
            {
                try
                {
                    string colums = "( ";
                    int c = 0;
                    while (c != array.Count)
                    {
                        var x = array[c];
                        if (x.type.Equals("int")){
                            colums = colums + x.name + " " + x.type ;
                        }
                        else
                        {
                            colums = colums + x.name + " " + x.type + " (" + x.length + ")";
                        }
                        
                        if (c + 1 == array.Count)
                        {
                            break;
                        }
                        else
                        {
                            colums = colums + ",";
                        }
                        c++;
                    }
                    colums = colums + ")";
                    string Query = "create table " + table_name + colums;

                    SqlCommand cmd = new SqlCommand(Query, newConnection.connection);

                    cmd.ExecuteNonQuery();
                    return "{ 'msg':  'Insertada correctamente'}";
                }
                catch (Exception e)
                {
                    return "{ 'msg':  'Error insertando'}";
                }


            }
            else
            {
                return "Error conectando a la BD";
            }

        }

    }
}