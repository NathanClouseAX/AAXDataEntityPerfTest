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
        /// There are no comments for SalesInvoiceJournalHeaderSingle in the schema.
        /// </summary>
    public partial class SalesInvoiceJournalHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SalesInvoiceJournalHeader>
    {
        /// <summary>
        /// Initialize a new SalesInvoiceJournalHeaderSingle object.
        /// </summary>
        public SalesInvoiceJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SalesInvoiceJournalHeaderSingle object.
        /// </summary>
        public SalesInvoiceJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SalesInvoiceJournalHeaderSingle object.
        /// </summary>
        public SalesInvoiceJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SalesInvoiceJournalHeader> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for SalesInvoiceJournalHeader in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// InvoiceNumber
    /// InvoiceDate
    /// LedgerVoucher
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "InvoiceNumber", "InvoiceDate", "LedgerVoucher")]
    [global::Microsoft.OData.Client.EntitySet("SalesInvoiceJournalHeaders")]
    public partial class SalesInvoiceJournalHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SalesInvoiceJournalHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="invoiceNumber">Initial value of InvoiceNumber.</param>
        /// <param name="invoiceDate">Initial value of InvoiceDate.</param>
        /// <param name="ledgerVoucher">Initial value of LedgerVoucher.</param>
        /// <param name="totalTaxAmount">Initial value of TotalTaxAmount.</param>
        /// <param name="totalDiscountCustomerGroupCode">Initial value of TotalDiscountCustomerGroupCode.</param>
        /// <param name="totalChargeAmount">Initial value of TotalChargeAmount.</param>
        /// <param name="totalDiscountAmount">Initial value of TotalDiscountAmount.</param>
        /// <param name="totalInvoiceAmount">Initial value of TotalInvoiceAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SalesInvoiceJournalHeader CreateSalesInvoiceJournalHeader(string dataAreaId, 
                    string invoiceNumber, 
                    global::System.DateTimeOffset invoiceDate, 
                    string ledgerVoucher, 
                    decimal totalTaxAmount, 
                    decimal totalDiscountCustomerGroupCode, 
                    decimal totalChargeAmount, 
                    decimal totalDiscountAmount, 
                    decimal totalInvoiceAmount)
        {
            SalesInvoiceJournalHeader salesInvoiceJournalHeader = new SalesInvoiceJournalHeader();
            salesInvoiceJournalHeader.dataAreaId = dataAreaId;
            salesInvoiceJournalHeader.InvoiceNumber = invoiceNumber;
            salesInvoiceJournalHeader.InvoiceDate = invoiceDate;
            salesInvoiceJournalHeader.LedgerVoucher = ledgerVoucher;
            salesInvoiceJournalHeader.TotalTaxAmount = totalTaxAmount;
            salesInvoiceJournalHeader.TotalDiscountCustomerGroupCode = totalDiscountCustomerGroupCode;
            salesInvoiceJournalHeader.TotalChargeAmount = totalChargeAmount;
            salesInvoiceJournalHeader.TotalDiscountAmount = totalDiscountAmount;
            salesInvoiceJournalHeader.TotalInvoiceAmount = totalInvoiceAmount;
            return salesInvoiceJournalHeader;
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
        /// There are no comments for Property InvoiceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InvoiceNumber
        {
            get
            {
                return this._InvoiceNumber;
            }
            set
            {
                this.OnInvoiceNumberChanging(value);
                this._InvoiceNumber = value;
                this.OnInvoiceNumberChanged();
                this.OnPropertyChanged("InvoiceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceNumber;
        partial void OnInvoiceNumberChanging(string value);
        partial void OnInvoiceNumberChanged();
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
        /// There are no comments for Property LedgerVoucher in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LedgerVoucher
        {
            get
            {
                return this._LedgerVoucher;
            }
            set
            {
                this.OnLedgerVoucherChanging(value);
                this._LedgerVoucher = value;
                this.OnLedgerVoucherChanged();
                this.OnPropertyChanged("LedgerVoucher");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerVoucher;
        partial void OnLedgerVoucherChanging(string value);
        partial void OnLedgerVoucherChanged();
        /// <summary>
        /// There are no comments for Property InvoiceAddressCountryRegionISOCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InvoiceAddressCountryRegionISOCode
        {
            get
            {
                return this._InvoiceAddressCountryRegionISOCode;
            }
            set
            {
                this.OnInvoiceAddressCountryRegionISOCodeChanging(value);
                this._InvoiceAddressCountryRegionISOCode = value;
                this.OnInvoiceAddressCountryRegionISOCodeChanged();
                this.OnPropertyChanged("InvoiceAddressCountryRegionISOCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceAddressCountryRegionISOCode;
        partial void OnInvoiceAddressCountryRegionISOCodeChanging(string value);
        partial void OnInvoiceAddressCountryRegionISOCodeChanged();
        /// <summary>
        /// There are no comments for Property InvoiceAddressZipCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InvoiceAddressZipCode
        {
            get
            {
                return this._InvoiceAddressZipCode;
            }
            set
            {
                this.OnInvoiceAddressZipCodeChanging(value);
                this._InvoiceAddressZipCode = value;
                this.OnInvoiceAddressZipCodeChanged();
                this.OnPropertyChanged("InvoiceAddressZipCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceAddressZipCode;
        partial void OnInvoiceAddressZipCodeChanging(string value);
        partial void OnInvoiceAddressZipCodeChanged();
        /// <summary>
        /// There are no comments for Property TotalTaxAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TotalTaxAmount
        {
            get
            {
                return this._TotalTaxAmount;
            }
            set
            {
                this.OnTotalTaxAmountChanging(value);
                this._TotalTaxAmount = value;
                this.OnTotalTaxAmountChanged();
                this.OnPropertyChanged("TotalTaxAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalTaxAmount;
        partial void OnTotalTaxAmountChanging(decimal value);
        partial void OnTotalTaxAmountChanged();
        /// <summary>
        /// There are no comments for Property TotalDiscountCustomerGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TotalDiscountCustomerGroupCode
        {
            get
            {
                return this._TotalDiscountCustomerGroupCode;
            }
            set
            {
                this.OnTotalDiscountCustomerGroupCodeChanging(value);
                this._TotalDiscountCustomerGroupCode = value;
                this.OnTotalDiscountCustomerGroupCodeChanged();
                this.OnPropertyChanged("TotalDiscountCustomerGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalDiscountCustomerGroupCode;
        partial void OnTotalDiscountCustomerGroupCodeChanging(decimal value);
        partial void OnTotalDiscountCustomerGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property InvoiceAddressStreetNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InvoiceAddressStreetNumber
        {
            get
            {
                return this._InvoiceAddressStreetNumber;
            }
            set
            {
                this.OnInvoiceAddressStreetNumberChanging(value);
                this._InvoiceAddressStreetNumber = value;
                this.OnInvoiceAddressStreetNumberChanged();
                this.OnPropertyChanged("InvoiceAddressStreetNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceAddressStreetNumber;
        partial void OnInvoiceAddressStreetNumberChanging(string value);
        partial void OnInvoiceAddressStreetNumberChanged();
        /// <summary>
        /// There are no comments for Property InvoiceAddressStreet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InvoiceAddressStreet
        {
            get
            {
                return this._InvoiceAddressStreet;
            }
            set
            {
                this.OnInvoiceAddressStreetChanging(value);
                this._InvoiceAddressStreet = value;
                this.OnInvoiceAddressStreetChanged();
                this.OnPropertyChanged("InvoiceAddressStreet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceAddressStreet;
        partial void OnInvoiceAddressStreetChanging(string value);
        partial void OnInvoiceAddressStreetChanged();
        /// <summary>
        /// There are no comments for Property TotalChargeAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TotalChargeAmount
        {
            get
            {
                return this._TotalChargeAmount;
            }
            set
            {
                this.OnTotalChargeAmountChanging(value);
                this._TotalChargeAmount = value;
                this.OnTotalChargeAmountChanged();
                this.OnPropertyChanged("TotalChargeAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalChargeAmount;
        partial void OnTotalChargeAmountChanging(decimal value);
        partial void OnTotalChargeAmountChanged();
        /// <summary>
        /// There are no comments for Property TotalDiscountAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TotalDiscountAmount
        {
            get
            {
                return this._TotalDiscountAmount;
            }
            set
            {
                this.OnTotalDiscountAmountChanging(value);
                this._TotalDiscountAmount = value;
                this.OnTotalDiscountAmountChanged();
                this.OnPropertyChanged("TotalDiscountAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalDiscountAmount;
        partial void OnTotalDiscountAmountChanging(decimal value);
        partial void OnTotalDiscountAmountChanged();
        /// <summary>
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this.OnCurrencyCodeChanging(value);
                this._CurrencyCode = value;
                this.OnCurrencyCodeChanged();
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property SalesOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesOrderNumber
        {
            get
            {
                return this._SalesOrderNumber;
            }
            set
            {
                this.OnSalesOrderNumberChanging(value);
                this._SalesOrderNumber = value;
                this.OnSalesOrderNumberChanged();
                this.OnPropertyChanged("SalesOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesOrderNumber;
        partial void OnSalesOrderNumberChanging(string value);
        partial void OnSalesOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property DeliveryTermsCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DeliveryTermsCode
        {
            get
            {
                return this._DeliveryTermsCode;
            }
            set
            {
                this.OnDeliveryTermsCodeChanging(value);
                this._DeliveryTermsCode = value;
                this.OnDeliveryTermsCodeChanged();
                this.OnPropertyChanged("DeliveryTermsCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeliveryTermsCode;
        partial void OnDeliveryTermsCodeChanging(string value);
        partial void OnDeliveryTermsCodeChanged();
        /// <summary>
        /// There are no comments for Property ContactPersonId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ContactPersonId
        {
            get
            {
                return this._ContactPersonId;
            }
            set
            {
                this.OnContactPersonIdChanging(value);
                this._ContactPersonId = value;
                this.OnContactPersonIdChanged();
                this.OnPropertyChanged("ContactPersonId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ContactPersonId;
        partial void OnContactPersonIdChanging(string value);
        partial void OnContactPersonIdChanged();
        /// <summary>
        /// There are no comments for Property SalesOrderResponsiblePersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesOrderResponsiblePersonnelNumber
        {
            get
            {
                return this._SalesOrderResponsiblePersonnelNumber;
            }
            set
            {
                this.OnSalesOrderResponsiblePersonnelNumberChanging(value);
                this._SalesOrderResponsiblePersonnelNumber = value;
                this.OnSalesOrderResponsiblePersonnelNumberChanged();
                this.OnPropertyChanged("SalesOrderResponsiblePersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesOrderResponsiblePersonnelNumber;
        partial void OnSalesOrderResponsiblePersonnelNumberChanging(string value);
        partial void OnSalesOrderResponsiblePersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property PaymentTermsName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PaymentTermsName
        {
            get
            {
                return this._PaymentTermsName;
            }
            set
            {
                this.OnPaymentTermsNameChanging(value);
                this._PaymentTermsName = value;
                this.OnPaymentTermsNameChanged();
                this.OnPropertyChanged("PaymentTermsName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentTermsName;
        partial void OnPaymentTermsNameChanging(string value);
        partial void OnPaymentTermsNameChanged();
        /// <summary>
        /// There are no comments for Property DeliveryModeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DeliveryModeCode
        {
            get
            {
                return this._DeliveryModeCode;
            }
            set
            {
                this.OnDeliveryModeCodeChanging(value);
                this._DeliveryModeCode = value;
                this.OnDeliveryModeCodeChanged();
                this.OnPropertyChanged("DeliveryModeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeliveryModeCode;
        partial void OnDeliveryModeCodeChanging(string value);
        partial void OnDeliveryModeCodeChanged();
        /// <summary>
        /// There are no comments for Property InvoiceCustomerAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InvoiceCustomerAccountNumber
        {
            get
            {
                return this._InvoiceCustomerAccountNumber;
            }
            set
            {
                this.OnInvoiceCustomerAccountNumberChanging(value);
                this._InvoiceCustomerAccountNumber = value;
                this.OnInvoiceCustomerAccountNumberChanged();
                this.OnPropertyChanged("InvoiceCustomerAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceCustomerAccountNumber;
        partial void OnInvoiceCustomerAccountNumberChanging(string value);
        partial void OnInvoiceCustomerAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property InvoiceAddressCity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InvoiceAddressCity
        {
            get
            {
                return this._InvoiceAddressCity;
            }
            set
            {
                this.OnInvoiceAddressCityChanging(value);
                this._InvoiceAddressCity = value;
                this.OnInvoiceAddressCityChanged();
                this.OnPropertyChanged("InvoiceAddressCity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceAddressCity;
        partial void OnInvoiceAddressCityChanging(string value);
        partial void OnInvoiceAddressCityChanged();
        /// <summary>
        /// There are no comments for Property InvoiceAddressState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InvoiceAddressState
        {
            get
            {
                return this._InvoiceAddressState;
            }
            set
            {
                this.OnInvoiceAddressStateChanging(value);
                this._InvoiceAddressState = value;
                this.OnInvoiceAddressStateChanged();
                this.OnPropertyChanged("InvoiceAddressState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceAddressState;
        partial void OnInvoiceAddressStateChanging(string value);
        partial void OnInvoiceAddressStateChanged();
        /// <summary>
        /// There are no comments for Property InvoiceAddressCountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InvoiceAddressCountryRegionId
        {
            get
            {
                return this._InvoiceAddressCountryRegionId;
            }
            set
            {
                this.OnInvoiceAddressCountryRegionIdChanging(value);
                this._InvoiceAddressCountryRegionId = value;
                this.OnInvoiceAddressCountryRegionIdChanged();
                this.OnPropertyChanged("InvoiceAddressCountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceAddressCountryRegionId;
        partial void OnInvoiceAddressCountryRegionIdChanging(string value);
        partial void OnInvoiceAddressCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property CustomersOrderReference in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomersOrderReference
        {
            get
            {
                return this._CustomersOrderReference;
            }
            set
            {
                this.OnCustomersOrderReferenceChanging(value);
                this._CustomersOrderReference = value;
                this.OnCustomersOrderReferenceChanged();
                this.OnPropertyChanged("CustomersOrderReference");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomersOrderReference;
        partial void OnCustomersOrderReferenceChanging(string value);
        partial void OnCustomersOrderReferenceChanged();
        /// <summary>
        /// There are no comments for Property TotalInvoiceAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TotalInvoiceAmount
        {
            get
            {
                return this._TotalInvoiceAmount;
            }
            set
            {
                this.OnTotalInvoiceAmountChanging(value);
                this._TotalInvoiceAmount = value;
                this.OnTotalInvoiceAmountChanged();
                this.OnPropertyChanged("TotalInvoiceAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalInvoiceAmount;
        partial void OnTotalInvoiceAmountChanging(decimal value);
        partial void OnTotalInvoiceAmountChanged();
        /// <summary>
        /// There are no comments for Property SalesOrderOriginCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesOrderOriginCode
        {
            get
            {
                return this._SalesOrderOriginCode;
            }
            set
            {
                this.OnSalesOrderOriginCodeChanging(value);
                this._SalesOrderOriginCode = value;
                this.OnSalesOrderOriginCodeChanged();
                this.OnPropertyChanged("SalesOrderOriginCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesOrderOriginCode;
        partial void OnSalesOrderOriginCodeChanging(string value);
        partial void OnSalesOrderOriginCodeChanged();
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
