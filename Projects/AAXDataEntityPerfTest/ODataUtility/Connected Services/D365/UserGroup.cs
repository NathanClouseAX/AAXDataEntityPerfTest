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
        /// There are no comments for UserGroupSingle in the schema.
        /// </summary>
    public partial class UserGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<UserGroup>
    {
        /// <summary>
        /// Initialize a new UserGroupSingle object.
        /// </summary>
        public UserGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new UserGroupSingle object.
        /// </summary>
        public UserGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new UserGroupSingle object.
        /// </summary>
        public UserGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<UserGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for UserGroupUserList in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.UserGroupUserList> UserGroupUserList
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._UserGroupUserList == null))
                {
                    this._UserGroupUserList = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.UserGroupUserList>(GetPath("UserGroupUserList"));
                }
                return this._UserGroupUserList;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.UserGroupUserList> _UserGroupUserList;
        /// <summary>
        /// There are no comments for BudgetControlGroupOverBudgetPermissionsSystemUserGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupOverBudgetPermission> BudgetControlGroupOverBudgetPermissionsSystemUserGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlGroupOverBudgetPermissionsSystemUserGroup == null))
                {
                    this._BudgetControlGroupOverBudgetPermissionsSystemUserGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupOverBudgetPermission>(GetPath("BudgetControlGroupOverBudgetPermissionsSystemUserGroup"));
                }
                return this._BudgetControlGroupOverBudgetPermissionsSystemUserGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupOverBudgetPermission> _BudgetControlGroupOverBudgetPermissionsSystemUserGroup;
        /// <summary>
        /// There are no comments for BudgetControlOverBudgetPermissionsSystemUserGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlOverBudgetPermission> BudgetControlOverBudgetPermissionsSystemUserGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlOverBudgetPermissionsSystemUserGroup == null))
                {
                    this._BudgetControlOverBudgetPermissionsSystemUserGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlOverBudgetPermission>(GetPath("BudgetControlOverBudgetPermissionsSystemUserGroup"));
                }
                return this._BudgetControlOverBudgetPermissionsSystemUserGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlOverBudgetPermission> _BudgetControlOverBudgetPermissionsSystemUserGroup;
        /// <summary>
        /// There are no comments for LedgerAccountAlias in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerAccountAlias> LedgerAccountAlias
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerAccountAlias == null))
                {
                    this._LedgerAccountAlias = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LedgerAccountAlias>(GetPath("LedgerAccountAlias"));
                }
                return this._LedgerAccountAlias;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerAccountAlias> _LedgerAccountAlias;
        /// <summary>
        /// There are no comments for BudgetControlRuleOverBudgetPermisionsSystemUserGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleOverBudgetPermission> BudgetControlRuleOverBudgetPermisionsSystemUserGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlRuleOverBudgetPermisionsSystemUserGroup == null))
                {
                    this._BudgetControlRuleOverBudgetPermisionsSystemUserGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleOverBudgetPermission>(GetPath("BudgetControlRuleOverBudgetPermisionsSystemUserGroup"));
                }
                return this._BudgetControlRuleOverBudgetPermisionsSystemUserGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleOverBudgetPermission> _BudgetControlRuleOverBudgetPermisionsSystemUserGroup;
        /// <summary>
        /// There are no comments for BudgetControlMessageLevelEntity_Role_SystemUserGroupEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlMessageLevel> BudgetControlMessageLevelEntity_Role_SystemUserGroupEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlMessageLevelEntity_Role_SystemUserGroupEntity == null))
                {
                    this._BudgetControlMessageLevelEntity_Role_SystemUserGroupEntity = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlMessageLevel>(GetPath("BudgetControlMessageLevelEntity_Role_SystemUserGroupEntity"));
                }
                return this._BudgetControlMessageLevelEntity_Role_SystemUserGroupEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlMessageLevel> _BudgetControlMessageLevelEntity_Role_SystemUserGroupEntity;
    }
        /// <summary>
        /// There are no comments for UserGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// GroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("GroupId")]
    [global::Microsoft.OData.Client.EntitySet("UserGroups")]
    public partial class UserGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new UserGroup object.
        /// </summary>
        /// <param name="groupId">Initial value of GroupId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static UserGroup CreateUserGroup(string groupId)
        {
            UserGroup userGroup = new UserGroup();
            userGroup.GroupId = groupId;
            return userGroup;
        }
        /// <summary>
        /// There are no comments for Property GroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupId
        {
            get
            {
                return this._GroupId;
            }
            set
            {
                this.OnGroupIdChanging(value);
                this._GroupId = value;
                this.OnGroupIdChanged();
                this.OnPropertyChanged("GroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupId;
        partial void OnGroupIdChanging(string value);
        partial void OnGroupIdChanged();
        /// <summary>
        /// There are no comments for Property name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this.OnnameChanging(value);
                this._name = value;
                this.OnnameChanged();
                this.OnPropertyChanged("name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _name;
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        /// <summary>
        /// There are no comments for Property UserGroupUserList in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.UserGroupUserList> UserGroupUserList
        {
            get
            {
                return this._UserGroupUserList;
            }
            set
            {
                this.OnUserGroupUserListChanging(value);
                this._UserGroupUserList = value;
                this.OnUserGroupUserListChanged();
                this.OnPropertyChanged("UserGroupUserList");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.UserGroupUserList> _UserGroupUserList = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.UserGroupUserList>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnUserGroupUserListChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.UserGroupUserList> value);
        partial void OnUserGroupUserListChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlGroupOverBudgetPermissionsSystemUserGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupOverBudgetPermission> BudgetControlGroupOverBudgetPermissionsSystemUserGroup
        {
            get
            {
                return this._BudgetControlGroupOverBudgetPermissionsSystemUserGroup;
            }
            set
            {
                this.OnBudgetControlGroupOverBudgetPermissionsSystemUserGroupChanging(value);
                this._BudgetControlGroupOverBudgetPermissionsSystemUserGroup = value;
                this.OnBudgetControlGroupOverBudgetPermissionsSystemUserGroupChanged();
                this.OnPropertyChanged("BudgetControlGroupOverBudgetPermissionsSystemUserGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupOverBudgetPermission> _BudgetControlGroupOverBudgetPermissionsSystemUserGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupOverBudgetPermission>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetControlGroupOverBudgetPermissionsSystemUserGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupOverBudgetPermission> value);
        partial void OnBudgetControlGroupOverBudgetPermissionsSystemUserGroupChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlOverBudgetPermissionsSystemUserGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlOverBudgetPermission> BudgetControlOverBudgetPermissionsSystemUserGroup
        {
            get
            {
                return this._BudgetControlOverBudgetPermissionsSystemUserGroup;
            }
            set
            {
                this.OnBudgetControlOverBudgetPermissionsSystemUserGroupChanging(value);
                this._BudgetControlOverBudgetPermissionsSystemUserGroup = value;
                this.OnBudgetControlOverBudgetPermissionsSystemUserGroupChanged();
                this.OnPropertyChanged("BudgetControlOverBudgetPermissionsSystemUserGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlOverBudgetPermission> _BudgetControlOverBudgetPermissionsSystemUserGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlOverBudgetPermission>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetControlOverBudgetPermissionsSystemUserGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlOverBudgetPermission> value);
        partial void OnBudgetControlOverBudgetPermissionsSystemUserGroupChanged();
        /// <summary>
        /// There are no comments for Property LedgerAccountAlias in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerAccountAlias> LedgerAccountAlias
        {
            get
            {
                return this._LedgerAccountAlias;
            }
            set
            {
                this.OnLedgerAccountAliasChanging(value);
                this._LedgerAccountAlias = value;
                this.OnLedgerAccountAliasChanged();
                this.OnPropertyChanged("LedgerAccountAlias");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerAccountAlias> _LedgerAccountAlias = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerAccountAlias>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLedgerAccountAliasChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerAccountAlias> value);
        partial void OnLedgerAccountAliasChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlRuleOverBudgetPermisionsSystemUserGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleOverBudgetPermission> BudgetControlRuleOverBudgetPermisionsSystemUserGroup
        {
            get
            {
                return this._BudgetControlRuleOverBudgetPermisionsSystemUserGroup;
            }
            set
            {
                this.OnBudgetControlRuleOverBudgetPermisionsSystemUserGroupChanging(value);
                this._BudgetControlRuleOverBudgetPermisionsSystemUserGroup = value;
                this.OnBudgetControlRuleOverBudgetPermisionsSystemUserGroupChanged();
                this.OnPropertyChanged("BudgetControlRuleOverBudgetPermisionsSystemUserGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleOverBudgetPermission> _BudgetControlRuleOverBudgetPermisionsSystemUserGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleOverBudgetPermission>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetControlRuleOverBudgetPermisionsSystemUserGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleOverBudgetPermission> value);
        partial void OnBudgetControlRuleOverBudgetPermisionsSystemUserGroupChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlMessageLevelEntity_Role_SystemUserGroupEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlMessageLevel> BudgetControlMessageLevelEntity_Role_SystemUserGroupEntity
        {
            get
            {
                return this._BudgetControlMessageLevelEntity_Role_SystemUserGroupEntity;
            }
            set
            {
                this.OnBudgetControlMessageLevelEntity_Role_SystemUserGroupEntityChanging(value);
                this._BudgetControlMessageLevelEntity_Role_SystemUserGroupEntity = value;
                this.OnBudgetControlMessageLevelEntity_Role_SystemUserGroupEntityChanged();
                this.OnPropertyChanged("BudgetControlMessageLevelEntity_Role_SystemUserGroupEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlMessageLevel> _BudgetControlMessageLevelEntity_Role_SystemUserGroupEntity = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlMessageLevel>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetControlMessageLevelEntity_Role_SystemUserGroupEntityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlMessageLevel> value);
        partial void OnBudgetControlMessageLevelEntity_Role_SystemUserGroupEntityChanged();
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
