
using ServicioWEB.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ServicioWEB
{
    interface InterfaceDB
    {
        string includeDB            (string jsonIDB );

        string createDB             (string jsonCDB );

        string createTable          (string jsonCT  );

        string deleteTable          (string jsonDT  );

        string multipleQuery        (string jsonMQ  );

        string insertValuesTable    (string jsonIVT );

        string updateValuesTable    (string jsonUVT );

        string deleteValuesTable    (string jsonDVT );

        string getConecctions       (               );

        string checkConnection      (int cID        );
    }
}
