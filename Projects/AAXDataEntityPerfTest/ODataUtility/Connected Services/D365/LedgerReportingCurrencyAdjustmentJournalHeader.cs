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
        /// There are no comments for LedgerReportingCurrencyAdjustmentJournalHeaderSingle in the schema.
        /// </summary>
    public partial class LedgerReportingCurrencyAdjustmentJournalHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerReportingCurrencyAdjustmentJournalHeader>
    {
        /// <summary>
        /// Initialize a new LedgerReportingCurrencyAdjustmentJournalHeaderSingle object.
        /// </summary>
        public LedgerReportingCurrencyAdjustmentJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LedgerReportingCurrencyAdjustmentJournalHeaderSingle object.
        /// </summary>
        public LedgerReportingCurrencyAdjustmentJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LedgerReportingCurrencyAdjustmentJournalHeaderSingle object.
        /// </summary>
        public LedgerReportingCurrencyAdjustmentJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerReportingCurrencyAdjustmentJournalHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntitySingle LegalEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LegalEntity == null))
                {
                    this._LegalEntity = new global::Microsoft.Dynamics.DataEntities.LegalEntitySingle(this.Context, GetPath("LegalEntity"));
                }
                return this._LegalEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntitySingle _LegalEntity;
        /// <summary>
        /// There are no comments for LedgerReportingCurrencyAdjustmentJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerReportingCurrencyAdjustmentJournalLine> LedgerReportingCurrencyAdjustmentJournalLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerReportingCurrencyAdjustmentJournalLine == null))
                {
                    this._LedgerReportingCurrencyAdjustmentJournalLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LedgerReportingCurrencyAdjustmentJournalLine>(GetPath("LedgerReportingCurrencyAdjustmentJournalLine"));
                }
                return this._LedgerReportingCurrencyAdjustmentJournalLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerReportingCurrencyAdjustmentJournalLine> _LedgerReportingCurrencyAdjustmentJournalLine;
    }
        /// <summary>
        /// There are no comments for LedgerReportingCurrencyAdjustmentJournalHeader in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// JournalBatchNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JournalBatchNumber")]
    [global::Microsoft.OData.Client.EntitySet("LedgerReportingCurrencyAdjustmentJournalHeaders")]
    public partial class LedgerReportingCurrencyAdjustmentJournalHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LedgerReportingCurrencyAdjustmentJournalHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="journalBatchNumber">Initial value of JournalBatchNumber.</param>
        /// <param name="journalTotalDebitReportingCurrency">Initial value of JournalTotalDebitReportingCurrency.</param>
        /// <param name="journalTotalCreditReportingCurrency">Initial value of JournalTotalCreditReportingCurrency.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LedgerReportingCurrencyAdjustmentJournalHeader CreateLedgerReportingCurrencyAdjustmentJournalHeader(string dataAreaId, string journalBatchNumber, decimal journalTotalDebitReportingCurrency, decimal journalTotalCreditReportingCurrency)
        {
            LedgerReportingCurrencyAdjustmentJournalHeader ledgerReportingCurrencyAdjustmentJournalHeader = new LedgerReportingCurrencyAdjustmentJournalHeader();
            ledgerReportingCurrencyAdjustmentJournalHeader.dataAreaId = dataAreaId;
            ledgerReportingCurrencyAdjustmentJournalHeader.JournalBatchNumber = journalBatchNumber;
            ledgerReportingCurrencyAdjustmentJournalHeader.JournalTotalDebitReportingCurrency = journalTotalDebitReportingCurrency;
            ledgerReportingCurrencyAdjustmentJournalHeader.JournalTotalCreditReportingCurrency = journalTotalCreditReportingCurrency;
            return ledgerReportingCurrencyAdjustmentJournalHeader;
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
        /// There are no comments for Property JournalBatchNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalBatchNumber
        {
            get
            {
                return this._JournalBatchNumber;
            }
            set
            {
                this.OnJournalBatchNumberChanging(value);
                this._JournalBatchNumber = value;
                this.OnJournalBatchNumberChanged();
                this.OnPropertyChanged("JournalBatchNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalBatchNumber;
        partial void OnJournalBatchNumberChanging(string value);
        partial void OnJournalBatchNumberChanged();
        /// <summary>
        /// There are no comments for Property ReportingCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReportingCurrency
        {
            get
            {
                return this._ReportingCurrency;
            }
            set
            {
                this.OnReportingCurrencyChanging(value);
                this._ReportingCurrency = value;
                this.OnReportingCurrencyChanged();
                this.OnPropertyChanged("ReportingCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReportingCurrency;
        partial void OnReportingCurrencyChanging(string value);
        partial void OnReportingCurrencyChanged();
        /// <summary>
        /// There are no comments for Property JournalTotalDebitReportingCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal JournalTotalDebitReportingCurrency
        {
            get
            {
                return this._JournalTotalDebitReportingCurrency;
            }
            set
            {
                this.OnJournalTotalDebitReportingCurrencyChanging(value);
                this._JournalTotalDebitReportingCurrency = value;
                this.OnJournalTotalDebitReportingCurrencyChanged();
                this.OnPropertyChanged("JournalTotalDebitReportingCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _JournalTotalDebitReportingCurrency;
        partial void OnJournalTotalDebitReportingCurrencyChanging(decimal value);
        partial void OnJournalTotalDebitReportingCurrencyChanged();
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
        /// There are no comments for Property PostingLayer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> PostingLayer
        {
            get
            {
                return this._PostingLayer;
            }
            set
            {
                this.OnPostingLayerChanging(value);
                this._PostingLayer = value;
                this.OnPostingLayerChanged();
                this.OnPropertyChanged("PostingLayer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> _PostingLayer;
        partial void OnPostingLayerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> value);
        partial void OnPostingLayerChanged();
        /// <summary>
        /// There are no comments for Property IsPosted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPosted
        {
            get
            {
                return this._IsPosted;
            }
            set
            {
                this.OnIsPostedChanging(value);
                this._IsPosted = value;
                this.OnIsPostedChanged();
                this.OnPropertyChanged("IsPosted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPosted;
        partial void OnIsPostedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPostedChanged();
        /// <summary>
        /// There are no comments for Property JournalTotalCreditReportingCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal JournalTotalCreditReportingCurrency
        {
            get
            {
                return this._JournalTotalCreditReportingCurrency;
            }
            set
            {
                this.OnJournalTotalCreditReportingCurrencyChanging(value);
                this._JournalTotalCreditReportingCurrency = value;
                this.OnJournalTotalCreditReportingCurrencyChanged();
                this.OnPropertyChanged("JournalTotalCreditReportingCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _JournalTotalCreditReportingCurrency;
        partial void OnJournalTotalCreditReportingCurrencyChanging(decimal value);
        partial void OnJournalTotalCreditReportingCurrencyChanged();
        /// <summary>
        /// There are no comments for Property LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntity LegalEntity
        {
            get
            {
                return this._LegalEntity;
            }
            set
            {
                this.OnLegalEntityChanging(value);
                this._LegalEntity = value;
                this.OnLegalEntityChanged();
                this.OnPropertyChanged("LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntity _LegalEntity;
        partial void OnLegalEntityChanging(global::Microsoft.Dynamics.DataEntities.LegalEntity value);
        partial void OnLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property LedgerReportingCurrencyAdjustmentJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerReportingCurrencyAdjustmentJournalLine> LedgerReportingCurrencyAdjustmentJournalLine
        {
            get
            {
                return this._LedgerReportingCurrencyAdjustmentJournalLine;
            }
            set
            {
                this.OnLedgerReportingCurrencyAdjustmentJournalLineChanging(value);
                this._LedgerReportingCurrencyAdjustmentJournalLine = value;
                this.OnLedgerReportingCurrencyAdjustmentJournalLineChanged();
                this.OnPropertyChanged("LedgerReportingCurrencyAdjustmentJournalLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerReportingCurrencyAdjustmentJournalLine> _LedgerReportingCurrencyAdjustmentJournalLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerReportingCurrencyAdjustmentJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLedgerReportingCurrencyAdjustmentJournalLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerReportingCurrencyAdjustmentJournalLine> value);
        partial void OnLedgerReportingCurrencyAdjustmentJournalLineChanged();
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
