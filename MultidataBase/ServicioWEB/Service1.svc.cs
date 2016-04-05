
using Newtonsoft.Json;
using ServicioWEB.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace ServicioWEB
{
     
    public class Service1 : IService1
    {
        InterfaceDB dbx = new Multidatabase();

        public string includeDB(String jsonIDB)
        {
            //string type, string user, string pass, string server, int port, string db
            string include = dbx.includeDB(jsonIDB);
            return include;
        }

        public string createDatabase(string json_cD)
        {
           
            string create = dbx.createDB(json_cD);
            return create;
        }

        public string createTable(string json_cT)
        {
         
            string create = dbx.createTable(json_cT);
            return create;
        }

        public string checkConnection(int id)
        {
            string check = dbx.checkConnection(id);
            return check;
        }

        public string deleteTable(string jsonDT)
        {
            string delete = dbx.deleteTable(jsonDT);
            return delete;
        }

        public string multipleQuery(string jsonMQ)
        {
           string MQ =  dbx.multipleQuery(jsonMQ);
           return MQ;
        }

        public string insertValuesTable(string jsonIVT)
        {
            string insert = dbx.insertValuesTable( jsonIVT);
            return insert;
        }

        public string updateValuesTable(string jsonCD)
        {
            throw new NotImplementedException();
        }

        public string deleteValuesTable(string jsonCD)
        {
            throw new NotImplementedException();
        }

        public string getConnections()
        {
            string connections = dbx.getConecctions();
            return connections;
        }
    }
}
