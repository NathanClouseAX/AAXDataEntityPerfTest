﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for RetailStaffSingle in the schema.
        /// </summary>
    public partial class RetailStaffSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStaff>
    {
        /// <summary>
        /// Initialize a new RetailStaffSingle object.
        /// </summary>
        public RetailStaffSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailStaffSingle object.
        /// </summary>
        public RetailStaffSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailStaffSingle object.
        /// </summary>
        public RetailStaffSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStaff> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle Worker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Worker == null))
                {
                    this._Worker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("Worker"));
                }
                return this._Worker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _Worker;
        /// <summary>
        /// There are no comments for RetailTillLayout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTillLayoutSingle RetailTillLayout
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTillLayout == null))
                {
                    this._RetailTillLayout = new global::Microsoft.Dynamics.DataEntities.RetailTillLayoutSingle(this.Context, GetPath("RetailTillLayout"));
                }
                return this._RetailTillLayout;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTillLayoutSingle _RetailTillLayout;
    }
        /// <summary>
        /// There are no comments for RetailStaff in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PersonnelNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailStaffs")]
    public partial class RetailStaff : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailStaff object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="worker">Initial value of Worker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailStaff CreateRetailStaff(string personnelNumber, global::Microsoft.Dynamics.DataEntities.Worker worker)
        {
            RetailStaff retailStaff = new RetailStaff();
            retailStaff.PersonnelNumber = personnelNumber;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            retailStaff.Worker = worker;
            return retailStaff;
        }
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property EmploymentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCashierSalesPersonOther> EmploymentType
        {
            get
            {
                return this._EmploymentType;
            }
            set
            {
                this.OnEmploymentTypeChanging(value);
                this._EmploymentType = value;
                this.OnEmploymentTypeChanged();
                this.OnPropertyChanged("EmploymentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCashierSalesPersonOther> _EmploymentType;
        partial void OnEmploymentTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCashierSalesPersonOther> value);
        partial void OnEmploymentTypeChanged();
        /// <summary>
        /// There are no comments for Property NameOnReceipt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string NameOnReceipt
        {
            get
            {
                return this._NameOnReceipt;
            }
            set
            {
                this.OnNameOnReceiptChanging(value);
                this._NameOnReceipt = value;
                this.OnNameOnReceiptChanged();
                this.OnPropertyChanged("NameOnReceipt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NameOnReceipt;
        partial void OnNameOnReceiptChanging(string value);
        partial void OnNameOnReceiptChanged();
        /// <summary>
        /// There are no comments for Property ExternalIdentifier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ExternalIdentifier
        {
            get
            {
                return this._ExternalIdentifier;
            }
            set
            {
                this.OnExternalIdentifierChanging(value);
                this._ExternalIdentifier = value;
                this.OnExternalIdentifierChanged();
                this.OnPropertyChanged("ExternalIdentifier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExternalIdentifier;
        partial void OnExternalIdentifierChanging(string value);
        partial void OnExternalIdentifierChanged();
        /// <summary>
        /// There are no comments for Property CultureName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CultureName
        {
            get
            {
                return this._CultureName;
            }
            set
            {
                this.OnCultureNameChanging(value);
                this._CultureName = value;
                this.OnCultureNameChanged();
                this.OnPropertyChanged("CultureName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CultureName;
        partial void OnCultureNameChanging(string value);
        partial void OnCultureNameChanged();
        /// <summary>
        /// There are no comments for Property LayoutId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LayoutId
        {
            get
            {
                return this._LayoutId;
            }
            set
            {
                this.OnLayoutIdChanging(value);
                this._LayoutId = value;
                this.OnLayoutIdChanged();
                this.OnPropertyChanged("LayoutId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LayoutId;
        partial void OnLayoutIdChanging(string value);
        partial void OnLayoutIdChanged();
        /// <summary>
        /// There are no comments for Property ExternalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ExternalName
        {
            get
            {
                return this._ExternalName;
            }
            set
            {
                this.OnExternalNameChanging(value);
                this._ExternalName = value;
                this.OnExternalNameChanged();
                this.OnPropertyChanged("ExternalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExternalName;
        partial void OnExternalNameChanging(string value);
        partial void OnExternalNameChanged();
        /// <summary>
        /// There are no comments for Property ExternalSubIdentifier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ExternalSubIdentifier
        {
            get
            {
                return this._ExternalSubIdentifier;
            }
            set
            {
                this.OnExternalSubIdentifierChanging(value);
                this._ExternalSubIdentifier = value;
                this.OnExternalSubIdentifierChanged();
                this.OnPropertyChanged("ExternalSubIdentifier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExternalSubIdentifier;
        partial void OnExternalSubIdentifierChanging(string value);
        partial void OnExternalSubIdentifierChanged();
        /// <summary>
        /// There are no comments for Property ExternalIdentityAlias in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ExternalIdentityAlias
        {
            get
            {
                return this._ExternalIdentityAlias;
            }
            set
            {
                this.OnExternalIdentityAliasChanging(value);
                this._ExternalIdentityAlias = value;
                this.OnExternalIdentityAliasChanged();
                this.OnPropertyChanged("ExternalIdentityAlias");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExternalIdentityAlias;
        partial void OnExternalIdentityAliasChanging(string value);
        partial void OnExternalIdentityAliasChanged();
        /// <summary>
        /// There are no comments for Property Image in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Image
        {
            get
            {
                return this._Image;
            }
            set
            {
                this.OnImageChanging(value);
                this._Image = value;
                this.OnImageChanged();
                this.OnPropertyChanged("Image");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Image;
        partial void OnImageChanging(string value);
        partial void OnImageChanged();
        /// <summary>
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker Worker
        {
            get
            {
                return this._Worker;
            }
            set
            {
                this.OnWorkerChanging(value);
                this._Worker = value;
                this.OnWorkerChanged();
                this.OnPropertyChanged("Worker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _Worker;
        partial void OnWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnWorkerChanged();
        /// <summary>
        /// There are no comments for Property RetailTillLayout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTillLayout RetailTillLayout
        {
            get
            {
                return this._RetailTillLayout;
            }
            set
            {
                this.OnRetailTillLayoutChanging(value);
                this._RetailTillLayout = value;
                this.OnRetailTillLayoutChanged();
                this.OnPropertyChanged("RetailTillLayout");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTillLayout _RetailTillLayout;
        partial void OnRetailTillLayoutChanging(global::Microsoft.Dynamics.DataEntities.RetailTillLayout value);
        partial void OnRetailTillLayoutChanged();
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
