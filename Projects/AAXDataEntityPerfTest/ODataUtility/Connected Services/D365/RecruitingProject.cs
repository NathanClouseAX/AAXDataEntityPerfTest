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
        /// There are no comments for RecruitingProjectSingle in the schema.
        /// </summary>
    public partial class RecruitingProjectSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RecruitingProject>
    {
        /// <summary>
        /// Initialize a new RecruitingProjectSingle object.
        /// </summary>
        public RecruitingProjectSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RecruitingProjectSingle object.
        /// </summary>
        public RecruitingProjectSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RecruitingProjectSingle object.
        /// </summary>
        public RecruitingProjectSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RecruitingProject> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for HiringManagrWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle HiringManagrWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._HiringManagrWorker == null))
                {
                    this._HiringManagrWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("HiringManagrWorker"));
                }
                return this._HiringManagrWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _HiringManagrWorker;
        /// <summary>
        /// There are no comments for Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DepartmentSingle Department
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Department == null))
                {
                    this._Department = new global::Microsoft.Dynamics.DataEntities.DepartmentSingle(this.Context, GetPath("Department"));
                }
                return this._Department;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DepartmentSingle _Department;
        /// <summary>
        /// There are no comments for OMOperatingUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle OMOperatingUnit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OMOperatingUnit == null))
                {
                    this._OMOperatingUnit = new global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle(this.Context, GetPath("OMOperatingUnit"));
                }
                return this._OMOperatingUnit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle _OMOperatingUnit;
        /// <summary>
        /// There are no comments for RecruitingMedia in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RecruitingMedia> RecruitingMedia
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RecruitingMedia == null))
                {
                    this._RecruitingMedia = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RecruitingMedia>(GetPath("RecruitingMedia"));
                }
                return this._RecruitingMedia;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RecruitingMedia> _RecruitingMedia;
    }
        /// <summary>
        /// There are no comments for RecruitingProject in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RecruitmentProject
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RecruitmentProject")]
    [global::Microsoft.OData.Client.EntitySet("RecruitingProjects")]
    public partial class RecruitingProject : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RecruitingProject object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="recruitmentProject">Initial value of RecruitmentProject.</param>
        /// <param name="requisitionApprovedOn">Initial value of RequisitionApprovedOn.</param>
        /// <param name="applicationDeadline">Initial value of ApplicationDeadline.</param>
        /// <param name="numberOfOpenings">Initial value of NumberOfOpenings.</param>
        /// <param name="estimatedStartDate">Initial value of EstimatedStartDate.</param>
        /// <param name="closeDate">Initial value of CloseDate.</param>
        /// <param name="openDate">Initial value of OpenDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RecruitingProject CreateRecruitingProject(string dataAreaId, 
                    string recruitmentProject, 
                    global::System.DateTimeOffset requisitionApprovedOn, 
                    global::System.DateTimeOffset applicationDeadline, 
                    decimal numberOfOpenings, 
                    global::System.DateTimeOffset estimatedStartDate, 
                    global::System.DateTimeOffset closeDate, 
                    global::System.DateTimeOffset openDate)
        {
            RecruitingProject recruitingProject = new RecruitingProject();
            recruitingProject.dataAreaId = dataAreaId;
            recruitingProject.RecruitmentProject = recruitmentProject;
            recruitingProject.RequisitionApprovedOn = requisitionApprovedOn;
            recruitingProject.ApplicationDeadline = applicationDeadline;
            recruitingProject.NumberOfOpenings = numberOfOpenings;
            recruitingProject.EstimatedStartDate = estimatedStartDate;
            recruitingProject.CloseDate = closeDate;
            recruitingProject.OpenDate = openDate;
            return recruitingProject;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property RequisitionApprovedOn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset RequisitionApprovedOn
        {
            get
            {
                return this._RequisitionApprovedOn;
            }
            set
            {
                this.OnRequisitionApprovedOnChanging(value);
                this._RequisitionApprovedOn = value;
                this.OnRequisitionApprovedOnChanged();
                this.OnPropertyChanged("RequisitionApprovedOn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _RequisitionApprovedOn;
        partial void OnRequisitionApprovedOnChanging(global::System.DateTimeOffset value);
        partial void OnRequisitionApprovedOnChanged();
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
        /// There are no comments for Property ApplicationDeadline in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ApplicationDeadline
        {
            get
            {
                return this._ApplicationDeadline;
            }
            set
            {
                this.OnApplicationDeadlineChanging(value);
                this._ApplicationDeadline = value;
                this.OnApplicationDeadlineChanged();
                this.OnPropertyChanged("ApplicationDeadline");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ApplicationDeadline;
        partial void OnApplicationDeadlineChanging(global::System.DateTimeOffset value);
        partial void OnApplicationDeadlineChanged();
        /// <summary>
        /// There are no comments for Property ProjectStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmRecruitingStatus> ProjectStatus
        {
            get
            {
                return this._ProjectStatus;
            }
            set
            {
                this.OnProjectStatusChanging(value);
                this._ProjectStatus = value;
                this.OnProjectStatusChanged();
                this.OnPropertyChanged("ProjectStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmRecruitingStatus> _ProjectStatus;
        partial void OnProjectStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmRecruitingStatus> value);
        partial void OnProjectStatusChanged();
        /// <summary>
        /// There are no comments for Property DepartmentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DepartmentNumber
        {
            get
            {
                return this._DepartmentNumber;
            }
            set
            {
                this.OnDepartmentNumberChanging(value);
                this._DepartmentNumber = value;
                this.OnDepartmentNumberChanged();
                this.OnPropertyChanged("DepartmentNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepartmentNumber;
        partial void OnDepartmentNumberChanging(string value);
        partial void OnDepartmentNumberChanged();
        /// <summary>
        /// There are no comments for Property JobId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobId
        {
            get
            {
                return this._JobId;
            }
            set
            {
                this.OnJobIdChanging(value);
                this._JobId = value;
                this.OnJobIdChanged();
                this.OnPropertyChanged("JobId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobId;
        partial void OnJobIdChanging(string value);
        partial void OnJobIdChanged();
        /// <summary>
        /// There are no comments for Property AlternativeContactPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AlternativeContactPersonnelNumber
        {
            get
            {
                return this._AlternativeContactPersonnelNumber;
            }
            set
            {
                this.OnAlternativeContactPersonnelNumberChanging(value);
                this._AlternativeContactPersonnelNumber = value;
                this.OnAlternativeContactPersonnelNumberChanged();
                this.OnPropertyChanged("AlternativeContactPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AlternativeContactPersonnelNumber;
        partial void OnAlternativeContactPersonnelNumberChanging(string value);
        partial void OnAlternativeContactPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property NumberOfOpenings in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal NumberOfOpenings
        {
            get
            {
                return this._NumberOfOpenings;
            }
            set
            {
                this.OnNumberOfOpeningsChanging(value);
                this._NumberOfOpenings = value;
                this.OnNumberOfOpeningsChanged();
                this.OnPropertyChanged("NumberOfOpenings");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _NumberOfOpenings;
        partial void OnNumberOfOpeningsChanging(decimal value);
        partial void OnNumberOfOpeningsChanged();
        /// <summary>
        /// There are no comments for Property EstimatedStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EstimatedStartDate
        {
            get
            {
                return this._EstimatedStartDate;
            }
            set
            {
                this.OnEstimatedStartDateChanging(value);
                this._EstimatedStartDate = value;
                this.OnEstimatedStartDateChanged();
                this.OnPropertyChanged("EstimatedStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EstimatedStartDate;
        partial void OnEstimatedStartDateChanging(global::System.DateTimeOffset value);
        partial void OnEstimatedStartDateChanged();
        /// <summary>
        /// There are no comments for Property RecruiterPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RecruiterPersonnelNumber
        {
            get
            {
                return this._RecruiterPersonnelNumber;
            }
            set
            {
                this.OnRecruiterPersonnelNumberChanging(value);
                this._RecruiterPersonnelNumber = value;
                this.OnRecruiterPersonnelNumberChanged();
                this.OnPropertyChanged("RecruiterPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RecruiterPersonnelNumber;
        partial void OnRecruiterPersonnelNumberChanging(string value);
        partial void OnRecruiterPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property HiringManagerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string HiringManagerPersonnelNumber
        {
            get
            {
                return this._HiringManagerPersonnelNumber;
            }
            set
            {
                this.OnHiringManagerPersonnelNumberChanging(value);
                this._HiringManagerPersonnelNumber = value;
                this.OnHiringManagerPersonnelNumberChanged();
                this.OnPropertyChanged("HiringManagerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HiringManagerPersonnelNumber;
        partial void OnHiringManagerPersonnelNumberChanging(string value);
        partial void OnHiringManagerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property DisplayOnEmployeSelfService in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DisplayOnEmployeSelfService
        {
            get
            {
                return this._DisplayOnEmployeSelfService;
            }
            set
            {
                this.OnDisplayOnEmployeSelfServiceChanging(value);
                this._DisplayOnEmployeSelfService = value;
                this.OnDisplayOnEmployeSelfServiceChanged();
                this.OnPropertyChanged("DisplayOnEmployeSelfService");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DisplayOnEmployeSelfService;
        partial void OnDisplayOnEmployeSelfServiceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDisplayOnEmployeSelfServiceChanged();
        /// <summary>
        /// There are no comments for Property CloseDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset CloseDate
        {
            get
            {
                return this._CloseDate;
            }
            set
            {
                this.OnCloseDateChanging(value);
                this._CloseDate = value;
                this.OnCloseDateChanged();
                this.OnPropertyChanged("CloseDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CloseDate;
        partial void OnCloseDateChanging(global::System.DateTimeOffset value);
        partial void OnCloseDateChanged();
        /// <summary>
        /// There are no comments for Property JobAdText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobAdText
        {
            get
            {
                return this._JobAdText;
            }
            set
            {
                this.OnJobAdTextChanging(value);
                this._JobAdText = value;
                this.OnJobAdTextChanged();
                this.OnPropertyChanged("JobAdText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobAdText;
        partial void OnJobAdTextChanging(string value);
        partial void OnJobAdTextChanged();
        /// <summary>
        /// There are no comments for Property OpenDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset OpenDate
        {
            get
            {
                return this._OpenDate;
            }
            set
            {
                this.OnOpenDateChanging(value);
                this._OpenDate = value;
                this.OnOpenDateChanged();
                this.OnPropertyChanged("OpenDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _OpenDate;
        partial void OnOpenDateChanging(global::System.DateTimeOffset value);
        partial void OnOpenDateChanged();
        /// <summary>
        /// There are no comments for Property HiringManagrWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker HiringManagrWorker
        {
            get
            {
                return this._HiringManagrWorker;
            }
            set
            {
                this.OnHiringManagrWorkerChanging(value);
                this._HiringManagrWorker = value;
                this.OnHiringManagrWorkerChanged();
                this.OnPropertyChanged("HiringManagrWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _HiringManagrWorker;
        partial void OnHiringManagrWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnHiringManagrWorkerChanged();
        /// <summary>
        /// There are no comments for Property Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Department Department
        {
            get
            {
                return this._Department;
            }
            set
            {
                this.OnDepartmentChanging(value);
                this._Department = value;
                this.OnDepartmentChanged();
                this.OnPropertyChanged("Department");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Department _Department;
        partial void OnDepartmentChanging(global::Microsoft.Dynamics.DataEntities.Department value);
        partial void OnDepartmentChanged();
        /// <summary>
        /// There are no comments for Property OMOperatingUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperatingUnit OMOperatingUnit
        {
            get
            {
                return this._OMOperatingUnit;
            }
            set
            {
                this.OnOMOperatingUnitChanging(value);
                this._OMOperatingUnit = value;
                this.OnOMOperatingUnitChanged();
                this.OnPropertyChanged("OMOperatingUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperatingUnit _OMOperatingUnit;
        partial void OnOMOperatingUnitChanging(global::Microsoft.Dynamics.DataEntities.OperatingUnit value);
        partial void OnOMOperatingUnitChanged();
        /// <summary>
        /// There are no comments for Property RecruitingMedia in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingMedia> RecruitingMedia
        {
            get
            {
                return this._RecruitingMedia;
            }
            set
            {
                this.OnRecruitingMediaChanging(value);
                this._RecruitingMedia = value;
                this.OnRecruitingMediaChanged();
                this.OnPropertyChanged("RecruitingMedia");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingMedia> _RecruitingMedia = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingMedia>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRecruitingMediaChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingMedia> value);
        partial void OnRecruitingMediaChanged();
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
