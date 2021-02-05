﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for ProductSizeGroupLineTranslationSingle in the schema.
        /// </summary>
    public partial class ProductSizeGroupLineTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductSizeGroupLineTranslation>
    {
        /// <summary>
        /// Initialize a new ProductSizeGroupLineTranslationSingle object.
        /// </summary>
        public ProductSizeGroupLineTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductSizeGroupLineTranslationSingle object.
        /// </summary>
        public ProductSizeGroupLineTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductSizeGroupLineTranslationSingle object.
        /// </summary>
        public ProductSizeGroupLineTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductSizeGroupLineTranslation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductSizeGroupLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductSizeGroupLineSingle ProductSizeGroupLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductSizeGroupLine == null))
                {
                    this._ProductSizeGroupLine = new global::Microsoft.Dynamics.DataEntities.ProductSizeGroupLineSingle(this.Context, GetPath("ProductSizeGroupLine"));
                }
                return this._ProductSizeGroupLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductSizeGroupLineSingle _ProductSizeGroupLine;
    }
        /// <summary>
        /// There are no comments for ProductSizeGroupLineTranslation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ProductSizeGroupId
    /// ProductSizeId
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductSizeGroupId", "ProductSizeId", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("ProductSizeGroupLineTranslations")]
    public partial class ProductSizeGroupLineTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductSizeGroupLineTranslation object.
        /// </summary>
        /// <param name="productSizeGroupId">Initial value of ProductSizeGroupId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        /// <param name="productSizeGroupLine">Initial value of ProductSizeGroupLine.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductSizeGroupLineTranslation CreateProductSizeGroupLineTranslation(string productSizeGroupId, string productSizeId, string languageId, global::Microsoft.Dynamics.DataEntities.ProductSizeGroupLine productSizeGroupLine)
        {
            ProductSizeGroupLineTranslation productSizeGroupLineTranslation = new ProductSizeGroupLineTranslation();
            productSizeGroupLineTranslation.ProductSizeGroupId = productSizeGroupId;
            productSizeGroupLineTranslation.ProductSizeId = productSizeId;
            productSizeGroupLineTranslation.LanguageId = languageId;
            if ((productSizeGroupLine == null))
            {
                throw new global::System.ArgumentNullException("productSizeGroupLine");
            }
            productSizeGroupLineTranslation.ProductSizeGroupLine = productSizeGroupLine;
            return productSizeGroupLineTranslation;
        }
        /// <summary>
        /// There are no comments for Property ProductSizeGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductSizeGroupId
        {
            get
            {
                return this._ProductSizeGroupId;
            }
            set
            {
                this.OnProductSizeGroupIdChanging(value);
                this._ProductSizeGroupId = value;
                this.OnProductSizeGroupIdChanged();
                this.OnPropertyChanged("ProductSizeGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductSizeGroupId;
        partial void OnProductSizeGroupIdChanging(string value);
        partial void OnProductSizeGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ProductSizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductSizeId
        {
            get
            {
                return this._ProductSizeId;
            }
            set
            {
                this.OnProductSizeIdChanging(value);
                this._ProductSizeId = value;
                this.OnProductSizeIdChanged();
                this.OnPropertyChanged("ProductSizeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductSizeId;
        partial void OnProductSizeIdChanging(string value);
        partial void OnProductSizeIdChanged();
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
        /// There are no comments for Property TranslatedSizeDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TranslatedSizeDescription
        {
            get
            {
                return this._TranslatedSizeDescription;
            }
            set
            {
                this.OnTranslatedSizeDescriptionChanging(value);
                this._TranslatedSizeDescription = value;
                this.OnTranslatedSizeDescriptionChanged();
                this.OnPropertyChanged("TranslatedSizeDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedSizeDescription;
        partial void OnTranslatedSizeDescriptionChanging(string value);
        partial void OnTranslatedSizeDescriptionChanged();
        /// <summary>
        /// There are no comments for Property TranslatedSizeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TranslatedSizeName
        {
            get
            {
                return this._TranslatedSizeName;
            }
            set
            {
                this.OnTranslatedSizeNameChanging(value);
                this._TranslatedSizeName = value;
                this.OnTranslatedSizeNameChanged();
                this.OnPropertyChanged("TranslatedSizeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedSizeName;
        partial void OnTranslatedSizeNameChanging(string value);
        partial void OnTranslatedSizeNameChanged();
        /// <summary>
        /// There are no comments for Property ProductSizeGroupLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductSizeGroupLine ProductSizeGroupLine
        {
            get
            {
                return this._ProductSizeGroupLine;
            }
            set
            {
                this.OnProductSizeGroupLineChanging(value);
                this._ProductSizeGroupLine = value;
                this.OnProductSizeGroupLineChanged();
                this.OnPropertyChanged("ProductSizeGroupLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductSizeGroupLine _ProductSizeGroupLine;
        partial void OnProductSizeGroupLineChanging(global::Microsoft.Dynamics.DataEntities.ProductSizeGroupLine value);
        partial void OnProductSizeGroupLineChanged();
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
