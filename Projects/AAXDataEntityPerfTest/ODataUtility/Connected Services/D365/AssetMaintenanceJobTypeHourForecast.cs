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
    /// There are no comments for AssetMaintenanceJobTypeHourForecastSingle in the schema.
    /// </summary>
    public partial class AssetMaintenanceJobTypeHourForecastSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceJobTypeHourForecast>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceJobTypeHourForecastSingle object.
        /// </summary>
        public AssetMaintenanceJobTypeHourForecastSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceJobTypeHourForecastSingle object.
        /// </summary>
        public AssetMaintenanceJobTypeHourForecastSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceJobTypeHourForecastSingle object.
        /// </summary>
        public AssetMaintenanceJobTypeHourForecastSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceJobTypeHourForecast> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AssetMaintenanceJobTypeHourForecast in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MaintenanceAssetId
    /// FunctionalLocationId
    /// JobTradeId
    /// JobTypeId
    /// JobVariantId
    /// ModelId
    /// ModelProductId
    /// MaintenanceAssetTypeId
    /// ProductId
    /// ForecastCategoryId
    /// ForecastLinePropertyId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MaintenanceAssetId", "FunctionalLocationId", "JobTradeId", "JobTypeId", "JobVariantId", "ModelId", "ModelProductId", "MaintenanceAssetTypeId", "ProductId", "ForecastCategoryId", "ForecastLinePropertyId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceJobTypeHourForecasts")]
    public partial class AssetMaintenanceJobTypeHourForecast : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceJobTypeHourForecast object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="maintenanceAssetId">Initial value of MaintenanceAssetId.</param>
        /// <param name="functionalLocationId">Initial value of FunctionalLocationId.</param>
        /// <param name="jobTradeId">Initial value of JobTradeId.</param>
        /// <param name="jobTypeId">Initial value of JobTypeId.</param>
        /// <param name="jobVariantId">Initial value of JobVariantId.</param>
        /// <param name="modelId">Initial value of ModelId.</param>
        /// <param name="modelProductId">Initial value of ModelProductId.</param>
        /// <param name="maintenanceAssetTypeId">Initial value of MaintenanceAssetTypeId.</param>
        /// <param name="productId">Initial value of ProductId.</param>
        /// <param name="forecastCategoryId">Initial value of ForecastCategoryId.</param>
        /// <param name="forecastLinePropertyId">Initial value of ForecastLinePropertyId.</param>
        /// <param name="forecastHours">Initial value of ForecastHours.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceJobTypeHourForecast CreateAssetMaintenanceJobTypeHourForecast(string dataAreaId, 
                    string maintenanceAssetId, 
                    string functionalLocationId, 
                    string jobTradeId, 
                    string jobTypeId, 
                    string jobVariantId, 
                    string modelId, 
                    string modelProductId, 
                    string maintenanceAssetTypeId, 
                    string productId, 
                    string forecastCategoryId, 
                    string forecastLinePropertyId, 
                    decimal forecastHours)
        {
            AssetMaintenanceJobTypeHourForecast assetMaintenanceJobTypeHourForecast = new AssetMaintenanceJobTypeHourForecast();
            assetMaintenanceJobTypeHourForecast.dataAreaId = dataAreaId;
            assetMaintenanceJobTypeHourForecast.MaintenanceAssetId = maintenanceAssetId;
            assetMaintenanceJobTypeHourForecast.FunctionalLocationId = functionalLocationId;
            assetMaintenanceJobTypeHourForecast.JobTradeId = jobTradeId;
            assetMaintenanceJobTypeHourForecast.JobTypeId = jobTypeId;
            assetMaintenanceJobTypeHourForecast.JobVariantId = jobVariantId;
            assetMaintenanceJobTypeHourForecast.ModelId = modelId;
            assetMaintenanceJobTypeHourForecast.ModelProductId = modelProductId;
            assetMaintenanceJobTypeHourForecast.MaintenanceAssetTypeId = maintenanceAssetTypeId;
            assetMaintenanceJobTypeHourForecast.ProductId = productId;
            assetMaintenanceJobTypeHourForecast.ForecastCategoryId = forecastCategoryId;
            assetMaintenanceJobTypeHourForecast.ForecastLinePropertyId = forecastLinePropertyId;
            assetMaintenanceJobTypeHourForecast.ForecastHours = forecastHours;
            return assetMaintenanceJobTypeHourForecast;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "dataAreaId is required.")]
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
        /// There are no comments for Property MaintenanceAssetId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaintenanceAssetId is required.")]
        public virtual string MaintenanceAssetId
        {
            get
            {
                return this._MaintenanceAssetId;
            }
            set
            {
                this.OnMaintenanceAssetIdChanging(value);
                this._MaintenanceAssetId = value;
                this.OnMaintenanceAssetIdChanged();
                this.OnPropertyChanged("MaintenanceAssetId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetId;
        partial void OnMaintenanceAssetIdChanging(string value);
        partial void OnMaintenanceAssetIdChanged();
        /// <summary>
        /// There are no comments for Property FunctionalLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FunctionalLocationId is required.")]
        public virtual string FunctionalLocationId
        {
            get
            {
                return this._FunctionalLocationId;
            }
            set
            {
                this.OnFunctionalLocationIdChanging(value);
                this._FunctionalLocationId = value;
                this.OnFunctionalLocationIdChanged();
                this.OnPropertyChanged("FunctionalLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FunctionalLocationId;
        partial void OnFunctionalLocationIdChanging(string value);
        partial void OnFunctionalLocationIdChanged();
        /// <summary>
        /// There are no comments for Property JobTradeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JobTradeId is required.")]
        public virtual string JobTradeId
        {
            get
            {
                return this._JobTradeId;
            }
            set
            {
                this.OnJobTradeIdChanging(value);
                this._JobTradeId = value;
                this.OnJobTradeIdChanged();
                this.OnPropertyChanged("JobTradeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTradeId;
        partial void OnJobTradeIdChanging(string value);
        partial void OnJobTradeIdChanged();
        /// <summary>
        /// There are no comments for Property JobTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JobTypeId is required.")]
        public virtual string JobTypeId
        {
            get
            {
                return this._JobTypeId;
            }
            set
            {
                this.OnJobTypeIdChanging(value);
                this._JobTypeId = value;
                this.OnJobTypeIdChanged();
                this.OnPropertyChanged("JobTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTypeId;
        partial void OnJobTypeIdChanging(string value);
        partial void OnJobTypeIdChanged();
        /// <summary>
        /// There are no comments for Property JobVariantId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JobVariantId is required.")]
        public virtual string JobVariantId
        {
            get
            {
                return this._JobVariantId;
            }
            set
            {
                this.OnJobVariantIdChanging(value);
                this._JobVariantId = value;
                this.OnJobVariantIdChanged();
                this.OnPropertyChanged("JobVariantId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobVariantId;
        partial void OnJobVariantIdChanging(string value);
        partial void OnJobVariantIdChanged();
        /// <summary>
        /// There are no comments for Property ModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ModelId is required.")]
        public virtual string ModelId
        {
            get
            {
                return this._ModelId;
            }
            set
            {
                this.OnModelIdChanging(value);
                this._ModelId = value;
                this.OnModelIdChanged();
                this.OnPropertyChanged("ModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModelId;
        partial void OnModelIdChanging(string value);
        partial void OnModelIdChanged();
        /// <summary>
        /// There are no comments for Property ModelProductId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ModelProductId is required.")]
        public virtual string ModelProductId
        {
            get
            {
                return this._ModelProductId;
            }
            set
            {
                this.OnModelProductIdChanging(value);
                this._ModelProductId = value;
                this.OnModelProductIdChanged();
                this.OnPropertyChanged("ModelProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModelProductId;
        partial void OnModelProductIdChanging(string value);
        partial void OnModelProductIdChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceAssetTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaintenanceAssetTypeId is required.")]
        public virtual string MaintenanceAssetTypeId
        {
            get
            {
                return this._MaintenanceAssetTypeId;
            }
            set
            {
                this.OnMaintenanceAssetTypeIdChanging(value);
                this._MaintenanceAssetTypeId = value;
                this.OnMaintenanceAssetTypeIdChanged();
                this.OnPropertyChanged("MaintenanceAssetTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetTypeId;
        partial void OnMaintenanceAssetTypeIdChanging(string value);
        partial void OnMaintenanceAssetTypeIdChanged();
        /// <summary>
        /// There are no comments for Property ProductId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductId is required.")]
        public virtual string ProductId
        {
            get
            {
                return this._ProductId;
            }
            set
            {
                this.OnProductIdChanging(value);
                this._ProductId = value;
                this.OnProductIdChanged();
                this.OnPropertyChanged("ProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductId;
        partial void OnProductIdChanging(string value);
        partial void OnProductIdChanged();
        /// <summary>
        /// There are no comments for Property ForecastCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ForecastCategoryId is required.")]
        public virtual string ForecastCategoryId
        {
            get
            {
                return this._ForecastCategoryId;
            }
            set
            {
                this.OnForecastCategoryIdChanging(value);
                this._ForecastCategoryId = value;
                this.OnForecastCategoryIdChanged();
                this.OnPropertyChanged("ForecastCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ForecastCategoryId;
        partial void OnForecastCategoryIdChanging(string value);
        partial void OnForecastCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property ForecastLinePropertyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ForecastLinePropertyId is required.")]
        public virtual string ForecastLinePropertyId
        {
            get
            {
                return this._ForecastLinePropertyId;
            }
            set
            {
                this.OnForecastLinePropertyIdChanging(value);
                this._ForecastLinePropertyId = value;
                this.OnForecastLinePropertyIdChanged();
                this.OnPropertyChanged("ForecastLinePropertyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ForecastLinePropertyId;
        partial void OnForecastLinePropertyIdChanging(string value);
        partial void OnForecastLinePropertyIdChanged();
        /// <summary>
        /// There are no comments for Property ForecastHours in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ForecastHours is required.")]
        public virtual decimal ForecastHours
        {
            get
            {
                return this._ForecastHours;
            }
            set
            {
                this.OnForecastHoursChanging(value);
                this._ForecastHours = value;
                this.OnForecastHoursChanged();
                this.OnPropertyChanged("ForecastHours");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ForecastHours;
        partial void OnForecastHoursChanging(decimal value);
        partial void OnForecastHoursChanged();
        /// <summary>
        /// There are no comments for Property ForecastCurrencyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ForecastCurrencyId
        {
            get
            {
                return this._ForecastCurrencyId;
            }
            set
            {
                this.OnForecastCurrencyIdChanging(value);
                this._ForecastCurrencyId = value;
                this.OnForecastCurrencyIdChanged();
                this.OnPropertyChanged("ForecastCurrencyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ForecastCurrencyId;
        partial void OnForecastCurrencyIdChanging(string value);
        partial void OnForecastCurrencyIdChanged();
        /// <summary>
        /// There are no comments for Property ForecastModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ForecastModelId
        {
            get
            {
                return this._ForecastModelId;
            }
            set
            {
                this.OnForecastModelIdChanging(value);
                this._ForecastModelId = value;
                this.OnForecastModelIdChanged();
                this.OnPropertyChanged("ForecastModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ForecastModelId;
        partial void OnForecastModelIdChanging(string value);
        partial void OnForecastModelIdChanged();
        /// <summary>
        /// There are no comments for Property ForecastProjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ForecastProjectId
        {
            get
            {
                return this._ForecastProjectId;
            }
            set
            {
                this.OnForecastProjectIdChanging(value);
                this._ForecastProjectId = value;
                this.OnForecastProjectIdChanged();
                this.OnPropertyChanged("ForecastProjectId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ForecastProjectId;
        partial void OnForecastProjectIdChanging(string value);
        partial void OnForecastProjectIdChanged();
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
