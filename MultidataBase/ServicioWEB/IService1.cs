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
        string includeDB(string jsonIDB);

        [OperationContract]
        string getConnections();

        [OperationContract]
        string createDatabase(string jsonCD);

        [OperationContract]
        string checkConnection(int cID);

        [OperationContract]
        string createTable(string jsonCD);

        [OperationContract]
        string deleteTable(string jsonDT);


        [OperationContract]
        string multipleQuery(string jsonCD);

        [OperationContract]
        string insertValuesTable(string jsonIVT);


        [OperationContract]
        string updateValuesTable(string jsonCD);

        [OperationContract]
        string deleteValuesTable(string jsonCD);


    }



}
