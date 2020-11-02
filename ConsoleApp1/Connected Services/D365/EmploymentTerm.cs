﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:24:13 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for EmploymentTermSingle in the schema.
    /// </summary>
    public partial class EmploymentTermSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EmploymentTerm>
    {
        /// <summary>
        /// Initialize a new EmploymentTermSingle object.
        /// </summary>
        public EmploymentTermSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EmploymentTermSingle object.
        /// </summary>
        public EmploymentTermSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EmploymentTermSingle object.
        /// </summary>
        public EmploymentTermSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EmploymentTerm> query)
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
        /// There are no comments for AgreementTerm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AgreementTermSingle AgreementTerm
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AgreementTerm == null))
                {
                    this._AgreementTerm = new global::Microsoft.Dynamics.DataEntities.AgreementTermSingle(this.Context, GetPath("AgreementTerm"));
                }
                return this._AgreementTerm;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AgreementTermSingle _AgreementTerm;
    }
    /// <summary>
    /// There are no comments for EmploymentTerm in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonnelNumber
    /// LegalEntityId
    /// EmploymentStartDate
    /// EmploymentEndDate
    /// AgreementTermId
    /// ValidFrom
    /// ValidTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelNumber", "LegalEntityId", "EmploymentStartDate", "EmploymentEndDate", "AgreementTermId", "ValidFrom", "ValidTo")]
    [global::Microsoft.OData.Client.EntitySet("EmploymentTerms")]
    public partial class EmploymentTerm : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EmploymentTerm object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="employmentStartDate">Initial value of EmploymentStartDate.</param>
        /// <param name="employmentEndDate">Initial value of EmploymentEndDate.</param>
        /// <param name="agreementTermId">Initial value of AgreementTermId.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="employment">Initial value of Employment.</param>
        /// <param name="agreementTerm">Initial value of AgreementTerm.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EmploymentTerm CreateEmploymentTerm(string personnelNumber, 
                    string legalEntityId, 
                    global::System.DateTimeOffset employmentStartDate, 
                    global::System.DateTimeOffset employmentEndDate, 
                    string agreementTermId, 
                    global::System.DateTimeOffset validFrom, 
                    global::System.DateTimeOffset validTo, 
                    global::Microsoft.Dynamics.DataEntities.Employment employment, 
                    global::Microsoft.Dynamics.DataEntities.AgreementTerm agreementTerm)
        {
            EmploymentTerm employmentTerm = new EmploymentTerm();
            employmentTerm.PersonnelNumber = personnelNumber;
            employmentTerm.LegalEntityId = legalEntityId;
            employmentTerm.EmploymentStartDate = employmentStartDate;
            employmentTerm.EmploymentEndDate = employmentEndDate;
            employmentTerm.AgreementTermId = agreementTermId;
            employmentTerm.ValidFrom = validFrom;
            employmentTerm.ValidTo = validTo;
            if ((employment == null))
            {
                throw new global::System.ArgumentNullException("employment");
            }
            employmentTerm.Employment = employment;
            if ((agreementTerm == null))
            {
                throw new global::System.ArgumentNullException("agreementTerm");
            }
            employmentTerm.AgreementTerm = agreementTerm;
            return employmentTerm;
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
        /// There are no comments for Property AgreementTermId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AgreementTermId
        {
            get
            {
                return this._AgreementTermId;
            }
            set
            {
                this.OnAgreementTermIdChanging(value);
                this._AgreementTermId = value;
                this.OnAgreementTermIdChanged();
                this.OnPropertyChanged("AgreementTermId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AgreementTermId;
        partial void OnAgreementTermIdChanging(string value);
        partial void OnAgreementTermIdChanged();
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
        /// There are no comments for Property AgreementTerm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AgreementTerm AgreementTerm
        {
            get
            {
                return this._AgreementTerm;
            }
            set
            {
                this.OnAgreementTermChanging(value);
                this._AgreementTerm = value;
                this.OnAgreementTermChanged();
                this.OnPropertyChanged("AgreementTerm");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AgreementTerm _AgreementTerm;
        partial void OnAgreementTermChanging(global::Microsoft.Dynamics.DataEntities.AgreementTerm value);
        partial void OnAgreementTermChanged();
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