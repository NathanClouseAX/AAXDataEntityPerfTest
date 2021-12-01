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
    /// There are no comments for ForecastModelSingle in the schema.
    /// </summary>
    public partial class ForecastModelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ForecastModel>
    {
        /// <summary>
        /// Initialize a new ForecastModelSingle object.
        /// </summary>
        public ForecastModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ForecastModelSingle object.
        /// </summary>
        public ForecastModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ForecastModelSingle object.
        /// </summary>
        public ForecastModelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ForecastModel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for SupplyForecastEntries in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SupplyForecastEntry> SupplyForecastEntries
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SupplyForecastEntries == null))
                {
                    this._SupplyForecastEntries = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.SupplyForecastEntry>(GetPath("SupplyForecastEntries"));
                }
                return this._SupplyForecastEntries;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SupplyForecastEntry> _SupplyForecastEntries;
    }
    /// <summary>
    /// There are no comments for ForecastModel in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ModelId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ModelId")]
    [global::Microsoft.OData.Client.EntitySet("ForecastModels")]
    public partial class ForecastModel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ForecastModel object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="modelId">Initial value of ModelId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ForecastModel CreateForecastModel(string dataAreaId, string modelId)
        {
            ForecastModel forecastModel = new ForecastModel();
            forecastModel.dataAreaId = dataAreaId;
            forecastModel.ModelId = modelId;
            return forecastModel;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "dataAreaId is required.")]
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
        /// There are no comments for Property ModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ModelId is required.")]
        public virtual string ModelId
        {
            get
            {
                return this._ModelId;
            }
            set
            {
                this.OnModelIdChanging(value);
                this._ModelId = value;
                this.OnModelIdChanged();
                this.OnPropertyChanged("ModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModelId;
        partial void OnModelIdChanging(string value);
        partial void OnModelIdChanged();
        /// <summary>
        /// There are no comments for Property AreSufficientProjectItemFundsRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AreSufficientProjectItemFundsRequired
        {
            get
            {
                return this._AreSufficientProjectItemFundsRequired;
            }
            set
            {
                this.OnAreSufficientProjectItemFundsRequiredChanging(value);
                this._AreSufficientProjectItemFundsRequired = value;
                this.OnAreSufficientProjectItemFundsRequiredChanged();
                this.OnPropertyChanged("AreSufficientProjectItemFundsRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AreSufficientProjectItemFundsRequired;
        partial void OnAreSufficientProjectItemFundsRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAreSufficientProjectItemFundsRequiredChanged();
        /// <summary>
        /// There are no comments for Property AreSufficientProjectExpenseFundsRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AreSufficientProjectExpenseFundsRequired
        {
            get
            {
                return this._AreSufficientProjectExpenseFundsRequired;
            }
            set
            {
                this.OnAreSufficientProjectExpenseFundsRequiredChanging(value);
                this._AreSufficientProjectExpenseFundsRequired = value;
                this.OnAreSufficientProjectExpenseFundsRequiredChanged();
                this.OnPropertyChanged("AreSufficientProjectExpenseFundsRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AreSufficientProjectExpenseFundsRequired;
        partial void OnAreSufficientProjectExpenseFundsRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAreSufficientProjectExpenseFundsRequiredChanged();
        /// <summary>
        /// There are no comments for Property IsCashFlowForecastGenerated in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCashFlowForecastGenerated
        {
            get
            {
                return this._IsCashFlowForecastGenerated;
            }
            set
            {
                this.OnIsCashFlowForecastGeneratedChanging(value);
                this._IsCashFlowForecastGenerated = value;
                this.OnIsCashFlowForecastGeneratedChanged();
                this.OnPropertyChanged("IsCashFlowForecastGenerated");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCashFlowForecastGenerated;
        partial void OnIsCashFlowForecastGeneratedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCashFlowForecastGeneratedChanged();
        /// <summary>
        /// There are no comments for Property WillProjectForecastGenerationUseProjectDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillProjectForecastGenerationUseProjectDate
        {
            get
            {
                return this._WillProjectForecastGenerationUseProjectDate;
            }
            set
            {
                this.OnWillProjectForecastGenerationUseProjectDateChanging(value);
                this._WillProjectForecastGenerationUseProjectDate = value;
                this.OnWillProjectForecastGenerationUseProjectDateChanged();
                this.OnPropertyChanged("WillProjectForecastGenerationUseProjectDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillProjectForecastGenerationUseProjectDate;
        partial void OnWillProjectForecastGenerationUseProjectDateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillProjectForecastGenerationUseProjectDateChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjBudgetType> BudgetControlType
        {
            get
            {
                return this._BudgetControlType;
            }
            set
            {
                this.OnBudgetControlTypeChanging(value);
                this._BudgetControlType = value;
                this.OnBudgetControlTypeChanged();
                this.OnPropertyChanged("BudgetControlType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjBudgetType> _BudgetControlType;
        partial void OnBudgetControlTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjBudgetType> value);
        partial void OnBudgetControlTypeChanged();
        /// <summary>
        /// There are no comments for Property IsProjectHourForecastAutomaticallyReduced in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsProjectHourForecastAutomaticallyReduced
        {
            get
            {
                return this._IsProjectHourForecastAutomaticallyReduced;
            }
            set
            {
                this.OnIsProjectHourForecastAutomaticallyReducedChanging(value);
                this._IsProjectHourForecastAutomaticallyReduced = value;
                this.OnIsProjectHourForecastAutomaticallyReducedChanged();
                this.OnPropertyChanged("IsProjectHourForecastAutomaticallyReduced");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsProjectHourForecastAutomaticallyReduced;
        partial void OnIsProjectHourForecastAutomaticallyReducedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsProjectHourForecastAutomaticallyReducedChanged();
        /// <summary>
        /// There are no comments for Property AreSufficientProjectHourFundsRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AreSufficientProjectHourFundsRequired
        {
            get
            {
                return this._AreSufficientProjectHourFundsRequired;
            }
            set
            {
                this.OnAreSufficientProjectHourFundsRequiredChanging(value);
                this._AreSufficientProjectHourFundsRequired = value;
                this.OnAreSufficientProjectHourFundsRequiredChanged();
                this.OnPropertyChanged("AreSufficientProjectHourFundsRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AreSufficientProjectHourFundsRequired;
        partial void OnAreSufficientProjectHourFundsRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAreSufficientProjectHourFundsRequiredChanged();
        /// <summary>
        /// There are no comments for Property IsProjectExpenseForecastAutomaticallyReduced in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsProjectExpenseForecastAutomaticallyReduced
        {
            get
            {
                return this._IsProjectExpenseForecastAutomaticallyReduced;
            }
            set
            {
                this.OnIsProjectExpenseForecastAutomaticallyReducedChanging(value);
                this._IsProjectExpenseForecastAutomaticallyReduced = value;
                this.OnIsProjectExpenseForecastAutomaticallyReducedChanged();
                this.OnPropertyChanged("IsProjectExpenseForecastAutomaticallyReduced");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsProjectExpenseForecastAutomaticallyReduced;
        partial void OnIsProjectExpenseForecastAutomaticallyReducedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsProjectExpenseForecastAutomaticallyReducedChanged();
        /// <summary>
        /// There are no comments for Property IsTimeAndMaterialProjectIncluded in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsTimeAndMaterialProjectIncluded
        {
            get
            {
                return this._IsTimeAndMaterialProjectIncluded;
            }
            set
            {
                this.OnIsTimeAndMaterialProjectIncludedChanging(value);
                this._IsTimeAndMaterialProjectIncluded = value;
                this.OnIsTimeAndMaterialProjectIncludedChanged();
                this.OnPropertyChanged("IsTimeAndMaterialProjectIncluded");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsTimeAndMaterialProjectIncluded;
        partial void OnIsTimeAndMaterialProjectIncludedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsTimeAndMaterialProjectIncludedChanged();
        /// <summary>
        /// There are no comments for Property IsInvestmentProjectWIPIncluded in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsInvestmentProjectWIPIncluded
        {
            get
            {
                return this._IsInvestmentProjectWIPIncluded;
            }
            set
            {
                this.OnIsInvestmentProjectWIPIncludedChanging(value);
                this._IsInvestmentProjectWIPIncluded = value;
                this.OnIsInvestmentProjectWIPIncludedChanged();
                this.OnPropertyChanged("IsInvestmentProjectWIPIncluded");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsInvestmentProjectWIPIncluded;
        partial void OnIsInvestmentProjectWIPIncludedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsInvestmentProjectWIPIncludedChanged();
        /// <summary>
        /// There are no comments for Property IsModelStopped in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsModelStopped
        {
            get
            {
                return this._IsModelStopped;
            }
            set
            {
                this.OnIsModelStoppedChanging(value);
                this._IsModelStopped = value;
                this.OnIsModelStoppedChanged();
                this.OnPropertyChanged("IsModelStopped");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsModelStopped;
        partial void OnIsModelStoppedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsModelStoppedChanged();
        /// <summary>
        /// There are no comments for Property ModelName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ModelName
        {
            get
            {
                return this._ModelName;
            }
            set
            {
                this.OnModelNameChanging(value);
                this._ModelName = value;
                this.OnModelNameChanged();
                this.OnPropertyChanged("ModelName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModelName;
        partial void OnModelNameChanging(string value);
        partial void OnModelNameChanged();
        /// <summary>
        /// There are no comments for Property IsFixedPriceProjectWIPIncluded in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsFixedPriceProjectWIPIncluded
        {
            get
            {
                return this._IsFixedPriceProjectWIPIncluded;
            }
            set
            {
                this.OnIsFixedPriceProjectWIPIncludedChanging(value);
                this._IsFixedPriceProjectWIPIncluded = value;
                this.OnIsFixedPriceProjectWIPIncludedChanged();
                this.OnPropertyChanged("IsFixedPriceProjectWIPIncluded");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsFixedPriceProjectWIPIncluded;
        partial void OnIsFixedPriceProjectWIPIncludedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsFixedPriceProjectWIPIncludedChanged();
        /// <summary>
        /// There are no comments for Property IsProjectItemForecastAutomaticallyReduced in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsProjectItemForecastAutomaticallyReduced
        {
            get
            {
                return this._IsProjectItemForecastAutomaticallyReduced;
            }
            set
            {
                this.OnIsProjectItemForecastAutomaticallyReducedChanging(value);
                this._IsProjectItemForecastAutomaticallyReduced = value;
                this.OnIsProjectItemForecastAutomaticallyReducedChanged();
                this.OnPropertyChanged("IsProjectItemForecastAutomaticallyReduced");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsProjectItemForecastAutomaticallyReduced;
        partial void OnIsProjectItemForecastAutomaticallyReducedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsProjectItemForecastAutomaticallyReducedChanged();
        /// <summary>
        /// There are no comments for Property SupplyForecastEntries in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SupplyForecastEntry> SupplyForecastEntries
        {
            get
            {
                return this._SupplyForecastEntries;
            }
            set
            {
                this.OnSupplyForecastEntriesChanging(value);
                this._SupplyForecastEntries = value;
                this.OnSupplyForecastEntriesChanged();
                this.OnPropertyChanged("SupplyForecastEntries");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SupplyForecastEntry> _SupplyForecastEntries = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SupplyForecastEntry>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSupplyForecastEntriesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SupplyForecastEntry> value);
        partial void OnSupplyForecastEntriesChanged();
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
