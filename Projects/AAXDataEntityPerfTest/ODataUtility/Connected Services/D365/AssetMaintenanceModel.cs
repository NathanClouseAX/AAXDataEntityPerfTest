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
        /// There are no comments for AssetMaintenanceModelSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceModelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceModel>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceModelSingle object.
        /// </summary>
        public AssetMaintenanceModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceModelSingle object.
        /// </summary>
        public AssetMaintenanceModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceModelSingle object.
        /// </summary>
        public AssetMaintenanceModelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceModel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceJobTypeDefault in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeDefault> AssetMaintenanceJobTypeDefault
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceJobTypeDefault == null))
                {
                    this._AssetMaintenanceJobTypeDefault = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeDefault>(GetPath("AssetMaintenanceJobTypeDefault"));
                }
                return this._AssetMaintenanceJobTypeDefault;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeDefault> _AssetMaintenanceJobTypeDefault;
        /// <summary>
        /// There are no comments for AssetMaintenanceProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceProductSingle AssetMaintenanceProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceProduct == null))
                {
                    this._AssetMaintenanceProduct = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceProductSingle(this.Context, GetPath("AssetMaintenanceProduct"));
                }
                return this._AssetMaintenanceProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceProductSingle _AssetMaintenanceProduct;
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
        /// There are no comments for AssetMaintenanceFunctionalLocationMaintenancePlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationMaintenancePlan> AssetMaintenanceFunctionalLocationMaintenancePlan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationMaintenancePlan == null))
                {
                    this._AssetMaintenanceFunctionalLocationMaintenancePlan = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationMaintenancePlan>(GetPath("AssetMaintenanceFunctionalLocationMaintenancePlan"));
                }
                return this._AssetMaintenanceFunctionalLocationMaintenancePlan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationMaintenancePlan> _AssetMaintenanceFunctionalLocationMaintenancePlan;
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetTypeDefault in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeDefault> AssetMaintenanceAssetTypeDefault
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetTypeDefault == null))
                {
                    this._AssetMaintenanceAssetTypeDefault = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeDefault>(GetPath("AssetMaintenanceAssetTypeDefault"));
                }
                return this._AssetMaintenanceAssetTypeDefault;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeDefault> _AssetMaintenanceAssetTypeDefault;
        /// <summary>
        /// There are no comments for AssetMaintenanceAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset> AssetMaintenanceAsset
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAsset == null))
                {
                    this._AssetMaintenanceAsset = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset>(GetPath("AssetMaintenanceAsset"));
                }
                return this._AssetMaintenanceAsset;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset> _AssetMaintenanceAsset;
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetCriticality in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCriticality> AssetMaintenanceAssetCriticality
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetCriticality == null))
                {
                    this._AssetMaintenanceAssetCriticality = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCriticality>(GetPath("AssetMaintenanceAssetCriticality"));
                }
                return this._AssetMaintenanceAssetCriticality;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCriticality> _AssetMaintenanceAssetCriticality;
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
        /// There are no comments for AssetMaintenanceFunctionalLocationRound in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationRound> AssetMaintenanceFunctionalLocationRound
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationRound == null))
                {
                    this._AssetMaintenanceFunctionalLocationRound = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationRound>(GetPath("AssetMaintenanceFunctionalLocationRound"));
                }
                return this._AssetMaintenanceFunctionalLocationRound;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationRound> _AssetMaintenanceFunctionalLocationRound;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceModel in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ProductId
    /// ModelId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProductId", "ModelId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceModels")]
    public partial class AssetMaintenanceModel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceModel object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="productId">Initial value of ProductId.</param>
        /// <param name="modelId">Initial value of ModelId.</param>
        /// <param name="assetMaintenanceProduct">Initial value of AssetMaintenanceProduct.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceModel CreateAssetMaintenanceModel(string dataAreaId, string productId, string modelId, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceProduct assetMaintenanceProduct)
        {
            AssetMaintenanceModel assetMaintenanceModel = new AssetMaintenanceModel();
            assetMaintenanceModel.dataAreaId = dataAreaId;
            assetMaintenanceModel.ProductId = productId;
            assetMaintenanceModel.ModelId = modelId;
            if ((assetMaintenanceProduct == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceProduct");
            }
            assetMaintenanceModel.AssetMaintenanceProduct = assetMaintenanceProduct;
            return assetMaintenanceModel;
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
        /// There are no comments for Property ProductId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductId
        {
            get
            {
                return this._ProductId;
            }
            set
            {
                this.OnProductIdChanging(value);
                this._ProductId = value;
                this.OnProductIdChanged();
                this.OnPropertyChanged("ProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductId;
        partial void OnProductIdChanging(string value);
        partial void OnProductIdChanged();
        /// <summary>
        /// There are no comments for Property ModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ModelId
        {
            get
            {
                return this._ModelId;
            }
            set
            {
                this.OnModelIdChanging(value);
                this._ModelId = value;
                this.OnModelIdChanged();
                this.OnPropertyChanged("ModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModelId;
        partial void OnModelIdChanging(string value);
        partial void OnModelIdChanged();
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
        /// There are no comments for Property AssetMaintenanceJobTypeDefault in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeDefault> AssetMaintenanceJobTypeDefault
        {
            get
            {
                return this._AssetMaintenanceJobTypeDefault;
            }
            set
            {
                this.OnAssetMaintenanceJobTypeDefaultChanging(value);
                this._AssetMaintenanceJobTypeDefault = value;
                this.OnAssetMaintenanceJobTypeDefaultChanged();
                this.OnPropertyChanged("AssetMaintenanceJobTypeDefault");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeDefault> _AssetMaintenanceJobTypeDefault = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeDefault>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceJobTypeDefaultChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeDefault> value);
        partial void OnAssetMaintenanceJobTypeDefaultChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceProduct AssetMaintenanceProduct
        {
            get
            {
                return this._AssetMaintenanceProduct;
            }
            set
            {
                this.OnAssetMaintenanceProductChanging(value);
                this._AssetMaintenanceProduct = value;
                this.OnAssetMaintenanceProductChanged();
                this.OnPropertyChanged("AssetMaintenanceProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceProduct _AssetMaintenanceProduct;
        partial void OnAssetMaintenanceProductChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceProduct value);
        partial void OnAssetMaintenanceProductChanged();
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
        /// There are no comments for Property AssetMaintenanceFunctionalLocationMaintenancePlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationMaintenancePlan> AssetMaintenanceFunctionalLocationMaintenancePlan
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationMaintenancePlan;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationMaintenancePlanChanging(value);
                this._AssetMaintenanceFunctionalLocationMaintenancePlan = value;
                this.OnAssetMaintenanceFunctionalLocationMaintenancePlanChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationMaintenancePlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationMaintenancePlan> _AssetMaintenanceFunctionalLocationMaintenancePlan = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationMaintenancePlan>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceFunctionalLocationMaintenancePlanChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationMaintenancePlan> value);
        partial void OnAssetMaintenanceFunctionalLocationMaintenancePlanChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetTypeDefault in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeDefault> AssetMaintenanceAssetTypeDefault
        {
            get
            {
                return this._AssetMaintenanceAssetTypeDefault;
            }
            set
            {
                this.OnAssetMaintenanceAssetTypeDefaultChanging(value);
                this._AssetMaintenanceAssetTypeDefault = value;
                this.OnAssetMaintenanceAssetTypeDefaultChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetTypeDefault");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeDefault> _AssetMaintenanceAssetTypeDefault = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeDefault>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetTypeDefaultChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeDefault> value);
        partial void OnAssetMaintenanceAssetTypeDefaultChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset> AssetMaintenanceAsset
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
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset> _AssetMaintenanceAsset = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset> value);
        partial void OnAssetMaintenanceAssetChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetCriticality in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCriticality> AssetMaintenanceAssetCriticality
        {
            get
            {
                return this._AssetMaintenanceAssetCriticality;
            }
            set
            {
                this.OnAssetMaintenanceAssetCriticalityChanging(value);
                this._AssetMaintenanceAssetCriticality = value;
                this.OnAssetMaintenanceAssetCriticalityChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetCriticality");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCriticality> _AssetMaintenanceAssetCriticality = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCriticality>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetCriticalityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCriticality> value);
        partial void OnAssetMaintenanceAssetCriticalityChanged();
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
        /// There are no comments for Property AssetMaintenanceFunctionalLocationRound in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationRound> AssetMaintenanceFunctionalLocationRound
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationRound;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationRoundChanging(value);
                this._AssetMaintenanceFunctionalLocationRound = value;
                this.OnAssetMaintenanceFunctionalLocationRoundChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationRound");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationRound> _AssetMaintenanceFunctionalLocationRound = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationRound>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceFunctionalLocationRoundChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationRound> value);
        partial void OnAssetMaintenanceFunctionalLocationRoundChanged();
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
