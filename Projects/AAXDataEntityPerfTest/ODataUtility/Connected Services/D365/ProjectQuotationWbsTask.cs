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
        /// There are no comments for ProjectQuotationWbsTaskSingle in the schema.
        /// </summary>
    public partial class ProjectQuotationWbsTaskSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectQuotationWbsTask>
    {
        /// <summary>
        /// Initialize a new ProjectQuotationWbsTaskSingle object.
        /// </summary>
        public ProjectQuotationWbsTaskSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjectQuotationWbsTaskSingle object.
        /// </summary>
        public ProjectQuotationWbsTaskSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjectQuotationWbsTaskSingle object.
        /// </summary>
        public ProjectQuotationWbsTaskSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectQuotationWbsTask> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProjectCategories in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectCategoryEntitySingle ProjectCategories
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjectCategories == null))
                {
                    this._ProjectCategories = new global::Microsoft.Dynamics.DataEntities.ProjectCategoryEntitySingle(this.Context, GetPath("ProjectCategories"));
                }
                return this._ProjectCategories;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectCategoryEntitySingle _ProjectCategories;
        /// <summary>
        /// There are no comments for ResourceCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ResourceCategorySingle ResourceCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ResourceCategory == null))
                {
                    this._ResourceCategory = new global::Microsoft.Dynamics.DataEntities.ResourceCategorySingle(this.Context, GetPath("ResourceCategory"));
                }
                return this._ResourceCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ResourceCategorySingle _ResourceCategory;
    }
        /// <summary>
        /// There are no comments for ProjectQuotationWbsTask in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// QuotationId
    /// WBSId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "QuotationId", "WBSId")]
    [global::Microsoft.OData.Client.EntitySet("ProjectQuotationWbsTasks")]
    public partial class ProjectQuotationWbsTask : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjectQuotationWbsTask object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="quotationId">Initial value of QuotationId.</param>
        /// <param name="wBSId">Initial value of WBSId.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="numberOfResources">Initial value of NumberOfResources.</param>
        /// <param name="taskEffortAtComplete">Initial value of TaskEffortAtComplete.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="taskCostAtComplete">Initial value of TaskCostAtComplete.</param>
        /// <param name="effort">Initial value of Effort.</param>
        /// <param name="duration">Initial value of Duration.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjectQuotationWbsTask CreateProjectQuotationWbsTask(string dataAreaId, 
                    string quotationId, 
                    string wBSId, 
                    global::System.DateTimeOffset endDate, 
                    decimal numberOfResources, 
                    decimal taskEffortAtComplete, 
                    global::System.DateTimeOffset startDate, 
                    decimal taskCostAtComplete, 
                    decimal effort, 
                    decimal duration)
        {
            ProjectQuotationWbsTask projectQuotationWbsTask = new ProjectQuotationWbsTask();
            projectQuotationWbsTask.dataAreaId = dataAreaId;
            projectQuotationWbsTask.QuotationId = quotationId;
            projectQuotationWbsTask.WBSId = wBSId;
            projectQuotationWbsTask.EndDate = endDate;
            projectQuotationWbsTask.NumberOfResources = numberOfResources;
            projectQuotationWbsTask.TaskEffortAtComplete = taskEffortAtComplete;
            projectQuotationWbsTask.StartDate = startDate;
            projectQuotationWbsTask.TaskCostAtComplete = taskCostAtComplete;
            projectQuotationWbsTask.Effort = effort;
            projectQuotationWbsTask.Duration = duration;
            return projectQuotationWbsTask;
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
        /// There are no comments for Property QuotationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string QuotationId
        {
            get
            {
                return this._QuotationId;
            }
            set
            {
                this.OnQuotationIdChanging(value);
                this._QuotationId = value;
                this.OnQuotationIdChanged();
                this.OnPropertyChanged("QuotationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QuotationId;
        partial void OnQuotationIdChanging(string value);
        partial void OnQuotationIdChanged();
        /// <summary>
        /// There are no comments for Property WBSId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WBSId
        {
            get
            {
                return this._WBSId;
            }
            set
            {
                this.OnWBSIdChanging(value);
                this._WBSId = value;
                this.OnWBSIdChanged();
                this.OnPropertyChanged("WBSId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WBSId;
        partial void OnWBSIdChanging(string value);
        partial void OnWBSIdChanged();
        /// <summary>
        /// There are no comments for Property EndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this.OnEndDateChanging(value);
                this._EndDate = value;
                this.OnEndDateChanged();
                this.OnPropertyChanged("EndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EndDate;
        partial void OnEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEndDateChanged();
        /// <summary>
        /// There are no comments for Property Category in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this.OnCategoryChanging(value);
                this._Category = value;
                this.OnCategoryChanged();
                this.OnPropertyChanged("Category");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Category;
        partial void OnCategoryChanging(string value);
        partial void OnCategoryChanged();
        /// <summary>
        /// There are no comments for Property IsTaskClosed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsTaskClosed
        {
            get
            {
                return this._IsTaskClosed;
            }
            set
            {
                this.OnIsTaskClosedChanging(value);
                this._IsTaskClosed = value;
                this.OnIsTaskClosedChanged();
                this.OnPropertyChanged("IsTaskClosed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsTaskClosed;
        partial void OnIsTaskClosedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsTaskClosedChanged();
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
        /// There are no comments for Property NumberOfResources in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal NumberOfResources
        {
            get
            {
                return this._NumberOfResources;
            }
            set
            {
                this.OnNumberOfResourcesChanging(value);
                this._NumberOfResources = value;
                this.OnNumberOfResourcesChanged();
                this.OnPropertyChanged("NumberOfResources");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _NumberOfResources;
        partial void OnNumberOfResourcesChanging(decimal value);
        partial void OnNumberOfResourcesChanged();
        /// <summary>
        /// There are no comments for Property TaskEffortAtComplete in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TaskEffortAtComplete
        {
            get
            {
                return this._TaskEffortAtComplete;
            }
            set
            {
                this.OnTaskEffortAtCompleteChanging(value);
                this._TaskEffortAtComplete = value;
                this.OnTaskEffortAtCompleteChanged();
                this.OnPropertyChanged("TaskEffortAtComplete");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TaskEffortAtComplete;
        partial void OnTaskEffortAtCompleteChanging(decimal value);
        partial void OnTaskEffortAtCompleteChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDate;
        partial void OnStartDateChanging(global::System.DateTimeOffset value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property TaskCostAtComplete in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TaskCostAtComplete
        {
            get
            {
                return this._TaskCostAtComplete;
            }
            set
            {
                this.OnTaskCostAtCompleteChanging(value);
                this._TaskCostAtComplete = value;
                this.OnTaskCostAtCompleteChanged();
                this.OnPropertyChanged("TaskCostAtComplete");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TaskCostAtComplete;
        partial void OnTaskCostAtCompleteChanging(decimal value);
        partial void OnTaskCostAtCompleteChanged();
        /// <summary>
        /// There are no comments for Property Effort in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Effort
        {
            get
            {
                return this._Effort;
            }
            set
            {
                this.OnEffortChanging(value);
                this._Effort = value;
                this.OnEffortChanged();
                this.OnPropertyChanged("Effort");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Effort;
        partial void OnEffortChanging(decimal value);
        partial void OnEffortChanged();
        /// <summary>
        /// There are no comments for Property IsCategoryMandatory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCategoryMandatory
        {
            get
            {
                return this._IsCategoryMandatory;
            }
            set
            {
                this.OnIsCategoryMandatoryChanging(value);
                this._IsCategoryMandatory = value;
                this.OnIsCategoryMandatoryChanged();
                this.OnPropertyChanged("IsCategoryMandatory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCategoryMandatory;
        partial void OnIsCategoryMandatoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCategoryMandatoryChanged();
        /// <summary>
        /// There are no comments for Property Role in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Role
        {
            get
            {
                return this._Role;
            }
            set
            {
                this.OnRoleChanging(value);
                this._Role = value;
                this.OnRoleChanged();
                this.OnPropertyChanged("Role");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Role;
        partial void OnRoleChanging(string value);
        partial void OnRoleChanged();
        /// <summary>
        /// There are no comments for Property ActivityTaskTimeType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.smmActivityTaskTimeType> ActivityTaskTimeType
        {
            get
            {
                return this._ActivityTaskTimeType;
            }
            set
            {
                this.OnActivityTaskTimeTypeChanging(value);
                this._ActivityTaskTimeType = value;
                this.OnActivityTaskTimeTypeChanged();
                this.OnPropertyChanged("ActivityTaskTimeType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.smmActivityTaskTimeType> _ActivityTaskTimeType;
        partial void OnActivityTaskTimeTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.smmActivityTaskTimeType> value);
        partial void OnActivityTaskTimeTypeChanged();
        /// <summary>
        /// There are no comments for Property Note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this.OnNoteChanging(value);
                this._Note = value;
                this.OnNoteChanged();
                this.OnPropertyChanged("Note");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Note;
        partial void OnNoteChanging(string value);
        partial void OnNoteChanged();
        /// <summary>
        /// There are no comments for Property Duration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Duration
        {
            get
            {
                return this._Duration;
            }
            set
            {
                this.OnDurationChanging(value);
                this._Duration = value;
                this.OnDurationChanged();
                this.OnPropertyChanged("Duration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Duration;
        partial void OnDurationChanging(decimal value);
        partial void OnDurationChanged();
        /// <summary>
        /// There are no comments for Property IsTaskMandatory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsTaskMandatory
        {
            get
            {
                return this._IsTaskMandatory;
            }
            set
            {
                this.OnIsTaskMandatoryChanging(value);
                this._IsTaskMandatory = value;
                this.OnIsTaskMandatoryChanged();
                this.OnPropertyChanged("IsTaskMandatory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsTaskMandatory;
        partial void OnIsTaskMandatoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsTaskMandatoryChanged();
        /// <summary>
        /// There are no comments for Property ActivityStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.smmActivityTaskTimeType> ActivityStatus
        {
            get
            {
                return this._ActivityStatus;
            }
            set
            {
                this.OnActivityStatusChanging(value);
                this._ActivityStatus = value;
                this.OnActivityStatusChanged();
                this.OnPropertyChanged("ActivityStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.smmActivityTaskTimeType> _ActivityStatus;
        partial void OnActivityStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.smmActivityTaskTimeType> value);
        partial void OnActivityStatusChanged();
        /// <summary>
        /// There are no comments for Property Predecessors in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Predecessors
        {
            get
            {
                return this._Predecessors;
            }
            set
            {
                this.OnPredecessorsChanging(value);
                this._Predecessors = value;
                this.OnPredecessorsChanged();
                this.OnPropertyChanged("Predecessors");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Predecessors;
        partial void OnPredecessorsChanging(string value);
        partial void OnPredecessorsChanged();
        /// <summary>
        /// There are no comments for Property TaskPriority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.smmActivityPriority> TaskPriority
        {
            get
            {
                return this._TaskPriority;
            }
            set
            {
                this.OnTaskPriorityChanging(value);
                this._TaskPriority = value;
                this.OnTaskPriorityChanged();
                this.OnPropertyChanged("TaskPriority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.smmActivityPriority> _TaskPriority;
        partial void OnTaskPriorityChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.smmActivityPriority> value);
        partial void OnTaskPriorityChanged();
        /// <summary>
        /// There are no comments for Property ProjectCategories in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectCategoryEntity ProjectCategories
        {
            get
            {
                return this._ProjectCategories;
            }
            set
            {
                this.OnProjectCategoriesChanging(value);
                this._ProjectCategories = value;
                this.OnProjectCategoriesChanged();
                this.OnPropertyChanged("ProjectCategories");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectCategoryEntity _ProjectCategories;
        partial void OnProjectCategoriesChanging(global::Microsoft.Dynamics.DataEntities.ProjectCategoryEntity value);
        partial void OnProjectCategoriesChanged();
        /// <summary>
        /// There are no comments for Property ResourceCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ResourceCategory ResourceCategory
        {
            get
            {
                return this._ResourceCategory;
            }
            set
            {
                this.OnResourceCategoryChanging(value);
                this._ResourceCategory = value;
                this.OnResourceCategoryChanged();
                this.OnPropertyChanged("ResourceCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ResourceCategory _ResourceCategory;
        partial void OnResourceCategoryChanging(global::Microsoft.Dynamics.DataEntities.ResourceCategory value);
        partial void OnResourceCategoryChanged();
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
