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
        /// There are no comments for ReleasedProductVariantV2Single in the schema.
        /// </summary>
    public partial class ReleasedProductVariantV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<ReleasedProductVariantV2>
    {
        /// <summary>
        /// Initialize a new ReleasedProductVariantV2Single object.
        /// </summary>
        public ReleasedProductVariantV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReleasedProductVariantV2Single object.
        /// </summary>
        public ReleasedProductVariantV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReleasedProductVariantV2Single object.
        /// </summary>
        public ReleasedProductVariantV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<ReleasedProductVariantV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for InventoryCountingJournalLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> InventoryCountingJournalLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._InventoryCountingJournalLines == null))
                {
                    this._InventoryCountingJournalLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine>(GetPath("InventoryCountingJournalLines"));
                }
                return this._InventoryCountingJournalLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> _InventoryCountingJournalLines;
        /// <summary>
        /// There are no comments for ReleasedProductVariantExternalCodesV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantExternalCodeV2> ReleasedProductVariantExternalCodesV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductVariantExternalCodesV2 == null))
                {
                    this._ReleasedProductVariantExternalCodesV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantExternalCodeV2>(GetPath("ReleasedProductVariantExternalCodesV2"));
                }
                return this._ReleasedProductVariantExternalCodesV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantExternalCodeV2> _ReleasedProductVariantExternalCodesV2;
        /// <summary>
        /// There are no comments for ReleasedProductMaster in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterSingle ReleasedProductMaster
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductMaster == null))
                {
                    this._ReleasedProductMaster = new global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterSingle(this.Context, GetPath("ReleasedProductMaster"));
                }
                return this._ReleasedProductMaster;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterSingle _ReleasedProductMaster;
        /// <summary>
        /// There are no comments for ReleasedProductMasterV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2Single ReleasedProductMasterV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductMasterV2 == null))
                {
                    this._ReleasedProductMasterV2 = new global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2Single(this.Context, GetPath("ReleasedProductMasterV2"));
                }
                return this._ReleasedProductMasterV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2Single _ReleasedProductMasterV2;
        /// <summary>
        /// There are no comments for ProductMaster in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductMasterSingle ProductMaster
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductMaster == null))
                {
                    this._ProductMaster = new global::Microsoft.Dynamics.DataEntities.ProductMasterSingle(this.Context, GetPath("ProductMaster"));
                }
                return this._ProductMaster;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductMasterSingle _ProductMaster;
        /// <summary>
        /// There are no comments for ProductLifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductLifecycleStateSingle ProductLifecycleState
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductLifecycleState == null))
                {
                    this._ProductLifecycleState = new global::Microsoft.Dynamics.DataEntities.ProductLifecycleStateSingle(this.Context, GetPath("ProductLifecycleState"));
                }
                return this._ProductLifecycleState;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductLifecycleStateSingle _ProductLifecycleState;
        /// <summary>
        /// There are no comments for ProductVariantV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVariantV2Single ProductVariantV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductVariantV2 == null))
                {
                    this._ProductVariantV2 = new global::Microsoft.Dynamics.DataEntities.ProductVariantV2Single(this.Context, GetPath("ProductVariantV2"));
                }
                return this._ProductVariantV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVariantV2Single _ProductVariantV2;
    }
        /// <summary>
        /// There are no comments for ReleasedProductVariantV2 in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ProductMasterNumber
    /// ProductConfigurationId
    /// ProductSizeId
    /// ProductColorId
    /// ProductStyleId
    /// ProductVersionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProductMasterNumber", "ProductConfigurationId", "ProductSizeId", "ProductColorId", "ProductStyleId", "ProductVersionId")]
    [global::Microsoft.OData.Client.EntitySet("ReleasedProductVariantsV2")]
    public partial class ReleasedProductVariantV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReleasedProductVariantV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="productMasterNumber">Initial value of ProductMasterNumber.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="productVersionId">Initial value of ProductVersionId.</param>
        /// <param name="releasedProductMaster">Initial value of ReleasedProductMaster.</param>
        /// <param name="releasedProductMasterV2">Initial value of ReleasedProductMasterV2.</param>
        /// <param name="productMaster">Initial value of ProductMaster.</param>
        /// <param name="productVariantV2">Initial value of ProductVariantV2.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReleasedProductVariantV2 CreateReleasedProductVariantV2(string dataAreaId, 
                    string productMasterNumber, 
                    string productConfigurationId, 
                    string productSizeId, 
                    string productColorId, 
                    string productStyleId, 
                    string productVersionId, 
                    global::Microsoft.Dynamics.DataEntities.ReleasedProductMaster releasedProductMaster, 
                    global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 releasedProductMasterV2, 
                    global::Microsoft.Dynamics.DataEntities.ProductMaster productMaster, 
                    global::Microsoft.Dynamics.DataEntities.ProductVariantV2 productVariantV2)
        {
            ReleasedProductVariantV2 releasedProductVariantV2 = new ReleasedProductVariantV2();
            releasedProductVariantV2.dataAreaId = dataAreaId;
            releasedProductVariantV2.ProductMasterNumber = productMasterNumber;
            releasedProductVariantV2.ProductConfigurationId = productConfigurationId;
            releasedProductVariantV2.ProductSizeId = productSizeId;
            releasedProductVariantV2.ProductColorId = productColorId;
            releasedProductVariantV2.ProductStyleId = productStyleId;
            releasedProductVariantV2.ProductVersionId = productVersionId;
            if ((releasedProductMaster == null))
            {
                throw new global::System.ArgumentNullException("releasedProductMaster");
            }
            releasedProductVariantV2.ReleasedProductMaster = releasedProductMaster;
            if ((releasedProductMasterV2 == null))
            {
                throw new global::System.ArgumentNullException("releasedProductMasterV2");
            }
            releasedProductVariantV2.ReleasedProductMasterV2 = releasedProductMasterV2;
            if ((productMaster == null))
            {
                throw new global::System.ArgumentNullException("productMaster");
            }
            releasedProductVariantV2.ProductMaster = productMaster;
            if ((productVariantV2 == null))
            {
                throw new global::System.ArgumentNullException("productVariantV2");
            }
            releasedProductVariantV2.ProductVariantV2 = productVariantV2;
            return releasedProductVariantV2;
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
        /// There are no comments for Property ProductMasterNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductMasterNumber
        {
            get
            {
                return this._ProductMasterNumber;
            }
            set
            {
                this.OnProductMasterNumberChanging(value);
                this._ProductMasterNumber = value;
                this.OnProductMasterNumberChanged();
                this.OnPropertyChanged("ProductMasterNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductMasterNumber;
        partial void OnProductMasterNumberChanging(string value);
        partial void OnProductMasterNumberChanged();
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
        /// There are no comments for Property ProductLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductLifecycleStateId
        {
            get
            {
                return this._ProductLifecycleStateId;
            }
            set
            {
                this.OnProductLifecycleStateIdChanging(value);
                this._ProductLifecycleStateId = value;
                this.OnProductLifecycleStateIdChanged();
                this.OnPropertyChanged("ProductLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductLifecycleStateId;
        partial void OnProductLifecycleStateIdChanging(string value);
        partial void OnProductLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property ProductDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductDescription
        {
            get
            {
                return this._ProductDescription;
            }
            set
            {
                this.OnProductDescriptionChanging(value);
                this._ProductDescription = value;
                this.OnProductDescriptionChanged();
                this.OnPropertyChanged("ProductDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductDescription;
        partial void OnProductDescriptionChanging(string value);
        partial void OnProductDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ProductName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this.OnProductNameChanging(value);
                this._ProductName = value;
                this.OnProductNameChanged();
                this.OnPropertyChanged("ProductName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductName;
        partial void OnProductNameChanging(string value);
        partial void OnProductNameChanged();
        /// <summary>
        /// There are no comments for Property ProductVariantNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductVariantNumber
        {
            get
            {
                return this._ProductVariantNumber;
            }
            set
            {
                this.OnProductVariantNumberChanging(value);
                this._ProductVariantNumber = value;
                this.OnProductVariantNumberChanged();
                this.OnPropertyChanged("ProductVariantNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductVariantNumber;
        partial void OnProductVariantNumberChanging(string value);
        partial void OnProductVariantNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductSearchName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductSearchName
        {
            get
            {
                return this._ProductSearchName;
            }
            set
            {
                this.OnProductSearchNameChanging(value);
                this._ProductSearchName = value;
                this.OnProductSearchNameChanged();
                this.OnPropertyChanged("ProductSearchName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductSearchName;
        partial void OnProductSearchNameChanging(string value);
        partial void OnProductSearchNameChanged();
        /// <summary>
        /// There are no comments for Property InventoryCountingJournalLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> InventoryCountingJournalLines
        {
            get
            {
                return this._InventoryCountingJournalLines;
            }
            set
            {
                this.OnInventoryCountingJournalLinesChanging(value);
                this._InventoryCountingJournalLines = value;
                this.OnInventoryCountingJournalLinesChanged();
                this.OnPropertyChanged("InventoryCountingJournalLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> _InventoryCountingJournalLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnInventoryCountingJournalLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> value);
        partial void OnInventoryCountingJournalLinesChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductVariantExternalCodesV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantExternalCodeV2> ReleasedProductVariantExternalCodesV2
        {
            get
            {
                return this._ReleasedProductVariantExternalCodesV2;
            }
            set
            {
                this.OnReleasedProductVariantExternalCodesV2Changing(value);
                this._ReleasedProductVariantExternalCodesV2 = value;
                this.OnReleasedProductVariantExternalCodesV2Changed();
                this.OnPropertyChanged("ReleasedProductVariantExternalCodesV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantExternalCodeV2> _ReleasedProductVariantExternalCodesV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantExternalCodeV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductVariantExternalCodesV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantExternalCodeV2> value);
        partial void OnReleasedProductVariantExternalCodesV2Changed();
        /// <summary>
        /// There are no comments for Property ReleasedProductMaster in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductMaster ReleasedProductMaster
        {
            get
            {
                return this._ReleasedProductMaster;
            }
            set
            {
                this.OnReleasedProductMasterChanging(value);
                this._ReleasedProductMaster = value;
                this.OnReleasedProductMasterChanged();
                this.OnPropertyChanged("ReleasedProductMaster");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductMaster _ReleasedProductMaster;
        partial void OnReleasedProductMasterChanging(global::Microsoft.Dynamics.DataEntities.ReleasedProductMaster value);
        partial void OnReleasedProductMasterChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductMasterV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 ReleasedProductMasterV2
        {
            get
            {
                return this._ReleasedProductMasterV2;
            }
            set
            {
                this.OnReleasedProductMasterV2Changing(value);
                this._ReleasedProductMasterV2 = value;
                this.OnReleasedProductMasterV2Changed();
                this.OnPropertyChanged("ReleasedProductMasterV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 _ReleasedProductMasterV2;
        partial void OnReleasedProductMasterV2Changing(global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 value);
        partial void OnReleasedProductMasterV2Changed();
        /// <summary>
        /// There are no comments for Property ProductMaster in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductMaster ProductMaster
        {
            get
            {
                return this._ProductMaster;
            }
            set
            {
                this.OnProductMasterChanging(value);
                this._ProductMaster = value;
                this.OnProductMasterChanged();
                this.OnPropertyChanged("ProductMaster");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductMaster _ProductMaster;
        partial void OnProductMasterChanging(global::Microsoft.Dynamics.DataEntities.ProductMaster value);
        partial void OnProductMasterChanged();
        /// <summary>
        /// There are no comments for Property ProductLifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductLifecycleState ProductLifecycleState
        {
            get
            {
                return this._ProductLifecycleState;
            }
            set
            {
                this.OnProductLifecycleStateChanging(value);
                this._ProductLifecycleState = value;
                this.OnProductLifecycleStateChanged();
                this.OnPropertyChanged("ProductLifecycleState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductLifecycleState _ProductLifecycleState;
        partial void OnProductLifecycleStateChanging(global::Microsoft.Dynamics.DataEntities.ProductLifecycleState value);
        partial void OnProductLifecycleStateChanged();
        /// <summary>
        /// There are no comments for Property ProductVariantV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVariantV2 ProductVariantV2
        {
            get
            {
                return this._ProductVariantV2;
            }
            set
            {
                this.OnProductVariantV2Changing(value);
                this._ProductVariantV2 = value;
                this.OnProductVariantV2Changed();
                this.OnPropertyChanged("ProductVariantV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVariantV2 _ProductVariantV2;
        partial void OnProductVariantV2Changing(global::Microsoft.Dynamics.DataEntities.ProductVariantV2 value);
        partial void OnProductVariantV2Changed();
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
