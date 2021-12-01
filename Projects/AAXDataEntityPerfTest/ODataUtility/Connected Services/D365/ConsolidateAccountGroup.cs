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
    /// There are no comments for ConsolidateAccountGroupSingle in the schema.
    /// </summary>
    public partial class ConsolidateAccountGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ConsolidateAccountGroup>
    {
        /// <summary>
        /// Initialize a new ConsolidateAccountGroupSingle object.
        /// </summary>
        public ConsolidateAccountGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ConsolidateAccountGroupSingle object.
        /// </summary>
        public ConsolidateAccountGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ConsolidateAccountGroupSingle object.
        /// </summary>
        public ConsolidateAccountGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ConsolidateAccountGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ConsolidateAccountGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ConsolidationAccountGroup
    /// ChartOfAccounts
    /// MainAccount
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ConsolidationAccountGroup", "ChartOfAccounts", "MainAccount")]
    [global::Microsoft.OData.Client.EntitySet("ConsolidateAccountGroups")]
    public partial class ConsolidateAccountGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ConsolidateAccountGroup object.
        /// </summary>
        /// <param name="consolidationAccountGroup">Initial value of ConsolidationAccountGroup.</param>
        /// <param name="chartOfAccounts">Initial value of ChartOfAccounts.</param>
        /// <param name="mainAccount">Initial value of MainAccount.</param>
        /// <param name="sATLevel">Initial value of SATLevel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ConsolidateAccountGroup CreateConsolidateAccountGroup(string consolidationAccountGroup, string chartOfAccounts, string mainAccount, int sATLevel)
        {
            ConsolidateAccountGroup consolidateAccountGroup = new ConsolidateAccountGroup();
            consolidateAccountGroup.ConsolidationAccountGroup = consolidationAccountGroup;
            consolidateAccountGroup.ChartOfAccounts = chartOfAccounts;
            consolidateAccountGroup.MainAccount = mainAccount;
            consolidateAccountGroup.SATLevel = sATLevel;
            return consolidateAccountGroup;
        }
        /// <summary>
        /// There are no comments for Property ConsolidationAccountGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ConsolidationAccountGroup is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ChartOfAccounts is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MainAccount is required.")]
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
        /// There are no comments for Property SATLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SATLevel is required.")]
        public virtual int SATLevel
        {
            get
            {
                return this._SATLevel;
            }
            set
            {
                this.OnSATLevelChanging(value);
                this._SATLevel = value;
                this.OnSATLevelChanged();
                this.OnPropertyChanged("SATLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _SATLevel;
        partial void OnSATLevelChanging(int value);
        partial void OnSATLevelChanged();
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
