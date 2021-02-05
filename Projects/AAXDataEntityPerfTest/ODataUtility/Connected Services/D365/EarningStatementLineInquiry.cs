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
        /// There are no comments for EarningStatementLineInquirySingle in the schema.
        /// </summary>
    public partial class EarningStatementLineInquirySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EarningStatementLineInquiry>
    {
        /// <summary>
        /// Initialize a new EarningStatementLineInquirySingle object.
        /// </summary>
        public EarningStatementLineInquirySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EarningStatementLineInquirySingle object.
        /// </summary>
        public EarningStatementLineInquirySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EarningStatementLineInquirySingle object.
        /// </summary>
        public EarningStatementLineInquirySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EarningStatementLineInquiry> query)
            : base(query) {}

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
        /// There are no comments for PremiumEarningCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PremiumEarningCodeSingle PremiumEarningCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PremiumEarningCode == null))
                {
                    this._PremiumEarningCode = new global::Microsoft.Dynamics.DataEntities.PremiumEarningCodeSingle(this.Context, GetPath("PremiumEarningCode"));
                }
                return this._PremiumEarningCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PremiumEarningCodeSingle _PremiumEarningCode;
        /// <summary>
        /// There are no comments for PayrollEarningStatement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EarningStatementSingle PayrollEarningStatement
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollEarningStatement == null))
                {
                    this._PayrollEarningStatement = new global::Microsoft.Dynamics.DataEntities.EarningStatementSingle(this.Context, GetPath("PayrollEarningStatement"));
                }
                return this._PayrollEarningStatement;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EarningStatementSingle _PayrollEarningStatement;
        /// <summary>
        /// There are no comments for PayrollPayPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayPeriodSingle PayrollPayPeriod
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollPayPeriod == null))
                {
                    this._PayrollPayPeriod = new global::Microsoft.Dynamics.DataEntities.PayPeriodSingle(this.Context, GetPath("PayrollPayPeriod"));
                }
                return this._PayrollPayPeriod;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayPeriodSingle _PayrollPayPeriod;
    }
        /// <summary>
        /// There are no comments for EarningStatementLineInquiry in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// DocumentNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DocumentNumber")]
    [global::Microsoft.OData.Client.EntitySet("EarningStatementLineInquiries")]
    public partial class EarningStatementLineInquiry : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EarningStatementLineInquiry object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="documentNumber">Initial value of DocumentNumber.</param>
        /// <param name="earningRate">Initial value of EarningRate.</param>
        /// <param name="accountingDate">Initial value of AccountingDate.</param>
        /// <param name="periodStartDate">Initial value of PeriodStartDate.</param>
        /// <param name="retroactivePriorRate">Initial value of RetroactivePriorRate.</param>
        /// <param name="accountingCurrencyAmount">Initial value of AccountingCurrencyAmount.</param>
        /// <param name="periodEndDate">Initial value of PeriodEndDate.</param>
        /// <param name="earningDate">Initial value of EarningDate.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="positionV2">Initial value of PositionV2.</param>
        /// <param name="payrollEarningStatement">Initial value of PayrollEarningStatement.</param>
        /// <param name="payrollPayPeriod">Initial value of PayrollPayPeriod.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EarningStatementLineInquiry CreateEarningStatementLineInquiry(string dataAreaId, 
                    string documentNumber, 
                    decimal earningRate, 
                    global::System.DateTimeOffset accountingDate, 
                    global::System.DateTimeOffset periodStartDate, 
                    decimal retroactivePriorRate, 
                    decimal accountingCurrencyAmount, 
                    global::System.DateTimeOffset periodEndDate, 
                    global::System.DateTimeOffset earningDate, 
                    decimal quantity, 
                    global::Microsoft.Dynamics.DataEntities.PositionV2 positionV2, 
                    global::Microsoft.Dynamics.DataEntities.EarningStatement payrollEarningStatement, 
                    global::Microsoft.Dynamics.DataEntities.PayPeriod payrollPayPeriod)
        {
            EarningStatementLineInquiry earningStatementLineInquiry = new EarningStatementLineInquiry();
            earningStatementLineInquiry.dataAreaId = dataAreaId;
            earningStatementLineInquiry.DocumentNumber = documentNumber;
            earningStatementLineInquiry.EarningRate = earningRate;
            earningStatementLineInquiry.AccountingDate = accountingDate;
            earningStatementLineInquiry.PeriodStartDate = periodStartDate;
            earningStatementLineInquiry.RetroactivePriorRate = retroactivePriorRate;
            earningStatementLineInquiry.AccountingCurrencyAmount = accountingCurrencyAmount;
            earningStatementLineInquiry.PeriodEndDate = periodEndDate;
            earningStatementLineInquiry.EarningDate = earningDate;
            earningStatementLineInquiry.Quantity = quantity;
            if ((positionV2 == null))
            {
                throw new global::System.ArgumentNullException("positionV2");
            }
            earningStatementLineInquiry.PositionV2 = positionV2;
            if ((payrollEarningStatement == null))
            {
                throw new global::System.ArgumentNullException("payrollEarningStatement");
            }
            earningStatementLineInquiry.PayrollEarningStatement = payrollEarningStatement;
            if ((payrollPayPeriod == null))
            {
                throw new global::System.ArgumentNullException("payrollPayPeriod");
            }
            earningStatementLineInquiry.PayrollPayPeriod = payrollPayPeriod;
            return earningStatementLineInquiry;
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
        /// There are no comments for Property PaymentStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPaymentProcessingStatus> PaymentStatus
        {
            get
            {
                return this._PaymentStatus;
            }
            set
            {
                this.OnPaymentStatusChanging(value);
                this._PaymentStatus = value;
                this.OnPaymentStatusChanged();
                this.OnPropertyChanged("PaymentStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPaymentProcessingStatus> _PaymentStatus;
        partial void OnPaymentStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPaymentProcessingStatus> value);
        partial void OnPaymentStatusChanged();
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
        /// There are no comments for Property EarningCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EarningCode
        {
            get
            {
                return this._EarningCode;
            }
            set
            {
                this.OnEarningCodeChanging(value);
                this._EarningCode = value;
                this.OnEarningCodeChanged();
                this.OnPropertyChanged("EarningCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EarningCode;
        partial void OnEarningCodeChanging(string value);
        partial void OnEarningCodeChanged();
        /// <summary>
        /// There are no comments for Property PayCycleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PayCycleId
        {
            get
            {
                return this._PayCycleId;
            }
            set
            {
                this.OnPayCycleIdChanging(value);
                this._PayCycleId = value;
                this.OnPayCycleIdChanged();
                this.OnPropertyChanged("PayCycleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PayCycleId;
        partial void OnPayCycleIdChanging(string value);
        partial void OnPayCycleIdChanged();
        /// <summary>
        /// There are no comments for Property PeriodStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset PeriodStartDate
        {
            get
            {
                return this._PeriodStartDate;
            }
            set
            {
                this.OnPeriodStartDateChanging(value);
                this._PeriodStartDate = value;
                this.OnPeriodStartDateChanged();
                this.OnPropertyChanged("PeriodStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodStartDate;
        partial void OnPeriodStartDateChanging(global::System.DateTimeOffset value);
        partial void OnPeriodStartDateChanged();
        /// <summary>
        /// There are no comments for Property RetroactivePriorRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RetroactivePriorRate
        {
            get
            {
                return this._RetroactivePriorRate;
            }
            set
            {
                this.OnRetroactivePriorRateChanging(value);
                this._RetroactivePriorRate = value;
                this.OnRetroactivePriorRateChanged();
                this.OnPropertyChanged("RetroactivePriorRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RetroactivePriorRate;
        partial void OnRetroactivePriorRateChanging(decimal value);
        partial void OnRetroactivePriorRateChanged();
        /// <summary>
        /// There are no comments for Property QuantityUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollQuantityUnit> QuantityUnit
        {
            get
            {
                return this._QuantityUnit;
            }
            set
            {
                this.OnQuantityUnitChanging(value);
                this._QuantityUnit = value;
                this.OnQuantityUnitChanged();
                this.OnPropertyChanged("QuantityUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollQuantityUnit> _QuantityUnit;
        partial void OnQuantityUnitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollQuantityUnit> value);
        partial void OnQuantityUnitChanged();
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
        /// There are no comments for Property GenerationSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollGenerationSource> GenerationSource
        {
            get
            {
                return this._GenerationSource;
            }
            set
            {
                this.OnGenerationSourceChanging(value);
                this._GenerationSource = value;
                this.OnGenerationSourceChanged();
                this.OnPropertyChanged("GenerationSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollGenerationSource> _GenerationSource;
        partial void OnGenerationSourceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollGenerationSource> value);
        partial void OnGenerationSourceChanged();
        /// <summary>
        /// There are no comments for Property IsProductive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsProductive
        {
            get
            {
                return this._IsProductive;
            }
            set
            {
                this.OnIsProductiveChanging(value);
                this._IsProductive = value;
                this.OnIsProductiveChanged();
                this.OnPropertyChanged("IsProductive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsProductive;
        partial void OnIsProductiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsProductiveChanged();
        /// <summary>
        /// There are no comments for Property EarningCodeDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EarningCodeDescription
        {
            get
            {
                return this._EarningCodeDescription;
            }
            set
            {
                this.OnEarningCodeDescriptionChanging(value);
                this._EarningCodeDescription = value;
                this.OnEarningCodeDescriptionChanged();
                this.OnPropertyChanged("EarningCodeDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EarningCodeDescription;
        partial void OnEarningCodeDescriptionChanging(string value);
        partial void OnEarningCodeDescriptionChanged();
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
        /// There are no comments for Property PremiumCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PremiumCode
        {
            get
            {
                return this._PremiumCode;
            }
            set
            {
                this.OnPremiumCodeChanging(value);
                this._PremiumCode = value;
                this.OnPremiumCodeChanged();
                this.OnPropertyChanged("PremiumCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PremiumCode;
        partial void OnPremiumCodeChanging(string value);
        partial void OnPremiumCodeChanged();
        /// <summary>
        /// There are no comments for Property FringeBenefitType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollFringeBenefitType> FringeBenefitType
        {
            get
            {
                return this._FringeBenefitType;
            }
            set
            {
                this.OnFringeBenefitTypeChanging(value);
                this._FringeBenefitType = value;
                this.OnFringeBenefitTypeChanged();
                this.OnPropertyChanged("FringeBenefitType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollFringeBenefitType> _FringeBenefitType;
        partial void OnFringeBenefitTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollFringeBenefitType> value);
        partial void OnFringeBenefitTypeChanged();
        /// <summary>
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Worker
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
        private string _Worker;
        partial void OnWorkerChanging(string value);
        partial void OnWorkerChanged();
        /// <summary>
        /// There are no comments for Property WorkerCompensationBenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkerCompensationBenefitId
        {
            get
            {
                return this._WorkerCompensationBenefitId;
            }
            set
            {
                this.OnWorkerCompensationBenefitIdChanging(value);
                this._WorkerCompensationBenefitId = value;
                this.OnWorkerCompensationBenefitIdChanged();
                this.OnPropertyChanged("WorkerCompensationBenefitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerCompensationBenefitId;
        partial void OnWorkerCompensationBenefitIdChanging(string value);
        partial void OnWorkerCompensationBenefitIdChanged();
        /// <summary>
        /// There are no comments for Property WorkerGLIBenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkerGLIBenefitId
        {
            get
            {
                return this._WorkerGLIBenefitId;
            }
            set
            {
                this.OnWorkerGLIBenefitIdChanging(value);
                this._WorkerGLIBenefitId = value;
                this.OnWorkerGLIBenefitIdChanged();
                this.OnPropertyChanged("WorkerGLIBenefitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerGLIBenefitId;
        partial void OnWorkerGLIBenefitIdChanging(string value);
        partial void OnWorkerGLIBenefitIdChanged();
        /// <summary>
        /// There are no comments for Property PeriodEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset PeriodEndDate
        {
            get
            {
                return this._PeriodEndDate;
            }
            set
            {
                this.OnPeriodEndDateChanging(value);
                this._PeriodEndDate = value;
                this.OnPeriodEndDateChanged();
                this.OnPropertyChanged("PeriodEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodEndDate;
        partial void OnPeriodEndDateChanging(global::System.DateTimeOffset value);
        partial void OnPeriodEndDateChanged();
        /// <summary>
        /// There are no comments for Property TaxRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxRegion
        {
            get
            {
                return this._TaxRegion;
            }
            set
            {
                this.OnTaxRegionChanging(value);
                this._TaxRegion = value;
                this.OnTaxRegionChanged();
                this.OnPropertyChanged("TaxRegion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxRegion;
        partial void OnTaxRegionChanging(string value);
        partial void OnTaxRegionChanged();
        /// <summary>
        /// There are no comments for Property EarningDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EarningDate
        {
            get
            {
                return this._EarningDate;
            }
            set
            {
                this.OnEarningDateChanging(value);
                this._EarningDate = value;
                this.OnEarningDateChanged();
                this.OnPropertyChanged("EarningDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EarningDate;
        partial void OnEarningDateChanging(global::System.DateTimeOffset value);
        partial void OnEarningDateChanged();
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
        /// There are no comments for Property PremiumEarningCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PremiumEarningCode PremiumEarningCode
        {
            get
            {
                return this._PremiumEarningCode;
            }
            set
            {
                this.OnPremiumEarningCodeChanging(value);
                this._PremiumEarningCode = value;
                this.OnPremiumEarningCodeChanged();
                this.OnPropertyChanged("PremiumEarningCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PremiumEarningCode _PremiumEarningCode;
        partial void OnPremiumEarningCodeChanging(global::Microsoft.Dynamics.DataEntities.PremiumEarningCode value);
        partial void OnPremiumEarningCodeChanged();
        /// <summary>
        /// There are no comments for Property PayrollEarningStatement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EarningStatement PayrollEarningStatement
        {
            get
            {
                return this._PayrollEarningStatement;
            }
            set
            {
                this.OnPayrollEarningStatementChanging(value);
                this._PayrollEarningStatement = value;
                this.OnPayrollEarningStatementChanged();
                this.OnPropertyChanged("PayrollEarningStatement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EarningStatement _PayrollEarningStatement;
        partial void OnPayrollEarningStatementChanging(global::Microsoft.Dynamics.DataEntities.EarningStatement value);
        partial void OnPayrollEarningStatementChanged();
        /// <summary>
        /// There are no comments for Property PayrollPayPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayPeriod PayrollPayPeriod
        {
            get
            {
                return this._PayrollPayPeriod;
            }
            set
            {
                this.OnPayrollPayPeriodChanging(value);
                this._PayrollPayPeriod = value;
                this.OnPayrollPayPeriodChanged();
                this.OnPropertyChanged("PayrollPayPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayPeriod _PayrollPayPeriod;
        partial void OnPayrollPayPeriodChanging(global::Microsoft.Dynamics.DataEntities.PayPeriod value);
        partial void OnPayrollPayPeriodChanged();
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
