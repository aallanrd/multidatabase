using Modelo.ServicioWEB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioWEB.Controladores;

namespace ServicioWEB
{
    class Multidatabase : InterfaceDB
    {

        SQLController controlSQL = new SQLController();
        aMariaController controlMaria = new aMariaController();
        aMongoController controlMongo = new aMongoController();
        


        public string createDB(String db_type,String db_name)
        {
            switch (db_type)
            {
                case "MariaDB": return controlMaria.createDB(db_name);
                case "MongoDB": return controlMongo.createDB(db_name);
                case "SQLDB":   return controlSQL.createDB(db_name);
                default: return "No existe conexion posible con este tipo de DB";
            }
           

        }

        public void createTable()
        {
            throw new NotImplementedException();
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

        public string includeDB(string type, string user, string pass, string server,int port,string database)
        {
            //Creamos un nuevo modelo de una base de datos a incluir.
            dbModel model = new dbModel(type, user, pass, server,"tcp/ip", port, database);

            //Llamamos al metodo que esta en el controlador con el modelo respectivo.

             return controlMaria.includeDB(model);
           // return "Connected";
          
           
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

        public string checkConnection(int connectionID) 
        {
            dbModel model =  controlMaria.getConnection(connectionID);
            if (model != null)
            {
                switch (model.getDBType())
                {
                    // case "MariaDB": checkMariaDBConnection();
                    case "MongoDB": return checkMongoConnection();
                    case "SQLDB": return checkSQLConnection();
                    default: return "Cant Check";
                }
               
            }
            else
            {
                return "Not checked";
            }
           
        }
        public string checkMongoConnection()
        {
             return controlMongo.consultDB();
           // return "Connected";
        }

        public string checkSQLConnection()
        {
            return controlSQL.consultDB();
            // return "Connected";
        }
    }
}
