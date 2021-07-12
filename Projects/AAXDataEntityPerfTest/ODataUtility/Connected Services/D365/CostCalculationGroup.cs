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
        /// There are no comments for CostCalculationGroupSingle in the schema.
        /// </summary>
    public partial class CostCalculationGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CostCalculationGroup>
    {
        /// <summary>
        /// Initialize a new CostCalculationGroupSingle object.
        /// </summary>
        public CostCalculationGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CostCalculationGroupSingle object.
        /// </summary>
        public CostCalculationGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CostCalculationGroupSingle object.
        /// </summary>
        public CostCalculationGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CostCalculationGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductsV2 == null))
                {
                    this._ReleasedProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(GetPath("ReleasedProductsV2"));
                }
                return this._ReleasedProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2;
    }
        /// <summary>
        /// There are no comments for CostCalculationGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// GroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GroupId")]
    [global::Microsoft.OData.Client.EntitySet("CostCalculationGroups")]
    public partial class CostCalculationGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CostCalculationGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="groupId">Initial value of GroupId.</param>
        /// <param name="showWarningIfContributionMarginPercentageLowerThan">Initial value of ShowWarningIfContributionMarginPercentageLowerThan.</param>
        /// <param name="showWarningIfCostPriceCalculationOlderThanDays">Initial value of ShowWarningIfCostPriceCalculationOlderThanDays.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CostCalculationGroup CreateCostCalculationGroup(string dataAreaId, string groupId, decimal showWarningIfContributionMarginPercentageLowerThan, int showWarningIfCostPriceCalculationOlderThanDays)
        {
            CostCalculationGroup costCalculationGroup = new CostCalculationGroup();
            costCalculationGroup.dataAreaId = dataAreaId;
            costCalculationGroup.GroupId = groupId;
            costCalculationGroup.ShowWarningIfContributionMarginPercentageLowerThan = showWarningIfContributionMarginPercentageLowerThan;
            costCalculationGroup.ShowWarningIfCostPriceCalculationOlderThanDays = showWarningIfCostPriceCalculationOlderThanDays;
            return costCalculationGroup;
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
        /// There are no comments for Property GroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupId
        {
            get
            {
                return this._GroupId;
            }
            set
            {
                this.OnGroupIdChanging(value);
                this._GroupId = value;
                this.OnGroupIdChanged();
                this.OnPropertyChanged("GroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupId;
        partial void OnGroupIdChanging(string value);
        partial void OnGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ShowWarningIfContributionMarginPercentageLowerThan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ShowWarningIfContributionMarginPercentageLowerThan
        {
            get
            {
                return this._ShowWarningIfContributionMarginPercentageLowerThan;
            }
            set
            {
                this.OnShowWarningIfContributionMarginPercentageLowerThanChanging(value);
                this._ShowWarningIfContributionMarginPercentageLowerThan = value;
                this.OnShowWarningIfContributionMarginPercentageLowerThanChanged();
                this.OnPropertyChanged("ShowWarningIfContributionMarginPercentageLowerThan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ShowWarningIfContributionMarginPercentageLowerThan;
        partial void OnShowWarningIfContributionMarginPercentageLowerThanChanging(decimal value);
        partial void OnShowWarningIfContributionMarginPercentageLowerThanChanged();
        /// <summary>
        /// There are no comments for Property WillCostCalculationIssueZeroConsumptionWarning in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillCostCalculationIssueZeroConsumptionWarning
        {
            get
            {
                return this._WillCostCalculationIssueZeroConsumptionWarning;
            }
            set
            {
                this.OnWillCostCalculationIssueZeroConsumptionWarningChanging(value);
                this._WillCostCalculationIssueZeroConsumptionWarning = value;
                this.OnWillCostCalculationIssueZeroConsumptionWarningChanged();
                this.OnPropertyChanged("WillCostCalculationIssueZeroConsumptionWarning");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillCostCalculationIssueZeroConsumptionWarning;
        partial void OnWillCostCalculationIssueZeroConsumptionWarningChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillCostCalculationIssueZeroConsumptionWarningChanged();
        /// <summary>
        /// There are no comments for Property WillCostCalculationIssueNoActiveAssignedRouteWarning in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillCostCalculationIssueNoActiveAssignedRouteWarning
        {
            get
            {
                return this._WillCostCalculationIssueNoActiveAssignedRouteWarning;
            }
            set
            {
                this.OnWillCostCalculationIssueNoActiveAssignedRouteWarningChanging(value);
                this._WillCostCalculationIssueNoActiveAssignedRouteWarning = value;
                this.OnWillCostCalculationIssueNoActiveAssignedRouteWarningChanged();
                this.OnPropertyChanged("WillCostCalculationIssueNoActiveAssignedRouteWarning");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillCostCalculationIssueNoActiveAssignedRouteWarning;
        partial void OnWillCostCalculationIssueNoActiveAssignedRouteWarningChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillCostCalculationIssueNoActiveAssignedRouteWarningChanged();
        /// <summary>
        /// There are no comments for Property GroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupName
        {
            get
            {
                return this._GroupName;
            }
            set
            {
                this.OnGroupNameChanging(value);
                this._GroupName = value;
                this.OnGroupNameChanged();
                this.OnPropertyChanged("GroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupName;
        partial void OnGroupNameChanging(string value);
        partial void OnGroupNameChanged();
        /// <summary>
        /// There are no comments for Property UnitCostCalculationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcCostPrice> UnitCostCalculationMethod
        {
            get
            {
                return this._UnitCostCalculationMethod;
            }
            set
            {
                this.OnUnitCostCalculationMethodChanging(value);
                this._UnitCostCalculationMethod = value;
                this.OnUnitCostCalculationMethodChanged();
                this.OnPropertyChanged("UnitCostCalculationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcCostPrice> _UnitCostCalculationMethod;
        partial void OnUnitCostCalculationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcCostPrice> value);
        partial void OnUnitCostCalculationMethodChanged();
        /// <summary>
        /// There are no comments for Property SalesPriceCalculationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcSalesPrice> SalesPriceCalculationMethod
        {
            get
            {
                return this._SalesPriceCalculationMethod;
            }
            set
            {
                this.OnSalesPriceCalculationMethodChanging(value);
                this._SalesPriceCalculationMethod = value;
                this.OnSalesPriceCalculationMethodChanged();
                this.OnPropertyChanged("SalesPriceCalculationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcSalesPrice> _SalesPriceCalculationMethod;
        partial void OnSalesPriceCalculationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcSalesPrice> value);
        partial void OnSalesPriceCalculationMethodChanged();
        /// <summary>
        /// There are no comments for Property WillCostCalculationIssueNoActiveAssignedBOMWarning in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillCostCalculationIssueNoActiveAssignedBOMWarning
        {
            get
            {
                return this._WillCostCalculationIssueNoActiveAssignedBOMWarning;
            }
            set
            {
                this.OnWillCostCalculationIssueNoActiveAssignedBOMWarningChanging(value);
                this._WillCostCalculationIssueNoActiveAssignedBOMWarning = value;
                this.OnWillCostCalculationIssueNoActiveAssignedBOMWarningChanged();
                this.OnPropertyChanged("WillCostCalculationIssueNoActiveAssignedBOMWarning");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillCostCalculationIssueNoActiveAssignedBOMWarning;
        partial void OnWillCostCalculationIssueNoActiveAssignedBOMWarningChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillCostCalculationIssueNoActiveAssignedBOMWarningChanged();
        /// <summary>
        /// There are no comments for Property WillCostCalulationIssueOperationsResourceRequirementNotMetWarning in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillCostCalulationIssueOperationsResourceRequirementNotMetWarning
        {
            get
            {
                return this._WillCostCalulationIssueOperationsResourceRequirementNotMetWarning;
            }
            set
            {
                this.OnWillCostCalulationIssueOperationsResourceRequirementNotMetWarningChanging(value);
                this._WillCostCalulationIssueOperationsResourceRequirementNotMetWarning = value;
                this.OnWillCostCalulationIssueOperationsResourceRequirementNotMetWarningChanged();
                this.OnPropertyChanged("WillCostCalulationIssueOperationsResourceRequirementNotMetWarning");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillCostCalulationIssueOperationsResourceRequirementNotMetWarning;
        partial void OnWillCostCalulationIssueOperationsResourceRequirementNotMetWarningChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillCostCalulationIssueOperationsResourceRequirementNotMetWarningChanged();
        /// <summary>
        /// There are no comments for Property ShowWarningIfCostPriceCalculationOlderThanDays in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int ShowWarningIfCostPriceCalculationOlderThanDays
        {
            get
            {
                return this._ShowWarningIfCostPriceCalculationOlderThanDays;
            }
            set
            {
                this.OnShowWarningIfCostPriceCalculationOlderThanDaysChanging(value);
                this._ShowWarningIfCostPriceCalculationOlderThanDays = value;
                this.OnShowWarningIfCostPriceCalculationOlderThanDaysChanged();
                this.OnPropertyChanged("ShowWarningIfCostPriceCalculationOlderThanDays");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ShowWarningIfCostPriceCalculationOlderThanDays;
        partial void OnShowWarningIfCostPriceCalculationOlderThanDaysChanging(int value);
        partial void OnShowWarningIfCostPriceCalculationOlderThanDaysChanged();
        /// <summary>
        /// There are no comments for Property WillCostCalulationIssueZeroCostPriceWarning in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillCostCalulationIssueZeroCostPriceWarning
        {
            get
            {
                return this._WillCostCalulationIssueZeroCostPriceWarning;
            }
            set
            {
                this.OnWillCostCalulationIssueZeroCostPriceWarningChanging(value);
                this._WillCostCalulationIssueZeroCostPriceWarning = value;
                this.OnWillCostCalulationIssueZeroCostPriceWarningChanged();
                this.OnPropertyChanged("WillCostCalulationIssueZeroCostPriceWarning");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillCostCalulationIssueZeroCostPriceWarning;
        partial void OnWillCostCalulationIssueZeroCostPriceWarningChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillCostCalulationIssueZeroCostPriceWarningChanged();
        /// <summary>
        /// There are no comments for Property StopExplosionAtItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> StopExplosionAtItem
        {
            get
            {
                return this._StopExplosionAtItem;
            }
            set
            {
                this.OnStopExplosionAtItemChanging(value);
                this._StopExplosionAtItem = value;
                this.OnStopExplosionAtItemChanged();
                this.OnPropertyChanged("StopExplosionAtItem");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _StopExplosionAtItem;
        partial void OnStopExplosionAtItemChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnStopExplosionAtItemChanged();
        /// <summary>
        /// There are no comments for Property AlternativeUnitCostCalculationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcCostPrice> AlternativeUnitCostCalculationMethod
        {
            get
            {
                return this._AlternativeUnitCostCalculationMethod;
            }
            set
            {
                this.OnAlternativeUnitCostCalculationMethodChanging(value);
                this._AlternativeUnitCostCalculationMethod = value;
                this.OnAlternativeUnitCostCalculationMethodChanged();
                this.OnPropertyChanged("AlternativeUnitCostCalculationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcCostPrice> _AlternativeUnitCostCalculationMethod;
        partial void OnAlternativeUnitCostCalculationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcCostPrice> value);
        partial void OnAlternativeUnitCostCalculationMethodChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                return this._ReleasedProductsV2;
            }
            set
            {
                this.OnReleasedProductsV2Changing(value);
                this._ReleasedProductsV2 = value;
                this.OnReleasedProductsV2Changed();
                this.OnPropertyChanged("ReleasedProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> value);
        partial void OnReleasedProductsV2Changed();
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
