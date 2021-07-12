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
        /// There are no comments for JobTemplateScreeningSingle in the schema.
        /// </summary>
    public partial class JobTemplateScreeningSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<JobTemplateScreening>
    {
        /// <summary>
        /// Initialize a new JobTemplateScreeningSingle object.
        /// </summary>
        public JobTemplateScreeningSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new JobTemplateScreeningSingle object.
        /// </summary>
        public JobTemplateScreeningSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new JobTemplateScreeningSingle object.
        /// </summary>
        public JobTemplateScreeningSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<JobTemplateScreening> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ScreeningType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ScreeningTypeSingle ScreeningType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ScreeningType == null))
                {
                    this._ScreeningType = new global::Microsoft.Dynamics.DataEntities.ScreeningTypeSingle(this.Context, GetPath("ScreeningType"));
                }
                return this._ScreeningType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ScreeningTypeSingle _ScreeningType;
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
        /// There are no comments for JobTemplateScreening in the schema.
        /// </summary>
    /// <KeyProperties>
    /// JobTemplateId
    /// ScreeningTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("JobTemplateId", "ScreeningTypeId")]
    [global::Microsoft.OData.Client.EntitySet("JobTemplateScreenings")]
    public partial class JobTemplateScreening : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new JobTemplateScreening object.
        /// </summary>
        /// <param name="jobTemplateId">Initial value of JobTemplateId.</param>
        /// <param name="screeningTypeId">Initial value of ScreeningTypeId.</param>
        /// <param name="screeningType">Initial value of ScreeningType.</param>
        /// <param name="jobTemplate">Initial value of JobTemplate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static JobTemplateScreening CreateJobTemplateScreening(string jobTemplateId, string screeningTypeId, global::Microsoft.Dynamics.DataEntities.ScreeningType screeningType, global::Microsoft.Dynamics.DataEntities.JobTemplate jobTemplate)
        {
            JobTemplateScreening jobTemplateScreening = new JobTemplateScreening();
            jobTemplateScreening.JobTemplateId = jobTemplateId;
            jobTemplateScreening.ScreeningTypeId = screeningTypeId;
            if ((screeningType == null))
            {
                throw new global::System.ArgumentNullException("screeningType");
            }
            jobTemplateScreening.ScreeningType = screeningType;
            if ((jobTemplate == null))
            {
                throw new global::System.ArgumentNullException("jobTemplate");
            }
            jobTemplateScreening.JobTemplate = jobTemplate;
            return jobTemplateScreening;
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
        /// There are no comments for Property ScreeningTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ScreeningTypeId
        {
            get
            {
                return this._ScreeningTypeId;
            }
            set
            {
                this.OnScreeningTypeIdChanging(value);
                this._ScreeningTypeId = value;
                this.OnScreeningTypeIdChanged();
                this.OnPropertyChanged("ScreeningTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ScreeningTypeId;
        partial void OnScreeningTypeIdChanging(string value);
        partial void OnScreeningTypeIdChanged();
        /// <summary>
        /// There are no comments for Property ScreeningType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ScreeningType ScreeningType
        {
            get
            {
                return this._ScreeningType;
            }
            set
            {
                this.OnScreeningTypeChanging(value);
                this._ScreeningType = value;
                this.OnScreeningTypeChanged();
                this.OnPropertyChanged("ScreeningType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ScreeningType _ScreeningType;
        partial void OnScreeningTypeChanging(global::Microsoft.Dynamics.DataEntities.ScreeningType value);
        partial void OnScreeningTypeChanged();
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
