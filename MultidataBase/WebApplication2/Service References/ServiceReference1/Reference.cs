﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="aMariaTipo", Namespace="http://schemas.datacontract.org/2004/07/ServicioWEB")]
    [System.SerializableAttribute()]
    public partial class aMariaTipo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMariaData", ReplyAction="http://tempuri.org/IService1/GetMariaDataResponse")]
        string GetMariaData(int value, string table, string db);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMariaData", ReplyAction="http://tempuri.org/IService1/GetMariaDataResponse")]
        System.Threading.Tasks.Task<string> GetMariaDataAsync(int value, string table, string db);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMariaDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetMariaDataUsingDataContractResponse")]
        WebApplication2.ServiceReference1.aMariaTipo GetMariaDataUsingDataContract(WebApplication2.ServiceReference1.aMariaTipo tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMariaDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetMariaDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WebApplication2.ServiceReference1.aMariaTipo> GetMariaDataUsingDataContractAsync(WebApplication2.ServiceReference1.aMariaTipo tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSQLData", ReplyAction="http://tempuri.org/IService1/GetSQLDataResponse")]
        string GetSQLData(int value, string table, string db);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSQLData", ReplyAction="http://tempuri.org/IService1/GetSQLDataResponse")]
        System.Threading.Tasks.Task<string> GetSQLDataAsync(int value, string table, string db);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSQLDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetSQLDataUsingDataContractResponse")]
        WebApplication2.ServiceReference1.aMariaTipo GetSQLDataUsingDataContract(WebApplication2.ServiceReference1.aMariaTipo tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSQLDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetSQLDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WebApplication2.ServiceReference1.aMariaTipo> GetSQLDataUsingDataContractAsync(WebApplication2.ServiceReference1.aMariaTipo tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMongoData", ReplyAction="http://tempuri.org/IService1/GetMongoDataResponse")]
        string GetMongoData(int value, string table, string db);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMongoData", ReplyAction="http://tempuri.org/IService1/GetMongoDataResponse")]
        System.Threading.Tasks.Task<string> GetMongoDataAsync(int value, string table, string db);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMongoDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetMongoDataUsingDataContractResponse")]
        WebApplication2.ServiceReference1.aMariaTipo GetMongoDataUsingDataContract(WebApplication2.ServiceReference1.aMariaTipo tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMongoDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetMongoDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WebApplication2.ServiceReference1.aMariaTipo> GetMongoDataUsingDataContractAsync(WebApplication2.ServiceReference1.aMariaTipo tipo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication2.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication2.ServiceReference1.IService1>, WebApplication2.ServiceReference1.IService1 {
        
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
        
        public string GetMariaData(int value, string table, string db) {
            return base.Channel.GetMariaData(value, table, db);
        }
        
        public System.Threading.Tasks.Task<string> GetMariaDataAsync(int value, string table, string db) {
            return base.Channel.GetMariaDataAsync(value, table, db);
        }
        
        public WebApplication2.ServiceReference1.aMariaTipo GetMariaDataUsingDataContract(WebApplication2.ServiceReference1.aMariaTipo tipo) {
            return base.Channel.GetMariaDataUsingDataContract(tipo);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.ServiceReference1.aMariaTipo> GetMariaDataUsingDataContractAsync(WebApplication2.ServiceReference1.aMariaTipo tipo) {
            return base.Channel.GetMariaDataUsingDataContractAsync(tipo);
        }
        
        public string GetSQLData(int value, string table, string db) {
            return base.Channel.GetSQLData(value, table, db);
        }
        
        public System.Threading.Tasks.Task<string> GetSQLDataAsync(int value, string table, string db) {
            return base.Channel.GetSQLDataAsync(value, table, db);
        }
        
        public WebApplication2.ServiceReference1.aMariaTipo GetSQLDataUsingDataContract(WebApplication2.ServiceReference1.aMariaTipo tipo) {
            return base.Channel.GetSQLDataUsingDataContract(tipo);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.ServiceReference1.aMariaTipo> GetSQLDataUsingDataContractAsync(WebApplication2.ServiceReference1.aMariaTipo tipo) {
            return base.Channel.GetSQLDataUsingDataContractAsync(tipo);
        }
        
        public string GetMongoData(int value, string table, string db) {
            return base.Channel.GetMongoData(value, table, db);
        }
        
        public System.Threading.Tasks.Task<string> GetMongoDataAsync(int value, string table, string db) {
            return base.Channel.GetMongoDataAsync(value, table, db);
        }
        
        public WebApplication2.ServiceReference1.aMariaTipo GetMongoDataUsingDataContract(WebApplication2.ServiceReference1.aMariaTipo tipo) {
            return base.Channel.GetMongoDataUsingDataContract(tipo);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.ServiceReference1.aMariaTipo> GetMongoDataUsingDataContractAsync(WebApplication2.ServiceReference1.aMariaTipo tipo) {
            return base.Channel.GetMongoDataUsingDataContractAsync(tipo);
        }
    }
}