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
        /// There are no comments for EngineeringProductVersionNumberingRuleSingle in the schema.
        /// </summary>
    public partial class EngineeringProductVersionNumberingRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringProductVersionNumberingRule>
    {
        /// <summary>
        /// Initialize a new EngineeringProductVersionNumberingRuleSingle object.
        /// </summary>
        public EngineeringProductVersionNumberingRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringProductVersionNumberingRuleSingle object.
        /// </summary>
        public EngineeringProductVersionNumberingRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringProductVersionNumberingRuleSingle object.
        /// </summary>
        public EngineeringProductVersionNumberingRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringProductVersionNumberingRule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringProductCategoryDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> EngineeringProductCategoryDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringProductCategoryDetails == null))
                {
                    this._EngineeringProductCategoryDetails = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails>(GetPath("EngineeringProductCategoryDetails"));
                }
                return this._EngineeringProductCategoryDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> _EngineeringProductCategoryDetails;
        /// <summary>
        /// There are no comments for ProductEngineeringVersionNumberingRuleListMembers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionNumberingRuleListMember> ProductEngineeringVersionNumberingRuleListMembers
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductEngineeringVersionNumberingRuleListMembers == null))
                {
                    this._ProductEngineeringVersionNumberingRuleListMembers = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionNumberingRuleListMember>(GetPath("ProductEngineeringVersionNumberingRuleListMembers"));
                }
                return this._ProductEngineeringVersionNumberingRuleListMembers;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionNumberingRuleListMember> _ProductEngineeringVersionNumberingRuleListMembers;
    }
        /// <summary>
        /// There are no comments for EngineeringProductVersionNumberingRule in the schema.
        /// </summary>
    /// <KeyProperties>
    /// RuleName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RuleName")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringProductVersionNumberingRules")]
    public partial class EngineeringProductVersionNumberingRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringProductVersionNumberingRule object.
        /// </summary>
        /// <param name="ruleName">Initial value of RuleName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringProductVersionNumberingRule CreateEngineeringProductVersionNumberingRule(string ruleName)
        {
            EngineeringProductVersionNumberingRule engineeringProductVersionNumberingRule = new EngineeringProductVersionNumberingRule();
            engineeringProductVersionNumberingRule.RuleName = ruleName;
            return engineeringProductVersionNumberingRule;
        }
        /// <summary>
        /// There are no comments for Property RuleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RuleName
        {
            get
            {
                return this._RuleName;
            }
            set
            {
                this.OnRuleNameChanging(value);
                this._RuleName = value;
                this.OnRuleNameChanged();
                this.OnPropertyChanged("RuleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RuleName;
        partial void OnRuleNameChanging(string value);
        partial void OnRuleNameChanged();
        /// <summary>
        /// There are no comments for Property RuleType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgVersionNumberRuleType> RuleType
        {
            get
            {
                return this._RuleType;
            }
            set
            {
                this.OnRuleTypeChanging(value);
                this._RuleType = value;
                this.OnRuleTypeChanged();
                this.OnPropertyChanged("RuleType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgVersionNumberRuleType> _RuleType;
        partial void OnRuleTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgVersionNumberRuleType> value);
        partial void OnRuleTypeChanged();
        /// <summary>
        /// There are no comments for Property AutoNumberingFormat in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AutoNumberingFormat
        {
            get
            {
                return this._AutoNumberingFormat;
            }
            set
            {
                this.OnAutoNumberingFormatChanging(value);
                this._AutoNumberingFormat = value;
                this.OnAutoNumberingFormatChanged();
                this.OnPropertyChanged("AutoNumberingFormat");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AutoNumberingFormat;
        partial void OnAutoNumberingFormatChanging(string value);
        partial void OnAutoNumberingFormatChanged();
        /// <summary>
        /// There are no comments for Property EngineeringProductCategoryDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> EngineeringProductCategoryDetails
        {
            get
            {
                return this._EngineeringProductCategoryDetails;
            }
            set
            {
                this.OnEngineeringProductCategoryDetailsChanging(value);
                this._EngineeringProductCategoryDetails = value;
                this.OnEngineeringProductCategoryDetailsChanged();
                this.OnPropertyChanged("EngineeringProductCategoryDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> _EngineeringProductCategoryDetails = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringProductCategoryDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> value);
        partial void OnEngineeringProductCategoryDetailsChanged();
        /// <summary>
        /// There are no comments for Property ProductEngineeringVersionNumberingRuleListMembers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionNumberingRuleListMember> ProductEngineeringVersionNumberingRuleListMembers
        {
            get
            {
                return this._ProductEngineeringVersionNumberingRuleListMembers;
            }
            set
            {
                this.OnProductEngineeringVersionNumberingRuleListMembersChanging(value);
                this._ProductEngineeringVersionNumberingRuleListMembers = value;
                this.OnProductEngineeringVersionNumberingRuleListMembersChanged();
                this.OnPropertyChanged("ProductEngineeringVersionNumberingRuleListMembers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionNumberingRuleListMember> _ProductEngineeringVersionNumberingRuleListMembers = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionNumberingRuleListMember>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductEngineeringVersionNumberingRuleListMembersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionNumberingRuleListMember> value);
        partial void OnProductEngineeringVersionNumberingRuleListMembersChanged();
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
