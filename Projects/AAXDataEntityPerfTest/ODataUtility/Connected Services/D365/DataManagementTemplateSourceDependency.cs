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
        /// There are no comments for DataManagementTemplateSourceDependencySingle in the schema.
        /// </summary>
    public partial class DataManagementTemplateSourceDependencySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DataManagementTemplateSourceDependency>
    {
        /// <summary>
        /// Initialize a new DataManagementTemplateSourceDependencySingle object.
        /// </summary>
        public DataManagementTemplateSourceDependencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DataManagementTemplateSourceDependencySingle object.
        /// </summary>
        public DataManagementTemplateSourceDependencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DataManagementTemplateSourceDependencySingle object.
        /// </summary>
        public DataManagementTemplateSourceDependencySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DataManagementTemplateSourceDependency> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TemplateSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSourceSingle TemplateSource
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TemplateSource == null))
                {
                    this._TemplateSource = new global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSourceSingle(this.Context, GetPath("TemplateSource"));
                }
                return this._TemplateSource;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSourceSingle _TemplateSource;
    }
        /// <summary>
        /// There are no comments for DataManagementTemplateSourceDependency in the schema.
        /// </summary>
    /// <KeyProperties>
    /// TemplateId
    /// SourceEntity
    /// DependentOnEntity
    /// RelationName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TemplateId", "SourceEntity", "DependentOnEntity", "RelationName")]
    [global::Microsoft.OData.Client.EntitySet("DataManagementTemplateSourceDependencies")]
    public partial class DataManagementTemplateSourceDependency : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DataManagementTemplateSourceDependency object.
        /// </summary>
        /// <param name="templateId">Initial value of TemplateId.</param>
        /// <param name="sourceEntity">Initial value of SourceEntity.</param>
        /// <param name="dependentOnEntity">Initial value of DependentOnEntity.</param>
        /// <param name="relationName">Initial value of RelationName.</param>
        /// <param name="templateSource">Initial value of TemplateSource.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DataManagementTemplateSourceDependency CreateDataManagementTemplateSourceDependency(string templateId, string sourceEntity, string dependentOnEntity, string relationName, global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSource templateSource)
        {
            DataManagementTemplateSourceDependency dataManagementTemplateSourceDependency = new DataManagementTemplateSourceDependency();
            dataManagementTemplateSourceDependency.TemplateId = templateId;
            dataManagementTemplateSourceDependency.SourceEntity = sourceEntity;
            dataManagementTemplateSourceDependency.DependentOnEntity = dependentOnEntity;
            dataManagementTemplateSourceDependency.RelationName = relationName;
            if ((templateSource == null))
            {
                throw new global::System.ArgumentNullException("templateSource");
            }
            dataManagementTemplateSourceDependency.TemplateSource = templateSource;
            return dataManagementTemplateSourceDependency;
        }
        /// <summary>
        /// There are no comments for Property TemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TemplateId
        {
            get
            {
                return this._TemplateId;
            }
            set
            {
                this.OnTemplateIdChanging(value);
                this._TemplateId = value;
                this.OnTemplateIdChanged();
                this.OnPropertyChanged("TemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TemplateId;
        partial void OnTemplateIdChanging(string value);
        partial void OnTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property SourceEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SourceEntity
        {
            get
            {
                return this._SourceEntity;
            }
            set
            {
                this.OnSourceEntityChanging(value);
                this._SourceEntity = value;
                this.OnSourceEntityChanged();
                this.OnPropertyChanged("SourceEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceEntity;
        partial void OnSourceEntityChanging(string value);
        partial void OnSourceEntityChanged();
        /// <summary>
        /// There are no comments for Property DependentOnEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DependentOnEntity
        {
            get
            {
                return this._DependentOnEntity;
            }
            set
            {
                this.OnDependentOnEntityChanging(value);
                this._DependentOnEntity = value;
                this.OnDependentOnEntityChanged();
                this.OnPropertyChanged("DependentOnEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DependentOnEntity;
        partial void OnDependentOnEntityChanging(string value);
        partial void OnDependentOnEntityChanged();
        /// <summary>
        /// There are no comments for Property RelationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RelationName
        {
            get
            {
                return this._RelationName;
            }
            set
            {
                this.OnRelationNameChanging(value);
                this._RelationName = value;
                this.OnRelationNameChanged();
                this.OnPropertyChanged("RelationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RelationName;
        partial void OnRelationNameChanging(string value);
        partial void OnRelationNameChanged();
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
        /// There are no comments for Property ValidationRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ValidationRequired
        {
            get
            {
                return this._ValidationRequired;
            }
            set
            {
                this.OnValidationRequiredChanging(value);
                this._ValidationRequired = value;
                this.OnValidationRequiredChanged();
                this.OnPropertyChanged("ValidationRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ValidationRequired;
        partial void OnValidationRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnValidationRequiredChanged();
        /// <summary>
        /// There are no comments for Property FriendlyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FriendlyName
        {
            get
            {
                return this._FriendlyName;
            }
            set
            {
                this.OnFriendlyNameChanging(value);
                this._FriendlyName = value;
                this.OnFriendlyNameChanged();
                this.OnPropertyChanged("FriendlyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FriendlyName;
        partial void OnFriendlyNameChanging(string value);
        partial void OnFriendlyNameChanged();
        /// <summary>
        /// There are no comments for Property TemplateSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSource TemplateSource
        {
            get
            {
                return this._TemplateSource;
            }
            set
            {
                this.OnTemplateSourceChanging(value);
                this._TemplateSource = value;
                this.OnTemplateSourceChanged();
                this.OnPropertyChanged("TemplateSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSource _TemplateSource;
        partial void OnTemplateSourceChanging(global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSource value);
        partial void OnTemplateSourceChanged();
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
