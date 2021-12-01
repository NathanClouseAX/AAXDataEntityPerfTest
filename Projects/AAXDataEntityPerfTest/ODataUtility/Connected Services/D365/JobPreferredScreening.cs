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
    /// There are no comments for JobPreferredScreeningSingle in the schema.
    /// </summary>
    public partial class JobPreferredScreeningSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<JobPreferredScreening>
    {
        /// <summary>
        /// Initialize a new JobPreferredScreeningSingle object.
        /// </summary>
        public JobPreferredScreeningSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new JobPreferredScreeningSingle object.
        /// </summary>
        public JobPreferredScreeningSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new JobPreferredScreeningSingle object.
        /// </summary>
        public JobPreferredScreeningSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<JobPreferredScreening> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Job in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobSingle Job
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Job == null))
                {
                    this._Job = new global::Microsoft.Dynamics.DataEntities.JobSingle(this.Context, GetPath("Job"));
                }
                return this._Job;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobSingle _Job;
        /// <summary>
        /// There are no comments for ScreeningType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ScreeningTypeSingle ScreeningType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ScreeningType == null))
                {
                    this._ScreeningType = new global::Microsoft.Dynamics.DataEntities.ScreeningTypeSingle(this.Context, GetPath("ScreeningType"));
                }
                return this._ScreeningType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ScreeningTypeSingle _ScreeningType;
    }
    /// <summary>
    /// There are no comments for JobPreferredScreening in the schema.
    /// </summary>
    /// <KeyProperties>
    /// JobId
    /// ScreeningTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("JobId", "ScreeningTypeId")]
    [global::Microsoft.OData.Client.EntitySet("JobPreferredScreenings")]
    public partial class JobPreferredScreening : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new JobPreferredScreening object.
        /// </summary>
        /// <param name="jobId">Initial value of JobId.</param>
        /// <param name="screeningTypeId">Initial value of ScreeningTypeId.</param>
        /// <param name="job">Initial value of Job.</param>
        /// <param name="screeningType">Initial value of ScreeningType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static JobPreferredScreening CreateJobPreferredScreening(string jobId, string screeningTypeId, global::Microsoft.Dynamics.DataEntities.Job job, global::Microsoft.Dynamics.DataEntities.ScreeningType screeningType)
        {
            JobPreferredScreening jobPreferredScreening = new JobPreferredScreening();
            jobPreferredScreening.JobId = jobId;
            jobPreferredScreening.ScreeningTypeId = screeningTypeId;
            if ((job == null))
            {
                throw new global::System.ArgumentNullException("job");
            }
            jobPreferredScreening.Job = job;
            if ((screeningType == null))
            {
                throw new global::System.ArgumentNullException("screeningType");
            }
            jobPreferredScreening.ScreeningType = screeningType;
            return jobPreferredScreening;
        }
        /// <summary>
        /// There are no comments for Property JobId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JobId is required.")]
        public virtual string JobId
        {
            get
            {
                return this._JobId;
            }
            set
            {
                this.OnJobIdChanging(value);
                this._JobId = value;
                this.OnJobIdChanged();
                this.OnPropertyChanged("JobId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobId;
        partial void OnJobIdChanging(string value);
        partial void OnJobIdChanged();
        /// <summary>
        /// There are no comments for Property ScreeningTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ScreeningTypeId is required.")]
        public virtual string ScreeningTypeId
        {
            get
            {
                return this._ScreeningTypeId;
            }
            set
            {
                this.OnScreeningTypeIdChanging(value);
                this._ScreeningTypeId = value;
                this.OnScreeningTypeIdChanged();
                this.OnPropertyChanged("ScreeningTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ScreeningTypeId;
        partial void OnScreeningTypeIdChanging(string value);
        partial void OnScreeningTypeIdChanged();
        /// <summary>
        /// There are no comments for Property Job in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Job is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Job Job
        {
            get
            {
                return this._Job;
            }
            set
            {
                this.OnJobChanging(value);
                this._Job = value;
                this.OnJobChanged();
                this.OnPropertyChanged("Job");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Job _Job;
        partial void OnJobChanging(global::Microsoft.Dynamics.DataEntities.Job value);
        partial void OnJobChanged();
        /// <summary>
        /// There are no comments for Property ScreeningType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ScreeningType is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ScreeningType ScreeningType
        {
            get
            {
                return this._ScreeningType;
            }
            set
            {
                this.OnScreeningTypeChanging(value);
                this._ScreeningType = value;
                this.OnScreeningTypeChanged();
                this.OnPropertyChanged("ScreeningType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ScreeningType _ScreeningType;
        partial void OnScreeningTypeChanging(global::Microsoft.Dynamics.DataEntities.ScreeningType value);
        partial void OnScreeningTypeChanged();
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
