﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectClient.ServerProject {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServerProject.IMiniDB")]
    public interface IMiniDB {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMiniDB/ReadFile", ReplyAction="http://tempuri.org/IMiniDB/ReadFileResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ProjectClient.ServerProject.ReadFileResponse ReadFile(ProjectClient.ServerProject.ReadFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMiniDB/ReadFile", ReplyAction="http://tempuri.org/IMiniDB/ReadFileResponse")]
        System.Threading.Tasks.Task<ProjectClient.ServerProject.ReadFileResponse> ReadFileAsync(ProjectClient.ServerProject.ReadFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMiniDB/SaveFile", ReplyAction="http://tempuri.org/IMiniDB/SaveFileResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool SaveFile(System.Data.DataTable table);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMiniDB/SaveFile", ReplyAction="http://tempuri.org/IMiniDB/SaveFileResponse")]
        System.Threading.Tasks.Task<bool> SaveFileAsync(System.Data.DataTable table);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMiniDB/GetListName", ReplyAction="http://tempuri.org/IMiniDB/GetListNameResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ProjectClient.ServerProject.ListNamesResponse GetListName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMiniDB/GetListName", ReplyAction="http://tempuri.org/IMiniDB/GetListNameResponse")]
        System.Threading.Tasks.Task<ProjectClient.ServerProject.ListNamesResponse> GetListNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMiniDB/GetSummary", ReplyAction="http://tempuri.org/IMiniDB/GetSummaryResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ProjectClient.ServerProject.SummaryDataResponse GetSummary(ProjectClient.ServerProject.SummaryDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMiniDB/GetSummary", ReplyAction="http://tempuri.org/IMiniDB/GetSummaryResponse")]
        System.Threading.Tasks.Task<ProjectClient.ServerProject.SummaryDataResponse> GetSummaryAsync(ProjectClient.ServerProject.SummaryDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMiniDB/GetFile", ReplyAction="http://tempuri.org/IMiniDB/GetFileResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ProjectClient.ServerProject.FileTransferResponse GetFile(ProjectClient.ServerProject.FileTransferRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMiniDB/GetFile", ReplyAction="http://tempuri.org/IMiniDB/GetFileResponse")]
        System.Threading.Tasks.Task<ProjectClient.ServerProject.FileTransferResponse> GetFileAsync(ProjectClient.ServerProject.FileTransferRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ReadFileRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameFileField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string NameFile {
            get {
                return this.nameFileField;
            }
            set {
                this.nameFileField = value;
                this.RaisePropertyChanged("NameFile");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class FileTransferResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameFileField;
        
        private byte[] fileField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string NameFile {
            get {
                return this.nameFileField;
            }
            set {
                this.nameFileField = value;
                this.RaisePropertyChanged("NameFile");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=1)]
        public byte[] File {
            get {
                return this.fileField;
            }
            set {
                this.fileField = value;
                this.RaisePropertyChanged("File");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class FileTransferRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string fileNameField;
        
        private FileType fileTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string FileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
                this.RaisePropertyChanged("FileName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public FileType FileType {
            get {
                return this.fileTypeField;
            }
            set {
                this.fileTypeField = value;
                this.RaisePropertyChanged("FileType");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum FileType {
        
        /// <remarks/>
        XML,
        
        /// <remarks/>
        CSV,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class GroupByList : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private double resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public double Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
                this.RaisePropertyChanged("Result");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SummaryDataResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string fileNameField;
        
        private string columnNameField;
        
        private OperationOnTable operationField;
        
        private System.Nullable<double> valueField;
        
        private GroupByList[] listValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string FileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
                this.RaisePropertyChanged("FileName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ColumnName {
            get {
                return this.columnNameField;
            }
            set {
                this.columnNameField = value;
                this.RaisePropertyChanged("ColumnName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public OperationOnTable Operation {
            get {
                return this.operationField;
            }
            set {
                this.operationField = value;
                this.RaisePropertyChanged("Operation");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<double> Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public GroupByList[] ListValue {
            get {
                return this.listValueField;
            }
            set {
                this.listValueField = value;
                this.RaisePropertyChanged("ListValue");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum OperationOnTable {
        
        /// <remarks/>
        SUM,
        
        /// <remarks/>
        AVG,
        
        /// <remarks/>
        COUNT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SummaryDataRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string fileNameField;
        
        private string columnNameField;
        
        private string groupColumnNameField;
        
        private OperationOnTable operationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string FileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
                this.RaisePropertyChanged("FileName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ColumnName {
            get {
                return this.columnNameField;
            }
            set {
                this.columnNameField = value;
                this.RaisePropertyChanged("ColumnName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string GroupColumnName {
            get {
                return this.groupColumnNameField;
            }
            set {
                this.groupColumnNameField = value;
                this.RaisePropertyChanged("GroupColumnName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public OperationOnTable Operation {
            get {
                return this.operationField;
            }
            set {
                this.operationField = value;
                this.RaisePropertyChanged("Operation");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ListNamesResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string[] listNamesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public string[] ListNames {
            get {
                return this.listNamesField;
            }
            set {
                this.listNamesField = value;
                this.RaisePropertyChanged("ListNames");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ReadFileResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Data.DataTable resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Data.DataTable Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
                this.RaisePropertyChanged("Result");
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
    public interface IMiniDBChannel : ProjectClient.ServerProject.IMiniDB, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MiniDBClient : System.ServiceModel.ClientBase<ProjectClient.ServerProject.IMiniDB>, ProjectClient.ServerProject.IMiniDB {
        
        public MiniDBClient() {
        }
        
        public MiniDBClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MiniDBClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MiniDBClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MiniDBClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ProjectClient.ServerProject.ReadFileResponse ReadFile(ProjectClient.ServerProject.ReadFileRequest request) {
            return base.Channel.ReadFile(request);
        }
        
        public System.Threading.Tasks.Task<ProjectClient.ServerProject.ReadFileResponse> ReadFileAsync(ProjectClient.ServerProject.ReadFileRequest request) {
            return base.Channel.ReadFileAsync(request);
        }
        
        public bool SaveFile(System.Data.DataTable table) {
            return base.Channel.SaveFile(table);
        }
        
        public System.Threading.Tasks.Task<bool> SaveFileAsync(System.Data.DataTable table) {
            return base.Channel.SaveFileAsync(table);
        }
        
        public ProjectClient.ServerProject.ListNamesResponse GetListName() {
            return base.Channel.GetListName();
        }
        
        public System.Threading.Tasks.Task<ProjectClient.ServerProject.ListNamesResponse> GetListNameAsync() {
            return base.Channel.GetListNameAsync();
        }
        
        public ProjectClient.ServerProject.SummaryDataResponse GetSummary(ProjectClient.ServerProject.SummaryDataRequest request) {
            return base.Channel.GetSummary(request);
        }
        
        public System.Threading.Tasks.Task<ProjectClient.ServerProject.SummaryDataResponse> GetSummaryAsync(ProjectClient.ServerProject.SummaryDataRequest request) {
            return base.Channel.GetSummaryAsync(request);
        }
        
        public ProjectClient.ServerProject.FileTransferResponse GetFile(ProjectClient.ServerProject.FileTransferRequest request) {
            return base.Channel.GetFile(request);
        }
        
        public System.Threading.Tasks.Task<ProjectClient.ServerProject.FileTransferResponse> GetFileAsync(ProjectClient.ServerProject.FileTransferRequest request) {
            return base.Channel.GetFileAsync(request);
        }
    }
}
