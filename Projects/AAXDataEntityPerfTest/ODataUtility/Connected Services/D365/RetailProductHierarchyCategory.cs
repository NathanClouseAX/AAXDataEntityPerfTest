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
        /// There are no comments for RetailProductHierarchyCategorySingle in the schema.
        /// </summary>
    public partial class RetailProductHierarchyCategorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailProductHierarchyCategory>
    {
        /// <summary>
        /// Initialize a new RetailProductHierarchyCategorySingle object.
        /// </summary>
        public RetailProductHierarchyCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailProductHierarchyCategorySingle object.
        /// </summary>
        public RetailProductHierarchyCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailProductHierarchyCategorySingle object.
        /// </summary>
        public RetailProductHierarchyCategorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailProductHierarchyCategory> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductCategoryHierarchy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchySingle ProductCategoryHierarchy
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductCategoryHierarchy == null))
                {
                    this._ProductCategoryHierarchy = new global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchySingle(this.Context, GetPath("ProductCategoryHierarchy"));
                }
                return this._ProductCategoryHierarchy;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchySingle _ProductCategoryHierarchy;
        /// <summary>
        /// There are no comments for RetailEcoResCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailEcoResCategorySingle RetailEcoResCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailEcoResCategory == null))
                {
                    this._RetailEcoResCategory = new global::Microsoft.Dynamics.DataEntities.RetailEcoResCategorySingle(this.Context, GetPath("RetailEcoResCategory"));
                }
                return this._RetailEcoResCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailEcoResCategorySingle _RetailEcoResCategory;
    }
        /// <summary>
        /// There are no comments for RetailProductHierarchyCategory in the schema.
        /// </summary>
    /// <KeyProperties>
    /// CategoryName
    /// CategoryHierarchyName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CategoryName", "CategoryHierarchyName")]
    [global::Microsoft.OData.Client.EntitySet("RetailProductHierarchyCategories")]
    public partial class RetailProductHierarchyCategory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailProductHierarchyCategory object.
        /// </summary>
        /// <param name="categoryName">Initial value of CategoryName.</param>
        /// <param name="categoryHierarchyName">Initial value of CategoryHierarchyName.</param>
        /// <param name="categoryRecordId">Initial value of CategoryRecordId.</param>
        /// <param name="parentCategoryRecordId">Initial value of ParentCategoryRecordId.</param>
        /// <param name="productCategoryHierarchy">Initial value of ProductCategoryHierarchy.</param>
        /// <param name="retailEcoResCategory">Initial value of RetailEcoResCategory.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailProductHierarchyCategory CreateRetailProductHierarchyCategory(string categoryName, 
                    string categoryHierarchyName, 
                    long categoryRecordId, 
                    long parentCategoryRecordId, 
                    global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchy productCategoryHierarchy, 
                    global::Microsoft.Dynamics.DataEntities.RetailEcoResCategory retailEcoResCategory)
        {
            RetailProductHierarchyCategory retailProductHierarchyCategory = new RetailProductHierarchyCategory();
            retailProductHierarchyCategory.CategoryName = categoryName;
            retailProductHierarchyCategory.CategoryHierarchyName = categoryHierarchyName;
            retailProductHierarchyCategory.CategoryRecordId = categoryRecordId;
            retailProductHierarchyCategory.ParentCategoryRecordId = parentCategoryRecordId;
            if ((productCategoryHierarchy == null))
            {
                throw new global::System.ArgumentNullException("productCategoryHierarchy");
            }
            retailProductHierarchyCategory.ProductCategoryHierarchy = productCategoryHierarchy;
            if ((retailEcoResCategory == null))
            {
                throw new global::System.ArgumentNullException("retailEcoResCategory");
            }
            retailProductHierarchyCategory.RetailEcoResCategory = retailEcoResCategory;
            return retailProductHierarchyCategory;
        }
        /// <summary>
        /// There are no comments for Property CategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CategoryName
        {
            get
            {
                return this._CategoryName;
            }
            set
            {
                this.OnCategoryNameChanging(value);
                this._CategoryName = value;
                this.OnCategoryNameChanged();
                this.OnPropertyChanged("CategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryName;
        partial void OnCategoryNameChanging(string value);
        partial void OnCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property CategoryHierarchyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CategoryHierarchyName
        {
            get
            {
                return this._CategoryHierarchyName;
            }
            set
            {
                this.OnCategoryHierarchyNameChanging(value);
                this._CategoryHierarchyName = value;
                this.OnCategoryHierarchyNameChanged();
                this.OnPropertyChanged("CategoryHierarchyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryHierarchyName;
        partial void OnCategoryHierarchyNameChanging(string value);
        partial void OnCategoryHierarchyNameChanged();
        /// <summary>
        /// There are no comments for Property ParentCategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ParentCategoryName
        {
            get
            {
                return this._ParentCategoryName;
            }
            set
            {
                this.OnParentCategoryNameChanging(value);
                this._ParentCategoryName = value;
                this.OnParentCategoryNameChanged();
                this.OnPropertyChanged("ParentCategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentCategoryName;
        partial void OnParentCategoryNameChanging(string value);
        partial void OnParentCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property CategoryRecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long CategoryRecordId
        {
            get
            {
                return this._CategoryRecordId;
            }
            set
            {
                this.OnCategoryRecordIdChanging(value);
                this._CategoryRecordId = value;
                this.OnCategoryRecordIdChanged();
                this.OnPropertyChanged("CategoryRecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _CategoryRecordId;
        partial void OnCategoryRecordIdChanging(long value);
        partial void OnCategoryRecordIdChanged();
        /// <summary>
        /// There are no comments for Property ParentCategoryRecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long ParentCategoryRecordId
        {
            get
            {
                return this._ParentCategoryRecordId;
            }
            set
            {
                this.OnParentCategoryRecordIdChanging(value);
                this._ParentCategoryRecordId = value;
                this.OnParentCategoryRecordIdChanged();
                this.OnPropertyChanged("ParentCategoryRecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _ParentCategoryRecordId;
        partial void OnParentCategoryRecordIdChanging(long value);
        partial void OnParentCategoryRecordIdChanged();
        /// <summary>
        /// There are no comments for Property ProductCategoryHierarchy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchy ProductCategoryHierarchy
        {
            get
            {
                return this._ProductCategoryHierarchy;
            }
            set
            {
                this.OnProductCategoryHierarchyChanging(value);
                this._ProductCategoryHierarchy = value;
                this.OnProductCategoryHierarchyChanged();
                this.OnPropertyChanged("ProductCategoryHierarchy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchy _ProductCategoryHierarchy;
        partial void OnProductCategoryHierarchyChanging(global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchy value);
        partial void OnProductCategoryHierarchyChanged();
        /// <summary>
        /// There are no comments for Property RetailEcoResCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailEcoResCategory RetailEcoResCategory
        {
            get
            {
                return this._RetailEcoResCategory;
            }
            set
            {
                this.OnRetailEcoResCategoryChanging(value);
                this._RetailEcoResCategory = value;
                this.OnRetailEcoResCategoryChanged();
                this.OnPropertyChanged("RetailEcoResCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailEcoResCategory _RetailEcoResCategory;
        partial void OnRetailEcoResCategoryChanging(global::Microsoft.Dynamics.DataEntities.RetailEcoResCategory value);
        partial void OnRetailEcoResCategoryChanged();
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
