﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication_GoodMojo.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IChuckNorrisService")]
    public interface IChuckNorrisService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChuckNorrisService/GetChuckNorrisFact", ReplyAction="http://tempuri.org/IChuckNorrisService/GetChuckNorrisFactResponse")]
        string GetChuckNorrisFact(System.Nullable<int> value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChuckNorrisServiceChannel : ConsoleApplication_GoodMojo.ServiceReference.IChuckNorrisService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChuckNorrisServiceClient : System.ServiceModel.ClientBase<ConsoleApplication_GoodMojo.ServiceReference.IChuckNorrisService>, ConsoleApplication_GoodMojo.ServiceReference.IChuckNorrisService {
        
        public ChuckNorrisServiceClient() {
        }
        
        public ChuckNorrisServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ChuckNorrisServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChuckNorrisServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChuckNorrisServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetChuckNorrisFact(System.Nullable<int> value) {
            return base.Channel.GetChuckNorrisFact(value);
        }
    }
}
