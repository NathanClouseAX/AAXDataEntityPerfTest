﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 12/8/2020 7:45:22 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for CodaDefinitionSingle in the schema.
        /// </summary>
    public partial class CodaDefinitionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CodaDefinition>
    {
        /// <summary>
        /// Initialize a new CodaDefinitionSingle object.
        /// </summary>
        public CodaDefinitionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CodaDefinitionSingle object.
        /// </summary>
        public CodaDefinitionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CodaDefinitionSingle object.
        /// </summary>
        public CodaDefinitionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CodaDefinition> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
    }
        /// <summary>
        /// There are no comments for CodaDefinition in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// BankAccount
    /// TransactionGroup
    /// Transaction
    /// TransactionCategory
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "BankAccount", "TransactionGroup", "Transaction", "TransactionCategory")]
    [global::Microsoft.OData.Client.EntitySet("CodaDefinitions")]
    public partial class CodaDefinition : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CodaDefinition object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="bankAccount">Initial value of BankAccount.</param>
        /// <param name="transactionGroup">Initial value of TransactionGroup.</param>
        /// <param name="transaction">Initial value of Transaction.</param>
        /// <param name="transactionCategory">Initial value of TransactionCategory.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CodaDefinition CreateCodaDefinition(string dataAreaId, string bankAccount, string transactionGroup, string transaction, string transactionCategory)
        {
            CodaDefinition codaDefinition = new CodaDefinition();
            codaDefinition.dataAreaId = dataAreaId;
            codaDefinition.BankAccount = bankAccount;
            codaDefinition.TransactionGroup = transactionGroup;
            codaDefinition.Transaction = transaction;
            codaDefinition.TransactionCategory = transactionCategory;
            return codaDefinition;
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
        /// There are no comments for Property BankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BankAccount
        {
            get
            {
                return this._BankAccount;
            }
            set
            {
                this.OnBankAccountChanging(value);
                this._BankAccount = value;
                this.OnBankAccountChanged();
                this.OnPropertyChanged("BankAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BankAccount;
        partial void OnBankAccountChanging(string value);
        partial void OnBankAccountChanged();
        /// <summary>
        /// There are no comments for Property TransactionGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TransactionGroup
        {
            get
            {
                return this._TransactionGroup;
            }
            set
            {
                this.OnTransactionGroupChanging(value);
                this._TransactionGroup = value;
                this.OnTransactionGroupChanged();
                this.OnPropertyChanged("TransactionGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionGroup;
        partial void OnTransactionGroupChanging(string value);
        partial void OnTransactionGroupChanged();
        /// <summary>
        /// There are no comments for Property Transaction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Transaction
        {
            get
            {
                return this._Transaction;
            }
            set
            {
                this.OnTransactionChanging(value);
                this._Transaction = value;
                this.OnTransactionChanged();
                this.OnPropertyChanged("Transaction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Transaction;
        partial void OnTransactionChanging(string value);
        partial void OnTransactionChanged();
        /// <summary>
        /// There are no comments for Property TransactionCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TransactionCategory
        {
            get
            {
                return this._TransactionCategory;
            }
            set
            {
                this.OnTransactionCategoryChanging(value);
                this._TransactionCategory = value;
                this.OnTransactionCategoryChanged();
                this.OnPropertyChanged("TransactionCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionCategory;
        partial void OnTransactionCategoryChanging(string value);
        partial void OnTransactionCategoryChanged();
        /// <summary>
        /// There are no comments for Property AccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BankCodaLedgerJournalACType> AccountType
        {
            get
            {
                return this._AccountType;
            }
            set
            {
                this.OnAccountTypeChanging(value);
                this._AccountType = value;
                this.OnAccountTypeChanged();
                this.OnPropertyChanged("AccountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BankCodaLedgerJournalACType> _AccountType;
        partial void OnAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BankCodaLedgerJournalACType> value);
        partial void OnAccountTypeChanged();
        /// <summary>
        /// There are no comments for Property GlobalizationCODA in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GlobalisationCode> GlobalizationCODA
        {
            get
            {
                return this._GlobalizationCODA;
            }
            set
            {
                this.OnGlobalizationCODAChanging(value);
                this._GlobalizationCODA = value;
                this.OnGlobalizationCODAChanged();
                this.OnPropertyChanged("GlobalizationCODA");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GlobalisationCode> _GlobalizationCODA;
        partial void OnGlobalizationCODAChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GlobalisationCode> value);
        partial void OnGlobalizationCODAChanged();
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
        /// There are no comments for Property AccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountDisplayValue
        {
            get
            {
                return this._AccountDisplayValue;
            }
            set
            {
                this.OnAccountDisplayValueChanging(value);
                this._AccountDisplayValue = value;
                this.OnAccountDisplayValueChanged();
                this.OnPropertyChanged("AccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountDisplayValue;
        partial void OnAccountDisplayValueChanging(string value);
        partial void OnAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
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
