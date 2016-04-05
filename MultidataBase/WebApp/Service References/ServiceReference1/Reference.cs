﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/includeDB", ReplyAction="http://tempuri.org/IService1/includeDBResponse")]
        string includeDB(string jsonIDB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/includeDB", ReplyAction="http://tempuri.org/IService1/includeDBResponse")]
        System.Threading.Tasks.Task<string> includeDBAsync(string jsonIDB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getConnections", ReplyAction="http://tempuri.org/IService1/getConnectionsResponse")]
        string getConnections();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getConnections", ReplyAction="http://tempuri.org/IService1/getConnectionsResponse")]
        System.Threading.Tasks.Task<string> getConnectionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createDatabase", ReplyAction="http://tempuri.org/IService1/createDatabaseResponse")]
        string createDatabase(string jsonCD);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createDatabase", ReplyAction="http://tempuri.org/IService1/createDatabaseResponse")]
        System.Threading.Tasks.Task<string> createDatabaseAsync(string jsonCD);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkConnection", ReplyAction="http://tempuri.org/IService1/checkConnectionResponse")]
        string checkConnection(int cID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkConnection", ReplyAction="http://tempuri.org/IService1/checkConnectionResponse")]
        System.Threading.Tasks.Task<string> checkConnectionAsync(int cID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createTable", ReplyAction="http://tempuri.org/IService1/createTableResponse")]
        string createTable(string jsonCD);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createTable", ReplyAction="http://tempuri.org/IService1/createTableResponse")]
        System.Threading.Tasks.Task<string> createTableAsync(string jsonCD);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteTable", ReplyAction="http://tempuri.org/IService1/deleteTableResponse")]
        string deleteTable(string jsonDT);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteTable", ReplyAction="http://tempuri.org/IService1/deleteTableResponse")]
        System.Threading.Tasks.Task<string> deleteTableAsync(string jsonDT);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/multipleQuery", ReplyAction="http://tempuri.org/IService1/multipleQueryResponse")]
        string multipleQuery(string jsonCD);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/multipleQuery", ReplyAction="http://tempuri.org/IService1/multipleQueryResponse")]
        System.Threading.Tasks.Task<string> multipleQueryAsync(string jsonCD);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertValuesTable", ReplyAction="http://tempuri.org/IService1/insertValuesTableResponse")]
        string insertValuesTable(string jsonIVT);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertValuesTable", ReplyAction="http://tempuri.org/IService1/insertValuesTableResponse")]
        System.Threading.Tasks.Task<string> insertValuesTableAsync(string jsonIVT);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateValuesTable", ReplyAction="http://tempuri.org/IService1/updateValuesTableResponse")]
        string updateValuesTable(string jsonCD);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateValuesTable", ReplyAction="http://tempuri.org/IService1/updateValuesTableResponse")]
        System.Threading.Tasks.Task<string> updateValuesTableAsync(string jsonCD);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteValuesTable", ReplyAction="http://tempuri.org/IService1/deleteValuesTableResponse")]
        string deleteValuesTable(string jsonCD);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteValuesTable", ReplyAction="http://tempuri.org/IService1/deleteValuesTableResponse")]
        System.Threading.Tasks.Task<string> deleteValuesTableAsync(string jsonCD);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApp.ServiceReference1.IService1>, WebApp.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string includeDB(string jsonIDB) {
            return base.Channel.includeDB(jsonIDB);
        }
        
        public System.Threading.Tasks.Task<string> includeDBAsync(string jsonIDB) {
            return base.Channel.includeDBAsync(jsonIDB);
        }
        
        public string getConnections() {
            return base.Channel.getConnections();
        }
        
        public System.Threading.Tasks.Task<string> getConnectionsAsync() {
            return base.Channel.getConnectionsAsync();
        }
        
        public string createDatabase(string jsonCD) {
            return base.Channel.createDatabase(jsonCD);
        }
        
        public System.Threading.Tasks.Task<string> createDatabaseAsync(string jsonCD) {
            return base.Channel.createDatabaseAsync(jsonCD);
        }
        
        public string checkConnection(int cID) {
            return base.Channel.checkConnection(cID);
        }
        
        public System.Threading.Tasks.Task<string> checkConnectionAsync(int cID) {
            return base.Channel.checkConnectionAsync(cID);
        }
        
        public string createTable(string jsonCD) {
            return base.Channel.createTable(jsonCD);
        }
        
        public System.Threading.Tasks.Task<string> createTableAsync(string jsonCD) {
            return base.Channel.createTableAsync(jsonCD);
        }
        
        public string deleteTable(string jsonDT) {
            return base.Channel.deleteTable(jsonDT);
        }
        
        public System.Threading.Tasks.Task<string> deleteTableAsync(string jsonDT) {
            return base.Channel.deleteTableAsync(jsonDT);
        }
        
        public string multipleQuery(string jsonCD) {
            return base.Channel.multipleQuery(jsonCD);
        }
        
        public System.Threading.Tasks.Task<string> multipleQueryAsync(string jsonCD) {
            return base.Channel.multipleQueryAsync(jsonCD);
        }
        
        public string insertValuesTable(string jsonIVT) {
            return base.Channel.insertValuesTable(jsonIVT);
        }
        
        public System.Threading.Tasks.Task<string> insertValuesTableAsync(string jsonIVT) {
            return base.Channel.insertValuesTableAsync(jsonIVT);
        }
        
        public string updateValuesTable(string jsonCD) {
            return base.Channel.updateValuesTable(jsonCD);
        }
        
        public System.Threading.Tasks.Task<string> updateValuesTableAsync(string jsonCD) {
            return base.Channel.updateValuesTableAsync(jsonCD);
        }
        
        public string deleteValuesTable(string jsonCD) {
            return base.Channel.deleteValuesTable(jsonCD);
        }
        
        public System.Threading.Tasks.Task<string> deleteValuesTableAsync(string jsonCD) {
            return base.Channel.deleteValuesTableAsync(jsonCD);
        }
    }
}
