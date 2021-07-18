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
        /// There are no comments for ReconciliationMatchRuleSetSingle in the schema.
        /// </summary>
    public partial class ReconciliationMatchRuleSetSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ReconciliationMatchRuleSet>
    {
        /// <summary>
        /// Initialize a new ReconciliationMatchRuleSetSingle object.
        /// </summary>
        public ReconciliationMatchRuleSetSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReconciliationMatchRuleSetSingle object.
        /// </summary>
        public ReconciliationMatchRuleSetSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReconciliationMatchRuleSetSingle object.
        /// </summary>
        public ReconciliationMatchRuleSetSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ReconciliationMatchRuleSet> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BankAccount> BankAccount
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BankAccount == null))
                {
                    this._BankAccount = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BankAccount>(GetPath("BankAccount"));
                }
                return this._BankAccount;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BankAccount> _BankAccount;
    }
        /// <summary>
        /// There are no comments for ReconciliationMatchRuleSet in the schema.
        /// </summary>
    /// <KeyProperties>
    /// MatchingRuleSet
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("MatchingRuleSet", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("ReconciliationMatchRuleSets")]
    public partial class ReconciliationMatchRuleSet : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReconciliationMatchRuleSet object.
        /// </summary>
        /// <param name="matchingRuleSet">Initial value of MatchingRuleSet.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReconciliationMatchRuleSet CreateReconciliationMatchRuleSet(string matchingRuleSet, decimal lineNumber)
        {
            ReconciliationMatchRuleSet reconciliationMatchRuleSet = new ReconciliationMatchRuleSet();
            reconciliationMatchRuleSet.MatchingRuleSet = matchingRuleSet;
            reconciliationMatchRuleSet.LineNumber = lineNumber;
            return reconciliationMatchRuleSet;
        }
        /// <summary>
        /// There are no comments for Property MatchingRuleSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MatchingRuleSet
        {
            get
            {
                return this._MatchingRuleSet;
            }
            set
            {
                this.OnMatchingRuleSetChanging(value);
                this._MatchingRuleSet = value;
                this.OnMatchingRuleSetChanged();
                this.OnPropertyChanged("MatchingRuleSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MatchingRuleSet;
        partial void OnMatchingRuleSetChanging(string value);
        partial void OnMatchingRuleSetChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
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
        /// There are no comments for Property MatchingRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MatchingRule
        {
            get
            {
                return this._MatchingRule;
            }
            set
            {
                this.OnMatchingRuleChanging(value);
                this._MatchingRule = value;
                this.OnMatchingRuleChanged();
                this.OnPropertyChanged("MatchingRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MatchingRule;
        partial void OnMatchingRuleChanging(string value);
        partial void OnMatchingRuleChanged();
        /// <summary>
        /// There are no comments for Property BankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BankAccount> BankAccount
        {
            get
            {
                return this._BankAccount;
            }
            set
            {
                this.OnBankAccountChanging(value);
                this._BankAccount = value;
                this.OnBankAccountChanged();
                this.OnPropertyChanged("BankAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BankAccount> _BankAccount = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BankAccount>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBankAccountChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BankAccount> value);
        partial void OnBankAccountChanged();
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
