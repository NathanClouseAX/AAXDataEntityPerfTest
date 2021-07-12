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
        /// There are no comments for CashDiscountSingle in the schema.
        /// </summary>
    public partial class CashDiscountSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CashDiscount>
    {
        /// <summary>
        /// Initialize a new CashDiscountSingle object.
        /// </summary>
        public CashDiscountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CashDiscountSingle object.
        /// </summary>
        public CashDiscountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CashDiscountSingle object.
        /// </summary>
        public CashDiscountSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CashDiscount> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CDSFreeTextInvoiceHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CDSFreeTextInvoiceHeader> CDSFreeTextInvoiceHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CDSFreeTextInvoiceHeaders == null))
                {
                    this._CDSFreeTextInvoiceHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CDSFreeTextInvoiceHeader>(GetPath("CDSFreeTextInvoiceHeaders"));
                }
                return this._CDSFreeTextInvoiceHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CDSFreeTextInvoiceHeader> _CDSFreeTextInvoiceHeaders;
        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
        /// <summary>
        /// There are no comments for FreeTextInvoiceHeaderCashDiscount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceHeader> FreeTextInvoiceHeaderCashDiscount
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FreeTextInvoiceHeaderCashDiscount == null))
                {
                    this._FreeTextInvoiceHeaderCashDiscount = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceHeader>(GetPath("FreeTextInvoiceHeaderCashDiscount"));
                }
                return this._FreeTextInvoiceHeaderCashDiscount;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceHeader> _FreeTextInvoiceHeaderCashDiscount;
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
        /// There are no comments for CashDiscount in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CashDiscountCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CashDiscountCode")]
    [global::Microsoft.OData.Client.EntitySet("CashDiscounts")]
    public partial class CashDiscount : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CashDiscount object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="cashDiscountCode">Initial value of CashDiscountCode.</param>
        /// <param name="percent">Initial value of Percent.</param>
        /// <param name="numberOfMonths">Initial value of NumberOfMonths.</param>
        /// <param name="numberOfDays">Initial value of NumberOfDays.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CashDiscount CreateCashDiscount(string dataAreaId, string cashDiscountCode, decimal percent, int numberOfMonths, int numberOfDays)
        {
            CashDiscount cashDiscount = new CashDiscount();
            cashDiscount.dataAreaId = dataAreaId;
            cashDiscount.CashDiscountCode = cashDiscountCode;
            cashDiscount.Percent = percent;
            cashDiscount.NumberOfMonths = numberOfMonths;
            cashDiscount.NumberOfDays = numberOfDays;
            return cashDiscount;
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
        /// There are no comments for Property CashDiscountCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CashDiscountCode
        {
            get
            {
                return this._CashDiscountCode;
            }
            set
            {
                this.OnCashDiscountCodeChanging(value);
                this._CashDiscountCode = value;
                this.OnCashDiscountCodeChanged();
                this.OnPropertyChanged("CashDiscountCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CashDiscountCode;
        partial void OnCashDiscountCodeChanging(string value);
        partial void OnCashDiscountCodeChanged();
        /// <summary>
        /// There are no comments for Property Percent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Percent
        {
            get
            {
                return this._Percent;
            }
            set
            {
                this.OnPercentChanging(value);
                this._Percent = value;
                this.OnPercentChanged();
                this.OnPropertyChanged("Percent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Percent;
        partial void OnPercentChanging(decimal value);
        partial void OnPercentChanged();
        /// <summary>
        /// There are no comments for Property OffsetMethodForVendorDiscounts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DiscountOffsetMethod> OffsetMethodForVendorDiscounts
        {
            get
            {
                return this._OffsetMethodForVendorDiscounts;
            }
            set
            {
                this.OnOffsetMethodForVendorDiscountsChanging(value);
                this._OffsetMethodForVendorDiscounts = value;
                this.OnOffsetMethodForVendorDiscountsChanged();
                this.OnPropertyChanged("OffsetMethodForVendorDiscounts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DiscountOffsetMethod> _OffsetMethodForVendorDiscounts;
        partial void OnOffsetMethodForVendorDiscountsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DiscountOffsetMethod> value);
        partial void OnOffsetMethodForVendorDiscountsChanged();
        /// <summary>
        /// There are no comments for Property NextCashDiscountCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string NextCashDiscountCode
        {
            get
            {
                return this._NextCashDiscountCode;
            }
            set
            {
                this.OnNextCashDiscountCodeChanging(value);
                this._NextCashDiscountCode = value;
                this.OnNextCashDiscountCodeChanged();
                this.OnPropertyChanged("NextCashDiscountCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NextCashDiscountCode;
        partial void OnNextCashDiscountCodeChanging(string value);
        partial void OnNextCashDiscountCodeChanged();
        /// <summary>
        /// There are no comments for Property NumberOfMonths in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int NumberOfMonths
        {
            get
            {
                return this._NumberOfMonths;
            }
            set
            {
                this.OnNumberOfMonthsChanging(value);
                this._NumberOfMonths = value;
                this.OnNumberOfMonthsChanged();
                this.OnPropertyChanged("NumberOfMonths");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NumberOfMonths;
        partial void OnNumberOfMonthsChanging(int value);
        partial void OnNumberOfMonthsChanged();
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
        /// There are no comments for Property MainAccountIdForCustomerDiscountsDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccountIdForCustomerDiscountsDisplayValue
        {
            get
            {
                return this._MainAccountIdForCustomerDiscountsDisplayValue;
            }
            set
            {
                this.OnMainAccountIdForCustomerDiscountsDisplayValueChanging(value);
                this._MainAccountIdForCustomerDiscountsDisplayValue = value;
                this.OnMainAccountIdForCustomerDiscountsDisplayValueChanged();
                this.OnPropertyChanged("MainAccountIdForCustomerDiscountsDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountIdForCustomerDiscountsDisplayValue;
        partial void OnMainAccountIdForCustomerDiscountsDisplayValueChanging(string value);
        partial void OnMainAccountIdForCustomerDiscountsDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DiscountMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NetCurrent> DiscountMethod
        {
            get
            {
                return this._DiscountMethod;
            }
            set
            {
                this.OnDiscountMethodChanging(value);
                this._DiscountMethod = value;
                this.OnDiscountMethodChanged();
                this.OnPropertyChanged("DiscountMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NetCurrent> _DiscountMethod;
        partial void OnDiscountMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NetCurrent> value);
        partial void OnDiscountMethodChanged();
        /// <summary>
        /// There are no comments for Property MainAccountIdForVendorDiscountsDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccountIdForVendorDiscountsDisplayValue
        {
            get
            {
                return this._MainAccountIdForVendorDiscountsDisplayValue;
            }
            set
            {
                this.OnMainAccountIdForVendorDiscountsDisplayValueChanging(value);
                this._MainAccountIdForVendorDiscountsDisplayValue = value;
                this.OnMainAccountIdForVendorDiscountsDisplayValueChanged();
                this.OnPropertyChanged("MainAccountIdForVendorDiscountsDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountIdForVendorDiscountsDisplayValue;
        partial void OnMainAccountIdForVendorDiscountsDisplayValueChanging(string value);
        partial void OnMainAccountIdForVendorDiscountsDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property NumberOfDays in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int NumberOfDays
        {
            get
            {
                return this._NumberOfDays;
            }
            set
            {
                this.OnNumberOfDaysChanging(value);
                this._NumberOfDays = value;
                this.OnNumberOfDaysChanged();
                this.OnPropertyChanged("NumberOfDays");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NumberOfDays;
        partial void OnNumberOfDaysChanging(int value);
        partial void OnNumberOfDaysChanged();
        /// <summary>
        /// There are no comments for Property DescriptionQRBill in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DescriptionQRBill
        {
            get
            {
                return this._DescriptionQRBill;
            }
            set
            {
                this.OnDescriptionQRBillChanging(value);
                this._DescriptionQRBill = value;
                this.OnDescriptionQRBillChanged();
                this.OnPropertyChanged("DescriptionQRBill");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DescriptionQRBill;
        partial void OnDescriptionQRBillChanging(string value);
        partial void OnDescriptionQRBillChanged();
        /// <summary>
        /// There are no comments for Property CDSFreeTextInvoiceHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CDSFreeTextInvoiceHeader> CDSFreeTextInvoiceHeaders
        {
            get
            {
                return this._CDSFreeTextInvoiceHeaders;
            }
            set
            {
                this.OnCDSFreeTextInvoiceHeadersChanging(value);
                this._CDSFreeTextInvoiceHeaders = value;
                this.OnCDSFreeTextInvoiceHeadersChanged();
                this.OnPropertyChanged("CDSFreeTextInvoiceHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CDSFreeTextInvoiceHeader> _CDSFreeTextInvoiceHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CDSFreeTextInvoiceHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCDSFreeTextInvoiceHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CDSFreeTextInvoiceHeader> value);
        partial void OnCDSFreeTextInvoiceHeadersChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
        /// <summary>
        /// There are no comments for Property FreeTextInvoiceHeaderCashDiscount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceHeader> FreeTextInvoiceHeaderCashDiscount
        {
            get
            {
                return this._FreeTextInvoiceHeaderCashDiscount;
            }
            set
            {
                this.OnFreeTextInvoiceHeaderCashDiscountChanging(value);
                this._FreeTextInvoiceHeaderCashDiscount = value;
                this.OnFreeTextInvoiceHeaderCashDiscountChanged();
                this.OnPropertyChanged("FreeTextInvoiceHeaderCashDiscount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceHeader> _FreeTextInvoiceHeaderCashDiscount = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFreeTextInvoiceHeaderCashDiscountChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceHeader> value);
        partial void OnFreeTextInvoiceHeaderCashDiscountChanged();
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
