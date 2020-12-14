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
        /// There are no comments for ProductApprovedVendorSingle in the schema.
        /// </summary>
    public partial class ProductApprovedVendorSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductApprovedVendor>
    {
        /// <summary>
        /// Initialize a new ProductApprovedVendorSingle object.
        /// </summary>
        public ProductApprovedVendorSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductApprovedVendorSingle object.
        /// </summary>
        public ProductApprovedVendorSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductApprovedVendorSingle object.
        /// </summary>
        public ProductApprovedVendorSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductApprovedVendor> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ApprovedVendor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorV2Single ApprovedVendor
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ApprovedVendor == null))
                {
                    this._ApprovedVendor = new global::Microsoft.Dynamics.DataEntities.VendorV2Single(this.Context, GetPath("ApprovedVendor"));
                }
                return this._ApprovedVendor;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorV2Single _ApprovedVendor;
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
        /// There are no comments for ProductApprovedVendor in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ItemNumber
    /// ApprovedVendorAccountNumber
    /// EffectiveDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ItemNumber", "ApprovedVendorAccountNumber", "EffectiveDate")]
    [global::Microsoft.OData.Client.EntitySet("ProductApprovedVendors")]
    public partial class ProductApprovedVendor : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductApprovedVendor object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="approvedVendorAccountNumber">Initial value of ApprovedVendorAccountNumber.</param>
        /// <param name="effectiveDate">Initial value of EffectiveDate.</param>
        /// <param name="expirationDate">Initial value of ExpirationDate.</param>
        /// <param name="approvedVendor">Initial value of ApprovedVendor.</param>
        /// <param name="releasedProduct">Initial value of ReleasedProduct.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductApprovedVendor CreateProductApprovedVendor(string dataAreaId, 
                    string itemNumber, 
                    string approvedVendorAccountNumber, 
                    global::System.DateTimeOffset effectiveDate, 
                    global::System.DateTimeOffset expirationDate, 
                    global::Microsoft.Dynamics.DataEntities.VendorV2 approvedVendor, 
                    global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 releasedProduct)
        {
            ProductApprovedVendor productApprovedVendor = new ProductApprovedVendor();
            productApprovedVendor.dataAreaId = dataAreaId;
            productApprovedVendor.ItemNumber = itemNumber;
            productApprovedVendor.ApprovedVendorAccountNumber = approvedVendorAccountNumber;
            productApprovedVendor.EffectiveDate = effectiveDate;
            productApprovedVendor.ExpirationDate = expirationDate;
            if ((approvedVendor == null))
            {
                throw new global::System.ArgumentNullException("approvedVendor");
            }
            productApprovedVendor.ApprovedVendor = approvedVendor;
            if ((releasedProduct == null))
            {
                throw new global::System.ArgumentNullException("releasedProduct");
            }
            productApprovedVendor.ReleasedProduct = releasedProduct;
            return productApprovedVendor;
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
        /// There are no comments for Property ApprovedVendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ApprovedVendorAccountNumber
        {
            get
            {
                return this._ApprovedVendorAccountNumber;
            }
            set
            {
                this.OnApprovedVendorAccountNumberChanging(value);
                this._ApprovedVendorAccountNumber = value;
                this.OnApprovedVendorAccountNumberChanged();
                this.OnPropertyChanged("ApprovedVendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ApprovedVendorAccountNumber;
        partial void OnApprovedVendorAccountNumberChanging(string value);
        partial void OnApprovedVendorAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property EffectiveDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EffectiveDate
        {
            get
            {
                return this._EffectiveDate;
            }
            set
            {
                this.OnEffectiveDateChanging(value);
                this._EffectiveDate = value;
                this.OnEffectiveDateChanged();
                this.OnPropertyChanged("EffectiveDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EffectiveDate;
        partial void OnEffectiveDateChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveDateChanged();
        /// <summary>
        /// There are no comments for Property ExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ExpirationDate
        {
            get
            {
                return this._ExpirationDate;
            }
            set
            {
                this.OnExpirationDateChanging(value);
                this._ExpirationDate = value;
                this.OnExpirationDateChanged();
                this.OnPropertyChanged("ExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ExpirationDate;
        partial void OnExpirationDateChanging(global::System.DateTimeOffset value);
        partial void OnExpirationDateChanged();
        /// <summary>
        /// There are no comments for Property ApprovedVendor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorV2 ApprovedVendor
        {
            get
            {
                return this._ApprovedVendor;
            }
            set
            {
                this.OnApprovedVendorChanging(value);
                this._ApprovedVendor = value;
                this.OnApprovedVendorChanged();
                this.OnPropertyChanged("ApprovedVendor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorV2 _ApprovedVendor;
        partial void OnApprovedVendorChanging(global::Microsoft.Dynamics.DataEntities.VendorV2 value);
        partial void OnApprovedVendorChanged();
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
