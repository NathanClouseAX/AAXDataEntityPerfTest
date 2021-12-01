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
    /// There are no comments for ProductMasterConfigurationTranslationSingle in the schema.
    /// </summary>
    public partial class ProductMasterConfigurationTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductMasterConfigurationTranslation>
    {
        /// <summary>
        /// Initialize a new ProductMasterConfigurationTranslationSingle object.
        /// </summary>
        public ProductMasterConfigurationTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductMasterConfigurationTranslationSingle object.
        /// </summary>
        public ProductMasterConfigurationTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductMasterConfigurationTranslationSingle object.
        /// </summary>
        public ProductMasterConfigurationTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductMasterConfigurationTranslation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductMasterConfiguration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductMasterConfigurationSingle ProductMasterConfiguration
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductMasterConfiguration == null))
                {
                    this._ProductMasterConfiguration = new global::Microsoft.Dynamics.DataEntities.ProductMasterConfigurationSingle(this.Context, GetPath("ProductMasterConfiguration"));
                }
                return this._ProductMasterConfiguration;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductMasterConfigurationSingle _ProductMasterConfiguration;
    }
    /// <summary>
    /// There are no comments for ProductMasterConfigurationTranslation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductMasterNumber
    /// ProductMasterConfigurationId
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductMasterNumber", "ProductMasterConfigurationId", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("ProductMasterConfigurationTranslations")]
    public partial class ProductMasterConfigurationTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductMasterConfigurationTranslation object.
        /// </summary>
        /// <param name="productMasterNumber">Initial value of ProductMasterNumber.</param>
        /// <param name="productMasterConfigurationId">Initial value of ProductMasterConfigurationId.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        /// <param name="productMasterConfiguration">Initial value of ProductMasterConfiguration.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductMasterConfigurationTranslation CreateProductMasterConfigurationTranslation(string productMasterNumber, string productMasterConfigurationId, string languageId, global::Microsoft.Dynamics.DataEntities.ProductMasterConfiguration productMasterConfiguration)
        {
            ProductMasterConfigurationTranslation productMasterConfigurationTranslation = new ProductMasterConfigurationTranslation();
            productMasterConfigurationTranslation.ProductMasterNumber = productMasterNumber;
            productMasterConfigurationTranslation.ProductMasterConfigurationId = productMasterConfigurationId;
            productMasterConfigurationTranslation.LanguageId = languageId;
            if ((productMasterConfiguration == null))
            {
                throw new global::System.ArgumentNullException("productMasterConfiguration");
            }
            productMasterConfigurationTranslation.ProductMasterConfiguration = productMasterConfiguration;
            return productMasterConfigurationTranslation;
        }
        /// <summary>
        /// There are no comments for Property ProductMasterNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductMasterNumber is required.")]
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
        /// There are no comments for Property ProductMasterConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductMasterConfigurationId is required.")]
        public virtual string ProductMasterConfigurationId
        {
            get
            {
                return this._ProductMasterConfigurationId;
            }
            set
            {
                this.OnProductMasterConfigurationIdChanging(value);
                this._ProductMasterConfigurationId = value;
                this.OnProductMasterConfigurationIdChanged();
                this.OnPropertyChanged("ProductMasterConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductMasterConfigurationId;
        partial void OnProductMasterConfigurationIdChanging(string value);
        partial void OnProductMasterConfigurationIdChanged();
        /// <summary>
        /// There are no comments for Property LanguageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LanguageId is required.")]
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
        /// There are no comments for Property TranslatedConfigurationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TranslatedConfigurationName
        {
            get
            {
                return this._TranslatedConfigurationName;
            }
            set
            {
                this.OnTranslatedConfigurationNameChanging(value);
                this._TranslatedConfigurationName = value;
                this.OnTranslatedConfigurationNameChanged();
                this.OnPropertyChanged("TranslatedConfigurationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedConfigurationName;
        partial void OnTranslatedConfigurationNameChanging(string value);
        partial void OnTranslatedConfigurationNameChanged();
        /// <summary>
        /// There are no comments for Property TranslatedConfigurationDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TranslatedConfigurationDescription
        {
            get
            {
                return this._TranslatedConfigurationDescription;
            }
            set
            {
                this.OnTranslatedConfigurationDescriptionChanging(value);
                this._TranslatedConfigurationDescription = value;
                this.OnTranslatedConfigurationDescriptionChanged();
                this.OnPropertyChanged("TranslatedConfigurationDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedConfigurationDescription;
        partial void OnTranslatedConfigurationDescriptionChanging(string value);
        partial void OnTranslatedConfigurationDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ProductMasterConfiguration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductMasterConfiguration is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductMasterConfiguration ProductMasterConfiguration
        {
            get
            {
                return this._ProductMasterConfiguration;
            }
            set
            {
                this.OnProductMasterConfigurationChanging(value);
                this._ProductMasterConfiguration = value;
                this.OnProductMasterConfigurationChanged();
                this.OnPropertyChanged("ProductMasterConfiguration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductMasterConfiguration _ProductMasterConfiguration;
        partial void OnProductMasterConfigurationChanging(global::Microsoft.Dynamics.DataEntities.ProductMasterConfiguration value);
        partial void OnProductMasterConfigurationChanged();
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
