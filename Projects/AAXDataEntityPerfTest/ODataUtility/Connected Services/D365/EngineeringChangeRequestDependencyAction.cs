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
        /// There are no comments for EngineeringChangeRequestDependencyActionSingle in the schema.
        /// </summary>
    public partial class EngineeringChangeRequestDependencyActionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeRequestDependencyAction>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeRequestDependencyActionSingle object.
        /// </summary>
        public EngineeringChangeRequestDependencyActionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeRequestDependencyActionSingle object.
        /// </summary>
        public EngineeringChangeRequestDependencyActionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeRequestDependencyActionSingle object.
        /// </summary>
        public EngineeringChangeRequestDependencyActionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeRequestDependencyAction> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringChangeRequestDependency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependencySingle EngineeringChangeRequestDependency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeRequestDependency == null))
                {
                    this._EngineeringChangeRequestDependency = new global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependencySingle(this.Context, GetPath("EngineeringChangeRequestDependency"));
                }
                return this._EngineeringChangeRequestDependency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependencySingle _EngineeringChangeRequestDependency;
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
    }
        /// <summary>
        /// There are no comments for EngineeringChangeRequestDependencyAction in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ActionClassName
    /// DependentProductNumber
    /// DependencyLegalEntityId
    /// DependencyTransactionDescription
    /// EngineeringChangeRequestNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ActionClassName", "DependentProductNumber", "DependencyLegalEntityId", "DependencyTransactionDescription", "EngineeringChangeRequestNumber")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeRequestDependencyActions")]
    public partial class EngineeringChangeRequestDependencyAction : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeRequestDependencyAction object.
        /// </summary>
        /// <param name="actionClassName">Initial value of ActionClassName.</param>
        /// <param name="dependentProductNumber">Initial value of DependentProductNumber.</param>
        /// <param name="dependencyLegalEntityId">Initial value of DependencyLegalEntityId.</param>
        /// <param name="dependencyTransactionDescription">Initial value of DependencyTransactionDescription.</param>
        /// <param name="engineeringChangeRequestNumber">Initial value of EngineeringChangeRequestNumber.</param>
        /// <param name="processedDateTime">Initial value of ProcessedDateTime.</param>
        /// <param name="engineeringChangeRequestDependency">Initial value of EngineeringChangeRequestDependency.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeRequestDependencyAction CreateEngineeringChangeRequestDependencyAction(string actionClassName, 
                    string dependentProductNumber, 
                    string dependencyLegalEntityId, 
                    string dependencyTransactionDescription, 
                    string engineeringChangeRequestNumber, 
                    global::System.DateTimeOffset processedDateTime, 
                    global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependency engineeringChangeRequestDependency)
        {
            EngineeringChangeRequestDependencyAction engineeringChangeRequestDependencyAction = new EngineeringChangeRequestDependencyAction();
            engineeringChangeRequestDependencyAction.ActionClassName = actionClassName;
            engineeringChangeRequestDependencyAction.DependentProductNumber = dependentProductNumber;
            engineeringChangeRequestDependencyAction.DependencyLegalEntityId = dependencyLegalEntityId;
            engineeringChangeRequestDependencyAction.DependencyTransactionDescription = dependencyTransactionDescription;
            engineeringChangeRequestDependencyAction.EngineeringChangeRequestNumber = engineeringChangeRequestNumber;
            engineeringChangeRequestDependencyAction.ProcessedDateTime = processedDateTime;
            if ((engineeringChangeRequestDependency == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangeRequestDependency");
            }
            engineeringChangeRequestDependencyAction.EngineeringChangeRequestDependency = engineeringChangeRequestDependency;
            return engineeringChangeRequestDependencyAction;
        }
        /// <summary>
        /// There are no comments for Property ActionClassName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ActionClassName
        {
            get
            {
                return this._ActionClassName;
            }
            set
            {
                this.OnActionClassNameChanging(value);
                this._ActionClassName = value;
                this.OnActionClassNameChanged();
                this.OnPropertyChanged("ActionClassName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActionClassName;
        partial void OnActionClassNameChanging(string value);
        partial void OnActionClassNameChanged();
        /// <summary>
        /// There are no comments for Property DependentProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DependentProductNumber
        {
            get
            {
                return this._DependentProductNumber;
            }
            set
            {
                this.OnDependentProductNumberChanging(value);
                this._DependentProductNumber = value;
                this.OnDependentProductNumberChanged();
                this.OnPropertyChanged("DependentProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DependentProductNumber;
        partial void OnDependentProductNumberChanging(string value);
        partial void OnDependentProductNumberChanged();
        /// <summary>
        /// There are no comments for Property DependencyLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DependencyLegalEntityId
        {
            get
            {
                return this._DependencyLegalEntityId;
            }
            set
            {
                this.OnDependencyLegalEntityIdChanging(value);
                this._DependencyLegalEntityId = value;
                this.OnDependencyLegalEntityIdChanged();
                this.OnPropertyChanged("DependencyLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DependencyLegalEntityId;
        partial void OnDependencyLegalEntityIdChanging(string value);
        partial void OnDependencyLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property DependencyTransactionDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DependencyTransactionDescription
        {
            get
            {
                return this._DependencyTransactionDescription;
            }
            set
            {
                this.OnDependencyTransactionDescriptionChanging(value);
                this._DependencyTransactionDescription = value;
                this.OnDependencyTransactionDescriptionChanged();
                this.OnPropertyChanged("DependencyTransactionDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DependencyTransactionDescription;
        partial void OnDependencyTransactionDescriptionChanging(string value);
        partial void OnDependencyTransactionDescriptionChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeRequestNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeRequestNumber
        {
            get
            {
                return this._EngineeringChangeRequestNumber;
            }
            set
            {
                this.OnEngineeringChangeRequestNumberChanging(value);
                this._EngineeringChangeRequestNumber = value;
                this.OnEngineeringChangeRequestNumberChanged();
                this.OnPropertyChanged("EngineeringChangeRequestNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeRequestNumber;
        partial void OnEngineeringChangeRequestNumberChanging(string value);
        partial void OnEngineeringChangeRequestNumberChanged();
        /// <summary>
        /// There are no comments for Property IsProcessableAction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsProcessableAction
        {
            get
            {
                return this._IsProcessableAction;
            }
            set
            {
                this.OnIsProcessableActionChanging(value);
                this._IsProcessableAction = value;
                this.OnIsProcessableActionChanged();
                this.OnPropertyChanged("IsProcessableAction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsProcessableAction;
        partial void OnIsProcessableActionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsProcessableActionChanged();
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
        /// There are no comments for Property ActionName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ActionName
        {
            get
            {
                return this._ActionName;
            }
            set
            {
                this.OnActionNameChanging(value);
                this._ActionName = value;
                this.OnActionNameChanged();
                this.OnPropertyChanged("ActionName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActionName;
        partial void OnActionNameChanging(string value);
        partial void OnActionNameChanged();
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
        /// There are no comments for Property EngineeringChangeRequestDependency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependency EngineeringChangeRequestDependency
        {
            get
            {
                return this._EngineeringChangeRequestDependency;
            }
            set
            {
                this.OnEngineeringChangeRequestDependencyChanging(value);
                this._EngineeringChangeRequestDependency = value;
                this.OnEngineeringChangeRequestDependencyChanged();
                this.OnPropertyChanged("EngineeringChangeRequestDependency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependency _EngineeringChangeRequestDependency;
        partial void OnEngineeringChangeRequestDependencyChanging(global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependency value);
        partial void OnEngineeringChangeRequestDependencyChanged();
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
