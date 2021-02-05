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
        /// There are no comments for BenefitExternalReportingSingle in the schema.
        /// </summary>
    public partial class BenefitExternalReportingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitExternalReporting>
    {
        /// <summary>
        /// Initialize a new BenefitExternalReportingSingle object.
        /// </summary>
        public BenefitExternalReportingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitExternalReportingSingle object.
        /// </summary>
        public BenefitExternalReportingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitExternalReportingSingle object.
        /// </summary>
        public BenefitExternalReportingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitExternalReporting> query)
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
        /// There are no comments for AddressCountryRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle AddressCountryRegion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AddressCountryRegion == null))
                {
                    this._AddressCountryRegion = new global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle(this.Context, GetPath("AddressCountryRegion"));
                }
                return this._AddressCountryRegion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle _AddressCountryRegion;
    }
        /// <summary>
        /// There are no comments for BenefitExternalReporting in the schema.
        /// </summary>
    /// <KeyProperties>
    /// BenefitPlanID
    /// ValidFrom
    /// ValidTo
    /// CountryRegionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BenefitPlanID", "ValidFrom", "ValidTo", "CountryRegionId")]
    [global::Microsoft.OData.Client.EntitySet("BenefitExternalReportings")]
    public partial class BenefitExternalReporting : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitExternalReporting object.
        /// </summary>
        /// <param name="benefitPlanID">Initial value of BenefitPlanID.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="countryRegionId">Initial value of CountryRegionId.</param>
        /// <param name="benefitPlan">Initial value of BenefitPlan.</param>
        /// <param name="addressCountryRegion">Initial value of AddressCountryRegion.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitExternalReporting CreateBenefitExternalReporting(string benefitPlanID, 
                    global::System.DateTimeOffset validFrom, 
                    global::System.DateTimeOffset validTo, 
                    string countryRegionId, 
                    global::Microsoft.Dynamics.DataEntities.BenefitPlan benefitPlan, 
                    global::Microsoft.Dynamics.DataEntities.AddressCountryRegion addressCountryRegion)
        {
            BenefitExternalReporting benefitExternalReporting = new BenefitExternalReporting();
            benefitExternalReporting.BenefitPlanID = benefitPlanID;
            benefitExternalReporting.ValidFrom = validFrom;
            benefitExternalReporting.ValidTo = validTo;
            benefitExternalReporting.CountryRegionId = countryRegionId;
            if ((benefitPlan == null))
            {
                throw new global::System.ArgumentNullException("benefitPlan");
            }
            benefitExternalReporting.BenefitPlan = benefitPlan;
            if ((addressCountryRegion == null))
            {
                throw new global::System.ArgumentNullException("addressCountryRegion");
            }
            benefitExternalReporting.AddressCountryRegion = addressCountryRegion;
            return benefitExternalReporting;
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
        /// There are no comments for Property CountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CountryRegionId
        {
            get
            {
                return this._CountryRegionId;
            }
            set
            {
                this.OnCountryRegionIdChanging(value);
                this._CountryRegionId = value;
                this.OnCountryRegionIdChanged();
                this.OnPropertyChanged("CountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionId;
        partial void OnCountryRegionIdChanging(string value);
        partial void OnCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property W2BoxNumberContribution in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollW2BoxNumber> W2BoxNumberContribution
        {
            get
            {
                return this._W2BoxNumberContribution;
            }
            set
            {
                this.OnW2BoxNumberContributionChanging(value);
                this._W2BoxNumberContribution = value;
                this.OnW2BoxNumberContributionChanged();
                this.OnPropertyChanged("W2BoxNumberContribution");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollW2BoxNumber> _W2BoxNumberContribution;
        partial void OnW2BoxNumberContributionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollW2BoxNumber> value);
        partial void OnW2BoxNumberContributionChanged();
        /// <summary>
        /// There are no comments for Property W2BoxNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollW2BoxNumber> W2BoxNumber
        {
            get
            {
                return this._W2BoxNumber;
            }
            set
            {
                this.OnW2BoxNumberChanging(value);
                this._W2BoxNumber = value;
                this.OnW2BoxNumberChanged();
                this.OnPropertyChanged("W2BoxNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollW2BoxNumber> _W2BoxNumber;
        partial void OnW2BoxNumberChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollW2BoxNumber> value);
        partial void OnW2BoxNumberChanged();
        /// <summary>
        /// There are no comments for Property W2BoxLabelContribution in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string W2BoxLabelContribution
        {
            get
            {
                return this._W2BoxLabelContribution;
            }
            set
            {
                this.OnW2BoxLabelContributionChanging(value);
                this._W2BoxLabelContribution = value;
                this.OnW2BoxLabelContributionChanged();
                this.OnPropertyChanged("W2BoxLabelContribution");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _W2BoxLabelContribution;
        partial void OnW2BoxLabelContributionChanging(string value);
        partial void OnW2BoxLabelContributionChanged();
        /// <summary>
        /// There are no comments for Property W2BoxLabel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string W2BoxLabel
        {
            get
            {
                return this._W2BoxLabel;
            }
            set
            {
                this.OnW2BoxLabelChanging(value);
                this._W2BoxLabel = value;
                this.OnW2BoxLabelChanged();
                this.OnPropertyChanged("W2BoxLabel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _W2BoxLabel;
        partial void OnW2BoxLabelChanging(string value);
        partial void OnW2BoxLabelChanged();
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
        /// There are no comments for Property AddressCountryRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCountryRegion AddressCountryRegion
        {
            get
            {
                return this._AddressCountryRegion;
            }
            set
            {
                this.OnAddressCountryRegionChanging(value);
                this._AddressCountryRegion = value;
                this.OnAddressCountryRegionChanged();
                this.OnPropertyChanged("AddressCountryRegion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCountryRegion _AddressCountryRegion;
        partial void OnAddressCountryRegionChanging(global::Microsoft.Dynamics.DataEntities.AddressCountryRegion value);
        partial void OnAddressCountryRegionChanged();
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
