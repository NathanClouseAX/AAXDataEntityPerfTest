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
        /// There are no comments for JobTemplateCertificateSingle in the schema.
        /// </summary>
    public partial class JobTemplateCertificateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<JobTemplateCertificate>
    {
        /// <summary>
        /// Initialize a new JobTemplateCertificateSingle object.
        /// </summary>
        public JobTemplateCertificateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new JobTemplateCertificateSingle object.
        /// </summary>
        public JobTemplateCertificateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new JobTemplateCertificateSingle object.
        /// </summary>
        public JobTemplateCertificateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<JobTemplateCertificate> query)
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
    }
        /// <summary>
        /// There are no comments for JobTemplateCertificate in the schema.
        /// </summary>
    /// <KeyProperties>
    /// JobTemplateId
    /// CertificateTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("JobTemplateId", "CertificateTypeId")]
    [global::Microsoft.OData.Client.EntitySet("JobTemplateCertificates")]
    public partial class JobTemplateCertificate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new JobTemplateCertificate object.
        /// </summary>
        /// <param name="jobTemplateId">Initial value of JobTemplateId.</param>
        /// <param name="certificateTypeId">Initial value of CertificateTypeId.</param>
        /// <param name="certificateType">Initial value of CertificateType.</param>
        /// <param name="jobTemplate">Initial value of JobTemplate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static JobTemplateCertificate CreateJobTemplateCertificate(string jobTemplateId, string certificateTypeId, global::Microsoft.Dynamics.DataEntities.CertificateType certificateType, global::Microsoft.Dynamics.DataEntities.JobTemplate jobTemplate)
        {
            JobTemplateCertificate jobTemplateCertificate = new JobTemplateCertificate();
            jobTemplateCertificate.JobTemplateId = jobTemplateId;
            jobTemplateCertificate.CertificateTypeId = certificateTypeId;
            if ((certificateType == null))
            {
                throw new global::System.ArgumentNullException("certificateType");
            }
            jobTemplateCertificate.CertificateType = certificateType;
            if ((jobTemplate == null))
            {
                throw new global::System.ArgumentNullException("jobTemplate");
            }
            jobTemplateCertificate.JobTemplate = jobTemplate;
            return jobTemplateCertificate;
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
        /// There are no comments for Property Importance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillImportance> Importance
        {
            get
            {
                return this._Importance;
            }
            set
            {
                this.OnImportanceChanging(value);
                this._Importance = value;
                this.OnImportanceChanged();
                this.OnPropertyChanged("Importance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillImportance> _Importance;
        partial void OnImportanceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillImportance> value);
        partial void OnImportanceChanged();
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
