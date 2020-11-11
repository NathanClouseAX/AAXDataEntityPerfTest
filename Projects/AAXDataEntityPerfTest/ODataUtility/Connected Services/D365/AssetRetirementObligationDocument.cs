﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 9/11/2020 3:24:26 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for AssetRetirementObligationDocumentSingle in the schema.
    /// </summary>
    public partial class AssetRetirementObligationDocumentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetRetirementObligationDocument>
    {
        /// <summary>
        /// Initialize a new AssetRetirementObligationDocumentSingle object.
        /// </summary>
        public AssetRetirementObligationDocumentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetRetirementObligationDocumentSingle object.
        /// </summary>
        public AssetRetirementObligationDocumentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetRetirementObligationDocumentSingle object.
        /// </summary>
        public AssetRetirementObligationDocumentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetRetirementObligationDocument> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AssetRetirementObligationDocument in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// DocumentId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DocumentId")]
    [global::Microsoft.OData.Client.EntitySet("AssetRetirementObligationDocuments")]
    public partial class AssetRetirementObligationDocument : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetRetirementObligationDocument object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="documentId">Initial value of DocumentId.</param>
        /// <param name="documentDate">Initial value of DocumentDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetRetirementObligationDocument CreateAssetRetirementObligationDocument(string dataAreaId, string documentId, global::System.DateTimeOffset documentDate)
        {
            AssetRetirementObligationDocument assetRetirementObligationDocument = new AssetRetirementObligationDocument();
            assetRetirementObligationDocument.dataAreaId = dataAreaId;
            assetRetirementObligationDocument.DocumentId = documentId;
            assetRetirementObligationDocument.DocumentDate = documentDate;
            return assetRetirementObligationDocument;
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
        /// There are no comments for Property DocumentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DocumentId
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
        private string _DocumentId;
        partial void OnDocumentIdChanging(string value);
        partial void OnDocumentIdChanged();
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
        /// There are no comments for Property DocumentDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DocumentDate
        {
            get
            {
                return this._DocumentDate;
            }
            set
            {
                this.OnDocumentDateChanging(value);
                this._DocumentDate = value;
                this.OnDocumentDateChanged();
                this.OnPropertyChanged("DocumentDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DocumentDate;
        partial void OnDocumentDateChanging(global::System.DateTimeOffset value);
        partial void OnDocumentDateChanged();
        /// <summary>
        /// There are no comments for Property PostingFrequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetRetirementPostingFrequency_JP> PostingFrequency
        {
            get
            {
                return this._PostingFrequency;
            }
            set
            {
                this.OnPostingFrequencyChanging(value);
                this._PostingFrequency = value;
                this.OnPostingFrequencyChanged();
                this.OnPropertyChanged("PostingFrequency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetRetirementPostingFrequency_JP> _PostingFrequency;
        partial void OnPostingFrequencyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetRetirementPostingFrequency_JP> value);
        partial void OnPostingFrequencyChanged();
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