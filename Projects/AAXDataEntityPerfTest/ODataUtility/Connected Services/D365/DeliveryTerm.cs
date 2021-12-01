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
    /// There are no comments for DeliveryTermSingle in the schema.
    /// </summary>
    public partial class DeliveryTermSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DeliveryTerm>
    {
        /// <summary>
        /// Initialize a new DeliveryTermSingle object.
        /// </summary>
        public DeliveryTermSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DeliveryTermSingle object.
        /// </summary>
        public DeliveryTermSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DeliveryTermSingle object.
        /// </summary>
        public DeliveryTermSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DeliveryTerm> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Prospects in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Prospect> Prospects
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Prospects == null))
                {
                    this._Prospects = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Prospect>(GetPath("Prospects"));
                }
                return this._Prospects;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Prospect> _Prospects;
        /// <summary>
        /// There are no comments for PurchaseAgreementHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PurchaseAgreementConfirmation> PurchaseAgreementHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PurchaseAgreementHeaders == null))
                {
                    this._PurchaseAgreementHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PurchaseAgreementConfirmation>(GetPath("PurchaseAgreementHeaders"));
                }
                return this._PurchaseAgreementHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PurchaseAgreementConfirmation> _PurchaseAgreementHeaders;
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
        /// There are no comments for SalesAgreementConfirmationHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SalesAgreementConfirmation> SalesAgreementConfirmationHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SalesAgreementConfirmationHeaders == null))
                {
                    this._SalesAgreementConfirmationHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.SalesAgreementConfirmation>(GetPath("SalesAgreementConfirmationHeaders"));
                }
                return this._SalesAgreementConfirmationHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SalesAgreementConfirmation> _SalesAgreementConfirmationHeaders;
    }
    /// <summary>
    /// There are no comments for DeliveryTerm in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TermsCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TermsCode")]
    [global::Microsoft.OData.Client.EntitySet("DeliveryTerms")]
    public partial class DeliveryTerm : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DeliveryTerm object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="termsCode">Initial value of TermsCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DeliveryTerm CreateDeliveryTerm(string dataAreaId, string termsCode)
        {
            DeliveryTerm deliveryTerm = new DeliveryTerm();
            deliveryTerm.dataAreaId = dataAreaId;
            deliveryTerm.TermsCode = termsCode;
            return deliveryTerm;
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
        /// There are no comments for Property TermsCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TermsCode is required.")]
        public virtual string TermsCode
        {
            get
            {
                return this._TermsCode;
            }
            set
            {
                this.OnTermsCodeChanging(value);
                this._TermsCode = value;
                this.OnTermsCodeChanged();
                this.OnPropertyChanged("TermsCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TermsCode;
        partial void OnTermsCodeChanging(string value);
        partial void OnTermsCodeChanged();
        /// <summary>
        /// There are no comments for Property InventoryProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string InventoryProfile
        {
            get
            {
                return this._InventoryProfile;
            }
            set
            {
                this.OnInventoryProfileChanging(value);
                this._InventoryProfile = value;
                this.OnInventoryProfileChanged();
                this.OnPropertyChanged("InventoryProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventoryProfile;
        partial void OnInventoryProfileChanging(string value);
        partial void OnInventoryProfileChanged();
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
        /// There are no comments for Property SalesTaxLocationRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LogisticsLocationRoleType> SalesTaxLocationRole
        {
            get
            {
                return this._SalesTaxLocationRole;
            }
            set
            {
                this.OnSalesTaxLocationRoleChanging(value);
                this._SalesTaxLocationRole = value;
                this.OnSalesTaxLocationRoleChanged();
                this.OnPropertyChanged("SalesTaxLocationRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LogisticsLocationRoleType> _SalesTaxLocationRole;
        partial void OnSalesTaxLocationRoleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LogisticsLocationRoleType> value);
        partial void OnSalesTaxLocationRoleChanged();
        /// <summary>
        /// There are no comments for Property IsCashOnDelivery in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCashOnDelivery
        {
            get
            {
                return this._IsCashOnDelivery;
            }
            set
            {
                this.OnIsCashOnDeliveryChanging(value);
                this._IsCashOnDelivery = value;
                this.OnIsCashOnDeliveryChanged();
                this.OnPropertyChanged("IsCashOnDelivery");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCashOnDelivery;
        partial void OnIsCashOnDeliveryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCashOnDeliveryChanged();
        /// <summary>
        /// There are no comments for Property DoRetailSalesOrdersGetTransportationChargesAdded in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DoRetailSalesOrdersGetTransportationChargesAdded
        {
            get
            {
                return this._DoRetailSalesOrdersGetTransportationChargesAdded;
            }
            set
            {
                this.OnDoRetailSalesOrdersGetTransportationChargesAddedChanging(value);
                this._DoRetailSalesOrdersGetTransportationChargesAdded = value;
                this.OnDoRetailSalesOrdersGetTransportationChargesAddedChanged();
                this.OnPropertyChanged("DoRetailSalesOrdersGetTransportationChargesAdded");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DoRetailSalesOrdersGetTransportationChargesAdded;
        partial void OnDoRetailSalesOrdersGetTransportationChargesAddedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDoRetailSalesOrdersGetTransportationChargesAddedChanged();
        /// <summary>
        /// There are no comments for Property WillShipmentConfirmationTransferCharges in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillShipmentConfirmationTransferCharges
        {
            get
            {
                return this._WillShipmentConfirmationTransferCharges;
            }
            set
            {
                this.OnWillShipmentConfirmationTransferChargesChanging(value);
                this._WillShipmentConfirmationTransferCharges = value;
                this.OnWillShipmentConfirmationTransferChargesChanged();
                this.OnPropertyChanged("WillShipmentConfirmationTransferCharges");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillShipmentConfirmationTransferCharges;
        partial void OnWillShipmentConfirmationTransferChargesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillShipmentConfirmationTransferChargesChanged();
        /// <summary>
        /// There are no comments for Property TermsDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TermsDescription
        {
            get
            {
                return this._TermsDescription;
            }
            set
            {
                this.OnTermsDescriptionChanging(value);
                this._TermsDescription = value;
                this.OnTermsDescriptionChanged();
                this.OnPropertyChanged("TermsDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TermsDescription;
        partial void OnTermsDescriptionChanging(string value);
        partial void OnTermsDescriptionChanged();
        /// <summary>
        /// There are no comments for Property FreightChargeTerms in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WMSFreightChargeTerms> FreightChargeTerms
        {
            get
            {
                return this._FreightChargeTerms;
            }
            set
            {
                this.OnFreightChargeTermsChanging(value);
                this._FreightChargeTerms = value;
                this.OnFreightChargeTermsChanged();
                this.OnPropertyChanged("FreightChargeTerms");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WMSFreightChargeTerms> _FreightChargeTerms;
        partial void OnFreightChargeTermsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WMSFreightChargeTerms> value);
        partial void OnFreightChargeTermsChanged();
        /// <summary>
        /// There are no comments for Property ReceiptTransactionStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustomInventTransStatus_RU> ReceiptTransactionStatus
        {
            get
            {
                return this._ReceiptTransactionStatus;
            }
            set
            {
                this.OnReceiptTransactionStatusChanging(value);
                this._ReceiptTransactionStatus = value;
                this.OnReceiptTransactionStatusChanged();
                this.OnPropertyChanged("ReceiptTransactionStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustomInventTransStatus_RU> _ReceiptTransactionStatus;
        partial void OnReceiptTransactionStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustomInventTransStatus_RU> value);
        partial void OnReceiptTransactionStatusChanged();
        /// <summary>
        /// There are no comments for Property Prospects in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Prospect> Prospects
        {
            get
            {
                return this._Prospects;
            }
            set
            {
                this.OnProspectsChanging(value);
                this._Prospects = value;
                this.OnProspectsChanged();
                this.OnPropertyChanged("Prospects");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Prospect> _Prospects = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Prospect>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProspectsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Prospect> value);
        partial void OnProspectsChanged();
        /// <summary>
        /// There are no comments for Property PurchaseAgreementHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseAgreementConfirmation> PurchaseAgreementHeaders
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
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseAgreementConfirmation> _PurchaseAgreementHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseAgreementConfirmation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPurchaseAgreementHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseAgreementConfirmation> value);
        partial void OnPurchaseAgreementHeadersChanged();
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
        /// There are no comments for Property SalesAgreementConfirmationHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreementConfirmation> SalesAgreementConfirmationHeaders
        {
            get
            {
                return this._SalesAgreementConfirmationHeaders;
            }
            set
            {
                this.OnSalesAgreementConfirmationHeadersChanging(value);
                this._SalesAgreementConfirmationHeaders = value;
                this.OnSalesAgreementConfirmationHeadersChanged();
                this.OnPropertyChanged("SalesAgreementConfirmationHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreementConfirmation> _SalesAgreementConfirmationHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreementConfirmation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSalesAgreementConfirmationHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreementConfirmation> value);
        partial void OnSalesAgreementConfirmationHeadersChanged();
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
