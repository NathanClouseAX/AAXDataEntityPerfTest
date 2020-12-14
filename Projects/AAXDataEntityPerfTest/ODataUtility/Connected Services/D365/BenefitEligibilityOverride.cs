﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 12/8/2020 7:45:22 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for BenefitEligibilityOverrideSingle in the schema.
        /// </summary>
    public partial class BenefitEligibilityOverrideSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitEligibilityOverride>
    {
        /// <summary>
        /// Initialize a new BenefitEligibilityOverrideSingle object.
        /// </summary>
        public BenefitEligibilityOverrideSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitEligibilityOverrideSingle object.
        /// </summary>
        public BenefitEligibilityOverrideSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitEligibilityOverrideSingle object.
        /// </summary>
        public BenefitEligibilityOverrideSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitEligibilityOverride> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BenefitPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitPlanSingle BenefitPlan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitPlan == null))
                {
                    this._BenefitPlan = new global::Microsoft.Dynamics.DataEntities.BenefitPlanSingle(this.Context, GetPath("BenefitPlan"));
                }
                return this._BenefitPlan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitPlanSingle _BenefitPlan;
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
        /// There are no comments for BenefitOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitOptionSingle BenefitOption
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitOption == null))
                {
                    this._BenefitOption = new global::Microsoft.Dynamics.DataEntities.BenefitOptionSingle(this.Context, GetPath("BenefitOption"));
                }
                return this._BenefitOption;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitOptionSingle _BenefitOption;
        /// <summary>
        /// There are no comments for Benefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitSingle Benefit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Benefit == null))
                {
                    this._Benefit = new global::Microsoft.Dynamics.DataEntities.BenefitSingle(this.Context, GetPath("Benefit"));
                }
                return this._Benefit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitSingle _Benefit;
    }
        /// <summary>
        /// There are no comments for BenefitEligibilityOverride in the schema.
        /// </summary>
    /// <KeyProperties>
    /// BenefitPlanId
    /// BenefitOptionId
    /// Effective
    /// Expiration
    /// WorkerId
    /// OverrideStartDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BenefitPlanId", "BenefitOptionId", "Effective", "Expiration", "WorkerId", "OverrideStartDate")]
    [global::Microsoft.OData.Client.EntitySet("BenefitEligibilityOverrides")]
    public partial class BenefitEligibilityOverride : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitEligibilityOverride object.
        /// </summary>
        /// <param name="benefitPlanId">Initial value of BenefitPlanId.</param>
        /// <param name="benefitOptionId">Initial value of BenefitOptionId.</param>
        /// <param name="effective">Initial value of Effective.</param>
        /// <param name="expiration">Initial value of Expiration.</param>
        /// <param name="workerId">Initial value of WorkerId.</param>
        /// <param name="overrideStartDate">Initial value of OverrideStartDate.</param>
        /// <param name="overrideEndDate">Initial value of OverrideEndDate.</param>
        /// <param name="benefitPlan">Initial value of BenefitPlan.</param>
        /// <param name="worker">Initial value of Worker.</param>
        /// <param name="benefitOption">Initial value of BenefitOption.</param>
        /// <param name="benefit">Initial value of Benefit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitEligibilityOverride CreateBenefitEligibilityOverride(string benefitPlanId, 
                    string benefitOptionId, 
                    global::System.DateTimeOffset effective, 
                    global::System.DateTimeOffset expiration, 
                    string workerId, 
                    global::System.DateTimeOffset overrideStartDate, 
                    global::System.DateTimeOffset overrideEndDate, 
                    global::Microsoft.Dynamics.DataEntities.BenefitPlan benefitPlan, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker, 
                    global::Microsoft.Dynamics.DataEntities.BenefitOption benefitOption, 
                    global::Microsoft.Dynamics.DataEntities.Benefit benefit)
        {
            BenefitEligibilityOverride benefitEligibilityOverride = new BenefitEligibilityOverride();
            benefitEligibilityOverride.BenefitPlanId = benefitPlanId;
            benefitEligibilityOverride.BenefitOptionId = benefitOptionId;
            benefitEligibilityOverride.Effective = effective;
            benefitEligibilityOverride.Expiration = expiration;
            benefitEligibilityOverride.WorkerId = workerId;
            benefitEligibilityOverride.OverrideStartDate = overrideStartDate;
            benefitEligibilityOverride.OverrideEndDate = overrideEndDate;
            if ((benefitPlan == null))
            {
                throw new global::System.ArgumentNullException("benefitPlan");
            }
            benefitEligibilityOverride.BenefitPlan = benefitPlan;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            benefitEligibilityOverride.Worker = worker;
            if ((benefitOption == null))
            {
                throw new global::System.ArgumentNullException("benefitOption");
            }
            benefitEligibilityOverride.BenefitOption = benefitOption;
            if ((benefit == null))
            {
                throw new global::System.ArgumentNullException("benefit");
            }
            benefitEligibilityOverride.Benefit = benefit;
            return benefitEligibilityOverride;
        }
        /// <summary>
        /// There are no comments for Property BenefitPlanId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BenefitPlanId
        {
            get
            {
                return this._BenefitPlanId;
            }
            set
            {
                this.OnBenefitPlanIdChanging(value);
                this._BenefitPlanId = value;
                this.OnBenefitPlanIdChanged();
                this.OnPropertyChanged("BenefitPlanId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitPlanId;
        partial void OnBenefitPlanIdChanging(string value);
        partial void OnBenefitPlanIdChanged();
        /// <summary>
        /// There are no comments for Property BenefitOptionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BenefitOptionId
        {
            get
            {
                return this._BenefitOptionId;
            }
            set
            {
                this.OnBenefitOptionIdChanging(value);
                this._BenefitOptionId = value;
                this.OnBenefitOptionIdChanged();
                this.OnPropertyChanged("BenefitOptionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitOptionId;
        partial void OnBenefitOptionIdChanging(string value);
        partial void OnBenefitOptionIdChanged();
        /// <summary>
        /// There are no comments for Property Effective in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset Effective
        {
            get
            {
                return this._Effective;
            }
            set
            {
                this.OnEffectiveChanging(value);
                this._Effective = value;
                this.OnEffectiveChanged();
                this.OnPropertyChanged("Effective");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Effective;
        partial void OnEffectiveChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveChanged();
        /// <summary>
        /// There are no comments for Property Expiration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset Expiration
        {
            get
            {
                return this._Expiration;
            }
            set
            {
                this.OnExpirationChanging(value);
                this._Expiration = value;
                this.OnExpirationChanged();
                this.OnPropertyChanged("Expiration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Expiration;
        partial void OnExpirationChanging(global::System.DateTimeOffset value);
        partial void OnExpirationChanged();
        /// <summary>
        /// There are no comments for Property WorkerId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkerId
        {
            get
            {
                return this._WorkerId;
            }
            set
            {
                this.OnWorkerIdChanging(value);
                this._WorkerId = value;
                this.OnWorkerIdChanged();
                this.OnPropertyChanged("WorkerId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerId;
        partial void OnWorkerIdChanging(string value);
        partial void OnWorkerIdChanged();
        /// <summary>
        /// There are no comments for Property OverrideStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset OverrideStartDate
        {
            get
            {
                return this._OverrideStartDate;
            }
            set
            {
                this.OnOverrideStartDateChanging(value);
                this._OverrideStartDate = value;
                this.OnOverrideStartDateChanged();
                this.OnPropertyChanged("OverrideStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _OverrideStartDate;
        partial void OnOverrideStartDateChanging(global::System.DateTimeOffset value);
        partial void OnOverrideStartDateChanged();
        /// <summary>
        /// There are no comments for Property BenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BenefitId
        {
            get
            {
                return this._BenefitId;
            }
            set
            {
                this.OnBenefitIdChanging(value);
                this._BenefitId = value;
                this.OnBenefitIdChanged();
                this.OnPropertyChanged("BenefitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitId;
        partial void OnBenefitIdChanging(string value);
        partial void OnBenefitIdChanged();
        /// <summary>
        /// There are no comments for Property OverrideEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset OverrideEndDate
        {
            get
            {
                return this._OverrideEndDate;
            }
            set
            {
                this.OnOverrideEndDateChanging(value);
                this._OverrideEndDate = value;
                this.OnOverrideEndDateChanged();
                this.OnPropertyChanged("OverrideEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _OverrideEndDate;
        partial void OnOverrideEndDateChanging(global::System.DateTimeOffset value);
        partial void OnOverrideEndDateChanged();
        /// <summary>
        /// There are no comments for Property BenefitPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitPlan BenefitPlan
        {
            get
            {
                return this._BenefitPlan;
            }
            set
            {
                this.OnBenefitPlanChanging(value);
                this._BenefitPlan = value;
                this.OnBenefitPlanChanged();
                this.OnPropertyChanged("BenefitPlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitPlan _BenefitPlan;
        partial void OnBenefitPlanChanging(global::Microsoft.Dynamics.DataEntities.BenefitPlan value);
        partial void OnBenefitPlanChanged();
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
        /// There are no comments for Property BenefitOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitOption BenefitOption
        {
            get
            {
                return this._BenefitOption;
            }
            set
            {
                this.OnBenefitOptionChanging(value);
                this._BenefitOption = value;
                this.OnBenefitOptionChanged();
                this.OnPropertyChanged("BenefitOption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitOption _BenefitOption;
        partial void OnBenefitOptionChanging(global::Microsoft.Dynamics.DataEntities.BenefitOption value);
        partial void OnBenefitOptionChanged();
        /// <summary>
        /// There are no comments for Property Benefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Benefit Benefit
        {
            get
            {
                return this._Benefit;
            }
            set
            {
                this.OnBenefitChanging(value);
                this._Benefit = value;
                this.OnBenefitChanged();
                this.OnPropertyChanged("Benefit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Benefit _Benefit;
        partial void OnBenefitChanging(global::Microsoft.Dynamics.DataEntities.Benefit value);
        partial void OnBenefitChanged();
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
