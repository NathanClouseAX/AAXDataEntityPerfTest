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
        /// There are no comments for AccrualPlanSingle in the schema.
        /// </summary>
    public partial class AccrualPlanSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AccrualPlan>
    {
        /// <summary>
        /// Initialize a new AccrualPlanSingle object.
        /// </summary>
        public AccrualPlanSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AccrualPlanSingle object.
        /// </summary>
        public AccrualPlanSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AccrualPlanSingle object.
        /// </summary>
        public AccrualPlanSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AccrualPlan> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WorkerEnrolledAccrualInquiry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrualInquiry> WorkerEnrolledAccrualInquiry
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerEnrolledAccrualInquiry == null))
                {
                    this._WorkerEnrolledAccrualInquiry = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrualInquiry>(GetPath("WorkerEnrolledAccrualInquiry"));
                }
                return this._WorkerEnrolledAccrualInquiry;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrualInquiry> _WorkerEnrolledAccrualInquiry;
        /// <summary>
        /// There are no comments for WorkerEnrolledAccruals in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrual> WorkerEnrolledAccruals
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerEnrolledAccruals == null))
                {
                    this._WorkerEnrolledAccruals = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrual>(GetPath("WorkerEnrolledAccruals"));
                }
                return this._WorkerEnrolledAccruals;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrual> _WorkerEnrolledAccruals;
        /// <summary>
        /// There are no comments for AccrualEarningCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AccrualEarningCode> AccrualEarningCodes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AccrualEarningCodes == null))
                {
                    this._AccrualEarningCodes = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AccrualEarningCode>(GetPath("AccrualEarningCodes"));
                }
                return this._AccrualEarningCodes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AccrualEarningCode> _AccrualEarningCodes;
        /// <summary>
        /// There are no comments for AccrualPlanRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AccrualPlanRule> AccrualPlanRules
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AccrualPlanRules == null))
                {
                    this._AccrualPlanRules = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AccrualPlanRule>(GetPath("AccrualPlanRules"));
                }
                return this._AccrualPlanRules;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AccrualPlanRule> _AccrualPlanRules;
        /// <summary>
        /// There are no comments for AccrualBasisEarningCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AccrualBasisEarningCode> AccrualBasisEarningCodes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AccrualBasisEarningCodes == null))
                {
                    this._AccrualBasisEarningCodes = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AccrualBasisEarningCode>(GetPath("AccrualBasisEarningCodes"));
                }
                return this._AccrualBasisEarningCodes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AccrualBasisEarningCode> _AccrualBasisEarningCodes;
    }
        /// <summary>
        /// There are no comments for AccrualPlan in the schema.
        /// </summary>
    /// <KeyProperties>
    /// AccrualId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AccrualId")]
    [global::Microsoft.OData.Client.EntitySet("AccrualPlans")]
    public partial class AccrualPlan : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AccrualPlan object.
        /// </summary>
        /// <param name="accrualId">Initial value of AccrualId.</param>
        /// <param name="customAccrualDate">Initial value of CustomAccrualDate.</param>
        /// <param name="startingDate">Initial value of StartingDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AccrualPlan CreateAccrualPlan(string accrualId, global::System.DateTimeOffset customAccrualDate, global::System.DateTimeOffset startingDate)
        {
            AccrualPlan accrualPlan = new AccrualPlan();
            accrualPlan.AccrualId = accrualId;
            accrualPlan.CustomAccrualDate = customAccrualDate;
            accrualPlan.StartingDate = startingDate;
            return accrualPlan;
        }
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
        /// There are no comments for Property IsIncludedInAccrual in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsIncludedInAccrual
        {
            get
            {
                return this._IsIncludedInAccrual;
            }
            set
            {
                this.OnIsIncludedInAccrualChanging(value);
                this._IsIncludedInAccrual = value;
                this.OnIsIncludedInAccrualChanged();
                this.OnPropertyChanged("IsIncludedInAccrual");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsIncludedInAccrual;
        partial void OnIsIncludedInAccrualChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsIncludedInAccrualChanged();
        /// <summary>
        /// There are no comments for Property CustomAccrualDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset CustomAccrualDate
        {
            get
            {
                return this._CustomAccrualDate;
            }
            set
            {
                this.OnCustomAccrualDateChanging(value);
                this._CustomAccrualDate = value;
                this.OnCustomAccrualDateChanged();
                this.OnPropertyChanged("CustomAccrualDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CustomAccrualDate;
        partial void OnCustomAccrualDateChanging(global::System.DateTimeOffset value);
        partial void OnCustomAccrualDateChanged();
        /// <summary>
        /// There are no comments for Property CanCarryForward in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CanCarryForward
        {
            get
            {
                return this._CanCarryForward;
            }
            set
            {
                this.OnCanCarryForwardChanging(value);
                this._CanCarryForward = value;
                this.OnCanCarryForwardChanged();
                this.OnPropertyChanged("CanCarryForward");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CanCarryForward;
        partial void OnCanCarryForwardChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCanCarryForwardChanged();
        /// <summary>
        /// There are no comments for Property WorkerAccrualDateMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollWorkerAccrualDateMethod> WorkerAccrualDateMethod
        {
            get
            {
                return this._WorkerAccrualDateMethod;
            }
            set
            {
                this.OnWorkerAccrualDateMethodChanging(value);
                this._WorkerAccrualDateMethod = value;
                this.OnWorkerAccrualDateMethodChanged();
                this.OnPropertyChanged("WorkerAccrualDateMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollWorkerAccrualDateMethod> _WorkerAccrualDateMethod;
        partial void OnWorkerAccrualDateMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollWorkerAccrualDateMethod> value);
        partial void OnWorkerAccrualDateMethodChanged();
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
        /// There are no comments for Property AccrualMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollAccrualMethod> AccrualMethod
        {
            get
            {
                return this._AccrualMethod;
            }
            set
            {
                this.OnAccrualMethodChanging(value);
                this._AccrualMethod = value;
                this.OnAccrualMethodChanged();
                this.OnPropertyChanged("AccrualMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollAccrualMethod> _AccrualMethod;
        partial void OnAccrualMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollAccrualMethod> value);
        partial void OnAccrualMethodChanged();
        /// <summary>
        /// There are no comments for Property StartingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset StartingDate
        {
            get
            {
                return this._StartingDate;
            }
            set
            {
                this.OnStartingDateChanging(value);
                this._StartingDate = value;
                this.OnStartingDateChanged();
                this.OnPropertyChanged("StartingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartingDate;
        partial void OnStartingDateChanging(global::System.DateTimeOffset value);
        partial void OnStartingDateChanged();
        /// <summary>
        /// There are no comments for Property CalculationFrequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CalculationFrequency
        {
            get
            {
                return this._CalculationFrequency;
            }
            set
            {
                this.OnCalculationFrequencyChanging(value);
                this._CalculationFrequency = value;
                this.OnCalculationFrequencyChanged();
                this.OnPropertyChanged("CalculationFrequency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CalculationFrequency;
        partial void OnCalculationFrequencyChanging(string value);
        partial void OnCalculationFrequencyChanged();
        /// <summary>
        /// There are no comments for Property WorkerEnrolledAccrualInquiry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrualInquiry> WorkerEnrolledAccrualInquiry
        {
            get
            {
                return this._WorkerEnrolledAccrualInquiry;
            }
            set
            {
                this.OnWorkerEnrolledAccrualInquiryChanging(value);
                this._WorkerEnrolledAccrualInquiry = value;
                this.OnWorkerEnrolledAccrualInquiryChanged();
                this.OnPropertyChanged("WorkerEnrolledAccrualInquiry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrualInquiry> _WorkerEnrolledAccrualInquiry = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrualInquiry>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWorkerEnrolledAccrualInquiryChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrualInquiry> value);
        partial void OnWorkerEnrolledAccrualInquiryChanged();
        /// <summary>
        /// There are no comments for Property WorkerEnrolledAccruals in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrual> WorkerEnrolledAccruals
        {
            get
            {
                return this._WorkerEnrolledAccruals;
            }
            set
            {
                this.OnWorkerEnrolledAccrualsChanging(value);
                this._WorkerEnrolledAccruals = value;
                this.OnWorkerEnrolledAccrualsChanged();
                this.OnPropertyChanged("WorkerEnrolledAccruals");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrual> _WorkerEnrolledAccruals = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrual>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWorkerEnrolledAccrualsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerEnrolledAccrual> value);
        partial void OnWorkerEnrolledAccrualsChanged();
        /// <summary>
        /// There are no comments for Property AccrualEarningCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualEarningCode> AccrualEarningCodes
        {
            get
            {
                return this._AccrualEarningCodes;
            }
            set
            {
                this.OnAccrualEarningCodesChanging(value);
                this._AccrualEarningCodes = value;
                this.OnAccrualEarningCodesChanged();
                this.OnPropertyChanged("AccrualEarningCodes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualEarningCode> _AccrualEarningCodes = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualEarningCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAccrualEarningCodesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualEarningCode> value);
        partial void OnAccrualEarningCodesChanged();
        /// <summary>
        /// There are no comments for Property AccrualPlanRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualPlanRule> AccrualPlanRules
        {
            get
            {
                return this._AccrualPlanRules;
            }
            set
            {
                this.OnAccrualPlanRulesChanging(value);
                this._AccrualPlanRules = value;
                this.OnAccrualPlanRulesChanged();
                this.OnPropertyChanged("AccrualPlanRules");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualPlanRule> _AccrualPlanRules = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualPlanRule>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAccrualPlanRulesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualPlanRule> value);
        partial void OnAccrualPlanRulesChanged();
        /// <summary>
        /// There are no comments for Property AccrualBasisEarningCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualBasisEarningCode> AccrualBasisEarningCodes
        {
            get
            {
                return this._AccrualBasisEarningCodes;
            }
            set
            {
                this.OnAccrualBasisEarningCodesChanging(value);
                this._AccrualBasisEarningCodes = value;
                this.OnAccrualBasisEarningCodesChanged();
                this.OnPropertyChanged("AccrualBasisEarningCodes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualBasisEarningCode> _AccrualBasisEarningCodes = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualBasisEarningCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAccrualBasisEarningCodesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualBasisEarningCode> value);
        partial void OnAccrualBasisEarningCodesChanged();
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
