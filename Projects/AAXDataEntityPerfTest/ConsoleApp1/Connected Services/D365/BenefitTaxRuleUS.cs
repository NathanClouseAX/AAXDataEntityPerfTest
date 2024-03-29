﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:24:13 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for BenefitTaxRuleUSSingle in the schema.
    /// </summary>
    public partial class BenefitTaxRuleUSSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitTaxRuleUS>
    {
        /// <summary>
        /// Initialize a new BenefitTaxRuleUSSingle object.
        /// </summary>
        public BenefitTaxRuleUSSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitTaxRuleUSSingle object.
        /// </summary>
        public BenefitTaxRuleUSSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitTaxRuleUSSingle object.
        /// </summary>
        public BenefitTaxRuleUSSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitTaxRuleUS> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BenefitPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitPlanSingle BenefitPlan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitPlan == null))
                {
                    this._BenefitPlan = new global::Microsoft.Dynamics.DataEntities.BenefitPlanSingle(this.Context, GetPath("BenefitPlan"));
                }
                return this._BenefitPlan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitPlanSingle _BenefitPlan;
        /// <summary>
        /// There are no comments for PayrollTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollTaxGroupSingle PayrollTaxGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollTaxGroup == null))
                {
                    this._PayrollTaxGroup = new global::Microsoft.Dynamics.DataEntities.PayrollTaxGroupSingle(this.Context, GetPath("PayrollTaxGroup"));
                }
                return this._PayrollTaxGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollTaxGroupSingle _PayrollTaxGroup;
    }
    /// <summary>
    /// There are no comments for BenefitTaxRuleUS in the schema.
    /// </summary>
    /// <KeyProperties>
    /// BenefitPlanID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BenefitPlanID")]
    [global::Microsoft.OData.Client.EntitySet("BenefitTaxRulesUS")]
    public partial class BenefitTaxRuleUS : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitTaxRuleUS object.
        /// </summary>
        /// <param name="benefitPlanID">Initial value of BenefitPlanID.</param>
        /// <param name="benefitPlan">Initial value of BenefitPlan.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitTaxRuleUS CreateBenefitTaxRuleUS(string benefitPlanID, global::Microsoft.Dynamics.DataEntities.BenefitPlan benefitPlan)
        {
            BenefitTaxRuleUS benefitTaxRuleUS = new BenefitTaxRuleUS();
            benefitTaxRuleUS.BenefitPlanID = benefitPlanID;
            if ((benefitPlan == null))
            {
                throw new global::System.ArgumentNullException("benefitPlan");
            }
            benefitTaxRuleUS.BenefitPlan = benefitPlan;
            return benefitTaxRuleUS;
        }
        /// <summary>
        /// There are no comments for Property BenefitPlanID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BenefitPlanID
        {
            get
            {
                return this._BenefitPlanID;
            }
            set
            {
                this.OnBenefitPlanIDChanging(value);
                this._BenefitPlanID = value;
                this.OnBenefitPlanIDChanged();
                this.OnPropertyChanged("BenefitPlanID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitPlanID;
        partial void OnBenefitPlanIDChanging(string value);
        partial void OnBenefitPlanIDChanged();
        /// <summary>
        /// There are no comments for Property IsExemptFromLocalIncomeTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsExemptFromLocalIncomeTax
        {
            get
            {
                return this._IsExemptFromLocalIncomeTax;
            }
            set
            {
                this.OnIsExemptFromLocalIncomeTaxChanging(value);
                this._IsExemptFromLocalIncomeTax = value;
                this.OnIsExemptFromLocalIncomeTaxChanged();
                this.OnPropertyChanged("IsExemptFromLocalIncomeTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsExemptFromLocalIncomeTax;
        partial void OnIsExemptFromLocalIncomeTaxChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsExemptFromLocalIncomeTaxChanged();
        /// <summary>
        /// There are no comments for Property IsExemptFromStateDisabilityInsurance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsExemptFromStateDisabilityInsurance
        {
            get
            {
                return this._IsExemptFromStateDisabilityInsurance;
            }
            set
            {
                this.OnIsExemptFromStateDisabilityInsuranceChanging(value);
                this._IsExemptFromStateDisabilityInsurance = value;
                this.OnIsExemptFromStateDisabilityInsuranceChanged();
                this.OnPropertyChanged("IsExemptFromStateDisabilityInsurance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsExemptFromStateDisabilityInsurance;
        partial void OnIsExemptFromStateDisabilityInsuranceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsExemptFromStateDisabilityInsuranceChanged();
        /// <summary>
        /// There are no comments for Property PreTaxBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPreTaxBasis> PreTaxBasis
        {
            get
            {
                return this._PreTaxBasis;
            }
            set
            {
                this.OnPreTaxBasisChanging(value);
                this._PreTaxBasis = value;
                this.OnPreTaxBasisChanged();
                this.OnPropertyChanged("PreTaxBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPreTaxBasis> _PreTaxBasis;
        partial void OnPreTaxBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPreTaxBasis> value);
        partial void OnPreTaxBasisChanged();
        /// <summary>
        /// There are no comments for Property IsExemptFromMedicare in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsExemptFromMedicare
        {
            get
            {
                return this._IsExemptFromMedicare;
            }
            set
            {
                this.OnIsExemptFromMedicareChanging(value);
                this._IsExemptFromMedicare = value;
                this.OnIsExemptFromMedicareChanged();
                this.OnPropertyChanged("IsExemptFromMedicare");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsExemptFromMedicare;
        partial void OnIsExemptFromMedicareChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsExemptFromMedicareChanged();
        /// <summary>
        /// There are no comments for Property IsExemptFromStateUnemployment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsExemptFromStateUnemployment
        {
            get
            {
                return this._IsExemptFromStateUnemployment;
            }
            set
            {
                this.OnIsExemptFromStateUnemploymentChanging(value);
                this._IsExemptFromStateUnemployment = value;
                this.OnIsExemptFromStateUnemploymentChanged();
                this.OnPropertyChanged("IsExemptFromStateUnemployment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsExemptFromStateUnemployment;
        partial void OnIsExemptFromStateUnemploymentChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsExemptFromStateUnemploymentChanged();
        /// <summary>
        /// There are no comments for Property IsExemptFromFederalIncomeTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsExemptFromFederalIncomeTax
        {
            get
            {
                return this._IsExemptFromFederalIncomeTax;
            }
            set
            {
                this.OnIsExemptFromFederalIncomeTaxChanging(value);
                this._IsExemptFromFederalIncomeTax = value;
                this.OnIsExemptFromFederalIncomeTaxChanged();
                this.OnPropertyChanged("IsExemptFromFederalIncomeTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsExemptFromFederalIncomeTax;
        partial void OnIsExemptFromFederalIncomeTaxChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsExemptFromFederalIncomeTaxChanged();
        /// <summary>
        /// There are no comments for Property IsExemptFromFICA in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsExemptFromFICA
        {
            get
            {
                return this._IsExemptFromFICA;
            }
            set
            {
                this.OnIsExemptFromFICAChanging(value);
                this._IsExemptFromFICA = value;
                this.OnIsExemptFromFICAChanged();
                this.OnPropertyChanged("IsExemptFromFICA");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsExemptFromFICA;
        partial void OnIsExemptFromFICAChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsExemptFromFICAChanged();
        /// <summary>
        /// There are no comments for Property TaxGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxGroupId
        {
            get
            {
                return this._TaxGroupId;
            }
            set
            {
                this.OnTaxGroupIdChanging(value);
                this._TaxGroupId = value;
                this.OnTaxGroupIdChanged();
                this.OnPropertyChanged("TaxGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxGroupId;
        partial void OnTaxGroupIdChanging(string value);
        partial void OnTaxGroupIdChanged();
        /// <summary>
        /// There are no comments for Property CustomPretaxMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollCustomPretaxMethod> CustomPretaxMethod
        {
            get
            {
                return this._CustomPretaxMethod;
            }
            set
            {
                this.OnCustomPretaxMethodChanging(value);
                this._CustomPretaxMethod = value;
                this.OnCustomPretaxMethodChanged();
                this.OnPropertyChanged("CustomPretaxMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollCustomPretaxMethod> _CustomPretaxMethod;
        partial void OnCustomPretaxMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollCustomPretaxMethod> value);
        partial void OnCustomPretaxMethodChanged();
        /// <summary>
        /// There are no comments for Property IsExemptFromStateIncomeTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsExemptFromStateIncomeTax
        {
            get
            {
                return this._IsExemptFromStateIncomeTax;
            }
            set
            {
                this.OnIsExemptFromStateIncomeTaxChanging(value);
                this._IsExemptFromStateIncomeTax = value;
                this.OnIsExemptFromStateIncomeTaxChanged();
                this.OnPropertyChanged("IsExemptFromStateIncomeTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsExemptFromStateIncomeTax;
        partial void OnIsExemptFromStateIncomeTaxChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsExemptFromStateIncomeTaxChanged();
        /// <summary>
        /// There are no comments for Property BenefitPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitPlan BenefitPlan
        {
            get
            {
                return this._BenefitPlan;
            }
            set
            {
                this.OnBenefitPlanChanging(value);
                this._BenefitPlan = value;
                this.OnBenefitPlanChanged();
                this.OnPropertyChanged("BenefitPlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitPlan _BenefitPlan;
        partial void OnBenefitPlanChanging(global::Microsoft.Dynamics.DataEntities.BenefitPlan value);
        partial void OnBenefitPlanChanged();
        /// <summary>
        /// There are no comments for Property PayrollTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollTaxGroup PayrollTaxGroup
        {
            get
            {
                return this._PayrollTaxGroup;
            }
            set
            {
                this.OnPayrollTaxGroupChanging(value);
                this._PayrollTaxGroup = value;
                this.OnPayrollTaxGroupChanged();
                this.OnPropertyChanged("PayrollTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollTaxGroup _PayrollTaxGroup;
        partial void OnPayrollTaxGroupChanging(global::Microsoft.Dynamics.DataEntities.PayrollTaxGroup value);
        partial void OnPayrollTaxGroupChanged();
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
