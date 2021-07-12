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
        /// There are no comments for DataManagementDefinitionGroupSingle in the schema.
        /// </summary>
    public partial class DataManagementDefinitionGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DataManagementDefinitionGroup>
    {
        /// <summary>
        /// Initialize a new DataManagementDefinitionGroupSingle object.
        /// </summary>
        public DataManagementDefinitionGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DataManagementDefinitionGroupSingle object.
        /// </summary>
        public DataManagementDefinitionGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DataManagementDefinitionGroupSingle object.
        /// </summary>
        public DataManagementDefinitionGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DataManagementDefinitionGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Details in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DataManagementDefinitionGroupDetail> Details
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Details == null))
                {
                    this._Details = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.DataManagementDefinitionGroupDetail>(GetPath("Details"));
                }
                return this._Details;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DataManagementDefinitionGroupDetail> _Details;
    }
        /// <summary>
        /// There are no comments for DataManagementDefinitionGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Name")]
    [global::Microsoft.OData.Client.EntitySet("DataManagementDefinitionGroups")]
    public partial class DataManagementDefinitionGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DataManagementDefinitionGroup object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DataManagementDefinitionGroup CreateDataManagementDefinitionGroup(string name)
        {
            DataManagementDefinitionGroup dataManagementDefinitionGroup = new DataManagementDefinitionGroup();
            dataManagementDefinitionGroup.Name = name;
            return dataManagementDefinitionGroup;
        }
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
        /// There are no comments for Property ProjectCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DMFProjectCategory> ProjectCategory
        {
            get
            {
                return this._ProjectCategory;
            }
            set
            {
                this.OnProjectCategoryChanging(value);
                this._ProjectCategory = value;
                this.OnProjectCategoryChanged();
                this.OnPropertyChanged("ProjectCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DMFProjectCategory> _ProjectCategory;
        partial void OnProjectCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DMFProjectCategory> value);
        partial void OnProjectCategoryChanged();
        /// <summary>
        /// There are no comments for Property OperationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DMFOperationType> OperationType
        {
            get
            {
                return this._OperationType;
            }
            set
            {
                this.OnOperationTypeChanging(value);
                this._OperationType = value;
                this.OnOperationTypeChanged();
                this.OnPropertyChanged("OperationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DMFOperationType> _OperationType;
        partial void OnOperationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DMFOperationType> value);
        partial void OnOperationTypeChanged();
        /// <summary>
        /// There are no comments for Property GenerateDataPackage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> GenerateDataPackage
        {
            get
            {
                return this._GenerateDataPackage;
            }
            set
            {
                this.OnGenerateDataPackageChanging(value);
                this._GenerateDataPackage = value;
                this.OnGenerateDataPackageChanged();
                this.OnPropertyChanged("GenerateDataPackage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _GenerateDataPackage;
        partial void OnGenerateDataPackageChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnGenerateDataPackageChanged();
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
        /// There are no comments for Property TruncateEntityData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> TruncateEntityData
        {
            get
            {
                return this._TruncateEntityData;
            }
            set
            {
                this.OnTruncateEntityDataChanging(value);
                this._TruncateEntityData = value;
                this.OnTruncateEntityDataChanged();
                this.OnPropertyChanged("TruncateEntityData");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _TruncateEntityData;
        partial void OnTruncateEntityDataChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnTruncateEntityDataChanged();
        /// <summary>
        /// There are no comments for Property Details in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementDefinitionGroupDetail> Details
        {
            get
            {
                return this._Details;
            }
            set
            {
                this.OnDetailsChanging(value);
                this._Details = value;
                this.OnDetailsChanged();
                this.OnPropertyChanged("Details");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementDefinitionGroupDetail> _Details = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementDefinitionGroupDetail>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementDefinitionGroupDetail> value);
        partial void OnDetailsChanged();
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
