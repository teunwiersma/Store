﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Store.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double bankField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
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
        public double bank {
            get {
                return this.bankField;
            }
            set {
                if ((this.bankField.Equals(value) != true)) {
                    this.bankField = value;
                    this.RaisePropertyChanged("bank");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int amountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double priceField;
        
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
        public int amount {
            get {
                return this.amountField;
            }
            set {
                if ((this.amountField.Equals(value) != true)) {
                    this.amountField = value;
                    this.RaisePropertyChanged("amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IMyService")]
    public interface IMyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetUsers", ReplyAction="http://tempuri.org/IMyService/GetUsersResponse")]
        Store.ServiceReference2.User[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetUsers", ReplyAction="http://tempuri.org/IMyService/GetUsersResponse")]
        System.Threading.Tasks.Task<Store.ServiceReference2.User[]> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/InsertUser", ReplyAction="http://tempuri.org/IMyService/InsertUserResponse")]
        void InsertUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/InsertUser", ReplyAction="http://tempuri.org/IMyService/InsertUserResponse")]
        System.Threading.Tasks.Task InsertUserAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetProducts", ReplyAction="http://tempuri.org/IMyService/GetProductsResponse")]
        Store.ServiceReference2.Product[] GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetProducts", ReplyAction="http://tempuri.org/IMyService/GetProductsResponse")]
        System.Threading.Tasks.Task<Store.ServiceReference2.Product[]> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/InsertProductToUser", ReplyAction="http://tempuri.org/IMyService/InsertProductToUserResponse")]
        void InsertProductToUser(string username, string product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/InsertProductToUser", ReplyAction="http://tempuri.org/IMyService/InsertProductToUserResponse")]
        System.Threading.Tasks.Task InsertProductToUserAsync(string username, string product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/findUser", ReplyAction="http://tempuri.org/IMyService/findUserResponse")]
        Store.ServiceReference2.User findUser(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/findUser", ReplyAction="http://tempuri.org/IMyService/findUserResponse")]
        System.Threading.Tasks.Task<Store.ServiceReference2.User> findUserAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/findProduct", ReplyAction="http://tempuri.org/IMyService/findProductResponse")]
        Store.ServiceReference2.Product findProduct(string productName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/findProduct", ReplyAction="http://tempuri.org/IMyService/findProductResponse")]
        System.Threading.Tasks.Task<Store.ServiceReference2.Product> findProductAsync(string productName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetProductsByUser", ReplyAction="http://tempuri.org/IMyService/GetProductsByUserResponse")]
        Store.ServiceReference2.Product[] GetProductsByUser(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetProductsByUser", ReplyAction="http://tempuri.org/IMyService/GetProductsByUserResponse")]
        System.Threading.Tasks.Task<Store.ServiceReference2.Product[]> GetProductsByUserAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/UpdateMoney", ReplyAction="http://tempuri.org/IMyService/UpdateMoneyResponse")]
        void UpdateMoney(double newBank, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/UpdateMoney", ReplyAction="http://tempuri.org/IMyService/UpdateMoneyResponse")]
        System.Threading.Tasks.Task UpdateMoneyAsync(double newBank, string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : Store.ServiceReference2.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<Store.ServiceReference2.IMyService>, Store.ServiceReference2.IMyService {
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Store.ServiceReference2.User[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<Store.ServiceReference2.User[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public void InsertUser(string username, string password) {
            base.Channel.InsertUser(username, password);
        }
        
        public System.Threading.Tasks.Task InsertUserAsync(string username, string password) {
            return base.Channel.InsertUserAsync(username, password);
        }
        
        public Store.ServiceReference2.Product[] GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<Store.ServiceReference2.Product[]> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public void InsertProductToUser(string username, string product) {
            base.Channel.InsertProductToUser(username, product);
        }
        
        public System.Threading.Tasks.Task InsertProductToUserAsync(string username, string product) {
            return base.Channel.InsertProductToUserAsync(username, product);
        }
        
        public Store.ServiceReference2.User findUser(string username) {
            return base.Channel.findUser(username);
        }
        
        public System.Threading.Tasks.Task<Store.ServiceReference2.User> findUserAsync(string username) {
            return base.Channel.findUserAsync(username);
        }
        
        public Store.ServiceReference2.Product findProduct(string productName) {
            return base.Channel.findProduct(productName);
        }
        
        public System.Threading.Tasks.Task<Store.ServiceReference2.Product> findProductAsync(string productName) {
            return base.Channel.findProductAsync(productName);
        }
        
        public Store.ServiceReference2.Product[] GetProductsByUser(string username) {
            return base.Channel.GetProductsByUser(username);
        }
        
        public System.Threading.Tasks.Task<Store.ServiceReference2.Product[]> GetProductsByUserAsync(string username) {
            return base.Channel.GetProductsByUserAsync(username);
        }
        
        public void UpdateMoney(double newBank, string username) {
            base.Channel.UpdateMoney(newBank, username);
        }
        
        public System.Threading.Tasks.Task UpdateMoneyAsync(double newBank, string username) {
            return base.Channel.UpdateMoneyAsync(newBank, username);
        }
    }
}
