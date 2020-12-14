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
        /// There are no comments for IdentificationTypeSingle in the schema.
        /// </summary>
    public partial class IdentificationTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<IdentificationType>
    {
        /// <summary>
        /// Initialize a new IdentificationTypeSingle object.
        /// </summary>
        public IdentificationTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new IdentificationTypeSingle object.
        /// </summary>
        public IdentificationTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new IdentificationTypeSingle object.
        /// </summary>
        public IdentificationTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<IdentificationType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PersonIdentificationNumbers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber> PersonIdentificationNumbers
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PersonIdentificationNumbers == null))
                {
                    this._PersonIdentificationNumbers = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber>(GetPath("PersonIdentificationNumbers"));
                }
                return this._PersonIdentificationNumbers;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber> _PersonIdentificationNumbers;
        /// <summary>
        /// There are no comments for PersonalIdentificationParameter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> PersonalIdentificationParameter
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PersonalIdentificationParameter == null))
                {
                    this._PersonalIdentificationParameter = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters>(GetPath("PersonalIdentificationParameter"));
                }
                return this._PersonalIdentificationParameter;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> _PersonalIdentificationParameter;
        /// <summary>
        /// There are no comments for SocialSecurityNumberParameter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> SocialSecurityNumberParameter
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SocialSecurityNumberParameter == null))
                {
                    this._SocialSecurityNumberParameter = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters>(GetPath("SocialSecurityNumberParameter"));
                }
                return this._SocialSecurityNumberParameter;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> _SocialSecurityNumberParameter;
        /// <summary>
        /// There are no comments for AlienIdentificationParameter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> AlienIdentificationParameter
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AlienIdentificationParameter == null))
                {
                    this._AlienIdentificationParameter = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters>(GetPath("AlienIdentificationParameter"));
                }
                return this._AlienIdentificationParameter;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> _AlienIdentificationParameter;
        /// <summary>
        /// There are no comments for NationalIdentificationParameter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> NationalIdentificationParameter
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._NationalIdentificationParameter == null))
                {
                    this._NationalIdentificationParameter = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters>(GetPath("NationalIdentificationParameter"));
                }
                return this._NationalIdentificationParameter;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> _NationalIdentificationParameter;
        /// <summary>
        /// There are no comments for i9DocumentTypes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.I9DocumentType> i9DocumentTypes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._i9DocumentTypes == null))
                {
                    this._i9DocumentTypes = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.I9DocumentType>(GetPath("i9DocumentTypes"));
                }
                return this._i9DocumentTypes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.I9DocumentType> _i9DocumentTypes;
    }
        /// <summary>
        /// There are no comments for IdentificationType in the schema.
        /// </summary>
    /// <KeyProperties>
    /// IdentificationTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("IdentificationTypeId")]
    [global::Microsoft.OData.Client.EntitySet("IdentificationTypes")]
    public partial class IdentificationType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new IdentificationType object.
        /// </summary>
        /// <param name="identificationTypeId">Initial value of IdentificationTypeId.</param>
        /// <param name="fixedLength">Initial value of FixedLength.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static IdentificationType CreateIdentificationType(string identificationTypeId, int fixedLength)
        {
            IdentificationType identificationType = new IdentificationType();
            identificationType.IdentificationTypeId = identificationTypeId;
            identificationType.FixedLength = fixedLength;
            return identificationType;
        }
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
        /// There are no comments for Property FixedLength in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int FixedLength
        {
            get
            {
                return this._FixedLength;
            }
            set
            {
                this.OnFixedLengthChanging(value);
                this._FixedLength = value;
                this.OnFixedLengthChanged();
                this.OnPropertyChanged("FixedLength");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _FixedLength;
        partial void OnFixedLengthChanging(int value);
        partial void OnFixedLengthChanged();
        /// <summary>
        /// There are no comments for Property IdentificationNumberFormat in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IdentificationNumberFormat
        {
            get
            {
                return this._IdentificationNumberFormat;
            }
            set
            {
                this.OnIdentificationNumberFormatChanging(value);
                this._IdentificationNumberFormat = value;
                this.OnIdentificationNumberFormatChanged();
                this.OnPropertyChanged("IdentificationNumberFormat");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IdentificationNumberFormat;
        partial void OnIdentificationNumberFormatChanging(string value);
        partial void OnIdentificationNumberFormatChanged();
        /// <summary>
        /// There are no comments for Property CheckDuplicates in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CheckDuplicates
        {
            get
            {
                return this._CheckDuplicates;
            }
            set
            {
                this.OnCheckDuplicatesChanging(value);
                this._CheckDuplicates = value;
                this.OnCheckDuplicatesChanged();
                this.OnPropertyChanged("CheckDuplicates");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CheckDuplicates;
        partial void OnCheckDuplicatesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCheckDuplicatesChanged();
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
        /// There are no comments for Property AllowedValues in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmIdentificationNumberAllowedValues> AllowedValues
        {
            get
            {
                return this._AllowedValues;
            }
            set
            {
                this.OnAllowedValuesChanging(value);
                this._AllowedValues = value;
                this.OnAllowedValuesChanged();
                this.OnPropertyChanged("AllowedValues");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmIdentificationNumberAllowedValues> _AllowedValues;
        partial void OnAllowedValuesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmIdentificationNumberAllowedValues> value);
        partial void OnAllowedValuesChanged();
        /// <summary>
        /// There are no comments for Property PersonIdentificationNumbers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber> PersonIdentificationNumbers
        {
            get
            {
                return this._PersonIdentificationNumbers;
            }
            set
            {
                this.OnPersonIdentificationNumbersChanging(value);
                this._PersonIdentificationNumbers = value;
                this.OnPersonIdentificationNumbersChanged();
                this.OnPropertyChanged("PersonIdentificationNumbers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber> _PersonIdentificationNumbers = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPersonIdentificationNumbersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber> value);
        partial void OnPersonIdentificationNumbersChanged();
        /// <summary>
        /// There are no comments for Property PersonalIdentificationParameter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> PersonalIdentificationParameter
        {
            get
            {
                return this._PersonalIdentificationParameter;
            }
            set
            {
                this.OnPersonalIdentificationParameterChanging(value);
                this._PersonalIdentificationParameter = value;
                this.OnPersonalIdentificationParameterChanged();
                this.OnPropertyChanged("PersonalIdentificationParameter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> _PersonalIdentificationParameter = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPersonalIdentificationParameterChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> value);
        partial void OnPersonalIdentificationParameterChanged();
        /// <summary>
        /// There are no comments for Property SocialSecurityNumberParameter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> SocialSecurityNumberParameter
        {
            get
            {
                return this._SocialSecurityNumberParameter;
            }
            set
            {
                this.OnSocialSecurityNumberParameterChanging(value);
                this._SocialSecurityNumberParameter = value;
                this.OnSocialSecurityNumberParameterChanged();
                this.OnPropertyChanged("SocialSecurityNumberParameter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> _SocialSecurityNumberParameter = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSocialSecurityNumberParameterChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> value);
        partial void OnSocialSecurityNumberParameterChanged();
        /// <summary>
        /// There are no comments for Property AlienIdentificationParameter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> AlienIdentificationParameter
        {
            get
            {
                return this._AlienIdentificationParameter;
            }
            set
            {
                this.OnAlienIdentificationParameterChanging(value);
                this._AlienIdentificationParameter = value;
                this.OnAlienIdentificationParameterChanged();
                this.OnPropertyChanged("AlienIdentificationParameter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> _AlienIdentificationParameter = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAlienIdentificationParameterChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> value);
        partial void OnAlienIdentificationParameterChanged();
        /// <summary>
        /// There are no comments for Property NationalIdentificationParameter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> NationalIdentificationParameter
        {
            get
            {
                return this._NationalIdentificationParameter;
            }
            set
            {
                this.OnNationalIdentificationParameterChanging(value);
                this._NationalIdentificationParameter = value;
                this.OnNationalIdentificationParameterChanged();
                this.OnPropertyChanged("NationalIdentificationParameter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> _NationalIdentificationParameter = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnNationalIdentificationParameterChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.HumanResourcesSharedParameters> value);
        partial void OnNationalIdentificationParameterChanged();
        /// <summary>
        /// There are no comments for Property i9DocumentTypes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.I9DocumentType> i9DocumentTypes
        {
            get
            {
                return this._i9DocumentTypes;
            }
            set
            {
                this.Oni9DocumentTypesChanging(value);
                this._i9DocumentTypes = value;
                this.Oni9DocumentTypesChanged();
                this.OnPropertyChanged("i9DocumentTypes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.I9DocumentType> _i9DocumentTypes = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.I9DocumentType>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void Oni9DocumentTypesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.I9DocumentType> value);
        partial void Oni9DocumentTypesChanged();
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
