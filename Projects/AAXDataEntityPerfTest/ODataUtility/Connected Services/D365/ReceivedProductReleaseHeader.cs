﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/3/2021 8:21:45 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for ReceivedProductReleaseHeaderSingle in the schema.
        /// </summary>
    public partial class ReceivedProductReleaseHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ReceivedProductReleaseHeader>
    {
        /// <summary>
        /// Initialize a new ReceivedProductReleaseHeaderSingle object.
        /// </summary>
        public ReceivedProductReleaseHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReceivedProductReleaseHeaderSingle object.
        /// </summary>
        public ReceivedProductReleaseHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReceivedProductReleaseHeaderSingle object.
        /// </summary>
        public ReceivedProductReleaseHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ReceivedProductReleaseHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CancellorWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle CancellorWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CancellorWorker == null))
                {
                    this._CancellorWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("CancellorWorker"));
                }
                return this._CancellorWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _CancellorWorker;
        /// <summary>
        /// There are no comments for ReceivingSite in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle ReceivingSite
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReceivingSite == null))
                {
                    this._ReceivingSite = new global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle(this.Context, GetPath("ReceivingSite"));
                }
                return this._ReceivingSite;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle _ReceivingSite;
        /// <summary>
        /// There are no comments for EngineeringProductVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionSingle EngineeringProductVersion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringProductVersion == null))
                {
                    this._EngineeringProductVersion = new global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionSingle(this.Context, GetPath("EngineeringProductVersion"));
                }
                return this._EngineeringProductVersion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionSingle _EngineeringProductVersion;
        /// <summary>
        /// There are no comments for ReleasingSite in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle ReleasingSite
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasingSite == null))
                {
                    this._ReleasingSite = new global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle(this.Context, GetPath("ReleasingSite"));
                }
                return this._ReleasingSite;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle _ReleasingSite;
        /// <summary>
        /// There are no comments for ProcessorWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle ProcessorWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProcessorWorker == null))
                {
                    this._ProcessorWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("ProcessorWorker"));
                }
                return this._ProcessorWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _ProcessorWorker;
        /// <summary>
        /// There are no comments for ReceivedProductReleaseLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> ReceivedProductReleaseLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReceivedProductReleaseLines == null))
                {
                    this._ReceivedProductReleaseLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine>(GetPath("ReceivedProductReleaseLines"));
                }
                return this._ReceivedProductReleaseLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> _ReceivedProductReleaseLines;
    }
        /// <summary>
        /// There are no comments for ReceivedProductReleaseHeader in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ProductNumber
    /// ReleasingLegalEntityId
    /// ReleaseStatus
    /// ProductVersionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProductNumber", "ReleasingLegalEntityId", "ReleaseStatus", "ProductVersionId")]
    [global::Microsoft.OData.Client.EntitySet("ReceivedProductReleaseHeaders")]
    public partial class ReceivedProductReleaseHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReceivedProductReleaseHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="productNumber">Initial value of ProductNumber.</param>
        /// <param name="releasingLegalEntityId">Initial value of ReleasingLegalEntityId.</param>
        /// <param name="productVersionId">Initial value of ProductVersionId.</param>
        /// <param name="cancelledDateTime">Initial value of CancelledDateTime.</param>
        /// <param name="processedDateTime">Initial value of ProcessedDateTime.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReceivedProductReleaseHeader CreateReceivedProductReleaseHeader(string dataAreaId, 
                    string productNumber, 
                    string releasingLegalEntityId, 
                    string productVersionId, 
                    global::System.DateTimeOffset cancelledDateTime, 
                    global::System.DateTimeOffset processedDateTime)
        {
            ReceivedProductReleaseHeader receivedProductReleaseHeader = new ReceivedProductReleaseHeader();
            receivedProductReleaseHeader.dataAreaId = dataAreaId;
            receivedProductReleaseHeader.ProductNumber = productNumber;
            receivedProductReleaseHeader.ReleasingLegalEntityId = releasingLegalEntityId;
            receivedProductReleaseHeader.ProductVersionId = productVersionId;
            receivedProductReleaseHeader.CancelledDateTime = cancelledDateTime;
            receivedProductReleaseHeader.ProcessedDateTime = processedDateTime;
            return receivedProductReleaseHeader;
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
        /// There are no comments for Property ReleasingLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReleasingLegalEntityId
        {
            get
            {
                return this._ReleasingLegalEntityId;
            }
            set
            {
                this.OnReleasingLegalEntityIdChanging(value);
                this._ReleasingLegalEntityId = value;
                this.OnReleasingLegalEntityIdChanged();
                this.OnPropertyChanged("ReleasingLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReleasingLegalEntityId;
        partial void OnReleasingLegalEntityIdChanging(string value);
        partial void OnReleasingLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property ReleaseStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReleaseStatus> ReleaseStatus
        {
            get
            {
                return this._ReleaseStatus;
            }
            set
            {
                this.OnReleaseStatusChanging(value);
                this._ReleaseStatus = value;
                this.OnReleaseStatusChanged();
                this.OnPropertyChanged("ReleaseStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReleaseStatus> _ReleaseStatus;
        partial void OnReleaseStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReleaseStatus> value);
        partial void OnReleaseStatusChanged();
        /// <summary>
        /// There are no comments for Property ProductVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductVersionId
        {
            get
            {
                return this._ProductVersionId;
            }
            set
            {
                this.OnProductVersionIdChanging(value);
                this._ProductVersionId = value;
                this.OnProductVersionIdChanged();
                this.OnPropertyChanged("ProductVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductVersionId;
        partial void OnProductVersionIdChanging(string value);
        partial void OnProductVersionIdChanged();
        /// <summary>
        /// There are no comments for Property ReleaseNotes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReleaseNotes
        {
            get
            {
                return this._ReleaseNotes;
            }
            set
            {
                this.OnReleaseNotesChanging(value);
                this._ReleaseNotes = value;
                this.OnReleaseNotesChanged();
                this.OnPropertyChanged("ReleaseNotes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReleaseNotes;
        partial void OnReleaseNotesChanging(string value);
        partial void OnReleaseNotesChanged();
        /// <summary>
        /// There are no comments for Property CancelledDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset CancelledDateTime
        {
            get
            {
                return this._CancelledDateTime;
            }
            set
            {
                this.OnCancelledDateTimeChanging(value);
                this._CancelledDateTime = value;
                this.OnCancelledDateTimeChanged();
                this.OnPropertyChanged("CancelledDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CancelledDateTime;
        partial void OnCancelledDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnCancelledDateTimeChanged();
        /// <summary>
        /// There are no comments for Property ReleasingSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReleasingSiteId
        {
            get
            {
                return this._ReleasingSiteId;
            }
            set
            {
                this.OnReleasingSiteIdChanging(value);
                this._ReleasingSiteId = value;
                this.OnReleasingSiteIdChanged();
                this.OnPropertyChanged("ReleasingSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReleasingSiteId;
        partial void OnReleasingSiteIdChanging(string value);
        partial void OnReleasingSiteIdChanged();
        /// <summary>
        /// There are no comments for Property HasError in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> HasError
        {
            get
            {
                return this._HasError;
            }
            set
            {
                this.OnHasErrorChanging(value);
                this._HasError = value;
                this.OnHasErrorChanged();
                this.OnPropertyChanged("HasError");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _HasError;
        partial void OnHasErrorChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnHasErrorChanged();
        /// <summary>
        /// There are no comments for Property ProcessorPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProcessorPersonnelNumber
        {
            get
            {
                return this._ProcessorPersonnelNumber;
            }
            set
            {
                this.OnProcessorPersonnelNumberChanging(value);
                this._ProcessorPersonnelNumber = value;
                this.OnProcessorPersonnelNumberChanged();
                this.OnPropertyChanged("ProcessorPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProcessorPersonnelNumber;
        partial void OnProcessorPersonnelNumberChanging(string value);
        partial void OnProcessorPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property ReceivingSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReceivingSiteId
        {
            get
            {
                return this._ReceivingSiteId;
            }
            set
            {
                this.OnReceivingSiteIdChanging(value);
                this._ReceivingSiteId = value;
                this.OnReceivingSiteIdChanged();
                this.OnPropertyChanged("ReceivingSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReceivingSiteId;
        partial void OnReceivingSiteIdChanging(string value);
        partial void OnReceivingSiteIdChanged();
        /// <summary>
        /// There are no comments for Property ProcessedDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ProcessedDateTime
        {
            get
            {
                return this._ProcessedDateTime;
            }
            set
            {
                this.OnProcessedDateTimeChanging(value);
                this._ProcessedDateTime = value;
                this.OnProcessedDateTimeChanged();
                this.OnPropertyChanged("ProcessedDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ProcessedDateTime;
        partial void OnProcessedDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnProcessedDateTimeChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderNumber
        {
            get
            {
                return this._EngineeringChangeOrderNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderNumberChanging(value);
                this._EngineeringChangeOrderNumber = value;
                this.OnEngineeringChangeOrderNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderNumber;
        partial void OnEngineeringChangeOrderNumberChanging(string value);
        partial void OnEngineeringChangeOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property CancellorPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CancellorPersonnelNumber
        {
            get
            {
                return this._CancellorPersonnelNumber;
            }
            set
            {
                this.OnCancellorPersonnelNumberChanging(value);
                this._CancellorPersonnelNumber = value;
                this.OnCancellorPersonnelNumberChanged();
                this.OnPropertyChanged("CancellorPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CancellorPersonnelNumber;
        partial void OnCancellorPersonnelNumberChanging(string value);
        partial void OnCancellorPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property CancellorWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker CancellorWorker
        {
            get
            {
                return this._CancellorWorker;
            }
            set
            {
                this.OnCancellorWorkerChanging(value);
                this._CancellorWorker = value;
                this.OnCancellorWorkerChanged();
                this.OnPropertyChanged("CancellorWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _CancellorWorker;
        partial void OnCancellorWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnCancellorWorkerChanged();
        /// <summary>
        /// There are no comments for Property ReceivingSite in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationalSite ReceivingSite
        {
            get
            {
                return this._ReceivingSite;
            }
            set
            {
                this.OnReceivingSiteChanging(value);
                this._ReceivingSite = value;
                this.OnReceivingSiteChanged();
                this.OnPropertyChanged("ReceivingSite");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationalSite _ReceivingSite;
        partial void OnReceivingSiteChanging(global::Microsoft.Dynamics.DataEntities.OperationalSite value);
        partial void OnReceivingSiteChanged();
        /// <summary>
        /// There are no comments for Property EngineeringProductVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringProductVersion EngineeringProductVersion
        {
            get
            {
                return this._EngineeringProductVersion;
            }
            set
            {
                this.OnEngineeringProductVersionChanging(value);
                this._EngineeringProductVersion = value;
                this.OnEngineeringProductVersionChanged();
                this.OnPropertyChanged("EngineeringProductVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringProductVersion _EngineeringProductVersion;
        partial void OnEngineeringProductVersionChanging(global::Microsoft.Dynamics.DataEntities.EngineeringProductVersion value);
        partial void OnEngineeringProductVersionChanged();
        /// <summary>
        /// There are no comments for Property ReleasingSite in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationalSite ReleasingSite
        {
            get
            {
                return this._ReleasingSite;
            }
            set
            {
                this.OnReleasingSiteChanging(value);
                this._ReleasingSite = value;
                this.OnReleasingSiteChanged();
                this.OnPropertyChanged("ReleasingSite");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationalSite _ReleasingSite;
        partial void OnReleasingSiteChanging(global::Microsoft.Dynamics.DataEntities.OperationalSite value);
        partial void OnReleasingSiteChanged();
        /// <summary>
        /// There are no comments for Property ProcessorWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker ProcessorWorker
        {
            get
            {
                return this._ProcessorWorker;
            }
            set
            {
                this.OnProcessorWorkerChanging(value);
                this._ProcessorWorker = value;
                this.OnProcessorWorkerChanged();
                this.OnPropertyChanged("ProcessorWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _ProcessorWorker;
        partial void OnProcessorWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnProcessorWorkerChanged();
        /// <summary>
        /// There are no comments for Property ReceivedProductReleaseLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> ReceivedProductReleaseLines
        {
            get
            {
                return this._ReceivedProductReleaseLines;
            }
            set
            {
                this.OnReceivedProductReleaseLinesChanging(value);
                this._ReceivedProductReleaseLines = value;
                this.OnReceivedProductReleaseLinesChanged();
                this.OnPropertyChanged("ReceivedProductReleaseLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> _ReceivedProductReleaseLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReceivedProductReleaseLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> value);
        partial void OnReceivedProductReleaseLinesChanged();
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
