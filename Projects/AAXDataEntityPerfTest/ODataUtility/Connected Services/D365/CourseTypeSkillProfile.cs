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
        /// There are no comments for CourseTypeSkillProfileSingle in the schema.
        /// </summary>
    public partial class CourseTypeSkillProfileSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CourseTypeSkillProfile>
    {
        /// <summary>
        /// Initialize a new CourseTypeSkillProfileSingle object.
        /// </summary>
        public CourseTypeSkillProfileSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CourseTypeSkillProfileSingle object.
        /// </summary>
        public CourseTypeSkillProfileSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CourseTypeSkillProfileSingle object.
        /// </summary>
        public CourseTypeSkillProfileSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CourseTypeSkillProfile> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RatingModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RatingModelSingle RatingModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RatingModel == null))
                {
                    this._RatingModel = new global::Microsoft.Dynamics.DataEntities.RatingModelSingle(this.Context, GetPath("RatingModel"));
                }
                return this._RatingModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RatingModelSingle _RatingModel;
        /// <summary>
        /// There are no comments for CourseType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CourseTypeSingle CourseType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseType == null))
                {
                    this._CourseType = new global::Microsoft.Dynamics.DataEntities.CourseTypeSingle(this.Context, GetPath("CourseType"));
                }
                return this._CourseType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CourseTypeSingle _CourseType;
        /// <summary>
        /// There are no comments for RatingLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RatingLevelSingle RatingLevel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RatingLevel == null))
                {
                    this._RatingLevel = new global::Microsoft.Dynamics.DataEntities.RatingLevelSingle(this.Context, GetPath("RatingLevel"));
                }
                return this._RatingLevel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RatingLevelSingle _RatingLevel;
        /// <summary>
        /// There are no comments for Skill in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.SkillSingle Skill
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Skill == null))
                {
                    this._Skill = new global::Microsoft.Dynamics.DataEntities.SkillSingle(this.Context, GetPath("Skill"));
                }
                return this._Skill;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SkillSingle _Skill;
    }
        /// <summary>
        /// There are no comments for CourseTypeSkillProfile in the schema.
        /// </summary>
    /// <KeyProperties>
    /// CourseTypeId
    /// SkillId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CourseTypeId", "SkillId")]
    [global::Microsoft.OData.Client.EntitySet("CourseTypeSkillProfiles")]
    public partial class CourseTypeSkillProfile : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CourseTypeSkillProfile object.
        /// </summary>
        /// <param name="courseTypeId">Initial value of CourseTypeId.</param>
        /// <param name="skillId">Initial value of SkillId.</param>
        /// <param name="ratingModel">Initial value of RatingModel.</param>
        /// <param name="courseType">Initial value of CourseType.</param>
        /// <param name="ratingLevel">Initial value of RatingLevel.</param>
        /// <param name="skill">Initial value of Skill.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CourseTypeSkillProfile CreateCourseTypeSkillProfile(string courseTypeId, 
                    string skillId, 
                    global::Microsoft.Dynamics.DataEntities.RatingModel ratingModel, 
                    global::Microsoft.Dynamics.DataEntities.CourseType courseType, 
                    global::Microsoft.Dynamics.DataEntities.RatingLevel ratingLevel, 
                    global::Microsoft.Dynamics.DataEntities.Skill skill)
        {
            CourseTypeSkillProfile courseTypeSkillProfile = new CourseTypeSkillProfile();
            courseTypeSkillProfile.CourseTypeId = courseTypeId;
            courseTypeSkillProfile.SkillId = skillId;
            if ((ratingModel == null))
            {
                throw new global::System.ArgumentNullException("ratingModel");
            }
            courseTypeSkillProfile.RatingModel = ratingModel;
            if ((courseType == null))
            {
                throw new global::System.ArgumentNullException("courseType");
            }
            courseTypeSkillProfile.CourseType = courseType;
            if ((ratingLevel == null))
            {
                throw new global::System.ArgumentNullException("ratingLevel");
            }
            courseTypeSkillProfile.RatingLevel = ratingLevel;
            if ((skill == null))
            {
                throw new global::System.ArgumentNullException("skill");
            }
            courseTypeSkillProfile.Skill = skill;
            return courseTypeSkillProfile;
        }
        /// <summary>
        /// There are no comments for Property CourseTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CourseTypeId
        {
            get
            {
                return this._CourseTypeId;
            }
            set
            {
                this.OnCourseTypeIdChanging(value);
                this._CourseTypeId = value;
                this.OnCourseTypeIdChanged();
                this.OnPropertyChanged("CourseTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CourseTypeId;
        partial void OnCourseTypeIdChanging(string value);
        partial void OnCourseTypeIdChanged();
        /// <summary>
        /// There are no comments for Property SkillId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SkillId
        {
            get
            {
                return this._SkillId;
            }
            set
            {
                this.OnSkillIdChanging(value);
                this._SkillId = value;
                this.OnSkillIdChanged();
                this.OnPropertyChanged("SkillId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SkillId;
        partial void OnSkillIdChanging(string value);
        partial void OnSkillIdChanged();
        /// <summary>
        /// There are no comments for Property LevelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LevelId
        {
            get
            {
                return this._LevelId;
            }
            set
            {
                this.OnLevelIdChanging(value);
                this._LevelId = value;
                this.OnLevelIdChanged();
                this.OnPropertyChanged("LevelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LevelId;
        partial void OnLevelIdChanging(string value);
        partial void OnLevelIdChanged();
        /// <summary>
        /// There are no comments for Property RatingId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RatingId
        {
            get
            {
                return this._RatingId;
            }
            set
            {
                this.OnRatingIdChanging(value);
                this._RatingId = value;
                this.OnRatingIdChanged();
                this.OnPropertyChanged("RatingId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RatingId;
        partial void OnRatingIdChanging(string value);
        partial void OnRatingIdChanged();
        /// <summary>
        /// There are no comments for Property RatingModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RatingModel RatingModel
        {
            get
            {
                return this._RatingModel;
            }
            set
            {
                this.OnRatingModelChanging(value);
                this._RatingModel = value;
                this.OnRatingModelChanged();
                this.OnPropertyChanged("RatingModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RatingModel _RatingModel;
        partial void OnRatingModelChanging(global::Microsoft.Dynamics.DataEntities.RatingModel value);
        partial void OnRatingModelChanged();
        /// <summary>
        /// There are no comments for Property CourseType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CourseType CourseType
        {
            get
            {
                return this._CourseType;
            }
            set
            {
                this.OnCourseTypeChanging(value);
                this._CourseType = value;
                this.OnCourseTypeChanged();
                this.OnPropertyChanged("CourseType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CourseType _CourseType;
        partial void OnCourseTypeChanging(global::Microsoft.Dynamics.DataEntities.CourseType value);
        partial void OnCourseTypeChanged();
        /// <summary>
        /// There are no comments for Property RatingLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RatingLevel RatingLevel
        {
            get
            {
                return this._RatingLevel;
            }
            set
            {
                this.OnRatingLevelChanging(value);
                this._RatingLevel = value;
                this.OnRatingLevelChanged();
                this.OnPropertyChanged("RatingLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RatingLevel _RatingLevel;
        partial void OnRatingLevelChanging(global::Microsoft.Dynamics.DataEntities.RatingLevel value);
        partial void OnRatingLevelChanged();
        /// <summary>
        /// There are no comments for Property Skill in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Skill Skill
        {
            get
            {
                return this._Skill;
            }
            set
            {
                this.OnSkillChanging(value);
                this._Skill = value;
                this.OnSkillChanged();
                this.OnPropertyChanged("Skill");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Skill _Skill;
        partial void OnSkillChanging(global::Microsoft.Dynamics.DataEntities.Skill value);
        partial void OnSkillChanged();
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
