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
        /// There are no comments for AssetMaintenanceWorkerResponsibleSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceWorkerResponsibleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkerResponsible>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceWorkerResponsibleSingle object.
        /// </summary>
        public AssetMaintenanceWorkerResponsibleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkerResponsibleSingle object.
        /// </summary>
        public AssetMaintenanceWorkerResponsibleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkerResponsibleSingle object.
        /// </summary>
        public AssetMaintenanceWorkerResponsibleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkerResponsible> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetSingle AssetMaintenanceAsset
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAsset == null))
                {
                    this._AssetMaintenanceAsset = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetSingle(this.Context, GetPath("AssetMaintenanceAsset"));
                }
                return this._AssetMaintenanceAsset;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetSingle _AssetMaintenanceAsset;
        /// <summary>
        /// There are no comments for AssetMaintenanceJobVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariantSingle AssetMaintenanceJobVariant
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceJobVariant == null))
                {
                    this._AssetMaintenanceJobVariant = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariantSingle(this.Context, GetPath("AssetMaintenanceJobVariant"));
                }
                return this._AssetMaintenanceJobVariant;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariantSingle _AssetMaintenanceJobVariant;
        /// <summary>
        /// There are no comments for AssetMaintenanceWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerSingle AssetMaintenanceWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorker == null))
                {
                    this._AssetMaintenanceWorker = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerSingle(this.Context, GetPath("AssetMaintenanceWorker"));
                }
                return this._AssetMaintenanceWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerSingle _AssetMaintenanceWorker;
        /// <summary>
        /// There are no comments for AssetMaintenanceJobTrade in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTradeSingle AssetMaintenanceJobTrade
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceJobTrade == null))
                {
                    this._AssetMaintenanceJobTrade = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTradeSingle(this.Context, GetPath("AssetMaintenanceJobTrade"));
                }
                return this._AssetMaintenanceJobTrade;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTradeSingle _AssetMaintenanceJobTrade;
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeSingle AssetMaintenanceAssetType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetType == null))
                {
                    this._AssetMaintenanceAssetType = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeSingle(this.Context, GetPath("AssetMaintenanceAssetType"));
                }
                return this._AssetMaintenanceAssetType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeSingle _AssetMaintenanceAssetType;
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationSingle AssetMaintenanceFunctionalLocation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocation == null))
                {
                    this._AssetMaintenanceFunctionalLocation = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationSingle(this.Context, GetPath("AssetMaintenanceFunctionalLocation"));
                }
                return this._AssetMaintenanceFunctionalLocation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationSingle _AssetMaintenanceFunctionalLocation;
        /// <summary>
        /// There are no comments for AssetMaintenanceJobGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobGroupSingle AssetMaintenanceJobGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceJobGroup == null))
                {
                    this._AssetMaintenanceJobGroup = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobGroupSingle(this.Context, GetPath("AssetMaintenanceJobGroup"));
                }
                return this._AssetMaintenanceJobGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobGroupSingle _AssetMaintenanceJobGroup;
        /// <summary>
        /// There are no comments for AssetMaintenanceJobType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeSingle AssetMaintenanceJobType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceJobType == null))
                {
                    this._AssetMaintenanceJobType = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeSingle(this.Context, GetPath("AssetMaintenanceJobType"));
                }
                return this._AssetMaintenanceJobType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeSingle _AssetMaintenanceJobType;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceWorkerResponsible in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MaintenanceAssetTypeId
    /// MaintenanceAssetId
    /// JobGroupId
    /// JobTypeId
    /// JobVariantId
    /// JobTradeId
    /// FunctionalLocationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MaintenanceAssetTypeId", "MaintenanceAssetId", "JobGroupId", "JobTypeId", "JobVariantId", "JobTradeId", "FunctionalLocationId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceWorkersResponsible")]
    public partial class AssetMaintenanceWorkerResponsible : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceWorkerResponsible object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="maintenanceAssetTypeId">Initial value of MaintenanceAssetTypeId.</param>
        /// <param name="maintenanceAssetId">Initial value of MaintenanceAssetId.</param>
        /// <param name="jobGroupId">Initial value of JobGroupId.</param>
        /// <param name="jobTypeId">Initial value of JobTypeId.</param>
        /// <param name="jobVariantId">Initial value of JobVariantId.</param>
        /// <param name="jobTradeId">Initial value of JobTradeId.</param>
        /// <param name="functionalLocationId">Initial value of FunctionalLocationId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceWorkerResponsible CreateAssetMaintenanceWorkerResponsible(string dataAreaId, 
                    string maintenanceAssetTypeId, 
                    string maintenanceAssetId, 
                    string jobGroupId, 
                    string jobTypeId, 
                    string jobVariantId, 
                    string jobTradeId, 
                    string functionalLocationId)
        {
            AssetMaintenanceWorkerResponsible assetMaintenanceWorkerResponsible = new AssetMaintenanceWorkerResponsible();
            assetMaintenanceWorkerResponsible.dataAreaId = dataAreaId;
            assetMaintenanceWorkerResponsible.MaintenanceAssetTypeId = maintenanceAssetTypeId;
            assetMaintenanceWorkerResponsible.MaintenanceAssetId = maintenanceAssetId;
            assetMaintenanceWorkerResponsible.JobGroupId = jobGroupId;
            assetMaintenanceWorkerResponsible.JobTypeId = jobTypeId;
            assetMaintenanceWorkerResponsible.JobVariantId = jobVariantId;
            assetMaintenanceWorkerResponsible.JobTradeId = jobTradeId;
            assetMaintenanceWorkerResponsible.FunctionalLocationId = functionalLocationId;
            return assetMaintenanceWorkerResponsible;
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
        /// There are no comments for Property MaintenanceAssetTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MaintenanceAssetTypeId
        {
            get
            {
                return this._MaintenanceAssetTypeId;
            }
            set
            {
                this.OnMaintenanceAssetTypeIdChanging(value);
                this._MaintenanceAssetTypeId = value;
                this.OnMaintenanceAssetTypeIdChanged();
                this.OnPropertyChanged("MaintenanceAssetTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetTypeId;
        partial void OnMaintenanceAssetTypeIdChanging(string value);
        partial void OnMaintenanceAssetTypeIdChanged();
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
        /// There are no comments for Property JobGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobGroupId
        {
            get
            {
                return this._JobGroupId;
            }
            set
            {
                this.OnJobGroupIdChanging(value);
                this._JobGroupId = value;
                this.OnJobGroupIdChanged();
                this.OnPropertyChanged("JobGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobGroupId;
        partial void OnJobGroupIdChanging(string value);
        partial void OnJobGroupIdChanged();
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
        /// There are no comments for Property WorkerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkerPersonnelNumber
        {
            get
            {
                return this._WorkerPersonnelNumber;
            }
            set
            {
                this.OnWorkerPersonnelNumberChanging(value);
                this._WorkerPersonnelNumber = value;
                this.OnWorkerPersonnelNumberChanged();
                this.OnPropertyChanged("WorkerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerPersonnelNumber;
        partial void OnWorkerPersonnelNumberChanging(string value);
        partial void OnWorkerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset AssetMaintenanceAsset
        {
            get
            {
                return this._AssetMaintenanceAsset;
            }
            set
            {
                this.OnAssetMaintenanceAssetChanging(value);
                this._AssetMaintenanceAsset = value;
                this.OnAssetMaintenanceAssetChanged();
                this.OnPropertyChanged("AssetMaintenanceAsset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset _AssetMaintenanceAsset;
        partial void OnAssetMaintenanceAssetChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset value);
        partial void OnAssetMaintenanceAssetChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceJobVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariant AssetMaintenanceJobVariant
        {
            get
            {
                return this._AssetMaintenanceJobVariant;
            }
            set
            {
                this.OnAssetMaintenanceJobVariantChanging(value);
                this._AssetMaintenanceJobVariant = value;
                this.OnAssetMaintenanceJobVariantChanged();
                this.OnPropertyChanged("AssetMaintenanceJobVariant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariant _AssetMaintenanceJobVariant;
        partial void OnAssetMaintenanceJobVariantChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariant value);
        partial void OnAssetMaintenanceJobVariantChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorker AssetMaintenanceWorker
        {
            get
            {
                return this._AssetMaintenanceWorker;
            }
            set
            {
                this.OnAssetMaintenanceWorkerChanging(value);
                this._AssetMaintenanceWorker = value;
                this.OnAssetMaintenanceWorkerChanged();
                this.OnPropertyChanged("AssetMaintenanceWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorker _AssetMaintenanceWorker;
        partial void OnAssetMaintenanceWorkerChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorker value);
        partial void OnAssetMaintenanceWorkerChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceJobTrade in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTrade AssetMaintenanceJobTrade
        {
            get
            {
                return this._AssetMaintenanceJobTrade;
            }
            set
            {
                this.OnAssetMaintenanceJobTradeChanging(value);
                this._AssetMaintenanceJobTrade = value;
                this.OnAssetMaintenanceJobTradeChanged();
                this.OnPropertyChanged("AssetMaintenanceJobTrade");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTrade _AssetMaintenanceJobTrade;
        partial void OnAssetMaintenanceJobTradeChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTrade value);
        partial void OnAssetMaintenanceJobTradeChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetType AssetMaintenanceAssetType
        {
            get
            {
                return this._AssetMaintenanceAssetType;
            }
            set
            {
                this.OnAssetMaintenanceAssetTypeChanging(value);
                this._AssetMaintenanceAssetType = value;
                this.OnAssetMaintenanceAssetTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetType _AssetMaintenanceAssetType;
        partial void OnAssetMaintenanceAssetTypeChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetType value);
        partial void OnAssetMaintenanceAssetTypeChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocation AssetMaintenanceFunctionalLocation
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocation;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationChanging(value);
                this._AssetMaintenanceFunctionalLocation = value;
                this.OnAssetMaintenanceFunctionalLocationChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocation _AssetMaintenanceFunctionalLocation;
        partial void OnAssetMaintenanceFunctionalLocationChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocation value);
        partial void OnAssetMaintenanceFunctionalLocationChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceJobGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobGroup AssetMaintenanceJobGroup
        {
            get
            {
                return this._AssetMaintenanceJobGroup;
            }
            set
            {
                this.OnAssetMaintenanceJobGroupChanging(value);
                this._AssetMaintenanceJobGroup = value;
                this.OnAssetMaintenanceJobGroupChanged();
                this.OnPropertyChanged("AssetMaintenanceJobGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobGroup _AssetMaintenanceJobGroup;
        partial void OnAssetMaintenanceJobGroupChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobGroup value);
        partial void OnAssetMaintenanceJobGroupChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceJobType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType AssetMaintenanceJobType
        {
            get
            {
                return this._AssetMaintenanceJobType;
            }
            set
            {
                this.OnAssetMaintenanceJobTypeChanging(value);
                this._AssetMaintenanceJobType = value;
                this.OnAssetMaintenanceJobTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceJobType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType _AssetMaintenanceJobType;
        partial void OnAssetMaintenanceJobTypeChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType value);
        partial void OnAssetMaintenanceJobTypeChanged();
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
