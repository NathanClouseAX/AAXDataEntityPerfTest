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
        /// There are no comments for BalanceControlSingle in the schema.
        /// </summary>
    public partial class BalanceControlSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BalanceControl>
    {
        /// <summary>
        /// Initialize a new BalanceControlSingle object.
        /// </summary>
        public BalanceControlSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BalanceControlSingle object.
        /// </summary>
        public BalanceControlSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BalanceControlSingle object.
        /// </summary>
        public BalanceControlSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BalanceControl> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LedgerBalanceControlMainAccountRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.MainAccountSingle LedgerBalanceControlMainAccountRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerBalanceControlMainAccountRole == null))
                {
                    this._LedgerBalanceControlMainAccountRole = new global::Microsoft.Dynamics.DataEntities.MainAccountSingle(this.Context, GetPath("LedgerBalanceControlMainAccountRole"));
                }
                return this._LedgerBalanceControlMainAccountRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.MainAccountSingle _LedgerBalanceControlMainAccountRole;
    }
        /// <summary>
        /// There are no comments for BalanceControl in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MainAccountId
    /// ChartOfAccounts
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MainAccountId", "ChartOfAccounts")]
    [global::Microsoft.OData.Client.EntitySet("BalanceControls")]
    public partial class BalanceControl : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BalanceControl object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="mainAccountId">Initial value of MainAccountId.</param>
        /// <param name="chartOfAccounts">Initial value of ChartOfAccounts.</param>
        /// <param name="ledgerBalanceControlMainAccountRole">Initial value of LedgerBalanceControlMainAccountRole.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BalanceControl CreateBalanceControl(string dataAreaId, string mainAccountId, string chartOfAccounts, global::Microsoft.Dynamics.DataEntities.MainAccount ledgerBalanceControlMainAccountRole)
        {
            BalanceControl balanceControl = new BalanceControl();
            balanceControl.dataAreaId = dataAreaId;
            balanceControl.MainAccountId = mainAccountId;
            balanceControl.ChartOfAccounts = chartOfAccounts;
            if ((ledgerBalanceControlMainAccountRole == null))
            {
                throw new global::System.ArgumentNullException("ledgerBalanceControlMainAccountRole");
            }
            balanceControl.LedgerBalanceControlMainAccountRole = ledgerBalanceControlMainAccountRole;
            return balanceControl;
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
        /// There are no comments for Property MainAccountId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccountId
        {
            get
            {
                return this._MainAccountId;
            }
            set
            {
                this.OnMainAccountIdChanging(value);
                this._MainAccountId = value;
                this.OnMainAccountIdChanged();
                this.OnPropertyChanged("MainAccountId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountId;
        partial void OnMainAccountIdChanging(string value);
        partial void OnMainAccountIdChanged();
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
        /// There are no comments for Property LedgerBalanceControlMainAccountRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.MainAccount LedgerBalanceControlMainAccountRole
        {
            get
            {
                return this._LedgerBalanceControlMainAccountRole;
            }
            set
            {
                this.OnLedgerBalanceControlMainAccountRoleChanging(value);
                this._LedgerBalanceControlMainAccountRole = value;
                this.OnLedgerBalanceControlMainAccountRoleChanged();
                this.OnPropertyChanged("LedgerBalanceControlMainAccountRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.MainAccount _LedgerBalanceControlMainAccountRole;
        partial void OnLedgerBalanceControlMainAccountRoleChanging(global::Microsoft.Dynamics.DataEntities.MainAccount value);
        partial void OnLedgerBalanceControlMainAccountRoleChanged();
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
