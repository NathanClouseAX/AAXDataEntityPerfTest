﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/28/2021 8:55:09 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for AssetMaintenanceStopObjectSingle in the schema.
    /// </summary>
    public partial class AssetMaintenanceStopObjectSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceStopObject>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceStopObjectSingle object.
        /// </summary>
        public AssetMaintenanceStopObjectSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceStopObjectSingle object.
        /// </summary>
        public AssetMaintenanceStopObjectSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceStopObjectSingle object.
        /// </summary>
        public AssetMaintenanceStopObjectSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceStopObject> query)
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
        /// There are no comments for AssetMaintenanceStop in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceStopSingle AssetMaintenanceStop
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceStop == null))
                {
                    this._AssetMaintenanceStop = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceStopSingle(this.Context, GetPath("AssetMaintenanceStop"));
                }
                return this._AssetMaintenanceStop;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceStopSingle _AssetMaintenanceStop;
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceStopObject in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MaintenanceStopId
    /// MaintenanceAssetId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MaintenanceStopId", "MaintenanceAssetId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceStopObjects")]
    public partial class AssetMaintenanceStopObject : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceStopObject object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="maintenanceStopId">Initial value of MaintenanceStopId.</param>
        /// <param name="maintenanceAssetId">Initial value of MaintenanceAssetId.</param>
        /// <param name="assetMaintenanceAsset">Initial value of AssetMaintenanceAsset.</param>
        /// <param name="assetMaintenanceStop">Initial value of AssetMaintenanceStop.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceStopObject CreateAssetMaintenanceStopObject(string dataAreaId, string maintenanceStopId, string maintenanceAssetId, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset assetMaintenanceAsset, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceStop assetMaintenanceStop)
        {
            AssetMaintenanceStopObject assetMaintenanceStopObject = new AssetMaintenanceStopObject();
            assetMaintenanceStopObject.dataAreaId = dataAreaId;
            assetMaintenanceStopObject.MaintenanceStopId = maintenanceStopId;
            assetMaintenanceStopObject.MaintenanceAssetId = maintenanceAssetId;
            if ((assetMaintenanceAsset == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceAsset");
            }
            assetMaintenanceStopObject.AssetMaintenanceAsset = assetMaintenanceAsset;
            if ((assetMaintenanceStop == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceStop");
            }
            assetMaintenanceStopObject.AssetMaintenanceStop = assetMaintenanceStop;
            return assetMaintenanceStopObject;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "dataAreaId is required.")]
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
        /// There are no comments for Property MaintenanceStopId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaintenanceStopId is required.")]
        public virtual string MaintenanceStopId
        {
            get
            {
                return this._MaintenanceStopId;
            }
            set
            {
                this.OnMaintenanceStopIdChanging(value);
                this._MaintenanceStopId = value;
                this.OnMaintenanceStopIdChanged();
                this.OnPropertyChanged("MaintenanceStopId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceStopId;
        partial void OnMaintenanceStopIdChanging(string value);
        partial void OnMaintenanceStopIdChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceAssetId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaintenanceAssetId is required.")]
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
        /// There are no comments for Property AssetMaintenanceAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetMaintenanceAsset is required.")]
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
        /// There are no comments for Property AssetMaintenanceStop in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetMaintenanceStop is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceStop AssetMaintenanceStop
        {
            get
            {
                return this._AssetMaintenanceStop;
            }
            set
            {
                this.OnAssetMaintenanceStopChanging(value);
                this._AssetMaintenanceStop = value;
                this.OnAssetMaintenanceStopChanged();
                this.OnPropertyChanged("AssetMaintenanceStop");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceStop _AssetMaintenanceStop;
        partial void OnAssetMaintenanceStopChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceStop value);
        partial void OnAssetMaintenanceStopChanged();
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
