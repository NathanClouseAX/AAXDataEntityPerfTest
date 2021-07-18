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
        /// There are no comments for RetailTransactionAuditableChargeLineSingle in the schema.
        /// </summary>
    public partial class RetailTransactionAuditableChargeLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTransactionAuditableChargeLine>
    {
        /// <summary>
        /// Initialize a new RetailTransactionAuditableChargeLineSingle object.
        /// </summary>
        public RetailTransactionAuditableChargeLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTransactionAuditableChargeLineSingle object.
        /// </summary>
        public RetailTransactionAuditableChargeLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTransactionAuditableChargeLineSingle object.
        /// </summary>
        public RetailTransactionAuditableChargeLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTransactionAuditableChargeLine> query)
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
        /// There are no comments for RetailTransactionAuditableChargeLine in the schema.
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
    [global::Microsoft.OData.Client.EntitySet("RetailTransactionAuditableChargeLines")]
    public partial class RetailTransactionAuditableChargeLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTransactionAuditableChargeLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="operatingUnitNumber">Initial value of OperatingUnitNumber.</param>
        /// <param name="storeNumber">Initial value of StoreNumber.</param>
        /// <param name="registerNumber">Initial value of RegisterNumber.</param>
        /// <param name="transactionId">Initial value of TransactionId.</param>
        /// <param name="salesLineNumber">Initial value of SalesLineNumber.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="salesTaxAmount">Initial value of SalesTaxAmount.</param>
        /// <param name="exclusiveTaxAmount">Initial value of ExclusiveTaxAmount.</param>
        /// <param name="inclusiveTaxAmount">Initial value of InclusiveTaxAmount.</param>
        /// <param name="taxExemptPriceInclusiveReductionAmount">Initial value of TaxExemptPriceInclusiveReductionAmount.</param>
        /// <param name="calculatedAmount">Initial value of CalculatedAmount.</param>
        /// <param name="taxExemptPriceInclusiveOriginalPrice">Initial value of TaxExemptPriceInclusiveOriginalPrice.</param>
        /// <param name="chargesValue">Initial value of ChargesValue.</param>
        /// <param name="retailTransactionAuditableSalesLine">Initial value of RetailTransactionAuditableSalesLine.</param>
        /// <param name="retailTransactionAuditable">Initial value of RetailTransactionAuditable.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTransactionAuditableChargeLine CreateRetailTransactionAuditableChargeLine(string dataAreaId, 
                    string operatingUnitNumber, 
                    string storeNumber, 
                    string registerNumber, 
                    string transactionId, 
                    decimal salesLineNumber, 
                    decimal lineNumber, 
                    decimal salesTaxAmount, 
                    decimal exclusiveTaxAmount, 
                    decimal inclusiveTaxAmount, 
                    decimal taxExemptPriceInclusiveReductionAmount, 
                    decimal calculatedAmount, 
                    decimal taxExemptPriceInclusiveOriginalPrice, 
                    decimal chargesValue, 
                    global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLine retailTransactionAuditableSalesLine, 
                    global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditable retailTransactionAuditable)
        {
            RetailTransactionAuditableChargeLine retailTransactionAuditableChargeLine = new RetailTransactionAuditableChargeLine();
            retailTransactionAuditableChargeLine.dataAreaId = dataAreaId;
            retailTransactionAuditableChargeLine.OperatingUnitNumber = operatingUnitNumber;
            retailTransactionAuditableChargeLine.StoreNumber = storeNumber;
            retailTransactionAuditableChargeLine.RegisterNumber = registerNumber;
            retailTransactionAuditableChargeLine.TransactionId = transactionId;
            retailTransactionAuditableChargeLine.SalesLineNumber = salesLineNumber;
            retailTransactionAuditableChargeLine.LineNumber = lineNumber;
            retailTransactionAuditableChargeLine.SalesTaxAmount = salesTaxAmount;
            retailTransactionAuditableChargeLine.ExclusiveTaxAmount = exclusiveTaxAmount;
            retailTransactionAuditableChargeLine.InclusiveTaxAmount = inclusiveTaxAmount;
            retailTransactionAuditableChargeLine.TaxExemptPriceInclusiveReductionAmount = taxExemptPriceInclusiveReductionAmount;
            retailTransactionAuditableChargeLine.CalculatedAmount = calculatedAmount;
            retailTransactionAuditableChargeLine.TaxExemptPriceInclusiveOriginalPrice = taxExemptPriceInclusiveOriginalPrice;
            retailTransactionAuditableChargeLine.ChargesValue = chargesValue;
            if ((retailTransactionAuditableSalesLine == null))
            {
                throw new global::System.ArgumentNullException("retailTransactionAuditableSalesLine");
            }
            retailTransactionAuditableChargeLine.RetailTransactionAuditableSalesLine = retailTransactionAuditableSalesLine;
            if ((retailTransactionAuditable == null))
            {
                throw new global::System.ArgumentNullException("retailTransactionAuditable");
            }
            retailTransactionAuditableChargeLine.RetailTransactionAuditable = retailTransactionAuditable;
            return retailTransactionAuditableChargeLine;
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
        /// There are no comments for Property SalesTaxAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SalesTaxAmount
        {
            get
            {
                return this._SalesTaxAmount;
            }
            set
            {
                this.OnSalesTaxAmountChanging(value);
                this._SalesTaxAmount = value;
                this.OnSalesTaxAmountChanged();
                this.OnPropertyChanged("SalesTaxAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SalesTaxAmount;
        partial void OnSalesTaxAmountChanging(decimal value);
        partial void OnSalesTaxAmountChanged();
        /// <summary>
        /// There are no comments for Property ExclusiveTaxAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ExclusiveTaxAmount
        {
            get
            {
                return this._ExclusiveTaxAmount;
            }
            set
            {
                this.OnExclusiveTaxAmountChanging(value);
                this._ExclusiveTaxAmount = value;
                this.OnExclusiveTaxAmountChanged();
                this.OnPropertyChanged("ExclusiveTaxAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExclusiveTaxAmount;
        partial void OnExclusiveTaxAmountChanging(decimal value);
        partial void OnExclusiveTaxAmountChanged();
        /// <summary>
        /// There are no comments for Property ItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemSalesTaxGroup
        {
            get
            {
                return this._ItemSalesTaxGroup;
            }
            set
            {
                this.OnItemSalesTaxGroupChanging(value);
                this._ItemSalesTaxGroup = value;
                this.OnItemSalesTaxGroupChanged();
                this.OnPropertyChanged("ItemSalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemSalesTaxGroup;
        partial void OnItemSalesTaxGroupChanging(string value);
        partial void OnItemSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this.OnCurrencyChanging(value);
                this._Currency = value;
                this.OnCurrencyChanged();
                this.OnPropertyChanged("Currency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Currency;
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
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
        /// There are no comments for Property CategoryType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupCategory> CategoryType
        {
            get
            {
                return this._CategoryType;
            }
            set
            {
                this.OnCategoryTypeChanging(value);
                this._CategoryType = value;
                this.OnCategoryTypeChanged();
                this.OnPropertyChanged("CategoryType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupCategory> _CategoryType;
        partial void OnCategoryTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupCategory> value);
        partial void OnCategoryTypeChanged();
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
        /// There are no comments for Property InclusiveTaxAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal InclusiveTaxAmount
        {
            get
            {
                return this._InclusiveTaxAmount;
            }
            set
            {
                this.OnInclusiveTaxAmountChanging(value);
                this._InclusiveTaxAmount = value;
                this.OnInclusiveTaxAmountChanged();
                this.OnPropertyChanged("InclusiveTaxAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InclusiveTaxAmount;
        partial void OnInclusiveTaxAmountChanging(decimal value);
        partial void OnInclusiveTaxAmountChanged();
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
        /// There are no comments for Property TaxExemptPriceInclusiveReductionAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TaxExemptPriceInclusiveReductionAmount
        {
            get
            {
                return this._TaxExemptPriceInclusiveReductionAmount;
            }
            set
            {
                this.OnTaxExemptPriceInclusiveReductionAmountChanging(value);
                this._TaxExemptPriceInclusiveReductionAmount = value;
                this.OnTaxExemptPriceInclusiveReductionAmountChanged();
                this.OnPropertyChanged("TaxExemptPriceInclusiveReductionAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TaxExemptPriceInclusiveReductionAmount;
        partial void OnTaxExemptPriceInclusiveReductionAmountChanging(decimal value);
        partial void OnTaxExemptPriceInclusiveReductionAmountChanged();
        /// <summary>
        /// There are no comments for Property CalculatedAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CalculatedAmount
        {
            get
            {
                return this._CalculatedAmount;
            }
            set
            {
                this.OnCalculatedAmountChanging(value);
                this._CalculatedAmount = value;
                this.OnCalculatedAmountChanged();
                this.OnPropertyChanged("CalculatedAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CalculatedAmount;
        partial void OnCalculatedAmountChanging(decimal value);
        partial void OnCalculatedAmountChanged();
        /// <summary>
        /// There are no comments for Property ChargesCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ChargesCode
        {
            get
            {
                return this._ChargesCode;
            }
            set
            {
                this.OnChargesCodeChanging(value);
                this._ChargesCode = value;
                this.OnChargesCodeChanged();
                this.OnPropertyChanged("ChargesCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChargesCode;
        partial void OnChargesCodeChanging(string value);
        partial void OnChargesCodeChanged();
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
        /// There are no comments for Property ModuleType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupModuleType> ModuleType
        {
            get
            {
                return this._ModuleType;
            }
            set
            {
                this.OnModuleTypeChanging(value);
                this._ModuleType = value;
                this.OnModuleTypeChanged();
                this.OnPropertyChanged("ModuleType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupModuleType> _ModuleType;
        partial void OnModuleTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupModuleType> value);
        partial void OnModuleTypeChanged();
        /// <summary>
        /// There are no comments for Property TaxExemptPriceInclusiveOriginalPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TaxExemptPriceInclusiveOriginalPrice
        {
            get
            {
                return this._TaxExemptPriceInclusiveOriginalPrice;
            }
            set
            {
                this.OnTaxExemptPriceInclusiveOriginalPriceChanging(value);
                this._TaxExemptPriceInclusiveOriginalPrice = value;
                this.OnTaxExemptPriceInclusiveOriginalPriceChanged();
                this.OnPropertyChanged("TaxExemptPriceInclusiveOriginalPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TaxExemptPriceInclusiveOriginalPrice;
        partial void OnTaxExemptPriceInclusiveOriginalPriceChanging(decimal value);
        partial void OnTaxExemptPriceInclusiveOriginalPriceChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesTaxGroup
        {
            get
            {
                return this._SalesTaxGroup;
            }
            set
            {
                this.OnSalesTaxGroupChanging(value);
                this._SalesTaxGroup = value;
                this.OnSalesTaxGroupChanged();
                this.OnPropertyChanged("SalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxGroup;
        partial void OnSalesTaxGroupChanging(string value);
        partial void OnSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property ChargesValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ChargesValue
        {
            get
            {
                return this._ChargesValue;
            }
            set
            {
                this.OnChargesValueChanging(value);
                this._ChargesValue = value;
                this.OnChargesValueChanged();
                this.OnPropertyChanged("ChargesValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ChargesValue;
        partial void OnChargesValueChanging(decimal value);
        partial void OnChargesValueChanged();
        /// <summary>
        /// There are no comments for Property Keep in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Keep
        {
            get
            {
                return this._Keep;
            }
            set
            {
                this.OnKeepChanging(value);
                this._Keep = value;
                this.OnKeepChanged();
                this.OnPropertyChanged("Keep");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Keep;
        partial void OnKeepChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnKeepChanged();
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
