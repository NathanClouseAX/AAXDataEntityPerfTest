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
        /// There are no comments for ConsolidateAccountSingle in the schema.
        /// </summary>
    public partial class ConsolidateAccountSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ConsolidateAccount>
    {
        /// <summary>
        /// Initialize a new ConsolidateAccountSingle object.
        /// </summary>
        public ConsolidateAccountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ConsolidateAccountSingle object.
        /// </summary>
        public ConsolidateAccountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ConsolidateAccountSingle object.
        /// </summary>
        public ConsolidateAccountSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ConsolidateAccount> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for ConsolidateAccount in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ConsolidationAccountGroup
    /// ChartOfAccounts
    /// MainAccount
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ConsolidationAccountGroup", "ChartOfAccounts", "MainAccount")]
    [global::Microsoft.OData.Client.EntitySet("ConsolidateAccounts")]
    public partial class ConsolidateAccount : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ConsolidateAccount object.
        /// </summary>
        /// <param name="consolidationAccountGroup">Initial value of ConsolidationAccountGroup.</param>
        /// <param name="chartOfAccounts">Initial value of ChartOfAccounts.</param>
        /// <param name="mainAccount">Initial value of MainAccount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ConsolidateAccount CreateConsolidateAccount(string consolidationAccountGroup, string chartOfAccounts, string mainAccount)
        {
            ConsolidateAccount consolidateAccount = new ConsolidateAccount();
            consolidateAccount.ConsolidationAccountGroup = consolidationAccountGroup;
            consolidateAccount.ChartOfAccounts = chartOfAccounts;
            consolidateAccount.MainAccount = mainAccount;
            return consolidateAccount;
        }
        /// <summary>
        /// There are no comments for Property ConsolidationAccountGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ConsolidationAccountGroup
        {
            get
            {
                return this._ConsolidationAccountGroup;
            }
            set
            {
                this.OnConsolidationAccountGroupChanging(value);
                this._ConsolidationAccountGroup = value;
                this.OnConsolidationAccountGroupChanged();
                this.OnPropertyChanged("ConsolidationAccountGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConsolidationAccountGroup;
        partial void OnConsolidationAccountGroupChanging(string value);
        partial void OnConsolidationAccountGroupChanged();
        /// <summary>
        /// There are no comments for Property ChartOfAccounts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ChartOfAccounts
        {
            get
            {
                return this._ChartOfAccounts;
            }
            set
            {
                this.OnChartOfAccountsChanging(value);
                this._ChartOfAccounts = value;
                this.OnChartOfAccountsChanged();
                this.OnPropertyChanged("ChartOfAccounts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChartOfAccounts;
        partial void OnChartOfAccountsChanging(string value);
        partial void OnChartOfAccountsChanged();
        /// <summary>
        /// There are no comments for Property MainAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccount
        {
            get
            {
                return this._MainAccount;
            }
            set
            {
                this.OnMainAccountChanging(value);
                this._MainAccount = value;
                this.OnMainAccountChanged();
                this.OnPropertyChanged("MainAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccount;
        partial void OnMainAccountChanging(string value);
        partial void OnMainAccountChanged();
        /// <summary>
        /// There are no comments for Property MainAccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimensionLedgerAccountType> MainAccountType
        {
            get
            {
                return this._MainAccountType;
            }
            set
            {
                this.OnMainAccountTypeChanging(value);
                this._MainAccountType = value;
                this.OnMainAccountTypeChanged();
                this.OnPropertyChanged("MainAccountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimensionLedgerAccountType> _MainAccountType;
        partial void OnMainAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimensionLedgerAccountType> value);
        partial void OnMainAccountTypeChanged();
        /// <summary>
        /// There are no comments for Property CostCenterName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CostCenterName
        {
            get
            {
                return this._CostCenterName;
            }
            set
            {
                this.OnCostCenterNameChanging(value);
                this._CostCenterName = value;
                this.OnCostCenterNameChanged();
                this.OnPropertyChanged("CostCenterName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CostCenterName;
        partial void OnCostCenterNameChanging(string value);
        partial void OnCostCenterNameChanged();
        /// <summary>
        /// There are no comments for Property MainAccountCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccountCategory
        {
            get
            {
                return this._MainAccountCategory;
            }
            set
            {
                this.OnMainAccountCategoryChanging(value);
                this._MainAccountCategory = value;
                this.OnMainAccountCategoryChanged();
                this.OnPropertyChanged("MainAccountCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountCategory;
        partial void OnMainAccountCategoryChanging(string value);
        partial void OnMainAccountCategoryChanged();
        /// <summary>
        /// There are no comments for Property MainAccountName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccountName
        {
            get
            {
                return this._MainAccountName;
            }
            set
            {
                this.OnMainAccountNameChanging(value);
                this._MainAccountName = value;
                this.OnMainAccountNameChanged();
                this.OnPropertyChanged("MainAccountName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountName;
        partial void OnMainAccountNameChanging(string value);
        partial void OnMainAccountNameChanged();
        /// <summary>
        /// There are no comments for Property ConsolidationAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ConsolidationAccount
        {
            get
            {
                return this._ConsolidationAccount;
            }
            set
            {
                this.OnConsolidationAccountChanging(value);
                this._ConsolidationAccount = value;
                this.OnConsolidationAccountChanged();
                this.OnPropertyChanged("ConsolidationAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConsolidationAccount;
        partial void OnConsolidationAccountChanging(string value);
        partial void OnConsolidationAccountChanged();
        /// <summary>
        /// There are no comments for Property ConsolidationAccountGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ConsolidationAccountGroupName
        {
            get
            {
                return this._ConsolidationAccountGroupName;
            }
            set
            {
                this.OnConsolidationAccountGroupNameChanging(value);
                this._ConsolidationAccountGroupName = value;
                this.OnConsolidationAccountGroupNameChanged();
                this.OnPropertyChanged("ConsolidationAccountGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConsolidationAccountGroupName;
        partial void OnConsolidationAccountGroupNameChanging(string value);
        partial void OnConsolidationAccountGroupNameChanged();
        /// <summary>
        /// There are no comments for Property ConsolidationAccountName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ConsolidationAccountName
        {
            get
            {
                return this._ConsolidationAccountName;
            }
            set
            {
                this.OnConsolidationAccountNameChanging(value);
                this._ConsolidationAccountName = value;
                this.OnConsolidationAccountNameChanged();
                this.OnPropertyChanged("ConsolidationAccountName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConsolidationAccountName;
        partial void OnConsolidationAccountNameChanging(string value);
        partial void OnConsolidationAccountNameChanged();
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
