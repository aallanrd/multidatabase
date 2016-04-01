
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
        bool includeDB(string type, string user, string pass, int port, string alias);

        void createDB();

        void createTable();

        void deleteTable();

        void multipleQuery();

        void insertValuesTable();
        void updateValuesTable();
        void getConecctions();

    }
}
