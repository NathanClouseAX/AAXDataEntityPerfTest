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
    /// There are no comments for CourseTypeSingle in the schema.
    /// </summary>
    public partial class CourseTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CourseType>
    {
        /// <summary>
        /// Initialize a new CourseTypeSingle object.
        /// </summary>
        public CourseTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CourseTypeSingle object.
        /// </summary>
        public CourseTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CourseTypeSingle object.
        /// </summary>
        public CourseTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CourseType> query)
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
        /// There are no comments for CourseTypeNotes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeNotes> CourseTypeNotes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseTypeNotes == null))
                {
                    this._CourseTypeNotes = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeNotes>(GetPath("CourseTypeNotes"));
                }
                return this._CourseTypeNotes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeNotes> _CourseTypeNotes;
        /// <summary>
        /// There are no comments for CourseTypeSkillProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeSkillProfile> CourseTypeSkillProfile
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseTypeSkillProfile == null))
                {
                    this._CourseTypeSkillProfile = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeSkillProfile>(GetPath("CourseTypeSkillProfile"));
                }
                return this._CourseTypeSkillProfile;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeSkillProfile> _CourseTypeSkillProfile;
        /// <summary>
        /// There are no comments for CourseGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CourseGroupSingle CourseGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseGroup == null))
                {
                    this._CourseGroup = new global::Microsoft.Dynamics.DataEntities.CourseGroupSingle(this.Context, GetPath("CourseGroup"));
                }
                return this._CourseGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CourseGroupSingle _CourseGroup;
        /// <summary>
        /// There are no comments for CourseTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTable> CourseTable
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseTable == null))
                {
                    this._CourseTable = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CourseTable>(GetPath("CourseTable"));
                }
                return this._CourseTable;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTable> _CourseTable;
        /// <summary>
        /// There are no comments for CourseTypeDefaultDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeDefaultDimension> CourseTypeDefaultDimension
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseTypeDefaultDimension == null))
                {
                    this._CourseTypeDefaultDimension = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeDefaultDimension>(GetPath("CourseTypeDefaultDimension"));
                }
                return this._CourseTypeDefaultDimension;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeDefaultDimension> _CourseTypeDefaultDimension;
        /// <summary>
        /// There are no comments for CourseTypeCertificateProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeCertificateProfile> CourseTypeCertificateProfile
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseTypeCertificateProfile == null))
                {
                    this._CourseTypeCertificateProfile = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeCertificateProfile>(GetPath("CourseTypeCertificateProfile"));
                }
                return this._CourseTypeCertificateProfile;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTypeCertificateProfile> _CourseTypeCertificateProfile;
    }
    /// <summary>
    /// There are no comments for CourseType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CourseType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CourseType")]
    [global::Microsoft.OData.Client.EntitySet("CourseTypes")]
    public partial class CourseType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CourseType object.
        /// </summary>
        /// <param name="courseType1">Initial value of CourseType1.</param>
        /// <param name="minimumNumberOfParticipants">Initial value of MinimumNumberOfParticipants.</param>
        /// <param name="numberOfDays">Initial value of NumberOfDays.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CourseType CreateCourseType(string courseType1, int minimumNumberOfParticipants, int numberOfDays)
        {
            CourseType courseType = new CourseType();
            courseType.CourseType1 = courseType1;
            courseType.MinimumNumberOfParticipants = minimumNumberOfParticipants;
            courseType.NumberOfDays = numberOfDays;
            return courseType;
        }
        /// <summary>
        /// There are no comments for Property CourseType1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CourseType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CourseType1 is required.")]
        public virtual string CourseType1
        {
            get
            {
                return this._CourseType1;
            }
            set
            {
                this.OnCourseType1Changing(value);
                this._CourseType1 = value;
                this.OnCourseType1Changed();
                this.OnPropertyChanged("CourseType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CourseType1;
        partial void OnCourseType1Changing(string value);
        partial void OnCourseType1Changed();
        /// <summary>
        /// There are no comments for Property GroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string GroupId
        {
            get
            {
                return this._GroupId;
            }
            set
            {
                this.OnGroupIdChanging(value);
                this._GroupId = value;
                this.OnGroupIdChanged();
                this.OnPropertyChanged("GroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupId;
        partial void OnGroupIdChanging(string value);
        partial void OnGroupIdChanged();
        /// <summary>
        /// There are no comments for Property AllowEmployeeSelfRegistration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowEmployeeSelfRegistration
        {
            get
            {
                return this._AllowEmployeeSelfRegistration;
            }
            set
            {
                this.OnAllowEmployeeSelfRegistrationChanging(value);
                this._AllowEmployeeSelfRegistration = value;
                this.OnAllowEmployeeSelfRegistrationChanged();
                this.OnPropertyChanged("AllowEmployeeSelfRegistration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowEmployeeSelfRegistration;
        partial void OnAllowEmployeeSelfRegistrationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowEmployeeSelfRegistrationChanged();
        /// <summary>
        /// There are no comments for Property MinimumNumberOfParticipants in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MinimumNumberOfParticipants is required.")]
        public virtual int MinimumNumberOfParticipants
        {
            get
            {
                return this._MinimumNumberOfParticipants;
            }
            set
            {
                this.OnMinimumNumberOfParticipantsChanging(value);
                this._MinimumNumberOfParticipants = value;
                this.OnMinimumNumberOfParticipantsChanged();
                this.OnPropertyChanged("MinimumNumberOfParticipants");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _MinimumNumberOfParticipants;
        partial void OnMinimumNumberOfParticipantsChanging(int value);
        partial void OnMinimumNumberOfParticipantsChanged();
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
        /// There are no comments for Property NumberOfDays in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NumberOfDays is required.")]
        public virtual int NumberOfDays
        {
            get
            {
                return this._NumberOfDays;
            }
            set
            {
                this.OnNumberOfDaysChanging(value);
                this._NumberOfDays = value;
                this.OnNumberOfDaysChanged();
                this.OnPropertyChanged("NumberOfDays");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NumberOfDays;
        partial void OnNumberOfDaysChanging(int value);
        partial void OnNumberOfDaysChanged();
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
        /// There are no comments for Property CourseTypeNotes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeNotes> CourseTypeNotes
        {
            get
            {
                return this._CourseTypeNotes;
            }
            set
            {
                this.OnCourseTypeNotesChanging(value);
                this._CourseTypeNotes = value;
                this.OnCourseTypeNotesChanged();
                this.OnPropertyChanged("CourseTypeNotes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeNotes> _CourseTypeNotes = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeNotes>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCourseTypeNotesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeNotes> value);
        partial void OnCourseTypeNotesChanged();
        /// <summary>
        /// There are no comments for Property CourseTypeSkillProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeSkillProfile> CourseTypeSkillProfile
        {
            get
            {
                return this._CourseTypeSkillProfile;
            }
            set
            {
                this.OnCourseTypeSkillProfileChanging(value);
                this._CourseTypeSkillProfile = value;
                this.OnCourseTypeSkillProfileChanged();
                this.OnPropertyChanged("CourseTypeSkillProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeSkillProfile> _CourseTypeSkillProfile = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeSkillProfile>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCourseTypeSkillProfileChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeSkillProfile> value);
        partial void OnCourseTypeSkillProfileChanged();
        /// <summary>
        /// There are no comments for Property CourseGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.Dynamics.DataEntities.CourseGroup CourseGroup
        {
            get
            {
                return this._CourseGroup;
            }
            set
            {
                this.OnCourseGroupChanging(value);
                this._CourseGroup = value;
                this.OnCourseGroupChanged();
                this.OnPropertyChanged("CourseGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CourseGroup _CourseGroup;
        partial void OnCourseGroupChanging(global::Microsoft.Dynamics.DataEntities.CourseGroup value);
        partial void OnCourseGroupChanged();
        /// <summary>
        /// There are no comments for Property CourseTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTable> CourseTable
        {
            get
            {
                return this._CourseTable;
            }
            set
            {
                this.OnCourseTableChanging(value);
                this._CourseTable = value;
                this.OnCourseTableChanged();
                this.OnPropertyChanged("CourseTable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTable> _CourseTable = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTable>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCourseTableChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTable> value);
        partial void OnCourseTableChanged();
        /// <summary>
        /// There are no comments for Property CourseTypeDefaultDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeDefaultDimension> CourseTypeDefaultDimension
        {
            get
            {
                return this._CourseTypeDefaultDimension;
            }
            set
            {
                this.OnCourseTypeDefaultDimensionChanging(value);
                this._CourseTypeDefaultDimension = value;
                this.OnCourseTypeDefaultDimensionChanged();
                this.OnPropertyChanged("CourseTypeDefaultDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeDefaultDimension> _CourseTypeDefaultDimension = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeDefaultDimension>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCourseTypeDefaultDimensionChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeDefaultDimension> value);
        partial void OnCourseTypeDefaultDimensionChanged();
        /// <summary>
        /// There are no comments for Property CourseTypeCertificateProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeCertificateProfile> CourseTypeCertificateProfile
        {
            get
            {
                return this._CourseTypeCertificateProfile;
            }
            set
            {
                this.OnCourseTypeCertificateProfileChanging(value);
                this._CourseTypeCertificateProfile = value;
                this.OnCourseTypeCertificateProfileChanged();
                this.OnPropertyChanged("CourseTypeCertificateProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeCertificateProfile> _CourseTypeCertificateProfile = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeCertificateProfile>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCourseTypeCertificateProfileChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTypeCertificateProfile> value);
        partial void OnCourseTypeCertificateProfileChanged();
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
