﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoreOutput.SR_ProgramListWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Program", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Program : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SR_ProgramListWebService.ProgramListWebServiceSoap")]
    public interface ProgramListWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetProgramListResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProgramList", ReplyAction="*")]
        CoreOutput.SR_ProgramListWebService.GetProgramListResponse GetProgramList(CoreOutput.SR_ProgramListWebService.GetProgramListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/GetProgramList", ReplyAction="*")]
        System.IAsyncResult BeginGetProgramList(CoreOutput.SR_ProgramListWebService.GetProgramListRequest request, System.AsyncCallback callback, object asyncState);
        
        CoreOutput.SR_ProgramListWebService.GetProgramListResponse EndGetProgramList(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProgramListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProgramList", Namespace="http://tempuri.org/", Order=0)]
        public CoreOutput.SR_ProgramListWebService.GetProgramListRequestBody Body;
        
        public GetProgramListRequest() {
        }
        
        public GetProgramListRequest(CoreOutput.SR_ProgramListWebService.GetProgramListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetProgramListRequestBody {
        
        public GetProgramListRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProgramListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProgramListResponse", Namespace="http://tempuri.org/", Order=0)]
        public CoreOutput.SR_ProgramListWebService.GetProgramListResponseBody Body;
        
        public GetProgramListResponse() {
        }
        
        public GetProgramListResponse(CoreOutput.SR_ProgramListWebService.GetProgramListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProgramListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Collections.Generic.List<CoreOutput.SR_ProgramListWebService.Program> GetProgramListResult;
        
        public GetProgramListResponseBody() {
        }
        
        public GetProgramListResponseBody(System.Collections.Generic.List<CoreOutput.SR_ProgramListWebService.Program> GetProgramListResult) {
            this.GetProgramListResult = GetProgramListResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProgramListWebServiceSoapChannel : CoreOutput.SR_ProgramListWebService.ProgramListWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetProgramListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetProgramListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<CoreOutput.SR_ProgramListWebService.Program> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<CoreOutput.SR_ProgramListWebService.Program>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProgramListWebServiceSoapClient : System.ServiceModel.ClientBase<CoreOutput.SR_ProgramListWebService.ProgramListWebServiceSoap>, CoreOutput.SR_ProgramListWebService.ProgramListWebServiceSoap {
        
        private BeginOperationDelegate onBeginGetProgramListDelegate;
        
        private EndOperationDelegate onEndGetProgramListDelegate;
        
        private System.Threading.SendOrPostCallback onGetProgramListCompletedDelegate;
        
        public ProgramListWebServiceSoapClient() {
        }
        
        public ProgramListWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProgramListWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProgramListWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProgramListWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetProgramListCompletedEventArgs> GetProgramListCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CoreOutput.SR_ProgramListWebService.GetProgramListResponse CoreOutput.SR_ProgramListWebService.ProgramListWebServiceSoap.GetProgramList(CoreOutput.SR_ProgramListWebService.GetProgramListRequest request) {
            return base.Channel.GetProgramList(request);
        }
        
        public System.Collections.Generic.List<CoreOutput.SR_ProgramListWebService.Program> GetProgramList() {
            CoreOutput.SR_ProgramListWebService.GetProgramListRequest inValue = new CoreOutput.SR_ProgramListWebService.GetProgramListRequest();
            inValue.Body = new CoreOutput.SR_ProgramListWebService.GetProgramListRequestBody();
            CoreOutput.SR_ProgramListWebService.GetProgramListResponse retVal = ((CoreOutput.SR_ProgramListWebService.ProgramListWebServiceSoap)(this)).GetProgramList(inValue);
            return retVal.Body.GetProgramListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CoreOutput.SR_ProgramListWebService.ProgramListWebServiceSoap.BeginGetProgramList(CoreOutput.SR_ProgramListWebService.GetProgramListRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetProgramList(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetProgramList(System.AsyncCallback callback, object asyncState) {
            CoreOutput.SR_ProgramListWebService.GetProgramListRequest inValue = new CoreOutput.SR_ProgramListWebService.GetProgramListRequest();
            inValue.Body = new CoreOutput.SR_ProgramListWebService.GetProgramListRequestBody();
            return ((CoreOutput.SR_ProgramListWebService.ProgramListWebServiceSoap)(this)).BeginGetProgramList(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CoreOutput.SR_ProgramListWebService.GetProgramListResponse CoreOutput.SR_ProgramListWebService.ProgramListWebServiceSoap.EndGetProgramList(System.IAsyncResult result) {
            return base.Channel.EndGetProgramList(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Collections.Generic.List<CoreOutput.SR_ProgramListWebService.Program> EndGetProgramList(System.IAsyncResult result) {
            CoreOutput.SR_ProgramListWebService.GetProgramListResponse retVal = ((CoreOutput.SR_ProgramListWebService.ProgramListWebServiceSoap)(this)).EndGetProgramList(result);
            return retVal.Body.GetProgramListResult;
        }
        
        private System.IAsyncResult OnBeginGetProgramList(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetProgramList(callback, asyncState);
        }
        
        private object[] OnEndGetProgramList(System.IAsyncResult result) {
            System.Collections.Generic.List<CoreOutput.SR_ProgramListWebService.Program> retVal = this.EndGetProgramList(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetProgramListCompleted(object state) {
            if ((this.GetProgramListCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetProgramListCompleted(this, new GetProgramListCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetProgramListAsync() {
            this.GetProgramListAsync(null);
        }
        
        public void GetProgramListAsync(object userState) {
            if ((this.onBeginGetProgramListDelegate == null)) {
                this.onBeginGetProgramListDelegate = new BeginOperationDelegate(this.OnBeginGetProgramList);
            }
            if ((this.onEndGetProgramListDelegate == null)) {
                this.onEndGetProgramListDelegate = new EndOperationDelegate(this.OnEndGetProgramList);
            }
            if ((this.onGetProgramListCompletedDelegate == null)) {
                this.onGetProgramListCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetProgramListCompleted);
            }
            base.InvokeAsync(this.onBeginGetProgramListDelegate, null, this.onEndGetProgramListDelegate, this.onGetProgramListCompletedDelegate, userState);
        }
    }
}
