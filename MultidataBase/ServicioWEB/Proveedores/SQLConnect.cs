using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioWEB
{
    class SQLConnect 
    {

        public SqlConnection connection;


        public SQLConnect(string uid, string pass, string server, int port, string database)
        {
            Initialize(uid, pass, server, port, database);
        }

        public void Initialize(string uid, string pass, string server, int port, string database)
        {

            connection = new SqlConnection("Server="+server+";Database="+database+";Integrated Security=True ");


        }

        public string OpenConnection()
        {
            try {
              
                connection.Open();
                return "Connected";
            }
            catch (Exception e)
            {
                return "Can-t Connected";
            } 
        }

        public string CloseConnection()
        {
            connection.Close();
            throw new NotImplementedException();
        }
    }
}
