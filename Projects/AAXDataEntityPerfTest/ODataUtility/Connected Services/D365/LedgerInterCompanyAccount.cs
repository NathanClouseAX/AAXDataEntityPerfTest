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
        /// There are no comments for LedgerInterCompanyAccountSingle in the schema.
        /// </summary>
    public partial class LedgerInterCompanyAccountSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerInterCompanyAccount>
    {
        /// <summary>
        /// Initialize a new LedgerInterCompanyAccountSingle object.
        /// </summary>
        public LedgerInterCompanyAccountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LedgerInterCompanyAccountSingle object.
        /// </summary>
        public LedgerInterCompanyAccountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LedgerInterCompanyAccountSingle object.
        /// </summary>
        public LedgerInterCompanyAccountSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerInterCompanyAccount> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LedgerInterCompanyAccountSourceCreditDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle LedgerInterCompanyAccountSourceCreditDimension
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerInterCompanyAccountSourceCreditDimension == null))
                {
                    this._LedgerInterCompanyAccountSourceCreditDimension = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("LedgerInterCompanyAccountSourceCreditDimension"));
                }
                return this._LedgerInterCompanyAccountSourceCreditDimension;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _LedgerInterCompanyAccountSourceCreditDimension;
        /// <summary>
        /// There are no comments for LedgerInterCompanyAccountDestinationCreditDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle LedgerInterCompanyAccountDestinationCreditDimension
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerInterCompanyAccountDestinationCreditDimension == null))
                {
                    this._LedgerInterCompanyAccountDestinationCreditDimension = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("LedgerInterCompanyAccountDestinationCreditDimension"));
                }
                return this._LedgerInterCompanyAccountDestinationCreditDimension;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _LedgerInterCompanyAccountDestinationCreditDimension;
        /// <summary>
        /// There are no comments for LedgerInterCompanyAccountDestinationDebitDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle LedgerInterCompanyAccountDestinationDebitDimension
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerInterCompanyAccountDestinationDebitDimension == null))
                {
                    this._LedgerInterCompanyAccountDestinationDebitDimension = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("LedgerInterCompanyAccountDestinationDebitDimension"));
                }
                return this._LedgerInterCompanyAccountDestinationDebitDimension;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _LedgerInterCompanyAccountDestinationDebitDimension;
        /// <summary>
        /// There are no comments for LedgerIntercompanyJournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JournalNameSingle LedgerIntercompanyJournalName
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerIntercompanyJournalName == null))
                {
                    this._LedgerIntercompanyJournalName = new global::Microsoft.Dynamics.DataEntities.JournalNameSingle(this.Context, GetPath("LedgerIntercompanyJournalName"));
                }
                return this._LedgerIntercompanyJournalName;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JournalNameSingle _LedgerIntercompanyJournalName;
        /// <summary>
        /// There are no comments for LedgerInterCompanyAccountSourceDebitDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle LedgerInterCompanyAccountSourceDebitDimension
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerInterCompanyAccountSourceDebitDimension == null))
                {
                    this._LedgerInterCompanyAccountSourceDebitDimension = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("LedgerInterCompanyAccountSourceDebitDimension"));
                }
                return this._LedgerInterCompanyAccountSourceDebitDimension;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _LedgerInterCompanyAccountSourceDebitDimension;
    }
        /// <summary>
        /// There are no comments for LedgerInterCompanyAccount in the schema.
        /// </summary>
    /// <KeyProperties>
    /// OriginatingLegalEntityId
    /// DestinationLegalEntityId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("OriginatingLegalEntityId", "DestinationLegalEntityId")]
    [global::Microsoft.OData.Client.EntitySet("LedgerInterCompanyAccounts")]
    public partial class LedgerInterCompanyAccount : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LedgerInterCompanyAccount object.
        /// </summary>
        /// <param name="originatingLegalEntityId">Initial value of OriginatingLegalEntityId.</param>
        /// <param name="destinationLegalEntityId">Initial value of DestinationLegalEntityId.</param>
        /// <param name="ledgerIntercompanyJournalName">Initial value of LedgerIntercompanyJournalName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LedgerInterCompanyAccount CreateLedgerInterCompanyAccount(string originatingLegalEntityId, string destinationLegalEntityId, global::Microsoft.Dynamics.DataEntities.JournalName ledgerIntercompanyJournalName)
        {
            LedgerInterCompanyAccount ledgerInterCompanyAccount = new LedgerInterCompanyAccount();
            ledgerInterCompanyAccount.OriginatingLegalEntityId = originatingLegalEntityId;
            ledgerInterCompanyAccount.DestinationLegalEntityId = destinationLegalEntityId;
            if ((ledgerIntercompanyJournalName == null))
            {
                throw new global::System.ArgumentNullException("ledgerIntercompanyJournalName");
            }
            ledgerInterCompanyAccount.LedgerIntercompanyJournalName = ledgerIntercompanyJournalName;
            return ledgerInterCompanyAccount;
        }
        /// <summary>
        /// There are no comments for Property OriginatingLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OriginatingLegalEntityId
        {
            get
            {
                return this._OriginatingLegalEntityId;
            }
            set
            {
                this.OnOriginatingLegalEntityIdChanging(value);
                this._OriginatingLegalEntityId = value;
                this.OnOriginatingLegalEntityIdChanged();
                this.OnPropertyChanged("OriginatingLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OriginatingLegalEntityId;
        partial void OnOriginatingLegalEntityIdChanging(string value);
        partial void OnOriginatingLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property DestinationLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DestinationLegalEntityId
        {
            get
            {
                return this._DestinationLegalEntityId;
            }
            set
            {
                this.OnDestinationLegalEntityIdChanging(value);
                this._DestinationLegalEntityId = value;
                this.OnDestinationLegalEntityIdChanged();
                this.OnPropertyChanged("DestinationLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DestinationLegalEntityId;
        partial void OnDestinationLegalEntityIdChanging(string value);
        partial void OnDestinationLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property VendorPaymentPostFinancialInterest in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> VendorPaymentPostFinancialInterest
        {
            get
            {
                return this._VendorPaymentPostFinancialInterest;
            }
            set
            {
                this.OnVendorPaymentPostFinancialInterestChanging(value);
                this._VendorPaymentPostFinancialInterest = value;
                this.OnVendorPaymentPostFinancialInterestChanged();
                this.OnPropertyChanged("VendorPaymentPostFinancialInterest");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> _VendorPaymentPostFinancialInterest;
        partial void OnVendorPaymentPostFinancialInterestChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> value);
        partial void OnVendorPaymentPostFinancialInterestChanged();
        /// <summary>
        /// There are no comments for Property OriginatingDebitAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OriginatingDebitAccountDisplayValue
        {
            get
            {
                return this._OriginatingDebitAccountDisplayValue;
            }
            set
            {
                this.OnOriginatingDebitAccountDisplayValueChanging(value);
                this._OriginatingDebitAccountDisplayValue = value;
                this.OnOriginatingDebitAccountDisplayValueChanged();
                this.OnPropertyChanged("OriginatingDebitAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OriginatingDebitAccountDisplayValue;
        partial void OnOriginatingDebitAccountDisplayValueChanging(string value);
        partial void OnOriginatingDebitAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property PostInterest in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> PostInterest
        {
            get
            {
                return this._PostInterest;
            }
            set
            {
                this.OnPostInterestChanging(value);
                this._PostInterest = value;
                this.OnPostInterestChanged();
                this.OnPropertyChanged("PostInterest");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> _PostInterest;
        partial void OnPostInterestChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> value);
        partial void OnPostInterestChanged();
        /// <summary>
        /// There are no comments for Property PostCurrencyExchangeGainOrLoss in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> PostCurrencyExchangeGainOrLoss
        {
            get
            {
                return this._PostCurrencyExchangeGainOrLoss;
            }
            set
            {
                this.OnPostCurrencyExchangeGainOrLossChanging(value);
                this._PostCurrencyExchangeGainOrLoss = value;
                this.OnPostCurrencyExchangeGainOrLossChanged();
                this.OnPropertyChanged("PostCurrencyExchangeGainOrLoss");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> _PostCurrencyExchangeGainOrLoss;
        partial void OnPostCurrencyExchangeGainOrLossChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> value);
        partial void OnPostCurrencyExchangeGainOrLossChanged();
        /// <summary>
        /// There are no comments for Property DestinationCreditAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DestinationCreditAccountDisplayValue
        {
            get
            {
                return this._DestinationCreditAccountDisplayValue;
            }
            set
            {
                this.OnDestinationCreditAccountDisplayValueChanging(value);
                this._DestinationCreditAccountDisplayValue = value;
                this.OnDestinationCreditAccountDisplayValueChanged();
                this.OnPropertyChanged("DestinationCreditAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DestinationCreditAccountDisplayValue;
        partial void OnDestinationCreditAccountDisplayValueChanging(string value);
        partial void OnDestinationCreditAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property Journal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Journal
        {
            get
            {
                return this._Journal;
            }
            set
            {
                this.OnJournalChanging(value);
                this._Journal = value;
                this.OnJournalChanged();
                this.OnPropertyChanged("Journal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Journal;
        partial void OnJournalChanging(string value);
        partial void OnJournalChanged();
        /// <summary>
        /// There are no comments for Property VendorPaymentPostFine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> VendorPaymentPostFine
        {
            get
            {
                return this._VendorPaymentPostFine;
            }
            set
            {
                this.OnVendorPaymentPostFineChanging(value);
                this._VendorPaymentPostFine = value;
                this.OnVendorPaymentPostFineChanged();
                this.OnPropertyChanged("VendorPaymentPostFine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> _VendorPaymentPostFine;
        partial void OnVendorPaymentPostFineChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> value);
        partial void OnVendorPaymentPostFineChanged();
        /// <summary>
        /// There are no comments for Property DestinationDebitAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DestinationDebitAccountDisplayValue
        {
            get
            {
                return this._DestinationDebitAccountDisplayValue;
            }
            set
            {
                this.OnDestinationDebitAccountDisplayValueChanging(value);
                this._DestinationDebitAccountDisplayValue = value;
                this.OnDestinationDebitAccountDisplayValueChanged();
                this.OnPropertyChanged("DestinationDebitAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DestinationDebitAccountDisplayValue;
        partial void OnDestinationDebitAccountDisplayValueChanging(string value);
        partial void OnDestinationDebitAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property OriginatingCreditAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OriginatingCreditAccountDisplayValue
        {
            get
            {
                return this._OriginatingCreditAccountDisplayValue;
            }
            set
            {
                this.OnOriginatingCreditAccountDisplayValueChanging(value);
                this._OriginatingCreditAccountDisplayValue = value;
                this.OnOriginatingCreditAccountDisplayValueChanged();
                this.OnPropertyChanged("OriginatingCreditAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OriginatingCreditAccountDisplayValue;
        partial void OnOriginatingCreditAccountDisplayValueChanging(string value);
        partial void OnOriginatingCreditAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property PostCashDiscount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> PostCashDiscount
        {
            get
            {
                return this._PostCashDiscount;
            }
            set
            {
                this.OnPostCashDiscountChanging(value);
                this._PostCashDiscount = value;
                this.OnPostCashDiscountChanged();
                this.OnPropertyChanged("PostCashDiscount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> _PostCashDiscount;
        partial void OnPostCashDiscountChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> value);
        partial void OnPostCashDiscountChanged();
        /// <summary>
        /// There are no comments for Property PostFine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> PostFine
        {
            get
            {
                return this._PostFine;
            }
            set
            {
                this.OnPostFineChanging(value);
                this._PostFine = value;
                this.OnPostFineChanged();
                this.OnPropertyChanged("PostFine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> _PostFine;
        partial void OnPostFineChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendSettleCompanyPostOption> value);
        partial void OnPostFineChanged();
        /// <summary>
        /// There are no comments for Property LedgerInterCompanyAccountSourceCreditDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination LedgerInterCompanyAccountSourceCreditDimension
        {
            get
            {
                return this._LedgerInterCompanyAccountSourceCreditDimension;
            }
            set
            {
                this.OnLedgerInterCompanyAccountSourceCreditDimensionChanging(value);
                this._LedgerInterCompanyAccountSourceCreditDimension = value;
                this.OnLedgerInterCompanyAccountSourceCreditDimensionChanged();
                this.OnPropertyChanged("LedgerInterCompanyAccountSourceCreditDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _LedgerInterCompanyAccountSourceCreditDimension;
        partial void OnLedgerInterCompanyAccountSourceCreditDimensionChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnLedgerInterCompanyAccountSourceCreditDimensionChanged();
        /// <summary>
        /// There are no comments for Property LedgerInterCompanyAccountDestinationCreditDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination LedgerInterCompanyAccountDestinationCreditDimension
        {
            get
            {
                return this._LedgerInterCompanyAccountDestinationCreditDimension;
            }
            set
            {
                this.OnLedgerInterCompanyAccountDestinationCreditDimensionChanging(value);
                this._LedgerInterCompanyAccountDestinationCreditDimension = value;
                this.OnLedgerInterCompanyAccountDestinationCreditDimensionChanged();
                this.OnPropertyChanged("LedgerInterCompanyAccountDestinationCreditDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _LedgerInterCompanyAccountDestinationCreditDimension;
        partial void OnLedgerInterCompanyAccountDestinationCreditDimensionChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnLedgerInterCompanyAccountDestinationCreditDimensionChanged();
        /// <summary>
        /// There are no comments for Property LedgerInterCompanyAccountDestinationDebitDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination LedgerInterCompanyAccountDestinationDebitDimension
        {
            get
            {
                return this._LedgerInterCompanyAccountDestinationDebitDimension;
            }
            set
            {
                this.OnLedgerInterCompanyAccountDestinationDebitDimensionChanging(value);
                this._LedgerInterCompanyAccountDestinationDebitDimension = value;
                this.OnLedgerInterCompanyAccountDestinationDebitDimensionChanged();
                this.OnPropertyChanged("LedgerInterCompanyAccountDestinationDebitDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _LedgerInterCompanyAccountDestinationDebitDimension;
        partial void OnLedgerInterCompanyAccountDestinationDebitDimensionChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnLedgerInterCompanyAccountDestinationDebitDimensionChanged();
        /// <summary>
        /// There are no comments for Property LedgerIntercompanyJournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JournalName LedgerIntercompanyJournalName
        {
            get
            {
                return this._LedgerIntercompanyJournalName;
            }
            set
            {
                this.OnLedgerIntercompanyJournalNameChanging(value);
                this._LedgerIntercompanyJournalName = value;
                this.OnLedgerIntercompanyJournalNameChanged();
                this.OnPropertyChanged("LedgerIntercompanyJournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JournalName _LedgerIntercompanyJournalName;
        partial void OnLedgerIntercompanyJournalNameChanging(global::Microsoft.Dynamics.DataEntities.JournalName value);
        partial void OnLedgerIntercompanyJournalNameChanged();
        /// <summary>
        /// There are no comments for Property LedgerInterCompanyAccountSourceDebitDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination LedgerInterCompanyAccountSourceDebitDimension
        {
            get
            {
                return this._LedgerInterCompanyAccountSourceDebitDimension;
            }
            set
            {
                this.OnLedgerInterCompanyAccountSourceDebitDimensionChanging(value);
                this._LedgerInterCompanyAccountSourceDebitDimension = value;
                this.OnLedgerInterCompanyAccountSourceDebitDimensionChanged();
                this.OnPropertyChanged("LedgerInterCompanyAccountSourceDebitDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _LedgerInterCompanyAccountSourceDebitDimension;
        partial void OnLedgerInterCompanyAccountSourceDebitDimensionChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnLedgerInterCompanyAccountSourceDebitDimensionChanged();
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
