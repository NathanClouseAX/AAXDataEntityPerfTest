﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/28/2021 8:55:09 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for TaxPostingGroupSingle in the schema.
    /// </summary>
    public partial class TaxPostingGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TaxPostingGroup>
    {
        /// <summary>
        /// Initialize a new TaxPostingGroupSingle object.
        /// </summary>
        public TaxPostingGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TaxPostingGroupSingle object.
        /// </summary>
        public TaxPostingGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TaxPostingGroupSingle object.
        /// </summary>
        public TaxPostingGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TaxPostingGroup> query)
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
        /// There are no comments for TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TaxCode> TaxCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TaxCode == null))
                {
                    this._TaxCode = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TaxCode>(GetPath("TaxCode"));
                }
                return this._TaxCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TaxCode> _TaxCode;
    }
    /// <summary>
    /// There are no comments for TaxPostingGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TaxPostingGroupCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TaxPostingGroupCode")]
    [global::Microsoft.OData.Client.EntitySet("TaxPostingGroups")]
    public partial class TaxPostingGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxPostingGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="taxPostingGroupCode">Initial value of TaxPostingGroupCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TaxPostingGroup CreateTaxPostingGroup(string dataAreaId, string taxPostingGroupCode)
        {
            TaxPostingGroup taxPostingGroup = new TaxPostingGroup();
            taxPostingGroup.dataAreaId = dataAreaId;
            taxPostingGroup.TaxPostingGroupCode = taxPostingGroupCode;
            return taxPostingGroup;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "dataAreaId is required.")]
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
        /// There are no comments for Property TaxPostingGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxPostingGroupCode is required.")]
        public virtual string TaxPostingGroupCode
        {
            get
            {
                return this._TaxPostingGroupCode;
            }
            set
            {
                this.OnTaxPostingGroupCodeChanging(value);
                this._TaxPostingGroupCode = value;
                this.OnTaxPostingGroupCodeChanged();
                this.OnPropertyChanged("TaxPostingGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxPostingGroupCode;
        partial void OnTaxPostingGroupCodeChanging(string value);
        partial void OnTaxPostingGroupCodeChanged();
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
        /// There are no comments for Property TaxSettlementMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TaxSettlementMainAccountIdDisplayValue
        {
            get
            {
                return this._TaxSettlementMainAccountIdDisplayValue;
            }
            set
            {
                this.OnTaxSettlementMainAccountIdDisplayValueChanging(value);
                this._TaxSettlementMainAccountIdDisplayValue = value;
                this.OnTaxSettlementMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("TaxSettlementMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxSettlementMainAccountIdDisplayValue;
        partial void OnTaxSettlementMainAccountIdDisplayValueChanging(string value);
        partial void OnTaxSettlementMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxUnrealizedPayablesMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TaxUnrealizedPayablesMainAccountIdDisplayValue
        {
            get
            {
                return this._TaxUnrealizedPayablesMainAccountIdDisplayValue;
            }
            set
            {
                this.OnTaxUnrealizedPayablesMainAccountIdDisplayValueChanging(value);
                this._TaxUnrealizedPayablesMainAccountIdDisplayValue = value;
                this.OnTaxUnrealizedPayablesMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("TaxUnrealizedPayablesMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxUnrealizedPayablesMainAccountIdDisplayValue;
        partial void OnTaxUnrealizedPayablesMainAccountIdDisplayValueChanging(string value);
        partial void OnTaxUnrealizedPayablesMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxReceivableShortTermMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TaxReceivableShortTermMainAccountIdDisplayValue
        {
            get
            {
                return this._TaxReceivableShortTermMainAccountIdDisplayValue;
            }
            set
            {
                this.OnTaxReceivableShortTermMainAccountIdDisplayValueChanging(value);
                this._TaxReceivableShortTermMainAccountIdDisplayValue = value;
                this.OnTaxReceivableShortTermMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("TaxReceivableShortTermMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxReceivableShortTermMainAccountIdDisplayValue;
        partial void OnTaxReceivableShortTermMainAccountIdDisplayValueChanging(string value);
        partial void OnTaxReceivableShortTermMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxReceivableMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TaxReceivableMainAccountIdDisplayValue
        {
            get
            {
                return this._TaxReceivableMainAccountIdDisplayValue;
            }
            set
            {
                this.OnTaxReceivableMainAccountIdDisplayValueChanging(value);
                this._TaxReceivableMainAccountIdDisplayValue = value;
                this.OnTaxReceivableMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("TaxReceivableMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxReceivableMainAccountIdDisplayValue;
        partial void OnTaxReceivableMainAccountIdDisplayValueChanging(string value);
        partial void OnTaxReceivableMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxFromCustomerCashDiscountMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TaxFromCustomerCashDiscountMainAccountIdDisplayValue
        {
            get
            {
                return this._TaxFromCustomerCashDiscountMainAccountIdDisplayValue;
            }
            set
            {
                this.OnTaxFromCustomerCashDiscountMainAccountIdDisplayValueChanging(value);
                this._TaxFromCustomerCashDiscountMainAccountIdDisplayValue = value;
                this.OnTaxFromCustomerCashDiscountMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("TaxFromCustomerCashDiscountMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxFromCustomerCashDiscountMainAccountIdDisplayValue;
        partial void OnTaxFromCustomerCashDiscountMainAccountIdDisplayValueChanging(string value);
        partial void OnTaxFromCustomerCashDiscountMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxSalesExpenseMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TaxSalesExpenseMainAccountIdDisplayValue
        {
            get
            {
                return this._TaxSalesExpenseMainAccountIdDisplayValue;
            }
            set
            {
                this.OnTaxSalesExpenseMainAccountIdDisplayValueChanging(value);
                this._TaxSalesExpenseMainAccountIdDisplayValue = value;
                this.OnTaxSalesExpenseMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("TaxSalesExpenseMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxSalesExpenseMainAccountIdDisplayValue;
        partial void OnTaxSalesExpenseMainAccountIdDisplayValueChanging(string value);
        partial void OnTaxSalesExpenseMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property UseTaxMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string UseTaxMainAccountIdDisplayValue
        {
            get
            {
                return this._UseTaxMainAccountIdDisplayValue;
            }
            set
            {
                this.OnUseTaxMainAccountIdDisplayValueChanging(value);
                this._UseTaxMainAccountIdDisplayValue = value;
                this.OnUseTaxMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("UseTaxMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UseTaxMainAccountIdDisplayValue;
        partial void OnUseTaxMainAccountIdDisplayValueChanging(string value);
        partial void OnUseTaxMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property UseTaxPayableMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string UseTaxPayableMainAccountIdDisplayValue
        {
            get
            {
                return this._UseTaxPayableMainAccountIdDisplayValue;
            }
            set
            {
                this.OnUseTaxPayableMainAccountIdDisplayValueChanging(value);
                this._UseTaxPayableMainAccountIdDisplayValue = value;
                this.OnUseTaxPayableMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("UseTaxPayableMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UseTaxPayableMainAccountIdDisplayValue;
        partial void OnUseTaxPayableMainAccountIdDisplayValueChanging(string value);
        partial void OnUseTaxPayableMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxReceivableLongTermMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TaxReceivableLongTermMainAccountIdDisplayValue
        {
            get
            {
                return this._TaxReceivableLongTermMainAccountIdDisplayValue;
            }
            set
            {
                this.OnTaxReceivableLongTermMainAccountIdDisplayValueChanging(value);
                this._TaxReceivableLongTermMainAccountIdDisplayValue = value;
                this.OnTaxReceivableLongTermMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("TaxReceivableLongTermMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxReceivableLongTermMainAccountIdDisplayValue;
        partial void OnTaxReceivableLongTermMainAccountIdDisplayValueChanging(string value);
        partial void OnTaxReceivableLongTermMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxPayableMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TaxPayableMainAccountIdDisplayValue
        {
            get
            {
                return this._TaxPayableMainAccountIdDisplayValue;
            }
            set
            {
                this.OnTaxPayableMainAccountIdDisplayValueChanging(value);
                this._TaxPayableMainAccountIdDisplayValue = value;
                this.OnTaxPayableMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("TaxPayableMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxPayableMainAccountIdDisplayValue;
        partial void OnTaxPayableMainAccountIdDisplayValueChanging(string value);
        partial void OnTaxPayableMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxUnrealizedReceivablesMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TaxUnrealizedReceivablesMainAccountIdDisplayValue
        {
            get
            {
                return this._TaxUnrealizedReceivablesMainAccountIdDisplayValue;
            }
            set
            {
                this.OnTaxUnrealizedReceivablesMainAccountIdDisplayValueChanging(value);
                this._TaxUnrealizedReceivablesMainAccountIdDisplayValue = value;
                this.OnTaxUnrealizedReceivablesMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("TaxUnrealizedReceivablesMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxUnrealizedReceivablesMainAccountIdDisplayValue;
        partial void OnTaxUnrealizedReceivablesMainAccountIdDisplayValueChanging(string value);
        partial void OnTaxUnrealizedReceivablesMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxFromVendorCashDiscountMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TaxFromVendorCashDiscountMainAccountIdDisplayValue
        {
            get
            {
                return this._TaxFromVendorCashDiscountMainAccountIdDisplayValue;
            }
            set
            {
                this.OnTaxFromVendorCashDiscountMainAccountIdDisplayValueChanging(value);
                this._TaxFromVendorCashDiscountMainAccountIdDisplayValue = value;
                this.OnTaxFromVendorCashDiscountMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("TaxFromVendorCashDiscountMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxFromVendorCashDiscountMainAccountIdDisplayValue;
        partial void OnTaxFromVendorCashDiscountMainAccountIdDisplayValueChanging(string value);
        partial void OnTaxFromVendorCashDiscountMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxIncomingDifferenceMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TaxIncomingDifferenceMainAccountIdDisplayValue
        {
            get
            {
                return this._TaxIncomingDifferenceMainAccountIdDisplayValue;
            }
            set
            {
                this.OnTaxIncomingDifferenceMainAccountIdDisplayValueChanging(value);
                this._TaxIncomingDifferenceMainAccountIdDisplayValue = value;
                this.OnTaxIncomingDifferenceMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("TaxIncomingDifferenceMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxIncomingDifferenceMainAccountIdDisplayValue;
        partial void OnTaxIncomingDifferenceMainAccountIdDisplayValueChanging(string value);
        partial void OnTaxIncomingDifferenceMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxOutgoingDifferenceMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TaxOutgoingDifferenceMainAccountIdDisplayValue
        {
            get
            {
                return this._TaxOutgoingDifferenceMainAccountIdDisplayValue;
            }
            set
            {
                this.OnTaxOutgoingDifferenceMainAccountIdDisplayValueChanging(value);
                this._TaxOutgoingDifferenceMainAccountIdDisplayValue = value;
                this.OnTaxOutgoingDifferenceMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("TaxOutgoingDifferenceMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxOutgoingDifferenceMainAccountIdDisplayValue;
        partial void OnTaxOutgoingDifferenceMainAccountIdDisplayValueChanging(string value);
        partial void OnTaxOutgoingDifferenceMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxOutgoingDiffOffsetMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TaxOutgoingDiffOffsetMainAccountIdDisplayValue
        {
            get
            {
                return this._TaxOutgoingDiffOffsetMainAccountIdDisplayValue;
            }
            set
            {
                this.OnTaxOutgoingDiffOffsetMainAccountIdDisplayValueChanging(value);
                this._TaxOutgoingDiffOffsetMainAccountIdDisplayValue = value;
                this.OnTaxOutgoingDiffOffsetMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("TaxOutgoingDiffOffsetMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxOutgoingDiffOffsetMainAccountIdDisplayValue;
        partial void OnTaxOutgoingDiffOffsetMainAccountIdDisplayValueChanging(string value);
        partial void OnTaxOutgoingDiffOffsetMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxIncomingDiffOffsetMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TaxIncomingDiffOffsetMainAccountIdDisplayValue
        {
            get
            {
                return this._TaxIncomingDiffOffsetMainAccountIdDisplayValue;
            }
            set
            {
                this.OnTaxIncomingDiffOffsetMainAccountIdDisplayValueChanging(value);
                this._TaxIncomingDiffOffsetMainAccountIdDisplayValue = value;
                this.OnTaxIncomingDiffOffsetMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("TaxIncomingDiffOffsetMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxIncomingDiffOffsetMainAccountIdDisplayValue;
        partial void OnTaxIncomingDiffOffsetMainAccountIdDisplayValueChanging(string value);
        partial void OnTaxIncomingDiffOffsetMainAccountIdDisplayValueChanged();
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
        /// There are no comments for Property TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TaxCode> TaxCode
        {
            get
            {
                return this._TaxCode;
            }
            set
            {
                this.OnTaxCodeChanging(value);
                this._TaxCode = value;
                this.OnTaxCodeChanged();
                this.OnPropertyChanged("TaxCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TaxCode> _TaxCode = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TaxCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTaxCodeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TaxCode> value);
        partial void OnTaxCodeChanged();
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
