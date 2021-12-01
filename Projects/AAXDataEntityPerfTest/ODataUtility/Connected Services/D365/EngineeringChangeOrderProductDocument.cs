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
    /// There are no comments for EngineeringChangeOrderProductDocumentSingle in the schema.
    /// </summary>
    public partial class EngineeringChangeOrderProductDocumentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductDocument>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductDocumentSingle object.
        /// </summary>
        public EngineeringChangeOrderProductDocumentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductDocumentSingle object.
        /// </summary>
        public EngineeringChangeOrderProductDocumentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductDocumentSingle object.
        /// </summary>
        public EngineeringChangeOrderProductDocumentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductDocument> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringChangeOrderProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle EngineeringChangeOrderProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProduct == null))
                {
                    this._EngineeringChangeOrderProduct = new global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle(this.Context, GetPath("EngineeringChangeOrderProduct"));
                }
                return this._EngineeringChangeOrderProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle _EngineeringChangeOrderProduct;
    }
    /// <summary>
    /// There are no comments for EngineeringChangeOrderProductDocument in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// DocumentId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DocumentId")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeOrderProductDocuments")]
    public partial class EngineeringChangeOrderProductDocument : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeOrderProductDocument object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="documentId">Initial value of DocumentId.</param>
        /// <param name="sequenceNumber">Initial value of SequenceNumber.</param>
        /// <param name="engineeringChangeOrderProductLineNumber">Initial value of EngineeringChangeOrderProductLineNumber.</param>
        /// <param name="engineeringChangeOrderProduct">Initial value of EngineeringChangeOrderProduct.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeOrderProductDocument CreateEngineeringChangeOrderProductDocument(string dataAreaId, global::System.Guid documentId, decimal sequenceNumber, decimal engineeringChangeOrderProductLineNumber, global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct engineeringChangeOrderProduct)
        {
            EngineeringChangeOrderProductDocument engineeringChangeOrderProductDocument = new EngineeringChangeOrderProductDocument();
            engineeringChangeOrderProductDocument.dataAreaId = dataAreaId;
            engineeringChangeOrderProductDocument.DocumentId = documentId;
            engineeringChangeOrderProductDocument.SequenceNumber = sequenceNumber;
            engineeringChangeOrderProductDocument.EngineeringChangeOrderProductLineNumber = engineeringChangeOrderProductLineNumber;
            if ((engineeringChangeOrderProduct == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangeOrderProduct");
            }
            engineeringChangeOrderProductDocument.EngineeringChangeOrderProduct = engineeringChangeOrderProduct;
            return engineeringChangeOrderProductDocument;
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
        /// There are no comments for Property DocumentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DocumentId is required.")]
        public virtual global::System.Guid DocumentId
        {
            get
            {
                return this._DocumentId;
            }
            set
            {
                this.OnDocumentIdChanging(value);
                this._DocumentId = value;
                this.OnDocumentIdChanged();
                this.OnPropertyChanged("DocumentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _DocumentId;
        partial void OnDocumentIdChanging(global::System.Guid value);
        partial void OnDocumentIdChanged();
        /// <summary>
        /// There are no comments for Property SequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SequenceNumber is required.")]
        public virtual decimal SequenceNumber
        {
            get
            {
                return this._SequenceNumber;
            }
            set
            {
                this.OnSequenceNumberChanging(value);
                this._SequenceNumber = value;
                this.OnSequenceNumberChanged();
                this.OnPropertyChanged("SequenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SequenceNumber;
        partial void OnSequenceNumberChanging(decimal value);
        partial void OnSequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property DocumentModificationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmChangeTypes> DocumentModificationType
        {
            get
            {
                return this._DocumentModificationType;
            }
            set
            {
                this.OnDocumentModificationTypeChanging(value);
                this._DocumentModificationType = value;
                this.OnDocumentModificationTypeChanged();
                this.OnPropertyChanged("DocumentModificationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmChangeTypes> _DocumentModificationType;
        partial void OnDocumentModificationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmChangeTypes> value);
        partial void OnDocumentModificationTypeChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EngineeringChangeOrderProductLineNumber is required.")]
        public virtual decimal EngineeringChangeOrderProductLineNumber
        {
            get
            {
                return this._EngineeringChangeOrderProductLineNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderProductLineNumberChanging(value);
                this._EngineeringChangeOrderProductLineNumber = value;
                this.OnEngineeringChangeOrderProductLineNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _EngineeringChangeOrderProductLineNumber;
        partial void OnEngineeringChangeOrderProductLineNumberChanging(decimal value);
        partial void OnEngineeringChangeOrderProductLineNumberChanged();
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
        /// There are no comments for Property EngineeringChangeOrderProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EngineeringChangeOrderProduct is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct EngineeringChangeOrderProduct
        {
            get
            {
                return this._EngineeringChangeOrderProduct;
            }
            set
            {
                this.OnEngineeringChangeOrderProductChanging(value);
                this._EngineeringChangeOrderProduct = value;
                this.OnEngineeringChangeOrderProductChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct _EngineeringChangeOrderProduct;
        partial void OnEngineeringChangeOrderProductChanging(global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct value);
        partial void OnEngineeringChangeOrderProductChanged();
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
