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
        /// There are no comments for LedgerFinancialReasonSingle in the schema.
        /// </summary>
    public partial class LedgerFinancialReasonSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerFinancialReason>
    {
        /// <summary>
        /// Initialize a new LedgerFinancialReasonSingle object.
        /// </summary>
        public LedgerFinancialReasonSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LedgerFinancialReasonSingle object.
        /// </summary>
        public LedgerFinancialReasonSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LedgerFinancialReasonSingle object.
        /// </summary>
        public LedgerFinancialReasonSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerFinancialReason> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetCode> BudgetCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetCode == null))
                {
                    this._BudgetCode = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetCode>(GetPath("BudgetCode"));
                }
                return this._BudgetCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetCode> _BudgetCode;
    }
        /// <summary>
        /// There are no comments for LedgerFinancialReason in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ReasonCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ReasonCode")]
    [global::Microsoft.OData.Client.EntitySet("LedgerFinancialReasons")]
    public partial class LedgerFinancialReason : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LedgerFinancialReason object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="reasonCode">Initial value of ReasonCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LedgerFinancialReason CreateLedgerFinancialReason(string dataAreaId, string reasonCode)
        {
            LedgerFinancialReason ledgerFinancialReason = new LedgerFinancialReason();
            ledgerFinancialReason.dataAreaId = dataAreaId;
            ledgerFinancialReason.ReasonCode = reasonCode;
            return ledgerFinancialReason;
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
        /// There are no comments for Property ForRAssetTransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ForRAssetTransactionType
        {
            get
            {
                return this._ForRAssetTransactionType;
            }
            set
            {
                this.OnForRAssetTransactionTypeChanging(value);
                this._ForRAssetTransactionType = value;
                this.OnForRAssetTransactionTypeChanged();
                this.OnPropertyChanged("ForRAssetTransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ForRAssetTransactionType;
        partial void OnForRAssetTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnForRAssetTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property PurposeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PurposeCode
        {
            get
            {
                return this._PurposeCode;
            }
            set
            {
                this.OnPurposeCodeChanging(value);
                this._PurposeCode = value;
                this.OnPurposeCodeChanged();
                this.OnPropertyChanged("PurposeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PurposeCode;
        partial void OnPurposeCodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPurposeCodeChanged();
        /// <summary>
        /// There are no comments for Property ForLedgerTransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ForLedgerTransactionType
        {
            get
            {
                return this._ForLedgerTransactionType;
            }
            set
            {
                this.OnForLedgerTransactionTypeChanging(value);
                this._ForLedgerTransactionType = value;
                this.OnForLedgerTransactionTypeChanged();
                this.OnPropertyChanged("ForLedgerTransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ForLedgerTransactionType;
        partial void OnForLedgerTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnForLedgerTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property ForAssetTransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ForAssetTransactionType
        {
            get
            {
                return this._ForAssetTransactionType;
            }
            set
            {
                this.OnForAssetTransactionTypeChanging(value);
                this._ForAssetTransactionType = value;
                this.OnForAssetTransactionTypeChanged();
                this.OnPropertyChanged("ForAssetTransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ForAssetTransactionType;
        partial void OnForAssetTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnForAssetTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property ForVendorTransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ForVendorTransactionType
        {
            get
            {
                return this._ForVendorTransactionType;
            }
            set
            {
                this.OnForVendorTransactionTypeChanging(value);
                this._ForVendorTransactionType = value;
                this.OnForVendorTransactionTypeChanged();
                this.OnPropertyChanged("ForVendorTransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ForVendorTransactionType;
        partial void OnForVendorTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnForVendorTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property ForCustomerTransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ForCustomerTransactionType
        {
            get
            {
                return this._ForCustomerTransactionType;
            }
            set
            {
                this.OnForCustomerTransactionTypeChanging(value);
                this._ForCustomerTransactionType = value;
                this.OnForCustomerTransactionTypeChanged();
                this.OnPropertyChanged("ForCustomerTransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ForCustomerTransactionType;
        partial void OnForCustomerTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnForCustomerTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property DefaultComment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultComment
        {
            get
            {
                return this._DefaultComment;
            }
            set
            {
                this.OnDefaultCommentChanging(value);
                this._DefaultComment = value;
                this.OnDefaultCommentChanged();
                this.OnPropertyChanged("DefaultComment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultComment;
        partial void OnDefaultCommentChanging(string value);
        partial void OnDefaultCommentChanged();
        /// <summary>
        /// There are no comments for Property CancellationReason in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CancellationReason
        {
            get
            {
                return this._CancellationReason;
            }
            set
            {
                this.OnCancellationReasonChanging(value);
                this._CancellationReason = value;
                this.OnCancellationReasonChanged();
                this.OnPropertyChanged("CancellationReason");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CancellationReason;
        partial void OnCancellationReasonChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCancellationReasonChanged();
        /// <summary>
        /// There are no comments for Property ForBankTransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ForBankTransactionType
        {
            get
            {
                return this._ForBankTransactionType;
            }
            set
            {
                this.OnForBankTransactionTypeChanging(value);
                this._ForBankTransactionType = value;
                this.OnForBankTransactionTypeChanged();
                this.OnPropertyChanged("ForBankTransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ForBankTransactionType;
        partial void OnForBankTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnForBankTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property ForRCashTransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ForRCashTransactionType
        {
            get
            {
                return this._ForRCashTransactionType;
            }
            set
            {
                this.OnForRCashTransactionTypeChanging(value);
                this._ForRCashTransactionType = value;
                this.OnForRCashTransactionTypeChanged();
                this.OnPropertyChanged("ForRCashTransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ForRCashTransactionType;
        partial void OnForRCashTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnForRCashTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property BudgetCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetCode> BudgetCode
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
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetCode> _BudgetCode = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetCodeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetCode> value);
        partial void OnBudgetCodeChanged();
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
