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
        protected static MongoClient _client;
        

       // public MongoDB.Driver.ConnectionMode connection;
        
        public MongoConnect()
        {
           
        }
        public  void start()
        {
            _client = new MongoClient();

        }

        public string OpenConnection()
        {

            var database = _client.GetDatabase("allandb");
            var collection = database.GetCollection<BsonDocument>("persons");

            if (collection != null)
            {
                return "Connected";
            }
            else{
                return "Not Retrieve Info";
            }

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
