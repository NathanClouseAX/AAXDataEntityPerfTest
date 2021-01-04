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
        /// There are no comments for BenefitHcmDetailSingle in the schema.
        /// </summary>
    public partial class BenefitHcmDetailSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitHcmDetail>
    {
        /// <summary>
        /// Initialize a new BenefitHcmDetailSingle object.
        /// </summary>
        public BenefitHcmDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitHcmDetailSingle object.
        /// </summary>
        public BenefitHcmDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitHcmDetailSingle object.
        /// </summary>
        public BenefitHcmDetailSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitHcmDetail> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Benefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitSingle Benefit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Benefit == null))
                {
                    this._Benefit = new global::Microsoft.Dynamics.DataEntities.BenefitSingle(this.Context, GetPath("Benefit"));
                }
                return this._Benefit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitSingle _Benefit;
        /// <summary>
        /// There are no comments for PolicyRuleType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicyRuleTypeSingle PolicyRuleType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PolicyRuleType == null))
                {
                    this._PolicyRuleType = new global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicyRuleTypeSingle(this.Context, GetPath("PolicyRuleType"));
                }
                return this._PolicyRuleType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicyRuleTypeSingle _PolicyRuleType;
    }
        /// <summary>
        /// There are no comments for BenefitHcmDetail in the schema.
        /// </summary>
    /// <KeyProperties>
    /// BenefitId
    /// Effective
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BenefitId", "Effective")]
    [global::Microsoft.OData.Client.EntitySet("BenefitHcmDetails")]
    public partial class BenefitHcmDetail : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitHcmDetail object.
        /// </summary>
        /// <param name="benefitId">Initial value of BenefitId.</param>
        /// <param name="effective">Initial value of Effective.</param>
        /// <param name="expiration">Initial value of Expiration.</param>
        /// <param name="benefit">Initial value of Benefit.</param>
        /// <param name="policyRuleType">Initial value of PolicyRuleType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitHcmDetail CreateBenefitHcmDetail(string benefitId, global::System.DateTimeOffset effective, global::System.DateTimeOffset expiration, global::Microsoft.Dynamics.DataEntities.Benefit benefit, global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicyRuleType policyRuleType)
        {
            BenefitHcmDetail benefitHcmDetail = new BenefitHcmDetail();
            benefitHcmDetail.BenefitId = benefitId;
            benefitHcmDetail.Effective = effective;
            benefitHcmDetail.Expiration = expiration;
            if ((benefit == null))
            {
                throw new global::System.ArgumentNullException("benefit");
            }
            benefitHcmDetail.Benefit = benefit;
            if ((policyRuleType == null))
            {
                throw new global::System.ArgumentNullException("policyRuleType");
            }
            benefitHcmDetail.PolicyRuleType = policyRuleType;
            return benefitHcmDetail;
        }
        /// <summary>
        /// There are no comments for Property BenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BenefitId
        {
            get
            {
                return this._BenefitId;
            }
            set
            {
                this.OnBenefitIdChanging(value);
                this._BenefitId = value;
                this.OnBenefitIdChanged();
                this.OnPropertyChanged("BenefitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitId;
        partial void OnBenefitIdChanging(string value);
        partial void OnBenefitIdChanged();
        /// <summary>
        /// There are no comments for Property Effective in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset Effective
        {
            get
            {
                return this._Effective;
            }
            set
            {
                this.OnEffectiveChanging(value);
                this._Effective = value;
                this.OnEffectiveChanged();
                this.OnPropertyChanged("Effective");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Effective;
        partial void OnEffectiveChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveChanged();
        /// <summary>
        /// There are no comments for Property Eligibility in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmBenefitEligibilityType> Eligibility
        {
            get
            {
                return this._Eligibility;
            }
            set
            {
                this.OnEligibilityChanging(value);
                this._Eligibility = value;
                this.OnEligibilityChanged();
                this.OnPropertyChanged("Eligibility");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmBenefitEligibilityType> _Eligibility;
        partial void OnEligibilityChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmBenefitEligibilityType> value);
        partial void OnEligibilityChanged();
        /// <summary>
        /// There are no comments for Property Expiration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset Expiration
        {
            get
            {
                return this._Expiration;
            }
            set
            {
                this.OnExpirationChanging(value);
                this._Expiration = value;
                this.OnExpirationChanged();
                this.OnPropertyChanged("Expiration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Expiration;
        partial void OnExpirationChanging(global::System.DateTimeOffset value);
        partial void OnExpirationChanged();
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
        /// There are no comments for Property Benefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Benefit Benefit
        {
            get
            {
                return this._Benefit;
            }
            set
            {
                this.OnBenefitChanging(value);
                this._Benefit = value;
                this.OnBenefitChanged();
                this.OnPropertyChanged("Benefit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Benefit _Benefit;
        partial void OnBenefitChanging(global::Microsoft.Dynamics.DataEntities.Benefit value);
        partial void OnBenefitChanged();
        /// <summary>
        /// There are no comments for Property PolicyRuleType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicyRuleType PolicyRuleType
        {
            get
            {
                return this._PolicyRuleType;
            }
            set
            {
                this.OnPolicyRuleTypeChanging(value);
                this._PolicyRuleType = value;
                this.OnPolicyRuleTypeChanged();
                this.OnPropertyChanged("PolicyRuleType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicyRuleType _PolicyRuleType;
        partial void OnPolicyRuleTypeChanging(global::Microsoft.Dynamics.DataEntities.BenefitEligibilityPolicyRuleType value);
        partial void OnPolicyRuleTypeChanged();
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
