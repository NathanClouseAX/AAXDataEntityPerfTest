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
        /// There are no comments for OperationSingle in the schema.
        /// </summary>
    public partial class OperationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Operation>
    {
        /// <summary>
        /// Initialize a new OperationSingle object.
        /// </summary>
        public OperationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new OperationSingle object.
        /// </summary>
        public OperationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new OperationSingle object.
        /// </summary>
        public OperationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Operation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RouteOperations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RouteOperation> RouteOperations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RouteOperations == null))
                {
                    this._RouteOperations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RouteOperation>(GetPath("RouteOperations"));
                }
                return this._RouteOperations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RouteOperation> _RouteOperations;
        /// <summary>
        /// There are no comments for JobCardProductionJournalEntries in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobCardProductionJournalEntry> JobCardProductionJournalEntries
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobCardProductionJournalEntries == null))
                {
                    this._JobCardProductionJournalEntries = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobCardProductionJournalEntry>(GetPath("JobCardProductionJournalEntries"));
                }
                return this._JobCardProductionJournalEntries;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobCardProductionJournalEntry> _JobCardProductionJournalEntries;
        /// <summary>
        /// There are no comments for QualityOrderHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.QualityOrderHeader> QualityOrderHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._QualityOrderHeaders == null))
                {
                    this._QualityOrderHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.QualityOrderHeader>(GetPath("QualityOrderHeaders"));
                }
                return this._QualityOrderHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.QualityOrderHeader> _QualityOrderHeaders;
        /// <summary>
        /// There are no comments for PayAgreementLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PayAgreementLine> PayAgreementLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayAgreementLines == null))
                {
                    this._PayAgreementLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PayAgreementLine>(GetPath("PayAgreementLines"));
                }
                return this._PayAgreementLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PayAgreementLine> _PayAgreementLines;
        /// <summary>
        /// There are no comments for RouteCardProductionJournalEntries in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RouteCardProductionJournalEntry> RouteCardProductionJournalEntries
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RouteCardProductionJournalEntries == null))
                {
                    this._RouteCardProductionJournalEntries = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RouteCardProductionJournalEntry>(GetPath("RouteCardProductionJournalEntries"));
                }
                return this._RouteCardProductionJournalEntries;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RouteCardProductionJournalEntry> _RouteCardProductionJournalEntries;
    }
        /// <summary>
        /// There are no comments for Operation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// OperationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "OperationId")]
    [global::Microsoft.OData.Client.EntitySet("Operations")]
    public partial class Operation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Operation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="operationId">Initial value of OperationId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Operation CreateOperation(string dataAreaId, string operationId)
        {
            Operation operation = new Operation();
            operation.dataAreaId = dataAreaId;
            operation.OperationId = operationId;
            return operation;
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
        /// There are no comments for Property OperationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OperationId
        {
            get
            {
                return this._OperationId;
            }
            set
            {
                this.OnOperationIdChanging(value);
                this._OperationId = value;
                this.OnOperationIdChanged();
                this.OnPropertyChanged("OperationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperationId;
        partial void OnOperationIdChanging(string value);
        partial void OnOperationIdChanged();
        /// <summary>
        /// There are no comments for Property OperationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OperationName
        {
            get
            {
                return this._OperationName;
            }
            set
            {
                this.OnOperationNameChanging(value);
                this._OperationName = value;
                this.OnOperationNameChanged();
                this.OnPropertyChanged("OperationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperationName;
        partial void OnOperationNameChanging(string value);
        partial void OnOperationNameChanged();
        /// <summary>
        /// There are no comments for Property RouteOperations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteOperation> RouteOperations
        {
            get
            {
                return this._RouteOperations;
            }
            set
            {
                this.OnRouteOperationsChanging(value);
                this._RouteOperations = value;
                this.OnRouteOperationsChanged();
                this.OnPropertyChanged("RouteOperations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteOperation> _RouteOperations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteOperation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRouteOperationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteOperation> value);
        partial void OnRouteOperationsChanged();
        /// <summary>
        /// There are no comments for Property JobCardProductionJournalEntries in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobCardProductionJournalEntry> JobCardProductionJournalEntries
        {
            get
            {
                return this._JobCardProductionJournalEntries;
            }
            set
            {
                this.OnJobCardProductionJournalEntriesChanging(value);
                this._JobCardProductionJournalEntries = value;
                this.OnJobCardProductionJournalEntriesChanged();
                this.OnPropertyChanged("JobCardProductionJournalEntries");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobCardProductionJournalEntry> _JobCardProductionJournalEntries = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobCardProductionJournalEntry>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobCardProductionJournalEntriesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobCardProductionJournalEntry> value);
        partial void OnJobCardProductionJournalEntriesChanged();
        /// <summary>
        /// There are no comments for Property QualityOrderHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.QualityOrderHeader> QualityOrderHeaders
        {
            get
            {
                return this._QualityOrderHeaders;
            }
            set
            {
                this.OnQualityOrderHeadersChanging(value);
                this._QualityOrderHeaders = value;
                this.OnQualityOrderHeadersChanged();
                this.OnPropertyChanged("QualityOrderHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.QualityOrderHeader> _QualityOrderHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.QualityOrderHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnQualityOrderHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.QualityOrderHeader> value);
        partial void OnQualityOrderHeadersChanged();
        /// <summary>
        /// There are no comments for Property PayAgreementLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayAgreementLine> PayAgreementLines
        {
            get
            {
                return this._PayAgreementLines;
            }
            set
            {
                this.OnPayAgreementLinesChanging(value);
                this._PayAgreementLines = value;
                this.OnPayAgreementLinesChanged();
                this.OnPropertyChanged("PayAgreementLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayAgreementLine> _PayAgreementLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayAgreementLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPayAgreementLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayAgreementLine> value);
        partial void OnPayAgreementLinesChanged();
        /// <summary>
        /// There are no comments for Property RouteCardProductionJournalEntries in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteCardProductionJournalEntry> RouteCardProductionJournalEntries
        {
            get
            {
                return this._RouteCardProductionJournalEntries;
            }
            set
            {
                this.OnRouteCardProductionJournalEntriesChanging(value);
                this._RouteCardProductionJournalEntries = value;
                this.OnRouteCardProductionJournalEntriesChanged();
                this.OnPropertyChanged("RouteCardProductionJournalEntries");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteCardProductionJournalEntry> _RouteCardProductionJournalEntries = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteCardProductionJournalEntry>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRouteCardProductionJournalEntriesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteCardProductionJournalEntry> value);
        partial void OnRouteCardProductionJournalEntriesChanged();
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
