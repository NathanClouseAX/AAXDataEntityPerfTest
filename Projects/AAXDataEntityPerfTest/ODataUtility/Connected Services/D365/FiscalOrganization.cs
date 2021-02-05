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
        /// There are no comments for FiscalOrganizationSingle in the schema.
        /// </summary>
    public partial class FiscalOrganizationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalOrganization>
    {
        /// <summary>
        /// Initialize a new FiscalOrganizationSingle object.
        /// </summary>
        public FiscalOrganizationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FiscalOrganizationSingle object.
        /// </summary>
        public FiscalOrganizationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FiscalOrganizationSingle object.
        /// </summary>
        public FiscalOrganizationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalOrganization> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
    }
        /// <summary>
        /// There are no comments for FiscalOrganization in the schema.
        /// </summary>
    /// <KeyProperties>
    /// RootFiscalEstablishmentDataArea
    /// RootFiscalEstablishment
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RootFiscalEstablishmentDataArea", "RootFiscalEstablishment")]
    [global::Microsoft.OData.Client.EntitySet("FiscalOrganizations")]
    public partial class FiscalOrganization : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FiscalOrganization object.
        /// </summary>
        /// <param name="rootFiscalEstablishmentDataArea">Initial value of RootFiscalEstablishmentDataArea.</param>
        /// <param name="rootFiscalEstablishment">Initial value of RootFiscalEstablishment.</param>
        /// <param name="constitutionArchiveDate">Initial value of ConstitutionArchiveDate.</param>
        /// <param name="conversionArchiveDate">Initial value of ConversionArchiveDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FiscalOrganization CreateFiscalOrganization(string rootFiscalEstablishmentDataArea, string rootFiscalEstablishment, global::System.DateTimeOffset constitutionArchiveDate, global::System.DateTimeOffset conversionArchiveDate)
        {
            FiscalOrganization fiscalOrganization = new FiscalOrganization();
            fiscalOrganization.RootFiscalEstablishmentDataArea = rootFiscalEstablishmentDataArea;
            fiscalOrganization.RootFiscalEstablishment = rootFiscalEstablishment;
            fiscalOrganization.ConstitutionArchiveDate = constitutionArchiveDate;
            fiscalOrganization.ConversionArchiveDate = conversionArchiveDate;
            return fiscalOrganization;
        }
        /// <summary>
        /// There are no comments for Property RootFiscalEstablishmentDataArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RootFiscalEstablishmentDataArea
        {
            get
            {
                return this._RootFiscalEstablishmentDataArea;
            }
            set
            {
                this.OnRootFiscalEstablishmentDataAreaChanging(value);
                this._RootFiscalEstablishmentDataArea = value;
                this.OnRootFiscalEstablishmentDataAreaChanged();
                this.OnPropertyChanged("RootFiscalEstablishmentDataArea");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RootFiscalEstablishmentDataArea;
        partial void OnRootFiscalEstablishmentDataAreaChanging(string value);
        partial void OnRootFiscalEstablishmentDataAreaChanged();
        /// <summary>
        /// There are no comments for Property RootFiscalEstablishment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RootFiscalEstablishment
        {
            get
            {
                return this._RootFiscalEstablishment;
            }
            set
            {
                this.OnRootFiscalEstablishmentChanging(value);
                this._RootFiscalEstablishment = value;
                this.OnRootFiscalEstablishmentChanged();
                this.OnPropertyChanged("RootFiscalEstablishment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RootFiscalEstablishment;
        partial void OnRootFiscalEstablishmentChanging(string value);
        partial void OnRootFiscalEstablishmentChanged();
        /// <summary>
        /// There are no comments for Property TypeOfAssessmentContribution in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribAssessmentContributionType_BR> TypeOfAssessmentContribution
        {
            get
            {
                return this._TypeOfAssessmentContribution;
            }
            set
            {
                this.OnTypeOfAssessmentContributionChanging(value);
                this._TypeOfAssessmentContribution = value;
                this.OnTypeOfAssessmentContributionChanged();
                this.OnPropertyChanged("TypeOfAssessmentContribution");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribAssessmentContributionType_BR> _TypeOfAssessmentContribution;
        partial void OnTypeOfAssessmentContributionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribAssessmentContributionType_BR> value);
        partial void OnTypeOfAssessmentContributionChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxPISExpenseDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesTaxPISExpenseDisplayValue
        {
            get
            {
                return this._SalesTaxPISExpenseDisplayValue;
            }
            set
            {
                this.OnSalesTaxPISExpenseDisplayValueChanging(value);
                this._SalesTaxPISExpenseDisplayValue = value;
                this.OnSalesTaxPISExpenseDisplayValueChanged();
                this.OnPropertyChanged("SalesTaxPISExpenseDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxPISExpenseDisplayValue;
        partial void OnSalesTaxPISExpenseDisplayValueChanging(string value);
        partial void OnSalesTaxPISExpenseDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property LegalEntityType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribLegalEntityType_BR> LegalEntityType
        {
            get
            {
                return this._LegalEntityType;
            }
            set
            {
                this.OnLegalEntityTypeChanging(value);
                this._LegalEntityType = value;
                this.OnLegalEntityTypeChanged();
                this.OnPropertyChanged("LegalEntityType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribLegalEntityType_BR> _LegalEntityType;
        partial void OnLegalEntityTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribLegalEntityType_BR> value);
        partial void OnLegalEntityTypeChanged();
        /// <summary>
        /// There are no comments for Property TypeOfActivity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribActivityType_BR> TypeOfActivity
        {
            get
            {
                return this._TypeOfActivity;
            }
            set
            {
                this.OnTypeOfActivityChanging(value);
                this._TypeOfActivity = value;
                this.OnTypeOfActivityChanged();
                this.OnPropertyChanged("TypeOfActivity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribActivityType_BR> _TypeOfActivity;
        partial void OnTypeOfActivityChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribActivityType_BR> value);
        partial void OnTypeOfActivityChanged();
        /// <summary>
        /// There are no comments for Property CompanyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBCompanyType_BR> CompanyType
        {
            get
            {
                return this._CompanyType;
            }
            set
            {
                this.OnCompanyTypeChanging(value);
                this._CompanyType = value;
                this.OnCompanyTypeChanged();
                this.OnPropertyChanged("CompanyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBCompanyType_BR> _CompanyType;
        partial void OnCompanyTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBCompanyType_BR> value);
        partial void OnCompanyTypeChanged();
        /// <summary>
        /// There are no comments for Property BookingAndAssessmentCriteria in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribAssessmentCriteria_BR> BookingAndAssessmentCriteria
        {
            get
            {
                return this._BookingAndAssessmentCriteria;
            }
            set
            {
                this.OnBookingAndAssessmentCriteriaChanging(value);
                this._BookingAndAssessmentCriteria = value;
                this.OnBookingAndAssessmentCriteriaChanged();
                this.OnPropertyChanged("BookingAndAssessmentCriteria");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribAssessmentCriteria_BR> _BookingAndAssessmentCriteria;
        partial void OnBookingAndAssessmentCriteriaChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribAssessmentCriteria_BR> value);
        partial void OnBookingAndAssessmentCriteriaChanged();
        /// <summary>
        /// There are no comments for Property SCPParticipation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBSCPType_BR> SCPParticipation
        {
            get
            {
                return this._SCPParticipation;
            }
            set
            {
                this.OnSCPParticipationChanging(value);
                this._SCPParticipation = value;
                this.OnSCPParticipationChanged();
                this.OnPropertyChanged("SCPParticipation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBSCPType_BR> _SCPParticipation;
        partial void OnSCPParticipationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBSCPType_BR> value);
        partial void OnSCPParticipationChanged();
        /// <summary>
        /// There are no comments for Property ConstitutionArchiveDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ConstitutionArchiveDate
        {
            get
            {
                return this._ConstitutionArchiveDate;
            }
            set
            {
                this.OnConstitutionArchiveDateChanging(value);
                this._ConstitutionArchiveDate = value;
                this.OnConstitutionArchiveDateChanged();
                this.OnPropertyChanged("ConstitutionArchiveDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ConstitutionArchiveDate;
        partial void OnConstitutionArchiveDateChanging(global::System.DateTimeOffset value);
        partial void OnConstitutionArchiveDateChanged();
        /// <summary>
        /// There are no comments for Property SCPCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SCPCode
        {
            get
            {
                return this._SCPCode;
            }
            set
            {
                this.OnSCPCodeChanging(value);
                this._SCPCode = value;
                this.OnSCPCodeChanged();
                this.OnPropertyChanged("SCPCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SCPCode;
        partial void OnSCPCodeChanging(string value);
        partial void OnSCPCodeChanged();
        /// <summary>
        /// There are no comments for Property LegalNature in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalNature
        {
            get
            {
                return this._LegalNature;
            }
            set
            {
                this.OnLegalNatureChanging(value);
                this._LegalNature = value;
                this.OnLegalNatureChanged();
                this.OnPropertyChanged("LegalNature");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalNature;
        partial void OnLegalNatureChanging(string value);
        partial void OnLegalNatureChanged();
        /// <summary>
        /// There are no comments for Property LayoutVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribVersion_BR> LayoutVersion
        {
            get
            {
                return this._LayoutVersion;
            }
            set
            {
                this.OnLayoutVersionChanging(value);
                this._LayoutVersion = value;
                this.OnLayoutVersionChanged();
                this.OnPropertyChanged("LayoutVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribVersion_BR> _LayoutVersion;
        partial void OnLayoutVersionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribVersion_BR> value);
        partial void OnLayoutVersionChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxCOFINSExpenseDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesTaxCOFINSExpenseDisplayValue
        {
            get
            {
                return this._SalesTaxCOFINSExpenseDisplayValue;
            }
            set
            {
                this.OnSalesTaxCOFINSExpenseDisplayValueChanging(value);
                this._SalesTaxCOFINSExpenseDisplayValue = value;
                this.OnSalesTaxCOFINSExpenseDisplayValueChanged();
                this.OnPropertyChanged("SalesTaxCOFINSExpenseDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxCOFINSExpenseDisplayValue;
        partial void OnSalesTaxCOFINSExpenseDisplayValueChanging(string value);
        partial void OnSalesTaxCOFINSExpenseDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property ConversionArchiveDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ConversionArchiveDate
        {
            get
            {
                return this._ConversionArchiveDate;
            }
            set
            {
                this.OnConversionArchiveDateChanging(value);
                this._ConversionArchiveDate = value;
                this.OnConversionArchiveDateChanged();
                this.OnPropertyChanged("ConversionArchiveDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ConversionArchiveDate;
        partial void OnConversionArchiveDateChanging(global::System.DateTimeOffset value);
        partial void OnConversionArchiveDateChanged();
        /// <summary>
        /// There are no comments for Property CreditAllocationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribCreditAllocationMethod_BR> CreditAllocationMethod
        {
            get
            {
                return this._CreditAllocationMethod;
            }
            set
            {
                this.OnCreditAllocationMethodChanging(value);
                this._CreditAllocationMethod = value;
                this.OnCreditAllocationMethodChanged();
                this.OnPropertyChanged("CreditAllocationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribCreditAllocationMethod_BR> _CreditAllocationMethod;
        partial void OnCreditAllocationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribCreditAllocationMethod_BR> value);
        partial void OnCreditAllocationMethodChanged();
        /// <summary>
        /// There are no comments for Property AssessmentRegimen in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribAssessmentRegimen_BR> AssessmentRegimen
        {
            get
            {
                return this._AssessmentRegimen;
            }
            set
            {
                this.OnAssessmentRegimenChanging(value);
                this._AssessmentRegimen = value;
                this.OnAssessmentRegimenChanged();
                this.OnPropertyChanged("AssessmentRegimen");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribAssessmentRegimen_BR> _AssessmentRegimen;
        partial void OnAssessmentRegimenChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBContribAssessmentRegimen_BR> value);
        partial void OnAssessmentRegimenChanged();
        /// <summary>
        /// There are no comments for Property LargeCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> LargeCompany
        {
            get
            {
                return this._LargeCompany;
            }
            set
            {
                this.OnLargeCompanyChanging(value);
                this._LargeCompany = value;
                this.OnLargeCompanyChanged();
                this.OnPropertyChanged("LargeCompany");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _LargeCompany;
        partial void OnLargeCompanyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnLargeCompanyChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
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
