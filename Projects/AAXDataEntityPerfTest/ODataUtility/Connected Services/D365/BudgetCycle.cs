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
        /// There are no comments for BudgetCycleSingle in the schema.
        /// </summary>
    public partial class BudgetCycleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetCycle>
    {
        /// <summary>
        /// Initialize a new BudgetCycleSingle object.
        /// </summary>
        public BudgetCycleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetCycleSingle object.
        /// </summary>
        public BudgetCycleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetCycleSingle object.
        /// </summary>
        public BudgetCycleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetCycle> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetControlCycleModelBudgetCycle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlCycleModel> BudgetControlCycleModelBudgetCycle
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlCycleModelBudgetCycle == null))
                {
                    this._BudgetControlCycleModelBudgetCycle = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlCycleModel>(GetPath("BudgetControlCycleModelBudgetCycle"));
                }
                return this._BudgetControlCycleModelBudgetCycle;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlCycleModel> _BudgetControlCycleModelBudgetCycle;
        /// <summary>
        /// There are no comments for BudgetTrackingWorkspaceParametersBudgetCycle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> BudgetTrackingWorkspaceParametersBudgetCycle
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetTrackingWorkspaceParametersBudgetCycle == null))
                {
                    this._BudgetTrackingWorkspaceParametersBudgetCycle = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters>(GetPath("BudgetTrackingWorkspaceParametersBudgetCycle"));
                }
                return this._BudgetTrackingWorkspaceParametersBudgetCycle;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> _BudgetTrackingWorkspaceParametersBudgetCycle;
    }
        /// <summary>
        /// There are no comments for BudgetCycle in the schema.
        /// </summary>
    /// <KeyProperties>
    /// BudgetCycleTimeSpanName
    /// FiscalCalendar
    /// BudgetCycleName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BudgetCycleTimeSpanName", "FiscalCalendar", "BudgetCycleName")]
    [global::Microsoft.OData.Client.EntitySet("BudgetCycles")]
    public partial class BudgetCycle : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetCycle object.
        /// </summary>
        /// <param name="budgetCycleTimeSpanName">Initial value of BudgetCycleTimeSpanName.</param>
        /// <param name="fiscalCalendar">Initial value of FiscalCalendar.</param>
        /// <param name="budgetCycleName">Initial value of BudgetCycleName.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="numberOfFiscalPeriods">Initial value of NumberOfFiscalPeriods.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetCycle CreateBudgetCycle(string budgetCycleTimeSpanName, 
                    string fiscalCalendar, 
                    string budgetCycleName, 
                    global::System.DateTimeOffset startDate, 
                    global::System.DateTimeOffset endDate, 
                    int numberOfFiscalPeriods)
        {
            BudgetCycle budgetCycle = new BudgetCycle();
            budgetCycle.BudgetCycleTimeSpanName = budgetCycleTimeSpanName;
            budgetCycle.FiscalCalendar = fiscalCalendar;
            budgetCycle.BudgetCycleName = budgetCycleName;
            budgetCycle.StartDate = startDate;
            budgetCycle.EndDate = endDate;
            budgetCycle.NumberOfFiscalPeriods = numberOfFiscalPeriods;
            return budgetCycle;
        }
        /// <summary>
        /// There are no comments for Property BudgetCycleTimeSpanName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BudgetCycleTimeSpanName
        {
            get
            {
                return this._BudgetCycleTimeSpanName;
            }
            set
            {
                this.OnBudgetCycleTimeSpanNameChanging(value);
                this._BudgetCycleTimeSpanName = value;
                this.OnBudgetCycleTimeSpanNameChanged();
                this.OnPropertyChanged("BudgetCycleTimeSpanName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetCycleTimeSpanName;
        partial void OnBudgetCycleTimeSpanNameChanging(string value);
        partial void OnBudgetCycleTimeSpanNameChanged();
        /// <summary>
        /// There are no comments for Property FiscalCalendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FiscalCalendar
        {
            get
            {
                return this._FiscalCalendar;
            }
            set
            {
                this.OnFiscalCalendarChanging(value);
                this._FiscalCalendar = value;
                this.OnFiscalCalendarChanged();
                this.OnPropertyChanged("FiscalCalendar");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalCalendar;
        partial void OnFiscalCalendarChanging(string value);
        partial void OnFiscalCalendarChanged();
        /// <summary>
        /// There are no comments for Property BudgetCycleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BudgetCycleName
        {
            get
            {
                return this._BudgetCycleName;
            }
            set
            {
                this.OnBudgetCycleNameChanging(value);
                this._BudgetCycleName = value;
                this.OnBudgetCycleNameChanged();
                this.OnPropertyChanged("BudgetCycleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetCycleName;
        partial void OnBudgetCycleNameChanging(string value);
        partial void OnBudgetCycleNameChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDate;
        partial void OnStartDateChanging(global::System.DateTimeOffset value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property EndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this.OnEndDateChanging(value);
                this._EndDate = value;
                this.OnEndDateChanged();
                this.OnPropertyChanged("EndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EndDate;
        partial void OnEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEndDateChanged();
        /// <summary>
        /// There are no comments for Property NumberOfFiscalPeriods in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int NumberOfFiscalPeriods
        {
            get
            {
                return this._NumberOfFiscalPeriods;
            }
            set
            {
                this.OnNumberOfFiscalPeriodsChanging(value);
                this._NumberOfFiscalPeriods = value;
                this.OnNumberOfFiscalPeriodsChanged();
                this.OnPropertyChanged("NumberOfFiscalPeriods");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NumberOfFiscalPeriods;
        partial void OnNumberOfFiscalPeriodsChanging(int value);
        partial void OnNumberOfFiscalPeriodsChanged();
        /// <summary>
        /// There are no comments for Property LengthOfBudgetCycle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCycleLengthOption> LengthOfBudgetCycle
        {
            get
            {
                return this._LengthOfBudgetCycle;
            }
            set
            {
                this.OnLengthOfBudgetCycleChanging(value);
                this._LengthOfBudgetCycle = value;
                this.OnLengthOfBudgetCycleChanged();
                this.OnPropertyChanged("LengthOfBudgetCycle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCycleLengthOption> _LengthOfBudgetCycle;
        partial void OnLengthOfBudgetCycleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCycleLengthOption> value);
        partial void OnLengthOfBudgetCycleChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlCycleModelBudgetCycle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlCycleModel> BudgetControlCycleModelBudgetCycle
        {
            get
            {
                return this._BudgetControlCycleModelBudgetCycle;
            }
            set
            {
                this.OnBudgetControlCycleModelBudgetCycleChanging(value);
                this._BudgetControlCycleModelBudgetCycle = value;
                this.OnBudgetControlCycleModelBudgetCycleChanged();
                this.OnPropertyChanged("BudgetControlCycleModelBudgetCycle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlCycleModel> _BudgetControlCycleModelBudgetCycle = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlCycleModel>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetControlCycleModelBudgetCycleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlCycleModel> value);
        partial void OnBudgetControlCycleModelBudgetCycleChanged();
        /// <summary>
        /// There are no comments for Property BudgetTrackingWorkspaceParametersBudgetCycle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> BudgetTrackingWorkspaceParametersBudgetCycle
        {
            get
            {
                return this._BudgetTrackingWorkspaceParametersBudgetCycle;
            }
            set
            {
                this.OnBudgetTrackingWorkspaceParametersBudgetCycleChanging(value);
                this._BudgetTrackingWorkspaceParametersBudgetCycle = value;
                this.OnBudgetTrackingWorkspaceParametersBudgetCycleChanged();
                this.OnPropertyChanged("BudgetTrackingWorkspaceParametersBudgetCycle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> _BudgetTrackingWorkspaceParametersBudgetCycle = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetTrackingWorkspaceParametersBudgetCycleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> value);
        partial void OnBudgetTrackingWorkspaceParametersBudgetCycleChanged();
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
