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
    /// There are no comments for ShippingCarrierSingle in the schema.
    /// </summary>
    public partial class ShippingCarrierSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingCarrier>
    {
        /// <summary>
        /// Initialize a new ShippingCarrierSingle object.
        /// </summary>
        public ShippingCarrierSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ShippingCarrierSingle object.
        /// </summary>
        public ShippingCarrierSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ShippingCarrierSingle object.
        /// </summary>
        public ShippingCarrierSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingCarrier> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FreightBillDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FreightBillDetail> FreightBillDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FreightBillDetails == null))
                {
                    this._FreightBillDetails = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FreightBillDetail>(GetPath("FreightBillDetails"));
                }
                return this._FreightBillDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FreightBillDetail> _FreightBillDetails;
        /// <summary>
        /// There are no comments for SalesAgreementHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SalesAgreement> SalesAgreementHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SalesAgreementHeaders == null))
                {
                    this._SalesAgreementHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.SalesAgreement>(GetPath("SalesAgreementHeaders"));
                }
                return this._SalesAgreementHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SalesAgreement> _SalesAgreementHeaders;
        /// <summary>
        /// There are no comments for PurchaseAgreementHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PurchaseAgreement> PurchaseAgreementHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PurchaseAgreementHeaders == null))
                {
                    this._PurchaseAgreementHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PurchaseAgreement>(GetPath("PurchaseAgreementHeaders"));
                }
                return this._PurchaseAgreementHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PurchaseAgreement> _PurchaseAgreementHeaders;
    }
    /// <summary>
    /// There are no comments for ShippingCarrier in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CarrierId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CarrierId")]
    [global::Microsoft.OData.Client.EntitySet("ShippingCarriers")]
    public partial class ShippingCarrier : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ShippingCarrier object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="carrierId">Initial value of CarrierId.</param>
        /// <param name="averageContainerWeight">Initial value of AverageContainerWeight.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ShippingCarrier CreateShippingCarrier(string dataAreaId, string carrierId, decimal averageContainerWeight)
        {
            ShippingCarrier shippingCarrier = new ShippingCarrier();
            shippingCarrier.dataAreaId = dataAreaId;
            shippingCarrier.CarrierId = carrierId;
            shippingCarrier.AverageContainerWeight = averageContainerWeight;
            return shippingCarrier;
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
        /// There are no comments for Property CarrierId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CarrierId is required.")]
        public virtual string CarrierId
        {
            get
            {
                return this._CarrierId;
            }
            set
            {
                this.OnCarrierIdChanging(value);
                this._CarrierId = value;
                this.OnCarrierIdChanged();
                this.OnPropertyChanged("CarrierId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CarrierId;
        partial void OnCarrierIdChanging(string value);
        partial void OnCarrierIdChanged();
        /// <summary>
        /// There are no comments for Property TransportationModeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TransportationModeId
        {
            get
            {
                return this._TransportationModeId;
            }
            set
            {
                this.OnTransportationModeIdChanging(value);
                this._TransportationModeId = value;
                this.OnTransportationModeIdChanged();
                this.OnPropertyChanged("TransportationModeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransportationModeId;
        partial void OnTransportationModeIdChanging(string value);
        partial void OnTransportationModeIdChanged();
        /// <summary>
        /// There are no comments for Property CarrierName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string CarrierName
        {
            get
            {
                return this._CarrierName;
            }
            set
            {
                this.OnCarrierNameChanging(value);
                this._CarrierName = value;
                this.OnCarrierNameChanged();
                this.OnPropertyChanged("CarrierName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CarrierName;
        partial void OnCarrierNameChanging(string value);
        partial void OnCarrierNameChanged();
        /// <summary>
        /// There are no comments for Property ShippingCarrierVendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ShippingCarrierVendorAccountNumber
        {
            get
            {
                return this._ShippingCarrierVendorAccountNumber;
            }
            set
            {
                this.OnShippingCarrierVendorAccountNumberChanging(value);
                this._ShippingCarrierVendorAccountNumber = value;
                this.OnShippingCarrierVendorAccountNumberChanged();
                this.OnPropertyChanged("ShippingCarrierVendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShippingCarrierVendorAccountNumber;
        partial void OnShippingCarrierVendorAccountNumberChanging(string value);
        partial void OnShippingCarrierVendorAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property IsShippingCarrierRatingActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsShippingCarrierRatingActive
        {
            get
            {
                return this._IsShippingCarrierRatingActive;
            }
            set
            {
                this.OnIsShippingCarrierRatingActiveChanging(value);
                this._IsShippingCarrierRatingActive = value;
                this.OnIsShippingCarrierRatingActiveChanged();
                this.OnPropertyChanged("IsShippingCarrierRatingActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsShippingCarrierRatingActive;
        partial void OnIsShippingCarrierRatingActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsShippingCarrierRatingActiveChanged();
        /// <summary>
        /// There are no comments for Property TransportationTenderType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TMSLoadTender> TransportationTenderType
        {
            get
            {
                return this._TransportationTenderType;
            }
            set
            {
                this.OnTransportationTenderTypeChanging(value);
                this._TransportationTenderType = value;
                this.OnTransportationTenderTypeChanged();
                this.OnPropertyChanged("TransportationTenderType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TMSLoadTender> _TransportationTenderType;
        partial void OnTransportationTenderTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TMSLoadTender> value);
        partial void OnTransportationTenderTypeChanged();
        /// <summary>
        /// There are no comments for Property AverageContainerWeight in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AverageContainerWeight is required.")]
        public virtual decimal AverageContainerWeight
        {
            get
            {
                return this._AverageContainerWeight;
            }
            set
            {
                this.OnAverageContainerWeightChanging(value);
                this._AverageContainerWeight = value;
                this.OnAverageContainerWeightChanged();
                this.OnPropertyChanged("AverageContainerWeight");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AverageContainerWeight;
        partial void OnAverageContainerWeightChanging(decimal value);
        partial void OnAverageContainerWeightChanged();
        /// <summary>
        /// There are no comments for Property ShippingCarrierWebsiteURL in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ShippingCarrierWebsiteURL
        {
            get
            {
                return this._ShippingCarrierWebsiteURL;
            }
            set
            {
                this.OnShippingCarrierWebsiteURLChanging(value);
                this._ShippingCarrierWebsiteURL = value;
                this.OnShippingCarrierWebsiteURLChanged();
                this.OnPropertyChanged("ShippingCarrierWebsiteURL");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShippingCarrierWebsiteURL;
        partial void OnShippingCarrierWebsiteURLChanging(string value);
        partial void OnShippingCarrierWebsiteURLChanged();
        /// <summary>
        /// There are no comments for Property ProNumberSequenceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ProNumberSequenceId
        {
            get
            {
                return this._ProNumberSequenceId;
            }
            set
            {
                this.OnProNumberSequenceIdChanging(value);
                this._ProNumberSequenceId = value;
                this.OnProNumberSequenceIdChanged();
                this.OnPropertyChanged("ProNumberSequenceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProNumberSequenceId;
        partial void OnProNumberSequenceIdChanging(string value);
        partial void OnProNumberSequenceIdChanged();
        /// <summary>
        /// There are no comments for Property ShippingCarrierTrackingURL in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ShippingCarrierTrackingURL
        {
            get
            {
                return this._ShippingCarrierTrackingURL;
            }
            set
            {
                this.OnShippingCarrierTrackingURLChanging(value);
                this._ShippingCarrierTrackingURL = value;
                this.OnShippingCarrierTrackingURLChanged();
                this.OnPropertyChanged("ShippingCarrierTrackingURL");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShippingCarrierTrackingURL;
        partial void OnShippingCarrierTrackingURLChanging(string value);
        partial void OnShippingCarrierTrackingURLChanged();
        /// <summary>
        /// There are no comments for Property StandardCarrierAlphaCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string StandardCarrierAlphaCode
        {
            get
            {
                return this._StandardCarrierAlphaCode;
            }
            set
            {
                this.OnStandardCarrierAlphaCodeChanging(value);
                this._StandardCarrierAlphaCode = value;
                this.OnStandardCarrierAlphaCodeChanged();
                this.OnPropertyChanged("StandardCarrierAlphaCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StandardCarrierAlphaCode;
        partial void OnStandardCarrierAlphaCodeChanging(string value);
        partial void OnStandardCarrierAlphaCodeChanged();
        /// <summary>
        /// There are no comments for Property IsBroker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsBroker
        {
            get
            {
                return this._IsBroker;
            }
            set
            {
                this.OnIsBrokerChanging(value);
                this._IsBroker = value;
                this.OnIsBrokerChanged();
                this.OnPropertyChanged("IsBroker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsBroker;
        partial void OnIsBrokerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsBrokerChanged();
        /// <summary>
        /// There are no comments for Property IsShippingCarrierActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsShippingCarrierActive
        {
            get
            {
                return this._IsShippingCarrierActive;
            }
            set
            {
                this.OnIsShippingCarrierActiveChanging(value);
                this._IsShippingCarrierActive = value;
                this.OnIsShippingCarrierActiveChanged();
                this.OnPropertyChanged("IsShippingCarrierActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsShippingCarrierActive;
        partial void OnIsShippingCarrierActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsShippingCarrierActiveChanged();
        /// <summary>
        /// There are no comments for Property FreightBillDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreightBillDetail> FreightBillDetails
        {
            get
            {
                return this._FreightBillDetails;
            }
            set
            {
                this.OnFreightBillDetailsChanging(value);
                this._FreightBillDetails = value;
                this.OnFreightBillDetailsChanged();
                this.OnPropertyChanged("FreightBillDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreightBillDetail> _FreightBillDetails = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreightBillDetail>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFreightBillDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreightBillDetail> value);
        partial void OnFreightBillDetailsChanged();
        /// <summary>
        /// There are no comments for Property SalesAgreementHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreement> SalesAgreementHeaders
        {
            get
            {
                return this._SalesAgreementHeaders;
            }
            set
            {
                this.OnSalesAgreementHeadersChanging(value);
                this._SalesAgreementHeaders = value;
                this.OnSalesAgreementHeadersChanged();
                this.OnPropertyChanged("SalesAgreementHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreement> _SalesAgreementHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreement>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSalesAgreementHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreement> value);
        partial void OnSalesAgreementHeadersChanged();
        /// <summary>
        /// There are no comments for Property PurchaseAgreementHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseAgreement> PurchaseAgreementHeaders
        {
            get
            {
                return this._PurchaseAgreementHeaders;
            }
            set
            {
                this.OnPurchaseAgreementHeadersChanging(value);
                this._PurchaseAgreementHeaders = value;
                this.OnPurchaseAgreementHeadersChanged();
                this.OnPropertyChanged("PurchaseAgreementHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseAgreement> _PurchaseAgreementHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseAgreement>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPurchaseAgreementHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseAgreement> value);
        partial void OnPurchaseAgreementHeadersChanged();
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
