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
        /// There are no comments for RebateAndDeductionsAgreementDateSetupCriterionItemSingle in the schema.
        /// </summary>
    public partial class RebateAndDeductionsAgreementDateSetupCriterionItemSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RebateAndDeductionsAgreementDateSetupCriterionItem>
    {
        /// <summary>
        /// Initialize a new RebateAndDeductionsAgreementDateSetupCriterionItemSingle object.
        /// </summary>
        public RebateAndDeductionsAgreementDateSetupCriterionItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RebateAndDeductionsAgreementDateSetupCriterionItemSingle object.
        /// </summary>
        public RebateAndDeductionsAgreementDateSetupCriterionItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RebateAndDeductionsAgreementDateSetupCriterionItemSingle object.
        /// </summary>
        public RebateAndDeductionsAgreementDateSetupCriterionItemSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RebateAndDeductionsAgreementDateSetupCriterionItem> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductStyle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductStyleSingle ProductStyle
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductStyle == null))
                {
                    this._ProductStyle = new global::Microsoft.Dynamics.DataEntities.ProductStyleSingle(this.Context, GetPath("ProductStyle"));
                }
                return this._ProductStyle;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductStyleSingle _ProductStyle;
        /// <summary>
        /// There are no comments for ProductColor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductColorSingle ProductColor
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductColor == null))
                {
                    this._ProductColor = new global::Microsoft.Dynamics.DataEntities.ProductColorSingle(this.Context, GetPath("ProductColor"));
                }
                return this._ProductColor;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductColorSingle _ProductColor;
        /// <summary>
        /// There are no comments for UnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle UnitOfMeasure
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._UnitOfMeasure == null))
                {
                    this._UnitOfMeasure = new global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle(this.Context, GetPath("UnitOfMeasure"));
                }
                return this._UnitOfMeasure;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle _UnitOfMeasure;
        /// <summary>
        /// There are no comments for ProductSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductSizeSingle ProductSize
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductSize == null))
                {
                    this._ProductSize = new global::Microsoft.Dynamics.DataEntities.ProductSizeSingle(this.Context, GetPath("ProductSize"));
                }
                return this._ProductSize;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductSizeSingle _ProductSize;
        /// <summary>
        /// There are no comments for RebateAndDeductionsAgreementDateSetupCriterion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetupCriterionSingle RebateAndDeductionsAgreementDateSetupCriterion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RebateAndDeductionsAgreementDateSetupCriterion == null))
                {
                    this._RebateAndDeductionsAgreementDateSetupCriterion = new global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetupCriterionSingle(this.Context, GetPath("RebateAndDeductionsAgreementDateSetupCriterion"));
                }
                return this._RebateAndDeductionsAgreementDateSetupCriterion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetupCriterionSingle _RebateAndDeductionsAgreementDateSetupCriterion;
    }
        /// <summary>
        /// There are no comments for RebateAndDeductionsAgreementDateSetupCriterionItem in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// AgreementNumber
    /// AgreementLineNumber
    /// RebateValidFromQuantityAmount
    /// RebateValidToQuantityAmount
    /// RebateAmount
    /// RebateCalculationMethod
    /// ItemNumber
    /// ProductConfigurationId
    /// ProductColorId
    /// ProductSizeId
    /// ProductStyleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AgreementNumber", "AgreementLineNumber", "RebateValidFromQuantityAmount", "RebateValidToQuantityAmount", "RebateAmount", "RebateCalculationMethod", "ItemNumber", "ProductConfigurationId", "ProductColorId", "ProductSizeId", "ProductStyleId")]
    [global::Microsoft.OData.Client.EntitySet("RebateAndDeductionsAgreementDateSetupCriterionItems")]
    public partial class RebateAndDeductionsAgreementDateSetupCriterionItem : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RebateAndDeductionsAgreementDateSetupCriterionItem object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="agreementNumber">Initial value of AgreementNumber.</param>
        /// <param name="agreementLineNumber">Initial value of AgreementLineNumber.</param>
        /// <param name="rebateValidFromQuantityAmount">Initial value of RebateValidFromQuantityAmount.</param>
        /// <param name="rebateValidToQuantityAmount">Initial value of RebateValidToQuantityAmount.</param>
        /// <param name="rebateAmount">Initial value of RebateAmount.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="multiple">Initial value of Multiple.</param>
        /// <param name="qty">Initial value of Qty.</param>
        /// <param name="rebateAndDeductionsAgreementDateSetupCriterion">Initial value of RebateAndDeductionsAgreementDateSetupCriterion.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RebateAndDeductionsAgreementDateSetupCriterionItem CreateRebateAndDeductionsAgreementDateSetupCriterionItem(string dataAreaId, 
                    string agreementNumber, 
                    decimal agreementLineNumber, 
                    decimal rebateValidFromQuantityAmount, 
                    decimal rebateValidToQuantityAmount, 
                    decimal rebateAmount, 
                    string itemNumber, 
                    string productConfigurationId, 
                    string productColorId, 
                    string productSizeId, 
                    string productStyleId, 
                    decimal multiple, 
                    decimal qty, 
                    global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetupCriterion rebateAndDeductionsAgreementDateSetupCriterion)
        {
            RebateAndDeductionsAgreementDateSetupCriterionItem rebateAndDeductionsAgreementDateSetupCriterionItem = new RebateAndDeductionsAgreementDateSetupCriterionItem();
            rebateAndDeductionsAgreementDateSetupCriterionItem.dataAreaId = dataAreaId;
            rebateAndDeductionsAgreementDateSetupCriterionItem.AgreementNumber = agreementNumber;
            rebateAndDeductionsAgreementDateSetupCriterionItem.AgreementLineNumber = agreementLineNumber;
            rebateAndDeductionsAgreementDateSetupCriterionItem.RebateValidFromQuantityAmount = rebateValidFromQuantityAmount;
            rebateAndDeductionsAgreementDateSetupCriterionItem.RebateValidToQuantityAmount = rebateValidToQuantityAmount;
            rebateAndDeductionsAgreementDateSetupCriterionItem.RebateAmount = rebateAmount;
            rebateAndDeductionsAgreementDateSetupCriterionItem.ItemNumber = itemNumber;
            rebateAndDeductionsAgreementDateSetupCriterionItem.ProductConfigurationId = productConfigurationId;
            rebateAndDeductionsAgreementDateSetupCriterionItem.ProductColorId = productColorId;
            rebateAndDeductionsAgreementDateSetupCriterionItem.ProductSizeId = productSizeId;
            rebateAndDeductionsAgreementDateSetupCriterionItem.ProductStyleId = productStyleId;
            rebateAndDeductionsAgreementDateSetupCriterionItem.Multiple = multiple;
            rebateAndDeductionsAgreementDateSetupCriterionItem.Qty = qty;
            if ((rebateAndDeductionsAgreementDateSetupCriterion == null))
            {
                throw new global::System.ArgumentNullException("rebateAndDeductionsAgreementDateSetupCriterion");
            }
            rebateAndDeductionsAgreementDateSetupCriterionItem.RebateAndDeductionsAgreementDateSetupCriterion = rebateAndDeductionsAgreementDateSetupCriterion;
            return rebateAndDeductionsAgreementDateSetupCriterionItem;
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
        /// There are no comments for Property AgreementNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AgreementNumber
        {
            get
            {
                return this._AgreementNumber;
            }
            set
            {
                this.OnAgreementNumberChanging(value);
                this._AgreementNumber = value;
                this.OnAgreementNumberChanged();
                this.OnPropertyChanged("AgreementNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AgreementNumber;
        partial void OnAgreementNumberChanging(string value);
        partial void OnAgreementNumberChanged();
        /// <summary>
        /// There are no comments for Property AgreementLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AgreementLineNumber
        {
            get
            {
                return this._AgreementLineNumber;
            }
            set
            {
                this.OnAgreementLineNumberChanging(value);
                this._AgreementLineNumber = value;
                this.OnAgreementLineNumberChanged();
                this.OnPropertyChanged("AgreementLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AgreementLineNumber;
        partial void OnAgreementLineNumberChanging(decimal value);
        partial void OnAgreementLineNumberChanged();
        /// <summary>
        /// There are no comments for Property RebateValidFromQuantityAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RebateValidFromQuantityAmount
        {
            get
            {
                return this._RebateValidFromQuantityAmount;
            }
            set
            {
                this.OnRebateValidFromQuantityAmountChanging(value);
                this._RebateValidFromQuantityAmount = value;
                this.OnRebateValidFromQuantityAmountChanged();
                this.OnPropertyChanged("RebateValidFromQuantityAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RebateValidFromQuantityAmount;
        partial void OnRebateValidFromQuantityAmountChanging(decimal value);
        partial void OnRebateValidFromQuantityAmountChanged();
        /// <summary>
        /// There are no comments for Property RebateValidToQuantityAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RebateValidToQuantityAmount
        {
            get
            {
                return this._RebateValidToQuantityAmount;
            }
            set
            {
                this.OnRebateValidToQuantityAmountChanging(value);
                this._RebateValidToQuantityAmount = value;
                this.OnRebateValidToQuantityAmountChanged();
                this.OnPropertyChanged("RebateValidToQuantityAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RebateValidToQuantityAmount;
        partial void OnRebateValidToQuantityAmountChanging(decimal value);
        partial void OnRebateValidToQuantityAmountChanged();
        /// <summary>
        /// There are no comments for Property RebateAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RebateAmount
        {
            get
            {
                return this._RebateAmount;
            }
            set
            {
                this.OnRebateAmountChanging(value);
                this._RebateAmount = value;
                this.OnRebateAmountChanged();
                this.OnPropertyChanged("RebateAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RebateAmount;
        partial void OnRebateAmountChanging(decimal value);
        partial void OnRebateAmountChanged();
        /// <summary>
        /// There are no comments for Property RebateCalculationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateMethod> RebateCalculationMethod
        {
            get
            {
                return this._RebateCalculationMethod;
            }
            set
            {
                this.OnRebateCalculationMethodChanging(value);
                this._RebateCalculationMethod = value;
                this.OnRebateCalculationMethodChanged();
                this.OnPropertyChanged("RebateCalculationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateMethod> _RebateCalculationMethod;
        partial void OnRebateCalculationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateMethod> value);
        partial void OnRebateCalculationMethodChanged();
        /// <summary>
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemNumber
        {
            get
            {
                return this._ItemNumber;
            }
            set
            {
                this.OnItemNumberChanging(value);
                this._ItemNumber = value;
                this.OnItemNumberChanged();
                this.OnPropertyChanged("ItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumber;
        partial void OnItemNumberChanging(string value);
        partial void OnItemNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductConfigurationId
        {
            get
            {
                return this._ProductConfigurationId;
            }
            set
            {
                this.OnProductConfigurationIdChanging(value);
                this._ProductConfigurationId = value;
                this.OnProductConfigurationIdChanged();
                this.OnPropertyChanged("ProductConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductConfigurationId;
        partial void OnProductConfigurationIdChanging(string value);
        partial void OnProductConfigurationIdChanged();
        /// <summary>
        /// There are no comments for Property ProductColorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductColorId
        {
            get
            {
                return this._ProductColorId;
            }
            set
            {
                this.OnProductColorIdChanging(value);
                this._ProductColorId = value;
                this.OnProductColorIdChanged();
                this.OnPropertyChanged("ProductColorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductColorId;
        partial void OnProductColorIdChanging(string value);
        partial void OnProductColorIdChanged();
        /// <summary>
        /// There are no comments for Property ProductSizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductSizeId
        {
            get
            {
                return this._ProductSizeId;
            }
            set
            {
                this.OnProductSizeIdChanging(value);
                this._ProductSizeId = value;
                this.OnProductSizeIdChanged();
                this.OnPropertyChanged("ProductSizeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductSizeId;
        partial void OnProductSizeIdChanging(string value);
        partial void OnProductSizeIdChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductStyleId
        {
            get
            {
                return this._ProductStyleId;
            }
            set
            {
                this.OnProductStyleIdChanging(value);
                this._ProductStyleId = value;
                this.OnProductStyleIdChanged();
                this.OnPropertyChanged("ProductStyleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductStyleId;
        partial void OnProductStyleIdChanging(string value);
        partial void OnProductStyleIdChanged();
        /// <summary>
        /// There are no comments for Property UnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UnitSymbol
        {
            get
            {
                return this._UnitSymbol;
            }
            set
            {
                this.OnUnitSymbolChanging(value);
                this._UnitSymbol = value;
                this.OnUnitSymbolChanged();
                this.OnPropertyChanged("UnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitSymbol;
        partial void OnUnitSymbolChanging(string value);
        partial void OnUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property Multiple in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Multiple
        {
            get
            {
                return this._Multiple;
            }
            set
            {
                this.OnMultipleChanging(value);
                this._Multiple = value;
                this.OnMultipleChanged();
                this.OnPropertyChanged("Multiple");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Multiple;
        partial void OnMultipleChanging(decimal value);
        partial void OnMultipleChanged();
        /// <summary>
        /// There are no comments for Property Qty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Qty
        {
            get
            {
                return this._Qty;
            }
            set
            {
                this.OnQtyChanging(value);
                this._Qty = value;
                this.OnQtyChanged();
                this.OnPropertyChanged("Qty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Qty;
        partial void OnQtyChanging(decimal value);
        partial void OnQtyChanged();
        /// <summary>
        /// There are no comments for Property ProductStyle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductStyle ProductStyle
        {
            get
            {
                return this._ProductStyle;
            }
            set
            {
                this.OnProductStyleChanging(value);
                this._ProductStyle = value;
                this.OnProductStyleChanged();
                this.OnPropertyChanged("ProductStyle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductStyle _ProductStyle;
        partial void OnProductStyleChanging(global::Microsoft.Dynamics.DataEntities.ProductStyle value);
        partial void OnProductStyleChanged();
        /// <summary>
        /// There are no comments for Property ProductColor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductColor ProductColor
        {
            get
            {
                return this._ProductColor;
            }
            set
            {
                this.OnProductColorChanging(value);
                this._ProductColor = value;
                this.OnProductColorChanged();
                this.OnPropertyChanged("ProductColor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductColor _ProductColor;
        partial void OnProductColorChanging(global::Microsoft.Dynamics.DataEntities.ProductColor value);
        partial void OnProductColorChanged();
        /// <summary>
        /// There are no comments for Property UnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasure UnitOfMeasure
        {
            get
            {
                return this._UnitOfMeasure;
            }
            set
            {
                this.OnUnitOfMeasureChanging(value);
                this._UnitOfMeasure = value;
                this.OnUnitOfMeasureChanged();
                this.OnPropertyChanged("UnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasure _UnitOfMeasure;
        partial void OnUnitOfMeasureChanging(global::Microsoft.Dynamics.DataEntities.UnitOfMeasure value);
        partial void OnUnitOfMeasureChanged();
        /// <summary>
        /// There are no comments for Property ProductSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductSize ProductSize
        {
            get
            {
                return this._ProductSize;
            }
            set
            {
                this.OnProductSizeChanging(value);
                this._ProductSize = value;
                this.OnProductSizeChanged();
                this.OnPropertyChanged("ProductSize");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductSize _ProductSize;
        partial void OnProductSizeChanging(global::Microsoft.Dynamics.DataEntities.ProductSize value);
        partial void OnProductSizeChanged();
        /// <summary>
        /// There are no comments for Property RebateAndDeductionsAgreementDateSetupCriterion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetupCriterion RebateAndDeductionsAgreementDateSetupCriterion
        {
            get
            {
                return this._RebateAndDeductionsAgreementDateSetupCriterion;
            }
            set
            {
                this.OnRebateAndDeductionsAgreementDateSetupCriterionChanging(value);
                this._RebateAndDeductionsAgreementDateSetupCriterion = value;
                this.OnRebateAndDeductionsAgreementDateSetupCriterionChanged();
                this.OnPropertyChanged("RebateAndDeductionsAgreementDateSetupCriterion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetupCriterion _RebateAndDeductionsAgreementDateSetupCriterion;
        partial void OnRebateAndDeductionsAgreementDateSetupCriterionChanging(global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetupCriterion value);
        partial void OnRebateAndDeductionsAgreementDateSetupCriterionChanged();
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
