using ServicioWEB.Modelo;
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
        aMongoController controlMongo = new aMongoController();


        // Inserta (si esta disponible), una nueva conexión dentro 
        // de metadatadb
        public string includeDB(string jsonIDB)
        {
            /*
            *string type, string user, string pass, string server,int port,string database
            *Creamos un nuevo modelo de una base de datos a incluir.
            */

            // Deserializamos el JSOn en un modelo de base de datos
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
                    }

                case "MongoDB":
                    string cMo = controlMongo.check(model);
                    if (cMo.Equals("Connected"))
                    {
                        return controlMaria.includeDB(model);
                    }
                    else
                    {
                        return "No hay conexion con esta instancia de MongoDB ";
                    }


                case "SQLDB":
                    string cS = controlSQL.check(model);
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


        //Crear una nueva base de datos en cualquier servidor/instancia registrada
        public string createDB(string jsonCDB)
        {
           // string json = "{ 'cID': '1', 'db_name':'MiDB' }";

            //Deserializa el JSOn
            database db = JsonConvert.DeserializeObject<database>(jsonCDB);

            //Obtiene la conexión correspondiente
            dbModel  m  =  controlMaria.getConnection(db.idC);

            //String db_type,String db_name
            switch (m.dbType)
            {
                case "MariaDB": return controlMaria.createDB(m,db.db_name);

                case "MongoDB": return controlMongo.createDB(m,db.db_name);

                case "SQLDB":   return controlSQL.  createDB(m,db.db_name);

                default: return "No existe conexion posible con este tipo de DB";
            }
           

        }

        public string createTable(string jsonCT)
        {
            //int iC, string name, ArrayList columnas
            // string json = "{ 'cID': 'idConexion', 'table_name':'TableName', columnas:	[{ alias:	“alias”, nombre:“nombre”,tipo:  “tipo”, null:	true / false },...]}";
            table table = JsonConvert.DeserializeObject<table>(jsonCT);
            int idC = table.cID;
            string columnas = table.columnas;   
            var cll = JsonConvert.DeserializeObject<List<Modelo.column>>(columnas);

            dbModel model = controlMaria.getConnection(idC);
            if (model != null)
            {
                switch (model.dbType)
                {
                    case "MariaDB": return controlMaria.createTable(model,table.table_name,cll);
                    case "MongoDB": return controlMongo.createTable(model, table.table_name, cll);
                    case "SQLDB": return controlSQL.createTable(model, table.table_name, cll);
                    default: return "Cant Check";
                }

            }
            else
            {
                return "Not checked";
            }

            
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
