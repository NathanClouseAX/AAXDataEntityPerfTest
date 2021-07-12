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
        /// There are no comments for RetailTransactionAuditableDiscountLineSingle in the schema.
        /// </summary>
    public partial class RetailTransactionAuditableDiscountLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTransactionAuditableDiscountLine>
    {
        /// <summary>
        /// Initialize a new RetailTransactionAuditableDiscountLineSingle object.
        /// </summary>
        public RetailTransactionAuditableDiscountLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTransactionAuditableDiscountLineSingle object.
        /// </summary>
        public RetailTransactionAuditableDiscountLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTransactionAuditableDiscountLineSingle object.
        /// </summary>
        public RetailTransactionAuditableDiscountLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTransactionAuditableDiscountLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailTransactionAuditableSalesLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLineSingle RetailTransactionAuditableSalesLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTransactionAuditableSalesLine == null))
                {
                    this._RetailTransactionAuditableSalesLine = new global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLineSingle(this.Context, GetPath("RetailTransactionAuditableSalesLine"));
                }
                return this._RetailTransactionAuditableSalesLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLineSingle _RetailTransactionAuditableSalesLine;
        /// <summary>
        /// There are no comments for RetailTransactionAuditable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSingle RetailTransactionAuditable
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTransactionAuditable == null))
                {
                    this._RetailTransactionAuditable = new global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSingle(this.Context, GetPath("RetailTransactionAuditable"));
                }
                return this._RetailTransactionAuditable;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSingle _RetailTransactionAuditable;
    }
        /// <summary>
        /// There are no comments for RetailTransactionAuditableDiscountLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// OperatingUnitNumber
    /// StoreNumber
    /// RegisterNumber
    /// TransactionId
    /// SalesLineNumber
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "OperatingUnitNumber", "StoreNumber", "RegisterNumber", "TransactionId", "SalesLineNumber", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailTransactionAuditableDiscountLines")]
    public partial class RetailTransactionAuditableDiscountLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTransactionAuditableDiscountLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="operatingUnitNumber">Initial value of OperatingUnitNumber.</param>
        /// <param name="storeNumber">Initial value of StoreNumber.</param>
        /// <param name="registerNumber">Initial value of RegisterNumber.</param>
        /// <param name="transactionId">Initial value of TransactionId.</param>
        /// <param name="salesLineNumber">Initial value of SalesLineNumber.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="discountAmount">Initial value of DiscountAmount.</param>
        /// <param name="discountCost">Initial value of DiscountCost.</param>
        /// <param name="percentage">Initial value of Percentage.</param>
        /// <param name="bundleId">Initial value of BundleId.</param>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="dealPrice">Initial value of DealPrice.</param>
        /// <param name="retailTransactionAuditableSalesLine">Initial value of RetailTransactionAuditableSalesLine.</param>
        /// <param name="retailTransactionAuditable">Initial value of RetailTransactionAuditable.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTransactionAuditableDiscountLine CreateRetailTransactionAuditableDiscountLine(string dataAreaId, 
                    string operatingUnitNumber, 
                    string storeNumber, 
                    string registerNumber, 
                    string transactionId, 
                    decimal salesLineNumber, 
                    decimal lineNumber, 
                    decimal discountAmount, 
                    decimal discountCost, 
                    decimal percentage, 
                    int bundleId, 
                    decimal amount, 
                    decimal dealPrice, 
                    global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLine retailTransactionAuditableSalesLine, 
                    global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditable retailTransactionAuditable)
        {
            RetailTransactionAuditableDiscountLine retailTransactionAuditableDiscountLine = new RetailTransactionAuditableDiscountLine();
            retailTransactionAuditableDiscountLine.dataAreaId = dataAreaId;
            retailTransactionAuditableDiscountLine.OperatingUnitNumber = operatingUnitNumber;
            retailTransactionAuditableDiscountLine.StoreNumber = storeNumber;
            retailTransactionAuditableDiscountLine.RegisterNumber = registerNumber;
            retailTransactionAuditableDiscountLine.TransactionId = transactionId;
            retailTransactionAuditableDiscountLine.SalesLineNumber = salesLineNumber;
            retailTransactionAuditableDiscountLine.LineNumber = lineNumber;
            retailTransactionAuditableDiscountLine.DiscountAmount = discountAmount;
            retailTransactionAuditableDiscountLine.DiscountCost = discountCost;
            retailTransactionAuditableDiscountLine.Percentage = percentage;
            retailTransactionAuditableDiscountLine.BundleId = bundleId;
            retailTransactionAuditableDiscountLine.Amount = amount;
            retailTransactionAuditableDiscountLine.DealPrice = dealPrice;
            if ((retailTransactionAuditableSalesLine == null))
            {
                throw new global::System.ArgumentNullException("retailTransactionAuditableSalesLine");
            }
            retailTransactionAuditableDiscountLine.RetailTransactionAuditableSalesLine = retailTransactionAuditableSalesLine;
            if ((retailTransactionAuditable == null))
            {
                throw new global::System.ArgumentNullException("retailTransactionAuditable");
            }
            retailTransactionAuditableDiscountLine.RetailTransactionAuditable = retailTransactionAuditable;
            return retailTransactionAuditableDiscountLine;
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
        /// There are no comments for Property OperatingUnitNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OperatingUnitNumber
        {
            get
            {
                return this._OperatingUnitNumber;
            }
            set
            {
                this.OnOperatingUnitNumberChanging(value);
                this._OperatingUnitNumber = value;
                this.OnOperatingUnitNumberChanged();
                this.OnPropertyChanged("OperatingUnitNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperatingUnitNumber;
        partial void OnOperatingUnitNumberChanging(string value);
        partial void OnOperatingUnitNumberChanged();
        /// <summary>
        /// There are no comments for Property StoreNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string StoreNumber
        {
            get
            {
                return this._StoreNumber;
            }
            set
            {
                this.OnStoreNumberChanging(value);
                this._StoreNumber = value;
                this.OnStoreNumberChanged();
                this.OnPropertyChanged("StoreNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreNumber;
        partial void OnStoreNumberChanging(string value);
        partial void OnStoreNumberChanged();
        /// <summary>
        /// There are no comments for Property RegisterNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RegisterNumber
        {
            get
            {
                return this._RegisterNumber;
            }
            set
            {
                this.OnRegisterNumberChanging(value);
                this._RegisterNumber = value;
                this.OnRegisterNumberChanged();
                this.OnPropertyChanged("RegisterNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegisterNumber;
        partial void OnRegisterNumberChanging(string value);
        partial void OnRegisterNumberChanged();
        /// <summary>
        /// There are no comments for Property TransactionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TransactionId
        {
            get
            {
                return this._TransactionId;
            }
            set
            {
                this.OnTransactionIdChanging(value);
                this._TransactionId = value;
                this.OnTransactionIdChanged();
                this.OnPropertyChanged("TransactionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionId;
        partial void OnTransactionIdChanging(string value);
        partial void OnTransactionIdChanged();
        /// <summary>
        /// There are no comments for Property SalesLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SalesLineNumber
        {
            get
            {
                return this._SalesLineNumber;
            }
            set
            {
                this.OnSalesLineNumberChanging(value);
                this._SalesLineNumber = value;
                this.OnSalesLineNumberChanged();
                this.OnPropertyChanged("SalesLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SalesLineNumber;
        partial void OnSalesLineNumberChanging(decimal value);
        partial void OnSalesLineNumberChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property DiscountAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DiscountAmount
        {
            get
            {
                return this._DiscountAmount;
            }
            set
            {
                this.OnDiscountAmountChanging(value);
                this._DiscountAmount = value;
                this.OnDiscountAmountChanged();
                this.OnPropertyChanged("DiscountAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DiscountAmount;
        partial void OnDiscountAmountChanging(decimal value);
        partial void OnDiscountAmountChanged();
        /// <summary>
        /// There are no comments for Property PeriodicDiscountOfferId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PeriodicDiscountOfferId
        {
            get
            {
                return this._PeriodicDiscountOfferId;
            }
            set
            {
                this.OnPeriodicDiscountOfferIdChanging(value);
                this._PeriodicDiscountOfferId = value;
                this.OnPeriodicDiscountOfferIdChanged();
                this.OnPropertyChanged("PeriodicDiscountOfferId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PeriodicDiscountOfferId;
        partial void OnPeriodicDiscountOfferIdChanging(string value);
        partial void OnPeriodicDiscountOfferIdChanged();
        /// <summary>
        /// There are no comments for Property HeaderAsynchronousOrderStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionOrderStatusType> HeaderAsynchronousOrderStatus
        {
            get
            {
                return this._HeaderAsynchronousOrderStatus;
            }
            set
            {
                this.OnHeaderAsynchronousOrderStatusChanging(value);
                this._HeaderAsynchronousOrderStatus = value;
                this.OnHeaderAsynchronousOrderStatusChanged();
                this.OnPropertyChanged("HeaderAsynchronousOrderStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionOrderStatusType> _HeaderAsynchronousOrderStatus;
        partial void OnHeaderAsynchronousOrderStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionOrderStatusType> value);
        partial void OnHeaderAsynchronousOrderStatusChanged();
        /// <summary>
        /// There are no comments for Property DiscountCost in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DiscountCost
        {
            get
            {
                return this._DiscountCost;
            }
            set
            {
                this.OnDiscountCostChanging(value);
                this._DiscountCost = value;
                this.OnDiscountCostChanged();
                this.OnPropertyChanged("DiscountCost");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DiscountCost;
        partial void OnDiscountCostChanging(decimal value);
        partial void OnDiscountCostChanged();
        /// <summary>
        /// There are no comments for Property Percentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Percentage
        {
            get
            {
                return this._Percentage;
            }
            set
            {
                this.OnPercentageChanging(value);
                this._Percentage = value;
                this.OnPercentageChanged();
                this.OnPropertyChanged("Percentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Percentage;
        partial void OnPercentageChanging(decimal value);
        partial void OnPercentageChanged();
        /// <summary>
        /// There are no comments for Property HeaderTransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionType> HeaderTransactionType
        {
            get
            {
                return this._HeaderTransactionType;
            }
            set
            {
                this.OnHeaderTransactionTypeChanging(value);
                this._HeaderTransactionType = value;
                this.OnHeaderTransactionTypeChanged();
                this.OnPropertyChanged("HeaderTransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionType> _HeaderTransactionType;
        partial void OnHeaderTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionType> value);
        partial void OnHeaderTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property DiscountOriginType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDiscountOriginType> DiscountOriginType
        {
            get
            {
                return this._DiscountOriginType;
            }
            set
            {
                this.OnDiscountOriginTypeChanging(value);
                this._DiscountOriginType = value;
                this.OnDiscountOriginTypeChanged();
                this.OnPropertyChanged("DiscountOriginType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDiscountOriginType> _DiscountOriginType;
        partial void OnDiscountOriginTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDiscountOriginType> value);
        partial void OnDiscountOriginTypeChanged();
        /// <summary>
        /// There are no comments for Property HeaderValidationStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionValidationStatus> HeaderValidationStatus
        {
            get
            {
                return this._HeaderValidationStatus;
            }
            set
            {
                this.OnHeaderValidationStatusChanging(value);
                this._HeaderValidationStatus = value;
                this.OnHeaderValidationStatusChanged();
                this.OnPropertyChanged("HeaderValidationStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionValidationStatus> _HeaderValidationStatus;
        partial void OnHeaderValidationStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionValidationStatus> value);
        partial void OnHeaderValidationStatusChanged();
        /// <summary>
        /// There are no comments for Property CustomerDiscountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCustomerDiscountType> CustomerDiscountType
        {
            get
            {
                return this._CustomerDiscountType;
            }
            set
            {
                this.OnCustomerDiscountTypeChanging(value);
                this._CustomerDiscountType = value;
                this.OnCustomerDiscountTypeChanged();
                this.OnPropertyChanged("CustomerDiscountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCustomerDiscountType> _CustomerDiscountType;
        partial void OnCustomerDiscountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCustomerDiscountType> value);
        partial void OnCustomerDiscountTypeChanged();
        /// <summary>
        /// There are no comments for Property BundleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int BundleId
        {
            get
            {
                return this._BundleId;
            }
            set
            {
                this.OnBundleIdChanging(value);
                this._BundleId = value;
                this.OnBundleIdChanged();
                this.OnPropertyChanged("BundleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _BundleId;
        partial void OnBundleIdChanging(int value);
        partial void OnBundleIdChanged();
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Amount;
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
        /// <summary>
        /// There are no comments for Property ManualDiscountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailManualDiscountType> ManualDiscountType
        {
            get
            {
                return this._ManualDiscountType;
            }
            set
            {
                this.OnManualDiscountTypeChanging(value);
                this._ManualDiscountType = value;
                this.OnManualDiscountTypeChanged();
                this.OnPropertyChanged("ManualDiscountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailManualDiscountType> _ManualDiscountType;
        partial void OnManualDiscountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailManualDiscountType> value);
        partial void OnManualDiscountTypeChanged();
        /// <summary>
        /// There are no comments for Property HeaderStoreNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string HeaderStoreNumber
        {
            get
            {
                return this._HeaderStoreNumber;
            }
            set
            {
                this.OnHeaderStoreNumberChanging(value);
                this._HeaderStoreNumber = value;
                this.OnHeaderStoreNumberChanged();
                this.OnPropertyChanged("HeaderStoreNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HeaderStoreNumber;
        partial void OnHeaderStoreNumberChanging(string value);
        partial void OnHeaderStoreNumberChanged();
        /// <summary>
        /// There are no comments for Property HeaderStatementNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string HeaderStatementNumber
        {
            get
            {
                return this._HeaderStatementNumber;
            }
            set
            {
                this.OnHeaderStatementNumberChanging(value);
                this._HeaderStatementNumber = value;
                this.OnHeaderStatementNumberChanged();
                this.OnPropertyChanged("HeaderStatementNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HeaderStatementNumber;
        partial void OnHeaderStatementNumberChanging(string value);
        partial void OnHeaderStatementNumberChanged();
        /// <summary>
        /// There are no comments for Property DealPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DealPrice
        {
            get
            {
                return this._DealPrice;
            }
            set
            {
                this.OnDealPriceChanging(value);
                this._DealPrice = value;
                this.OnDealPriceChanged();
                this.OnPropertyChanged("DealPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DealPrice;
        partial void OnDealPriceChanging(decimal value);
        partial void OnDealPriceChanged();
        /// <summary>
        /// There are no comments for Property RetailTransactionAuditableSalesLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLine RetailTransactionAuditableSalesLine
        {
            get
            {
                return this._RetailTransactionAuditableSalesLine;
            }
            set
            {
                this.OnRetailTransactionAuditableSalesLineChanging(value);
                this._RetailTransactionAuditableSalesLine = value;
                this.OnRetailTransactionAuditableSalesLineChanged();
                this.OnPropertyChanged("RetailTransactionAuditableSalesLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLine _RetailTransactionAuditableSalesLine;
        partial void OnRetailTransactionAuditableSalesLineChanging(global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLine value);
        partial void OnRetailTransactionAuditableSalesLineChanged();
        /// <summary>
        /// There are no comments for Property RetailTransactionAuditable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditable RetailTransactionAuditable
        {
            get
            {
                return this._RetailTransactionAuditable;
            }
            set
            {
                this.OnRetailTransactionAuditableChanging(value);
                this._RetailTransactionAuditable = value;
                this.OnRetailTransactionAuditableChanged();
                this.OnPropertyChanged("RetailTransactionAuditable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditable _RetailTransactionAuditable;
        partial void OnRetailTransactionAuditableChanging(global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditable value);
        partial void OnRetailTransactionAuditableChanged();
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
