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
        /// There are no comments for PremiumEarningCodeSingle in the schema.
        /// </summary>
    public partial class PremiumEarningCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PremiumEarningCode>
    {
        /// <summary>
        /// Initialize a new PremiumEarningCodeSingle object.
        /// </summary>
        public PremiumEarningCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PremiumEarningCodeSingle object.
        /// </summary>
        public PremiumEarningCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PremiumEarningCodeSingle object.
        /// </summary>
        public PremiumEarningCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PremiumEarningCode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EarningStatementLineInquiry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> EarningStatementLineInquiry
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EarningStatementLineInquiry == null))
                {
                    this._EarningStatementLineInquiry = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry>(GetPath("EarningStatementLineInquiry"));
                }
                return this._EarningStatementLineInquiry;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> _EarningStatementLineInquiry;
        /// <summary>
        /// There are no comments for CalculationFrequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencySingle CalculationFrequency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CalculationFrequency == null))
                {
                    this._CalculationFrequency = new global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencySingle(this.Context, GetPath("CalculationFrequency"));
                }
                return this._CalculationFrequency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencySingle _CalculationFrequency;
    }
        /// <summary>
        /// There are no comments for PremiumEarningCode in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PremiumEarningCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PremiumEarningCode")]
    [global::Microsoft.OData.Client.EntitySet("PremiumEarningCodes")]
    public partial class PremiumEarningCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PremiumEarningCode object.
        /// </summary>
        /// <param name="premiumEarningCode1">Initial value of PremiumEarningCode1.</param>
        /// <param name="calculationFrequency">Initial value of CalculationFrequency.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PremiumEarningCode CreatePremiumEarningCode(string premiumEarningCode1, global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequency calculationFrequency)
        {
            PremiumEarningCode premiumEarningCode = new PremiumEarningCode();
            premiumEarningCode.PremiumEarningCode1 = premiumEarningCode1;
            if ((calculationFrequency == null))
            {
                throw new global::System.ArgumentNullException("calculationFrequency");
            }
            premiumEarningCode.CalculationFrequency = calculationFrequency;
            return premiumEarningCode;
        }
        /// <summary>
        /// There are no comments for Property PremiumEarningCode1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PremiumEarningCode")]
        public virtual string PremiumEarningCode1
        {
            get
            {
                return this._PremiumEarningCode1;
            }
            set
            {
                this.OnPremiumEarningCode1Changing(value);
                this._PremiumEarningCode1 = value;
                this.OnPremiumEarningCode1Changed();
                this.OnPropertyChanged("PremiumEarningCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PremiumEarningCode1;
        partial void OnPremiumEarningCode1Changing(string value);
        partial void OnPremiumEarningCode1Changed();
        /// <summary>
        /// There are no comments for Property EarningCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EarningCodeId
        {
            get
            {
                return this._EarningCodeId;
            }
            set
            {
                this.OnEarningCodeIdChanging(value);
                this._EarningCodeId = value;
                this.OnEarningCodeIdChanged();
                this.OnPropertyChanged("EarningCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EarningCodeId;
        partial void OnEarningCodeIdChanging(string value);
        partial void OnEarningCodeIdChanged();
        /// <summary>
        /// There are no comments for Property CalculationFrequencyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CalculationFrequencyId
        {
            get
            {
                return this._CalculationFrequencyId;
            }
            set
            {
                this.OnCalculationFrequencyIdChanging(value);
                this._CalculationFrequencyId = value;
                this.OnCalculationFrequencyIdChanged();
                this.OnPropertyChanged("CalculationFrequencyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CalculationFrequencyId;
        partial void OnCalculationFrequencyIdChanging(string value);
        partial void OnCalculationFrequencyIdChanged();
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
        /// There are no comments for Property PayoutBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPayoutBasis> PayoutBasis
        {
            get
            {
                return this._PayoutBasis;
            }
            set
            {
                this.OnPayoutBasisChanging(value);
                this._PayoutBasis = value;
                this.OnPayoutBasisChanged();
                this.OnPropertyChanged("PayoutBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPayoutBasis> _PayoutBasis;
        partial void OnPayoutBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPayoutBasis> value);
        partial void OnPayoutBasisChanged();
        /// <summary>
        /// There are no comments for Property PolicyRuleTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PolicyRuleTypeId
        {
            get
            {
                return this._PolicyRuleTypeId;
            }
            set
            {
                this.OnPolicyRuleTypeIdChanging(value);
                this._PolicyRuleTypeId = value;
                this.OnPolicyRuleTypeIdChanged();
                this.OnPropertyChanged("PolicyRuleTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PolicyRuleTypeId;
        partial void OnPolicyRuleTypeIdChanging(string value);
        partial void OnPolicyRuleTypeIdChanged();
        /// <summary>
        /// There are no comments for Property PolicyTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SysPolicyTypeEnum> PolicyTypeId
        {
            get
            {
                return this._PolicyTypeId;
            }
            set
            {
                this.OnPolicyTypeIdChanging(value);
                this._PolicyTypeId = value;
                this.OnPolicyTypeIdChanged();
                this.OnPropertyChanged("PolicyTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SysPolicyTypeEnum> _PolicyTypeId;
        partial void OnPolicyTypeIdChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SysPolicyTypeEnum> value);
        partial void OnPolicyTypeIdChanged();
        /// <summary>
        /// There are no comments for Property EarningStatementLineInquiry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> EarningStatementLineInquiry
        {
            get
            {
                return this._EarningStatementLineInquiry;
            }
            set
            {
                this.OnEarningStatementLineInquiryChanging(value);
                this._EarningStatementLineInquiry = value;
                this.OnEarningStatementLineInquiryChanged();
                this.OnPropertyChanged("EarningStatementLineInquiry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> _EarningStatementLineInquiry = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEarningStatementLineInquiryChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> value);
        partial void OnEarningStatementLineInquiryChanged();
        /// <summary>
        /// There are no comments for Property CalculationFrequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequency CalculationFrequency
        {
            get
            {
                return this._CalculationFrequency;
            }
            set
            {
                this.OnCalculationFrequencyChanging(value);
                this._CalculationFrequency = value;
                this.OnCalculationFrequencyChanged();
                this.OnPropertyChanged("CalculationFrequency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequency _CalculationFrequency;
        partial void OnCalculationFrequencyChanging(global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequency value);
        partial void OnCalculationFrequencyChanged();
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
