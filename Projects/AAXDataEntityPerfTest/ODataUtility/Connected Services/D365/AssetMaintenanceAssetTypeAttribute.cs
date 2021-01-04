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
        /// There are no comments for AssetMaintenanceAssetTypeAttributeSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceAssetTypeAttributeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetTypeAttribute>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceAssetTypeAttributeSingle object.
        /// </summary>
        public AssetMaintenanceAssetTypeAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetTypeAttributeSingle object.
        /// </summary>
        public AssetMaintenanceAssetTypeAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetTypeAttributeSingle object.
        /// </summary>
        public AssetMaintenanceAssetTypeAttributeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetTypeAttribute> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceSpecificationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceSpecificationTypeSingle AssetMaintenanceSpecificationType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceSpecificationType == null))
                {
                    this._AssetMaintenanceSpecificationType = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceSpecificationTypeSingle(this.Context, GetPath("AssetMaintenanceSpecificationType"));
                }
                return this._AssetMaintenanceSpecificationType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceSpecificationTypeSingle _AssetMaintenanceSpecificationType;
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
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetTypeAttribute in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MaintenanceAssetTypeId
    /// AttributeTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MaintenanceAssetTypeId", "AttributeTypeId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceAssetTypeAttributes")]
    public partial class AssetMaintenanceAssetTypeAttribute : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceAssetTypeAttribute object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="maintenanceAssetTypeId">Initial value of MaintenanceAssetTypeId.</param>
        /// <param name="attributeTypeId">Initial value of AttributeTypeId.</param>
        /// <param name="assetMaintenanceSpecificationType">Initial value of AssetMaintenanceSpecificationType.</param>
        /// <param name="assetMaintenanceAssetType">Initial value of AssetMaintenanceAssetType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceAssetTypeAttribute CreateAssetMaintenanceAssetTypeAttribute(string dataAreaId, string maintenanceAssetTypeId, string attributeTypeId, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceSpecificationType assetMaintenanceSpecificationType, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetType assetMaintenanceAssetType)
        {
            AssetMaintenanceAssetTypeAttribute assetMaintenanceAssetTypeAttribute = new AssetMaintenanceAssetTypeAttribute();
            assetMaintenanceAssetTypeAttribute.dataAreaId = dataAreaId;
            assetMaintenanceAssetTypeAttribute.MaintenanceAssetTypeId = maintenanceAssetTypeId;
            assetMaintenanceAssetTypeAttribute.AttributeTypeId = attributeTypeId;
            if ((assetMaintenanceSpecificationType == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceSpecificationType");
            }
            assetMaintenanceAssetTypeAttribute.AssetMaintenanceSpecificationType = assetMaintenanceSpecificationType;
            if ((assetMaintenanceAssetType == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceAssetType");
            }
            assetMaintenanceAssetTypeAttribute.AssetMaintenanceAssetType = assetMaintenanceAssetType;
            return assetMaintenanceAssetTypeAttribute;
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
        /// There are no comments for Property AttributeTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttributeTypeId
        {
            get
            {
                return this._AttributeTypeId;
            }
            set
            {
                this.OnAttributeTypeIdChanging(value);
                this._AttributeTypeId = value;
                this.OnAttributeTypeIdChanged();
                this.OnPropertyChanged("AttributeTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeTypeId;
        partial void OnAttributeTypeIdChanging(string value);
        partial void OnAttributeTypeIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceSpecificationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceSpecificationType AssetMaintenanceSpecificationType
        {
            get
            {
                return this._AssetMaintenanceSpecificationType;
            }
            set
            {
                this.OnAssetMaintenanceSpecificationTypeChanging(value);
                this._AssetMaintenanceSpecificationType = value;
                this.OnAssetMaintenanceSpecificationTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceSpecificationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceSpecificationType _AssetMaintenanceSpecificationType;
        partial void OnAssetMaintenanceSpecificationTypeChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceSpecificationType value);
        partial void OnAssetMaintenanceSpecificationTypeChanged();
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
