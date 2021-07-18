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
        /// There are no comments for PersonLaborUnionSingle in the schema.
        /// </summary>
    public partial class PersonLaborUnionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PersonLaborUnion>
    {
        /// <summary>
        /// Initialize a new PersonLaborUnionSingle object.
        /// </summary>
        public PersonLaborUnionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PersonLaborUnionSingle object.
        /// </summary>
        public PersonLaborUnionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PersonLaborUnionSingle object.
        /// </summary>
        public PersonLaborUnionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PersonLaborUnion> query)
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
        /// There are no comments for LaborUnion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnionsSingle LaborUnion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LaborUnion == null))
                {
                    this._LaborUnion = new global::Microsoft.Dynamics.DataEntities.UnionsSingle(this.Context, GetPath("LaborUnion"));
                }
                return this._LaborUnion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnionsSingle _LaborUnion;
    }
        /// <summary>
        /// There are no comments for PersonLaborUnion in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PartyNumber
    /// UnionId
    /// StartDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PartyNumber", "UnionId", "StartDate")]
    [global::Microsoft.OData.Client.EntitySet("PersonLaborUnions")]
    public partial class PersonLaborUnion : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PersonLaborUnion object.
        /// </summary>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        /// <param name="unionId">Initial value of UnionId.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="person">Initial value of Person.</param>
        /// <param name="laborUnion">Initial value of LaborUnion.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PersonLaborUnion CreatePersonLaborUnion(string partyNumber, 
                    string unionId, 
                    global::System.DateTimeOffset startDate, 
                    global::System.DateTimeOffset endDate, 
                    global::Microsoft.Dynamics.DataEntities.Person person, 
                    global::Microsoft.Dynamics.DataEntities.Unions laborUnion)
        {
            PersonLaborUnion personLaborUnion = new PersonLaborUnion();
            personLaborUnion.PartyNumber = partyNumber;
            personLaborUnion.UnionId = unionId;
            personLaborUnion.StartDate = startDate;
            personLaborUnion.EndDate = endDate;
            if ((person == null))
            {
                throw new global::System.ArgumentNullException("person");
            }
            personLaborUnion.Person = person;
            if ((laborUnion == null))
            {
                throw new global::System.ArgumentNullException("laborUnion");
            }
            personLaborUnion.LaborUnion = laborUnion;
            return personLaborUnion;
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
        /// There are no comments for Property UnionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UnionId
        {
            get
            {
                return this._UnionId;
            }
            set
            {
                this.OnUnionIdChanging(value);
                this._UnionId = value;
                this.OnUnionIdChanged();
                this.OnPropertyChanged("UnionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnionId;
        partial void OnUnionIdChanging(string value);
        partial void OnUnionIdChanged();
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
        /// There are no comments for Property LaborUnion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Unions LaborUnion
        {
            get
            {
                return this._LaborUnion;
            }
            set
            {
                this.OnLaborUnionChanging(value);
                this._LaborUnion = value;
                this.OnLaborUnionChanged();
                this.OnPropertyChanged("LaborUnion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Unions _LaborUnion;
        partial void OnLaborUnionChanging(global::Microsoft.Dynamics.DataEntities.Unions value);
        partial void OnLaborUnionChanged();
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
