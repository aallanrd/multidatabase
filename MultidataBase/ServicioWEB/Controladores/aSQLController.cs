﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicioWEB.Controladores;
using Modelo.ServicioWEB;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ServicioWEB.Controladores
{
    public class aSQLController
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
                    try { 
                    MySqlDataReader Reader = cmd.ExecuteReader();
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

               
                    // mariaDB.Insert(db);
                    string Query = "select * from  metadatadb.servidores";

                    MySqlCommand cmd = new MySqlCommand(Query, conexion.connection);
                    try
                    {
                        MySqlDataReader rdr = cmd.ExecuteReader();
                  //  int cont = 0;
                    string citationstexter = "{ 'servers' : ";
                        while (rdr.Read())
                        {
                        citationstexter = citationstexter + " {" + ("'db_type' : '"+ rdr.GetString(0) +"', 'usr' : '"+ rdr.GetString(1)+ "' , 'pass' : '" + rdr.GetString(2) + "', 'server' : '" + rdr.GetString(3) +  "', 'protocol' : '" + rdr.GetString(4)+ "' ,'port' : '" + rdr.GetInt32(5) + "', 'allias' : '" + rdr.GetString(6)+"' }, ");
                        //cont++;
                        }
                    rdr.Close();















































































                        conexion.CloseConnection();
                        return citationstexter;
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


    }



}