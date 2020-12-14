﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 12/8/2020 7:45:22 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductRouteOperationSingle in the schema.
        /// </summary>
    public partial class EngineeringChangeOrderProductRouteOperationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductRouteOperation>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteOperationSingle object.
        /// </summary>
        public EngineeringChangeOrderProductRouteOperationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteOperationSingle object.
        /// </summary>
        public EngineeringChangeOrderProductRouteOperationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteOperationSingle object.
        /// </summary>
        public EngineeringChangeOrderProductRouteOperationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductRouteOperation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductRouteOperationProperties in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationProperties> EngineeringChangeOrderProductRouteOperationProperties
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProductRouteOperationProperties == null))
                {
                    this._EngineeringChangeOrderProductRouteOperationProperties = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationProperties>(GetPath("EngineeringChangeOrderProductRouteOperationProperties"));
                }
                return this._EngineeringChangeOrderProductRouteOperationProperties;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationProperties> _EngineeringChangeOrderProductRouteOperationProperties;
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductRouteHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteHeaderSingle EngineeringChangeOrderProductRouteHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProductRouteHeader == null))
                {
                    this._EngineeringChangeOrderProductRouteHeader = new global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteHeaderSingle(this.Context, GetPath("EngineeringChangeOrderProductRouteHeader"));
                }
                return this._EngineeringChangeOrderProductRouteHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteHeaderSingle _EngineeringChangeOrderProductRouteHeader;
    }
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductRouteOperation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// OperationId
    /// OperationNumber
    /// EngineeringChangeOrderProductRouteId
    /// OperationPriority
    /// EngineeringChangeOrderNumber
    /// EngineeringChangeOrderProductLineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "OperationId", "OperationNumber", "EngineeringChangeOrderProductRouteId", "OperationPriority", "EngineeringChangeOrderNumber", "EngineeringChangeOrderProductLineNumber")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeOrderProductRouteOperations")]
    public partial class EngineeringChangeOrderProductRouteOperation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeOrderProductRouteOperation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="operationId">Initial value of OperationId.</param>
        /// <param name="operationNumber">Initial value of OperationNumber.</param>
        /// <param name="engineeringChangeOrderProductRouteId">Initial value of EngineeringChangeOrderProductRouteId.</param>
        /// <param name="engineeringChangeOrderNumber">Initial value of EngineeringChangeOrderNumber.</param>
        /// <param name="engineeringChangeOrderProductLineNumber">Initial value of EngineeringChangeOrderProductLineNumber.</param>
        /// <param name="accumulatedScrapPercentage">Initial value of AccumulatedScrapPercentage.</param>
        /// <param name="operationSequence">Initial value of OperationSequence.</param>
        /// <param name="nextRouteOperationNumber">Initial value of NextRouteOperationNumber.</param>
        /// <param name="scrapPercentage">Initial value of ScrapPercentage.</param>
        /// <param name="engineeringChangeOrderProductRouteHeader">Initial value of EngineeringChangeOrderProductRouteHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeOrderProductRouteOperation CreateEngineeringChangeOrderProductRouteOperation(string dataAreaId, 
                    string operationId, 
                    int operationNumber, 
                    string engineeringChangeOrderProductRouteId, 
                    string engineeringChangeOrderNumber, 
                    decimal engineeringChangeOrderProductLineNumber, 
                    decimal accumulatedScrapPercentage, 
                    int operationSequence, 
                    int nextRouteOperationNumber, 
                    decimal scrapPercentage, 
                    global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteHeader engineeringChangeOrderProductRouteHeader)
        {
            EngineeringChangeOrderProductRouteOperation engineeringChangeOrderProductRouteOperation = new EngineeringChangeOrderProductRouteOperation();
            engineeringChangeOrderProductRouteOperation.dataAreaId = dataAreaId;
            engineeringChangeOrderProductRouteOperation.OperationId = operationId;
            engineeringChangeOrderProductRouteOperation.OperationNumber = operationNumber;
            engineeringChangeOrderProductRouteOperation.EngineeringChangeOrderProductRouteId = engineeringChangeOrderProductRouteId;
            engineeringChangeOrderProductRouteOperation.EngineeringChangeOrderNumber = engineeringChangeOrderNumber;
            engineeringChangeOrderProductRouteOperation.EngineeringChangeOrderProductLineNumber = engineeringChangeOrderProductLineNumber;
            engineeringChangeOrderProductRouteOperation.AccumulatedScrapPercentage = accumulatedScrapPercentage;
            engineeringChangeOrderProductRouteOperation.OperationSequence = operationSequence;
            engineeringChangeOrderProductRouteOperation.NextRouteOperationNumber = nextRouteOperationNumber;
            engineeringChangeOrderProductRouteOperation.ScrapPercentage = scrapPercentage;
            if ((engineeringChangeOrderProductRouteHeader == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangeOrderProductRouteHeader");
            }
            engineeringChangeOrderProductRouteOperation.EngineeringChangeOrderProductRouteHeader = engineeringChangeOrderProductRouteHeader;
            return engineeringChangeOrderProductRouteOperation;
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
        /// There are no comments for Property OperationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OperationId
        {
            get
            {
                return this._OperationId;
            }
            set
            {
                this.OnOperationIdChanging(value);
                this._OperationId = value;
                this.OnOperationIdChanged();
                this.OnPropertyChanged("OperationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperationId;
        partial void OnOperationIdChanging(string value);
        partial void OnOperationIdChanged();
        /// <summary>
        /// There are no comments for Property OperationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int OperationNumber
        {
            get
            {
                return this._OperationNumber;
            }
            set
            {
                this.OnOperationNumberChanging(value);
                this._OperationNumber = value;
                this.OnOperationNumberChanged();
                this.OnPropertyChanged("OperationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _OperationNumber;
        partial void OnOperationNumberChanging(int value);
        partial void OnOperationNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderProductRouteId
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteId;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteIdChanging(value);
                this._EngineeringChangeOrderProductRouteId = value;
                this.OnEngineeringChangeOrderProductRouteIdChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderProductRouteId;
        partial void OnEngineeringChangeOrderProductRouteIdChanging(string value);
        partial void OnEngineeringChangeOrderProductRouteIdChanged();
        /// <summary>
        /// There are no comments for Property OperationPriority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RouteOprPriority> OperationPriority
        {
            get
            {
                return this._OperationPriority;
            }
            set
            {
                this.OnOperationPriorityChanging(value);
                this._OperationPriority = value;
                this.OnOperationPriorityChanged();
                this.OnPropertyChanged("OperationPriority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RouteOprPriority> _OperationPriority;
        partial void OnOperationPriorityChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RouteOprPriority> value);
        partial void OnOperationPriorityChanged();
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
        /// There are no comments for Property AccumulatedScrapPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AccumulatedScrapPercentage
        {
            get
            {
                return this._AccumulatedScrapPercentage;
            }
            set
            {
                this.OnAccumulatedScrapPercentageChanging(value);
                this._AccumulatedScrapPercentage = value;
                this.OnAccumulatedScrapPercentageChanged();
                this.OnPropertyChanged("AccumulatedScrapPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AccumulatedScrapPercentage;
        partial void OnAccumulatedScrapPercentageChanging(decimal value);
        partial void OnAccumulatedScrapPercentageChanged();
        /// <summary>
        /// There are no comments for Property OperationSequence in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int OperationSequence
        {
            get
            {
                return this._OperationSequence;
            }
            set
            {
                this.OnOperationSequenceChanging(value);
                this._OperationSequence = value;
                this.OnOperationSequenceChanged();
                this.OnPropertyChanged("OperationSequence");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _OperationSequence;
        partial void OnOperationSequenceChanging(int value);
        partial void OnOperationSequenceChanged();
        /// <summary>
        /// There are no comments for Property NextRouteOperationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int NextRouteOperationNumber
        {
            get
            {
                return this._NextRouteOperationNumber;
            }
            set
            {
                this.OnNextRouteOperationNumberChanging(value);
                this._NextRouteOperationNumber = value;
                this.OnNextRouteOperationNumberChanged();
                this.OnPropertyChanged("NextRouteOperationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NextRouteOperationNumber;
        partial void OnNextRouteOperationNumberChanging(int value);
        partial void OnNextRouteOperationNumberChanged();
        /// <summary>
        /// There are no comments for Property ScrapPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ScrapPercentage
        {
            get
            {
                return this._ScrapPercentage;
            }
            set
            {
                this.OnScrapPercentageChanging(value);
                this._ScrapPercentage = value;
                this.OnScrapPercentageChanged();
                this.OnPropertyChanged("ScrapPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ScrapPercentage;
        partial void OnScrapPercentageChanging(decimal value);
        partial void OnScrapPercentageChanged();
        /// <summary>
        /// There are no comments for Property OperationRateMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JmgJobPayTypeEnum> OperationRateMethod
        {
            get
            {
                return this._OperationRateMethod;
            }
            set
            {
                this.OnOperationRateMethodChanging(value);
                this._OperationRateMethod = value;
                this.OnOperationRateMethodChanged();
                this.OnPropertyChanged("OperationRateMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JmgJobPayTypeEnum> _OperationRateMethod;
        partial void OnOperationRateMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JmgJobPayTypeEnum> value);
        partial void OnOperationRateMethodChanged();
        /// <summary>
        /// There are no comments for Property NextOperationLinkType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SchedJobLinkType> NextOperationLinkType
        {
            get
            {
                return this._NextOperationLinkType;
            }
            set
            {
                this.OnNextOperationLinkTypeChanging(value);
                this._NextOperationLinkType = value;
                this.OnNextOperationLinkTypeChanged();
                this.OnPropertyChanged("NextOperationLinkType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SchedJobLinkType> _NextOperationLinkType;
        partial void OnNextOperationLinkTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SchedJobLinkType> value);
        partial void OnNextOperationLinkTypeChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteProductionSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderProductRouteProductionSiteId
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteProductionSiteId;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteProductionSiteIdChanging(value);
                this._EngineeringChangeOrderProductRouteProductionSiteId = value;
                this.OnEngineeringChangeOrderProductRouteProductionSiteIdChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteProductionSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderProductRouteProductionSiteId;
        partial void OnEngineeringChangeOrderProductRouteProductionSiteIdChanging(string value);
        partial void OnEngineeringChangeOrderProductRouteProductionSiteIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationProperties in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationProperties> EngineeringChangeOrderProductRouteOperationProperties
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationProperties;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesChanging(value);
                this._EngineeringChangeOrderProductRouteOperationProperties = value;
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationProperties");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationProperties> _EngineeringChangeOrderProductRouteOperationProperties = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationProperties>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationProperties> value);
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteHeader EngineeringChangeOrderProductRouteHeader
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteHeader;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteHeaderChanging(value);
                this._EngineeringChangeOrderProductRouteHeader = value;
                this.OnEngineeringChangeOrderProductRouteHeaderChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteHeader _EngineeringChangeOrderProductRouteHeader;
        partial void OnEngineeringChangeOrderProductRouteHeaderChanging(global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteHeader value);
        partial void OnEngineeringChangeOrderProductRouteHeaderChanged();
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
