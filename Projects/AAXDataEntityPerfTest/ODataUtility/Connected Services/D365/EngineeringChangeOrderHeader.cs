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
        /// There are no comments for EngineeringChangeOrderHeaderSingle in the schema.
        /// </summary>
    public partial class EngineeringChangeOrderHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderHeader>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeOrderHeaderSingle object.
        /// </summary>
        public EngineeringChangeOrderHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderHeaderSingle object.
        /// </summary>
        public EngineeringChangeOrderHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderHeaderSingle object.
        /// </summary>
        public EngineeringChangeOrderHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringChangeCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeCategorySingle EngineeringChangeCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeCategory == null))
                {
                    this._EngineeringChangeCategory = new global::Microsoft.Dynamics.DataEntities.EngineeringChangeCategorySingle(this.Context, GetPath("EngineeringChangeCategory"));
                }
                return this._EngineeringChangeCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeCategorySingle _EngineeringChangeCategory;
        /// <summary>
        /// There are no comments for EngineeringChangeSeverity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeSeveritySingle EngineeringChangeSeverity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeSeverity == null))
                {
                    this._EngineeringChangeSeverity = new global::Microsoft.Dynamics.DataEntities.EngineeringChangeSeveritySingle(this.Context, GetPath("EngineeringChangeSeverity"));
                }
                return this._EngineeringChangeSeverity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeSeveritySingle _EngineeringChangeSeverity;
        /// <summary>
        /// There are no comments for ProjectV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectV2Single ProjectV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjectV2 == null))
                {
                    this._ProjectV2 = new global::Microsoft.Dynamics.DataEntities.ProjectV2Single(this.Context, GetPath("ProjectV2"));
                }
                return this._ProjectV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectV2Single _ProjectV2;
        /// <summary>
        /// There are no comments for EngineerWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle EngineerWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineerWorker == null))
                {
                    this._EngineerWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("EngineerWorker"));
                }
                return this._EngineerWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _EngineerWorker;
        /// <summary>
        /// There are no comments for OrderResponsibleWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle OrderResponsibleWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OrderResponsibleWorker == null))
                {
                    this._OrderResponsibleWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("OrderResponsibleWorker"));
                }
                return this._OrderResponsibleWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _OrderResponsibleWorker;
        /// <summary>
        /// There are no comments for EngineeringChangePriority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangePrioritySingle EngineeringChangePriority
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangePriority == null))
                {
                    this._EngineeringChangePriority = new global::Microsoft.Dynamics.DataEntities.EngineeringChangePrioritySingle(this.Context, GetPath("EngineeringChangePriority"));
                }
                return this._EngineeringChangePriority;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangePrioritySingle _EngineeringChangePriority;
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> EngineeringChangeOrderProducts
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProducts == null))
                {
                    this._EngineeringChangeOrderProducts = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct>(GetPath("EngineeringChangeOrderProducts"));
                }
                return this._EngineeringChangeOrderProducts;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> _EngineeringChangeOrderProducts;
        /// <summary>
        /// There are no comments for EngineeringChangeOrderDependencies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderDependency> EngineeringChangeOrderDependencies
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderDependencies == null))
                {
                    this._EngineeringChangeOrderDependencies = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderDependency>(GetPath("EngineeringChangeOrderDependencies"));
                }
                return this._EngineeringChangeOrderDependencies;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderDependency> _EngineeringChangeOrderDependencies;
    }
        /// <summary>
        /// There are no comments for EngineeringChangeOrderHeader in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// OrderNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "OrderNumber")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeOrderHeaders")]
    public partial class EngineeringChangeOrderHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeOrderHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="orderNumber">Initial value of OrderNumber.</param>
        /// <param name="engineeringChangeCategory">Initial value of EngineeringChangeCategory.</param>
        /// <param name="engineeringChangePriority">Initial value of EngineeringChangePriority.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeOrderHeader CreateEngineeringChangeOrderHeader(string dataAreaId, string orderNumber, global::Microsoft.Dynamics.DataEntities.EngineeringChangeCategory engineeringChangeCategory, global::Microsoft.Dynamics.DataEntities.EngineeringChangePriority engineeringChangePriority)
        {
            EngineeringChangeOrderHeader engineeringChangeOrderHeader = new EngineeringChangeOrderHeader();
            engineeringChangeOrderHeader.dataAreaId = dataAreaId;
            engineeringChangeOrderHeader.OrderNumber = orderNumber;
            if ((engineeringChangeCategory == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangeCategory");
            }
            engineeringChangeOrderHeader.EngineeringChangeCategory = engineeringChangeCategory;
            if ((engineeringChangePriority == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangePriority");
            }
            engineeringChangeOrderHeader.EngineeringChangePriority = engineeringChangePriority;
            return engineeringChangeOrderHeader;
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
        /// There are no comments for Property OrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OrderNumber
        {
            get
            {
                return this._OrderNumber;
            }
            set
            {
                this.OnOrderNumberChanging(value);
                this._OrderNumber = value;
                this.OnOrderNumberChanged();
                this.OnPropertyChanged("OrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrderNumber;
        partial void OnOrderNumberChanging(string value);
        partial void OnOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property OrderResponsiblePersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OrderResponsiblePersonnelNumber
        {
            get
            {
                return this._OrderResponsiblePersonnelNumber;
            }
            set
            {
                this.OnOrderResponsiblePersonnelNumberChanging(value);
                this._OrderResponsiblePersonnelNumber = value;
                this.OnOrderResponsiblePersonnelNumberChanged();
                this.OnPropertyChanged("OrderResponsiblePersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrderResponsiblePersonnelNumber;
        partial void OnOrderResponsiblePersonnelNumberChanging(string value);
        partial void OnOrderResponsiblePersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property OrderTitle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OrderTitle
        {
            get
            {
                return this._OrderTitle;
            }
            set
            {
                this.OnOrderTitleChanging(value);
                this._OrderTitle = value;
                this.OnOrderTitleChanged();
                this.OnPropertyChanged("OrderTitle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrderTitle;
        partial void OnOrderTitleChanging(string value);
        partial void OnOrderTitleChanged();
        /// <summary>
        /// There are no comments for Property EngineerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineerPersonnelNumber
        {
            get
            {
                return this._EngineerPersonnelNumber;
            }
            set
            {
                this.OnEngineerPersonnelNumberChanging(value);
                this._EngineerPersonnelNumber = value;
                this.OnEngineerPersonnelNumberChanged();
                this.OnPropertyChanged("EngineerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineerPersonnelNumber;
        partial void OnEngineerPersonnelNumberChanging(string value);
        partial void OnEngineerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeSeverityName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeSeverityName
        {
            get
            {
                return this._EngineeringChangeSeverityName;
            }
            set
            {
                this.OnEngineeringChangeSeverityNameChanging(value);
                this._EngineeringChangeSeverityName = value;
                this.OnEngineeringChangeSeverityNameChanged();
                this.OnPropertyChanged("EngineeringChangeSeverityName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeSeverityName;
        partial void OnEngineeringChangeSeverityNameChanging(string value);
        partial void OnEngineeringChangeSeverityNameChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeCategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeCategoryName
        {
            get
            {
                return this._EngineeringChangeCategoryName;
            }
            set
            {
                this.OnEngineeringChangeCategoryNameChanging(value);
                this._EngineeringChangeCategoryName = value;
                this.OnEngineeringChangeCategoryNameChanged();
                this.OnPropertyChanged("EngineeringChangeCategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeCategoryName;
        partial void OnEngineeringChangeCategoryNameChanging(string value);
        partial void OnEngineeringChangeCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property ProjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjectId
        {
            get
            {
                return this._ProjectId;
            }
            set
            {
                this.OnProjectIdChanging(value);
                this._ProjectId = value;
                this.OnProjectIdChanged();
                this.OnPropertyChanged("ProjectId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectId;
        partial void OnProjectIdChanging(string value);
        partial void OnProjectIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangePriorityName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangePriorityName
        {
            get
            {
                return this._EngineeringChangePriorityName;
            }
            set
            {
                this.OnEngineeringChangePriorityNameChanging(value);
                this._EngineeringChangePriorityName = value;
                this.OnEngineeringChangePriorityNameChanged();
                this.OnPropertyChanged("EngineeringChangePriorityName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangePriorityName;
        partial void OnEngineeringChangePriorityNameChanging(string value);
        partial void OnEngineeringChangePriorityNameChanged();
        /// <summary>
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        /// <summary>
        /// There are no comments for Property ProjectLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjectLegalEntityId
        {
            get
            {
                return this._ProjectLegalEntityId;
            }
            set
            {
                this.OnProjectLegalEntityIdChanging(value);
                this._ProjectLegalEntityId = value;
                this.OnProjectLegalEntityIdChanged();
                this.OnPropertyChanged("ProjectLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectLegalEntityId;
        partial void OnProjectLegalEntityIdChanging(string value);
        partial void OnProjectLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeCategory EngineeringChangeCategory
        {
            get
            {
                return this._EngineeringChangeCategory;
            }
            set
            {
                this.OnEngineeringChangeCategoryChanging(value);
                this._EngineeringChangeCategory = value;
                this.OnEngineeringChangeCategoryChanged();
                this.OnPropertyChanged("EngineeringChangeCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeCategory _EngineeringChangeCategory;
        partial void OnEngineeringChangeCategoryChanging(global::Microsoft.Dynamics.DataEntities.EngineeringChangeCategory value);
        partial void OnEngineeringChangeCategoryChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeSeverity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeSeverity EngineeringChangeSeverity
        {
            get
            {
                return this._EngineeringChangeSeverity;
            }
            set
            {
                this.OnEngineeringChangeSeverityChanging(value);
                this._EngineeringChangeSeverity = value;
                this.OnEngineeringChangeSeverityChanged();
                this.OnPropertyChanged("EngineeringChangeSeverity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeSeverity _EngineeringChangeSeverity;
        partial void OnEngineeringChangeSeverityChanging(global::Microsoft.Dynamics.DataEntities.EngineeringChangeSeverity value);
        partial void OnEngineeringChangeSeverityChanged();
        /// <summary>
        /// There are no comments for Property ProjectV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectV2 ProjectV2
        {
            get
            {
                return this._ProjectV2;
            }
            set
            {
                this.OnProjectV2Changing(value);
                this._ProjectV2 = value;
                this.OnProjectV2Changed();
                this.OnPropertyChanged("ProjectV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectV2 _ProjectV2;
        partial void OnProjectV2Changing(global::Microsoft.Dynamics.DataEntities.ProjectV2 value);
        partial void OnProjectV2Changed();
        /// <summary>
        /// There are no comments for Property EngineerWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker EngineerWorker
        {
            get
            {
                return this._EngineerWorker;
            }
            set
            {
                this.OnEngineerWorkerChanging(value);
                this._EngineerWorker = value;
                this.OnEngineerWorkerChanged();
                this.OnPropertyChanged("EngineerWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _EngineerWorker;
        partial void OnEngineerWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnEngineerWorkerChanged();
        /// <summary>
        /// There are no comments for Property OrderResponsibleWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker OrderResponsibleWorker
        {
            get
            {
                return this._OrderResponsibleWorker;
            }
            set
            {
                this.OnOrderResponsibleWorkerChanging(value);
                this._OrderResponsibleWorker = value;
                this.OnOrderResponsibleWorkerChanged();
                this.OnPropertyChanged("OrderResponsibleWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _OrderResponsibleWorker;
        partial void OnOrderResponsibleWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnOrderResponsibleWorkerChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangePriority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangePriority EngineeringChangePriority
        {
            get
            {
                return this._EngineeringChangePriority;
            }
            set
            {
                this.OnEngineeringChangePriorityChanging(value);
                this._EngineeringChangePriority = value;
                this.OnEngineeringChangePriorityChanged();
                this.OnPropertyChanged("EngineeringChangePriority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangePriority _EngineeringChangePriority;
        partial void OnEngineeringChangePriorityChanging(global::Microsoft.Dynamics.DataEntities.EngineeringChangePriority value);
        partial void OnEngineeringChangePriorityChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> EngineeringChangeOrderProducts
        {
            get
            {
                return this._EngineeringChangeOrderProducts;
            }
            set
            {
                this.OnEngineeringChangeOrderProductsChanging(value);
                this._EngineeringChangeOrderProducts = value;
                this.OnEngineeringChangeOrderProductsChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProducts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> _EngineeringChangeOrderProducts = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeOrderProductsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> value);
        partial void OnEngineeringChangeOrderProductsChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderDependencies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderDependency> EngineeringChangeOrderDependencies
        {
            get
            {
                return this._EngineeringChangeOrderDependencies;
            }
            set
            {
                this.OnEngineeringChangeOrderDependenciesChanging(value);
                this._EngineeringChangeOrderDependencies = value;
                this.OnEngineeringChangeOrderDependenciesChanged();
                this.OnPropertyChanged("EngineeringChangeOrderDependencies");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderDependency> _EngineeringChangeOrderDependencies = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderDependency>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeOrderDependenciesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderDependency> value);
        partial void OnEngineeringChangeOrderDependenciesChanged();
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
