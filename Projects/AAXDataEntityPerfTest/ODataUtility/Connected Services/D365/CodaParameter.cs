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
        /// There are no comments for CodaParameterSingle in the schema.
        /// </summary>
    public partial class CodaParameterSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CodaParameter>
    {
        /// <summary>
        /// Initialize a new CodaParameterSingle object.
        /// </summary>
        public CodaParameterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CodaParameterSingle object.
        /// </summary>
        public CodaParameterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CodaParameterSingle object.
        /// </summary>
        public CodaParameterSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CodaParameter> query)
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
    }
        /// <summary>
        /// There are no comments for CodaParameter in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId")]
    [global::Microsoft.OData.Client.EntitySet("CodaParameters")]
    public partial class CodaParameter : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CodaParameter object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="codaDeviation">Initial value of CodaDeviation.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CodaParameter CreateCodaParameter(string dataAreaId, decimal codaDeviation)
        {
            CodaParameter codaParameter = new CodaParameter();
            codaParameter.dataAreaId = dataAreaId;
            codaParameter.CodaDeviation = codaDeviation;
            return codaParameter;
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
        /// There are no comments for Property AccountNumberDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountNumberDisplayValue
        {
            get
            {
                return this._AccountNumberDisplayValue;
            }
            set
            {
                this.OnAccountNumberDisplayValueChanging(value);
                this._AccountNumberDisplayValue = value;
                this.OnAccountNumberDisplayValueChanged();
                this.OnPropertyChanged("AccountNumberDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountNumberDisplayValue;
        partial void OnAccountNumberDisplayValueChanging(string value);
        partial void OnAccountNumberDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property CodaDeviation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CodaDeviation
        {
            get
            {
                return this._CodaDeviation;
            }
            set
            {
                this.OnCodaDeviationChanging(value);
                this._CodaDeviation = value;
                this.OnCodaDeviationChanged();
                this.OnPropertyChanged("CodaDeviation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CodaDeviation;
        partial void OnCodaDeviationChanging(decimal value);
        partial void OnCodaDeviationChanged();
        /// <summary>
        /// There are no comments for Property ItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemSalesTaxGroup
        {
            get
            {
                return this._ItemSalesTaxGroup;
            }
            set
            {
                this.OnItemSalesTaxGroupChanging(value);
                this._ItemSalesTaxGroup = value;
                this.OnItemSalesTaxGroupChanged();
                this.OnPropertyChanged("ItemSalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemSalesTaxGroup;
        partial void OnItemSalesTaxGroupChanging(string value);
        partial void OnItemSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property IsOverrideStatementInCaseOfNoMatching in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsOverrideStatementInCaseOfNoMatching
        {
            get
            {
                return this._IsOverrideStatementInCaseOfNoMatching;
            }
            set
            {
                this.OnIsOverrideStatementInCaseOfNoMatchingChanging(value);
                this._IsOverrideStatementInCaseOfNoMatching = value;
                this.OnIsOverrideStatementInCaseOfNoMatchingChanged();
                this.OnPropertyChanged("IsOverrideStatementInCaseOfNoMatching");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsOverrideStatementInCaseOfNoMatching;
        partial void OnIsOverrideStatementInCaseOfNoMatchingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsOverrideStatementInCaseOfNoMatchingChanged();
        /// <summary>
        /// There are no comments for Property IsAutoCreateNewBankAccounts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAutoCreateNewBankAccounts
        {
            get
            {
                return this._IsAutoCreateNewBankAccounts;
            }
            set
            {
                this.OnIsAutoCreateNewBankAccountsChanging(value);
                this._IsAutoCreateNewBankAccounts = value;
                this.OnIsAutoCreateNewBankAccountsChanged();
                this.OnPropertyChanged("IsAutoCreateNewBankAccounts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAutoCreateNewBankAccounts;
        partial void OnIsAutoCreateNewBankAccountsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAutoCreateNewBankAccountsChanged();
        /// <summary>
        /// There are no comments for Property PrefixNewBankAccounts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PrefixNewBankAccounts
        {
            get
            {
                return this._PrefixNewBankAccounts;
            }
            set
            {
                this.OnPrefixNewBankAccountsChanging(value);
                this._PrefixNewBankAccounts = value;
                this.OnPrefixNewBankAccountsChanged();
                this.OnPropertyChanged("PrefixNewBankAccounts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PrefixNewBankAccounts;
        partial void OnPrefixNewBankAccountsChanging(string value);
        partial void OnPrefixNewBankAccountsChanged();
        /// <summary>
        /// There are no comments for Property CostAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CostAccountDisplayValue
        {
            get
            {
                return this._CostAccountDisplayValue;
            }
            set
            {
                this.OnCostAccountDisplayValueChanging(value);
                this._CostAccountDisplayValue = value;
                this.OnCostAccountDisplayValueChanged();
                this.OnPropertyChanged("CostAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CostAccountDisplayValue;
        partial void OnCostAccountDisplayValueChanging(string value);
        partial void OnCostAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property RevenueAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RevenueAccountDisplayValue
        {
            get
            {
                return this._RevenueAccountDisplayValue;
            }
            set
            {
                this.OnRevenueAccountDisplayValueChanging(value);
                this._RevenueAccountDisplayValue = value;
                this.OnRevenueAccountDisplayValueChanged();
                this.OnPropertyChanged("RevenueAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RevenueAccountDisplayValue;
        partial void OnRevenueAccountDisplayValueChanging(string value);
        partial void OnRevenueAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesTaxGroup
        {
            get
            {
                return this._SalesTaxGroup;
            }
            set
            {
                this.OnSalesTaxGroupChanging(value);
                this._SalesTaxGroup = value;
                this.OnSalesTaxGroupChanged();
                this.OnPropertyChanged("SalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxGroup;
        partial void OnSalesTaxGroupChanging(string value);
        partial void OnSalesTaxGroupChanged();
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
