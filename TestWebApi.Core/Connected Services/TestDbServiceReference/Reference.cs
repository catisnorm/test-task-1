﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWebApi.Core.TestDbServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/TestWebApi.Data")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TestWebApi.Core.TestDbServiceReference.Subscription[] SubscriptionsField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TestWebApi.Core.TestDbServiceReference.Subscription[] Subscriptions {
            get {
                return this.SubscriptionsField;
            }
            set {
                if ((object.ReferenceEquals(this.SubscriptionsField, value) != true)) {
                    this.SubscriptionsField = value;
                    this.RaisePropertyChanged("Subscriptions");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Subscription", Namespace="http://schemas.datacontract.org/2004/07/TestWebApi.Data")]
    [System.SerializableAttribute()]
    public partial class Subscription : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CallMinutesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float PriceIncVatAmountField;
        
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
        public int CallMinutes {
            get {
                return this.CallMinutesField;
            }
            set {
                if ((this.CallMinutesField.Equals(value) != true)) {
                    this.CallMinutesField = value;
                    this.RaisePropertyChanged("CallMinutes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float PriceIncVatAmount {
            get {
                return this.PriceIncVatAmountField;
            }
            set {
                if ((this.PriceIncVatAmountField.Equals(value) != true)) {
                    this.PriceIncVatAmountField = value;
                    this.RaisePropertyChanged("PriceIncVatAmount");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserResult", Namespace="http://schemas.datacontract.org/2004/07/TestWebApi.Data")]
    [System.SerializableAttribute()]
    public partial class UserResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public int Code {
            get {
                return this.CodeField;
            }
            set {
                if ((this.CodeField.Equals(value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SubscriptionResult", Namespace="http://schemas.datacontract.org/2004/07/TestWebApi.Data")]
    [System.SerializableAttribute()]
    public partial class SubscriptionResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public int Code {
            get {
                return this.CodeField;
            }
            set {
                if ((this.CodeField.Equals(value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TestDbServiceReference.ITestDbService")]
    public interface ITestDbService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/GetUsers", ReplyAction="http://tempuri.org/ITestDbService/GetUsersResponse")]
        TestWebApi.Core.TestDbServiceReference.User[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/GetUsers", ReplyAction="http://tempuri.org/ITestDbService/GetUsersResponse")]
        System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.User[]> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/GetUser", ReplyAction="http://tempuri.org/ITestDbService/GetUserResponse")]
        TestWebApi.Core.TestDbServiceReference.User GetUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/GetUser", ReplyAction="http://tempuri.org/ITestDbService/GetUserResponse")]
        System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.User> GetUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/CreateUser", ReplyAction="http://tempuri.org/ITestDbService/CreateUserResponse")]
        TestWebApi.Core.TestDbServiceReference.User CreateUser(TestWebApi.Core.TestDbServiceReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/CreateUser", ReplyAction="http://tempuri.org/ITestDbService/CreateUserResponse")]
        System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.User> CreateUserAsync(TestWebApi.Core.TestDbServiceReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/AddSubscription", ReplyAction="http://tempuri.org/ITestDbService/AddSubscriptionResponse")]
        TestWebApi.Core.TestDbServiceReference.UserResult AddSubscription(int userId, System.Guid subscriptionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/AddSubscription", ReplyAction="http://tempuri.org/ITestDbService/AddSubscriptionResponse")]
        System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.UserResult> AddSubscriptionAsync(int userId, System.Guid subscriptionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/DeleteUser", ReplyAction="http://tempuri.org/ITestDbService/DeleteUserResponse")]
        TestWebApi.Core.TestDbServiceReference.UserResult DeleteUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/DeleteUser", ReplyAction="http://tempuri.org/ITestDbService/DeleteUserResponse")]
        System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.UserResult> DeleteUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/GetSubscriptions", ReplyAction="http://tempuri.org/ITestDbService/GetSubscriptionsResponse")]
        TestWebApi.Core.TestDbServiceReference.Subscription[] GetSubscriptions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/GetSubscriptions", ReplyAction="http://tempuri.org/ITestDbService/GetSubscriptionsResponse")]
        System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.Subscription[]> GetSubscriptionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/GetSubscription", ReplyAction="http://tempuri.org/ITestDbService/GetSubscriptionResponse")]
        TestWebApi.Core.TestDbServiceReference.Subscription GetSubscription(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/GetSubscription", ReplyAction="http://tempuri.org/ITestDbService/GetSubscriptionResponse")]
        System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.Subscription> GetSubscriptionAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/CreateSubscription", ReplyAction="http://tempuri.org/ITestDbService/CreateSubscriptionResponse")]
        TestWebApi.Core.TestDbServiceReference.Subscription CreateSubscription(TestWebApi.Core.TestDbServiceReference.Subscription subscription);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/CreateSubscription", ReplyAction="http://tempuri.org/ITestDbService/CreateSubscriptionResponse")]
        System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.Subscription> CreateSubscriptionAsync(TestWebApi.Core.TestDbServiceReference.Subscription subscription);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/UpdateSubscription", ReplyAction="http://tempuri.org/ITestDbService/UpdateSubscriptionResponse")]
        TestWebApi.Core.TestDbServiceReference.SubscriptionResult UpdateSubscription(TestWebApi.Core.TestDbServiceReference.Subscription subscription);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/UpdateSubscription", ReplyAction="http://tempuri.org/ITestDbService/UpdateSubscriptionResponse")]
        System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.SubscriptionResult> UpdateSubscriptionAsync(TestWebApi.Core.TestDbServiceReference.Subscription subscription);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/DeleteSubscription", ReplyAction="http://tempuri.org/ITestDbService/DeleteSubscriptionResponse")]
        TestWebApi.Core.TestDbServiceReference.SubscriptionResult DeleteSubscription(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestDbService/DeleteSubscription", ReplyAction="http://tempuri.org/ITestDbService/DeleteSubscriptionResponse")]
        System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.SubscriptionResult> DeleteSubscriptionAsync(System.Guid id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITestDbServiceChannel : TestWebApi.Core.TestDbServiceReference.ITestDbService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestDbServiceClient : System.ServiceModel.ClientBase<TestWebApi.Core.TestDbServiceReference.ITestDbService>, TestWebApi.Core.TestDbServiceReference.ITestDbService {
        
        public TestDbServiceClient() {
        }
        
        public TestDbServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TestDbServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestDbServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestDbServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestWebApi.Core.TestDbServiceReference.User[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.User[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public TestWebApi.Core.TestDbServiceReference.User GetUser(int id) {
            return base.Channel.GetUser(id);
        }
        
        public System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.User> GetUserAsync(int id) {
            return base.Channel.GetUserAsync(id);
        }
        
        public TestWebApi.Core.TestDbServiceReference.User CreateUser(TestWebApi.Core.TestDbServiceReference.User user) {
            return base.Channel.CreateUser(user);
        }
        
        public System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.User> CreateUserAsync(TestWebApi.Core.TestDbServiceReference.User user) {
            return base.Channel.CreateUserAsync(user);
        }
        
        public TestWebApi.Core.TestDbServiceReference.UserResult AddSubscription(int userId, System.Guid subscriptionId) {
            return base.Channel.AddSubscription(userId, subscriptionId);
        }
        
        public System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.UserResult> AddSubscriptionAsync(int userId, System.Guid subscriptionId) {
            return base.Channel.AddSubscriptionAsync(userId, subscriptionId);
        }
        
        public TestWebApi.Core.TestDbServiceReference.UserResult DeleteUser(int id) {
            return base.Channel.DeleteUser(id);
        }
        
        public System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.UserResult> DeleteUserAsync(int id) {
            return base.Channel.DeleteUserAsync(id);
        }
        
        public TestWebApi.Core.TestDbServiceReference.Subscription[] GetSubscriptions() {
            return base.Channel.GetSubscriptions();
        }
        
        public System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.Subscription[]> GetSubscriptionsAsync() {
            return base.Channel.GetSubscriptionsAsync();
        }
        
        public TestWebApi.Core.TestDbServiceReference.Subscription GetSubscription(System.Guid id) {
            return base.Channel.GetSubscription(id);
        }
        
        public System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.Subscription> GetSubscriptionAsync(System.Guid id) {
            return base.Channel.GetSubscriptionAsync(id);
        }
        
        public TestWebApi.Core.TestDbServiceReference.Subscription CreateSubscription(TestWebApi.Core.TestDbServiceReference.Subscription subscription) {
            return base.Channel.CreateSubscription(subscription);
        }
        
        public System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.Subscription> CreateSubscriptionAsync(TestWebApi.Core.TestDbServiceReference.Subscription subscription) {
            return base.Channel.CreateSubscriptionAsync(subscription);
        }
        
        public TestWebApi.Core.TestDbServiceReference.SubscriptionResult UpdateSubscription(TestWebApi.Core.TestDbServiceReference.Subscription subscription) {
            return base.Channel.UpdateSubscription(subscription);
        }
        
        public System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.SubscriptionResult> UpdateSubscriptionAsync(TestWebApi.Core.TestDbServiceReference.Subscription subscription) {
            return base.Channel.UpdateSubscriptionAsync(subscription);
        }
        
        public TestWebApi.Core.TestDbServiceReference.SubscriptionResult DeleteSubscription(System.Guid id) {
            return base.Channel.DeleteSubscription(id);
        }
        
        public System.Threading.Tasks.Task<TestWebApi.Core.TestDbServiceReference.SubscriptionResult> DeleteSubscriptionAsync(System.Guid id) {
            return base.Channel.DeleteSubscriptionAsync(id);
        }
    }
}
