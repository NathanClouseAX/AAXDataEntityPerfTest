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
        /// There are no comments for WithholdLedgerAccountGroupSingle in the schema.
        /// </summary>
    public partial class WithholdLedgerAccountGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdLedgerAccountGroup>
    {
        /// <summary>
        /// Initialize a new WithholdLedgerAccountGroupSingle object.
        /// </summary>
        public WithholdLedgerAccountGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WithholdLedgerAccountGroupSingle object.
        /// </summary>
        public WithholdLedgerAccountGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WithholdLedgerAccountGroupSingle object.
        /// </summary>
        public WithholdLedgerAccountGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdLedgerAccountGroup> query)
            : base(query) {}

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
        /// There are no comments for WithholdingTaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode> WithholdingTaxCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WithholdingTaxCode == null))
                {
                    this._WithholdingTaxCode = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode>(GetPath("WithholdingTaxCode"));
                }
                return this._WithholdingTaxCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode> _WithholdingTaxCode;
    }
        /// <summary>
        /// There are no comments for WithholdLedgerAccountGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TaxWithholdAccountGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TaxWithholdAccountGroup")]
    [global::Microsoft.OData.Client.EntitySet("WithholdLedgerAccountGroups")]
    public partial class WithholdLedgerAccountGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WithholdLedgerAccountGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="taxWithholdAccountGroup">Initial value of TaxWithholdAccountGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WithholdLedgerAccountGroup CreateWithholdLedgerAccountGroup(string dataAreaId, string taxWithholdAccountGroup)
        {
            WithholdLedgerAccountGroup withholdLedgerAccountGroup = new WithholdLedgerAccountGroup();
            withholdLedgerAccountGroup.dataAreaId = dataAreaId;
            withholdLedgerAccountGroup.TaxWithholdAccountGroup = taxWithholdAccountGroup;
            return withholdLedgerAccountGroup;
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
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property ExpenseLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ExpenseLedgerDimensionDisplayValue
        {
            get
            {
                return this._ExpenseLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnExpenseLedgerDimensionDisplayValueChanging(value);
                this._ExpenseLedgerDimensionDisplayValue = value;
                this.OnExpenseLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("ExpenseLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExpenseLedgerDimensionDisplayValue;
        partial void OnExpenseLedgerDimensionDisplayValueChanging(string value);
        partial void OnExpenseLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxWithholdLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxWithholdLedgerDimensionDisplayValue
        {
            get
            {
                return this._TaxWithholdLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnTaxWithholdLedgerDimensionDisplayValueChanging(value);
                this._TaxWithholdLedgerDimensionDisplayValue = value;
                this.OnTaxWithholdLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("TaxWithholdLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxWithholdLedgerDimensionDisplayValue;
        partial void OnTaxWithholdLedgerDimensionDisplayValueChanging(string value);
        partial void OnTaxWithholdLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxWithhodlSettlementLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxWithhodlSettlementLedgerDimensionDisplayValue
        {
            get
            {
                return this._TaxWithhodlSettlementLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnTaxWithhodlSettlementLedgerDimensionDisplayValueChanging(value);
                this._TaxWithhodlSettlementLedgerDimensionDisplayValue = value;
                this.OnTaxWithhodlSettlementLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("TaxWithhodlSettlementLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxWithhodlSettlementLedgerDimensionDisplayValue;
        partial void OnTaxWithhodlSettlementLedgerDimensionDisplayValueChanging(string value);
        partial void OnTaxWithhodlSettlementLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxWithholdOffsetLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxWithholdOffsetLedgerDimensionDisplayValue
        {
            get
            {
                return this._TaxWithholdOffsetLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnTaxWithholdOffsetLedgerDimensionDisplayValueChanging(value);
                this._TaxWithholdOffsetLedgerDimensionDisplayValue = value;
                this.OnTaxWithholdOffsetLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("TaxWithholdOffsetLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxWithholdOffsetLedgerDimensionDisplayValue;
        partial void OnTaxWithholdOffsetLedgerDimensionDisplayValueChanging(string value);
        partial void OnTaxWithholdOffsetLedgerDimensionDisplayValueChanged();
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
        /// There are no comments for Property WithholdingTaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode> WithholdingTaxCode
        {
            get
            {
                return this._WithholdingTaxCode;
            }
            set
            {
                this.OnWithholdingTaxCodeChanging(value);
                this._WithholdingTaxCode = value;
                this.OnWithholdingTaxCodeChanged();
                this.OnPropertyChanged("WithholdingTaxCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode> _WithholdingTaxCode = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWithholdingTaxCodeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode> value);
        partial void OnWithholdingTaxCodeChanged();
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
