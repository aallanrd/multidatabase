using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicioWEB.Controladores;
using Modelo.ServicioWEB;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections;
using Newtonsoft.Json;

namespace ServicioWEB.Controladores
{
    public class aMariaController
    {
        MariaDBConnect conexion = new MariaDBConnect("root", "Ard2592allan", "localhost", 3306, "metadatadb");

        public string includeDB(dbModel m)
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {

                MariaDBConnect mariaDB = new MariaDBConnect(m.getUser(), m.getPass(), m.getServer(), m.getPort(), m.getAllias());
                if (mariaDB.OpenConnection().Equals("Connected"))
                {

                    // mariaDB.Insert(db);
                    string Query = "insert into metadatadb.servidores(database_type,user,pass,server,protocol,port,alias) values('"
                    + m.getDBType() + "','" + m.getUser() + "','" + m.getPass() + "','" + m.getServer() + "','" + m.getProtocol() + "','" +
                    m.getPort() + "','" + m.getAllias() + "');";

                    MySqlCommand cmd = new MySqlCommand(Query, conexion.connection);
                   
                    try
                    {
                        cmd.ExecuteNonQuery();

                        conexion.CloseConnection();
                        return "Insertado correctamente";
                    }
                    catch (Exception e)
                    {
                        return "Error insertando" + e;
                    }
                }
                else
                {
                    return ("No hay conexion con la base de datos" + m.getAllias());
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


                // mariaDB.Insert(db);
                string Query = "select * from  metadatadb.servidores";

                MySqlCommand cmd = new MySqlCommand(Query,conexion.connection);

                ArrayList objs = new ArrayList();
                //cmd.ExecuteNonQuery();
                try
                {
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    //  int cont = 0;
                  //  string citationstexter = "[";
                    while (rdr.Read())
                    {
                        objs.Add(new
                        {
                            db_type = rdr.GetString(0),
                            usr = rdr.GetString(1),
                            pass = rdr.GetString(2),
                            server = rdr.GetString(3),
                            protocol = rdr.GetString(4),
                            port = rdr.GetString(5),
                            allias = rdr.GetString(6),
                            id = rdr.GetString(7)

                        });
                        //      citationstexter = citationstexter  + ("{ 'db_type' : '" + rdr.GetString(0) + "',   'usr' : '" + rdr.GetString(1) + "' , 'pass' : '" + rdr.GetString(2) + "',  'server' : '" + rdr.GetString(3) + "', 'protocol' : '" + rdr.GetString(4) + "'        ,'port' : '" + rdr.GetInt32(5) + "', 'allias' : '" + rdr.GetString(6) + "' }, ");
                        //cont++;
                    }
                  //  citationstexter = citationstexter + "]";
                    rdr.Close();
                    conexion.CloseConnection();
                    return  JsonConvert.SerializeObject(objs);
                   
                   // return citationstexter;
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

                    MySqlCommand cmd = new MySqlCommand(Query, conexion.connection);

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

        

        public dbModel getConnection(int cID)
        {
            if (conexion.OpenConnection().Equals("Connected"))
            {


                // mariaDB.Insert(db);
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
                    //  citationstexter = citationstexter + "]";
                  
                    
               
                    // return citationstexter;
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


    }



}