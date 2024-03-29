﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/28/2021 8:55:09 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for RetailTransactionAuditableAddressLineSingle in the schema.
    /// </summary>
    public partial class RetailTransactionAuditableAddressLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTransactionAuditableAddressLine>
    {
        /// <summary>
        /// Initialize a new RetailTransactionAuditableAddressLineSingle object.
        /// </summary>
        public RetailTransactionAuditableAddressLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTransactionAuditableAddressLineSingle object.
        /// </summary>
        public RetailTransactionAuditableAddressLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTransactionAuditableAddressLineSingle object.
        /// </summary>
        public RetailTransactionAuditableAddressLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTransactionAuditableAddressLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailTransactionAuditableSalesLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLineSingle RetailTransactionAuditableSalesLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTransactionAuditableSalesLine == null))
                {
                    this._RetailTransactionAuditableSalesLine = new global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLineSingle(this.Context, GetPath("RetailTransactionAuditableSalesLine"));
                }
                return this._RetailTransactionAuditableSalesLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLineSingle _RetailTransactionAuditableSalesLine;
        /// <summary>
        /// There are no comments for RetailTransactionAuditable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSingle RetailTransactionAuditable
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTransactionAuditable == null))
                {
                    this._RetailTransactionAuditable = new global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSingle(this.Context, GetPath("RetailTransactionAuditable"));
                }
                return this._RetailTransactionAuditable;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSingle _RetailTransactionAuditable;
    }
    /// <summary>
    /// There are no comments for RetailTransactionAuditableAddressLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// OperatingUnitNumber
    /// StoreNumber
    /// RegisterNumber
    /// TransactionId
    /// SalesLineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "OperatingUnitNumber", "StoreNumber", "RegisterNumber", "TransactionId", "SalesLineNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailTransactionAuditableAddressLines")]
    public partial class RetailTransactionAuditableAddressLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTransactionAuditableAddressLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="operatingUnitNumber">Initial value of OperatingUnitNumber.</param>
        /// <param name="storeNumber">Initial value of StoreNumber.</param>
        /// <param name="registerNumber">Initial value of RegisterNumber.</param>
        /// <param name="transactionId">Initial value of TransactionId.</param>
        /// <param name="salesLineNumber">Initial value of SalesLineNumber.</param>
        /// <param name="retailTransactionAuditableSalesLine">Initial value of RetailTransactionAuditableSalesLine.</param>
        /// <param name="retailTransactionAuditable">Initial value of RetailTransactionAuditable.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTransactionAuditableAddressLine CreateRetailTransactionAuditableAddressLine(string dataAreaId, 
                    string operatingUnitNumber, 
                    string storeNumber, 
                    string registerNumber, 
                    string transactionId, 
                    decimal salesLineNumber, 
                    global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLine retailTransactionAuditableSalesLine, 
                    global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditable retailTransactionAuditable)
        {
            RetailTransactionAuditableAddressLine retailTransactionAuditableAddressLine = new RetailTransactionAuditableAddressLine();
            retailTransactionAuditableAddressLine.dataAreaId = dataAreaId;
            retailTransactionAuditableAddressLine.OperatingUnitNumber = operatingUnitNumber;
            retailTransactionAuditableAddressLine.StoreNumber = storeNumber;
            retailTransactionAuditableAddressLine.RegisterNumber = registerNumber;
            retailTransactionAuditableAddressLine.TransactionId = transactionId;
            retailTransactionAuditableAddressLine.SalesLineNumber = salesLineNumber;
            if ((retailTransactionAuditableSalesLine == null))
            {
                throw new global::System.ArgumentNullException("retailTransactionAuditableSalesLine");
            }
            retailTransactionAuditableAddressLine.RetailTransactionAuditableSalesLine = retailTransactionAuditableSalesLine;
            if ((retailTransactionAuditable == null))
            {
                throw new global::System.ArgumentNullException("retailTransactionAuditable");
            }
            retailTransactionAuditableAddressLine.RetailTransactionAuditable = retailTransactionAuditable;
            return retailTransactionAuditableAddressLine;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "dataAreaId is required.")]
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
        /// There are no comments for Property OperatingUnitNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OperatingUnitNumber is required.")]
        public virtual string OperatingUnitNumber
        {
            get
            {
                return this._OperatingUnitNumber;
            }
            set
            {
                this.OnOperatingUnitNumberChanging(value);
                this._OperatingUnitNumber = value;
                this.OnOperatingUnitNumberChanged();
                this.OnPropertyChanged("OperatingUnitNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperatingUnitNumber;
        partial void OnOperatingUnitNumberChanging(string value);
        partial void OnOperatingUnitNumberChanged();
        /// <summary>
        /// There are no comments for Property StoreNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StoreNumber is required.")]
        public virtual string StoreNumber
        {
            get
            {
                return this._StoreNumber;
            }
            set
            {
                this.OnStoreNumberChanging(value);
                this._StoreNumber = value;
                this.OnStoreNumberChanged();
                this.OnPropertyChanged("StoreNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreNumber;
        partial void OnStoreNumberChanging(string value);
        partial void OnStoreNumberChanged();
        /// <summary>
        /// There are no comments for Property RegisterNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RegisterNumber is required.")]
        public virtual string RegisterNumber
        {
            get
            {
                return this._RegisterNumber;
            }
            set
            {
                this.OnRegisterNumberChanging(value);
                this._RegisterNumber = value;
                this.OnRegisterNumberChanged();
                this.OnPropertyChanged("RegisterNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegisterNumber;
        partial void OnRegisterNumberChanging(string value);
        partial void OnRegisterNumberChanged();
        /// <summary>
        /// There are no comments for Property TransactionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransactionId is required.")]
        public virtual string TransactionId
        {
            get
            {
                return this._TransactionId;
            }
            set
            {
                this.OnTransactionIdChanging(value);
                this._TransactionId = value;
                this.OnTransactionIdChanged();
                this.OnPropertyChanged("TransactionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionId;
        partial void OnTransactionIdChanging(string value);
        partial void OnTransactionIdChanged();
        /// <summary>
        /// There are no comments for Property SalesLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SalesLineNumber is required.")]
        public virtual decimal SalesLineNumber
        {
            get
            {
                return this._SalesLineNumber;
            }
            set
            {
                this.OnSalesLineNumberChanging(value);
                this._SalesLineNumber = value;
                this.OnSalesLineNumberChanged();
                this.OnPropertyChanged("SalesLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SalesLineNumber;
        partial void OnSalesLineNumberChanging(decimal value);
        partial void OnSalesLineNumberChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property HeaderAsynchronousOrderStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionOrderStatusType> HeaderAsynchronousOrderStatus
        {
            get
            {
                return this._HeaderAsynchronousOrderStatus;
            }
            set
            {
                this.OnHeaderAsynchronousOrderStatusChanging(value);
                this._HeaderAsynchronousOrderStatus = value;
                this.OnHeaderAsynchronousOrderStatusChanged();
                this.OnPropertyChanged("HeaderAsynchronousOrderStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionOrderStatusType> _HeaderAsynchronousOrderStatus;
        partial void OnHeaderAsynchronousOrderStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionOrderStatusType> value);
        partial void OnHeaderAsynchronousOrderStatusChanged();
        /// <summary>
        /// There are no comments for Property County in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string County
        {
            get
            {
                return this._County;
            }
            set
            {
                this.OnCountyChanging(value);
                this._County = value;
                this.OnCountyChanged();
                this.OnPropertyChanged("County");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _County;
        partial void OnCountyChanging(string value);
        partial void OnCountyChanged();
        /// <summary>
        /// There are no comments for Property District in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string District
        {
            get
            {
                return this._District;
            }
            set
            {
                this.OnDistrictChanging(value);
                this._District = value;
                this.OnDistrictChanged();
                this.OnPropertyChanged("District");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _District;
        partial void OnDistrictChanging(string value);
        partial void OnDistrictChanged();
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
        /// There are no comments for Property City in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string City
        {
            get
            {
                return this._City;
            }
            set
            {
                this.OnCityChanging(value);
                this._City = value;
                this.OnCityChanged();
                this.OnPropertyChanged("City");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _City;
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
        /// <summary>
        /// There are no comments for Property Email in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this.OnEmailChanging(value);
                this._Email = value;
                this.OnEmailChanged();
                this.OnPropertyChanged("Email");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Email;
        partial void OnEmailChanging(string value);
        partial void OnEmailChanged();
        /// <summary>
        /// There are no comments for Property StreetNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string StreetNumber
        {
            get
            {
                return this._StreetNumber;
            }
            set
            {
                this.OnStreetNumberChanging(value);
                this._StreetNumber = value;
                this.OnStreetNumberChanged();
                this.OnPropertyChanged("StreetNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StreetNumber;
        partial void OnStreetNumberChanging(string value);
        partial void OnStreetNumberChanged();
        /// <summary>
        /// There are no comments for Property SalesName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string SalesName
        {
            get
            {
                return this._SalesName;
            }
            set
            {
                this.OnSalesNameChanging(value);
                this._SalesName = value;
                this.OnSalesNameChanged();
                this.OnPropertyChanged("SalesName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesName;
        partial void OnSalesNameChanging(string value);
        partial void OnSalesNameChanged();
        /// <summary>
        /// There are no comments for Property DeliveryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string DeliveryName
        {
            get
            {
                return this._DeliveryName;
            }
            set
            {
                this.OnDeliveryNameChanging(value);
                this._DeliveryName = value;
                this.OnDeliveryNameChanged();
                this.OnPropertyChanged("DeliveryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeliveryName;
        partial void OnDeliveryNameChanging(string value);
        partial void OnDeliveryNameChanged();
        /// <summary>
        /// There are no comments for Property Attention in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string Attention
        {
            get
            {
                return this._Attention;
            }
            set
            {
                this.OnAttentionChanging(value);
                this._Attention = value;
                this.OnAttentionChanged();
                this.OnPropertyChanged("Attention");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Attention;
        partial void OnAttentionChanging(string value);
        partial void OnAttentionChanged();
        /// <summary>
        /// There are no comments for Property HeaderValidationStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionValidationStatus> HeaderValidationStatus
        {
            get
            {
                return this._HeaderValidationStatus;
            }
            set
            {
                this.OnHeaderValidationStatusChanging(value);
                this._HeaderValidationStatus = value;
                this.OnHeaderValidationStatusChanged();
                this.OnPropertyChanged("HeaderValidationStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionValidationStatus> _HeaderValidationStatus;
        partial void OnHeaderValidationStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionValidationStatus> value);
        partial void OnHeaderValidationStatusChanged();
        /// <summary>
        /// There are no comments for Property ZipCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ZipCode
        {
            get
            {
                return this._ZipCode;
            }
            set
            {
                this.OnZipCodeChanging(value);
                this._ZipCode = value;
                this.OnZipCodeChanged();
                this.OnPropertyChanged("ZipCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ZipCode;
        partial void OnZipCodeChanging(string value);
        partial void OnZipCodeChanged();
        /// <summary>
        /// There are no comments for Property Telephone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string Telephone
        {
            get
            {
                return this._Telephone;
            }
            set
            {
                this.OnTelephoneChanging(value);
                this._Telephone = value;
                this.OnTelephoneChanged();
                this.OnPropertyChanged("Telephone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Telephone;
        partial void OnTelephoneChanging(string value);
        partial void OnTelephoneChanged();
        /// <summary>
        /// There are no comments for Property Street in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string Street
        {
            get
            {
                return this._Street;
            }
            set
            {
                this.OnStreetChanging(value);
                this._Street = value;
                this.OnStreetChanged();
                this.OnPropertyChanged("Street");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Street;
        partial void OnStreetChanging(string value);
        partial void OnStreetChanged();
        /// <summary>
        /// There are no comments for Property HeaderTransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionType> HeaderTransactionType
        {
            get
            {
                return this._HeaderTransactionType;
            }
            set
            {
                this.OnHeaderTransactionTypeChanging(value);
                this._HeaderTransactionType = value;
                this.OnHeaderTransactionTypeChanged();
                this.OnPropertyChanged("HeaderTransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionType> _HeaderTransactionType;
        partial void OnHeaderTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionType> value);
        partial void OnHeaderTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property RetailTransactionAuditableSalesLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailTransactionAuditableSalesLine is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLine RetailTransactionAuditableSalesLine
        {
            get
            {
                return this._RetailTransactionAuditableSalesLine;
            }
            set
            {
                this.OnRetailTransactionAuditableSalesLineChanging(value);
                this._RetailTransactionAuditableSalesLine = value;
                this.OnRetailTransactionAuditableSalesLineChanged();
                this.OnPropertyChanged("RetailTransactionAuditableSalesLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLine _RetailTransactionAuditableSalesLine;
        partial void OnRetailTransactionAuditableSalesLineChanging(global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditableSalesLine value);
        partial void OnRetailTransactionAuditableSalesLineChanged();
        /// <summary>
        /// There are no comments for Property RetailTransactionAuditable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailTransactionAuditable is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditable RetailTransactionAuditable
        {
            get
            {
                return this._RetailTransactionAuditable;
            }
            set
            {
                this.OnRetailTransactionAuditableChanging(value);
                this._RetailTransactionAuditable = value;
                this.OnRetailTransactionAuditableChanged();
                this.OnPropertyChanged("RetailTransactionAuditable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditable _RetailTransactionAuditable;
        partial void OnRetailTransactionAuditableChanging(global::Microsoft.Dynamics.DataEntities.RetailTransactionAuditable value);
        partial void OnRetailTransactionAuditableChanged();
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
