﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SecureContactClient.ContactService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/SecureContact")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonIdField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonId {
            get {
                return this.PersonIdField;
            }
            set {
                if ((this.PersonIdField.Equals(value) != true)) {
                    this.PersonIdField = value;
                    this.RaisePropertyChanged("PersonId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomFaultMsg", Namespace="http://schemas.datacontract.org/2004/07/SecureContact")]
    [System.SerializableAttribute()]
    public partial class CustomFaultMsg : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ContactService.IContactService")]
    public interface IContactService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/HasPerson", ReplyAction="http://tempuri.org/IContactService/HasPersonResponse")]
        bool HasPerson(int personId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/GetPerson", ReplyAction="http://tempuri.org/IContactService/GetPersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureContactClient.ContactService.CustomFaultMsg), Action="http://tempuri.org/IContactService/GetPersonCustomFaultMsgFault", Name="CustomFaultMsg", Namespace="http://schemas.datacontract.org/2004/07/SecureContact")]
        SecureContactClient.ContactService.Person GetPerson(int personId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/GetAll", ReplyAction="http://tempuri.org/IContactService/GetAllResponse")]
        SecureContactClient.ContactService.Person[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/AddPerson", ReplyAction="http://tempuri.org/IContactService/AddPersonResponse")]
        void AddPerson(SecureContactClient.ContactService.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/EditPerson", ReplyAction="http://tempuri.org/IContactService/EditPersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureContactClient.ContactService.CustomFaultMsg), Action="http://tempuri.org/IContactService/EditPersonCustomFaultMsgFault", Name="CustomFaultMsg", Namespace="http://schemas.datacontract.org/2004/07/SecureContact")]
        void EditPerson(int personId, SecureContactClient.ContactService.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/DeletePerson", ReplyAction="http://tempuri.org/IContactService/DeletePersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureContactClient.ContactService.CustomFaultMsg), Action="http://tempuri.org/IContactService/DeletePersonCustomFaultMsgFault", Name="CustomFaultMsg", Namespace="http://schemas.datacontract.org/2004/07/SecureContact")]
        void DeletePerson(int personId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContactServiceChannel : SecureContactClient.ContactService.IContactService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContactServiceClient : System.ServiceModel.ClientBase<SecureContactClient.ContactService.IContactService>, SecureContactClient.ContactService.IContactService {
        
        public ContactServiceClient() {
        }
        
        public ContactServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContactServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContactServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContactServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool HasPerson(int personId) {
            return base.Channel.HasPerson(personId);
        }
        
        public SecureContactClient.ContactService.Person GetPerson(int personId) {
            return base.Channel.GetPerson(personId);
        }
        
        public SecureContactClient.ContactService.Person[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public void AddPerson(SecureContactClient.ContactService.Person person) {
            base.Channel.AddPerson(person);
        }
        
        public void EditPerson(int personId, SecureContactClient.ContactService.Person person) {
            base.Channel.EditPerson(personId, person);
        }
        
        public void DeletePerson(int personId) {
            base.Channel.DeletePerson(personId);
        }
    }
}
