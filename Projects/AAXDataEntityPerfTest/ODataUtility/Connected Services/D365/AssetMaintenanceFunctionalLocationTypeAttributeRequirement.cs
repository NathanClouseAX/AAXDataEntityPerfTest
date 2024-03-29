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
    /// There are no comments for AssetMaintenanceFunctionalLocationTypeAttributeRequirementSingle in the schema.
    /// </summary>
    public partial class AssetMaintenanceFunctionalLocationTypeAttributeRequirementSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceFunctionalLocationTypeAttributeRequirement>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationTypeAttributeRequirementSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationTypeAttributeRequirementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationTypeAttributeRequirementSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationTypeAttributeRequirementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationTypeAttributeRequirementSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationTypeAttributeRequirementSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceFunctionalLocationTypeAttributeRequirement> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeSingle AssetMaintenanceFunctionalLocationType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationType == null))
                {
                    this._AssetMaintenanceFunctionalLocationType = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeSingle(this.Context, GetPath("AssetMaintenanceFunctionalLocationType"));
                }
                return this._AssetMaintenanceFunctionalLocationType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeSingle _AssetMaintenanceFunctionalLocationType;
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceFunctionalLocationTypeAttributeRequirement in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// FunctionalLocationTypeId
    /// AttributeTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FunctionalLocationTypeId", "AttributeTypeId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceFunctionalLocationTypeAttributeRequirements")]
    public partial class AssetMaintenanceFunctionalLocationTypeAttributeRequirement : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceFunctionalLocationTypeAttributeRequirement object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="functionalLocationTypeId">Initial value of FunctionalLocationTypeId.</param>
        /// <param name="attributeTypeId">Initial value of AttributeTypeId.</param>
        /// <param name="valueReal">Initial value of ValueReal.</param>
        /// <param name="valueDate">Initial value of ValueDate.</param>
        /// <param name="valueInteger">Initial value of ValueInteger.</param>
        /// <param name="assetMaintenanceFunctionalLocationType">Initial value of AssetMaintenanceFunctionalLocationType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceFunctionalLocationTypeAttributeRequirement CreateAssetMaintenanceFunctionalLocationTypeAttributeRequirement(string dataAreaId, 
                    string functionalLocationTypeId, 
                    string attributeTypeId, 
                    decimal valueReal, 
                    global::System.DateTimeOffset valueDate, 
                    int valueInteger, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationType assetMaintenanceFunctionalLocationType)
        {
            AssetMaintenanceFunctionalLocationTypeAttributeRequirement assetMaintenanceFunctionalLocationTypeAttributeRequirement = new AssetMaintenanceFunctionalLocationTypeAttributeRequirement();
            assetMaintenanceFunctionalLocationTypeAttributeRequirement.dataAreaId = dataAreaId;
            assetMaintenanceFunctionalLocationTypeAttributeRequirement.FunctionalLocationTypeId = functionalLocationTypeId;
            assetMaintenanceFunctionalLocationTypeAttributeRequirement.AttributeTypeId = attributeTypeId;
            assetMaintenanceFunctionalLocationTypeAttributeRequirement.ValueReal = valueReal;
            assetMaintenanceFunctionalLocationTypeAttributeRequirement.ValueDate = valueDate;
            assetMaintenanceFunctionalLocationTypeAttributeRequirement.ValueInteger = valueInteger;
            if ((assetMaintenanceFunctionalLocationType == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceFunctionalLocationType");
            }
            assetMaintenanceFunctionalLocationTypeAttributeRequirement.AssetMaintenanceFunctionalLocationType = assetMaintenanceFunctionalLocationType;
            return assetMaintenanceFunctionalLocationTypeAttributeRequirement;
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
        /// There are no comments for Property FunctionalLocationTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FunctionalLocationTypeId is required.")]
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
        /// There are no comments for Property ThresholdCriteria in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CuesThresholdCriteria> ThresholdCriteria
        {
            get
            {
                return this._ThresholdCriteria;
            }
            set
            {
                this.OnThresholdCriteriaChanging(value);
                this._ThresholdCriteria = value;
                this.OnThresholdCriteriaChanged();
                this.OnPropertyChanged("ThresholdCriteria");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CuesThresholdCriteria> _ThresholdCriteria;
        partial void OnThresholdCriteriaChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CuesThresholdCriteria> value);
        partial void OnThresholdCriteriaChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetMaintenanceFunctionalLocationType is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationType AssetMaintenanceFunctionalLocationType
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationType;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationTypeChanging(value);
                this._AssetMaintenanceFunctionalLocationType = value;
                this.OnAssetMaintenanceFunctionalLocationTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationType _AssetMaintenanceFunctionalLocationType;
        partial void OnAssetMaintenanceFunctionalLocationTypeChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationType value);
        partial void OnAssetMaintenanceFunctionalLocationTypeChanged();
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
