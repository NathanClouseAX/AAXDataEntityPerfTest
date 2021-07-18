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
        /// There are no comments for RetailCatalogTranslationSingle in the schema.
        /// </summary>
    public partial class RetailCatalogTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailCatalogTranslation>
    {
        /// <summary>
        /// Initialize a new RetailCatalogTranslationSingle object.
        /// </summary>
        public RetailCatalogTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailCatalogTranslationSingle object.
        /// </summary>
        public RetailCatalogTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailCatalogTranslationSingle object.
        /// </summary>
        public RetailCatalogTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailCatalogTranslation> query)
            : base(query) {}

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
        /// There are no comments for RetailCatalogTranslation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// CatalogNumber
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CatalogNumber", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("RetailCatalogTranslations")]
    public partial class RetailCatalogTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailCatalogTranslation object.
        /// </summary>
        /// <param name="catalogNumber">Initial value of CatalogNumber.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        /// <param name="retailCatalog">Initial value of RetailCatalog.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailCatalogTranslation CreateRetailCatalogTranslation(string catalogNumber, string languageId, global::Microsoft.Dynamics.DataEntities.RetailCatalog retailCatalog)
        {
            RetailCatalogTranslation retailCatalogTranslation = new RetailCatalogTranslation();
            retailCatalogTranslation.CatalogNumber = catalogNumber;
            retailCatalogTranslation.LanguageId = languageId;
            if ((retailCatalog == null))
            {
                throw new global::System.ArgumentNullException("retailCatalog");
            }
            retailCatalogTranslation.RetailCatalog = retailCatalog;
            return retailCatalogTranslation;
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
        /// There are no comments for Property FriendlyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FriendlyName
        {
            get
            {
                return this._FriendlyName;
            }
            set
            {
                this.OnFriendlyNameChanging(value);
                this._FriendlyName = value;
                this.OnFriendlyNameChanged();
                this.OnPropertyChanged("FriendlyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FriendlyName;
        partial void OnFriendlyNameChanging(string value);
        partial void OnFriendlyNameChanged();
        /// <summary>
        /// There are no comments for Property Image in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Image
        {
            get
            {
                return this._Image;
            }
            set
            {
                this.OnImageChanging(value);
                this._Image = value;
                this.OnImageChanged();
                this.OnPropertyChanged("Image");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Image;
        partial void OnImageChanging(string value);
        partial void OnImageChanged();
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
