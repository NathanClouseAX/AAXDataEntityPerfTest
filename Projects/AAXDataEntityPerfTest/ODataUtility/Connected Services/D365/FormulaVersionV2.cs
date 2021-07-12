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
        /// There are no comments for FormulaVersionV2Single in the schema.
        /// </summary>
    public partial class FormulaVersionV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<FormulaVersionV2>
    {
        /// <summary>
        /// Initialize a new FormulaVersionV2Single object.
        /// </summary>
        public FormulaVersionV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FormulaVersionV2Single object.
        /// </summary>
        public FormulaVersionV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FormulaVersionV2Single object.
        /// </summary>
        public FormulaVersionV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<FormulaVersionV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVersionSingle ProductVersion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductVersion == null))
                {
                    this._ProductVersion = new global::Microsoft.Dynamics.DataEntities.ProductVersionSingle(this.Context, GetPath("ProductVersion"));
                }
                return this._ProductVersion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVersionSingle _ProductVersion;
    }
        /// <summary>
        /// There are no comments for FormulaVersionV2 in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ManufacturedItemNumber
    /// FormulaId
    /// ProductionSiteId
    /// ProductConfigurationId
    /// ProductColorId
    /// ProductSizeId
    /// ProductStyleId
    /// ProductVersionId
    /// IsActive
    /// ValidFromDate
    /// FromQuantity
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ManufacturedItemNumber", "FormulaId", "ProductionSiteId", "ProductConfigurationId", "ProductColorId", "ProductSizeId", "ProductStyleId", "ProductVersionId", "IsActive", "ValidFromDate", "FromQuantity")]
    [global::Microsoft.OData.Client.EntitySet("FormulaVersionsV2")]
    public partial class FormulaVersionV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FormulaVersionV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="manufacturedItemNumber">Initial value of ManufacturedItemNumber.</param>
        /// <param name="formulaId">Initial value of FormulaId.</param>
        /// <param name="productionSiteId">Initial value of ProductionSiteId.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="productVersionId">Initial value of ProductVersionId.</param>
        /// <param name="validFromDate">Initial value of ValidFromDate.</param>
        /// <param name="fromQuantity">Initial value of FromQuantity.</param>
        /// <param name="formulaBatchSize">Initial value of FormulaBatchSize.</param>
        /// <param name="changedDate">Initial value of ChangedDate.</param>
        /// <param name="fromCatchWeightQuantity">Initial value of FromCatchWeightQuantity.</param>
        /// <param name="formulaBatchSizeMultiples">Initial value of FormulaBatchSizeMultiples.</param>
        /// <param name="catchWeightSize">Initial value of CatchWeightSize.</param>
        /// <param name="validToDate">Initial value of ValidToDate.</param>
        /// <param name="yieldPercentage">Initial value of YieldPercentage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FormulaVersionV2 CreateFormulaVersionV2(string dataAreaId, 
                    string manufacturedItemNumber, 
                    string formulaId, 
                    string productionSiteId, 
                    string productConfigurationId, 
                    string productColorId, 
                    string productSizeId, 
                    string productStyleId, 
                    string productVersionId, 
                    global::System.DateTimeOffset validFromDate, 
                    decimal fromQuantity, 
                    decimal formulaBatchSize, 
                    global::System.DateTimeOffset changedDate, 
                    decimal fromCatchWeightQuantity, 
                    decimal formulaBatchSizeMultiples, 
                    decimal catchWeightSize, 
                    global::System.DateTimeOffset validToDate, 
                    decimal yieldPercentage)
        {
            FormulaVersionV2 formulaVersionV2 = new FormulaVersionV2();
            formulaVersionV2.dataAreaId = dataAreaId;
            formulaVersionV2.ManufacturedItemNumber = manufacturedItemNumber;
            formulaVersionV2.FormulaId = formulaId;
            formulaVersionV2.ProductionSiteId = productionSiteId;
            formulaVersionV2.ProductConfigurationId = productConfigurationId;
            formulaVersionV2.ProductColorId = productColorId;
            formulaVersionV2.ProductSizeId = productSizeId;
            formulaVersionV2.ProductStyleId = productStyleId;
            formulaVersionV2.ProductVersionId = productVersionId;
            formulaVersionV2.ValidFromDate = validFromDate;
            formulaVersionV2.FromQuantity = fromQuantity;
            formulaVersionV2.FormulaBatchSize = formulaBatchSize;
            formulaVersionV2.ChangedDate = changedDate;
            formulaVersionV2.FromCatchWeightQuantity = fromCatchWeightQuantity;
            formulaVersionV2.FormulaBatchSizeMultiples = formulaBatchSizeMultiples;
            formulaVersionV2.CatchWeightSize = catchWeightSize;
            formulaVersionV2.ValidToDate = validToDate;
            formulaVersionV2.YieldPercentage = yieldPercentage;
            return formulaVersionV2;
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
        /// There are no comments for Property ManufacturedItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ManufacturedItemNumber
        {
            get
            {
                return this._ManufacturedItemNumber;
            }
            set
            {
                this.OnManufacturedItemNumberChanging(value);
                this._ManufacturedItemNumber = value;
                this.OnManufacturedItemNumberChanged();
                this.OnPropertyChanged("ManufacturedItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ManufacturedItemNumber;
        partial void OnManufacturedItemNumberChanging(string value);
        partial void OnManufacturedItemNumberChanged();
        /// <summary>
        /// There are no comments for Property FormulaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FormulaId
        {
            get
            {
                return this._FormulaId;
            }
            set
            {
                this.OnFormulaIdChanging(value);
                this._FormulaId = value;
                this.OnFormulaIdChanged();
                this.OnPropertyChanged("FormulaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FormulaId;
        partial void OnFormulaIdChanging(string value);
        partial void OnFormulaIdChanged();
        /// <summary>
        /// There are no comments for Property ProductionSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductionSiteId
        {
            get
            {
                return this._ProductionSiteId;
            }
            set
            {
                this.OnProductionSiteIdChanging(value);
                this._ProductionSiteId = value;
                this.OnProductionSiteIdChanged();
                this.OnPropertyChanged("ProductionSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductionSiteId;
        partial void OnProductionSiteIdChanging(string value);
        partial void OnProductionSiteIdChanged();
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
        /// There are no comments for Property ProductVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductVersionId
        {
            get
            {
                return this._ProductVersionId;
            }
            set
            {
                this.OnProductVersionIdChanging(value);
                this._ProductVersionId = value;
                this.OnProductVersionIdChanged();
                this.OnPropertyChanged("ProductVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductVersionId;
        partial void OnProductVersionIdChanging(string value);
        partial void OnProductVersionIdChanged();
        /// <summary>
        /// There are no comments for Property IsActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                this.OnIsActiveChanging(value);
                this._IsActive = value;
                this.OnIsActiveChanged();
                this.OnPropertyChanged("IsActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsActive;
        partial void OnIsActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsActiveChanged();
        /// <summary>
        /// There are no comments for Property ValidFromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidFromDate
        {
            get
            {
                return this._ValidFromDate;
            }
            set
            {
                this.OnValidFromDateChanging(value);
                this._ValidFromDate = value;
                this.OnValidFromDateChanged();
                this.OnPropertyChanged("ValidFromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFromDate;
        partial void OnValidFromDateChanging(global::System.DateTimeOffset value);
        partial void OnValidFromDateChanged();
        /// <summary>
        /// There are no comments for Property FromQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal FromQuantity
        {
            get
            {
                return this._FromQuantity;
            }
            set
            {
                this.OnFromQuantityChanging(value);
                this._FromQuantity = value;
                this.OnFromQuantityChanged();
                this.OnPropertyChanged("FromQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FromQuantity;
        partial void OnFromQuantityChanging(decimal value);
        partial void OnFromQuantityChanged();
        /// <summary>
        /// There are no comments for Property FormulaBatchSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal FormulaBatchSize
        {
            get
            {
                return this._FormulaBatchSize;
            }
            set
            {
                this.OnFormulaBatchSizeChanging(value);
                this._FormulaBatchSize = value;
                this.OnFormulaBatchSizeChanged();
                this.OnPropertyChanged("FormulaBatchSize");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FormulaBatchSize;
        partial void OnFormulaBatchSizeChanging(decimal value);
        partial void OnFormulaBatchSizeChanged();
        /// <summary>
        /// There are no comments for Property ApproverPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ApproverPersonnelNumber
        {
            get
            {
                return this._ApproverPersonnelNumber;
            }
            set
            {
                this.OnApproverPersonnelNumberChanging(value);
                this._ApproverPersonnelNumber = value;
                this.OnApproverPersonnelNumberChanged();
                this.OnPropertyChanged("ApproverPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ApproverPersonnelNumber;
        partial void OnApproverPersonnelNumberChanging(string value);
        partial void OnApproverPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property ChangedDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ChangedDate
        {
            get
            {
                return this._ChangedDate;
            }
            set
            {
                this.OnChangedDateChanging(value);
                this._ChangedDate = value;
                this.OnChangedDateChanged();
                this.OnPropertyChanged("ChangedDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ChangedDate;
        partial void OnChangedDateChanging(global::System.DateTimeOffset value);
        partial void OnChangedDateChanged();
        /// <summary>
        /// There are no comments for Property FromCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal FromCatchWeightQuantity
        {
            get
            {
                return this._FromCatchWeightQuantity;
            }
            set
            {
                this.OnFromCatchWeightQuantityChanging(value);
                this._FromCatchWeightQuantity = value;
                this.OnFromCatchWeightQuantityChanged();
                this.OnPropertyChanged("FromCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FromCatchWeightQuantity;
        partial void OnFromCatchWeightQuantityChanging(decimal value);
        partial void OnFromCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property IsApproved in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsApproved
        {
            get
            {
                return this._IsApproved;
            }
            set
            {
                this.OnIsApprovedChanging(value);
                this._IsApproved = value;
                this.OnIsApprovedChanged();
                this.OnPropertyChanged("IsApproved");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsApproved;
        partial void OnIsApprovedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsApprovedChanged();
        /// <summary>
        /// There are no comments for Property FormulaBatchSizeMultiples in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal FormulaBatchSizeMultiples
        {
            get
            {
                return this._FormulaBatchSizeMultiples;
            }
            set
            {
                this.OnFormulaBatchSizeMultiplesChanging(value);
                this._FormulaBatchSizeMultiples = value;
                this.OnFormulaBatchSizeMultiplesChanged();
                this.OnPropertyChanged("FormulaBatchSizeMultiples");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FormulaBatchSizeMultiples;
        partial void OnFormulaBatchSizeMultiplesChanging(decimal value);
        partial void OnFormulaBatchSizeMultiplesChanged();
        /// <summary>
        /// There are no comments for Property CatchWeightSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CatchWeightSize
        {
            get
            {
                return this._CatchWeightSize;
            }
            set
            {
                this.OnCatchWeightSizeChanging(value);
                this._CatchWeightSize = value;
                this.OnCatchWeightSizeChanged();
                this.OnPropertyChanged("CatchWeightSize");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CatchWeightSize;
        partial void OnCatchWeightSizeChanging(decimal value);
        partial void OnCatchWeightSizeChanged();
        /// <summary>
        /// There are no comments for Property IsSelectedForDesigner in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsSelectedForDesigner
        {
            get
            {
                return this._IsSelectedForDesigner;
            }
            set
            {
                this.OnIsSelectedForDesignerChanging(value);
                this._IsSelectedForDesigner = value;
                this.OnIsSelectedForDesignerChanged();
                this.OnPropertyChanged("IsSelectedForDesigner");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsSelectedForDesigner;
        partial void OnIsSelectedForDesignerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsSelectedForDesignerChanged();
        /// <summary>
        /// There are no comments for Property IsCoProductQuantityVariationAllowed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCoProductQuantityVariationAllowed
        {
            get
            {
                return this._IsCoProductQuantityVariationAllowed;
            }
            set
            {
                this.OnIsCoProductQuantityVariationAllowedChanging(value);
                this._IsCoProductQuantityVariationAllowed = value;
                this.OnIsCoProductQuantityVariationAllowedChanged();
                this.OnPropertyChanged("IsCoProductQuantityVariationAllowed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCoProductQuantityVariationAllowed;
        partial void OnIsCoProductQuantityVariationAllowedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCoProductQuantityVariationAllowedChanged();
        /// <summary>
        /// There are no comments for Property WillCostCalculationIncludeVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillCostCalculationIncludeVersion
        {
            get
            {
                return this._WillCostCalculationIncludeVersion;
            }
            set
            {
                this.OnWillCostCalculationIncludeVersionChanging(value);
                this._WillCostCalculationIncludeVersion = value;
                this.OnWillCostCalculationIncludeVersionChanged();
                this.OnPropertyChanged("WillCostCalculationIncludeVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillCostCalculationIncludeVersion;
        partial void OnWillCostCalculationIncludeVersionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillCostCalculationIncludeVersionChanged();
        /// <summary>
        /// There are no comments for Property ValidToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidToDate
        {
            get
            {
                return this._ValidToDate;
            }
            set
            {
                this.OnValidToDateChanging(value);
                this._ValidToDate = value;
                this.OnValidToDateChanged();
                this.OnPropertyChanged("ValidToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidToDate;
        partial void OnValidToDateChanging(global::System.DateTimeOffset value);
        partial void OnValidToDateChanged();
        /// <summary>
        /// There are no comments for Property BulkItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BulkItemNumber
        {
            get
            {
                return this._BulkItemNumber;
            }
            set
            {
                this.OnBulkItemNumberChanging(value);
                this._BulkItemNumber = value;
                this.OnBulkItemNumberChanged();
                this.OnPropertyChanged("BulkItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BulkItemNumber;
        partial void OnBulkItemNumberChanging(string value);
        partial void OnBulkItemNumberChanged();
        /// <summary>
        /// There are no comments for Property YieldPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal YieldPercentage
        {
            get
            {
                return this._YieldPercentage;
            }
            set
            {
                this.OnYieldPercentageChanging(value);
                this._YieldPercentage = value;
                this.OnYieldPercentageChanged();
                this.OnPropertyChanged("YieldPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _YieldPercentage;
        partial void OnYieldPercentageChanging(decimal value);
        partial void OnYieldPercentageChanged();
        /// <summary>
        /// There are no comments for Property IsTotalCostAllocationUsed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsTotalCostAllocationUsed
        {
            get
            {
                return this._IsTotalCostAllocationUsed;
            }
            set
            {
                this.OnIsTotalCostAllocationUsedChanging(value);
                this._IsTotalCostAllocationUsed = value;
                this.OnIsTotalCostAllocationUsedChanged();
                this.OnPropertyChanged("IsTotalCostAllocationUsed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsTotalCostAllocationUsed;
        partial void OnIsTotalCostAllocationUsedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsTotalCostAllocationUsedChanged();
        /// <summary>
        /// There are no comments for Property VersionName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VersionName
        {
            get
            {
                return this._VersionName;
            }
            set
            {
                this.OnVersionNameChanging(value);
                this._VersionName = value;
                this.OnVersionNameChanged();
                this.OnPropertyChanged("VersionName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VersionName;
        partial void OnVersionNameChanging(string value);
        partial void OnVersionNameChanged();
        /// <summary>
        /// There are no comments for Property ProductVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVersion ProductVersion
        {
            get
            {
                return this._ProductVersion;
            }
            set
            {
                this.OnProductVersionChanging(value);
                this._ProductVersion = value;
                this.OnProductVersionChanged();
                this.OnPropertyChanged("ProductVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVersion _ProductVersion;
        partial void OnProductVersionChanging(global::Microsoft.Dynamics.DataEntities.ProductVersion value);
        partial void OnProductVersionChanged();
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
