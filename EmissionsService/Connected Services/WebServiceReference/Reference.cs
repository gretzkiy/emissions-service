﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmissionsService.WebServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TransferData", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class TransferData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string valueUuidField;
        
        private int timestampStartField;
        
        private int timestampEndField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string valueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string parameterUuidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string unitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string typeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sensorUuidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string stateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sourceUuidField;
        
        private int pnivField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string valueUuid {
            get {
                return this.valueUuidField;
            }
            set {
                if ((object.ReferenceEquals(this.valueUuidField, value) != true)) {
                    this.valueUuidField = value;
                    this.RaisePropertyChanged("valueUuid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int timestampStart {
            get {
                return this.timestampStartField;
            }
            set {
                if ((this.timestampStartField.Equals(value) != true)) {
                    this.timestampStartField = value;
                    this.RaisePropertyChanged("timestampStart");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int timestampEnd {
            get {
                return this.timestampEndField;
            }
            set {
                if ((this.timestampEndField.Equals(value) != true)) {
                    this.timestampEndField = value;
                    this.RaisePropertyChanged("timestampEnd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string value {
            get {
                return this.valueField;
            }
            set {
                if ((object.ReferenceEquals(this.valueField, value) != true)) {
                    this.valueField = value;
                    this.RaisePropertyChanged("value");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string parameterUuid {
            get {
                return this.parameterUuidField;
            }
            set {
                if ((object.ReferenceEquals(this.parameterUuidField, value) != true)) {
                    this.parameterUuidField = value;
                    this.RaisePropertyChanged("parameterUuid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string code {
            get {
                return this.codeField;
            }
            set {
                if ((object.ReferenceEquals(this.codeField, value) != true)) {
                    this.codeField = value;
                    this.RaisePropertyChanged("code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string unit {
            get {
                return this.unitField;
            }
            set {
                if ((object.ReferenceEquals(this.unitField, value) != true)) {
                    this.unitField = value;
                    this.RaisePropertyChanged("unit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string type {
            get {
                return this.typeField;
            }
            set {
                if ((object.ReferenceEquals(this.typeField, value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string sensorUuid {
            get {
                return this.sensorUuidField;
            }
            set {
                if ((object.ReferenceEquals(this.sensorUuidField, value) != true)) {
                    this.sensorUuidField = value;
                    this.RaisePropertyChanged("sensorUuid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string state {
            get {
                return this.stateField;
            }
            set {
                if ((object.ReferenceEquals(this.stateField, value) != true)) {
                    this.stateField = value;
                    this.RaisePropertyChanged("state");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string sourceUuid {
            get {
                return this.sourceUuidField;
            }
            set {
                if ((object.ReferenceEquals(this.sourceUuidField, value) != true)) {
                    this.sourceUuidField = value;
                    this.RaisePropertyChanged("sourceUuid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=11)]
        public int pniv {
            get {
                return this.pnivField;
            }
            set {
                if ((this.pnivField.Equals(value) != true)) {
                    this.pnivField = value;
                    this.RaisePropertyChanged("pniv");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceReference.EmissionsWebServiceSoap")]
    public interface EmissionsWebServiceSoap {
        
        // CODEGEN: Контракт генерации сообщений с именем HelloWorldResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        EmissionsService.WebServiceReference.HelloWorldResponse HelloWorld(EmissionsService.WebServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<EmissionsService.WebServiceReference.HelloWorldResponse> HelloWorldAsync(EmissionsService.WebServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int num1, int num2);
        
        // CODEGEN: Контракт генерации сообщений с именем transferData из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TestMethod", ReplyAction="*")]
        EmissionsService.WebServiceReference.TestMethodResponse TestMethod(EmissionsService.WebServiceReference.TestMethodRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TestMethod", ReplyAction="*")]
        System.Threading.Tasks.Task<EmissionsService.WebServiceReference.TestMethodResponse> TestMethodAsync(EmissionsService.WebServiceReference.TestMethodRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем data из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UploadData", ReplyAction="*")]
        EmissionsService.WebServiceReference.UploadDataResponse UploadData(EmissionsService.WebServiceReference.UploadDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UploadData", ReplyAction="*")]
        System.Threading.Tasks.Task<EmissionsService.WebServiceReference.UploadDataResponse> UploadDataAsync(EmissionsService.WebServiceReference.UploadDataRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public EmissionsService.WebServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(EmissionsService.WebServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public EmissionsService.WebServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(EmissionsService.WebServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TestMethodRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TestMethod", Namespace="http://tempuri.org/", Order=0)]
        public EmissionsService.WebServiceReference.TestMethodRequestBody Body;
        
        public TestMethodRequest() {
        }
        
        public TestMethodRequest(EmissionsService.WebServiceReference.TestMethodRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TestMethodRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public EmissionsService.WebServiceReference.TransferData[] transferData;
        
        public TestMethodRequestBody() {
        }
        
        public TestMethodRequestBody(EmissionsService.WebServiceReference.TransferData[] transferData) {
            this.transferData = transferData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TestMethodResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TestMethodResponse", Namespace="http://tempuri.org/", Order=0)]
        public EmissionsService.WebServiceReference.TestMethodResponseBody Body;
        
        public TestMethodResponse() {
        }
        
        public TestMethodResponse(EmissionsService.WebServiceReference.TestMethodResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TestMethodResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TestMethodResult;
        
        public TestMethodResponseBody() {
        }
        
        public TestMethodResponseBody(string TestMethodResult) {
            this.TestMethodResult = TestMethodResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadData", Namespace="http://tempuri.org/", Order=0)]
        public EmissionsService.WebServiceReference.UploadDataRequestBody Body;
        
        public UploadDataRequest() {
        }
        
        public UploadDataRequest(EmissionsService.WebServiceReference.UploadDataRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UploadDataRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public EmissionsService.WebServiceReference.TransferData[] data;
        
        public UploadDataRequestBody() {
        }
        
        public UploadDataRequestBody(EmissionsService.WebServiceReference.TransferData[] data) {
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadDataResponse", Namespace="http://tempuri.org/", Order=0)]
        public EmissionsService.WebServiceReference.UploadDataResponseBody Body;
        
        public UploadDataResponse() {
        }
        
        public UploadDataResponse(EmissionsService.WebServiceReference.UploadDataResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UploadDataResponseBody {
        
        public UploadDataResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EmissionsWebServiceSoapChannel : EmissionsService.WebServiceReference.EmissionsWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmissionsWebServiceSoapClient : System.ServiceModel.ClientBase<EmissionsService.WebServiceReference.EmissionsWebServiceSoap>, EmissionsService.WebServiceReference.EmissionsWebServiceSoap {
        
        public EmissionsWebServiceSoapClient() {
        }
        
        public EmissionsWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmissionsWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmissionsWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmissionsWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EmissionsService.WebServiceReference.HelloWorldResponse EmissionsService.WebServiceReference.EmissionsWebServiceSoap.HelloWorld(EmissionsService.WebServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            EmissionsService.WebServiceReference.HelloWorldRequest inValue = new EmissionsService.WebServiceReference.HelloWorldRequest();
            inValue.Body = new EmissionsService.WebServiceReference.HelloWorldRequestBody();
            EmissionsService.WebServiceReference.HelloWorldResponse retVal = ((EmissionsService.WebServiceReference.EmissionsWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EmissionsService.WebServiceReference.HelloWorldResponse> EmissionsService.WebServiceReference.EmissionsWebServiceSoap.HelloWorldAsync(EmissionsService.WebServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<EmissionsService.WebServiceReference.HelloWorldResponse> HelloWorldAsync() {
            EmissionsService.WebServiceReference.HelloWorldRequest inValue = new EmissionsService.WebServiceReference.HelloWorldRequest();
            inValue.Body = new EmissionsService.WebServiceReference.HelloWorldRequestBody();
            return ((EmissionsService.WebServiceReference.EmissionsWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int Add(int num1, int num2) {
            return base.Channel.Add(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int num1, int num2) {
            return base.Channel.AddAsync(num1, num2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EmissionsService.WebServiceReference.TestMethodResponse EmissionsService.WebServiceReference.EmissionsWebServiceSoap.TestMethod(EmissionsService.WebServiceReference.TestMethodRequest request) {
            return base.Channel.TestMethod(request);
        }
        
        public string TestMethod(EmissionsService.WebServiceReference.TransferData[] transferData) {
            EmissionsService.WebServiceReference.TestMethodRequest inValue = new EmissionsService.WebServiceReference.TestMethodRequest();
            inValue.Body = new EmissionsService.WebServiceReference.TestMethodRequestBody();
            inValue.Body.transferData = transferData;
            EmissionsService.WebServiceReference.TestMethodResponse retVal = ((EmissionsService.WebServiceReference.EmissionsWebServiceSoap)(this)).TestMethod(inValue);
            return retVal.Body.TestMethodResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EmissionsService.WebServiceReference.TestMethodResponse> EmissionsService.WebServiceReference.EmissionsWebServiceSoap.TestMethodAsync(EmissionsService.WebServiceReference.TestMethodRequest request) {
            return base.Channel.TestMethodAsync(request);
        }
        
        public System.Threading.Tasks.Task<EmissionsService.WebServiceReference.TestMethodResponse> TestMethodAsync(EmissionsService.WebServiceReference.TransferData[] transferData) {
            EmissionsService.WebServiceReference.TestMethodRequest inValue = new EmissionsService.WebServiceReference.TestMethodRequest();
            inValue.Body = new EmissionsService.WebServiceReference.TestMethodRequestBody();
            inValue.Body.transferData = transferData;
            return ((EmissionsService.WebServiceReference.EmissionsWebServiceSoap)(this)).TestMethodAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EmissionsService.WebServiceReference.UploadDataResponse EmissionsService.WebServiceReference.EmissionsWebServiceSoap.UploadData(EmissionsService.WebServiceReference.UploadDataRequest request) {
            return base.Channel.UploadData(request);
        }
        
        public void UploadData(EmissionsService.WebServiceReference.TransferData[] data) {
            EmissionsService.WebServiceReference.UploadDataRequest inValue = new EmissionsService.WebServiceReference.UploadDataRequest();
            inValue.Body = new EmissionsService.WebServiceReference.UploadDataRequestBody();
            inValue.Body.data = data;
            EmissionsService.WebServiceReference.UploadDataResponse retVal = ((EmissionsService.WebServiceReference.EmissionsWebServiceSoap)(this)).UploadData(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EmissionsService.WebServiceReference.UploadDataResponse> EmissionsService.WebServiceReference.EmissionsWebServiceSoap.UploadDataAsync(EmissionsService.WebServiceReference.UploadDataRequest request) {
            return base.Channel.UploadDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<EmissionsService.WebServiceReference.UploadDataResponse> UploadDataAsync(EmissionsService.WebServiceReference.TransferData[] data) {
            EmissionsService.WebServiceReference.UploadDataRequest inValue = new EmissionsService.WebServiceReference.UploadDataRequest();
            inValue.Body = new EmissionsService.WebServiceReference.UploadDataRequestBody();
            inValue.Body.data = data;
            return ((EmissionsService.WebServiceReference.EmissionsWebServiceSoap)(this)).UploadDataAsync(inValue);
        }
    }
}
