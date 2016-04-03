using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ServicioWEB
{
    class MongoConnect
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

       // public MongoDB.Driver.ConnectionMode connection;
        public MongoConnect()
        {

        }
        public MongoConnect(string uid, string pass, string server, int port, string database)
        {

        }
        public void start()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("test");
        }

        public string OpenConnection()
        {


            return "Opened";
        }


        //Close connection
        public bool CloseConnection()
        {
            try
            {
              //  connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
