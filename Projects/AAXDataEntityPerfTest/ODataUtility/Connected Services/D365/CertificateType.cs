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
    /// There are no comments for CertificateTypeSingle in the schema.
    /// </summary>
    public partial class CertificateTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CertificateType>
    {
        /// <summary>
        /// Initialize a new CertificateTypeSingle object.
        /// </summary>
        public CertificateTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CertificateTypeSingle object.
        /// </summary>
        public CertificateTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CertificateTypeSingle object.
        /// </summary>
        public CertificateTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CertificateType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PersonCertificate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonCertificate> PersonCertificate
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PersonCertificate == null))
                {
                    this._PersonCertificate = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PersonCertificate>(GetPath("PersonCertificate"));
                }
                return this._PersonCertificate;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonCertificate> _PersonCertificate;
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
        /// There are no comments for JobPreferredCertificates in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobPreferredCertificate> JobPreferredCertificates
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobPreferredCertificates == null))
                {
                    this._JobPreferredCertificates = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobPreferredCertificate>(GetPath("JobPreferredCertificates"));
                }
                return this._JobPreferredCertificates;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobPreferredCertificate> _JobPreferredCertificates;
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
    /// There are no comments for CertificateType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CertificateType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CertificateType")]
    [global::Microsoft.OData.Client.EntitySet("CertificateTypes")]
    public partial class CertificateType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CertificateType object.
        /// </summary>
        /// <param name="certificateType1">Initial value of CertificateType1.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CertificateType CreateCertificateType(string certificateType1)
        {
            CertificateType certificateType = new CertificateType();
            certificateType.CertificateType1 = certificateType1;
            return certificateType;
        }
        /// <summary>
        /// There are no comments for Property CertificateType1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CertificateType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CertificateType1 is required.")]
        public virtual string CertificateType1
        {
            get
            {
                return this._CertificateType1;
            }
            set
            {
                this.OnCertificateType1Changing(value);
                this._CertificateType1 = value;
                this.OnCertificateType1Changed();
                this.OnPropertyChanged("CertificateType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CertificateType1;
        partial void OnCertificateType1Changing(string value);
        partial void OnCertificateType1Changed();
        /// <summary>
        /// There are no comments for Property RequireRenewal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> RequireRenewal
        {
            get
            {
                return this._RequireRenewal;
            }
            set
            {
                this.OnRequireRenewalChanging(value);
                this._RequireRenewal = value;
                this.OnRequireRenewalChanged();
                this.OnPropertyChanged("RequireRenewal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _RequireRenewal;
        partial void OnRequireRenewalChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRequireRenewalChanged();
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
        /// There are no comments for Property PersonCertificate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonCertificate> PersonCertificate
        {
            get
            {
                return this._PersonCertificate;
            }
            set
            {
                this.OnPersonCertificateChanging(value);
                this._PersonCertificate = value;
                this.OnPersonCertificateChanged();
                this.OnPropertyChanged("PersonCertificate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonCertificate> _PersonCertificate = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonCertificate>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPersonCertificateChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonCertificate> value);
        partial void OnPersonCertificateChanged();
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
        /// There are no comments for Property JobPreferredCertificates in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredCertificate> JobPreferredCertificates
        {
            get
            {
                return this._JobPreferredCertificates;
            }
            set
            {
                this.OnJobPreferredCertificatesChanging(value);
                this._JobPreferredCertificates = value;
                this.OnJobPreferredCertificatesChanged();
                this.OnPropertyChanged("JobPreferredCertificates");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredCertificate> _JobPreferredCertificates = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredCertificate>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobPreferredCertificatesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredCertificate> value);
        partial void OnJobPreferredCertificatesChanged();
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
