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
        /// There are no comments for AssetMaintenanceWorkOrderTypeSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceWorkOrderTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkOrderType>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderTypeSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderTypeSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderTypeSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkOrderType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceWorkOrderParentProjectsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderParentProjectV2> AssetMaintenanceWorkOrderParentProjectsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorkOrderParentProjectsV2 == null))
                {
                    this._AssetMaintenanceWorkOrderParentProjectsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderParentProjectV2>(GetPath("AssetMaintenanceWorkOrderParentProjectsV2"));
                }
                return this._AssetMaintenanceWorkOrderParentProjectsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderParentProjectV2> _AssetMaintenanceWorkOrderParentProjectsV2;
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetPriority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetPriority> AssetMaintenanceAssetPriority
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetPriority == null))
                {
                    this._AssetMaintenanceAssetPriority = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetPriority>(GetPath("AssetMaintenanceAssetPriority"));
                }
                return this._AssetMaintenanceAssetPriority;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetPriority> _AssetMaintenanceAssetPriority;
        /// <summary>
        /// There are no comments for AssetMaintenanceRequestType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestType> AssetMaintenanceRequestType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceRequestType == null))
                {
                    this._AssetMaintenanceRequestType = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestType>(GetPath("AssetMaintenanceRequestType"));
                }
                return this._AssetMaintenanceRequestType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestType> _AssetMaintenanceRequestType;
        /// <summary>
        /// There are no comments for AssetMaintenanceRound in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRound> AssetMaintenanceRound
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceRound == null))
                {
                    this._AssetMaintenanceRound = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRound>(GetPath("AssetMaintenanceRound"));
                }
                return this._AssetMaintenanceRound;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRound> _AssetMaintenanceRound;
        /// <summary>
        /// There are no comments for AssetMaintenanceScheduledExecution in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceScheduledExecution> AssetMaintenanceScheduledExecution
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceScheduledExecution == null))
                {
                    this._AssetMaintenanceScheduledExecution = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceScheduledExecution>(GetPath("AssetMaintenanceScheduledExecution"));
                }
                return this._AssetMaintenanceScheduledExecution;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceScheduledExecution> _AssetMaintenanceScheduledExecution;
        /// <summary>
        /// There are no comments for AssetMaintenanceWorkOrderParentProject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderParentProject> AssetMaintenanceWorkOrderParentProject
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorkOrderParentProject == null))
                {
                    this._AssetMaintenanceWorkOrderParentProject = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderParentProject>(GetPath("AssetMaintenanceWorkOrderParentProject"));
                }
                return this._AssetMaintenanceWorkOrderParentProject;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderParentProject> _AssetMaintenanceWorkOrderParentProject;
        /// <summary>
        /// There are no comments for AssetMaintenanceWorkOrderStandardProjectGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderStandardProjectGroup> AssetMaintenanceWorkOrderStandardProjectGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorkOrderStandardProjectGroup == null))
                {
                    this._AssetMaintenanceWorkOrderStandardProjectGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderStandardProjectGroup>(GetPath("AssetMaintenanceWorkOrderStandardProjectGroup"));
                }
                return this._AssetMaintenanceWorkOrderStandardProjectGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderStandardProjectGroup> _AssetMaintenanceWorkOrderStandardProjectGroup;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceWorkOrderType in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// WorkOrderTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WorkOrderTypeId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceWorkOrderTypes")]
    public partial class AssetMaintenanceWorkOrderType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceWorkOrderType object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="workOrderTypeId">Initial value of WorkOrderTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceWorkOrderType CreateAssetMaintenanceWorkOrderType(string dataAreaId, string workOrderTypeId)
        {
            AssetMaintenanceWorkOrderType assetMaintenanceWorkOrderType = new AssetMaintenanceWorkOrderType();
            assetMaintenanceWorkOrderType.dataAreaId = dataAreaId;
            assetMaintenanceWorkOrderType.WorkOrderTypeId = workOrderTypeId;
            return assetMaintenanceWorkOrderType;
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
        /// There are no comments for Property WorkOrderTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkOrderTypeId
        {
            get
            {
                return this._WorkOrderTypeId;
            }
            set
            {
                this.OnWorkOrderTypeIdChanging(value);
                this._WorkOrderTypeId = value;
                this.OnWorkOrderTypeIdChanged();
                this.OnPropertyChanged("WorkOrderTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkOrderTypeId;
        partial void OnWorkOrderTypeIdChanging(string value);
        partial void OnWorkOrderTypeIdChanged();
        /// <summary>
        /// There are no comments for Property FaultRemedyMandatory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> FaultRemedyMandatory
        {
            get
            {
                return this._FaultRemedyMandatory;
            }
            set
            {
                this.OnFaultRemedyMandatoryChanging(value);
                this._FaultRemedyMandatory = value;
                this.OnFaultRemedyMandatoryChanged();
                this.OnPropertyChanged("FaultRemedyMandatory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _FaultRemedyMandatory;
        partial void OnFaultRemedyMandatoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnFaultRemedyMandatoryChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property FaultCauseMandatory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> FaultCauseMandatory
        {
            get
            {
                return this._FaultCauseMandatory;
            }
            set
            {
                this.OnFaultCauseMandatoryChanging(value);
                this._FaultCauseMandatory = value;
                this.OnFaultCauseMandatoryChanged();
                this.OnPropertyChanged("FaultCauseMandatory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _FaultCauseMandatory;
        partial void OnFaultCauseMandatoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnFaultCauseMandatoryChanged();
        /// <summary>
        /// There are no comments for Property ScheduleOneWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ScheduleOneWorker
        {
            get
            {
                return this._ScheduleOneWorker;
            }
            set
            {
                this.OnScheduleOneWorkerChanging(value);
                this._ScheduleOneWorker = value;
                this.OnScheduleOneWorkerChanged();
                this.OnPropertyChanged("ScheduleOneWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ScheduleOneWorker;
        partial void OnScheduleOneWorkerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnScheduleOneWorkerChanged();
        /// <summary>
        /// There are no comments for Property WorkOrderLifecycleModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkOrderLifecycleModelId
        {
            get
            {
                return this._WorkOrderLifecycleModelId;
            }
            set
            {
                this.OnWorkOrderLifecycleModelIdChanging(value);
                this._WorkOrderLifecycleModelId = value;
                this.OnWorkOrderLifecycleModelIdChanged();
                this.OnPropertyChanged("WorkOrderLifecycleModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkOrderLifecycleModelId;
        partial void OnWorkOrderLifecycleModelIdChanging(string value);
        partial void OnWorkOrderLifecycleModelIdChanged();
        /// <summary>
        /// There are no comments for Property ProductionStopMandatory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ProductionStopMandatory
        {
            get
            {
                return this._ProductionStopMandatory;
            }
            set
            {
                this.OnProductionStopMandatoryChanging(value);
                this._ProductionStopMandatory = value;
                this.OnProductionStopMandatoryChanged();
                this.OnPropertyChanged("ProductionStopMandatory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ProductionStopMandatory;
        partial void OnProductionStopMandatoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnProductionStopMandatoryChanged();
        /// <summary>
        /// There are no comments for Property CostType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetCostType> CostType
        {
            get
            {
                return this._CostType;
            }
            set
            {
                this.OnCostTypeChanging(value);
                this._CostType = value;
                this.OnCostTypeChanged();
                this.OnPropertyChanged("CostType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetCostType> _CostType;
        partial void OnCostTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetCostType> value);
        partial void OnCostTypeChanged();
        /// <summary>
        /// There are no comments for Property FaultSymptomMandatory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> FaultSymptomMandatory
        {
            get
            {
                return this._FaultSymptomMandatory;
            }
            set
            {
                this.OnFaultSymptomMandatoryChanging(value);
                this._FaultSymptomMandatory = value;
                this.OnFaultSymptomMandatoryChanged();
                this.OnPropertyChanged("FaultSymptomMandatory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _FaultSymptomMandatory;
        partial void OnFaultSymptomMandatoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnFaultSymptomMandatoryChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWorkOrderParentProjectsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderParentProjectV2> AssetMaintenanceWorkOrderParentProjectsV2
        {
            get
            {
                return this._AssetMaintenanceWorkOrderParentProjectsV2;
            }
            set
            {
                this.OnAssetMaintenanceWorkOrderParentProjectsV2Changing(value);
                this._AssetMaintenanceWorkOrderParentProjectsV2 = value;
                this.OnAssetMaintenanceWorkOrderParentProjectsV2Changed();
                this.OnPropertyChanged("AssetMaintenanceWorkOrderParentProjectsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderParentProjectV2> _AssetMaintenanceWorkOrderParentProjectsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderParentProjectV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceWorkOrderParentProjectsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderParentProjectV2> value);
        partial void OnAssetMaintenanceWorkOrderParentProjectsV2Changed();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetPriority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetPriority> AssetMaintenanceAssetPriority
        {
            get
            {
                return this._AssetMaintenanceAssetPriority;
            }
            set
            {
                this.OnAssetMaintenanceAssetPriorityChanging(value);
                this._AssetMaintenanceAssetPriority = value;
                this.OnAssetMaintenanceAssetPriorityChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetPriority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetPriority> _AssetMaintenanceAssetPriority = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetPriority>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetPriorityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetPriority> value);
        partial void OnAssetMaintenanceAssetPriorityChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceRequestType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestType> AssetMaintenanceRequestType
        {
            get
            {
                return this._AssetMaintenanceRequestType;
            }
            set
            {
                this.OnAssetMaintenanceRequestTypeChanging(value);
                this._AssetMaintenanceRequestType = value;
                this.OnAssetMaintenanceRequestTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceRequestType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestType> _AssetMaintenanceRequestType = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestType>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceRequestTypeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestType> value);
        partial void OnAssetMaintenanceRequestTypeChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceRound in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRound> AssetMaintenanceRound
        {
            get
            {
                return this._AssetMaintenanceRound;
            }
            set
            {
                this.OnAssetMaintenanceRoundChanging(value);
                this._AssetMaintenanceRound = value;
                this.OnAssetMaintenanceRoundChanged();
                this.OnPropertyChanged("AssetMaintenanceRound");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRound> _AssetMaintenanceRound = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRound>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceRoundChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRound> value);
        partial void OnAssetMaintenanceRoundChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceScheduledExecution in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceScheduledExecution> AssetMaintenanceScheduledExecution
        {
            get
            {
                return this._AssetMaintenanceScheduledExecution;
            }
            set
            {
                this.OnAssetMaintenanceScheduledExecutionChanging(value);
                this._AssetMaintenanceScheduledExecution = value;
                this.OnAssetMaintenanceScheduledExecutionChanged();
                this.OnPropertyChanged("AssetMaintenanceScheduledExecution");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceScheduledExecution> _AssetMaintenanceScheduledExecution = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceScheduledExecution>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceScheduledExecutionChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceScheduledExecution> value);
        partial void OnAssetMaintenanceScheduledExecutionChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWorkOrderParentProject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderParentProject> AssetMaintenanceWorkOrderParentProject
        {
            get
            {
                return this._AssetMaintenanceWorkOrderParentProject;
            }
            set
            {
                this.OnAssetMaintenanceWorkOrderParentProjectChanging(value);
                this._AssetMaintenanceWorkOrderParentProject = value;
                this.OnAssetMaintenanceWorkOrderParentProjectChanged();
                this.OnPropertyChanged("AssetMaintenanceWorkOrderParentProject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderParentProject> _AssetMaintenanceWorkOrderParentProject = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderParentProject>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceWorkOrderParentProjectChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderParentProject> value);
        partial void OnAssetMaintenanceWorkOrderParentProjectChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWorkOrderStandardProjectGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderStandardProjectGroup> AssetMaintenanceWorkOrderStandardProjectGroup
        {
            get
            {
                return this._AssetMaintenanceWorkOrderStandardProjectGroup;
            }
            set
            {
                this.OnAssetMaintenanceWorkOrderStandardProjectGroupChanging(value);
                this._AssetMaintenanceWorkOrderStandardProjectGroup = value;
                this.OnAssetMaintenanceWorkOrderStandardProjectGroupChanged();
                this.OnPropertyChanged("AssetMaintenanceWorkOrderStandardProjectGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderStandardProjectGroup> _AssetMaintenanceWorkOrderStandardProjectGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderStandardProjectGroup>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceWorkOrderStandardProjectGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderStandardProjectGroup> value);
        partial void OnAssetMaintenanceWorkOrderStandardProjectGroupChanged();
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
