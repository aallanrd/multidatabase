using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicioWEB.Controladores;
using ServicioWEB.Modelo;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections;
using Newtonsoft.Json;

namespace ServicioWEB.Controladores
{
    public class aMariaController
    {

        // Instancia Fija para Metadata
        MariaDBConnect conexion = new MariaDBConnect("root", "Ard2592allan", "localhost", 3306, "metadatadb");


        //Inserta en la base de datos de metadata una nueva conexión. 
        public string includeDB(dbModel m)
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {
                
                    string Query = "insert into metadatadb.servidores(database_type,user,pass,server,protocol,port,alias) values('"
                    + m.dbType + "','" + m.username + "','" + m.pass + "','" + m.server + "','" + m.protocol + "','" +
                    m.port+ "','" + m.alias + "');";

                    MySqlCommand cmd = new MySqlCommand(Query, conexion.connection);

                    try
                    {
                        cmd.ExecuteNonQuery();

                        conexion.CloseConnection();

                       return "{ 'msg':  'Insertada correctamente'}";
                    }
                    catch (Exception e)
                    {
                    return "{ 'msg':  'Error Insertando'}";
                }
                
              

            }

            else

            {


                conexion.CloseConnection();
                return "No hay conexion con la base de datos : metadata";
            }

        }

        //Retorna en un string-JSON las conexiones existentes en metadatadb de MariaDB.
        public string consultDB()
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {
                
                string Query = "select * from  metadatadb.servidores";
                MySqlCommand cmd = new MySqlCommand(Query, conexion.connection);
                
                try
                {
                    ArrayList objs = new ArrayList();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        objs.Add(new
                        {
                            db_type = rdr.GetString (0),  usr = rdr.GetString   (1),
                            pass = rdr.GetString    (2),  server = rdr.GetString(3),
                            protocol = rdr.GetString(4),  port = rdr.GetString  (5),
                            allias = rdr.GetString  (6),  id = rdr.GetString    (7)

                        });
                     
                    }
         
                    rdr.Close();
                    conexion.CloseConnection();
                    // -- Serializa todos los objetos obtenidos de la base a JSON.
                    var json = JsonConvert.SerializeObject(objs, Formatting.Indented);
                    return json;
                  
                }
                catch (Exception e)
                {
                    return "{ 'error': '" + e + "'}";
                }
            }

            else
            {
                return ("No hay conexion con la base de datos");
            }
        }

        //Crear una nueva Base de Datos en una instancia seleccionada 
        public string createDB(dbModel m, string database_name)
        {
            MariaDBConnect newConnection = new MariaDBConnect(m.username, m.pass, m.server, m.port, m.alias);
            if (newConnection.OpenConnection().Equals("Connected"))
            {
                try
                {
                    string Query = "CREATE DATABASE " + database_name + "";

                    MySqlCommand cmd = new MySqlCommand(Query, newConnection.connection);

                    cmd.ExecuteNonQuery();
                    return "{ 'msg':  'Insertada correctamente'}";
                }
                catch (Exception e)
                {
                    return "'msg': 'Error creando base de datos', 'error': '" + e + "'}" ;
                }
            }
            else
            {
                return "{ 'msg':  'Error al abrir instancia de BD'}";
            }

        }

        //Crear una nueva tabla en una instancia de MariaDB
        public string createTable(dbModel db, string table_name, List<Modelo.column> array)
        {

            MariaDBConnect newConnection = new MariaDBConnect(db.username,db.pass,db.server,db.port,db.alias);
            if (newConnection.OpenConnection().Equals("Connected"))
            {
                try
                {
                    string colums = "( ";
                    int c = 0;
                    while (c != array.Count)
                    {
                        var x = array[c];
                        colums = colums + x.name + " " + x.type + " (" + x.length + ")";
                        if(c+1 == array.Count)
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

                    MySqlCommand cmd = new MySqlCommand(Query, newConnection.connection);

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

        //Obtener una conexión específica por Identificador de Conexión.
        public dbModel getConnection(int cID)
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {

                string Query = "select * from  metadatadb.servidores";

                MySqlCommand cmd = new MySqlCommand(Query, conexion.connection);

                ArrayList objs = new ArrayList();
                //cmd.ExecuteNonQuery();
                try
                {
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dbModel model = null;
                    while (rdr.Read())
                    {
                        int z = rdr.GetInt32(7);
                        if (z == cID)
                        {
                            string db_type = rdr.GetString(0);
                            string usr = rdr.GetString(1);
                            string pass = rdr.GetString(2);
                            string server = rdr.GetString(3);
                            string protocol = rdr.GetString(4);
                            int port = rdr.GetInt32(5);
                            string allias = rdr.GetString(6);
                            string id = rdr.GetString(7);
                            model = new dbModel(
                                db_type, usr, pass, server, protocol, port, allias);
                            return model;
                        }


                    }
                    rdr.Close();
                    conexion.CloseConnection();
                    return model;
                }
                catch (Exception e)
                {
                    return null;
                }
            }

            else
            {
                return null;
            }
        }

        //Chequear que existe una conexion posible de mariaDB con el modelo del parámetro.
        public string check(dbModel model)
        {

            MariaDBConnect cc = new MariaDBConnect(model.username, model.pass, model.server, model.port, model.alias);
            if (cc.OpenConnection().Equals("Connected"))
            {
                return "Connected";
            }
            else
            {
                return "Cant connect";
            }


        }

    }

}