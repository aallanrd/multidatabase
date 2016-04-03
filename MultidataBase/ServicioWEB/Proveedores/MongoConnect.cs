using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections;

namespace ServicioWEB
{
    class MongoConnect
    {
        protected static MongoClient _client;
    


        // public MongoDB.Driver.ConnectionMode connection;

        public MongoConnect()
        {
           // var credential = MongoCredential.CreateMongoCRCredential("allandb", "aallanrd", "abc1234");

          //  var settings = new MongoClientSettings
          //  {
          //      Credentials = new[] { credential }
          //  };

            // _client = new MongoClient(settings);
            _client = new MongoClient();
        }

        public ArrayList users = new ArrayList();

        public async void start()
        {
            //string conn = "mongodb://[aallanrd:abc1234@]localhost[:27017 ][/[local][?]]";
            // _client = new MongoClient(conn);
            await OpenConnection();
        }

        public async Task<string> OpenConnection()
        {

            var database = _client.GetDatabase("createDBX");

            //MongoServer server = _client.GetServer();
            //MongoDatabase db = server.GetDatabase("MyDatabase");

            if (database != null)
            {
                var collection = database.GetCollection<BsonDocument>("restaurants");

                var document = new BsonDocument
                        {
                            { "address" , new BsonDocument
                                {
                                    { "street", "2 Avenue" },
                                    { "zipcode", "10075" },
                                    { "building", "1480" },
                                    { "coord", new BsonArray { 73.9557413, 40.7720266 } }
                                }
                            },
                            { "borough", "Manhattan" },
                            { "cuisine", "Italian" },
                            { "grades", new BsonArray
                                {
                                    new BsonDocument
                                    {
                                        { "date", new DateTime(2014, 10, 1, 0, 0, 0, DateTimeKind.Utc) },
                                        { "grade", "A" },
                                        { "score", 11 }
                                    },
                                    new BsonDocument
                                    {
                                        { "date", new DateTime(2014, 1, 6, 0, 0, 0, DateTimeKind.Utc) },
                                        { "grade", "B" },
                                        { "score", 17 }
                                    }
                                }
                            },
                            { "name", "Vella" },
                            { "restaurant_id", "41704620" }
                        };


                await collection.InsertOneAsync(document);

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
