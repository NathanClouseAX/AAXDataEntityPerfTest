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
        /// There are no comments for WorkerPositionEarningCodeSingle in the schema.
        /// </summary>
    public partial class WorkerPositionEarningCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerPositionEarningCode>
    {
        /// <summary>
        /// Initialize a new WorkerPositionEarningCodeSingle object.
        /// </summary>
        public WorkerPositionEarningCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkerPositionEarningCodeSingle object.
        /// </summary>
        public WorkerPositionEarningCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkerPositionEarningCodeSingle object.
        /// </summary>
        public WorkerPositionEarningCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerPositionEarningCode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PayrollCalculationFrequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencySingle PayrollCalculationFrequency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollCalculationFrequency == null))
                {
                    this._PayrollCalculationFrequency = new global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencySingle(this.Context, GetPath("PayrollCalculationFrequency"));
                }
                return this._PayrollCalculationFrequency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencySingle _PayrollCalculationFrequency;
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
    }
        /// <summary>
        /// There are no comments for WorkerPositionEarningCode in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PersonnelNumber
    /// EarningCodeId
    /// PositionId
    /// ValidFrom
    /// ValidTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelNumber", "EarningCodeId", "PositionId", "ValidFrom", "ValidTo")]
    [global::Microsoft.OData.Client.EntitySet("WorkerPositionEarningCodes")]
    public partial class WorkerPositionEarningCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkerPositionEarningCode object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="earningCodeId">Initial value of EarningCodeId.</param>
        /// <param name="positionId">Initial value of PositionId.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="worker">Initial value of Worker.</param>
        /// <param name="positionV2">Initial value of PositionV2.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkerPositionEarningCode CreateWorkerPositionEarningCode(string personnelNumber, 
                    string earningCodeId, 
                    string positionId, 
                    global::System.DateTimeOffset validFrom, 
                    global::System.DateTimeOffset validTo, 
                    decimal amount, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker, 
                    global::Microsoft.Dynamics.DataEntities.PositionV2 positionV2)
        {
            WorkerPositionEarningCode workerPositionEarningCode = new WorkerPositionEarningCode();
            workerPositionEarningCode.PersonnelNumber = personnelNumber;
            workerPositionEarningCode.EarningCodeId = earningCodeId;
            workerPositionEarningCode.PositionId = positionId;
            workerPositionEarningCode.ValidFrom = validFrom;
            workerPositionEarningCode.ValidTo = validTo;
            workerPositionEarningCode.Amount = amount;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            workerPositionEarningCode.Worker = worker;
            if ((positionV2 == null))
            {
                throw new global::System.ArgumentNullException("positionV2");
            }
            workerPositionEarningCode.PositionV2 = positionV2;
            return workerPositionEarningCode;
        }
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
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property FrequencyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FrequencyId
        {
            get
            {
                return this._FrequencyId;
            }
            set
            {
                this.OnFrequencyIdChanging(value);
                this._FrequencyId = value;
                this.OnFrequencyIdChanged();
                this.OnPropertyChanged("FrequencyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FrequencyId;
        partial void OnFrequencyIdChanging(string value);
        partial void OnFrequencyIdChanged();
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Amount;
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
        /// <summary>
        /// There are no comments for Property PayrollCalculationFrequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequency PayrollCalculationFrequency
        {
            get
            {
                return this._PayrollCalculationFrequency;
            }
            set
            {
                this.OnPayrollCalculationFrequencyChanging(value);
                this._PayrollCalculationFrequency = value;
                this.OnPayrollCalculationFrequencyChanged();
                this.OnPropertyChanged("PayrollCalculationFrequency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequency _PayrollCalculationFrequency;
        partial void OnPayrollCalculationFrequencyChanging(global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequency value);
        partial void OnPayrollCalculationFrequencyChanged();
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
