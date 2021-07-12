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
        /// There are no comments for CourseTypeCertificateProfileSingle in the schema.
        /// </summary>
    public partial class CourseTypeCertificateProfileSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CourseTypeCertificateProfile>
    {
        /// <summary>
        /// Initialize a new CourseTypeCertificateProfileSingle object.
        /// </summary>
        public CourseTypeCertificateProfileSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CourseTypeCertificateProfileSingle object.
        /// </summary>
        public CourseTypeCertificateProfileSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CourseTypeCertificateProfileSingle object.
        /// </summary>
        public CourseTypeCertificateProfileSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CourseTypeCertificateProfile> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CertificateType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CertificateTypeSingle CertificateType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CertificateType == null))
                {
                    this._CertificateType = new global::Microsoft.Dynamics.DataEntities.CertificateTypeSingle(this.Context, GetPath("CertificateType"));
                }
                return this._CertificateType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CertificateTypeSingle _CertificateType;
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
        /// There are no comments for CourseTypeCertificateProfile in the schema.
        /// </summary>
    /// <KeyProperties>
    /// CourseTypeId
    /// CertificateTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CourseTypeId", "CertificateTypeId")]
    [global::Microsoft.OData.Client.EntitySet("CourseTypeCertificateProfiles")]
    public partial class CourseTypeCertificateProfile : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CourseTypeCertificateProfile object.
        /// </summary>
        /// <param name="courseTypeId">Initial value of CourseTypeId.</param>
        /// <param name="certificateTypeId">Initial value of CertificateTypeId.</param>
        /// <param name="certificateType">Initial value of CertificateType.</param>
        /// <param name="courseType">Initial value of CourseType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CourseTypeCertificateProfile CreateCourseTypeCertificateProfile(string courseTypeId, string certificateTypeId, global::Microsoft.Dynamics.DataEntities.CertificateType certificateType, global::Microsoft.Dynamics.DataEntities.CourseType courseType)
        {
            CourseTypeCertificateProfile courseTypeCertificateProfile = new CourseTypeCertificateProfile();
            courseTypeCertificateProfile.CourseTypeId = courseTypeId;
            courseTypeCertificateProfile.CertificateTypeId = certificateTypeId;
            if ((certificateType == null))
            {
                throw new global::System.ArgumentNullException("certificateType");
            }
            courseTypeCertificateProfile.CertificateType = certificateType;
            if ((courseType == null))
            {
                throw new global::System.ArgumentNullException("courseType");
            }
            courseTypeCertificateProfile.CourseType = courseType;
            return courseTypeCertificateProfile;
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
        /// There are no comments for Property CertificateTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CertificateTypeId
        {
            get
            {
                return this._CertificateTypeId;
            }
            set
            {
                this.OnCertificateTypeIdChanging(value);
                this._CertificateTypeId = value;
                this.OnCertificateTypeIdChanged();
                this.OnPropertyChanged("CertificateTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CertificateTypeId;
        partial void OnCertificateTypeIdChanging(string value);
        partial void OnCertificateTypeIdChanged();
        /// <summary>
        /// There are no comments for Property CertificateType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CertificateType CertificateType
        {
            get
            {
                return this._CertificateType;
            }
            set
            {
                this.OnCertificateTypeChanging(value);
                this._CertificateType = value;
                this.OnCertificateTypeChanged();
                this.OnPropertyChanged("CertificateType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CertificateType _CertificateType;
        partial void OnCertificateTypeChanging(global::Microsoft.Dynamics.DataEntities.CertificateType value);
        partial void OnCertificateTypeChanged();
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
