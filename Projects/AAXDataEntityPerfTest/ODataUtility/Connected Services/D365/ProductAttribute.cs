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
        /// There are no comments for ProductAttributeSingle in the schema.
        /// </summary>
    public partial class ProductAttributeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductAttribute>
    {
        /// <summary>
        /// Initialize a new ProductAttributeSingle object.
        /// </summary>
        public ProductAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductAttributeSingle object.
        /// </summary>
        public ProductAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductAttributeSingle object.
        /// </summary>
        public ProductAttributeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductAttribute> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedEngineeringProductVersionAttributeValues in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersionAttributeValue> ReleasedEngineeringProductVersionAttributeValues
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedEngineeringProductVersionAttributeValues == null))
                {
                    this._ReleasedEngineeringProductVersionAttributeValues = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersionAttributeValue>(GetPath("ReleasedEngineeringProductVersionAttributeValues"));
                }
                return this._ReleasedEngineeringProductVersionAttributeValues;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersionAttributeValue> _ReleasedEngineeringProductVersionAttributeValues;
        /// <summary>
        /// There are no comments for ProductAttributeTranslations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductAttributeTranslation> ProductAttributeTranslations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductAttributeTranslations == null))
                {
                    this._ProductAttributeTranslations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductAttributeTranslation>(GetPath("ProductAttributeTranslations"));
                }
                return this._ProductAttributeTranslations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductAttributeTranslation> _ProductAttributeTranslations;
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductAttributes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductAttribute> EngineeringChangeOrderProductAttributes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProductAttributes == null))
                {
                    this._EngineeringChangeOrderProductAttributes = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductAttribute>(GetPath("EngineeringChangeOrderProductAttributes"));
                }
                return this._EngineeringChangeOrderProductAttributes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductAttribute> _EngineeringChangeOrderProductAttributes;
        /// <summary>
        /// There are no comments for AttributeMetadata in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AttributeMetadata> AttributeMetadata
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AttributeMetadata == null))
                {
                    this._AttributeMetadata = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AttributeMetadata>(GetPath("AttributeMetadata"));
                }
                return this._AttributeMetadata;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AttributeMetadata> _AttributeMetadata;
        /// <summary>
        /// There are no comments for ReleasedEngineeringProductVersionAttributes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersionAttribute> ReleasedEngineeringProductVersionAttributes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedEngineeringProductVersionAttributes == null))
                {
                    this._ReleasedEngineeringProductVersionAttributes = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersionAttribute>(GetPath("ReleasedEngineeringProductVersionAttributes"));
                }
                return this._ReleasedEngineeringProductVersionAttributes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersionAttribute> _ReleasedEngineeringProductVersionAttributes;
    }
        /// <summary>
        /// There are no comments for ProductAttribute in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ProductAttributeTypeName
    /// AttributeName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductAttributeTypeName", "AttributeName")]
    [global::Microsoft.OData.Client.EntitySet("ProductAttributes")]
    public partial class ProductAttribute : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductAttribute object.
        /// </summary>
        /// <param name="productAttributeTypeName">Initial value of ProductAttributeTypeName.</param>
        /// <param name="attributeName">Initial value of AttributeName.</param>
        /// <param name="defaultDateTimeValue">Initial value of DefaultDateTimeValue.</param>
        /// <param name="defaultCurrencyValue">Initial value of DefaultCurrencyValue.</param>
        /// <param name="defaultDecimalValue">Initial value of DefaultDecimalValue.</param>
        /// <param name="defaultIntegerValue">Initial value of DefaultIntegerValue.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductAttribute CreateProductAttribute(string productAttributeTypeName, 
                    string attributeName, 
                    global::System.DateTimeOffset defaultDateTimeValue, 
                    decimal defaultCurrencyValue, 
                    decimal defaultDecimalValue, 
                    int defaultIntegerValue)
        {
            ProductAttribute productAttribute = new ProductAttribute();
            productAttribute.ProductAttributeTypeName = productAttributeTypeName;
            productAttribute.AttributeName = attributeName;
            productAttribute.DefaultDateTimeValue = defaultDateTimeValue;
            productAttribute.DefaultCurrencyValue = defaultCurrencyValue;
            productAttribute.DefaultDecimalValue = defaultDecimalValue;
            productAttribute.DefaultIntegerValue = defaultIntegerValue;
            return productAttribute;
        }
        /// <summary>
        /// There are no comments for Property ProductAttributeTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductAttributeTypeName
        {
            get
            {
                return this._ProductAttributeTypeName;
            }
            set
            {
                this.OnProductAttributeTypeNameChanging(value);
                this._ProductAttributeTypeName = value;
                this.OnProductAttributeTypeNameChanged();
                this.OnPropertyChanged("ProductAttributeTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductAttributeTypeName;
        partial void OnProductAttributeTypeNameChanging(string value);
        partial void OnProductAttributeTypeNameChanged();
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
        /// There are no comments for Property DefaultDateTimeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DefaultDateTimeValue
        {
            get
            {
                return this._DefaultDateTimeValue;
            }
            set
            {
                this.OnDefaultDateTimeValueChanging(value);
                this._DefaultDateTimeValue = value;
                this.OnDefaultDateTimeValueChanged();
                this.OnPropertyChanged("DefaultDateTimeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DefaultDateTimeValue;
        partial void OnDefaultDateTimeValueChanging(global::System.DateTimeOffset value);
        partial void OnDefaultDateTimeValueChanged();
        /// <summary>
        /// There are no comments for Property DefaultCurrencyValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DefaultCurrencyValue
        {
            get
            {
                return this._DefaultCurrencyValue;
            }
            set
            {
                this.OnDefaultCurrencyValueChanging(value);
                this._DefaultCurrencyValue = value;
                this.OnDefaultCurrencyValueChanged();
                this.OnPropertyChanged("DefaultCurrencyValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DefaultCurrencyValue;
        partial void OnDefaultCurrencyValueChanging(decimal value);
        partial void OnDefaultCurrencyValueChanged();
        /// <summary>
        /// There are no comments for Property DefaultBooleanValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DefaultBooleanValue
        {
            get
            {
                return this._DefaultBooleanValue;
            }
            set
            {
                this.OnDefaultBooleanValueChanging(value);
                this._DefaultBooleanValue = value;
                this.OnDefaultBooleanValueChanged();
                this.OnPropertyChanged("DefaultBooleanValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DefaultBooleanValue;
        partial void OnDefaultBooleanValueChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDefaultBooleanValueChanged();
        /// <summary>
        /// There are no comments for Property DefaultDecimalValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DefaultDecimalValue
        {
            get
            {
                return this._DefaultDecimalValue;
            }
            set
            {
                this.OnDefaultDecimalValueChanging(value);
                this._DefaultDecimalValue = value;
                this.OnDefaultDecimalValueChanged();
                this.OnPropertyChanged("DefaultDecimalValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DefaultDecimalValue;
        partial void OnDefaultDecimalValueChanging(decimal value);
        partial void OnDefaultDecimalValueChanged();
        /// <summary>
        /// There are no comments for Property DefaultIntegerValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int DefaultIntegerValue
        {
            get
            {
                return this._DefaultIntegerValue;
            }
            set
            {
                this.OnDefaultIntegerValueChanging(value);
                this._DefaultIntegerValue = value;
                this.OnDefaultIntegerValueChanged();
                this.OnPropertyChanged("DefaultIntegerValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DefaultIntegerValue;
        partial void OnDefaultIntegerValueChanging(int value);
        partial void OnDefaultIntegerValueChanged();
        /// <summary>
        /// There are no comments for Property DefaultCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultCurrencyCode
        {
            get
            {
                return this._DefaultCurrencyCode;
            }
            set
            {
                this.OnDefaultCurrencyCodeChanging(value);
                this._DefaultCurrencyCode = value;
                this.OnDefaultCurrencyCodeChanged();
                this.OnPropertyChanged("DefaultCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultCurrencyCode;
        partial void OnDefaultCurrencyCodeChanging(string value);
        partial void OnDefaultCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property AttributeDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttributeDescription
        {
            get
            {
                return this._AttributeDescription;
            }
            set
            {
                this.OnAttributeDescriptionChanging(value);
                this._AttributeDescription = value;
                this.OnAttributeDescriptionChanged();
                this.OnPropertyChanged("AttributeDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeDescription;
        partial void OnAttributeDescriptionChanging(string value);
        partial void OnAttributeDescriptionChanged();
        /// <summary>
        /// There are no comments for Property DefaultTextValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultTextValue
        {
            get
            {
                return this._DefaultTextValue;
            }
            set
            {
                this.OnDefaultTextValueChanging(value);
                this._DefaultTextValue = value;
                this.OnDefaultTextValueChanged();
                this.OnPropertyChanged("DefaultTextValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultTextValue;
        partial void OnDefaultTextValueChanging(string value);
        partial void OnDefaultTextValueChanged();
        /// <summary>
        /// There are no comments for Property AttributeHelpText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttributeHelpText
        {
            get
            {
                return this._AttributeHelpText;
            }
            set
            {
                this.OnAttributeHelpTextChanging(value);
                this._AttributeHelpText = value;
                this.OnAttributeHelpTextChanged();
                this.OnPropertyChanged("AttributeHelpText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeHelpText;
        partial void OnAttributeHelpTextChanging(string value);
        partial void OnAttributeHelpTextChanged();
        /// <summary>
        /// There are no comments for Property FriendlyAttributeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FriendlyAttributeName
        {
            get
            {
                return this._FriendlyAttributeName;
            }
            set
            {
                this.OnFriendlyAttributeNameChanging(value);
                this._FriendlyAttributeName = value;
                this.OnFriendlyAttributeNameChanged();
                this.OnPropertyChanged("FriendlyAttributeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FriendlyAttributeName;
        partial void OnFriendlyAttributeNameChanging(string value);
        partial void OnFriendlyAttributeNameChanged();
        /// <summary>
        /// There are no comments for Property ReleasedEngineeringProductVersionAttributeValues in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersionAttributeValue> ReleasedEngineeringProductVersionAttributeValues
        {
            get
            {
                return this._ReleasedEngineeringProductVersionAttributeValues;
            }
            set
            {
                this.OnReleasedEngineeringProductVersionAttributeValuesChanging(value);
                this._ReleasedEngineeringProductVersionAttributeValues = value;
                this.OnReleasedEngineeringProductVersionAttributeValuesChanged();
                this.OnPropertyChanged("ReleasedEngineeringProductVersionAttributeValues");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersionAttributeValue> _ReleasedEngineeringProductVersionAttributeValues = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersionAttributeValue>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedEngineeringProductVersionAttributeValuesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersionAttributeValue> value);
        partial void OnReleasedEngineeringProductVersionAttributeValuesChanged();
        /// <summary>
        /// There are no comments for Property ProductAttributeTranslations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductAttributeTranslation> ProductAttributeTranslations
        {
            get
            {
                return this._ProductAttributeTranslations;
            }
            set
            {
                this.OnProductAttributeTranslationsChanging(value);
                this._ProductAttributeTranslations = value;
                this.OnProductAttributeTranslationsChanged();
                this.OnPropertyChanged("ProductAttributeTranslations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductAttributeTranslation> _ProductAttributeTranslations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductAttributeTranslation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductAttributeTranslationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductAttributeTranslation> value);
        partial void OnProductAttributeTranslationsChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductAttributes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductAttribute> EngineeringChangeOrderProductAttributes
        {
            get
            {
                return this._EngineeringChangeOrderProductAttributes;
            }
            set
            {
                this.OnEngineeringChangeOrderProductAttributesChanging(value);
                this._EngineeringChangeOrderProductAttributes = value;
                this.OnEngineeringChangeOrderProductAttributesChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductAttributes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductAttribute> _EngineeringChangeOrderProductAttributes = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductAttribute>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeOrderProductAttributesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductAttribute> value);
        partial void OnEngineeringChangeOrderProductAttributesChanged();
        /// <summary>
        /// There are no comments for Property AttributeMetadata in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AttributeMetadata> AttributeMetadata
        {
            get
            {
                return this._AttributeMetadata;
            }
            set
            {
                this.OnAttributeMetadataChanging(value);
                this._AttributeMetadata = value;
                this.OnAttributeMetadataChanged();
                this.OnPropertyChanged("AttributeMetadata");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AttributeMetadata> _AttributeMetadata = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AttributeMetadata>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAttributeMetadataChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AttributeMetadata> value);
        partial void OnAttributeMetadataChanged();
        /// <summary>
        /// There are no comments for Property ReleasedEngineeringProductVersionAttributes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersionAttribute> ReleasedEngineeringProductVersionAttributes
        {
            get
            {
                return this._ReleasedEngineeringProductVersionAttributes;
            }
            set
            {
                this.OnReleasedEngineeringProductVersionAttributesChanging(value);
                this._ReleasedEngineeringProductVersionAttributes = value;
                this.OnReleasedEngineeringProductVersionAttributesChanged();
                this.OnPropertyChanged("ReleasedEngineeringProductVersionAttributes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersionAttribute> _ReleasedEngineeringProductVersionAttributes = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersionAttribute>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedEngineeringProductVersionAttributesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersionAttribute> value);
        partial void OnReleasedEngineeringProductVersionAttributesChanged();
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
