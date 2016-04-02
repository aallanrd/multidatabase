
using Modelo.ServicioWEB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ServicioWEB
{
    interface InterfaceDB
    {
        string includeDB(string type, string user, string pass, string server, int port, string database);

        void createDB();

        void createTable();

        void deleteTable();

        void multipleQuery();

        void insertValuesTable();
        void updateValuesTable();

        string getConecctions();

    }
}
