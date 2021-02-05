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
        /// There are no comments for PersonSkillSingle in the schema.
        /// </summary>
    public partial class PersonSkillSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PersonSkill>
    {
        /// <summary>
        /// Initialize a new PersonSkillSingle object.
        /// </summary>
        public PersonSkillSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PersonSkillSingle object.
        /// </summary>
        public PersonSkillSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PersonSkillSingle object.
        /// </summary>
        public PersonSkillSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PersonSkill> query)
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
        /// There are no comments for RatingLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RatingLevelSingle RatingLevel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RatingLevel == null))
                {
                    this._RatingLevel = new global::Microsoft.Dynamics.DataEntities.RatingLevelSingle(this.Context, GetPath("RatingLevel"));
                }
                return this._RatingLevel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RatingLevelSingle _RatingLevel;
        /// <summary>
        /// There are no comments for Skill in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.SkillSingle Skill
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Skill == null))
                {
                    this._Skill = new global::Microsoft.Dynamics.DataEntities.SkillSingle(this.Context, GetPath("Skill"));
                }
                return this._Skill;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SkillSingle _Skill;
    }
        /// <summary>
        /// There are no comments for PersonSkill in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PartyNumber
    /// LevelType
    /// SkillId
    /// LevelDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PartyNumber", "LevelType", "SkillId", "LevelDate")]
    [global::Microsoft.OData.Client.EntitySet("PersonSkills")]
    public partial class PersonSkill : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PersonSkill object.
        /// </summary>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        /// <param name="skillId">Initial value of SkillId.</param>
        /// <param name="levelDate">Initial value of LevelDate.</param>
        /// <param name="yearsOfExperience">Initial value of YearsOfExperience.</param>
        /// <param name="person">Initial value of Person.</param>
        /// <param name="ratingLevel">Initial value of RatingLevel.</param>
        /// <param name="skill">Initial value of Skill.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PersonSkill CreatePersonSkill(string partyNumber, 
                    string skillId, 
                    global::System.DateTimeOffset levelDate, 
                    decimal yearsOfExperience, 
                    global::Microsoft.Dynamics.DataEntities.Person person, 
                    global::Microsoft.Dynamics.DataEntities.RatingLevel ratingLevel, 
                    global::Microsoft.Dynamics.DataEntities.Skill skill)
        {
            PersonSkill personSkill = new PersonSkill();
            personSkill.PartyNumber = partyNumber;
            personSkill.SkillId = skillId;
            personSkill.LevelDate = levelDate;
            personSkill.YearsOfExperience = yearsOfExperience;
            if ((person == null))
            {
                throw new global::System.ArgumentNullException("person");
            }
            personSkill.Person = person;
            if ((ratingLevel == null))
            {
                throw new global::System.ArgumentNullException("ratingLevel");
            }
            personSkill.RatingLevel = ratingLevel;
            if ((skill == null))
            {
                throw new global::System.ArgumentNullException("skill");
            }
            personSkill.Skill = skill;
            return personSkill;
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
        /// There are no comments for Property LevelType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillLevelType> LevelType
        {
            get
            {
                return this._LevelType;
            }
            set
            {
                this.OnLevelTypeChanging(value);
                this._LevelType = value;
                this.OnLevelTypeChanged();
                this.OnPropertyChanged("LevelType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillLevelType> _LevelType;
        partial void OnLevelTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillLevelType> value);
        partial void OnLevelTypeChanged();
        /// <summary>
        /// There are no comments for Property SkillId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SkillId
        {
            get
            {
                return this._SkillId;
            }
            set
            {
                this.OnSkillIdChanging(value);
                this._SkillId = value;
                this.OnSkillIdChanged();
                this.OnPropertyChanged("SkillId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SkillId;
        partial void OnSkillIdChanging(string value);
        partial void OnSkillIdChanged();
        /// <summary>
        /// There are no comments for Property LevelDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset LevelDate
        {
            get
            {
                return this._LevelDate;
            }
            set
            {
                this.OnLevelDateChanging(value);
                this._LevelDate = value;
                this.OnLevelDateChanged();
                this.OnPropertyChanged("LevelDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _LevelDate;
        partial void OnLevelDateChanging(global::System.DateTimeOffset value);
        partial void OnLevelDateChanged();
        /// <summary>
        /// There are no comments for Property RatingLevelExaminer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RatingLevelExaminer
        {
            get
            {
                return this._RatingLevelExaminer;
            }
            set
            {
                this.OnRatingLevelExaminerChanging(value);
                this._RatingLevelExaminer = value;
                this.OnRatingLevelExaminerChanged();
                this.OnPropertyChanged("RatingLevelExaminer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RatingLevelExaminer;
        partial void OnRatingLevelExaminerChanging(string value);
        partial void OnRatingLevelExaminerChanged();
        /// <summary>
        /// There are no comments for Property YearsOfExperience in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal YearsOfExperience
        {
            get
            {
                return this._YearsOfExperience;
            }
            set
            {
                this.OnYearsOfExperienceChanging(value);
                this._YearsOfExperience = value;
                this.OnYearsOfExperienceChanged();
                this.OnPropertyChanged("YearsOfExperience");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _YearsOfExperience;
        partial void OnYearsOfExperienceChanging(decimal value);
        partial void OnYearsOfExperienceChanged();
        /// <summary>
        /// There are no comments for Property LevelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LevelId
        {
            get
            {
                return this._LevelId;
            }
            set
            {
                this.OnLevelIdChanging(value);
                this._LevelId = value;
                this.OnLevelIdChanged();
                this.OnPropertyChanged("LevelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LevelId;
        partial void OnLevelIdChanging(string value);
        partial void OnLevelIdChanged();
        /// <summary>
        /// There are no comments for Property RatingId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RatingId
        {
            get
            {
                return this._RatingId;
            }
            set
            {
                this.OnRatingIdChanging(value);
                this._RatingId = value;
                this.OnRatingIdChanged();
                this.OnPropertyChanged("RatingId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RatingId;
        partial void OnRatingIdChanging(string value);
        partial void OnRatingIdChanged();
        /// <summary>
        /// There are no comments for Property Verified in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Verified
        {
            get
            {
                return this._Verified;
            }
            set
            {
                this.OnVerifiedChanging(value);
                this._Verified = value;
                this.OnVerifiedChanged();
                this.OnPropertyChanged("Verified");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Verified;
        partial void OnVerifiedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnVerifiedChanged();
        /// <summary>
        /// There are no comments for Property Certifier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Certifier
        {
            get
            {
                return this._Certifier;
            }
            set
            {
                this.OnCertifierChanging(value);
                this._Certifier = value;
                this.OnCertifierChanged();
                this.OnPropertyChanged("Certifier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Certifier;
        partial void OnCertifierChanging(string value);
        partial void OnCertifierChanged();
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
        /// There are no comments for Property RatingLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RatingLevel RatingLevel
        {
            get
            {
                return this._RatingLevel;
            }
            set
            {
                this.OnRatingLevelChanging(value);
                this._RatingLevel = value;
                this.OnRatingLevelChanged();
                this.OnPropertyChanged("RatingLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RatingLevel _RatingLevel;
        partial void OnRatingLevelChanging(global::Microsoft.Dynamics.DataEntities.RatingLevel value);
        partial void OnRatingLevelChanged();
        /// <summary>
        /// There are no comments for Property Skill in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Skill Skill
        {
            get
            {
                return this._Skill;
            }
            set
            {
                this.OnSkillChanging(value);
                this._Skill = value;
                this.OnSkillChanged();
                this.OnPropertyChanged("Skill");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Skill _Skill;
        partial void OnSkillChanging(global::Microsoft.Dynamics.DataEntities.Skill value);
        partial void OnSkillChanged();
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
