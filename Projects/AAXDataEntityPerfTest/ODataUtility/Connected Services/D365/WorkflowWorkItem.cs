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
        /// There are no comments for WorkflowWorkItemSingle in the schema.
        /// </summary>
    public partial class WorkflowWorkItemSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkflowWorkItem>
    {
        /// <summary>
        /// Initialize a new WorkflowWorkItemSingle object.
        /// </summary>
        public WorkflowWorkItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkflowWorkItemSingle object.
        /// </summary>
        public WorkflowWorkItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkflowWorkItemSingle object.
        /// </summary>
        public WorkflowWorkItemSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkflowWorkItem> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for WorkflowWorkItem in the schema.
        /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("WorkflowWorkItems")]
    public partial class WorkflowWorkItem : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkflowWorkItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="originalCorrelationId">Initial value of OriginalCorrelationId.</param>
        /// <param name="correlationId">Initial value of CorrelationId.</param>
        /// <param name="stepId">Initial value of StepId.</param>
        /// <param name="parentCorrelationId">Initial value of ParentCorrelationId.</param>
        /// <param name="commentId">Initial value of CommentId.</param>
        /// <param name="activityId">Initial value of ActivityId.</param>
        /// <param name="subWorkflowId">Initial value of SubWorkflowId.</param>
        /// <param name="rootCorrelationId">Initial value of RootCorrelationId.</param>
        /// <param name="escalationLevel">Initial value of EscalationLevel.</param>
        /// <param name="dueDateTime">Initial value of DueDateTime.</param>
        /// <param name="configurationId">Initial value of ConfigurationId.</param>
        /// <param name="documentClassId">Initial value of DocumentClassId.</param>
        /// <param name="notificationId">Initial value of NotificationId.</param>
        /// <param name="elementId">Initial value of ElementId.</param>
        /// <param name="refTableId">Initial value of RefTableId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkflowWorkItem CreateWorkflowWorkItem(global::System.Guid ID, 
                    global::System.Guid originalCorrelationId, 
                    global::System.Guid correlationId, 
                    global::System.Guid stepId, 
                    global::System.Guid parentCorrelationId, 
                    global::System.Guid commentId, 
                    global::System.Guid activityId, 
                    global::System.Guid subWorkflowId, 
                    global::System.Guid rootCorrelationId, 
                    int escalationLevel, 
                    global::System.DateTimeOffset dueDateTime, 
                    global::System.Guid configurationId, 
                    int documentClassId, 
                    long notificationId, 
                    global::System.Guid elementId, 
                    int refTableId)
        {
            WorkflowWorkItem workflowWorkItem = new WorkflowWorkItem();
            workflowWorkItem.Id = ID;
            workflowWorkItem.OriginalCorrelationId = originalCorrelationId;
            workflowWorkItem.CorrelationId = correlationId;
            workflowWorkItem.StepId = stepId;
            workflowWorkItem.ParentCorrelationId = parentCorrelationId;
            workflowWorkItem.CommentId = commentId;
            workflowWorkItem.ActivityId = activityId;
            workflowWorkItem.SubWorkflowId = subWorkflowId;
            workflowWorkItem.RootCorrelationId = rootCorrelationId;
            workflowWorkItem.EscalationLevel = escalationLevel;
            workflowWorkItem.DueDateTime = dueDateTime;
            workflowWorkItem.ConfigurationId = configurationId;
            workflowWorkItem.DocumentClassId = documentClassId;
            workflowWorkItem.NotificationId = notificationId;
            workflowWorkItem.ElementId = elementId;
            workflowWorkItem.RefTableId = refTableId;
            return workflowWorkItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property IsClaimed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsClaimed
        {
            get
            {
                return this._IsClaimed;
            }
            set
            {
                this.OnIsClaimedChanging(value);
                this._IsClaimed = value;
                this.OnIsClaimedChanged();
                this.OnPropertyChanged("IsClaimed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsClaimed;
        partial void OnIsClaimedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsClaimedChanged();
        /// <summary>
        /// There are no comments for Property Subject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Subject
        {
            get
            {
                return this._Subject;
            }
            set
            {
                this.OnSubjectChanging(value);
                this._Subject = value;
                this.OnSubjectChanged();
                this.OnPropertyChanged("Subject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Subject;
        partial void OnSubjectChanging(string value);
        partial void OnSubjectChanged();
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
        /// There are no comments for Property OriginalCorrelationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid OriginalCorrelationId
        {
            get
            {
                return this._OriginalCorrelationId;
            }
            set
            {
                this.OnOriginalCorrelationIdChanging(value);
                this._OriginalCorrelationId = value;
                this.OnOriginalCorrelationIdChanged();
                this.OnPropertyChanged("OriginalCorrelationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _OriginalCorrelationId;
        partial void OnOriginalCorrelationIdChanging(global::System.Guid value);
        partial void OnOriginalCorrelationIdChanged();
        /// <summary>
        /// There are no comments for Property CorrelationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid CorrelationId
        {
            get
            {
                return this._CorrelationId;
            }
            set
            {
                this.OnCorrelationIdChanging(value);
                this._CorrelationId = value;
                this.OnCorrelationIdChanged();
                this.OnPropertyChanged("CorrelationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _CorrelationId;
        partial void OnCorrelationIdChanging(global::System.Guid value);
        partial void OnCorrelationIdChanged();
        /// <summary>
        /// There are no comments for Property StepId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid StepId
        {
            get
            {
                return this._StepId;
            }
            set
            {
                this.OnStepIdChanging(value);
                this._StepId = value;
                this.OnStepIdChanged();
                this.OnPropertyChanged("StepId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _StepId;
        partial void OnStepIdChanging(global::System.Guid value);
        partial void OnStepIdChanged();
        /// <summary>
        /// There are no comments for Property ParentCorrelationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid ParentCorrelationId
        {
            get
            {
                return this._ParentCorrelationId;
            }
            set
            {
                this.OnParentCorrelationIdChanging(value);
                this._ParentCorrelationId = value;
                this.OnParentCorrelationIdChanged();
                this.OnPropertyChanged("ParentCorrelationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ParentCorrelationId;
        partial void OnParentCorrelationIdChanging(global::System.Guid value);
        partial void OnParentCorrelationIdChanged();
        /// <summary>
        /// There are no comments for Property CommentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid CommentId
        {
            get
            {
                return this._CommentId;
            }
            set
            {
                this.OnCommentIdChanging(value);
                this._CommentId = value;
                this.OnCommentIdChanged();
                this.OnPropertyChanged("CommentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _CommentId;
        partial void OnCommentIdChanging(global::System.Guid value);
        partial void OnCommentIdChanged();
        /// <summary>
        /// There are no comments for Property ActivityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid ActivityId
        {
            get
            {
                return this._ActivityId;
            }
            set
            {
                this.OnActivityIdChanging(value);
                this._ActivityId = value;
                this.OnActivityIdChanged();
                this.OnPropertyChanged("ActivityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ActivityId;
        partial void OnActivityIdChanging(global::System.Guid value);
        partial void OnActivityIdChanged();
        /// <summary>
        /// There are no comments for Property SubWorkflowId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid SubWorkflowId
        {
            get
            {
                return this._SubWorkflowId;
            }
            set
            {
                this.OnSubWorkflowIdChanging(value);
                this._SubWorkflowId = value;
                this.OnSubWorkflowIdChanged();
                this.OnPropertyChanged("SubWorkflowId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _SubWorkflowId;
        partial void OnSubWorkflowIdChanging(global::System.Guid value);
        partial void OnSubWorkflowIdChanged();
        /// <summary>
        /// There are no comments for Property RootCorrelationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid RootCorrelationId
        {
            get
            {
                return this._RootCorrelationId;
            }
            set
            {
                this.OnRootCorrelationIdChanging(value);
                this._RootCorrelationId = value;
                this.OnRootCorrelationIdChanged();
                this.OnPropertyChanged("RootCorrelationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _RootCorrelationId;
        partial void OnRootCorrelationIdChanging(global::System.Guid value);
        partial void OnRootCorrelationIdChanged();
        /// <summary>
        /// There are no comments for Property WorkflowWorkItem_Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkflowWorkItem_Name
        {
            get
            {
                return this._WorkflowWorkItem_Name;
            }
            set
            {
                this.OnWorkflowWorkItem_NameChanging(value);
                this._WorkflowWorkItem_Name = value;
                this.OnWorkflowWorkItem_NameChanged();
                this.OnPropertyChanged("WorkflowWorkItem_Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkflowWorkItem_Name;
        partial void OnWorkflowWorkItem_NameChanging(string value);
        partial void OnWorkflowWorkItem_NameChanged();
        /// <summary>
        /// There are no comments for Property MenuItemName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MenuItemName
        {
            get
            {
                return this._MenuItemName;
            }
            set
            {
                this.OnMenuItemNameChanging(value);
                this._MenuItemName = value;
                this.OnMenuItemNameChanged();
                this.OnPropertyChanged("MenuItemName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MenuItemName;
        partial void OnMenuItemNameChanging(string value);
        partial void OnMenuItemNameChanged();
        /// <summary>
        /// There are no comments for Property EscalationLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int EscalationLevel
        {
            get
            {
                return this._EscalationLevel;
            }
            set
            {
                this.OnEscalationLevelChanging(value);
                this._EscalationLevel = value;
                this.OnEscalationLevelChanged();
                this.OnPropertyChanged("EscalationLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _EscalationLevel;
        partial void OnEscalationLevelChanging(int value);
        partial void OnEscalationLevelChanged();
        /// <summary>
        /// There are no comments for Property DueDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DueDateTime
        {
            get
            {
                return this._DueDateTime;
            }
            set
            {
                this.OnDueDateTimeChanging(value);
                this._DueDateTime = value;
                this.OnDueDateTimeChanged();
                this.OnPropertyChanged("DueDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DueDateTime;
        partial void OnDueDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnDueDateTimeChanged();
        /// <summary>
        /// There are no comments for Property ConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid ConfigurationId
        {
            get
            {
                return this._ConfigurationId;
            }
            set
            {
                this.OnConfigurationIdChanging(value);
                this._ConfigurationId = value;
                this.OnConfigurationIdChanged();
                this.OnPropertyChanged("ConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ConfigurationId;
        partial void OnConfigurationIdChanging(global::System.Guid value);
        partial void OnConfigurationIdChanged();
        /// <summary>
        /// There are no comments for Property WorkflowWorkItem_WorkitemType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkflowWorkItem_WorkitemType
        {
            get
            {
                return this._WorkflowWorkItem_WorkitemType;
            }
            set
            {
                this.OnWorkflowWorkItem_WorkitemTypeChanging(value);
                this._WorkflowWorkItem_WorkitemType = value;
                this.OnWorkflowWorkItem_WorkitemTypeChanged();
                this.OnPropertyChanged("WorkflowWorkItem_WorkitemType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkflowWorkItem_WorkitemType;
        partial void OnWorkflowWorkItem_WorkitemTypeChanging(string value);
        partial void OnWorkflowWorkItem_WorkitemTypeChanged();
        /// <summary>
        /// There are no comments for Property DocumentClassId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int DocumentClassId
        {
            get
            {
                return this._DocumentClassId;
            }
            set
            {
                this.OnDocumentClassIdChanging(value);
                this._DocumentClassId = value;
                this.OnDocumentClassIdChanged();
                this.OnPropertyChanged("DocumentClassId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DocumentClassId;
        partial void OnDocumentClassIdChanging(int value);
        partial void OnDocumentClassIdChanged();
        /// <summary>
        /// There are no comments for Property CompanyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                this.OnCompanyIdChanging(value);
                this._CompanyId = value;
                this.OnCompanyIdChanged();
                this.OnPropertyChanged("CompanyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CompanyId;
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WorkflowWorkItemType> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WorkflowWorkItemType> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WorkflowWorkItemType> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property DataSourceName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DataSourceName
        {
            get
            {
                return this._DataSourceName;
            }
            set
            {
                this.OnDataSourceNameChanging(value);
                this._DataSourceName = value;
                this.OnDataSourceNameChanged();
                this.OnPropertyChanged("DataSourceName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataSourceName;
        partial void OnDataSourceNameChanging(string value);
        partial void OnDataSourceNameChanged();
        /// <summary>
        /// There are no comments for Property Context in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Context
        {
            get
            {
                return this._Context;
            }
            set
            {
                this.OnContextChanging(value);
                this._Context = value;
                this.OnContextChanged();
                this.OnPropertyChanged("Context");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Context;
        partial void OnContextChanging(string value);
        partial void OnContextChanged();
        /// <summary>
        /// There are no comments for Property NotificationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long NotificationId
        {
            get
            {
                return this._NotificationId;
            }
            set
            {
                this.OnNotificationIdChanging(value);
                this._NotificationId = value;
                this.OnNotificationIdChanged();
                this.OnPropertyChanged("NotificationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _NotificationId;
        partial void OnNotificationIdChanging(long value);
        partial void OnNotificationIdChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WorkflowWorkItemStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WorkflowWorkItemStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WorkflowWorkItemStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property ElementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid ElementId
        {
            get
            {
                return this._ElementId;
            }
            set
            {
                this.OnElementIdChanging(value);
                this._ElementId = value;
                this.OnElementIdChanged();
                this.OnPropertyChanged("ElementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ElementId;
        partial void OnElementIdChanging(global::System.Guid value);
        partial void OnElementIdChanged();
        /// <summary>
        /// There are no comments for Property RefTableId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int RefTableId
        {
            get
            {
                return this._RefTableId;
            }
            set
            {
                this.OnRefTableIdChanging(value);
                this._RefTableId = value;
                this.OnRefTableIdChanged();
                this.OnPropertyChanged("RefTableId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _RefTableId;
        partial void OnRefTableIdChanging(int value);
        partial void OnRefTableIdChanged();
        /// <summary>
        /// There are no comments for Property UserId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                this.OnUserIdChanging(value);
                this._UserId = value;
                this.OnUserIdChanged();
                this.OnPropertyChanged("UserId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserId;
        partial void OnUserIdChanging(string value);
        partial void OnUserIdChanged();
        /// <summary>
        /// There are no comments for Property IsRead in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsRead
        {
            get
            {
                return this._IsRead;
            }
            set
            {
                this.OnIsReadChanging(value);
                this._IsRead = value;
                this.OnIsReadChanged();
                this.OnPropertyChanged("IsRead");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsRead;
        partial void OnIsReadChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsReadChanged();
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
