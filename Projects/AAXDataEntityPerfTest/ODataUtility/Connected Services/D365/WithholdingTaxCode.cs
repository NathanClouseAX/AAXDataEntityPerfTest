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
        /// There are no comments for WithholdingTaxCodeSingle in the schema.
        /// </summary>
    public partial class WithholdingTaxCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdingTaxCode>
    {
        /// <summary>
        /// Initialize a new WithholdingTaxCodeSingle object.
        /// </summary>
        public WithholdingTaxCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WithholdingTaxCodeSingle object.
        /// </summary>
        public WithholdingTaxCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WithholdingTaxCodeSingle object.
        /// </summary>
        public WithholdingTaxCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdingTaxCode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WithholdingGroupData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WithholdingGroupData> WithholdingGroupData
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WithholdingGroupData == null))
                {
                    this._WithholdingGroupData = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WithholdingGroupData>(GetPath("WithholdingGroupData"));
                }
                return this._WithholdingGroupData;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WithholdingGroupData> _WithholdingGroupData;
        /// <summary>
        /// There are no comments for WithholdingTaxCodeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeValue> WithholdingTaxCodeValue
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WithholdingTaxCodeValue == null))
                {
                    this._WithholdingTaxCodeValue = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeValue>(GetPath("WithholdingTaxCodeValue"));
                }
                return this._WithholdingTaxCodeValue;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeValue> _WithholdingTaxCodeValue;
        /// <summary>
        /// There are no comments for WithholdLedgerAccountGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WithholdLedgerAccountGroupSingle WithholdLedgerAccountGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WithholdLedgerAccountGroup == null))
                {
                    this._WithholdLedgerAccountGroup = new global::Microsoft.Dynamics.DataEntities.WithholdLedgerAccountGroupSingle(this.Context, GetPath("WithholdLedgerAccountGroup"));
                }
                return this._WithholdLedgerAccountGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WithholdLedgerAccountGroupSingle _WithholdLedgerAccountGroup;
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
        /// There are no comments for WithholdingPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WithholdingPeriodSingle WithholdingPeriod
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WithholdingPeriod == null))
                {
                    this._WithholdingPeriod = new global::Microsoft.Dynamics.DataEntities.WithholdingPeriodSingle(this.Context, GetPath("WithholdingPeriod"));
                }
                return this._WithholdingPeriod;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WithholdingPeriodSingle _WithholdingPeriod;
        /// <summary>
        /// There are no comments for WithholdingTaxCodeLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeLimit> WithholdingTaxCodeLimit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WithholdingTaxCodeLimit == null))
                {
                    this._WithholdingTaxCodeLimit = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeLimit>(GetPath("WithholdingTaxCodeLimit"));
                }
                return this._WithholdingTaxCodeLimit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeLimit> _WithholdingTaxCodeLimit;
    }
        /// <summary>
        /// There are no comments for WithholdingTaxCode in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// WithholdingCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WithholdingCode")]
    [global::Microsoft.OData.Client.EntitySet("WithholdingTaxCodes")]
    public partial class WithholdingTaxCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WithholdingTaxCode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="withholdingCode">Initial value of WithholdingCode.</param>
        /// <param name="withholdingTaxRoundOff">Initial value of WithholdingTaxRoundOff.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WithholdingTaxCode CreateWithholdingTaxCode(string dataAreaId, string withholdingCode, decimal withholdingTaxRoundOff)
        {
            WithholdingTaxCode withholdingTaxCode = new WithholdingTaxCode();
            withholdingTaxCode.dataAreaId = dataAreaId;
            withholdingTaxCode.WithholdingCode = withholdingCode;
            withholdingTaxCode.WithholdingTaxRoundOff = withholdingTaxRoundOff;
            return withholdingTaxCode;
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
        /// There are no comments for Property WithholdingCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WithholdingCode
        {
            get
            {
                return this._WithholdingCode;
            }
            set
            {
                this.OnWithholdingCodeChanging(value);
                this._WithholdingCode = value;
                this.OnWithholdingCodeChanged();
                this.OnPropertyChanged("WithholdingCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WithholdingCode;
        partial void OnWithholdingCodeChanging(string value);
        partial void OnWithholdingCodeChanged();
        /// <summary>
        /// There are no comments for Property WithholdingComponentGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WithholdingComponentGroup
        {
            get
            {
                return this._WithholdingComponentGroup;
            }
            set
            {
                this.OnWithholdingComponentGroupChanging(value);
                this._WithholdingComponentGroup = value;
                this.OnWithholdingComponentGroupChanged();
                this.OnPropertyChanged("WithholdingComponentGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WithholdingComponentGroup;
        partial void OnWithholdingComponentGroupChanging(string value);
        partial void OnWithholdingComponentGroupChanged();
        /// <summary>
        /// There are no comments for Property WithholdingTaxBase in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdBaseType> WithholdingTaxBase
        {
            get
            {
                return this._WithholdingTaxBase;
            }
            set
            {
                this.OnWithholdingTaxBaseChanging(value);
                this._WithholdingTaxBase = value;
                this.OnWithholdingTaxBaseChanged();
                this.OnPropertyChanged("WithholdingTaxBase");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdBaseType> _WithholdingTaxBase;
        partial void OnWithholdingTaxBaseChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdBaseType> value);
        partial void OnWithholdingTaxBaseChanged();
        /// <summary>
        /// There are no comments for Property WithholdingTaxName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WithholdingTaxName
        {
            get
            {
                return this._WithholdingTaxName;
            }
            set
            {
                this.OnWithholdingTaxNameChanging(value);
                this._WithholdingTaxName = value;
                this.OnWithholdingTaxNameChanged();
                this.OnPropertyChanged("WithholdingTaxName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WithholdingTaxName;
        partial void OnWithholdingTaxNameChanging(string value);
        partial void OnWithholdingTaxNameChanged();
        /// <summary>
        /// There are no comments for Property BrazilianTaxWithholdType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdType_BR> BrazilianTaxWithholdType
        {
            get
            {
                return this._BrazilianTaxWithholdType;
            }
            set
            {
                this.OnBrazilianTaxWithholdTypeChanging(value);
                this._BrazilianTaxWithholdType = value;
                this.OnBrazilianTaxWithholdTypeChanged();
                this.OnPropertyChanged("BrazilianTaxWithholdType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdType_BR> _BrazilianTaxWithholdType;
        partial void OnBrazilianTaxWithholdTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdType_BR> value);
        partial void OnBrazilianTaxWithholdTypeChanged();
        /// <summary>
        /// There are no comments for Property WithholdingTaxRoundOffType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RoundOffType> WithholdingTaxRoundOffType
        {
            get
            {
                return this._WithholdingTaxRoundOffType;
            }
            set
            {
                this.OnWithholdingTaxRoundOffTypeChanging(value);
                this._WithholdingTaxRoundOffType = value;
                this.OnWithholdingTaxRoundOffTypeChanged();
                this.OnPropertyChanged("WithholdingTaxRoundOffType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RoundOffType> _WithholdingTaxRoundOffType;
        partial void OnWithholdingTaxRoundOffTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RoundOffType> value);
        partial void OnWithholdingTaxRoundOffTypeChanged();
        /// <summary>
        /// There are no comments for Property TaxWithholdAccountGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxWithholdAccountGroup
        {
            get
            {
                return this._TaxWithholdAccountGroup;
            }
            set
            {
                this.OnTaxWithholdAccountGroupChanging(value);
                this._TaxWithholdAccountGroup = value;
                this.OnTaxWithholdAccountGroupChanged();
                this.OnPropertyChanged("TaxWithholdAccountGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxWithholdAccountGroup;
        partial void OnTaxWithholdAccountGroupChanging(string value);
        partial void OnTaxWithholdAccountGroupChanged();
        /// <summary>
        /// There are no comments for Property SettlementPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SettlementPeriod
        {
            get
            {
                return this._SettlementPeriod;
            }
            set
            {
                this.OnSettlementPeriodChanging(value);
                this._SettlementPeriod = value;
                this.OnSettlementPeriodChanged();
                this.OnPropertyChanged("SettlementPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SettlementPeriod;
        partial void OnSettlementPeriodChanging(string value);
        partial void OnSettlementPeriodChanged();
        /// <summary>
        /// There are no comments for Property TaxWithholdPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxWithholdPeriod
        {
            get
            {
                return this._TaxWithholdPeriod;
            }
            set
            {
                this.OnTaxWithholdPeriodChanging(value);
                this._TaxWithholdPeriod = value;
                this.OnTaxWithholdPeriodChanged();
                this.OnPropertyChanged("TaxWithholdPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxWithholdPeriod;
        partial void OnTaxWithholdPeriodChanging(string value);
        partial void OnTaxWithholdPeriodChanged();
        /// <summary>
        /// There are no comments for Property MainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccountIdDisplayValue
        {
            get
            {
                return this._MainAccountIdDisplayValue;
            }
            set
            {
                this.OnMainAccountIdDisplayValueChanging(value);
                this._MainAccountIdDisplayValue = value;
                this.OnMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("MainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountIdDisplayValue;
        partial void OnMainAccountIdDisplayValueChanging(string value);
        partial void OnMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdCodeType_IN> TaxType
        {
            get
            {
                return this._TaxType;
            }
            set
            {
                this.OnTaxTypeChanging(value);
                this._TaxType = value;
                this.OnTaxTypeChanged();
                this.OnPropertyChanged("TaxType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdCodeType_IN> _TaxType;
        partial void OnTaxTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdCodeType_IN> value);
        partial void OnTaxTypeChanged();
        /// <summary>
        /// There are no comments for Property BrazilianTaxWithholdPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BrazilianTaxWithholdPeriod
        {
            get
            {
                return this._BrazilianTaxWithholdPeriod;
            }
            set
            {
                this.OnBrazilianTaxWithholdPeriodChanging(value);
                this._BrazilianTaxWithholdPeriod = value;
                this.OnBrazilianTaxWithholdPeriodChanged();
                this.OnPropertyChanged("BrazilianTaxWithholdPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BrazilianTaxWithholdPeriod;
        partial void OnBrazilianTaxWithholdPeriodChanging(string value);
        partial void OnBrazilianTaxWithholdPeriodChanged();
        /// <summary>
        /// There are no comments for Property WithholdingTaxComponent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WithholdingTaxComponent
        {
            get
            {
                return this._WithholdingTaxComponent;
            }
            set
            {
                this.OnWithholdingTaxComponentChanging(value);
                this._WithholdingTaxComponent = value;
                this.OnWithholdingTaxComponentChanged();
                this.OnPropertyChanged("WithholdingTaxComponent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WithholdingTaxComponent;
        partial void OnWithholdingTaxComponentChanging(string value);
        partial void OnWithholdingTaxComponentChanged();
        /// <summary>
        /// There are no comments for Property WithholdingTaxReceivableDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WithholdingTaxReceivableDisplayValue
        {
            get
            {
                return this._WithholdingTaxReceivableDisplayValue;
            }
            set
            {
                this.OnWithholdingTaxReceivableDisplayValueChanging(value);
                this._WithholdingTaxReceivableDisplayValue = value;
                this.OnWithholdingTaxReceivableDisplayValueChanged();
                this.OnPropertyChanged("WithholdingTaxReceivableDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WithholdingTaxReceivableDisplayValue;
        partial void OnWithholdingTaxReceivableDisplayValueChanging(string value);
        partial void OnWithholdingTaxReceivableDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property ApplyThreshold in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ApplyThreshold
        {
            get
            {
                return this._ApplyThreshold;
            }
            set
            {
                this.OnApplyThresholdChanging(value);
                this._ApplyThreshold = value;
                this.OnApplyThresholdChanged();
                this.OnPropertyChanged("ApplyThreshold");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ApplyThreshold;
        partial void OnApplyThresholdChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnApplyThresholdChanged();
        /// <summary>
        /// There are no comments for Property CurrencyCodeID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CurrencyCodeID
        {
            get
            {
                return this._CurrencyCodeID;
            }
            set
            {
                this.OnCurrencyCodeIDChanging(value);
                this._CurrencyCodeID = value;
                this.OnCurrencyCodeIDChanged();
                this.OnPropertyChanged("CurrencyCodeID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCodeID;
        partial void OnCurrencyCodeIDChanging(string value);
        partial void OnCurrencyCodeIDChanged();
        /// <summary>
        /// There are no comments for Property SettlementAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SettlementAccountDisplayValue
        {
            get
            {
                return this._SettlementAccountDisplayValue;
            }
            set
            {
                this.OnSettlementAccountDisplayValueChanging(value);
                this._SettlementAccountDisplayValue = value;
                this.OnSettlementAccountDisplayValueChanged();
                this.OnPropertyChanged("SettlementAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SettlementAccountDisplayValue;
        partial void OnSettlementAccountDisplayValueChanging(string value);
        partial void OnSettlementAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property ReceivableAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReceivableAccountDisplayValue
        {
            get
            {
                return this._ReceivableAccountDisplayValue;
            }
            set
            {
                this.OnReceivableAccountDisplayValueChanging(value);
                this._ReceivableAccountDisplayValue = value;
                this.OnReceivableAccountDisplayValueChanged();
                this.OnPropertyChanged("ReceivableAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReceivableAccountDisplayValue;
        partial void OnReceivableAccountDisplayValueChanging(string value);
        partial void OnReceivableAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property WithholdingTaxRoundOff in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal WithholdingTaxRoundOff
        {
            get
            {
                return this._WithholdingTaxRoundOff;
            }
            set
            {
                this.OnWithholdingTaxRoundOffChanging(value);
                this._WithholdingTaxRoundOff = value;
                this.OnWithholdingTaxRoundOffChanged();
                this.OnPropertyChanged("WithholdingTaxRoundOff");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _WithholdingTaxRoundOff;
        partial void OnWithholdingTaxRoundOffChanging(decimal value);
        partial void OnWithholdingTaxRoundOffChanged();
        /// <summary>
        /// There are no comments for Property WithholdingGroupData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingGroupData> WithholdingGroupData
        {
            get
            {
                return this._WithholdingGroupData;
            }
            set
            {
                this.OnWithholdingGroupDataChanging(value);
                this._WithholdingGroupData = value;
                this.OnWithholdingGroupDataChanged();
                this.OnPropertyChanged("WithholdingGroupData");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingGroupData> _WithholdingGroupData = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingGroupData>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWithholdingGroupDataChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingGroupData> value);
        partial void OnWithholdingGroupDataChanged();
        /// <summary>
        /// There are no comments for Property WithholdingTaxCodeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeValue> WithholdingTaxCodeValue
        {
            get
            {
                return this._WithholdingTaxCodeValue;
            }
            set
            {
                this.OnWithholdingTaxCodeValueChanging(value);
                this._WithholdingTaxCodeValue = value;
                this.OnWithholdingTaxCodeValueChanged();
                this.OnPropertyChanged("WithholdingTaxCodeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeValue> _WithholdingTaxCodeValue = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeValue>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWithholdingTaxCodeValueChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeValue> value);
        partial void OnWithholdingTaxCodeValueChanged();
        /// <summary>
        /// There are no comments for Property WithholdLedgerAccountGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WithholdLedgerAccountGroup WithholdLedgerAccountGroup
        {
            get
            {
                return this._WithholdLedgerAccountGroup;
            }
            set
            {
                this.OnWithholdLedgerAccountGroupChanging(value);
                this._WithholdLedgerAccountGroup = value;
                this.OnWithholdLedgerAccountGroupChanged();
                this.OnPropertyChanged("WithholdLedgerAccountGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WithholdLedgerAccountGroup _WithholdLedgerAccountGroup;
        partial void OnWithholdLedgerAccountGroupChanging(global::Microsoft.Dynamics.DataEntities.WithholdLedgerAccountGroup value);
        partial void OnWithholdLedgerAccountGroupChanged();
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
        /// There are no comments for Property WithholdingPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WithholdingPeriod WithholdingPeriod
        {
            get
            {
                return this._WithholdingPeriod;
            }
            set
            {
                this.OnWithholdingPeriodChanging(value);
                this._WithholdingPeriod = value;
                this.OnWithholdingPeriodChanged();
                this.OnPropertyChanged("WithholdingPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WithholdingPeriod _WithholdingPeriod;
        partial void OnWithholdingPeriodChanging(global::Microsoft.Dynamics.DataEntities.WithholdingPeriod value);
        partial void OnWithholdingPeriodChanged();
        /// <summary>
        /// There are no comments for Property WithholdingTaxCodeLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeLimit> WithholdingTaxCodeLimit
        {
            get
            {
                return this._WithholdingTaxCodeLimit;
            }
            set
            {
                this.OnWithholdingTaxCodeLimitChanging(value);
                this._WithholdingTaxCodeLimit = value;
                this.OnWithholdingTaxCodeLimitChanged();
                this.OnPropertyChanged("WithholdingTaxCodeLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeLimit> _WithholdingTaxCodeLimit = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeLimit>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWithholdingTaxCodeLimitChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeLimit> value);
        partial void OnWithholdingTaxCodeLimitChanged();
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
