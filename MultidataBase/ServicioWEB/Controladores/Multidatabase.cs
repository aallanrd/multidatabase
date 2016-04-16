using Modelo.ServicioWEB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioWEB.Controladores;
using System.Collections;
using Newtonsoft.Json;

namespace ServicioWEB
{
    class Multidatabase : InterfaceDB
    {

        aSQLController controlSQL = new aSQLController();
        aMariaController controlMaria = new aMariaController();
        //aMongoController controlMongo = new aMongoController();
        


        public string createDB(string jsonCDB)
        {
           // string json = "{ 'db_name': 'database', 'db_type':'type' }";

            Modelo.database db = JsonConvert.DeserializeObject<Modelo.database>(jsonCDB);
            string db_name = db.db_name;
            string db_type = db.db_type;
            //String db_type,String db_name
            switch (db_type)
            {
                case "MariaDB": return controlMaria.createDB(db_name);
               // case "MongoDB": return controlMongo.createDB(db_name);
                case "SQLDB":   return controlSQL.createDB(db_name);
                default: return "No existe conexion posible con este tipo de DB";
            }
           

        }

        public string createTable(string jsonCT)
        {
            //int iC, string name, ArrayList columnas
            // string json = "{ 'cID': 'idConexion', 'table_name':'TableName', columnas:	[{ alias:	“alias”, nombre:“nombre”,tipo:  “tipo”, null:	true / false },...]}";
             Modelo.table table = JsonConvert.DeserializeObject<Modelo.table>(jsonCT);
            IList<string> idC = table.columnas;
            string tName = table.table_name;
             
            return "Table Created";

        }

        public void deleteTable()
        {
            throw new NotImplementedException();
        }

        public string getConecctions()
        {

              string b = controlMaria.consultDB();
              return b;
            //return "Connected";
        }

        public string includeDB(string jsonIDB)
        {
            //string type, string user, string pass, string server,int port,string database
            //string db_type, string user, string pass, string server, int port, string allias
            //Creamos un nuevo modelo de una base de datos a incluir.
            // dbModel model = new dbModel(type, user, pass, server,"tcp/ip", port, database);
            dbModel model = JsonConvert.DeserializeObject<dbModel>(jsonIDB);

            switch (model.dbType)
                {
                    case "MariaDB":
                        string cMa = controlMaria.check(model);
                        if (cMa.Equals("Connected"))
                        {
                            return controlMaria.includeDB(model);
                        }
                    else
                    {
                        return "No hay conexion con esta instancia de MariaDB ";
                    }/*
                    
                    case "MongoDB":
                        string cMo = controlMongo.check(model);
                        if (cMo.Equals("Connected"))
                        {
                            return controlMaria.includeDB(model);
                        }
                    else
                    {
                        return "No hay conexion con esta instancia de MongoDB ";
                    }*/


                case "SQLDB":
                        string cS  = controlSQL.check(model);
                        if (cS.Equals("Connected"))
                        {
                            return controlMaria.includeDB(model);
                        }
                    else
                    {
                        return "No hay conexion con esta instancia de SQLDB ";
                    }


                default: return "Cant Check";
                }
           
        }

     

        public string checkConnection(int connectionID) 
        {
            dbModel model =  controlMaria.getConnection(connectionID);
            if (model != null)
            {
                switch (model.dbType)
                {
                    case "MariaDB": return controlMaria.check(model);
                    //case "MongoDB": return controlMongo.check(model);
                    case "SQLDB": return controlSQL.check(model);
                    default: return "Cant Check";
                }
               
            }
            else
            {
                return "Not checked";
            }
           
        }

      

        public string deleteTable(string jsonDT)
        {
            throw new NotImplementedException();
        }

        public string multipleQuery(string jsonMQ)
        {
            throw new NotImplementedException();
        }

        public string insertValuesTable(string jsonIVT)
        {
            throw new NotImplementedException();
        }

        public string updateValuesTable(string jsonUVT)
        {
            throw new NotImplementedException();
        }

        public string deleteValuesTable(string jsonUVT)
        {
            throw new NotImplementedException();
        }
    }
}
