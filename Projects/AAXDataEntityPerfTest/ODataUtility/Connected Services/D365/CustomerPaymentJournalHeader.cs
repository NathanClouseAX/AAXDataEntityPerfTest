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
        /// There are no comments for CustomerPaymentJournalHeaderSingle in the schema.
        /// </summary>
    public partial class CustomerPaymentJournalHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerPaymentJournalHeader>
    {
        /// <summary>
        /// Initialize a new CustomerPaymentJournalHeaderSingle object.
        /// </summary>
        public CustomerPaymentJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomerPaymentJournalHeaderSingle object.
        /// </summary>
        public CustomerPaymentJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomerPaymentJournalHeaderSingle object.
        /// </summary>
        public CustomerPaymentJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerPaymentJournalHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CustomerPaymentJournalHeaderRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PaymentJournalLineSettledInvoice> CustomerPaymentJournalHeaderRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerPaymentJournalHeaderRole == null))
                {
                    this._CustomerPaymentJournalHeaderRole = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PaymentJournalLineSettledInvoice>(GetPath("CustomerPaymentJournalHeaderRole"));
                }
                return this._CustomerPaymentJournalHeaderRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PaymentJournalLineSettledInvoice> _CustomerPaymentJournalHeaderRole;
        /// <summary>
        /// There are no comments for CustomerPaymentJournalLineHeaderEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> CustomerPaymentJournalLineHeaderEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerPaymentJournalLineHeaderEntity == null))
                {
                    this._CustomerPaymentJournalLineHeaderEntity = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine>(GetPath("CustomerPaymentJournalLineHeaderEntity"));
                }
                return this._CustomerPaymentJournalLineHeaderEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> _CustomerPaymentJournalLineHeaderEntity;
    }
        /// <summary>
        /// There are no comments for CustomerPaymentJournalHeader in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// JournalBatchNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JournalBatchNumber")]
    [global::Microsoft.OData.Client.EntitySet("CustomerPaymentJournalHeaders")]
    public partial class CustomerPaymentJournalHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomerPaymentJournalHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="journalBatchNumber">Initial value of JournalBatchNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomerPaymentJournalHeader CreateCustomerPaymentJournalHeader(string dataAreaId, string journalBatchNumber)
        {
            CustomerPaymentJournalHeader customerPaymentJournalHeader = new CustomerPaymentJournalHeader();
            customerPaymentJournalHeader.dataAreaId = dataAreaId;
            customerPaymentJournalHeader.JournalBatchNumber = journalBatchNumber;
            return customerPaymentJournalHeader;
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
        /// There are no comments for Property JournalBatchNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalBatchNumber
        {
            get
            {
                return this._JournalBatchNumber;
            }
            set
            {
                this.OnJournalBatchNumberChanging(value);
                this._JournalBatchNumber = value;
                this.OnJournalBatchNumberChanged();
                this.OnPropertyChanged("JournalBatchNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalBatchNumber;
        partial void OnJournalBatchNumberChanging(string value);
        partial void OnJournalBatchNumberChanged();
        /// <summary>
        /// There are no comments for Property JournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalName
        {
            get
            {
                return this._JournalName;
            }
            set
            {
                this.OnJournalNameChanging(value);
                this._JournalName = value;
                this.OnJournalNameChanged();
                this.OnPropertyChanged("JournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalName;
        partial void OnJournalNameChanging(string value);
        partial void OnJournalNameChanged();
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
        /// There are no comments for Property IsPosted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPosted
        {
            get
            {
                return this._IsPosted;
            }
            set
            {
                this.OnIsPostedChanging(value);
                this._IsPosted = value;
                this.OnIsPostedChanged();
                this.OnPropertyChanged("IsPosted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPosted;
        partial void OnIsPostedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPostedChanged();
        /// <summary>
        /// There are no comments for Property CustomerPaymentJournalHeaderRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentJournalLineSettledInvoice> CustomerPaymentJournalHeaderRole
        {
            get
            {
                return this._CustomerPaymentJournalHeaderRole;
            }
            set
            {
                this.OnCustomerPaymentJournalHeaderRoleChanging(value);
                this._CustomerPaymentJournalHeaderRole = value;
                this.OnCustomerPaymentJournalHeaderRoleChanged();
                this.OnPropertyChanged("CustomerPaymentJournalHeaderRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentJournalLineSettledInvoice> _CustomerPaymentJournalHeaderRole = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentJournalLineSettledInvoice>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCustomerPaymentJournalHeaderRoleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentJournalLineSettledInvoice> value);
        partial void OnCustomerPaymentJournalHeaderRoleChanged();
        /// <summary>
        /// There are no comments for Property CustomerPaymentJournalLineHeaderEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> CustomerPaymentJournalLineHeaderEntity
        {
            get
            {
                return this._CustomerPaymentJournalLineHeaderEntity;
            }
            set
            {
                this.OnCustomerPaymentJournalLineHeaderEntityChanging(value);
                this._CustomerPaymentJournalLineHeaderEntity = value;
                this.OnCustomerPaymentJournalLineHeaderEntityChanged();
                this.OnPropertyChanged("CustomerPaymentJournalLineHeaderEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> _CustomerPaymentJournalLineHeaderEntity = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCustomerPaymentJournalLineHeaderEntityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> value);
        partial void OnCustomerPaymentJournalLineHeaderEntityChanged();
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