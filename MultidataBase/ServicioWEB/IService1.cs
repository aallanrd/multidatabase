using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace ServicioWEB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string includeDB(string type, string user, string pass, int port, string alias);

        [OperationContract]
        string GetMariaData(int value, string table, string db);

        [OperationContract]
        aMariaTipo GetMariaDataUsingDataContract(aMariaTipo tipo);

        // TODO: Add your service operations here

        [OperationContract]
        string GetSQLData(int value, string table, string db);

        [OperationContract]
        aMariaTipo GetSQLDataUsingDataContract(aMariaTipo tipo);

        [OperationContract]
        string GetMongoData(int value, string table, string db);

        [OperationContract]
        aMariaTipo GetMongoDataUsingDataContract(aMariaTipo tipo);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Servicio.ContractType".
    [DataContract]
    public class aMariaTipo
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
