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
    /// There are no comments for AssetMaintenanceAssetAttributeSingle in the schema.
    /// </summary>
    public partial class AssetMaintenanceAssetAttributeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetAttribute>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceAssetAttributeSingle object.
        /// </summary>
        public AssetMaintenanceAssetAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetAttributeSingle object.
        /// </summary>
        public AssetMaintenanceAssetAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetAttributeSingle object.
        /// </summary>
        public AssetMaintenanceAssetAttributeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetAttribute> query)
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
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceAssetAttribute in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MaintenanceAssetId
    /// AttributeTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MaintenanceAssetId", "AttributeTypeId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceAssetAttributes")]
    public partial class AssetMaintenanceAssetAttribute : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceAssetAttribute object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="maintenanceAssetId">Initial value of MaintenanceAssetId.</param>
        /// <param name="attributeTypeId">Initial value of AttributeTypeId.</param>
        /// <param name="valueReal">Initial value of ValueReal.</param>
        /// <param name="valueDate">Initial value of ValueDate.</param>
        /// <param name="valueInteger">Initial value of ValueInteger.</param>
        /// <param name="line">Initial value of Line.</param>
        /// <param name="assetMaintenanceSpecificationType">Initial value of AssetMaintenanceSpecificationType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceAssetAttribute CreateAssetMaintenanceAssetAttribute(string dataAreaId, 
                    string maintenanceAssetId, 
                    string attributeTypeId, 
                    decimal valueReal, 
                    global::System.DateTimeOffset valueDate, 
                    int valueInteger, 
                    int line, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceSpecificationType assetMaintenanceSpecificationType)
        {
            AssetMaintenanceAssetAttribute assetMaintenanceAssetAttribute = new AssetMaintenanceAssetAttribute();
            assetMaintenanceAssetAttribute.dataAreaId = dataAreaId;
            assetMaintenanceAssetAttribute.MaintenanceAssetId = maintenanceAssetId;
            assetMaintenanceAssetAttribute.AttributeTypeId = attributeTypeId;
            assetMaintenanceAssetAttribute.ValueReal = valueReal;
            assetMaintenanceAssetAttribute.ValueDate = valueDate;
            assetMaintenanceAssetAttribute.ValueInteger = valueInteger;
            assetMaintenanceAssetAttribute.Line = line;
            if ((assetMaintenanceSpecificationType == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceSpecificationType");
            }
            assetMaintenanceAssetAttribute.AssetMaintenanceSpecificationType = assetMaintenanceSpecificationType;
            return assetMaintenanceAssetAttribute;
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
        /// There are no comments for Property AttributeTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AttributeTypeId is required.")]
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
        /// There are no comments for Property ValueReal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValueReal is required.")]
        public virtual decimal ValueReal
        {
            get
            {
                return this._ValueReal;
            }
            set
            {
                this.OnValueRealChanging(value);
                this._ValueReal = value;
                this.OnValueRealChanged();
                this.OnPropertyChanged("ValueReal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ValueReal;
        partial void OnValueRealChanging(decimal value);
        partial void OnValueRealChanged();
        /// <summary>
        /// There are no comments for Property ValueNoYes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ValueNoYes
        {
            get
            {
                return this._ValueNoYes;
            }
            set
            {
                this.OnValueNoYesChanging(value);
                this._ValueNoYes = value;
                this.OnValueNoYesChanged();
                this.OnPropertyChanged("ValueNoYes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ValueNoYes;
        partial void OnValueNoYesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnValueNoYesChanged();
        /// <summary>
        /// There are no comments for Property ValueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValueDate is required.")]
        public virtual global::System.DateTimeOffset ValueDate
        {
            get
            {
                return this._ValueDate;
            }
            set
            {
                this.OnValueDateChanging(value);
                this._ValueDate = value;
                this.OnValueDateChanged();
                this.OnPropertyChanged("ValueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValueDate;
        partial void OnValueDateChanging(global::System.DateTimeOffset value);
        partial void OnValueDateChanged();
        /// <summary>
        /// There are no comments for Property ValueString in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ValueString
        {
            get
            {
                return this._ValueString;
            }
            set
            {
                this.OnValueStringChanging(value);
                this._ValueString = value;
                this.OnValueStringChanged();
                this.OnPropertyChanged("ValueString");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ValueString;
        partial void OnValueStringChanging(string value);
        partial void OnValueStringChanged();
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
        /// There are no comments for Property Mandatory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Mandatory
        {
            get
            {
                return this._Mandatory;
            }
            set
            {
                this.OnMandatoryChanging(value);
                this._Mandatory = value;
                this.OnMandatoryChanged();
                this.OnPropertyChanged("Mandatory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Mandatory;
        partial void OnMandatoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnMandatoryChanged();
        /// <summary>
        /// There are no comments for Property ValueInteger in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValueInteger is required.")]
        public virtual int ValueInteger
        {
            get
            {
                return this._ValueInteger;
            }
            set
            {
                this.OnValueIntegerChanging(value);
                this._ValueInteger = value;
                this.OnValueIntegerChanged();
                this.OnPropertyChanged("ValueInteger");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ValueInteger;
        partial void OnValueIntegerChanging(int value);
        partial void OnValueIntegerChanged();
        /// <summary>
        /// There are no comments for Property Line in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Line is required.")]
        public virtual int Line
        {
            get
            {
                return this._Line;
            }
            set
            {
                this.OnLineChanging(value);
                this._Line = value;
                this.OnLineChanged();
                this.OnPropertyChanged("Line");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Line;
        partial void OnLineChanging(int value);
        partial void OnLineChanged();
        /// <summary>
        /// There are no comments for Property AttributeTypeDataType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetConditionType> AttributeTypeDataType
        {
            get
            {
                return this._AttributeTypeDataType;
            }
            set
            {
                this.OnAttributeTypeDataTypeChanging(value);
                this._AttributeTypeDataType = value;
                this.OnAttributeTypeDataTypeChanged();
                this.OnPropertyChanged("AttributeTypeDataType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetConditionType> _AttributeTypeDataType;
        partial void OnAttributeTypeDataTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetConditionType> value);
        partial void OnAttributeTypeDataTypeChanged();
        /// <summary>
        /// There are no comments for Property UnitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string UnitId
        {
            get
            {
                return this._UnitId;
            }
            set
            {
                this.OnUnitIdChanging(value);
                this._UnitId = value;
                this.OnUnitIdChanged();
                this.OnPropertyChanged("UnitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitId;
        partial void OnUnitIdChanging(string value);
        partial void OnUnitIdChanged();
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
        /// There are no comments for Property AssetMaintenanceSpecificationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetMaintenanceSpecificationType is required.")]
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
