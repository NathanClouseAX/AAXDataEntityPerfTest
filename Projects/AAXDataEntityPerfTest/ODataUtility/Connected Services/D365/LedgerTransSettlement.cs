﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for LedgerTransSettlementSingle in the schema.
        /// </summary>
    public partial class LedgerTransSettlementSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerTransSettlement>
    {
        /// <summary>
        /// Initialize a new LedgerTransSettlementSingle object.
        /// </summary>
        public LedgerTransSettlementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LedgerTransSettlementSingle object.
        /// </summary>
        public LedgerTransSettlementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LedgerTransSettlementSingle object.
        /// </summary>
        public LedgerTransSettlementSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerTransSettlement> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LedgerDimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle LedgerDimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerDimensionCombination == null))
                {
                    this._LedgerDimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("LedgerDimensionCombination"));
                }
                return this._LedgerDimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _LedgerDimensionCombination;
    }
        /// <summary>
        /// There are no comments for LedgerTransSettlement in the schema.
        /// </summary>
    /// <KeyProperties>
    /// GeneralJournalAccountEntry
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("GeneralJournalAccountEntry")]
    [global::Microsoft.OData.Client.EntitySet("LedgerTransSettlements")]
    public partial class LedgerTransSettlement : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LedgerTransSettlement object.
        /// </summary>
        /// <param name="generalJournalAccountEntry">Initial value of GeneralJournalAccountEntry.</param>
        /// <param name="accountingCurrencyAmount">Initial value of AccountingCurrencyAmount.</param>
        /// <param name="documentDate">Initial value of DocumentDate.</param>
        /// <param name="accountingDate">Initial value of AccountingDate.</param>
        /// <param name="reportingCurrencyAmount">Initial value of ReportingCurrencyAmount.</param>
        /// <param name="transactionCurrencyAmount">Initial value of TransactionCurrencyAmount.</param>
        /// <param name="settleDate">Initial value of SettleDate.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="dateProcessed">Initial value of DateProcessed.</param>
        /// <param name="ledger">Initial value of Ledger.</param>
        /// <param name="mainAccount">Initial value of MainAccount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LedgerTransSettlement CreateLedgerTransSettlement(long generalJournalAccountEntry, 
                    decimal accountingCurrencyAmount, 
                    global::System.DateTimeOffset documentDate, 
                    global::System.DateTimeOffset accountingDate, 
                    decimal reportingCurrencyAmount, 
                    decimal transactionCurrencyAmount, 
                    global::System.DateTimeOffset settleDate, 
                    decimal quantity, 
                    global::System.DateTimeOffset dateProcessed, 
                    long ledger, 
                    long mainAccount)
        {
            LedgerTransSettlement ledgerTransSettlement = new LedgerTransSettlement();
            ledgerTransSettlement.GeneralJournalAccountEntry = generalJournalAccountEntry;
            ledgerTransSettlement.AccountingCurrencyAmount = accountingCurrencyAmount;
            ledgerTransSettlement.DocumentDate = documentDate;
            ledgerTransSettlement.AccountingDate = accountingDate;
            ledgerTransSettlement.ReportingCurrencyAmount = reportingCurrencyAmount;
            ledgerTransSettlement.TransactionCurrencyAmount = transactionCurrencyAmount;
            ledgerTransSettlement.SettleDate = settleDate;
            ledgerTransSettlement.Quantity = quantity;
            ledgerTransSettlement.DateProcessed = dateProcessed;
            ledgerTransSettlement.Ledger = ledger;
            ledgerTransSettlement.MainAccount = mainAccount;
            return ledgerTransSettlement;
        }
        /// <summary>
        /// There are no comments for Property GeneralJournalAccountEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long GeneralJournalAccountEntry
        {
            get
            {
                return this._GeneralJournalAccountEntry;
            }
            set
            {
                this.OnGeneralJournalAccountEntryChanging(value);
                this._GeneralJournalAccountEntry = value;
                this.OnGeneralJournalAccountEntryChanged();
                this.OnPropertyChanged("GeneralJournalAccountEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _GeneralJournalAccountEntry;
        partial void OnGeneralJournalAccountEntryChanging(long value);
        partial void OnGeneralJournalAccountEntryChanged();
        /// <summary>
        /// There are no comments for Property PostingType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerPostingType> PostingType
        {
            get
            {
                return this._PostingType;
            }
            set
            {
                this.OnPostingTypeChanging(value);
                this._PostingType = value;
                this.OnPostingTypeChanged();
                this.OnPropertyChanged("PostingType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerPostingType> _PostingType;
        partial void OnPostingTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerPostingType> value);
        partial void OnPostingTypeChanged();
        /// <summary>
        /// There are no comments for Property Marked in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Marked
        {
            get
            {
                return this._Marked;
            }
            set
            {
                this.OnMarkedChanging(value);
                this._Marked = value;
                this.OnMarkedChanged();
                this.OnPropertyChanged("Marked");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Marked;
        partial void OnMarkedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnMarkedChanged();
        /// <summary>
        /// There are no comments for Property AccountingCurrencyAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AccountingCurrencyAmount
        {
            get
            {
                return this._AccountingCurrencyAmount;
            }
            set
            {
                this.OnAccountingCurrencyAmountChanging(value);
                this._AccountingCurrencyAmount = value;
                this.OnAccountingCurrencyAmountChanged();
                this.OnPropertyChanged("AccountingCurrencyAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AccountingCurrencyAmount;
        partial void OnAccountingCurrencyAmountChanging(decimal value);
        partial void OnAccountingCurrencyAmountChanged();
        /// <summary>
        /// There are no comments for Property DocumentDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DocumentDate
        {
            get
            {
                return this._DocumentDate;
            }
            set
            {
                this.OnDocumentDateChanging(value);
                this._DocumentDate = value;
                this.OnDocumentDateChanged();
                this.OnPropertyChanged("DocumentDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DocumentDate;
        partial void OnDocumentDateChanging(global::System.DateTimeOffset value);
        partial void OnDocumentDateChanged();
        /// <summary>
        /// There are no comments for Property DocumentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DocumentNumber
        {
            get
            {
                return this._DocumentNumber;
            }
            set
            {
                this.OnDocumentNumberChanging(value);
                this._DocumentNumber = value;
                this.OnDocumentNumberChanged();
                this.OnPropertyChanged("DocumentNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentNumber;
        partial void OnDocumentNumberChanging(string value);
        partial void OnDocumentNumberChanged();
        /// <summary>
        /// There are no comments for Property TransactionCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TransactionCurrencyCode
        {
            get
            {
                return this._TransactionCurrencyCode;
            }
            set
            {
                this.OnTransactionCurrencyCodeChanging(value);
                this._TransactionCurrencyCode = value;
                this.OnTransactionCurrencyCodeChanged();
                this.OnPropertyChanged("TransactionCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionCurrencyCode;
        partial void OnTransactionCurrencyCodeChanging(string value);
        partial void OnTransactionCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property AccountingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset AccountingDate
        {
            get
            {
                return this._AccountingDate;
            }
            set
            {
                this.OnAccountingDateChanging(value);
                this._AccountingDate = value;
                this.OnAccountingDateChanged();
                this.OnPropertyChanged("AccountingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AccountingDate;
        partial void OnAccountingDateChanging(global::System.DateTimeOffset value);
        partial void OnAccountingDateChanged();
        /// <summary>
        /// There are no comments for Property LedgerAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LedgerAccountDisplayValue
        {
            get
            {
                return this._LedgerAccountDisplayValue;
            }
            set
            {
                this.OnLedgerAccountDisplayValueChanging(value);
                this._LedgerAccountDisplayValue = value;
                this.OnLedgerAccountDisplayValueChanged();
                this.OnPropertyChanged("LedgerAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerAccountDisplayValue;
        partial void OnLedgerAccountDisplayValueChanging(string value);
        partial void OnLedgerAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property SubledgerVoucher in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SubledgerVoucher
        {
            get
            {
                return this._SubledgerVoucher;
            }
            set
            {
                this.OnSubledgerVoucherChanging(value);
                this._SubledgerVoucher = value;
                this.OnSubledgerVoucherChanged();
                this.OnPropertyChanged("SubledgerVoucher");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SubledgerVoucher;
        partial void OnSubledgerVoucherChanging(string value);
        partial void OnSubledgerVoucherChanged();
        /// <summary>
        /// There are no comments for Property Text in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Text
        {
            get
            {
                return this._Text;
            }
            set
            {
                this.OnTextChanging(value);
                this._Text = value;
                this.OnTextChanged();
                this.OnPropertyChanged("Text");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Text;
        partial void OnTextChanging(string value);
        partial void OnTextChanged();
        /// <summary>
        /// There are no comments for Property ReportingCurrencyAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReportingCurrencyAmount
        {
            get
            {
                return this._ReportingCurrencyAmount;
            }
            set
            {
                this.OnReportingCurrencyAmountChanging(value);
                this._ReportingCurrencyAmount = value;
                this.OnReportingCurrencyAmountChanged();
                this.OnPropertyChanged("ReportingCurrencyAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReportingCurrencyAmount;
        partial void OnReportingCurrencyAmountChanging(decimal value);
        partial void OnReportingCurrencyAmountChanged();
        /// <summary>
        /// There are no comments for Property TransactionCurrencyAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TransactionCurrencyAmount
        {
            get
            {
                return this._TransactionCurrencyAmount;
            }
            set
            {
                this.OnTransactionCurrencyAmountChanging(value);
                this._TransactionCurrencyAmount = value;
                this.OnTransactionCurrencyAmountChanged();
                this.OnPropertyChanged("TransactionCurrencyAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TransactionCurrencyAmount;
        partial void OnTransactionCurrencyAmountChanging(decimal value);
        partial void OnTransactionCurrencyAmountChanged();
        /// <summary>
        /// There are no comments for Property SettleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SettleId
        {
            get
            {
                return this._SettleId;
            }
            set
            {
                this.OnSettleIdChanging(value);
                this._SettleId = value;
                this.OnSettleIdChanged();
                this.OnPropertyChanged("SettleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SettleId;
        partial void OnSettleIdChanging(string value);
        partial void OnSettleIdChanged();
        /// <summary>
        /// There are no comments for Property SettleDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset SettleDate
        {
            get
            {
                return this._SettleDate;
            }
            set
            {
                this.OnSettleDateChanging(value);
                this._SettleDate = value;
                this.OnSettleDateChanged();
                this.OnPropertyChanged("SettleDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _SettleDate;
        partial void OnSettleDateChanging(global::System.DateTimeOffset value);
        partial void OnSettleDateChanged();
        /// <summary>
        /// There are no comments for Property JournalNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalNumber
        {
            get
            {
                return this._JournalNumber;
            }
            set
            {
                this.OnJournalNumberChanging(value);
                this._JournalNumber = value;
                this.OnJournalNumberChanged();
                this.OnPropertyChanged("JournalNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalNumber;
        partial void OnJournalNumberChanging(string value);
        partial void OnJournalNumberChanged();
        /// <summary>
        /// There are no comments for Property PostingLayer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> PostingLayer
        {
            get
            {
                return this._PostingLayer;
            }
            set
            {
                this.OnPostingLayerChanging(value);
                this._PostingLayer = value;
                this.OnPostingLayerChanged();
                this.OnPropertyChanged("PostingLayer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> _PostingLayer;
        partial void OnPostingLayerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> value);
        partial void OnPostingLayerChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Quantity;
        partial void OnQuantityChanging(decimal value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property DateProcessed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DateProcessed
        {
            get
            {
                return this._DateProcessed;
            }
            set
            {
                this.OnDateProcessedChanging(value);
                this._DateProcessed = value;
                this.OnDateProcessedChanged();
                this.OnPropertyChanged("DateProcessed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateProcessed;
        partial void OnDateProcessedChanging(global::System.DateTimeOffset value);
        partial void OnDateProcessedChanged();
        /// <summary>
        /// There are no comments for Property Ledger in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long Ledger
        {
            get
            {
                return this._Ledger;
            }
            set
            {
                this.OnLedgerChanging(value);
                this._Ledger = value;
                this.OnLedgerChanged();
                this.OnPropertyChanged("Ledger");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _Ledger;
        partial void OnLedgerChanging(long value);
        partial void OnLedgerChanged();
        /// <summary>
        /// There are no comments for Property MainAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long MainAccount
        {
            get
            {
                return this._MainAccount;
            }
            set
            {
                this.OnMainAccountChanging(value);
                this._MainAccount = value;
                this.OnMainAccountChanged();
                this.OnPropertyChanged("MainAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _MainAccount;
        partial void OnMainAccountChanging(long value);
        partial void OnMainAccountChanged();
        /// <summary>
        /// There are no comments for Property LedgerDimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination LedgerDimensionCombination
        {
            get
            {
                return this._LedgerDimensionCombination;
            }
            set
            {
                this.OnLedgerDimensionCombinationChanging(value);
                this._LedgerDimensionCombination = value;
                this.OnLedgerDimensionCombinationChanged();
                this.OnPropertyChanged("LedgerDimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _LedgerDimensionCombination;
        partial void OnLedgerDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnLedgerDimensionCombinationChanged();
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
