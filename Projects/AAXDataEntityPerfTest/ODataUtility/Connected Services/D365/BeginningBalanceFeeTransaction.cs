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
    /// There are no comments for BeginningBalanceFeeTransactionSingle in the schema.
    /// </summary>
    public partial class BeginningBalanceFeeTransactionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BeginningBalanceFeeTransaction>
    {
        /// <summary>
        /// Initialize a new BeginningBalanceFeeTransactionSingle object.
        /// </summary>
        public BeginningBalanceFeeTransactionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BeginningBalanceFeeTransactionSingle object.
        /// </summary>
        public BeginningBalanceFeeTransactionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BeginningBalanceFeeTransactionSingle object.
        /// </summary>
        public BeginningBalanceFeeTransactionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BeginningBalanceFeeTransaction> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for JournalHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JournalTableSingle JournalHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JournalHeader == null))
                {
                    this._JournalHeader = new global::Microsoft.Dynamics.DataEntities.JournalTableSingle(this.Context, GetPath("JournalHeader"));
                }
                return this._JournalHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JournalTableSingle _JournalHeader;
        /// <summary>
        /// There are no comments for ProjectRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectSingle ProjectRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjectRole == null))
                {
                    this._ProjectRole = new global::Microsoft.Dynamics.DataEntities.ProjectSingle(this.Context, GetPath("ProjectRole"));
                }
                return this._ProjectRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectSingle _ProjectRole;
        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
    /// <summary>
    /// There are no comments for BeginningBalanceFeeTransaction in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LineNumber
    /// JournalId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LineNumber", "JournalId")]
    [global::Microsoft.OData.Client.EntitySet("BeginningBalanceFeeTransactions")]
    public partial class BeginningBalanceFeeTransaction : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BeginningBalanceFeeTransaction object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="journalId">Initial value of JournalId.</param>
        /// <param name="salesAmount">Initial value of SalesAmount.</param>
        /// <param name="canAccrueRevenue">Initial value of CanAccrueRevenue.</param>
        /// <param name="projectDate">Initial value of ProjectDate.</param>
        /// <param name="salesPrice">Initial value of SalesPrice.</param>
        /// <param name="voucherDate">Initial value of VoucherDate.</param>
        /// <param name="journalHeader">Initial value of JournalHeader.</param>
        /// <param name="projectRole">Initial value of ProjectRole.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BeginningBalanceFeeTransaction CreateBeginningBalanceFeeTransaction(string dataAreaId, 
                    decimal lineNumber, 
                    string journalId, 
                    decimal salesAmount, 
                    bool canAccrueRevenue, 
                    global::System.DateTimeOffset projectDate, 
                    decimal salesPrice, 
                    global::System.DateTimeOffset voucherDate, 
                    global::Microsoft.Dynamics.DataEntities.JournalTable journalHeader, 
                    global::Microsoft.Dynamics.DataEntities.Project projectRole)
        {
            BeginningBalanceFeeTransaction beginningBalanceFeeTransaction = new BeginningBalanceFeeTransaction();
            beginningBalanceFeeTransaction.dataAreaId = dataAreaId;
            beginningBalanceFeeTransaction.LineNumber = lineNumber;
            beginningBalanceFeeTransaction.JournalId = journalId;
            beginningBalanceFeeTransaction.SalesAmount = salesAmount;
            beginningBalanceFeeTransaction.CanAccrueRevenue = canAccrueRevenue;
            beginningBalanceFeeTransaction.ProjectDate = projectDate;
            beginningBalanceFeeTransaction.SalesPrice = salesPrice;
            beginningBalanceFeeTransaction.VoucherDate = voucherDate;
            if ((journalHeader == null))
            {
                throw new global::System.ArgumentNullException("journalHeader");
            }
            beginningBalanceFeeTransaction.JournalHeader = journalHeader;
            if ((projectRole == null))
            {
                throw new global::System.ArgumentNullException("projectRole");
            }
            beginningBalanceFeeTransaction.ProjectRole = projectRole;
            return beginningBalanceFeeTransaction;
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
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNumber is required.")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property JournalId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JournalId is required.")]
        public virtual string JournalId
        {
            get
            {
                return this._JournalId;
            }
            set
            {
                this.OnJournalIdChanging(value);
                this._JournalId = value;
                this.OnJournalIdChanged();
                this.OnPropertyChanged("JournalId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalId;
        partial void OnJournalIdChanging(string value);
        partial void OnJournalIdChanged();
        /// <summary>
        /// There are no comments for Property TransactionStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjTransStatusPostedInvoiced> TransactionStatus
        {
            get
            {
                return this._TransactionStatus;
            }
            set
            {
                this.OnTransactionStatusChanging(value);
                this._TransactionStatus = value;
                this.OnTransactionStatusChanged();
                this.OnPropertyChanged("TransactionStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjTransStatusPostedInvoiced> _TransactionStatus;
        partial void OnTransactionStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjTransStatusPostedInvoiced> value);
        partial void OnTransactionStatusChanged();
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
        /// There are no comments for Property JournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string JournalName
        {
            get
            {
                return this._JournalName;
            }
            set
            {
                this.OnJournalNameChanging(value);
                this._JournalName = value;
                this.OnJournalNameChanged();
                this.OnPropertyChanged("JournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalName;
        partial void OnJournalNameChanging(string value);
        partial void OnJournalNameChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string SalesTaxGroup
        {
            get
            {
                return this._SalesTaxGroup;
            }
            set
            {
                this.OnSalesTaxGroupChanging(value);
                this._SalesTaxGroup = value;
                this.OnSalesTaxGroupChanged();
                this.OnPropertyChanged("SalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxGroup;
        partial void OnSalesTaxGroupChanging(string value);
        partial void OnSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property Voucher in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string Voucher
        {
            get
            {
                return this._Voucher;
            }
            set
            {
                this.OnVoucherChanging(value);
                this._Voucher = value;
                this.OnVoucherChanged();
                this.OnPropertyChanged("Voucher");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Voucher;
        partial void OnVoucherChanging(string value);
        partial void OnVoucherChanged();
        /// <summary>
        /// There are no comments for Property SalesAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SalesAmount is required.")]
        public virtual decimal SalesAmount
        {
            get
            {
                return this._SalesAmount;
            }
            set
            {
                this.OnSalesAmountChanging(value);
                this._SalesAmount = value;
                this.OnSalesAmountChanged();
                this.OnPropertyChanged("SalesAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SalesAmount;
        partial void OnSalesAmountChanging(decimal value);
        partial void OnSalesAmountChanged();
        /// <summary>
        /// There are no comments for Property JournalDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string JournalDescription
        {
            get
            {
                return this._JournalDescription;
            }
            set
            {
                this.OnJournalDescriptionChanging(value);
                this._JournalDescription = value;
                this.OnJournalDescriptionChanged();
                this.OnPropertyChanged("JournalDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalDescription;
        partial void OnJournalDescriptionChanging(string value);
        partial void OnJournalDescriptionChanged();
        /// <summary>
        /// There are no comments for Property JournalDetailSummary in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> JournalDetailSummary
        {
            get
            {
                return this._JournalDetailSummary;
            }
            set
            {
                this.OnJournalDetailSummaryChanging(value);
                this._JournalDetailSummary = value;
                this.OnJournalDetailSummaryChanged();
                this.OnPropertyChanged("JournalDetailSummary");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> _JournalDetailSummary;
        partial void OnJournalDetailSummaryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> value);
        partial void OnJournalDetailSummaryChanged();
        /// <summary>
        /// There are no comments for Property SalesCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string SalesCurrency
        {
            get
            {
                return this._SalesCurrency;
            }
            set
            {
                this.OnSalesCurrencyChanging(value);
                this._SalesCurrency = value;
                this.OnSalesCurrencyChanged();
                this.OnPropertyChanged("SalesCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesCurrency;
        partial void OnSalesCurrencyChanging(string value);
        partial void OnSalesCurrencyChanged();
        /// <summary>
        /// There are no comments for Property CanAccrueRevenue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CanAccrueRevenue is required.")]
        public virtual bool CanAccrueRevenue
        {
            get
            {
                return this._CanAccrueRevenue;
            }
            set
            {
                this.OnCanAccrueRevenueChanging(value);
                this._CanAccrueRevenue = value;
                this.OnCanAccrueRevenueChanged();
                this.OnPropertyChanged("CanAccrueRevenue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private bool _CanAccrueRevenue;
        partial void OnCanAccrueRevenueChanging(bool value);
        partial void OnCanAccrueRevenueChanged();
        /// <summary>
        /// There are no comments for Property ItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ItemSalesTaxGroup
        {
            get
            {
                return this._ItemSalesTaxGroup;
            }
            set
            {
                this.OnItemSalesTaxGroupChanging(value);
                this._ItemSalesTaxGroup = value;
                this.OnItemSalesTaxGroupChanged();
                this.OnPropertyChanged("ItemSalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemSalesTaxGroup;
        partial void OnItemSalesTaxGroupChanging(string value);
        partial void OnItemSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property ProjectDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjectDate is required.")]
        public virtual global::System.DateTimeOffset ProjectDate
        {
            get
            {
                return this._ProjectDate;
            }
            set
            {
                this.OnProjectDateChanging(value);
                this._ProjectDate = value;
                this.OnProjectDateChanged();
                this.OnPropertyChanged("ProjectDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ProjectDate;
        partial void OnProjectDateChanging(global::System.DateTimeOffset value);
        partial void OnProjectDateChanged();
        /// <summary>
        /// There are no comments for Property ProjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ProjectId
        {
            get
            {
                return this._ProjectId;
            }
            set
            {
                this.OnProjectIdChanging(value);
                this._ProjectId = value;
                this.OnProjectIdChanged();
                this.OnPropertyChanged("ProjectId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectId;
        partial void OnProjectIdChanging(string value);
        partial void OnProjectIdChanged();
        /// <summary>
        /// There are no comments for Property FundingSourceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string FundingSourceId
        {
            get
            {
                return this._FundingSourceId;
            }
            set
            {
                this.OnFundingSourceIdChanging(value);
                this._FundingSourceId = value;
                this.OnFundingSourceIdChanged();
                this.OnPropertyChanged("FundingSourceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FundingSourceId;
        partial void OnFundingSourceIdChanging(string value);
        partial void OnFundingSourceIdChanged();
        /// <summary>
        /// There are no comments for Property SalesPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SalesPrice is required.")]
        public virtual decimal SalesPrice
        {
            get
            {
                return this._SalesPrice;
            }
            set
            {
                this.OnSalesPriceChanging(value);
                this._SalesPrice = value;
                this.OnSalesPriceChanged();
                this.OnPropertyChanged("SalesPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SalesPrice;
        partial void OnSalesPriceChanging(decimal value);
        partial void OnSalesPriceChanged();
        /// <summary>
        /// There are no comments for Property VoucherDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VoucherDate is required.")]
        public virtual global::System.DateTimeOffset VoucherDate
        {
            get
            {
                return this._VoucherDate;
            }
            set
            {
                this.OnVoucherDateChanging(value);
                this._VoucherDate = value;
                this.OnVoucherDateChanged();
                this.OnPropertyChanged("VoucherDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _VoucherDate;
        partial void OnVoucherDateChanging(global::System.DateTimeOffset value);
        partial void OnVoucherDateChanged();
        /// <summary>
        /// There are no comments for Property CategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string CategoryId
        {
            get
            {
                return this._CategoryId;
            }
            set
            {
                this.OnCategoryIdChanging(value);
                this._CategoryId = value;
                this.OnCategoryIdChanged();
                this.OnPropertyChanged("CategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryId;
        partial void OnCategoryIdChanging(string value);
        partial void OnCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property Resource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string Resource
        {
            get
            {
                return this._Resource;
            }
            set
            {
                this.OnResourceChanging(value);
                this._Resource = value;
                this.OnResourceChanged();
                this.OnPropertyChanged("Resource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Resource;
        partial void OnResourceChanging(string value);
        partial void OnResourceChanged();
        /// <summary>
        /// There are no comments for Property LinePropertyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string LinePropertyId
        {
            get
            {
                return this._LinePropertyId;
            }
            set
            {
                this.OnLinePropertyIdChanging(value);
                this._LinePropertyId = value;
                this.OnLinePropertyIdChanged();
                this.OnPropertyChanged("LinePropertyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LinePropertyId;
        partial void OnLinePropertyIdChanging(string value);
        partial void OnLinePropertyIdChanged();
        /// <summary>
        /// There are no comments for Property DefaultDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string DefaultDimensionDisplayValue
        {
            get
            {
                return this._DefaultDimensionDisplayValue;
            }
            set
            {
                this.OnDefaultDimensionDisplayValueChanging(value);
                this._DefaultDimensionDisplayValue = value;
                this.OnDefaultDimensionDisplayValueChanged();
                this.OnPropertyChanged("DefaultDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultDimensionDisplayValue;
        partial void OnDefaultDimensionDisplayValueChanging(string value);
        partial void OnDefaultDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property JournalHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JournalHeader is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.JournalTable JournalHeader
        {
            get
            {
                return this._JournalHeader;
            }
            set
            {
                this.OnJournalHeaderChanging(value);
                this._JournalHeader = value;
                this.OnJournalHeaderChanged();
                this.OnPropertyChanged("JournalHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JournalTable _JournalHeader;
        partial void OnJournalHeaderChanging(global::Microsoft.Dynamics.DataEntities.JournalTable value);
        partial void OnJournalHeaderChanged();
        /// <summary>
        /// There are no comments for Property ProjectRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjectRole is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Project ProjectRole
        {
            get
            {
                return this._ProjectRole;
            }
            set
            {
                this.OnProjectRoleChanging(value);
                this._ProjectRole = value;
                this.OnProjectRoleChanged();
                this.OnPropertyChanged("ProjectRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Project _ProjectRole;
        partial void OnProjectRoleChanging(global::Microsoft.Dynamics.DataEntities.Project value);
        partial void OnProjectRoleChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
