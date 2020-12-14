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
        /// There are no comments for VendorPaymentJournalLineSettledInvoiceSingle in the schema.
        /// </summary>
    public partial class VendorPaymentJournalLineSettledInvoiceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorPaymentJournalLineSettledInvoice>
    {
        /// <summary>
        /// Initialize a new VendorPaymentJournalLineSettledInvoiceSingle object.
        /// </summary>
        public VendorPaymentJournalLineSettledInvoiceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorPaymentJournalLineSettledInvoiceSingle object.
        /// </summary>
        public VendorPaymentJournalLineSettledInvoiceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorPaymentJournalLineSettledInvoiceSingle object.
        /// </summary>
        public VendorPaymentJournalLineSettledInvoiceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorPaymentJournalLineSettledInvoice> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for VendorPaymentJournalLineEntityRelatedRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLineSingle VendorPaymentJournalLineEntityRelatedRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendorPaymentJournalLineEntityRelatedRole == null))
                {
                    this._VendorPaymentJournalLineEntityRelatedRole = new global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLineSingle(this.Context, GetPath("VendorPaymentJournalLineEntityRelatedRole"));
                }
                return this._VendorPaymentJournalLineEntityRelatedRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLineSingle _VendorPaymentJournalLineEntityRelatedRole;
        /// <summary>
        /// There are no comments for VendorPaymentJournalHeaderRelatedRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalHeaderSingle VendorPaymentJournalHeaderRelatedRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendorPaymentJournalHeaderRelatedRole == null))
                {
                    this._VendorPaymentJournalHeaderRelatedRole = new global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalHeaderSingle(this.Context, GetPath("VendorPaymentJournalHeaderRelatedRole"));
                }
                return this._VendorPaymentJournalHeaderRelatedRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalHeaderSingle _VendorPaymentJournalHeaderRelatedRole;
        /// <summary>
        /// There are no comments for VendorPaymentJournalLineSettledInvoiceAccountCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle VendorPaymentJournalLineSettledInvoiceAccountCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendorPaymentJournalLineSettledInvoiceAccountCombination == null))
                {
                    this._VendorPaymentJournalLineSettledInvoiceAccountCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("VendorPaymentJournalLineSettledInvoiceAccountCombination"));
                }
                return this._VendorPaymentJournalLineSettledInvoiceAccountCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _VendorPaymentJournalLineSettledInvoiceAccountCombination;
    }
        /// <summary>
        /// There are no comments for VendorPaymentJournalLineSettledInvoice in the schema.
        /// </summary>
    /// <KeyProperties>
    /// JournalLineCompany
    /// JournalBatchNumber
    /// JournalLineNumber
    /// InvoiceNumber
    /// InvoiceCompany
    /// InvoiceDueDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("JournalLineCompany", "JournalBatchNumber", "JournalLineNumber", "InvoiceNumber", "InvoiceCompany", "InvoiceDueDate")]
    [global::Microsoft.OData.Client.EntitySet("VendorPaymentJournalLineSettledInvoices")]
    public partial class VendorPaymentJournalLineSettledInvoice : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorPaymentJournalLineSettledInvoice object.
        /// </summary>
        /// <param name="journalLineCompany">Initial value of JournalLineCompany.</param>
        /// <param name="journalBatchNumber">Initial value of JournalBatchNumber.</param>
        /// <param name="journalLineNumber">Initial value of JournalLineNumber.</param>
        /// <param name="invoiceNumber">Initial value of InvoiceNumber.</param>
        /// <param name="invoiceCompany">Initial value of InvoiceCompany.</param>
        /// <param name="invoiceDueDate">Initial value of InvoiceDueDate.</param>
        /// <param name="invoiceToPaymentCrossRate">Initial value of InvoiceToPaymentCrossRate.</param>
        /// <param name="cashDiscountToTakeInInvoiceCurrency">Initial value of CashDiscountToTakeInInvoiceCurrency.</param>
        /// <param name="settlementAmountInInvoiceCurrency">Initial value of SettlementAmountInInvoiceCurrency.</param>
        /// <param name="vendorPaymentJournalLineEntityRelatedRole">Initial value of VendorPaymentJournalLineEntityRelatedRole.</param>
        /// <param name="vendorPaymentJournalHeaderRelatedRole">Initial value of VendorPaymentJournalHeaderRelatedRole.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorPaymentJournalLineSettledInvoice CreateVendorPaymentJournalLineSettledInvoice(string journalLineCompany, 
                    string journalBatchNumber, 
                    decimal journalLineNumber, 
                    string invoiceNumber, 
                    string invoiceCompany, 
                    global::System.DateTimeOffset invoiceDueDate, 
                    decimal invoiceToPaymentCrossRate, 
                    decimal cashDiscountToTakeInInvoiceCurrency, 
                    decimal settlementAmountInInvoiceCurrency, 
                    global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine vendorPaymentJournalLineEntityRelatedRole, 
                    global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalHeader vendorPaymentJournalHeaderRelatedRole)
        {
            VendorPaymentJournalLineSettledInvoice vendorPaymentJournalLineSettledInvoice = new VendorPaymentJournalLineSettledInvoice();
            vendorPaymentJournalLineSettledInvoice.JournalLineCompany = journalLineCompany;
            vendorPaymentJournalLineSettledInvoice.JournalBatchNumber = journalBatchNumber;
            vendorPaymentJournalLineSettledInvoice.JournalLineNumber = journalLineNumber;
            vendorPaymentJournalLineSettledInvoice.InvoiceNumber = invoiceNumber;
            vendorPaymentJournalLineSettledInvoice.InvoiceCompany = invoiceCompany;
            vendorPaymentJournalLineSettledInvoice.InvoiceDueDate = invoiceDueDate;
            vendorPaymentJournalLineSettledInvoice.InvoiceToPaymentCrossRate = invoiceToPaymentCrossRate;
            vendorPaymentJournalLineSettledInvoice.CashDiscountToTakeInInvoiceCurrency = cashDiscountToTakeInInvoiceCurrency;
            vendorPaymentJournalLineSettledInvoice.SettlementAmountInInvoiceCurrency = settlementAmountInInvoiceCurrency;
            if ((vendorPaymentJournalLineEntityRelatedRole == null))
            {
                throw new global::System.ArgumentNullException("vendorPaymentJournalLineEntityRelatedRole");
            }
            vendorPaymentJournalLineSettledInvoice.VendorPaymentJournalLineEntityRelatedRole = vendorPaymentJournalLineEntityRelatedRole;
            if ((vendorPaymentJournalHeaderRelatedRole == null))
            {
                throw new global::System.ArgumentNullException("vendorPaymentJournalHeaderRelatedRole");
            }
            vendorPaymentJournalLineSettledInvoice.VendorPaymentJournalHeaderRelatedRole = vendorPaymentJournalHeaderRelatedRole;
            return vendorPaymentJournalLineSettledInvoice;
        }
        /// <summary>
        /// There are no comments for Property JournalLineCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalLineCompany
        {
            get
            {
                return this._JournalLineCompany;
            }
            set
            {
                this.OnJournalLineCompanyChanging(value);
                this._JournalLineCompany = value;
                this.OnJournalLineCompanyChanged();
                this.OnPropertyChanged("JournalLineCompany");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalLineCompany;
        partial void OnJournalLineCompanyChanging(string value);
        partial void OnJournalLineCompanyChanged();
        /// <summary>
        /// There are no comments for Property JournalBatchNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalBatchNumber
        {
            get
            {
                return this._JournalBatchNumber;
            }
            set
            {
                this.OnJournalBatchNumberChanging(value);
                this._JournalBatchNumber = value;
                this.OnJournalBatchNumberChanged();
                this.OnPropertyChanged("JournalBatchNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalBatchNumber;
        partial void OnJournalBatchNumberChanging(string value);
        partial void OnJournalBatchNumberChanged();
        /// <summary>
        /// There are no comments for Property JournalLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal JournalLineNumber
        {
            get
            {
                return this._JournalLineNumber;
            }
            set
            {
                this.OnJournalLineNumberChanging(value);
                this._JournalLineNumber = value;
                this.OnJournalLineNumberChanged();
                this.OnPropertyChanged("JournalLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _JournalLineNumber;
        partial void OnJournalLineNumberChanging(decimal value);
        partial void OnJournalLineNumberChanged();
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
        /// There are no comments for Property InvoiceCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InvoiceCompany
        {
            get
            {
                return this._InvoiceCompany;
            }
            set
            {
                this.OnInvoiceCompanyChanging(value);
                this._InvoiceCompany = value;
                this.OnInvoiceCompanyChanged();
                this.OnPropertyChanged("InvoiceCompany");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceCompany;
        partial void OnInvoiceCompanyChanging(string value);
        partial void OnInvoiceCompanyChanged();
        /// <summary>
        /// There are no comments for Property InvoiceDueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset InvoiceDueDate
        {
            get
            {
                return this._InvoiceDueDate;
            }
            set
            {
                this.OnInvoiceDueDateChanging(value);
                this._InvoiceDueDate = value;
                this.OnInvoiceDueDateChanged();
                this.OnPropertyChanged("InvoiceDueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _InvoiceDueDate;
        partial void OnInvoiceDueDateChanging(global::System.DateTimeOffset value);
        partial void OnInvoiceDueDateChanged();
        /// <summary>
        /// There are no comments for Property InvoiceToPaymentCrossRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal InvoiceToPaymentCrossRate
        {
            get
            {
                return this._InvoiceToPaymentCrossRate;
            }
            set
            {
                this.OnInvoiceToPaymentCrossRateChanging(value);
                this._InvoiceToPaymentCrossRate = value;
                this.OnInvoiceToPaymentCrossRateChanged();
                this.OnPropertyChanged("InvoiceToPaymentCrossRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InvoiceToPaymentCrossRate;
        partial void OnInvoiceToPaymentCrossRateChanging(decimal value);
        partial void OnInvoiceToPaymentCrossRateChanged();
        /// <summary>
        /// There are no comments for Property CashDiscountToTakeInInvoiceCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CashDiscountToTakeInInvoiceCurrency
        {
            get
            {
                return this._CashDiscountToTakeInInvoiceCurrency;
            }
            set
            {
                this.OnCashDiscountToTakeInInvoiceCurrencyChanging(value);
                this._CashDiscountToTakeInInvoiceCurrency = value;
                this.OnCashDiscountToTakeInInvoiceCurrencyChanged();
                this.OnPropertyChanged("CashDiscountToTakeInInvoiceCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CashDiscountToTakeInInvoiceCurrency;
        partial void OnCashDiscountToTakeInInvoiceCurrencyChanging(decimal value);
        partial void OnCashDiscountToTakeInInvoiceCurrencyChanged();
        /// <summary>
        /// There are no comments for Property SettlementAmountInInvoiceCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SettlementAmountInInvoiceCurrency
        {
            get
            {
                return this._SettlementAmountInInvoiceCurrency;
            }
            set
            {
                this.OnSettlementAmountInInvoiceCurrencyChanging(value);
                this._SettlementAmountInInvoiceCurrency = value;
                this.OnSettlementAmountInInvoiceCurrencyChanged();
                this.OnPropertyChanged("SettlementAmountInInvoiceCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SettlementAmountInInvoiceCurrency;
        partial void OnSettlementAmountInInvoiceCurrencyChanging(decimal value);
        partial void OnSettlementAmountInInvoiceCurrencyChanged();
        /// <summary>
        /// There are no comments for Property invoiceAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string invoiceAccount
        {
            get
            {
                return this._invoiceAccount;
            }
            set
            {
                this.OninvoiceAccountChanging(value);
                this._invoiceAccount = value;
                this.OninvoiceAccountChanged();
                this.OnPropertyChanged("invoiceAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _invoiceAccount;
        partial void OninvoiceAccountChanging(string value);
        partial void OninvoiceAccountChanged();
        /// <summary>
        /// There are no comments for Property AccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountDisplayValue
        {
            get
            {
                return this._AccountDisplayValue;
            }
            set
            {
                this.OnAccountDisplayValueChanging(value);
                this._AccountDisplayValue = value;
                this.OnAccountDisplayValueChanged();
                this.OnPropertyChanged("AccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountDisplayValue;
        partial void OnAccountDisplayValueChanging(string value);
        partial void OnAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property VendorPaymentJournalLineEntityRelatedRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine VendorPaymentJournalLineEntityRelatedRole
        {
            get
            {
                return this._VendorPaymentJournalLineEntityRelatedRole;
            }
            set
            {
                this.OnVendorPaymentJournalLineEntityRelatedRoleChanging(value);
                this._VendorPaymentJournalLineEntityRelatedRole = value;
                this.OnVendorPaymentJournalLineEntityRelatedRoleChanged();
                this.OnPropertyChanged("VendorPaymentJournalLineEntityRelatedRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine _VendorPaymentJournalLineEntityRelatedRole;
        partial void OnVendorPaymentJournalLineEntityRelatedRoleChanging(global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine value);
        partial void OnVendorPaymentJournalLineEntityRelatedRoleChanged();
        /// <summary>
        /// There are no comments for Property VendorPaymentJournalHeaderRelatedRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalHeader VendorPaymentJournalHeaderRelatedRole
        {
            get
            {
                return this._VendorPaymentJournalHeaderRelatedRole;
            }
            set
            {
                this.OnVendorPaymentJournalHeaderRelatedRoleChanging(value);
                this._VendorPaymentJournalHeaderRelatedRole = value;
                this.OnVendorPaymentJournalHeaderRelatedRoleChanged();
                this.OnPropertyChanged("VendorPaymentJournalHeaderRelatedRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalHeader _VendorPaymentJournalHeaderRelatedRole;
        partial void OnVendorPaymentJournalHeaderRelatedRoleChanging(global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalHeader value);
        partial void OnVendorPaymentJournalHeaderRelatedRoleChanged();
        /// <summary>
        /// There are no comments for Property VendorPaymentJournalLineSettledInvoiceAccountCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination VendorPaymentJournalLineSettledInvoiceAccountCombination
        {
            get
            {
                return this._VendorPaymentJournalLineSettledInvoiceAccountCombination;
            }
            set
            {
                this.OnVendorPaymentJournalLineSettledInvoiceAccountCombinationChanging(value);
                this._VendorPaymentJournalLineSettledInvoiceAccountCombination = value;
                this.OnVendorPaymentJournalLineSettledInvoiceAccountCombinationChanged();
                this.OnPropertyChanged("VendorPaymentJournalLineSettledInvoiceAccountCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _VendorPaymentJournalLineSettledInvoiceAccountCombination;
        partial void OnVendorPaymentJournalLineSettledInvoiceAccountCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnVendorPaymentJournalLineSettledInvoiceAccountCombinationChanged();
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
