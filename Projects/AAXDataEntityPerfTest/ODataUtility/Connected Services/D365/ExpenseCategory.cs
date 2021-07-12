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
        /// There are no comments for ExpenseCategorySingle in the schema.
        /// </summary>
    public partial class ExpenseCategorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ExpenseCategory>
    {
        /// <summary>
        /// Initialize a new ExpenseCategorySingle object.
        /// </summary>
        public ExpenseCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ExpenseCategorySingle object.
        /// </summary>
        public ExpenseCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ExpenseCategorySingle object.
        /// </summary>
        public ExpenseCategorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ExpenseCategory> query)
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
        /// There are no comments for ExpenseCategory in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ExpenseCategory
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ExpenseCategory")]
    [global::Microsoft.OData.Client.EntitySet("ExpenseCategories")]
    public partial class ExpenseCategory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ExpenseCategory object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="expenseCategory1">Initial value of ExpenseCategory1.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ExpenseCategory CreateExpenseCategory(string dataAreaId, string expenseCategory1)
        {
            ExpenseCategory expenseCategory = new ExpenseCategory();
            expenseCategory.dataAreaId = dataAreaId;
            expenseCategory.ExpenseCategory1 = expenseCategory1;
            return expenseCategory;
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
        /// There are no comments for Property ExpenseCategory1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpenseCategory")]
        public virtual string ExpenseCategory1
        {
            get
            {
                return this._ExpenseCategory1;
            }
            set
            {
                this.OnExpenseCategory1Changing(value);
                this._ExpenseCategory1 = value;
                this.OnExpenseCategory1Changed();
                this.OnPropertyChanged("ExpenseCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExpenseCategory1;
        partial void OnExpenseCategory1Changing(string value);
        partial void OnExpenseCategory1Changed();
        /// <summary>
        /// There are no comments for Property IsImportOnly in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsImportOnly
        {
            get
            {
                return this._IsImportOnly;
            }
            set
            {
                this.OnIsImportOnlyChanging(value);
                this._IsImportOnly = value;
                this.OnIsImportOnlyChanged();
                this.OnPropertyChanged("IsImportOnly");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsImportOnly;
        partial void OnIsImportOnlyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsImportOnlyChanged();
        /// <summary>
        /// There are no comments for Property LedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LedgerDimensionDisplayValue
        {
            get
            {
                return this._LedgerDimensionDisplayValue;
            }
            set
            {
                this.OnLedgerDimensionDisplayValueChanging(value);
                this._LedgerDimensionDisplayValue = value;
                this.OnLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("LedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerDimensionDisplayValue;
        partial void OnLedgerDimensionDisplayValueChanging(string value);
        partial void OnLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property AccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> AccountType
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> _AccountType;
        partial void OnAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> value);
        partial void OnAccountTypeChanged();
        /// <summary>
        /// There are no comments for Property TaxItemGroupIfBilledToEmployee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxItemGroupIfBilledToEmployee
        {
            get
            {
                return this._TaxItemGroupIfBilledToEmployee;
            }
            set
            {
                this.OnTaxItemGroupIfBilledToEmployeeChanging(value);
                this._TaxItemGroupIfBilledToEmployee = value;
                this.OnTaxItemGroupIfBilledToEmployeeChanged();
                this.OnPropertyChanged("TaxItemGroupIfBilledToEmployee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxItemGroupIfBilledToEmployee;
        partial void OnTaxItemGroupIfBilledToEmployeeChanging(string value);
        partial void OnTaxItemGroupIfBilledToEmployeeChanged();
        /// <summary>
        /// There are no comments for Property StatisticsGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string StatisticsGroup
        {
            get
            {
                return this._StatisticsGroup;
            }
            set
            {
                this.OnStatisticsGroupChanging(value);
                this._StatisticsGroup = value;
                this.OnStatisticsGroupChanged();
                this.OnPropertyChanged("StatisticsGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StatisticsGroup;
        partial void OnStatisticsGroupChanging(string value);
        partial void OnStatisticsGroupChanged();
        /// <summary>
        /// There are no comments for Property ExpenseType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvExpType> ExpenseType
        {
            get
            {
                return this._ExpenseType;
            }
            set
            {
                this.OnExpenseTypeChanging(value);
                this._ExpenseType = value;
                this.OnExpenseTypeChanged();
                this.OnPropertyChanged("ExpenseType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvExpType> _ExpenseType;
        partial void OnExpenseTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvExpType> value);
        partial void OnExpenseTypeChanged();
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
        /// There are no comments for Property DefaultPaymentMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultPaymentMethod
        {
            get
            {
                return this._DefaultPaymentMethod;
            }
            set
            {
                this.OnDefaultPaymentMethodChanging(value);
                this._DefaultPaymentMethod = value;
                this.OnDefaultPaymentMethodChanged();
                this.OnPropertyChanged("DefaultPaymentMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultPaymentMethod;
        partial void OnDefaultPaymentMethodChanging(string value);
        partial void OnDefaultPaymentMethodChanged();
        /// <summary>
        /// There are no comments for Property IsInactive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsInactive
        {
            get
            {
                return this._IsInactive;
            }
            set
            {
                this.OnIsInactiveChanging(value);
                this._IsInactive = value;
                this.OnIsInactiveChanged();
                this.OnPropertyChanged("IsInactive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsInactive;
        partial void OnIsInactiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsInactiveChanged();
        /// <summary>
        /// There are no comments for Property TaxItemGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxItemGroup
        {
            get
            {
                return this._TaxItemGroup;
            }
            set
            {
                this.OnTaxItemGroupChanging(value);
                this._TaxItemGroup = value;
                this.OnTaxItemGroupChanged();
                this.OnPropertyChanged("TaxItemGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxItemGroup;
        partial void OnTaxItemGroupChanging(string value);
        partial void OnTaxItemGroupChanged();
        /// <summary>
        /// There are no comments for Property IsItemizationMandatory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsItemizationMandatory
        {
            get
            {
                return this._IsItemizationMandatory;
            }
            set
            {
                this.OnIsItemizationMandatoryChanging(value);
                this._IsItemizationMandatory = value;
                this.OnIsItemizationMandatoryChanged();
                this.OnPropertyChanged("IsItemizationMandatory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsItemizationMandatory;
        partial void OnIsItemizationMandatoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsItemizationMandatoryChanged();
        /// <summary>
        /// There are no comments for Property IsCommon in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCommon
        {
            get
            {
                return this._IsCommon;
            }
            set
            {
                this.OnIsCommonChanging(value);
                this._IsCommon = value;
                this.OnIsCommonChanged();
                this.OnPropertyChanged("IsCommon");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCommon;
        partial void OnIsCommonChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCommonChanged();
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
