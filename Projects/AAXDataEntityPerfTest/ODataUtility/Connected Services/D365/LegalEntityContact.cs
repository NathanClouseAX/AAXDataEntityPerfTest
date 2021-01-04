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
        /// There are no comments for LegalEntityContactSingle in the schema.
        /// </summary>
    public partial class LegalEntityContactSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LegalEntityContact>
    {
        /// <summary>
        /// Initialize a new LegalEntityContactSingle object.
        /// </summary>
        public LegalEntityContactSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LegalEntityContactSingle object.
        /// </summary>
        public LegalEntityContactSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LegalEntityContactSingle object.
        /// </summary>
        public LegalEntityContactSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LegalEntityContact> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntitySingle LegalEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LegalEntity == null))
                {
                    this._LegalEntity = new global::Microsoft.Dynamics.DataEntities.LegalEntitySingle(this.Context, GetPath("LegalEntity"));
                }
                return this._LegalEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntitySingle _LegalEntity;
    }
        /// <summary>
        /// There are no comments for LegalEntityContact in the schema.
        /// </summary>
    /// <KeyProperties>
    /// Type
    /// Description
    /// Locator
    /// DataArea
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Type", "Description", "Locator", "DataArea")]
    [global::Microsoft.OData.Client.EntitySet("LegalEntityContacts")]
    public partial class LegalEntityContact : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LegalEntityContact object.
        /// </summary>
        /// <param name="description">Initial value of Description.</param>
        /// <param name="locator">Initial value of Locator.</param>
        /// <param name="dataArea">Initial value of DataArea.</param>
        /// <param name="legalEntity">Initial value of LegalEntity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LegalEntityContact CreateLegalEntityContact(string description, string locator, string dataArea, global::Microsoft.Dynamics.DataEntities.LegalEntity legalEntity)
        {
            LegalEntityContact legalEntityContact = new LegalEntityContact();
            legalEntityContact.Description = description;
            legalEntityContact.Locator = locator;
            legalEntityContact.DataArea = dataArea;
            if ((legalEntity == null))
            {
                throw new global::System.ArgumentNullException("legalEntity");
            }
            legalEntityContact.LegalEntity = legalEntity;
            return legalEntityContact;
        }
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LogisticsElectronicAddressMethodType> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LogisticsElectronicAddressMethodType> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LogisticsElectronicAddressMethodType> value);
        partial void OnTypeChanged();
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
        /// There are no comments for Property Locator in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Locator
        {
            get
            {
                return this._Locator;
            }
            set
            {
                this.OnLocatorChanging(value);
                this._Locator = value;
                this.OnLocatorChanged();
                this.OnPropertyChanged("Locator");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Locator;
        partial void OnLocatorChanging(string value);
        partial void OnLocatorChanged();
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
        /// There are no comments for Property IsMobilePhone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsMobilePhone
        {
            get
            {
                return this._IsMobilePhone;
            }
            set
            {
                this.OnIsMobilePhoneChanging(value);
                this._IsMobilePhone = value;
                this.OnIsMobilePhoneChanged();
                this.OnPropertyChanged("IsMobilePhone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsMobilePhone;
        partial void OnIsMobilePhoneChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsMobilePhoneChanged();
        /// <summary>
        /// There are no comments for Property CountryRegionCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CountryRegionCode
        {
            get
            {
                return this._CountryRegionCode;
            }
            set
            {
                this.OnCountryRegionCodeChanging(value);
                this._CountryRegionCode = value;
                this.OnCountryRegionCodeChanged();
                this.OnPropertyChanged("CountryRegionCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionCode;
        partial void OnCountryRegionCodeChanging(string value);
        partial void OnCountryRegionCodeChanged();
        /// <summary>
        /// There are no comments for Property Purpose in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Purpose
        {
            get
            {
                return this._Purpose;
            }
            set
            {
                this.OnPurposeChanging(value);
                this._Purpose = value;
                this.OnPurposeChanged();
                this.OnPropertyChanged("Purpose");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Purpose;
        partial void OnPurposeChanging(string value);
        partial void OnPurposeChanged();
        /// <summary>
        /// There are no comments for Property LocatorExtension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LocatorExtension
        {
            get
            {
                return this._LocatorExtension;
            }
            set
            {
                this.OnLocatorExtensionChanging(value);
                this._LocatorExtension = value;
                this.OnLocatorExtensionChanged();
                this.OnPropertyChanged("LocatorExtension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LocatorExtension;
        partial void OnLocatorExtensionChanging(string value);
        partial void OnLocatorExtensionChanged();
        /// <summary>
        /// There are no comments for Property LocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LocationId
        {
            get
            {
                return this._LocationId;
            }
            set
            {
                this.OnLocationIdChanging(value);
                this._LocationId = value;
                this.OnLocationIdChanged();
                this.OnPropertyChanged("LocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LocationId;
        partial void OnLocationIdChanging(string value);
        partial void OnLocationIdChanged();
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
        /// There are no comments for Property IsPrivate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPrivate
        {
            get
            {
                return this._IsPrivate;
            }
            set
            {
                this.OnIsPrivateChanging(value);
                this._IsPrivate = value;
                this.OnIsPrivateChanged();
                this.OnPropertyChanged("IsPrivate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPrivate;
        partial void OnIsPrivateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPrivateChanged();
        /// <summary>
        /// There are no comments for Property LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntity LegalEntity
        {
            get
            {
                return this._LegalEntity;
            }
            set
            {
                this.OnLegalEntityChanging(value);
                this._LegalEntity = value;
                this.OnLegalEntityChanged();
                this.OnPropertyChanged("LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntity _LegalEntity;
        partial void OnLegalEntityChanging(global::Microsoft.Dynamics.DataEntities.LegalEntity value);
        partial void OnLegalEntityChanged();
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
