﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:24:13 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for WorkerAccrualAdjustmentSingle in the schema.
    /// </summary>
    public partial class WorkerAccrualAdjustmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerAccrualAdjustment>
    {
        /// <summary>
        /// Initialize a new WorkerAccrualAdjustmentSingle object.
        /// </summary>
        public WorkerAccrualAdjustmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkerAccrualAdjustmentSingle object.
        /// </summary>
        public WorkerAccrualAdjustmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkerAccrualAdjustmentSingle object.
        /// </summary>
        public WorkerAccrualAdjustmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerAccrualAdjustment> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PayrollWorkerEnrolledAccrual in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrualSingle PayrollWorkerEnrolledAccrual
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollWorkerEnrolledAccrual == null))
                {
                    this._PayrollWorkerEnrolledAccrual = new global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrualSingle(this.Context, GetPath("PayrollWorkerEnrolledAccrual"));
                }
                return this._PayrollWorkerEnrolledAccrual;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrualSingle _PayrollWorkerEnrolledAccrual;
    }
    /// <summary>
    /// There are no comments for WorkerAccrualAdjustment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// AdjustmentType
    /// AccrualId
    /// SequenceNumber
    /// LegalEntityId
    /// EnrolledAccrualLegalEntityId
    /// PersonnelNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AdjustmentType", "AccrualId", "SequenceNumber", "LegalEntityId", "EnrolledAccrualLegalEntityId", "PersonnelNumber")]
    [global::Microsoft.OData.Client.EntitySet("WorkerAccrualAdjustments")]
    public partial class WorkerAccrualAdjustment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkerAccrualAdjustment object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="accrualId">Initial value of AccrualId.</param>
        /// <param name="sequenceNumber">Initial value of SequenceNumber.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="enrolledAccrualLegalEntityId">Initial value of EnrolledAccrualLegalEntityId.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="transactionDate">Initial value of TransactionDate.</param>
        /// <param name="adjustedHours">Initial value of AdjustedHours.</param>
        /// <param name="payrollWorkerEnrolledAccrual">Initial value of PayrollWorkerEnrolledAccrual.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkerAccrualAdjustment CreateWorkerAccrualAdjustment(string dataAreaId, 
                    string accrualId, 
                    int sequenceNumber, 
                    string legalEntityId, 
                    string enrolledAccrualLegalEntityId, 
                    string personnelNumber, 
                    global::System.DateTimeOffset transactionDate, 
                    decimal adjustedHours, 
                    global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrual payrollWorkerEnrolledAccrual)
        {
            WorkerAccrualAdjustment workerAccrualAdjustment = new WorkerAccrualAdjustment();
            workerAccrualAdjustment.dataAreaId = dataAreaId;
            workerAccrualAdjustment.AccrualId = accrualId;
            workerAccrualAdjustment.SequenceNumber = sequenceNumber;
            workerAccrualAdjustment.LegalEntityId = legalEntityId;
            workerAccrualAdjustment.EnrolledAccrualLegalEntityId = enrolledAccrualLegalEntityId;
            workerAccrualAdjustment.PersonnelNumber = personnelNumber;
            workerAccrualAdjustment.TransactionDate = transactionDate;
            workerAccrualAdjustment.AdjustedHours = adjustedHours;
            if ((payrollWorkerEnrolledAccrual == null))
            {
                throw new global::System.ArgumentNullException("payrollWorkerEnrolledAccrual");
            }
            workerAccrualAdjustment.PayrollWorkerEnrolledAccrual = payrollWorkerEnrolledAccrual;
            return workerAccrualAdjustment;
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
        /// There are no comments for Property AdjustmentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollAccrualAdjustmentType> AdjustmentType
        {
            get
            {
                return this._AdjustmentType;
            }
            set
            {
                this.OnAdjustmentTypeChanging(value);
                this._AdjustmentType = value;
                this.OnAdjustmentTypeChanged();
                this.OnPropertyChanged("AdjustmentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollAccrualAdjustmentType> _AdjustmentType;
        partial void OnAdjustmentTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollAccrualAdjustmentType> value);
        partial void OnAdjustmentTypeChanged();
        /// <summary>
        /// There are no comments for Property AccrualId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccrualId
        {
            get
            {
                return this._AccrualId;
            }
            set
            {
                this.OnAccrualIdChanging(value);
                this._AccrualId = value;
                this.OnAccrualIdChanged();
                this.OnPropertyChanged("AccrualId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccrualId;
        partial void OnAccrualIdChanging(string value);
        partial void OnAccrualIdChanged();
        /// <summary>
        /// There are no comments for Property SequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int SequenceNumber
        {
            get
            {
                return this._SequenceNumber;
            }
            set
            {
                this.OnSequenceNumberChanging(value);
                this._SequenceNumber = value;
                this.OnSequenceNumberChanged();
                this.OnPropertyChanged("SequenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _SequenceNumber;
        partial void OnSequenceNumberChanging(int value);
        partial void OnSequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property EnrolledAccrualLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EnrolledAccrualLegalEntityId
        {
            get
            {
                return this._EnrolledAccrualLegalEntityId;
            }
            set
            {
                this.OnEnrolledAccrualLegalEntityIdChanging(value);
                this._EnrolledAccrualLegalEntityId = value;
                this.OnEnrolledAccrualLegalEntityIdChanged();
                this.OnPropertyChanged("EnrolledAccrualLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EnrolledAccrualLegalEntityId;
        partial void OnEnrolledAccrualLegalEntityIdChanging(string value);
        partial void OnEnrolledAccrualLegalEntityIdChanged();
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
        /// There are no comments for Property TransactionDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset TransactionDate
        {
            get
            {
                return this._TransactionDate;
            }
            set
            {
                this.OnTransactionDateChanging(value);
                this._TransactionDate = value;
                this.OnTransactionDateChanged();
                this.OnPropertyChanged("TransactionDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TransactionDate;
        partial void OnTransactionDateChanging(global::System.DateTimeOffset value);
        partial void OnTransactionDateChanged();
        /// <summary>
        /// There are no comments for Property AdjustedHours in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AdjustedHours
        {
            get
            {
                return this._AdjustedHours;
            }
            set
            {
                this.OnAdjustedHoursChanging(value);
                this._AdjustedHours = value;
                this.OnAdjustedHoursChanged();
                this.OnPropertyChanged("AdjustedHours");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AdjustedHours;
        partial void OnAdjustedHoursChanging(decimal value);
        partial void OnAdjustedHoursChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property PayrollWorkerEnrolledAccrual in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrual PayrollWorkerEnrolledAccrual
        {
            get
            {
                return this._PayrollWorkerEnrolledAccrual;
            }
            set
            {
                this.OnPayrollWorkerEnrolledAccrualChanging(value);
                this._PayrollWorkerEnrolledAccrual = value;
                this.OnPayrollWorkerEnrolledAccrualChanged();
                this.OnPropertyChanged("PayrollWorkerEnrolledAccrual");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrual _PayrollWorkerEnrolledAccrual;
        partial void OnPayrollWorkerEnrolledAccrualChanging(global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrual value);
        partial void OnPayrollWorkerEnrolledAccrualChanged();
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