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
        /// There are no comments for LedgerAccountAliasSingle in the schema.
        /// </summary>
    public partial class LedgerAccountAliasSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerAccountAlias>
    {
        /// <summary>
        /// Initialize a new LedgerAccountAliasSingle object.
        /// </summary>
        public LedgerAccountAliasSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LedgerAccountAliasSingle object.
        /// </summary>
        public LedgerAccountAliasSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LedgerAccountAliasSingle object.
        /// </summary>
        public LedgerAccountAliasSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerAccountAlias> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
        /// <summary>
        /// There are no comments for LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntitySingle LegalEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LegalEntity == null))
                {
                    this._LegalEntity = new global::Microsoft.Dynamics.DataEntities.LegalEntitySingle(this.Context, GetPath("LegalEntity"));
                }
                return this._LegalEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntitySingle _LegalEntity;
        /// <summary>
        /// There are no comments for SystemUser in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.SystemUserSingle SystemUser
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SystemUser == null))
                {
                    this._SystemUser = new global::Microsoft.Dynamics.DataEntities.SystemUserSingle(this.Context, GetPath("SystemUser"));
                }
                return this._SystemUser;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SystemUserSingle _SystemUser;
        /// <summary>
        /// There are no comments for DimensionAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionAttributeSingle DimensionAttribute
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionAttribute == null))
                {
                    this._DimensionAttribute = new global::Microsoft.Dynamics.DataEntities.DimensionAttributeSingle(this.Context, GetPath("DimensionAttribute"));
                }
                return this._DimensionAttribute;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionAttributeSingle _DimensionAttribute;
        /// <summary>
        /// There are no comments for UserGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UserGroupSingle UserGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._UserGroup == null))
                {
                    this._UserGroup = new global::Microsoft.Dynamics.DataEntities.UserGroupSingle(this.Context, GetPath("UserGroup"));
                }
                return this._UserGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UserGroupSingle _UserGroup;
    }
        /// <summary>
        /// There are no comments for LedgerAccountAlias in the schema.
        /// </summary>
    /// <KeyProperties>
    /// Name
    /// AliasType
    /// UserInfo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Name", "AliasType", "UserInfo")]
    [global::Microsoft.OData.Client.EntitySet("LedgerAccountAliases")]
    public partial class LedgerAccountAlias : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LedgerAccountAlias object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="userInfo">Initial value of UserInfo.</param>
        /// <param name="dimensionCombination">Initial value of DimensionCombination.</param>
        /// <param name="dimensionAttribute">Initial value of DimensionAttribute.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LedgerAccountAlias CreateLedgerAccountAlias(string name, string userInfo, global::Microsoft.Dynamics.DataEntities.DimensionCombination dimensionCombination, global::Microsoft.Dynamics.DataEntities.DimensionAttribute dimensionAttribute)
        {
            LedgerAccountAlias ledgerAccountAlias = new LedgerAccountAlias();
            ledgerAccountAlias.Name = name;
            ledgerAccountAlias.UserInfo = userInfo;
            if ((dimensionCombination == null))
            {
                throw new global::System.ArgumentNullException("dimensionCombination");
            }
            ledgerAccountAlias.DimensionCombination = dimensionCombination;
            if ((dimensionAttribute == null))
            {
                throw new global::System.ArgumentNullException("dimensionAttribute");
            }
            ledgerAccountAlias.DimensionAttribute = dimensionAttribute;
            return ledgerAccountAlias;
        }
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
        /// There are no comments for Property AliasType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimensionAliasType> AliasType
        {
            get
            {
                return this._AliasType;
            }
            set
            {
                this.OnAliasTypeChanging(value);
                this._AliasType = value;
                this.OnAliasTypeChanged();
                this.OnPropertyChanged("AliasType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimensionAliasType> _AliasType;
        partial void OnAliasTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimensionAliasType> value);
        partial void OnAliasTypeChanged();
        /// <summary>
        /// There are no comments for Property UserInfo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UserInfo
        {
            get
            {
                return this._UserInfo;
            }
            set
            {
                this.OnUserInfoChanging(value);
                this._UserInfo = value;
                this.OnUserInfoChanged();
                this.OnPropertyChanged("UserInfo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserInfo;
        partial void OnUserInfoChanging(string value);
        partial void OnUserInfoChanged();
        /// <summary>
        /// There are no comments for Property DimensionAttributeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionAttributeName
        {
            get
            {
                return this._DimensionAttributeName;
            }
            set
            {
                this.OnDimensionAttributeNameChanging(value);
                this._DimensionAttributeName = value;
                this.OnDimensionAttributeNameChanged();
                this.OnPropertyChanged("DimensionAttributeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionAttributeName;
        partial void OnDimensionAttributeNameChanging(string value);
        partial void OnDimensionAttributeNameChanged();
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
        /// There are no comments for Property DimensionAttributeValueCombinationAccountStructure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionAttributeValueCombinationAccountStructure
        {
            get
            {
                return this._DimensionAttributeValueCombinationAccountStructure;
            }
            set
            {
                this.OnDimensionAttributeValueCombinationAccountStructureChanging(value);
                this._DimensionAttributeValueCombinationAccountStructure = value;
                this.OnDimensionAttributeValueCombinationAccountStructureChanged();
                this.OnPropertyChanged("DimensionAttributeValueCombinationAccountStructure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionAttributeValueCombinationAccountStructure;
        partial void OnDimensionAttributeValueCombinationAccountStructureChanging(string value);
        partial void OnDimensionAttributeValueCombinationAccountStructureChanged();
        /// <summary>
        /// There are no comments for Property UserGroupInfo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UserGroupInfo
        {
            get
            {
                return this._UserGroupInfo;
            }
            set
            {
                this.OnUserGroupInfoChanging(value);
                this._UserGroupInfo = value;
                this.OnUserGroupInfoChanged();
                this.OnPropertyChanged("UserGroupInfo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserGroupInfo;
        partial void OnUserGroupInfoChanging(string value);
        partial void OnUserGroupInfoChanged();
        /// <summary>
        /// There are no comments for Property DimensionAttributeValueCombinationDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionAttributeValueCombinationDisplayValue
        {
            get
            {
                return this._DimensionAttributeValueCombinationDisplayValue;
            }
            set
            {
                this.OnDimensionAttributeValueCombinationDisplayValueChanging(value);
                this._DimensionAttributeValueCombinationDisplayValue = value;
                this.OnDimensionAttributeValueCombinationDisplayValueChanged();
                this.OnPropertyChanged("DimensionAttributeValueCombinationDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionAttributeValueCombinationDisplayValue;
        partial void OnDimensionAttributeValueCombinationDisplayValueChanging(string value);
        partial void OnDimensionAttributeValueCombinationDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
        /// <summary>
        /// There are no comments for Property LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntity LegalEntity
        {
            get
            {
                return this._LegalEntity;
            }
            set
            {
                this.OnLegalEntityChanging(value);
                this._LegalEntity = value;
                this.OnLegalEntityChanged();
                this.OnPropertyChanged("LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntity _LegalEntity;
        partial void OnLegalEntityChanging(global::Microsoft.Dynamics.DataEntities.LegalEntity value);
        partial void OnLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property SystemUser in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.SystemUser SystemUser
        {
            get
            {
                return this._SystemUser;
            }
            set
            {
                this.OnSystemUserChanging(value);
                this._SystemUser = value;
                this.OnSystemUserChanged();
                this.OnPropertyChanged("SystemUser");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SystemUser _SystemUser;
        partial void OnSystemUserChanging(global::Microsoft.Dynamics.DataEntities.SystemUser value);
        partial void OnSystemUserChanged();
        /// <summary>
        /// There are no comments for Property DimensionAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionAttribute DimensionAttribute
        {
            get
            {
                return this._DimensionAttribute;
            }
            set
            {
                this.OnDimensionAttributeChanging(value);
                this._DimensionAttribute = value;
                this.OnDimensionAttributeChanged();
                this.OnPropertyChanged("DimensionAttribute");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionAttribute _DimensionAttribute;
        partial void OnDimensionAttributeChanging(global::Microsoft.Dynamics.DataEntities.DimensionAttribute value);
        partial void OnDimensionAttributeChanged();
        /// <summary>
        /// There are no comments for Property UserGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UserGroup UserGroup
        {
            get
            {
                return this._UserGroup;
            }
            set
            {
                this.OnUserGroupChanging(value);
                this._UserGroup = value;
                this.OnUserGroupChanged();
                this.OnPropertyChanged("UserGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UserGroup _UserGroup;
        partial void OnUserGroupChanging(global::Microsoft.Dynamics.DataEntities.UserGroup value);
        partial void OnUserGroupChanged();
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
