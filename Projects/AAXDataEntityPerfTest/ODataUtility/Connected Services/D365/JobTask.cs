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
        /// There are no comments for JobTaskSingle in the schema.
        /// </summary>
    public partial class JobTaskSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<JobTask>
    {
        /// <summary>
        /// Initialize a new JobTaskSingle object.
        /// </summary>
        public JobTaskSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new JobTaskSingle object.
        /// </summary>
        public JobTaskSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new JobTaskSingle object.
        /// </summary>
        public JobTaskSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<JobTask> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for JobTaskAssignments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTaskAssignment> JobTaskAssignments
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTaskAssignments == null))
                {
                    this._JobTaskAssignments = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobTaskAssignment>(GetPath("JobTaskAssignments"));
                }
                return this._JobTaskAssignments;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTaskAssignment> _JobTaskAssignments;
        /// <summary>
        /// There are no comments for JobTemplateTasks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateTask> JobTemplateTasks
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTemplateTasks == null))
                {
                    this._JobTemplateTasks = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateTask>(GetPath("JobTemplateTasks"));
                }
                return this._JobTemplateTasks;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateTask> _JobTemplateTasks;
    }
        /// <summary>
        /// There are no comments for JobTask in the schema.
        /// </summary>
    /// <KeyProperties>
    /// JobTaskId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("JobTaskId")]
    [global::Microsoft.OData.Client.EntitySet("JobTasks")]
    public partial class JobTask : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new JobTask object.
        /// </summary>
        /// <param name="jobTaskId">Initial value of JobTaskId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static JobTask CreateJobTask(string jobTaskId)
        {
            JobTask jobTask = new JobTask();
            jobTask.JobTaskId = jobTaskId;
            return jobTask;
        }
        /// <summary>
        /// There are no comments for Property JobTaskId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property JobTaskAssignments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTaskAssignment> JobTaskAssignments
        {
            get
            {
                return this._JobTaskAssignments;
            }
            set
            {
                this.OnJobTaskAssignmentsChanging(value);
                this._JobTaskAssignments = value;
                this.OnJobTaskAssignmentsChanged();
                this.OnPropertyChanged("JobTaskAssignments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTaskAssignment> _JobTaskAssignments = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTaskAssignment>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobTaskAssignmentsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTaskAssignment> value);
        partial void OnJobTaskAssignmentsChanged();
        /// <summary>
        /// There are no comments for Property JobTemplateTasks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateTask> JobTemplateTasks
        {
            get
            {
                return this._JobTemplateTasks;
            }
            set
            {
                this.OnJobTemplateTasksChanging(value);
                this._JobTemplateTasks = value;
                this.OnJobTemplateTasksChanged();
                this.OnPropertyChanged("JobTemplateTasks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateTask> _JobTemplateTasks = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateTask>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobTemplateTasksChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateTask> value);
        partial void OnJobTemplateTasksChanged();
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
