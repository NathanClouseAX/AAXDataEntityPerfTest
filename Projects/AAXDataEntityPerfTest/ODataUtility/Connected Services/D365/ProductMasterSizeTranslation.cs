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
        /// There are no comments for ProductMasterSizeTranslationSingle in the schema.
        /// </summary>
    public partial class ProductMasterSizeTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductMasterSizeTranslation>
    {
        /// <summary>
        /// Initialize a new ProductMasterSizeTranslationSingle object.
        /// </summary>
        public ProductMasterSizeTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductMasterSizeTranslationSingle object.
        /// </summary>
        public ProductMasterSizeTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductMasterSizeTranslationSingle object.
        /// </summary>
        public ProductMasterSizeTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductMasterSizeTranslation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductMasterSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductMasterSizeSingle ProductMasterSize
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductMasterSize == null))
                {
                    this._ProductMasterSize = new global::Microsoft.Dynamics.DataEntities.ProductMasterSizeSingle(this.Context, GetPath("ProductMasterSize"));
                }
                return this._ProductMasterSize;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductMasterSizeSingle _ProductMasterSize;
    }
        /// <summary>
        /// There are no comments for ProductMasterSizeTranslation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ProductMasterNumber
    /// ProductMasterSizeId
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductMasterNumber", "ProductMasterSizeId", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("ProductMasterSizeTranslations")]
    public partial class ProductMasterSizeTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductMasterSizeTranslation object.
        /// </summary>
        /// <param name="productMasterNumber">Initial value of ProductMasterNumber.</param>
        /// <param name="productMasterSizeId">Initial value of ProductMasterSizeId.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        /// <param name="productMasterSize">Initial value of ProductMasterSize.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductMasterSizeTranslation CreateProductMasterSizeTranslation(string productMasterNumber, string productMasterSizeId, string languageId, global::Microsoft.Dynamics.DataEntities.ProductMasterSize productMasterSize)
        {
            ProductMasterSizeTranslation productMasterSizeTranslation = new ProductMasterSizeTranslation();
            productMasterSizeTranslation.ProductMasterNumber = productMasterNumber;
            productMasterSizeTranslation.ProductMasterSizeId = productMasterSizeId;
            productMasterSizeTranslation.LanguageId = languageId;
            if ((productMasterSize == null))
            {
                throw new global::System.ArgumentNullException("productMasterSize");
            }
            productMasterSizeTranslation.ProductMasterSize = productMasterSize;
            return productMasterSizeTranslation;
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
        /// There are no comments for Property ProductMasterSizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductMasterSizeId
        {
            get
            {
                return this._ProductMasterSizeId;
            }
            set
            {
                this.OnProductMasterSizeIdChanging(value);
                this._ProductMasterSizeId = value;
                this.OnProductMasterSizeIdChanged();
                this.OnPropertyChanged("ProductMasterSizeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductMasterSizeId;
        partial void OnProductMasterSizeIdChanging(string value);
        partial void OnProductMasterSizeIdChanged();
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
        /// There are no comments for Property ProductMasterSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductMasterSize ProductMasterSize
        {
            get
            {
                return this._ProductMasterSize;
            }
            set
            {
                this.OnProductMasterSizeChanging(value);
                this._ProductMasterSize = value;
                this.OnProductMasterSizeChanged();
                this.OnPropertyChanged("ProductMasterSize");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductMasterSize _ProductMasterSize;
        partial void OnProductMasterSizeChanging(global::Microsoft.Dynamics.DataEntities.ProductMasterSize value);
        partial void OnProductMasterSizeChanged();
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
