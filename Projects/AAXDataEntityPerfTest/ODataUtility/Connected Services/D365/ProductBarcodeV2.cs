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
        /// There are no comments for ProductBarcodeV2Single in the schema.
        /// </summary>
    public partial class ProductBarcodeV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductBarcodeV2>
    {
        /// <summary>
        /// Initialize a new ProductBarcodeV2Single object.
        /// </summary>
        public ProductBarcodeV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductBarcodeV2Single object.
        /// </summary>
        public ProductBarcodeV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductBarcodeV2Single object.
        /// </summary>
        public ProductBarcodeV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductBarcodeV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BarcodeSetup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BarcodeSetupSingle BarcodeSetup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BarcodeSetup == null))
                {
                    this._BarcodeSetup = new global::Microsoft.Dynamics.DataEntities.BarcodeSetupSingle(this.Context, GetPath("BarcodeSetup"));
                }
                return this._BarcodeSetup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BarcodeSetupSingle _BarcodeSetup;
        /// <summary>
        /// There are no comments for ProductVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVersionSingle ProductVersion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductVersion == null))
                {
                    this._ProductVersion = new global::Microsoft.Dynamics.DataEntities.ProductVersionSingle(this.Context, GetPath("ProductVersion"));
                }
                return this._ProductVersion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVersionSingle _ProductVersion;
        /// <summary>
        /// There are no comments for ProductColor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductColorSingle ProductColor
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductColor == null))
                {
                    this._ProductColor = new global::Microsoft.Dynamics.DataEntities.ProductColorSingle(this.Context, GetPath("ProductColor"));
                }
                return this._ProductColor;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductColorSingle _ProductColor;
        /// <summary>
        /// There are no comments for ProductStyle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductStyleSingle ProductStyle
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductStyle == null))
                {
                    this._ProductStyle = new global::Microsoft.Dynamics.DataEntities.ProductStyleSingle(this.Context, GetPath("ProductStyle"));
                }
                return this._ProductStyle;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductStyleSingle _ProductStyle;
        /// <summary>
        /// There are no comments for ReleasedProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single ReleasedProductV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductV2 == null))
                {
                    this._ReleasedProductV2 = new global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single(this.Context, GetPath("ReleasedProductV2"));
                }
                return this._ReleasedProductV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single _ReleasedProductV2;
        /// <summary>
        /// There are no comments for ProductSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductSizeSingle ProductSize
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductSize == null))
                {
                    this._ProductSize = new global::Microsoft.Dynamics.DataEntities.ProductSizeSingle(this.Context, GetPath("ProductSize"));
                }
                return this._ProductSize;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductSizeSingle _ProductSize;
    }
        /// <summary>
        /// There are no comments for ProductBarcodeV2 in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ItemNumber
    /// ProductConfigurationId
    /// ProductColorId
    /// ProductSizeId
    /// ProductStyleId
    /// ProductVersionId
    /// ProductQuantityUnitSymbol
    /// BarcodeSetupId
    /// Barcode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ItemNumber", "ProductConfigurationId", "ProductColorId", "ProductSizeId", "ProductStyleId", "ProductVersionId", "ProductQuantityUnitSymbol", "BarcodeSetupId", "Barcode")]
    [global::Microsoft.OData.Client.EntitySet("ProductBarcodesV2")]
    public partial class ProductBarcodeV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductBarcodeV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="productVersionId">Initial value of ProductVersionId.</param>
        /// <param name="productQuantityUnitSymbol">Initial value of ProductQuantityUnitSymbol.</param>
        /// <param name="barcodeSetupId">Initial value of BarcodeSetupId.</param>
        /// <param name="barcode">Initial value of Barcode.</param>
        /// <param name="productQuantity">Initial value of ProductQuantity.</param>
        /// <param name="releasedProductV2">Initial value of ReleasedProductV2.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductBarcodeV2 CreateProductBarcodeV2(string dataAreaId, 
                    string itemNumber, 
                    string productConfigurationId, 
                    string productColorId, 
                    string productSizeId, 
                    string productStyleId, 
                    string productVersionId, 
                    string productQuantityUnitSymbol, 
                    string barcodeSetupId, 
                    string barcode, 
                    decimal productQuantity, 
                    global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 releasedProductV2)
        {
            ProductBarcodeV2 productBarcodeV2 = new ProductBarcodeV2();
            productBarcodeV2.dataAreaId = dataAreaId;
            productBarcodeV2.ItemNumber = itemNumber;
            productBarcodeV2.ProductConfigurationId = productConfigurationId;
            productBarcodeV2.ProductColorId = productColorId;
            productBarcodeV2.ProductSizeId = productSizeId;
            productBarcodeV2.ProductStyleId = productStyleId;
            productBarcodeV2.ProductVersionId = productVersionId;
            productBarcodeV2.ProductQuantityUnitSymbol = productQuantityUnitSymbol;
            productBarcodeV2.BarcodeSetupId = barcodeSetupId;
            productBarcodeV2.Barcode = barcode;
            productBarcodeV2.ProductQuantity = productQuantity;
            if ((releasedProductV2 == null))
            {
                throw new global::System.ArgumentNullException("releasedProductV2");
            }
            productBarcodeV2.ReleasedProductV2 = releasedProductV2;
            return productBarcodeV2;
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
        /// There are no comments for Property ProductQuantityUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductQuantityUnitSymbol
        {
            get
            {
                return this._ProductQuantityUnitSymbol;
            }
            set
            {
                this.OnProductQuantityUnitSymbolChanging(value);
                this._ProductQuantityUnitSymbol = value;
                this.OnProductQuantityUnitSymbolChanged();
                this.OnPropertyChanged("ProductQuantityUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductQuantityUnitSymbol;
        partial void OnProductQuantityUnitSymbolChanging(string value);
        partial void OnProductQuantityUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property BarcodeSetupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BarcodeSetupId
        {
            get
            {
                return this._BarcodeSetupId;
            }
            set
            {
                this.OnBarcodeSetupIdChanging(value);
                this._BarcodeSetupId = value;
                this.OnBarcodeSetupIdChanged();
                this.OnPropertyChanged("BarcodeSetupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BarcodeSetupId;
        partial void OnBarcodeSetupIdChanging(string value);
        partial void OnBarcodeSetupIdChanged();
        /// <summary>
        /// There are no comments for Property Barcode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Barcode
        {
            get
            {
                return this._Barcode;
            }
            set
            {
                this.OnBarcodeChanging(value);
                this._Barcode = value;
                this.OnBarcodeChanged();
                this.OnPropertyChanged("Barcode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Barcode;
        partial void OnBarcodeChanging(string value);
        partial void OnBarcodeChanged();
        /// <summary>
        /// There are no comments for Property ProductDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductDescription
        {
            get
            {
                return this._ProductDescription;
            }
            set
            {
                this.OnProductDescriptionChanging(value);
                this._ProductDescription = value;
                this.OnProductDescriptionChanged();
                this.OnPropertyChanged("ProductDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductDescription;
        partial void OnProductDescriptionChanging(string value);
        partial void OnProductDescriptionChanged();
        /// <summary>
        /// There are no comments for Property IsDefaultScannedBarcode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefaultScannedBarcode
        {
            get
            {
                return this._IsDefaultScannedBarcode;
            }
            set
            {
                this.OnIsDefaultScannedBarcodeChanging(value);
                this._IsDefaultScannedBarcode = value;
                this.OnIsDefaultScannedBarcodeChanged();
                this.OnPropertyChanged("IsDefaultScannedBarcode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefaultScannedBarcode;
        partial void OnIsDefaultScannedBarcodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultScannedBarcodeChanged();
        /// <summary>
        /// There are no comments for Property IsDefaultDisplayedBarcode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefaultDisplayedBarcode
        {
            get
            {
                return this._IsDefaultDisplayedBarcode;
            }
            set
            {
                this.OnIsDefaultDisplayedBarcodeChanging(value);
                this._IsDefaultDisplayedBarcode = value;
                this.OnIsDefaultDisplayedBarcodeChanged();
                this.OnPropertyChanged("IsDefaultDisplayedBarcode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefaultDisplayedBarcode;
        partial void OnIsDefaultDisplayedBarcodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultDisplayedBarcodeChanged();
        /// <summary>
        /// There are no comments for Property IsDefaultPrintedBarcode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefaultPrintedBarcode
        {
            get
            {
                return this._IsDefaultPrintedBarcode;
            }
            set
            {
                this.OnIsDefaultPrintedBarcodeChanging(value);
                this._IsDefaultPrintedBarcode = value;
                this.OnIsDefaultPrintedBarcodeChanged();
                this.OnPropertyChanged("IsDefaultPrintedBarcode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefaultPrintedBarcode;
        partial void OnIsDefaultPrintedBarcodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultPrintedBarcodeChanged();
        /// <summary>
        /// There are no comments for Property ProductQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ProductQuantity
        {
            get
            {
                return this._ProductQuantity;
            }
            set
            {
                this.OnProductQuantityChanging(value);
                this._ProductQuantity = value;
                this.OnProductQuantityChanged();
                this.OnPropertyChanged("ProductQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ProductQuantity;
        partial void OnProductQuantityChanging(decimal value);
        partial void OnProductQuantityChanged();
        /// <summary>
        /// There are no comments for Property BarcodeSetup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BarcodeSetup BarcodeSetup
        {
            get
            {
                return this._BarcodeSetup;
            }
            set
            {
                this.OnBarcodeSetupChanging(value);
                this._BarcodeSetup = value;
                this.OnBarcodeSetupChanged();
                this.OnPropertyChanged("BarcodeSetup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BarcodeSetup _BarcodeSetup;
        partial void OnBarcodeSetupChanging(global::Microsoft.Dynamics.DataEntities.BarcodeSetup value);
        partial void OnBarcodeSetupChanged();
        /// <summary>
        /// There are no comments for Property ProductVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVersion ProductVersion
        {
            get
            {
                return this._ProductVersion;
            }
            set
            {
                this.OnProductVersionChanging(value);
                this._ProductVersion = value;
                this.OnProductVersionChanged();
                this.OnPropertyChanged("ProductVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVersion _ProductVersion;
        partial void OnProductVersionChanging(global::Microsoft.Dynamics.DataEntities.ProductVersion value);
        partial void OnProductVersionChanged();
        /// <summary>
        /// There are no comments for Property ProductColor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductColor ProductColor
        {
            get
            {
                return this._ProductColor;
            }
            set
            {
                this.OnProductColorChanging(value);
                this._ProductColor = value;
                this.OnProductColorChanged();
                this.OnPropertyChanged("ProductColor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductColor _ProductColor;
        partial void OnProductColorChanging(global::Microsoft.Dynamics.DataEntities.ProductColor value);
        partial void OnProductColorChanged();
        /// <summary>
        /// There are no comments for Property ProductStyle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductStyle ProductStyle
        {
            get
            {
                return this._ProductStyle;
            }
            set
            {
                this.OnProductStyleChanging(value);
                this._ProductStyle = value;
                this.OnProductStyleChanged();
                this.OnPropertyChanged("ProductStyle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductStyle _ProductStyle;
        partial void OnProductStyleChanging(global::Microsoft.Dynamics.DataEntities.ProductStyle value);
        partial void OnProductStyleChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 ReleasedProductV2
        {
            get
            {
                return this._ReleasedProductV2;
            }
            set
            {
                this.OnReleasedProductV2Changing(value);
                this._ReleasedProductV2 = value;
                this.OnReleasedProductV2Changed();
                this.OnPropertyChanged("ReleasedProductV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 _ReleasedProductV2;
        partial void OnReleasedProductV2Changing(global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 value);
        partial void OnReleasedProductV2Changed();
        /// <summary>
        /// There are no comments for Property ProductSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductSize ProductSize
        {
            get
            {
                return this._ProductSize;
            }
            set
            {
                this.OnProductSizeChanging(value);
                this._ProductSize = value;
                this.OnProductSizeChanged();
                this.OnPropertyChanged("ProductSize");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductSize _ProductSize;
        partial void OnProductSizeChanging(global::Microsoft.Dynamics.DataEntities.ProductSize value);
        partial void OnProductSizeChanged();
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
