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
        /// There are no comments for RetailTransactionAuditableTaxLineSingle in the schema.
        /// </summary>
    public partial class RetailTransactionAuditableTaxLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTransactionAuditableTaxLine>
    {
        /// <summary>
        /// Initialize a new RetailTransactionAuditableTaxLineSingle object.
        /// </summary>
        public RetailTransactionAuditableTaxLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTransactionAuditableTaxLineSingle object.
        /// </summary>
        public RetailTransactionAuditableTaxLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTransactionAuditableTaxLineSingle object.
        /// </summary>
        public RetailTransactionAuditableTaxLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTransactionAuditableTaxLine> query)
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
        /// There are no comments for RetailTransactionAuditableTaxLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// OperatingUnitNumber
    /// RegisterNumber
    /// StoreNumber
    /// TransactionId
    /// SalesLineNumber
    /// TaxCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "OperatingUnitNumber", "RegisterNumber", "StoreNumber", "TransactionId", "SalesLineNumber", "TaxCode")]
    [global::Microsoft.OData.Client.EntitySet("RetailTransactionAuditableTaxLines")]
    public partial class RetailTransactionAuditableTaxLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTransactionAuditableTaxLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="operatingUnitNumber">Initial value of OperatingUnitNumber.</param>
        /// <param name="registerNumber">Initial value of RegisterNumber.</param>
        /// <param name="storeNumber">Initial value of StoreNumber.</param>
        /// <param name="transactionId">Initial value of TransactionId.</param>
        /// <param name="salesLineNumber">Initial value of SalesLineNumber.</param>
        /// <param name="taxCode">Initial value of TaxCode.</param>
        /// <param name="taxPercentage">Initial value of TaxPercentage.</param>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="retailTransactionAuditableSalesLine">Initial value of RetailTransactionAuditableSalesLine.</param>
        /// <param name="retailTransactionAuditable">Initial value of RetailTransactionAuditable.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTransactionAuditableTaxLine CreateRetailTransactionAuditableTaxLine(string dataAreaId, 
                    string operatingUnitNumber, 
                    string registerNumber, 
                    string storeNumber, 
                    string transactionId, 
                    decimal salesLineNumber, 
                    string taxCode, 
                    decimal taxPercentage, 
                    decimal amount, 
                    global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLine retailTransactionAuditableSalesLine, 
                    global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditable retailTransactionAuditable)
        {
            RetailTransactionAuditableTaxLine retailTransactionAuditableTaxLine = new RetailTransactionAuditableTaxLine();
            retailTransactionAuditableTaxLine.dataAreaId = dataAreaId;
            retailTransactionAuditableTaxLine.OperatingUnitNumber = operatingUnitNumber;
            retailTransactionAuditableTaxLine.RegisterNumber = registerNumber;
            retailTransactionAuditableTaxLine.StoreNumber = storeNumber;
            retailTransactionAuditableTaxLine.TransactionId = transactionId;
            retailTransactionAuditableTaxLine.SalesLineNumber = salesLineNumber;
            retailTransactionAuditableTaxLine.TaxCode = taxCode;
            retailTransactionAuditableTaxLine.TaxPercentage = taxPercentage;
            retailTransactionAuditableTaxLine.Amount = amount;
            if ((retailTransactionAuditableSalesLine == null))
            {
                throw new global::System.ArgumentNullException("retailTransactionAuditableSalesLine");
            }
            retailTransactionAuditableTaxLine.RetailTransactionAuditableSalesLine = retailTransactionAuditableSalesLine;
            if ((retailTransactionAuditable == null))
            {
                throw new global::System.ArgumentNullException("retailTransactionAuditable");
            }
            retailTransactionAuditableTaxLine.RetailTransactionAuditable = retailTransactionAuditable;
            return retailTransactionAuditableTaxLine;
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
        /// There are no comments for Property TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxCode
        {
            get
            {
                return this._TaxCode;
            }
            set
            {
                this.OnTaxCodeChanging(value);
                this._TaxCode = value;
                this.OnTaxCodeChanged();
                this.OnPropertyChanged("TaxCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxCode;
        partial void OnTaxCodeChanging(string value);
        partial void OnTaxCodeChanged();
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
        /// There are no comments for Property TaxPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TaxPercentage
        {
            get
            {
                return this._TaxPercentage;
            }
            set
            {
                this.OnTaxPercentageChanging(value);
                this._TaxPercentage = value;
                this.OnTaxPercentageChanged();
                this.OnPropertyChanged("TaxPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TaxPercentage;
        partial void OnTaxPercentageChanging(decimal value);
        partial void OnTaxPercentageChanged();
        /// <summary>
        /// There are no comments for Property IsIncludedInPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsIncludedInPrice
        {
            get
            {
                return this._IsIncludedInPrice;
            }
            set
            {
                this.OnIsIncludedInPriceChanging(value);
                this._IsIncludedInPrice = value;
                this.OnIsIncludedInPriceChanged();
                this.OnPropertyChanged("IsIncludedInPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsIncludedInPrice;
        partial void OnIsIncludedInPriceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsIncludedInPriceChanged();
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
        /// There are no comments for Property IsExempt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsExempt
        {
            get
            {
                return this._IsExempt;
            }
            set
            {
                this.OnIsExemptChanging(value);
                this._IsExempt = value;
                this.OnIsExemptChanged();
                this.OnPropertyChanged("IsExempt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsExempt;
        partial void OnIsExemptChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsExemptChanged();
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
