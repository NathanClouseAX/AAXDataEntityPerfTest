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
        /// There are no comments for EducationDisciplineCategorySingle in the schema.
        /// </summary>
    public partial class EducationDisciplineCategorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EducationDisciplineCategory>
    {
        /// <summary>
        /// Initialize a new EducationDisciplineCategorySingle object.
        /// </summary>
        public EducationDisciplineCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EducationDisciplineCategorySingle object.
        /// </summary>
        public EducationDisciplineCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EducationDisciplineCategorySingle object.
        /// </summary>
        public EducationDisciplineCategorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EducationDisciplineCategory> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EducationDisciplineGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EducationDisciplineGroup> EducationDisciplineGroups
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EducationDisciplineGroups == null))
                {
                    this._EducationDisciplineGroups = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EducationDisciplineGroup>(GetPath("EducationDisciplineGroups"));
                }
                return this._EducationDisciplineGroups;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EducationDisciplineGroup> _EducationDisciplineGroups;
    }
        /// <summary>
        /// There are no comments for EducationDisciplineCategory in the schema.
        /// </summary>
    /// <KeyProperties>
    /// EducationDisciplineCategory
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EducationDisciplineCategory")]
    [global::Microsoft.OData.Client.EntitySet("EducationDisciplineCategories")]
    public partial class EducationDisciplineCategory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EducationDisciplineCategory object.
        /// </summary>
        /// <param name="educationDisciplineCategory1">Initial value of EducationDisciplineCategory1.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EducationDisciplineCategory CreateEducationDisciplineCategory(string educationDisciplineCategory1)
        {
            EducationDisciplineCategory educationDisciplineCategory = new EducationDisciplineCategory();
            educationDisciplineCategory.EducationDisciplineCategory1 = educationDisciplineCategory1;
            return educationDisciplineCategory;
        }
        /// <summary>
        /// There are no comments for Property EducationDisciplineCategory1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EducationDisciplineCategory")]
        public virtual string EducationDisciplineCategory1
        {
            get
            {
                return this._EducationDisciplineCategory1;
            }
            set
            {
                this.OnEducationDisciplineCategory1Changing(value);
                this._EducationDisciplineCategory1 = value;
                this.OnEducationDisciplineCategory1Changed();
                this.OnPropertyChanged("EducationDisciplineCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EducationDisciplineCategory1;
        partial void OnEducationDisciplineCategory1Changing(string value);
        partial void OnEducationDisciplineCategory1Changed();
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
        /// There are no comments for Property EducationDisciplineGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EducationDisciplineGroup> EducationDisciplineGroups
        {
            get
            {
                return this._EducationDisciplineGroups;
            }
            set
            {
                this.OnEducationDisciplineGroupsChanging(value);
                this._EducationDisciplineGroups = value;
                this.OnEducationDisciplineGroupsChanged();
                this.OnPropertyChanged("EducationDisciplineGroups");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EducationDisciplineGroup> _EducationDisciplineGroups = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EducationDisciplineGroup>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEducationDisciplineGroupsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EducationDisciplineGroup> value);
        partial void OnEducationDisciplineGroupsChanged();
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
