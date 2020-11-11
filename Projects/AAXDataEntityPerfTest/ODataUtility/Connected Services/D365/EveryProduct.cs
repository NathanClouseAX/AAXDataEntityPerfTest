﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/8/2020 8:07:52 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for EveryProductSingle in the schema.
        /// </summary>
    public partial class EveryProductSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EveryProduct>
    {
        /// <summary>
        /// Initialize a new EveryProductSingle object.
        /// </summary>
        public EveryProductSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EveryProductSingle object.
        /// </summary>
        public EveryProductSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EveryProductSingle object.
        /// </summary>
        public EveryProductSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EveryProduct> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single ReleasedProductV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductV2 == null))
                {
                    this._ReleasedProductV2 = new global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single(this.Context, GetPath("ReleasedProductV2"));
                }
                return this._ReleasedProductV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single _ReleasedProductV2;
        /// <summary>
        /// There are no comments for ProductUnitOfMeasureConversions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductUnitOfMeasureConversion> ProductUnitOfMeasureConversions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductUnitOfMeasureConversions == null))
                {
                    this._ProductUnitOfMeasureConversions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductUnitOfMeasureConversion>(GetPath("ProductUnitOfMeasureConversions"));
                }
                return this._ProductUnitOfMeasureConversions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductUnitOfMeasureConversion> _ProductUnitOfMeasureConversions;
        /// <summary>
        /// There are no comments for ProductSpecificUnitOfMeasureConversions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductSpecificUnitOfMeasureConversion> ProductSpecificUnitOfMeasureConversions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductSpecificUnitOfMeasureConversions == null))
                {
                    this._ProductSpecificUnitOfMeasureConversions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductSpecificUnitOfMeasureConversion>(GetPath("ProductSpecificUnitOfMeasureConversions"));
                }
                return this._ProductSpecificUnitOfMeasureConversions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductSpecificUnitOfMeasureConversion> _ProductSpecificUnitOfMeasureConversions;
    }
        /// <summary>
        /// There are no comments for EveryProduct in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ProductNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductNumber")]
    [global::Microsoft.OData.Client.EntitySet("AllProducts")]
    public partial class EveryProduct : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EveryProduct object.
        /// </summary>
        /// <param name="productNumber">Initial value of ProductNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EveryProduct CreateEveryProduct(string productNumber)
        {
            EveryProduct everyProduct = new EveryProduct();
            everyProduct.ProductNumber = productNumber;
            return everyProduct;
        }
        /// <summary>
        /// There are no comments for Property ProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductNumber
        {
            get
            {
                return this._ProductNumber;
            }
            set
            {
                this.OnProductNumberChanging(value);
                this._ProductNumber = value;
                this.OnProductNumberChanged();
                this.OnPropertyChanged("ProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductNumber;
        partial void OnProductNumberChanging(string value);
        partial void OnProductNumberChanged();
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
        /// There are no comments for Property ReleasedProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 ReleasedProductV2
        {
            get
            {
                return this._ReleasedProductV2;
            }
            set
            {
                this.OnReleasedProductV2Changing(value);
                this._ReleasedProductV2 = value;
                this.OnReleasedProductV2Changed();
                this.OnPropertyChanged("ReleasedProductV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 _ReleasedProductV2;
        partial void OnReleasedProductV2Changing(global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 value);
        partial void OnReleasedProductV2Changed();
        /// <summary>
        /// There are no comments for Property ProductUnitOfMeasureConversions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductUnitOfMeasureConversion> ProductUnitOfMeasureConversions
        {
            get
            {
                return this._ProductUnitOfMeasureConversions;
            }
            set
            {
                this.OnProductUnitOfMeasureConversionsChanging(value);
                this._ProductUnitOfMeasureConversions = value;
                this.OnProductUnitOfMeasureConversionsChanged();
                this.OnPropertyChanged("ProductUnitOfMeasureConversions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductUnitOfMeasureConversion> _ProductUnitOfMeasureConversions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductUnitOfMeasureConversion>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductUnitOfMeasureConversionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductUnitOfMeasureConversion> value);
        partial void OnProductUnitOfMeasureConversionsChanged();
        /// <summary>
        /// There are no comments for Property ProductSpecificUnitOfMeasureConversions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductSpecificUnitOfMeasureConversion> ProductSpecificUnitOfMeasureConversions
        {
            get
            {
                return this._ProductSpecificUnitOfMeasureConversions;
            }
            set
            {
                this.OnProductSpecificUnitOfMeasureConversionsChanging(value);
                this._ProductSpecificUnitOfMeasureConversions = value;
                this.OnProductSpecificUnitOfMeasureConversionsChanged();
                this.OnPropertyChanged("ProductSpecificUnitOfMeasureConversions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductSpecificUnitOfMeasureConversion> _ProductSpecificUnitOfMeasureConversions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductSpecificUnitOfMeasureConversion>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductSpecificUnitOfMeasureConversionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductSpecificUnitOfMeasureConversion> value);
        partial void OnProductSpecificUnitOfMeasureConversionsChanged();
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