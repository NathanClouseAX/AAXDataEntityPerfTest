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
        /// There are no comments for CategorySingle in the schema.
        /// </summary>
    public partial class CategorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Category>
    {
        /// <summary>
        /// Initialize a new CategorySingle object.
        /// </summary>
        public CategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CategorySingle object.
        /// </summary>
        public CategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CategorySingle object.
        /// </summary>
        public CategorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Category> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringProductCategoryDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetailsSingle EngineeringProductCategoryDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringProductCategoryDetails == null))
                {
                    this._EngineeringProductCategoryDetails = new global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetailsSingle(this.Context, GetPath("EngineeringProductCategoryDetails"));
                }
                return this._EngineeringProductCategoryDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetailsSingle _EngineeringProductCategoryDetails;
        /// <summary>
        /// There are no comments for SharedCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.SharedCategorySingle SharedCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SharedCategory == null))
                {
                    this._SharedCategory = new global::Microsoft.Dynamics.DataEntities.SharedCategorySingle(this.Context, GetPath("SharedCategory"));
                }
                return this._SharedCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SharedCategorySingle _SharedCategory;
    }
        /// <summary>
        /// There are no comments for Category in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CategoryId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CategoryId")]
    [global::Microsoft.OData.Client.EntitySet("Categories")]
    public partial class Category : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Category object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="categoryId">Initial value of CategoryId.</param>
        /// <param name="sharedCategory">Initial value of SharedCategory.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Category CreateCategory(string dataAreaId, string categoryId, global::Microsoft.Dynamics.DataEntities.SharedCategory sharedCategory)
        {
            Category category = new Category();
            category.dataAreaId = dataAreaId;
            category.CategoryId = categoryId;
            if ((sharedCategory == null))
            {
                throw new global::System.ArgumentNullException("sharedCategory");
            }
            category.SharedCategory = sharedCategory;
            return category;
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
        /// There are no comments for Property CategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CategoryId
        {
            get
            {
                return this._CategoryId;
            }
            set
            {
                this.OnCategoryIdChanging(value);
                this._CategoryId = value;
                this.OnCategoryIdChanged();
                this.OnPropertyChanged("CategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryId;
        partial void OnCategoryIdChanging(string value);
        partial void OnCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property SharedCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SharedCategoryId
        {
            get
            {
                return this._SharedCategoryId;
            }
            set
            {
                this.OnSharedCategoryIdChanging(value);
                this._SharedCategoryId = value;
                this.OnSharedCategoryIdChanged();
                this.OnPropertyChanged("SharedCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SharedCategoryId;
        partial void OnSharedCategoryIdChanging(string value);
        partial void OnSharedCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property UseInExpense in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseInExpense
        {
            get
            {
                return this._UseInExpense;
            }
            set
            {
                this.OnUseInExpenseChanging(value);
                this._UseInExpense = value;
                this.OnUseInExpenseChanged();
                this.OnPropertyChanged("UseInExpense");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseInExpense;
        partial void OnUseInExpenseChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseInExpenseChanged();
        /// <summary>
        /// There are no comments for Property UseInProject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseInProject
        {
            get
            {
                return this._UseInProject;
            }
            set
            {
                this.OnUseInProjectChanging(value);
                this._UseInProject = value;
                this.OnUseInProjectChanged();
                this.OnPropertyChanged("UseInProject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseInProject;
        partial void OnUseInProjectChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseInProjectChanged();
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
        /// There are no comments for Property UseInProduction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseInProduction
        {
            get
            {
                return this._UseInProduction;
            }
            set
            {
                this.OnUseInProductionChanging(value);
                this._UseInProduction = value;
                this.OnUseInProductionChanged();
                this.OnPropertyChanged("UseInProduction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseInProduction;
        partial void OnUseInProductionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseInProductionChanged();
        /// <summary>
        /// There are no comments for Property EngineeringProductCategoryDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails EngineeringProductCategoryDetails
        {
            get
            {
                return this._EngineeringProductCategoryDetails;
            }
            set
            {
                this.OnEngineeringProductCategoryDetailsChanging(value);
                this._EngineeringProductCategoryDetails = value;
                this.OnEngineeringProductCategoryDetailsChanged();
                this.OnPropertyChanged("EngineeringProductCategoryDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails _EngineeringProductCategoryDetails;
        partial void OnEngineeringProductCategoryDetailsChanging(global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails value);
        partial void OnEngineeringProductCategoryDetailsChanged();
        /// <summary>
        /// There are no comments for Property SharedCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.SharedCategory SharedCategory
        {
            get
            {
                return this._SharedCategory;
            }
            set
            {
                this.OnSharedCategoryChanging(value);
                this._SharedCategory = value;
                this.OnSharedCategoryChanged();
                this.OnPropertyChanged("SharedCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SharedCategory _SharedCategory;
        partial void OnSharedCategoryChanging(global::Microsoft.Dynamics.DataEntities.SharedCategory value);
        partial void OnSharedCategoryChanged();
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
