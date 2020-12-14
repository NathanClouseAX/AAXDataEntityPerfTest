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
        /// There are no comments for RouteVersionSingle in the schema.
        /// </summary>
    public partial class RouteVersionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RouteVersion>
    {
        /// <summary>
        /// Initialize a new RouteVersionSingle object.
        /// </summary>
        public RouteVersionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RouteVersionSingle object.
        /// </summary>
        public RouteVersionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RouteVersionSingle object.
        /// </summary>
        public RouteVersionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RouteVersion> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RouteHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RouteHeaderSingle RouteHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RouteHeader == null))
                {
                    this._RouteHeader = new global::Microsoft.Dynamics.DataEntities.RouteHeaderSingle(this.Context, GetPath("RouteHeader"));
                }
                return this._RouteHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RouteHeaderSingle _RouteHeader;
        /// <summary>
        /// There are no comments for ApprovingWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle ApprovingWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ApprovingWorker == null))
                {
                    this._ApprovingWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("ApprovingWorker"));
                }
                return this._ApprovingWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _ApprovingWorker;
    }
        /// <summary>
        /// There are no comments for RouteVersion in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ValidFromQuantity
    /// ValidFromDate
    /// RouteId
    /// ProductSizeId
    /// ProductColorId
    /// ProductionSiteId
    /// ProductConfigurationId
    /// ProductStyleId
    /// ItemNumber
    /// IsActive
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ValidFromQuantity", "ValidFromDate", "RouteId", "ProductSizeId", "ProductColorId", "ProductionSiteId", "ProductConfigurationId", "ProductStyleId", "ItemNumber", "IsActive")]
    [global::Microsoft.OData.Client.EntitySet("RouteVersions")]
    public partial class RouteVersion : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RouteVersion object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="validFromQuantity">Initial value of ValidFromQuantity.</param>
        /// <param name="validFromDate">Initial value of ValidFromDate.</param>
        /// <param name="routeId">Initial value of RouteId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productionSiteId">Initial value of ProductionSiteId.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="isActive">Initial value of IsActive.</param>
        /// <param name="validToDate">Initial value of ValidToDate.</param>
        /// <param name="routeHeader">Initial value of RouteHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RouteVersion CreateRouteVersion(string dataAreaId, 
                    decimal validFromQuantity, 
                    global::System.DateTimeOffset validFromDate, 
                    string routeId, 
                    string productSizeId, 
                    string productColorId, 
                    string productionSiteId, 
                    string productConfigurationId, 
                    string productStyleId, 
                    string itemNumber, 
                    int isActive, 
                    global::System.DateTimeOffset validToDate, 
                    global::Microsoft.Dynamics.DataEntities.RouteHeader routeHeader)
        {
            RouteVersion routeVersion = new RouteVersion();
            routeVersion.dataAreaId = dataAreaId;
            routeVersion.ValidFromQuantity = validFromQuantity;
            routeVersion.ValidFromDate = validFromDate;
            routeVersion.RouteId = routeId;
            routeVersion.ProductSizeId = productSizeId;
            routeVersion.ProductColorId = productColorId;
            routeVersion.ProductionSiteId = productionSiteId;
            routeVersion.ProductConfigurationId = productConfigurationId;
            routeVersion.ProductStyleId = productStyleId;
            routeVersion.ItemNumber = itemNumber;
            routeVersion.IsActive = isActive;
            routeVersion.ValidToDate = validToDate;
            if ((routeHeader == null))
            {
                throw new global::System.ArgumentNullException("routeHeader");
            }
            routeVersion.RouteHeader = routeHeader;
            return routeVersion;
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
        /// There are no comments for Property ValidFromQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ValidFromQuantity
        {
            get
            {
                return this._ValidFromQuantity;
            }
            set
            {
                this.OnValidFromQuantityChanging(value);
                this._ValidFromQuantity = value;
                this.OnValidFromQuantityChanged();
                this.OnPropertyChanged("ValidFromQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ValidFromQuantity;
        partial void OnValidFromQuantityChanging(decimal value);
        partial void OnValidFromQuantityChanged();
        /// <summary>
        /// There are no comments for Property ValidFromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidFromDate
        {
            get
            {
                return this._ValidFromDate;
            }
            set
            {
                this.OnValidFromDateChanging(value);
                this._ValidFromDate = value;
                this.OnValidFromDateChanged();
                this.OnPropertyChanged("ValidFromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFromDate;
        partial void OnValidFromDateChanging(global::System.DateTimeOffset value);
        partial void OnValidFromDateChanged();
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
        /// There are no comments for Property ProductSizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductSizeId
        {
            get
            {
                return this._ProductSizeId;
            }
            set
            {
                this.OnProductSizeIdChanging(value);
                this._ProductSizeId = value;
                this.OnProductSizeIdChanged();
                this.OnPropertyChanged("ProductSizeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductSizeId;
        partial void OnProductSizeIdChanging(string value);
        partial void OnProductSizeIdChanged();
        /// <summary>
        /// There are no comments for Property ProductColorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductColorId
        {
            get
            {
                return this._ProductColorId;
            }
            set
            {
                this.OnProductColorIdChanging(value);
                this._ProductColorId = value;
                this.OnProductColorIdChanged();
                this.OnPropertyChanged("ProductColorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductColorId;
        partial void OnProductColorIdChanging(string value);
        partial void OnProductColorIdChanged();
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
        /// There are no comments for Property ProductConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductConfigurationId
        {
            get
            {
                return this._ProductConfigurationId;
            }
            set
            {
                this.OnProductConfigurationIdChanging(value);
                this._ProductConfigurationId = value;
                this.OnProductConfigurationIdChanged();
                this.OnPropertyChanged("ProductConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductConfigurationId;
        partial void OnProductConfigurationIdChanging(string value);
        partial void OnProductConfigurationIdChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductStyleId
        {
            get
            {
                return this._ProductStyleId;
            }
            set
            {
                this.OnProductStyleIdChanging(value);
                this._ProductStyleId = value;
                this.OnProductStyleIdChanged();
                this.OnPropertyChanged("ProductStyleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductStyleId;
        partial void OnProductStyleIdChanging(string value);
        partial void OnProductStyleIdChanged();
        /// <summary>
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemNumber
        {
            get
            {
                return this._ItemNumber;
            }
            set
            {
                this.OnItemNumberChanging(value);
                this._ItemNumber = value;
                this.OnItemNumberChanged();
                this.OnPropertyChanged("ItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumber;
        partial void OnItemNumberChanging(string value);
        partial void OnItemNumberChanged();
        /// <summary>
        /// There are no comments for Property IsActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                this.OnIsActiveChanging(value);
                this._IsActive = value;
                this.OnIsActiveChanged();
                this.OnPropertyChanged("IsActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _IsActive;
        partial void OnIsActiveChanging(int value);
        partial void OnIsActiveChanged();
        /// <summary>
        /// There are no comments for Property VersionName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VersionName
        {
            get
            {
                return this._VersionName;
            }
            set
            {
                this.OnVersionNameChanging(value);
                this._VersionName = value;
                this.OnVersionNameChanged();
                this.OnPropertyChanged("VersionName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VersionName;
        partial void OnVersionNameChanging(string value);
        partial void OnVersionNameChanged();
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
        /// There are no comments for Property ValidToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidToDate
        {
            get
            {
                return this._ValidToDate;
            }
            set
            {
                this.OnValidToDateChanging(value);
                this._ValidToDate = value;
                this.OnValidToDateChanged();
                this.OnPropertyChanged("ValidToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidToDate;
        partial void OnValidToDateChanging(global::System.DateTimeOffset value);
        partial void OnValidToDateChanged();
        /// <summary>
        /// There are no comments for Property RouteHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RouteHeader RouteHeader
        {
            get
            {
                return this._RouteHeader;
            }
            set
            {
                this.OnRouteHeaderChanging(value);
                this._RouteHeader = value;
                this.OnRouteHeaderChanged();
                this.OnPropertyChanged("RouteHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RouteHeader _RouteHeader;
        partial void OnRouteHeaderChanging(global::Microsoft.Dynamics.DataEntities.RouteHeader value);
        partial void OnRouteHeaderChanged();
        /// <summary>
        /// There are no comments for Property ApprovingWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker ApprovingWorker
        {
            get
            {
                return this._ApprovingWorker;
            }
            set
            {
                this.OnApprovingWorkerChanging(value);
                this._ApprovingWorker = value;
                this.OnApprovingWorkerChanged();
                this.OnPropertyChanged("ApprovingWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _ApprovingWorker;
        partial void OnApprovingWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnApprovingWorkerChanged();
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
        /// <summary>
        /// There are no comments for RemoveApproval in the schema.
        /// </summary>
        public virtual global::Microsoft.OData.Client.DataServiceActionQuery RemoveApproval()
        {
            global::Microsoft.OData.Client.EntityDescriptor resource = Context.EntityTracker.TryGetEntityDescriptor(this);
            if (resource == null)
            {
                throw new global::System.Exception("cannot find entity");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(this.Context, resource.EditLink.OriginalString.Trim('/') + "/Microsoft.Dynamics.DataEntities.RemoveApproval");
        }
        /// <summary>
        /// There are no comments for Activate in the schema.
        /// </summary>
        public virtual global::Microsoft.OData.Client.DataServiceActionQuery Activate()
        {
            global::Microsoft.OData.Client.EntityDescriptor resource = Context.EntityTracker.TryGetEntityDescriptor(this);
            if (resource == null)
            {
                throw new global::System.Exception("cannot find entity");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(this.Context, resource.EditLink.OriginalString.Trim('/') + "/Microsoft.Dynamics.DataEntities.Activate");
        }
        /// <summary>
        /// There are no comments for Approve in the schema.
        /// </summary>
        public virtual global::Microsoft.OData.Client.DataServiceActionQuery Approve(string _approverPersonnelNumber)
        {
            global::Microsoft.OData.Client.EntityDescriptor resource = Context.EntityTracker.TryGetEntityDescriptor(this);
            if (resource == null)
            {
                throw new global::System.Exception("cannot find entity");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(this.Context, resource.EditLink.OriginalString.Trim('/') + "/Microsoft.Dynamics.DataEntities.Approve", new global::Microsoft.OData.Client.BodyOperationParameter("_approverPersonnelNumber", _approverPersonnelNumber));
        }
    }
}
