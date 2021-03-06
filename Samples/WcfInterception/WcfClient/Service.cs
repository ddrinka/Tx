﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace Tx.Samples.WCFInterception
{
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class DailyStockQuote : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private double CloseField;
        
        private double HighField;
        
        private double LowField;
        
        private double OpenField;
        
        private string SymbolField;
        
        private int VolumeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Close
        {
            get
            {
                return this.CloseField;
            }
            set
            {
                this.CloseField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double High
        {
            get
            {
                return this.HighField;
            }
            set
            {
                this.HighField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Low
        {
            get
            {
                return this.LowField;
            }
            set
            {
                this.LowField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Open
        {
            get
            {
                return this.OpenField;
            }
            set
            {
                this.OpenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Symbol
        {
            get
            {
                return this.SymbolField;
            }
            set
            {
                this.SymbolField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Volume
        {
            get
            {
                return this.VolumeField;
            }
            set
            {
                this.VolumeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "Tx.Samples.WCFInterception.IStockQuoteService")]
    public interface IStockQuoteService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockQuoteService/GetQuote", ReplyAction="http://tempuri.org/IStockQuoteService/GetQuoteResponse")]
        Tx.Samples.WCFInterception.DailyStockQuote GetQuote(string symbol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockQuoteService/PurchaseStock", ReplyAction="http://tempuri.org/IStockQuoteService/PurchaseStockResponse")]
        bool PurchaseStock(string symbol, int quantity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IStockQuoteServiceChannel : Tx.Samples.WCFInterception.IStockQuoteService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class StockQuoteServiceClient : System.ServiceModel.ClientBase<Tx.Samples.WCFInterception.IStockQuoteService>, Tx.Samples.WCFInterception.IStockQuoteService
    {
        
        public StockQuoteServiceClient()
        {
        }
        
        public StockQuoteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public StockQuoteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public StockQuoteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public StockQuoteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }

        public Tx.Samples.WCFInterception.DailyStockQuote GetQuote(string symbol)
        {
            return base.Channel.GetQuote(symbol);
        }
        
        public bool PurchaseStock(string symbol, int quantity)
        {
            return base.Channel.PurchaseStock(symbol, quantity);
        }
    }
}
