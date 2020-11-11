﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/8/2020 8:07:52 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for JobTemplateResponsibilitySingle in the schema.
        /// </summary>
    public partial class JobTemplateResponsibilitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<JobTemplateResponsibility>
    {
        /// <summary>
        /// Initialize a new JobTemplateResponsibilitySingle object.
        /// </summary>
        public JobTemplateResponsibilitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new JobTemplateResponsibilitySingle object.
        /// </summary>
        public JobTemplateResponsibilitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new JobTemplateResponsibilitySingle object.
        /// </summary>
        public JobTemplateResponsibilitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<JobTemplateResponsibility> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for JobTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobTemplateSingle JobTemplate
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTemplate == null))
                {
                    this._JobTemplate = new global::Microsoft.Dynamics.DataEntities.JobTemplateSingle(this.Context, GetPath("JobTemplate"));
                }
                return this._JobTemplate;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobTemplateSingle _JobTemplate;
        /// <summary>
        /// There are no comments for Responsibility in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ResponsibilitySingle Responsibility
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Responsibility == null))
                {
                    this._Responsibility = new global::Microsoft.Dynamics.DataEntities.ResponsibilitySingle(this.Context, GetPath("Responsibility"));
                }
                return this._Responsibility;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ResponsibilitySingle _Responsibility;
    }
        /// <summary>
        /// There are no comments for JobTemplateResponsibility in the schema.
        /// </summary>
    /// <KeyProperties>
    /// JobTemplateId
    /// AreaOfResponsibilityId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("JobTemplateId", "AreaOfResponsibilityId")]
    [global::Microsoft.OData.Client.EntitySet("JobTemplateResponsibilities")]
    public partial class JobTemplateResponsibility : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new JobTemplateResponsibility object.
        /// </summary>
        /// <param name="jobTemplateId">Initial value of JobTemplateId.</param>
        /// <param name="areaOfResponsibilityId">Initial value of AreaOfResponsibilityId.</param>
        /// <param name="jobTemplate">Initial value of JobTemplate.</param>
        /// <param name="responsibility">Initial value of Responsibility.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static JobTemplateResponsibility CreateJobTemplateResponsibility(string jobTemplateId, string areaOfResponsibilityId, global::Microsoft.Dynamics.DataEntities.JobTemplate jobTemplate, global::Microsoft.Dynamics.DataEntities.Responsibility responsibility)
        {
            JobTemplateResponsibility jobTemplateResponsibility = new JobTemplateResponsibility();
            jobTemplateResponsibility.JobTemplateId = jobTemplateId;
            jobTemplateResponsibility.AreaOfResponsibilityId = areaOfResponsibilityId;
            if ((jobTemplate == null))
            {
                throw new global::System.ArgumentNullException("jobTemplate");
            }
            jobTemplateResponsibility.JobTemplate = jobTemplate;
            if ((responsibility == null))
            {
                throw new global::System.ArgumentNullException("responsibility");
            }
            jobTemplateResponsibility.Responsibility = responsibility;
            return jobTemplateResponsibility;
        }
        /// <summary>
        /// There are no comments for Property JobTemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobTemplateId
        {
            get
            {
                return this._JobTemplateId;
            }
            set
            {
                this.OnJobTemplateIdChanging(value);
                this._JobTemplateId = value;
                this.OnJobTemplateIdChanged();
                this.OnPropertyChanged("JobTemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTemplateId;
        partial void OnJobTemplateIdChanging(string value);
        partial void OnJobTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property AreaOfResponsibilityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AreaOfResponsibilityId
        {
            get
            {
                return this._AreaOfResponsibilityId;
            }
            set
            {
                this.OnAreaOfResponsibilityIdChanging(value);
                this._AreaOfResponsibilityId = value;
                this.OnAreaOfResponsibilityIdChanged();
                this.OnPropertyChanged("AreaOfResponsibilityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AreaOfResponsibilityId;
        partial void OnAreaOfResponsibilityIdChanging(string value);
        partial void OnAreaOfResponsibilityIdChanged();
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
        /// There are no comments for Property JobTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobTemplate JobTemplate
        {
            get
            {
                return this._JobTemplate;
            }
            set
            {
                this.OnJobTemplateChanging(value);
                this._JobTemplate = value;
                this.OnJobTemplateChanged();
                this.OnPropertyChanged("JobTemplate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobTemplate _JobTemplate;
        partial void OnJobTemplateChanging(global::Microsoft.Dynamics.DataEntities.JobTemplate value);
        partial void OnJobTemplateChanged();
        /// <summary>
        /// There are no comments for Property Responsibility in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Responsibility Responsibility
        {
            get
            {
                return this._Responsibility;
            }
            set
            {
                this.OnResponsibilityChanging(value);
                this._Responsibility = value;
                this.OnResponsibilityChanged();
                this.OnPropertyChanged("Responsibility");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Responsibility _Responsibility;
        partial void OnResponsibilityChanging(global::Microsoft.Dynamics.DataEntities.Responsibility value);
        partial void OnResponsibilityChanged();
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