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

        aSQLController controlSQL = new aSQLController();
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
           
                switch (model.getDBType())
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
                    case "MariaDB": return controlMaria.check(model);
                    case "MongoDB": return controlMongo.check(model);
                    case "SQLDB": return controlSQL.check(model);
                    default: return "Cant Check";
                }
               
            }
            else
            {
                return "Not checked";
            }
           
        }
       
      

     
    }
}
