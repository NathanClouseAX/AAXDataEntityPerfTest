﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/8/2020 8:07:52 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for BenefitEligibilityRuleSingle in the schema.
        /// </summary>
    public partial class BenefitEligibilityRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitEligibilityRule>
    {
        /// <summary>
        /// Initialize a new BenefitEligibilityRuleSingle object.
        /// </summary>
        public BenefitEligibilityRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitEligibilityRuleSingle object.
        /// </summary>
        public BenefitEligibilityRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitEligibilityRuleSingle object.
        /// </summary>
        public BenefitEligibilityRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitEligibilityRule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BenefitEligibilityPolicy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicySingle BenefitEligibilityPolicy
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitEligibilityPolicy == null))
                {
                    this._BenefitEligibilityPolicy = new global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicySingle(this.Context, GetPath("BenefitEligibilityPolicy"));
                }
                return this._BenefitEligibilityPolicy;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicySingle _BenefitEligibilityPolicy;
        /// <summary>
        /// There are no comments for BenefitEligibilityPolicyRuleType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicyRuleTypeSingle BenefitEligibilityPolicyRuleType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitEligibilityPolicyRuleType == null))
                {
                    this._BenefitEligibilityPolicyRuleType = new global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicyRuleTypeSingle(this.Context, GetPath("BenefitEligibilityPolicyRuleType"));
                }
                return this._BenefitEligibilityPolicyRuleType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicyRuleTypeSingle _BenefitEligibilityPolicyRuleType;
    }
        /// <summary>
        /// There are no comments for BenefitEligibilityRule in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PolicyName
    /// PolicyRulesName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PolicyName", "PolicyRulesName")]
    [global::Microsoft.OData.Client.EntitySet("BenefitEligibilityRules")]
    public partial class BenefitEligibilityRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitEligibilityRule object.
        /// </summary>
        /// <param name="policyName">Initial value of PolicyName.</param>
        /// <param name="policyRulesName">Initial value of PolicyRulesName.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="expressionId">Initial value of ExpressionId.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="benefitEligibilityPolicy">Initial value of BenefitEligibilityPolicy.</param>
        /// <param name="benefitEligibilityPolicyRuleType">Initial value of BenefitEligibilityPolicyRuleType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitEligibilityRule CreateBenefitEligibilityRule(string policyName, 
                    string policyRulesName, 
                    global::System.DateTimeOffset validTo, 
                    global::System.Guid expressionId, 
                    global::System.DateTimeOffset validFrom, 
                    global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicy benefitEligibilityPolicy, 
                    global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicyRuleType benefitEligibilityPolicyRuleType)
        {
            BenefitEligibilityRule benefitEligibilityRule = new BenefitEligibilityRule();
            benefitEligibilityRule.PolicyName = policyName;
            benefitEligibilityRule.PolicyRulesName = policyRulesName;
            benefitEligibilityRule.ValidTo = validTo;
            benefitEligibilityRule.ExpressionId = expressionId;
            benefitEligibilityRule.ValidFrom = validFrom;
            if ((benefitEligibilityPolicy == null))
            {
                throw new global::System.ArgumentNullException("benefitEligibilityPolicy");
            }
            benefitEligibilityRule.BenefitEligibilityPolicy = benefitEligibilityPolicy;
            if ((benefitEligibilityPolicyRuleType == null))
            {
                throw new global::System.ArgumentNullException("benefitEligibilityPolicyRuleType");
            }
            benefitEligibilityRule.BenefitEligibilityPolicyRuleType = benefitEligibilityPolicyRuleType;
            return benefitEligibilityRule;
        }
        /// <summary>
        /// There are no comments for Property PolicyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PolicyName
        {
            get
            {
                return this._PolicyName;
            }
            set
            {
                this.OnPolicyNameChanging(value);
                this._PolicyName = value;
                this.OnPolicyNameChanged();
                this.OnPropertyChanged("PolicyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PolicyName;
        partial void OnPolicyNameChanging(string value);
        partial void OnPolicyNameChanged();
        /// <summary>
        /// There are no comments for Property PolicyRulesName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PolicyRulesName
        {
            get
            {
                return this._PolicyRulesName;
            }
            set
            {
                this.OnPolicyRulesNameChanging(value);
                this._PolicyRulesName = value;
                this.OnPolicyRulesNameChanged();
                this.OnPropertyChanged("PolicyRulesName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PolicyRulesName;
        partial void OnPolicyRulesNameChanging(string value);
        partial void OnPolicyRulesNameChanged();
        /// <summary>
        /// There are no comments for Property IsInherited in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsInherited
        {
            get
            {
                return this._IsInherited;
            }
            set
            {
                this.OnIsInheritedChanging(value);
                this._IsInherited = value;
                this.OnIsInheritedChanged();
                this.OnPropertyChanged("IsInherited");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsInherited;
        partial void OnIsInheritedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsInheritedChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property ExpressionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid ExpressionId
        {
            get
            {
                return this._ExpressionId;
            }
            set
            {
                this.OnExpressionIdChanging(value);
                this._ExpressionId = value;
                this.OnExpressionIdChanged();
                this.OnPropertyChanged("ExpressionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ExpressionId;
        partial void OnExpressionIdChanging(global::System.Guid value);
        partial void OnExpressionIdChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property BenefitEligibilityPolicy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicy BenefitEligibilityPolicy
        {
            get
            {
                return this._BenefitEligibilityPolicy;
            }
            set
            {
                this.OnBenefitEligibilityPolicyChanging(value);
                this._BenefitEligibilityPolicy = value;
                this.OnBenefitEligibilityPolicyChanged();
                this.OnPropertyChanged("BenefitEligibilityPolicy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicy _BenefitEligibilityPolicy;
        partial void OnBenefitEligibilityPolicyChanging(global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicy value);
        partial void OnBenefitEligibilityPolicyChanged();
        /// <summary>
        /// There are no comments for Property BenefitEligibilityPolicyRuleType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicyRuleType BenefitEligibilityPolicyRuleType
        {
            get
            {
                return this._BenefitEligibilityPolicyRuleType;
            }
            set
            {
                this.OnBenefitEligibilityPolicyRuleTypeChanging(value);
                this._BenefitEligibilityPolicyRuleType = value;
                this.OnBenefitEligibilityPolicyRuleTypeChanged();
                this.OnPropertyChanged("BenefitEligibilityPolicyRuleType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicyRuleType _BenefitEligibilityPolicyRuleType;
        partial void OnBenefitEligibilityPolicyRuleTypeChanging(global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicyRuleType value);
        partial void OnBenefitEligibilityPolicyRuleTypeChanged();
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