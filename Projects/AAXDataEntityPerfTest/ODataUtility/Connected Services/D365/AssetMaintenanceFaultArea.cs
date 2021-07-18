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
        /// There are no comments for AssetMaintenanceFaultAreaSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceFaultAreaSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceFaultArea>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceFaultAreaSingle object.
        /// </summary>
        public AssetMaintenanceFaultAreaSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceFaultAreaSingle object.
        /// </summary>
        public AssetMaintenanceFaultAreaSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceFaultAreaSingle object.
        /// </summary>
        public AssetMaintenanceFaultAreaSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceFaultArea> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceAssetTypeFaultType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeFaultType> AssetMaintenanceAssetTypeFaultType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetTypeFaultType == null))
                {
                    this._AssetMaintenanceAssetTypeFaultType = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeFaultType>(GetPath("AssetMaintenanceAssetTypeFaultType"));
                }
                return this._AssetMaintenanceAssetTypeFaultType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeFaultType> _AssetMaintenanceAssetTypeFaultType;
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetTypeFaultArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeFaultArea> AssetMaintenanceAssetTypeFaultArea
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetTypeFaultArea == null))
                {
                    this._AssetMaintenanceAssetTypeFaultArea = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeFaultArea>(GetPath("AssetMaintenanceAssetTypeFaultArea"));
                }
                return this._AssetMaintenanceAssetTypeFaultArea;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeFaultArea> _AssetMaintenanceAssetTypeFaultArea;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceFaultArea in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// FaultAreaId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FaultAreaId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceFaultAreas")]
    public partial class AssetMaintenanceFaultArea : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceFaultArea object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="faultAreaId">Initial value of FaultAreaId.</param>
        /// <param name="percent">Initial value of Percent.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceFaultArea CreateAssetMaintenanceFaultArea(string dataAreaId, string faultAreaId, decimal percent)
        {
            AssetMaintenanceFaultArea assetMaintenanceFaultArea = new AssetMaintenanceFaultArea();
            assetMaintenanceFaultArea.dataAreaId = dataAreaId;
            assetMaintenanceFaultArea.FaultAreaId = faultAreaId;
            assetMaintenanceFaultArea.Percent = percent;
            return assetMaintenanceFaultArea;
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
        /// There are no comments for Property FaultAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FaultAreaId
        {
            get
            {
                return this._FaultAreaId;
            }
            set
            {
                this.OnFaultAreaIdChanging(value);
                this._FaultAreaId = value;
                this.OnFaultAreaIdChanged();
                this.OnPropertyChanged("FaultAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FaultAreaId;
        partial void OnFaultAreaIdChanging(string value);
        partial void OnFaultAreaIdChanged();
        /// <summary>
        /// There are no comments for Property Percent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Percent
        {
            get
            {
                return this._Percent;
            }
            set
            {
                this.OnPercentChanging(value);
                this._Percent = value;
                this.OnPercentChanged();
                this.OnPropertyChanged("Percent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Percent;
        partial void OnPercentChanging(decimal value);
        partial void OnPercentChanged();
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
        /// There are no comments for Property AssetMaintenanceAssetTypeFaultType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeFaultType> AssetMaintenanceAssetTypeFaultType
        {
            get
            {
                return this._AssetMaintenanceAssetTypeFaultType;
            }
            set
            {
                this.OnAssetMaintenanceAssetTypeFaultTypeChanging(value);
                this._AssetMaintenanceAssetTypeFaultType = value;
                this.OnAssetMaintenanceAssetTypeFaultTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetTypeFaultType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeFaultType> _AssetMaintenanceAssetTypeFaultType = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeFaultType>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetTypeFaultTypeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeFaultType> value);
        partial void OnAssetMaintenanceAssetTypeFaultTypeChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetTypeFaultArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeFaultArea> AssetMaintenanceAssetTypeFaultArea
        {
            get
            {
                return this._AssetMaintenanceAssetTypeFaultArea;
            }
            set
            {
                this.OnAssetMaintenanceAssetTypeFaultAreaChanging(value);
                this._AssetMaintenanceAssetTypeFaultArea = value;
                this.OnAssetMaintenanceAssetTypeFaultAreaChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetTypeFaultArea");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeFaultArea> _AssetMaintenanceAssetTypeFaultArea = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeFaultArea>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetTypeFaultAreaChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeFaultArea> value);
        partial void OnAssetMaintenanceAssetTypeFaultAreaChanged();
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
