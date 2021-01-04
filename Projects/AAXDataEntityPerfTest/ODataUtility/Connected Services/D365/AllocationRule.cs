﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/3/2021 8:21:45 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for AllocationRuleSingle in the schema.
        /// </summary>
    public partial class AllocationRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AllocationRule>
    {
        /// <summary>
        /// Initialize a new AllocationRuleSingle object.
        /// </summary>
        public AllocationRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AllocationRuleSingle object.
        /// </summary>
        public AllocationRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AllocationRuleSingle object.
        /// </summary>
        public AllocationRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AllocationRule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AllocationRuleDestination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AllocationRuleDestination> AllocationRuleDestination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AllocationRuleDestination == null))
                {
                    this._AllocationRuleDestination = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AllocationRuleDestination>(GetPath("AllocationRuleDestination"));
                }
                return this._AllocationRuleDestination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AllocationRuleDestination> _AllocationRuleDestination;
        /// <summary>
        /// There are no comments for AllocationRuleSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AllocationRuleSource> AllocationRuleSource
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AllocationRuleSource == null))
                {
                    this._AllocationRuleSource = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AllocationRuleSource>(GetPath("AllocationRuleSource"));
                }
                return this._AllocationRuleSource;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AllocationRuleSource> _AllocationRuleSource;
        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
        /// <summary>
        /// There are no comments for AllocationRule in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// Rule
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Rule")]
    [global::Microsoft.OData.Client.EntitySet("AllocationRules")]
    public partial class AllocationRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AllocationRule object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="rule">Initial value of Rule.</param>
        /// <param name="dateLastRun">Initial value of DateLastRun.</param>
        /// <param name="expirationDate">Initial value of ExpirationDate.</param>
        /// <param name="effectiveDate">Initial value of EffectiveDate.</param>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="fixedValue">Initial value of FixedValue.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AllocationRule CreateAllocationRule(string dataAreaId, 
                    string rule, 
                    global::System.DateTimeOffset dateLastRun, 
                    global::System.DateTimeOffset expirationDate, 
                    global::System.DateTimeOffset effectiveDate, 
                    decimal amount, 
                    decimal fixedValue)
        {
            AllocationRule allocationRule = new AllocationRule();
            allocationRule.dataAreaId = dataAreaId;
            allocationRule.Rule = rule;
            allocationRule.DateLastRun = dateLastRun;
            allocationRule.ExpirationDate = expirationDate;
            allocationRule.EffectiveDate = effectiveDate;
            allocationRule.Amount = amount;
            allocationRule.FixedValue = fixedValue;
            return allocationRule;
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
        /// There are no comments for Property Rule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Rule
        {
            get
            {
                return this._Rule;
            }
            set
            {
                this.OnRuleChanging(value);
                this._Rule = value;
                this.OnRuleChanged();
                this.OnPropertyChanged("Rule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Rule;
        partial void OnRuleChanging(string value);
        partial void OnRuleChanged();
        /// <summary>
        /// There are no comments for Property DateLastRun in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DateLastRun
        {
            get
            {
                return this._DateLastRun;
            }
            set
            {
                this.OnDateLastRunChanging(value);
                this._DateLastRun = value;
                this.OnDateLastRunChanged();
                this.OnPropertyChanged("DateLastRun");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateLastRun;
        partial void OnDateLastRunChanging(global::System.DateTimeOffset value);
        partial void OnDateLastRunChanged();
        /// <summary>
        /// There are no comments for Property ExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ExpirationDate
        {
            get
            {
                return this._ExpirationDate;
            }
            set
            {
                this.OnExpirationDateChanging(value);
                this._ExpirationDate = value;
                this.OnExpirationDateChanged();
                this.OnPropertyChanged("ExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ExpirationDate;
        partial void OnExpirationDateChanging(global::System.DateTimeOffset value);
        partial void OnExpirationDateChanged();
        /// <summary>
        /// There are no comments for Property IntercompanyRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IntercompanyRule
        {
            get
            {
                return this._IntercompanyRule;
            }
            set
            {
                this.OnIntercompanyRuleChanging(value);
                this._IntercompanyRule = value;
                this.OnIntercompanyRuleChanged();
                this.OnPropertyChanged("IntercompanyRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IntercompanyRule;
        partial void OnIntercompanyRuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIntercompanyRuleChanged();
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
        /// There are no comments for Property JournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalName
        {
            get
            {
                return this._JournalName;
            }
            set
            {
                this.OnJournalNameChanging(value);
                this._JournalName = value;
                this.OnJournalNameChanged();
                this.OnPropertyChanged("JournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalName;
        partial void OnJournalNameChanging(string value);
        partial void OnJournalNameChanged();
        /// <summary>
        /// There are no comments for Property KeepDimensionFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationFromTo> KeepDimensionFrom
        {
            get
            {
                return this._KeepDimensionFrom;
            }
            set
            {
                this.OnKeepDimensionFromChanging(value);
                this._KeepDimensionFrom = value;
                this.OnKeepDimensionFromChanged();
                this.OnPropertyChanged("KeepDimensionFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationFromTo> _KeepDimensionFrom;
        partial void OnKeepDimensionFromChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationFromTo> value);
        partial void OnKeepDimensionFromChanged();
        /// <summary>
        /// There are no comments for Property Active in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Active
        {
            get
            {
                return this._Active;
            }
            set
            {
                this.OnActiveChanging(value);
                this._Active = value;
                this.OnActiveChanged();
                this.OnPropertyChanged("Active");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Active;
        partial void OnActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnActiveChanged();
        /// <summary>
        /// There are no comments for Property KeepAccountFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationFromTo> KeepAccountFrom
        {
            get
            {
                return this._KeepAccountFrom;
            }
            set
            {
                this.OnKeepAccountFromChanging(value);
                this._KeepAccountFrom = value;
                this.OnKeepAccountFromChanged();
                this.OnPropertyChanged("KeepAccountFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationFromTo> _KeepAccountFrom;
        partial void OnKeepAccountFromChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationFromTo> value);
        partial void OnKeepAccountFromChanged();
        /// <summary>
        /// There are no comments for Property MathematicalOperation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationMathType> MathematicalOperation
        {
            get
            {
                return this._MathematicalOperation;
            }
            set
            {
                this.OnMathematicalOperationChanging(value);
                this._MathematicalOperation = value;
                this.OnMathematicalOperationChanged();
                this.OnPropertyChanged("MathematicalOperation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationMathType> _MathematicalOperation;
        partial void OnMathematicalOperationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationMathType> value);
        partial void OnMathematicalOperationChanged();
        /// <summary>
        /// There are no comments for Property EffectiveDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EffectiveDate
        {
            get
            {
                return this._EffectiveDate;
            }
            set
            {
                this.OnEffectiveDateChanging(value);
                this._EffectiveDate = value;
                this.OnEffectiveDateChanged();
                this.OnPropertyChanged("EffectiveDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EffectiveDate;
        partial void OnEffectiveDateChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveDateChanged();
        /// <summary>
        /// There are no comments for Property OffsetAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OffsetAccountDisplayValue
        {
            get
            {
                return this._OffsetAccountDisplayValue;
            }
            set
            {
                this.OnOffsetAccountDisplayValueChanging(value);
                this._OffsetAccountDisplayValue = value;
                this.OnOffsetAccountDisplayValueChanged();
                this.OnPropertyChanged("OffsetAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OffsetAccountDisplayValue;
        partial void OnOffsetAccountDisplayValueChanging(string value);
        partial void OnOffsetAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DataSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationSource> DataSource
        {
            get
            {
                return this._DataSource;
            }
            set
            {
                this.OnDataSourceChanging(value);
                this._DataSource = value;
                this.OnDataSourceChanged();
                this.OnPropertyChanged("DataSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationSource> _DataSource;
        partial void OnDataSourceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationSource> value);
        partial void OnDataSourceChanged();
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
        /// There are no comments for Property DimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionDisplayValue
        {
            get
            {
                return this._DimensionDisplayValue;
            }
            set
            {
                this.OnDimensionDisplayValueChanging(value);
                this._DimensionDisplayValue = value;
                this.OnDimensionDisplayValueChanged();
                this.OnPropertyChanged("DimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionDisplayValue;
        partial void OnDimensionDisplayValueChanging(string value);
        partial void OnDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property FixedValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal FixedValue
        {
            get
            {
                return this._FixedValue;
            }
            set
            {
                this.OnFixedValueChanging(value);
                this._FixedValue = value;
                this.OnFixedValueChanged();
                this.OnPropertyChanged("FixedValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FixedValue;
        partial void OnFixedValueChanging(decimal value);
        partial void OnFixedValueChanged();
        /// <summary>
        /// There are no comments for Property AllocationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationMethod> AllocationMethod
        {
            get
            {
                return this._AllocationMethod;
            }
            set
            {
                this.OnAllocationMethodChanging(value);
                this._AllocationMethod = value;
                this.OnAllocationMethodChanged();
                this.OnPropertyChanged("AllocationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationMethod> _AllocationMethod;
        partial void OnAllocationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationMethod> value);
        partial void OnAllocationMethodChanged();
        /// <summary>
        /// There are no comments for Property OffsetAccountFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationFromTo> OffsetAccountFrom
        {
            get
            {
                return this._OffsetAccountFrom;
            }
            set
            {
                this.OnOffsetAccountFromChanging(value);
                this._OffsetAccountFrom = value;
                this.OnOffsetAccountFromChanged();
                this.OnPropertyChanged("OffsetAccountFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationFromTo> _OffsetAccountFrom;
        partial void OnOffsetAccountFromChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationFromTo> value);
        partial void OnOffsetAccountFromChanged();
        /// <summary>
        /// There are no comments for Property OffsetDimensionFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationFromTo> OffsetDimensionFrom
        {
            get
            {
                return this._OffsetDimensionFrom;
            }
            set
            {
                this.OnOffsetDimensionFromChanging(value);
                this._OffsetDimensionFrom = value;
                this.OnOffsetDimensionFromChanged();
                this.OnPropertyChanged("OffsetDimensionFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationFromTo> _OffsetDimensionFrom;
        partial void OnOffsetDimensionFromChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationFromTo> value);
        partial void OnOffsetDimensionFromChanged();
        /// <summary>
        /// There are no comments for Property DateIntervalCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DateIntervalCode
        {
            get
            {
                return this._DateIntervalCode;
            }
            set
            {
                this.OnDateIntervalCodeChanging(value);
                this._DateIntervalCode = value;
                this.OnDateIntervalCodeChanged();
                this.OnPropertyChanged("DateIntervalCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DateIntervalCode;
        partial void OnDateIntervalCodeChanging(string value);
        partial void OnDateIntervalCodeChanged();
        /// <summary>
        /// There are no comments for Property AllocationRuleDestination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AllocationRuleDestination> AllocationRuleDestination
        {
            get
            {
                return this._AllocationRuleDestination;
            }
            set
            {
                this.OnAllocationRuleDestinationChanging(value);
                this._AllocationRuleDestination = value;
                this.OnAllocationRuleDestinationChanged();
                this.OnPropertyChanged("AllocationRuleDestination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AllocationRuleDestination> _AllocationRuleDestination = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AllocationRuleDestination>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAllocationRuleDestinationChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AllocationRuleDestination> value);
        partial void OnAllocationRuleDestinationChanged();
        /// <summary>
        /// There are no comments for Property AllocationRuleSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AllocationRuleSource> AllocationRuleSource
        {
            get
            {
                return this._AllocationRuleSource;
            }
            set
            {
                this.OnAllocationRuleSourceChanging(value);
                this._AllocationRuleSource = value;
                this.OnAllocationRuleSourceChanged();
                this.OnPropertyChanged("AllocationRuleSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AllocationRuleSource> _AllocationRuleSource = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AllocationRuleSource>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAllocationRuleSourceChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AllocationRuleSource> value);
        partial void OnAllocationRuleSourceChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
