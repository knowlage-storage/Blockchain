﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlockchainExplorerDesktop.BlockchainService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Block", Namespace="http://schemas.datacontract.org/2004/07/BlockchainService")]
    [System.SerializableAttribute()]
    public partial class Block : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedOnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HashField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PreviousHashField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VersionField;
        
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
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedOn {
            get {
                return this.CreatedOnField;
            }
            set {
                if ((this.CreatedOnField.Equals(value) != true)) {
                    this.CreatedOnField = value;
                    this.RaisePropertyChanged("CreatedOn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Hash {
            get {
                return this.HashField;
            }
            set {
                if ((object.ReferenceEquals(this.HashField, value) != true)) {
                    this.HashField = value;
                    this.RaisePropertyChanged("Hash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PreviousHash {
            get {
                return this.PreviousHashField;
            }
            set {
                if ((object.ReferenceEquals(this.PreviousHashField, value) != true)) {
                    this.PreviousHashField = value;
                    this.RaisePropertyChanged("PreviousHash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Version {
            get {
                return this.VersionField;
            }
            set {
                if ((this.VersionField.Equals(value) != true)) {
                    this.VersionField = value;
                    this.RaisePropertyChanged("Version");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/BlockchainService")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BlockchainExplorerDesktop.BlockchainService.UserRole RoleField;
        
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
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BlockchainExplorerDesktop.BlockchainService.UserRole Role {
            get {
                return this.RoleField;
            }
            set {
                if ((this.RoleField.Equals(value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserRole", Namespace="http://schemas.datacontract.org/2004/07/Blockchain")]
    public enum UserRole : byte {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Admin = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Writer = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Reader = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BlockchainService.IBlockchainService")]
    public interface IBlockchainService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlockchainService/AddHost", ReplyAction="http://tempuri.org/IBlockchainService/AddHostResponse")]
        BlockchainExplorerDesktop.BlockchainService.Block AddHost(string ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlockchainService/AddHost", ReplyAction="http://tempuri.org/IBlockchainService/AddHostResponse")]
        System.Threading.Tasks.Task<BlockchainExplorerDesktop.BlockchainService.Block> AddHostAsync(string ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlockchainService/AddUser", ReplyAction="http://tempuri.org/IBlockchainService/AddUserResponse")]
        BlockchainExplorerDesktop.BlockchainService.Block AddUser(string login, string password, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlockchainService/AddUser", ReplyAction="http://tempuri.org/IBlockchainService/AddUserResponse")]
        System.Threading.Tasks.Task<BlockchainExplorerDesktop.BlockchainService.Block> AddUserAsync(string login, string password, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlockchainService/AddData", ReplyAction="http://tempuri.org/IBlockchainService/AddDataResponse")]
        BlockchainExplorerDesktop.BlockchainService.Block AddData(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlockchainService/AddData", ReplyAction="http://tempuri.org/IBlockchainService/AddDataResponse")]
        System.Threading.Tasks.Task<BlockchainExplorerDesktop.BlockchainService.Block> AddDataAsync(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlockchainService/Login", ReplyAction="http://tempuri.org/IBlockchainService/LoginResponse")]
        BlockchainExplorerDesktop.BlockchainService.User Login([System.ServiceModel.MessageParameterAttribute(Name="login")] string login1, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlockchainService/Login", ReplyAction="http://tempuri.org/IBlockchainService/LoginResponse")]
        System.Threading.Tasks.Task<BlockchainExplorerDesktop.BlockchainService.User> LoginAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlockchainService/GetChain", ReplyAction="http://tempuri.org/IBlockchainService/GetChainResponse")]
        BlockchainExplorerDesktop.BlockchainService.Block[] GetChain();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlockchainService/GetChain", ReplyAction="http://tempuri.org/IBlockchainService/GetChainResponse")]
        System.Threading.Tasks.Task<BlockchainExplorerDesktop.BlockchainService.Block[]> GetChainAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBlockchainServiceChannel : BlockchainExplorerDesktop.BlockchainService.IBlockchainService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BlockchainServiceClient : System.ServiceModel.ClientBase<BlockchainExplorerDesktop.BlockchainService.IBlockchainService>, BlockchainExplorerDesktop.BlockchainService.IBlockchainService {
        
        public BlockchainServiceClient() {
        }
        
        public BlockchainServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BlockchainServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BlockchainServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BlockchainServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BlockchainExplorerDesktop.BlockchainService.Block AddHost(string ip) {
            return base.Channel.AddHost(ip);
        }
        
        public System.Threading.Tasks.Task<BlockchainExplorerDesktop.BlockchainService.Block> AddHostAsync(string ip) {
            return base.Channel.AddHostAsync(ip);
        }
        
        public BlockchainExplorerDesktop.BlockchainService.Block AddUser(string login, string password, string role) {
            return base.Channel.AddUser(login, password, role);
        }
        
        public System.Threading.Tasks.Task<BlockchainExplorerDesktop.BlockchainService.Block> AddUserAsync(string login, string password, string role) {
            return base.Channel.AddUserAsync(login, password, role);
        }
        
        public BlockchainExplorerDesktop.BlockchainService.Block AddData(string text) {
            return base.Channel.AddData(text);
        }
        
        public System.Threading.Tasks.Task<BlockchainExplorerDesktop.BlockchainService.Block> AddDataAsync(string text) {
            return base.Channel.AddDataAsync(text);
        }
        
        public BlockchainExplorerDesktop.BlockchainService.User Login(string login1, string password) {
            return base.Channel.Login(login1, password);
        }
        
        public System.Threading.Tasks.Task<BlockchainExplorerDesktop.BlockchainService.User> LoginAsync(string login, string password) {
            return base.Channel.LoginAsync(login, password);
        }
        
        public BlockchainExplorerDesktop.BlockchainService.Block[] GetChain() {
            return base.Channel.GetChain();
        }
        
        public System.Threading.Tasks.Task<BlockchainExplorerDesktop.BlockchainService.Block[]> GetChainAsync() {
            return base.Channel.GetChainAsync();
        }
    }
}