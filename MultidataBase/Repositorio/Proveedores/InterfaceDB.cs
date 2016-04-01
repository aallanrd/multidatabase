
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;

namespace Repositorio.Proveedores
{
    interface InterfaceDB
    {
        bool includeDB(Modelo.dbModel model);

        void createDB();

        void createTable();

        void deleteTable();

        void multipleQuery();

        void insertValuesTable();
        void updateValuesTable();
        void getConecctions();

    }
}
