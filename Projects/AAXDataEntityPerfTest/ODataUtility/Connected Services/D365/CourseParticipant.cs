﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 7/17/2021 8:49:18 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for CourseParticipantSingle in the schema.
        /// </summary>
    public partial class CourseParticipantSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CourseParticipant>
    {
        /// <summary>
        /// Initialize a new CourseParticipantSingle object.
        /// </summary>
        public CourseParticipantSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CourseParticipantSingle object.
        /// </summary>
        public CourseParticipantSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CourseParticipantSingle object.
        /// </summary>
        public CourseParticipantSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CourseParticipant> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DirPerson in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PersonSingle DirPerson
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DirPerson == null))
                {
                    this._DirPerson = new global::Microsoft.Dynamics.DataEntities.PersonSingle(this.Context, GetPath("DirPerson"));
                }
                return this._DirPerson;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PersonSingle _DirPerson;
        /// <summary>
        /// There are no comments for CourseTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CourseTableSingle CourseTable
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseTable == null))
                {
                    this._CourseTable = new global::Microsoft.Dynamics.DataEntities.CourseTableSingle(this.Context, GetPath("CourseTable"));
                }
                return this._CourseTable;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CourseTableSingle _CourseTable;
        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
        /// <summary>
        /// There are no comments for CourseParticipant in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CourseId
    /// PersonId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CourseId", "PersonId")]
    [global::Microsoft.OData.Client.EntitySet("CourseParticipants")]
    public partial class CourseParticipant : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CourseParticipant object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="courseId">Initial value of CourseId.</param>
        /// <param name="personId">Initial value of PersonId.</param>
        /// <param name="registeredDate">Initial value of RegisteredDate.</param>
        /// <param name="dirPerson">Initial value of DirPerson.</param>
        /// <param name="courseTable">Initial value of CourseTable.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CourseParticipant CreateCourseParticipant(string dataAreaId, 
                    string courseId, 
                    string personId, 
                    global::System.DateTimeOffset registeredDate, 
                    global::Microsoft.Dynamics.DataEntities.Person dirPerson, 
                    global::Microsoft.Dynamics.DataEntities.CourseTable courseTable)
        {
            CourseParticipant courseParticipant = new CourseParticipant();
            courseParticipant.dataAreaId = dataAreaId;
            courseParticipant.CourseId = courseId;
            courseParticipant.PersonId = personId;
            courseParticipant.RegisteredDate = registeredDate;
            if ((dirPerson == null))
            {
                throw new global::System.ArgumentNullException("dirPerson");
            }
            courseParticipant.DirPerson = dirPerson;
            if ((courseTable == null))
            {
                throw new global::System.ArgumentNullException("courseTable");
            }
            courseParticipant.CourseTable = courseTable;
            return courseParticipant;
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
        /// There are no comments for Property CourseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CourseId
        {
            get
            {
                return this._CourseId;
            }
            set
            {
                this.OnCourseIdChanging(value);
                this._CourseId = value;
                this.OnCourseIdChanged();
                this.OnPropertyChanged("CourseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CourseId;
        partial void OnCourseIdChanging(string value);
        partial void OnCourseIdChanged();
        /// <summary>
        /// There are no comments for Property PersonId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonId
        {
            get
            {
                return this._PersonId;
            }
            set
            {
                this.OnPersonIdChanging(value);
                this._PersonId = value;
                this.OnPersonIdChanged();
                this.OnPropertyChanged("PersonId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonId;
        partial void OnPersonIdChanging(string value);
        partial void OnPersonIdChanged();
        /// <summary>
        /// There are no comments for Property RegisteredDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset RegisteredDate
        {
            get
            {
                return this._RegisteredDate;
            }
            set
            {
                this.OnRegisteredDateChanging(value);
                this._RegisteredDate = value;
                this.OnRegisteredDateChanged();
                this.OnPropertyChanged("RegisteredDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _RegisteredDate;
        partial void OnRegisteredDateChanging(global::System.DateTimeOffset value);
        partial void OnRegisteredDateChanged();
        /// <summary>
        /// There are no comments for Property PreCancelStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCourseAttendeeStatus> PreCancelStatus
        {
            get
            {
                return this._PreCancelStatus;
            }
            set
            {
                this.OnPreCancelStatusChanging(value);
                this._PreCancelStatus = value;
                this.OnPreCancelStatusChanged();
                this.OnPropertyChanged("PreCancelStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCourseAttendeeStatus> _PreCancelStatus;
        partial void OnPreCancelStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCourseAttendeeStatus> value);
        partial void OnPreCancelStatusChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCourseAttendeeStatus> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCourseAttendeeStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCourseAttendeeStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property DimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionDisplayValue
        {
            get
            {
                return this._DimensionDisplayValue;
            }
            set
            {
                this.OnDimensionDisplayValueChanging(value);
                this._DimensionDisplayValue = value;
                this.OnDimensionDisplayValueChanged();
                this.OnPropertyChanged("DimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionDisplayValue;
        partial void OnDimensionDisplayValueChanging(string value);
        partial void OnDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property WorkflowContext in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmWorkflowOperation> WorkflowContext
        {
            get
            {
                return this._WorkflowContext;
            }
            set
            {
                this.OnWorkflowContextChanging(value);
                this._WorkflowContext = value;
                this.OnWorkflowContextChanged();
                this.OnPropertyChanged("WorkflowContext");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmWorkflowOperation> _WorkflowContext;
        partial void OnWorkflowContextChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmWorkflowOperation> value);
        partial void OnWorkflowContextChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmApprovalStatus> ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmApprovalStatus> _ApprovalStatus;
        partial void OnApprovalStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmApprovalStatus> value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property DirPerson in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Person DirPerson
        {
            get
            {
                return this._DirPerson;
            }
            set
            {
                this.OnDirPersonChanging(value);
                this._DirPerson = value;
                this.OnDirPersonChanged();
                this.OnPropertyChanged("DirPerson");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Person _DirPerson;
        partial void OnDirPersonChanging(global::Microsoft.Dynamics.DataEntities.Person value);
        partial void OnDirPersonChanged();
        /// <summary>
        /// There are no comments for Property CourseTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CourseTable CourseTable
        {
            get
            {
                return this._CourseTable;
            }
            set
            {
                this.OnCourseTableChanging(value);
                this._CourseTable = value;
                this.OnCourseTableChanged();
                this.OnPropertyChanged("CourseTable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CourseTable _CourseTable;
        partial void OnCourseTableChanging(global::Microsoft.Dynamics.DataEntities.CourseTable value);
        partial void OnCourseTableChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
