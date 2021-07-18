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
        /// There are no comments for LeaseExpenseScheduleSingle in the schema.
        /// </summary>
    public partial class LeaseExpenseScheduleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LeaseExpenseSchedule>
    {
        /// <summary>
        /// Initialize a new LeaseExpenseScheduleSingle object.
        /// </summary>
        public LeaseExpenseScheduleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeaseExpenseScheduleSingle object.
        /// </summary>
        public LeaseExpenseScheduleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeaseExpenseScheduleSingle object.
        /// </summary>
        public LeaseExpenseScheduleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LeaseExpenseSchedule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionCombinationEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombinationEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombinationEntity == null))
                {
                    this._DimensionCombinationEntity = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombinationEntity"));
                }
                return this._DimensionCombinationEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombinationEntity;
    }
        /// <summary>
        /// There are no comments for LeaseExpenseSchedule in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LineNumber
    /// LeaseId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LineNumber", "LeaseId")]
    [global::Microsoft.OData.Client.EntitySet("LeaseExpenseSchedules")]
    public partial class LeaseExpenseSchedule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeaseExpenseSchedule object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="leaseId">Initial value of LeaseId.</param>
        /// <param name="scheduleLineDate">Initial value of ScheduleLineDate.</param>
        /// <param name="paymentAmount">Initial value of PaymentAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeaseExpenseSchedule CreateLeaseExpenseSchedule(string dataAreaId, int lineNumber, string leaseId, global::System.DateTimeOffset scheduleLineDate, decimal paymentAmount)
        {
            LeaseExpenseSchedule leaseExpenseSchedule = new LeaseExpenseSchedule();
            leaseExpenseSchedule.dataAreaId = dataAreaId;
            leaseExpenseSchedule.LineNumber = lineNumber;
            leaseExpenseSchedule.LeaseId = leaseId;
            leaseExpenseSchedule.ScheduleLineDate = scheduleLineDate;
            leaseExpenseSchedule.PaymentAmount = paymentAmount;
            return leaseExpenseSchedule;
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
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int LineNumber
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
        private int _LineNumber;
        partial void OnLineNumberChanging(int value);
        partial void OnLineNumberChanged();
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
        /// There are no comments for Property Invoice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Invoice
        {
            get
            {
                return this._Invoice;
            }
            set
            {
                this.OnInvoiceChanging(value);
                this._Invoice = value;
                this.OnInvoiceChanged();
                this.OnPropertyChanged("Invoice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Invoice;
        partial void OnInvoiceChanging(string value);
        partial void OnInvoiceChanged();
        /// <summary>
        /// There are no comments for Property JournalBatchNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalBatchNumber
        {
            get
            {
                return this._JournalBatchNumber;
            }
            set
            {
                this.OnJournalBatchNumberChanging(value);
                this._JournalBatchNumber = value;
                this.OnJournalBatchNumberChanged();
                this.OnPropertyChanged("JournalBatchNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalBatchNumber;
        partial void OnJournalBatchNumberChanging(string value);
        partial void OnJournalBatchNumberChanged();
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
        /// There are no comments for Property ExpenseType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ExpenseType
        {
            get
            {
                return this._ExpenseType;
            }
            set
            {
                this.OnExpenseTypeChanging(value);
                this._ExpenseType = value;
                this.OnExpenseTypeChanged();
                this.OnPropertyChanged("ExpenseType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExpenseType;
        partial void OnExpenseTypeChanging(string value);
        partial void OnExpenseTypeChanged();
        /// <summary>
        /// There are no comments for Property OffsetAccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> OffsetAccountType
        {
            get
            {
                return this._OffsetAccountType;
            }
            set
            {
                this.OnOffsetAccountTypeChanging(value);
                this._OffsetAccountType = value;
                this.OnOffsetAccountTypeChanged();
                this.OnPropertyChanged("OffsetAccountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> _OffsetAccountType;
        partial void OnOffsetAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> value);
        partial void OnOffsetAccountTypeChanged();
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
        /// There are no comments for Property OffsetLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OffsetLedgerDimensionDisplayValue
        {
            get
            {
                return this._OffsetLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnOffsetLedgerDimensionDisplayValueChanging(value);
                this._OffsetLedgerDimensionDisplayValue = value;
                this.OnOffsetLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("OffsetLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OffsetLedgerDimensionDisplayValue;
        partial void OnOffsetLedgerDimensionDisplayValueChanging(string value);
        partial void OnOffsetLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombinationEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombinationEntity
        {
            get
            {
                return this._DimensionCombinationEntity;
            }
            set
            {
                this.OnDimensionCombinationEntityChanging(value);
                this._DimensionCombinationEntity = value;
                this.OnDimensionCombinationEntityChanged();
                this.OnPropertyChanged("DimensionCombinationEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombinationEntity;
        partial void OnDimensionCombinationEntityChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationEntityChanged();
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
