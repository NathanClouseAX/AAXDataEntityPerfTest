﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 9/11/2020 3:24:26 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for IntrastatCountryRegionParameterSingle in the schema.
    /// </summary>
    public partial class IntrastatCountryRegionParameterSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<IntrastatCountryRegionParameter>
    {
        /// <summary>
        /// Initialize a new IntrastatCountryRegionParameterSingle object.
        /// </summary>
        public IntrastatCountryRegionParameterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new IntrastatCountryRegionParameterSingle object.
        /// </summary>
        public IntrastatCountryRegionParameterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new IntrastatCountryRegionParameterSingle object.
        /// </summary>
        public IntrastatCountryRegionParameterSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<IntrastatCountryRegionParameter> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for IntrastatCountryRegionParameter in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CountryRegionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CountryRegionId")]
    [global::Microsoft.OData.Client.EntitySet("IntrastatCountryRegionParameters")]
    public partial class IntrastatCountryRegionParameter : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new IntrastatCountryRegionParameter object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="countryRegionId">Initial value of CountryRegionId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static IntrastatCountryRegionParameter CreateIntrastatCountryRegionParameter(string dataAreaId, string countryRegionId)
        {
            IntrastatCountryRegionParameter intrastatCountryRegionParameter = new IntrastatCountryRegionParameter();
            intrastatCountryRegionParameter.dataAreaId = dataAreaId;
            intrastatCountryRegionParameter.CountryRegionId = countryRegionId;
            return intrastatCountryRegionParameter;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string dataAreaId
        {
            get
            {
                return this._dataAreaId;
            }
            set
            {
                this.OndataAreaIdChanging(value);
                this._dataAreaId = value;
                this.OndataAreaIdChanged();
                this.OnPropertyChanged("dataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _dataAreaId;
        partial void OndataAreaIdChanging(string value);
        partial void OndataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property CountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CountryRegionId
        {
            get
            {
                return this._CountryRegionId;
            }
            set
            {
                this.OnCountryRegionIdChanging(value);
                this._CountryRegionId = value;
                this.OnCountryRegionIdChanged();
                this.OnPropertyChanged("CountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionId;
        partial void OnCountryRegionIdChanging(string value);
        partial void OnCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property CountryRegionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CountryRegionType> CountryRegionType
        {
            get
            {
                return this._CountryRegionType;
            }
            set
            {
                this.OnCountryRegionTypeChanging(value);
                this._CountryRegionType = value;
                this.OnCountryRegionTypeChanged();
                this.OnPropertyChanged("CountryRegionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CountryRegionType> _CountryRegionType;
        partial void OnCountryRegionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CountryRegionType> value);
        partial void OnCountryRegionTypeChanged();
        /// <summary>
        /// There are no comments for Property IntrastatCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IntrastatCode
        {
            get
            {
                return this._IntrastatCode;
            }
            set
            {
                this.OnIntrastatCodeChanging(value);
                this._IntrastatCode = value;
                this.OnIntrastatCodeChanged();
                this.OnPropertyChanged("IntrastatCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IntrastatCode;
        partial void OnIntrastatCodeChanging(string value);
        partial void OnIntrastatCodeChanged();
        /// <summary>
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this.OnCurrencyChanging(value);
                this._Currency = value;
                this.OnCurrencyChanged();
                this.OnPropertyChanged("Currency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Currency;
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        /// <summary>
        /// There are no comments for Property BlackListedCountry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> BlackListedCountry
        {
            get
            {
                return this._BlackListedCountry;
            }
            set
            {
                this.OnBlackListedCountryChanging(value);
                this._BlackListedCountry = value;
                this.OnBlackListedCountryChanged();
                this.OnPropertyChanged("BlackListedCountry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _BlackListedCountry;
        partial void OnBlackListedCountryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnBlackListedCountryChanged();
        /// <summary>
        /// There are no comments for Property CountryThreeDigitCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CountryThreeDigitCode
        {
            get
            {
                return this._CountryThreeDigitCode;
            }
            set
            {
                this.OnCountryThreeDigitCodeChanging(value);
                this._CountryThreeDigitCode = value;
                this.OnCountryThreeDigitCodeChanged();
                this.OnPropertyChanged("CountryThreeDigitCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryThreeDigitCode;
        partial void OnCountryThreeDigitCodeChanging(string value);
        partial void OnCountryThreeDigitCodeChanged();
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
