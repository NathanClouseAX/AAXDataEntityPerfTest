﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 7/17/2021 8:49:18 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for RetailReplenishmentRuleSingle in the schema.
        /// </summary>
    public partial class RetailReplenishmentRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailReplenishmentRule>
    {
        /// <summary>
        /// Initialize a new RetailReplenishmentRuleSingle object.
        /// </summary>
        public RetailReplenishmentRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailReplenishmentRuleSingle object.
        /// </summary>
        public RetailReplenishmentRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailReplenishmentRuleSingle object.
        /// </summary>
        public RetailReplenishmentRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailReplenishmentRule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailServiceCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailServiceCategory> RetailServiceCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailServiceCategory == null))
                {
                    this._RetailServiceCategory = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailServiceCategory>(GetPath("RetailServiceCategory"));
                }
                return this._RetailServiceCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailServiceCategory> _RetailServiceCategory;
        /// <summary>
        /// There are no comments for ReplenishmentRuleLinesV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReplenishmentRuleLinesV2Single ReplenishmentRuleLinesV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReplenishmentRuleLinesV2 == null))
                {
                    this._ReplenishmentRuleLinesV2 = new global::Microsoft.Dynamics.DataEntities.ReplenishmentRuleLinesV2Single(this.Context, GetPath("ReplenishmentRuleLinesV2"));
                }
                return this._ReplenishmentRuleLinesV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReplenishmentRuleLinesV2Single _ReplenishmentRuleLinesV2;
    }
        /// <summary>
        /// There are no comments for RetailReplenishmentRule in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ReplenishmentRule
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ReplenishmentRule")]
    [global::Microsoft.OData.Client.EntitySet("RetailReplenishmentRules")]
    public partial class RetailReplenishmentRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailReplenishmentRule object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="replenishmentRule">Initial value of ReplenishmentRule.</param>
        /// <param name="replenishmentRuleLinesV2">Initial value of ReplenishmentRuleLinesV2.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailReplenishmentRule CreateRetailReplenishmentRule(string dataAreaId, string replenishmentRule, global::Microsoft.Dynamics.DataEntities.ReplenishmentRuleLinesV2 replenishmentRuleLinesV2)
        {
            RetailReplenishmentRule retailReplenishmentRule = new RetailReplenishmentRule();
            retailReplenishmentRule.dataAreaId = dataAreaId;
            retailReplenishmentRule.ReplenishmentRule = replenishmentRule;
            if ((replenishmentRuleLinesV2 == null))
            {
                throw new global::System.ArgumentNullException("replenishmentRuleLinesV2");
            }
            retailReplenishmentRule.ReplenishmentRuleLinesV2 = replenishmentRuleLinesV2;
            return retailReplenishmentRule;
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
        /// There are no comments for Property ReplenishmentRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReplenishmentRule
        {
            get
            {
                return this._ReplenishmentRule;
            }
            set
            {
                this.OnReplenishmentRuleChanging(value);
                this._ReplenishmentRule = value;
                this.OnReplenishmentRuleChanged();
                this.OnPropertyChanged("ReplenishmentRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReplenishmentRule;
        partial void OnReplenishmentRuleChanging(string value);
        partial void OnReplenishmentRuleChanged();
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
        /// There are no comments for Property RetailServiceCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailServiceCategory> RetailServiceCategory
        {
            get
            {
                return this._RetailServiceCategory;
            }
            set
            {
                this.OnRetailServiceCategoryChanging(value);
                this._RetailServiceCategory = value;
                this.OnRetailServiceCategoryChanged();
                this.OnPropertyChanged("RetailServiceCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailServiceCategory> _RetailServiceCategory = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailServiceCategory>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailServiceCategoryChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailServiceCategory> value);
        partial void OnRetailServiceCategoryChanged();
        /// <summary>
        /// There are no comments for Property ReplenishmentRuleLinesV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReplenishmentRuleLinesV2 ReplenishmentRuleLinesV2
        {
            get
            {
                return this._ReplenishmentRuleLinesV2;
            }
            set
            {
                this.OnReplenishmentRuleLinesV2Changing(value);
                this._ReplenishmentRuleLinesV2 = value;
                this.OnReplenishmentRuleLinesV2Changed();
                this.OnPropertyChanged("ReplenishmentRuleLinesV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReplenishmentRuleLinesV2 _ReplenishmentRuleLinesV2;
        partial void OnReplenishmentRuleLinesV2Changing(global::Microsoft.Dynamics.DataEntities.ReplenishmentRuleLinesV2 value);
        partial void OnReplenishmentRuleLinesV2Changed();
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
