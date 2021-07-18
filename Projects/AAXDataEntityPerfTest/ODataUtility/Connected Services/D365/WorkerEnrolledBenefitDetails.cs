﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 7/17/2021 8:49:18 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for WorkerEnrolledBenefitDetailsSingle in the schema.
        /// </summary>
    public partial class WorkerEnrolledBenefitDetailsSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerEnrolledBenefitDetails>
    {
        /// <summary>
        /// Initialize a new WorkerEnrolledBenefitDetailsSingle object.
        /// </summary>
        public WorkerEnrolledBenefitDetailsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkerEnrolledBenefitDetailsSingle object.
        /// </summary>
        public WorkerEnrolledBenefitDetailsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkerEnrolledBenefitDetailsSingle object.
        /// </summary>
        public WorkerEnrolledBenefitDetailsSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerEnrolledBenefitDetails> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WorkerEnrolledBenefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefitSingle WorkerEnrolledBenefit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerEnrolledBenefit == null))
                {
                    this._WorkerEnrolledBenefit = new global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefitSingle(this.Context, GetPath("WorkerEnrolledBenefit"));
                }
                return this._WorkerEnrolledBenefit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefitSingle _WorkerEnrolledBenefit;
        /// <summary>
        /// There are no comments for PositionV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2Single PositionV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PositionV2 == null))
                {
                    this._PositionV2 = new global::Microsoft.Dynamics.DataEntities.PositionV2Single(this.Context, GetPath("PositionV2"));
                }
                return this._PositionV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2Single _PositionV2;
    }
        /// <summary>
        /// There are no comments for WorkerEnrolledBenefitDetails in the schema.
        /// </summary>
    /// <KeyProperties>
    /// BenefitId
    /// PersonnelNumber
    /// EnrollmentStart
    /// EnrollmentEnd
    /// BenefitDetailValidFrom
    /// BenefitDetailValidTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BenefitId", "PersonnelNumber", "EnrollmentStart", "EnrollmentEnd", "BenefitDetailValidFrom", "BenefitDetailValidTo")]
    [global::Microsoft.OData.Client.EntitySet("WorkerEnrolledBenefitDetails")]
    public partial class WorkerEnrolledBenefitDetails : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkerEnrolledBenefitDetails object.
        /// </summary>
        /// <param name="benefitId">Initial value of BenefitId.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="enrollmentStart">Initial value of EnrollmentStart.</param>
        /// <param name="enrollmentEnd">Initial value of EnrollmentEnd.</param>
        /// <param name="benefitDetailValidFrom">Initial value of BenefitDetailValidFrom.</param>
        /// <param name="benefitDetailValidTo">Initial value of BenefitDetailValidTo.</param>
        /// <param name="contributionAmountCur">Initial value of ContributionAmountCur.</param>
        /// <param name="deductionPriorityNumber">Initial value of DeductionPriorityNumber.</param>
        /// <param name="calculationPriorityNumber">Initial value of CalculationPriorityNumber.</param>
        /// <param name="deductionAmountCur">Initial value of DeductionAmountCur.</param>
        /// <param name="workerEnrolledBenefit">Initial value of WorkerEnrolledBenefit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkerEnrolledBenefitDetails CreateWorkerEnrolledBenefitDetails(string benefitId, 
                    string personnelNumber, 
                    global::System.DateTimeOffset enrollmentStart, 
                    global::System.DateTimeOffset enrollmentEnd, 
                    global::System.DateTimeOffset benefitDetailValidFrom, 
                    global::System.DateTimeOffset benefitDetailValidTo, 
                    decimal contributionAmountCur, 
                    long deductionPriorityNumber, 
                    long calculationPriorityNumber, 
                    decimal deductionAmountCur, 
                    global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit workerEnrolledBenefit)
        {
            WorkerEnrolledBenefitDetails workerEnrolledBenefitDetails = new WorkerEnrolledBenefitDetails();
            workerEnrolledBenefitDetails.BenefitId = benefitId;
            workerEnrolledBenefitDetails.PersonnelNumber = personnelNumber;
            workerEnrolledBenefitDetails.EnrollmentStart = enrollmentStart;
            workerEnrolledBenefitDetails.EnrollmentEnd = enrollmentEnd;
            workerEnrolledBenefitDetails.BenefitDetailValidFrom = benefitDetailValidFrom;
            workerEnrolledBenefitDetails.BenefitDetailValidTo = benefitDetailValidTo;
            workerEnrolledBenefitDetails.ContributionAmountCur = contributionAmountCur;
            workerEnrolledBenefitDetails.DeductionPriorityNumber = deductionPriorityNumber;
            workerEnrolledBenefitDetails.CalculationPriorityNumber = calculationPriorityNumber;
            workerEnrolledBenefitDetails.DeductionAmountCur = deductionAmountCur;
            if ((workerEnrolledBenefit == null))
            {
                throw new global::System.ArgumentNullException("workerEnrolledBenefit");
            }
            workerEnrolledBenefitDetails.WorkerEnrolledBenefit = workerEnrolledBenefit;
            return workerEnrolledBenefitDetails;
        }
        /// <summary>
        /// There are no comments for Property BenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BenefitId
        {
            get
            {
                return this._BenefitId;
            }
            set
            {
                this.OnBenefitIdChanging(value);
                this._BenefitId = value;
                this.OnBenefitIdChanged();
                this.OnPropertyChanged("BenefitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitId;
        partial void OnBenefitIdChanging(string value);
        partial void OnBenefitIdChanged();
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
        /// There are no comments for Property EnrollmentStart in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EnrollmentStart
        {
            get
            {
                return this._EnrollmentStart;
            }
            set
            {
                this.OnEnrollmentStartChanging(value);
                this._EnrollmentStart = value;
                this.OnEnrollmentStartChanged();
                this.OnPropertyChanged("EnrollmentStart");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EnrollmentStart;
        partial void OnEnrollmentStartChanging(global::System.DateTimeOffset value);
        partial void OnEnrollmentStartChanged();
        /// <summary>
        /// There are no comments for Property EnrollmentEnd in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EnrollmentEnd
        {
            get
            {
                return this._EnrollmentEnd;
            }
            set
            {
                this.OnEnrollmentEndChanging(value);
                this._EnrollmentEnd = value;
                this.OnEnrollmentEndChanged();
                this.OnPropertyChanged("EnrollmentEnd");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EnrollmentEnd;
        partial void OnEnrollmentEndChanging(global::System.DateTimeOffset value);
        partial void OnEnrollmentEndChanged();
        /// <summary>
        /// There are no comments for Property BenefitDetailValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset BenefitDetailValidFrom
        {
            get
            {
                return this._BenefitDetailValidFrom;
            }
            set
            {
                this.OnBenefitDetailValidFromChanging(value);
                this._BenefitDetailValidFrom = value;
                this.OnBenefitDetailValidFromChanged();
                this.OnPropertyChanged("BenefitDetailValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _BenefitDetailValidFrom;
        partial void OnBenefitDetailValidFromChanging(global::System.DateTimeOffset value);
        partial void OnBenefitDetailValidFromChanged();
        /// <summary>
        /// There are no comments for Property BenefitDetailValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset BenefitDetailValidTo
        {
            get
            {
                return this._BenefitDetailValidTo;
            }
            set
            {
                this.OnBenefitDetailValidToChanging(value);
                this._BenefitDetailValidTo = value;
                this.OnBenefitDetailValidToChanged();
                this.OnPropertyChanged("BenefitDetailValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _BenefitDetailValidTo;
        partial void OnBenefitDetailValidToChanging(global::System.DateTimeOffset value);
        partial void OnBenefitDetailValidToChanged();
        /// <summary>
        /// There are no comments for Property ContributionAmountCur in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ContributionAmountCur
        {
            get
            {
                return this._ContributionAmountCur;
            }
            set
            {
                this.OnContributionAmountCurChanging(value);
                this._ContributionAmountCur = value;
                this.OnContributionAmountCurChanged();
                this.OnPropertyChanged("ContributionAmountCur");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ContributionAmountCur;
        partial void OnContributionAmountCurChanging(decimal value);
        partial void OnContributionAmountCurChanged();
        /// <summary>
        /// There are no comments for Property ContributionBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollContributionBasis> ContributionBasis
        {
            get
            {
                return this._ContributionBasis;
            }
            set
            {
                this.OnContributionBasisChanging(value);
                this._ContributionBasis = value;
                this.OnContributionBasisChanged();
                this.OnPropertyChanged("ContributionBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollContributionBasis> _ContributionBasis;
        partial void OnContributionBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollContributionBasis> value);
        partial void OnContributionBasisChanged();
        /// <summary>
        /// There are no comments for Property PartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PartyNumber
        {
            get
            {
                return this._PartyNumber;
            }
            set
            {
                this.OnPartyNumberChanging(value);
                this._PartyNumber = value;
                this.OnPartyNumberChanged();
                this.OnPropertyChanged("PartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartyNumber;
        partial void OnPartyNumberChanging(string value);
        partial void OnPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property DeductionPriorityNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long DeductionPriorityNumber
        {
            get
            {
                return this._DeductionPriorityNumber;
            }
            set
            {
                this.OnDeductionPriorityNumberChanging(value);
                this._DeductionPriorityNumber = value;
                this.OnDeductionPriorityNumberChanged();
                this.OnPropertyChanged("DeductionPriorityNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _DeductionPriorityNumber;
        partial void OnDeductionPriorityNumberChanging(long value);
        partial void OnDeductionPriorityNumberChanged();
        /// <summary>
        /// There are no comments for Property DeductionBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollDeductionBasis> DeductionBasis
        {
            get
            {
                return this._DeductionBasis;
            }
            set
            {
                this.OnDeductionBasisChanging(value);
                this._DeductionBasis = value;
                this.OnDeductionBasisChanged();
                this.OnPropertyChanged("DeductionBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollDeductionBasis> _DeductionBasis;
        partial void OnDeductionBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollDeductionBasis> value);
        partial void OnDeductionBasisChanged();
        /// <summary>
        /// There are no comments for Property ContributionRateSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollBenefitRateSource> ContributionRateSource
        {
            get
            {
                return this._ContributionRateSource;
            }
            set
            {
                this.OnContributionRateSourceChanging(value);
                this._ContributionRateSource = value;
                this.OnContributionRateSourceChanged();
                this.OnPropertyChanged("ContributionRateSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollBenefitRateSource> _ContributionRateSource;
        partial void OnContributionRateSourceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollBenefitRateSource> value);
        partial void OnContributionRateSourceChanged();
        /// <summary>
        /// There are no comments for Property PositionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PositionId
        {
            get
            {
                return this._PositionId;
            }
            set
            {
                this.OnPositionIdChanging(value);
                this._PositionId = value;
                this.OnPositionIdChanged();
                this.OnPropertyChanged("PositionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PositionId;
        partial void OnPositionIdChanging(string value);
        partial void OnPositionIdChanged();
        /// <summary>
        /// There are no comments for Property OverrideLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> OverrideLimit
        {
            get
            {
                return this._OverrideLimit;
            }
            set
            {
                this.OnOverrideLimitChanging(value);
                this._OverrideLimit = value;
                this.OnOverrideLimitChanged();
                this.OnPropertyChanged("OverrideLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _OverrideLimit;
        partial void OnOverrideLimitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnOverrideLimitChanged();
        /// <summary>
        /// There are no comments for Property CalculationPriorityNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long CalculationPriorityNumber
        {
            get
            {
                return this._CalculationPriorityNumber;
            }
            set
            {
                this.OnCalculationPriorityNumberChanging(value);
                this._CalculationPriorityNumber = value;
                this.OnCalculationPriorityNumberChanged();
                this.OnPropertyChanged("CalculationPriorityNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _CalculationPriorityNumber;
        partial void OnCalculationPriorityNumberChanging(long value);
        partial void OnCalculationPriorityNumberChanged();
        /// <summary>
        /// There are no comments for Property DataArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DataArea
        {
            get
            {
                return this._DataArea;
            }
            set
            {
                this.OnDataAreaChanging(value);
                this._DataArea = value;
                this.OnDataAreaChanged();
                this.OnPropertyChanged("DataArea");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataArea;
        partial void OnDataAreaChanging(string value);
        partial void OnDataAreaChanged();
        /// <summary>
        /// There are no comments for Property DeductionAmountCur in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DeductionAmountCur
        {
            get
            {
                return this._DeductionAmountCur;
            }
            set
            {
                this.OnDeductionAmountCurChanging(value);
                this._DeductionAmountCur = value;
                this.OnDeductionAmountCurChanged();
                this.OnPropertyChanged("DeductionAmountCur");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DeductionAmountCur;
        partial void OnDeductionAmountCurChanging(decimal value);
        partial void OnDeductionAmountCurChanged();
        /// <summary>
        /// There are no comments for Property Note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this.OnNoteChanging(value);
                this._Note = value;
                this.OnNoteChanged();
                this.OnPropertyChanged("Note");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Note;
        partial void OnNoteChanging(string value);
        partial void OnNoteChanged();
        /// <summary>
        /// There are no comments for Property DeductionRateSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollBenefitRateSource> DeductionRateSource
        {
            get
            {
                return this._DeductionRateSource;
            }
            set
            {
                this.OnDeductionRateSourceChanging(value);
                this._DeductionRateSource = value;
                this.OnDeductionRateSourceChanged();
                this.OnPropertyChanged("DeductionRateSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollBenefitRateSource> _DeductionRateSource;
        partial void OnDeductionRateSourceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollBenefitRateSource> value);
        partial void OnDeductionRateSourceChanged();
        /// <summary>
        /// There are no comments for Property IsRetirementCatchUp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsRetirementCatchUp
        {
            get
            {
                return this._IsRetirementCatchUp;
            }
            set
            {
                this.OnIsRetirementCatchUpChanging(value);
                this._IsRetirementCatchUp = value;
                this.OnIsRetirementCatchUpChanged();
                this.OnPropertyChanged("IsRetirementCatchUp");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsRetirementCatchUp;
        partial void OnIsRetirementCatchUpChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsRetirementCatchUpChanged();
        /// <summary>
        /// There are no comments for Property VendAccountNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendAccountNum
        {
            get
            {
                return this._VendAccountNum;
            }
            set
            {
                this.OnVendAccountNumChanging(value);
                this._VendAccountNum = value;
                this.OnVendAccountNumChanged();
                this.OnPropertyChanged("VendAccountNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendAccountNum;
        partial void OnVendAccountNumChanging(string value);
        partial void OnVendAccountNumChanged();
        /// <summary>
        /// There are no comments for Property WorkerEnrolledBenefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit WorkerEnrolledBenefit
        {
            get
            {
                return this._WorkerEnrolledBenefit;
            }
            set
            {
                this.OnWorkerEnrolledBenefitChanging(value);
                this._WorkerEnrolledBenefit = value;
                this.OnWorkerEnrolledBenefitChanged();
                this.OnPropertyChanged("WorkerEnrolledBenefit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit _WorkerEnrolledBenefit;
        partial void OnWorkerEnrolledBenefitChanging(global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit value);
        partial void OnWorkerEnrolledBenefitChanged();
        /// <summary>
        /// There are no comments for Property PositionV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2 PositionV2
        {
            get
            {
                return this._PositionV2;
            }
            set
            {
                this.OnPositionV2Changing(value);
                this._PositionV2 = value;
                this.OnPositionV2Changed();
                this.OnPropertyChanged("PositionV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2 _PositionV2;
        partial void OnPositionV2Changing(global::Microsoft.Dynamics.DataEntities.PositionV2 value);
        partial void OnPositionV2Changed();
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
