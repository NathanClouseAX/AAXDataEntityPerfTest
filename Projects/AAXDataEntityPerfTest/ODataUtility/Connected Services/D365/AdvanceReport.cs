﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/3/2021 8:21:45 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for AdvanceReportSingle in the schema.
        /// </summary>
    public partial class AdvanceReportSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AdvanceReport>
    {
        /// <summary>
        /// Initialize a new AdvanceReportSingle object.
        /// </summary>
        public AdvanceReportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AdvanceReportSingle object.
        /// </summary>
        public AdvanceReportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AdvanceReportSingle object.
        /// </summary>
        public AdvanceReportSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AdvanceReport> query)
            : base(query) {}

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
        /// There are no comments for AdvanceReport in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// AdvanceReportId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AdvanceReportId")]
    [global::Microsoft.OData.Client.EntitySet("AdvanceReports")]
    public partial class AdvanceReport : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AdvanceReport object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="advanceReportId">Initial value of AdvanceReportId.</param>
        /// <param name="transactionDate">Initial value of TransactionDate.</param>
        /// <param name="checkingDate">Initial value of CheckingDate.</param>
        /// <param name="firmingDate">Initial value of FirmingDate.</param>
        /// <param name="amount">Initial value of Amount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AdvanceReport CreateAdvanceReport(string dataAreaId, 
                    string advanceReportId, 
                    global::System.DateTimeOffset transactionDate, 
                    global::System.DateTimeOffset checkingDate, 
                    global::System.DateTimeOffset firmingDate, 
                    decimal amount)
        {
            AdvanceReport advanceReport = new AdvanceReport();
            advanceReport.dataAreaId = dataAreaId;
            advanceReport.AdvanceReportId = advanceReportId;
            advanceReport.TransactionDate = transactionDate;
            advanceReport.CheckingDate = checkingDate;
            advanceReport.FirmingDate = firmingDate;
            advanceReport.Amount = amount;
            return advanceReport;
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
        /// There are no comments for Property AdvanceReportId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AdvanceReportId
        {
            get
            {
                return this._AdvanceReportId;
            }
            set
            {
                this.OnAdvanceReportIdChanging(value);
                this._AdvanceReportId = value;
                this.OnAdvanceReportIdChanged();
                this.OnPropertyChanged("AdvanceReportId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdvanceReportId;
        partial void OnAdvanceReportIdChanging(string value);
        partial void OnAdvanceReportIdChanged();
        /// <summary>
        /// There are no comments for Property TransactionDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset TransactionDate
        {
            get
            {
                return this._TransactionDate;
            }
            set
            {
                this.OnTransactionDateChanging(value);
                this._TransactionDate = value;
                this.OnTransactionDateChanged();
                this.OnPropertyChanged("TransactionDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TransactionDate;
        partial void OnTransactionDateChanging(global::System.DateTimeOffset value);
        partial void OnTransactionDateChanged();
        /// <summary>
        /// There are no comments for Property IsFullyFactured in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsFullyFactured
        {
            get
            {
                return this._IsFullyFactured;
            }
            set
            {
                this.OnIsFullyFacturedChanging(value);
                this._IsFullyFactured = value;
                this.OnIsFullyFacturedChanged();
                this.OnPropertyChanged("IsFullyFactured");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsFullyFactured;
        partial void OnIsFullyFacturedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsFullyFacturedChanged();
        /// <summary>
        /// There are no comments for Property DimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionDisplayValue
        {
            get
            {
                return this._DimensionDisplayValue;
            }
            set
            {
                this.OnDimensionDisplayValueChanging(value);
                this._DimensionDisplayValue = value;
                this.OnDimensionDisplayValueChanged();
                this.OnPropertyChanged("DimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionDisplayValue;
        partial void OnDimensionDisplayValueChanging(string value);
        partial void OnDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property AdvancePurpose in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AdvancePurpose
        {
            get
            {
                return this._AdvancePurpose;
            }
            set
            {
                this.OnAdvancePurposeChanging(value);
                this._AdvancePurpose = value;
                this.OnAdvancePurposeChanged();
                this.OnPropertyChanged("AdvancePurpose");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdvancePurpose;
        partial void OnAdvancePurposeChanging(string value);
        partial void OnAdvancePurposeChanged();
        /// <summary>
        /// There are no comments for Property CheckingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset CheckingDate
        {
            get
            {
                return this._CheckingDate;
            }
            set
            {
                this.OnCheckingDateChanging(value);
                this._CheckingDate = value;
                this.OnCheckingDateChanged();
                this.OnPropertyChanged("CheckingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CheckingDate;
        partial void OnCheckingDateChanging(global::System.DateTimeOffset value);
        partial void OnCheckingDateChanged();
        /// <summary>
        /// There are no comments for Property FirmingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset FirmingDate
        {
            get
            {
                return this._FirmingDate;
            }
            set
            {
                this.OnFirmingDateChanging(value);
                this._FirmingDate = value;
                this.OnFirmingDateChanged();
                this.OnPropertyChanged("FirmingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _FirmingDate;
        partial void OnFirmingDateChanging(global::System.DateTimeOffset value);
        partial void OnFirmingDateChanged();
        /// <summary>
        /// There are no comments for Property AdvanceStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EmplAdvStatus_RU> AdvanceStatus
        {
            get
            {
                return this._AdvanceStatus;
            }
            set
            {
                this.OnAdvanceStatusChanging(value);
                this._AdvanceStatus = value;
                this.OnAdvanceStatusChanged();
                this.OnPropertyChanged("AdvanceStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EmplAdvStatus_RU> _AdvanceStatus;
        partial void OnAdvanceStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EmplAdvStatus_RU> value);
        partial void OnAdvanceStatusChanged();
        /// <summary>
        /// There are no comments for Property PostingProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PostingProfile
        {
            get
            {
                return this._PostingProfile;
            }
            set
            {
                this.OnPostingProfileChanging(value);
                this._PostingProfile = value;
                this.OnPostingProfileChanged();
                this.OnPropertyChanged("PostingProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PostingProfile;
        partial void OnPostingProfileChanging(string value);
        partial void OnPostingProfileChanged();
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Amount;
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
        /// <summary>
        /// There are no comments for Property AdvanceHolder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AdvanceHolder
        {
            get
            {
                return this._AdvanceHolder;
            }
            set
            {
                this.OnAdvanceHolderChanging(value);
                this._AdvanceHolder = value;
                this.OnAdvanceHolderChanged();
                this.OnPropertyChanged("AdvanceHolder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdvanceHolder;
        partial void OnAdvanceHolderChanging(string value);
        partial void OnAdvanceHolderChanged();
        /// <summary>
        /// There are no comments for Property OfficialSession in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OfficialSession
        {
            get
            {
                return this._OfficialSession;
            }
            set
            {
                this.OnOfficialSessionChanging(value);
                this._OfficialSession = value;
                this.OnOfficialSessionChanged();
                this.OnPropertyChanged("OfficialSession");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OfficialSession;
        partial void OnOfficialSessionChanging(string value);
        partial void OnOfficialSessionChanged();
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
