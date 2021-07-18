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
        /// There are no comments for AssetMaintenanceAssetTypeFaultSymptomSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceAssetTypeFaultSymptomSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetTypeFaultSymptom>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceAssetTypeFaultSymptomSingle object.
        /// </summary>
        public AssetMaintenanceAssetTypeFaultSymptomSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetTypeFaultSymptomSingle object.
        /// </summary>
        public AssetMaintenanceAssetTypeFaultSymptomSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetTypeFaultSymptomSingle object.
        /// </summary>
        public AssetMaintenanceAssetTypeFaultSymptomSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetTypeFaultSymptom> query)
            : base(query) {}

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
        /// There are no comments for AssetMaintenanceFaultSymptom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultSymptomSingle AssetMaintenanceFaultSymptom
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFaultSymptom == null))
                {
                    this._AssetMaintenanceFaultSymptom = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultSymptomSingle(this.Context, GetPath("AssetMaintenanceFaultSymptom"));
                }
                return this._AssetMaintenanceFaultSymptom;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultSymptomSingle _AssetMaintenanceFaultSymptom;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetTypeFaultSymptom in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MaintenanceAssetTypeId
    /// FaultSymptomId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MaintenanceAssetTypeId", "FaultSymptomId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceAssetTypeFaultSymptoms")]
    public partial class AssetMaintenanceAssetTypeFaultSymptom : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceAssetTypeFaultSymptom object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="maintenanceAssetTypeId">Initial value of MaintenanceAssetTypeId.</param>
        /// <param name="faultSymptomId">Initial value of FaultSymptomId.</param>
        /// <param name="assetMaintenanceAssetType">Initial value of AssetMaintenanceAssetType.</param>
        /// <param name="assetMaintenanceFaultSymptom">Initial value of AssetMaintenanceFaultSymptom.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceAssetTypeFaultSymptom CreateAssetMaintenanceAssetTypeFaultSymptom(string dataAreaId, string maintenanceAssetTypeId, string faultSymptomId, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetType assetMaintenanceAssetType, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultSymptom assetMaintenanceFaultSymptom)
        {
            AssetMaintenanceAssetTypeFaultSymptom assetMaintenanceAssetTypeFaultSymptom = new AssetMaintenanceAssetTypeFaultSymptom();
            assetMaintenanceAssetTypeFaultSymptom.dataAreaId = dataAreaId;
            assetMaintenanceAssetTypeFaultSymptom.MaintenanceAssetTypeId = maintenanceAssetTypeId;
            assetMaintenanceAssetTypeFaultSymptom.FaultSymptomId = faultSymptomId;
            if ((assetMaintenanceAssetType == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceAssetType");
            }
            assetMaintenanceAssetTypeFaultSymptom.AssetMaintenanceAssetType = assetMaintenanceAssetType;
            if ((assetMaintenanceFaultSymptom == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceFaultSymptom");
            }
            assetMaintenanceAssetTypeFaultSymptom.AssetMaintenanceFaultSymptom = assetMaintenanceFaultSymptom;
            return assetMaintenanceAssetTypeFaultSymptom;
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
        /// There are no comments for Property FaultSymptomId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FaultSymptomId
        {
            get
            {
                return this._FaultSymptomId;
            }
            set
            {
                this.OnFaultSymptomIdChanging(value);
                this._FaultSymptomId = value;
                this.OnFaultSymptomIdChanged();
                this.OnPropertyChanged("FaultSymptomId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FaultSymptomId;
        partial void OnFaultSymptomIdChanging(string value);
        partial void OnFaultSymptomIdChanged();
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
        /// There are no comments for Property AssetMaintenanceFaultSymptom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultSymptom AssetMaintenanceFaultSymptom
        {
            get
            {
                return this._AssetMaintenanceFaultSymptom;
            }
            set
            {
                this.OnAssetMaintenanceFaultSymptomChanging(value);
                this._AssetMaintenanceFaultSymptom = value;
                this.OnAssetMaintenanceFaultSymptomChanged();
                this.OnPropertyChanged("AssetMaintenanceFaultSymptom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultSymptom _AssetMaintenanceFaultSymptom;
        partial void OnAssetMaintenanceFaultSymptomChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultSymptom value);
        partial void OnAssetMaintenanceFaultSymptomChanged();
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
