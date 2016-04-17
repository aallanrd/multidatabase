using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;
using ServicioWEB.Modelo;

namespace ServicioWEB
{
    class MariaDBConnect 
    {
        public MySqlConnection connection;
      

        //Constructor
        public MariaDBConnect(string uid, string pass, string server, int port, string database)
        {
            Initialize(uid,pass,server,port,database);
        }

        public MariaDBConnect()
        {
        }

        //Initialize values
        public void Initialize(string uid, string pass, string server, int port, string database)
        {
           
                connection = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + pass + "");
            
        }

        //open connection to database
        public string OpenConnection()
        {
            try
            {
                connection.Open();
                return "Connected";
            }
            catch (MySqlException ex)
            {
               
                switch (ex.Number)
                {
                    case 0:
                        return("Cannot connect to server.  Contact administrator");
                     

                    case 1045:
                        return("Invalid username/password, please try again");

                    default:
                        return "Error";
                       
                }
               
            }
        }

        
        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

       
      

        
    }
}
