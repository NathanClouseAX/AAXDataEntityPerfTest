﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 7/17/2021 8:49:18 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2Single in the schema.
        /// </summary>
    public partial class EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2Single object.
        /// </summary>
        public EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2Single object.
        /// </summary>
        public EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2Single object.
        /// </summary>
        public EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductRouteOperationPropertiesV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationPropertiesV2Single EngineeringChangeOrderProductRouteOperationPropertiesV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProductRouteOperationPropertiesV2 == null))
                {
                    this._EngineeringChangeOrderProductRouteOperationPropertiesV2 = new global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationPropertiesV2Single(this.Context, GetPath("EngineeringChangeOrderProductRouteOperationPropertiesV2"));
                }
                return this._EngineeringChangeOrderProductRouteOperationPropertiesV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationPropertiesV2Single _EngineeringChangeOrderProductRouteOperationPropertiesV2;
    }
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2 in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// EngineeringChangeOrderNumber
    /// EngineeringChangeOrderProductLineNumber
    /// EngineeringChangeOrderProductRouteHeaderCreationSequenceNumber
    /// EngineeringChangeOrderProductRouteOperationId
    /// EngineeringChangeOrderProductRouteOperationNumber
    /// EngineeringChangeOrderProductRouteOperationChangeType
    /// EngineeringChangeOrderProductRouteOperationPriority
    /// EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId
    /// EngineeringChangeOrderProductRouteOperationPropertiesRouteId
    /// EngineeringChangeOrderProductRouteOperationPropertiesItemNumber
    /// EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId
    /// EngineeringChangeOrderProductRouteOperationPropertiesChangeType
    /// DocumentId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "EngineeringChangeOrderNumber", "EngineeringChangeOrderProductLineNumber", "EngineeringChangeOrderProductRouteHeaderCreationSequenceNumber", "EngineeringChangeOrderProductRouteOperationId", "EngineeringChangeOrderProductRouteOperationNumber", "EngineeringChangeOrderProductRouteOperationChangeType", "EngineeringChangeOrderProductRouteOperationPriority", "EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId", "EngineeringChangeOrderProductRouteOperationPropertiesRouteId", "EngineeringChangeOrderProductRouteOperationPropertiesItemNumber", "EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId", "EngineeringChangeOrderProductRouteOperationPropertiesChangeType", "DocumentId")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeOrderProductRouteOperationPropertiesDocumentsV2")]
    public partial class EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="engineeringChangeOrderNumber">Initial value of EngineeringChangeOrderNumber.</param>
        /// <param name="engineeringChangeOrderProductLineNumber">Initial value of EngineeringChangeOrderProductLineNumber.</param>
        /// <param name="engineeringChangeOrderProductRouteHeaderCreationSequenceNumber">Initial value of EngineeringChangeOrderProductRouteHeaderCreationSequenceNumber.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationId">Initial value of EngineeringChangeOrderProductRouteOperationId.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationNumber">Initial value of EngineeringChangeOrderProductRouteOperationNumber.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId">Initial value of EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationPropertiesRouteId">Initial value of EngineeringChangeOrderProductRouteOperationPropertiesRouteId.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationPropertiesItemNumber">Initial value of EngineeringChangeOrderProductRouteOperationPropertiesItemNumber.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationPropertiesProductGroupId">Initial value of EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId.</param>
        /// <param name="documentId">Initial value of DocumentId.</param>
        /// <param name="sequenceNumber">Initial value of SequenceNumber.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationPropertiesV2">Initial value of EngineeringChangeOrderProductRouteOperationPropertiesV2.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2 CreateEngineeringChangeOrderProductRouteOperationPropertiesDocumentV2(string dataAreaId, 
                    string engineeringChangeOrderNumber, 
                    decimal engineeringChangeOrderProductLineNumber, 
                    int engineeringChangeOrderProductRouteHeaderCreationSequenceNumber, 
                    string engineeringChangeOrderProductRouteOperationId, 
                    int engineeringChangeOrderProductRouteOperationNumber, 
                    string engineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId, 
                    string engineeringChangeOrderProductRouteOperationPropertiesRouteId, 
                    string engineeringChangeOrderProductRouteOperationPropertiesItemNumber, 
                    string engineeringChangeOrderProductRouteOperationPropertiesProductGroupId, 
                    global::System.Guid documentId, 
                    decimal sequenceNumber, 
                    global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationPropertiesV2 engineeringChangeOrderProductRouteOperationPropertiesV2)
        {
            EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2 engineeringChangeOrderProductRouteOperationPropertiesDocumentV2 = new EngineeringChangeOrderProductRouteOperationPropertiesDocumentV2();
            engineeringChangeOrderProductRouteOperationPropertiesDocumentV2.dataAreaId = dataAreaId;
            engineeringChangeOrderProductRouteOperationPropertiesDocumentV2.EngineeringChangeOrderNumber = engineeringChangeOrderNumber;
            engineeringChangeOrderProductRouteOperationPropertiesDocumentV2.EngineeringChangeOrderProductLineNumber = engineeringChangeOrderProductLineNumber;
            engineeringChangeOrderProductRouteOperationPropertiesDocumentV2.EngineeringChangeOrderProductRouteHeaderCreationSequenceNumber = engineeringChangeOrderProductRouteHeaderCreationSequenceNumber;
            engineeringChangeOrderProductRouteOperationPropertiesDocumentV2.EngineeringChangeOrderProductRouteOperationId = engineeringChangeOrderProductRouteOperationId;
            engineeringChangeOrderProductRouteOperationPropertiesDocumentV2.EngineeringChangeOrderProductRouteOperationNumber = engineeringChangeOrderProductRouteOperationNumber;
            engineeringChangeOrderProductRouteOperationPropertiesDocumentV2.EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId = engineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId;
            engineeringChangeOrderProductRouteOperationPropertiesDocumentV2.EngineeringChangeOrderProductRouteOperationPropertiesRouteId = engineeringChangeOrderProductRouteOperationPropertiesRouteId;
            engineeringChangeOrderProductRouteOperationPropertiesDocumentV2.EngineeringChangeOrderProductRouteOperationPropertiesItemNumber = engineeringChangeOrderProductRouteOperationPropertiesItemNumber;
            engineeringChangeOrderProductRouteOperationPropertiesDocumentV2.EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId = engineeringChangeOrderProductRouteOperationPropertiesProductGroupId;
            engineeringChangeOrderProductRouteOperationPropertiesDocumentV2.DocumentId = documentId;
            engineeringChangeOrderProductRouteOperationPropertiesDocumentV2.SequenceNumber = sequenceNumber;
            if ((engineeringChangeOrderProductRouteOperationPropertiesV2 == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangeOrderProductRouteOperationPropertiesV2");
            }
            engineeringChangeOrderProductRouteOperationPropertiesDocumentV2.EngineeringChangeOrderProductRouteOperationPropertiesV2 = engineeringChangeOrderProductRouteOperationPropertiesV2;
            return engineeringChangeOrderProductRouteOperationPropertiesDocumentV2;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string dataAreaId
        {
            get
            {
                return this._dataAreaId;
            }
            set
            {
                this.OndataAreaIdChanging(value);
                this._dataAreaId = value;
                this.OndataAreaIdChanged();
                this.OnPropertyChanged("dataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _dataAreaId;
        partial void OndataAreaIdChanging(string value);
        partial void OndataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderNumber
        {
            get
            {
                return this._EngineeringChangeOrderNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderNumberChanging(value);
                this._EngineeringChangeOrderNumber = value;
                this.OnEngineeringChangeOrderNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderNumber;
        partial void OnEngineeringChangeOrderNumberChanging(string value);
        partial void OnEngineeringChangeOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal EngineeringChangeOrderProductLineNumber
        {
            get
            {
                return this._EngineeringChangeOrderProductLineNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderProductLineNumberChanging(value);
                this._EngineeringChangeOrderProductLineNumber = value;
                this.OnEngineeringChangeOrderProductLineNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _EngineeringChangeOrderProductLineNumber;
        partial void OnEngineeringChangeOrderProductLineNumberChanging(decimal value);
        partial void OnEngineeringChangeOrderProductLineNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteHeaderCreationSequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int EngineeringChangeOrderProductRouteHeaderCreationSequenceNumber
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteHeaderCreationSequenceNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteHeaderCreationSequenceNumberChanging(value);
                this._EngineeringChangeOrderProductRouteHeaderCreationSequenceNumber = value;
                this.OnEngineeringChangeOrderProductRouteHeaderCreationSequenceNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteHeaderCreationSequenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _EngineeringChangeOrderProductRouteHeaderCreationSequenceNumber;
        partial void OnEngineeringChangeOrderProductRouteHeaderCreationSequenceNumberChanging(int value);
        partial void OnEngineeringChangeOrderProductRouteHeaderCreationSequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderProductRouteOperationId
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationId;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationIdChanging(value);
                this._EngineeringChangeOrderProductRouteOperationId = value;
                this.OnEngineeringChangeOrderProductRouteOperationIdChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderProductRouteOperationId;
        partial void OnEngineeringChangeOrderProductRouteOperationIdChanging(string value);
        partial void OnEngineeringChangeOrderProductRouteOperationIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int EngineeringChangeOrderProductRouteOperationNumber
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationNumberChanging(value);
                this._EngineeringChangeOrderProductRouteOperationNumber = value;
                this.OnEngineeringChangeOrderProductRouteOperationNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _EngineeringChangeOrderProductRouteOperationNumber;
        partial void OnEngineeringChangeOrderProductRouteOperationNumberChanging(int value);
        partial void OnEngineeringChangeOrderProductRouteOperationNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationChangeType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmChangeTypes> EngineeringChangeOrderProductRouteOperationChangeType
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationChangeType;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationChangeTypeChanging(value);
                this._EngineeringChangeOrderProductRouteOperationChangeType = value;
                this.OnEngineeringChangeOrderProductRouteOperationChangeTypeChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationChangeType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmChangeTypes> _EngineeringChangeOrderProductRouteOperationChangeType;
        partial void OnEngineeringChangeOrderProductRouteOperationChangeTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmChangeTypes> value);
        partial void OnEngineeringChangeOrderProductRouteOperationChangeTypeChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationPriority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RouteOprPriority> EngineeringChangeOrderProductRouteOperationPriority
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationPriority;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationPriorityChanging(value);
                this._EngineeringChangeOrderProductRouteOperationPriority = value;
                this.OnEngineeringChangeOrderProductRouteOperationPriorityChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationPriority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RouteOprPriority> _EngineeringChangeOrderProductRouteOperationPriority;
        partial void OnEngineeringChangeOrderProductRouteOperationPriorityChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RouteOprPriority> value);
        partial void OnEngineeringChangeOrderProductRouteOperationPriorityChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationIdChanging(value);
                this._EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId = value;
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationIdChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId;
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationIdChanging(string value);
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationPropertiesRouteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderProductRouteOperationPropertiesRouteId
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationPropertiesRouteId;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesRouteIdChanging(value);
                this._EngineeringChangeOrderProductRouteOperationPropertiesRouteId = value;
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesRouteIdChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationPropertiesRouteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderProductRouteOperationPropertiesRouteId;
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesRouteIdChanging(string value);
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesRouteIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationPropertiesItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderProductRouteOperationPropertiesItemNumber
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationPropertiesItemNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesItemNumberChanging(value);
                this._EngineeringChangeOrderProductRouteOperationPropertiesItemNumber = value;
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesItemNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationPropertiesItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderProductRouteOperationPropertiesItemNumber;
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesItemNumberChanging(string value);
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesItemNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesProductGroupIdChanging(value);
                this._EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId = value;
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesProductGroupIdChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId;
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesProductGroupIdChanging(string value);
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesProductGroupIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationPropertiesChangeType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmChangeTypes> EngineeringChangeOrderProductRouteOperationPropertiesChangeType
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationPropertiesChangeType;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesChangeTypeChanging(value);
                this._EngineeringChangeOrderProductRouteOperationPropertiesChangeType = value;
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesChangeTypeChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationPropertiesChangeType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmChangeTypes> _EngineeringChangeOrderProductRouteOperationPropertiesChangeType;
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesChangeTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmChangeTypes> value);
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesChangeTypeChanged();
        /// <summary>
        /// There are no comments for Property DocumentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid DocumentId
        {
            get
            {
                return this._DocumentId;
            }
            set
            {
                this.OnDocumentIdChanging(value);
                this._DocumentId = value;
                this.OnDocumentIdChanged();
                this.OnPropertyChanged("DocumentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _DocumentId;
        partial void OnDocumentIdChanging(global::System.Guid value);
        partial void OnDocumentIdChanged();
        /// <summary>
        /// There are no comments for Property SequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SequenceNumber
        {
            get
            {
                return this._SequenceNumber;
            }
            set
            {
                this.OnSequenceNumberChanging(value);
                this._SequenceNumber = value;
                this.OnSequenceNumberChanged();
                this.OnPropertyChanged("SequenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SequenceNumber;
        partial void OnSequenceNumberChanging(decimal value);
        partial void OnSequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property DocumentModificationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmChangeTypes> DocumentModificationType
        {
            get
            {
                return this._DocumentModificationType;
            }
            set
            {
                this.OnDocumentModificationTypeChanging(value);
                this._DocumentModificationType = value;
                this.OnDocumentModificationTypeChanged();
                this.OnPropertyChanged("DocumentModificationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmChangeTypes> _DocumentModificationType;
        partial void OnDocumentModificationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmChangeTypes> value);
        partial void OnDocumentModificationTypeChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationPropertiesV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationPropertiesV2 EngineeringChangeOrderProductRouteOperationPropertiesV2
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationPropertiesV2;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesV2Changing(value);
                this._EngineeringChangeOrderProductRouteOperationPropertiesV2 = value;
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesV2Changed();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationPropertiesV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationPropertiesV2 _EngineeringChangeOrderProductRouteOperationPropertiesV2;
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesV2Changing(global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationPropertiesV2 value);
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesV2Changed();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}