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

        //Para caso de ese SQL autetificacion
        public SQLConnect(string uid, string pass, string server, int port, string database)
        {
            Initialize(uid, pass, server, port, database);
        }
        


        

       //public void InitializeBD()
    //    {

  //          connection = new SqlConnection("Server=DESKTOP-FV57AJ9\\SQLEXPRESS;Database=master;Integrated Security=True ");
//        }
        //Para caso si de accesar con sql autentificacion
        public void Initialize(string uid, string pass, string server, int port, string database)
        {

            connection = new SqlConnection("Server=DESKTOP-FV57AJ9\\SQLEXPRESS;Database=master;Integrated Security=True ");


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
