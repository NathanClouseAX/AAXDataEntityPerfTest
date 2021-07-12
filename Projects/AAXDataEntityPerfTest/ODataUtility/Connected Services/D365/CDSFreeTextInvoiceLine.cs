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
        /// There are no comments for CDSFreeTextInvoiceLineSingle in the schema.
        /// </summary>
    public partial class CDSFreeTextInvoiceLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CDSFreeTextInvoiceLine>
    {
        /// <summary>
        /// Initialize a new CDSFreeTextInvoiceLineSingle object.
        /// </summary>
        public CDSFreeTextInvoiceLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CDSFreeTextInvoiceLineSingle object.
        /// </summary>
        public CDSFreeTextInvoiceLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CDSFreeTextInvoiceLineSingle object.
        /// </summary>
        public CDSFreeTextInvoiceLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CDSFreeTextInvoiceLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CDSFreeTextInvoiceHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CDSFreeTextInvoiceHeaderSingle CDSFreeTextInvoiceHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CDSFreeTextInvoiceHeader == null))
                {
                    this._CDSFreeTextInvoiceHeader = new global::Microsoft.Dynamics.DataEntities.CDSFreeTextInvoiceHeaderSingle(this.Context, GetPath("CDSFreeTextInvoiceHeader"));
                }
                return this._CDSFreeTextInvoiceHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CDSFreeTextInvoiceHeaderSingle _CDSFreeTextInvoiceHeader;
        /// <summary>
        /// There are no comments for SalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxGroupSingle SalesTaxGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SalesTaxGroup == null))
                {
                    this._SalesTaxGroup = new global::Microsoft.Dynamics.DataEntities.TaxGroupSingle(this.Context, GetPath("SalesTaxGroup"));
                }
                return this._SalesTaxGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxGroupSingle _SalesTaxGroup;
        /// <summary>
        /// There are no comments for MainAccountDimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle MainAccountDimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._MainAccountDimensionCombination == null))
                {
                    this._MainAccountDimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("MainAccountDimensionCombination"));
                }
                return this._MainAccountDimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _MainAccountDimensionCombination;
    }
        /// <summary>
        /// There are no comments for CDSFreeTextInvoiceLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ExternalInvoiceId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ExternalInvoiceId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("CDSFreeTextInvoiceLines")]
    public partial class CDSFreeTextInvoiceLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CDSFreeTextInvoiceLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="externalInvoiceId">Initial value of ExternalInvoiceId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="unitPrice">Initial value of UnitPrice.</param>
        /// <param name="transactionCurrencyAmount">Initial value of TransactionCurrencyAmount.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="cDSFreeTextInvoiceHeader">Initial value of CDSFreeTextInvoiceHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CDSFreeTextInvoiceLine CreateCDSFreeTextInvoiceLine(string dataAreaId, 
                    string externalInvoiceId, 
                    decimal lineNumber, 
                    decimal unitPrice, 
                    decimal transactionCurrencyAmount, 
                    decimal quantity, 
                    global::Microsoft.Dynamics.DataEntities.CDSFreeTextInvoiceHeader cDSFreeTextInvoiceHeader)
        {
            CDSFreeTextInvoiceLine cDSFreeTextInvoiceLine = new CDSFreeTextInvoiceLine();
            cDSFreeTextInvoiceLine.dataAreaId = dataAreaId;
            cDSFreeTextInvoiceLine.ExternalInvoiceId = externalInvoiceId;
            cDSFreeTextInvoiceLine.LineNumber = lineNumber;
            cDSFreeTextInvoiceLine.UnitPrice = unitPrice;
            cDSFreeTextInvoiceLine.TransactionCurrencyAmount = transactionCurrencyAmount;
            cDSFreeTextInvoiceLine.Quantity = quantity;
            if ((cDSFreeTextInvoiceHeader == null))
            {
                throw new global::System.ArgumentNullException("cDSFreeTextInvoiceHeader");
            }
            cDSFreeTextInvoiceLine.CDSFreeTextInvoiceHeader = cDSFreeTextInvoiceHeader;
            return cDSFreeTextInvoiceLine;
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
        /// There are no comments for Property ExternalInvoiceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ExternalInvoiceId
        {
            get
            {
                return this._ExternalInvoiceId;
            }
            set
            {
                this.OnExternalInvoiceIdChanging(value);
                this._ExternalInvoiceId = value;
                this.OnExternalInvoiceIdChanged();
                this.OnPropertyChanged("ExternalInvoiceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExternalInvoiceId;
        partial void OnExternalInvoiceIdChanging(string value);
        partial void OnExternalInvoiceIdChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property UnitPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal UnitPrice
        {
            get
            {
                return this._UnitPrice;
            }
            set
            {
                this.OnUnitPriceChanging(value);
                this._UnitPrice = value;
                this.OnUnitPriceChanged();
                this.OnPropertyChanged("UnitPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _UnitPrice;
        partial void OnUnitPriceChanging(decimal value);
        partial void OnUnitPriceChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesTaxGroupId
        {
            get
            {
                return this._SalesTaxGroupId;
            }
            set
            {
                this.OnSalesTaxGroupIdChanging(value);
                this._SalesTaxGroupId = value;
                this.OnSalesTaxGroupIdChanged();
                this.OnPropertyChanged("SalesTaxGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxGroupId;
        partial void OnSalesTaxGroupIdChanging(string value);
        partial void OnSalesTaxGroupIdChanged();
        /// <summary>
        /// There are no comments for Property MainAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccountDisplayValue
        {
            get
            {
                return this._MainAccountDisplayValue;
            }
            set
            {
                this.OnMainAccountDisplayValueChanging(value);
                this._MainAccountDisplayValue = value;
                this.OnMainAccountDisplayValueChanged();
                this.OnPropertyChanged("MainAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountDisplayValue;
        partial void OnMainAccountDisplayValueChanging(string value);
        partial void OnMainAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxItemGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesTaxItemGroupId
        {
            get
            {
                return this._SalesTaxItemGroupId;
            }
            set
            {
                this.OnSalesTaxItemGroupIdChanging(value);
                this._SalesTaxItemGroupId = value;
                this.OnSalesTaxItemGroupIdChanged();
                this.OnPropertyChanged("SalesTaxItemGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxItemGroupId;
        partial void OnSalesTaxItemGroupIdChanging(string value);
        partial void OnSalesTaxItemGroupIdChanged();
        /// <summary>
        /// There are no comments for Property TransactionCurrencyAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TransactionCurrencyAmount
        {
            get
            {
                return this._TransactionCurrencyAmount;
            }
            set
            {
                this.OnTransactionCurrencyAmountChanging(value);
                this._TransactionCurrencyAmount = value;
                this.OnTransactionCurrencyAmountChanged();
                this.OnPropertyChanged("TransactionCurrencyAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TransactionCurrencyAmount;
        partial void OnTransactionCurrencyAmountChanging(decimal value);
        partial void OnTransactionCurrencyAmountChanged();
        /// <summary>
        /// There are no comments for Property InvoiceText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InvoiceText
        {
            get
            {
                return this._InvoiceText;
            }
            set
            {
                this.OnInvoiceTextChanging(value);
                this._InvoiceText = value;
                this.OnInvoiceTextChanged();
                this.OnPropertyChanged("InvoiceText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceText;
        partial void OnInvoiceTextChanging(string value);
        partial void OnInvoiceTextChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Quantity;
        partial void OnQuantityChanging(decimal value);
        partial void OnQuantityChanged();
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
        /// There are no comments for Property CDSFreeTextInvoiceHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CDSFreeTextInvoiceHeader CDSFreeTextInvoiceHeader
        {
            get
            {
                return this._CDSFreeTextInvoiceHeader;
            }
            set
            {
                this.OnCDSFreeTextInvoiceHeaderChanging(value);
                this._CDSFreeTextInvoiceHeader = value;
                this.OnCDSFreeTextInvoiceHeaderChanged();
                this.OnPropertyChanged("CDSFreeTextInvoiceHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CDSFreeTextInvoiceHeader _CDSFreeTextInvoiceHeader;
        partial void OnCDSFreeTextInvoiceHeaderChanging(global::Microsoft.Dynamics.DataEntities.CDSFreeTextInvoiceHeader value);
        partial void OnCDSFreeTextInvoiceHeaderChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxGroup SalesTaxGroup
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
        private global::Microsoft.Dynamics.DataEntities.TaxGroup _SalesTaxGroup;
        partial void OnSalesTaxGroupChanging(global::Microsoft.Dynamics.DataEntities.TaxGroup value);
        partial void OnSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property MainAccountDimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination MainAccountDimensionCombination
        {
            get
            {
                return this._MainAccountDimensionCombination;
            }
            set
            {
                this.OnMainAccountDimensionCombinationChanging(value);
                this._MainAccountDimensionCombination = value;
                this.OnMainAccountDimensionCombinationChanged();
                this.OnPropertyChanged("MainAccountDimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _MainAccountDimensionCombination;
        partial void OnMainAccountDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnMainAccountDimensionCombinationChanged();
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
