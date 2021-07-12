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
        /// There are no comments for TrvRequisitionLineSingle in the schema.
        /// </summary>
    public partial class TrvRequisitionLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TrvRequisitionLine>
    {
        /// <summary>
        /// Initialize a new TrvRequisitionLineSingle object.
        /// </summary>
        public TrvRequisitionLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TrvRequisitionLineSingle object.
        /// </summary>
        public TrvRequisitionLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TrvRequisitionLineSingle object.
        /// </summary>
        public TrvRequisitionLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TrvRequisitionLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
        /// <summary>
        /// There are no comments for TrvRequisitionLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TransactionCurrencyAmount
    /// TransactionCurrencyCode
    /// TrvRequisitionTable_RequisitionNumber
    /// LegalEntity1_DataArea
    /// Category
    /// LegalEntity_DataArea
    /// EstimatedDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TransactionCurrencyAmount", "TransactionCurrencyCode", "TrvRequisitionTable_RequisitionNumber", "LegalEntity1_DataArea", "Category", "LegalEntity_DataArea", "EstimatedDate")]
    [global::Microsoft.OData.Client.EntitySet("TrvRequisitionLines")]
    public partial class TrvRequisitionLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TrvRequisitionLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="transactionCurrencyAmount">Initial value of TransactionCurrencyAmount.</param>
        /// <param name="transactionCurrencyCode">Initial value of TransactionCurrencyCode.</param>
        /// <param name="trvRequisitionTable_RequisitionNumber">Initial value of TrvRequisitionTable_RequisitionNumber.</param>
        /// <param name="legalEntity1_DataArea">Initial value of LegalEntity1_DataArea.</param>
        /// <param name="category">Initial value of Category.</param>
        /// <param name="legalEntity_DataArea">Initial value of LegalEntity_DataArea.</param>
        /// <param name="estimatedDate">Initial value of EstimatedDate.</param>
        /// <param name="mileage">Initial value of Mileage.</param>
        /// <param name="accountingCurrencyAmount">Initial value of AccountingCurrencyAmount.</param>
        /// <param name="perdiemDateFrom">Initial value of PerdiemDateFrom.</param>
        /// <param name="mileageRate">Initial value of MileageRate.</param>
        /// <param name="exchangeRate">Initial value of ExchangeRate.</param>
        /// <param name="perdiemDateTo">Initial value of PerdiemDateTo.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TrvRequisitionLine CreateTrvRequisitionLine(string dataAreaId, 
                    decimal transactionCurrencyAmount, 
                    string transactionCurrencyCode, 
                    string trvRequisitionTable_RequisitionNumber, 
                    string legalEntity1_DataArea, 
                    string category, 
                    string legalEntity_DataArea, 
                    global::System.DateTimeOffset estimatedDate, 
                    decimal mileage, 
                    decimal accountingCurrencyAmount, 
                    global::System.DateTimeOffset perdiemDateFrom, 
                    decimal mileageRate, 
                    decimal exchangeRate, 
                    global::System.DateTimeOffset perdiemDateTo)
        {
            TrvRequisitionLine trvRequisitionLine = new TrvRequisitionLine();
            trvRequisitionLine.dataAreaId = dataAreaId;
            trvRequisitionLine.TransactionCurrencyAmount = transactionCurrencyAmount;
            trvRequisitionLine.TransactionCurrencyCode = transactionCurrencyCode;
            trvRequisitionLine.TrvRequisitionTable_RequisitionNumber = trvRequisitionTable_RequisitionNumber;
            trvRequisitionLine.LegalEntity1_DataArea = legalEntity1_DataArea;
            trvRequisitionLine.Category = category;
            trvRequisitionLine.LegalEntity_DataArea = legalEntity_DataArea;
            trvRequisitionLine.EstimatedDate = estimatedDate;
            trvRequisitionLine.Mileage = mileage;
            trvRequisitionLine.AccountingCurrencyAmount = accountingCurrencyAmount;
            trvRequisitionLine.PerdiemDateFrom = perdiemDateFrom;
            trvRequisitionLine.MileageRate = mileageRate;
            trvRequisitionLine.ExchangeRate = exchangeRate;
            trvRequisitionLine.PerdiemDateTo = perdiemDateTo;
            return trvRequisitionLine;
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
        /// There are no comments for Property TrvRequisitionTable_RequisitionNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TrvRequisitionTable_RequisitionNumber
        {
            get
            {
                return this._TrvRequisitionTable_RequisitionNumber;
            }
            set
            {
                this.OnTrvRequisitionTable_RequisitionNumberChanging(value);
                this._TrvRequisitionTable_RequisitionNumber = value;
                this.OnTrvRequisitionTable_RequisitionNumberChanged();
                this.OnPropertyChanged("TrvRequisitionTable_RequisitionNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TrvRequisitionTable_RequisitionNumber;
        partial void OnTrvRequisitionTable_RequisitionNumberChanging(string value);
        partial void OnTrvRequisitionTable_RequisitionNumberChanged();
        /// <summary>
        /// There are no comments for Property LegalEntity1_DataArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntity1_DataArea
        {
            get
            {
                return this._LegalEntity1_DataArea;
            }
            set
            {
                this.OnLegalEntity1_DataAreaChanging(value);
                this._LegalEntity1_DataArea = value;
                this.OnLegalEntity1_DataAreaChanged();
                this.OnPropertyChanged("LegalEntity1_DataArea");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntity1_DataArea;
        partial void OnLegalEntity1_DataAreaChanging(string value);
        partial void OnLegalEntity1_DataAreaChanged();
        /// <summary>
        /// There are no comments for Property Category in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this.OnCategoryChanging(value);
                this._Category = value;
                this.OnCategoryChanged();
                this.OnPropertyChanged("Category");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Category;
        partial void OnCategoryChanging(string value);
        partial void OnCategoryChanged();
        /// <summary>
        /// There are no comments for Property LegalEntity_DataArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntity_DataArea
        {
            get
            {
                return this._LegalEntity_DataArea;
            }
            set
            {
                this.OnLegalEntity_DataAreaChanging(value);
                this._LegalEntity_DataArea = value;
                this.OnLegalEntity_DataAreaChanged();
                this.OnPropertyChanged("LegalEntity_DataArea");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntity_DataArea;
        partial void OnLegalEntity_DataAreaChanging(string value);
        partial void OnLegalEntity_DataAreaChanged();
        /// <summary>
        /// There are no comments for Property EstimatedDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EstimatedDate
        {
            get
            {
                return this._EstimatedDate;
            }
            set
            {
                this.OnEstimatedDateChanging(value);
                this._EstimatedDate = value;
                this.OnEstimatedDateChanged();
                this.OnPropertyChanged("EstimatedDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EstimatedDate;
        partial void OnEstimatedDateChanging(global::System.DateTimeOffset value);
        partial void OnEstimatedDateChanged();
        /// <summary>
        /// There are no comments for Property Mileage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Mileage
        {
            get
            {
                return this._Mileage;
            }
            set
            {
                this.OnMileageChanging(value);
                this._Mileage = value;
                this.OnMileageChanged();
                this.OnPropertyChanged("Mileage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Mileage;
        partial void OnMileageChanging(decimal value);
        partial void OnMileageChanged();
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
        /// There are no comments for Property ReconciliationStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvRequisitionReconciliationStatus> ReconciliationStatus
        {
            get
            {
                return this._ReconciliationStatus;
            }
            set
            {
                this.OnReconciliationStatusChanging(value);
                this._ReconciliationStatus = value;
                this.OnReconciliationStatusChanged();
                this.OnPropertyChanged("ReconciliationStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvRequisitionReconciliationStatus> _ReconciliationStatus;
        partial void OnReconciliationStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvRequisitionReconciliationStatus> value);
        partial void OnReconciliationStatusChanged();
        /// <summary>
        /// There are no comments for Property ProjLinePropertyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjLinePropertyId
        {
            get
            {
                return this._ProjLinePropertyId;
            }
            set
            {
                this.OnProjLinePropertyIdChanging(value);
                this._ProjLinePropertyId = value;
                this.OnProjLinePropertyIdChanged();
                this.OnPropertyChanged("ProjLinePropertyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjLinePropertyId;
        partial void OnProjLinePropertyIdChanging(string value);
        partial void OnProjLinePropertyIdChanged();
        /// <summary>
        /// There are no comments for Property PerdiemDateFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset PerdiemDateFrom
        {
            get
            {
                return this._PerdiemDateFrom;
            }
            set
            {
                this.OnPerdiemDateFromChanging(value);
                this._PerdiemDateFrom = value;
                this.OnPerdiemDateFromChanged();
                this.OnPropertyChanged("PerdiemDateFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PerdiemDateFrom;
        partial void OnPerdiemDateFromChanging(global::System.DateTimeOffset value);
        partial void OnPerdiemDateFromChanged();
        /// <summary>
        /// There are no comments for Property MileageRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MileageRate
        {
            get
            {
                return this._MileageRate;
            }
            set
            {
                this.OnMileageRateChanging(value);
                this._MileageRate = value;
                this.OnMileageRateChanged();
                this.OnPropertyChanged("MileageRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MileageRate;
        partial void OnMileageRateChanging(decimal value);
        partial void OnMileageRateChanged();
        /// <summary>
        /// There are no comments for Property AirlineServiceClass in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvAirlineServiceClassEnum> AirlineServiceClass
        {
            get
            {
                return this._AirlineServiceClass;
            }
            set
            {
                this.OnAirlineServiceClassChanging(value);
                this._AirlineServiceClass = value;
                this.OnAirlineServiceClassChanged();
                this.OnPropertyChanged("AirlineServiceClass");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvAirlineServiceClassEnum> _AirlineServiceClass;
        partial void OnAirlineServiceClassChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvAirlineServiceClassEnum> value);
        partial void OnAirlineServiceClassChanged();
        /// <summary>
        /// There are no comments for Property ProjTable_ProjId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjTable_ProjId
        {
            get
            {
                return this._ProjTable_ProjId;
            }
            set
            {
                this.OnProjTable_ProjIdChanging(value);
                this._ProjTable_ProjId = value;
                this.OnProjTable_ProjIdChanged();
                this.OnPropertyChanged("ProjTable_ProjId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjTable_ProjId;
        partial void OnProjTable_ProjIdChanging(string value);
        partial void OnProjTable_ProjIdChanged();
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
        /// There are no comments for Property ProjPolicyText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjPolicyText
        {
            get
            {
                return this._ProjPolicyText;
            }
            set
            {
                this.OnProjPolicyTextChanging(value);
                this._ProjPolicyText = value;
                this.OnProjPolicyTextChanged();
                this.OnPropertyChanged("ProjPolicyText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjPolicyText;
        partial void OnProjPolicyTextChanging(string value);
        partial void OnProjPolicyTextChanged();
        /// <summary>
        /// There are no comments for Property ProjPolicyStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjExpPolicyStatus> ProjPolicyStatus
        {
            get
            {
                return this._ProjPolicyStatus;
            }
            set
            {
                this.OnProjPolicyStatusChanging(value);
                this._ProjPolicyStatus = value;
                this.OnProjPolicyStatusChanged();
                this.OnPropertyChanged("ProjPolicyStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjExpPolicyStatus> _ProjPolicyStatus;
        partial void OnProjPolicyStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjExpPolicyStatus> value);
        partial void OnProjPolicyStatusChanged();
        /// <summary>
        /// There are no comments for Property CarRentalVehicleClass in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvCarRentalVehicleClassEnum> CarRentalVehicleClass
        {
            get
            {
                return this._CarRentalVehicleClass;
            }
            set
            {
                this.OnCarRentalVehicleClassChanging(value);
                this._CarRentalVehicleClass = value;
                this.OnCarRentalVehicleClassChanged();
                this.OnPropertyChanged("CarRentalVehicleClass");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvCarRentalVehicleClassEnum> _CarRentalVehicleClass;
        partial void OnCarRentalVehicleClassChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvCarRentalVehicleClassEnum> value);
        partial void OnCarRentalVehicleClassChanged();
        /// <summary>
        /// There are no comments for Property PerdiemDateTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset PerdiemDateTo
        {
            get
            {
                return this._PerdiemDateTo;
            }
            set
            {
                this.OnPerdiemDateToChanging(value);
                this._PerdiemDateTo = value;
                this.OnPerdiemDateToChanged();
                this.OnPropertyChanged("PerdiemDateTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PerdiemDateTo;
        partial void OnPerdiemDateToChanging(global::System.DateTimeOffset value);
        partial void OnPerdiemDateToChanged();
        /// <summary>
        /// There are no comments for Property ReferenceDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReferenceDataAreaId
        {
            get
            {
                return this._ReferenceDataAreaId;
            }
            set
            {
                this.OnReferenceDataAreaIdChanging(value);
                this._ReferenceDataAreaId = value;
                this.OnReferenceDataAreaIdChanged();
                this.OnPropertyChanged("ReferenceDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReferenceDataAreaId;
        partial void OnReferenceDataAreaIdChanging(string value);
        partial void OnReferenceDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property IsBudgetCheckPending in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsBudgetCheckPending
        {
            get
            {
                return this._IsBudgetCheckPending;
            }
            set
            {
                this.OnIsBudgetCheckPendingChanging(value);
                this._IsBudgetCheckPending = value;
                this.OnIsBudgetCheckPendingChanged();
                this.OnPropertyChanged("IsBudgetCheckPending");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsBudgetCheckPending;
        partial void OnIsBudgetCheckPendingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsBudgetCheckPendingChanged();
        /// <summary>
        /// There are no comments for Property Merchant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Merchant
        {
            get
            {
                return this._Merchant;
            }
            set
            {
                this.OnMerchantChanging(value);
                this._Merchant = value;
                this.OnMerchantChanged();
                this.OnPropertyChanged("Merchant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Merchant;
        partial void OnMerchantChanging(string value);
        partial void OnMerchantChanged();
        /// <summary>
        /// There are no comments for Property ProjActivityNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjActivityNumber
        {
            get
            {
                return this._ProjActivityNumber;
            }
            set
            {
                this.OnProjActivityNumberChanging(value);
                this._ProjActivityNumber = value;
                this.OnProjActivityNumberChanged();
                this.OnPropertyChanged("ProjActivityNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjActivityNumber;
        partial void OnProjActivityNumberChanging(string value);
        partial void OnProjActivityNumberChanged();
        /// <summary>
        /// There are no comments for Property DefaultDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultDimensionDisplayValue
        {
            get
            {
                return this._DefaultDimensionDisplayValue;
            }
            set
            {
                this.OnDefaultDimensionDisplayValueChanging(value);
                this._DefaultDimensionDisplayValue = value;
                this.OnDefaultDimensionDisplayValueChanged();
                this.OnPropertyChanged("DefaultDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultDimensionDisplayValue;
        partial void OnDefaultDimensionDisplayValueChanging(string value);
        partial void OnDefaultDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property ExpType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvExpType> ExpType
        {
            get
            {
                return this._ExpType;
            }
            set
            {
                this.OnExpTypeChanging(value);
                this._ExpType = value;
                this.OnExpTypeChanged();
                this.OnPropertyChanged("ExpType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvExpType> _ExpType;
        partial void OnExpTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvExpType> value);
        partial void OnExpTypeChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
