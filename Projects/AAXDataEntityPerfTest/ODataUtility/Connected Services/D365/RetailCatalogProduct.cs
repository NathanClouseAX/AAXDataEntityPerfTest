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
        /// There are no comments for RetailCatalogProductSingle in the schema.
        /// </summary>
    public partial class RetailCatalogProductSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailCatalogProduct>
    {
        /// <summary>
        /// Initialize a new RetailCatalogProductSingle object.
        /// </summary>
        public RetailCatalogProductSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailCatalogProductSingle object.
        /// </summary>
        public RetailCatalogProductSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailCatalogProductSingle object.
        /// </summary>
        public RetailCatalogProductSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailCatalogProduct> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailCatalog in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle RetailCatalog
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalog == null))
                {
                    this._RetailCatalog = new global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle(this.Context, GetPath("RetailCatalog"));
                }
                return this._RetailCatalog;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle _RetailCatalog;
        /// <summary>
        /// There are no comments for RetailCatalogProductAttributeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalogProductAttributeValueSingle RetailCatalogProductAttributeValue
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalogProductAttributeValue == null))
                {
                    this._RetailCatalogProductAttributeValue = new global::Microsoft.Dynamics.DataEntities.RetailCatalogProductAttributeValueSingle(this.Context, GetPath("RetailCatalogProductAttributeValue"));
                }
                return this._RetailCatalogProductAttributeValue;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalogProductAttributeValueSingle _RetailCatalogProductAttributeValue;
        /// <summary>
        /// There are no comments for RetailCatalogInternalOrganizationProductAttributeValue2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> RetailCatalogInternalOrganizationProductAttributeValue2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalogInternalOrganizationProductAttributeValue2 == null))
                {
                    this._RetailCatalogInternalOrganizationProductAttributeValue2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2>(GetPath("RetailCatalogInternalOrganizationProductAttributeValue2"));
                }
                return this._RetailCatalogInternalOrganizationProductAttributeValue2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> _RetailCatalogInternalOrganizationProductAttributeValue2;
        /// <summary>
        /// There are no comments for RetailCatalogProductCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogProductCategory> RetailCatalogProductCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalogProductCategory == null))
                {
                    this._RetailCatalogProductCategory = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogProductCategory>(GetPath("RetailCatalogProductCategory"));
                }
                return this._RetailCatalogProductCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogProductCategory> _RetailCatalogProductCategory;
        /// <summary>
        /// There are no comments for RetailCatalogInternalOrganizationProductAttributeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue> RetailCatalogInternalOrganizationProductAttributeValue
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalogInternalOrganizationProductAttributeValue == null))
                {
                    this._RetailCatalogInternalOrganizationProductAttributeValue = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue>(GetPath("RetailCatalogInternalOrganizationProductAttributeValue"));
                }
                return this._RetailCatalogInternalOrganizationProductAttributeValue;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue> _RetailCatalogInternalOrganizationProductAttributeValue;
    }
        /// <summary>
        /// There are no comments for RetailCatalogProduct in the schema.
        /// </summary>
    /// <KeyProperties>
    /// CatalogNumber
    /// DisplayProductNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CatalogNumber", "DisplayProductNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailCatalogProducts")]
    public partial class RetailCatalogProduct : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailCatalogProduct object.
        /// </summary>
        /// <param name="catalogNumber">Initial value of CatalogNumber.</param>
        /// <param name="displayProductNumber">Initial value of DisplayProductNumber.</param>
        /// <param name="displayOrder">Initial value of DisplayOrder.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailCatalogProduct CreateRetailCatalogProduct(string catalogNumber, string displayProductNumber, decimal displayOrder)
        {
            RetailCatalogProduct retailCatalogProduct = new RetailCatalogProduct();
            retailCatalogProduct.CatalogNumber = catalogNumber;
            retailCatalogProduct.DisplayProductNumber = displayProductNumber;
            retailCatalogProduct.DisplayOrder = displayOrder;
            return retailCatalogProduct;
        }
        /// <summary>
        /// There are no comments for Property CatalogNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CatalogNumber
        {
            get
            {
                return this._CatalogNumber;
            }
            set
            {
                this.OnCatalogNumberChanging(value);
                this._CatalogNumber = value;
                this.OnCatalogNumberChanged();
                this.OnPropertyChanged("CatalogNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CatalogNumber;
        partial void OnCatalogNumberChanging(string value);
        partial void OnCatalogNumberChanged();
        /// <summary>
        /// There are no comments for Property DisplayProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DisplayProductNumber
        {
            get
            {
                return this._DisplayProductNumber;
            }
            set
            {
                this.OnDisplayProductNumberChanging(value);
                this._DisplayProductNumber = value;
                this.OnDisplayProductNumberChanged();
                this.OnPropertyChanged("DisplayProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DisplayProductNumber;
        partial void OnDisplayProductNumberChanging(string value);
        partial void OnDisplayProductNumberChanged();
        /// <summary>
        /// There are no comments for Property DisplayOrder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DisplayOrder
        {
            get
            {
                return this._DisplayOrder;
            }
            set
            {
                this.OnDisplayOrderChanging(value);
                this._DisplayOrder = value;
                this.OnDisplayOrderChanged();
                this.OnPropertyChanged("DisplayOrder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DisplayOrder;
        partial void OnDisplayOrderChanging(decimal value);
        partial void OnDisplayOrderChanged();
        /// <summary>
        /// There are no comments for Property UseHierarchy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseHierarchy
        {
            get
            {
                return this._UseHierarchy;
            }
            set
            {
                this.OnUseHierarchyChanging(value);
                this._UseHierarchy = value;
                this.OnUseHierarchyChanged();
                this.OnPropertyChanged("UseHierarchy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseHierarchy;
        partial void OnUseHierarchyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseHierarchyChanged();
        /// <summary>
        /// There are no comments for Property RetailCatalog in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalog RetailCatalog
        {
            get
            {
                return this._RetailCatalog;
            }
            set
            {
                this.OnRetailCatalogChanging(value);
                this._RetailCatalog = value;
                this.OnRetailCatalogChanged();
                this.OnPropertyChanged("RetailCatalog");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalog _RetailCatalog;
        partial void OnRetailCatalogChanging(global::Microsoft.Dynamics.DataEntities.RetailCatalog value);
        partial void OnRetailCatalogChanged();
        /// <summary>
        /// There are no comments for Property RetailCatalogProductAttributeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalogProductAttributeValue RetailCatalogProductAttributeValue
        {
            get
            {
                return this._RetailCatalogProductAttributeValue;
            }
            set
            {
                this.OnRetailCatalogProductAttributeValueChanging(value);
                this._RetailCatalogProductAttributeValue = value;
                this.OnRetailCatalogProductAttributeValueChanged();
                this.OnPropertyChanged("RetailCatalogProductAttributeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalogProductAttributeValue _RetailCatalogProductAttributeValue;
        partial void OnRetailCatalogProductAttributeValueChanging(global::Microsoft.Dynamics.DataEntities.RetailCatalogProductAttributeValue value);
        partial void OnRetailCatalogProductAttributeValueChanged();
        /// <summary>
        /// There are no comments for Property RetailCatalogInternalOrganizationProductAttributeValue2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> RetailCatalogInternalOrganizationProductAttributeValue2
        {
            get
            {
                return this._RetailCatalogInternalOrganizationProductAttributeValue2;
            }
            set
            {
                this.OnRetailCatalogInternalOrganizationProductAttributeValue2Changing(value);
                this._RetailCatalogInternalOrganizationProductAttributeValue2 = value;
                this.OnRetailCatalogInternalOrganizationProductAttributeValue2Changed();
                this.OnPropertyChanged("RetailCatalogInternalOrganizationProductAttributeValue2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> _RetailCatalogInternalOrganizationProductAttributeValue2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailCatalogInternalOrganizationProductAttributeValue2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> value);
        partial void OnRetailCatalogInternalOrganizationProductAttributeValue2Changed();
        /// <summary>
        /// There are no comments for Property RetailCatalogProductCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogProductCategory> RetailCatalogProductCategory
        {
            get
            {
                return this._RetailCatalogProductCategory;
            }
            set
            {
                this.OnRetailCatalogProductCategoryChanging(value);
                this._RetailCatalogProductCategory = value;
                this.OnRetailCatalogProductCategoryChanged();
                this.OnPropertyChanged("RetailCatalogProductCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogProductCategory> _RetailCatalogProductCategory = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogProductCategory>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailCatalogProductCategoryChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogProductCategory> value);
        partial void OnRetailCatalogProductCategoryChanged();
        /// <summary>
        /// There are no comments for Property RetailCatalogInternalOrganizationProductAttributeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue> RetailCatalogInternalOrganizationProductAttributeValue
        {
            get
            {
                return this._RetailCatalogInternalOrganizationProductAttributeValue;
            }
            set
            {
                this.OnRetailCatalogInternalOrganizationProductAttributeValueChanging(value);
                this._RetailCatalogInternalOrganizationProductAttributeValue = value;
                this.OnRetailCatalogInternalOrganizationProductAttributeValueChanged();
                this.OnPropertyChanged("RetailCatalogInternalOrganizationProductAttributeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue> _RetailCatalogInternalOrganizationProductAttributeValue = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailCatalogInternalOrganizationProductAttributeValueChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue> value);
        partial void OnRetailCatalogInternalOrganizationProductAttributeValueChanged();
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
