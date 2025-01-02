﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
        
        // CODEGEN: Generating message contract since element name user from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OpenSessionByID", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.OpenSessionByIDResponse OpenSessionByID(WindowsFormsApplication1.ServiceReference1.OpenSessionByIDRequest request);
        
        // CODEGEN: Generating message contract since element name sessionID from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CloseSession", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.CloseSessionResponse CloseSession(WindowsFormsApplication1.ServiceReference1.CloseSessionRequest request);
        
        // CODEGEN: Generating message contract since element name sessionID from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FetchCustomer", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.FetchCustomerResponse FetchCustomer(WindowsFormsApplication1.ServiceReference1.FetchCustomerRequest request);
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
    public partial class OpenSessionByIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OpenSessionByID", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.OpenSessionByIDRequestBody Body;
        
        public OpenSessionByIDRequest() {
        }
        
        public OpenSessionByIDRequest(WindowsFormsApplication1.ServiceReference1.OpenSessionByIDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class OpenSessionByIDRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string user;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int companyID;
        
        public OpenSessionByIDRequestBody() {
        }
        
        public OpenSessionByIDRequestBody(string user, string password, int companyID) {
            this.user = user;
            this.password = password;
            this.companyID = companyID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OpenSessionByIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OpenSessionByIDResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.OpenSessionByIDResponseBody Body;
        
        public OpenSessionByIDResponse() {
        }
        
        public OpenSessionByIDResponse(WindowsFormsApplication1.ServiceReference1.OpenSessionByIDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class OpenSessionByIDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string OpenSessionByIDResult;
        
        public OpenSessionByIDResponseBody() {
        }
        
        public OpenSessionByIDResponseBody(string OpenSessionByIDResult) {
            this.OpenSessionByIDResult = OpenSessionByIDResult;
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
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public bool bForce;
        
        public CloseSessionRequestBody() {
        }
        
        public CloseSessionRequestBody(string sessionID, bool bForce) {
            this.sessionID = sessionID;
            this.bForce = bForce;
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string user;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string company;
        
        public FetchCustomerRequestBody() {
        }
        
        public FetchCustomerRequestBody(string sessionID, string reference, string user, string password, string company) {
            this.sessionID = sessionID;
            this.reference = reference;
            this.user = user;
            this.password = password;
            this.company = company;
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
        WindowsFormsApplication1.ServiceReference1.OpenSessionByIDResponse WindowsFormsApplication1.ServiceReference1.Service1Soap.OpenSessionByID(WindowsFormsApplication1.ServiceReference1.OpenSessionByIDRequest request) {
            return base.Channel.OpenSessionByID(request);
        }
        
        public string OpenSessionByID(string user, string password, int companyID) {
            WindowsFormsApplication1.ServiceReference1.OpenSessionByIDRequest inValue = new WindowsFormsApplication1.ServiceReference1.OpenSessionByIDRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.OpenSessionByIDRequestBody();
            inValue.Body.user = user;
            inValue.Body.password = password;
            inValue.Body.companyID = companyID;
            WindowsFormsApplication1.ServiceReference1.OpenSessionByIDResponse retVal = ((WindowsFormsApplication1.ServiceReference1.Service1Soap)(this)).OpenSessionByID(inValue);
            return retVal.Body.OpenSessionByIDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.CloseSessionResponse WindowsFormsApplication1.ServiceReference1.Service1Soap.CloseSession(WindowsFormsApplication1.ServiceReference1.CloseSessionRequest request) {
            return base.Channel.CloseSession(request);
        }
        
        public void CloseSession(string sessionID, bool bForce) {
            WindowsFormsApplication1.ServiceReference1.CloseSessionRequest inValue = new WindowsFormsApplication1.ServiceReference1.CloseSessionRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.CloseSessionRequestBody();
            inValue.Body.sessionID = sessionID;
            inValue.Body.bForce = bForce;
            WindowsFormsApplication1.ServiceReference1.CloseSessionResponse retVal = ((WindowsFormsApplication1.ServiceReference1.Service1Soap)(this)).CloseSession(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.FetchCustomerResponse WindowsFormsApplication1.ServiceReference1.Service1Soap.FetchCustomer(WindowsFormsApplication1.ServiceReference1.FetchCustomerRequest request) {
            return base.Channel.FetchCustomer(request);
        }
        
        public string FetchCustomer(string sessionID, string reference, string user, string password, string company) {
            WindowsFormsApplication1.ServiceReference1.FetchCustomerRequest inValue = new WindowsFormsApplication1.ServiceReference1.FetchCustomerRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.FetchCustomerRequestBody();
            inValue.Body.sessionID = sessionID;
            inValue.Body.reference = reference;
            inValue.Body.user = user;
            inValue.Body.password = password;
            inValue.Body.company = company;
            WindowsFormsApplication1.ServiceReference1.FetchCustomerResponse retVal = ((WindowsFormsApplication1.ServiceReference1.Service1Soap)(this)).FetchCustomer(inValue);
            return retVal.Body.FetchCustomerResult;
        }
    }
}
