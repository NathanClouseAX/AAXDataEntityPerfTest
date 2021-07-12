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
        /// There are no comments for ProductMasterStyleSingle in the schema.
        /// </summary>
    public partial class ProductMasterStyleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductMasterStyle>
    {
        /// <summary>
        /// Initialize a new ProductMasterStyleSingle object.
        /// </summary>
        public ProductMasterStyleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductMasterStyleSingle object.
        /// </summary>
        public ProductMasterStyleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductMasterStyleSingle object.
        /// </summary>
        public ProductMasterStyleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductMasterStyle> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductMasterStyleTranslations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductMasterStyleTranslation> ProductMasterStyleTranslations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductMasterStyleTranslations == null))
                {
                    this._ProductMasterStyleTranslations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductMasterStyleTranslation>(GetPath("ProductMasterStyleTranslations"));
                }
                return this._ProductMasterStyleTranslations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductMasterStyleTranslation> _ProductMasterStyleTranslations;
        /// <summary>
        /// There are no comments for ProductStyle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductStyleSingle ProductStyle
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductStyle == null))
                {
                    this._ProductStyle = new global::Microsoft.Dynamics.DataEntities.ProductStyleSingle(this.Context, GetPath("ProductStyle"));
                }
                return this._ProductStyle;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductStyleSingle _ProductStyle;
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
    }
        /// <summary>
        /// There are no comments for ProductMasterStyle in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ProductMasterNumber
    /// ProductStyleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductMasterNumber", "ProductStyleId")]
    [global::Microsoft.OData.Client.EntitySet("ProductMasterStyles")]
    public partial class ProductMasterStyle : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductMasterStyle object.
        /// </summary>
        /// <param name="productMasterNumber">Initial value of ProductMasterNumber.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="displaySequenceNumber">Initial value of DisplaySequenceNumber.</param>
        /// <param name="replenishmentWeight">Initial value of ReplenishmentWeight.</param>
        /// <param name="productStyle">Initial value of ProductStyle.</param>
        /// <param name="productMaster">Initial value of ProductMaster.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductMasterStyle CreateProductMasterStyle(string productMasterNumber, 
                    string productStyleId, 
                    decimal displaySequenceNumber, 
                    int replenishmentWeight, 
                    global::Microsoft.Dynamics.DataEntities.ProductStyle productStyle, 
                    global::Microsoft.Dynamics.DataEntities.ProductMaster productMaster)
        {
            ProductMasterStyle productMasterStyle = new ProductMasterStyle();
            productMasterStyle.ProductMasterNumber = productMasterNumber;
            productMasterStyle.ProductStyleId = productStyleId;
            productMasterStyle.DisplaySequenceNumber = displaySequenceNumber;
            productMasterStyle.ReplenishmentWeight = replenishmentWeight;
            if ((productStyle == null))
            {
                throw new global::System.ArgumentNullException("productStyle");
            }
            productMasterStyle.ProductStyle = productStyle;
            if ((productMaster == null))
            {
                throw new global::System.ArgumentNullException("productMaster");
            }
            productMasterStyle.ProductMaster = productMaster;
            return productMasterStyle;
        }
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
        /// There are no comments for Property DisplaySequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DisplaySequenceNumber
        {
            get
            {
                return this._DisplaySequenceNumber;
            }
            set
            {
                this.OnDisplaySequenceNumberChanging(value);
                this._DisplaySequenceNumber = value;
                this.OnDisplaySequenceNumberChanged();
                this.OnPropertyChanged("DisplaySequenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DisplaySequenceNumber;
        partial void OnDisplaySequenceNumberChanging(decimal value);
        partial void OnDisplaySequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property ReplenishmentWeight in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int ReplenishmentWeight
        {
            get
            {
                return this._ReplenishmentWeight;
            }
            set
            {
                this.OnReplenishmentWeightChanging(value);
                this._ReplenishmentWeight = value;
                this.OnReplenishmentWeightChanged();
                this.OnPropertyChanged("ReplenishmentWeight");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ReplenishmentWeight;
        partial void OnReplenishmentWeightChanging(int value);
        partial void OnReplenishmentWeightChanged();
        /// <summary>
        /// There are no comments for Property ProductMasterStyleTranslations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductMasterStyleTranslation> ProductMasterStyleTranslations
        {
            get
            {
                return this._ProductMasterStyleTranslations;
            }
            set
            {
                this.OnProductMasterStyleTranslationsChanging(value);
                this._ProductMasterStyleTranslations = value;
                this.OnProductMasterStyleTranslationsChanged();
                this.OnPropertyChanged("ProductMasterStyleTranslations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductMasterStyleTranslation> _ProductMasterStyleTranslations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductMasterStyleTranslation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductMasterStyleTranslationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductMasterStyleTranslation> value);
        partial void OnProductMasterStyleTranslationsChanged();
        /// <summary>
        /// There are no comments for Property ProductStyle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductStyle ProductStyle
        {
            get
            {
                return this._ProductStyle;
            }
            set
            {
                this.OnProductStyleChanging(value);
                this._ProductStyle = value;
                this.OnProductStyleChanged();
                this.OnPropertyChanged("ProductStyle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductStyle _ProductStyle;
        partial void OnProductStyleChanging(global::Microsoft.Dynamics.DataEntities.ProductStyle value);
        partial void OnProductStyleChanged();
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
