﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/3/2021 8:21:45 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for AssetMaintenanceRequestSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceRequestSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceRequest>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceRequestSingle object.
        /// </summary>
        public AssetMaintenanceRequestSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceRequestSingle object.
        /// </summary>
        public AssetMaintenanceRequestSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceRequestSingle object.
        /// </summary>
        public AssetMaintenanceRequestSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceRequest> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceAssetCalendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> AssetMaintenanceAssetCalendar
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetCalendar == null))
                {
                    this._AssetMaintenanceAssetCalendar = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar>(GetPath("AssetMaintenanceAssetCalendar"));
                }
                return this._AssetMaintenanceAssetCalendar;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> _AssetMaintenanceAssetCalendar;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceRequest in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RequestId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RequestId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceRequests")]
    public partial class AssetMaintenanceRequest : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceRequest object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="requestId">Initial value of RequestId.</param>
        /// <param name="productionStopFrom">Initial value of ProductionStopFrom.</param>
        /// <param name="actualStart">Initial value of ActualStart.</param>
        /// <param name="workOrderPriority">Initial value of WorkOrderPriority.</param>
        /// <param name="addressLatitude">Initial value of AddressLatitude.</param>
        /// <param name="actualEnd">Initial value of ActualEnd.</param>
        /// <param name="addressLongitude">Initial value of AddressLongitude.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceRequest CreateAssetMaintenanceRequest(string dataAreaId, 
                    string requestId, 
                    global::System.DateTimeOffset productionStopFrom, 
                    global::System.DateTimeOffset actualStart, 
                    int workOrderPriority, 
                    decimal addressLatitude, 
                    global::System.DateTimeOffset actualEnd, 
                    decimal addressLongitude)
        {
            AssetMaintenanceRequest assetMaintenanceRequest = new AssetMaintenanceRequest();
            assetMaintenanceRequest.dataAreaId = dataAreaId;
            assetMaintenanceRequest.RequestId = requestId;
            assetMaintenanceRequest.ProductionStopFrom = productionStopFrom;
            assetMaintenanceRequest.ActualStart = actualStart;
            assetMaintenanceRequest.WorkOrderPriority = workOrderPriority;
            assetMaintenanceRequest.AddressLatitude = addressLatitude;
            assetMaintenanceRequest.ActualEnd = actualEnd;
            assetMaintenanceRequest.AddressLongitude = addressLongitude;
            return assetMaintenanceRequest;
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
        /// There are no comments for Property RequestId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RequestId
        {
            get
            {
                return this._RequestId;
            }
            set
            {
                this.OnRequestIdChanging(value);
                this._RequestId = value;
                this.OnRequestIdChanged();
                this.OnPropertyChanged("RequestId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequestId;
        partial void OnRequestIdChanging(string value);
        partial void OnRequestIdChanged();
        /// <summary>
        /// There are no comments for Property ProductionStopFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ProductionStopFrom
        {
            get
            {
                return this._ProductionStopFrom;
            }
            set
            {
                this.OnProductionStopFromChanging(value);
                this._ProductionStopFrom = value;
                this.OnProductionStopFromChanged();
                this.OnPropertyChanged("ProductionStopFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ProductionStopFrom;
        partial void OnProductionStopFromChanging(global::System.DateTimeOffset value);
        partial void OnProductionStopFromChanged();
        /// <summary>
        /// There are no comments for Property ActualStart in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ActualStart
        {
            get
            {
                return this._ActualStart;
            }
            set
            {
                this.OnActualStartChanging(value);
                this._ActualStart = value;
                this.OnActualStartChanged();
                this.OnPropertyChanged("ActualStart");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ActualStart;
        partial void OnActualStartChanging(global::System.DateTimeOffset value);
        partial void OnActualStartChanged();
        /// <summary>
        /// There are no comments for Property StartedByWorkerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string StartedByWorkerPersonnelNumber
        {
            get
            {
                return this._StartedByWorkerPersonnelNumber;
            }
            set
            {
                this.OnStartedByWorkerPersonnelNumberChanging(value);
                this._StartedByWorkerPersonnelNumber = value;
                this.OnStartedByWorkerPersonnelNumberChanged();
                this.OnPropertyChanged("StartedByWorkerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StartedByWorkerPersonnelNumber;
        partial void OnStartedByWorkerPersonnelNumberChanging(string value);
        partial void OnStartedByWorkerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property JobVariantId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobVariantId
        {
            get
            {
                return this._JobVariantId;
            }
            set
            {
                this.OnJobVariantIdChanging(value);
                this._JobVariantId = value;
                this.OnJobVariantIdChanged();
                this.OnPropertyChanged("JobVariantId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobVariantId;
        partial void OnJobVariantIdChanging(string value);
        partial void OnJobVariantIdChanged();
        /// <summary>
        /// There are no comments for Property WorkOrderPriority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int WorkOrderPriority
        {
            get
            {
                return this._WorkOrderPriority;
            }
            set
            {
                this.OnWorkOrderPriorityChanging(value);
                this._WorkOrderPriority = value;
                this.OnWorkOrderPriorityChanged();
                this.OnPropertyChanged("WorkOrderPriority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _WorkOrderPriority;
        partial void OnWorkOrderPriorityChanging(int value);
        partial void OnWorkOrderPriorityChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property WorkOrderId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkOrderId
        {
            get
            {
                return this._WorkOrderId;
            }
            set
            {
                this.OnWorkOrderIdChanging(value);
                this._WorkOrderId = value;
                this.OnWorkOrderIdChanged();
                this.OnPropertyChanged("WorkOrderId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkOrderId;
        partial void OnWorkOrderIdChanging(string value);
        partial void OnWorkOrderIdChanged();
        /// <summary>
        /// There are no comments for Property FunctionalLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FunctionalLocationId
        {
            get
            {
                return this._FunctionalLocationId;
            }
            set
            {
                this.OnFunctionalLocationIdChanging(value);
                this._FunctionalLocationId = value;
                this.OnFunctionalLocationIdChanged();
                this.OnPropertyChanged("FunctionalLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FunctionalLocationId;
        partial void OnFunctionalLocationIdChanging(string value);
        partial void OnFunctionalLocationIdChanged();
        /// <summary>
        /// There are no comments for Property AddressLatitude in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AddressLatitude
        {
            get
            {
                return this._AddressLatitude;
            }
            set
            {
                this.OnAddressLatitudeChanging(value);
                this._AddressLatitude = value;
                this.OnAddressLatitudeChanged();
                this.OnPropertyChanged("AddressLatitude");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AddressLatitude;
        partial void OnAddressLatitudeChanging(decimal value);
        partial void OnAddressLatitudeChanged();
        /// <summary>
        /// There are no comments for Property RequestTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RequestTypeId
        {
            get
            {
                return this._RequestTypeId;
            }
            set
            {
                this.OnRequestTypeIdChanging(value);
                this._RequestTypeId = value;
                this.OnRequestTypeIdChanged();
                this.OnPropertyChanged("RequestTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequestTypeId;
        partial void OnRequestTypeIdChanging(string value);
        partial void OnRequestTypeIdChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceAssetVerified in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> MaintenanceAssetVerified
        {
            get
            {
                return this._MaintenanceAssetVerified;
            }
            set
            {
                this.OnMaintenanceAssetVerifiedChanging(value);
                this._MaintenanceAssetVerified = value;
                this.OnMaintenanceAssetVerifiedChanged();
                this.OnPropertyChanged("MaintenanceAssetVerified");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _MaintenanceAssetVerified;
        partial void OnMaintenanceAssetVerifiedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnMaintenanceAssetVerifiedChanged();
        /// <summary>
        /// There are no comments for Property JobTradeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobTradeId
        {
            get
            {
                return this._JobTradeId;
            }
            set
            {
                this.OnJobTradeIdChanging(value);
                this._JobTradeId = value;
                this.OnJobTradeIdChanged();
                this.OnPropertyChanged("JobTradeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTradeId;
        partial void OnJobTradeIdChanging(string value);
        partial void OnJobTradeIdChanged();
        /// <summary>
        /// There are no comments for Property JobTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobTypeId
        {
            get
            {
                return this._JobTypeId;
            }
            set
            {
                this.OnJobTypeIdChanging(value);
                this._JobTypeId = value;
                this.OnJobTypeIdChanged();
                this.OnPropertyChanged("JobTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTypeId;
        partial void OnJobTypeIdChanging(string value);
        partial void OnJobTypeIdChanged();
        /// <summary>
        /// There are no comments for Property ResponsibleWorkerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ResponsibleWorkerPersonnelNumber
        {
            get
            {
                return this._ResponsibleWorkerPersonnelNumber;
            }
            set
            {
                this.OnResponsibleWorkerPersonnelNumberChanging(value);
                this._ResponsibleWorkerPersonnelNumber = value;
                this.OnResponsibleWorkerPersonnelNumberChanged();
                this.OnPropertyChanged("ResponsibleWorkerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResponsibleWorkerPersonnelNumber;
        partial void OnResponsibleWorkerPersonnelNumberChanging(string value);
        partial void OnResponsibleWorkerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property ActualEnd in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ActualEnd
        {
            get
            {
                return this._ActualEnd;
            }
            set
            {
                this.OnActualEndChanging(value);
                this._ActualEnd = value;
                this.OnActualEndChanged();
                this.OnPropertyChanged("ActualEnd");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ActualEnd;
        partial void OnActualEndChanging(global::System.DateTimeOffset value);
        partial void OnActualEndChanged();
        /// <summary>
        /// There are no comments for Property WorkerGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkerGroupId
        {
            get
            {
                return this._WorkerGroupId;
            }
            set
            {
                this.OnWorkerGroupIdChanging(value);
                this._WorkerGroupId = value;
                this.OnWorkerGroupIdChanged();
                this.OnPropertyChanged("WorkerGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerGroupId;
        partial void OnWorkerGroupIdChanging(string value);
        partial void OnWorkerGroupIdChanged();
        /// <summary>
        /// There are no comments for Property AddressLongitude in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AddressLongitude
        {
            get
            {
                return this._AddressLongitude;
            }
            set
            {
                this.OnAddressLongitudeChanging(value);
                this._AddressLongitude = value;
                this.OnAddressLongitudeChanged();
                this.OnPropertyChanged("AddressLongitude");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AddressLongitude;
        partial void OnAddressLongitudeChanging(decimal value);
        partial void OnAddressLongitudeChanged();
        /// <summary>
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceAssetVerifiedByWorkerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MaintenanceAssetVerifiedByWorkerPersonnelNumber
        {
            get
            {
                return this._MaintenanceAssetVerifiedByWorkerPersonnelNumber;
            }
            set
            {
                this.OnMaintenanceAssetVerifiedByWorkerPersonnelNumberChanging(value);
                this._MaintenanceAssetVerifiedByWorkerPersonnelNumber = value;
                this.OnMaintenanceAssetVerifiedByWorkerPersonnelNumberChanged();
                this.OnPropertyChanged("MaintenanceAssetVerifiedByWorkerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetVerifiedByWorkerPersonnelNumber;
        partial void OnMaintenanceAssetVerifiedByWorkerPersonnelNumberChanging(string value);
        partial void OnMaintenanceAssetVerifiedByWorkerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property RequestLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RequestLifecycleStateId
        {
            get
            {
                return this._RequestLifecycleStateId;
            }
            set
            {
                this.OnRequestLifecycleStateIdChanging(value);
                this._RequestLifecycleStateId = value;
                this.OnRequestLifecycleStateIdChanged();
                this.OnPropertyChanged("RequestLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequestLifecycleStateId;
        partial void OnRequestLifecycleStateIdChanging(string value);
        partial void OnRequestLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceAssetId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MaintenanceAssetId
        {
            get
            {
                return this._MaintenanceAssetId;
            }
            set
            {
                this.OnMaintenanceAssetIdChanging(value);
                this._MaintenanceAssetId = value;
                this.OnMaintenanceAssetIdChanged();
                this.OnPropertyChanged("MaintenanceAssetId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetId;
        partial void OnMaintenanceAssetIdChanging(string value);
        partial void OnMaintenanceAssetIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetCalendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> AssetMaintenanceAssetCalendar
        {
            get
            {
                return this._AssetMaintenanceAssetCalendar;
            }
            set
            {
                this.OnAssetMaintenanceAssetCalendarChanging(value);
                this._AssetMaintenanceAssetCalendar = value;
                this.OnAssetMaintenanceAssetCalendarChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetCalendar");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> _AssetMaintenanceAssetCalendar = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetCalendarChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> value);
        partial void OnAssetMaintenanceAssetCalendarChanged();
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
