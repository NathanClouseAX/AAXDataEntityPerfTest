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
    /// There are no comments for JobTaskAssignmentSingle in the schema.
    /// </summary>
    public partial class JobTaskAssignmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<JobTaskAssignment>
    {
        /// <summary>
        /// Initialize a new JobTaskAssignmentSingle object.
        /// </summary>
        public JobTaskAssignmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new JobTaskAssignmentSingle object.
        /// </summary>
        public JobTaskAssignmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new JobTaskAssignmentSingle object.
        /// </summary>
        public JobTaskAssignmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<JobTaskAssignment> query)
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
        /// There are no comments for JobTask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobTaskSingle JobTask
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTask == null))
                {
                    this._JobTask = new global::Microsoft.Dynamics.DataEntities.JobTaskSingle(this.Context, GetPath("JobTask"));
                }
                return this._JobTask;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobTaskSingle _JobTask;
    }
    /// <summary>
    /// There are no comments for JobTaskAssignment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// JobId
    /// JobTaskId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("JobId", "JobTaskId")]
    [global::Microsoft.OData.Client.EntitySet("JobTaskAssignments")]
    public partial class JobTaskAssignment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new JobTaskAssignment object.
        /// </summary>
        /// <param name="jobId">Initial value of JobId.</param>
        /// <param name="jobTaskId">Initial value of JobTaskId.</param>
        /// <param name="job">Initial value of Job.</param>
        /// <param name="jobTask">Initial value of JobTask.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static JobTaskAssignment CreateJobTaskAssignment(string jobId, string jobTaskId, global::Microsoft.Dynamics.DataEntities.Job job, global::Microsoft.Dynamics.DataEntities.JobTask jobTask)
        {
            JobTaskAssignment jobTaskAssignment = new JobTaskAssignment();
            jobTaskAssignment.JobId = jobId;
            jobTaskAssignment.JobTaskId = jobTaskId;
            if ((job == null))
            {
                throw new global::System.ArgumentNullException("job");
            }
            jobTaskAssignment.Job = job;
            if ((jobTask == null))
            {
                throw new global::System.ArgumentNullException("jobTask");
            }
            jobTaskAssignment.JobTask = jobTask;
            return jobTaskAssignment;
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
        /// There are no comments for Property JobTaskId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JobTaskId is required.")]
        public virtual string JobTaskId
        {
            get
            {
                return this._JobTaskId;
            }
            set
            {
                this.OnJobTaskIdChanging(value);
                this._JobTaskId = value;
                this.OnJobTaskIdChanged();
                this.OnPropertyChanged("JobTaskId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTaskId;
        partial void OnJobTaskIdChanging(string value);
        partial void OnJobTaskIdChanged();
        /// <summary>
        /// There are no comments for Property Note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this.OnNoteChanging(value);
                this._Note = value;
                this.OnNoteChanged();
                this.OnPropertyChanged("Note");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Note;
        partial void OnNoteChanging(string value);
        partial void OnNoteChanged();
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
        /// There are no comments for Property JobTask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JobTask is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobTask JobTask
        {
            get
            {
                return this._JobTask;
            }
            set
            {
                this.OnJobTaskChanging(value);
                this._JobTask = value;
                this.OnJobTaskChanged();
                this.OnPropertyChanged("JobTask");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobTask _JobTask;
        partial void OnJobTaskChanging(global::Microsoft.Dynamics.DataEntities.JobTask value);
        partial void OnJobTaskChanged();
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
