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
        string includeDB(string type, string user, string pass, string server, int port, string database);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/includeDB", ReplyAction="http://tempuri.org/IService1/includeDBResponse")]
        System.Threading.Tasks.Task<string> includeDBAsync(string type, string user, string pass, string server, int port, string database);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getConnections", ReplyAction="http://tempuri.org/IService1/getConnectionsResponse")]
        string getConnections();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getConnections", ReplyAction="http://tempuri.org/IService1/getConnectionsResponse")]
        System.Threading.Tasks.Task<string> getConnectionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createDatabase", ReplyAction="http://tempuri.org/IService1/createDatabaseResponse")]
        string createDatabase(string db_name, string db_type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createDatabase", ReplyAction="http://tempuri.org/IService1/createDatabaseResponse")]
        System.Threading.Tasks.Task<string> createDatabaseAsync(string db_name, string db_type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkMongoConnection", ReplyAction="http://tempuri.org/IService1/checkMongoConnectionResponse")]
        string checkMongoConnection();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkMongoConnection", ReplyAction="http://tempuri.org/IService1/checkMongoConnectionResponse")]
        System.Threading.Tasks.Task<string> checkMongoConnectionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkSQLConnection", ReplyAction="http://tempuri.org/IService1/checkSQLConnectionResponse")]
        string checkSQLConnection();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkSQLConnection", ReplyAction="http://tempuri.org/IService1/checkSQLConnectionResponse")]
        System.Threading.Tasks.Task<string> checkSQLConnectionAsync();
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
        
        public string includeDB(string type, string user, string pass, string server, int port, string database) {
            return base.Channel.includeDB(type, user, pass, server, port, database);
        }
        
        public System.Threading.Tasks.Task<string> includeDBAsync(string type, string user, string pass, string server, int port, string database) {
            return base.Channel.includeDBAsync(type, user, pass, server, port, database);
        }
        
        public string getConnections() {
            return base.Channel.getConnections();
        }
        
        public System.Threading.Tasks.Task<string> getConnectionsAsync() {
            return base.Channel.getConnectionsAsync();
        }
        
        public string createDatabase(string db_name, string db_type) {
            return base.Channel.createDatabase(db_name, db_type);
        }
        
        public System.Threading.Tasks.Task<string> createDatabaseAsync(string db_name, string db_type) {
            return base.Channel.createDatabaseAsync(db_name, db_type);
        }
        
        public string checkMongoConnection() {
            return base.Channel.checkMongoConnection();
        }
        
        public System.Threading.Tasks.Task<string> checkMongoConnectionAsync() {
            return base.Channel.checkMongoConnectionAsync();
        }
        
        public string checkSQLConnection() {
            return base.Channel.checkSQLConnection();
        }
        
        public System.Threading.Tasks.Task<string> checkSQLConnectionAsync() {
            return base.Channel.checkSQLConnectionAsync();
        }
    }
}
