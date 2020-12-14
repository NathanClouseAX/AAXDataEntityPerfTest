﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 12/8/2020 7:45:22 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for RetailCatalogInternalOrganizationProductAttributeValueSingle in the schema.
        /// </summary>
    public partial class RetailCatalogInternalOrganizationProductAttributeValueSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailCatalogInternalOrganizationProductAttributeValue>
    {
        /// <summary>
        /// Initialize a new RetailCatalogInternalOrganizationProductAttributeValueSingle object.
        /// </summary>
        public RetailCatalogInternalOrganizationProductAttributeValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailCatalogInternalOrganizationProductAttributeValueSingle object.
        /// </summary>
        public RetailCatalogInternalOrganizationProductAttributeValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailCatalogInternalOrganizationProductAttributeValueSingle object.
        /// </summary>
        public RetailCatalogInternalOrganizationProductAttributeValueSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailCatalogInternalOrganizationProductAttributeValue> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailCatalogInternalOrganization in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationSingle RetailCatalogInternalOrganization
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalogInternalOrganization == null))
                {
                    this._RetailCatalogInternalOrganization = new global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationSingle(this.Context, GetPath("RetailCatalogInternalOrganization"));
                }
                return this._RetailCatalogInternalOrganization;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationSingle _RetailCatalogInternalOrganization;
        /// <summary>
        /// There are no comments for RetailCatalogProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalogProductSingle RetailCatalogProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalogProduct == null))
                {
                    this._RetailCatalogProduct = new global::Microsoft.Dynamics.DataEntities.RetailCatalogProductSingle(this.Context, GetPath("RetailCatalogProduct"));
                }
                return this._RetailCatalogProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalogProductSingle _RetailCatalogProduct;
        /// <summary>
        /// There are no comments for RetailCatalog in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle RetailCatalog
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalog == null))
                {
                    this._RetailCatalog = new global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle(this.Context, GetPath("RetailCatalog"));
                }
                return this._RetailCatalog;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle _RetailCatalog;
    }
        /// <summary>
        /// There are no comments for RetailCatalogInternalOrganizationProductAttributeValue in the schema.
        /// </summary>
    /// <KeyProperties>
    /// CatalogNumber
    /// PartyNumber
    /// DisplayProductNumber
    /// AttributeGroupName
    /// AttributeName
    /// AttributeTypeName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CatalogNumber", "PartyNumber", "DisplayProductNumber", "AttributeGroupName", "AttributeName", "AttributeTypeName")]
    [global::Microsoft.OData.Client.EntitySet("RetailCatalogInternalOrganizationProductAttributeValues")]
    public partial class RetailCatalogInternalOrganizationProductAttributeValue : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailCatalogInternalOrganizationProductAttributeValue object.
        /// </summary>
        /// <param name="catalogNumber">Initial value of CatalogNumber.</param>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        /// <param name="displayProductNumber">Initial value of DisplayProductNumber.</param>
        /// <param name="attributeGroupName">Initial value of AttributeGroupName.</param>
        /// <param name="attributeName">Initial value of AttributeName.</param>
        /// <param name="attributeTypeName">Initial value of AttributeTypeName.</param>
        /// <param name="integerValue">Initial value of IntegerValue.</param>
        /// <param name="decimalValue">Initial value of DecimalValue.</param>
        /// <param name="dateTimeValue">Initial value of DateTimeValue.</param>
        /// <param name="currencyValue">Initial value of CurrencyValue.</param>
        /// <param name="retailCatalogInternalOrganization">Initial value of RetailCatalogInternalOrganization.</param>
        /// <param name="retailCatalogProduct">Initial value of RetailCatalogProduct.</param>
        /// <param name="retailCatalog">Initial value of RetailCatalog.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailCatalogInternalOrganizationProductAttributeValue CreateRetailCatalogInternalOrganizationProductAttributeValue(string catalogNumber, 
                    string partyNumber, 
                    string displayProductNumber, 
                    string attributeGroupName, 
                    string attributeName, 
                    string attributeTypeName, 
                    int integerValue, 
                    decimal decimalValue, 
                    global::System.DateTimeOffset dateTimeValue, 
                    decimal currencyValue, 
                    global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganization retailCatalogInternalOrganization, 
                    global::Microsoft.Dynamics.DataEntities.RetailCatalogProduct retailCatalogProduct, 
                    global::Microsoft.Dynamics.DataEntities.RetailCatalog retailCatalog)
        {
            RetailCatalogInternalOrganizationProductAttributeValue retailCatalogInternalOrganizationProductAttributeValue = new RetailCatalogInternalOrganizationProductAttributeValue();
            retailCatalogInternalOrganizationProductAttributeValue.CatalogNumber = catalogNumber;
            retailCatalogInternalOrganizationProductAttributeValue.PartyNumber = partyNumber;
            retailCatalogInternalOrganizationProductAttributeValue.DisplayProductNumber = displayProductNumber;
            retailCatalogInternalOrganizationProductAttributeValue.AttributeGroupName = attributeGroupName;
            retailCatalogInternalOrganizationProductAttributeValue.AttributeName = attributeName;
            retailCatalogInternalOrganizationProductAttributeValue.AttributeTypeName = attributeTypeName;
            retailCatalogInternalOrganizationProductAttributeValue.IntegerValue = integerValue;
            retailCatalogInternalOrganizationProductAttributeValue.DecimalValue = decimalValue;
            retailCatalogInternalOrganizationProductAttributeValue.DateTimeValue = dateTimeValue;
            retailCatalogInternalOrganizationProductAttributeValue.CurrencyValue = currencyValue;
            if ((retailCatalogInternalOrganization == null))
            {
                throw new global::System.ArgumentNullException("retailCatalogInternalOrganization");
            }
            retailCatalogInternalOrganizationProductAttributeValue.RetailCatalogInternalOrganization = retailCatalogInternalOrganization;
            if ((retailCatalogProduct == null))
            {
                throw new global::System.ArgumentNullException("retailCatalogProduct");
            }
            retailCatalogInternalOrganizationProductAttributeValue.RetailCatalogProduct = retailCatalogProduct;
            if ((retailCatalog == null))
            {
                throw new global::System.ArgumentNullException("retailCatalog");
            }
            retailCatalogInternalOrganizationProductAttributeValue.RetailCatalog = retailCatalog;
            return retailCatalogInternalOrganizationProductAttributeValue;
        }
        /// <summary>
        /// There are no comments for Property CatalogNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CatalogNumber
        {
            get
            {
                return this._CatalogNumber;
            }
            set
            {
                this.OnCatalogNumberChanging(value);
                this._CatalogNumber = value;
                this.OnCatalogNumberChanged();
                this.OnPropertyChanged("CatalogNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CatalogNumber;
        partial void OnCatalogNumberChanging(string value);
        partial void OnCatalogNumberChanged();
        /// <summary>
        /// There are no comments for Property PartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PartyNumber
        {
            get
            {
                return this._PartyNumber;
            }
            set
            {
                this.OnPartyNumberChanging(value);
                this._PartyNumber = value;
                this.OnPartyNumberChanged();
                this.OnPropertyChanged("PartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartyNumber;
        partial void OnPartyNumberChanging(string value);
        partial void OnPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property DisplayProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DisplayProductNumber
        {
            get
            {
                return this._DisplayProductNumber;
            }
            set
            {
                this.OnDisplayProductNumberChanging(value);
                this._DisplayProductNumber = value;
                this.OnDisplayProductNumberChanged();
                this.OnPropertyChanged("DisplayProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DisplayProductNumber;
        partial void OnDisplayProductNumberChanging(string value);
        partial void OnDisplayProductNumberChanged();
        /// <summary>
        /// There are no comments for Property AttributeGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttributeGroupName
        {
            get
            {
                return this._AttributeGroupName;
            }
            set
            {
                this.OnAttributeGroupNameChanging(value);
                this._AttributeGroupName = value;
                this.OnAttributeGroupNameChanged();
                this.OnPropertyChanged("AttributeGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeGroupName;
        partial void OnAttributeGroupNameChanging(string value);
        partial void OnAttributeGroupNameChanged();
        /// <summary>
        /// There are no comments for Property AttributeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttributeName
        {
            get
            {
                return this._AttributeName;
            }
            set
            {
                this.OnAttributeNameChanging(value);
                this._AttributeName = value;
                this.OnAttributeNameChanged();
                this.OnPropertyChanged("AttributeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeName;
        partial void OnAttributeNameChanging(string value);
        partial void OnAttributeNameChanged();
        /// <summary>
        /// There are no comments for Property AttributeTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttributeTypeName
        {
            get
            {
                return this._AttributeTypeName;
            }
            set
            {
                this.OnAttributeTypeNameChanging(value);
                this._AttributeTypeName = value;
                this.OnAttributeTypeNameChanged();
                this.OnPropertyChanged("AttributeTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeTypeName;
        partial void OnAttributeTypeNameChanging(string value);
        partial void OnAttributeTypeNameChanged();
        /// <summary>
        /// There are no comments for Property IntegerValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int IntegerValue
        {
            get
            {
                return this._IntegerValue;
            }
            set
            {
                this.OnIntegerValueChanging(value);
                this._IntegerValue = value;
                this.OnIntegerValueChanged();
                this.OnPropertyChanged("IntegerValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _IntegerValue;
        partial void OnIntegerValueChanging(int value);
        partial void OnIntegerValueChanged();
        /// <summary>
        /// There are no comments for Property BooleanValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> BooleanValue
        {
            get
            {
                return this._BooleanValue;
            }
            set
            {
                this.OnBooleanValueChanging(value);
                this._BooleanValue = value;
                this.OnBooleanValueChanged();
                this.OnPropertyChanged("BooleanValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _BooleanValue;
        partial void OnBooleanValueChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnBooleanValueChanged();
        /// <summary>
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this.OnCurrencyCodeChanging(value);
                this._CurrencyCode = value;
                this.OnCurrencyCodeChanged();
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property DecimalValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DecimalValue
        {
            get
            {
                return this._DecimalValue;
            }
            set
            {
                this.OnDecimalValueChanging(value);
                this._DecimalValue = value;
                this.OnDecimalValueChanged();
                this.OnPropertyChanged("DecimalValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DecimalValue;
        partial void OnDecimalValueChanging(decimal value);
        partial void OnDecimalValueChanged();
        /// <summary>
        /// There are no comments for Property DateTimeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DateTimeValue
        {
            get
            {
                return this._DateTimeValue;
            }
            set
            {
                this.OnDateTimeValueChanging(value);
                this._DateTimeValue = value;
                this.OnDateTimeValueChanged();
                this.OnPropertyChanged("DateTimeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateTimeValue;
        partial void OnDateTimeValueChanging(global::System.DateTimeOffset value);
        partial void OnDateTimeValueChanged();
        /// <summary>
        /// There are no comments for Property CurrencyValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CurrencyValue
        {
            get
            {
                return this._CurrencyValue;
            }
            set
            {
                this.OnCurrencyValueChanging(value);
                this._CurrencyValue = value;
                this.OnCurrencyValueChanged();
                this.OnPropertyChanged("CurrencyValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CurrencyValue;
        partial void OnCurrencyValueChanging(decimal value);
        partial void OnCurrencyValueChanged();
        /// <summary>
        /// There are no comments for Property TextValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TextValue
        {
            get
            {
                return this._TextValue;
            }
            set
            {
                this.OnTextValueChanging(value);
                this._TextValue = value;
                this.OnTextValueChanged();
                this.OnPropertyChanged("TextValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TextValue;
        partial void OnTextValueChanging(string value);
        partial void OnTextValueChanged();
        /// <summary>
        /// There are no comments for Property RetailCatalogInternalOrganization in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganization RetailCatalogInternalOrganization
        {
            get
            {
                return this._RetailCatalogInternalOrganization;
            }
            set
            {
                this.OnRetailCatalogInternalOrganizationChanging(value);
                this._RetailCatalogInternalOrganization = value;
                this.OnRetailCatalogInternalOrganizationChanged();
                this.OnPropertyChanged("RetailCatalogInternalOrganization");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganization _RetailCatalogInternalOrganization;
        partial void OnRetailCatalogInternalOrganizationChanging(global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganization value);
        partial void OnRetailCatalogInternalOrganizationChanged();
        /// <summary>
        /// There are no comments for Property RetailCatalogProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalogProduct RetailCatalogProduct
        {
            get
            {
                return this._RetailCatalogProduct;
            }
            set
            {
                this.OnRetailCatalogProductChanging(value);
                this._RetailCatalogProduct = value;
                this.OnRetailCatalogProductChanged();
                this.OnPropertyChanged("RetailCatalogProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalogProduct _RetailCatalogProduct;
        partial void OnRetailCatalogProductChanging(global::Microsoft.Dynamics.DataEntities.RetailCatalogProduct value);
        partial void OnRetailCatalogProductChanged();
        /// <summary>
        /// There are no comments for Property RetailCatalog in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalog RetailCatalog
        {
            get
            {
                return this._RetailCatalog;
            }
            set
            {
                this.OnRetailCatalogChanging(value);
                this._RetailCatalog = value;
                this.OnRetailCatalogChanged();
                this.OnPropertyChanged("RetailCatalog");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalog _RetailCatalog;
        partial void OnRetailCatalogChanging(global::Microsoft.Dynamics.DataEntities.RetailCatalog value);
        partial void OnRetailCatalogChanged();
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
