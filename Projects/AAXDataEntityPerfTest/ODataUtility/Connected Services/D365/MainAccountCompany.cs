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
        /// There are no comments for MainAccountCompanySingle in the schema.
        /// </summary>
    public partial class MainAccountCompanySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<MainAccountCompany>
    {
        /// <summary>
        /// Initialize a new MainAccountCompanySingle object.
        /// </summary>
        public MainAccountCompanySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MainAccountCompanySingle object.
        /// </summary>
        public MainAccountCompanySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MainAccountCompanySingle object.
        /// </summary>
        public MainAccountCompanySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<MainAccountCompany> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntitySingle LegalEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LegalEntity == null))
                {
                    this._LegalEntity = new global::Microsoft.Dynamics.DataEntities.LegalEntitySingle(this.Context, GetPath("LegalEntity"));
                }
                return this._LegalEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntitySingle _LegalEntity;
    }
        /// <summary>
        /// There are no comments for MainAccountCompany in the schema.
        /// </summary>
    /// <KeyProperties>
    /// MainAccountId
    /// LegalEntityId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("MainAccountId", "LegalEntityId")]
    [global::Microsoft.OData.Client.EntitySet("MainAccountCompanies")]
    public partial class MainAccountCompany : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MainAccountCompany object.
        /// </summary>
        /// <param name="mainAccountId">Initial value of MainAccountId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="legalEntity">Initial value of LegalEntity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static MainAccountCompany CreateMainAccountCompany(string mainAccountId, string legalEntityId, global::Microsoft.Dynamics.DataEntities.LegalEntity legalEntity)
        {
            MainAccountCompany mainAccountCompany = new MainAccountCompany();
            mainAccountCompany.MainAccountId = mainAccountId;
            mainAccountCompany.LegalEntityId = legalEntityId;
            if ((legalEntity == null))
            {
                throw new global::System.ArgumentNullException("legalEntity");
            }
            mainAccountCompany.LegalEntity = legalEntity;
            return mainAccountCompany;
        }
        /// <summary>
        /// There are no comments for Property MainAccountId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccountId
        {
            get
            {
                return this._MainAccountId;
            }
            set
            {
                this.OnMainAccountIdChanging(value);
                this._MainAccountId = value;
                this.OnMainAccountIdChanged();
                this.OnPropertyChanged("MainAccountId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountId;
        partial void OnMainAccountIdChanging(string value);
        partial void OnMainAccountIdChanged();
        /// <summary>
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
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
        /// There are no comments for Property LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntity LegalEntity
        {
            get
            {
                return this._LegalEntity;
            }
            set
            {
                this.OnLegalEntityChanging(value);
                this._LegalEntity = value;
                this.OnLegalEntityChanged();
                this.OnPropertyChanged("LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntity _LegalEntity;
        partial void OnLegalEntityChanging(global::Microsoft.Dynamics.DataEntities.LegalEntity value);
        partial void OnLegalEntityChanged();
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
