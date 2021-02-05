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
        /// There are no comments for BudgetControlMessageLevelSingle in the schema.
        /// </summary>
    public partial class BudgetControlMessageLevelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlMessageLevel>
    {
        /// <summary>
        /// Initialize a new BudgetControlMessageLevelSingle object.
        /// </summary>
        public BudgetControlMessageLevelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetControlMessageLevelSingle object.
        /// </summary>
        public BudgetControlMessageLevelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetControlMessageLevelSingle object.
        /// </summary>
        public BudgetControlMessageLevelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlMessageLevel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetControlConfigurations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle BudgetControlConfigurations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlConfigurations == null))
                {
                    this._BudgetControlConfigurations = new global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle(this.Context, GetPath("BudgetControlConfigurations"));
                }
                return this._BudgetControlConfigurations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle _BudgetControlConfigurations;
        /// <summary>
        /// There are no comments for BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UserGroupSingle BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity == null))
                {
                    this._BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity = new global::Microsoft.Dynamics.DataEntities.UserGroupSingle(this.Context, GetPath("BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity"));
                }
                return this._BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UserGroupSingle _BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity;
    }
        /// <summary>
        /// There are no comments for BudgetControlMessageLevel in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LegalEntityId
    /// Status
    /// UserGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LegalEntityId", "Status", "UserGroupId")]
    [global::Microsoft.OData.Client.EntitySet("BudgetControlMessageLevels")]
    public partial class BudgetControlMessageLevel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetControlMessageLevel object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="userGroupId">Initial value of UserGroupId.</param>
        /// <param name="budgetControlConfigurations">Initial value of BudgetControlConfigurations.</param>
        /// <param name="budgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity">Initial value of BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetControlMessageLevel CreateBudgetControlMessageLevel(string dataAreaId, string legalEntityId, string userGroupId, global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration budgetControlConfigurations, global::Microsoft.Dynamics.DataEntities.UserGroup budgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity)
        {
            BudgetControlMessageLevel budgetControlMessageLevel = new BudgetControlMessageLevel();
            budgetControlMessageLevel.dataAreaId = dataAreaId;
            budgetControlMessageLevel.LegalEntityId = legalEntityId;
            budgetControlMessageLevel.UserGroupId = userGroupId;
            if ((budgetControlConfigurations == null))
            {
                throw new global::System.ArgumentNullException("budgetControlConfigurations");
            }
            budgetControlMessageLevel.BudgetControlConfigurations = budgetControlConfigurations;
            if ((budgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity == null))
            {
                throw new global::System.ArgumentNullException("budgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity");
            }
            budgetControlMessageLevel.BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity = budgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity;
            return budgetControlMessageLevel;
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
        /// There are no comments for Property Selected in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Selected
        {
            get
            {
                return this._Selected;
            }
            set
            {
                this.OnSelectedChanging(value);
                this._Selected = value;
                this.OnSelectedChanged();
                this.OnPropertyChanged("Selected");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Selected;
        partial void OnSelectedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSelectedChanged();
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
        /// There are no comments for Property BudgetControlConfigurations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration BudgetControlConfigurations
        {
            get
            {
                return this._BudgetControlConfigurations;
            }
            set
            {
                this.OnBudgetControlConfigurationsChanging(value);
                this._BudgetControlConfigurations = value;
                this.OnBudgetControlConfigurationsChanged();
                this.OnPropertyChanged("BudgetControlConfigurations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration _BudgetControlConfigurations;
        partial void OnBudgetControlConfigurationsChanging(global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration value);
        partial void OnBudgetControlConfigurationsChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UserGroup BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity
        {
            get
            {
                return this._BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity;
            }
            set
            {
                this.OnBudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntityChanging(value);
                this._BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity = value;
                this.OnBudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntityChanged();
                this.OnPropertyChanged("BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UserGroup _BudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntity;
        partial void OnBudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntityChanging(global::Microsoft.Dynamics.DataEntities.UserGroup value);
        partial void OnBudgetControlMessageLevelEntity_RelatedRole_SystemUserGroupEntityChanged();
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
