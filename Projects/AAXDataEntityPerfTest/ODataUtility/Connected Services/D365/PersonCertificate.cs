﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 12/8/2020 7:45:22 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for PersonCertificateSingle in the schema.
        /// </summary>
    public partial class PersonCertificateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PersonCertificate>
    {
        /// <summary>
        /// Initialize a new PersonCertificateSingle object.
        /// </summary>
        public PersonCertificateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PersonCertificateSingle object.
        /// </summary>
        public PersonCertificateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PersonCertificateSingle object.
        /// </summary>
        public PersonCertificateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PersonCertificate> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PersonSingle Person
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Person == null))
                {
                    this._Person = new global::Microsoft.Dynamics.DataEntities.PersonSingle(this.Context, GetPath("Person"));
                }
                return this._Person;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PersonSingle _Person;
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
    }
        /// <summary>
        /// There are no comments for PersonCertificate in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PartyNumber
    /// CertificateTypeId
    /// StartDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PartyNumber", "CertificateTypeId", "StartDate")]
    [global::Microsoft.OData.Client.EntitySet("PersonCertificates")]
    public partial class PersonCertificate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PersonCertificate object.
        /// </summary>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        /// <param name="certificateTypeId">Initial value of CertificateTypeId.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="person">Initial value of Person.</param>
        /// <param name="certificateType">Initial value of CertificateType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PersonCertificate CreatePersonCertificate(string partyNumber, 
                    string certificateTypeId, 
                    global::System.DateTimeOffset startDate, 
                    global::System.DateTimeOffset endDate, 
                    global::Microsoft.Dynamics.DataEntities.Person person, 
                    global::Microsoft.Dynamics.DataEntities.CertificateType certificateType)
        {
            PersonCertificate personCertificate = new PersonCertificate();
            personCertificate.PartyNumber = partyNumber;
            personCertificate.CertificateTypeId = certificateTypeId;
            personCertificate.StartDate = startDate;
            personCertificate.EndDate = endDate;
            if ((person == null))
            {
                throw new global::System.ArgumentNullException("person");
            }
            personCertificate.Person = person;
            if ((certificateType == null))
            {
                throw new global::System.ArgumentNullException("certificateType");
            }
            personCertificate.CertificateType = certificateType;
            return personCertificate;
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
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        /// <summary>
        /// There are no comments for Property Person in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Person Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this.OnPersonChanging(value);
                this._Person = value;
                this.OnPersonChanged();
                this.OnPropertyChanged("Person");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Person _Person;
        partial void OnPersonChanging(global::Microsoft.Dynamics.DataEntities.Person value);
        partial void OnPersonChanged();
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
