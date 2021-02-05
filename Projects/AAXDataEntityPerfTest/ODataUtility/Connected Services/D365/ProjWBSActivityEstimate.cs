﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for ProjWBSActivityEstimateSingle in the schema.
        /// </summary>
    public partial class ProjWBSActivityEstimateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjWBSActivityEstimate>
    {
        /// <summary>
        /// Initialize a new ProjWBSActivityEstimateSingle object.
        /// </summary>
        public ProjWBSActivityEstimateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjWBSActivityEstimateSingle object.
        /// </summary>
        public ProjWBSActivityEstimateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjWBSActivityEstimateSingle object.
        /// </summary>
        public ProjWBSActivityEstimateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjWBSActivityEstimate> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProjectCategories in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectCategoryEntitySingle ProjectCategories
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjectCategories == null))
                {
                    this._ProjectCategories = new global::Microsoft.Dynamics.DataEntities.ProjectCategoryEntitySingle(this.Context, GetPath("ProjectCategories"));
                }
                return this._ProjectCategories;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectCategoryEntitySingle _ProjectCategories;
    }
        /// <summary>
        /// There are no comments for ProjWBSActivityEstimate in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ProjectId
    /// WBSId
    /// TransactionType
    /// Category
    /// ResourceCategory
    /// ItemNumber
    /// SalesCategory
    /// LineProperty
    /// Quantity
    /// UnitCostPrice
    /// UnitSalesPrice
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProjectId", "WBSId", "TransactionType", "Category", "ResourceCategory", "ItemNumber", "SalesCategory", "LineProperty", "Quantity", "UnitCostPrice", "UnitSalesPrice")]
    [global::Microsoft.OData.Client.EntitySet("ProjWBSActivityEstimates")]
    public partial class ProjWBSActivityEstimate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjWBSActivityEstimate object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="projectId">Initial value of ProjectId.</param>
        /// <param name="wBSId">Initial value of WBSId.</param>
        /// <param name="category">Initial value of Category.</param>
        /// <param name="resourceCategory">Initial value of ResourceCategory.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="salesCategory">Initial value of SalesCategory.</param>
        /// <param name="lineProperty">Initial value of LineProperty.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="unitCostPrice">Initial value of UnitCostPrice.</param>
        /// <param name="unitSalesPrice">Initial value of UnitSalesPrice.</param>
        /// <param name="totalSalesPrice">Initial value of TotalSalesPrice.</param>
        /// <param name="totalCostPrice">Initial value of TotalCostPrice.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjWBSActivityEstimate CreateProjWBSActivityEstimate(string dataAreaId, 
                    string projectId, 
                    string wBSId, 
                    string category, 
                    string resourceCategory, 
                    string itemNumber, 
                    string salesCategory, 
                    string lineProperty, 
                    decimal quantity, 
                    decimal unitCostPrice, 
                    decimal unitSalesPrice, 
                    decimal totalSalesPrice, 
                    decimal totalCostPrice)
        {
            ProjWBSActivityEstimate projWBSActivityEstimate = new ProjWBSActivityEstimate();
            projWBSActivityEstimate.dataAreaId = dataAreaId;
            projWBSActivityEstimate.ProjectId = projectId;
            projWBSActivityEstimate.WBSId = wBSId;
            projWBSActivityEstimate.Category = category;
            projWBSActivityEstimate.ResourceCategory = resourceCategory;
            projWBSActivityEstimate.ItemNumber = itemNumber;
            projWBSActivityEstimate.SalesCategory = salesCategory;
            projWBSActivityEstimate.LineProperty = lineProperty;
            projWBSActivityEstimate.Quantity = quantity;
            projWBSActivityEstimate.UnitCostPrice = unitCostPrice;
            projWBSActivityEstimate.UnitSalesPrice = unitSalesPrice;
            projWBSActivityEstimate.TotalSalesPrice = totalSalesPrice;
            projWBSActivityEstimate.TotalCostPrice = totalCostPrice;
            return projWBSActivityEstimate;
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
        /// There are no comments for Property ProjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjectId
        {
            get
            {
                return this._ProjectId;
            }
            set
            {
                this.OnProjectIdChanging(value);
                this._ProjectId = value;
                this.OnProjectIdChanged();
                this.OnPropertyChanged("ProjectId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectId;
        partial void OnProjectIdChanging(string value);
        partial void OnProjectIdChanged();
        /// <summary>
        /// There are no comments for Property WBSId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WBSId
        {
            get
            {
                return this._WBSId;
            }
            set
            {
                this.OnWBSIdChanging(value);
                this._WBSId = value;
                this.OnWBSIdChanged();
                this.OnPropertyChanged("WBSId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WBSId;
        partial void OnWBSIdChanging(string value);
        partial void OnWBSIdChanged();
        /// <summary>
        /// There are no comments for Property TransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.QuotationProjTransType> TransactionType
        {
            get
            {
                return this._TransactionType;
            }
            set
            {
                this.OnTransactionTypeChanging(value);
                this._TransactionType = value;
                this.OnTransactionTypeChanged();
                this.OnPropertyChanged("TransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.QuotationProjTransType> _TransactionType;
        partial void OnTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.QuotationProjTransType> value);
        partial void OnTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property Category in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this.OnCategoryChanging(value);
                this._Category = value;
                this.OnCategoryChanged();
                this.OnPropertyChanged("Category");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Category;
        partial void OnCategoryChanging(string value);
        partial void OnCategoryChanged();
        /// <summary>
        /// There are no comments for Property ResourceCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ResourceCategory
        {
            get
            {
                return this._ResourceCategory;
            }
            set
            {
                this.OnResourceCategoryChanging(value);
                this._ResourceCategory = value;
                this.OnResourceCategoryChanged();
                this.OnPropertyChanged("ResourceCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResourceCategory;
        partial void OnResourceCategoryChanging(string value);
        partial void OnResourceCategoryChanged();
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
        /// There are no comments for Property SalesCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesCategory
        {
            get
            {
                return this._SalesCategory;
            }
            set
            {
                this.OnSalesCategoryChanging(value);
                this._SalesCategory = value;
                this.OnSalesCategoryChanged();
                this.OnPropertyChanged("SalesCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesCategory;
        partial void OnSalesCategoryChanging(string value);
        partial void OnSalesCategoryChanged();
        /// <summary>
        /// There are no comments for Property LineProperty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LineProperty
        {
            get
            {
                return this._LineProperty;
            }
            set
            {
                this.OnLinePropertyChanging(value);
                this._LineProperty = value;
                this.OnLinePropertyChanged();
                this.OnPropertyChanged("LineProperty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LineProperty;
        partial void OnLinePropertyChanging(string value);
        partial void OnLinePropertyChanged();
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
        /// There are no comments for Property UnitCostPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal UnitCostPrice
        {
            get
            {
                return this._UnitCostPrice;
            }
            set
            {
                this.OnUnitCostPriceChanging(value);
                this._UnitCostPrice = value;
                this.OnUnitCostPriceChanged();
                this.OnPropertyChanged("UnitCostPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _UnitCostPrice;
        partial void OnUnitCostPriceChanging(decimal value);
        partial void OnUnitCostPriceChanged();
        /// <summary>
        /// There are no comments for Property UnitSalesPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal UnitSalesPrice
        {
            get
            {
                return this._UnitSalesPrice;
            }
            set
            {
                this.OnUnitSalesPriceChanging(value);
                this._UnitSalesPrice = value;
                this.OnUnitSalesPriceChanged();
                this.OnPropertyChanged("UnitSalesPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _UnitSalesPrice;
        partial void OnUnitSalesPriceChanging(decimal value);
        partial void OnUnitSalesPriceChanged();
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
        /// There are no comments for Property TotalSalesPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TotalSalesPrice
        {
            get
            {
                return this._TotalSalesPrice;
            }
            set
            {
                this.OnTotalSalesPriceChanging(value);
                this._TotalSalesPrice = value;
                this.OnTotalSalesPriceChanged();
                this.OnPropertyChanged("TotalSalesPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalSalesPrice;
        partial void OnTotalSalesPriceChanging(decimal value);
        partial void OnTotalSalesPriceChanged();
        /// <summary>
        /// There are no comments for Property TotalCostPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TotalCostPrice
        {
            get
            {
                return this._TotalCostPrice;
            }
            set
            {
                this.OnTotalCostPriceChanging(value);
                this._TotalCostPrice = value;
                this.OnTotalCostPriceChanged();
                this.OnPropertyChanged("TotalCostPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalCostPrice;
        partial void OnTotalCostPriceChanging(decimal value);
        partial void OnTotalCostPriceChanged();
        /// <summary>
        /// There are no comments for Property TaskName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaskName
        {
            get
            {
                return this._TaskName;
            }
            set
            {
                this.OnTaskNameChanging(value);
                this._TaskName = value;
                this.OnTaskNameChanged();
                this.OnPropertyChanged("TaskName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaskName;
        partial void OnTaskNameChanging(string value);
        partial void OnTaskNameChanged();
        /// <summary>
        /// There are no comments for Property ProjectCategories in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectCategoryEntity ProjectCategories
        {
            get
            {
                return this._ProjectCategories;
            }
            set
            {
                this.OnProjectCategoriesChanging(value);
                this._ProjectCategories = value;
                this.OnProjectCategoriesChanged();
                this.OnPropertyChanged("ProjectCategories");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectCategoryEntity _ProjectCategories;
        partial void OnProjectCategoriesChanging(global::Microsoft.Dynamics.DataEntities.ProjectCategoryEntity value);
        partial void OnProjectCategoriesChanged();
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
