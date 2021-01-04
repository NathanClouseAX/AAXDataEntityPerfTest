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
        /// There are no comments for ProductMasterColorTranslationSingle in the schema.
        /// </summary>
    public partial class ProductMasterColorTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductMasterColorTranslation>
    {
        /// <summary>
        /// Initialize a new ProductMasterColorTranslationSingle object.
        /// </summary>
        public ProductMasterColorTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductMasterColorTranslationSingle object.
        /// </summary>
        public ProductMasterColorTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductMasterColorTranslationSingle object.
        /// </summary>
        public ProductMasterColorTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductMasterColorTranslation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductMasterColor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductMasterColorSingle ProductMasterColor
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductMasterColor == null))
                {
                    this._ProductMasterColor = new global::Microsoft.Dynamics.DataEntities.ProductMasterColorSingle(this.Context, GetPath("ProductMasterColor"));
                }
                return this._ProductMasterColor;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductMasterColorSingle _ProductMasterColor;
    }
        /// <summary>
        /// There are no comments for ProductMasterColorTranslation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ProductMasterNumber
    /// ProductMasterColorId
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductMasterNumber", "ProductMasterColorId", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("ProductMasterColorTranslations")]
    public partial class ProductMasterColorTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductMasterColorTranslation object.
        /// </summary>
        /// <param name="productMasterNumber">Initial value of ProductMasterNumber.</param>
        /// <param name="productMasterColorId">Initial value of ProductMasterColorId.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        /// <param name="productMasterColor">Initial value of ProductMasterColor.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductMasterColorTranslation CreateProductMasterColorTranslation(string productMasterNumber, string productMasterColorId, string languageId, global::Microsoft.Dynamics.DataEntities.ProductMasterColor productMasterColor)
        {
            ProductMasterColorTranslation productMasterColorTranslation = new ProductMasterColorTranslation();
            productMasterColorTranslation.ProductMasterNumber = productMasterNumber;
            productMasterColorTranslation.ProductMasterColorId = productMasterColorId;
            productMasterColorTranslation.LanguageId = languageId;
            if ((productMasterColor == null))
            {
                throw new global::System.ArgumentNullException("productMasterColor");
            }
            productMasterColorTranslation.ProductMasterColor = productMasterColor;
            return productMasterColorTranslation;
        }
        /// <summary>
        /// There are no comments for Property ProductMasterNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductMasterNumber
        {
            get
            {
                return this._ProductMasterNumber;
            }
            set
            {
                this.OnProductMasterNumberChanging(value);
                this._ProductMasterNumber = value;
                this.OnProductMasterNumberChanged();
                this.OnPropertyChanged("ProductMasterNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductMasterNumber;
        partial void OnProductMasterNumberChanging(string value);
        partial void OnProductMasterNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductMasterColorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductMasterColorId
        {
            get
            {
                return this._ProductMasterColorId;
            }
            set
            {
                this.OnProductMasterColorIdChanging(value);
                this._ProductMasterColorId = value;
                this.OnProductMasterColorIdChanged();
                this.OnPropertyChanged("ProductMasterColorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductMasterColorId;
        partial void OnProductMasterColorIdChanging(string value);
        partial void OnProductMasterColorIdChanged();
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
        /// There are no comments for Property TranslatedColorDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TranslatedColorDescription
        {
            get
            {
                return this._TranslatedColorDescription;
            }
            set
            {
                this.OnTranslatedColorDescriptionChanging(value);
                this._TranslatedColorDescription = value;
                this.OnTranslatedColorDescriptionChanged();
                this.OnPropertyChanged("TranslatedColorDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedColorDescription;
        partial void OnTranslatedColorDescriptionChanging(string value);
        partial void OnTranslatedColorDescriptionChanged();
        /// <summary>
        /// There are no comments for Property TranslatedColorName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TranslatedColorName
        {
            get
            {
                return this._TranslatedColorName;
            }
            set
            {
                this.OnTranslatedColorNameChanging(value);
                this._TranslatedColorName = value;
                this.OnTranslatedColorNameChanged();
                this.OnPropertyChanged("TranslatedColorName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedColorName;
        partial void OnTranslatedColorNameChanging(string value);
        partial void OnTranslatedColorNameChanged();
        /// <summary>
        /// There are no comments for Property ProductMasterColor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductMasterColor ProductMasterColor
        {
            get
            {
                return this._ProductMasterColor;
            }
            set
            {
                this.OnProductMasterColorChanging(value);
                this._ProductMasterColor = value;
                this.OnProductMasterColorChanged();
                this.OnPropertyChanged("ProductMasterColor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductMasterColor _ProductMasterColor;
        partial void OnProductMasterColorChanging(global::Microsoft.Dynamics.DataEntities.ProductMasterColor value);
        partial void OnProductMasterColorChanged();
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
