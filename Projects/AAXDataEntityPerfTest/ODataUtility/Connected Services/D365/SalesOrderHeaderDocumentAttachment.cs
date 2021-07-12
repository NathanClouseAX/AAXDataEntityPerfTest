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
        /// There are no comments for SalesOrderHeaderDocumentAttachmentSingle in the schema.
        /// </summary>
    public partial class SalesOrderHeaderDocumentAttachmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SalesOrderHeaderDocumentAttachment>
    {
        /// <summary>
        /// Initialize a new SalesOrderHeaderDocumentAttachmentSingle object.
        /// </summary>
        public SalesOrderHeaderDocumentAttachmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SalesOrderHeaderDocumentAttachmentSingle object.
        /// </summary>
        public SalesOrderHeaderDocumentAttachmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SalesOrderHeaderDocumentAttachmentSingle object.
        /// </summary>
        public SalesOrderHeaderDocumentAttachmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SalesOrderHeaderDocumentAttachment> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CDSSalesOrderHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CDSSalesOrderHeaderSingle CDSSalesOrderHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CDSSalesOrderHeader == null))
                {
                    this._CDSSalesOrderHeader = new global::Microsoft.Dynamics.DataEntities.CDSSalesOrderHeaderSingle(this.Context, GetPath("CDSSalesOrderHeader"));
                }
                return this._CDSSalesOrderHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CDSSalesOrderHeaderSingle _CDSSalesOrderHeader;
    }
        /// <summary>
        /// There are no comments for SalesOrderHeaderDocumentAttachment in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// DocumentId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DocumentId")]
    [global::Microsoft.OData.Client.EntitySet("SalesOrderHeaderDocumentAttachments")]
    public partial class SalesOrderHeaderDocumentAttachment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SalesOrderHeaderDocumentAttachment object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="documentId">Initial value of DocumentId.</param>
        /// <param name="cDSSalesOrderHeader">Initial value of CDSSalesOrderHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SalesOrderHeaderDocumentAttachment CreateSalesOrderHeaderDocumentAttachment(string dataAreaId, global::System.Guid documentId, global::Microsoft.Dynamics.DataEntities.CDSSalesOrderHeader cDSSalesOrderHeader)
        {
            SalesOrderHeaderDocumentAttachment salesOrderHeaderDocumentAttachment = new SalesOrderHeaderDocumentAttachment();
            salesOrderHeaderDocumentAttachment.dataAreaId = dataAreaId;
            salesOrderHeaderDocumentAttachment.DocumentId = documentId;
            if ((cDSSalesOrderHeader == null))
            {
                throw new global::System.ArgumentNullException("cDSSalesOrderHeader");
            }
            salesOrderHeaderDocumentAttachment.CDSSalesOrderHeader = cDSSalesOrderHeader;
            return salesOrderHeaderDocumentAttachment;
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
        /// There are no comments for Property FileType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FileType
        {
            get
            {
                return this._FileType;
            }
            set
            {
                this.OnFileTypeChanging(value);
                this._FileType = value;
                this.OnFileTypeChanged();
                this.OnPropertyChanged("FileType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FileType;
        partial void OnFileTypeChanging(string value);
        partial void OnFileTypeChanged();
        /// <summary>
        /// There are no comments for Property IsDefaultAttachment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefaultAttachment
        {
            get
            {
                return this._IsDefaultAttachment;
            }
            set
            {
                this.OnIsDefaultAttachmentChanging(value);
                this._IsDefaultAttachment = value;
                this.OnIsDefaultAttachmentChanged();
                this.OnPropertyChanged("IsDefaultAttachment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefaultAttachment;
        partial void OnIsDefaultAttachmentChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultAttachmentChanged();
        /// <summary>
        /// There are no comments for Property SalesOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesOrderNumber
        {
            get
            {
                return this._SalesOrderNumber;
            }
            set
            {
                this.OnSalesOrderNumberChanging(value);
                this._SalesOrderNumber = value;
                this.OnSalesOrderNumberChanged();
                this.OnPropertyChanged("SalesOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesOrderNumber;
        partial void OnSalesOrderNumberChanging(string value);
        partial void OnSalesOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property AccessRestriction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> AccessRestriction
        {
            get
            {
                return this._AccessRestriction;
            }
            set
            {
                this.OnAccessRestrictionChanging(value);
                this._AccessRestriction = value;
                this.OnAccessRestrictionChanged();
                this.OnPropertyChanged("AccessRestriction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> _AccessRestriction;
        partial void OnAccessRestrictionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> value);
        partial void OnAccessRestrictionChanged();
        /// <summary>
        /// There are no comments for Property AttachmentDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttachmentDescription
        {
            get
            {
                return this._AttachmentDescription;
            }
            set
            {
                this.OnAttachmentDescriptionChanging(value);
                this._AttachmentDescription = value;
                this.OnAttachmentDescriptionChanged();
                this.OnPropertyChanged("AttachmentDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttachmentDescription;
        partial void OnAttachmentDescriptionChanging(string value);
        partial void OnAttachmentDescriptionChanged();
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
        /// There are no comments for Property DocumentAttachmentTypeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DocumentAttachmentTypeCode
        {
            get
            {
                return this._DocumentAttachmentTypeCode;
            }
            set
            {
                this.OnDocumentAttachmentTypeCodeChanging(value);
                this._DocumentAttachmentTypeCode = value;
                this.OnDocumentAttachmentTypeCodeChanged();
                this.OnPropertyChanged("DocumentAttachmentTypeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentAttachmentTypeCode;
        partial void OnDocumentAttachmentTypeCodeChanging(string value);
        partial void OnDocumentAttachmentTypeCodeChanged();
        /// <summary>
        /// There are no comments for Property FileName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FileName
        {
            get
            {
                return this._FileName;
            }
            set
            {
                this.OnFileNameChanging(value);
                this._FileName = value;
                this.OnFileNameChanged();
                this.OnPropertyChanged("FileName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FileName;
        partial void OnFileNameChanging(string value);
        partial void OnFileNameChanged();
        /// <summary>
        /// There are no comments for Property Attachment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual byte[] Attachment
        {
            get
            {
                return this._Attachment;
            }
            set
            {
                this.OnAttachmentChanging(value);
                this._Attachment = value;
                this.OnAttachmentChanged();
                this.OnPropertyChanged("Attachment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private byte[] _Attachment;
        partial void OnAttachmentChanging(byte[] value);
        partial void OnAttachmentChanged();
        /// <summary>
        /// There are no comments for Property CDSSalesOrderHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CDSSalesOrderHeader CDSSalesOrderHeader
        {
            get
            {
                return this._CDSSalesOrderHeader;
            }
            set
            {
                this.OnCDSSalesOrderHeaderChanging(value);
                this._CDSSalesOrderHeader = value;
                this.OnCDSSalesOrderHeaderChanged();
                this.OnPropertyChanged("CDSSalesOrderHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CDSSalesOrderHeader _CDSSalesOrderHeader;
        partial void OnCDSSalesOrderHeaderChanging(global::Microsoft.Dynamics.DataEntities.CDSSalesOrderHeader value);
        partial void OnCDSSalesOrderHeaderChanged();
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
