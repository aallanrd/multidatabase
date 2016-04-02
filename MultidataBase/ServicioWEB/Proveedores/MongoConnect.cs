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

        public void start()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("test");
        }
     
    }
}
