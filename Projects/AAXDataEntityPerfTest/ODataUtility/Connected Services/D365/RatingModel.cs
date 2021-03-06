﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 7/17/2021 8:49:18 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for RatingModelSingle in the schema.
        /// </summary>
    public partial class RatingModelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RatingModel>
    {
        /// <summary>
        /// Initialize a new RatingModelSingle object.
        /// </summary>
        public RatingModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RatingModelSingle object.
        /// </summary>
        public RatingModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RatingModelSingle object.
        /// </summary>
        public RatingModelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RatingModel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RatingLevels in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RatingLevel> RatingLevels
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RatingLevels == null))
                {
                    this._RatingLevels = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RatingLevel>(GetPath("RatingLevels"));
                }
                return this._RatingLevels;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RatingLevel> _RatingLevels;
        /// <summary>
        /// There are no comments for JobPreferredSkill in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobPreferredSkill> JobPreferredSkill
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobPreferredSkill == null))
                {
                    this._JobPreferredSkill = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobPreferredSkill>(GetPath("JobPreferredSkill"));
                }
                return this._JobPreferredSkill;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobPreferredSkill> _JobPreferredSkill;
        /// <summary>
        /// There are no comments for HcmRatingModel_HcmSkill in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Skill> HcmRatingModel_HcmSkill
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._HcmRatingModel_HcmSkill == null))
                {
                    this._HcmRatingModel_HcmSkill = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Skill>(GetPath("HcmRatingModel_HcmSkill"));
                }
                return this._HcmRatingModel_HcmSkill;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Skill> _HcmRatingModel_HcmSkill;
        /// <summary>
        /// There are no comments for CourseTypeSkillProfiles in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeSkillProfile> CourseTypeSkillProfiles
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseTypeSkillProfiles == null))
                {
                    this._CourseTypeSkillProfiles = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeSkillProfile>(GetPath("CourseTypeSkillProfiles"));
                }
                return this._CourseTypeSkillProfiles;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeSkillProfile> _CourseTypeSkillProfiles;
    }
        /// <summary>
        /// There are no comments for RatingModel in the schema.
        /// </summary>
    /// <KeyProperties>
    /// RatingModelId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RatingModelId")]
    [global::Microsoft.OData.Client.EntitySet("RatingModels")]
    public partial class RatingModel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RatingModel object.
        /// </summary>
        /// <param name="ratingModelId">Initial value of RatingModelId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RatingModel CreateRatingModel(string ratingModelId)
        {
            RatingModel ratingModel = new RatingModel();
            ratingModel.RatingModelId = ratingModelId;
            return ratingModel;
        }
        /// <summary>
        /// There are no comments for Property RatingModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RatingModelId
        {
            get
            {
                return this._RatingModelId;
            }
            set
            {
                this.OnRatingModelIdChanging(value);
                this._RatingModelId = value;
                this.OnRatingModelIdChanged();
                this.OnPropertyChanged("RatingModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RatingModelId;
        partial void OnRatingModelIdChanging(string value);
        partial void OnRatingModelIdChanged();
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
        /// There are no comments for Property RatingLevels in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RatingLevel> RatingLevels
        {
            get
            {
                return this._RatingLevels;
            }
            set
            {
                this.OnRatingLevelsChanging(value);
                this._RatingLevels = value;
                this.OnRatingLevelsChanged();
                this.OnPropertyChanged("RatingLevels");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RatingLevel> _RatingLevels = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RatingLevel>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRatingLevelsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RatingLevel> value);
        partial void OnRatingLevelsChanged();
        /// <summary>
        /// There are no comments for Property JobPreferredSkill in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredSkill> JobPreferredSkill
        {
            get
            {
                return this._JobPreferredSkill;
            }
            set
            {
                this.OnJobPreferredSkillChanging(value);
                this._JobPreferredSkill = value;
                this.OnJobPreferredSkillChanged();
                this.OnPropertyChanged("JobPreferredSkill");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredSkill> _JobPreferredSkill = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredSkill>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobPreferredSkillChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredSkill> value);
        partial void OnJobPreferredSkillChanged();
        /// <summary>
        /// There are no comments for Property HcmRatingModel_HcmSkill in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Skill> HcmRatingModel_HcmSkill
        {
            get
            {
                return this._HcmRatingModel_HcmSkill;
            }
            set
            {
                this.OnHcmRatingModel_HcmSkillChanging(value);
                this._HcmRatingModel_HcmSkill = value;
                this.OnHcmRatingModel_HcmSkillChanged();
                this.OnPropertyChanged("HcmRatingModel_HcmSkill");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Skill> _HcmRatingModel_HcmSkill = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Skill>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnHcmRatingModel_HcmSkillChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Skill> value);
        partial void OnHcmRatingModel_HcmSkillChanged();
        /// <summary>
        /// There are no comments for Property CourseTypeSkillProfiles in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeSkillProfile> CourseTypeSkillProfiles
        {
            get
            {
                return this._CourseTypeSkillProfiles;
            }
            set
            {
                this.OnCourseTypeSkillProfilesChanging(value);
                this._CourseTypeSkillProfiles = value;
                this.OnCourseTypeSkillProfilesChanged();
                this.OnPropertyChanged("CourseTypeSkillProfiles");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeSkillProfile> _CourseTypeSkillProfiles = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeSkillProfile>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCourseTypeSkillProfilesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeSkillProfile> value);
        partial void OnCourseTypeSkillProfilesChanged();
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
