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
        /// There are no comments for RetailReplenishmentRuleLineSingle in the schema.
        /// </summary>
    public partial class RetailReplenishmentRuleLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailReplenishmentRuleLine>
    {
        /// <summary>
        /// Initialize a new RetailReplenishmentRuleLineSingle object.
        /// </summary>
        public RetailReplenishmentRuleLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailReplenishmentRuleLineSingle object.
        /// </summary>
        public RetailReplenishmentRuleLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailReplenishmentRuleLineSingle object.
        /// </summary>
        public RetailReplenishmentRuleLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailReplenishmentRuleLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailChannelSingle RetailChannel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailChannel == null))
                {
                    this._RetailChannel = new global::Microsoft.Dynamics.DataEntities.RetailChannelSingle(this.Context, GetPath("RetailChannel"));
                }
                return this._RetailChannel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailChannelSingle _RetailChannel;
        /// <summary>
        /// There are no comments for OrganizationHierarchyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OrganizationHierarchyTypeSingle OrganizationHierarchyType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OrganizationHierarchyType == null))
                {
                    this._OrganizationHierarchyType = new global::Microsoft.Dynamics.DataEntities.OrganizationHierarchyTypeSingle(this.Context, GetPath("OrganizationHierarchyType"));
                }
                return this._OrganizationHierarchyType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OrganizationHierarchyTypeSingle _OrganizationHierarchyType;
    }
        /// <summary>
        /// There are no comments for RetailReplenishmentRuleLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ReplenishmentRule
    /// Type
    /// ReplenishmentHierarchyTypeName
    /// ReplenishmentOrganizationPartyNumber
    /// ReplenishmentHierarchyValidFrom
    /// ReplenishmentHierarchyValidTo
    /// RetailChannelId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ReplenishmentRule", "Type", "ReplenishmentHierarchyTypeName", "ReplenishmentOrganizationPartyNumber", "ReplenishmentHierarchyValidFrom", "ReplenishmentHierarchyValidTo", "RetailChannelId")]
    [global::Microsoft.OData.Client.EntitySet("RetailReplenishmentRuleLines")]
    public partial class RetailReplenishmentRuleLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailReplenishmentRuleLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="replenishmentRule">Initial value of ReplenishmentRule.</param>
        /// <param name="replenishmentHierarchyTypeName">Initial value of ReplenishmentHierarchyTypeName.</param>
        /// <param name="replenishmentOrganizationPartyNumber">Initial value of ReplenishmentOrganizationPartyNumber.</param>
        /// <param name="replenishmentHierarchyValidFrom">Initial value of ReplenishmentHierarchyValidFrom.</param>
        /// <param name="replenishmentHierarchyValidTo">Initial value of ReplenishmentHierarchyValidTo.</param>
        /// <param name="retailChannelId">Initial value of RetailChannelId.</param>
        /// <param name="defaultWeight">Initial value of DefaultWeight.</param>
        /// <param name="percent">Initial value of Percent.</param>
        /// <param name="weight">Initial value of Weight.</param>
        /// <param name="defaultPercent">Initial value of DefaultPercent.</param>
        /// <param name="organizationHierarchyType">Initial value of OrganizationHierarchyType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailReplenishmentRuleLine CreateRetailReplenishmentRuleLine(string dataAreaId, 
                    string replenishmentRule, 
                    string replenishmentHierarchyTypeName, 
                    string replenishmentOrganizationPartyNumber, 
                    global::System.DateTimeOffset replenishmentHierarchyValidFrom, 
                    global::System.DateTimeOffset replenishmentHierarchyValidTo, 
                    string retailChannelId, 
                    decimal defaultWeight, 
                    decimal percent, 
                    decimal weight, 
                    decimal defaultPercent, 
                    global::Microsoft.Dynamics.DataEntities.OrganizationHierarchyType organizationHierarchyType)
        {
            RetailReplenishmentRuleLine retailReplenishmentRuleLine = new RetailReplenishmentRuleLine();
            retailReplenishmentRuleLine.dataAreaId = dataAreaId;
            retailReplenishmentRuleLine.ReplenishmentRule = replenishmentRule;
            retailReplenishmentRuleLine.ReplenishmentHierarchyTypeName = replenishmentHierarchyTypeName;
            retailReplenishmentRuleLine.ReplenishmentOrganizationPartyNumber = replenishmentOrganizationPartyNumber;
            retailReplenishmentRuleLine.ReplenishmentHierarchyValidFrom = replenishmentHierarchyValidFrom;
            retailReplenishmentRuleLine.ReplenishmentHierarchyValidTo = replenishmentHierarchyValidTo;
            retailReplenishmentRuleLine.RetailChannelId = retailChannelId;
            retailReplenishmentRuleLine.DefaultWeight = defaultWeight;
            retailReplenishmentRuleLine.Percent = percent;
            retailReplenishmentRuleLine.Weight = weight;
            retailReplenishmentRuleLine.DefaultPercent = defaultPercent;
            if ((organizationHierarchyType == null))
            {
                throw new global::System.ArgumentNullException("organizationHierarchyType");
            }
            retailReplenishmentRuleLine.OrganizationHierarchyType = organizationHierarchyType;
            return retailReplenishmentRuleLine;
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
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailReplenishmentRuleType> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailReplenishmentRuleType> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailReplenishmentRuleType> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property ReplenishmentHierarchyTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReplenishmentHierarchyTypeName
        {
            get
            {
                return this._ReplenishmentHierarchyTypeName;
            }
            set
            {
                this.OnReplenishmentHierarchyTypeNameChanging(value);
                this._ReplenishmentHierarchyTypeName = value;
                this.OnReplenishmentHierarchyTypeNameChanged();
                this.OnPropertyChanged("ReplenishmentHierarchyTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReplenishmentHierarchyTypeName;
        partial void OnReplenishmentHierarchyTypeNameChanging(string value);
        partial void OnReplenishmentHierarchyTypeNameChanged();
        /// <summary>
        /// There are no comments for Property ReplenishmentOrganizationPartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReplenishmentOrganizationPartyNumber
        {
            get
            {
                return this._ReplenishmentOrganizationPartyNumber;
            }
            set
            {
                this.OnReplenishmentOrganizationPartyNumberChanging(value);
                this._ReplenishmentOrganizationPartyNumber = value;
                this.OnReplenishmentOrganizationPartyNumberChanged();
                this.OnPropertyChanged("ReplenishmentOrganizationPartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReplenishmentOrganizationPartyNumber;
        partial void OnReplenishmentOrganizationPartyNumberChanging(string value);
        partial void OnReplenishmentOrganizationPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property ReplenishmentHierarchyValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ReplenishmentHierarchyValidFrom
        {
            get
            {
                return this._ReplenishmentHierarchyValidFrom;
            }
            set
            {
                this.OnReplenishmentHierarchyValidFromChanging(value);
                this._ReplenishmentHierarchyValidFrom = value;
                this.OnReplenishmentHierarchyValidFromChanged();
                this.OnPropertyChanged("ReplenishmentHierarchyValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ReplenishmentHierarchyValidFrom;
        partial void OnReplenishmentHierarchyValidFromChanging(global::System.DateTimeOffset value);
        partial void OnReplenishmentHierarchyValidFromChanged();
        /// <summary>
        /// There are no comments for Property ReplenishmentHierarchyValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ReplenishmentHierarchyValidTo
        {
            get
            {
                return this._ReplenishmentHierarchyValidTo;
            }
            set
            {
                this.OnReplenishmentHierarchyValidToChanging(value);
                this._ReplenishmentHierarchyValidTo = value;
                this.OnReplenishmentHierarchyValidToChanged();
                this.OnPropertyChanged("ReplenishmentHierarchyValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ReplenishmentHierarchyValidTo;
        partial void OnReplenishmentHierarchyValidToChanging(global::System.DateTimeOffset value);
        partial void OnReplenishmentHierarchyValidToChanged();
        /// <summary>
        /// There are no comments for Property RetailChannelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RetailChannelId
        {
            get
            {
                return this._RetailChannelId;
            }
            set
            {
                this.OnRetailChannelIdChanging(value);
                this._RetailChannelId = value;
                this.OnRetailChannelIdChanged();
                this.OnPropertyChanged("RetailChannelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RetailChannelId;
        partial void OnRetailChannelIdChanging(string value);
        partial void OnRetailChannelIdChanged();
        /// <summary>
        /// There are no comments for Property DefaultWeight in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DefaultWeight
        {
            get
            {
                return this._DefaultWeight;
            }
            set
            {
                this.OnDefaultWeightChanging(value);
                this._DefaultWeight = value;
                this.OnDefaultWeightChanged();
                this.OnPropertyChanged("DefaultWeight");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DefaultWeight;
        partial void OnDefaultWeightChanging(decimal value);
        partial void OnDefaultWeightChanged();
        /// <summary>
        /// There are no comments for Property Percent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Percent
        {
            get
            {
                return this._Percent;
            }
            set
            {
                this.OnPercentChanging(value);
                this._Percent = value;
                this.OnPercentChanged();
                this.OnPropertyChanged("Percent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Percent;
        partial void OnPercentChanging(decimal value);
        partial void OnPercentChanged();
        /// <summary>
        /// There are no comments for Property Weight in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Weight
        {
            get
            {
                return this._Weight;
            }
            set
            {
                this.OnWeightChanging(value);
                this._Weight = value;
                this.OnWeightChanged();
                this.OnPropertyChanged("Weight");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Weight;
        partial void OnWeightChanging(decimal value);
        partial void OnWeightChanged();
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
        /// There are no comments for Property DefaultPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DefaultPercent
        {
            get
            {
                return this._DefaultPercent;
            }
            set
            {
                this.OnDefaultPercentChanging(value);
                this._DefaultPercent = value;
                this.OnDefaultPercentChanged();
                this.OnPropertyChanged("DefaultPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DefaultPercent;
        partial void OnDefaultPercentChanging(decimal value);
        partial void OnDefaultPercentChanged();
        /// <summary>
        /// There are no comments for Property RetailChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailChannel RetailChannel
        {
            get
            {
                return this._RetailChannel;
            }
            set
            {
                this.OnRetailChannelChanging(value);
                this._RetailChannel = value;
                this.OnRetailChannelChanged();
                this.OnPropertyChanged("RetailChannel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailChannel _RetailChannel;
        partial void OnRetailChannelChanging(global::Microsoft.Dynamics.DataEntities.RetailChannel value);
        partial void OnRetailChannelChanged();
        /// <summary>
        /// There are no comments for Property OrganizationHierarchyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OrganizationHierarchyType OrganizationHierarchyType
        {
            get
            {
                return this._OrganizationHierarchyType;
            }
            set
            {
                this.OnOrganizationHierarchyTypeChanging(value);
                this._OrganizationHierarchyType = value;
                this.OnOrganizationHierarchyTypeChanged();
                this.OnPropertyChanged("OrganizationHierarchyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OrganizationHierarchyType _OrganizationHierarchyType;
        partial void OnOrganizationHierarchyTypeChanging(global::Microsoft.Dynamics.DataEntities.OrganizationHierarchyType value);
        partial void OnOrganizationHierarchyTypeChanged();
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
