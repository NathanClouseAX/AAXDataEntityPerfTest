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
    /// There are no comments for RecruitingMediaSingle in the schema.
    /// </summary>
    public partial class RecruitingMediaSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RecruitingMedia>
    {
        /// <summary>
        /// Initialize a new RecruitingMediaSingle object.
        /// </summary>
        public RecruitingMediaSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RecruitingMediaSingle object.
        /// </summary>
        public RecruitingMediaSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RecruitingMediaSingle object.
        /// </summary>
        public RecruitingMediaSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RecruitingMedia> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RecruitingProject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RecruitingProjectSingle RecruitingProject
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RecruitingProject == null))
                {
                    this._RecruitingProject = new global::Microsoft.Dynamics.DataEntities.RecruitingProjectSingle(this.Context, GetPath("RecruitingProject"));
                }
                return this._RecruitingProject;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RecruitingProjectSingle _RecruitingProject;
    }
    /// <summary>
    /// There are no comments for RecruitingMedia in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RecruitmentProject
    /// Media
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RecruitmentProject", "Media")]
    [global::Microsoft.OData.Client.EntitySet("RecruitingMedias")]
    public partial class RecruitingMedia : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RecruitingMedia object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="recruitmentProject">Initial value of RecruitmentProject.</param>
        /// <param name="media">Initial value of Media.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="recruitingProject">Initial value of RecruitingProject.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RecruitingMedia CreateRecruitingMedia(string dataAreaId, 
                    string recruitmentProject, 
                    string media, 
                    global::System.DateTimeOffset startDate, 
                    global::System.DateTimeOffset endDate, 
                    global::Microsoft.Dynamics.DataEntities.RecruitingProject recruitingProject)
        {
            RecruitingMedia recruitingMedia = new RecruitingMedia();
            recruitingMedia.dataAreaId = dataAreaId;
            recruitingMedia.RecruitmentProject = recruitmentProject;
            recruitingMedia.Media = media;
            recruitingMedia.StartDate = startDate;
            recruitingMedia.EndDate = endDate;
            if ((recruitingProject == null))
            {
                throw new global::System.ArgumentNullException("recruitingProject");
            }
            recruitingMedia.RecruitingProject = recruitingProject;
            return recruitingMedia;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "dataAreaId is required.")]
        public virtual string dataAreaId
        {
            get
            {
                return this._dataAreaId;
            }
            set
            {
                this.OndataAreaIdChanging(value);
                this._dataAreaId = value;
                this.OndataAreaIdChanged();
                this.OnPropertyChanged("dataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _dataAreaId;
        partial void OndataAreaIdChanging(string value);
        partial void OndataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property RecruitmentProject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecruitmentProject is required.")]
        public virtual string RecruitmentProject
        {
            get
            {
                return this._RecruitmentProject;
            }
            set
            {
                this.OnRecruitmentProjectChanging(value);
                this._RecruitmentProject = value;
                this.OnRecruitmentProjectChanged();
                this.OnPropertyChanged("RecruitmentProject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RecruitmentProject;
        partial void OnRecruitmentProjectChanging(string value);
        partial void OnRecruitmentProjectChanged();
        /// <summary>
        /// There are no comments for Property Media in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Media is required.")]
        public virtual string Media
        {
            get
            {
                return this._Media;
            }
            set
            {
                this.OnMediaChanging(value);
                this._Media = value;
                this.OnMediaChanged();
                this.OnPropertyChanged("Media");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Media;
        partial void OnMediaChanging(string value);
        partial void OnMediaChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StartDate is required.")]
        public virtual global::System.DateTimeOffset StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDate;
        partial void OnStartDateChanging(global::System.DateTimeOffset value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property EndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EndDate is required.")]
        public virtual global::System.DateTimeOffset EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this.OnEndDateChanging(value);
                this._EndDate = value;
                this.OnEndDateChanged();
                this.OnPropertyChanged("EndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EndDate;
        partial void OnEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEndDateChanged();
        /// <summary>
        /// There are no comments for Property RecruitingProject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecruitingProject is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RecruitingProject RecruitingProject
        {
            get
            {
                return this._RecruitingProject;
            }
            set
            {
                this.OnRecruitingProjectChanging(value);
                this._RecruitingProject = value;
                this.OnRecruitingProjectChanged();
                this.OnPropertyChanged("RecruitingProject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RecruitingProject _RecruitingProject;
        partial void OnRecruitingProjectChanging(global::Microsoft.Dynamics.DataEntities.RecruitingProject value);
        partial void OnRecruitingProjectChanged();
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
