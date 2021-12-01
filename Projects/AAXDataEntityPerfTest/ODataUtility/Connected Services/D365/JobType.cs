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
    /// There are no comments for JobTypeSingle in the schema.
    /// </summary>
    public partial class JobTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<JobType>
    {
        /// <summary>
        /// Initialize a new JobTypeSingle object.
        /// </summary>
        public JobTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new JobTypeSingle object.
        /// </summary>
        public JobTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new JobTypeSingle object.
        /// </summary>
        public JobTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<JobType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CompensationEligibilityRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationEligibilityRule> CompensationEligibilityRules
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationEligibilityRules == null))
                {
                    this._CompensationEligibilityRules = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompensationEligibilityRule>(GetPath("CompensationEligibilityRules"));
                }
                return this._CompensationEligibilityRules;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationEligibilityRule> _CompensationEligibilityRules;
        /// <summary>
        /// There are no comments for Jobs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Job> Jobs
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Jobs == null))
                {
                    this._Jobs = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Job>(GetPath("Jobs"));
                }
                return this._Jobs;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Job> _Jobs;
    }
    /// <summary>
    /// There are no comments for JobType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// JobTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("JobTypeId")]
    [global::Microsoft.OData.Client.EntitySet("JobTypes")]
    public partial class JobType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new JobType object.
        /// </summary>
        /// <param name="jobTypeId">Initial value of JobTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static JobType CreateJobType(string jobTypeId)
        {
            JobType jobType = new JobType();
            jobType.JobTypeId = jobTypeId;
            return jobType;
        }
        /// <summary>
        /// There are no comments for Property JobTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JobTypeId is required.")]
        public virtual string JobTypeId
        {
            get
            {
                return this._JobTypeId;
            }
            set
            {
                this.OnJobTypeIdChanging(value);
                this._JobTypeId = value;
                this.OnJobTypeIdChanged();
                this.OnPropertyChanged("JobTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTypeId;
        partial void OnJobTypeIdChanging(string value);
        partial void OnJobTypeIdChanged();
        /// <summary>
        /// There are no comments for Property PaidHourly in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PaidHourly
        {
            get
            {
                return this._PaidHourly;
            }
            set
            {
                this.OnPaidHourlyChanging(value);
                this._PaidHourly = value;
                this.OnPaidHourlyChanged();
                this.OnPropertyChanged("PaidHourly");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PaidHourly;
        partial void OnPaidHourlyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPaidHourlyChanged();
        /// <summary>
        /// There are no comments for Property ExemptStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmJobTypeExemptStatus> ExemptStatus
        {
            get
            {
                return this._ExemptStatus;
            }
            set
            {
                this.OnExemptStatusChanging(value);
                this._ExemptStatus = value;
                this.OnExemptStatusChanged();
                this.OnPropertyChanged("ExemptStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmJobTypeExemptStatus> _ExemptStatus;
        partial void OnExemptStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmJobTypeExemptStatus> value);
        partial void OnExemptStatusChanged();
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
        /// There are no comments for Property CompensationEligibilityRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationEligibilityRule> CompensationEligibilityRules
        {
            get
            {
                return this._CompensationEligibilityRules;
            }
            set
            {
                this.OnCompensationEligibilityRulesChanging(value);
                this._CompensationEligibilityRules = value;
                this.OnCompensationEligibilityRulesChanged();
                this.OnPropertyChanged("CompensationEligibilityRules");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationEligibilityRule> _CompensationEligibilityRules = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationEligibilityRule>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompensationEligibilityRulesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationEligibilityRule> value);
        partial void OnCompensationEligibilityRulesChanged();
        /// <summary>
        /// There are no comments for Property Jobs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job> Jobs
        {
            get
            {
                return this._Jobs;
            }
            set
            {
                this.OnJobsChanging(value);
                this._Jobs = value;
                this.OnJobsChanged();
                this.OnPropertyChanged("Jobs");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job> _Jobs = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job> value);
        partial void OnJobsChanged();
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
