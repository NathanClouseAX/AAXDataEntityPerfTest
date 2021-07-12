﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 6/6/2021 9:11:38 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductRouteHeaderV2Single in the schema.
        /// </summary>
    public partial class EngineeringChangeOrderProductRouteHeaderV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductRouteHeaderV2>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteHeaderV2Single object.
        /// </summary>
        public EngineeringChangeOrderProductRouteHeaderV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteHeaderV2Single object.
        /// </summary>
        public EngineeringChangeOrderProductRouteHeaderV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteHeaderV2Single object.
        /// </summary>
        public EngineeringChangeOrderProductRouteHeaderV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductRouteHeaderV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringChangeOrderProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle EngineeringChangeOrderProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProduct == null))
                {
                    this._EngineeringChangeOrderProduct = new global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle(this.Context, GetPath("EngineeringChangeOrderProduct"));
                }
                return this._EngineeringChangeOrderProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle _EngineeringChangeOrderProduct;
        /// <summary>
        /// There are no comments for ApproverWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle ApproverWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ApproverWorker == null))
                {
                    this._ApproverWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("ApproverWorker"));
                }
                return this._ApproverWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _ApproverWorker;
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductRouteOperationsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationV2> EngineeringChangeOrderProductRouteOperationsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProductRouteOperationsV2 == null))
                {
                    this._EngineeringChangeOrderProductRouteOperationsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationV2>(GetPath("EngineeringChangeOrderProductRouteOperationsV2"));
                }
                return this._EngineeringChangeOrderProductRouteOperationsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationV2> _EngineeringChangeOrderProductRouteOperationsV2;
    }
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductRouteHeaderV2 in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// EngineeringChangeOrderNumber
    /// EngineeringChangeOrderProductLineNumber
    /// CreationSequenceNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "EngineeringChangeOrderNumber", "EngineeringChangeOrderProductLineNumber", "CreationSequenceNumber")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeOrderProductRouteHeadersV2")]
    public partial class EngineeringChangeOrderProductRouteHeaderV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeOrderProductRouteHeaderV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="engineeringChangeOrderNumber">Initial value of EngineeringChangeOrderNumber.</param>
        /// <param name="engineeringChangeOrderProductLineNumber">Initial value of EngineeringChangeOrderProductLineNumber.</param>
        /// <param name="creationSequenceNumber">Initial value of CreationSequenceNumber.</param>
        /// <param name="engineeringChangeOrderProduct">Initial value of EngineeringChangeOrderProduct.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeOrderProductRouteHeaderV2 CreateEngineeringChangeOrderProductRouteHeaderV2(string dataAreaId, string engineeringChangeOrderNumber, decimal engineeringChangeOrderProductLineNumber, int creationSequenceNumber, global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct engineeringChangeOrderProduct)
        {
            EngineeringChangeOrderProductRouteHeaderV2 engineeringChangeOrderProductRouteHeaderV2 = new EngineeringChangeOrderProductRouteHeaderV2();
            engineeringChangeOrderProductRouteHeaderV2.dataAreaId = dataAreaId;
            engineeringChangeOrderProductRouteHeaderV2.EngineeringChangeOrderNumber = engineeringChangeOrderNumber;
            engineeringChangeOrderProductRouteHeaderV2.EngineeringChangeOrderProductLineNumber = engineeringChangeOrderProductLineNumber;
            engineeringChangeOrderProductRouteHeaderV2.CreationSequenceNumber = creationSequenceNumber;
            if ((engineeringChangeOrderProduct == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangeOrderProduct");
            }
            engineeringChangeOrderProductRouteHeaderV2.EngineeringChangeOrderProduct = engineeringChangeOrderProduct;
            return engineeringChangeOrderProductRouteHeaderV2;
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
        /// There are no comments for Property CreationSequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int CreationSequenceNumber
        {
            get
            {
                return this._CreationSequenceNumber;
            }
            set
            {
                this.OnCreationSequenceNumberChanging(value);
                this._CreationSequenceNumber = value;
                this.OnCreationSequenceNumberChanged();
                this.OnPropertyChanged("CreationSequenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _CreationSequenceNumber;
        partial void OnCreationSequenceNumberChanging(int value);
        partial void OnCreationSequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductionSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductionSiteId
        {
            get
            {
                return this._ProductionSiteId;
            }
            set
            {
                this.OnProductionSiteIdChanging(value);
                this._ProductionSiteId = value;
                this.OnProductionSiteIdChanged();
                this.OnPropertyChanged("ProductionSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductionSiteId;
        partial void OnProductionSiteIdChanging(string value);
        partial void OnProductionSiteIdChanged();
        /// <summary>
        /// There are no comments for Property ProductGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductGroupId
        {
            get
            {
                return this._ProductGroupId;
            }
            set
            {
                this.OnProductGroupIdChanging(value);
                this._ProductGroupId = value;
                this.OnProductGroupIdChanged();
                this.OnPropertyChanged("ProductGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductGroupId;
        partial void OnProductGroupIdChanging(string value);
        partial void OnProductGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ApproverPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ApproverPersonnelNumber
        {
            get
            {
                return this._ApproverPersonnelNumber;
            }
            set
            {
                this.OnApproverPersonnelNumberChanging(value);
                this._ApproverPersonnelNumber = value;
                this.OnApproverPersonnelNumberChanged();
                this.OnPropertyChanged("ApproverPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ApproverPersonnelNumber;
        partial void OnApproverPersonnelNumberChanging(string value);
        partial void OnApproverPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property RouteName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RouteName
        {
            get
            {
                return this._RouteName;
            }
            set
            {
                this.OnRouteNameChanging(value);
                this._RouteName = value;
                this.OnRouteNameChanged();
                this.OnPropertyChanged("RouteName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RouteName;
        partial void OnRouteNameChanging(string value);
        partial void OnRouteNameChanged();
        /// <summary>
        /// There are no comments for Property RouteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RouteId
        {
            get
            {
                return this._RouteId;
            }
            set
            {
                this.OnRouteIdChanging(value);
                this._RouteId = value;
                this.OnRouteIdChanged();
                this.OnPropertyChanged("RouteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RouteId;
        partial void OnRouteIdChanging(string value);
        partial void OnRouteIdChanged();
        /// <summary>
        /// There are no comments for Property IsApproved in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsApproved
        {
            get
            {
                return this._IsApproved;
            }
            set
            {
                this.OnIsApprovedChanging(value);
                this._IsApproved = value;
                this.OnIsApprovedChanged();
                this.OnPropertyChanged("IsApproved");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsApproved;
        partial void OnIsApprovedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsApprovedChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct EngineeringChangeOrderProduct
        {
            get
            {
                return this._EngineeringChangeOrderProduct;
            }
            set
            {
                this.OnEngineeringChangeOrderProductChanging(value);
                this._EngineeringChangeOrderProduct = value;
                this.OnEngineeringChangeOrderProductChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct _EngineeringChangeOrderProduct;
        partial void OnEngineeringChangeOrderProductChanging(global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct value);
        partial void OnEngineeringChangeOrderProductChanged();
        /// <summary>
        /// There are no comments for Property ApproverWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker ApproverWorker
        {
            get
            {
                return this._ApproverWorker;
            }
            set
            {
                this.OnApproverWorkerChanging(value);
                this._ApproverWorker = value;
                this.OnApproverWorkerChanged();
                this.OnPropertyChanged("ApproverWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _ApproverWorker;
        partial void OnApproverWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnApproverWorkerChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationV2> EngineeringChangeOrderProductRouteOperationsV2
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationsV2;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationsV2Changing(value);
                this._EngineeringChangeOrderProductRouteOperationsV2 = value;
                this.OnEngineeringChangeOrderProductRouteOperationsV2Changed();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationV2> _EngineeringChangeOrderProductRouteOperationsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeOrderProductRouteOperationsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationV2> value);
        partial void OnEngineeringChangeOrderProductRouteOperationsV2Changed();
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
