using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

//Aqui me toca bretear...

namespace ServicioWEB
{
    class MongoConnect
    {
        protected static MongoClient _client;
        

       // public MongoDB.Driver.ConnectionMode connection;
        
        public MongoConnect()
        {
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
