﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 6/6/2021 9:11:38 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for CompVarPlanTableSingle in the schema.
        /// </summary>
    public partial class CompVarPlanTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CompVarPlanTable>
    {
        /// <summary>
        /// Initialize a new CompVarPlanTableSingle object.
        /// </summary>
        public CompVarPlanTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CompVarPlanTableSingle object.
        /// </summary>
        public CompVarPlanTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CompVarPlanTableSingle object.
        /// </summary>
        public CompVarPlanTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CompVarPlanTable> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CompVarPlanLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevel> CompVarPlanLevel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompVarPlanLevel == null))
                {
                    this._CompVarPlanLevel = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevel>(GetPath("CompVarPlanLevel"));
                }
                return this._CompVarPlanLevel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevel> _CompVarPlanLevel;
        /// <summary>
        /// There are no comments for Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CurrencySingle Currency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Currency == null))
                {
                    this._Currency = new global::Microsoft.Dynamics.DataEntities.CurrencySingle(this.Context, GetPath("Currency"));
                }
                return this._Currency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CurrencySingle _Currency;
    }
        /// <summary>
        /// There are no comments for CompVarPlanTable in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PlanId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PlanId")]
    [global::Microsoft.OData.Client.EntitySet("CompVarPlanTables")]
    public partial class CompVarPlanTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CompVarPlanTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="planId">Initial value of PlanId.</param>
        /// <param name="expirationDate">Initial value of ExpirationDate.</param>
        /// <param name="leverageOverObjective">Initial value of LeverageOverObjective.</param>
        /// <param name="unitValue">Initial value of UnitValue.</param>
        /// <param name="leverageMaximum">Initial value of LeverageMaximum.</param>
        /// <param name="effectiveDate">Initial value of EffectiveDate.</param>
        /// <param name="leverage100Percent">Initial value of Leverage100Percent.</param>
        /// <param name="percentOfBasis">Initial value of PercentOfBasis.</param>
        /// <param name="leverageUnderObjective">Initial value of LeverageUnderObjective.</param>
        /// <param name="leverageMinimum">Initial value of LeverageMinimum.</param>
        /// <param name="numberOfUnits">Initial value of NumberOfUnits.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CompVarPlanTable CreateCompVarPlanTable(string dataAreaId, 
                    string planId, 
                    global::System.DateTimeOffset expirationDate, 
                    decimal leverageOverObjective, 
                    decimal unitValue, 
                    decimal leverageMaximum, 
                    global::System.DateTimeOffset effectiveDate, 
                    decimal leverage100Percent, 
                    decimal percentOfBasis, 
                    decimal leverageUnderObjective, 
                    decimal leverageMinimum, 
                    int numberOfUnits)
        {
            CompVarPlanTable compVarPlanTable = new CompVarPlanTable();
            compVarPlanTable.dataAreaId = dataAreaId;
            compVarPlanTable.PlanId = planId;
            compVarPlanTable.ExpirationDate = expirationDate;
            compVarPlanTable.LeverageOverObjective = leverageOverObjective;
            compVarPlanTable.UnitValue = unitValue;
            compVarPlanTable.LeverageMaximum = leverageMaximum;
            compVarPlanTable.EffectiveDate = effectiveDate;
            compVarPlanTable.Leverage100Percent = leverage100Percent;
            compVarPlanTable.PercentOfBasis = percentOfBasis;
            compVarPlanTable.LeverageUnderObjective = leverageUnderObjective;
            compVarPlanTable.LeverageMinimum = leverageMinimum;
            compVarPlanTable.NumberOfUnits = numberOfUnits;
            return compVarPlanTable;
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
        /// There are no comments for Property PlanId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PlanId
        {
            get
            {
                return this._PlanId;
            }
            set
            {
                this.OnPlanIdChanging(value);
                this._PlanId = value;
                this.OnPlanIdChanged();
                this.OnPropertyChanged("PlanId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlanId;
        partial void OnPlanIdChanging(string value);
        partial void OnPlanIdChanged();
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
        /// There are no comments for Property VariableCompensationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VariableCompensationType
        {
            get
            {
                return this._VariableCompensationType;
            }
            set
            {
                this.OnVariableCompensationTypeChanging(value);
                this._VariableCompensationType = value;
                this.OnVariableCompensationTypeChanged();
                this.OnPropertyChanged("VariableCompensationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VariableCompensationType;
        partial void OnVariableCompensationTypeChanging(string value);
        partial void OnVariableCompensationTypeChanged();
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
        /// There are no comments for Property LeverageOverObjective in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LeverageOverObjective
        {
            get
            {
                return this._LeverageOverObjective;
            }
            set
            {
                this.OnLeverageOverObjectiveChanging(value);
                this._LeverageOverObjective = value;
                this.OnLeverageOverObjectiveChanged();
                this.OnPropertyChanged("LeverageOverObjective");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LeverageOverObjective;
        partial void OnLeverageOverObjectiveChanging(decimal value);
        partial void OnLeverageOverObjectiveChanged();
        /// <summary>
        /// There are no comments for Property UnitValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal UnitValue
        {
            get
            {
                return this._UnitValue;
            }
            set
            {
                this.OnUnitValueChanging(value);
                this._UnitValue = value;
                this.OnUnitValueChanged();
                this.OnPropertyChanged("UnitValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _UnitValue;
        partial void OnUnitValueChanging(decimal value);
        partial void OnUnitValueChanged();
        /// <summary>
        /// There are no comments for Property EnableRecommendation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EnableRecommendation
        {
            get
            {
                return this._EnableRecommendation;
            }
            set
            {
                this.OnEnableRecommendationChanging(value);
                this._EnableRecommendation = value;
                this.OnEnableRecommendationChanged();
                this.OnPropertyChanged("EnableRecommendation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EnableRecommendation;
        partial void OnEnableRecommendationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEnableRecommendationChanged();
        /// <summary>
        /// There are no comments for Property UnitRelationship in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UnitRelationship
        {
            get
            {
                return this._UnitRelationship;
            }
            set
            {
                this.OnUnitRelationshipChanging(value);
                this._UnitRelationship = value;
                this.OnUnitRelationshipChanged();
                this.OnPropertyChanged("UnitRelationship");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UnitRelationship;
        partial void OnUnitRelationshipChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUnitRelationshipChanged();
        /// <summary>
        /// There are no comments for Property LeverageToleranceMax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompTolerance> LeverageToleranceMax
        {
            get
            {
                return this._LeverageToleranceMax;
            }
            set
            {
                this.OnLeverageToleranceMaxChanging(value);
                this._LeverageToleranceMax = value;
                this.OnLeverageToleranceMaxChanged();
                this.OnPropertyChanged("LeverageToleranceMax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompTolerance> _LeverageToleranceMax;
        partial void OnLeverageToleranceMaxChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompTolerance> value);
        partial void OnLeverageToleranceMaxChanged();
        /// <summary>
        /// There are no comments for Property LeverageMaximum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LeverageMaximum
        {
            get
            {
                return this._LeverageMaximum;
            }
            set
            {
                this.OnLeverageMaximumChanging(value);
                this._LeverageMaximum = value;
                this.OnLeverageMaximumChanged();
                this.OnPropertyChanged("LeverageMaximum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LeverageMaximum;
        partial void OnLeverageMaximumChanging(decimal value);
        partial void OnLeverageMaximumChanged();
        /// <summary>
        /// There are no comments for Property EnableLevels in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EnableLevels
        {
            get
            {
                return this._EnableLevels;
            }
            set
            {
                this.OnEnableLevelsChanging(value);
                this._EnableLevels = value;
                this.OnEnableLevelsChanged();
                this.OnPropertyChanged("EnableLevels");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EnableLevels;
        partial void OnEnableLevelsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEnableLevelsChanged();
        /// <summary>
        /// There are no comments for Property LeverageToleranceMin in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompTolerance> LeverageToleranceMin
        {
            get
            {
                return this._LeverageToleranceMin;
            }
            set
            {
                this.OnLeverageToleranceMinChanging(value);
                this._LeverageToleranceMin = value;
                this.OnLeverageToleranceMinChanged();
                this.OnPropertyChanged("LeverageToleranceMin");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompTolerance> _LeverageToleranceMin;
        partial void OnLeverageToleranceMinChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompTolerance> value);
        partial void OnLeverageToleranceMinChanged();
        /// <summary>
        /// There are no comments for Property VariableAwardBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarAwardBasis> VariableAwardBasis
        {
            get
            {
                return this._VariableAwardBasis;
            }
            set
            {
                this.OnVariableAwardBasisChanging(value);
                this._VariableAwardBasis = value;
                this.OnVariableAwardBasisChanged();
                this.OnPropertyChanged("VariableAwardBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarAwardBasis> _VariableAwardBasis;
        partial void OnVariableAwardBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarAwardBasis> value);
        partial void OnVariableAwardBasisChanged();
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
        /// There are no comments for Property EnableEnrollment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EnableEnrollment
        {
            get
            {
                return this._EnableEnrollment;
            }
            set
            {
                this.OnEnableEnrollmentChanging(value);
                this._EnableEnrollment = value;
                this.OnEnableEnrollmentChanged();
                this.OnPropertyChanged("EnableEnrollment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EnableEnrollment;
        partial void OnEnableEnrollmentChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEnableEnrollmentChanged();
        /// <summary>
        /// There are no comments for Property HireRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompHireRule> HireRule
        {
            get
            {
                return this._HireRule;
            }
            set
            {
                this.OnHireRuleChanging(value);
                this._HireRule = value;
                this.OnHireRuleChanged();
                this.OnPropertyChanged("HireRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompHireRule> _HireRule;
        partial void OnHireRuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompHireRule> value);
        partial void OnHireRuleChanged();
        /// <summary>
        /// There are no comments for Property Leverage100Percent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Leverage100Percent
        {
            get
            {
                return this._Leverage100Percent;
            }
            set
            {
                this.OnLeverage100PercentChanging(value);
                this._Leverage100Percent = value;
                this.OnLeverage100PercentChanged();
                this.OnPropertyChanged("Leverage100Percent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Leverage100Percent;
        partial void OnLeverage100PercentChanging(decimal value);
        partial void OnLeverage100PercentChanged();
        /// <summary>
        /// There are no comments for Property PercentOfBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PercentOfBasis
        {
            get
            {
                return this._PercentOfBasis;
            }
            set
            {
                this.OnPercentOfBasisChanging(value);
                this._PercentOfBasis = value;
                this.OnPercentOfBasisChanged();
                this.OnPropertyChanged("PercentOfBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PercentOfBasis;
        partial void OnPercentOfBasisChanging(decimal value);
        partial void OnPercentOfBasisChanged();
        /// <summary>
        /// There are no comments for Property UnitCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UnitCurrencyCode
        {
            get
            {
                return this._UnitCurrencyCode;
            }
            set
            {
                this.OnUnitCurrencyCodeChanging(value);
                this._UnitCurrencyCode = value;
                this.OnUnitCurrencyCodeChanged();
                this.OnPropertyChanged("UnitCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitCurrencyCode;
        partial void OnUnitCurrencyCodeChanging(string value);
        partial void OnUnitCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property LeverageUnderObjective in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LeverageUnderObjective
        {
            get
            {
                return this._LeverageUnderObjective;
            }
            set
            {
                this.OnLeverageUnderObjectiveChanging(value);
                this._LeverageUnderObjective = value;
                this.OnLeverageUnderObjectiveChanged();
                this.OnPropertyChanged("LeverageUnderObjective");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LeverageUnderObjective;
        partial void OnLeverageUnderObjectiveChanging(decimal value);
        partial void OnLeverageUnderObjectiveChanged();
        /// <summary>
        /// There are no comments for Property VestingRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VestingRule
        {
            get
            {
                return this._VestingRule;
            }
            set
            {
                this.OnVestingRuleChanging(value);
                this._VestingRule = value;
                this.OnVestingRuleChanged();
                this.OnPropertyChanged("VestingRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VestingRule;
        partial void OnVestingRuleChanging(string value);
        partial void OnVestingRuleChanged();
        /// <summary>
        /// There are no comments for Property CalculationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarPlanCalcType> CalculationType
        {
            get
            {
                return this._CalculationType;
            }
            set
            {
                this.OnCalculationTypeChanging(value);
                this._CalculationType = value;
                this.OnCalculationTypeChanged();
                this.OnPropertyChanged("CalculationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarPlanCalcType> _CalculationType;
        partial void OnCalculationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarPlanCalcType> value);
        partial void OnCalculationTypeChanged();
        /// <summary>
        /// There are no comments for Property LeverageMinimum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LeverageMinimum
        {
            get
            {
                return this._LeverageMinimum;
            }
            set
            {
                this.OnLeverageMinimumChanging(value);
                this._LeverageMinimum = value;
                this.OnLeverageMinimumChanged();
                this.OnPropertyChanged("LeverageMinimum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LeverageMinimum;
        partial void OnLeverageMinimumChanging(decimal value);
        partial void OnLeverageMinimumChanged();
        /// <summary>
        /// There are no comments for Property NumberOfUnits in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int NumberOfUnits
        {
            get
            {
                return this._NumberOfUnits;
            }
            set
            {
                this.OnNumberOfUnitsChanging(value);
                this._NumberOfUnits = value;
                this.OnNumberOfUnitsChanged();
                this.OnPropertyChanged("NumberOfUnits");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NumberOfUnits;
        partial void OnNumberOfUnitsChanging(int value);
        partial void OnNumberOfUnitsChanged();
        /// <summary>
        /// There are no comments for Property AwardBasisCalculation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarPlanAwardBasis> AwardBasisCalculation
        {
            get
            {
                return this._AwardBasisCalculation;
            }
            set
            {
                this.OnAwardBasisCalculationChanging(value);
                this._AwardBasisCalculation = value;
                this.OnAwardBasisCalculationChanged();
                this.OnPropertyChanged("AwardBasisCalculation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarPlanAwardBasis> _AwardBasisCalculation;
        partial void OnAwardBasisCalculationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarPlanAwardBasis> value);
        partial void OnAwardBasisCalculationChanged();
        /// <summary>
        /// There are no comments for Property CompVarPlanLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevel> CompVarPlanLevel
        {
            get
            {
                return this._CompVarPlanLevel;
            }
            set
            {
                this.OnCompVarPlanLevelChanging(value);
                this._CompVarPlanLevel = value;
                this.OnCompVarPlanLevelChanged();
                this.OnPropertyChanged("CompVarPlanLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevel> _CompVarPlanLevel = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevel>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompVarPlanLevelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevel> value);
        partial void OnCompVarPlanLevelChanged();
        /// <summary>
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Currency Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this.OnCurrencyChanging(value);
                this._Currency = value;
                this.OnCurrencyChanged();
                this.OnPropertyChanged("Currency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Currency _Currency;
        partial void OnCurrencyChanging(global::Microsoft.Dynamics.DataEntities.Currency value);
        partial void OnCurrencyChanged();
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
