﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Service1Soap")]
    public interface Service1Soap {
        
        // CODEGEN: Generating message contract since element name user from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OpenSession", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.OpenSessionResponse OpenSession(WindowsFormsApplication1.ServiceReference1.OpenSessionRequest request);
        
        // CODEGEN: Generating message contract since element name sessionID from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CloseSession", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.CloseSessionResponse CloseSession(WindowsFormsApplication1.ServiceReference1.CloseSessionRequest request);
        
        // CODEGEN: Generating message contract since element name sessionID from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FetchCustomer", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.FetchCustomerResponse FetchCustomer(WindowsFormsApplication1.ServiceReference1.FetchCustomerRequest request);
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.HelloWorldResponse HelloWorld(WindowsFormsApplication1.ServiceReference1.HelloWorldRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OpenSessionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OpenSession", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.OpenSessionRequestBody Body;
        
        public OpenSessionRequest() {
        }
        
        public OpenSessionRequest(WindowsFormsApplication1.ServiceReference1.OpenSessionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class OpenSessionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string user;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string company;
        
        public OpenSessionRequestBody() {
        }
        
        public OpenSessionRequestBody(string user, string password, string company) {
            this.user = user;
            this.password = password;
            this.company = company;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OpenSessionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OpenSessionResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.OpenSessionResponseBody Body;
        
        public OpenSessionResponse() {
        }
        
        public OpenSessionResponse(WindowsFormsApplication1.ServiceReference1.OpenSessionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class OpenSessionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string OpenSessionResult;
        
        public OpenSessionResponseBody() {
        }
        
        public OpenSessionResponseBody(string OpenSessionResult) {
            this.OpenSessionResult = OpenSessionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CloseSessionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CloseSession", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.CloseSessionRequestBody Body;
        
        public CloseSessionRequest() {
        }
        
        public CloseSessionRequest(WindowsFormsApplication1.ServiceReference1.CloseSessionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CloseSessionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sessionID;
        
        public CloseSessionRequestBody() {
        }
        
        public CloseSessionRequestBody(string sessionID) {
            this.sessionID = sessionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CloseSessionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CloseSessionResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.CloseSessionResponseBody Body;
        
        public CloseSessionResponse() {
        }
        
        public CloseSessionResponse(WindowsFormsApplication1.ServiceReference1.CloseSessionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CloseSessionResponseBody {
        
        public CloseSessionResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FetchCustomerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FetchCustomer", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.FetchCustomerRequestBody Body;
        
        public FetchCustomerRequest() {
        }
        
        public FetchCustomerRequest(WindowsFormsApplication1.ServiceReference1.FetchCustomerRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FetchCustomerRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sessionID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string reference;
        
        public FetchCustomerRequestBody() {
        }
        
        public FetchCustomerRequestBody(string sessionID, string reference) {
            this.sessionID = sessionID;
            this.reference = reference;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FetchCustomerResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FetchCustomerResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.FetchCustomerResponseBody Body;
        
        public FetchCustomerResponse() {
        }
        
        public FetchCustomerResponse(WindowsFormsApplication1.ServiceReference1.FetchCustomerResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FetchCustomerResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FetchCustomerResult;
        
        public FetchCustomerResponseBody() {
        }
        
        public FetchCustomerResponseBody(string FetchCustomerResult) {
            this.FetchCustomerResult = FetchCustomerResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WindowsFormsApplication1.ServiceReference1.HelloWorldRequestBody Body) {
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
        public WindowsFormsApplication1.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WindowsFormsApplication1.ServiceReference1.HelloWorldResponseBody Body) {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : WindowsFormsApplication1.ServiceReference1.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.Service1Soap>, WindowsFormsApplication1.ServiceReference1.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.OpenSessionResponse WindowsFormsApplication1.ServiceReference1.Service1Soap.OpenSession(WindowsFormsApplication1.ServiceReference1.OpenSessionRequest request) {
            return base.Channel.OpenSession(request);
        }
        
        public string OpenSession(string user, string password, string company) {
            WindowsFormsApplication1.ServiceReference1.OpenSessionRequest inValue = new WindowsFormsApplication1.ServiceReference1.OpenSessionRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.OpenSessionRequestBody();
            inValue.Body.user = user;
            inValue.Body.password = password;
            inValue.Body.company = company;
            WindowsFormsApplication1.ServiceReference1.OpenSessionResponse retVal = ((WindowsFormsApplication1.ServiceReference1.Service1Soap)(this)).OpenSession(inValue);
            return retVal.Body.OpenSessionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.CloseSessionResponse WindowsFormsApplication1.ServiceReference1.Service1Soap.CloseSession(WindowsFormsApplication1.ServiceReference1.CloseSessionRequest request) {
            return base.Channel.CloseSession(request);
        }
        
        public void CloseSession(string sessionID) {
            WindowsFormsApplication1.ServiceReference1.CloseSessionRequest inValue = new WindowsFormsApplication1.ServiceReference1.CloseSessionRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.CloseSessionRequestBody();
            inValue.Body.sessionID = sessionID;
            WindowsFormsApplication1.ServiceReference1.CloseSessionResponse retVal = ((WindowsFormsApplication1.ServiceReference1.Service1Soap)(this)).CloseSession(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.FetchCustomerResponse WindowsFormsApplication1.ServiceReference1.Service1Soap.FetchCustomer(WindowsFormsApplication1.ServiceReference1.FetchCustomerRequest request) {
            return base.Channel.FetchCustomer(request);
        }
        
        public string FetchCustomer(string sessionID, string reference) {
            WindowsFormsApplication1.ServiceReference1.FetchCustomerRequest inValue = new WindowsFormsApplication1.ServiceReference1.FetchCustomerRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.FetchCustomerRequestBody();
            inValue.Body.sessionID = sessionID;
            inValue.Body.reference = reference;
            WindowsFormsApplication1.ServiceReference1.FetchCustomerResponse retVal = ((WindowsFormsApplication1.ServiceReference1.Service1Soap)(this)).FetchCustomer(inValue);
            return retVal.Body.FetchCustomerResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.HelloWorldResponse WindowsFormsApplication1.ServiceReference1.Service1Soap.HelloWorld(WindowsFormsApplication1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WindowsFormsApplication1.ServiceReference1.HelloWorldRequest inValue = new WindowsFormsApplication1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.HelloWorldRequestBody();
            WindowsFormsApplication1.ServiceReference1.HelloWorldResponse retVal = ((WindowsFormsApplication1.ServiceReference1.Service1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
    }
}
