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
        /// There are no comments for ProjectPeriodSingle in the schema.
        /// </summary>
    public partial class ProjectPeriodSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectPeriod>
    {
        /// <summary>
        /// Initialize a new ProjectPeriodSingle object.
        /// </summary>
        public ProjectPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjectPeriodSingle object.
        /// </summary>
        public ProjectPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjectPeriodSingle object.
        /// </summary>
        public ProjectPeriodSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectPeriod> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RebateClaimAssignedRebateAndDeductionsDateSetups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetup> RebateClaimAssignedRebateAndDeductionsDateSetups
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RebateClaimAssignedRebateAndDeductionsDateSetups == null))
                {
                    this._RebateClaimAssignedRebateAndDeductionsDateSetups = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetup>(GetPath("RebateClaimAssignedRebateAndDeductionsDateSetups"));
                }
                return this._RebateClaimAssignedRebateAndDeductionsDateSetups;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetup> _RebateClaimAssignedRebateAndDeductionsDateSetups;
        /// <summary>
        /// There are no comments for RebateProvisionAssignedRebateAndDeductionsDateSetups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetup> RebateProvisionAssignedRebateAndDeductionsDateSetups
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RebateProvisionAssignedRebateAndDeductionsDateSetups == null))
                {
                    this._RebateProvisionAssignedRebateAndDeductionsDateSetups = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetup>(GetPath("RebateProvisionAssignedRebateAndDeductionsDateSetups"));
                }
                return this._RebateProvisionAssignedRebateAndDeductionsDateSetups;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetup> _RebateProvisionAssignedRebateAndDeductionsDateSetups;
    }
        /// <summary>
        /// There are no comments for ProjectPeriod in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PeriodId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PeriodId")]
    [global::Microsoft.OData.Client.EntitySet("ProjectPeriods")]
    public partial class ProjectPeriod : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjectPeriod object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="periodId">Initial value of PeriodId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjectPeriod CreateProjectPeriod(string dataAreaId, string periodId)
        {
            ProjectPeriod projectPeriod = new ProjectPeriod();
            projectPeriod.dataAreaId = dataAreaId;
            projectPeriod.PeriodId = periodId;
            return projectPeriod;
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
        /// There are no comments for Property PeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PeriodId
        {
            get
            {
                return this._PeriodId;
            }
            set
            {
                this.OnPeriodIdChanging(value);
                this._PeriodId = value;
                this.OnPeriodIdChanged();
                this.OnPropertyChanged("PeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PeriodId;
        partial void OnPeriodIdChanging(string value);
        partial void OnPeriodIdChanged();
        /// <summary>
        /// There are no comments for Property IsWeekAutoSplit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsWeekAutoSplit
        {
            get
            {
                return this._IsWeekAutoSplit;
            }
            set
            {
                this.OnIsWeekAutoSplitChanging(value);
                this._IsWeekAutoSplit = value;
                this.OnIsWeekAutoSplitChanged();
                this.OnPropertyChanged("IsWeekAutoSplit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsWeekAutoSplit;
        partial void OnIsWeekAutoSplitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsWeekAutoSplitChanged();
        /// <summary>
        /// There are no comments for Property WeekDayPeriodStart in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WeekDays> WeekDayPeriodStart
        {
            get
            {
                return this._WeekDayPeriodStart;
            }
            set
            {
                this.OnWeekDayPeriodStartChanging(value);
                this._WeekDayPeriodStart = value;
                this.OnWeekDayPeriodStartChanged();
                this.OnPropertyChanged("WeekDayPeriodStart");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WeekDays> _WeekDayPeriodStart;
        partial void OnWeekDayPeriodStartChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WeekDays> value);
        partial void OnWeekDayPeriodStartChanged();
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
        /// There are no comments for Property Frequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TSPerWeekMth> Frequency
        {
            get
            {
                return this._Frequency;
            }
            set
            {
                this.OnFrequencyChanging(value);
                this._Frequency = value;
                this.OnFrequencyChanged();
                this.OnPropertyChanged("Frequency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TSPerWeekMth> _Frequency;
        partial void OnFrequencyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TSPerWeekMth> value);
        partial void OnFrequencyChanged();
        /// <summary>
        /// There are no comments for Property RebateClaimAssignedRebateAndDeductionsDateSetups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetup> RebateClaimAssignedRebateAndDeductionsDateSetups
        {
            get
            {
                return this._RebateClaimAssignedRebateAndDeductionsDateSetups;
            }
            set
            {
                this.OnRebateClaimAssignedRebateAndDeductionsDateSetupsChanging(value);
                this._RebateClaimAssignedRebateAndDeductionsDateSetups = value;
                this.OnRebateClaimAssignedRebateAndDeductionsDateSetupsChanged();
                this.OnPropertyChanged("RebateClaimAssignedRebateAndDeductionsDateSetups");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetup> _RebateClaimAssignedRebateAndDeductionsDateSetups = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetup>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRebateClaimAssignedRebateAndDeductionsDateSetupsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetup> value);
        partial void OnRebateClaimAssignedRebateAndDeductionsDateSetupsChanged();
        /// <summary>
        /// There are no comments for Property RebateProvisionAssignedRebateAndDeductionsDateSetups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetup> RebateProvisionAssignedRebateAndDeductionsDateSetups
        {
            get
            {
                return this._RebateProvisionAssignedRebateAndDeductionsDateSetups;
            }
            set
            {
                this.OnRebateProvisionAssignedRebateAndDeductionsDateSetupsChanging(value);
                this._RebateProvisionAssignedRebateAndDeductionsDateSetups = value;
                this.OnRebateProvisionAssignedRebateAndDeductionsDateSetupsChanged();
                this.OnPropertyChanged("RebateProvisionAssignedRebateAndDeductionsDateSetups");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetup> _RebateProvisionAssignedRebateAndDeductionsDateSetups = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetup>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRebateProvisionAssignedRebateAndDeductionsDateSetupsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetup> value);
        partial void OnRebateProvisionAssignedRebateAndDeductionsDateSetupsChanged();
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
