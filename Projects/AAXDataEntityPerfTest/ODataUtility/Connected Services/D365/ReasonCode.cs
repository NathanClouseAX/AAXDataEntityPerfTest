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
        /// There are no comments for ReasonCodeSingle in the schema.
        /// </summary>
    public partial class ReasonCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ReasonCode>
    {
        /// <summary>
        /// Initialize a new ReasonCodeSingle object.
        /// </summary>
        public ReasonCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReasonCodeSingle object.
        /// </summary>
        public ReasonCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReasonCodeSingle object.
        /// </summary>
        public ReasonCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ReasonCode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AbsenceReason in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AbsenceReason> AbsenceReason
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AbsenceReason == null))
                {
                    this._AbsenceReason = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AbsenceReason>(GetPath("AbsenceReason"));
                }
                return this._AbsenceReason;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AbsenceReason> _AbsenceReason;
        /// <summary>
        /// There are no comments for Positions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Position> Positions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Positions == null))
                {
                    this._Positions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Position>(GetPath("Positions"));
                }
                return this._Positions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Position> _Positions;
        /// <summary>
        /// There are no comments for EmploymentDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> EmploymentDetail
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EmploymentDetail == null))
                {
                    this._EmploymentDetail = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EmploymentDetail>(GetPath("EmploymentDetail"));
                }
                return this._EmploymentDetail;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> _EmploymentDetail;
        /// <summary>
        /// There are no comments for Applicants in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Applicant> Applicants
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Applicants == null))
                {
                    this._Applicants = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Applicant>(GetPath("Applicants"));
                }
                return this._Applicants;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Applicant> _Applicants;
        /// <summary>
        /// There are no comments for Applications in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Application> Applications
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Applications == null))
                {
                    this._Applications = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Application>(GetPath("Applications"));
                }
                return this._Applications;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Application> _Applications;
        /// <summary>
        /// There are no comments for PersonSkillMapping in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonSkillMapping> PersonSkillMapping
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PersonSkillMapping == null))
                {
                    this._PersonSkillMapping = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PersonSkillMapping>(GetPath("PersonSkillMapping"));
                }
                return this._PersonSkillMapping;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonSkillMapping> _PersonSkillMapping;
    }
        /// <summary>
        /// There are no comments for ReasonCode in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ReasonCodeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ReasonCodeId")]
    [global::Microsoft.OData.Client.EntitySet("ReasonCodes")]
    public partial class ReasonCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReasonCode object.
        /// </summary>
        /// <param name="reasonCodeId">Initial value of ReasonCodeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReasonCode CreateReasonCode(string reasonCodeId)
        {
            ReasonCode reasonCode = new ReasonCode();
            reasonCode.ReasonCodeId = reasonCodeId;
            return reasonCode;
        }
        /// <summary>
        /// There are no comments for Property ReasonCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReasonCodeId
        {
            get
            {
                return this._ReasonCodeId;
            }
            set
            {
                this.OnReasonCodeIdChanging(value);
                this._ReasonCodeId = value;
                this.OnReasonCodeIdChanged();
                this.OnPropertyChanged("ReasonCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReasonCodeId;
        partial void OnReasonCodeIdChanging(string value);
        partial void OnReasonCodeIdChanged();
        /// <summary>
        /// There are no comments for Property IsSkillMappingApplicable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsSkillMappingApplicable
        {
            get
            {
                return this._IsSkillMappingApplicable;
            }
            set
            {
                this.OnIsSkillMappingApplicableChanging(value);
                this._IsSkillMappingApplicable = value;
                this.OnIsSkillMappingApplicableChanged();
                this.OnPropertyChanged("IsSkillMappingApplicable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsSkillMappingApplicable;
        partial void OnIsSkillMappingApplicableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsSkillMappingApplicableChanged();
        /// <summary>
        /// There are no comments for Property IsCreateNewPositionApplicable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCreateNewPositionApplicable
        {
            get
            {
                return this._IsCreateNewPositionApplicable;
            }
            set
            {
                this.OnIsCreateNewPositionApplicableChanging(value);
                this._IsCreateNewPositionApplicable = value;
                this.OnIsCreateNewPositionApplicableChanged();
                this.OnPropertyChanged("IsCreateNewPositionApplicable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCreateNewPositionApplicable;
        partial void OnIsCreateNewPositionApplicableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCreateNewPositionApplicableChanged();
        /// <summary>
        /// There are no comments for Property IsCompensationApplicable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCompensationApplicable
        {
            get
            {
                return this._IsCompensationApplicable;
            }
            set
            {
                this.OnIsCompensationApplicableChanging(value);
                this._IsCompensationApplicable = value;
                this.OnIsCompensationApplicableChanged();
                this.OnPropertyChanged("IsCompensationApplicable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCompensationApplicable;
        partial void OnIsCompensationApplicableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCompensationApplicableChanged();
        /// <summary>
        /// There are no comments for Property IsTerminationApplicable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsTerminationApplicable
        {
            get
            {
                return this._IsTerminationApplicable;
            }
            set
            {
                this.OnIsTerminationApplicableChanging(value);
                this._IsTerminationApplicable = value;
                this.OnIsTerminationApplicableChanged();
                this.OnPropertyChanged("IsTerminationApplicable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsTerminationApplicable;
        partial void OnIsTerminationApplicableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsTerminationApplicableChanged();
        /// <summary>
        /// There are no comments for Property IsTransferApplicable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsTransferApplicable
        {
            get
            {
                return this._IsTransferApplicable;
            }
            set
            {
                this.OnIsTransferApplicableChanging(value);
                this._IsTransferApplicable = value;
                this.OnIsTransferApplicableChanged();
                this.OnPropertyChanged("IsTransferApplicable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsTransferApplicable;
        partial void OnIsTransferApplicableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsTransferApplicableChanged();
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
        /// There are no comments for Property IsAbsenceApplicable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAbsenceApplicable
        {
            get
            {
                return this._IsAbsenceApplicable;
            }
            set
            {
                this.OnIsAbsenceApplicableChanging(value);
                this._IsAbsenceApplicable = value;
                this.OnIsAbsenceApplicableChanged();
                this.OnPropertyChanged("IsAbsenceApplicable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAbsenceApplicable;
        partial void OnIsAbsenceApplicableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAbsenceApplicableChanged();
        /// <summary>
        /// There are no comments for Property IsEditPositionApplicable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsEditPositionApplicable
        {
            get
            {
                return this._IsEditPositionApplicable;
            }
            set
            {
                this.OnIsEditPositionApplicableChanging(value);
                this._IsEditPositionApplicable = value;
                this.OnIsEditPositionApplicableChanged();
                this.OnPropertyChanged("IsEditPositionApplicable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsEditPositionApplicable;
        partial void OnIsEditPositionApplicableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsEditPositionApplicableChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmReasonCodeType> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmReasonCodeType> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmReasonCodeType> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property IsApplicationApplicable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsApplicationApplicable
        {
            get
            {
                return this._IsApplicationApplicable;
            }
            set
            {
                this.OnIsApplicationApplicableChanging(value);
                this._IsApplicationApplicable = value;
                this.OnIsApplicationApplicableChanged();
                this.OnPropertyChanged("IsApplicationApplicable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsApplicationApplicable;
        partial void OnIsApplicationApplicableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsApplicationApplicableChanged();
        /// <summary>
        /// There are no comments for Property IsHireApplicable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsHireApplicable
        {
            get
            {
                return this._IsHireApplicable;
            }
            set
            {
                this.OnIsHireApplicableChanging(value);
                this._IsHireApplicable = value;
                this.OnIsHireApplicableChanged();
                this.OnPropertyChanged("IsHireApplicable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsHireApplicable;
        partial void OnIsHireApplicableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsHireApplicableChanged();
        /// <summary>
        /// There are no comments for Property AbsenceReason in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AbsenceReason> AbsenceReason
        {
            get
            {
                return this._AbsenceReason;
            }
            set
            {
                this.OnAbsenceReasonChanging(value);
                this._AbsenceReason = value;
                this.OnAbsenceReasonChanged();
                this.OnPropertyChanged("AbsenceReason");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AbsenceReason> _AbsenceReason = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AbsenceReason>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAbsenceReasonChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AbsenceReason> value);
        partial void OnAbsenceReasonChanged();
        /// <summary>
        /// There are no comments for Property Positions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position> Positions
        {
            get
            {
                return this._Positions;
            }
            set
            {
                this.OnPositionsChanging(value);
                this._Positions = value;
                this.OnPositionsChanged();
                this.OnPropertyChanged("Positions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position> _Positions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPositionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position> value);
        partial void OnPositionsChanged();
        /// <summary>
        /// There are no comments for Property EmploymentDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> EmploymentDetail
        {
            get
            {
                return this._EmploymentDetail;
            }
            set
            {
                this.OnEmploymentDetailChanging(value);
                this._EmploymentDetail = value;
                this.OnEmploymentDetailChanged();
                this.OnPropertyChanged("EmploymentDetail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> _EmploymentDetail = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEmploymentDetailChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> value);
        partial void OnEmploymentDetailChanged();
        /// <summary>
        /// There are no comments for Property Applicants in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Applicant> Applicants
        {
            get
            {
                return this._Applicants;
            }
            set
            {
                this.OnApplicantsChanging(value);
                this._Applicants = value;
                this.OnApplicantsChanged();
                this.OnPropertyChanged("Applicants");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Applicant> _Applicants = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Applicant>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnApplicantsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Applicant> value);
        partial void OnApplicantsChanged();
        /// <summary>
        /// There are no comments for Property Applications in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Application> Applications
        {
            get
            {
                return this._Applications;
            }
            set
            {
                this.OnApplicationsChanging(value);
                this._Applications = value;
                this.OnApplicationsChanged();
                this.OnPropertyChanged("Applications");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Application> _Applications = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Application>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnApplicationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Application> value);
        partial void OnApplicationsChanged();
        /// <summary>
        /// There are no comments for Property PersonSkillMapping in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonSkillMapping> PersonSkillMapping
        {
            get
            {
                return this._PersonSkillMapping;
            }
            set
            {
                this.OnPersonSkillMappingChanging(value);
                this._PersonSkillMapping = value;
                this.OnPersonSkillMappingChanged();
                this.OnPropertyChanged("PersonSkillMapping");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonSkillMapping> _PersonSkillMapping = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonSkillMapping>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPersonSkillMappingChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonSkillMapping> value);
        partial void OnPersonSkillMappingChanged();
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
