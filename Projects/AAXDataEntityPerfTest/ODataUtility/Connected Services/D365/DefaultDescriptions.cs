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
        /// There are no comments for DefaultDescriptionsSingle in the schema.
        /// </summary>
    public partial class DefaultDescriptionsSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DefaultDescriptions>
    {
        /// <summary>
        /// Initialize a new DefaultDescriptionsSingle object.
        /// </summary>
        public DefaultDescriptionsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DefaultDescriptionsSingle object.
        /// </summary>
        public DefaultDescriptionsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DefaultDescriptionsSingle object.
        /// </summary>
        public DefaultDescriptionsSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DefaultDescriptions> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DefaultDescriptionParameters in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DefaultDescriptionParameters> DefaultDescriptionParameters
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DefaultDescriptionParameters == null))
                {
                    this._DefaultDescriptionParameters = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.DefaultDescriptionParameters>(GetPath("DefaultDescriptionParameters"));
                }
                return this._DefaultDescriptionParameters;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DefaultDescriptionParameters> _DefaultDescriptionParameters;
    }
        /// <summary>
        /// There are no comments for DefaultDescriptions in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// Description
    /// Language
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Description", "Language")]
    [global::Microsoft.OData.Client.EntitySet("DefaultDescriptions")]
    public partial class DefaultDescriptions : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DefaultDescriptions object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="language">Initial value of Language.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DefaultDescriptions CreateDefaultDescriptions(string dataAreaId, string language)
        {
            DefaultDescriptions defaultDescriptions = new DefaultDescriptions();
            defaultDescriptions.dataAreaId = dataAreaId;
            defaultDescriptions.Language = language;
            return defaultDescriptions;
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
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerTransTxt> Description
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerTransTxt> _Description;
        partial void OnDescriptionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerTransTxt> value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Language in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Language
        {
            get
            {
                return this._Language;
            }
            set
            {
                this.OnLanguageChanging(value);
                this._Language = value;
                this.OnLanguageChanged();
                this.OnPropertyChanged("Language");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Language;
        partial void OnLanguageChanging(string value);
        partial void OnLanguageChanged();
        /// <summary>
        /// There are no comments for Property Text in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Text
        {
            get
            {
                return this._Text;
            }
            set
            {
                this.OnTextChanging(value);
                this._Text = value;
                this.OnTextChanged();
                this.OnPropertyChanged("Text");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Text;
        partial void OnTextChanging(string value);
        partial void OnTextChanged();
        /// <summary>
        /// There are no comments for Property DefaultDescriptionParameters in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DefaultDescriptionParameters> DefaultDescriptionParameters
        {
            get
            {
                return this._DefaultDescriptionParameters;
            }
            set
            {
                this.OnDefaultDescriptionParametersChanging(value);
                this._DefaultDescriptionParameters = value;
                this.OnDefaultDescriptionParametersChanged();
                this.OnPropertyChanged("DefaultDescriptionParameters");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DefaultDescriptionParameters> _DefaultDescriptionParameters = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DefaultDescriptionParameters>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDefaultDescriptionParametersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DefaultDescriptionParameters> value);
        partial void OnDefaultDescriptionParametersChanged();
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
