﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETestApp.Dservice {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/DMS.API")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ScreenshotDetails", Namespace="http://schemas.datacontract.org/2004/07/DMS.API")]
    [System.SerializableAttribute()]
    public partial class ScreenshotDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> createdDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fk_DeviceIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> isDeletedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string screenshot1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string screenshot2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string screenshot3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string screenshot4Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string screenshot5Field;
        
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
        public System.Nullable<System.DateTime> createdDate {
            get {
                return this.createdDateField;
            }
            set {
                if ((this.createdDateField.Equals(value) != true)) {
                    this.createdDateField = value;
                    this.RaisePropertyChanged("createdDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fk_DeviceId {
            get {
                return this.fk_DeviceIdField;
            }
            set {
                if ((object.ReferenceEquals(this.fk_DeviceIdField, value) != true)) {
                    this.fk_DeviceIdField = value;
                    this.RaisePropertyChanged("fk_DeviceId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long id {
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
        public System.Nullable<bool> isDeleted {
            get {
                return this.isDeletedField;
            }
            set {
                if ((this.isDeletedField.Equals(value) != true)) {
                    this.isDeletedField = value;
                    this.RaisePropertyChanged("isDeleted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string screenshot1 {
            get {
                return this.screenshot1Field;
            }
            set {
                if ((object.ReferenceEquals(this.screenshot1Field, value) != true)) {
                    this.screenshot1Field = value;
                    this.RaisePropertyChanged("screenshot1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string screenshot2 {
            get {
                return this.screenshot2Field;
            }
            set {
                if ((object.ReferenceEquals(this.screenshot2Field, value) != true)) {
                    this.screenshot2Field = value;
                    this.RaisePropertyChanged("screenshot2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string screenshot3 {
            get {
                return this.screenshot3Field;
            }
            set {
                if ((object.ReferenceEquals(this.screenshot3Field, value) != true)) {
                    this.screenshot3Field = value;
                    this.RaisePropertyChanged("screenshot3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string screenshot4 {
            get {
                return this.screenshot4Field;
            }
            set {
                if ((object.ReferenceEquals(this.screenshot4Field, value) != true)) {
                    this.screenshot4Field = value;
                    this.RaisePropertyChanged("screenshot4");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string screenshot5 {
            get {
                return this.screenshot5Field;
            }
            set {
                if ((object.ReferenceEquals(this.screenshot5Field, value) != true)) {
                    this.screenshot5Field = value;
                    this.RaisePropertyChanged("screenshot5");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DevicesDetails", Namespace="http://schemas.datacontract.org/2004/07/DMS.API")]
    [System.SerializableAttribute()]
    public partial class DevicesDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> createdDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string deviceIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string deviceIpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string deviceNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> deviceStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> isDeletedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> isShutdownDeviceField;
        
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
        public System.Nullable<System.DateTime> createdDate {
            get {
                return this.createdDateField;
            }
            set {
                if ((this.createdDateField.Equals(value) != true)) {
                    this.createdDateField = value;
                    this.RaisePropertyChanged("createdDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string deviceId {
            get {
                return this.deviceIdField;
            }
            set {
                if ((object.ReferenceEquals(this.deviceIdField, value) != true)) {
                    this.deviceIdField = value;
                    this.RaisePropertyChanged("deviceId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string deviceIp {
            get {
                return this.deviceIpField;
            }
            set {
                if ((object.ReferenceEquals(this.deviceIpField, value) != true)) {
                    this.deviceIpField = value;
                    this.RaisePropertyChanged("deviceIp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string deviceName {
            get {
                return this.deviceNameField;
            }
            set {
                if ((object.ReferenceEquals(this.deviceNameField, value) != true)) {
                    this.deviceNameField = value;
                    this.RaisePropertyChanged("deviceName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> deviceStatus {
            get {
                return this.deviceStatusField;
            }
            set {
                if ((this.deviceStatusField.Equals(value) != true)) {
                    this.deviceStatusField = value;
                    this.RaisePropertyChanged("deviceStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long id {
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
        public System.Nullable<bool> isDeleted {
            get {
                return this.isDeletedField;
            }
            set {
                if ((this.isDeletedField.Equals(value) != true)) {
                    this.isDeletedField = value;
                    this.RaisePropertyChanged("isDeleted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> isShutdownDevice {
            get {
                return this.isShutdownDeviceField;
            }
            set {
                if ((this.isShutdownDeviceField.Equals(value) != true)) {
                    this.isShutdownDeviceField = value;
                    this.RaisePropertyChanged("isShutdownDevice");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Dservice.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        ETestApp.Dservice.CompositeType GetDataUsingDataContract(ETestApp.Dservice.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveImage", ReplyAction="http://tempuri.org/IService1/SaveImageResponse")]
        void SaveImage(string deviceId, string imageBas64);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveImageObj", ReplyAction="http://tempuri.org/IService1/SaveImageObjResponse")]
        long SaveImageObj(ETestApp.Dservice.ScreenshotDetails scrnObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveDeviceIfNotExists", ReplyAction="http://tempuri.org/IService1/SaveDeviceIfNotExistsResponse")]
        void SaveDeviceIfNotExists(ETestApp.Dservice.DevicesDetails devObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateImageObj", ReplyAction="http://tempuri.org/IService1/UpdateImageObjResponse")]
        void UpdateImageObj(ETestApp.Dservice.ScreenshotDetails scrnObj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ETestApp.Dservice.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ETestApp.Dservice.IService1>, ETestApp.Dservice.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public ETestApp.Dservice.CompositeType GetDataUsingDataContract(ETestApp.Dservice.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public void SaveImage(string deviceId, string imageBas64) {
            base.Channel.SaveImage(deviceId, imageBas64);
        }
        
        public long SaveImageObj(ETestApp.Dservice.ScreenshotDetails scrnObj) {
            return base.Channel.SaveImageObj(scrnObj);
        }
        
        public void SaveDeviceIfNotExists(ETestApp.Dservice.DevicesDetails devObj) {
            base.Channel.SaveDeviceIfNotExists(devObj);
        }
        
        public void UpdateImageObj(ETestApp.Dservice.ScreenshotDetails scrnObj) {
            base.Channel.UpdateImageObj(scrnObj);
        }
    }
}
