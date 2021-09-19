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
        /// There are no comments for LeaseExpenseCostScheduleHistorySingle in the schema.
        /// </summary>
    public partial class LeaseExpenseCostScheduleHistorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LeaseExpenseCostScheduleHistory>
    {
        /// <summary>
        /// Initialize a new LeaseExpenseCostScheduleHistorySingle object.
        /// </summary>
        public LeaseExpenseCostScheduleHistorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeaseExpenseCostScheduleHistorySingle object.
        /// </summary>
        public LeaseExpenseCostScheduleHistorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeaseExpenseCostScheduleHistorySingle object.
        /// </summary>
        public LeaseExpenseCostScheduleHistorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LeaseExpenseCostScheduleHistory> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for LeaseExpenseCostScheduleHistory in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LeaseId
    /// LineLeaseCounter
    /// ScheduleLineDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LeaseId", "LineLeaseCounter", "ScheduleLineDate")]
    [global::Microsoft.OData.Client.EntitySet("LeaseExpenseCostSchedulesHistory")]
    public partial class LeaseExpenseCostScheduleHistory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeaseExpenseCostScheduleHistory object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="leaseId">Initial value of LeaseId.</param>
        /// <param name="lineLeaseCounter">Initial value of LineLeaseCounter.</param>
        /// <param name="scheduleLineDate">Initial value of ScheduleLineDate.</param>
        /// <param name="leaseCounter">Initial value of LeaseCounter.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeaseExpenseCostScheduleHistory CreateLeaseExpenseCostScheduleHistory(string dataAreaId, string leaseId, int lineLeaseCounter, global::System.DateTimeOffset scheduleLineDate, int leaseCounter)
        {
            LeaseExpenseCostScheduleHistory leaseExpenseCostScheduleHistory = new LeaseExpenseCostScheduleHistory();
            leaseExpenseCostScheduleHistory.dataAreaId = dataAreaId;
            leaseExpenseCostScheduleHistory.LeaseId = leaseId;
            leaseExpenseCostScheduleHistory.LineLeaseCounter = lineLeaseCounter;
            leaseExpenseCostScheduleHistory.ScheduleLineDate = scheduleLineDate;
            leaseExpenseCostScheduleHistory.LeaseCounter = leaseCounter;
            return leaseExpenseCostScheduleHistory;
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