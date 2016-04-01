using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace ServicioWEB
{
     
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        InterfaceDB db = new Multidatabase();
        public bool includeDB(dbModel model)
        {
            bool b = false;
            db.includeDB(model);
            return b;
        }


        public string GetMariaData(int value, string table, string db)
        {
            return string.Format("You entered: {0}", value);
        }

        public aMariaTipo GetMariaDataUsingDataContract(aMariaTipo composite)
        {
            return composite;
        }
        public string GetSQLData(int value, string table, string db)
        {
            return string.Format("You entered: {0}", value);
        }

        public aMariaTipo GetSQLDataUsingDataContract(aMariaTipo composite)
        {
            return composite;
        }
        public string GetMongoData(int value, string table, string db)
        {
            return string.Format("You entered: {0}", value);
        }

        public aMariaTipo GetMongoDataUsingDataContract(aMariaTipo composite)
        {
            
            return composite;
        }
    }
}
