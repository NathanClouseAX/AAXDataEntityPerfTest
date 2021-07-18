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
        /// There are no comments for KittingKitLineSingle in the schema.
        /// </summary>
    public partial class KittingKitLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<KittingKitLine>
    {
        /// <summary>
        /// Initialize a new KittingKitLineSingle object.
        /// </summary>
        public KittingKitLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new KittingKitLineSingle object.
        /// </summary>
        public KittingKitLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new KittingKitLineSingle object.
        /// </summary>
        public KittingKitLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<KittingKitLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Kitting_KitHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Kitting_KitHeaderSingle Kitting_KitHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Kitting_KitHeader == null))
                {
                    this._Kitting_KitHeader = new global::Microsoft.Dynamics.DataEntities.Kitting_KitHeaderSingle(this.Context, GetPath("Kitting_KitHeader"));
                }
                return this._Kitting_KitHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Kitting_KitHeaderSingle _Kitting_KitHeader;
        /// <summary>
        /// There are no comments for KitHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Kitting_KitHeaderSingle KitHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._KitHeader == null))
                {
                    this._KitHeader = new global::Microsoft.Dynamics.DataEntities.Kitting_KitHeaderSingle(this.Context, GetPath("KitHeader"));
                }
                return this._KitHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Kitting_KitHeaderSingle _KitHeader;
    }
        /// <summary>
        /// There are no comments for KittingKitLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// KitId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "KitId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("KittingKitLines")]
    public partial class KittingKitLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new KittingKitLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="kitId">Initial value of KitId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="physicalProductWidth">Initial value of PhysicalProductWidth.</param>
        /// <param name="consumptionCalculationConstant">Initial value of ConsumptionCalculationConstant.</param>
        /// <param name="quantityDenominator">Initial value of QuantityDenominator.</param>
        /// <param name="physicalProductDepth">Initial value of PhysicalProductDepth.</param>
        /// <param name="quantityRoundingUpMultiples">Initial value of QuantityRoundingUpMultiples.</param>
        /// <param name="physicalProductHeight">Initial value of PhysicalProductHeight.</param>
        /// <param name="physicalProductDensity">Initial value of PhysicalProductDensity.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="kitting_KitHeader">Initial value of Kitting_KitHeader.</param>
        /// <param name="kitHeader">Initial value of KitHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static KittingKitLine CreateKittingKitLine(string dataAreaId, 
                    string kitId, 
                    decimal lineNumber, 
                    decimal physicalProductWidth, 
                    decimal consumptionCalculationConstant, 
                    decimal quantityDenominator, 
                    decimal physicalProductDepth, 
                    decimal quantityRoundingUpMultiples, 
                    decimal physicalProductHeight, 
                    decimal physicalProductDensity, 
                    decimal quantity, 
                    global::Microsoft.Dynamics.DataEntities.Kitting_KitHeader kitting_KitHeader, 
                    global::Microsoft.Dynamics.DataEntities.Kitting_KitHeader kitHeader)
        {
            KittingKitLine kittingKitLine = new KittingKitLine();
            kittingKitLine.dataAreaId = dataAreaId;
            kittingKitLine.KitId = kitId;
            kittingKitLine.LineNumber = lineNumber;
            kittingKitLine.PhysicalProductWidth = physicalProductWidth;
            kittingKitLine.ConsumptionCalculationConstant = consumptionCalculationConstant;
            kittingKitLine.QuantityDenominator = quantityDenominator;
            kittingKitLine.PhysicalProductDepth = physicalProductDepth;
            kittingKitLine.QuantityRoundingUpMultiples = quantityRoundingUpMultiples;
            kittingKitLine.PhysicalProductHeight = physicalProductHeight;
            kittingKitLine.PhysicalProductDensity = physicalProductDensity;
            kittingKitLine.Quantity = quantity;
            if ((kitting_KitHeader == null))
            {
                throw new global::System.ArgumentNullException("kitting_KitHeader");
            }
            kittingKitLine.Kitting_KitHeader = kitting_KitHeader;
            if ((kitHeader == null))
            {
                throw new global::System.ArgumentNullException("kitHeader");
            }
            kittingKitLine.KitHeader = kitHeader;
            return kittingKitLine;
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
        /// There are no comments for Property KitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string KitId
        {
            get
            {
                return this._KitId;
            }
            set
            {
                this.OnKitIdChanging(value);
                this._KitId = value;
                this.OnKitIdChanged();
                this.OnPropertyChanged("KitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _KitId;
        partial void OnKitIdChanging(string value);
        partial void OnKitIdChanged();
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
        /// There are no comments for Property PhysicalProductWidth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PhysicalProductWidth
        {
            get
            {
                return this._PhysicalProductWidth;
            }
            set
            {
                this.OnPhysicalProductWidthChanging(value);
                this._PhysicalProductWidth = value;
                this.OnPhysicalProductWidthChanged();
                this.OnPropertyChanged("PhysicalProductWidth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PhysicalProductWidth;
        partial void OnPhysicalProductWidthChanging(decimal value);
        partial void OnPhysicalProductWidthChanged();
        /// <summary>
        /// There are no comments for Property ConsumptionWarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ConsumptionWarehouseId
        {
            get
            {
                return this._ConsumptionWarehouseId;
            }
            set
            {
                this.OnConsumptionWarehouseIdChanging(value);
                this._ConsumptionWarehouseId = value;
                this.OnConsumptionWarehouseIdChanged();
                this.OnPropertyChanged("ConsumptionWarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConsumptionWarehouseId;
        partial void OnConsumptionWarehouseIdChanging(string value);
        partial void OnConsumptionWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property RoundingUpMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMRoundUp> RoundingUpMethod
        {
            get
            {
                return this._RoundingUpMethod;
            }
            set
            {
                this.OnRoundingUpMethodChanging(value);
                this._RoundingUpMethod = value;
                this.OnRoundingUpMethodChanged();
                this.OnPropertyChanged("RoundingUpMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMRoundUp> _RoundingUpMethod;
        partial void OnRoundingUpMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMRoundUp> value);
        partial void OnRoundingUpMethodChanged();
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
        /// There are no comments for Property ProductUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductUnitSymbol
        {
            get
            {
                return this._ProductUnitSymbol;
            }
            set
            {
                this.OnProductUnitSymbolChanging(value);
                this._ProductUnitSymbol = value;
                this.OnProductUnitSymbolChanged();
                this.OnPropertyChanged("ProductUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductUnitSymbol;
        partial void OnProductUnitSymbolChanging(string value);
        partial void OnProductUnitSymbolChanged();
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
        /// There are no comments for Property ConsumptionCalculationConstant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ConsumptionCalculationConstant
        {
            get
            {
                return this._ConsumptionCalculationConstant;
            }
            set
            {
                this.OnConsumptionCalculationConstantChanging(value);
                this._ConsumptionCalculationConstant = value;
                this.OnConsumptionCalculationConstantChanged();
                this.OnPropertyChanged("ConsumptionCalculationConstant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ConsumptionCalculationConstant;
        partial void OnConsumptionCalculationConstantChanging(decimal value);
        partial void OnConsumptionCalculationConstantChanged();
        /// <summary>
        /// There are no comments for Property QuantityDenominator in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal QuantityDenominator
        {
            get
            {
                return this._QuantityDenominator;
            }
            set
            {
                this.OnQuantityDenominatorChanging(value);
                this._QuantityDenominator = value;
                this.OnQuantityDenominatorChanged();
                this.OnPropertyChanged("QuantityDenominator");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _QuantityDenominator;
        partial void OnQuantityDenominatorChanging(decimal value);
        partial void OnQuantityDenominatorChanged();
        /// <summary>
        /// There are no comments for Property PhysicalProductDepth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PhysicalProductDepth
        {
            get
            {
                return this._PhysicalProductDepth;
            }
            set
            {
                this.OnPhysicalProductDepthChanging(value);
                this._PhysicalProductDepth = value;
                this.OnPhysicalProductDepthChanged();
                this.OnPropertyChanged("PhysicalProductDepth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PhysicalProductDepth;
        partial void OnPhysicalProductDepthChanging(decimal value);
        partial void OnPhysicalProductDepthChanged();
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
        /// There are no comments for Property QuantityRoundingUpMultiples in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal QuantityRoundingUpMultiples
        {
            get
            {
                return this._QuantityRoundingUpMultiples;
            }
            set
            {
                this.OnQuantityRoundingUpMultiplesChanging(value);
                this._QuantityRoundingUpMultiples = value;
                this.OnQuantityRoundingUpMultiplesChanged();
                this.OnPropertyChanged("QuantityRoundingUpMultiples");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _QuantityRoundingUpMultiples;
        partial void OnQuantityRoundingUpMultiplesChanging(decimal value);
        partial void OnQuantityRoundingUpMultiplesChanged();
        /// <summary>
        /// There are no comments for Property PhysicalProductHeight in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PhysicalProductHeight
        {
            get
            {
                return this._PhysicalProductHeight;
            }
            set
            {
                this.OnPhysicalProductHeightChanging(value);
                this._PhysicalProductHeight = value;
                this.OnPhysicalProductHeightChanged();
                this.OnPropertyChanged("PhysicalProductHeight");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PhysicalProductHeight;
        partial void OnPhysicalProductHeightChanging(decimal value);
        partial void OnPhysicalProductHeightChanged();
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
        /// There are no comments for Property PhysicalProductDensity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PhysicalProductDensity
        {
            get
            {
                return this._PhysicalProductDensity;
            }
            set
            {
                this.OnPhysicalProductDensityChanging(value);
                this._PhysicalProductDensity = value;
                this.OnPhysicalProductDensityChanged();
                this.OnPropertyChanged("PhysicalProductDensity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PhysicalProductDensity;
        partial void OnPhysicalProductDensityChanging(decimal value);
        partial void OnPhysicalProductDensityChanged();
        /// <summary>
        /// There are no comments for Property ConsumptionCalculationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMFormula> ConsumptionCalculationMethod
        {
            get
            {
                return this._ConsumptionCalculationMethod;
            }
            set
            {
                this.OnConsumptionCalculationMethodChanging(value);
                this._ConsumptionCalculationMethod = value;
                this.OnConsumptionCalculationMethodChanged();
                this.OnPropertyChanged("ConsumptionCalculationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMFormula> _ConsumptionCalculationMethod;
        partial void OnConsumptionCalculationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMFormula> value);
        partial void OnConsumptionCalculationMethodChanged();
        /// <summary>
        /// There are no comments for Property ConsumptionSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ConsumptionSiteId
        {
            get
            {
                return this._ConsumptionSiteId;
            }
            set
            {
                this.OnConsumptionSiteIdChanging(value);
                this._ConsumptionSiteId = value;
                this.OnConsumptionSiteIdChanged();
                this.OnPropertyChanged("ConsumptionSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConsumptionSiteId;
        partial void OnConsumptionSiteIdChanging(string value);
        partial void OnConsumptionSiteIdChanged();
        /// <summary>
        /// There are no comments for Property ConsumptionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMConsumpType> ConsumptionType
        {
            get
            {
                return this._ConsumptionType;
            }
            set
            {
                this.OnConsumptionTypeChanging(value);
                this._ConsumptionType = value;
                this.OnConsumptionTypeChanged();
                this.OnPropertyChanged("ConsumptionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMConsumpType> _ConsumptionType;
        partial void OnConsumptionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMConsumpType> value);
        partial void OnConsumptionTypeChanged();
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
        /// There are no comments for Property Kitting_KitHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Kitting_KitHeader Kitting_KitHeader
        {
            get
            {
                return this._Kitting_KitHeader;
            }
            set
            {
                this.OnKitting_KitHeaderChanging(value);
                this._Kitting_KitHeader = value;
                this.OnKitting_KitHeaderChanged();
                this.OnPropertyChanged("Kitting_KitHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Kitting_KitHeader _Kitting_KitHeader;
        partial void OnKitting_KitHeaderChanging(global::Microsoft.Dynamics.DataEntities.Kitting_KitHeader value);
        partial void OnKitting_KitHeaderChanged();
        /// <summary>
        /// There are no comments for Property KitHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Kitting_KitHeader KitHeader
        {
            get
            {
                return this._KitHeader;
            }
            set
            {
                this.OnKitHeaderChanging(value);
                this._KitHeader = value;
                this.OnKitHeaderChanged();
                this.OnPropertyChanged("KitHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Kitting_KitHeader _KitHeader;
        partial void OnKitHeaderChanging(global::Microsoft.Dynamics.DataEntities.Kitting_KitHeader value);
        partial void OnKitHeaderChanged();
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
