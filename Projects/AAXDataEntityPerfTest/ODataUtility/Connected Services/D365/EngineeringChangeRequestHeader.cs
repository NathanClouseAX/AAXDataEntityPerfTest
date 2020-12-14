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
        /// There are no comments for EngineeringChangeRequestHeaderSingle in the schema.
        /// </summary>
    public partial class EngineeringChangeRequestHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeRequestHeader>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeRequestHeaderSingle object.
        /// </summary>
        public EngineeringChangeRequestHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeRequestHeaderSingle object.
        /// </summary>
        public EngineeringChangeRequestHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeRequestHeaderSingle object.
        /// </summary>
        public EngineeringChangeRequestHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeRequestHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringChangeRequestProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestProduct> EngineeringChangeRequestProducts
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeRequestProducts == null))
                {
                    this._EngineeringChangeRequestProducts = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestProduct>(GetPath("EngineeringChangeRequestProducts"));
                }
                return this._EngineeringChangeRequestProducts;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestProduct> _EngineeringChangeRequestProducts;
        /// <summary>
        /// There are no comments for EngineeringChangeRequestDependencies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependency> EngineeringChangeRequestDependencies
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeRequestDependencies == null))
                {
                    this._EngineeringChangeRequestDependencies = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependency>(GetPath("EngineeringChangeRequestDependencies"));
                }
                return this._EngineeringChangeRequestDependencies;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependency> _EngineeringChangeRequestDependencies;
        /// <summary>
        /// There are no comments for EngineeringChangeRequestSources in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestSource> EngineeringChangeRequestSources
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeRequestSources == null))
                {
                    this._EngineeringChangeRequestSources = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestSource>(GetPath("EngineeringChangeRequestSources"));
                }
                return this._EngineeringChangeRequestSources;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestSource> _EngineeringChangeRequestSources;
        /// <summary>
        /// There are no comments for RequesterWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle RequesterWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RequesterWorker == null))
                {
                    this._RequesterWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("RequesterWorker"));
                }
                return this._RequesterWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _RequesterWorker;
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
    }
        /// <summary>
        /// There are no comments for EngineeringChangeRequestHeader in the schema.
        /// </summary>
    /// <KeyProperties>
    /// RequestNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RequestNumber")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeRequestHeaders")]
    public partial class EngineeringChangeRequestHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeRequestHeader object.
        /// </summary>
        /// <param name="requestNumber">Initial value of RequestNumber.</param>
        /// <param name="requesterWorker">Initial value of RequesterWorker.</param>
        /// <param name="engineeringChangePriority">Initial value of EngineeringChangePriority.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeRequestHeader CreateEngineeringChangeRequestHeader(string requestNumber, global::Microsoft.Dynamics.DataEntities.Worker requesterWorker, global::Microsoft.Dynamics.DataEntities.EngineeringChangePriority engineeringChangePriority)
        {
            EngineeringChangeRequestHeader engineeringChangeRequestHeader = new EngineeringChangeRequestHeader();
            engineeringChangeRequestHeader.RequestNumber = requestNumber;
            if ((requesterWorker == null))
            {
                throw new global::System.ArgumentNullException("requesterWorker");
            }
            engineeringChangeRequestHeader.RequesterWorker = requesterWorker;
            if ((engineeringChangePriority == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangePriority");
            }
            engineeringChangeRequestHeader.EngineeringChangePriority = engineeringChangePriority;
            return engineeringChangeRequestHeader;
        }
        /// <summary>
        /// There are no comments for Property RequestNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RequestNumber
        {
            get
            {
                return this._RequestNumber;
            }
            set
            {
                this.OnRequestNumberChanging(value);
                this._RequestNumber = value;
                this.OnRequestNumberChanged();
                this.OnPropertyChanged("RequestNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequestNumber;
        partial void OnRequestNumberChanging(string value);
        partial void OnRequestNumberChanged();
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
        /// There are no comments for Property RequestSeverityClassification in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmRequestSeverity> RequestSeverityClassification
        {
            get
            {
                return this._RequestSeverityClassification;
            }
            set
            {
                this.OnRequestSeverityClassificationChanging(value);
                this._RequestSeverityClassification = value;
                this.OnRequestSeverityClassificationChanged();
                this.OnPropertyChanged("RequestSeverityClassification");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmRequestSeverity> _RequestSeverityClassification;
        partial void OnRequestSeverityClassificationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmRequestSeverity> value);
        partial void OnRequestSeverityClassificationChanged();
        /// <summary>
        /// There are no comments for Property RequesterPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RequesterPersonnelNumber
        {
            get
            {
                return this._RequesterPersonnelNumber;
            }
            set
            {
                this.OnRequesterPersonnelNumberChanging(value);
                this._RequesterPersonnelNumber = value;
                this.OnRequesterPersonnelNumberChanged();
                this.OnPropertyChanged("RequesterPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequesterPersonnelNumber;
        partial void OnRequesterPersonnelNumberChanging(string value);
        partial void OnRequesterPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property RequestTitle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RequestTitle
        {
            get
            {
                return this._RequestTitle;
            }
            set
            {
                this.OnRequestTitleChanging(value);
                this._RequestTitle = value;
                this.OnRequestTitleChanged();
                this.OnPropertyChanged("RequestTitle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequestTitle;
        partial void OnRequestTitleChanging(string value);
        partial void OnRequestTitleChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeRequestProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestProduct> EngineeringChangeRequestProducts
        {
            get
            {
                return this._EngineeringChangeRequestProducts;
            }
            set
            {
                this.OnEngineeringChangeRequestProductsChanging(value);
                this._EngineeringChangeRequestProducts = value;
                this.OnEngineeringChangeRequestProductsChanged();
                this.OnPropertyChanged("EngineeringChangeRequestProducts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestProduct> _EngineeringChangeRequestProducts = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestProduct>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeRequestProductsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestProduct> value);
        partial void OnEngineeringChangeRequestProductsChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeRequestDependencies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependency> EngineeringChangeRequestDependencies
        {
            get
            {
                return this._EngineeringChangeRequestDependencies;
            }
            set
            {
                this.OnEngineeringChangeRequestDependenciesChanging(value);
                this._EngineeringChangeRequestDependencies = value;
                this.OnEngineeringChangeRequestDependenciesChanged();
                this.OnPropertyChanged("EngineeringChangeRequestDependencies");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependency> _EngineeringChangeRequestDependencies = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependency>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeRequestDependenciesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependency> value);
        partial void OnEngineeringChangeRequestDependenciesChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeRequestSources in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestSource> EngineeringChangeRequestSources
        {
            get
            {
                return this._EngineeringChangeRequestSources;
            }
            set
            {
                this.OnEngineeringChangeRequestSourcesChanging(value);
                this._EngineeringChangeRequestSources = value;
                this.OnEngineeringChangeRequestSourcesChanged();
                this.OnPropertyChanged("EngineeringChangeRequestSources");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestSource> _EngineeringChangeRequestSources = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestSource>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeRequestSourcesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestSource> value);
        partial void OnEngineeringChangeRequestSourcesChanged();
        /// <summary>
        /// There are no comments for Property RequesterWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker RequesterWorker
        {
            get
            {
                return this._RequesterWorker;
            }
            set
            {
                this.OnRequesterWorkerChanging(value);
                this._RequesterWorker = value;
                this.OnRequesterWorkerChanged();
                this.OnPropertyChanged("RequesterWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _RequesterWorker;
        partial void OnRequesterWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnRequesterWorkerChanged();
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
