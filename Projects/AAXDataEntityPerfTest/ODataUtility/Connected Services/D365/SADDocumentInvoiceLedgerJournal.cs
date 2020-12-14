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
        /// There are no comments for SADDocumentInvoiceLedgerJournalSingle in the schema.
        /// </summary>
    public partial class SADDocumentInvoiceLedgerJournalSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SADDocumentInvoiceLedgerJournal>
    {
        /// <summary>
        /// Initialize a new SADDocumentInvoiceLedgerJournalSingle object.
        /// </summary>
        public SADDocumentInvoiceLedgerJournalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SADDocumentInvoiceLedgerJournalSingle object.
        /// </summary>
        public SADDocumentInvoiceLedgerJournalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SADDocumentInvoiceLedgerJournalSingle object.
        /// </summary>
        public SADDocumentInvoiceLedgerJournalSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SADDocumentInvoiceLedgerJournal> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for SADDocumentLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.SADDocumentLedgerJournalSingle SADDocumentLedgerJournal
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SADDocumentLedgerJournal == null))
                {
                    this._SADDocumentLedgerJournal = new global::Microsoft.Dynamics.DataEntities.SADDocumentLedgerJournalSingle(this.Context, GetPath("SADDocumentLedgerJournal"));
                }
                return this._SADDocumentLedgerJournal;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SADDocumentLedgerJournalSingle _SADDocumentLedgerJournal;
        /// <summary>
        /// There are no comments for SADDocumentInvoiceLineLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLineLedgerJournal> SADDocumentInvoiceLineLedgerJournal
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SADDocumentInvoiceLineLedgerJournal == null))
                {
                    this._SADDocumentInvoiceLineLedgerJournal = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLineLedgerJournal>(GetPath("SADDocumentInvoiceLineLedgerJournal"));
                }
                return this._SADDocumentInvoiceLineLedgerJournal;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLineLedgerJournal> _SADDocumentInvoiceLineLedgerJournal;
    }
        /// <summary>
        /// There are no comments for SADDocumentInvoiceLedgerJournal in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// SADNumber
    /// SADDate
    /// Invoice
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SADNumber", "SADDate", "Invoice")]
    [global::Microsoft.OData.Client.EntitySet("SADDocumentInvoiceLedgerJournals")]
    public partial class SADDocumentInvoiceLedgerJournal : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SADDocumentInvoiceLedgerJournal object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="sADNumber">Initial value of SADNumber.</param>
        /// <param name="sADDate">Initial value of SADDate.</param>
        /// <param name="invoice">Initial value of Invoice.</param>
        /// <param name="invoiceDate">Initial value of InvoiceDate.</param>
        /// <param name="sADDocumentLedgerJournal">Initial value of SADDocumentLedgerJournal.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SADDocumentInvoiceLedgerJournal CreateSADDocumentInvoiceLedgerJournal(string dataAreaId, 
                    string sADNumber, 
                    global::System.DateTimeOffset sADDate, 
                    string invoice, 
                    global::System.DateTimeOffset invoiceDate, 
                    global::Microsoft.Dynamics.DataEntities.SADDocumentLedgerJournal sADDocumentLedgerJournal)
        {
            SADDocumentInvoiceLedgerJournal sADDocumentInvoiceLedgerJournal = new SADDocumentInvoiceLedgerJournal();
            sADDocumentInvoiceLedgerJournal.dataAreaId = dataAreaId;
            sADDocumentInvoiceLedgerJournal.SADNumber = sADNumber;
            sADDocumentInvoiceLedgerJournal.SADDate = sADDate;
            sADDocumentInvoiceLedgerJournal.Invoice = invoice;
            sADDocumentInvoiceLedgerJournal.InvoiceDate = invoiceDate;
            if ((sADDocumentLedgerJournal == null))
            {
                throw new global::System.ArgumentNullException("sADDocumentLedgerJournal");
            }
            sADDocumentInvoiceLedgerJournal.SADDocumentLedgerJournal = sADDocumentLedgerJournal;
            return sADDocumentInvoiceLedgerJournal;
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
        /// There are no comments for Property SADNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SADNumber
        {
            get
            {
                return this._SADNumber;
            }
            set
            {
                this.OnSADNumberChanging(value);
                this._SADNumber = value;
                this.OnSADNumberChanged();
                this.OnPropertyChanged("SADNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SADNumber;
        partial void OnSADNumberChanging(string value);
        partial void OnSADNumberChanged();
        /// <summary>
        /// There are no comments for Property SADDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset SADDate
        {
            get
            {
                return this._SADDate;
            }
            set
            {
                this.OnSADDateChanging(value);
                this._SADDate = value;
                this.OnSADDateChanged();
                this.OnPropertyChanged("SADDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _SADDate;
        partial void OnSADDateChanging(global::System.DateTimeOffset value);
        partial void OnSADDateChanged();
        /// <summary>
        /// There are no comments for Property Invoice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Invoice
        {
            get
            {
                return this._Invoice;
            }
            set
            {
                this.OnInvoiceChanging(value);
                this._Invoice = value;
                this.OnInvoiceChanged();
                this.OnPropertyChanged("Invoice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Invoice;
        partial void OnInvoiceChanging(string value);
        partial void OnInvoiceChanged();
        /// <summary>
        /// There are no comments for Property InvoiceDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset InvoiceDate
        {
            get
            {
                return this._InvoiceDate;
            }
            set
            {
                this.OnInvoiceDateChanging(value);
                this._InvoiceDate = value;
                this.OnInvoiceDateChanged();
                this.OnPropertyChanged("InvoiceDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _InvoiceDate;
        partial void OnInvoiceDateChanging(global::System.DateTimeOffset value);
        partial void OnInvoiceDateChanged();
        /// <summary>
        /// There are no comments for Property VendorAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorAccount
        {
            get
            {
                return this._VendorAccount;
            }
            set
            {
                this.OnVendorAccountChanging(value);
                this._VendorAccount = value;
                this.OnVendorAccountChanged();
                this.OnPropertyChanged("VendorAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAccount;
        partial void OnVendorAccountChanging(string value);
        partial void OnVendorAccountChanged();
        /// <summary>
        /// There are no comments for Property SADDocumentLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.SADDocumentLedgerJournal SADDocumentLedgerJournal
        {
            get
            {
                return this._SADDocumentLedgerJournal;
            }
            set
            {
                this.OnSADDocumentLedgerJournalChanging(value);
                this._SADDocumentLedgerJournal = value;
                this.OnSADDocumentLedgerJournalChanged();
                this.OnPropertyChanged("SADDocumentLedgerJournal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SADDocumentLedgerJournal _SADDocumentLedgerJournal;
        partial void OnSADDocumentLedgerJournalChanging(global::Microsoft.Dynamics.DataEntities.SADDocumentLedgerJournal value);
        partial void OnSADDocumentLedgerJournalChanged();
        /// <summary>
        /// There are no comments for Property SADDocumentInvoiceLineLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLineLedgerJournal> SADDocumentInvoiceLineLedgerJournal
        {
            get
            {
                return this._SADDocumentInvoiceLineLedgerJournal;
            }
            set
            {
                this.OnSADDocumentInvoiceLineLedgerJournalChanging(value);
                this._SADDocumentInvoiceLineLedgerJournal = value;
                this.OnSADDocumentInvoiceLineLedgerJournalChanged();
                this.OnPropertyChanged("SADDocumentInvoiceLineLedgerJournal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLineLedgerJournal> _SADDocumentInvoiceLineLedgerJournal = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLineLedgerJournal>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSADDocumentInvoiceLineLedgerJournalChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLineLedgerJournal> value);
        partial void OnSADDocumentInvoiceLineLedgerJournalChanged();
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
