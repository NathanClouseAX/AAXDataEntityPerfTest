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
        /// There are no comments for PurchaseOrderAutoCostHeaderSingle in the schema.
        /// </summary>
    public partial class PurchaseOrderAutoCostHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PurchaseOrderAutoCostHeader>
    {
        /// <summary>
        /// Initialize a new PurchaseOrderAutoCostHeaderSingle object.
        /// </summary>
        public PurchaseOrderAutoCostHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PurchaseOrderAutoCostHeaderSingle object.
        /// </summary>
        public PurchaseOrderAutoCostHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PurchaseOrderAutoCostHeaderSingle object.
        /// </summary>
        public PurchaseOrderAutoCostHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PurchaseOrderAutoCostHeader> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for PurchaseOrderAutoCostHeader in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PurchaseOrderCostAutoNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PurchaseOrderCostAutoNumber")]
    [global::Microsoft.OData.Client.EntitySet("PurchaseOrderAutoCostHeaders")]
    public partial class PurchaseOrderAutoCostHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PurchaseOrderAutoCostHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="purchaseOrderCostAutoNumber">Initial value of PurchaseOrderCostAutoNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PurchaseOrderAutoCostHeader CreatePurchaseOrderAutoCostHeader(string dataAreaId, string purchaseOrderCostAutoNumber)
        {
            PurchaseOrderAutoCostHeader purchaseOrderAutoCostHeader = new PurchaseOrderAutoCostHeader();
            purchaseOrderAutoCostHeader.dataAreaId = dataAreaId;
            purchaseOrderAutoCostHeader.PurchaseOrderCostAutoNumber = purchaseOrderCostAutoNumber;
            return purchaseOrderAutoCostHeader;
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
        /// There are no comments for Property PurchaseOrderCostAutoNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PurchaseOrderCostAutoNumber
        {
            get
            {
                return this._PurchaseOrderCostAutoNumber;
            }
            set
            {
                this.OnPurchaseOrderCostAutoNumberChanging(value);
                this._PurchaseOrderCostAutoNumber = value;
                this.OnPurchaseOrderCostAutoNumberChanged();
                this.OnPropertyChanged("PurchaseOrderCostAutoNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseOrderCostAutoNumber;
        partial void OnPurchaseOrderCostAutoNumberChanging(string value);
        partial void OnPurchaseOrderCostAutoNumberChanged();
        /// <summary>
        /// There are no comments for Property VendorLandedCostTypeGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorLandedCostTypeGroupId
        {
            get
            {
                return this._VendorLandedCostTypeGroupId;
            }
            set
            {
                this.OnVendorLandedCostTypeGroupIdChanging(value);
                this._VendorLandedCostTypeGroupId = value;
                this.OnVendorLandedCostTypeGroupIdChanged();
                this.OnPropertyChanged("VendorLandedCostTypeGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorLandedCostTypeGroupId;
        partial void OnVendorLandedCostTypeGroupIdChanging(string value);
        partial void OnVendorLandedCostTypeGroupIdChanged();
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
