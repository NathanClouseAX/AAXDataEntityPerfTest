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
        /// There are no comments for PayStatementEarningLineSingle in the schema.
        /// </summary>
    public partial class PayStatementEarningLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PayStatementEarningLine>
    {
        /// <summary>
        /// Initialize a new PayStatementEarningLineSingle object.
        /// </summary>
        public PayStatementEarningLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PayStatementEarningLineSingle object.
        /// </summary>
        public PayStatementEarningLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PayStatementEarningLineSingle object.
        /// </summary>
        public PayStatementEarningLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PayStatementEarningLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle Worker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Worker == null))
                {
                    this._Worker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("Worker"));
                }
                return this._Worker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _Worker;
        /// <summary>
        /// There are no comments for PositionV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2Single PositionV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PositionV2 == null))
                {
                    this._PositionV2 = new global::Microsoft.Dynamics.DataEntities.PositionV2Single(this.Context, GetPath("PositionV2"));
                }
                return this._PositionV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2Single _PositionV2;
        /// <summary>
        /// There are no comments for WorkerTaxRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerTaxRegionSingle WorkerTaxRegion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerTaxRegion == null))
                {
                    this._WorkerTaxRegion = new global::Microsoft.Dynamics.DataEntities.WorkerTaxRegionSingle(this.Context, GetPath("WorkerTaxRegion"));
                }
                return this._WorkerTaxRegion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerTaxRegionSingle _WorkerTaxRegion;
        /// <summary>
        /// There are no comments for PayStatementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayStatementHeaderSingle PayStatementHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayStatementHeader == null))
                {
                    this._PayStatementHeader = new global::Microsoft.Dynamics.DataEntities.PayStatementHeaderSingle(this.Context, GetPath("PayStatementHeader"));
                }
                return this._PayStatementHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayStatementHeaderSingle _PayStatementHeader;
    }
        /// <summary>
        /// There are no comments for PayStatementEarningLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PayStatementNumber
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PayStatementNumber", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("PayStatementEarningLines")]
    public partial class PayStatementEarningLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PayStatementEarningLine object.
        /// </summary>
        /// <param name="payStatementNumber">Initial value of PayStatementNumber.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="earningRate">Initial value of EarningRate.</param>
        /// <param name="accountingDate">Initial value of AccountingDate.</param>
        /// <param name="earningsDate">Initial value of EarningsDate.</param>
        /// <param name="reversedPayStatementLineNum">Initial value of ReversedPayStatementLineNum.</param>
        /// <param name="amountInTransactionCurrency">Initial value of AmountInTransactionCurrency.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="worker">Initial value of Worker.</param>
        /// <param name="positionV2">Initial value of PositionV2.</param>
        /// <param name="workerTaxRegion">Initial value of WorkerTaxRegion.</param>
        /// <param name="payStatementHeader">Initial value of PayStatementHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PayStatementEarningLine CreatePayStatementEarningLine(string payStatementNumber, 
                    decimal lineNumber, 
                    decimal earningRate, 
                    global::System.DateTimeOffset accountingDate, 
                    global::System.DateTimeOffset earningsDate, 
                    decimal reversedPayStatementLineNum, 
                    decimal amountInTransactionCurrency, 
                    decimal quantity, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker, 
                    global::Microsoft.Dynamics.DataEntities.PositionV2 positionV2, 
                    global::Microsoft.Dynamics.DataEntities.WorkerTaxRegion workerTaxRegion, 
                    global::Microsoft.Dynamics.DataEntities.PayStatementHeader payStatementHeader)
        {
            PayStatementEarningLine payStatementEarningLine = new PayStatementEarningLine();
            payStatementEarningLine.PayStatementNumber = payStatementNumber;
            payStatementEarningLine.LineNumber = lineNumber;
            payStatementEarningLine.EarningRate = earningRate;
            payStatementEarningLine.AccountingDate = accountingDate;
            payStatementEarningLine.EarningsDate = earningsDate;
            payStatementEarningLine.ReversedPayStatementLineNum = reversedPayStatementLineNum;
            payStatementEarningLine.AmountInTransactionCurrency = amountInTransactionCurrency;
            payStatementEarningLine.Quantity = quantity;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            payStatementEarningLine.Worker = worker;
            if ((positionV2 == null))
            {
                throw new global::System.ArgumentNullException("positionV2");
            }
            payStatementEarningLine.PositionV2 = positionV2;
            if ((workerTaxRegion == null))
            {
                throw new global::System.ArgumentNullException("workerTaxRegion");
            }
            payStatementEarningLine.WorkerTaxRegion = workerTaxRegion;
            if ((payStatementHeader == null))
            {
                throw new global::System.ArgumentNullException("payStatementHeader");
            }
            payStatementEarningLine.PayStatementHeader = payStatementHeader;
            return payStatementEarningLine;
        }
        /// <summary>
        /// There are no comments for Property PayStatementNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PayStatementNumber
        {
            get
            {
                return this._PayStatementNumber;
            }
            set
            {
                this.OnPayStatementNumberChanging(value);
                this._PayStatementNumber = value;
                this.OnPayStatementNumberChanged();
                this.OnPropertyChanged("PayStatementNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PayStatementNumber;
        partial void OnPayStatementNumberChanging(string value);
        partial void OnPayStatementNumberChanged();
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
        /// There are no comments for Property EarningRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal EarningRate
        {
            get
            {
                return this._EarningRate;
            }
            set
            {
                this.OnEarningRateChanging(value);
                this._EarningRate = value;
                this.OnEarningRateChanged();
                this.OnPropertyChanged("EarningRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _EarningRate;
        partial void OnEarningRateChanging(decimal value);
        partial void OnEarningRateChanged();
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
        /// There are no comments for Property WorkerTaxRegionLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkerTaxRegionLocationId
        {
            get
            {
                return this._WorkerTaxRegionLocationId;
            }
            set
            {
                this.OnWorkerTaxRegionLocationIdChanging(value);
                this._WorkerTaxRegionLocationId = value;
                this.OnWorkerTaxRegionLocationIdChanged();
                this.OnPropertyChanged("WorkerTaxRegionLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerTaxRegionLocationId;
        partial void OnWorkerTaxRegionLocationIdChanging(string value);
        partial void OnWorkerTaxRegionLocationIdChanged();
        /// <summary>
        /// There are no comments for Property Company in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                this.OnCompanyChanging(value);
                this._Company = value;
                this.OnCompanyChanged();
                this.OnPropertyChanged("Company");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Company;
        partial void OnCompanyChanging(string value);
        partial void OnCompanyChanged();
        /// <summary>
        /// There are no comments for Property EarningCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EarningCodeId
        {
            get
            {
                return this._EarningCodeId;
            }
            set
            {
                this.OnEarningCodeIdChanging(value);
                this._EarningCodeId = value;
                this.OnEarningCodeIdChanged();
                this.OnPropertyChanged("EarningCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EarningCodeId;
        partial void OnEarningCodeIdChanging(string value);
        partial void OnEarningCodeIdChanged();
        /// <summary>
        /// There are no comments for Property EarningsDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EarningsDate
        {
            get
            {
                return this._EarningsDate;
            }
            set
            {
                this.OnEarningsDateChanging(value);
                this._EarningsDate = value;
                this.OnEarningsDateChanged();
                this.OnPropertyChanged("EarningsDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EarningsDate;
        partial void OnEarningsDateChanging(global::System.DateTimeOffset value);
        partial void OnEarningsDateChanged();
        /// <summary>
        /// There are no comments for Property ReversedPayStatementLineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReversedPayStatementLineNum
        {
            get
            {
                return this._ReversedPayStatementLineNum;
            }
            set
            {
                this.OnReversedPayStatementLineNumChanging(value);
                this._ReversedPayStatementLineNum = value;
                this.OnReversedPayStatementLineNumChanged();
                this.OnPropertyChanged("ReversedPayStatementLineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReversedPayStatementLineNum;
        partial void OnReversedPayStatementLineNumChanging(decimal value);
        partial void OnReversedPayStatementLineNumChanged();
        /// <summary>
        /// There are no comments for Property PositionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PositionId
        {
            get
            {
                return this._PositionId;
            }
            set
            {
                this.OnPositionIdChanging(value);
                this._PositionId = value;
                this.OnPositionIdChanged();
                this.OnPropertyChanged("PositionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PositionId;
        partial void OnPositionIdChanging(string value);
        partial void OnPositionIdChanged();
        /// <summary>
        /// There are no comments for Property GeneralLiabilityInsuranceBenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GeneralLiabilityInsuranceBenefitId
        {
            get
            {
                return this._GeneralLiabilityInsuranceBenefitId;
            }
            set
            {
                this.OnGeneralLiabilityInsuranceBenefitIdChanging(value);
                this._GeneralLiabilityInsuranceBenefitId = value;
                this.OnGeneralLiabilityInsuranceBenefitIdChanged();
                this.OnPropertyChanged("GeneralLiabilityInsuranceBenefitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GeneralLiabilityInsuranceBenefitId;
        partial void OnGeneralLiabilityInsuranceBenefitIdChanging(string value);
        partial void OnGeneralLiabilityInsuranceBenefitIdChanged();
        /// <summary>
        /// There are no comments for Property ReversedPayStatementNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReversedPayStatementNumber
        {
            get
            {
                return this._ReversedPayStatementNumber;
            }
            set
            {
                this.OnReversedPayStatementNumberChanging(value);
                this._ReversedPayStatementNumber = value;
                this.OnReversedPayStatementNumberChanged();
                this.OnPropertyChanged("ReversedPayStatementNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReversedPayStatementNumber;
        partial void OnReversedPayStatementNumberChanging(string value);
        partial void OnReversedPayStatementNumberChanged();
        /// <summary>
        /// There are no comments for Property AmountInTransactionCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AmountInTransactionCurrency
        {
            get
            {
                return this._AmountInTransactionCurrency;
            }
            set
            {
                this.OnAmountInTransactionCurrencyChanging(value);
                this._AmountInTransactionCurrency = value;
                this.OnAmountInTransactionCurrencyChanged();
                this.OnPropertyChanged("AmountInTransactionCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmountInTransactionCurrency;
        partial void OnAmountInTransactionCurrencyChanging(decimal value);
        partial void OnAmountInTransactionCurrencyChanged();
        /// <summary>
        /// There are no comments for Property PayStatementLineSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPayStatementLineSource> PayStatementLineSource
        {
            get
            {
                return this._PayStatementLineSource;
            }
            set
            {
                this.OnPayStatementLineSourceChanging(value);
                this._PayStatementLineSource = value;
                this.OnPayStatementLineSourceChanged();
                this.OnPropertyChanged("PayStatementLineSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPayStatementLineSource> _PayStatementLineSource;
        partial void OnPayStatementLineSourceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPayStatementLineSource> value);
        partial void OnPayStatementLineSourceChanged();
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property LineToRemove in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> LineToRemove
        {
            get
            {
                return this._LineToRemove;
            }
            set
            {
                this.OnLineToRemoveChanging(value);
                this._LineToRemove = value;
                this.OnLineToRemoveChanged();
                this.OnPropertyChanged("LineToRemove");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _LineToRemove;
        partial void OnLineToRemoveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnLineToRemoveChanged();
        /// <summary>
        /// There are no comments for Property CompensationBenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CompensationBenefitId
        {
            get
            {
                return this._CompensationBenefitId;
            }
            set
            {
                this.OnCompensationBenefitIdChanging(value);
                this._CompensationBenefitId = value;
                this.OnCompensationBenefitIdChanged();
                this.OnPropertyChanged("CompensationBenefitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CompensationBenefitId;
        partial void OnCompensationBenefitIdChanging(string value);
        partial void OnCompensationBenefitIdChanged();
        /// <summary>
        /// There are no comments for Property AccountingDistributionTemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountingDistributionTemplateId
        {
            get
            {
                return this._AccountingDistributionTemplateId;
            }
            set
            {
                this.OnAccountingDistributionTemplateIdChanging(value);
                this._AccountingDistributionTemplateId = value;
                this.OnAccountingDistributionTemplateIdChanged();
                this.OnPropertyChanged("AccountingDistributionTemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountingDistributionTemplateId;
        partial void OnAccountingDistributionTemplateIdChanging(string value);
        partial void OnAccountingDistributionTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property EmployerContribution in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EmployerContribution
        {
            get
            {
                return this._EmployerContribution;
            }
            set
            {
                this.OnEmployerContributionChanging(value);
                this._EmployerContribution = value;
                this.OnEmployerContributionChanged();
                this.OnPropertyChanged("EmployerContribution");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EmployerContribution;
        partial void OnEmployerContributionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEmployerContributionChanged();
        /// <summary>
        /// There are no comments for Property LineOverridden in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> LineOverridden
        {
            get
            {
                return this._LineOverridden;
            }
            set
            {
                this.OnLineOverriddenChanging(value);
                this._LineOverridden = value;
                this.OnLineOverriddenChanged();
                this.OnPropertyChanged("LineOverridden");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _LineOverridden;
        partial void OnLineOverriddenChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnLineOverriddenChanged();
        /// <summary>
        /// There are no comments for Property AccountingDistributionLegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountingDistributionLegalEntity
        {
            get
            {
                return this._AccountingDistributionLegalEntity;
            }
            set
            {
                this.OnAccountingDistributionLegalEntityChanging(value);
                this._AccountingDistributionLegalEntity = value;
                this.OnAccountingDistributionLegalEntityChanged();
                this.OnPropertyChanged("AccountingDistributionLegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountingDistributionLegalEntity;
        partial void OnAccountingDistributionLegalEntityChanging(string value);
        partial void OnAccountingDistributionLegalEntityChanged();
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
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker Worker
        {
            get
            {
                return this._Worker;
            }
            set
            {
                this.OnWorkerChanging(value);
                this._Worker = value;
                this.OnWorkerChanged();
                this.OnPropertyChanged("Worker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _Worker;
        partial void OnWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnWorkerChanged();
        /// <summary>
        /// There are no comments for Property PositionV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2 PositionV2
        {
            get
            {
                return this._PositionV2;
            }
            set
            {
                this.OnPositionV2Changing(value);
                this._PositionV2 = value;
                this.OnPositionV2Changed();
                this.OnPropertyChanged("PositionV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2 _PositionV2;
        partial void OnPositionV2Changing(global::Microsoft.Dynamics.DataEntities.PositionV2 value);
        partial void OnPositionV2Changed();
        /// <summary>
        /// There are no comments for Property WorkerTaxRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerTaxRegion WorkerTaxRegion
        {
            get
            {
                return this._WorkerTaxRegion;
            }
            set
            {
                this.OnWorkerTaxRegionChanging(value);
                this._WorkerTaxRegion = value;
                this.OnWorkerTaxRegionChanged();
                this.OnPropertyChanged("WorkerTaxRegion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerTaxRegion _WorkerTaxRegion;
        partial void OnWorkerTaxRegionChanging(global::Microsoft.Dynamics.DataEntities.WorkerTaxRegion value);
        partial void OnWorkerTaxRegionChanged();
        /// <summary>
        /// There are no comments for Property PayStatementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayStatementHeader PayStatementHeader
        {
            get
            {
                return this._PayStatementHeader;
            }
            set
            {
                this.OnPayStatementHeaderChanging(value);
                this._PayStatementHeader = value;
                this.OnPayStatementHeaderChanged();
                this.OnPropertyChanged("PayStatementHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayStatementHeader _PayStatementHeader;
        partial void OnPayStatementHeaderChanging(global::Microsoft.Dynamics.DataEntities.PayStatementHeader value);
        partial void OnPayStatementHeaderChanged();
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
