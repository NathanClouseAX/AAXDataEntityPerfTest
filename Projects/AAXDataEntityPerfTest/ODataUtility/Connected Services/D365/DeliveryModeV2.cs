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
    /// There are no comments for DeliveryModeV2Single in the schema.
    /// </summary>
    public partial class DeliveryModeV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<DeliveryModeV2>
    {
        /// <summary>
        /// Initialize a new DeliveryModeV2Single object.
        /// </summary>
        public DeliveryModeV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DeliveryModeV2Single object.
        /// </summary>
        public DeliveryModeV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DeliveryModeV2Single object.
        /// </summary>
        public DeliveryModeV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<DeliveryModeV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DeliveryModeChannelLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DeliveryModeChannelLine> DeliveryModeChannelLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DeliveryModeChannelLine == null))
                {
                    this._DeliveryModeChannelLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.DeliveryModeChannelLine>(GetPath("DeliveryModeChannelLine"));
                }
                return this._DeliveryModeChannelLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DeliveryModeChannelLine> _DeliveryModeChannelLine;
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
    /// There are no comments for DeliveryModeV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ModeCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ModeCode")]
    [global::Microsoft.OData.Client.EntitySet("DeliveryModesV2")]
    public partial class DeliveryModeV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DeliveryModeV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="modeCode">Initial value of ModeCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DeliveryModeV2 CreateDeliveryModeV2(string dataAreaId, string modeCode)
        {
            DeliveryModeV2 deliveryModeV2 = new DeliveryModeV2();
            deliveryModeV2.dataAreaId = dataAreaId;
            deliveryModeV2.ModeCode = modeCode;
            return deliveryModeV2;
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
        /// There are no comments for Property ModeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ModeCode is required.")]
        public virtual string ModeCode
        {
            get
            {
                return this._ModeCode;
            }
            set
            {
                this.OnModeCodeChanging(value);
                this._ModeCode = value;
                this.OnModeCodeChanged();
                this.OnPropertyChanged("ModeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModeCode;
        partial void OnModeCodeChanging(string value);
        partial void OnModeCodeChanged();
        /// <summary>
        /// There are no comments for Property IntrastatTransportModeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string IntrastatTransportModeCode
        {
            get
            {
                return this._IntrastatTransportModeCode;
            }
            set
            {
                this.OnIntrastatTransportModeCodeChanging(value);
                this._IntrastatTransportModeCode = value;
                this.OnIntrastatTransportModeCodeChanged();
                this.OnPropertyChanged("IntrastatTransportModeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IntrastatTransportModeCode;
        partial void OnIntrastatTransportModeCodeChanging(string value);
        partial void OnIntrastatTransportModeCodeChanged();
        /// <summary>
        /// There are no comments for Property ChargeDeliveryGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ChargeDeliveryGroupId
        {
            get
            {
                return this._ChargeDeliveryGroupId;
            }
            set
            {
                this.OnChargeDeliveryGroupIdChanging(value);
                this._ChargeDeliveryGroupId = value;
                this.OnChargeDeliveryGroupIdChanged();
                this.OnPropertyChanged("ChargeDeliveryGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChargeDeliveryGroupId;
        partial void OnChargeDeliveryGroupIdChanging(string value);
        partial void OnChargeDeliveryGroupIdChanged();
        /// <summary>
        /// There are no comments for Property DefaultExpediteCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string DefaultExpediteCode
        {
            get
            {
                return this._DefaultExpediteCode;
            }
            set
            {
                this.OnDefaultExpediteCodeChanging(value);
                this._DefaultExpediteCode = value;
                this.OnDefaultExpediteCodeChanged();
                this.OnPropertyChanged("DefaultExpediteCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultExpediteCode;
        partial void OnDefaultExpediteCodeChanging(string value);
        partial void OnDefaultExpediteCodeChanged();
        /// <summary>
        /// There are no comments for Property ModeDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ModeDescription
        {
            get
            {
                return this._ModeDescription;
            }
            set
            {
                this.OnModeDescriptionChanging(value);
                this._ModeDescription = value;
                this.OnModeDescriptionChanged();
                this.OnPropertyChanged("ModeDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModeDescription;
        partial void OnModeDescriptionChanging(string value);
        partial void OnModeDescriptionChanged();
        /// <summary>
        /// There are no comments for Property DeliveryModeChannelLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DeliveryModeChannelLine> DeliveryModeChannelLine
        {
            get
            {
                return this._DeliveryModeChannelLine;
            }
            set
            {
                this.OnDeliveryModeChannelLineChanging(value);
                this._DeliveryModeChannelLine = value;
                this.OnDeliveryModeChannelLineChanged();
                this.OnPropertyChanged("DeliveryModeChannelLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DeliveryModeChannelLine> _DeliveryModeChannelLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DeliveryModeChannelLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDeliveryModeChannelLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DeliveryModeChannelLine> value);
        partial void OnDeliveryModeChannelLineChanged();
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
