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
            var credential = MongoCredential.CreateMongoCRCredential("allandb", "aallanrd", "abc1234");

            var settings = new MongoClientSettings
            {
                Credentials = new[] { credential }
            };

             _client = new MongoClient(settings);
        }
        public  void start()
        {
            //string conn = "mongodb://[aallanrd:abc1234@]localhost[:27017 ][/[local][?]]";
           // _client = new MongoClient(conn);

        }

        public string OpenConnection()
        {
            var database = _client.GetDatabase("allandb");
            if (database!=null)
            {
                var collection = database.GetCollection<BsonDocument>("persons");

                if (collection != null)
                {
                    return "Connected";
                }
                else {
                    return "Not Retrieve Info of persons";
                }
            }
            else
            {
                return "Cant Get Database";
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
