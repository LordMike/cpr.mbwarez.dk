﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPR.CPRWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://cpr.mbwarez.dk/CPRService", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Gender", Namespace="http://cpr.mbwarez.dk/CPRService")]
    public enum Gender : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Male = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Female = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://cpr.mbwarez.dk/CPRService", ConfigurationName="CPRWebService.CPRServiceSoap")]
    public interface CPRServiceSoap {
        
        // CODEGEN: Generating message contract since element name RetrieveCPRResult from namespace http://cpr.mbwarez.dk/CPRService is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://cpr.mbwarez.dk/CPRService/RetrieveCPR", ReplyAction="*")]
        CPR.CPRWebService.RetrieveCPRResponse RetrieveCPR(CPR.CPRWebService.RetrieveCPRRequest request);
        
        // CODEGEN: Generating message contract since element name RetrieveCPRGenderResult from namespace http://cpr.mbwarez.dk/CPRService is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://cpr.mbwarez.dk/CPRService/RetrieveCPRGender", ReplyAction="*")]
        CPR.CPRWebService.RetrieveCPRGenderResponse RetrieveCPRGender(CPR.CPRWebService.RetrieveCPRGenderRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RetrieveCPRRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RetrieveCPR", Namespace="http://cpr.mbwarez.dk/CPRService", Order=0)]
        public CPR.CPRWebService.RetrieveCPRRequestBody Body;
        
        public RetrieveCPRRequest() {
        }
        
        public RetrieveCPRRequest(CPR.CPRWebService.RetrieveCPRRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://cpr.mbwarez.dk/CPRService")]
    public partial class RetrieveCPRRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.DateTime date;
        
        public RetrieveCPRRequestBody() {
        }
        
        public RetrieveCPRRequestBody(System.DateTime date) {
            this.date = date;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RetrieveCPRResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RetrieveCPRResponse", Namespace="http://cpr.mbwarez.dk/CPRService", Order=0)]
        public CPR.CPRWebService.RetrieveCPRResponseBody Body;
        
        public RetrieveCPRResponse() {
        }
        
        public RetrieveCPRResponse(CPR.CPRWebService.RetrieveCPRResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://cpr.mbwarez.dk/CPRService")]
    public partial class RetrieveCPRResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CPR.CPRWebService.ArrayOfString RetrieveCPRResult;
        
        public RetrieveCPRResponseBody() {
        }
        
        public RetrieveCPRResponseBody(CPR.CPRWebService.ArrayOfString RetrieveCPRResult) {
            this.RetrieveCPRResult = RetrieveCPRResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RetrieveCPRGenderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RetrieveCPRGender", Namespace="http://cpr.mbwarez.dk/CPRService", Order=0)]
        public CPR.CPRWebService.RetrieveCPRGenderRequestBody Body;
        
        public RetrieveCPRGenderRequest() {
        }
        
        public RetrieveCPRGenderRequest(CPR.CPRWebService.RetrieveCPRGenderRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://cpr.mbwarez.dk/CPRService")]
    public partial class RetrieveCPRGenderRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.DateTime date;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public CPR.CPRWebService.Gender gender;
        
        public RetrieveCPRGenderRequestBody() {
        }
        
        public RetrieveCPRGenderRequestBody(System.DateTime date, CPR.CPRWebService.Gender gender) {
            this.date = date;
            this.gender = gender;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RetrieveCPRGenderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RetrieveCPRGenderResponse", Namespace="http://cpr.mbwarez.dk/CPRService", Order=0)]
        public CPR.CPRWebService.RetrieveCPRGenderResponseBody Body;
        
        public RetrieveCPRGenderResponse() {
        }
        
        public RetrieveCPRGenderResponse(CPR.CPRWebService.RetrieveCPRGenderResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://cpr.mbwarez.dk/CPRService")]
    public partial class RetrieveCPRGenderResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CPR.CPRWebService.ArrayOfString RetrieveCPRGenderResult;
        
        public RetrieveCPRGenderResponseBody() {
        }
        
        public RetrieveCPRGenderResponseBody(CPR.CPRWebService.ArrayOfString RetrieveCPRGenderResult) {
            this.RetrieveCPRGenderResult = RetrieveCPRGenderResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CPRServiceSoapChannel : CPR.CPRWebService.CPRServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CPRServiceSoapClient : System.ServiceModel.ClientBase<CPR.CPRWebService.CPRServiceSoap>, CPR.CPRWebService.CPRServiceSoap {
        
        public CPRServiceSoapClient() {
        }
        
        public CPRServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CPRServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CPRServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CPRServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CPR.CPRWebService.RetrieveCPRResponse CPR.CPRWebService.CPRServiceSoap.RetrieveCPR(CPR.CPRWebService.RetrieveCPRRequest request) {
            return base.Channel.RetrieveCPR(request);
        }
        
        public CPR.CPRWebService.ArrayOfString RetrieveCPR(System.DateTime date) {
            CPR.CPRWebService.RetrieveCPRRequest inValue = new CPR.CPRWebService.RetrieveCPRRequest();
            inValue.Body = new CPR.CPRWebService.RetrieveCPRRequestBody();
            inValue.Body.date = date;
            CPR.CPRWebService.RetrieveCPRResponse retVal = ((CPR.CPRWebService.CPRServiceSoap)(this)).RetrieveCPR(inValue);
            return retVal.Body.RetrieveCPRResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CPR.CPRWebService.RetrieveCPRGenderResponse CPR.CPRWebService.CPRServiceSoap.RetrieveCPRGender(CPR.CPRWebService.RetrieveCPRGenderRequest request) {
            return base.Channel.RetrieveCPRGender(request);
        }
        
        public CPR.CPRWebService.ArrayOfString RetrieveCPRGender(System.DateTime date, CPR.CPRWebService.Gender gender) {
            CPR.CPRWebService.RetrieveCPRGenderRequest inValue = new CPR.CPRWebService.RetrieveCPRGenderRequest();
            inValue.Body = new CPR.CPRWebService.RetrieveCPRGenderRequestBody();
            inValue.Body.date = date;
            inValue.Body.gender = gender;
            CPR.CPRWebService.RetrieveCPRGenderResponse retVal = ((CPR.CPRWebService.CPRServiceSoap)(this)).RetrieveCPRGender(inValue);
            return retVal.Body.RetrieveCPRGenderResult;
        }
    }
}
