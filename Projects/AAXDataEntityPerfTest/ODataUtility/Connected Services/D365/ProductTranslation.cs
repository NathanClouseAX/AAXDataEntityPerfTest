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
        /// There are no comments for ProductTranslationSingle in the schema.
        /// </summary>
    public partial class ProductTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductTranslation>
    {
        /// <summary>
        /// Initialize a new ProductTranslationSingle object.
        /// </summary>
        public ProductTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductTranslationSingle object.
        /// </summary>
        public ProductTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductTranslationSingle object.
        /// </summary>
        public ProductTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductTranslation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductMaster in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterSingle ReleasedProductMaster
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductMaster == null))
                {
                    this._ReleasedProductMaster = new global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterSingle(this.Context, GetPath("ReleasedProductMaster"));
                }
                return this._ReleasedProductMaster;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterSingle _ReleasedProductMaster;
        /// <summary>
        /// There are no comments for ReleasedProductMasterV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2Single ReleasedProductMasterV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductMasterV2 == null))
                {
                    this._ReleasedProductMasterV2 = new global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2Single(this.Context, GetPath("ReleasedProductMasterV2"));
                }
                return this._ReleasedProductMasterV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2Single _ReleasedProductMasterV2;
        /// <summary>
        /// There are no comments for ReleasedDistinctProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedDistinctProductSingle ReleasedDistinctProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedDistinctProduct == null))
                {
                    this._ReleasedDistinctProduct = new global::Microsoft.Dynamics.DataEntities.ReleasedDistinctProductSingle(this.Context, GetPath("ReleasedDistinctProduct"));
                }
                return this._ReleasedDistinctProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedDistinctProductSingle _ReleasedDistinctProduct;
        /// <summary>
        /// There are no comments for ProductMaster in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductMasterSingle ProductMaster
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductMaster == null))
                {
                    this._ProductMaster = new global::Microsoft.Dynamics.DataEntities.ProductMasterSingle(this.Context, GetPath("ProductMaster"));
                }
                return this._ProductMaster;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductMasterSingle _ProductMaster;
        /// <summary>
        /// There are no comments for ReleasedProductVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantSingle ReleasedProductVariant
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductVariant == null))
                {
                    this._ReleasedProductVariant = new global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantSingle(this.Context, GetPath("ReleasedProductVariant"));
                }
                return this._ReleasedProductVariant;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantSingle _ReleasedProductVariant;
        /// <summary>
        /// There are no comments for ReleasedDistinctProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedDistinctProductV2Single ReleasedDistinctProductV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedDistinctProductV2 == null))
                {
                    this._ReleasedDistinctProductV2 = new global::Microsoft.Dynamics.DataEntities.ReleasedDistinctProductV2Single(this.Context, GetPath("ReleasedDistinctProductV2"));
                }
                return this._ReleasedDistinctProductV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedDistinctProductV2Single _ReleasedDistinctProductV2;
        /// <summary>
        /// There are no comments for DistinctProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DistinctProductSingle DistinctProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DistinctProduct == null))
                {
                    this._DistinctProduct = new global::Microsoft.Dynamics.DataEntities.DistinctProductSingle(this.Context, GetPath("DistinctProduct"));
                }
                return this._DistinctProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DistinctProductSingle _DistinctProduct;
        /// <summary>
        /// There are no comments for ProductVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVariantSingle ProductVariant
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductVariant == null))
                {
                    this._ProductVariant = new global::Microsoft.Dynamics.DataEntities.ProductVariantSingle(this.Context, GetPath("ProductVariant"));
                }
                return this._ProductVariant;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVariantSingle _ProductVariant;
    }
        /// <summary>
        /// There are no comments for ProductTranslation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ProductNumber
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductNumber", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("ProductTranslations")]
    public partial class ProductTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductTranslation object.
        /// </summary>
        /// <param name="productNumber">Initial value of ProductNumber.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductTranslation CreateProductTranslation(string productNumber, string languageId)
        {
            ProductTranslation productTranslation = new ProductTranslation();
            productTranslation.ProductNumber = productNumber;
            productTranslation.LanguageId = languageId;
            return productTranslation;
        }
        /// <summary>
        /// There are no comments for Property ProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductNumber
        {
            get
            {
                return this._ProductNumber;
            }
            set
            {
                this.OnProductNumberChanging(value);
                this._ProductNumber = value;
                this.OnProductNumberChanged();
                this.OnPropertyChanged("ProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductNumber;
        partial void OnProductNumberChanging(string value);
        partial void OnProductNumberChanged();
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
        /// There are no comments for Property ProductName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this.OnProductNameChanging(value);
                this._ProductName = value;
                this.OnProductNameChanged();
                this.OnPropertyChanged("ProductName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductName;
        partial void OnProductNameChanging(string value);
        partial void OnProductNameChanged();
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
        /// There are no comments for Property ReleasedProductMaster in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductMaster ReleasedProductMaster
        {
            get
            {
                return this._ReleasedProductMaster;
            }
            set
            {
                this.OnReleasedProductMasterChanging(value);
                this._ReleasedProductMaster = value;
                this.OnReleasedProductMasterChanged();
                this.OnPropertyChanged("ReleasedProductMaster");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductMaster _ReleasedProductMaster;
        partial void OnReleasedProductMasterChanging(global::Microsoft.Dynamics.DataEntities.ReleasedProductMaster value);
        partial void OnReleasedProductMasterChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductMasterV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 ReleasedProductMasterV2
        {
            get
            {
                return this._ReleasedProductMasterV2;
            }
            set
            {
                this.OnReleasedProductMasterV2Changing(value);
                this._ReleasedProductMasterV2 = value;
                this.OnReleasedProductMasterV2Changed();
                this.OnPropertyChanged("ReleasedProductMasterV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 _ReleasedProductMasterV2;
        partial void OnReleasedProductMasterV2Changing(global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 value);
        partial void OnReleasedProductMasterV2Changed();
        /// <summary>
        /// There are no comments for Property ReleasedDistinctProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedDistinctProduct ReleasedDistinctProduct
        {
            get
            {
                return this._ReleasedDistinctProduct;
            }
            set
            {
                this.OnReleasedDistinctProductChanging(value);
                this._ReleasedDistinctProduct = value;
                this.OnReleasedDistinctProductChanged();
                this.OnPropertyChanged("ReleasedDistinctProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedDistinctProduct _ReleasedDistinctProduct;
        partial void OnReleasedDistinctProductChanging(global::Microsoft.Dynamics.DataEntities.ReleasedDistinctProduct value);
        partial void OnReleasedDistinctProductChanged();
        /// <summary>
        /// There are no comments for Property ProductMaster in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductMaster ProductMaster
        {
            get
            {
                return this._ProductMaster;
            }
            set
            {
                this.OnProductMasterChanging(value);
                this._ProductMaster = value;
                this.OnProductMasterChanged();
                this.OnPropertyChanged("ProductMaster");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductMaster _ProductMaster;
        partial void OnProductMasterChanging(global::Microsoft.Dynamics.DataEntities.ProductMaster value);
        partial void OnProductMasterChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductVariant ReleasedProductVariant
        {
            get
            {
                return this._ReleasedProductVariant;
            }
            set
            {
                this.OnReleasedProductVariantChanging(value);
                this._ReleasedProductVariant = value;
                this.OnReleasedProductVariantChanged();
                this.OnPropertyChanged("ReleasedProductVariant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductVariant _ReleasedProductVariant;
        partial void OnReleasedProductVariantChanging(global::Microsoft.Dynamics.DataEntities.ReleasedProductVariant value);
        partial void OnReleasedProductVariantChanged();
        /// <summary>
        /// There are no comments for Property ReleasedDistinctProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedDistinctProductV2 ReleasedDistinctProductV2
        {
            get
            {
                return this._ReleasedDistinctProductV2;
            }
            set
            {
                this.OnReleasedDistinctProductV2Changing(value);
                this._ReleasedDistinctProductV2 = value;
                this.OnReleasedDistinctProductV2Changed();
                this.OnPropertyChanged("ReleasedDistinctProductV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedDistinctProductV2 _ReleasedDistinctProductV2;
        partial void OnReleasedDistinctProductV2Changing(global::Microsoft.Dynamics.DataEntities.ReleasedDistinctProductV2 value);
        partial void OnReleasedDistinctProductV2Changed();
        /// <summary>
        /// There are no comments for Property DistinctProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DistinctProduct DistinctProduct
        {
            get
            {
                return this._DistinctProduct;
            }
            set
            {
                this.OnDistinctProductChanging(value);
                this._DistinctProduct = value;
                this.OnDistinctProductChanged();
                this.OnPropertyChanged("DistinctProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DistinctProduct _DistinctProduct;
        partial void OnDistinctProductChanging(global::Microsoft.Dynamics.DataEntities.DistinctProduct value);
        partial void OnDistinctProductChanged();
        /// <summary>
        /// There are no comments for Property ProductVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVariant ProductVariant
        {
            get
            {
                return this._ProductVariant;
            }
            set
            {
                this.OnProductVariantChanging(value);
                this._ProductVariant = value;
                this.OnProductVariantChanged();
                this.OnPropertyChanged("ProductVariant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVariant _ProductVariant;
        partial void OnProductVariantChanging(global::Microsoft.Dynamics.DataEntities.ProductVariant value);
        partial void OnProductVariantChanged();
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
