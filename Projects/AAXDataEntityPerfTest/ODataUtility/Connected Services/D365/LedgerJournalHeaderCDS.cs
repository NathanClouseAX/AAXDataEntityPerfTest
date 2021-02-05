﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for LedgerJournalHeaderCDSSingle in the schema.
        /// </summary>
    public partial class LedgerJournalHeaderCDSSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerJournalHeaderCDS>
    {
        /// <summary>
        /// Initialize a new LedgerJournalHeaderCDSSingle object.
        /// </summary>
        public LedgerJournalHeaderCDSSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LedgerJournalHeaderCDSSingle object.
        /// </summary>
        public LedgerJournalHeaderCDSSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LedgerJournalHeaderCDSSingle object.
        /// </summary>
        public LedgerJournalHeaderCDSSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerJournalHeaderCDS> query)
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
        /// There are no comments for LedgerJournalCDSLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> LedgerJournalCDSLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerJournalCDSLine == null))
                {
                    this._LedgerJournalCDSLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine>(GetPath("LedgerJournalCDSLine"));
                }
                return this._LedgerJournalCDSLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> _LedgerJournalCDSLine;
    }
        /// <summary>
        /// There are no comments for LedgerJournalHeaderCDS in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// IntegrationComputedKey
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "IntegrationComputedKey")]
    [global::Microsoft.OData.Client.EntitySet("LedgerJournalHeadersCDS")]
    public partial class LedgerJournalHeaderCDS : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LedgerJournalHeaderCDS object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="integrationComputedKey">Initial value of IntegrationComputedKey.</param>
        /// <param name="journalTotalCredit">Initial value of JournalTotalCredit.</param>
        /// <param name="journalTotalDebit">Initial value of JournalTotalDebit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LedgerJournalHeaderCDS CreateLedgerJournalHeaderCDS(string dataAreaId, string integrationComputedKey, decimal journalTotalCredit, decimal journalTotalDebit)
        {
            LedgerJournalHeaderCDS ledgerJournalHeaderCDS = new LedgerJournalHeaderCDS();
            ledgerJournalHeaderCDS.dataAreaId = dataAreaId;
            ledgerJournalHeaderCDS.IntegrationComputedKey = integrationComputedKey;
            ledgerJournalHeaderCDS.JournalTotalCredit = journalTotalCredit;
            ledgerJournalHeaderCDS.JournalTotalDebit = journalTotalDebit;
            return ledgerJournalHeaderCDS;
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
        /// There are no comments for Property IntegrationComputedKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IntegrationComputedKey
        {
            get
            {
                return this._IntegrationComputedKey;
            }
            set
            {
                this.OnIntegrationComputedKeyChanging(value);
                this._IntegrationComputedKey = value;
                this.OnIntegrationComputedKeyChanged();
                this.OnPropertyChanged("IntegrationComputedKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IntegrationComputedKey;
        partial void OnIntegrationComputedKeyChanging(string value);
        partial void OnIntegrationComputedKeyChanged();
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
        /// There are no comments for Property IntegrationKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IntegrationKey
        {
            get
            {
                return this._IntegrationKey;
            }
            set
            {
                this.OnIntegrationKeyChanging(value);
                this._IntegrationKey = value;
                this.OnIntegrationKeyChanged();
                this.OnPropertyChanged("IntegrationKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IntegrationKey;
        partial void OnIntegrationKeyChanging(string value);
        partial void OnIntegrationKeyChanged();
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
        /// There are no comments for Property JournalTotalCredit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal JournalTotalCredit
        {
            get
            {
                return this._JournalTotalCredit;
            }
            set
            {
                this.OnJournalTotalCreditChanging(value);
                this._JournalTotalCredit = value;
                this.OnJournalTotalCreditChanged();
                this.OnPropertyChanged("JournalTotalCredit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _JournalTotalCredit;
        partial void OnJournalTotalCreditChanging(decimal value);
        partial void OnJournalTotalCreditChanged();
        /// <summary>
        /// There are no comments for Property JournalTotalDebit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal JournalTotalDebit
        {
            get
            {
                return this._JournalTotalDebit;
            }
            set
            {
                this.OnJournalTotalDebitChanging(value);
                this._JournalTotalDebit = value;
                this.OnJournalTotalDebitChanged();
                this.OnPropertyChanged("JournalTotalDebit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _JournalTotalDebit;
        partial void OnJournalTotalDebitChanging(decimal value);
        partial void OnJournalTotalDebitChanged();
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
        /// There are no comments for Property LedgerJournalCDSLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> LedgerJournalCDSLine
        {
            get
            {
                return this._LedgerJournalCDSLine;
            }
            set
            {
                this.OnLedgerJournalCDSLineChanging(value);
                this._LedgerJournalCDSLine = value;
                this.OnLedgerJournalCDSLineChanged();
                this.OnPropertyChanged("LedgerJournalCDSLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> _LedgerJournalCDSLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLedgerJournalCDSLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> value);
        partial void OnLedgerJournalCDSLineChanged();
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
