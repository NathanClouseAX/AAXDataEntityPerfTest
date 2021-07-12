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
        /// There are no comments for ValidationTaskAreaSingle in the schema.
        /// </summary>
    public partial class ValidationTaskAreaSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ValidationTaskArea>
    {
        /// <summary>
        /// Initialize a new ValidationTaskAreaSingle object.
        /// </summary>
        public ValidationTaskAreaSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ValidationTaskAreaSingle object.
        /// </summary>
        public ValidationTaskAreaSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ValidationTaskAreaSingle object.
        /// </summary>
        public ValidationTaskAreaSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ValidationTaskArea> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ValidationProjectTask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ValidationProjectTask> ValidationProjectTask
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ValidationProjectTask == null))
                {
                    this._ValidationProjectTask = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ValidationProjectTask>(GetPath("ValidationProjectTask"));
                }
                return this._ValidationProjectTask;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ValidationProjectTask> _ValidationProjectTask;
    }
        /// <summary>
        /// There are no comments for ValidationTaskArea in the schema.
        /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Name")]
    [global::Microsoft.OData.Client.EntitySet("ValidationTaskAreas")]
    public partial class ValidationTaskArea : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ValidationTaskArea object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="displayOrder">Initial value of DisplayOrder.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ValidationTaskArea CreateValidationTaskArea(string name, decimal displayOrder)
        {
            ValidationTaskArea validationTaskArea = new ValidationTaskArea();
            validationTaskArea.Name = name;
            validationTaskArea.DisplayOrder = displayOrder;
            return validationTaskArea;
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
        /// There are no comments for Property DisplayOrder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DisplayOrder
        {
            get
            {
                return this._DisplayOrder;
            }
            set
            {
                this.OnDisplayOrderChanging(value);
                this._DisplayOrder = value;
                this.OnDisplayOrderChanged();
                this.OnPropertyChanged("DisplayOrder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DisplayOrder;
        partial void OnDisplayOrderChanging(decimal value);
        partial void OnDisplayOrderChanged();
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
        /// There are no comments for Property ValidationProjectTask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ValidationProjectTask> ValidationProjectTask
        {
            get
            {
                return this._ValidationProjectTask;
            }
            set
            {
                this.OnValidationProjectTaskChanging(value);
                this._ValidationProjectTask = value;
                this.OnValidationProjectTaskChanged();
                this.OnPropertyChanged("ValidationProjectTask");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ValidationProjectTask> _ValidationProjectTask = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ValidationProjectTask>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnValidationProjectTaskChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ValidationProjectTask> value);
        partial void OnValidationProjectTaskChanged();
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
