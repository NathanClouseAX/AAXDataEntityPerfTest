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
        /// There are no comments for WorkerEnrolledAccrualSingle in the schema.
        /// </summary>
    public partial class WorkerEnrolledAccrualSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerEnrolledAccrual>
    {
        /// <summary>
        /// Initialize a new WorkerEnrolledAccrualSingle object.
        /// </summary>
        public WorkerEnrolledAccrualSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkerEnrolledAccrualSingle object.
        /// </summary>
        public WorkerEnrolledAccrualSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkerEnrolledAccrualSingle object.
        /// </summary>
        public WorkerEnrolledAccrualSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerEnrolledAccrual> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PayrollAccrualPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AccrualPlanSingle PayrollAccrualPlan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollAccrualPlan == null))
                {
                    this._PayrollAccrualPlan = new global::Microsoft.Dynamics.DataEntities.AccrualPlanSingle(this.Context, GetPath("PayrollAccrualPlan"));
                }
                return this._PayrollAccrualPlan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AccrualPlanSingle _PayrollAccrualPlan;
        /// <summary>
        /// There are no comments for HcmWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle HcmWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._HcmWorker == null))
                {
                    this._HcmWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("HcmWorker"));
                }
                return this._HcmWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _HcmWorker;
        /// <summary>
        /// There are no comments for WorkerAccrualAdjustments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerAccrualAdjustment> WorkerAccrualAdjustments
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerAccrualAdjustments == null))
                {
                    this._WorkerAccrualAdjustments = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WorkerAccrualAdjustment>(GetPath("WorkerAccrualAdjustments"));
                }
                return this._WorkerAccrualAdjustments;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerAccrualAdjustment> _WorkerAccrualAdjustments;
    }
        /// <summary>
        /// There are no comments for WorkerEnrolledAccrual in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// AccrualId
    /// PersonnelNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AccrualId", "PersonnelNumber")]
    [global::Microsoft.OData.Client.EntitySet("WorkerEnrolledAccruals")]
    public partial class WorkerEnrolledAccrual : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkerEnrolledAccrual object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="accrualId">Initial value of AccrualId.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="customAccuralDate">Initial value of CustomAccuralDate.</param>
        /// <param name="payrollAccrualPlan">Initial value of PayrollAccrualPlan.</param>
        /// <param name="hcmWorker">Initial value of HcmWorker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkerEnrolledAccrual CreateWorkerEnrolledAccrual(string dataAreaId, 
                    string accrualId, 
                    string personnelNumber, 
                    global::System.DateTimeOffset customAccuralDate, 
                    global::Microsoft.Dynamics.DataEntities.AccrualPlan payrollAccrualPlan, 
                    global::Microsoft.Dynamics.DataEntities.Worker hcmWorker)
        {
            WorkerEnrolledAccrual workerEnrolledAccrual = new WorkerEnrolledAccrual();
            workerEnrolledAccrual.dataAreaId = dataAreaId;
            workerEnrolledAccrual.AccrualId = accrualId;
            workerEnrolledAccrual.PersonnelNumber = personnelNumber;
            workerEnrolledAccrual.CustomAccuralDate = customAccuralDate;
            if ((payrollAccrualPlan == null))
            {
                throw new global::System.ArgumentNullException("payrollAccrualPlan");
            }
            workerEnrolledAccrual.PayrollAccrualPlan = payrollAccrualPlan;
            if ((hcmWorker == null))
            {
                throw new global::System.ArgumentNullException("hcmWorker");
            }
            workerEnrolledAccrual.HcmWorker = hcmWorker;
            return workerEnrolledAccrual;
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
        /// There are no comments for Property AccrualDateBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollAccrualDateBasis> AccrualDateBasis
        {
            get
            {
                return this._AccrualDateBasis;
            }
            set
            {
                this.OnAccrualDateBasisChanging(value);
                this._AccrualDateBasis = value;
                this.OnAccrualDateBasisChanged();
                this.OnPropertyChanged("AccrualDateBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollAccrualDateBasis> _AccrualDateBasis;
        partial void OnAccrualDateBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollAccrualDateBasis> value);
        partial void OnAccrualDateBasisChanged();
        /// <summary>
        /// There are no comments for Property IsAccrualStopped in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAccrualStopped
        {
            get
            {
                return this._IsAccrualStopped;
            }
            set
            {
                this.OnIsAccrualStoppedChanging(value);
                this._IsAccrualStopped = value;
                this.OnIsAccrualStoppedChanged();
                this.OnPropertyChanged("IsAccrualStopped");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAccrualStopped;
        partial void OnIsAccrualStoppedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAccrualStoppedChanged();
        /// <summary>
        /// There are no comments for Property CustomAccuralDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset CustomAccuralDate
        {
            get
            {
                return this._CustomAccuralDate;
            }
            set
            {
                this.OnCustomAccuralDateChanging(value);
                this._CustomAccuralDate = value;
                this.OnCustomAccuralDateChanged();
                this.OnPropertyChanged("CustomAccuralDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CustomAccuralDate;
        partial void OnCustomAccuralDateChanging(global::System.DateTimeOffset value);
        partial void OnCustomAccuralDateChanged();
        /// <summary>
        /// There are no comments for Property IsUsageStopped in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsUsageStopped
        {
            get
            {
                return this._IsUsageStopped;
            }
            set
            {
                this.OnIsUsageStoppedChanging(value);
                this._IsUsageStopped = value;
                this.OnIsUsageStoppedChanged();
                this.OnPropertyChanged("IsUsageStopped");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsUsageStopped;
        partial void OnIsUsageStoppedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsUsageStoppedChanged();
        /// <summary>
        /// There are no comments for Property PayrollAccrualPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AccrualPlan PayrollAccrualPlan
        {
            get
            {
                return this._PayrollAccrualPlan;
            }
            set
            {
                this.OnPayrollAccrualPlanChanging(value);
                this._PayrollAccrualPlan = value;
                this.OnPayrollAccrualPlanChanged();
                this.OnPropertyChanged("PayrollAccrualPlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AccrualPlan _PayrollAccrualPlan;
        partial void OnPayrollAccrualPlanChanging(global::Microsoft.Dynamics.DataEntities.AccrualPlan value);
        partial void OnPayrollAccrualPlanChanged();
        /// <summary>
        /// There are no comments for Property HcmWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker HcmWorker
        {
            get
            {
                return this._HcmWorker;
            }
            set
            {
                this.OnHcmWorkerChanging(value);
                this._HcmWorker = value;
                this.OnHcmWorkerChanged();
                this.OnPropertyChanged("HcmWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _HcmWorker;
        partial void OnHcmWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnHcmWorkerChanged();
        /// <summary>
        /// There are no comments for Property WorkerAccrualAdjustments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerAccrualAdjustment> WorkerAccrualAdjustments
        {
            get
            {
                return this._WorkerAccrualAdjustments;
            }
            set
            {
                this.OnWorkerAccrualAdjustmentsChanging(value);
                this._WorkerAccrualAdjustments = value;
                this.OnWorkerAccrualAdjustmentsChanged();
                this.OnPropertyChanged("WorkerAccrualAdjustments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerAccrualAdjustment> _WorkerAccrualAdjustments = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerAccrualAdjustment>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWorkerAccrualAdjustmentsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerAccrualAdjustment> value);
        partial void OnWorkerAccrualAdjustmentsChanged();
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
