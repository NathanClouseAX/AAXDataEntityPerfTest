﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/28/2021 8:55:09 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for LeasePaymentScheduleContractHistorySingle in the schema.
    /// </summary>
    public partial class LeasePaymentScheduleContractHistorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LeasePaymentScheduleContractHistory>
    {
        /// <summary>
        /// Initialize a new LeasePaymentScheduleContractHistorySingle object.
        /// </summary>
        public LeasePaymentScheduleContractHistorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeasePaymentScheduleContractHistorySingle object.
        /// </summary>
        public LeasePaymentScheduleContractHistorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeasePaymentScheduleContractHistorySingle object.
        /// </summary>
        public LeasePaymentScheduleContractHistorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LeasePaymentScheduleContractHistory> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for LeasePaymentScheduleContractHistory in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LeaseId
    /// LeaseCounter
    /// StartDate
    /// EndDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LeaseId", "LeaseCounter", "StartDate", "EndDate")]
    [global::Microsoft.OData.Client.EntitySet("LeasePaymentScheduleContractsHistory")]
    public partial class LeasePaymentScheduleContractHistory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeasePaymentScheduleContractHistory object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="leaseId">Initial value of LeaseId.</param>
        /// <param name="leaseCounter">Initial value of LeaseCounter.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="costPerUnit">Initial value of CostPerUnit.</param>
        /// <param name="indexRate">Initial value of IndexRate.</param>
        /// <param name="paymentAmount">Initial value of PaymentAmount.</param>
        /// <param name="periods">Initial value of Periods.</param>
        /// <param name="variablePayment">Initial value of VariablePayment.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeasePaymentScheduleContractHistory CreateLeasePaymentScheduleContractHistory(string dataAreaId, 
                    string leaseId, 
                    int leaseCounter, 
                    global::System.DateTimeOffset startDate, 
                    global::System.DateTimeOffset endDate, 
                    decimal costPerUnit, 
                    decimal indexRate, 
                    decimal paymentAmount, 
                    int periods, 
                    decimal variablePayment)
        {
            LeasePaymentScheduleContractHistory leasePaymentScheduleContractHistory = new LeasePaymentScheduleContractHistory();
            leasePaymentScheduleContractHistory.dataAreaId = dataAreaId;
            leasePaymentScheduleContractHistory.LeaseId = leaseId;
            leasePaymentScheduleContractHistory.LeaseCounter = leaseCounter;
            leasePaymentScheduleContractHistory.StartDate = startDate;
            leasePaymentScheduleContractHistory.EndDate = endDate;
            leasePaymentScheduleContractHistory.CostPerUnit = costPerUnit;
            leasePaymentScheduleContractHistory.IndexRate = indexRate;
            leasePaymentScheduleContractHistory.PaymentAmount = paymentAmount;
            leasePaymentScheduleContractHistory.Periods = periods;
            leasePaymentScheduleContractHistory.VariablePayment = variablePayment;
            return leasePaymentScheduleContractHistory;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "dataAreaId is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LeaseId is required.")]
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
        /// There are no comments for Property LeaseCounter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LeaseCounter is required.")]
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
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StartDate is required.")]
        public virtual global::System.DateTimeOffset StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDate;
        partial void OnStartDateChanging(global::System.DateTimeOffset value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property EndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EndDate is required.")]
        public virtual global::System.DateTimeOffset EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this.OnEndDateChanging(value);
                this._EndDate = value;
                this.OnEndDateChanged();
                this.OnPropertyChanged("EndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EndDate;
        partial void OnEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEndDateChanged();
        /// <summary>
        /// There are no comments for Property CostPerUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CostPerUnit is required.")]
        public virtual decimal CostPerUnit
        {
            get
            {
                return this._CostPerUnit;
            }
            set
            {
                this.OnCostPerUnitChanging(value);
                this._CostPerUnit = value;
                this.OnCostPerUnitChanged();
                this.OnPropertyChanged("CostPerUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CostPerUnit;
        partial void OnCostPerUnitChanging(decimal value);
        partial void OnCostPerUnitChanged();
        /// <summary>
        /// There are no comments for Property IndexRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "IndexRate is required.")]
        public virtual decimal IndexRate
        {
            get
            {
                return this._IndexRate;
            }
            set
            {
                this.OnIndexRateChanging(value);
                this._IndexRate = value;
                this.OnIndexRateChanged();
                this.OnPropertyChanged("IndexRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _IndexRate;
        partial void OnIndexRateChanging(decimal value);
        partial void OnIndexRateChanged();
        /// <summary>
        /// There are no comments for Property PaymentAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PaymentAmount is required.")]
        public virtual decimal PaymentAmount
        {
            get
            {
                return this._PaymentAmount;
            }
            set
            {
                this.OnPaymentAmountChanging(value);
                this._PaymentAmount = value;
                this.OnPaymentAmountChanged();
                this.OnPropertyChanged("PaymentAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PaymentAmount;
        partial void OnPaymentAmountChanging(decimal value);
        partial void OnPaymentAmountChanged();
        /// <summary>
        /// There are no comments for Property Term in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string Term
        {
            get
            {
                return this._Term;
            }
            set
            {
                this.OnTermChanging(value);
                this._Term = value;
                this.OnTermChanged();
                this.OnPropertyChanged("Term");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Term;
        partial void OnTermChanging(string value);
        partial void OnTermChanged();
        /// <summary>
        /// There are no comments for Property RecordCreatedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLeaseCreatedBy> RecordCreatedBy
        {
            get
            {
                return this._RecordCreatedBy;
            }
            set
            {
                this.OnRecordCreatedByChanging(value);
                this._RecordCreatedBy = value;
                this.OnRecordCreatedByChanged();
                this.OnPropertyChanged("RecordCreatedBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLeaseCreatedBy> _RecordCreatedBy;
        partial void OnRecordCreatedByChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLeaseCreatedBy> value);
        partial void OnRecordCreatedByChanged();
        /// <summary>
        /// There are no comments for Property Interval in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLeaseLeaseTermInterval> Interval
        {
            get
            {
                return this._Interval;
            }
            set
            {
                this.OnIntervalChanging(value);
                this._Interval = value;
                this.OnIntervalChanged();
                this.OnPropertyChanged("Interval");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLeaseLeaseTermInterval> _Interval;
        partial void OnIntervalChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLeaseLeaseTermInterval> value);
        partial void OnIntervalChanged();
        /// <summary>
        /// There are no comments for Property IndexType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string IndexType
        {
            get
            {
                return this._IndexType;
            }
            set
            {
                this.OnIndexTypeChanging(value);
                this._IndexType = value;
                this.OnIndexTypeChanged();
                this.OnPropertyChanged("IndexType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IndexType;
        partial void OnIndexTypeChanging(string value);
        partial void OnIndexTypeChanged();
        /// <summary>
        /// There are no comments for Property Periods in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Periods is required.")]
        public virtual int Periods
        {
            get
            {
                return this._Periods;
            }
            set
            {
                this.OnPeriodsChanging(value);
                this._Periods = value;
                this.OnPeriodsChanged();
                this.OnPropertyChanged("Periods");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Periods;
        partial void OnPeriodsChanging(int value);
        partial void OnPeriodsChanged();
        /// <summary>
        /// There are no comments for Property Frequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLeasePaymentFrequency> Frequency
        {
            get
            {
                return this._Frequency;
            }
            set
            {
                this.OnFrequencyChanging(value);
                this._Frequency = value;
                this.OnFrequencyChanged();
                this.OnPropertyChanged("Frequency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLeasePaymentFrequency> _Frequency;
        partial void OnFrequencyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLeasePaymentFrequency> value);
        partial void OnFrequencyChanged();
        /// <summary>
        /// There are no comments for Property Excercise in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYesCombo> Excercise
        {
            get
            {
                return this._Excercise;
            }
            set
            {
                this.OnExcerciseChanging(value);
                this._Excercise = value;
                this.OnExcerciseChanged();
                this.OnPropertyChanged("Excercise");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYesCombo> _Excercise;
        partial void OnExcerciseChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYesCombo> value);
        partial void OnExcerciseChanged();
        /// <summary>
        /// There are no comments for Property VariablePayment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VariablePayment is required.")]
        public virtual decimal VariablePayment
        {
            get
            {
                return this._VariablePayment;
            }
            set
            {
                this.OnVariablePaymentChanging(value);
                this._VariablePayment = value;
                this.OnVariablePaymentChanged();
                this.OnPropertyChanged("VariablePayment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _VariablePayment;
        partial void OnVariablePaymentChanging(decimal value);
        partial void OnVariablePaymentChanged();
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
