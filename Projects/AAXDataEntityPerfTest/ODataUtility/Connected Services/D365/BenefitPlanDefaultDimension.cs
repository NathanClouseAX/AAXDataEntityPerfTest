﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/28/2021 8:55:09 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for BenefitPlanDefaultDimensionSingle in the schema.
    /// </summary>
    public partial class BenefitPlanDefaultDimensionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitPlanDefaultDimension>
    {
        /// <summary>
        /// Initialize a new BenefitPlanDefaultDimensionSingle object.
        /// </summary>
        public BenefitPlanDefaultDimensionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitPlanDefaultDimensionSingle object.
        /// </summary>
        public BenefitPlanDefaultDimensionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitPlanDefaultDimensionSingle object.
        /// </summary>
        public BenefitPlanDefaultDimensionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitPlanDefaultDimension> query)
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
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
    /// <summary>
    /// There are no comments for BenefitPlanDefaultDimension in the schema.
    /// </summary>
    /// <KeyProperties>
    /// BenefitPlanId
    /// LegalEntityId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BenefitPlanId", "LegalEntityId")]
    [global::Microsoft.OData.Client.EntitySet("BenefitPlanDefaultDimensions")]
    public partial class BenefitPlanDefaultDimension : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitPlanDefaultDimension object.
        /// </summary>
        /// <param name="benefitPlanId">Initial value of BenefitPlanId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="benefitPlan">Initial value of BenefitPlan.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitPlanDefaultDimension CreateBenefitPlanDefaultDimension(string benefitPlanId, string legalEntityId, global::Microsoft.Dynamics.DataEntities.BenefitPlan benefitPlan)
        {
            BenefitPlanDefaultDimension benefitPlanDefaultDimension = new BenefitPlanDefaultDimension();
            benefitPlanDefaultDimension.BenefitPlanId = benefitPlanId;
            benefitPlanDefaultDimension.LegalEntityId = legalEntityId;
            if ((benefitPlan == null))
            {
                throw new global::System.ArgumentNullException("benefitPlan");
            }
            benefitPlanDefaultDimension.BenefitPlan = benefitPlan;
            return benefitPlanDefaultDimension;
        }
        /// <summary>
        /// There are no comments for Property BenefitPlanId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BenefitPlanId is required.")]
        public virtual string BenefitPlanId
        {
            get
            {
                return this._BenefitPlanId;
            }
            set
            {
                this.OnBenefitPlanIdChanging(value);
                this._BenefitPlanId = value;
                this.OnBenefitPlanIdChanged();
                this.OnPropertyChanged("BenefitPlanId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitPlanId;
        partial void OnBenefitPlanIdChanging(string value);
        partial void OnBenefitPlanIdChanged();
        /// <summary>
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LegalEntityId is required.")]
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
        /// There are no comments for Property Vendor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string Vendor
        {
            get
            {
                return this._Vendor;
            }
            set
            {
                this.OnVendorChanging(value);
                this._Vendor = value;
                this.OnVendorChanged();
                this.OnPropertyChanged("Vendor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Vendor;
        partial void OnVendorChanging(string value);
        partial void OnVendorChanged();
        /// <summary>
        /// There are no comments for Property DefaultFinancialDimensionsDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string DefaultFinancialDimensionsDisplayValue
        {
            get
            {
                return this._DefaultFinancialDimensionsDisplayValue;
            }
            set
            {
                this.OnDefaultFinancialDimensionsDisplayValueChanging(value);
                this._DefaultFinancialDimensionsDisplayValue = value;
                this.OnDefaultFinancialDimensionsDisplayValueChanged();
                this.OnPropertyChanged("DefaultFinancialDimensionsDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultFinancialDimensionsDisplayValue;
        partial void OnDefaultFinancialDimensionsDisplayValueChanging(string value);
        partial void OnDefaultFinancialDimensionsDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property Category in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this.OnCategoryChanging(value);
                this._Category = value;
                this.OnCategoryChanged();
                this.OnPropertyChanged("Category");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Category;
        partial void OnCategoryChanging(string value);
        partial void OnCategoryChanged();
        /// <summary>
        /// There are no comments for Property BenefitPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BenefitPlan is required.")]
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
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
