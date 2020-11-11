﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/8/2020 8:07:52 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for CustomerAttachmentSingle in the schema.
        /// </summary>
    public partial class CustomerAttachmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerAttachment>
    {
        /// <summary>
        /// Initialize a new CustomerAttachmentSingle object.
        /// </summary>
        public CustomerAttachmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomerAttachmentSingle object.
        /// </summary>
        public CustomerAttachmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomerAttachmentSingle object.
        /// </summary>
        public CustomerAttachmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerAttachment> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CustomerAttachmentsEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerV3Single CustomerAttachmentsEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerAttachmentsEntity == null))
                {
                    this._CustomerAttachmentsEntity = new global::Microsoft.Dynamics.DataEntities.CustomerV3Single(this.Context, GetPath("CustomerAttachmentsEntity"));
                }
                return this._CustomerAttachmentsEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerV3Single _CustomerAttachmentsEntity;
    }
        /// <summary>
        /// There are no comments for CustomerAttachment in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// DocumentId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DocumentId")]
    [global::Microsoft.OData.Client.EntitySet("CustomerAttachments")]
    public partial class CustomerAttachment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomerAttachment object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="documentId">Initial value of DocumentId.</param>
        /// <param name="customerAttachmentsEntity">Initial value of CustomerAttachmentsEntity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomerAttachment CreateCustomerAttachment(string dataAreaId, global::System.Guid documentId, global::Microsoft.Dynamics.DataEntities.CustomerV3 customerAttachmentsEntity)
        {
            CustomerAttachment customerAttachment = new CustomerAttachment();
            customerAttachment.dataAreaId = dataAreaId;
            customerAttachment.DocumentId = documentId;
            if ((customerAttachmentsEntity == null))
            {
                throw new global::System.ArgumentNullException("customerAttachmentsEntity");
            }
            customerAttachment.CustomerAttachmentsEntity = customerAttachmentsEntity;
            return customerAttachment;
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
        /// There are no comments for Property FileContents in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual byte[] FileContents
        {
            get
            {
                return this._FileContents;
            }
            set
            {
                this.OnFileContentsChanging(value);
                this._FileContents = value;
                this.OnFileContentsChanged();
                this.OnPropertyChanged("FileContents");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private byte[] _FileContents;
        partial void OnFileContentsChanging(byte[] value);
        partial void OnFileContentsChanged();
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
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property TypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TypeId
        {
            get
            {
                return this._TypeId;
            }
            set
            {
                this.OnTypeIdChanging(value);
                this._TypeId = value;
                this.OnTypeIdChanged();
                this.OnPropertyChanged("TypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TypeId;
        partial void OnTypeIdChanging(string value);
        partial void OnTypeIdChanged();
        /// <summary>
        /// There are no comments for Property Restriction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> Restriction
        {
            get
            {
                return this._Restriction;
            }
            set
            {
                this.OnRestrictionChanging(value);
                this._Restriction = value;
                this.OnRestrictionChanged();
                this.OnPropertyChanged("Restriction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> _Restriction;
        partial void OnRestrictionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> value);
        partial void OnRestrictionChanged();
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
        /// There are no comments for Property CustomerAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerAccountNumber
        {
            get
            {
                return this._CustomerAccountNumber;
            }
            set
            {
                this.OnCustomerAccountNumberChanging(value);
                this._CustomerAccountNumber = value;
                this.OnCustomerAccountNumberChanged();
                this.OnPropertyChanged("CustomerAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAccountNumber;
        partial void OnCustomerAccountNumberChanging(string value);
        partial void OnCustomerAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property DefaultAttachment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DefaultAttachment
        {
            get
            {
                return this._DefaultAttachment;
            }
            set
            {
                this.OnDefaultAttachmentChanging(value);
                this._DefaultAttachment = value;
                this.OnDefaultAttachmentChanged();
                this.OnPropertyChanged("DefaultAttachment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DefaultAttachment;
        partial void OnDefaultAttachmentChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDefaultAttachmentChanged();
        /// <summary>
        /// There are no comments for Property CustomerAttachmentsEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerV3 CustomerAttachmentsEntity
        {
            get
            {
                return this._CustomerAttachmentsEntity;
            }
            set
            {
                this.OnCustomerAttachmentsEntityChanging(value);
                this._CustomerAttachmentsEntity = value;
                this.OnCustomerAttachmentsEntityChanged();
                this.OnPropertyChanged("CustomerAttachmentsEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerV3 _CustomerAttachmentsEntity;
        partial void OnCustomerAttachmentsEntityChanging(global::Microsoft.Dynamics.DataEntities.CustomerV3 value);
        partial void OnCustomerAttachmentsEntityChanged();
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