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

        aMariaController control = new aMariaController();

        public string createDB(String db_name)
        {
           return control.createDB(db_name);
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
           
            string b = control.consultDB();
            return b;
        }

        public string includeDB(string type, string user, string pass, string server,int port,string database)
        {
            //Creamos un nuevo modelo de una base de datos a incluir.
            dbModel model = new dbModel(type, user, pass, server,"tcp/ip", port, database);

            //Llamamos al metodo que esta en el controlador con el modelo respectivo.

            return control.includeDB(model);
          
           
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
