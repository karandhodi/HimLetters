﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HimLetters.ServiceReferenceLetterType {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="getLetterTypeList_Results", Namespace="http://schemas.datacontract.org/2004/07/HimLettersWCFService")]
    [System.SerializableAttribute()]
    public partial class getLetterTypeList_Results : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LetterTypeException", Namespace="http://schemas.datacontract.org/2004/07/HimLettersWCFService")]
    [System.SerializableAttribute()]
    public partial class LetterTypeException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceLetterType.IServiceLetterType")]
    public interface IServiceLetterType {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLetterType/GetLetterTypeList", ReplyAction="http://tempuri.org/IServiceLetterType/GetLetterTypeListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(HimLetters.ServiceReferenceLetterType.LetterTypeException), Action="http://tempuri.org/IServiceLetterType/GetLetterTypeListLetterTypeExceptionFault", Name="LetterTypeException", Namespace="http://schemas.datacontract.org/2004/07/HimLettersWCFService")]
        HimLetters.ServiceReferenceLetterType.getLetterTypeList_Results[] GetLetterTypeList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLetterType/GetLetterTypeList", ReplyAction="http://tempuri.org/IServiceLetterType/GetLetterTypeListResponse")]
        System.Threading.Tasks.Task<HimLetters.ServiceReferenceLetterType.getLetterTypeList_Results[]> GetLetterTypeListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceLetterTypeChannel : HimLetters.ServiceReferenceLetterType.IServiceLetterType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceLetterTypeClient : System.ServiceModel.ClientBase<HimLetters.ServiceReferenceLetterType.IServiceLetterType>, HimLetters.ServiceReferenceLetterType.IServiceLetterType {
        
        public ServiceLetterTypeClient() {
        }
        
        public ServiceLetterTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceLetterTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLetterTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLetterTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HimLetters.ServiceReferenceLetterType.getLetterTypeList_Results[] GetLetterTypeList() {
            return base.Channel.GetLetterTypeList();
        }
        
        public System.Threading.Tasks.Task<HimLetters.ServiceReferenceLetterType.getLetterTypeList_Results[]> GetLetterTypeListAsync() {
            return base.Channel.GetLetterTypeListAsync();
        }
    }
}
