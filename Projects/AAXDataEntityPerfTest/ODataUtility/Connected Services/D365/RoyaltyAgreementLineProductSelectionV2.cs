﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/28/2021 8:55:09 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for RoyaltyAgreementLineProductSelectionV2Single in the schema.
    /// </summary>
    public partial class RoyaltyAgreementLineProductSelectionV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<RoyaltyAgreementLineProductSelectionV2>
    {
        /// <summary>
        /// Initialize a new RoyaltyAgreementLineProductSelectionV2Single object.
        /// </summary>
        public RoyaltyAgreementLineProductSelectionV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RoyaltyAgreementLineProductSelectionV2Single object.
        /// </summary>
        public RoyaltyAgreementLineProductSelectionV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RoyaltyAgreementLineProductSelectionV2Single object.
        /// </summary>
        public RoyaltyAgreementLineProductSelectionV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<RoyaltyAgreementLineProductSelectionV2> query)
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
    /// There are no comments for RoyaltyAgreementLineProductSelectionV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RoyaltyAgreementLineId
    /// RoyaltyAgreementId
    /// ItemNumber
    /// SalesUnitSymbol
    /// QualifyingSiteId
    /// QualifyingWarehouseId
    /// ProductConfigurationId
    /// ProductColorId
    /// ProductSizeId
    /// ProductStyleId
    /// ProductVersionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RoyaltyAgreementLineId", "RoyaltyAgreementId", "ItemNumber", "SalesUnitSymbol", "QualifyingSiteId", "QualifyingWarehouseId", "ProductConfigurationId", "ProductColorId", "ProductSizeId", "ProductStyleId", "ProductVersionId")]
    [global::Microsoft.OData.Client.EntitySet("RoyaltyAgreementLineProductSelectionsV2")]
    public partial class RoyaltyAgreementLineProductSelectionV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RoyaltyAgreementLineProductSelectionV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="royaltyAgreementLineId">Initial value of RoyaltyAgreementLineId.</param>
        /// <param name="royaltyAgreementId">Initial value of RoyaltyAgreementId.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="salesUnitSymbol">Initial value of SalesUnitSymbol.</param>
        /// <param name="qualifyingSiteId">Initial value of QualifyingSiteId.</param>
        /// <param name="qualifyingWarehouseId">Initial value of QualifyingWarehouseId.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="productVersionId">Initial value of ProductVersionId.</param>
        /// <param name="royaltyAgreementLine">Initial value of RoyaltyAgreementLine.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RoyaltyAgreementLineProductSelectionV2 CreateRoyaltyAgreementLineProductSelectionV2(string dataAreaId, 
                    string royaltyAgreementLineId, 
                    string royaltyAgreementId, 
                    string itemNumber, 
                    string salesUnitSymbol, 
                    string qualifyingSiteId, 
                    string qualifyingWarehouseId, 
                    string productConfigurationId, 
                    string productColorId, 
                    string productSizeId, 
                    string productStyleId, 
                    string productVersionId, 
                    global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLine royaltyAgreementLine)
        {
            RoyaltyAgreementLineProductSelectionV2 royaltyAgreementLineProductSelectionV2 = new RoyaltyAgreementLineProductSelectionV2();
            royaltyAgreementLineProductSelectionV2.dataAreaId = dataAreaId;
            royaltyAgreementLineProductSelectionV2.RoyaltyAgreementLineId = royaltyAgreementLineId;
            royaltyAgreementLineProductSelectionV2.RoyaltyAgreementId = royaltyAgreementId;
            royaltyAgreementLineProductSelectionV2.ItemNumber = itemNumber;
            royaltyAgreementLineProductSelectionV2.SalesUnitSymbol = salesUnitSymbol;
            royaltyAgreementLineProductSelectionV2.QualifyingSiteId = qualifyingSiteId;
            royaltyAgreementLineProductSelectionV2.QualifyingWarehouseId = qualifyingWarehouseId;
            royaltyAgreementLineProductSelectionV2.ProductConfigurationId = productConfigurationId;
            royaltyAgreementLineProductSelectionV2.ProductColorId = productColorId;
            royaltyAgreementLineProductSelectionV2.ProductSizeId = productSizeId;
            royaltyAgreementLineProductSelectionV2.ProductStyleId = productStyleId;
            royaltyAgreementLineProductSelectionV2.ProductVersionId = productVersionId;
            if ((royaltyAgreementLine == null))
            {
                throw new global::System.ArgumentNullException("royaltyAgreementLine");
            }
            royaltyAgreementLineProductSelectionV2.RoyaltyAgreementLine = royaltyAgreementLine;
            return royaltyAgreementLineProductSelectionV2;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "dataAreaId is required.")]
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
        /// There are no comments for Property RoyaltyAgreementLineId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RoyaltyAgreementLineId is required.")]
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
        /// There are no comments for Property RoyaltyAgreementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RoyaltyAgreementId is required.")]
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
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemNumber is required.")]
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
        /// There are no comments for Property SalesUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SalesUnitSymbol is required.")]
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
        /// There are no comments for Property QualifyingSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QualifyingSiteId is required.")]
        public virtual string QualifyingSiteId
        {
            get
            {
                return this._QualifyingSiteId;
            }
            set
            {
                this.OnQualifyingSiteIdChanging(value);
                this._QualifyingSiteId = value;
                this.OnQualifyingSiteIdChanged();
                this.OnPropertyChanged("QualifyingSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QualifyingSiteId;
        partial void OnQualifyingSiteIdChanging(string value);
        partial void OnQualifyingSiteIdChanged();
        /// <summary>
        /// There are no comments for Property QualifyingWarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QualifyingWarehouseId is required.")]
        public virtual string QualifyingWarehouseId
        {
            get
            {
                return this._QualifyingWarehouseId;
            }
            set
            {
                this.OnQualifyingWarehouseIdChanging(value);
                this._QualifyingWarehouseId = value;
                this.OnQualifyingWarehouseIdChanged();
                this.OnPropertyChanged("QualifyingWarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QualifyingWarehouseId;
        partial void OnQualifyingWarehouseIdChanging(string value);
        partial void OnQualifyingWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property ProductConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductConfigurationId is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductColorId is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductSizeId is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductStyleId is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductVersionId is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RoyaltyAgreementLine is required.")]
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
