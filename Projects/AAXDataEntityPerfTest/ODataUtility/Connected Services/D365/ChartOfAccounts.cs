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
    /// There are no comments for ChartOfAccountsSingle in the schema.
    /// </summary>
    public partial class ChartOfAccountsSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ChartOfAccounts>
    {
        /// <summary>
        /// Initialize a new ChartOfAccountsSingle object.
        /// </summary>
        public ChartOfAccountsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ChartOfAccountsSingle object.
        /// </summary>
        public ChartOfAccountsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ChartOfAccountsSingle object.
        /// </summary>
        public ChartOfAccountsSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ChartOfAccounts> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LedgerChartOfAccountsEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AccountTranslation> LedgerChartOfAccountsEntityRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerChartOfAccountsEntityRole == null))
                {
                    this._LedgerChartOfAccountsEntityRole = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AccountTranslation>(GetPath("LedgerChartOfAccountsEntityRole"));
                }
                return this._LedgerChartOfAccountsEntityRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AccountTranslation> _LedgerChartOfAccountsEntityRole;
        /// <summary>
        /// There are no comments for LedgerChartOfAccountsEntityRole2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ConsolidateAccount> LedgerChartOfAccountsEntityRole2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerChartOfAccountsEntityRole2 == null))
                {
                    this._LedgerChartOfAccountsEntityRole2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ConsolidateAccount>(GetPath("LedgerChartOfAccountsEntityRole2"));
                }
                return this._LedgerChartOfAccountsEntityRole2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ConsolidateAccount> _LedgerChartOfAccountsEntityRole2;
        /// <summary>
        /// There are no comments for TotalAccountLedgerChartOfAccountsEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.MainAccountTotalAccountInterval> TotalAccountLedgerChartOfAccountsEntityRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TotalAccountLedgerChartOfAccountsEntityRole == null))
                {
                    this._TotalAccountLedgerChartOfAccountsEntityRole = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.MainAccountTotalAccountInterval>(GetPath("TotalAccountLedgerChartOfAccountsEntityRole"));
                }
                return this._TotalAccountLedgerChartOfAccountsEntityRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.MainAccountTotalAccountInterval> _TotalAccountLedgerChartOfAccountsEntityRole;
    }
    /// <summary>
    /// There are no comments for ChartOfAccounts in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ChartOfAccounts
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ChartOfAccounts")]
    [global::Microsoft.OData.Client.EntitySet("ChartOfAccounts")]
    public partial class ChartOfAccounts : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ChartOfAccounts object.
        /// </summary>
        /// <param name="chartOfAccounts1">Initial value of ChartOfAccounts1.</param>
        /// <param name="chartOfAccountsRecId">Initial value of ChartOfAccountsRecId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ChartOfAccounts CreateChartOfAccounts(string chartOfAccounts1, long chartOfAccountsRecId)
        {
            ChartOfAccounts chartOfAccounts = new ChartOfAccounts();
            chartOfAccounts.ChartOfAccounts1 = chartOfAccounts1;
            chartOfAccounts.ChartOfAccountsRecId = chartOfAccountsRecId;
            return chartOfAccounts;
        }
        /// <summary>
        /// There are no comments for Property ChartOfAccounts1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChartOfAccounts")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ChartOfAccounts1 is required.")]
        public virtual string ChartOfAccounts1
        {
            get
            {
                return this._ChartOfAccounts1;
            }
            set
            {
                this.OnChartOfAccounts1Changing(value);
                this._ChartOfAccounts1 = value;
                this.OnChartOfAccounts1Changed();
                this.OnPropertyChanged("ChartOfAccounts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChartOfAccounts1;
        partial void OnChartOfAccounts1Changing(string value);
        partial void OnChartOfAccounts1Changed();
        /// <summary>
        /// There are no comments for Property MainAccountMask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string MainAccountMask
        {
            get
            {
                return this._MainAccountMask;
            }
            set
            {
                this.OnMainAccountMaskChanging(value);
                this._MainAccountMask = value;
                this.OnMainAccountMaskChanged();
                this.OnPropertyChanged("MainAccountMask");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountMask;
        partial void OnMainAccountMaskChanging(string value);
        partial void OnMainAccountMaskChanged();
        /// <summary>
        /// There are no comments for Property ChartOfAccountsRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ChartOfAccountsRecId is required.")]
        public virtual long ChartOfAccountsRecId
        {
            get
            {
                return this._ChartOfAccountsRecId;
            }
            set
            {
                this.OnChartOfAccountsRecIdChanging(value);
                this._ChartOfAccountsRecId = value;
                this.OnChartOfAccountsRecIdChanged();
                this.OnPropertyChanged("ChartOfAccountsRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _ChartOfAccountsRecId;
        partial void OnChartOfAccountsRecIdChanging(long value);
        partial void OnChartOfAccountsRecIdChanged();
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
        /// There are no comments for Property LedgerChartOfAccountsEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccountTranslation> LedgerChartOfAccountsEntityRole
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
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccountTranslation> _LedgerChartOfAccountsEntityRole = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccountTranslation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLedgerChartOfAccountsEntityRoleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccountTranslation> value);
        partial void OnLedgerChartOfAccountsEntityRoleChanged();
        /// <summary>
        /// There are no comments for Property LedgerChartOfAccountsEntityRole2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConsolidateAccount> LedgerChartOfAccountsEntityRole2
        {
            get
            {
                return this._LedgerChartOfAccountsEntityRole2;
            }
            set
            {
                this.OnLedgerChartOfAccountsEntityRole2Changing(value);
                this._LedgerChartOfAccountsEntityRole2 = value;
                this.OnLedgerChartOfAccountsEntityRole2Changed();
                this.OnPropertyChanged("LedgerChartOfAccountsEntityRole2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConsolidateAccount> _LedgerChartOfAccountsEntityRole2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConsolidateAccount>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLedgerChartOfAccountsEntityRole2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConsolidateAccount> value);
        partial void OnLedgerChartOfAccountsEntityRole2Changed();
        /// <summary>
        /// There are no comments for Property TotalAccountLedgerChartOfAccountsEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.MainAccountTotalAccountInterval> TotalAccountLedgerChartOfAccountsEntityRole
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
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.MainAccountTotalAccountInterval> _TotalAccountLedgerChartOfAccountsEntityRole = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.MainAccountTotalAccountInterval>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTotalAccountLedgerChartOfAccountsEntityRoleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.MainAccountTotalAccountInterval> value);
        partial void OnTotalAccountLedgerChartOfAccountsEntityRoleChanged();
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
