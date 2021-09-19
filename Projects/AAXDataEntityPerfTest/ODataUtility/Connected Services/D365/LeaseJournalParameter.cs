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
        /// There are no comments for LeaseJournalParameterSingle in the schema.
        /// </summary>
    public partial class LeaseJournalParameterSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LeaseJournalParameter>
    {
        /// <summary>
        /// Initialize a new LeaseJournalParameterSingle object.
        /// </summary>
        public LeaseJournalParameterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeaseJournalParameterSingle object.
        /// </summary>
        public LeaseJournalParameterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeaseJournalParameterSingle object.
        /// </summary>
        public LeaseJournalParameterSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LeaseJournalParameter> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for LeaseJournalParameter in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// InitialRecognitionJournalName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "InitialRecognitionJournalName")]
    [global::Microsoft.OData.Client.EntitySet("LeaseJournalParameters")]
    public partial class LeaseJournalParameter : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeaseJournalParameter object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="initialRecognitionJournalName">Initial value of InitialRecognitionJournalName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeaseJournalParameter CreateLeaseJournalParameter(string dataAreaId, string initialRecognitionJournalName)
        {
            LeaseJournalParameter leaseJournalParameter = new LeaseJournalParameter();
            leaseJournalParameter.dataAreaId = dataAreaId;
            leaseJournalParameter.InitialRecognitionJournalName = initialRecognitionJournalName;
            return leaseJournalParameter;
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
        /// There are no comments for Property InitialRecognitionJournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InitialRecognitionJournalName
        {
            get
            {
                return this._InitialRecognitionJournalName;
            }
            set
            {
                this.OnInitialRecognitionJournalNameChanging(value);
                this._InitialRecognitionJournalName = value;
                this.OnInitialRecognitionJournalNameChanged();
                this.OnPropertyChanged("InitialRecognitionJournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InitialRecognitionJournalName;
        partial void OnInitialRecognitionJournalNameChanging(string value);
        partial void OnInitialRecognitionJournalNameChanged();
        /// <summary>
        /// There are no comments for Property OverrideLeaseType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> OverrideLeaseType
        {
            get
            {
                return this._OverrideLeaseType;
            }
            set
            {
                this.OnOverrideLeaseTypeChanging(value);
                this._OverrideLeaseType = value;
                this.OnOverrideLeaseTypeChanged();
                this.OnPropertyChanged("OverrideLeaseType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _OverrideLeaseType;
        partial void OnOverrideLeaseTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnOverrideLeaseTypeChanged();
        /// <summary>
        /// There are no comments for Property CrossEntityBatch in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CrossEntityBatch
        {
            get
            {
                return this._CrossEntityBatch;
            }
            set
            {
                this.OnCrossEntityBatchChanging(value);
                this._CrossEntityBatch = value;
                this.OnCrossEntityBatchChanged();
                this.OnPropertyChanged("CrossEntityBatch");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CrossEntityBatch;
        partial void OnCrossEntityBatchChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCrossEntityBatchChanged();
        /// <summary>
        /// There are no comments for Property AllowConfirmedLeaseDeletion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowConfirmedLeaseDeletion
        {
            get
            {
                return this._AllowConfirmedLeaseDeletion;
            }
            set
            {
                this.OnAllowConfirmedLeaseDeletionChanging(value);
                this._AllowConfirmedLeaseDeletion = value;
                this.OnAllowConfirmedLeaseDeletionChanged();
                this.OnPropertyChanged("AllowConfirmedLeaseDeletion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowConfirmedLeaseDeletion;
        partial void OnAllowConfirmedLeaseDeletionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowConfirmedLeaseDeletionChanged();
        /// <summary>
        /// There are no comments for Property Company in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                this.OnCompanyChanging(value);
                this._Company = value;
                this.OnCompanyChanged();
                this.OnPropertyChanged("Company");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Company;
        partial void OnCompanyChanging(string value);
        partial void OnCompanyChanged();
        /// <summary>
        /// There are no comments for Property MonthlyJournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MonthlyJournalName
        {
            get
            {
                return this._MonthlyJournalName;
            }
            set
            {
                this.OnMonthlyJournalNameChanging(value);
                this._MonthlyJournalName = value;
                this.OnMonthlyJournalNameChanged();
                this.OnPropertyChanged("MonthlyJournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MonthlyJournalName;
        partial void OnMonthlyJournalNameChanging(string value);
        partial void OnMonthlyJournalNameChanged();
        /// <summary>
        /// There are no comments for Property VoucherTypeMnthJourNameCN in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VoucherTypeMnthJourNameCN
        {
            get
            {
                return this._VoucherTypeMnthJourNameCN;
            }
            set
            {
                this.OnVoucherTypeMnthJourNameCNChanging(value);
                this._VoucherTypeMnthJourNameCN = value;
                this.OnVoucherTypeMnthJourNameCNChanged();
                this.OnPropertyChanged("VoucherTypeMnthJourNameCN");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VoucherTypeMnthJourNameCN;
        partial void OnVoucherTypeMnthJourNameCNChanging(string value);
        partial void OnVoucherTypeMnthJourNameCNChanged();
        /// <summary>
        /// There are no comments for Property InvoiceJournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InvoiceJournalName
        {
            get
            {
                return this._InvoiceJournalName;
            }
            set
            {
                this.OnInvoiceJournalNameChanging(value);
                this._InvoiceJournalName = value;
                this.OnInvoiceJournalNameChanged();
                this.OnPropertyChanged("InvoiceJournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceJournalName;
        partial void OnInvoiceJournalNameChanging(string value);
        partial void OnInvoiceJournalNameChanged();
        /// <summary>
        /// There are no comments for Property VoucherTypeInitRecoNameCN in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VoucherTypeInitRecoNameCN
        {
            get
            {
                return this._VoucherTypeInitRecoNameCN;
            }
            set
            {
                this.OnVoucherTypeInitRecoNameCNChanging(value);
                this._VoucherTypeInitRecoNameCN = value;
                this.OnVoucherTypeInitRecoNameCNChanged();
                this.OnPropertyChanged("VoucherTypeInitRecoNameCN");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VoucherTypeInitRecoNameCN;
        partial void OnVoucherTypeInitRecoNameCNChanging(string value);
        partial void OnVoucherTypeInitRecoNameCNChanged();
        /// <summary>
        /// There are no comments for Property VoucherTypeInvJourNameCN in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VoucherTypeInvJourNameCN
        {
            get
            {
                return this._VoucherTypeInvJourNameCN;
            }
            set
            {
                this.OnVoucherTypeInvJourNameCNChanging(value);
                this._VoucherTypeInvJourNameCN = value;
                this.OnVoucherTypeInvJourNameCNChanged();
                this.OnPropertyChanged("VoucherTypeInvJourNameCN");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VoucherTypeInvJourNameCN;
        partial void OnVoucherTypeInvJourNameCNChanging(string value);
        partial void OnVoucherTypeInvJourNameCNChanged();
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