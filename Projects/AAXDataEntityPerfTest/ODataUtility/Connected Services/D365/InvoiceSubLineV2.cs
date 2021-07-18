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
        /// There are no comments for InvoiceSubLineV2Single in the schema.
        /// </summary>
    public partial class InvoiceSubLineV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<InvoiceSubLineV2>
    {
        /// <summary>
        /// Initialize a new InvoiceSubLineV2Single object.
        /// </summary>
        public InvoiceSubLineV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InvoiceSubLineV2Single object.
        /// </summary>
        public InvoiceSubLineV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InvoiceSubLineV2Single object.
        /// </summary>
        public InvoiceSubLineV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<InvoiceSubLineV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for VendorInvoiceLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorInvoiceLineSingle VendorInvoiceLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendorInvoiceLine == null))
                {
                    this._VendorInvoiceLine = new global::Microsoft.Dynamics.DataEntities.VendorInvoiceLineSingle(this.Context, GetPath("VendorInvoiceLine"));
                }
                return this._VendorInvoiceLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorInvoiceLineSingle _VendorInvoiceLine;
    }
        /// <summary>
        /// There are no comments for InvoiceSubLineV2 in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ProductReceiptNumber
    /// InvoiceLineReference
    /// PurchaseOrder
    /// InvoiceLineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProductReceiptNumber", "InvoiceLineReference", "PurchaseOrder", "InvoiceLineNumber")]
    [global::Microsoft.OData.Client.EntitySet("InvoiceSubLinesV2")]
    public partial class InvoiceSubLineV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new InvoiceSubLineV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="productReceiptNumber">Initial value of ProductReceiptNumber.</param>
        /// <param name="invoiceLineReference">Initial value of InvoiceLineReference.</param>
        /// <param name="purchaseOrder">Initial value of PurchaseOrder.</param>
        /// <param name="invoiceLineNumber">Initial value of InvoiceLineNumber.</param>
        /// <param name="purchaseOrderLineNumber">Initial value of PurchaseOrderLineNumber.</param>
        /// <param name="purchaseQuantity">Initial value of PurchaseQuantity.</param>
        /// <param name="vendorInvoiceLine">Initial value of VendorInvoiceLine.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static InvoiceSubLineV2 CreateInvoiceSubLineV2(string dataAreaId, 
                    string productReceiptNumber, 
                    string invoiceLineReference, 
                    string purchaseOrder, 
                    decimal invoiceLineNumber, 
                    long purchaseOrderLineNumber, 
                    decimal purchaseQuantity, 
                    global::Microsoft.Dynamics.DataEntities.VendorInvoiceLine vendorInvoiceLine)
        {
            InvoiceSubLineV2 invoiceSubLineV2 = new InvoiceSubLineV2();
            invoiceSubLineV2.dataAreaId = dataAreaId;
            invoiceSubLineV2.ProductReceiptNumber = productReceiptNumber;
            invoiceSubLineV2.InvoiceLineReference = invoiceLineReference;
            invoiceSubLineV2.PurchaseOrder = purchaseOrder;
            invoiceSubLineV2.InvoiceLineNumber = invoiceLineNumber;
            invoiceSubLineV2.PurchaseOrderLineNumber = purchaseOrderLineNumber;
            invoiceSubLineV2.PurchaseQuantity = purchaseQuantity;
            if ((vendorInvoiceLine == null))
            {
                throw new global::System.ArgumentNullException("vendorInvoiceLine");
            }
            invoiceSubLineV2.VendorInvoiceLine = vendorInvoiceLine;
            return invoiceSubLineV2;
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
        /// There are no comments for Property ProductReceiptNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductReceiptNumber
        {
            get
            {
                return this._ProductReceiptNumber;
            }
            set
            {
                this.OnProductReceiptNumberChanging(value);
                this._ProductReceiptNumber = value;
                this.OnProductReceiptNumberChanged();
                this.OnPropertyChanged("ProductReceiptNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductReceiptNumber;
        partial void OnProductReceiptNumberChanging(string value);
        partial void OnProductReceiptNumberChanged();
        /// <summary>
        /// There are no comments for Property InvoiceLineReference in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InvoiceLineReference
        {
            get
            {
                return this._InvoiceLineReference;
            }
            set
            {
                this.OnInvoiceLineReferenceChanging(value);
                this._InvoiceLineReference = value;
                this.OnInvoiceLineReferenceChanged();
                this.OnPropertyChanged("InvoiceLineReference");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceLineReference;
        partial void OnInvoiceLineReferenceChanging(string value);
        partial void OnInvoiceLineReferenceChanged();
        /// <summary>
        /// There are no comments for Property PurchaseOrder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PurchaseOrder
        {
            get
            {
                return this._PurchaseOrder;
            }
            set
            {
                this.OnPurchaseOrderChanging(value);
                this._PurchaseOrder = value;
                this.OnPurchaseOrderChanged();
                this.OnPropertyChanged("PurchaseOrder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseOrder;
        partial void OnPurchaseOrderChanging(string value);
        partial void OnPurchaseOrderChanged();
        /// <summary>
        /// There are no comments for Property InvoiceLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal InvoiceLineNumber
        {
            get
            {
                return this._InvoiceLineNumber;
            }
            set
            {
                this.OnInvoiceLineNumberChanging(value);
                this._InvoiceLineNumber = value;
                this.OnInvoiceLineNumberChanged();
                this.OnPropertyChanged("InvoiceLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InvoiceLineNumber;
        partial void OnInvoiceLineNumberChanging(decimal value);
        partial void OnInvoiceLineNumberChanged();
        /// <summary>
        /// There are no comments for Property PurchaseOrderLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long PurchaseOrderLineNumber
        {
            get
            {
                return this._PurchaseOrderLineNumber;
            }
            set
            {
                this.OnPurchaseOrderLineNumberChanging(value);
                this._PurchaseOrderLineNumber = value;
                this.OnPurchaseOrderLineNumberChanged();
                this.OnPropertyChanged("PurchaseOrderLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _PurchaseOrderLineNumber;
        partial void OnPurchaseOrderLineNumberChanging(long value);
        partial void OnPurchaseOrderLineNumberChanged();
        /// <summary>
        /// There are no comments for Property PurchaseQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PurchaseQuantity
        {
            get
            {
                return this._PurchaseQuantity;
            }
            set
            {
                this.OnPurchaseQuantityChanging(value);
                this._PurchaseQuantity = value;
                this.OnPurchaseQuantityChanged();
                this.OnPropertyChanged("PurchaseQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PurchaseQuantity;
        partial void OnPurchaseQuantityChanging(decimal value);
        partial void OnPurchaseQuantityChanged();
        /// <summary>
        /// There are no comments for Property VendorInvoiceLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorInvoiceLine VendorInvoiceLine
        {
            get
            {
                return this._VendorInvoiceLine;
            }
            set
            {
                this.OnVendorInvoiceLineChanging(value);
                this._VendorInvoiceLine = value;
                this.OnVendorInvoiceLineChanged();
                this.OnPropertyChanged("VendorInvoiceLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorInvoiceLine _VendorInvoiceLine;
        partial void OnVendorInvoiceLineChanging(global::Microsoft.Dynamics.DataEntities.VendorInvoiceLine value);
        partial void OnVendorInvoiceLineChanged();
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
