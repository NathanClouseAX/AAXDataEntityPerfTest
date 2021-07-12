﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 6/6/2021 9:11:38 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for FolioAutoCostHeaderSingle in the schema.
        /// </summary>
    public partial class FolioAutoCostHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FolioAutoCostHeader>
    {
        /// <summary>
        /// Initialize a new FolioAutoCostHeaderSingle object.
        /// </summary>
        public FolioAutoCostHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FolioAutoCostHeaderSingle object.
        /// </summary>
        public FolioAutoCostHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FolioAutoCostHeaderSingle object.
        /// </summary>
        public FolioAutoCostHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FolioAutoCostHeader> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for FolioAutoCostHeader in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// FolioCostAutoNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FolioCostAutoNumber")]
    [global::Microsoft.OData.Client.EntitySet("FolioAutoCostHeaders")]
    public partial class FolioAutoCostHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FolioAutoCostHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="folioCostAutoNumber">Initial value of FolioCostAutoNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FolioAutoCostHeader CreateFolioAutoCostHeader(string dataAreaId, string folioCostAutoNumber)
        {
            FolioAutoCostHeader folioAutoCostHeader = new FolioAutoCostHeader();
            folioAutoCostHeader.dataAreaId = dataAreaId;
            folioAutoCostHeader.FolioCostAutoNumber = folioCostAutoNumber;
            return folioAutoCostHeader;
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
        /// There are no comments for Property FolioCostAutoNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FolioCostAutoNumber
        {
            get
            {
                return this._FolioCostAutoNumber;
            }
            set
            {
                this.OnFolioCostAutoNumberChanging(value);
                this._FolioCostAutoNumber = value;
                this.OnFolioCostAutoNumberChanged();
                this.OnPropertyChanged("FolioCostAutoNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FolioCostAutoNumber;
        partial void OnFolioCostAutoNumberChanging(string value);
        partial void OnFolioCostAutoNumberChanged();
        /// <summary>
        /// There are no comments for Property FromShippingPortId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FromShippingPortId
        {
            get
            {
                return this._FromShippingPortId;
            }
            set
            {
                this.OnFromShippingPortIdChanging(value);
                this._FromShippingPortId = value;
                this.OnFromShippingPortIdChanged();
                this.OnPropertyChanged("FromShippingPortId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FromShippingPortId;
        partial void OnFromShippingPortIdChanging(string value);
        partial void OnFromShippingPortIdChanged();
        /// <summary>
        /// There are no comments for Property DeliveryModeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DeliveryModeCode
        {
            get
            {
                return this._DeliveryModeCode;
            }
            set
            {
                this.OnDeliveryModeCodeChanging(value);
                this._DeliveryModeCode = value;
                this.OnDeliveryModeCodeChanged();
                this.OnPropertyChanged("DeliveryModeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeliveryModeCode;
        partial void OnDeliveryModeCodeChanging(string value);
        partial void OnDeliveryModeCodeChanged();
        /// <summary>
        /// There are no comments for Property ToShippingPortId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ToShippingPortId
        {
            get
            {
                return this._ToShippingPortId;
            }
            set
            {
                this.OnToShippingPortIdChanging(value);
                this._ToShippingPortId = value;
                this.OnToShippingPortIdChanged();
                this.OnPropertyChanged("ToShippingPortId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ToShippingPortId;
        partial void OnToShippingPortIdChanging(string value);
        partial void OnToShippingPortIdChanged();
        /// <summary>
        /// There are no comments for Property CustomsBrokerVendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomsBrokerVendorAccountNumber
        {
            get
            {
                return this._CustomsBrokerVendorAccountNumber;
            }
            set
            {
                this.OnCustomsBrokerVendorAccountNumberChanging(value);
                this._CustomsBrokerVendorAccountNumber = value;
                this.OnCustomsBrokerVendorAccountNumberChanged();
                this.OnPropertyChanged("CustomsBrokerVendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomsBrokerVendorAccountNumber;
        partial void OnCustomsBrokerVendorAccountNumberChanging(string value);
        partial void OnCustomsBrokerVendorAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property VendorLandedCostTypeGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorLandedCostTypeGroupId
        {
            get
            {
                return this._VendorLandedCostTypeGroupId;
            }
            set
            {
                this.OnVendorLandedCostTypeGroupIdChanging(value);
                this._VendorLandedCostTypeGroupId = value;
                this.OnVendorLandedCostTypeGroupIdChanged();
                this.OnPropertyChanged("VendorLandedCostTypeGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorLandedCostTypeGroupId;
        partial void OnVendorLandedCostTypeGroupIdChanging(string value);
        partial void OnVendorLandedCostTypeGroupIdChanged();
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
