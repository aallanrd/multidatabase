using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;
using Modelo.ServicioWEB;

namespace ServicioWEB
{
    class MariaDBConnect 
    {
        private MySqlConnection connection;
      

        //Constructor
        public MariaDBConnect(string uid, string pass, string server, int port, string database)
        {
            Initialize(uid,pass,server,port,database);
        }

        //Initialize values
        public void Initialize(string uid, string pass, string server,int port,string database)
        {
         
            connection = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server="+server+ ";database=" + database + ";uid=" + uid + ";password=" + pass + "");
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
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
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

        //Insert statement
        public void Insert(dbModel db)
        {

        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
        public string Select()
        {
            string stm = "SELECT VERSION()";
            MySqlCommand cmd = new MySqlCommand(stm, connection);
            string version = Convert.ToString(cmd.ExecuteScalar());
            return("MySQL version : "   + version);


        }

        //Count statement
        public int Count()
        {
            return 0;
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}
