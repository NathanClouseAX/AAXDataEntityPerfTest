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
        /// There are no comments for JobTemplateSingle in the schema.
        /// </summary>
    public partial class JobTemplateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<JobTemplate>
    {
        /// <summary>
        /// Initialize a new JobTemplateSingle object.
        /// </summary>
        public JobTemplateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new JobTemplateSingle object.
        /// </summary>
        public JobTemplateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new JobTemplateSingle object.
        /// </summary>
        public JobTemplateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<JobTemplate> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for JobTemplateScreenings in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateScreening> JobTemplateScreenings
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTemplateScreenings == null))
                {
                    this._JobTemplateScreenings = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateScreening>(GetPath("JobTemplateScreenings"));
                }
                return this._JobTemplateScreenings;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateScreening> _JobTemplateScreenings;
        /// <summary>
        /// There are no comments for JobTemplateCertificates in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateCertificate> JobTemplateCertificates
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTemplateCertificates == null))
                {
                    this._JobTemplateCertificates = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateCertificate>(GetPath("JobTemplateCertificates"));
                }
                return this._JobTemplateCertificates;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateCertificate> _JobTemplateCertificates;
        /// <summary>
        /// There are no comments for JobTemplateEducationDisciplines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateEducationDiscipline> JobTemplateEducationDisciplines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTemplateEducationDisciplines == null))
                {
                    this._JobTemplateEducationDisciplines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateEducationDiscipline>(GetPath("JobTemplateEducationDisciplines"));
                }
                return this._JobTemplateEducationDisciplines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateEducationDiscipline> _JobTemplateEducationDisciplines;
        /// <summary>
        /// There are no comments for JobTemplateExams in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateExam> JobTemplateExams
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTemplateExams == null))
                {
                    this._JobTemplateExams = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateExam>(GetPath("JobTemplateExams"));
                }
                return this._JobTemplateExams;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateExam> _JobTemplateExams;
        /// <summary>
        /// There are no comments for JobTemplateSkills in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateSkill> JobTemplateSkills
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTemplateSkills == null))
                {
                    this._JobTemplateSkills = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateSkill>(GetPath("JobTemplateSkills"));
                }
                return this._JobTemplateSkills;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateSkill> _JobTemplateSkills;
        /// <summary>
        /// There are no comments for JobTemplateResponsibilities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateResponsibility> JobTemplateResponsibilities
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTemplateResponsibilities == null))
                {
                    this._JobTemplateResponsibilities = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateResponsibility>(GetPath("JobTemplateResponsibilities"));
                }
                return this._JobTemplateResponsibilities;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateResponsibility> _JobTemplateResponsibilities;
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
        /// <summary>
        /// There are no comments for JobADARequirement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobTemplateADARequirementSingle JobADARequirement
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobADARequirement == null))
                {
                    this._JobADARequirement = new global::Microsoft.Dynamics.DataEntities.JobTemplateADARequirementSingle(this.Context, GetPath("JobADARequirement"));
                }
                return this._JobADARequirement;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobTemplateADARequirementSingle _JobADARequirement;
    }
        /// <summary>
        /// There are no comments for JobTemplate in the schema.
        /// </summary>
    /// <KeyProperties>
    /// JobTemplate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("JobTemplate")]
    [global::Microsoft.OData.Client.EntitySet("JobTemplates")]
    public partial class JobTemplate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new JobTemplate object.
        /// </summary>
        /// <param name="jobTemplate1">Initial value of JobTemplate1.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static JobTemplate CreateJobTemplate(string jobTemplate1)
        {
            JobTemplate jobTemplate = new JobTemplate();
            jobTemplate.JobTemplate1 = jobTemplate1;
            return jobTemplate;
        }
        /// <summary>
        /// There are no comments for Property JobTemplate1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("JobTemplate")]
        public virtual string JobTemplate1
        {
            get
            {
                return this._JobTemplate1;
            }
            set
            {
                this.OnJobTemplate1Changing(value);
                this._JobTemplate1 = value;
                this.OnJobTemplate1Changed();
                this.OnPropertyChanged("JobTemplate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTemplate1;
        partial void OnJobTemplate1Changing(string value);
        partial void OnJobTemplate1Changed();
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
        /// There are no comments for Property JobTemplateScreenings in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateScreening> JobTemplateScreenings
        {
            get
            {
                return this._JobTemplateScreenings;
            }
            set
            {
                this.OnJobTemplateScreeningsChanging(value);
                this._JobTemplateScreenings = value;
                this.OnJobTemplateScreeningsChanged();
                this.OnPropertyChanged("JobTemplateScreenings");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateScreening> _JobTemplateScreenings = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateScreening>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobTemplateScreeningsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateScreening> value);
        partial void OnJobTemplateScreeningsChanged();
        /// <summary>
        /// There are no comments for Property JobTemplateCertificates in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateCertificate> JobTemplateCertificates
        {
            get
            {
                return this._JobTemplateCertificates;
            }
            set
            {
                this.OnJobTemplateCertificatesChanging(value);
                this._JobTemplateCertificates = value;
                this.OnJobTemplateCertificatesChanged();
                this.OnPropertyChanged("JobTemplateCertificates");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateCertificate> _JobTemplateCertificates = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateCertificate>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobTemplateCertificatesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateCertificate> value);
        partial void OnJobTemplateCertificatesChanged();
        /// <summary>
        /// There are no comments for Property JobTemplateEducationDisciplines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateEducationDiscipline> JobTemplateEducationDisciplines
        {
            get
            {
                return this._JobTemplateEducationDisciplines;
            }
            set
            {
                this.OnJobTemplateEducationDisciplinesChanging(value);
                this._JobTemplateEducationDisciplines = value;
                this.OnJobTemplateEducationDisciplinesChanged();
                this.OnPropertyChanged("JobTemplateEducationDisciplines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateEducationDiscipline> _JobTemplateEducationDisciplines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateEducationDiscipline>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobTemplateEducationDisciplinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateEducationDiscipline> value);
        partial void OnJobTemplateEducationDisciplinesChanged();
        /// <summary>
        /// There are no comments for Property JobTemplateExams in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateExam> JobTemplateExams
        {
            get
            {
                return this._JobTemplateExams;
            }
            set
            {
                this.OnJobTemplateExamsChanging(value);
                this._JobTemplateExams = value;
                this.OnJobTemplateExamsChanged();
                this.OnPropertyChanged("JobTemplateExams");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateExam> _JobTemplateExams = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateExam>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobTemplateExamsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateExam> value);
        partial void OnJobTemplateExamsChanged();
        /// <summary>
        /// There are no comments for Property JobTemplateSkills in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateSkill> JobTemplateSkills
        {
            get
            {
                return this._JobTemplateSkills;
            }
            set
            {
                this.OnJobTemplateSkillsChanging(value);
                this._JobTemplateSkills = value;
                this.OnJobTemplateSkillsChanged();
                this.OnPropertyChanged("JobTemplateSkills");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateSkill> _JobTemplateSkills = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateSkill>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobTemplateSkillsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateSkill> value);
        partial void OnJobTemplateSkillsChanged();
        /// <summary>
        /// There are no comments for Property JobTemplateResponsibilities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateResponsibility> JobTemplateResponsibilities
        {
            get
            {
                return this._JobTemplateResponsibilities;
            }
            set
            {
                this.OnJobTemplateResponsibilitiesChanging(value);
                this._JobTemplateResponsibilities = value;
                this.OnJobTemplateResponsibilitiesChanged();
                this.OnPropertyChanged("JobTemplateResponsibilities");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateResponsibility> _JobTemplateResponsibilities = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateResponsibility>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobTemplateResponsibilitiesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateResponsibility> value);
        partial void OnJobTemplateResponsibilitiesChanged();
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
        /// There are no comments for Property JobADARequirement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobTemplateADARequirement JobADARequirement
        {
            get
            {
                return this._JobADARequirement;
            }
            set
            {
                this.OnJobADARequirementChanging(value);
                this._JobADARequirement = value;
                this.OnJobADARequirementChanged();
                this.OnPropertyChanged("JobADARequirement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobTemplateADARequirement _JobADARequirement;
        partial void OnJobADARequirementChanging(global::Microsoft.Dynamics.DataEntities.JobTemplateADARequirement value);
        partial void OnJobADARequirementChanged();
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
