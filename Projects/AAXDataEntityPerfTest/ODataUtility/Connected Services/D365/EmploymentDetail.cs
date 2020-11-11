﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/8/2020 8:07:52 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for EmploymentDetailSingle in the schema.
        /// </summary>
    public partial class EmploymentDetailSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EmploymentDetail>
    {
        /// <summary>
        /// Initialize a new EmploymentDetailSingle object.
        /// </summary>
        public EmploymentDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EmploymentDetailSingle object.
        /// </summary>
        public EmploymentDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EmploymentDetailSingle object.
        /// </summary>
        public EmploymentDetailSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EmploymentDetail> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Employment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EmploymentSingle Employment
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Employment == null))
                {
                    this._Employment = new global::Microsoft.Dynamics.DataEntities.EmploymentSingle(this.Context, GetPath("Employment"));
                }
                return this._Employment;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EmploymentSingle _Employment;
        /// <summary>
        /// There are no comments for ReasonCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReasonCodeSingle ReasonCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReasonCode == null))
                {
                    this._ReasonCode = new global::Microsoft.Dynamics.DataEntities.ReasonCodeSingle(this.Context, GetPath("ReasonCode"));
                }
                return this._ReasonCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReasonCodeSingle _ReasonCode;
    }
        /// <summary>
        /// There are no comments for EmploymentDetail in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PersonnelNumber
    /// LegalEntityId
    /// EmploymentStartDate
    /// EmploymentEndDate
    /// ValidFrom
    /// ValidTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelNumber", "LegalEntityId", "EmploymentStartDate", "EmploymentEndDate", "ValidFrom", "ValidTo")]
    [global::Microsoft.OData.Client.EntitySet("EmploymentDetails")]
    public partial class EmploymentDetail : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EmploymentDetail object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="employmentStartDate">Initial value of EmploymentStartDate.</param>
        /// <param name="employmentEndDate">Initial value of EmploymentEndDate.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="workerNoticeAmount">Initial value of WorkerNoticeAmount.</param>
        /// <param name="transitionDate">Initial value of TransitionDate.</param>
        /// <param name="lastDateWorked">Initial value of LastDateWorked.</param>
        /// <param name="employerNoticeAmount">Initial value of EmployerNoticeAmount.</param>
        /// <param name="adjustedWorkerStartDate">Initial value of AdjustedWorkerStartDate.</param>
        /// <param name="workerStartDate">Initial value of WorkerStartDate.</param>
        /// <param name="employment">Initial value of Employment.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EmploymentDetail CreateEmploymentDetail(string personnelNumber, 
                    string legalEntityId, 
                    global::System.DateTimeOffset employmentStartDate, 
                    global::System.DateTimeOffset employmentEndDate, 
                    global::System.DateTimeOffset validFrom, 
                    global::System.DateTimeOffset validTo, 
                    int workerNoticeAmount, 
                    global::System.DateTimeOffset transitionDate, 
                    global::System.DateTimeOffset lastDateWorked, 
                    int employerNoticeAmount, 
                    global::System.DateTimeOffset adjustedWorkerStartDate, 
                    global::System.DateTimeOffset workerStartDate, 
                    global::Microsoft.Dynamics.DataEntities.Employment employment)
        {
            EmploymentDetail employmentDetail = new EmploymentDetail();
            employmentDetail.PersonnelNumber = personnelNumber;
            employmentDetail.LegalEntityId = legalEntityId;
            employmentDetail.EmploymentStartDate = employmentStartDate;
            employmentDetail.EmploymentEndDate = employmentEndDate;
            employmentDetail.ValidFrom = validFrom;
            employmentDetail.ValidTo = validTo;
            employmentDetail.WorkerNoticeAmount = workerNoticeAmount;
            employmentDetail.TransitionDate = transitionDate;
            employmentDetail.LastDateWorked = lastDateWorked;
            employmentDetail.EmployerNoticeAmount = employerNoticeAmount;
            employmentDetail.AdjustedWorkerStartDate = adjustedWorkerStartDate;
            employmentDetail.WorkerStartDate = workerStartDate;
            if ((employment == null))
            {
                throw new global::System.ArgumentNullException("employment");
            }
            employmentDetail.Employment = employment;
            return employmentDetail;
        }
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property EmploymentStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EmploymentStartDate
        {
            get
            {
                return this._EmploymentStartDate;
            }
            set
            {
                this.OnEmploymentStartDateChanging(value);
                this._EmploymentStartDate = value;
                this.OnEmploymentStartDateChanged();
                this.OnPropertyChanged("EmploymentStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EmploymentStartDate;
        partial void OnEmploymentStartDateChanging(global::System.DateTimeOffset value);
        partial void OnEmploymentStartDateChanged();
        /// <summary>
        /// There are no comments for Property EmploymentEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EmploymentEndDate
        {
            get
            {
                return this._EmploymentEndDate;
            }
            set
            {
                this.OnEmploymentEndDateChanging(value);
                this._EmploymentEndDate = value;
                this.OnEmploymentEndDateChanged();
                this.OnPropertyChanged("EmploymentEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EmploymentEndDate;
        partial void OnEmploymentEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEmploymentEndDateChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property WorkerNoticeAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int WorkerNoticeAmount
        {
            get
            {
                return this._WorkerNoticeAmount;
            }
            set
            {
                this.OnWorkerNoticeAmountChanging(value);
                this._WorkerNoticeAmount = value;
                this.OnWorkerNoticeAmountChanged();
                this.OnPropertyChanged("WorkerNoticeAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _WorkerNoticeAmount;
        partial void OnWorkerNoticeAmountChanging(int value);
        partial void OnWorkerNoticeAmountChanged();
        /// <summary>
        /// There are no comments for Property EmploymentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> EmploymentType
        {
            get
            {
                return this._EmploymentType;
            }
            set
            {
                this.OnEmploymentTypeChanging(value);
                this._EmploymentType = value;
                this.OnEmploymentTypeChanged();
                this.OnPropertyChanged("EmploymentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> _EmploymentType;
        partial void OnEmploymentTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> value);
        partial void OnEmploymentTypeChanged();
        /// <summary>
        /// There are no comments for Property TransitionDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset TransitionDate
        {
            get
            {
                return this._TransitionDate;
            }
            set
            {
                this.OnTransitionDateChanging(value);
                this._TransitionDate = value;
                this.OnTransitionDateChanged();
                this.OnPropertyChanged("TransitionDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TransitionDate;
        partial void OnTransitionDateChanging(global::System.DateTimeOffset value);
        partial void OnTransitionDateChanged();
        /// <summary>
        /// There are no comments for Property LastDateWorked in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset LastDateWorked
        {
            get
            {
                return this._LastDateWorked;
            }
            set
            {
                this.OnLastDateWorkedChanging(value);
                this._LastDateWorked = value;
                this.OnLastDateWorkedChanged();
                this.OnPropertyChanged("LastDateWorked");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _LastDateWorked;
        partial void OnLastDateWorkedChanging(global::System.DateTimeOffset value);
        partial void OnLastDateWorkedChanged();
        /// <summary>
        /// There are no comments for Property EmployerNoticeAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int EmployerNoticeAmount
        {
            get
            {
                return this._EmployerNoticeAmount;
            }
            set
            {
                this.OnEmployerNoticeAmountChanging(value);
                this._EmployerNoticeAmount = value;
                this.OnEmployerNoticeAmountChanged();
                this.OnPropertyChanged("EmployerNoticeAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _EmployerNoticeAmount;
        partial void OnEmployerNoticeAmountChanging(int value);
        partial void OnEmployerNoticeAmountChanged();
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
        /// There are no comments for Property AdjustedWorkerStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset AdjustedWorkerStartDate
        {
            get
            {
                return this._AdjustedWorkerStartDate;
            }
            set
            {
                this.OnAdjustedWorkerStartDateChanging(value);
                this._AdjustedWorkerStartDate = value;
                this.OnAdjustedWorkerStartDateChanged();
                this.OnPropertyChanged("AdjustedWorkerStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AdjustedWorkerStartDate;
        partial void OnAdjustedWorkerStartDateChanging(global::System.DateTimeOffset value);
        partial void OnAdjustedWorkerStartDateChanged();
        /// <summary>
        /// There are no comments for Property EmployerUnitOfNotice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmUnitOfNotice> EmployerUnitOfNotice
        {
            get
            {
                return this._EmployerUnitOfNotice;
            }
            set
            {
                this.OnEmployerUnitOfNoticeChanging(value);
                this._EmployerUnitOfNotice = value;
                this.OnEmployerUnitOfNoticeChanged();
                this.OnPropertyChanged("EmployerUnitOfNotice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmUnitOfNotice> _EmployerUnitOfNotice;
        partial void OnEmployerUnitOfNoticeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmUnitOfNotice> value);
        partial void OnEmployerUnitOfNoticeChanged();
        /// <summary>
        /// There are no comments for Property WorkerStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset WorkerStartDate
        {
            get
            {
                return this._WorkerStartDate;
            }
            set
            {
                this.OnWorkerStartDateChanging(value);
                this._WorkerStartDate = value;
                this.OnWorkerStartDateChanged();
                this.OnPropertyChanged("WorkerStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _WorkerStartDate;
        partial void OnWorkerStartDateChanging(global::System.DateTimeOffset value);
        partial void OnWorkerStartDateChanged();
        /// <summary>
        /// There are no comments for Property WorkerUnitOfNotice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmUnitOfNotice> WorkerUnitOfNotice
        {
            get
            {
                return this._WorkerUnitOfNotice;
            }
            set
            {
                this.OnWorkerUnitOfNoticeChanging(value);
                this._WorkerUnitOfNotice = value;
                this.OnWorkerUnitOfNoticeChanged();
                this.OnPropertyChanged("WorkerUnitOfNotice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmUnitOfNotice> _WorkerUnitOfNotice;
        partial void OnWorkerUnitOfNoticeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmUnitOfNotice> value);
        partial void OnWorkerUnitOfNoticeChanged();
        /// <summary>
        /// There are no comments for Property Employment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Employment Employment
        {
            get
            {
                return this._Employment;
            }
            set
            {
                this.OnEmploymentChanging(value);
                this._Employment = value;
                this.OnEmploymentChanged();
                this.OnPropertyChanged("Employment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Employment _Employment;
        partial void OnEmploymentChanging(global::Microsoft.Dynamics.DataEntities.Employment value);
        partial void OnEmploymentChanged();
        /// <summary>
        /// There are no comments for Property ReasonCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReasonCode ReasonCode
        {
            get
            {
                return this._ReasonCode;
            }
            set
            {
                this.OnReasonCodeChanging(value);
                this._ReasonCode = value;
                this.OnReasonCodeChanged();
                this.OnPropertyChanged("ReasonCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReasonCode _ReasonCode;
        partial void OnReasonCodeChanging(global::Microsoft.Dynamics.DataEntities.ReasonCode value);
        partial void OnReasonCodeChanged();
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