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
    /// There are no comments for ChannelCategoryAttributeSingle in the schema.
    /// </summary>
    public partial class ChannelCategoryAttributeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ChannelCategoryAttribute>
    {
        /// <summary>
        /// Initialize a new ChannelCategoryAttributeSingle object.
        /// </summary>
        public ChannelCategoryAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ChannelCategoryAttributeSingle object.
        /// </summary>
        public ChannelCategoryAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ChannelCategoryAttributeSingle object.
        /// </summary>
        public ChannelCategoryAttributeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ChannelCategoryAttribute> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailChannelSingle RetailChannel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailChannel == null))
                {
                    this._RetailChannel = new global::Microsoft.Dynamics.DataEntities.RetailChannelSingle(this.Context, GetPath("RetailChannel"));
                }
                return this._RetailChannel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailChannelSingle _RetailChannel;
        /// <summary>
        /// There are no comments for ProductCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductCategorySingle ProductCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductCategory == null))
                {
                    this._ProductCategory = new global::Microsoft.Dynamics.DataEntities.ProductCategorySingle(this.Context, GetPath("ProductCategory"));
                }
                return this._ProductCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductCategorySingle _ProductCategory;
    }
    /// <summary>
    /// There are no comments for ChannelCategoryAttribute in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RetailChannelId
    /// ProductCategoryHierarchyName
    /// ProductCategoryName
    /// AttributeName
    /// AttributeTypeName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RetailChannelId", "ProductCategoryHierarchyName", "ProductCategoryName", "AttributeName", "AttributeTypeName")]
    [global::Microsoft.OData.Client.EntitySet("ChannelCategoryAttributes")]
    public partial class ChannelCategoryAttribute : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ChannelCategoryAttribute object.
        /// </summary>
        /// <param name="retailChannelId">Initial value of RetailChannelId.</param>
        /// <param name="productCategoryHierarchyName">Initial value of ProductCategoryHierarchyName.</param>
        /// <param name="productCategoryName">Initial value of ProductCategoryName.</param>
        /// <param name="attributeName">Initial value of AttributeName.</param>
        /// <param name="attributeTypeName">Initial value of AttributeTypeName.</param>
        /// <param name="retailChannel">Initial value of RetailChannel.</param>
        /// <param name="productCategory">Initial value of ProductCategory.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ChannelCategoryAttribute CreateChannelCategoryAttribute(string retailChannelId, 
                    string productCategoryHierarchyName, 
                    string productCategoryName, 
                    string attributeName, 
                    string attributeTypeName, 
                    global::Microsoft.Dynamics.DataEntities.RetailChannel retailChannel, 
                    global::Microsoft.Dynamics.DataEntities.ProductCategory productCategory)
        {
            ChannelCategoryAttribute channelCategoryAttribute = new ChannelCategoryAttribute();
            channelCategoryAttribute.RetailChannelId = retailChannelId;
            channelCategoryAttribute.ProductCategoryHierarchyName = productCategoryHierarchyName;
            channelCategoryAttribute.ProductCategoryName = productCategoryName;
            channelCategoryAttribute.AttributeName = attributeName;
            channelCategoryAttribute.AttributeTypeName = attributeTypeName;
            if ((retailChannel == null))
            {
                throw new global::System.ArgumentNullException("retailChannel");
            }
            channelCategoryAttribute.RetailChannel = retailChannel;
            if ((productCategory == null))
            {
                throw new global::System.ArgumentNullException("productCategory");
            }
            channelCategoryAttribute.ProductCategory = productCategory;
            return channelCategoryAttribute;
        }
        /// <summary>
        /// There are no comments for Property RetailChannelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailChannelId is required.")]
        public virtual string RetailChannelId
        {
            get
            {
                return this._RetailChannelId;
            }
            set
            {
                this.OnRetailChannelIdChanging(value);
                this._RetailChannelId = value;
                this.OnRetailChannelIdChanged();
                this.OnPropertyChanged("RetailChannelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RetailChannelId;
        partial void OnRetailChannelIdChanging(string value);
        partial void OnRetailChannelIdChanged();
        /// <summary>
        /// There are no comments for Property ProductCategoryHierarchyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductCategoryHierarchyName is required.")]
        public virtual string ProductCategoryHierarchyName
        {
            get
            {
                return this._ProductCategoryHierarchyName;
            }
            set
            {
                this.OnProductCategoryHierarchyNameChanging(value);
                this._ProductCategoryHierarchyName = value;
                this.OnProductCategoryHierarchyNameChanged();
                this.OnPropertyChanged("ProductCategoryHierarchyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductCategoryHierarchyName;
        partial void OnProductCategoryHierarchyNameChanging(string value);
        partial void OnProductCategoryHierarchyNameChanged();
        /// <summary>
        /// There are no comments for Property ProductCategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductCategoryName is required.")]
        public virtual string ProductCategoryName
        {
            get
            {
                return this._ProductCategoryName;
            }
            set
            {
                this.OnProductCategoryNameChanging(value);
                this._ProductCategoryName = value;
                this.OnProductCategoryNameChanged();
                this.OnPropertyChanged("ProductCategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductCategoryName;
        partial void OnProductCategoryNameChanging(string value);
        partial void OnProductCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property AttributeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AttributeName is required.")]
        public virtual string AttributeName
        {
            get
            {
                return this._AttributeName;
            }
            set
            {
                this.OnAttributeNameChanging(value);
                this._AttributeName = value;
                this.OnAttributeNameChanged();
                this.OnPropertyChanged("AttributeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeName;
        partial void OnAttributeNameChanging(string value);
        partial void OnAttributeNameChanged();
        /// <summary>
        /// There are no comments for Property AttributeTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AttributeTypeName is required.")]
        public virtual string AttributeTypeName
        {
            get
            {
                return this._AttributeTypeName;
            }
            set
            {
                this.OnAttributeTypeNameChanging(value);
                this._AttributeTypeName = value;
                this.OnAttributeTypeNameChanged();
                this.OnPropertyChanged("AttributeTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeTypeName;
        partial void OnAttributeTypeNameChanging(string value);
        partial void OnAttributeTypeNameChanged();
        /// <summary>
        /// There are no comments for Property RetailChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailChannel is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailChannel RetailChannel
        {
            get
            {
                return this._RetailChannel;
            }
            set
            {
                this.OnRetailChannelChanging(value);
                this._RetailChannel = value;
                this.OnRetailChannelChanged();
                this.OnPropertyChanged("RetailChannel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailChannel _RetailChannel;
        partial void OnRetailChannelChanging(global::Microsoft.Dynamics.DataEntities.RetailChannel value);
        partial void OnRetailChannelChanged();
        /// <summary>
        /// There are no comments for Property ProductCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductCategory is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductCategory ProductCategory
        {
            get
            {
                return this._ProductCategory;
            }
            set
            {
                this.OnProductCategoryChanging(value);
                this._ProductCategory = value;
                this.OnProductCategoryChanged();
                this.OnPropertyChanged("ProductCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductCategory _ProductCategory;
        partial void OnProductCategoryChanging(global::Microsoft.Dynamics.DataEntities.ProductCategory value);
        partial void OnProductCategoryChanged();
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
