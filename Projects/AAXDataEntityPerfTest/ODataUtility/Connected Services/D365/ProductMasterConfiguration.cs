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
        /// There are no comments for ProductMasterConfigurationSingle in the schema.
        /// </summary>
    public partial class ProductMasterConfigurationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductMasterConfiguration>
    {
        /// <summary>
        /// Initialize a new ProductMasterConfigurationSingle object.
        /// </summary>
        public ProductMasterConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductMasterConfigurationSingle object.
        /// </summary>
        public ProductMasterConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductMasterConfigurationSingle object.
        /// </summary>
        public ProductMasterConfigurationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductMasterConfiguration> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductMasterConfigurationTranslations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductMasterConfigurationTranslation> ProductMasterConfigurationTranslations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductMasterConfigurationTranslations == null))
                {
                    this._ProductMasterConfigurationTranslations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductMasterConfigurationTranslation>(GetPath("ProductMasterConfigurationTranslations"));
                }
                return this._ProductMasterConfigurationTranslations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductMasterConfigurationTranslation> _ProductMasterConfigurationTranslations;
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
        /// There are no comments for ProductMasterConfiguration in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ProductMasterNumber
    /// ProductConfigurationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductMasterNumber", "ProductConfigurationId")]
    [global::Microsoft.OData.Client.EntitySet("ProductMasterConfigurations")]
    public partial class ProductMasterConfiguration : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductMasterConfiguration object.
        /// </summary>
        /// <param name="productMasterNumber">Initial value of ProductMasterNumber.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="displaySequenceNumber">Initial value of DisplaySequenceNumber.</param>
        /// <param name="replenishmentWeight">Initial value of ReplenishmentWeight.</param>
        /// <param name="productMaster">Initial value of ProductMaster.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductMasterConfiguration CreateProductMasterConfiguration(string productMasterNumber, string productConfigurationId, decimal displaySequenceNumber, int replenishmentWeight, global::Microsoft.Dynamics.DataEntities.ProductMaster productMaster)
        {
            ProductMasterConfiguration productMasterConfiguration = new ProductMasterConfiguration();
            productMasterConfiguration.ProductMasterNumber = productMasterNumber;
            productMasterConfiguration.ProductConfigurationId = productConfigurationId;
            productMasterConfiguration.DisplaySequenceNumber = displaySequenceNumber;
            productMasterConfiguration.ReplenishmentWeight = replenishmentWeight;
            if ((productMaster == null))
            {
                throw new global::System.ArgumentNullException("productMaster");
            }
            productMasterConfiguration.ProductMaster = productMaster;
            return productMasterConfiguration;
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
        /// There are no comments for Property ContainerUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ContainerUnitSymbol
        {
            get
            {
                return this._ContainerUnitSymbol;
            }
            set
            {
                this.OnContainerUnitSymbolChanging(value);
                this._ContainerUnitSymbol = value;
                this.OnContainerUnitSymbolChanged();
                this.OnPropertyChanged("ContainerUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ContainerUnitSymbol;
        partial void OnContainerUnitSymbolChanging(string value);
        partial void OnContainerUnitSymbolChanged();
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
        /// There are no comments for Property ProductMasterConfigurationTranslations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductMasterConfigurationTranslation> ProductMasterConfigurationTranslations
        {
            get
            {
                return this._ProductMasterConfigurationTranslations;
            }
            set
            {
                this.OnProductMasterConfigurationTranslationsChanging(value);
                this._ProductMasterConfigurationTranslations = value;
                this.OnProductMasterConfigurationTranslationsChanged();
                this.OnPropertyChanged("ProductMasterConfigurationTranslations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductMasterConfigurationTranslation> _ProductMasterConfigurationTranslations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductMasterConfigurationTranslation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductMasterConfigurationTranslationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductMasterConfigurationTranslation> value);
        partial void OnProductMasterConfigurationTranslationsChanged();
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
