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
        /// There are no comments for BudgetRegisterEntryHeaderSingle in the schema.
        /// </summary>
    public partial class BudgetRegisterEntryHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetRegisterEntryHeader>
    {
        /// <summary>
        /// Initialize a new BudgetRegisterEntryHeaderSingle object.
        /// </summary>
        public BudgetRegisterEntryHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetRegisterEntryHeaderSingle object.
        /// </summary>
        public BudgetRegisterEntryHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetRegisterEntryHeaderSingle object.
        /// </summary>
        public BudgetRegisterEntryHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetRegisterEntryHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetRegisterEntryBudgetRegisterEntryHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntrySingle BudgetRegisterEntryBudgetRegisterEntryHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetRegisterEntryBudgetRegisterEntryHeader == null))
                {
                    this._BudgetRegisterEntryBudgetRegisterEntryHeader = new global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntrySingle(this.Context, GetPath("BudgetRegisterEntryBudgetRegisterEntryHeader"));
                }
                return this._BudgetRegisterEntryBudgetRegisterEntryHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntrySingle _BudgetRegisterEntryBudgetRegisterEntryHeader;
        /// <summary>
        /// There are no comments for BudgetModels in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetModelSingle BudgetModels
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetModels == null))
                {
                    this._BudgetModels = new global::Microsoft.Dynamics.DataEntities.BudgetModelSingle(this.Context, GetPath("BudgetModels"));
                }
                return this._BudgetModels;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetModelSingle _BudgetModels;
        /// <summary>
        /// There are no comments for PrimaryLedger in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LedgerSingle PrimaryLedger
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PrimaryLedger == null))
                {
                    this._PrimaryLedger = new global::Microsoft.Dynamics.DataEntities.LedgerSingle(this.Context, GetPath("PrimaryLedger"));
                }
                return this._PrimaryLedger;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LedgerSingle _PrimaryLedger;
        /// <summary>
        /// There are no comments for BudgetCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetCodeSingle BudgetCodes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetCodes == null))
                {
                    this._BudgetCodes = new global::Microsoft.Dynamics.DataEntities.BudgetCodeSingle(this.Context, GetPath("BudgetCodes"));
                }
                return this._BudgetCodes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetCodeSingle _BudgetCodes;
        /// <summary>
        /// There are no comments for BudgetRegisterEntryLineEntryHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryLineSingle BudgetRegisterEntryLineEntryHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetRegisterEntryLineEntryHeader == null))
                {
                    this._BudgetRegisterEntryLineEntryHeader = new global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryLineSingle(this.Context, GetPath("BudgetRegisterEntryLineEntryHeader"));
                }
                return this._BudgetRegisterEntryLineEntryHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryLineSingle _BudgetRegisterEntryLineEntryHeader;
    }
        /// <summary>
        /// There are no comments for BudgetRegisterEntryHeader in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LegalEntityId
    /// EntryNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LegalEntityId", "EntryNumber")]
    [global::Microsoft.OData.Client.EntitySet("BudgetRegisterEntryHeaders")]
    public partial class BudgetRegisterEntryHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetRegisterEntryHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="entryNumber">Initial value of EntryNumber.</param>
        /// <param name="revenueBudgetTotal">Initial value of RevenueBudgetTotal.</param>
        /// <param name="expenseBudgetTotal">Initial value of ExpenseBudgetTotal.</param>
        /// <param name="defaultDate">Initial value of DefaultDate.</param>
        /// <param name="budgetRegisterEntryBudgetRegisterEntryHeader">Initial value of BudgetRegisterEntryBudgetRegisterEntryHeader.</param>
        /// <param name="budgetRegisterEntryLineEntryHeader">Initial value of BudgetRegisterEntryLineEntryHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetRegisterEntryHeader CreateBudgetRegisterEntryHeader(string dataAreaId, 
                    string legalEntityId, 
                    string entryNumber, 
                    decimal revenueBudgetTotal, 
                    decimal expenseBudgetTotal, 
                    global::System.DateTimeOffset defaultDate, 
                    global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntry budgetRegisterEntryBudgetRegisterEntryHeader, 
                    global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryLine budgetRegisterEntryLineEntryHeader)
        {
            BudgetRegisterEntryHeader budgetRegisterEntryHeader = new BudgetRegisterEntryHeader();
            budgetRegisterEntryHeader.dataAreaId = dataAreaId;
            budgetRegisterEntryHeader.LegalEntityId = legalEntityId;
            budgetRegisterEntryHeader.EntryNumber = entryNumber;
            budgetRegisterEntryHeader.RevenueBudgetTotal = revenueBudgetTotal;
            budgetRegisterEntryHeader.ExpenseBudgetTotal = expenseBudgetTotal;
            budgetRegisterEntryHeader.DefaultDate = defaultDate;
            if ((budgetRegisterEntryBudgetRegisterEntryHeader == null))
            {
                throw new global::System.ArgumentNullException("budgetRegisterEntryBudgetRegisterEntryHeader");
            }
            budgetRegisterEntryHeader.BudgetRegisterEntryBudgetRegisterEntryHeader = budgetRegisterEntryBudgetRegisterEntryHeader;
            if ((budgetRegisterEntryLineEntryHeader == null))
            {
                throw new global::System.ArgumentNullException("budgetRegisterEntryLineEntryHeader");
            }
            budgetRegisterEntryHeader.BudgetRegisterEntryLineEntryHeader = budgetRegisterEntryLineEntryHeader;
            return budgetRegisterEntryHeader;
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
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property EntryNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EntryNumber
        {
            get
            {
                return this._EntryNumber;
            }
            set
            {
                this.OnEntryNumberChanging(value);
                this._EntryNumber = value;
                this.OnEntryNumberChanged();
                this.OnPropertyChanged("EntryNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EntryNumber;
        partial void OnEntryNumberChanging(string value);
        partial void OnEntryNumberChanged();
        /// <summary>
        /// There are no comments for Property RevenueBudgetTotal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RevenueBudgetTotal
        {
            get
            {
                return this._RevenueBudgetTotal;
            }
            set
            {
                this.OnRevenueBudgetTotalChanging(value);
                this._RevenueBudgetTotal = value;
                this.OnRevenueBudgetTotalChanged();
                this.OnPropertyChanged("RevenueBudgetTotal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RevenueBudgetTotal;
        partial void OnRevenueBudgetTotalChanging(decimal value);
        partial void OnRevenueBudgetTotalChanged();
        /// <summary>
        /// There are no comments for Property ExpenseBudgetTotal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ExpenseBudgetTotal
        {
            get
            {
                return this._ExpenseBudgetTotal;
            }
            set
            {
                this.OnExpenseBudgetTotalChanging(value);
                this._ExpenseBudgetTotal = value;
                this.OnExpenseBudgetTotalChanged();
                this.OnPropertyChanged("ExpenseBudgetTotal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExpenseBudgetTotal;
        partial void OnExpenseBudgetTotalChanging(decimal value);
        partial void OnExpenseBudgetTotalChanged();
        /// <summary>
        /// There are no comments for Property ReasonComment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReasonComment
        {
            get
            {
                return this._ReasonComment;
            }
            set
            {
                this.OnReasonCommentChanging(value);
                this._ReasonComment = value;
                this.OnReasonCommentChanged();
                this.OnPropertyChanged("ReasonComment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReasonComment;
        partial void OnReasonCommentChanging(string value);
        partial void OnReasonCommentChanged();
        /// <summary>
        /// There are no comments for Property BudgetType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetTransactionType> BudgetType
        {
            get
            {
                return this._BudgetType;
            }
            set
            {
                this.OnBudgetTypeChanging(value);
                this._BudgetType = value;
                this.OnBudgetTypeChanged();
                this.OnPropertyChanged("BudgetType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetTransactionType> _BudgetType;
        partial void OnBudgetTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetTransactionType> value);
        partial void OnBudgetTypeChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetTransactionStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetTransactionStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetTransactionStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property SourceDocument in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SourceDocument
        {
            get
            {
                return this._SourceDocument;
            }
            set
            {
                this.OnSourceDocumentChanging(value);
                this._SourceDocument = value;
                this.OnSourceDocumentChanged();
                this.OnPropertyChanged("SourceDocument");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceDocument;
        partial void OnSourceDocumentChanging(string value);
        partial void OnSourceDocumentChanged();
        /// <summary>
        /// There are no comments for Property BudgetModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BudgetModelId
        {
            get
            {
                return this._BudgetModelId;
            }
            set
            {
                this.OnBudgetModelIdChanging(value);
                this._BudgetModelId = value;
                this.OnBudgetModelIdChanged();
                this.OnPropertyChanged("BudgetModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetModelId;
        partial void OnBudgetModelIdChanging(string value);
        partial void OnBudgetModelIdChanged();
        /// <summary>
        /// There are no comments for Property ReasonCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReasonCode
        {
            get
            {
                return this._ReasonCode;
            }
            set
            {
                this.OnReasonCodeChanging(value);
                this._ReasonCode = value;
                this.OnReasonCodeChanged();
                this.OnPropertyChanged("ReasonCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReasonCode;
        partial void OnReasonCodeChanging(string value);
        partial void OnReasonCodeChanged();
        /// <summary>
        /// There are no comments for Property DefaultDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DefaultDate
        {
            get
            {
                return this._DefaultDate;
            }
            set
            {
                this.OnDefaultDateChanging(value);
                this._DefaultDate = value;
                this.OnDefaultDateChanged();
                this.OnPropertyChanged("DefaultDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DefaultDate;
        partial void OnDefaultDateChanging(global::System.DateTimeOffset value);
        partial void OnDefaultDateChanged();
        /// <summary>
        /// There are no comments for Property WorkflowStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetTransactionWorkflowStatus> WorkflowStatus
        {
            get
            {
                return this._WorkflowStatus;
            }
            set
            {
                this.OnWorkflowStatusChanging(value);
                this._WorkflowStatus = value;
                this.OnWorkflowStatusChanged();
                this.OnPropertyChanged("WorkflowStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetTransactionWorkflowStatus> _WorkflowStatus;
        partial void OnWorkflowStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetTransactionWorkflowStatus> value);
        partial void OnWorkflowStatusChanged();
        /// <summary>
        /// There are no comments for Property OneTimeRevision in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> OneTimeRevision
        {
            get
            {
                return this._OneTimeRevision;
            }
            set
            {
                this.OnOneTimeRevisionChanging(value);
                this._OneTimeRevision = value;
                this.OnOneTimeRevisionChanged();
                this.OnPropertyChanged("OneTimeRevision");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _OneTimeRevision;
        partial void OnOneTimeRevisionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnOneTimeRevisionChanged();
        /// <summary>
        /// There are no comments for Property BudgetCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BudgetCode
        {
            get
            {
                return this._BudgetCode;
            }
            set
            {
                this.OnBudgetCodeChanging(value);
                this._BudgetCode = value;
                this.OnBudgetCodeChanged();
                this.OnPropertyChanged("BudgetCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetCode;
        partial void OnBudgetCodeChanging(string value);
        partial void OnBudgetCodeChanged();
        /// <summary>
        /// There are no comments for Property BudgetRegisterEntryBudgetRegisterEntryHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntry BudgetRegisterEntryBudgetRegisterEntryHeader
        {
            get
            {
                return this._BudgetRegisterEntryBudgetRegisterEntryHeader;
            }
            set
            {
                this.OnBudgetRegisterEntryBudgetRegisterEntryHeaderChanging(value);
                this._BudgetRegisterEntryBudgetRegisterEntryHeader = value;
                this.OnBudgetRegisterEntryBudgetRegisterEntryHeaderChanged();
                this.OnPropertyChanged("BudgetRegisterEntryBudgetRegisterEntryHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntry _BudgetRegisterEntryBudgetRegisterEntryHeader;
        partial void OnBudgetRegisterEntryBudgetRegisterEntryHeaderChanging(global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntry value);
        partial void OnBudgetRegisterEntryBudgetRegisterEntryHeaderChanged();
        /// <summary>
        /// There are no comments for Property BudgetModels in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetModel BudgetModels
        {
            get
            {
                return this._BudgetModels;
            }
            set
            {
                this.OnBudgetModelsChanging(value);
                this._BudgetModels = value;
                this.OnBudgetModelsChanged();
                this.OnPropertyChanged("BudgetModels");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetModel _BudgetModels;
        partial void OnBudgetModelsChanging(global::Microsoft.Dynamics.DataEntities.BudgetModel value);
        partial void OnBudgetModelsChanged();
        /// <summary>
        /// There are no comments for Property PrimaryLedger in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Ledger PrimaryLedger
        {
            get
            {
                return this._PrimaryLedger;
            }
            set
            {
                this.OnPrimaryLedgerChanging(value);
                this._PrimaryLedger = value;
                this.OnPrimaryLedgerChanged();
                this.OnPropertyChanged("PrimaryLedger");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Ledger _PrimaryLedger;
        partial void OnPrimaryLedgerChanging(global::Microsoft.Dynamics.DataEntities.Ledger value);
        partial void OnPrimaryLedgerChanged();
        /// <summary>
        /// There are no comments for Property BudgetCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetCode BudgetCodes
        {
            get
            {
                return this._BudgetCodes;
            }
            set
            {
                this.OnBudgetCodesChanging(value);
                this._BudgetCodes = value;
                this.OnBudgetCodesChanged();
                this.OnPropertyChanged("BudgetCodes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetCode _BudgetCodes;
        partial void OnBudgetCodesChanging(global::Microsoft.Dynamics.DataEntities.BudgetCode value);
        partial void OnBudgetCodesChanged();
        /// <summary>
        /// There are no comments for Property BudgetRegisterEntryLineEntryHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryLine BudgetRegisterEntryLineEntryHeader
        {
            get
            {
                return this._BudgetRegisterEntryLineEntryHeader;
            }
            set
            {
                this.OnBudgetRegisterEntryLineEntryHeaderChanging(value);
                this._BudgetRegisterEntryLineEntryHeader = value;
                this.OnBudgetRegisterEntryLineEntryHeaderChanged();
                this.OnPropertyChanged("BudgetRegisterEntryLineEntryHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryLine _BudgetRegisterEntryLineEntryHeader;
        partial void OnBudgetRegisterEntryLineEntryHeaderChanging(global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryLine value);
        partial void OnBudgetRegisterEntryLineEntryHeaderChanged();
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
