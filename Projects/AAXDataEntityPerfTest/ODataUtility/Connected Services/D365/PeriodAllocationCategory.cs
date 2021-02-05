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
        /// There are no comments for PeriodAllocationCategorySingle in the schema.
        /// </summary>
    public partial class PeriodAllocationCategorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PeriodAllocationCategory>
    {
        /// <summary>
        /// Initialize a new PeriodAllocationCategorySingle object.
        /// </summary>
        public PeriodAllocationCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PeriodAllocationCategorySingle object.
        /// </summary>
        public PeriodAllocationCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PeriodAllocationCategorySingle object.
        /// </summary>
        public PeriodAllocationCategorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PeriodAllocationCategory> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetParameters in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetParameters> BudgetParameters
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetParameters == null))
                {
                    this._BudgetParameters = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetParameters>(GetPath("BudgetParameters"));
                }
                return this._BudgetParameters;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetParameters> _BudgetParameters;
    }
        /// <summary>
        /// There are no comments for PeriodAllocationCategory in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PeriodKey
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PeriodKey", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("PeriodAllocationCategories")]
    public partial class PeriodAllocationCategory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PeriodAllocationCategory object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="periodKey">Initial value of PeriodKey.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="allocationPercentage">Initial value of AllocationPercentage.</param>
        /// <param name="timeInterval">Initial value of TimeInterval.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PeriodAllocationCategory CreatePeriodAllocationCategory(string dataAreaId, string periodKey, decimal lineNumber, decimal allocationPercentage, int timeInterval)
        {
            PeriodAllocationCategory periodAllocationCategory = new PeriodAllocationCategory();
            periodAllocationCategory.dataAreaId = dataAreaId;
            periodAllocationCategory.PeriodKey = periodKey;
            periodAllocationCategory.LineNumber = lineNumber;
            periodAllocationCategory.AllocationPercentage = allocationPercentage;
            periodAllocationCategory.TimeInterval = timeInterval;
            return periodAllocationCategory;
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
        /// There are no comments for Property PeriodKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PeriodKey
        {
            get
            {
                return this._PeriodKey;
            }
            set
            {
                this.OnPeriodKeyChanging(value);
                this._PeriodKey = value;
                this.OnPeriodKeyChanged();
                this.OnPropertyChanged("PeriodKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PeriodKey;
        partial void OnPeriodKeyChanging(string value);
        partial void OnPeriodKeyChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property DimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionDisplayValue
        {
            get
            {
                return this._DimensionDisplayValue;
            }
            set
            {
                this.OnDimensionDisplayValueChanging(value);
                this._DimensionDisplayValue = value;
                this.OnDimensionDisplayValueChanged();
                this.OnPropertyChanged("DimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionDisplayValue;
        partial void OnDimensionDisplayValueChanging(string value);
        partial void OnDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property AllocationPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AllocationPercentage
        {
            get
            {
                return this._AllocationPercentage;
            }
            set
            {
                this.OnAllocationPercentageChanging(value);
                this._AllocationPercentage = value;
                this.OnAllocationPercentageChanged();
                this.OnPropertyChanged("AllocationPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AllocationPercentage;
        partial void OnAllocationPercentageChanging(decimal value);
        partial void OnAllocationPercentageChanged();
        /// <summary>
        /// There are no comments for Property IsFixed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsFixed
        {
            get
            {
                return this._IsFixed;
            }
            set
            {
                this.OnIsFixedChanging(value);
                this._IsFixed = value;
                this.OnIsFixedChanged();
                this.OnPropertyChanged("IsFixed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsFixed;
        partial void OnIsFixedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsFixedChanged();
        /// <summary>
        /// There are no comments for Property TimeInterval in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int TimeInterval
        {
            get
            {
                return this._TimeInterval;
            }
            set
            {
                this.OnTimeIntervalChanging(value);
                this._TimeInterval = value;
                this.OnTimeIntervalChanged();
                this.OnPropertyChanged("TimeInterval");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _TimeInterval;
        partial void OnTimeIntervalChanging(int value);
        partial void OnTimeIntervalChanged();
        /// <summary>
        /// There are no comments for Property UnitOfTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PeriodUnit> UnitOfTime
        {
            get
            {
                return this._UnitOfTime;
            }
            set
            {
                this.OnUnitOfTimeChanging(value);
                this._UnitOfTime = value;
                this.OnUnitOfTimeChanged();
                this.OnPropertyChanged("UnitOfTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PeriodUnit> _UnitOfTime;
        partial void OnUnitOfTimeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PeriodUnit> value);
        partial void OnUnitOfTimeChanged();
        /// <summary>
        /// There are no comments for Property BudgetParameters in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetParameters> BudgetParameters
        {
            get
            {
                return this._BudgetParameters;
            }
            set
            {
                this.OnBudgetParametersChanging(value);
                this._BudgetParameters = value;
                this.OnBudgetParametersChanged();
                this.OnPropertyChanged("BudgetParameters");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetParameters> _BudgetParameters = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetParameters>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetParametersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetParameters> value);
        partial void OnBudgetParametersChanged();
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
