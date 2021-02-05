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
        /// There are no comments for WorkerGarnishmentRuleSingle in the schema.
        /// </summary>
    public partial class WorkerGarnishmentRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerGarnishmentRule>
    {
        /// <summary>
        /// Initialize a new WorkerGarnishmentRuleSingle object.
        /// </summary>
        public WorkerGarnishmentRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkerGarnishmentRuleSingle object.
        /// </summary>
        public WorkerGarnishmentRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkerGarnishmentRuleSingle object.
        /// </summary>
        public WorkerGarnishmentRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerGarnishmentRule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressStateSingle State
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._State == null))
                {
                    this._State = new global::Microsoft.Dynamics.DataEntities.AddressStateSingle(this.Context, GetPath("State"));
                }
                return this._State;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressStateSingle _State;
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
        /// There are no comments for DisposableIncome in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DisposableIncomeSingle DisposableIncome
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DisposableIncome == null))
                {
                    this._DisposableIncome = new global::Microsoft.Dynamics.DataEntities.DisposableIncomeSingle(this.Context, GetPath("DisposableIncome"));
                }
                return this._DisposableIncome;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DisposableIncomeSingle _DisposableIncome;
    }
        /// <summary>
        /// There are no comments for WorkerGarnishmentRule in the schema.
        /// </summary>
    /// <KeyProperties>
    /// GarnishmentTaxLevyType
    /// PersonnelNumber
    /// StateId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("GarnishmentTaxLevyType", "PersonnelNumber", "StateId")]
    [global::Microsoft.OData.Client.EntitySet("WorkerGarnishmentRules")]
    public partial class WorkerGarnishmentRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkerGarnishmentRule object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="stateId">Initial value of StateId.</param>
        /// <param name="disposableEarningsPercent">Initial value of DisposableEarningsPercent.</param>
        /// <param name="disposableIncomeExemption">Initial value of DisposableIncomeExemption.</param>
        /// <param name="exemptEarningAmount">Initial value of ExemptEarningAmount.</param>
        /// <param name="alternateLimit">Initial value of AlternateLimit.</param>
        /// <param name="minimumWageMultiplier">Initial value of MinimumWageMultiplier.</param>
        /// <param name="minimumWage">Initial value of MinimumWage.</param>
        /// <param name="worker">Initial value of Worker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkerGarnishmentRule CreateWorkerGarnishmentRule(string personnelNumber, 
                    string stateId, 
                    decimal disposableEarningsPercent, 
                    decimal disposableIncomeExemption, 
                    decimal exemptEarningAmount, 
                    decimal alternateLimit, 
                    decimal minimumWageMultiplier, 
                    decimal minimumWage, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker)
        {
            WorkerGarnishmentRule workerGarnishmentRule = new WorkerGarnishmentRule();
            workerGarnishmentRule.PersonnelNumber = personnelNumber;
            workerGarnishmentRule.StateId = stateId;
            workerGarnishmentRule.DisposableEarningsPercent = disposableEarningsPercent;
            workerGarnishmentRule.DisposableIncomeExemption = disposableIncomeExemption;
            workerGarnishmentRule.ExemptEarningAmount = exemptEarningAmount;
            workerGarnishmentRule.AlternateLimit = alternateLimit;
            workerGarnishmentRule.MinimumWageMultiplier = minimumWageMultiplier;
            workerGarnishmentRule.MinimumWage = minimumWage;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            workerGarnishmentRule.Worker = worker;
            return workerGarnishmentRule;
        }
        /// <summary>
        /// There are no comments for Property GarnishmentTaxLevyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollGarnishmentTaxLevyType> GarnishmentTaxLevyType
        {
            get
            {
                return this._GarnishmentTaxLevyType;
            }
            set
            {
                this.OnGarnishmentTaxLevyTypeChanging(value);
                this._GarnishmentTaxLevyType = value;
                this.OnGarnishmentTaxLevyTypeChanged();
                this.OnPropertyChanged("GarnishmentTaxLevyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollGarnishmentTaxLevyType> _GarnishmentTaxLevyType;
        partial void OnGarnishmentTaxLevyTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollGarnishmentTaxLevyType> value);
        partial void OnGarnishmentTaxLevyTypeChanged();
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
        /// There are no comments for Property StateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string StateId
        {
            get
            {
                return this._StateId;
            }
            set
            {
                this.OnStateIdChanging(value);
                this._StateId = value;
                this.OnStateIdChanged();
                this.OnPropertyChanged("StateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StateId;
        partial void OnStateIdChanging(string value);
        partial void OnStateIdChanged();
        /// <summary>
        /// There are no comments for Property MultipleMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollMultipleGarnishmentMethod> MultipleMethod
        {
            get
            {
                return this._MultipleMethod;
            }
            set
            {
                this.OnMultipleMethodChanging(value);
                this._MultipleMethod = value;
                this.OnMultipleMethodChanged();
                this.OnPropertyChanged("MultipleMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollMultipleGarnishmentMethod> _MultipleMethod;
        partial void OnMultipleMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollMultipleGarnishmentMethod> value);
        partial void OnMultipleMethodChanged();
        /// <summary>
        /// There are no comments for Property DisposableEarningsPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DisposableEarningsPercent
        {
            get
            {
                return this._DisposableEarningsPercent;
            }
            set
            {
                this.OnDisposableEarningsPercentChanging(value);
                this._DisposableEarningsPercent = value;
                this.OnDisposableEarningsPercentChanged();
                this.OnPropertyChanged("DisposableEarningsPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DisposableEarningsPercent;
        partial void OnDisposableEarningsPercentChanging(decimal value);
        partial void OnDisposableEarningsPercentChanged();
        /// <summary>
        /// There are no comments for Property LimitMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollLimitMethod> LimitMethod
        {
            get
            {
                return this._LimitMethod;
            }
            set
            {
                this.OnLimitMethodChanging(value);
                this._LimitMethod = value;
                this.OnLimitMethodChanged();
                this.OnPropertyChanged("LimitMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollLimitMethod> _LimitMethod;
        partial void OnLimitMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollLimitMethod> value);
        partial void OnLimitMethodChanged();
        /// <summary>
        /// There are no comments for Property DisposableIncomeExemption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DisposableIncomeExemption
        {
            get
            {
                return this._DisposableIncomeExemption;
            }
            set
            {
                this.OnDisposableIncomeExemptionChanging(value);
                this._DisposableIncomeExemption = value;
                this.OnDisposableIncomeExemptionChanged();
                this.OnPropertyChanged("DisposableIncomeExemption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DisposableIncomeExemption;
        partial void OnDisposableIncomeExemptionChanging(decimal value);
        partial void OnDisposableIncomeExemptionChanged();
        /// <summary>
        /// There are no comments for Property ExemptEarningAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ExemptEarningAmount
        {
            get
            {
                return this._ExemptEarningAmount;
            }
            set
            {
                this.OnExemptEarningAmountChanging(value);
                this._ExemptEarningAmount = value;
                this.OnExemptEarningAmountChanged();
                this.OnPropertyChanged("ExemptEarningAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExemptEarningAmount;
        partial void OnExemptEarningAmountChanging(decimal value);
        partial void OnExemptEarningAmountChanged();
        /// <summary>
        /// There are no comments for Property AlternateLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AlternateLimit
        {
            get
            {
                return this._AlternateLimit;
            }
            set
            {
                this.OnAlternateLimitChanging(value);
                this._AlternateLimit = value;
                this.OnAlternateLimitChanged();
                this.OnPropertyChanged("AlternateLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AlternateLimit;
        partial void OnAlternateLimitChanging(decimal value);
        partial void OnAlternateLimitChanged();
        /// <summary>
        /// There are no comments for Property MinimumWageMultiplier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MinimumWageMultiplier
        {
            get
            {
                return this._MinimumWageMultiplier;
            }
            set
            {
                this.OnMinimumWageMultiplierChanging(value);
                this._MinimumWageMultiplier = value;
                this.OnMinimumWageMultiplierChanged();
                this.OnPropertyChanged("MinimumWageMultiplier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MinimumWageMultiplier;
        partial void OnMinimumWageMultiplierChanging(decimal value);
        partial void OnMinimumWageMultiplierChanged();
        /// <summary>
        /// There are no comments for Property MinimumWage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MinimumWage
        {
            get
            {
                return this._MinimumWage;
            }
            set
            {
                this.OnMinimumWageChanging(value);
                this._MinimumWage = value;
                this.OnMinimumWageChanged();
                this.OnPropertyChanged("MinimumWage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MinimumWage;
        partial void OnMinimumWageChanging(decimal value);
        partial void OnMinimumWageChanged();
        /// <summary>
        /// There are no comments for Property AllowReduction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowReduction
        {
            get
            {
                return this._AllowReduction;
            }
            set
            {
                this.OnAllowReductionChanging(value);
                this._AllowReduction = value;
                this.OnAllowReductionChanged();
                this.OnPropertyChanged("AllowReduction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowReduction;
        partial void OnAllowReductionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowReductionChanged();
        /// <summary>
        /// There are no comments for Property DisposableIncomeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DisposableIncomeName
        {
            get
            {
                return this._DisposableIncomeName;
            }
            set
            {
                this.OnDisposableIncomeNameChanging(value);
                this._DisposableIncomeName = value;
                this.OnDisposableIncomeNameChanged();
                this.OnPropertyChanged("DisposableIncomeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DisposableIncomeName;
        partial void OnDisposableIncomeNameChanging(string value);
        partial void OnDisposableIncomeNameChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressState State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressState _State;
        partial void OnStateChanging(global::Microsoft.Dynamics.DataEntities.AddressState value);
        partial void OnStateChanged();
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
        /// There are no comments for Property DisposableIncome in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DisposableIncome DisposableIncome
        {
            get
            {
                return this._DisposableIncome;
            }
            set
            {
                this.OnDisposableIncomeChanging(value);
                this._DisposableIncome = value;
                this.OnDisposableIncomeChanged();
                this.OnPropertyChanged("DisposableIncome");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DisposableIncome _DisposableIncome;
        partial void OnDisposableIncomeChanging(global::Microsoft.Dynamics.DataEntities.DisposableIncome value);
        partial void OnDisposableIncomeChanged();
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
