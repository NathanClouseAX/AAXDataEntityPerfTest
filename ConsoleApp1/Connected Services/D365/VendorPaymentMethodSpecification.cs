﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:24:13 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for VendorPaymentMethodSpecificationSingle in the schema.
    /// </summary>
    public partial class VendorPaymentMethodSpecificationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorPaymentMethodSpecification>
    {
        /// <summary>
        /// Initialize a new VendorPaymentMethodSpecificationSingle object.
        /// </summary>
        public VendorPaymentMethodSpecificationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorPaymentMethodSpecificationSingle object.
        /// </summary>
        public VendorPaymentMethodSpecificationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorPaymentMethodSpecificationSingle object.
        /// </summary>
        public VendorPaymentMethodSpecificationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorPaymentMethodSpecification> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for VendorPaymentMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorPaymentMethodSingle VendorPaymentMethod
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendorPaymentMethod == null))
                {
                    this._VendorPaymentMethod = new global::Microsoft.Dynamics.DataEntities.VendorPaymentMethodSingle(this.Context, GetPath("VendorPaymentMethod"));
                }
                return this._VendorPaymentMethod;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorPaymentMethodSingle _VendorPaymentMethod;
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
    }
    /// <summary>
    /// There are no comments for VendorPaymentMethodSpecification in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PaymentMethodName
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PaymentMethodName", "Name")]
    [global::Microsoft.OData.Client.EntitySet("VendorPaymentMethodSpecifications")]
    public partial class VendorPaymentMethodSpecification : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorPaymentMethodSpecification object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="paymentMethodName">Initial value of PaymentMethodName.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="vendorPaymentMethod">Initial value of VendorPaymentMethod.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorPaymentMethodSpecification CreateVendorPaymentMethodSpecification(string dataAreaId, string paymentMethodName, string name, global::Microsoft.Dynamics.DataEntities.VendorPaymentMethod vendorPaymentMethod)
        {
            VendorPaymentMethodSpecification vendorPaymentMethodSpecification = new VendorPaymentMethodSpecification();
            vendorPaymentMethodSpecification.dataAreaId = dataAreaId;
            vendorPaymentMethodSpecification.PaymentMethodName = paymentMethodName;
            vendorPaymentMethodSpecification.Name = name;
            if ((vendorPaymentMethod == null))
            {
                throw new global::System.ArgumentNullException("vendorPaymentMethod");
            }
            vendorPaymentMethodSpecification.VendorPaymentMethod = vendorPaymentMethod;
            return vendorPaymentMethodSpecification;
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
        /// There are no comments for Property PaymentMethodName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PaymentMethodName
        {
            get
            {
                return this._PaymentMethodName;
            }
            set
            {
                this.OnPaymentMethodNameChanging(value);
                this._PaymentMethodName = value;
                this.OnPaymentMethodNameChanged();
                this.OnPropertyChanged("PaymentMethodName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentMethodName;
        partial void OnPaymentMethodNameChanging(string value);
        partial void OnPaymentMethodNameChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property ElectronicPaymentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ElectronicPaymentType
        {
            get
            {
                return this._ElectronicPaymentType;
            }
            set
            {
                this.OnElectronicPaymentTypeChanging(value);
                this._ElectronicPaymentType = value;
                this.OnElectronicPaymentTypeChanged();
                this.OnPropertyChanged("ElectronicPaymentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ElectronicPaymentType;
        partial void OnElectronicPaymentTypeChanging(string value);
        partial void OnElectronicPaymentTypeChanged();
        /// <summary>
        /// There are no comments for Property SpecParameters in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SpecParameters
        {
            get
            {
                return this._SpecParameters;
            }
            set
            {
                this.OnSpecParametersChanging(value);
                this._SpecParameters = value;
                this.OnSpecParametersChanged();
                this.OnPropertyChanged("SpecParameters");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SpecParameters;
        partial void OnSpecParametersChanging(string value);
        partial void OnSpecParametersChanged();
        /// <summary>
        /// There are no comments for Property ElectronicPaymentSegment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ElectronicPaymentSegment
        {
            get
            {
                return this._ElectronicPaymentSegment;
            }
            set
            {
                this.OnElectronicPaymentSegmentChanging(value);
                this._ElectronicPaymentSegment = value;
                this.OnElectronicPaymentSegmentChanged();
                this.OnPropertyChanged("ElectronicPaymentSegment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ElectronicPaymentSegment;
        partial void OnElectronicPaymentSegmentChanging(string value);
        partial void OnElectronicPaymentSegmentChanged();
        /// <summary>
        /// There are no comments for Property ClassName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ClassName
        {
            get
            {
                return this._ClassName;
            }
            set
            {
                this.OnClassNameChanging(value);
                this._ClassName = value;
                this.OnClassNameChanged();
                this.OnPropertyChanged("ClassName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ClassName;
        partial void OnClassNameChanging(string value);
        partial void OnClassNameChanged();
        /// <summary>
        /// There are no comments for Property ElectronicPaymentWay in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ElectronicPaymentWay
        {
            get
            {
                return this._ElectronicPaymentWay;
            }
            set
            {
                this.OnElectronicPaymentWayChanging(value);
                this._ElectronicPaymentWay = value;
                this.OnElectronicPaymentWayChanged();
                this.OnPropertyChanged("ElectronicPaymentWay");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ElectronicPaymentWay;
        partial void OnElectronicPaymentWayChanging(string value);
        partial void OnElectronicPaymentWayChanged();
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
        /// There are no comments for Property ElectronicPaymentValidationControl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ValidationControl_BR> ElectronicPaymentValidationControl
        {
            get
            {
                return this._ElectronicPaymentValidationControl;
            }
            set
            {
                this.OnElectronicPaymentValidationControlChanging(value);
                this._ElectronicPaymentValidationControl = value;
                this.OnElectronicPaymentValidationControlChanged();
                this.OnPropertyChanged("ElectronicPaymentValidationControl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ValidationControl_BR> _ElectronicPaymentValidationControl;
        partial void OnElectronicPaymentValidationControlChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ValidationControl_BR> value);
        partial void OnElectronicPaymentValidationControlChanged();
        /// <summary>
        /// There are no comments for Property VendorPaymentMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorPaymentMethod VendorPaymentMethod
        {
            get
            {
                return this._VendorPaymentMethod;
            }
            set
            {
                this.OnVendorPaymentMethodChanging(value);
                this._VendorPaymentMethod = value;
                this.OnVendorPaymentMethodChanged();
                this.OnPropertyChanged("VendorPaymentMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorPaymentMethod _VendorPaymentMethod;
        partial void OnVendorPaymentMethodChanging(global::Microsoft.Dynamics.DataEntities.VendorPaymentMethod value);
        partial void OnVendorPaymentMethodChanged();
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