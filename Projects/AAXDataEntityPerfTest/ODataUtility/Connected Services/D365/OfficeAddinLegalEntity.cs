﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 7/17/2021 8:49:18 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for OfficeAddinLegalEntitySingle in the schema.
        /// </summary>
    public partial class OfficeAddinLegalEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<OfficeAddinLegalEntity>
    {
        /// <summary>
        /// Initialize a new OfficeAddinLegalEntitySingle object.
        /// </summary>
        public OfficeAddinLegalEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new OfficeAddinLegalEntitySingle object.
        /// </summary>
        public OfficeAddinLegalEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new OfficeAddinLegalEntitySingle object.
        /// </summary>
        public OfficeAddinLegalEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<OfficeAddinLegalEntity> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValueTotalAccountInterval> FinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntity == null))
                {
                    this._FinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntity = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValueTotalAccountInterval>(GetPath("FinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntity"));
                }
                return this._FinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValueTotalAccountInterval> _FinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntity;
        /// <summary>
        /// There are no comments for VendInvoiceJournalLineOffsetCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> VendInvoiceJournalLineOffsetCompany
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendInvoiceJournalLineOffsetCompany == null))
                {
                    this._VendInvoiceJournalLineOffsetCompany = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine>(GetPath("VendInvoiceJournalLineOffsetCompany"));
                }
                return this._VendInvoiceJournalLineOffsetCompany;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> _VendInvoiceJournalLineOffsetCompany;
        /// <summary>
        /// There are no comments for VendInvoiceJournalLineCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> VendInvoiceJournalLineCompany
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendInvoiceJournalLineCompany == null))
                {
                    this._VendInvoiceJournalLineCompany = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine>(GetPath("VendInvoiceJournalLineCompany"));
                }
                return this._VendInvoiceJournalLineCompany;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> _VendInvoiceJournalLineCompany;
        /// <summary>
        /// There are no comments for CustomerPaymentJournalLineCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> CustomerPaymentJournalLineCompany
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerPaymentJournalLineCompany == null))
                {
                    this._CustomerPaymentJournalLineCompany = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine>(GetPath("CustomerPaymentJournalLineCompany"));
                }
                return this._CustomerPaymentJournalLineCompany;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> _CustomerPaymentJournalLineCompany;
        /// <summary>
        /// There are no comments for VendPaymentJournalLineCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine> VendPaymentJournalLineCompany
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendPaymentJournalLineCompany == null))
                {
                    this._VendPaymentJournalLineCompany = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine>(GetPath("VendPaymentJournalLineCompany"));
                }
                return this._VendPaymentJournalLineCompany;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine> _VendPaymentJournalLineCompany;
        /// <summary>
        /// There are no comments for CustInvoiceJournalLineOffsetCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.GeneralLedgerCustInvoiceJournalLine> CustInvoiceJournalLineOffsetCompany
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustInvoiceJournalLineOffsetCompany == null))
                {
                    this._CustInvoiceJournalLineOffsetCompany = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.GeneralLedgerCustInvoiceJournalLine>(GetPath("CustInvoiceJournalLineOffsetCompany"));
                }
                return this._CustInvoiceJournalLineOffsetCompany;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.GeneralLedgerCustInvoiceJournalLine> _CustInvoiceJournalLineOffsetCompany;
        /// <summary>
        /// There are no comments for CustInvoiceJournalLineCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.GeneralLedgerCustInvoiceJournalLine> CustInvoiceJournalLineCompany
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustInvoiceJournalLineCompany == null))
                {
                    this._CustInvoiceJournalLineCompany = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.GeneralLedgerCustInvoiceJournalLine>(GetPath("CustInvoiceJournalLineCompany"));
                }
                return this._CustInvoiceJournalLineCompany;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.GeneralLedgerCustInvoiceJournalLine> _CustInvoiceJournalLineCompany;
        /// <summary>
        /// There are no comments for FinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValueLegalEntityOverride> FinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntity == null))
                {
                    this._FinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntity = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValueLegalEntityOverride>(GetPath("FinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntity"));
                }
                return this._FinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValueLegalEntityOverride> _FinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntity;
        /// <summary>
        /// There are no comments for FinancialDimensionValueEntity_Role_LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValue> FinancialDimensionValueEntity_Role_LegalEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FinancialDimensionValueEntity_Role_LegalEntity == null))
                {
                    this._FinancialDimensionValueEntity_Role_LegalEntity = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValue>(GetPath("FinancialDimensionValueEntity_Role_LegalEntity"));
                }
                return this._FinancialDimensionValueEntity_Role_LegalEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValue> _FinancialDimensionValueEntity_Role_LegalEntity;
    }
        /// <summary>
        /// There are no comments for OfficeAddinLegalEntity in the schema.
        /// </summary>
    /// <KeyProperties>
    /// CompanyId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CompanyId")]
    [global::Microsoft.OData.Client.EntitySet("OfficeAddinLegalEntities")]
    public partial class OfficeAddinLegalEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new OfficeAddinLegalEntity object.
        /// </summary>
        /// <param name="companyId">Initial value of CompanyId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static OfficeAddinLegalEntity CreateOfficeAddinLegalEntity(string companyId)
        {
            OfficeAddinLegalEntity officeAddinLegalEntity = new OfficeAddinLegalEntity();
            officeAddinLegalEntity.CompanyId = companyId;
            return officeAddinLegalEntity;
        }
        /// <summary>
        /// There are no comments for Property CompanyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                this.OnCompanyIdChanging(value);
                this._CompanyId = value;
                this.OnCompanyIdChanged();
                this.OnPropertyChanged("CompanyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CompanyId;
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
        /// <summary>
        /// There are no comments for Property ZakatFileNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ZakatFileNumber
        {
            get
            {
                return this._ZakatFileNumber;
            }
            set
            {
                this.OnZakatFileNumberChanging(value);
                this._ZakatFileNumber = value;
                this.OnZakatFileNumberChanged();
                this.OnPropertyChanged("ZakatFileNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ZakatFileNumber;
        partial void OnZakatFileNumberChanging(string value);
        partial void OnZakatFileNumberChanged();
        /// <summary>
        /// There are no comments for Property BusinessActivityDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BusinessActivityDescription
        {
            get
            {
                return this._BusinessActivityDescription;
            }
            set
            {
                this.OnBusinessActivityDescriptionChanging(value);
                this._BusinessActivityDescription = value;
                this.OnBusinessActivityDescriptionChanged();
                this.OnPropertyChanged("BusinessActivityDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BusinessActivityDescription;
        partial void OnBusinessActivityDescriptionChanging(string value);
        partial void OnBusinessActivityDescriptionChanged();
        /// <summary>
        /// There are no comments for Property BusinessActivity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BusinessActivity
        {
            get
            {
                return this._BusinessActivity;
            }
            set
            {
                this.OnBusinessActivityChanging(value);
                this._BusinessActivity = value;
                this.OnBusinessActivityChanged();
                this.OnPropertyChanged("BusinessActivity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BusinessActivity;
        partial void OnBusinessActivityChanging(string value);
        partial void OnBusinessActivityChanged();
        /// <summary>
        /// There are no comments for Property CompanyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CompanyName
        {
            get
            {
                return this._CompanyName;
            }
            set
            {
                this.OnCompanyNameChanging(value);
                this._CompanyName = value;
                this.OnCompanyNameChanged();
                this.OnPropertyChanged("CompanyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CompanyName;
        partial void OnCompanyNameChanging(string value);
        partial void OnCompanyNameChanged();
        /// <summary>
        /// There are no comments for Property FinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValueTotalAccountInterval> FinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntity
        {
            get
            {
                return this._FinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntity;
            }
            set
            {
                this.OnFinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntityChanging(value);
                this._FinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntity = value;
                this.OnFinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntityChanged();
                this.OnPropertyChanged("FinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValueTotalAccountInterval> _FinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntity = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValueTotalAccountInterval>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValueTotalAccountInterval> value);
        partial void OnFinancialDimensionValueTotalAccountIntervalEntity_Role_OfficeAddinLegalEntityEntityChanged();
        /// <summary>
        /// There are no comments for Property VendInvoiceJournalLineOffsetCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> VendInvoiceJournalLineOffsetCompany
        {
            get
            {
                return this._VendInvoiceJournalLineOffsetCompany;
            }
            set
            {
                this.OnVendInvoiceJournalLineOffsetCompanyChanging(value);
                this._VendInvoiceJournalLineOffsetCompany = value;
                this.OnVendInvoiceJournalLineOffsetCompanyChanged();
                this.OnPropertyChanged("VendInvoiceJournalLineOffsetCompany");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> _VendInvoiceJournalLineOffsetCompany = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVendInvoiceJournalLineOffsetCompanyChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> value);
        partial void OnVendInvoiceJournalLineOffsetCompanyChanged();
        /// <summary>
        /// There are no comments for Property VendInvoiceJournalLineCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> VendInvoiceJournalLineCompany
        {
            get
            {
                return this._VendInvoiceJournalLineCompany;
            }
            set
            {
                this.OnVendInvoiceJournalLineCompanyChanging(value);
                this._VendInvoiceJournalLineCompany = value;
                this.OnVendInvoiceJournalLineCompanyChanged();
                this.OnPropertyChanged("VendInvoiceJournalLineCompany");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> _VendInvoiceJournalLineCompany = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVendInvoiceJournalLineCompanyChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> value);
        partial void OnVendInvoiceJournalLineCompanyChanged();
        /// <summary>
        /// There are no comments for Property CustomerPaymentJournalLineCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> CustomerPaymentJournalLineCompany
        {
            get
            {
                return this._CustomerPaymentJournalLineCompany;
            }
            set
            {
                this.OnCustomerPaymentJournalLineCompanyChanging(value);
                this._CustomerPaymentJournalLineCompany = value;
                this.OnCustomerPaymentJournalLineCompanyChanged();
                this.OnPropertyChanged("CustomerPaymentJournalLineCompany");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> _CustomerPaymentJournalLineCompany = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCustomerPaymentJournalLineCompanyChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> value);
        partial void OnCustomerPaymentJournalLineCompanyChanged();
        /// <summary>
        /// There are no comments for Property VendPaymentJournalLineCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine> VendPaymentJournalLineCompany
        {
            get
            {
                return this._VendPaymentJournalLineCompany;
            }
            set
            {
                this.OnVendPaymentJournalLineCompanyChanging(value);
                this._VendPaymentJournalLineCompany = value;
                this.OnVendPaymentJournalLineCompanyChanged();
                this.OnPropertyChanged("VendPaymentJournalLineCompany");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine> _VendPaymentJournalLineCompany = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVendPaymentJournalLineCompanyChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine> value);
        partial void OnVendPaymentJournalLineCompanyChanged();
        /// <summary>
        /// There are no comments for Property CustInvoiceJournalLineOffsetCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GeneralLedgerCustInvoiceJournalLine> CustInvoiceJournalLineOffsetCompany
        {
            get
            {
                return this._CustInvoiceJournalLineOffsetCompany;
            }
            set
            {
                this.OnCustInvoiceJournalLineOffsetCompanyChanging(value);
                this._CustInvoiceJournalLineOffsetCompany = value;
                this.OnCustInvoiceJournalLineOffsetCompanyChanged();
                this.OnPropertyChanged("CustInvoiceJournalLineOffsetCompany");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GeneralLedgerCustInvoiceJournalLine> _CustInvoiceJournalLineOffsetCompany = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GeneralLedgerCustInvoiceJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCustInvoiceJournalLineOffsetCompanyChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GeneralLedgerCustInvoiceJournalLine> value);
        partial void OnCustInvoiceJournalLineOffsetCompanyChanged();
        /// <summary>
        /// There are no comments for Property CustInvoiceJournalLineCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GeneralLedgerCustInvoiceJournalLine> CustInvoiceJournalLineCompany
        {
            get
            {
                return this._CustInvoiceJournalLineCompany;
            }
            set
            {
                this.OnCustInvoiceJournalLineCompanyChanging(value);
                this._CustInvoiceJournalLineCompany = value;
                this.OnCustInvoiceJournalLineCompanyChanged();
                this.OnPropertyChanged("CustInvoiceJournalLineCompany");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GeneralLedgerCustInvoiceJournalLine> _CustInvoiceJournalLineCompany = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GeneralLedgerCustInvoiceJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCustInvoiceJournalLineCompanyChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GeneralLedgerCustInvoiceJournalLine> value);
        partial void OnCustInvoiceJournalLineCompanyChanged();
        /// <summary>
        /// There are no comments for Property FinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValueLegalEntityOverride> FinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntity
        {
            get
            {
                return this._FinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntity;
            }
            set
            {
                this.OnFinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntityChanging(value);
                this._FinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntity = value;
                this.OnFinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntityChanged();
                this.OnPropertyChanged("FinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValueLegalEntityOverride> _FinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntity = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValueLegalEntityOverride>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValueLegalEntityOverride> value);
        partial void OnFinancialDimensionValueLegalEntityOverrideEntity_Role_LegalEntityChanged();
        /// <summary>
        /// There are no comments for Property FinancialDimensionValueEntity_Role_LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValue> FinancialDimensionValueEntity_Role_LegalEntity
        {
            get
            {
                return this._FinancialDimensionValueEntity_Role_LegalEntity;
            }
            set
            {
                this.OnFinancialDimensionValueEntity_Role_LegalEntityChanging(value);
                this._FinancialDimensionValueEntity_Role_LegalEntity = value;
                this.OnFinancialDimensionValueEntity_Role_LegalEntityChanged();
                this.OnPropertyChanged("FinancialDimensionValueEntity_Role_LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValue> _FinancialDimensionValueEntity_Role_LegalEntity = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValue>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFinancialDimensionValueEntity_Role_LegalEntityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FinancialDimensionValue> value);
        partial void OnFinancialDimensionValueEntity_Role_LegalEntityChanged();
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
