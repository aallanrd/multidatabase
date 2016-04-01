using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Modelo;

namespace Repositorio.Proveedores
{
    class Multidatabase : InterfaceDB
    {
        public bool createDB()
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

        public bool includeDB(Modelo.dbModel db)
        {
            MariaDBConnect mariaDB = new MariaDBConnect();
            mariaDB.Initialize(db.getUser(), db.getPass(), "localhost", "metadataDB");
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
