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
        /// There are no comments for BatchJobSingle in the schema.
        /// </summary>
    public partial class BatchJobSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BatchJob>
    {
        /// <summary>
        /// Initialize a new BatchJobSingle object.
        /// </summary>
        public BatchJobSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BatchJobSingle object.
        /// </summary>
        public BatchJobSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BatchJobSingle object.
        /// </summary>
        public BatchJobSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BatchJob> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for BatchJob in the schema.
        /// </summary>
    /// <KeyProperties>
    /// BatchJobRecId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BatchJobRecId")]
    [global::Microsoft.OData.Client.EntitySet("BatchJobs")]
    public partial class BatchJob : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BatchJob object.
        /// </summary>
        /// <param name="batchJobRecId">Initial value of BatchJobRecId.</param>
        /// <param name="finishing">Initial value of Finishing.</param>
        /// <param name="startDateTime">Initial value of StartDateTime.</param>
        /// <param name="startTime">Initial value of StartTime.</param>
        /// <param name="endDateTime">Initial value of EndDateTime.</param>
        /// <param name="origStartDateTime">Initial value of OrigStartDateTime.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="runtimeJob">Initial value of RuntimeJob.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BatchJob CreateBatchJob(long batchJobRecId, 
                    int finishing, 
                    global::System.DateTimeOffset startDateTime, 
                    int startTime, 
                    global::System.DateTimeOffset endDateTime, 
                    global::System.DateTimeOffset origStartDateTime, 
                    global::System.DateTimeOffset startDate, 
                    bool runtimeJob)
        {
            BatchJob batchJob = new BatchJob();
            batchJob.BatchJobRecId = batchJobRecId;
            batchJob.Finishing = finishing;
            batchJob.StartDateTime = startDateTime;
            batchJob.StartTime = startTime;
            batchJob.EndDateTime = endDateTime;
            batchJob.OrigStartDateTime = origStartDateTime;
            batchJob.StartDate = startDate;
            batchJob.RuntimeJob = runtimeJob;
            return batchJob;
        }
        /// <summary>
        /// There are no comments for Property BatchJobRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long BatchJobRecId
        {
            get
            {
                return this._BatchJobRecId;
            }
            set
            {
                this.OnBatchJobRecIdChanging(value);
                this._BatchJobRecId = value;
                this.OnBatchJobRecIdChanged();
                this.OnPropertyChanged("BatchJobRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _BatchJobRecId;
        partial void OnBatchJobRecIdChanging(long value);
        partial void OnBatchJobRecIdChanged();
        /// <summary>
        /// There are no comments for Property Finishing in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Finishing
        {
            get
            {
                return this._Finishing;
            }
            set
            {
                this.OnFinishingChanging(value);
                this._Finishing = value;
                this.OnFinishingChanged();
                this.OnPropertyChanged("Finishing");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Finishing;
        partial void OnFinishingChanging(int value);
        partial void OnFinishingChanged();
        /// <summary>
        /// There are no comments for Property StartDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset StartDateTime
        {
            get
            {
                return this._StartDateTime;
            }
            set
            {
                this.OnStartDateTimeChanging(value);
                this._StartDateTime = value;
                this.OnStartDateTimeChanged();
                this.OnPropertyChanged("StartDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDateTime;
        partial void OnStartDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnStartDateTimeChanged();
        /// <summary>
        /// There are no comments for Property StartTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int StartTime
        {
            get
            {
                return this._StartTime;
            }
            set
            {
                this.OnStartTimeChanging(value);
                this._StartTime = value;
                this.OnStartTimeChanged();
                this.OnPropertyChanged("StartTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _StartTime;
        partial void OnStartTimeChanging(int value);
        partial void OnStartTimeChanged();
        /// <summary>
        /// There are no comments for Property EndDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EndDateTime
        {
            get
            {
                return this._EndDateTime;
            }
            set
            {
                this.OnEndDateTimeChanging(value);
                this._EndDateTime = value;
                this.OnEndDateTimeChanged();
                this.OnPropertyChanged("EndDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EndDateTime;
        partial void OnEndDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnEndDateTimeChanged();
        /// <summary>
        /// There are no comments for Property JobDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobDescription
        {
            get
            {
                return this._JobDescription;
            }
            set
            {
                this.OnJobDescriptionChanging(value);
                this._JobDescription = value;
                this.OnJobDescriptionChanged();
                this.OnPropertyChanged("JobDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobDescription;
        partial void OnJobDescriptionChanging(string value);
        partial void OnJobDescriptionChanged();
        /// <summary>
        /// There are no comments for Property CompanyAccounts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CompanyAccounts
        {
            get
            {
                return this._CompanyAccounts;
            }
            set
            {
                this.OnCompanyAccountsChanging(value);
                this._CompanyAccounts = value;
                this.OnCompanyAccountsChanged();
                this.OnPropertyChanged("CompanyAccounts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CompanyAccounts;
        partial void OnCompanyAccountsChanging(string value);
        partial void OnCompanyAccountsChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BatchStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BatchStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BatchStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property OrigStartDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset OrigStartDateTime
        {
            get
            {
                return this._OrigStartDateTime;
            }
            set
            {
                this.OnOrigStartDateTimeChanging(value);
                this._OrigStartDateTime = value;
                this.OnOrigStartDateTimeChanged();
                this.OnPropertyChanged("OrigStartDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _OrigStartDateTime;
        partial void OnOrigStartDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnOrigStartDateTimeChanged();
        /// <summary>
        /// There are no comments for Property ExecutingBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ExecutingBy
        {
            get
            {
                return this._ExecutingBy;
            }
            set
            {
                this.OnExecutingByChanging(value);
                this._ExecutingBy = value;
                this.OnExecutingByChanged();
                this.OnPropertyChanged("ExecutingBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExecutingBy;
        partial void OnExecutingByChanging(string value);
        partial void OnExecutingByChanged();
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
        /// There are no comments for Property PartitionKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PartitionKey
        {
            get
            {
                return this._PartitionKey;
            }
            set
            {
                this.OnPartitionKeyChanging(value);
                this._PartitionKey = value;
                this.OnPartitionKeyChanged();
                this.OnPropertyChanged("PartitionKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartitionKey;
        partial void OnPartitionKeyChanging(string value);
        partial void OnPartitionKeyChanged();
        /// <summary>
        /// There are no comments for Property CanceledBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CanceledBy
        {
            get
            {
                return this._CanceledBy;
            }
            set
            {
                this.OnCanceledByChanging(value);
                this._CanceledBy = value;
                this.OnCanceledByChanged();
                this.OnPropertyChanged("CanceledBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CanceledBy;
        partial void OnCanceledByChanging(string value);
        partial void OnCanceledByChanged();
        /// <summary>
        /// There are no comments for Property Recurrence in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual byte[] Recurrence
        {
            get
            {
                return this._Recurrence;
            }
            set
            {
                this.OnRecurrenceChanging(value);
                this._Recurrence = value;
                this.OnRecurrenceChanged();
                this.OnPropertyChanged("Recurrence");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private byte[] _Recurrence;
        partial void OnRecurrenceChanging(byte[] value);
        partial void OnRecurrenceChanged();
        /// <summary>
        /// There are no comments for Property SaveJobToHistory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BatchLogLevel> SaveJobToHistory
        {
            get
            {
                return this._SaveJobToHistory;
            }
            set
            {
                this.OnSaveJobToHistoryChanging(value);
                this._SaveJobToHistory = value;
                this.OnSaveJobToHistoryChanged();
                this.OnPropertyChanged("SaveJobToHistory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BatchLogLevel> _SaveJobToHistory;
        partial void OnSaveJobToHistoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BatchLogLevel> value);
        partial void OnSaveJobToHistoryChanged();
        /// <summary>
        /// There are no comments for Property RuntimeJob in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual bool RuntimeJob
        {
            get
            {
                return this._RuntimeJob;
            }
            set
            {
                this.OnRuntimeJobChanging(value);
                this._RuntimeJob = value;
                this.OnRuntimeJobChanged();
                this.OnPropertyChanged("RuntimeJob");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private bool _RuntimeJob;
        partial void OnRuntimeJobChanging(bool value);
        partial void OnRuntimeJobChanged();
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
