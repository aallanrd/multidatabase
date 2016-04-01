using Modelo.ServicioWEB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicioWEB
{
    class Multidatabase : InterfaceDB
    {
        public void createDB()
        {
            
        }

        public void createTable()
        {
            throw new NotImplementedException();
        }

        public void deleteTable()
        {
            throw new NotImplementedException();
        }

        public void getConecctions()
        {
            throw new NotImplementedException();
        }

        public bool includeDB(string type, string user, string pass, int port,string alias)
        {
            MariaDBConnect mariaDB = new MariaDBConnect();
            dbModel model = new dbModel(type, user, pass, "localhost", "tcp/ip", port, alias);
            mariaDB.Initialize(model.getUser(), model.getPass(), model.getServer(), "metadataDB");
            bool x = mariaDB.OpenConnection();

           // mariaDB.Insert(db);

            mariaDB.CloseConnection();
            return x;
        }

        public void insertValuesTable()
        {
            throw new NotImplementedException();
        }

        public void multipleQuery()
        {
            throw new NotImplementedException();
        }

        public void updateValuesTable()
        {
            throw new NotImplementedException();
        }
    }
}
