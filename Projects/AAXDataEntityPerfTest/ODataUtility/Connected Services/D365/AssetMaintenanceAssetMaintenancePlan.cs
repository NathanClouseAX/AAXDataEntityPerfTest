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
        /// There are no comments for AssetMaintenanceAssetMaintenancePlanSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceAssetMaintenancePlanSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetMaintenancePlan>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceAssetMaintenancePlanSingle object.
        /// </summary>
        public AssetMaintenanceAssetMaintenancePlanSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetMaintenancePlanSingle object.
        /// </summary>
        public AssetMaintenanceAssetMaintenancePlanSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetMaintenancePlanSingle object.
        /// </summary>
        public AssetMaintenanceAssetMaintenancePlanSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetMaintenancePlan> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenancePlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenancePlanSingle AssetMaintenancePlan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenancePlan == null))
                {
                    this._AssetMaintenancePlan = new global::Microsoft.Dynamics.DataEntities.AssetMaintenancePlanSingle(this.Context, GetPath("AssetMaintenancePlan"));
                }
                return this._AssetMaintenancePlan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenancePlanSingle _AssetMaintenancePlan;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetMaintenancePlan in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MaintenanceAssetId
    /// MaintenancePlanId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MaintenanceAssetId", "MaintenancePlanId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceAssetMaintenancePlans")]
    public partial class AssetMaintenanceAssetMaintenancePlan : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceAssetMaintenancePlan object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="maintenanceAssetId">Initial value of MaintenanceAssetId.</param>
        /// <param name="maintenancePlanId">Initial value of MaintenancePlanId.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="assetMaintenancePlan">Initial value of AssetMaintenancePlan.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceAssetMaintenancePlan CreateAssetMaintenanceAssetMaintenancePlan(string dataAreaId, string maintenanceAssetId, string maintenancePlanId, global::System.DateTimeOffset startDate, global::Microsoft.Dynamics.DataEntities.AssetMaintenancePlan assetMaintenancePlan)
        {
            AssetMaintenanceAssetMaintenancePlan assetMaintenanceAssetMaintenancePlan = new AssetMaintenanceAssetMaintenancePlan();
            assetMaintenanceAssetMaintenancePlan.dataAreaId = dataAreaId;
            assetMaintenanceAssetMaintenancePlan.MaintenanceAssetId = maintenanceAssetId;
            assetMaintenanceAssetMaintenancePlan.MaintenancePlanId = maintenancePlanId;
            assetMaintenanceAssetMaintenancePlan.StartDate = startDate;
            if ((assetMaintenancePlan == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenancePlan");
            }
            assetMaintenanceAssetMaintenancePlan.AssetMaintenancePlan = assetMaintenancePlan;
            return assetMaintenanceAssetMaintenancePlan;
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
        /// There are no comments for Property MaintenancePlanId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MaintenancePlanId
        {
            get
            {
                return this._MaintenancePlanId;
            }
            set
            {
                this.OnMaintenancePlanIdChanging(value);
                this._MaintenancePlanId = value;
                this.OnMaintenancePlanIdChanged();
                this.OnPropertyChanged("MaintenancePlanId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenancePlanId;
        partial void OnMaintenancePlanIdChanging(string value);
        partial void OnMaintenancePlanIdChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDate;
        partial void OnStartDateChanging(global::System.DateTimeOffset value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenancePlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenancePlan AssetMaintenancePlan
        {
            get
            {
                return this._AssetMaintenancePlan;
            }
            set
            {
                this.OnAssetMaintenancePlanChanging(value);
                this._AssetMaintenancePlan = value;
                this.OnAssetMaintenancePlanChanged();
                this.OnPropertyChanged("AssetMaintenancePlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenancePlan _AssetMaintenancePlan;
        partial void OnAssetMaintenancePlanChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenancePlan value);
        partial void OnAssetMaintenancePlanChanged();
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