﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:24:13 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for CourseTypeEducationProfileSingle in the schema.
    /// </summary>
    public partial class CourseTypeEducationProfileSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CourseTypeEducationProfile>
    {
        /// <summary>
        /// Initialize a new CourseTypeEducationProfileSingle object.
        /// </summary>
        public CourseTypeEducationProfileSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CourseTypeEducationProfileSingle object.
        /// </summary>
        public CourseTypeEducationProfileSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CourseTypeEducationProfileSingle object.
        /// </summary>
        public CourseTypeEducationProfileSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CourseTypeEducationProfile> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EducationDiscipline in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EducationDisciplineSingle EducationDiscipline
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EducationDiscipline == null))
                {
                    this._EducationDiscipline = new global::Microsoft.Dynamics.DataEntities.EducationDisciplineSingle(this.Context, GetPath("EducationDiscipline"));
                }
                return this._EducationDiscipline;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EducationDisciplineSingle _EducationDiscipline;
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
    }
    /// <summary>
    /// There are no comments for CourseTypeEducationProfile in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CourseTypeId
    /// EducationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CourseTypeId", "EducationId")]
    [global::Microsoft.OData.Client.EntitySet("CourseTypeEducationProfiles")]
    public partial class CourseTypeEducationProfile : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CourseTypeEducationProfile object.
        /// </summary>
        /// <param name="courseTypeId">Initial value of CourseTypeId.</param>
        /// <param name="educationId">Initial value of EducationId.</param>
        /// <param name="educationDiscipline">Initial value of EducationDiscipline.</param>
        /// <param name="courseType">Initial value of CourseType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CourseTypeEducationProfile CreateCourseTypeEducationProfile(string courseTypeId, string educationId, global::Microsoft.Dynamics.DataEntities.EducationDiscipline educationDiscipline, global::Microsoft.Dynamics.DataEntities.CourseType courseType)
        {
            CourseTypeEducationProfile courseTypeEducationProfile = new CourseTypeEducationProfile();
            courseTypeEducationProfile.CourseTypeId = courseTypeId;
            courseTypeEducationProfile.EducationId = educationId;
            if ((educationDiscipline == null))
            {
                throw new global::System.ArgumentNullException("educationDiscipline");
            }
            courseTypeEducationProfile.EducationDiscipline = educationDiscipline;
            if ((courseType == null))
            {
                throw new global::System.ArgumentNullException("courseType");
            }
            courseTypeEducationProfile.CourseType = courseType;
            return courseTypeEducationProfile;
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
        /// There are no comments for Property EducationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EducationId
        {
            get
            {
                return this._EducationId;
            }
            set
            {
                this.OnEducationIdChanging(value);
                this._EducationId = value;
                this.OnEducationIdChanged();
                this.OnPropertyChanged("EducationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EducationId;
        partial void OnEducationIdChanging(string value);
        partial void OnEducationIdChanged();
        /// <summary>
        /// There are no comments for Property EducationDiscipline in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EducationDiscipline EducationDiscipline
        {
            get
            {
                return this._EducationDiscipline;
            }
            set
            {
                this.OnEducationDisciplineChanging(value);
                this._EducationDiscipline = value;
                this.OnEducationDisciplineChanged();
                this.OnPropertyChanged("EducationDiscipline");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EducationDiscipline _EducationDiscipline;
        partial void OnEducationDisciplineChanging(global::Microsoft.Dynamics.DataEntities.EducationDiscipline value);
        partial void OnEducationDisciplineChanged();
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