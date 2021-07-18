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
        /// There are no comments for LeasePaymentScheduleContractImportSingle in the schema.
        /// </summary>
    public partial class LeasePaymentScheduleContractImportSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LeasePaymentScheduleContractImport>
    {
        /// <summary>
        /// Initialize a new LeasePaymentScheduleContractImportSingle object.
        /// </summary>
        public LeasePaymentScheduleContractImportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeasePaymentScheduleContractImportSingle object.
        /// </summary>
        public LeasePaymentScheduleContractImportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeasePaymentScheduleContractImportSingle object.
        /// </summary>
        public LeasePaymentScheduleContractImportSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LeasePaymentScheduleContractImport> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for LeasePaymentScheduleContractImport in the schema.
        /// </summary>
    /// <KeyProperties>
    /// LeaseId
    /// StartDate
    /// ImportId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LeaseId", "StartDate", "ImportId")]
    [global::Microsoft.OData.Client.EntitySet("LeasePaymentScheduleContractImports")]
    public partial class LeasePaymentScheduleContractImport : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeasePaymentScheduleContractImport object.
        /// </summary>
        /// <param name="leaseId">Initial value of LeaseId.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="importId">Initial value of ImportId.</param>
        /// <param name="variablePayment">Initial value of VariablePayment.</param>
        /// <param name="periods">Initial value of Periods.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="paymentAmount">Initial value of PaymentAmount.</param>
        /// <param name="costPerUnit">Initial value of CostPerUnit.</param>
        /// <param name="indexRate">Initial value of IndexRate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeasePaymentScheduleContractImport CreateLeasePaymentScheduleContractImport(string leaseId, 
                    global::System.DateTimeOffset startDate, 
                    string importId, 
                    decimal variablePayment, 
                    int periods, 
                    global::System.DateTimeOffset endDate, 
                    decimal paymentAmount, 
                    decimal costPerUnit, 
                    decimal indexRate)
        {
            LeasePaymentScheduleContractImport leasePaymentScheduleContractImport = new LeasePaymentScheduleContractImport();
            leasePaymentScheduleContractImport.LeaseId = leaseId;
            leasePaymentScheduleContractImport.StartDate = startDate;
            leasePaymentScheduleContractImport.ImportId = importId;
            leasePaymentScheduleContractImport.VariablePayment = variablePayment;
            leasePaymentScheduleContractImport.Periods = periods;
            leasePaymentScheduleContractImport.EndDate = endDate;
            leasePaymentScheduleContractImport.PaymentAmount = paymentAmount;
            leasePaymentScheduleContractImport.CostPerUnit = costPerUnit;
            leasePaymentScheduleContractImport.IndexRate = indexRate;
            return leasePaymentScheduleContractImport;
        }
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
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property ImportId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ImportId
        {
            get
            {
                return this._ImportId;
            }
            set
            {
                this.OnImportIdChanging(value);
                this._ImportId = value;
                this.OnImportIdChanged();
                this.OnPropertyChanged("ImportId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ImportId;
        partial void OnImportIdChanging(string value);
        partial void OnImportIdChanged();
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
        /// There are no comments for Property Periods in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property EndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property PaymentAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property CostPerUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property IndexRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
