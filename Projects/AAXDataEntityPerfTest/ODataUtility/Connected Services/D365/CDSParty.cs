﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/3/2021 8:21:45 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for CDSPartySingle in the schema.
        /// </summary>
    public partial class CDSPartySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CDSParty>
    {
        /// <summary>
        /// Initialize a new CDSPartySingle object.
        /// </summary>
        public CDSPartySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CDSPartySingle object.
        /// </summary>
        public CDSPartySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CDSPartySingle object.
        /// </summary>
        public CDSPartySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CDSParty> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Customer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerV3Single Customer
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Customer == null))
                {
                    this._Customer = new global::Microsoft.Dynamics.DataEntities.CustomerV3Single(this.Context, GetPath("Customer"));
                }
                return this._Customer;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerV3Single _Customer;
    }
        /// <summary>
        /// There are no comments for CDSParty in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PartyNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PartyNumber")]
    [global::Microsoft.OData.Client.EntitySet("CDSParties")]
    public partial class CDSParty : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CDSParty object.
        /// </summary>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        /// <param name="personBirthDay">Initial value of PersonBirthDay.</param>
        /// <param name="personAnniversaryYear">Initial value of PersonAnniversaryYear.</param>
        /// <param name="personAnniversaryDay">Initial value of PersonAnniversaryDay.</param>
        /// <param name="personBirthYear">Initial value of PersonBirthYear.</param>
        /// <param name="organizationNumOfEmployees">Initial value of OrganizationNumOfEmployees.</param>
        /// <param name="customer">Initial value of Customer.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CDSParty CreateCDSParty(string partyNumber, 
                    int personBirthDay, 
                    int personAnniversaryYear, 
                    int personAnniversaryDay, 
                    int personBirthYear, 
                    int organizationNumOfEmployees, 
                    global::Microsoft.Dynamics.DataEntities.CustomerV3 customer)
        {
            CDSParty cDSParty = new CDSParty();
            cDSParty.PartyNumber = partyNumber;
            cDSParty.PersonBirthDay = personBirthDay;
            cDSParty.PersonAnniversaryYear = personAnniversaryYear;
            cDSParty.PersonAnniversaryDay = personAnniversaryDay;
            cDSParty.PersonBirthYear = personBirthYear;
            cDSParty.OrganizationNumOfEmployees = organizationNumOfEmployees;
            if ((customer == null))
            {
                throw new global::System.ArgumentNullException("customer");
            }
            cDSParty.Customer = customer;
            return cDSParty;
        }
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
        /// There are no comments for Property PersonPersonalSuffix in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonPersonalSuffix
        {
            get
            {
                return this._PersonPersonalSuffix;
            }
            set
            {
                this.OnPersonPersonalSuffixChanging(value);
                this._PersonPersonalSuffix = value;
                this.OnPersonPersonalSuffixChanged();
                this.OnPropertyChanged("PersonPersonalSuffix");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonPersonalSuffix;
        partial void OnPersonPersonalSuffixChanging(string value);
        partial void OnPersonPersonalSuffixChanged();
        /// <summary>
        /// There are no comments for Property PersonPhoneticLastName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonPhoneticLastName
        {
            get
            {
                return this._PersonPhoneticLastName;
            }
            set
            {
                this.OnPersonPhoneticLastNameChanging(value);
                this._PersonPhoneticLastName = value;
                this.OnPersonPhoneticLastNameChanged();
                this.OnPropertyChanged("PersonPhoneticLastName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonPhoneticLastName;
        partial void OnPersonPhoneticLastNameChanging(string value);
        partial void OnPersonPhoneticLastNameChanged();
        /// <summary>
        /// There are no comments for Property PersonAnniversaryMonth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MonthsOfYear> PersonAnniversaryMonth
        {
            get
            {
                return this._PersonAnniversaryMonth;
            }
            set
            {
                this.OnPersonAnniversaryMonthChanging(value);
                this._PersonAnniversaryMonth = value;
                this.OnPersonAnniversaryMonthChanged();
                this.OnPropertyChanged("PersonAnniversaryMonth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MonthsOfYear> _PersonAnniversaryMonth;
        partial void OnPersonAnniversaryMonthChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MonthsOfYear> value);
        partial void OnPersonAnniversaryMonthChanged();
        /// <summary>
        /// There are no comments for Property PersonLastName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonLastName
        {
            get
            {
                return this._PersonLastName;
            }
            set
            {
                this.OnPersonLastNameChanging(value);
                this._PersonLastName = value;
                this.OnPersonLastNameChanged();
                this.OnPropertyChanged("PersonLastName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonLastName;
        partial void OnPersonLastNameChanging(string value);
        partial void OnPersonLastNameChanged();
        /// <summary>
        /// There are no comments for Property PartyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PartyType
        {
            get
            {
                return this._PartyType;
            }
            set
            {
                this.OnPartyTypeChanging(value);
                this._PartyType = value;
                this.OnPartyTypeChanged();
                this.OnPropertyChanged("PartyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartyType;
        partial void OnPartyTypeChanging(string value);
        partial void OnPartyTypeChanged();
        /// <summary>
        /// There are no comments for Property PersonPersonalTitle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonPersonalTitle
        {
            get
            {
                return this._PersonPersonalTitle;
            }
            set
            {
                this.OnPersonPersonalTitleChanging(value);
                this._PersonPersonalTitle = value;
                this.OnPersonPersonalTitleChanged();
                this.OnPropertyChanged("PersonPersonalTitle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonPersonalTitle;
        partial void OnPersonPersonalTitleChanging(string value);
        partial void OnPersonPersonalTitleChanged();
        /// <summary>
        /// There are no comments for Property PersonInitials in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonInitials
        {
            get
            {
                return this._PersonInitials;
            }
            set
            {
                this.OnPersonInitialsChanging(value);
                this._PersonInitials = value;
                this.OnPersonInitialsChanged();
                this.OnPropertyChanged("PersonInitials");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonInitials;
        partial void OnPersonInitialsChanging(string value);
        partial void OnPersonInitialsChanged();
        /// <summary>
        /// There are no comments for Property PersonGender in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Gender> PersonGender
        {
            get
            {
                return this._PersonGender;
            }
            set
            {
                this.OnPersonGenderChanging(value);
                this._PersonGender = value;
                this.OnPersonGenderChanged();
                this.OnPropertyChanged("PersonGender");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Gender> _PersonGender;
        partial void OnPersonGenderChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Gender> value);
        partial void OnPersonGenderChanged();
        /// <summary>
        /// There are no comments for Property PersonLastNamePrefix in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonLastNamePrefix
        {
            get
            {
                return this._PersonLastNamePrefix;
            }
            set
            {
                this.OnPersonLastNamePrefixChanging(value);
                this._PersonLastNamePrefix = value;
                this.OnPersonLastNamePrefixChanged();
                this.OnPropertyChanged("PersonLastNamePrefix");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonLastNamePrefix;
        partial void OnPersonLastNamePrefixChanging(string value);
        partial void OnPersonLastNamePrefixChanged();
        /// <summary>
        /// There are no comments for Property PersonBirthDay in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int PersonBirthDay
        {
            get
            {
                return this._PersonBirthDay;
            }
            set
            {
                this.OnPersonBirthDayChanging(value);
                this._PersonBirthDay = value;
                this.OnPersonBirthDayChanged();
                this.OnPropertyChanged("PersonBirthDay");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PersonBirthDay;
        partial void OnPersonBirthDayChanging(int value);
        partial void OnPersonBirthDayChanged();
        /// <summary>
        /// There are no comments for Property LanguageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LanguageId
        {
            get
            {
                return this._LanguageId;
            }
            set
            {
                this.OnLanguageIdChanging(value);
                this._LanguageId = value;
                this.OnLanguageIdChanged();
                this.OnPropertyChanged("LanguageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LanguageId;
        partial void OnLanguageIdChanging(string value);
        partial void OnLanguageIdChanged();
        /// <summary>
        /// There are no comments for Property OrganizationPhoneticName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OrganizationPhoneticName
        {
            get
            {
                return this._OrganizationPhoneticName;
            }
            set
            {
                this.OnOrganizationPhoneticNameChanging(value);
                this._OrganizationPhoneticName = value;
                this.OnOrganizationPhoneticNameChanged();
                this.OnPropertyChanged("OrganizationPhoneticName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrganizationPhoneticName;
        partial void OnOrganizationPhoneticNameChanging(string value);
        partial void OnOrganizationPhoneticNameChanged();
        /// <summary>
        /// There are no comments for Property PersonAnniversaryYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int PersonAnniversaryYear
        {
            get
            {
                return this._PersonAnniversaryYear;
            }
            set
            {
                this.OnPersonAnniversaryYearChanging(value);
                this._PersonAnniversaryYear = value;
                this.OnPersonAnniversaryYearChanged();
                this.OnPropertyChanged("PersonAnniversaryYear");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PersonAnniversaryYear;
        partial void OnPersonAnniversaryYearChanging(int value);
        partial void OnPersonAnniversaryYearChanged();
        /// <summary>
        /// There are no comments for Property PersonAnniversaryDay in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int PersonAnniversaryDay
        {
            get
            {
                return this._PersonAnniversaryDay;
            }
            set
            {
                this.OnPersonAnniversaryDayChanging(value);
                this._PersonAnniversaryDay = value;
                this.OnPersonAnniversaryDayChanged();
                this.OnPropertyChanged("PersonAnniversaryDay");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PersonAnniversaryDay;
        partial void OnPersonAnniversaryDayChanging(int value);
        partial void OnPersonAnniversaryDayChanged();
        /// <summary>
        /// There are no comments for Property PersonMaritalStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirPersonMaritalStatus> PersonMaritalStatus
        {
            get
            {
                return this._PersonMaritalStatus;
            }
            set
            {
                this.OnPersonMaritalStatusChanging(value);
                this._PersonMaritalStatus = value;
                this.OnPersonMaritalStatusChanged();
                this.OnPropertyChanged("PersonMaritalStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirPersonMaritalStatus> _PersonMaritalStatus;
        partial void OnPersonMaritalStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirPersonMaritalStatus> value);
        partial void OnPersonMaritalStatusChanged();
        /// <summary>
        /// There are no comments for Property PersonPhoneticMiddleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonPhoneticMiddleName
        {
            get
            {
                return this._PersonPhoneticMiddleName;
            }
            set
            {
                this.OnPersonPhoneticMiddleNameChanging(value);
                this._PersonPhoneticMiddleName = value;
                this.OnPersonPhoneticMiddleNameChanged();
                this.OnPropertyChanged("PersonPhoneticMiddleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonPhoneticMiddleName;
        partial void OnPersonPhoneticMiddleNameChanging(string value);
        partial void OnPersonPhoneticMiddleNameChanged();
        /// <summary>
        /// There are no comments for Property PersonChildrenNames in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonChildrenNames
        {
            get
            {
                return this._PersonChildrenNames;
            }
            set
            {
                this.OnPersonChildrenNamesChanging(value);
                this._PersonChildrenNames = value;
                this.OnPersonChildrenNamesChanged();
                this.OnPropertyChanged("PersonChildrenNames");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonChildrenNames;
        partial void OnPersonChildrenNamesChanging(string value);
        partial void OnPersonChildrenNamesChanged();
        /// <summary>
        /// There are no comments for Property PersonBirthYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int PersonBirthYear
        {
            get
            {
                return this._PersonBirthYear;
            }
            set
            {
                this.OnPersonBirthYearChanging(value);
                this._PersonBirthYear = value;
                this.OnPersonBirthYearChanged();
                this.OnPropertyChanged("PersonBirthYear");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PersonBirthYear;
        partial void OnPersonBirthYearChanging(int value);
        partial void OnPersonBirthYearChanged();
        /// <summary>
        /// There are no comments for Property PersonMiddleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonMiddleName
        {
            get
            {
                return this._PersonMiddleName;
            }
            set
            {
                this.OnPersonMiddleNameChanging(value);
                this._PersonMiddleName = value;
                this.OnPersonMiddleNameChanged();
                this.OnPropertyChanged("PersonMiddleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonMiddleName;
        partial void OnPersonMiddleNameChanging(string value);
        partial void OnPersonMiddleNameChanged();
        /// <summary>
        /// There are no comments for Property OrganizationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OrganizationNumber
        {
            get
            {
                return this._OrganizationNumber;
            }
            set
            {
                this.OnOrganizationNumberChanging(value);
                this._OrganizationNumber = value;
                this.OnOrganizationNumberChanged();
                this.OnPropertyChanged("OrganizationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrganizationNumber;
        partial void OnOrganizationNumberChanging(string value);
        partial void OnOrganizationNumberChanged();
        /// <summary>
        /// There are no comments for Property PersonProfessionalSuffix in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonProfessionalSuffix
        {
            get
            {
                return this._PersonProfessionalSuffix;
            }
            set
            {
                this.OnPersonProfessionalSuffixChanging(value);
                this._PersonProfessionalSuffix = value;
                this.OnPersonProfessionalSuffixChanged();
                this.OnPropertyChanged("PersonProfessionalSuffix");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonProfessionalSuffix;
        partial void OnPersonProfessionalSuffixChanging(string value);
        partial void OnPersonProfessionalSuffixChanged();
        /// <summary>
        /// There are no comments for Property OrganizationABCCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ABC> OrganizationABCCode
        {
            get
            {
                return this._OrganizationABCCode;
            }
            set
            {
                this.OnOrganizationABCCodeChanging(value);
                this._OrganizationABCCode = value;
                this.OnOrganizationABCCodeChanged();
                this.OnPropertyChanged("OrganizationABCCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ABC> _OrganizationABCCode;
        partial void OnOrganizationABCCodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ABC> value);
        partial void OnOrganizationABCCodeChanged();
        /// <summary>
        /// There are no comments for Property AddressBooks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressBooks
        {
            get
            {
                return this._AddressBooks;
            }
            set
            {
                this.OnAddressBooksChanging(value);
                this._AddressBooks = value;
                this.OnAddressBooksChanged();
                this.OnPropertyChanged("AddressBooks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressBooks;
        partial void OnAddressBooksChanging(string value);
        partial void OnAddressBooksChanged();
        /// <summary>
        /// There are no comments for Property PersonFirstName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonFirstName
        {
            get
            {
                return this._PersonFirstName;
            }
            set
            {
                this.OnPersonFirstNameChanging(value);
                this._PersonFirstName = value;
                this.OnPersonFirstNameChanged();
                this.OnPropertyChanged("PersonFirstName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonFirstName;
        partial void OnPersonFirstNameChanging(string value);
        partial void OnPersonFirstNameChanged();
        /// <summary>
        /// There are no comments for Property KnownAs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string KnownAs
        {
            get
            {
                return this._KnownAs;
            }
            set
            {
                this.OnKnownAsChanging(value);
                this._KnownAs = value;
                this.OnKnownAsChanged();
                this.OnPropertyChanged("KnownAs");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _KnownAs;
        partial void OnKnownAsChanging(string value);
        partial void OnKnownAsChanged();
        /// <summary>
        /// There are no comments for Property OrganizationNumOfEmployees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int OrganizationNumOfEmployees
        {
            get
            {
                return this._OrganizationNumOfEmployees;
            }
            set
            {
                this.OnOrganizationNumOfEmployeesChanging(value);
                this._OrganizationNumOfEmployees = value;
                this.OnOrganizationNumOfEmployeesChanged();
                this.OnPropertyChanged("OrganizationNumOfEmployees");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _OrganizationNumOfEmployees;
        partial void OnOrganizationNumOfEmployeesChanging(int value);
        partial void OnOrganizationNumOfEmployeesChanged();
        /// <summary>
        /// There are no comments for Property PersonPhoneticFirstName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonPhoneticFirstName
        {
            get
            {
                return this._PersonPhoneticFirstName;
            }
            set
            {
                this.OnPersonPhoneticFirstNameChanging(value);
                this._PersonPhoneticFirstName = value;
                this.OnPersonPhoneticFirstNameChanged();
                this.OnPropertyChanged("PersonPhoneticFirstName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonPhoneticFirstName;
        partial void OnPersonPhoneticFirstNameChanging(string value);
        partial void OnPersonPhoneticFirstNameChanged();
        /// <summary>
        /// There are no comments for Property PersonBirthMonth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MonthsOfYear> PersonBirthMonth
        {
            get
            {
                return this._PersonBirthMonth;
            }
            set
            {
                this.OnPersonBirthMonthChanging(value);
                this._PersonBirthMonth = value;
                this.OnPersonBirthMonthChanged();
                this.OnPropertyChanged("PersonBirthMonth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MonthsOfYear> _PersonBirthMonth;
        partial void OnPersonBirthMonthChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MonthsOfYear> value);
        partial void OnPersonBirthMonthChanged();
        /// <summary>
        /// There are no comments for Property PersonProfessionalTitle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonProfessionalTitle
        {
            get
            {
                return this._PersonProfessionalTitle;
            }
            set
            {
                this.OnPersonProfessionalTitleChanging(value);
                this._PersonProfessionalTitle = value;
                this.OnPersonProfessionalTitleChanged();
                this.OnPropertyChanged("PersonProfessionalTitle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonProfessionalTitle;
        partial void OnPersonProfessionalTitleChanging(string value);
        partial void OnPersonProfessionalTitleChanged();
        /// <summary>
        /// There are no comments for Property NameAlias in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string NameAlias
        {
            get
            {
                return this._NameAlias;
            }
            set
            {
                this.OnNameAliasChanging(value);
                this._NameAlias = value;
                this.OnNameAliasChanged();
                this.OnPropertyChanged("NameAlias");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NameAlias;
        partial void OnNameAliasChanging(string value);
        partial void OnNameAliasChanged();
        /// <summary>
        /// There are no comments for Property OrganizationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OrganizationName
        {
            get
            {
                return this._OrganizationName;
            }
            set
            {
                this.OnOrganizationNameChanging(value);
                this._OrganizationName = value;
                this.OnOrganizationNameChanged();
                this.OnPropertyChanged("OrganizationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrganizationName;
        partial void OnOrganizationNameChanging(string value);
        partial void OnOrganizationNameChanged();
        /// <summary>
        /// There are no comments for Property PersonHobbies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonHobbies
        {
            get
            {
                return this._PersonHobbies;
            }
            set
            {
                this.OnPersonHobbiesChanging(value);
                this._PersonHobbies = value;
                this.OnPersonHobbiesChanged();
                this.OnPropertyChanged("PersonHobbies");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonHobbies;
        partial void OnPersonHobbiesChanging(string value);
        partial void OnPersonHobbiesChanged();
        /// <summary>
        /// There are no comments for Property Customer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerV3 Customer
        {
            get
            {
                return this._Customer;
            }
            set
            {
                this.OnCustomerChanging(value);
                this._Customer = value;
                this.OnCustomerChanged();
                this.OnPropertyChanged("Customer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerV3 _Customer;
        partial void OnCustomerChanging(global::Microsoft.Dynamics.DataEntities.CustomerV3 value);
        partial void OnCustomerChanged();
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
