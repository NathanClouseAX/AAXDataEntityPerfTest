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
        /// There are no comments for LeaseDepreciationScheduleHistorySingle in the schema.
        /// </summary>
    public partial class LeaseDepreciationScheduleHistorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LeaseDepreciationScheduleHistory>
    {
        /// <summary>
        /// Initialize a new LeaseDepreciationScheduleHistorySingle object.
        /// </summary>
        public LeaseDepreciationScheduleHistorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeaseDepreciationScheduleHistorySingle object.
        /// </summary>
        public LeaseDepreciationScheduleHistorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeaseDepreciationScheduleHistorySingle object.
        /// </summary>
        public LeaseDepreciationScheduleHistorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LeaseDepreciationScheduleHistory> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for LeaseDepreciationScheduleHistory in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LeaseId
    /// LineLeaseCounter
    /// ScheduleLineDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LeaseId", "LineLeaseCounter", "ScheduleLineDate")]
    [global::Microsoft.OData.Client.EntitySet("LeaseDepreciationSchedulesHistory")]
    public partial class LeaseDepreciationScheduleHistory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeaseDepreciationScheduleHistory object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="leaseId">Initial value of LeaseId.</param>
        /// <param name="lineLeaseCounter">Initial value of LineLeaseCounter.</param>
        /// <param name="scheduleLineDate">Initial value of ScheduleLineDate.</param>
        /// <param name="amortizationExpenseReportingAmount">Initial value of AmortizationExpenseReportingAmount.</param>
        /// <param name="leaseCounter">Initial value of LeaseCounter.</param>
        /// <param name="exchangeRateReporting">Initial value of ExchangeRateReporting.</param>
        /// <param name="period">Initial value of Period.</param>
        /// <param name="assetROUAccountingAmount">Initial value of AssetROUAccountingAmount.</param>
        /// <param name="accumulatedAmortization">Initial value of AccumulatedAmortization.</param>
        /// <param name="netBookAccountingAmount">Initial value of NetBookAccountingAmount.</param>
        /// <param name="netBookReportingAmount">Initial value of NetBookReportingAmount.</param>
        /// <param name="exchangeRate">Initial value of ExchangeRate.</param>
        /// <param name="periodEndDate">Initial value of PeriodEndDate.</param>
        /// <param name="accumulatedAmortizationAccountingAmount">Initial value of AccumulatedAmortizationAccountingAmount.</param>
        /// <param name="amortizationExpense">Initial value of AmortizationExpense.</param>
        /// <param name="assetROUTransactionAmount">Initial value of AssetROUTransactionAmount.</param>
        /// <param name="assetROUReportingAmount">Initial value of AssetROUReportingAmount.</param>
        /// <param name="beginningNetBookReportingAmount">Initial value of BeginningNetBookReportingAmount.</param>
        /// <param name="amortizationExpenseAccountingAmount">Initial value of AmortizationExpenseAccountingAmount.</param>
        /// <param name="beginningNetBookAccountingAmount">Initial value of BeginningNetBookAccountingAmount.</param>
        /// <param name="accumulatedAmortizationReportingAmount">Initial value of AccumulatedAmortizationReportingAmount.</param>
        /// <param name="months">Initial value of Months.</param>
        /// <param name="netBookValue">Initial value of NetBookValue.</param>
        /// <param name="beginningNetBookValue">Initial value of BeginningNetBookValue.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeaseDepreciationScheduleHistory CreateLeaseDepreciationScheduleHistory(string dataAreaId, 
                    string leaseId, 
                    int lineLeaseCounter, 
                    global::System.DateTimeOffset scheduleLineDate, 
                    decimal amortizationExpenseReportingAmount, 
                    int leaseCounter, 
                    decimal exchangeRateReporting, 
                    int period, 
                    decimal assetROUAccountingAmount, 
                    decimal accumulatedAmortization, 
                    decimal netBookAccountingAmount, 
                    decimal netBookReportingAmount, 
                    decimal exchangeRate, 
                    global::System.DateTimeOffset periodEndDate, 
                    decimal accumulatedAmortizationAccountingAmount, 
                    decimal amortizationExpense, 
                    decimal assetROUTransactionAmount, 
                    decimal assetROUReportingAmount, 
                    decimal beginningNetBookReportingAmount, 
                    decimal amortizationExpenseAccountingAmount, 
                    decimal beginningNetBookAccountingAmount, 
                    decimal accumulatedAmortizationReportingAmount, 
                    int months, 
                    decimal netBookValue, 
                    decimal beginningNetBookValue)
        {
            LeaseDepreciationScheduleHistory leaseDepreciationScheduleHistory = new LeaseDepreciationScheduleHistory();
            leaseDepreciationScheduleHistory.dataAreaId = dataAreaId;
            leaseDepreciationScheduleHistory.LeaseId = leaseId;
            leaseDepreciationScheduleHistory.LineLeaseCounter = lineLeaseCounter;
            leaseDepreciationScheduleHistory.ScheduleLineDate = scheduleLineDate;
            leaseDepreciationScheduleHistory.AmortizationExpenseReportingAmount = amortizationExpenseReportingAmount;
            leaseDepreciationScheduleHistory.LeaseCounter = leaseCounter;
            leaseDepreciationScheduleHistory.ExchangeRateReporting = exchangeRateReporting;
            leaseDepreciationScheduleHistory.Period = period;
            leaseDepreciationScheduleHistory.AssetROUAccountingAmount = assetROUAccountingAmount;
            leaseDepreciationScheduleHistory.AccumulatedAmortization = accumulatedAmortization;
            leaseDepreciationScheduleHistory.NetBookAccountingAmount = netBookAccountingAmount;
            leaseDepreciationScheduleHistory.NetBookReportingAmount = netBookReportingAmount;
            leaseDepreciationScheduleHistory.ExchangeRate = exchangeRate;
            leaseDepreciationScheduleHistory.PeriodEndDate = periodEndDate;
            leaseDepreciationScheduleHistory.AccumulatedAmortizationAccountingAmount = accumulatedAmortizationAccountingAmount;
            leaseDepreciationScheduleHistory.AmortizationExpense = amortizationExpense;
            leaseDepreciationScheduleHistory.AssetROUTransactionAmount = assetROUTransactionAmount;
            leaseDepreciationScheduleHistory.AssetROUReportingAmount = assetROUReportingAmount;
            leaseDepreciationScheduleHistory.BeginningNetBookReportingAmount = beginningNetBookReportingAmount;
            leaseDepreciationScheduleHistory.AmortizationExpenseAccountingAmount = amortizationExpenseAccountingAmount;
            leaseDepreciationScheduleHistory.BeginningNetBookAccountingAmount = beginningNetBookAccountingAmount;
            leaseDepreciationScheduleHistory.AccumulatedAmortizationReportingAmount = accumulatedAmortizationReportingAmount;
            leaseDepreciationScheduleHistory.Months = months;
            leaseDepreciationScheduleHistory.NetBookValue = netBookValue;
            leaseDepreciationScheduleHistory.BeginningNetBookValue = beginningNetBookValue;
            return leaseDepreciationScheduleHistory;
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
        /// There are no comments for Property LeaseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LeaseId
        {
            get
            {
                return this._LeaseId;
            }
            set
            {
                this.OnLeaseIdChanging(value);
                this._LeaseId = value;
                this.OnLeaseIdChanged();
                this.OnPropertyChanged("LeaseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LeaseId;
        partial void OnLeaseIdChanging(string value);
        partial void OnLeaseIdChanged();
        /// <summary>
        /// There are no comments for Property LineLeaseCounter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int LineLeaseCounter
        {
            get
            {
                return this._LineLeaseCounter;
            }
            set
            {
                this.OnLineLeaseCounterChanging(value);
                this._LineLeaseCounter = value;
                this.OnLineLeaseCounterChanged();
                this.OnPropertyChanged("LineLeaseCounter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _LineLeaseCounter;
        partial void OnLineLeaseCounterChanging(int value);
        partial void OnLineLeaseCounterChanged();
        /// <summary>
        /// There are no comments for Property ScheduleLineDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ScheduleLineDate
        {
            get
            {
                return this._ScheduleLineDate;
            }
            set
            {
                this.OnScheduleLineDateChanging(value);
                this._ScheduleLineDate = value;
                this.OnScheduleLineDateChanged();
                this.OnPropertyChanged("ScheduleLineDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ScheduleLineDate;
        partial void OnScheduleLineDateChanging(global::System.DateTimeOffset value);
        partial void OnScheduleLineDateChanged();
        /// <summary>
        /// There are no comments for Property AmortizationExpenseReportingAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AmortizationExpenseReportingAmount
        {
            get
            {
                return this._AmortizationExpenseReportingAmount;
            }
            set
            {
                this.OnAmortizationExpenseReportingAmountChanging(value);
                this._AmortizationExpenseReportingAmount = value;
                this.OnAmortizationExpenseReportingAmountChanged();
                this.OnPropertyChanged("AmortizationExpenseReportingAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmortizationExpenseReportingAmount;
        partial void OnAmortizationExpenseReportingAmountChanging(decimal value);
        partial void OnAmortizationExpenseReportingAmountChanged();
        /// <summary>
        /// There are no comments for Property LeaseCounter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int LeaseCounter
        {
            get
            {
                return this._LeaseCounter;
            }
            set
            {
                this.OnLeaseCounterChanging(value);
                this._LeaseCounter = value;
                this.OnLeaseCounterChanged();
                this.OnPropertyChanged("LeaseCounter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _LeaseCounter;
        partial void OnLeaseCounterChanging(int value);
        partial void OnLeaseCounterChanged();
        /// <summary>
        /// There are no comments for Property ExchangeRateReporting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ExchangeRateReporting
        {
            get
            {
                return this._ExchangeRateReporting;
            }
            set
            {
                this.OnExchangeRateReportingChanging(value);
                this._ExchangeRateReporting = value;
                this.OnExchangeRateReportingChanged();
                this.OnPropertyChanged("ExchangeRateReporting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExchangeRateReporting;
        partial void OnExchangeRateReportingChanging(decimal value);
        partial void OnExchangeRateReportingChanged();
        /// <summary>
        /// There are no comments for Property Period in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Period
        {
            get
            {
                return this._Period;
            }
            set
            {
                this.OnPeriodChanging(value);
                this._Period = value;
                this.OnPeriodChanged();
                this.OnPropertyChanged("Period");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Period;
        partial void OnPeriodChanging(int value);
        partial void OnPeriodChanged();
        /// <summary>
        /// There are no comments for Property AssetROUAccountingAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AssetROUAccountingAmount
        {
            get
            {
                return this._AssetROUAccountingAmount;
            }
            set
            {
                this.OnAssetROUAccountingAmountChanging(value);
                this._AssetROUAccountingAmount = value;
                this.OnAssetROUAccountingAmountChanged();
                this.OnPropertyChanged("AssetROUAccountingAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AssetROUAccountingAmount;
        partial void OnAssetROUAccountingAmountChanging(decimal value);
        partial void OnAssetROUAccountingAmountChanged();
        /// <summary>
        /// There are no comments for Property AccumulatedAmortization in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AccumulatedAmortization
        {
            get
            {
                return this._AccumulatedAmortization;
            }
            set
            {
                this.OnAccumulatedAmortizationChanging(value);
                this._AccumulatedAmortization = value;
                this.OnAccumulatedAmortizationChanged();
                this.OnPropertyChanged("AccumulatedAmortization");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AccumulatedAmortization;
        partial void OnAccumulatedAmortizationChanging(decimal value);
        partial void OnAccumulatedAmortizationChanged();
        /// <summary>
        /// There are no comments for Property NetBookAccountingAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal NetBookAccountingAmount
        {
            get
            {
                return this._NetBookAccountingAmount;
            }
            set
            {
                this.OnNetBookAccountingAmountChanging(value);
                this._NetBookAccountingAmount = value;
                this.OnNetBookAccountingAmountChanged();
                this.OnPropertyChanged("NetBookAccountingAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _NetBookAccountingAmount;
        partial void OnNetBookAccountingAmountChanging(decimal value);
        partial void OnNetBookAccountingAmountChanged();
        /// <summary>
        /// There are no comments for Property NetBookReportingAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal NetBookReportingAmount
        {
            get
            {
                return this._NetBookReportingAmount;
            }
            set
            {
                this.OnNetBookReportingAmountChanging(value);
                this._NetBookReportingAmount = value;
                this.OnNetBookReportingAmountChanged();
                this.OnPropertyChanged("NetBookReportingAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _NetBookReportingAmount;
        partial void OnNetBookReportingAmountChanging(decimal value);
        partial void OnNetBookReportingAmountChanged();
        /// <summary>
        /// There are no comments for Property ExchangeRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ExchangeRate
        {
            get
            {
                return this._ExchangeRate;
            }
            set
            {
                this.OnExchangeRateChanging(value);
                this._ExchangeRate = value;
                this.OnExchangeRateChanged();
                this.OnPropertyChanged("ExchangeRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExchangeRate;
        partial void OnExchangeRateChanging(decimal value);
        partial void OnExchangeRateChanged();
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
        /// There are no comments for Property AccumulatedAmortizationAccountingAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AccumulatedAmortizationAccountingAmount
        {
            get
            {
                return this._AccumulatedAmortizationAccountingAmount;
            }
            set
            {
                this.OnAccumulatedAmortizationAccountingAmountChanging(value);
                this._AccumulatedAmortizationAccountingAmount = value;
                this.OnAccumulatedAmortizationAccountingAmountChanged();
                this.OnPropertyChanged("AccumulatedAmortizationAccountingAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AccumulatedAmortizationAccountingAmount;
        partial void OnAccumulatedAmortizationAccountingAmountChanging(decimal value);
        partial void OnAccumulatedAmortizationAccountingAmountChanged();
        /// <summary>
        /// There are no comments for Property AmortizationExpense in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AmortizationExpense
        {
            get
            {
                return this._AmortizationExpense;
            }
            set
            {
                this.OnAmortizationExpenseChanging(value);
                this._AmortizationExpense = value;
                this.OnAmortizationExpenseChanged();
                this.OnPropertyChanged("AmortizationExpense");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmortizationExpense;
        partial void OnAmortizationExpenseChanging(decimal value);
        partial void OnAmortizationExpenseChanged();
        /// <summary>
        /// There are no comments for Property AssetROUTransactionAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AssetROUTransactionAmount
        {
            get
            {
                return this._AssetROUTransactionAmount;
            }
            set
            {
                this.OnAssetROUTransactionAmountChanging(value);
                this._AssetROUTransactionAmount = value;
                this.OnAssetROUTransactionAmountChanged();
                this.OnPropertyChanged("AssetROUTransactionAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AssetROUTransactionAmount;
        partial void OnAssetROUTransactionAmountChanging(decimal value);
        partial void OnAssetROUTransactionAmountChanged();
        /// <summary>
        /// There are no comments for Property AssetROUReportingAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AssetROUReportingAmount
        {
            get
            {
                return this._AssetROUReportingAmount;
            }
            set
            {
                this.OnAssetROUReportingAmountChanging(value);
                this._AssetROUReportingAmount = value;
                this.OnAssetROUReportingAmountChanged();
                this.OnPropertyChanged("AssetROUReportingAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AssetROUReportingAmount;
        partial void OnAssetROUReportingAmountChanging(decimal value);
        partial void OnAssetROUReportingAmountChanged();
        /// <summary>
        /// There are no comments for Property LatestJournalNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LatestJournalNum
        {
            get
            {
                return this._LatestJournalNum;
            }
            set
            {
                this.OnLatestJournalNumChanging(value);
                this._LatestJournalNum = value;
                this.OnLatestJournalNumChanged();
                this.OnPropertyChanged("LatestJournalNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LatestJournalNum;
        partial void OnLatestJournalNumChanging(string value);
        partial void OnLatestJournalNumChanged();
        /// <summary>
        /// There are no comments for Property BeginningNetBookReportingAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal BeginningNetBookReportingAmount
        {
            get
            {
                return this._BeginningNetBookReportingAmount;
            }
            set
            {
                this.OnBeginningNetBookReportingAmountChanging(value);
                this._BeginningNetBookReportingAmount = value;
                this.OnBeginningNetBookReportingAmountChanged();
                this.OnPropertyChanged("BeginningNetBookReportingAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _BeginningNetBookReportingAmount;
        partial void OnBeginningNetBookReportingAmountChanging(decimal value);
        partial void OnBeginningNetBookReportingAmountChanged();
        /// <summary>
        /// There are no comments for Property AmortizationExpenseAccountingAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AmortizationExpenseAccountingAmount
        {
            get
            {
                return this._AmortizationExpenseAccountingAmount;
            }
            set
            {
                this.OnAmortizationExpenseAccountingAmountChanging(value);
                this._AmortizationExpenseAccountingAmount = value;
                this.OnAmortizationExpenseAccountingAmountChanged();
                this.OnPropertyChanged("AmortizationExpenseAccountingAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmortizationExpenseAccountingAmount;
        partial void OnAmortizationExpenseAccountingAmountChanging(decimal value);
        partial void OnAmortizationExpenseAccountingAmountChanged();
        /// <summary>
        /// There are no comments for Property BeginningNetBookAccountingAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal BeginningNetBookAccountingAmount
        {
            get
            {
                return this._BeginningNetBookAccountingAmount;
            }
            set
            {
                this.OnBeginningNetBookAccountingAmountChanging(value);
                this._BeginningNetBookAccountingAmount = value;
                this.OnBeginningNetBookAccountingAmountChanged();
                this.OnPropertyChanged("BeginningNetBookAccountingAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _BeginningNetBookAccountingAmount;
        partial void OnBeginningNetBookAccountingAmountChanging(decimal value);
        partial void OnBeginningNetBookAccountingAmountChanged();
        /// <summary>
        /// There are no comments for Property AccumulatedAmortizationReportingAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AccumulatedAmortizationReportingAmount
        {
            get
            {
                return this._AccumulatedAmortizationReportingAmount;
            }
            set
            {
                this.OnAccumulatedAmortizationReportingAmountChanging(value);
                this._AccumulatedAmortizationReportingAmount = value;
                this.OnAccumulatedAmortizationReportingAmountChanged();
                this.OnPropertyChanged("AccumulatedAmortizationReportingAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AccumulatedAmortizationReportingAmount;
        partial void OnAccumulatedAmortizationReportingAmountChanging(decimal value);
        partial void OnAccumulatedAmortizationReportingAmountChanged();
        /// <summary>
        /// There are no comments for Property Months in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Months
        {
            get
            {
                return this._Months;
            }
            set
            {
                this.OnMonthsChanging(value);
                this._Months = value;
                this.OnMonthsChanged();
                this.OnPropertyChanged("Months");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Months;
        partial void OnMonthsChanging(int value);
        partial void OnMonthsChanged();
        /// <summary>
        /// There are no comments for Property Reversed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Reversed
        {
            get
            {
                return this._Reversed;
            }
            set
            {
                this.OnReversedChanging(value);
                this._Reversed = value;
                this.OnReversedChanged();
                this.OnPropertyChanged("Reversed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Reversed;
        partial void OnReversedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnReversedChanged();
        /// <summary>
        /// There are no comments for Property NetBookValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal NetBookValue
        {
            get
            {
                return this._NetBookValue;
            }
            set
            {
                this.OnNetBookValueChanging(value);
                this._NetBookValue = value;
                this.OnNetBookValueChanged();
                this.OnPropertyChanged("NetBookValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _NetBookValue;
        partial void OnNetBookValueChanging(decimal value);
        partial void OnNetBookValueChanged();
        /// <summary>
        /// There are no comments for Property JournalPosted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> JournalPosted
        {
            get
            {
                return this._JournalPosted;
            }
            set
            {
                this.OnJournalPostedChanging(value);
                this._JournalPosted = value;
                this.OnJournalPostedChanged();
                this.OnPropertyChanged("JournalPosted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _JournalPosted;
        partial void OnJournalPostedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnJournalPostedChanged();
        /// <summary>
        /// There are no comments for Property JournalNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalNum
        {
            get
            {
                return this._JournalNum;
            }
            set
            {
                this.OnJournalNumChanging(value);
                this._JournalNum = value;
                this.OnJournalNumChanged();
                this.OnPropertyChanged("JournalNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalNum;
        partial void OnJournalNumChanging(string value);
        partial void OnJournalNumChanged();
        /// <summary>
        /// There are no comments for Property JournalCreated in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> JournalCreated
        {
            get
            {
                return this._JournalCreated;
            }
            set
            {
                this.OnJournalCreatedChanging(value);
                this._JournalCreated = value;
                this.OnJournalCreatedChanged();
                this.OnPropertyChanged("JournalCreated");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _JournalCreated;
        partial void OnJournalCreatedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnJournalCreatedChanged();
        /// <summary>
        /// There are no comments for Property BeginningNetBookValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal BeginningNetBookValue
        {
            get
            {
                return this._BeginningNetBookValue;
            }
            set
            {
                this.OnBeginningNetBookValueChanging(value);
                this._BeginningNetBookValue = value;
                this.OnBeginningNetBookValueChanged();
                this.OnPropertyChanged("BeginningNetBookValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _BeginningNetBookValue;
        partial void OnBeginningNetBookValueChanging(decimal value);
        partial void OnBeginningNetBookValueChanged();
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
