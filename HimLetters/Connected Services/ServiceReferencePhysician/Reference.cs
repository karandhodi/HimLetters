﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HimLetters.ServiceReferencePhysician {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="getPhysiciansList_Results", Namespace="http://schemas.datacontract.org/2004/07/HimLettersWCFService")]
    [System.SerializableAttribute()]
    public partial class getPhysiciansList_Results : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaxField;
        
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
        public string Fax {
            get {
                return this.FaxField;
            }
            set {
                if ((object.ReferenceEquals(this.FaxField, value) != true)) {
                    this.FaxField = value;
                    this.RaisePropertyChanged("Fax");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PhysicianException", Namespace="http://schemas.datacontract.org/2004/07/HimLettersWCFService")]
    [System.SerializableAttribute()]
    public partial class PhysicianException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencePhysician.IServicePhysician")]
    public interface IServicePhysician {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhysician/GetPhysicianList", ReplyAction="http://tempuri.org/IServicePhysician/GetPhysicianListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(HimLetters.ServiceReferencePhysician.PhysicianException), Action="http://tempuri.org/IServicePhysician/GetPhysicianListPhysicianExceptionFault", Name="PhysicianException", Namespace="http://schemas.datacontract.org/2004/07/HimLettersWCFService")]
        HimLetters.ServiceReferencePhysician.getPhysiciansList_Results[] GetPhysicianList(string letterTypeId, string facilityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhysician/GetPhysicianList", ReplyAction="http://tempuri.org/IServicePhysician/GetPhysicianListResponse")]
        System.Threading.Tasks.Task<HimLetters.ServiceReferencePhysician.getPhysiciansList_Results[]> GetPhysicianListAsync(string letterTypeId, string facilityId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicePhysicianChannel : HimLetters.ServiceReferencePhysician.IServicePhysician, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePhysicianClient : System.ServiceModel.ClientBase<HimLetters.ServiceReferencePhysician.IServicePhysician>, HimLetters.ServiceReferencePhysician.IServicePhysician {
        
        public ServicePhysicianClient() {
        }
        
        public ServicePhysicianClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicePhysicianClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePhysicianClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePhysicianClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HimLetters.ServiceReferencePhysician.getPhysiciansList_Results[] GetPhysicianList(string letterTypeId, string facilityId) {
            return base.Channel.GetPhysicianList(letterTypeId, facilityId);
        }
        
        public System.Threading.Tasks.Task<HimLetters.ServiceReferencePhysician.getPhysiciansList_Results[]> GetPhysicianListAsync(string letterTypeId, string facilityId) {
            return base.Channel.GetPhysicianListAsync(letterTypeId, facilityId);
        }
    }
}
