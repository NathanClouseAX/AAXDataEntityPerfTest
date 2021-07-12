﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 6/6/2021 9:11:38 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for BudgetControlOverBudgetPermissionSingle in the schema.
        /// </summary>
    public partial class BudgetControlOverBudgetPermissionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlOverBudgetPermission>
    {
        /// <summary>
        /// Initialize a new BudgetControlOverBudgetPermissionSingle object.
        /// </summary>
        public BudgetControlOverBudgetPermissionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetControlOverBudgetPermissionSingle object.
        /// </summary>
        public BudgetControlOverBudgetPermissionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetControlOverBudgetPermissionSingle object.
        /// </summary>
        public BudgetControlOverBudgetPermissionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlOverBudgetPermission> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetControlConfigurationOverrideUserGroupOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle BudgetControlConfigurationOverrideUserGroupOption
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlConfigurationOverrideUserGroupOption == null))
                {
                    this._BudgetControlConfigurationOverrideUserGroupOption = new global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle(this.Context, GetPath("BudgetControlConfigurationOverrideUserGroupOption"));
                }
                return this._BudgetControlConfigurationOverrideUserGroupOption;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle _BudgetControlConfigurationOverrideUserGroupOption;
        /// <summary>
        /// There are no comments for SystemUserGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UserGroupSingle SystemUserGroups
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SystemUserGroups == null))
                {
                    this._SystemUserGroups = new global::Microsoft.Dynamics.DataEntities.UserGroupSingle(this.Context, GetPath("SystemUserGroups"));
                }
                return this._SystemUserGroups;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UserGroupSingle _SystemUserGroups;
    }
        /// <summary>
        /// There are no comments for BudgetControlOverBudgetPermission in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LegalEntityId
    /// Status
    /// UserGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LegalEntityId", "Status", "UserGroupId")]
    [global::Microsoft.OData.Client.EntitySet("BudgetControlOverBudgetPermissions")]
    public partial class BudgetControlOverBudgetPermission : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetControlOverBudgetPermission object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="userGroupId">Initial value of UserGroupId.</param>
        /// <param name="budgetControlConfigurationOverrideUserGroupOption">Initial value of BudgetControlConfigurationOverrideUserGroupOption.</param>
        /// <param name="systemUserGroups">Initial value of SystemUserGroups.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetControlOverBudgetPermission CreateBudgetControlOverBudgetPermission(string dataAreaId, string legalEntityId, string userGroupId, global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration budgetControlConfigurationOverrideUserGroupOption, global::Microsoft.Dynamics.DataEntities.UserGroup systemUserGroups)
        {
            BudgetControlOverBudgetPermission budgetControlOverBudgetPermission = new BudgetControlOverBudgetPermission();
            budgetControlOverBudgetPermission.dataAreaId = dataAreaId;
            budgetControlOverBudgetPermission.LegalEntityId = legalEntityId;
            budgetControlOverBudgetPermission.UserGroupId = userGroupId;
            if ((budgetControlConfigurationOverrideUserGroupOption == null))
            {
                throw new global::System.ArgumentNullException("budgetControlConfigurationOverrideUserGroupOption");
            }
            budgetControlOverBudgetPermission.BudgetControlConfigurationOverrideUserGroupOption = budgetControlConfigurationOverrideUserGroupOption;
            if ((systemUserGroups == null))
            {
                throw new global::System.ArgumentNullException("systemUserGroups");
            }
            budgetControlOverBudgetPermission.SystemUserGroups = systemUserGroups;
            return budgetControlOverBudgetPermission;
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
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property UserGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UserGroupId
        {
            get
            {
                return this._UserGroupId;
            }
            set
            {
                this.OnUserGroupIdChanging(value);
                this._UserGroupId = value;
                this.OnUserGroupIdChanged();
                this.OnPropertyChanged("UserGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserGroupId;
        partial void OnUserGroupIdChanging(string value);
        partial void OnUserGroupIdChanged();
        /// <summary>
        /// There are no comments for Property OverBudgetOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCheckOverbudgetOption> OverBudgetOption
        {
            get
            {
                return this._OverBudgetOption;
            }
            set
            {
                this.OnOverBudgetOptionChanging(value);
                this._OverBudgetOption = value;
                this.OnOverBudgetOptionChanged();
                this.OnPropertyChanged("OverBudgetOption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCheckOverbudgetOption> _OverBudgetOption;
        partial void OnOverBudgetOptionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCheckOverbudgetOption> value);
        partial void OnOverBudgetOptionChanged();
        /// <summary>
        /// There are no comments for Property UserGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UserGroupName
        {
            get
            {
                return this._UserGroupName;
            }
            set
            {
                this.OnUserGroupNameChanging(value);
                this._UserGroupName = value;
                this.OnUserGroupNameChanged();
                this.OnPropertyChanged("UserGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserGroupName;
        partial void OnUserGroupNameChanging(string value);
        partial void OnUserGroupNameChanged();
        /// <summary>
        /// There are no comments for Property InUseBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InUseBy
        {
            get
            {
                return this._InUseBy;
            }
            set
            {
                this.OnInUseByChanging(value);
                this._InUseBy = value;
                this.OnInUseByChanged();
                this.OnPropertyChanged("InUseBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InUseBy;
        partial void OnInUseByChanging(string value);
        partial void OnInUseByChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlConfigurationOverrideUserGroupOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration BudgetControlConfigurationOverrideUserGroupOption
        {
            get
            {
                return this._BudgetControlConfigurationOverrideUserGroupOption;
            }
            set
            {
                this.OnBudgetControlConfigurationOverrideUserGroupOptionChanging(value);
                this._BudgetControlConfigurationOverrideUserGroupOption = value;
                this.OnBudgetControlConfigurationOverrideUserGroupOptionChanged();
                this.OnPropertyChanged("BudgetControlConfigurationOverrideUserGroupOption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration _BudgetControlConfigurationOverrideUserGroupOption;
        partial void OnBudgetControlConfigurationOverrideUserGroupOptionChanging(global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration value);
        partial void OnBudgetControlConfigurationOverrideUserGroupOptionChanged();
        /// <summary>
        /// There are no comments for Property SystemUserGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UserGroup SystemUserGroups
        {
            get
            {
                return this._SystemUserGroups;
            }
            set
            {
                this.OnSystemUserGroupsChanging(value);
                this._SystemUserGroups = value;
                this.OnSystemUserGroupsChanged();
                this.OnPropertyChanged("SystemUserGroups");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UserGroup _SystemUserGroups;
        partial void OnSystemUserGroupsChanging(global::Microsoft.Dynamics.DataEntities.UserGroup value);
        partial void OnSystemUserGroupsChanged();
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
