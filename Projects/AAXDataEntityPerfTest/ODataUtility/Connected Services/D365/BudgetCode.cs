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
        /// There are no comments for BudgetCodeSingle in the schema.
        /// </summary>
    public partial class BudgetCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetCode>
    {
        /// <summary>
        /// Initialize a new BudgetCodeSingle object.
        /// </summary>
        public BudgetCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetCodeSingle object.
        /// </summary>
        public BudgetCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetCodeSingle object.
        /// </summary>
        public BudgetCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetCode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LedgerFinancialReason in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LedgerFinancialReasonSingle LedgerFinancialReason
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerFinancialReason == null))
                {
                    this._LedgerFinancialReason = new global::Microsoft.Dynamics.DataEntities.LedgerFinancialReasonSingle(this.Context, GetPath("LedgerFinancialReason"));
                }
                return this._LedgerFinancialReason;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LedgerFinancialReasonSingle _LedgerFinancialReason;
        /// <summary>
        /// There are no comments for BudgetRegisterEntryBudgetCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntrySingle BudgetRegisterEntryBudgetCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetRegisterEntryBudgetCode == null))
                {
                    this._BudgetRegisterEntryBudgetCode = new global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntrySingle(this.Context, GetPath("BudgetRegisterEntryBudgetCode"));
                }
                return this._BudgetRegisterEntryBudgetCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntrySingle _BudgetRegisterEntryBudgetCode;
        /// <summary>
        /// There are no comments for BudgetRegisterEntryHeaderBudgetCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryHeaderSingle BudgetRegisterEntryHeaderBudgetCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetRegisterEntryHeaderBudgetCode == null))
                {
                    this._BudgetRegisterEntryHeaderBudgetCode = new global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryHeaderSingle(this.Context, GetPath("BudgetRegisterEntryHeaderBudgetCode"));
                }
                return this._BudgetRegisterEntryHeaderBudgetCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryHeaderSingle _BudgetRegisterEntryHeaderBudgetCode;
    }
        /// <summary>
        /// There are no comments for BudgetCode in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// BudgetCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "BudgetCode")]
    [global::Microsoft.OData.Client.EntitySet("BudgetCodes")]
    public partial class BudgetCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetCode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="budgetCode1">Initial value of BudgetCode1.</param>
        /// <param name="budgetRegisterEntryBudgetCode">Initial value of BudgetRegisterEntryBudgetCode.</param>
        /// <param name="budgetRegisterEntryHeaderBudgetCode">Initial value of BudgetRegisterEntryHeaderBudgetCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetCode CreateBudgetCode(string dataAreaId, string budgetCode1, global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntry budgetRegisterEntryBudgetCode, global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryHeader budgetRegisterEntryHeaderBudgetCode)
        {
            BudgetCode budgetCode = new BudgetCode();
            budgetCode.dataAreaId = dataAreaId;
            budgetCode.BudgetCode1 = budgetCode1;
            if ((budgetRegisterEntryBudgetCode == null))
            {
                throw new global::System.ArgumentNullException("budgetRegisterEntryBudgetCode");
            }
            budgetCode.BudgetRegisterEntryBudgetCode = budgetRegisterEntryBudgetCode;
            if ((budgetRegisterEntryHeaderBudgetCode == null))
            {
                throw new global::System.ArgumentNullException("budgetRegisterEntryHeaderBudgetCode");
            }
            budgetCode.BudgetRegisterEntryHeaderBudgetCode = budgetRegisterEntryHeaderBudgetCode;
            return budgetCode;
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
        /// There are no comments for Property BudgetCode1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetCode")]
        public virtual string BudgetCode1
        {
            get
            {
                return this._BudgetCode1;
            }
            set
            {
                this.OnBudgetCode1Changing(value);
                this._BudgetCode1 = value;
                this.OnBudgetCode1Changed();
                this.OnPropertyChanged("BudgetCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetCode1;
        partial void OnBudgetCode1Changing(string value);
        partial void OnBudgetCode1Changed();
        /// <summary>
        /// There are no comments for Property WorkflowId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkflowId
        {
            get
            {
                return this._WorkflowId;
            }
            set
            {
                this.OnWorkflowIdChanging(value);
                this._WorkflowId = value;
                this.OnWorkflowIdChanged();
                this.OnPropertyChanged("WorkflowId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkflowId;
        partial void OnWorkflowIdChanging(string value);
        partial void OnWorkflowIdChanged();
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
        /// There are no comments for Property IsDefaultCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefaultCode
        {
            get
            {
                return this._IsDefaultCode;
            }
            set
            {
                this.OnIsDefaultCodeChanging(value);
                this._IsDefaultCode = value;
                this.OnIsDefaultCodeChanged();
                this.OnPropertyChanged("IsDefaultCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefaultCode;
        partial void OnIsDefaultCodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultCodeChanged();
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
        /// There are no comments for Property LedgerFinancialReason in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LedgerFinancialReason LedgerFinancialReason
        {
            get
            {
                return this._LedgerFinancialReason;
            }
            set
            {
                this.OnLedgerFinancialReasonChanging(value);
                this._LedgerFinancialReason = value;
                this.OnLedgerFinancialReasonChanged();
                this.OnPropertyChanged("LedgerFinancialReason");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LedgerFinancialReason _LedgerFinancialReason;
        partial void OnLedgerFinancialReasonChanging(global::Microsoft.Dynamics.DataEntities.LedgerFinancialReason value);
        partial void OnLedgerFinancialReasonChanged();
        /// <summary>
        /// There are no comments for Property BudgetRegisterEntryBudgetCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntry BudgetRegisterEntryBudgetCode
        {
            get
            {
                return this._BudgetRegisterEntryBudgetCode;
            }
            set
            {
                this.OnBudgetRegisterEntryBudgetCodeChanging(value);
                this._BudgetRegisterEntryBudgetCode = value;
                this.OnBudgetRegisterEntryBudgetCodeChanged();
                this.OnPropertyChanged("BudgetRegisterEntryBudgetCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntry _BudgetRegisterEntryBudgetCode;
        partial void OnBudgetRegisterEntryBudgetCodeChanging(global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntry value);
        partial void OnBudgetRegisterEntryBudgetCodeChanged();
        /// <summary>
        /// There are no comments for Property BudgetRegisterEntryHeaderBudgetCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryHeader BudgetRegisterEntryHeaderBudgetCode
        {
            get
            {
                return this._BudgetRegisterEntryHeaderBudgetCode;
            }
            set
            {
                this.OnBudgetRegisterEntryHeaderBudgetCodeChanging(value);
                this._BudgetRegisterEntryHeaderBudgetCode = value;
                this.OnBudgetRegisterEntryHeaderBudgetCodeChanged();
                this.OnPropertyChanged("BudgetRegisterEntryHeaderBudgetCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryHeader _BudgetRegisterEntryHeaderBudgetCode;
        partial void OnBudgetRegisterEntryHeaderBudgetCodeChanging(global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryHeader value);
        partial void OnBudgetRegisterEntryHeaderBudgetCodeChanged();
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
