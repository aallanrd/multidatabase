using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections;

//Prueba

namespace ServicioWEB
{
    class MongoConnect
    {
        protected static MongoClient _client;
    


        // public MongoDB.Driver.ConnectionMode connection;

        public MongoConnect()
        {

           
            _client = new MongoClient();

        }

        public ArrayList users = new ArrayList();

        public  void start()
        {
            //string conn = "mongodb://[aallanrd:abc1234@]localhost[:27017 ][/[local][?]]";
            // _client = new MongoClient(conn);
             OpenConnection();
        }

        //ABre una conexion y crea una base de datos :D
        public  string  OpenConnection()
        {

            var database = _client.GetDatabase("test");

            //MongoServer server = _client.GetServer();
            //MongoDatabase db = server.GetDatabase("MyDatabase");

            if (database != null)
            {
               
               return "Connected";
             
            }
            else
            {
                return "Cant Get Database";
            }


        }

       

        public string createDB(string x)
        {

            var database = _client.GetDatabase(x);

            //MongoServer server = _client.GetServer();
            //MongoDatabase db = server.GetDatabase("MyDatabase");

            if (database != null)
            {
                var collection = database.GetCollection<BsonDocument>("test");

                var document = new BsonDocument
                        {
                            
                            { "DBLOg", "Created" },
                         
                        };


                 collection.InsertOneAsync(document);

                if (collection != null)
                {
                    return "Creada Correctamente";
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


        public string createTabla(string x)
        {

            var database = _client.GetDatabase("Gerardo");

            //MongoServer server = _client.GetServer();
            //MongoDatabase db = server.GetDatabase("MyDatabase");

            if (database != null)
            {
                var collection = database.GetCollection<BsonDocument>(x);

                var document = new BsonDocument
                        {

                            { "DBLOg", "Created" },

                        };


                collection.InsertOneAsync(document);

                if (collection != null)
                {
                    return "Creada Correctamente";
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

        public string dropCollection(String database_name, String collection_name)
        {
            var database = _client.GetDatabase(database_name);

            if (database != null)
            {
                database.DropCollection(collection_name);
                return "Coleccion borrada...";
            }
            else
                return "Error";

        }

        //Algoritmo en desarrollo........ Le falta bastante
        public string insertinCollection(String database_name, String collection_name, String elemento)
        {
            var database = _client.GetDatabase(database_name);

            if (database != null)
            {
                var collection = database.GetCollection<String>(collection_name);

               // Symbol symbol = new Symbol();
               // symbol.Name = "Star";
                collection.InsertOneAsync(elemento);

                return "Inserción exitosa.....";
            }
            else
                return "Error";





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
