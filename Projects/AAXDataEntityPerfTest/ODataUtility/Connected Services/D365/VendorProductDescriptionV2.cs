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
        /// There are no comments for VendorProductDescriptionV2Single in the schema.
        /// </summary>
    public partial class VendorProductDescriptionV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorProductDescriptionV2>
    {
        /// <summary>
        /// Initialize a new VendorProductDescriptionV2Single object.
        /// </summary>
        public VendorProductDescriptionV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorProductDescriptionV2Single object.
        /// </summary>
        public VendorProductDescriptionV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorProductDescriptionV2Single object.
        /// </summary>
        public VendorProductDescriptionV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorProductDescriptionV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Vendor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorV2Single Vendor
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Vendor == null))
                {
                    this._Vendor = new global::Microsoft.Dynamics.DataEntities.VendorV2Single(this.Context, GetPath("Vendor"));
                }
                return this._Vendor;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorV2Single _Vendor;
        /// <summary>
        /// There are no comments for ReleasedProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single ReleasedProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProduct == null))
                {
                    this._ReleasedProduct = new global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single(this.Context, GetPath("ReleasedProduct"));
                }
                return this._ReleasedProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single _ReleasedProduct;
    }
        /// <summary>
        /// There are no comments for VendorProductDescriptionV2 in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ItemNumber
    /// ProductColorId
    /// ProductConfigurationId
    /// ProductSizeId
    /// ProductStyleId
    /// ProductVersionId
    /// VendorAccountNumber
    /// ProductDescriptionVendorGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ItemNumber", "ProductColorId", "ProductConfigurationId", "ProductSizeId", "ProductStyleId", "ProductVersionId", "VendorAccountNumber", "ProductDescriptionVendorGroupId")]
    [global::Microsoft.OData.Client.EntitySet("VendorProductDescriptionsV2")]
    public partial class VendorProductDescriptionV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorProductDescriptionV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="productVersionId">Initial value of ProductVersionId.</param>
        /// <param name="vendorAccountNumber">Initial value of VendorAccountNumber.</param>
        /// <param name="productDescriptionVendorGroupId">Initial value of ProductDescriptionVendorGroupId.</param>
        /// <param name="releasedProduct">Initial value of ReleasedProduct.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorProductDescriptionV2 CreateVendorProductDescriptionV2(string dataAreaId, 
                    string itemNumber, 
                    string productColorId, 
                    string productConfigurationId, 
                    string productSizeId, 
                    string productStyleId, 
                    string productVersionId, 
                    string vendorAccountNumber, 
                    string productDescriptionVendorGroupId, 
                    global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 releasedProduct)
        {
            VendorProductDescriptionV2 vendorProductDescriptionV2 = new VendorProductDescriptionV2();
            vendorProductDescriptionV2.dataAreaId = dataAreaId;
            vendorProductDescriptionV2.ItemNumber = itemNumber;
            vendorProductDescriptionV2.ProductColorId = productColorId;
            vendorProductDescriptionV2.ProductConfigurationId = productConfigurationId;
            vendorProductDescriptionV2.ProductSizeId = productSizeId;
            vendorProductDescriptionV2.ProductStyleId = productStyleId;
            vendorProductDescriptionV2.ProductVersionId = productVersionId;
            vendorProductDescriptionV2.VendorAccountNumber = vendorAccountNumber;
            vendorProductDescriptionV2.ProductDescriptionVendorGroupId = productDescriptionVendorGroupId;
            if ((releasedProduct == null))
            {
                throw new global::System.ArgumentNullException("releasedProduct");
            }
            vendorProductDescriptionV2.ReleasedProduct = releasedProduct;
            return vendorProductDescriptionV2;
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
        /// There are no comments for Property VendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorAccountNumber
        {
            get
            {
                return this._VendorAccountNumber;
            }
            set
            {
                this.OnVendorAccountNumberChanging(value);
                this._VendorAccountNumber = value;
                this.OnVendorAccountNumberChanged();
                this.OnPropertyChanged("VendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAccountNumber;
        partial void OnVendorAccountNumberChanging(string value);
        partial void OnVendorAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductDescriptionVendorGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductDescriptionVendorGroupId
        {
            get
            {
                return this._ProductDescriptionVendorGroupId;
            }
            set
            {
                this.OnProductDescriptionVendorGroupIdChanging(value);
                this._ProductDescriptionVendorGroupId = value;
                this.OnProductDescriptionVendorGroupIdChanged();
                this.OnPropertyChanged("ProductDescriptionVendorGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductDescriptionVendorGroupId;
        partial void OnProductDescriptionVendorGroupIdChanging(string value);
        partial void OnProductDescriptionVendorGroupIdChanged();
        /// <summary>
        /// There are no comments for Property VendorABCCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ABC> VendorABCCode
        {
            get
            {
                return this._VendorABCCode;
            }
            set
            {
                this.OnVendorABCCodeChanging(value);
                this._VendorABCCode = value;
                this.OnVendorABCCodeChanged();
                this.OnPropertyChanged("VendorABCCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ABC> _VendorABCCode;
        partial void OnVendorABCCodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ABC> value);
        partial void OnVendorABCCodeChanged();
        /// <summary>
        /// There are no comments for Property VendorProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorProductNumber
        {
            get
            {
                return this._VendorProductNumber;
            }
            set
            {
                this.OnVendorProductNumberChanging(value);
                this._VendorProductNumber = value;
                this.OnVendorProductNumberChanged();
                this.OnPropertyChanged("VendorProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorProductNumber;
        partial void OnVendorProductNumberChanging(string value);
        partial void OnVendorProductNumberChanged();
        /// <summary>
        /// There are no comments for Property VendorProductDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorProductDescription
        {
            get
            {
                return this._VendorProductDescription;
            }
            set
            {
                this.OnVendorProductDescriptionChanging(value);
                this._VendorProductDescription = value;
                this.OnVendorProductDescriptionChanged();
                this.OnPropertyChanged("VendorProductDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorProductDescription;
        partial void OnVendorProductDescriptionChanging(string value);
        partial void OnVendorProductDescriptionChanged();
        /// <summary>
        /// There are no comments for Property VendorABCCodeNote in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorABCCodeNote
        {
            get
            {
                return this._VendorABCCodeNote;
            }
            set
            {
                this.OnVendorABCCodeNoteChanging(value);
                this._VendorABCCodeNote = value;
                this.OnVendorABCCodeNoteChanged();
                this.OnPropertyChanged("VendorABCCodeNote");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorABCCodeNote;
        partial void OnVendorABCCodeNoteChanging(string value);
        partial void OnVendorABCCodeNoteChanged();
        /// <summary>
        /// There are no comments for Property Vendor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorV2 Vendor
        {
            get
            {
                return this._Vendor;
            }
            set
            {
                this.OnVendorChanging(value);
                this._Vendor = value;
                this.OnVendorChanged();
                this.OnPropertyChanged("Vendor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorV2 _Vendor;
        partial void OnVendorChanging(global::Microsoft.Dynamics.DataEntities.VendorV2 value);
        partial void OnVendorChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 ReleasedProduct
        {
            get
            {
                return this._ReleasedProduct;
            }
            set
            {
                this.OnReleasedProductChanging(value);
                this._ReleasedProduct = value;
                this.OnReleasedProductChanged();
                this.OnPropertyChanged("ReleasedProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 _ReleasedProduct;
        partial void OnReleasedProductChanging(global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 value);
        partial void OnReleasedProductChanged();
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
