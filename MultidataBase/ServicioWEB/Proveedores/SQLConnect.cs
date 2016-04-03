using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioWEB
{
    class SQLConnect : Multidatabase
    {

        public SqlConnection connection;
        public SQLConnect()
        {

        }

        public SQLConnect(string uid, string pass, string server, int port, string database)
        {

        }
        public string OpenConnection()
        {
            try
            {
                connection.Open();
                return "Connected";
            }
            catch (SqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        return ("Cannot connect to server.  Contact administrator");


                    case 1045:
                        return ("Invalid username/password, please try again");

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
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
