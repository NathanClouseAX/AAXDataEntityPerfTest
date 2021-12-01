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
    /// There are no comments for CallCenterCatalogCouponSingle in the schema.
    /// </summary>
    public partial class CallCenterCatalogCouponSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CallCenterCatalogCoupon>
    {
        /// <summary>
        /// Initialize a new CallCenterCatalogCouponSingle object.
        /// </summary>
        public CallCenterCatalogCouponSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CallCenterCatalogCouponSingle object.
        /// </summary>
        public CallCenterCatalogCouponSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CallCenterCatalogCouponSingle object.
        /// </summary>
        public CallCenterCatalogCouponSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CallCenterCatalogCoupon> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailCatalog in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle RetailCatalog
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalog == null))
                {
                    this._RetailCatalog = new global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle(this.Context, GetPath("RetailCatalog"));
                }
                return this._RetailCatalog;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle _RetailCatalog;
    }
    /// <summary>
    /// There are no comments for CallCenterCatalogCoupon in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CatalogCode
    /// CouponId
    /// CatalogNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CatalogCode", "CouponId", "CatalogNumber")]
    [global::Microsoft.OData.Client.EntitySet("CallCenterCatalogCoupons")]
    public partial class CallCenterCatalogCoupon : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CallCenterCatalogCoupon object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="couponId">Initial value of CouponId.</param>
        /// <param name="catalogNumber">Initial value of CatalogNumber.</param>
        /// <param name="retailCatalog">Initial value of RetailCatalog.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CallCenterCatalogCoupon CreateCallCenterCatalogCoupon(string dataAreaId, string couponId, string catalogNumber, global::Microsoft.Dynamics.DataEntities.RetailCatalog retailCatalog)
        {
            CallCenterCatalogCoupon callCenterCatalogCoupon = new CallCenterCatalogCoupon();
            callCenterCatalogCoupon.dataAreaId = dataAreaId;
            callCenterCatalogCoupon.CouponId = couponId;
            callCenterCatalogCoupon.CatalogNumber = catalogNumber;
            if ((retailCatalog == null))
            {
                throw new global::System.ArgumentNullException("retailCatalog");
            }
            callCenterCatalogCoupon.RetailCatalog = retailCatalog;
            return callCenterCatalogCoupon;
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
        /// There are no comments for Property CatalogCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRTableAll> CatalogCode
        {
            get
            {
                return this._CatalogCode;
            }
            set
            {
                this.OnCatalogCodeChanging(value);
                this._CatalogCode = value;
                this.OnCatalogCodeChanged();
                this.OnPropertyChanged("CatalogCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRTableAll> _CatalogCode;
        partial void OnCatalogCodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRTableAll> value);
        partial void OnCatalogCodeChanged();
        /// <summary>
        /// There are no comments for Property CouponId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CouponId is required.")]
        public virtual string CouponId
        {
            get
            {
                return this._CouponId;
            }
            set
            {
                this.OnCouponIdChanging(value);
                this._CouponId = value;
                this.OnCouponIdChanged();
                this.OnPropertyChanged("CouponId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CouponId;
        partial void OnCouponIdChanging(string value);
        partial void OnCouponIdChanged();
        /// <summary>
        /// There are no comments for Property CatalogNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CatalogNumber is required.")]
        public virtual string CatalogNumber
        {
            get
            {
                return this._CatalogNumber;
            }
            set
            {
                this.OnCatalogNumberChanging(value);
                this._CatalogNumber = value;
                this.OnCatalogNumberChanged();
                this.OnPropertyChanged("CatalogNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CatalogNumber;
        partial void OnCatalogNumberChanging(string value);
        partial void OnCatalogNumberChanged();
        /// <summary>
        /// There are no comments for Property RetailCatalog in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailCatalog is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalog RetailCatalog
        {
            get
            {
                return this._RetailCatalog;
            }
            set
            {
                this.OnRetailCatalogChanging(value);
                this._RetailCatalog = value;
                this.OnRetailCatalogChanged();
                this.OnPropertyChanged("RetailCatalog");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalog _RetailCatalog;
        partial void OnRetailCatalogChanging(global::Microsoft.Dynamics.DataEntities.RetailCatalog value);
        partial void OnRetailCatalogChanged();
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
