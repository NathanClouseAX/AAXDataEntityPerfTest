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
        /// There are no comments for ProjectOnAccForecastSingle in the schema.
        /// </summary>
    public partial class ProjectOnAccForecastSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectOnAccForecast>
    {
        /// <summary>
        /// Initialize a new ProjectOnAccForecastSingle object.
        /// </summary>
        public ProjectOnAccForecastSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjectOnAccForecastSingle object.
        /// </summary>
        public ProjectOnAccForecastSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjectOnAccForecastSingle object.
        /// </summary>
        public ProjectOnAccForecastSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectOnAccForecast> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Project in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectSingle Project
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Project == null))
                {
                    this._Project = new global::Microsoft.Dynamics.DataEntities.ProjectSingle(this.Context, GetPath("Project"));
                }
                return this._Project;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectSingle _Project;
        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
        /// <summary>
        /// There are no comments for ProjectOnAccForecast in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TransactionID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TransactionID")]
    [global::Microsoft.OData.Client.EntitySet("ProjectOnAccForecasts")]
    public partial class ProjectOnAccForecast : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjectOnAccForecast object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="transactionID">Initial value of TransactionID.</param>
        /// <param name="eliminationDate">Initial value of EliminationDate.</param>
        /// <param name="invoiceDate">Initial value of InvoiceDate.</param>
        /// <param name="projectDate">Initial value of ProjectDate.</param>
        /// <param name="salesPaymentDate">Initial value of SalesPaymentDate.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="exchangeRate">Initial value of ExchangeRate.</param>
        /// <param name="salesPrice">Initial value of SalesPrice.</param>
        /// <param name="project">Initial value of Project.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjectOnAccForecast CreateProjectOnAccForecast(string dataAreaId, 
                    string transactionID, 
                    global::System.DateTimeOffset eliminationDate, 
                    global::System.DateTimeOffset invoiceDate, 
                    global::System.DateTimeOffset projectDate, 
                    global::System.DateTimeOffset salesPaymentDate, 
                    decimal quantity, 
                    decimal exchangeRate, 
                    decimal salesPrice, 
                    global::Microsoft.Dynamics.DataEntities.Project project)
        {
            ProjectOnAccForecast projectOnAccForecast = new ProjectOnAccForecast();
            projectOnAccForecast.dataAreaId = dataAreaId;
            projectOnAccForecast.TransactionID = transactionID;
            projectOnAccForecast.EliminationDate = eliminationDate;
            projectOnAccForecast.InvoiceDate = invoiceDate;
            projectOnAccForecast.ProjectDate = projectDate;
            projectOnAccForecast.SalesPaymentDate = salesPaymentDate;
            projectOnAccForecast.Quantity = quantity;
            projectOnAccForecast.ExchangeRate = exchangeRate;
            projectOnAccForecast.SalesPrice = salesPrice;
            if ((project == null))
            {
                throw new global::System.ArgumentNullException("project");
            }
            projectOnAccForecast.Project = project;
            return projectOnAccForecast;
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
        /// There are no comments for Property TransactionID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TransactionID
        {
            get
            {
                return this._TransactionID;
            }
            set
            {
                this.OnTransactionIDChanging(value);
                this._TransactionID = value;
                this.OnTransactionIDChanged();
                this.OnPropertyChanged("TransactionID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionID;
        partial void OnTransactionIDChanging(string value);
        partial void OnTransactionIDChanged();
        /// <summary>
        /// There are no comments for Property DefaultDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultDimensionDisplayValue
        {
            get
            {
                return this._DefaultDimensionDisplayValue;
            }
            set
            {
                this.OnDefaultDimensionDisplayValueChanging(value);
                this._DefaultDimensionDisplayValue = value;
                this.OnDefaultDimensionDisplayValueChanged();
                this.OnPropertyChanged("DefaultDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultDimensionDisplayValue;
        partial void OnDefaultDimensionDisplayValueChanging(string value);
        partial void OnDefaultDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property BudgetType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjForecastBudgetType> BudgetType
        {
            get
            {
                return this._BudgetType;
            }
            set
            {
                this.OnBudgetTypeChanging(value);
                this._BudgetType = value;
                this.OnBudgetTypeChanged();
                this.OnPropertyChanged("BudgetType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjForecastBudgetType> _BudgetType;
        partial void OnBudgetTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjForecastBudgetType> value);
        partial void OnBudgetTypeChanged();
        /// <summary>
        /// There are no comments for Property ProjectContractID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjectContractID
        {
            get
            {
                return this._ProjectContractID;
            }
            set
            {
                this.OnProjectContractIDChanging(value);
                this._ProjectContractID = value;
                this.OnProjectContractIDChanged();
                this.OnPropertyChanged("ProjectContractID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectContractID;
        partial void OnProjectContractIDChanging(string value);
        partial void OnProjectContractIDChanged();
        /// <summary>
        /// There are no comments for Property EliminationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EliminationDate
        {
            get
            {
                return this._EliminationDate;
            }
            set
            {
                this.OnEliminationDateChanging(value);
                this._EliminationDate = value;
                this.OnEliminationDateChanged();
                this.OnPropertyChanged("EliminationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EliminationDate;
        partial void OnEliminationDateChanging(global::System.DateTimeOffset value);
        partial void OnEliminationDateChanged();
        /// <summary>
        /// There are no comments for Property InvoiceDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset InvoiceDate
        {
            get
            {
                return this._InvoiceDate;
            }
            set
            {
                this.OnInvoiceDateChanging(value);
                this._InvoiceDate = value;
                this.OnInvoiceDateChanged();
                this.OnPropertyChanged("InvoiceDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _InvoiceDate;
        partial void OnInvoiceDateChanging(global::System.DateTimeOffset value);
        partial void OnInvoiceDateChanged();
        /// <summary>
        /// There are no comments for Property ProjectDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ProjectDate
        {
            get
            {
                return this._ProjectDate;
            }
            set
            {
                this.OnProjectDateChanging(value);
                this._ProjectDate = value;
                this.OnProjectDateChanged();
                this.OnPropertyChanged("ProjectDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ProjectDate;
        partial void OnProjectDateChanging(global::System.DateTimeOffset value);
        partial void OnProjectDateChanged();
        /// <summary>
        /// There are no comments for Property SalesCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesCurrency
        {
            get
            {
                return this._SalesCurrency;
            }
            set
            {
                this.OnSalesCurrencyChanging(value);
                this._SalesCurrency = value;
                this.OnSalesCurrencyChanged();
                this.OnPropertyChanged("SalesCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesCurrency;
        partial void OnSalesCurrencyChanging(string value);
        partial void OnSalesCurrencyChanged();
        /// <summary>
        /// There are no comments for Property SalesPaymentDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset SalesPaymentDate
        {
            get
            {
                return this._SalesPaymentDate;
            }
            set
            {
                this.OnSalesPaymentDateChanging(value);
                this._SalesPaymentDate = value;
                this.OnSalesPaymentDateChanged();
                this.OnPropertyChanged("SalesPaymentDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _SalesPaymentDate;
        partial void OnSalesPaymentDateChanging(global::System.DateTimeOffset value);
        partial void OnSalesPaymentDateChanged();
        /// <summary>
        /// There are no comments for Property ProjectID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjectID
        {
            get
            {
                return this._ProjectID;
            }
            set
            {
                this.OnProjectIDChanging(value);
                this._ProjectID = value;
                this.OnProjectIDChanged();
                this.OnPropertyChanged("ProjectID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectID;
        partial void OnProjectIDChanging(string value);
        partial void OnProjectIDChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Quantity;
        partial void OnQuantityChanging(decimal value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property ForecastModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ForecastModel
        {
            get
            {
                return this._ForecastModel;
            }
            set
            {
                this.OnForecastModelChanging(value);
                this._ForecastModel = value;
                this.OnForecastModelChanged();
                this.OnPropertyChanged("ForecastModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ForecastModel;
        partial void OnForecastModelChanging(string value);
        partial void OnForecastModelChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ExchangeRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ExchangeRate
        {
            get
            {
                return this._ExchangeRate;
            }
            set
            {
                this.OnExchangeRateChanging(value);
                this._ExchangeRate = value;
                this.OnExchangeRateChanged();
                this.OnPropertyChanged("ExchangeRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExchangeRate;
        partial void OnExchangeRateChanging(decimal value);
        partial void OnExchangeRateChanged();
        /// <summary>
        /// There are no comments for Property SalesPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SalesPrice
        {
            get
            {
                return this._SalesPrice;
            }
            set
            {
                this.OnSalesPriceChanging(value);
                this._SalesPrice = value;
                this.OnSalesPriceChanged();
                this.OnPropertyChanged("SalesPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SalesPrice;
        partial void OnSalesPriceChanging(decimal value);
        partial void OnSalesPriceChanged();
        /// <summary>
        /// There are no comments for Property FundingSourceID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FundingSourceID
        {
            get
            {
                return this._FundingSourceID;
            }
            set
            {
                this.OnFundingSourceIDChanging(value);
                this._FundingSourceID = value;
                this.OnFundingSourceIDChanged();
                this.OnPropertyChanged("FundingSourceID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FundingSourceID;
        partial void OnFundingSourceIDChanging(string value);
        partial void OnFundingSourceIDChanged();
        /// <summary>
        /// There are no comments for Property Project in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Project Project
        {
            get
            {
                return this._Project;
            }
            set
            {
                this.OnProjectChanging(value);
                this._Project = value;
                this.OnProjectChanged();
                this.OnPropertyChanged("Project");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Project _Project;
        partial void OnProjectChanging(global::Microsoft.Dynamics.DataEntities.Project value);
        partial void OnProjectChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
