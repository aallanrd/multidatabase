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

        public string includeDB(string type, string user, string pass, string server,int port,string database)
        {
            dbModel model = new dbModel(type, user, pass, server,"tcp/ip", port, database);
            aMariaController control = new aMariaController();
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
