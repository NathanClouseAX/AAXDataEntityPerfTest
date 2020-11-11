﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/8/2020 8:07:52 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationLifecycleStateSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceFunctionalLocationLifecycleStateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceFunctionalLocationLifecycleState>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationLifecycleStateSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationLifecycleStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationLifecycleStateSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationLifecycleStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationLifecycleStateSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationLifecycleStateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceFunctionalLocationLifecycleState> query)
            : base(query) {}

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
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationLifecycleState in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LifecycleStateId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LifecycleStateId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceFunctionalLocationLifecycleStates")]
    public partial class AssetMaintenanceFunctionalLocationLifecycleState : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceFunctionalLocationLifecycleState object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="lifecycleStateId">Initial value of LifecycleStateId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceFunctionalLocationLifecycleState CreateAssetMaintenanceFunctionalLocationLifecycleState(string dataAreaId, string lifecycleStateId)
        {
            AssetMaintenanceFunctionalLocationLifecycleState assetMaintenanceFunctionalLocationLifecycleState = new AssetMaintenanceFunctionalLocationLifecycleState();
            assetMaintenanceFunctionalLocationLifecycleState.dataAreaId = dataAreaId;
            assetMaintenanceFunctionalLocationLifecycleState.LifecycleStateId = lifecycleStateId;
            return assetMaintenanceFunctionalLocationLifecycleState;
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
        /// There are no comments for Property LifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LifecycleStateId
        {
            get
            {
                return this._LifecycleStateId;
            }
            set
            {
                this.OnLifecycleStateIdChanging(value);
                this._LifecycleStateId = value;
                this.OnLifecycleStateIdChanged();
                this.OnPropertyChanged("LifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LifecycleStateId;
        partial void OnLifecycleStateIdChanging(string value);
        partial void OnLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property FunctionalLocationActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> FunctionalLocationActive
        {
            get
            {
                return this._FunctionalLocationActive;
            }
            set
            {
                this.OnFunctionalLocationActiveChanging(value);
                this._FunctionalLocationActive = value;
                this.OnFunctionalLocationActiveChanged();
                this.OnPropertyChanged("FunctionalLocationActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _FunctionalLocationActive;
        partial void OnFunctionalLocationActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnFunctionalLocationActiveChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceAssetLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MaintenanceAssetLifecycleStateId
        {
            get
            {
                return this._MaintenanceAssetLifecycleStateId;
            }
            set
            {
                this.OnMaintenanceAssetLifecycleStateIdChanging(value);
                this._MaintenanceAssetLifecycleStateId = value;
                this.OnMaintenanceAssetLifecycleStateIdChanged();
                this.OnPropertyChanged("MaintenanceAssetLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetLifecycleStateId;
        partial void OnMaintenanceAssetLifecycleStateIdChanging(string value);
        partial void OnMaintenanceAssetLifecycleStateIdChanged();
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
        /// There are no comments for Property AllowRenameLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowRenameLocation
        {
            get
            {
                return this._AllowRenameLocation;
            }
            set
            {
                this.OnAllowRenameLocationChanging(value);
                this._AllowRenameLocation = value;
                this.OnAllowRenameLocationChanged();
                this.OnPropertyChanged("AllowRenameLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowRenameLocation;
        partial void OnAllowRenameLocationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowRenameLocationChanged();
        /// <summary>
        /// There are no comments for Property AllowNewSubLocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowNewSubLocations
        {
            get
            {
                return this._AllowNewSubLocations;
            }
            set
            {
                this.OnAllowNewSubLocationsChanging(value);
                this._AllowNewSubLocations = value;
                this.OnAllowNewSubLocationsChanged();
                this.OnPropertyChanged("AllowNewSubLocations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowNewSubLocations;
        partial void OnAllowNewSubLocationsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowNewSubLocationsChanged();
        /// <summary>
        /// There are no comments for Property AllowDeleteLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowDeleteLocation
        {
            get
            {
                return this._AllowDeleteLocation;
            }
            set
            {
                this.OnAllowDeleteLocationChanging(value);
                this._AllowDeleteLocation = value;
                this.OnAllowDeleteLocationChanged();
                this.OnPropertyChanged("AllowDeleteLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowDeleteLocation;
        partial void OnAllowDeleteLocationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowDeleteLocationChanged();
        /// <summary>
        /// There are no comments for Property CreateLocationMaintenanceAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CreateLocationMaintenanceAsset
        {
            get
            {
                return this._CreateLocationMaintenanceAsset;
            }
            set
            {
                this.OnCreateLocationMaintenanceAssetChanging(value);
                this._CreateLocationMaintenanceAsset = value;
                this.OnCreateLocationMaintenanceAssetChanged();
                this.OnPropertyChanged("CreateLocationMaintenanceAsset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CreateLocationMaintenanceAsset;
        partial void OnCreateLocationMaintenanceAssetChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCreateLocationMaintenanceAssetChanged();
        /// <summary>
        /// There are no comments for Property AllowInstallMaintenanceAssets in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowInstallMaintenanceAssets
        {
            get
            {
                return this._AllowInstallMaintenanceAssets;
            }
            set
            {
                this.OnAllowInstallMaintenanceAssetsChanging(value);
                this._AllowInstallMaintenanceAssets = value;
                this.OnAllowInstallMaintenanceAssetsChanged();
                this.OnPropertyChanged("AllowInstallMaintenanceAssets");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowInstallMaintenanceAssets;
        partial void OnAllowInstallMaintenanceAssetsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowInstallMaintenanceAssetsChanged();
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