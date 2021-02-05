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
        /// There are no comments for AccountTranslationSingle in the schema.
        /// </summary>
    public partial class AccountTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AccountTranslation>
    {
        /// <summary>
        /// Initialize a new AccountTranslationSingle object.
        /// </summary>
        public AccountTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AccountTranslationSingle object.
        /// </summary>
        public AccountTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AccountTranslationSingle object.
        /// </summary>
        public AccountTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AccountTranslation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LedgerChartOfAccountsEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ChartOfAccountsSingle LedgerChartOfAccountsEntityRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerChartOfAccountsEntityRole == null))
                {
                    this._LedgerChartOfAccountsEntityRole = new global::Microsoft.Dynamics.DataEntities.ChartOfAccountsSingle(this.Context, GetPath("LedgerChartOfAccountsEntityRole"));
                }
                return this._LedgerChartOfAccountsEntityRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ChartOfAccountsSingle _LedgerChartOfAccountsEntityRole;
        /// <summary>
        /// There are no comments for MainAccountEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.MainAccountSingle MainAccountEntityRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._MainAccountEntityRole == null))
                {
                    this._MainAccountEntityRole = new global::Microsoft.Dynamics.DataEntities.MainAccountSingle(this.Context, GetPath("MainAccountEntityRole"));
                }
                return this._MainAccountEntityRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.MainAccountSingle _MainAccountEntityRole;
    }
        /// <summary>
        /// There are no comments for AccountTranslation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// MainAccount
    /// ChartOfAccounts
    /// Language
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("MainAccount", "ChartOfAccounts", "Language")]
    [global::Microsoft.OData.Client.EntitySet("AccountTranslations")]
    public partial class AccountTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AccountTranslation object.
        /// </summary>
        /// <param name="mainAccount">Initial value of MainAccount.</param>
        /// <param name="chartOfAccounts">Initial value of ChartOfAccounts.</param>
        /// <param name="language">Initial value of Language.</param>
        /// <param name="ledgerChartOfAccountsEntityRole">Initial value of LedgerChartOfAccountsEntityRole.</param>
        /// <param name="mainAccountEntityRole">Initial value of MainAccountEntityRole.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AccountTranslation CreateAccountTranslation(string mainAccount, string chartOfAccounts, string language, global::Microsoft.Dynamics.DataEntities.ChartOfAccounts ledgerChartOfAccountsEntityRole, global::Microsoft.Dynamics.DataEntities.MainAccount mainAccountEntityRole)
        {
            AccountTranslation accountTranslation = new AccountTranslation();
            accountTranslation.MainAccount = mainAccount;
            accountTranslation.ChartOfAccounts = chartOfAccounts;
            accountTranslation.Language = language;
            if ((ledgerChartOfAccountsEntityRole == null))
            {
                throw new global::System.ArgumentNullException("ledgerChartOfAccountsEntityRole");
            }
            accountTranslation.LedgerChartOfAccountsEntityRole = ledgerChartOfAccountsEntityRole;
            if ((mainAccountEntityRole == null))
            {
                throw new global::System.ArgumentNullException("mainAccountEntityRole");
            }
            accountTranslation.MainAccountEntityRole = mainAccountEntityRole;
            return accountTranslation;
        }
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
        /// There are no comments for Property Language in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Language
        {
            get
            {
                return this._Language;
            }
            set
            {
                this.OnLanguageChanging(value);
                this._Language = value;
                this.OnLanguageChanged();
                this.OnPropertyChanged("Language");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Language;
        partial void OnLanguageChanging(string value);
        partial void OnLanguageChanged();
        /// <summary>
        /// There are no comments for Property TranslatedText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TranslatedText
        {
            get
            {
                return this._TranslatedText;
            }
            set
            {
                this.OnTranslatedTextChanging(value);
                this._TranslatedText = value;
                this.OnTranslatedTextChanged();
                this.OnPropertyChanged("TranslatedText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedText;
        partial void OnTranslatedTextChanging(string value);
        partial void OnTranslatedTextChanged();
        /// <summary>
        /// There are no comments for Property OriginalText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OriginalText
        {
            get
            {
                return this._OriginalText;
            }
            set
            {
                this.OnOriginalTextChanging(value);
                this._OriginalText = value;
                this.OnOriginalTextChanged();
                this.OnPropertyChanged("OriginalText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OriginalText;
        partial void OnOriginalTextChanging(string value);
        partial void OnOriginalTextChanged();
        /// <summary>
        /// There are no comments for Property LedgerChartOfAccountsEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ChartOfAccounts LedgerChartOfAccountsEntityRole
        {
            get
            {
                return this._LedgerChartOfAccountsEntityRole;
            }
            set
            {
                this.OnLedgerChartOfAccountsEntityRoleChanging(value);
                this._LedgerChartOfAccountsEntityRole = value;
                this.OnLedgerChartOfAccountsEntityRoleChanged();
                this.OnPropertyChanged("LedgerChartOfAccountsEntityRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ChartOfAccounts _LedgerChartOfAccountsEntityRole;
        partial void OnLedgerChartOfAccountsEntityRoleChanging(global::Microsoft.Dynamics.DataEntities.ChartOfAccounts value);
        partial void OnLedgerChartOfAccountsEntityRoleChanged();
        /// <summary>
        /// There are no comments for Property MainAccountEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.MainAccount MainAccountEntityRole
        {
            get
            {
                return this._MainAccountEntityRole;
            }
            set
            {
                this.OnMainAccountEntityRoleChanging(value);
                this._MainAccountEntityRole = value;
                this.OnMainAccountEntityRoleChanged();
                this.OnPropertyChanged("MainAccountEntityRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.MainAccount _MainAccountEntityRole;
        partial void OnMainAccountEntityRoleChanging(global::Microsoft.Dynamics.DataEntities.MainAccount value);
        partial void OnMainAccountEntityRoleChanged();
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
