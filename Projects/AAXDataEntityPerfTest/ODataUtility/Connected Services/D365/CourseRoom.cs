﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/3/2021 8:21:45 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for CourseRoomSingle in the schema.
        /// </summary>
    public partial class CourseRoomSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CourseRoom>
    {
        /// <summary>
        /// Initialize a new CourseRoomSingle object.
        /// </summary>
        public CourseRoomSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CourseRoomSingle object.
        /// </summary>
        public CourseRoomSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CourseRoomSingle object.
        /// </summary>
        public CourseRoomSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CourseRoom> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Location in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CourseLocationSingle Location
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Location == null))
                {
                    this._Location = new global::Microsoft.Dynamics.DataEntities.CourseLocationSingle(this.Context, GetPath("Location"));
                }
                return this._Location;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CourseLocationSingle _Location;
        /// <summary>
        /// There are no comments for Group in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ClassroomGroupSingle Group
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Group == null))
                {
                    this._Group = new global::Microsoft.Dynamics.DataEntities.ClassroomGroupSingle(this.Context, GetPath("Group"));
                }
                return this._Group;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ClassroomGroupSingle _Group;
        /// <summary>
        /// There are no comments for CourseTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTable> CourseTable
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseTable == null))
                {
                    this._CourseTable = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CourseTable>(GetPath("CourseTable"));
                }
                return this._CourseTable;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseTable> _CourseTable;
    }
        /// <summary>
        /// There are no comments for CourseRoom in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// Classroom
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Classroom")]
    [global::Microsoft.OData.Client.EntitySet("CourseRooms")]
    public partial class CourseRoom : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CourseRoom object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="classroom">Initial value of Classroom.</param>
        /// <param name="maxAttendees">Initial value of MaxAttendees.</param>
        /// <param name="useIntensity">Initial value of UseIntensity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CourseRoom CreateCourseRoom(string dataAreaId, string classroom, int maxAttendees, int useIntensity)
        {
            CourseRoom courseRoom = new CourseRoom();
            courseRoom.dataAreaId = dataAreaId;
            courseRoom.Classroom = classroom;
            courseRoom.MaxAttendees = maxAttendees;
            courseRoom.UseIntensity = useIntensity;
            return courseRoom;
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
        /// There are no comments for Property Classroom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Classroom
        {
            get
            {
                return this._Classroom;
            }
            set
            {
                this.OnClassroomChanging(value);
                this._Classroom = value;
                this.OnClassroomChanged();
                this.OnPropertyChanged("Classroom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Classroom;
        partial void OnClassroomChanging(string value);
        partial void OnClassroomChanged();
        /// <summary>
        /// There are no comments for Property MaxAttendees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int MaxAttendees
        {
            get
            {
                return this._MaxAttendees;
            }
            set
            {
                this.OnMaxAttendeesChanging(value);
                this._MaxAttendees = value;
                this.OnMaxAttendeesChanged();
                this.OnPropertyChanged("MaxAttendees");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _MaxAttendees;
        partial void OnMaxAttendeesChanging(int value);
        partial void OnMaxAttendeesChanged();
        /// <summary>
        /// There are no comments for Property CourseLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CourseLocation
        {
            get
            {
                return this._CourseLocation;
            }
            set
            {
                this.OnCourseLocationChanging(value);
                this._CourseLocation = value;
                this.OnCourseLocationChanged();
                this.OnPropertyChanged("CourseLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CourseLocation;
        partial void OnCourseLocationChanging(string value);
        partial void OnCourseLocationChanged();
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
        /// There are no comments for Property UseIntensity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int UseIntensity
        {
            get
            {
                return this._UseIntensity;
            }
            set
            {
                this.OnUseIntensityChanging(value);
                this._UseIntensity = value;
                this.OnUseIntensityChanged();
                this.OnPropertyChanged("UseIntensity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _UseIntensity;
        partial void OnUseIntensityChanging(int value);
        partial void OnUseIntensityChanged();
        /// <summary>
        /// There are no comments for Property ClassroomGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ClassroomGroup
        {
            get
            {
                return this._ClassroomGroup;
            }
            set
            {
                this.OnClassroomGroupChanging(value);
                this._ClassroomGroup = value;
                this.OnClassroomGroupChanged();
                this.OnPropertyChanged("ClassroomGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ClassroomGroup;
        partial void OnClassroomGroupChanging(string value);
        partial void OnClassroomGroupChanged();
        /// <summary>
        /// There are no comments for Property Location in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CourseLocation Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                this.OnLocationChanging(value);
                this._Location = value;
                this.OnLocationChanged();
                this.OnPropertyChanged("Location");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CourseLocation _Location;
        partial void OnLocationChanging(global::Microsoft.Dynamics.DataEntities.CourseLocation value);
        partial void OnLocationChanged();
        /// <summary>
        /// There are no comments for Property Group in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ClassroomGroup Group
        {
            get
            {
                return this._Group;
            }
            set
            {
                this.OnGroupChanging(value);
                this._Group = value;
                this.OnGroupChanged();
                this.OnPropertyChanged("Group");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ClassroomGroup _Group;
        partial void OnGroupChanging(global::Microsoft.Dynamics.DataEntities.ClassroomGroup value);
        partial void OnGroupChanged();
        /// <summary>
        /// There are no comments for Property CourseTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTable> CourseTable
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
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTable> _CourseTable = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTable>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCourseTableChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseTable> value);
        partial void OnCourseTableChanged();
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
