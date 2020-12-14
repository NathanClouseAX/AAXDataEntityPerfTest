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
        /// There are no comments for ProductAttributeTranslationSingle in the schema.
        /// </summary>
    public partial class ProductAttributeTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductAttributeTranslation>
    {
        /// <summary>
        /// Initialize a new ProductAttributeTranslationSingle object.
        /// </summary>
        public ProductAttributeTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductAttributeTranslationSingle object.
        /// </summary>
        public ProductAttributeTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductAttributeTranslationSingle object.
        /// </summary>
        public ProductAttributeTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductAttributeTranslation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductAttributeSingle ProductAttribute
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductAttribute == null))
                {
                    this._ProductAttribute = new global::Microsoft.Dynamics.DataEntities.ProductAttributeSingle(this.Context, GetPath("ProductAttribute"));
                }
                return this._ProductAttribute;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductAttributeSingle _ProductAttribute;
    }
        /// <summary>
        /// There are no comments for ProductAttributeTranslation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ProductAttributeName
    /// ProductAttributeTypeName
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductAttributeName", "ProductAttributeTypeName", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("ProductAttributeTranslations")]
    public partial class ProductAttributeTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductAttributeTranslation object.
        /// </summary>
        /// <param name="productAttributeName">Initial value of ProductAttributeName.</param>
        /// <param name="productAttributeTypeName">Initial value of ProductAttributeTypeName.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        /// <param name="productAttribute">Initial value of ProductAttribute.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductAttributeTranslation CreateProductAttributeTranslation(string productAttributeName, string productAttributeTypeName, string languageId, global::Microsoft.Dynamics.DataEntities.ProductAttribute productAttribute)
        {
            ProductAttributeTranslation productAttributeTranslation = new ProductAttributeTranslation();
            productAttributeTranslation.ProductAttributeName = productAttributeName;
            productAttributeTranslation.ProductAttributeTypeName = productAttributeTypeName;
            productAttributeTranslation.LanguageId = languageId;
            if ((productAttribute == null))
            {
                throw new global::System.ArgumentNullException("productAttribute");
            }
            productAttributeTranslation.ProductAttribute = productAttribute;
            return productAttributeTranslation;
        }
        /// <summary>
        /// There are no comments for Property ProductAttributeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductAttributeName
        {
            get
            {
                return this._ProductAttributeName;
            }
            set
            {
                this.OnProductAttributeNameChanging(value);
                this._ProductAttributeName = value;
                this.OnProductAttributeNameChanged();
                this.OnPropertyChanged("ProductAttributeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductAttributeName;
        partial void OnProductAttributeNameChanging(string value);
        partial void OnProductAttributeNameChanged();
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
        /// There are no comments for Property LanguageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LanguageId
        {
            get
            {
                return this._LanguageId;
            }
            set
            {
                this.OnLanguageIdChanging(value);
                this._LanguageId = value;
                this.OnLanguageIdChanged();
                this.OnPropertyChanged("LanguageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LanguageId;
        partial void OnLanguageIdChanging(string value);
        partial void OnLanguageIdChanged();
        /// <summary>
        /// There are no comments for Property TranslatedAttributeHelpText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TranslatedAttributeHelpText
        {
            get
            {
                return this._TranslatedAttributeHelpText;
            }
            set
            {
                this.OnTranslatedAttributeHelpTextChanging(value);
                this._TranslatedAttributeHelpText = value;
                this.OnTranslatedAttributeHelpTextChanged();
                this.OnPropertyChanged("TranslatedAttributeHelpText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedAttributeHelpText;
        partial void OnTranslatedAttributeHelpTextChanging(string value);
        partial void OnTranslatedAttributeHelpTextChanged();
        /// <summary>
        /// There are no comments for Property TranslatedAttributeDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TranslatedAttributeDescription
        {
            get
            {
                return this._TranslatedAttributeDescription;
            }
            set
            {
                this.OnTranslatedAttributeDescriptionChanging(value);
                this._TranslatedAttributeDescription = value;
                this.OnTranslatedAttributeDescriptionChanged();
                this.OnPropertyChanged("TranslatedAttributeDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedAttributeDescription;
        partial void OnTranslatedAttributeDescriptionChanging(string value);
        partial void OnTranslatedAttributeDescriptionChanged();
        /// <summary>
        /// There are no comments for Property TranslatedFriendlyAttributeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TranslatedFriendlyAttributeName
        {
            get
            {
                return this._TranslatedFriendlyAttributeName;
            }
            set
            {
                this.OnTranslatedFriendlyAttributeNameChanging(value);
                this._TranslatedFriendlyAttributeName = value;
                this.OnTranslatedFriendlyAttributeNameChanged();
                this.OnPropertyChanged("TranslatedFriendlyAttributeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedFriendlyAttributeName;
        partial void OnTranslatedFriendlyAttributeNameChanging(string value);
        partial void OnTranslatedFriendlyAttributeNameChanged();
        /// <summary>
        /// There are no comments for Property ProductAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductAttribute ProductAttribute
        {
            get
            {
                return this._ProductAttribute;
            }
            set
            {
                this.OnProductAttributeChanging(value);
                this._ProductAttribute = value;
                this.OnProductAttributeChanged();
                this.OnPropertyChanged("ProductAttribute");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductAttribute _ProductAttribute;
        partial void OnProductAttributeChanging(global::Microsoft.Dynamics.DataEntities.ProductAttribute value);
        partial void OnProductAttributeChanged();
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
