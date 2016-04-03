using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace ServicioWEB
{
     
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        InterfaceDB dbx = new Multidatabase();

        public string includeDB(string type, string user, string pass, string server, int port, string db)
        {
            string include = dbx.includeDB(type, user, pass,server, port, db);
            return include;
        }

        public string getConnections()
        {
            string connections = dbx.getConecctions();
            return connections;
        }

        public string createDatabase(string db_name,string db_type)
        {
            string create = dbx.createDB(db_name,db_type);
            return create;
        }

        public string checkMongoConnection()
        {
            string checkMongo = dbx.checkMongoConnection();
            return checkMongo;
        }

        public string checkSQLConnection()
        {
            string checkSQL = dbx.checkSQLConnection();
            return checkSQL;
        }
    }
}
