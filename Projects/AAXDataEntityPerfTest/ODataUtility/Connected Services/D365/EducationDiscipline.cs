﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 12/8/2020 7:45:22 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for EducationDisciplineSingle in the schema.
        /// </summary>
    public partial class EducationDisciplineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EducationDiscipline>
    {
        /// <summary>
        /// Initialize a new EducationDisciplineSingle object.
        /// </summary>
        public EducationDisciplineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EducationDisciplineSingle object.
        /// </summary>
        public EducationDisciplineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EducationDisciplineSingle object.
        /// </summary>
        public EducationDisciplineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EducationDiscipline> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CourseTypeEducationProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeEducationProfile> CourseTypeEducationProfile
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseTypeEducationProfile == null))
                {
                    this._CourseTypeEducationProfile = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeEducationProfile>(GetPath("CourseTypeEducationProfile"));
                }
                return this._CourseTypeEducationProfile;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeEducationProfile> _CourseTypeEducationProfile;
        /// <summary>
        /// There are no comments for JobPreferredEducationDisciplines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobPreferredEducationDiscipline> JobPreferredEducationDisciplines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobPreferredEducationDisciplines == null))
                {
                    this._JobPreferredEducationDisciplines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobPreferredEducationDiscipline>(GetPath("JobPreferredEducationDisciplines"));
                }
                return this._JobPreferredEducationDisciplines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobPreferredEducationDiscipline> _JobPreferredEducationDisciplines;
        /// <summary>
        /// There are no comments for EducationDisciplineGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EducationDisciplineGroup> EducationDisciplineGroups
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EducationDisciplineGroups == null))
                {
                    this._EducationDisciplineGroups = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EducationDisciplineGroup>(GetPath("EducationDisciplineGroups"));
                }
                return this._EducationDisciplineGroups;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EducationDisciplineGroup> _EducationDisciplineGroups;
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
    }
        /// <summary>
        /// There are no comments for EducationDiscipline in the schema.
        /// </summary>
    /// <KeyProperties>
    /// EducationDiscipline
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EducationDiscipline")]
    [global::Microsoft.OData.Client.EntitySet("EducationDisciplines")]
    public partial class EducationDiscipline : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EducationDiscipline object.
        /// </summary>
        /// <param name="educationDiscipline1">Initial value of EducationDiscipline1.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EducationDiscipline CreateEducationDiscipline(string educationDiscipline1)
        {
            EducationDiscipline educationDiscipline = new EducationDiscipline();
            educationDiscipline.EducationDiscipline1 = educationDiscipline1;
            return educationDiscipline;
        }
        /// <summary>
        /// There are no comments for Property EducationDiscipline1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EducationDiscipline")]
        public virtual string EducationDiscipline1
        {
            get
            {
                return this._EducationDiscipline1;
            }
            set
            {
                this.OnEducationDiscipline1Changing(value);
                this._EducationDiscipline1 = value;
                this.OnEducationDiscipline1Changed();
                this.OnPropertyChanged("EducationDiscipline");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EducationDiscipline1;
        partial void OnEducationDiscipline1Changing(string value);
        partial void OnEducationDiscipline1Changed();
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
        /// There are no comments for Property CourseTypeEducationProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeEducationProfile> CourseTypeEducationProfile
        {
            get
            {
                return this._CourseTypeEducationProfile;
            }
            set
            {
                this.OnCourseTypeEducationProfileChanging(value);
                this._CourseTypeEducationProfile = value;
                this.OnCourseTypeEducationProfileChanged();
                this.OnPropertyChanged("CourseTypeEducationProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeEducationProfile> _CourseTypeEducationProfile = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeEducationProfile>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCourseTypeEducationProfileChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeEducationProfile> value);
        partial void OnCourseTypeEducationProfileChanged();
        /// <summary>
        /// There are no comments for Property JobPreferredEducationDisciplines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredEducationDiscipline> JobPreferredEducationDisciplines
        {
            get
            {
                return this._JobPreferredEducationDisciplines;
            }
            set
            {
                this.OnJobPreferredEducationDisciplinesChanging(value);
                this._JobPreferredEducationDisciplines = value;
                this.OnJobPreferredEducationDisciplinesChanged();
                this.OnPropertyChanged("JobPreferredEducationDisciplines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredEducationDiscipline> _JobPreferredEducationDisciplines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredEducationDiscipline>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobPreferredEducationDisciplinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredEducationDiscipline> value);
        partial void OnJobPreferredEducationDisciplinesChanged();
        /// <summary>
        /// There are no comments for Property EducationDisciplineGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EducationDisciplineGroup> EducationDisciplineGroups
        {
            get
            {
                return this._EducationDisciplineGroups;
            }
            set
            {
                this.OnEducationDisciplineGroupsChanging(value);
                this._EducationDisciplineGroups = value;
                this.OnEducationDisciplineGroupsChanged();
                this.OnPropertyChanged("EducationDisciplineGroups");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EducationDisciplineGroup> _EducationDisciplineGroups = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EducationDisciplineGroup>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEducationDisciplineGroupsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EducationDisciplineGroup> value);
        partial void OnEducationDisciplineGroupsChanged();
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
