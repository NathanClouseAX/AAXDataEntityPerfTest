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
        /// There are no comments for PersonIdentificationNumberSingle in the schema.
        /// </summary>
    public partial class PersonIdentificationNumberSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PersonIdentificationNumber>
    {
        /// <summary>
        /// Initialize a new PersonIdentificationNumberSingle object.
        /// </summary>
        public PersonIdentificationNumberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PersonIdentificationNumberSingle object.
        /// </summary>
        public PersonIdentificationNumberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PersonIdentificationNumberSingle object.
        /// </summary>
        public PersonIdentificationNumberSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PersonIdentificationNumber> query)
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
        /// There are no comments for IdentificationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.IdentificationTypeSingle IdentificationType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._IdentificationType == null))
                {
                    this._IdentificationType = new global::Microsoft.Dynamics.DataEntities.IdentificationTypeSingle(this.Context, GetPath("IdentificationType"));
                }
                return this._IdentificationType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.IdentificationTypeSingle _IdentificationType;
        /// <summary>
        /// There are no comments for IssuingAgency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.IssuingAgencySingle IssuingAgency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._IssuingAgency == null))
                {
                    this._IssuingAgency = new global::Microsoft.Dynamics.DataEntities.IssuingAgencySingle(this.Context, GetPath("IssuingAgency"));
                }
                return this._IssuingAgency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.IssuingAgencySingle _IssuingAgency;
    }
        /// <summary>
        /// There are no comments for PersonIdentificationNumber in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PartyNumber
    /// IdentificationTypeId
    /// IdentificationNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PartyNumber", "IdentificationTypeId", "IdentificationNumber")]
    [global::Microsoft.OData.Client.EntitySet("PersonIdentificationNumbers")]
    public partial class PersonIdentificationNumber : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PersonIdentificationNumber object.
        /// </summary>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        /// <param name="identificationTypeId">Initial value of IdentificationTypeId.</param>
        /// <param name="identificationNumber">Initial value of IdentificationNumber.</param>
        /// <param name="issuedDate">Initial value of IssuedDate.</param>
        /// <param name="expirationDate">Initial value of ExpirationDate.</param>
        /// <param name="person">Initial value of Person.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PersonIdentificationNumber CreatePersonIdentificationNumber(string partyNumber, 
                    string identificationTypeId, 
                    string identificationNumber, 
                    global::System.DateTimeOffset issuedDate, 
                    global::System.DateTimeOffset expirationDate, 
                    global::Microsoft.Dynamics.DataEntities.Person person)
        {
            PersonIdentificationNumber personIdentificationNumber = new PersonIdentificationNumber();
            personIdentificationNumber.PartyNumber = partyNumber;
            personIdentificationNumber.IdentificationTypeId = identificationTypeId;
            personIdentificationNumber.IdentificationNumber = identificationNumber;
            personIdentificationNumber.IssuedDate = issuedDate;
            personIdentificationNumber.ExpirationDate = expirationDate;
            if ((person == null))
            {
                throw new global::System.ArgumentNullException("person");
            }
            personIdentificationNumber.Person = person;
            return personIdentificationNumber;
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
        /// There are no comments for Property IdentificationTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IdentificationTypeId
        {
            get
            {
                return this._IdentificationTypeId;
            }
            set
            {
                this.OnIdentificationTypeIdChanging(value);
                this._IdentificationTypeId = value;
                this.OnIdentificationTypeIdChanged();
                this.OnPropertyChanged("IdentificationTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IdentificationTypeId;
        partial void OnIdentificationTypeIdChanging(string value);
        partial void OnIdentificationTypeIdChanged();
        /// <summary>
        /// There are no comments for Property IdentificationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IdentificationNumber
        {
            get
            {
                return this._IdentificationNumber;
            }
            set
            {
                this.OnIdentificationNumberChanging(value);
                this._IdentificationNumber = value;
                this.OnIdentificationNumberChanged();
                this.OnPropertyChanged("IdentificationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IdentificationNumber;
        partial void OnIdentificationNumberChanging(string value);
        partial void OnIdentificationNumberChanged();
        /// <summary>
        /// There are no comments for Property EntryType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EntryType
        {
            get
            {
                return this._EntryType;
            }
            set
            {
                this.OnEntryTypeChanging(value);
                this._EntryType = value;
                this.OnEntryTypeChanged();
                this.OnPropertyChanged("EntryType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EntryType;
        partial void OnEntryTypeChanging(string value);
        partial void OnEntryTypeChanged();
        /// <summary>
        /// There are no comments for Property IssuingAgencyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IssuingAgencyId
        {
            get
            {
                return this._IssuingAgencyId;
            }
            set
            {
                this.OnIssuingAgencyIdChanging(value);
                this._IssuingAgencyId = value;
                this.OnIssuingAgencyIdChanged();
                this.OnPropertyChanged("IssuingAgencyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IssuingAgencyId;
        partial void OnIssuingAgencyIdChanging(string value);
        partial void OnIssuingAgencyIdChanged();
        /// <summary>
        /// There are no comments for Property IsPrimary in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPrimary
        {
            get
            {
                return this._IsPrimary;
            }
            set
            {
                this.OnIsPrimaryChanging(value);
                this._IsPrimary = value;
                this.OnIsPrimaryChanged();
                this.OnPropertyChanged("IsPrimary");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPrimary;
        partial void OnIsPrimaryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPrimaryChanged();
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
        /// There are no comments for Property IssuedDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset IssuedDate
        {
            get
            {
                return this._IssuedDate;
            }
            set
            {
                this.OnIssuedDateChanging(value);
                this._IssuedDate = value;
                this.OnIssuedDateChanged();
                this.OnPropertyChanged("IssuedDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _IssuedDate;
        partial void OnIssuedDateChanging(global::System.DateTimeOffset value);
        partial void OnIssuedDateChanged();
        /// <summary>
        /// There are no comments for Property ExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ExpirationDate
        {
            get
            {
                return this._ExpirationDate;
            }
            set
            {
                this.OnExpirationDateChanging(value);
                this._ExpirationDate = value;
                this.OnExpirationDateChanged();
                this.OnPropertyChanged("ExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ExpirationDate;
        partial void OnExpirationDateChanging(global::System.DateTimeOffset value);
        partial void OnExpirationDateChanged();
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
        /// There are no comments for Property IdentificationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.IdentificationType IdentificationType
        {
            get
            {
                return this._IdentificationType;
            }
            set
            {
                this.OnIdentificationTypeChanging(value);
                this._IdentificationType = value;
                this.OnIdentificationTypeChanged();
                this.OnPropertyChanged("IdentificationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.IdentificationType _IdentificationType;
        partial void OnIdentificationTypeChanging(global::Microsoft.Dynamics.DataEntities.IdentificationType value);
        partial void OnIdentificationTypeChanged();
        /// <summary>
        /// There are no comments for Property IssuingAgency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.IssuingAgency IssuingAgency
        {
            get
            {
                return this._IssuingAgency;
            }
            set
            {
                this.OnIssuingAgencyChanging(value);
                this._IssuingAgency = value;
                this.OnIssuingAgencyChanged();
                this.OnPropertyChanged("IssuingAgency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.IssuingAgency _IssuingAgency;
        partial void OnIssuingAgencyChanging(global::Microsoft.Dynamics.DataEntities.IssuingAgency value);
        partial void OnIssuingAgencyChanged();
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
