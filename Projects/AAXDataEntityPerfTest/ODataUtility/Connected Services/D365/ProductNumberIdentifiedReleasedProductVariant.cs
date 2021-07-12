﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 6/6/2021 9:11:38 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for ProductNumberIdentifiedReleasedProductVariantSingle in the schema.
        /// </summary>
    public partial class ProductNumberIdentifiedReleasedProductVariantSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductNumberIdentifiedReleasedProductVariant>
    {
        /// <summary>
        /// Initialize a new ProductNumberIdentifiedReleasedProductVariantSingle object.
        /// </summary>
        public ProductNumberIdentifiedReleasedProductVariantSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductNumberIdentifiedReleasedProductVariantSingle object.
        /// </summary>
        public ProductNumberIdentifiedReleasedProductVariantSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductNumberIdentifiedReleasedProductVariantSingle object.
        /// </summary>
        public ProductNumberIdentifiedReleasedProductVariantSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductNumberIdentifiedReleasedProductVariant> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductMaster in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2Single ReleasedProductMaster
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductMaster == null))
                {
                    this._ReleasedProductMaster = new global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2Single(this.Context, GetPath("ReleasedProductMaster"));
                }
                return this._ReleasedProductMaster;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2Single _ReleasedProductMaster;
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
        /// There are no comments for ProductVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedProductVariantSingle ProductVariant
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductVariant == null))
                {
                    this._ProductVariant = new global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedProductVariantSingle(this.Context, GetPath("ProductVariant"));
                }
                return this._ProductVariant;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedProductVariantSingle _ProductVariant;
        /// <summary>
        /// There are no comments for ProductNumberIdentifiedReleasedProductVariantExternalCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedReleasedProductVariantExternalCode> ProductNumberIdentifiedReleasedProductVariantExternalCodes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductNumberIdentifiedReleasedProductVariantExternalCodes == null))
                {
                    this._ProductNumberIdentifiedReleasedProductVariantExternalCodes = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedReleasedProductVariantExternalCode>(GetPath("ProductNumberIdentifiedReleasedProductVariantExternalCodes"));
                }
                return this._ProductNumberIdentifiedReleasedProductVariantExternalCodes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedReleasedProductVariantExternalCode> _ProductNumberIdentifiedReleasedProductVariantExternalCodes;
    }
        /// <summary>
        /// There are no comments for ProductNumberIdentifiedReleasedProductVariant in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ProductVariantNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProductVariantNumber")]
    [global::Microsoft.OData.Client.EntitySet("ProductNumberIdentifiedReleasedProductVariants")]
    public partial class ProductNumberIdentifiedReleasedProductVariant : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductNumberIdentifiedReleasedProductVariant object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="productVariantNumber">Initial value of ProductVariantNumber.</param>
        /// <param name="releasedProductMaster">Initial value of ReleasedProductMaster.</param>
        /// <param name="productMaster">Initial value of ProductMaster.</param>
        /// <param name="productVariant">Initial value of ProductVariant.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductNumberIdentifiedReleasedProductVariant CreateProductNumberIdentifiedReleasedProductVariant(string dataAreaId, string productVariantNumber, global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 releasedProductMaster, global::Microsoft.Dynamics.DataEntities.ProductMaster productMaster, global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedProductVariant productVariant)
        {
            ProductNumberIdentifiedReleasedProductVariant productNumberIdentifiedReleasedProductVariant = new ProductNumberIdentifiedReleasedProductVariant();
            productNumberIdentifiedReleasedProductVariant.dataAreaId = dataAreaId;
            productNumberIdentifiedReleasedProductVariant.ProductVariantNumber = productVariantNumber;
            if ((releasedProductMaster == null))
            {
                throw new global::System.ArgumentNullException("releasedProductMaster");
            }
            productNumberIdentifiedReleasedProductVariant.ReleasedProductMaster = releasedProductMaster;
            if ((productMaster == null))
            {
                throw new global::System.ArgumentNullException("productMaster");
            }
            productNumberIdentifiedReleasedProductVariant.ProductMaster = productMaster;
            if ((productVariant == null))
            {
                throw new global::System.ArgumentNullException("productVariant");
            }
            productNumberIdentifiedReleasedProductVariant.ProductVariant = productVariant;
            return productNumberIdentifiedReleasedProductVariant;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property ProductVariantNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductVariantNumber
        {
            get
            {
                return this._ProductVariantNumber;
            }
            set
            {
                this.OnProductVariantNumberChanging(value);
                this._ProductVariantNumber = value;
                this.OnProductVariantNumberChanged();
                this.OnPropertyChanged("ProductVariantNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductVariantNumber;
        partial void OnProductVariantNumberChanging(string value);
        partial void OnProductVariantNumberChanged();
        /// <summary>
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemNumber
        {
            get
            {
                return this._ItemNumber;
            }
            set
            {
                this.OnItemNumberChanging(value);
                this._ItemNumber = value;
                this.OnItemNumberChanged();
                this.OnPropertyChanged("ItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumber;
        partial void OnItemNumberChanging(string value);
        partial void OnItemNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductVersionId
        {
            get
            {
                return this._ProductVersionId;
            }
            set
            {
                this.OnProductVersionIdChanging(value);
                this._ProductVersionId = value;
                this.OnProductVersionIdChanged();
                this.OnPropertyChanged("ProductVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductVersionId;
        partial void OnProductVersionIdChanging(string value);
        partial void OnProductVersionIdChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductStyleId
        {
            get
            {
                return this._ProductStyleId;
            }
            set
            {
                this.OnProductStyleIdChanging(value);
                this._ProductStyleId = value;
                this.OnProductStyleIdChanged();
                this.OnPropertyChanged("ProductStyleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductStyleId;
        partial void OnProductStyleIdChanging(string value);
        partial void OnProductStyleIdChanged();
        /// <summary>
        /// There are no comments for Property ProductConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductConfigurationId
        {
            get
            {
                return this._ProductConfigurationId;
            }
            set
            {
                this.OnProductConfigurationIdChanging(value);
                this._ProductConfigurationId = value;
                this.OnProductConfigurationIdChanged();
                this.OnPropertyChanged("ProductConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductConfigurationId;
        partial void OnProductConfigurationIdChanging(string value);
        partial void OnProductConfigurationIdChanged();
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
        /// There are no comments for Property ProductColorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductColorId
        {
            get
            {
                return this._ProductColorId;
            }
            set
            {
                this.OnProductColorIdChanging(value);
                this._ProductColorId = value;
                this.OnProductColorIdChanged();
                this.OnPropertyChanged("ProductColorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductColorId;
        partial void OnProductColorIdChanging(string value);
        partial void OnProductColorIdChanged();
        /// <summary>
        /// There are no comments for Property ProductSearchName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductSearchName
        {
            get
            {
                return this._ProductSearchName;
            }
            set
            {
                this.OnProductSearchNameChanging(value);
                this._ProductSearchName = value;
                this.OnProductSearchNameChanged();
                this.OnPropertyChanged("ProductSearchName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductSearchName;
        partial void OnProductSearchNameChanging(string value);
        partial void OnProductSearchNameChanged();
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
        /// There are no comments for Property ReleasedProductMaster in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 ReleasedProductMaster
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
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 _ReleasedProductMaster;
        partial void OnReleasedProductMasterChanging(global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 value);
        partial void OnReleasedProductMasterChanged();
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
        /// There are no comments for Property ProductVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedProductVariant ProductVariant
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
        private global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedProductVariant _ProductVariant;
        partial void OnProductVariantChanging(global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedProductVariant value);
        partial void OnProductVariantChanged();
        /// <summary>
        /// There are no comments for Property ProductNumberIdentifiedReleasedProductVariantExternalCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedReleasedProductVariantExternalCode> ProductNumberIdentifiedReleasedProductVariantExternalCodes
        {
            get
            {
                return this._ProductNumberIdentifiedReleasedProductVariantExternalCodes;
            }
            set
            {
                this.OnProductNumberIdentifiedReleasedProductVariantExternalCodesChanging(value);
                this._ProductNumberIdentifiedReleasedProductVariantExternalCodes = value;
                this.OnProductNumberIdentifiedReleasedProductVariantExternalCodesChanged();
                this.OnPropertyChanged("ProductNumberIdentifiedReleasedProductVariantExternalCodes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedReleasedProductVariantExternalCode> _ProductNumberIdentifiedReleasedProductVariantExternalCodes = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedReleasedProductVariantExternalCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductNumberIdentifiedReleasedProductVariantExternalCodesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedReleasedProductVariantExternalCode> value);
        partial void OnProductNumberIdentifiedReleasedProductVariantExternalCodesChanged();
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
