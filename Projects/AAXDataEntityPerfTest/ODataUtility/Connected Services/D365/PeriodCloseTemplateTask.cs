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
        /// There are no comments for PeriodCloseTemplateTaskSingle in the schema.
        /// </summary>
    public partial class PeriodCloseTemplateTaskSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PeriodCloseTemplateTask>
    {
        /// <summary>
        /// Initialize a new PeriodCloseTemplateTaskSingle object.
        /// </summary>
        public PeriodCloseTemplateTaskSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PeriodCloseTemplateTaskSingle object.
        /// </summary>
        public PeriodCloseTemplateTaskSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PeriodCloseTemplateTaskSingle object.
        /// </summary>
        public PeriodCloseTemplateTaskSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PeriodCloseTemplateTask> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for PeriodCloseTemplateTask in the schema.
        /// </summary>
    /// <KeyProperties>
    /// Template
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Template", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("PeriodCloseTemplateTasks")]
    public partial class PeriodCloseTemplateTask : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PeriodCloseTemplateTask object.
        /// </summary>
        /// <param name="template">Initial value of Template.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="dueTime">Initial value of DueTime.</param>
        /// <param name="targetDaysFromProjectComplete">Initial value of TargetDaysFromProjectComplete.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PeriodCloseTemplateTask CreatePeriodCloseTemplateTask(string template, decimal lineNumber, int dueTime, int targetDaysFromProjectComplete)
        {
            PeriodCloseTemplateTask periodCloseTemplateTask = new PeriodCloseTemplateTask();
            periodCloseTemplateTask.Template = template;
            periodCloseTemplateTask.LineNumber = lineNumber;
            periodCloseTemplateTask.DueTime = dueTime;
            periodCloseTemplateTask.TargetDaysFromProjectComplete = targetDaysFromProjectComplete;
            return periodCloseTemplateTask;
        }
        /// <summary>
        /// There are no comments for Property Template in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Template
        {
            get
            {
                return this._Template;
            }
            set
            {
                this.OnTemplateChanging(value);
                this._Template = value;
                this.OnTemplateChanged();
                this.OnPropertyChanged("Template");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Template;
        partial void OnTemplateChanging(string value);
        partial void OnTemplateChanged();
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
        /// There are no comments for Property Area in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Area
        {
            get
            {
                return this._Area;
            }
            set
            {
                this.OnAreaChanging(value);
                this._Area = value;
                this.OnAreaChanged();
                this.OnPropertyChanged("Area");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Area;
        partial void OnAreaChanging(string value);
        partial void OnAreaChanged();
        /// <summary>
        /// There are no comments for Property Task in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Task
        {
            get
            {
                return this._Task;
            }
            set
            {
                this.OnTaskChanging(value);
                this._Task = value;
                this.OnTaskChanged();
                this.OnPropertyChanged("Task");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Task;
        partial void OnTaskChanging(string value);
        partial void OnTaskChanged();
        /// <summary>
        /// There are no comments for Property CompanySelection in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CompanySelection
        {
            get
            {
                return this._CompanySelection;
            }
            set
            {
                this.OnCompanySelectionChanging(value);
                this._CompanySelection = value;
                this.OnCompanySelectionChanged();
                this.OnPropertyChanged("CompanySelection");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CompanySelection;
        partial void OnCompanySelectionChanging(string value);
        partial void OnCompanySelectionChanged();
        /// <summary>
        /// There are no comments for Property TaskLinkType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerPeriodCloseTaskAction> TaskLinkType
        {
            get
            {
                return this._TaskLinkType;
            }
            set
            {
                this.OnTaskLinkTypeChanging(value);
                this._TaskLinkType = value;
                this.OnTaskLinkTypeChanged();
                this.OnPropertyChanged("TaskLinkType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerPeriodCloseTaskAction> _TaskLinkType;
        partial void OnTaskLinkTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerPeriodCloseTaskAction> value);
        partial void OnTaskLinkTypeChanged();
        /// <summary>
        /// There are no comments for Property ClosingRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ClosingRole
        {
            get
            {
                return this._ClosingRole;
            }
            set
            {
                this.OnClosingRoleChanging(value);
                this._ClosingRole = value;
                this.OnClosingRoleChanged();
                this.OnPropertyChanged("ClosingRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ClosingRole;
        partial void OnClosingRoleChanging(string value);
        partial void OnClosingRoleChanged();
        /// <summary>
        /// There are no comments for Property DueTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int DueTime
        {
            get
            {
                return this._DueTime;
            }
            set
            {
                this.OnDueTimeChanging(value);
                this._DueTime = value;
                this.OnDueTimeChanged();
                this.OnPropertyChanged("DueTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DueTime;
        partial void OnDueTimeChanging(int value);
        partial void OnDueTimeChanged();
        /// <summary>
        /// There are no comments for Property TargetDaysFromProjectComplete in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int TargetDaysFromProjectComplete
        {
            get
            {
                return this._TargetDaysFromProjectComplete;
            }
            set
            {
                this.OnTargetDaysFromProjectCompleteChanging(value);
                this._TargetDaysFromProjectComplete = value;
                this.OnTargetDaysFromProjectCompleteChanged();
                this.OnPropertyChanged("TargetDaysFromProjectComplete");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _TargetDaysFromProjectComplete;
        partial void OnTargetDaysFromProjectCompleteChanging(int value);
        partial void OnTargetDaysFromProjectCompleteChanged();
        /// <summary>
        /// There are no comments for Property TaskLink in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaskLink
        {
            get
            {
                return this._TaskLink;
            }
            set
            {
                this.OnTaskLinkChanging(value);
                this._TaskLink = value;
                this.OnTaskLinkChanged();
                this.OnPropertyChanged("TaskLink");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaskLink;
        partial void OnTaskLinkChanging(string value);
        partial void OnTaskLinkChanged();
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
