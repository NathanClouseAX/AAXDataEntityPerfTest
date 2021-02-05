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
        /// There are no comments for MainAccountTotalAccountIntervalSingle in the schema.
        /// </summary>
    public partial class MainAccountTotalAccountIntervalSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<MainAccountTotalAccountInterval>
    {
        /// <summary>
        /// Initialize a new MainAccountTotalAccountIntervalSingle object.
        /// </summary>
        public MainAccountTotalAccountIntervalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MainAccountTotalAccountIntervalSingle object.
        /// </summary>
        public MainAccountTotalAccountIntervalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MainAccountTotalAccountIntervalSingle object.
        /// </summary>
        public MainAccountTotalAccountIntervalSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<MainAccountTotalAccountInterval> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TotalAccountLedgerChartOfAccountsEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ChartOfAccountsSingle TotalAccountLedgerChartOfAccountsEntityRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TotalAccountLedgerChartOfAccountsEntityRole == null))
                {
                    this._TotalAccountLedgerChartOfAccountsEntityRole = new global::Microsoft.Dynamics.DataEntities.ChartOfAccountsSingle(this.Context, GetPath("TotalAccountLedgerChartOfAccountsEntityRole"));
                }
                return this._TotalAccountLedgerChartOfAccountsEntityRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ChartOfAccountsSingle _TotalAccountLedgerChartOfAccountsEntityRole;
        /// <summary>
        /// There are no comments for TotalAccountMainAccountEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.MainAccountSingle TotalAccountMainAccountEntityRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TotalAccountMainAccountEntityRole == null))
                {
                    this._TotalAccountMainAccountEntityRole = new global::Microsoft.Dynamics.DataEntities.MainAccountSingle(this.Context, GetPath("TotalAccountMainAccountEntityRole"));
                }
                return this._TotalAccountMainAccountEntityRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.MainAccountSingle _TotalAccountMainAccountEntityRole;
    }
        /// <summary>
        /// There are no comments for MainAccountTotalAccountInterval in the schema.
        /// </summary>
    /// <KeyProperties>
    /// MainAccountId
    /// ChartOfAccounts
    /// FromValue
    /// ToValue
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("MainAccountId", "ChartOfAccounts", "FromValue", "ToValue")]
    [global::Microsoft.OData.Client.EntitySet("MainAccountTotalAccountIntervals")]
    public partial class MainAccountTotalAccountInterval : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MainAccountTotalAccountInterval object.
        /// </summary>
        /// <param name="mainAccountId">Initial value of MainAccountId.</param>
        /// <param name="chartOfAccounts">Initial value of ChartOfAccounts.</param>
        /// <param name="fromValue">Initial value of FromValue.</param>
        /// <param name="toValue">Initial value of ToValue.</param>
        /// <param name="totalAccountLedgerChartOfAccountsEntityRole">Initial value of TotalAccountLedgerChartOfAccountsEntityRole.</param>
        /// <param name="totalAccountMainAccountEntityRole">Initial value of TotalAccountMainAccountEntityRole.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static MainAccountTotalAccountInterval CreateMainAccountTotalAccountInterval(string mainAccountId, 
                    string chartOfAccounts, 
                    string fromValue, 
                    string toValue, 
                    global::Microsoft.Dynamics.DataEntities.ChartOfAccounts totalAccountLedgerChartOfAccountsEntityRole, 
                    global::Microsoft.Dynamics.DataEntities.MainAccount totalAccountMainAccountEntityRole)
        {
            MainAccountTotalAccountInterval mainAccountTotalAccountInterval = new MainAccountTotalAccountInterval();
            mainAccountTotalAccountInterval.MainAccountId = mainAccountId;
            mainAccountTotalAccountInterval.ChartOfAccounts = chartOfAccounts;
            mainAccountTotalAccountInterval.FromValue = fromValue;
            mainAccountTotalAccountInterval.ToValue = toValue;
            if ((totalAccountLedgerChartOfAccountsEntityRole == null))
            {
                throw new global::System.ArgumentNullException("totalAccountLedgerChartOfAccountsEntityRole");
            }
            mainAccountTotalAccountInterval.TotalAccountLedgerChartOfAccountsEntityRole = totalAccountLedgerChartOfAccountsEntityRole;
            if ((totalAccountMainAccountEntityRole == null))
            {
                throw new global::System.ArgumentNullException("totalAccountMainAccountEntityRole");
            }
            mainAccountTotalAccountInterval.TotalAccountMainAccountEntityRole = totalAccountMainAccountEntityRole;
            return mainAccountTotalAccountInterval;
        }
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
        /// There are no comments for Property FromValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FromValue
        {
            get
            {
                return this._FromValue;
            }
            set
            {
                this.OnFromValueChanging(value);
                this._FromValue = value;
                this.OnFromValueChanged();
                this.OnPropertyChanged("FromValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FromValue;
        partial void OnFromValueChanging(string value);
        partial void OnFromValueChanged();
        /// <summary>
        /// There are no comments for Property ToValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ToValue
        {
            get
            {
                return this._ToValue;
            }
            set
            {
                this.OnToValueChanging(value);
                this._ToValue = value;
                this.OnToValueChanged();
                this.OnPropertyChanged("ToValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ToValue;
        partial void OnToValueChanging(string value);
        partial void OnToValueChanged();
        /// <summary>
        /// There are no comments for Property InvertTotalSign in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> InvertTotalSign
        {
            get
            {
                return this._InvertTotalSign;
            }
            set
            {
                this.OnInvertTotalSignChanging(value);
                this._InvertTotalSign = value;
                this.OnInvertTotalSignChanged();
                this.OnPropertyChanged("InvertTotalSign");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _InvertTotalSign;
        partial void OnInvertTotalSignChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnInvertTotalSignChanged();
        /// <summary>
        /// There are no comments for Property TotalAccountLedgerChartOfAccountsEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ChartOfAccounts TotalAccountLedgerChartOfAccountsEntityRole
        {
            get
            {
                return this._TotalAccountLedgerChartOfAccountsEntityRole;
            }
            set
            {
                this.OnTotalAccountLedgerChartOfAccountsEntityRoleChanging(value);
                this._TotalAccountLedgerChartOfAccountsEntityRole = value;
                this.OnTotalAccountLedgerChartOfAccountsEntityRoleChanged();
                this.OnPropertyChanged("TotalAccountLedgerChartOfAccountsEntityRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ChartOfAccounts _TotalAccountLedgerChartOfAccountsEntityRole;
        partial void OnTotalAccountLedgerChartOfAccountsEntityRoleChanging(global::Microsoft.Dynamics.DataEntities.ChartOfAccounts value);
        partial void OnTotalAccountLedgerChartOfAccountsEntityRoleChanged();
        /// <summary>
        /// There are no comments for Property TotalAccountMainAccountEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.MainAccount TotalAccountMainAccountEntityRole
        {
            get
            {
                return this._TotalAccountMainAccountEntityRole;
            }
            set
            {
                this.OnTotalAccountMainAccountEntityRoleChanging(value);
                this._TotalAccountMainAccountEntityRole = value;
                this.OnTotalAccountMainAccountEntityRoleChanged();
                this.OnPropertyChanged("TotalAccountMainAccountEntityRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.MainAccount _TotalAccountMainAccountEntityRole;
        partial void OnTotalAccountMainAccountEntityRoleChanging(global::Microsoft.Dynamics.DataEntities.MainAccount value);
        partial void OnTotalAccountMainAccountEntityRoleChanged();
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
