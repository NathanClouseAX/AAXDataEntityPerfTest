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
    /// There are no comments for SpecialCategoryMemberSingle in the schema.
    /// </summary>
    public partial class SpecialCategoryMemberSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SpecialCategoryMember>
    {
        /// <summary>
        /// Initialize a new SpecialCategoryMemberSingle object.
        /// </summary>
        public SpecialCategoryMemberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SpecialCategoryMemberSingle object.
        /// </summary>
        public SpecialCategoryMemberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SpecialCategoryMemberSingle object.
        /// </summary>
        public SpecialCategoryMemberSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SpecialCategoryMember> query)
            : base(query) {}

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
        /// <summary>
        /// There are no comments for ProductVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVariantSingle ProductVariant
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductVariant == null))
                {
                    this._ProductVariant = new global::Microsoft.Dynamics.DataEntities.ProductVariantSingle(this.Context, GetPath("ProductVariant"));
                }
                return this._ProductVariant;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVariantSingle _ProductVariant;
    }
    /// <summary>
    /// There are no comments for SpecialCategoryMember in the schema.
    /// </summary>
    /// <KeyProperties>
    /// HeaderProductCategoryHierarchyName
    /// HeaderProductCategoryName
    /// LineProductCategoryHierarchyName
    /// LineProductCategoryName
    /// ProductNumber
    /// ProductVariantNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("HeaderProductCategoryHierarchyName", "HeaderProductCategoryName", "LineProductCategoryHierarchyName", "LineProductCategoryName", "ProductNumber", "ProductVariantNumber")]
    [global::Microsoft.OData.Client.EntitySet("SpecialCategoryMembers")]
    public partial class SpecialCategoryMember : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SpecialCategoryMember object.
        /// </summary>
        /// <param name="headerProductCategoryHierarchyName">Initial value of HeaderProductCategoryHierarchyName.</param>
        /// <param name="headerProductCategoryName">Initial value of HeaderProductCategoryName.</param>
        /// <param name="lineProductCategoryHierarchyName">Initial value of LineProductCategoryHierarchyName.</param>
        /// <param name="lineProductCategoryName">Initial value of LineProductCategoryName.</param>
        /// <param name="productNumber">Initial value of ProductNumber.</param>
        /// <param name="productVariantNumber">Initial value of ProductVariantNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SpecialCategoryMember CreateSpecialCategoryMember(string headerProductCategoryHierarchyName, 
                    string headerProductCategoryName, 
                    string lineProductCategoryHierarchyName, 
                    string lineProductCategoryName, 
                    string productNumber, 
                    string productVariantNumber)
        {
            SpecialCategoryMember specialCategoryMember = new SpecialCategoryMember();
            specialCategoryMember.HeaderProductCategoryHierarchyName = headerProductCategoryHierarchyName;
            specialCategoryMember.HeaderProductCategoryName = headerProductCategoryName;
            specialCategoryMember.LineProductCategoryHierarchyName = lineProductCategoryHierarchyName;
            specialCategoryMember.LineProductCategoryName = lineProductCategoryName;
            specialCategoryMember.ProductNumber = productNumber;
            specialCategoryMember.ProductVariantNumber = productVariantNumber;
            return specialCategoryMember;
        }
        /// <summary>
        /// There are no comments for Property HeaderProductCategoryHierarchyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "HeaderProductCategoryHierarchyName is required.")]
        public virtual string HeaderProductCategoryHierarchyName
        {
            get
            {
                return this._HeaderProductCategoryHierarchyName;
            }
            set
            {
                this.OnHeaderProductCategoryHierarchyNameChanging(value);
                this._HeaderProductCategoryHierarchyName = value;
                this.OnHeaderProductCategoryHierarchyNameChanged();
                this.OnPropertyChanged("HeaderProductCategoryHierarchyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HeaderProductCategoryHierarchyName;
        partial void OnHeaderProductCategoryHierarchyNameChanging(string value);
        partial void OnHeaderProductCategoryHierarchyNameChanged();
        /// <summary>
        /// There are no comments for Property HeaderProductCategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "HeaderProductCategoryName is required.")]
        public virtual string HeaderProductCategoryName
        {
            get
            {
                return this._HeaderProductCategoryName;
            }
            set
            {
                this.OnHeaderProductCategoryNameChanging(value);
                this._HeaderProductCategoryName = value;
                this.OnHeaderProductCategoryNameChanged();
                this.OnPropertyChanged("HeaderProductCategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HeaderProductCategoryName;
        partial void OnHeaderProductCategoryNameChanging(string value);
        partial void OnHeaderProductCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property LineProductCategoryHierarchyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineProductCategoryHierarchyName is required.")]
        public virtual string LineProductCategoryHierarchyName
        {
            get
            {
                return this._LineProductCategoryHierarchyName;
            }
            set
            {
                this.OnLineProductCategoryHierarchyNameChanging(value);
                this._LineProductCategoryHierarchyName = value;
                this.OnLineProductCategoryHierarchyNameChanged();
                this.OnPropertyChanged("LineProductCategoryHierarchyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LineProductCategoryHierarchyName;
        partial void OnLineProductCategoryHierarchyNameChanging(string value);
        partial void OnLineProductCategoryHierarchyNameChanged();
        /// <summary>
        /// There are no comments for Property LineProductCategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineProductCategoryName is required.")]
        public virtual string LineProductCategoryName
        {
            get
            {
                return this._LineProductCategoryName;
            }
            set
            {
                this.OnLineProductCategoryNameChanging(value);
                this._LineProductCategoryName = value;
                this.OnLineProductCategoryNameChanged();
                this.OnPropertyChanged("LineProductCategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LineProductCategoryName;
        partial void OnLineProductCategoryNameChanging(string value);
        partial void OnLineProductCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property ProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductNumber is required.")]
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
        /// There are no comments for Property ProductVariantNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductVariantNumber is required.")]
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
        /// There are no comments for Property ProductCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

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
        /// There are no comments for Property ProductVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.Dynamics.DataEntities.ProductVariant ProductVariant
        {
            get
            {
                return this._ProductVariant;
            }
            set
            {
                this.OnProductVariantChanging(value);
                this._ProductVariant = value;
                this.OnProductVariantChanged();
                this.OnPropertyChanged("ProductVariant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVariant _ProductVariant;
        partial void OnProductVariantChanging(global::Microsoft.Dynamics.DataEntities.ProductVariant value);
        partial void OnProductVariantChanged();
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
