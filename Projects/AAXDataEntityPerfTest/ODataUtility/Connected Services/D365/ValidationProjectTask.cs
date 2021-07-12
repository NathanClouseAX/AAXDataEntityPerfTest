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
        /// There are no comments for ValidationProjectTaskSingle in the schema.
        /// </summary>
    public partial class ValidationProjectTaskSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ValidationProjectTask>
    {
        /// <summary>
        /// Initialize a new ValidationProjectTaskSingle object.
        /// </summary>
        public ValidationProjectTaskSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ValidationProjectTaskSingle object.
        /// </summary>
        public ValidationProjectTaskSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ValidationProjectTaskSingle object.
        /// </summary>
        public ValidationProjectTaskSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ValidationProjectTask> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ValidationTaskArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ValidationTaskAreaSingle ValidationTaskArea
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ValidationTaskArea == null))
                {
                    this._ValidationTaskArea = new global::Microsoft.Dynamics.DataEntities.ValidationTaskAreaSingle(this.Context, GetPath("ValidationTaskArea"));
                }
                return this._ValidationTaskArea;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ValidationTaskAreaSingle _ValidationTaskArea;
        /// <summary>
        /// There are no comments for ValidationProject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ValidationProjectSingle ValidationProject
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ValidationProject == null))
                {
                    this._ValidationProject = new global::Microsoft.Dynamics.DataEntities.ValidationProjectSingle(this.Context, GetPath("ValidationProject"));
                }
                return this._ValidationProject;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ValidationProjectSingle _ValidationProject;
    }
        /// <summary>
        /// There are no comments for ValidationProjectTask in the schema.
        /// </summary>
    /// <KeyProperties>
    /// DataValidationProject_Name
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DataValidationProject_Name", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("ValidationProjectTasks")]
    public partial class ValidationProjectTask : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ValidationProjectTask object.
        /// </summary>
        /// <param name="dataValidationProject_Name">Initial value of DataValidationProject_Name.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="displayOrder">Initial value of DisplayOrder.</param>
        /// <param name="validationTaskArea">Initial value of ValidationTaskArea.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ValidationProjectTask CreateValidationProjectTask(string dataValidationProject_Name, decimal lineNumber, decimal displayOrder, global::Microsoft.Dynamics.DataEntities.ValidationTaskArea validationTaskArea)
        {
            ValidationProjectTask validationProjectTask = new ValidationProjectTask();
            validationProjectTask.DataValidationProject_Name = dataValidationProject_Name;
            validationProjectTask.LineNumber = lineNumber;
            validationProjectTask.DisplayOrder = displayOrder;
            if ((validationTaskArea == null))
            {
                throw new global::System.ArgumentNullException("validationTaskArea");
            }
            validationProjectTask.ValidationTaskArea = validationTaskArea;
            return validationProjectTask;
        }
        /// <summary>
        /// There are no comments for Property DataValidationProject_Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DataValidationProject_Name
        {
            get
            {
                return this._DataValidationProject_Name;
            }
            set
            {
                this.OnDataValidationProject_NameChanging(value);
                this._DataValidationProject_Name = value;
                this.OnDataValidationProject_NameChanged();
                this.OnPropertyChanged("DataValidationProject_Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataValidationProject_Name;
        partial void OnDataValidationProject_NameChanging(string value);
        partial void OnDataValidationProject_NameChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
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
        /// There are no comments for Property MenuItemType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MenuItemType> MenuItemType
        {
            get
            {
                return this._MenuItemType;
            }
            set
            {
                this.OnMenuItemTypeChanging(value);
                this._MenuItemType = value;
                this.OnMenuItemTypeChanged();
                this.OnPropertyChanged("MenuItemType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MenuItemType> _MenuItemType;
        partial void OnMenuItemTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MenuItemType> value);
        partial void OnMenuItemTypeChanged();
        /// <summary>
        /// There are no comments for Property MenuItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MenuItem
        {
            get
            {
                return this._MenuItem;
            }
            set
            {
                this.OnMenuItemChanging(value);
                this._MenuItem = value;
                this.OnMenuItemChanged();
                this.OnPropertyChanged("MenuItem");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MenuItem;
        partial void OnMenuItemChanging(string value);
        partial void OnMenuItemChanged();
        /// <summary>
        /// There are no comments for Property Area_Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Area_Name
        {
            get
            {
                return this._Area_Name;
            }
            set
            {
                this.OnArea_NameChanging(value);
                this._Area_Name = value;
                this.OnArea_NameChanged();
                this.OnPropertyChanged("Area_Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Area_Name;
        partial void OnArea_NameChanging(string value);
        partial void OnArea_NameChanged();
        /// <summary>
        /// There are no comments for Property ValidationTaskArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ValidationTaskArea ValidationTaskArea
        {
            get
            {
                return this._ValidationTaskArea;
            }
            set
            {
                this.OnValidationTaskAreaChanging(value);
                this._ValidationTaskArea = value;
                this.OnValidationTaskAreaChanged();
                this.OnPropertyChanged("ValidationTaskArea");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ValidationTaskArea _ValidationTaskArea;
        partial void OnValidationTaskAreaChanging(global::Microsoft.Dynamics.DataEntities.ValidationTaskArea value);
        partial void OnValidationTaskAreaChanged();
        /// <summary>
        /// There are no comments for Property ValidationProject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ValidationProject ValidationProject
        {
            get
            {
                return this._ValidationProject;
            }
            set
            {
                this.OnValidationProjectChanging(value);
                this._ValidationProject = value;
                this.OnValidationProjectChanged();
                this.OnPropertyChanged("ValidationProject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ValidationProject _ValidationProject;
        partial void OnValidationProjectChanging(global::Microsoft.Dynamics.DataEntities.ValidationProject value);
        partial void OnValidationProjectChanged();
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
