using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections;

using FluentAssertions;


//Prueba

namespace ServicioWEB
{
    class MongoConnect
    {
        protected static MongoClient _client;
    


        // public MongoDB.Driver.ConnectionMode connection;

        public MongoConnect()
        {
|//<<<<<<< HEAD
            //MongoUrl url = new MongoUrl("mongodb://localhost");
            MongoClient mc = new MongoClient("mongodb://localhost");
            MongoServer mongo = mc.GetServer();
            MongoDatabase db = mongo.GetDatabase("test"); //Aqui se ingresa el nombre de la base de datos
            var cols = db.GetCollectionNames(); //Variable para guardar los nombres de las colecciones

            foreach(string col in cols)
            {
                Console.WriteLine(col); //Ver colecciones de la base de datos
            }
            Console.ReadLine();
//=======
           // var credential = MongoCredential.CreateMongoCRCredential("allandb", "aallanrd", "abc1234");

          //  var settings = new MongoClientSettings
          //  {
          //      Credentials = new[] { credential }
          //  };

            // _client = new MongoClient(settings);
            _client = new MongoClient();
//>>>>>>> origin/master
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

            var database = _client.GetDatabase("allandb");

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

        public void mostrarTabla(string x,string y) 

        {
            var database = _client.GetDatabase(x);
          
            var collection = database.GetCollection<BsonDocument>("allandb");
            var filter = new BsonDocument();
            var count = 0;
            using (var cursor = collection.FindAsync(filter))
            {
                while (cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        // process document
                        count++;
                    }
                }
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
