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
        /// There are no comments for AssetMaintenanceFunctionalLocationTypeSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceFunctionalLocationTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceFunctionalLocationType>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationTypeSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationTypeSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationTypeSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceFunctionalLocationType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationLifecycleModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationLifecycleModelSingle AssetMaintenanceFunctionalLocationLifecycleModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationLifecycleModel == null))
                {
                    this._AssetMaintenanceFunctionalLocationLifecycleModel = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationLifecycleModelSingle(this.Context, GetPath("AssetMaintenanceFunctionalLocationLifecycleModel"));
                }
                return this._AssetMaintenanceFunctionalLocationLifecycleModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationLifecycleModelSingle _AssetMaintenanceFunctionalLocationLifecycleModel;
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
        /// There are no comments for AssetMaintenanceFunctionalLocationTypeAttributeRequirement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeAttributeRequirement> AssetMaintenanceFunctionalLocationTypeAttributeRequirement
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationTypeAttributeRequirement == null))
                {
                    this._AssetMaintenanceFunctionalLocationTypeAttributeRequirement = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeAttributeRequirement>(GetPath("AssetMaintenanceFunctionalLocationTypeAttributeRequirement"));
                }
                return this._AssetMaintenanceFunctionalLocationTypeAttributeRequirement;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeAttributeRequirement> _AssetMaintenanceFunctionalLocationTypeAttributeRequirement;
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationTypePermittedSubType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypePermittedSubType> AssetMaintenanceFunctionalLocationTypePermittedSubType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationTypePermittedSubType == null))
                {
                    this._AssetMaintenanceFunctionalLocationTypePermittedSubType = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypePermittedSubType>(GetPath("AssetMaintenanceFunctionalLocationTypePermittedSubType"));
                }
                return this._AssetMaintenanceFunctionalLocationTypePermittedSubType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypePermittedSubType> _AssetMaintenanceFunctionalLocationTypePermittedSubType;
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationTypeMaintenanceSequense in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeMaintenanceSequense> AssetMaintenanceFunctionalLocationTypeMaintenanceSequense
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationTypeMaintenanceSequense == null))
                {
                    this._AssetMaintenanceFunctionalLocationTypeMaintenanceSequense = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeMaintenanceSequense>(GetPath("AssetMaintenanceFunctionalLocationTypeMaintenanceSequense"));
                }
                return this._AssetMaintenanceFunctionalLocationTypeMaintenanceSequense;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeMaintenanceSequense> _AssetMaintenanceFunctionalLocationTypeMaintenanceSequense;
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocation> AssetMaintenanceFunctionalLocation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocation == null))
                {
                    this._AssetMaintenanceFunctionalLocation = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocation>(GetPath("AssetMaintenanceFunctionalLocation"));
                }
                return this._AssetMaintenanceFunctionalLocation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocation> _AssetMaintenanceFunctionalLocation;
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationAllowedByObjectType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAllowedByObjectType> AssetMaintenanceFunctionalLocationAllowedByObjectType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationAllowedByObjectType == null))
                {
                    this._AssetMaintenanceFunctionalLocationAllowedByObjectType = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAllowedByObjectType>(GetPath("AssetMaintenanceFunctionalLocationAllowedByObjectType"));
                }
                return this._AssetMaintenanceFunctionalLocationAllowedByObjectType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAllowedByObjectType> _AssetMaintenanceFunctionalLocationAllowedByObjectType;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationType in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// FunctionalLocationTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FunctionalLocationTypeId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceFunctionalLocationTypes")]
    public partial class AssetMaintenanceFunctionalLocationType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceFunctionalLocationType object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="functionalLocationTypeId">Initial value of FunctionalLocationTypeId.</param>
        /// <param name="assetMaintenanceFunctionalLocationLifecycleModel">Initial value of AssetMaintenanceFunctionalLocationLifecycleModel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceFunctionalLocationType CreateAssetMaintenanceFunctionalLocationType(string dataAreaId, string functionalLocationTypeId, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationLifecycleModel assetMaintenanceFunctionalLocationLifecycleModel)
        {
            AssetMaintenanceFunctionalLocationType assetMaintenanceFunctionalLocationType = new AssetMaintenanceFunctionalLocationType();
            assetMaintenanceFunctionalLocationType.dataAreaId = dataAreaId;
            assetMaintenanceFunctionalLocationType.FunctionalLocationTypeId = functionalLocationTypeId;
            if ((assetMaintenanceFunctionalLocationLifecycleModel == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceFunctionalLocationLifecycleModel");
            }
            assetMaintenanceFunctionalLocationType.AssetMaintenanceFunctionalLocationLifecycleModel = assetMaintenanceFunctionalLocationLifecycleModel;
            return assetMaintenanceFunctionalLocationType;
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
        /// There are no comments for Property FunctionalLocationTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FunctionalLocationTypeId
        {
            get
            {
                return this._FunctionalLocationTypeId;
            }
            set
            {
                this.OnFunctionalLocationTypeIdChanging(value);
                this._FunctionalLocationTypeId = value;
                this.OnFunctionalLocationTypeIdChanged();
                this.OnPropertyChanged("FunctionalLocationTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FunctionalLocationTypeId;
        partial void OnFunctionalLocationTypeIdChanging(string value);
        partial void OnFunctionalLocationTypeIdChanged();
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
        /// There are no comments for Property UpdateAssetDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UpdateAssetDimension
        {
            get
            {
                return this._UpdateAssetDimension;
            }
            set
            {
                this.OnUpdateAssetDimensionChanging(value);
                this._UpdateAssetDimension = value;
                this.OnUpdateAssetDimensionChanged();
                this.OnPropertyChanged("UpdateAssetDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UpdateAssetDimension;
        partial void OnUpdateAssetDimensionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUpdateAssetDimensionChanged();
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
        /// There are no comments for Property AllowMultipleInstalledAssets in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowMultipleInstalledAssets
        {
            get
            {
                return this._AllowMultipleInstalledAssets;
            }
            set
            {
                this.OnAllowMultipleInstalledAssetsChanging(value);
                this._AllowMultipleInstalledAssets = value;
                this.OnAllowMultipleInstalledAssetsChanged();
                this.OnPropertyChanged("AllowMultipleInstalledAssets");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowMultipleInstalledAssets;
        partial void OnAllowMultipleInstalledAssetsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowMultipleInstalledAssetsChanged();
        /// <summary>
        /// There are no comments for Property LifecycleModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LifecycleModelId
        {
            get
            {
                return this._LifecycleModelId;
            }
            set
            {
                this.OnLifecycleModelIdChanging(value);
                this._LifecycleModelId = value;
                this.OnLifecycleModelIdChanged();
                this.OnPropertyChanged("LifecycleModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LifecycleModelId;
        partial void OnLifecycleModelIdChanging(string value);
        partial void OnLifecycleModelIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocationLifecycleModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationLifecycleModel AssetMaintenanceFunctionalLocationLifecycleModel
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationLifecycleModel;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationLifecycleModelChanging(value);
                this._AssetMaintenanceFunctionalLocationLifecycleModel = value;
                this.OnAssetMaintenanceFunctionalLocationLifecycleModelChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationLifecycleModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationLifecycleModel _AssetMaintenanceFunctionalLocationLifecycleModel;
        partial void OnAssetMaintenanceFunctionalLocationLifecycleModelChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationLifecycleModel value);
        partial void OnAssetMaintenanceFunctionalLocationLifecycleModelChanged();
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
        /// There are no comments for Property AssetMaintenanceFunctionalLocationTypeAttributeRequirement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeAttributeRequirement> AssetMaintenanceFunctionalLocationTypeAttributeRequirement
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationTypeAttributeRequirement;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationTypeAttributeRequirementChanging(value);
                this._AssetMaintenanceFunctionalLocationTypeAttributeRequirement = value;
                this.OnAssetMaintenanceFunctionalLocationTypeAttributeRequirementChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationTypeAttributeRequirement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeAttributeRequirement> _AssetMaintenanceFunctionalLocationTypeAttributeRequirement = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeAttributeRequirement>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceFunctionalLocationTypeAttributeRequirementChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeAttributeRequirement> value);
        partial void OnAssetMaintenanceFunctionalLocationTypeAttributeRequirementChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocationTypePermittedSubType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypePermittedSubType> AssetMaintenanceFunctionalLocationTypePermittedSubType
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationTypePermittedSubType;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationTypePermittedSubTypeChanging(value);
                this._AssetMaintenanceFunctionalLocationTypePermittedSubType = value;
                this.OnAssetMaintenanceFunctionalLocationTypePermittedSubTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationTypePermittedSubType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypePermittedSubType> _AssetMaintenanceFunctionalLocationTypePermittedSubType = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypePermittedSubType>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceFunctionalLocationTypePermittedSubTypeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypePermittedSubType> value);
        partial void OnAssetMaintenanceFunctionalLocationTypePermittedSubTypeChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocationTypeMaintenanceSequense in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeMaintenanceSequense> AssetMaintenanceFunctionalLocationTypeMaintenanceSequense
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationTypeMaintenanceSequense;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationTypeMaintenanceSequenseChanging(value);
                this._AssetMaintenanceFunctionalLocationTypeMaintenanceSequense = value;
                this.OnAssetMaintenanceFunctionalLocationTypeMaintenanceSequenseChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationTypeMaintenanceSequense");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeMaintenanceSequense> _AssetMaintenanceFunctionalLocationTypeMaintenanceSequense = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeMaintenanceSequense>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceFunctionalLocationTypeMaintenanceSequenseChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeMaintenanceSequense> value);
        partial void OnAssetMaintenanceFunctionalLocationTypeMaintenanceSequenseChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocation> AssetMaintenanceFunctionalLocation
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
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocation> _AssetMaintenanceFunctionalLocation = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceFunctionalLocationChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocation> value);
        partial void OnAssetMaintenanceFunctionalLocationChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocationAllowedByObjectType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAllowedByObjectType> AssetMaintenanceFunctionalLocationAllowedByObjectType
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationAllowedByObjectType;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationAllowedByObjectTypeChanging(value);
                this._AssetMaintenanceFunctionalLocationAllowedByObjectType = value;
                this.OnAssetMaintenanceFunctionalLocationAllowedByObjectTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationAllowedByObjectType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAllowedByObjectType> _AssetMaintenanceFunctionalLocationAllowedByObjectType = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAllowedByObjectType>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceFunctionalLocationAllowedByObjectTypeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAllowedByObjectType> value);
        partial void OnAssetMaintenanceFunctionalLocationAllowedByObjectTypeChanged();
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
