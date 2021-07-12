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
        /// There are no comments for ProductSizeGroupSingle in the schema.
        /// </summary>
    public partial class ProductSizeGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductSizeGroup>
    {
        /// <summary>
        /// Initialize a new ProductSizeGroupSingle object.
        /// </summary>
        public ProductSizeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductSizeGroupSingle object.
        /// </summary>
        public ProductSizeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductSizeGroupSingle object.
        /// </summary>
        public ProductSizeGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductSizeGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductSizeGroupLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductSizeGroupLine> ProductSizeGroupLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductSizeGroupLines == null))
                {
                    this._ProductSizeGroupLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductSizeGroupLine>(GetPath("ProductSizeGroupLines"));
                }
                return this._ProductSizeGroupLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductSizeGroupLine> _ProductSizeGroupLines;
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductV2> Products
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Products == null))
                {
                    this._Products = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductV2>(GetPath("Products"));
                }
                return this._Products;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductV2> _Products;
    }
        /// <summary>
        /// There are no comments for ProductSizeGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// GroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("GroupId")]
    [global::Microsoft.OData.Client.EntitySet("ProductSizeGroups")]
    public partial class ProductSizeGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductSizeGroup object.
        /// </summary>
        /// <param name="groupId">Initial value of GroupId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductSizeGroup CreateProductSizeGroup(string groupId)
        {
            ProductSizeGroup productSizeGroup = new ProductSizeGroup();
            productSizeGroup.GroupId = groupId;
            return productSizeGroup;
        }
        /// <summary>
        /// There are no comments for Property GroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupId
        {
            get
            {
                return this._GroupId;
            }
            set
            {
                this.OnGroupIdChanging(value);
                this._GroupId = value;
                this.OnGroupIdChanged();
                this.OnPropertyChanged("GroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupId;
        partial void OnGroupIdChanging(string value);
        partial void OnGroupIdChanged();
        /// <summary>
        /// There are no comments for Property GroupDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupDescription
        {
            get
            {
                return this._GroupDescription;
            }
            set
            {
                this.OnGroupDescriptionChanging(value);
                this._GroupDescription = value;
                this.OnGroupDescriptionChanged();
                this.OnPropertyChanged("GroupDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupDescription;
        partial void OnGroupDescriptionChanging(string value);
        partial void OnGroupDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ProductSizeGroupLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductSizeGroupLine> ProductSizeGroupLines
        {
            get
            {
                return this._ProductSizeGroupLines;
            }
            set
            {
                this.OnProductSizeGroupLinesChanging(value);
                this._ProductSizeGroupLines = value;
                this.OnProductSizeGroupLinesChanged();
                this.OnPropertyChanged("ProductSizeGroupLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductSizeGroupLine> _ProductSizeGroupLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductSizeGroupLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductSizeGroupLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductSizeGroupLine> value);
        partial void OnProductSizeGroupLinesChanged();
        /// <summary>
        /// There are no comments for Property Products in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductV2> Products
        {
            get
            {
                return this._Products;
            }
            set
            {
                this.OnProductsChanging(value);
                this._Products = value;
                this.OnProductsChanged();
                this.OnPropertyChanged("Products");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductV2> _Products = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductV2> value);
        partial void OnProductsChanged();
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
