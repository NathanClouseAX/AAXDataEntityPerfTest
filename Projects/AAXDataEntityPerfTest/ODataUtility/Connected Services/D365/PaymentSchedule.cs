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
        /// There are no comments for PaymentScheduleSingle in the schema.
        /// </summary>
    public partial class PaymentScheduleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PaymentSchedule>
    {
        /// <summary>
        /// Initialize a new PaymentScheduleSingle object.
        /// </summary>
        public PaymentScheduleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PaymentScheduleSingle object.
        /// </summary>
        public PaymentScheduleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PaymentScheduleSingle object.
        /// </summary>
        public PaymentScheduleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PaymentSchedule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PaymentTerm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PaymentTerm> PaymentTerm
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PaymentTerm == null))
                {
                    this._PaymentTerm = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PaymentTerm>(GetPath("PaymentTerm"));
                }
                return this._PaymentTerm;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PaymentTerm> _PaymentTerm;
        /// <summary>
        /// There are no comments for FreeTextInvoiceHeaderPaymentSchedule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceHeader> FreeTextInvoiceHeaderPaymentSchedule
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FreeTextInvoiceHeaderPaymentSchedule == null))
                {
                    this._FreeTextInvoiceHeaderPaymentSchedule = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceHeader>(GetPath("FreeTextInvoiceHeaderPaymentSchedule"));
                }
                return this._FreeTextInvoiceHeaderPaymentSchedule;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceHeader> _FreeTextInvoiceHeaderPaymentSchedule;
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
        /// There are no comments for PaymentScheduleLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PaymentScheduleLine> PaymentScheduleLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PaymentScheduleLines == null))
                {
                    this._PaymentScheduleLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PaymentScheduleLine>(GetPath("PaymentScheduleLines"));
                }
                return this._PaymentScheduleLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PaymentScheduleLine> _PaymentScheduleLines;
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
        /// There are no comments for PaymentSchedule in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Name")]
    [global::Microsoft.OData.Client.EntitySet("PaymentSchedules")]
    public partial class PaymentSchedule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PaymentSchedule object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="numberOfPayments">Initial value of NumberOfPayments.</param>
        /// <param name="minimumPaymentAmount">Initial value of MinimumPaymentAmount.</param>
        /// <param name="installmentMinimumOrderAmount">Initial value of InstallmentMinimumOrderAmount.</param>
        /// <param name="installmentMaximumOrderAmount">Initial value of InstallmentMaximumOrderAmount.</param>
        /// <param name="paymentFrequency">Initial value of PaymentFrequency.</param>
        /// <param name="fixedPaymentAmount">Initial value of FixedPaymentAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PaymentSchedule CreatePaymentSchedule(string dataAreaId, 
                    string name, 
                    int numberOfPayments, 
                    decimal minimumPaymentAmount, 
                    decimal installmentMinimumOrderAmount, 
                    decimal installmentMaximumOrderAmount, 
                    int paymentFrequency, 
                    decimal fixedPaymentAmount)
        {
            PaymentSchedule paymentSchedule = new PaymentSchedule();
            paymentSchedule.dataAreaId = dataAreaId;
            paymentSchedule.Name = name;
            paymentSchedule.NumberOfPayments = numberOfPayments;
            paymentSchedule.MinimumPaymentAmount = minimumPaymentAmount;
            paymentSchedule.InstallmentMinimumOrderAmount = installmentMinimumOrderAmount;
            paymentSchedule.InstallmentMaximumOrderAmount = installmentMaximumOrderAmount;
            paymentSchedule.PaymentFrequency = paymentFrequency;
            paymentSchedule.FixedPaymentAmount = fixedPaymentAmount;
            return paymentSchedule;
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
        /// There are no comments for Property AllocationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PaymSchedBy> AllocationMethod
        {
            get
            {
                return this._AllocationMethod;
            }
            set
            {
                this.OnAllocationMethodChanging(value);
                this._AllocationMethod = value;
                this.OnAllocationMethodChanged();
                this.OnPropertyChanged("AllocationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PaymSchedBy> _AllocationMethod;
        partial void OnAllocationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PaymSchedBy> value);
        partial void OnAllocationMethodChanged();
        /// <summary>
        /// There are no comments for Property NumberOfPayments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int NumberOfPayments
        {
            get
            {
                return this._NumberOfPayments;
            }
            set
            {
                this.OnNumberOfPaymentsChanging(value);
                this._NumberOfPayments = value;
                this.OnNumberOfPaymentsChanged();
                this.OnPropertyChanged("NumberOfPayments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NumberOfPayments;
        partial void OnNumberOfPaymentsChanging(int value);
        partial void OnNumberOfPaymentsChanged();
        /// <summary>
        /// There are no comments for Property PaymentFrequencyUnits in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PeriodUnit> PaymentFrequencyUnits
        {
            get
            {
                return this._PaymentFrequencyUnits;
            }
            set
            {
                this.OnPaymentFrequencyUnitsChanging(value);
                this._PaymentFrequencyUnits = value;
                this.OnPaymentFrequencyUnitsChanged();
                this.OnPropertyChanged("PaymentFrequencyUnits");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PeriodUnit> _PaymentFrequencyUnits;
        partial void OnPaymentFrequencyUnitsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PeriodUnit> value);
        partial void OnPaymentFrequencyUnitsChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxAllocationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PaymSchedTaxDistribution> SalesTaxAllocationMethod
        {
            get
            {
                return this._SalesTaxAllocationMethod;
            }
            set
            {
                this.OnSalesTaxAllocationMethodChanging(value);
                this._SalesTaxAllocationMethod = value;
                this.OnSalesTaxAllocationMethodChanged();
                this.OnPropertyChanged("SalesTaxAllocationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PaymSchedTaxDistribution> _SalesTaxAllocationMethod;
        partial void OnSalesTaxAllocationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PaymSchedTaxDistribution> value);
        partial void OnSalesTaxAllocationMethodChanged();
        /// <summary>
        /// There are no comments for Property ChargeAllocationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRPaymSchedMiscChargeDist> ChargeAllocationMethod
        {
            get
            {
                return this._ChargeAllocationMethod;
            }
            set
            {
                this.OnChargeAllocationMethodChanging(value);
                this._ChargeAllocationMethod = value;
                this.OnChargeAllocationMethodChanged();
                this.OnPropertyChanged("ChargeAllocationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRPaymSchedMiscChargeDist> _ChargeAllocationMethod;
        partial void OnChargeAllocationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRPaymSchedMiscChargeDist> value);
        partial void OnChargeAllocationMethodChanged();
        /// <summary>
        /// There are no comments for Property MinimumPaymentAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MinimumPaymentAmount
        {
            get
            {
                return this._MinimumPaymentAmount;
            }
            set
            {
                this.OnMinimumPaymentAmountChanging(value);
                this._MinimumPaymentAmount = value;
                this.OnMinimumPaymentAmountChanged();
                this.OnPropertyChanged("MinimumPaymentAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MinimumPaymentAmount;
        partial void OnMinimumPaymentAmountChanging(decimal value);
        partial void OnMinimumPaymentAmountChanged();
        /// <summary>
        /// There are no comments for Property InstallmentMinimumOrderAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal InstallmentMinimumOrderAmount
        {
            get
            {
                return this._InstallmentMinimumOrderAmount;
            }
            set
            {
                this.OnInstallmentMinimumOrderAmountChanging(value);
                this._InstallmentMinimumOrderAmount = value;
                this.OnInstallmentMinimumOrderAmountChanged();
                this.OnPropertyChanged("InstallmentMinimumOrderAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InstallmentMinimumOrderAmount;
        partial void OnInstallmentMinimumOrderAmountChanging(decimal value);
        partial void OnInstallmentMinimumOrderAmountChanged();
        /// <summary>
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
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
        /// There are no comments for Property InstallmentMaximumOrderAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal InstallmentMaximumOrderAmount
        {
            get
            {
                return this._InstallmentMaximumOrderAmount;
            }
            set
            {
                this.OnInstallmentMaximumOrderAmountChanging(value);
                this._InstallmentMaximumOrderAmount = value;
                this.OnInstallmentMaximumOrderAmountChanged();
                this.OnPropertyChanged("InstallmentMaximumOrderAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InstallmentMaximumOrderAmount;
        partial void OnInstallmentMaximumOrderAmountChanging(decimal value);
        partial void OnInstallmentMaximumOrderAmountChanged();
        /// <summary>
        /// There are no comments for Property PaymentFrequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int PaymentFrequency
        {
            get
            {
                return this._PaymentFrequency;
            }
            set
            {
                this.OnPaymentFrequencyChanging(value);
                this._PaymentFrequency = value;
                this.OnPaymentFrequencyChanged();
                this.OnPropertyChanged("PaymentFrequency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PaymentFrequency;
        partial void OnPaymentFrequencyChanging(int value);
        partial void OnPaymentFrequencyChanged();
        /// <summary>
        /// There are no comments for Property IsFlexibleInstallmentPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsFlexibleInstallmentPlan
        {
            get
            {
                return this._IsFlexibleInstallmentPlan;
            }
            set
            {
                this.OnIsFlexibleInstallmentPlanChanging(value);
                this._IsFlexibleInstallmentPlan = value;
                this.OnIsFlexibleInstallmentPlanChanged();
                this.OnPropertyChanged("IsFlexibleInstallmentPlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsFlexibleInstallmentPlan;
        partial void OnIsFlexibleInstallmentPlanChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsFlexibleInstallmentPlanChanged();
        /// <summary>
        /// There are no comments for Property FixedPaymentAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal FixedPaymentAmount
        {
            get
            {
                return this._FixedPaymentAmount;
            }
            set
            {
                this.OnFixedPaymentAmountChanging(value);
                this._FixedPaymentAmount = value;
                this.OnFixedPaymentAmountChanged();
                this.OnPropertyChanged("FixedPaymentAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FixedPaymentAmount;
        partial void OnFixedPaymentAmountChanging(decimal value);
        partial void OnFixedPaymentAmountChanged();
        /// <summary>
        /// There are no comments for Property PaymentTerm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentTerm> PaymentTerm
        {
            get
            {
                return this._PaymentTerm;
            }
            set
            {
                this.OnPaymentTermChanging(value);
                this._PaymentTerm = value;
                this.OnPaymentTermChanged();
                this.OnPropertyChanged("PaymentTerm");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentTerm> _PaymentTerm = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentTerm>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPaymentTermChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentTerm> value);
        partial void OnPaymentTermChanged();
        /// <summary>
        /// There are no comments for Property FreeTextInvoiceHeaderPaymentSchedule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceHeader> FreeTextInvoiceHeaderPaymentSchedule
        {
            get
            {
                return this._FreeTextInvoiceHeaderPaymentSchedule;
            }
            set
            {
                this.OnFreeTextInvoiceHeaderPaymentScheduleChanging(value);
                this._FreeTextInvoiceHeaderPaymentSchedule = value;
                this.OnFreeTextInvoiceHeaderPaymentScheduleChanged();
                this.OnPropertyChanged("FreeTextInvoiceHeaderPaymentSchedule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceHeader> _FreeTextInvoiceHeaderPaymentSchedule = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFreeTextInvoiceHeaderPaymentScheduleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceHeader> value);
        partial void OnFreeTextInvoiceHeaderPaymentScheduleChanged();
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
        /// There are no comments for Property PaymentScheduleLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentScheduleLine> PaymentScheduleLines
        {
            get
            {
                return this._PaymentScheduleLines;
            }
            set
            {
                this.OnPaymentScheduleLinesChanging(value);
                this._PaymentScheduleLines = value;
                this.OnPaymentScheduleLinesChanged();
                this.OnPropertyChanged("PaymentScheduleLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentScheduleLine> _PaymentScheduleLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentScheduleLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPaymentScheduleLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentScheduleLine> value);
        partial void OnPaymentScheduleLinesChanged();
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
