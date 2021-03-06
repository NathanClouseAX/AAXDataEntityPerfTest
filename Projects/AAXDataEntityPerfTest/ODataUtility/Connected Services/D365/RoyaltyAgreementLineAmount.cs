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
        /// There are no comments for RoyaltyAgreementLineAmountSingle in the schema.
        /// </summary>
    public partial class RoyaltyAgreementLineAmountSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RoyaltyAgreementLineAmount>
    {
        /// <summary>
        /// Initialize a new RoyaltyAgreementLineAmountSingle object.
        /// </summary>
        public RoyaltyAgreementLineAmountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RoyaltyAgreementLineAmountSingle object.
        /// </summary>
        public RoyaltyAgreementLineAmountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RoyaltyAgreementLineAmountSingle object.
        /// </summary>
        public RoyaltyAgreementLineAmountSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RoyaltyAgreementLineAmount> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RoyaltyAgreementLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineSingle RoyaltyAgreementLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RoyaltyAgreementLine == null))
                {
                    this._RoyaltyAgreementLine = new global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineSingle(this.Context, GetPath("RoyaltyAgreementLine"));
                }
                return this._RoyaltyAgreementLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineSingle _RoyaltyAgreementLine;
    }
        /// <summary>
        /// There are no comments for RoyaltyAgreementLineAmount in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RoyaltyAgreementId
    /// RoyaltyAgreementLineId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RoyaltyAgreementId", "RoyaltyAgreementLineId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("RoyaltyAgreementLineAmounts")]
    public partial class RoyaltyAgreementLineAmount : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RoyaltyAgreementLineAmount object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="royaltyAgreementId">Initial value of RoyaltyAgreementId.</param>
        /// <param name="royaltyAgreementLineId">Initial value of RoyaltyAgreementLineId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="toNetSalesAmount">Initial value of ToNetSalesAmount.</param>
        /// <param name="fromGrossSalesAmount">Initial value of FromGrossSalesAmount.</param>
        /// <param name="fromNetSalesAmount">Initial value of FromNetSalesAmount.</param>
        /// <param name="toGrossSalesAmount">Initial value of ToGrossSalesAmount.</param>
        /// <param name="fixedRoyaltyAmount">Initial value of FixedRoyaltyAmount.</param>
        /// <param name="royaltyAmountPerProductUnitSold">Initial value of RoyaltyAmountPerProductUnitSold.</param>
        /// <param name="salesPriceQuantity">Initial value of SalesPriceQuantity.</param>
        /// <param name="royaltyPercentage">Initial value of RoyaltyPercentage.</param>
        /// <param name="royaltyAgreementLine">Initial value of RoyaltyAgreementLine.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RoyaltyAgreementLineAmount CreateRoyaltyAgreementLineAmount(string dataAreaId, 
                    string royaltyAgreementId, 
                    string royaltyAgreementLineId, 
                    long lineNumber, 
                    decimal toNetSalesAmount, 
                    decimal fromGrossSalesAmount, 
                    decimal fromNetSalesAmount, 
                    decimal toGrossSalesAmount, 
                    decimal fixedRoyaltyAmount, 
                    decimal royaltyAmountPerProductUnitSold, 
                    decimal salesPriceQuantity, 
                    decimal royaltyPercentage, 
                    global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLine royaltyAgreementLine)
        {
            RoyaltyAgreementLineAmount royaltyAgreementLineAmount = new RoyaltyAgreementLineAmount();
            royaltyAgreementLineAmount.dataAreaId = dataAreaId;
            royaltyAgreementLineAmount.RoyaltyAgreementId = royaltyAgreementId;
            royaltyAgreementLineAmount.RoyaltyAgreementLineId = royaltyAgreementLineId;
            royaltyAgreementLineAmount.LineNumber = lineNumber;
            royaltyAgreementLineAmount.ToNetSalesAmount = toNetSalesAmount;
            royaltyAgreementLineAmount.FromGrossSalesAmount = fromGrossSalesAmount;
            royaltyAgreementLineAmount.FromNetSalesAmount = fromNetSalesAmount;
            royaltyAgreementLineAmount.ToGrossSalesAmount = toGrossSalesAmount;
            royaltyAgreementLineAmount.FixedRoyaltyAmount = fixedRoyaltyAmount;
            royaltyAgreementLineAmount.RoyaltyAmountPerProductUnitSold = royaltyAmountPerProductUnitSold;
            royaltyAgreementLineAmount.SalesPriceQuantity = salesPriceQuantity;
            royaltyAgreementLineAmount.RoyaltyPercentage = royaltyPercentage;
            if ((royaltyAgreementLine == null))
            {
                throw new global::System.ArgumentNullException("royaltyAgreementLine");
            }
            royaltyAgreementLineAmount.RoyaltyAgreementLine = royaltyAgreementLine;
            return royaltyAgreementLineAmount;
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
        /// There are no comments for Property RoyaltyAgreementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RoyaltyAgreementId
        {
            get
            {
                return this._RoyaltyAgreementId;
            }
            set
            {
                this.OnRoyaltyAgreementIdChanging(value);
                this._RoyaltyAgreementId = value;
                this.OnRoyaltyAgreementIdChanged();
                this.OnPropertyChanged("RoyaltyAgreementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoyaltyAgreementId;
        partial void OnRoyaltyAgreementIdChanging(string value);
        partial void OnRoyaltyAgreementIdChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyAgreementLineId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RoyaltyAgreementLineId
        {
            get
            {
                return this._RoyaltyAgreementLineId;
            }
            set
            {
                this.OnRoyaltyAgreementLineIdChanging(value);
                this._RoyaltyAgreementLineId = value;
                this.OnRoyaltyAgreementLineIdChanged();
                this.OnPropertyChanged("RoyaltyAgreementLineId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoyaltyAgreementLineId;
        partial void OnRoyaltyAgreementLineIdChanging(string value);
        partial void OnRoyaltyAgreementLineIdChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long LineNumber
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
        private long _LineNumber;
        partial void OnLineNumberChanging(long value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property ToNetSalesAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ToNetSalesAmount
        {
            get
            {
                return this._ToNetSalesAmount;
            }
            set
            {
                this.OnToNetSalesAmountChanging(value);
                this._ToNetSalesAmount = value;
                this.OnToNetSalesAmountChanged();
                this.OnPropertyChanged("ToNetSalesAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ToNetSalesAmount;
        partial void OnToNetSalesAmountChanging(decimal value);
        partial void OnToNetSalesAmountChanged();
        /// <summary>
        /// There are no comments for Property FromGrossSalesAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal FromGrossSalesAmount
        {
            get
            {
                return this._FromGrossSalesAmount;
            }
            set
            {
                this.OnFromGrossSalesAmountChanging(value);
                this._FromGrossSalesAmount = value;
                this.OnFromGrossSalesAmountChanged();
                this.OnPropertyChanged("FromGrossSalesAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FromGrossSalesAmount;
        partial void OnFromGrossSalesAmountChanging(decimal value);
        partial void OnFromGrossSalesAmountChanged();
        /// <summary>
        /// There are no comments for Property FromNetSalesAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal FromNetSalesAmount
        {
            get
            {
                return this._FromNetSalesAmount;
            }
            set
            {
                this.OnFromNetSalesAmountChanging(value);
                this._FromNetSalesAmount = value;
                this.OnFromNetSalesAmountChanged();
                this.OnPropertyChanged("FromNetSalesAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FromNetSalesAmount;
        partial void OnFromNetSalesAmountChanging(decimal value);
        partial void OnFromNetSalesAmountChanged();
        /// <summary>
        /// There are no comments for Property ToGrossSalesAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ToGrossSalesAmount
        {
            get
            {
                return this._ToGrossSalesAmount;
            }
            set
            {
                this.OnToGrossSalesAmountChanging(value);
                this._ToGrossSalesAmount = value;
                this.OnToGrossSalesAmountChanged();
                this.OnPropertyChanged("ToGrossSalesAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ToGrossSalesAmount;
        partial void OnToGrossSalesAmountChanging(decimal value);
        partial void OnToGrossSalesAmountChanged();
        /// <summary>
        /// There are no comments for Property FixedRoyaltyAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal FixedRoyaltyAmount
        {
            get
            {
                return this._FixedRoyaltyAmount;
            }
            set
            {
                this.OnFixedRoyaltyAmountChanging(value);
                this._FixedRoyaltyAmount = value;
                this.OnFixedRoyaltyAmountChanged();
                this.OnPropertyChanged("FixedRoyaltyAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FixedRoyaltyAmount;
        partial void OnFixedRoyaltyAmountChanging(decimal value);
        partial void OnFixedRoyaltyAmountChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyAmountPerProductUnitSold in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RoyaltyAmountPerProductUnitSold
        {
            get
            {
                return this._RoyaltyAmountPerProductUnitSold;
            }
            set
            {
                this.OnRoyaltyAmountPerProductUnitSoldChanging(value);
                this._RoyaltyAmountPerProductUnitSold = value;
                this.OnRoyaltyAmountPerProductUnitSoldChanged();
                this.OnPropertyChanged("RoyaltyAmountPerProductUnitSold");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RoyaltyAmountPerProductUnitSold;
        partial void OnRoyaltyAmountPerProductUnitSoldChanging(decimal value);
        partial void OnRoyaltyAmountPerProductUnitSoldChanged();
        /// <summary>
        /// There are no comments for Property SalesUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesUnitSymbol
        {
            get
            {
                return this._SalesUnitSymbol;
            }
            set
            {
                this.OnSalesUnitSymbolChanging(value);
                this._SalesUnitSymbol = value;
                this.OnSalesUnitSymbolChanged();
                this.OnPropertyChanged("SalesUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesUnitSymbol;
        partial void OnSalesUnitSymbolChanging(string value);
        partial void OnSalesUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property SalesPriceQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SalesPriceQuantity
        {
            get
            {
                return this._SalesPriceQuantity;
            }
            set
            {
                this.OnSalesPriceQuantityChanging(value);
                this._SalesPriceQuantity = value;
                this.OnSalesPriceQuantityChanged();
                this.OnPropertyChanged("SalesPriceQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SalesPriceQuantity;
        partial void OnSalesPriceQuantityChanging(decimal value);
        partial void OnSalesPriceQuantityChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RoyaltyPercentage
        {
            get
            {
                return this._RoyaltyPercentage;
            }
            set
            {
                this.OnRoyaltyPercentageChanging(value);
                this._RoyaltyPercentage = value;
                this.OnRoyaltyPercentageChanged();
                this.OnPropertyChanged("RoyaltyPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RoyaltyPercentage;
        partial void OnRoyaltyPercentageChanging(decimal value);
        partial void OnRoyaltyPercentageChanged();
        /// <summary>
        /// There are no comments for Property VendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorAccountNumber
        {
            get
            {
                return this._VendorAccountNumber;
            }
            set
            {
                this.OnVendorAccountNumberChanging(value);
                this._VendorAccountNumber = value;
                this.OnVendorAccountNumberChanged();
                this.OnPropertyChanged("VendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAccountNumber;
        partial void OnVendorAccountNumberChanging(string value);
        partial void OnVendorAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyAgreementLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLine RoyaltyAgreementLine
        {
            get
            {
                return this._RoyaltyAgreementLine;
            }
            set
            {
                this.OnRoyaltyAgreementLineChanging(value);
                this._RoyaltyAgreementLine = value;
                this.OnRoyaltyAgreementLineChanged();
                this.OnPropertyChanged("RoyaltyAgreementLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLine _RoyaltyAgreementLine;
        partial void OnRoyaltyAgreementLineChanging(global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLine value);
        partial void OnRoyaltyAgreementLineChanged();
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
