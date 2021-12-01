﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/28/2021 8:55:09 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for CourseLocationHotelSingle in the schema.
    /// </summary>
    public partial class CourseLocationHotelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CourseLocationHotel>
    {
        /// <summary>
        /// Initialize a new CourseLocationHotelSingle object.
        /// </summary>
        public CourseLocationHotelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CourseLocationHotelSingle object.
        /// </summary>
        public CourseLocationHotelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CourseLocationHotelSingle object.
        /// </summary>
        public CourseLocationHotelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CourseLocationHotel> query)
            : base(query) {}

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
        /// There are no comments for CourseHotel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CourseHotelSingle CourseHotel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseHotel == null))
                {
                    this._CourseHotel = new global::Microsoft.Dynamics.DataEntities.CourseHotelSingle(this.Context, GetPath("CourseHotel"));
                }
                return this._CourseHotel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CourseHotelSingle _CourseHotel;
    }
    /// <summary>
    /// There are no comments for CourseLocationHotel in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CourseId
    /// CourseLocation
    /// Hotel
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CourseId", "CourseLocation", "Hotel")]
    [global::Microsoft.OData.Client.EntitySet("CourseLocationHotels")]
    public partial class CourseLocationHotel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CourseLocationHotel object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="courseId">Initial value of CourseId.</param>
        /// <param name="courseLocation">Initial value of CourseLocation.</param>
        /// <param name="hotel">Initial value of Hotel.</param>
        /// <param name="courseTable">Initial value of CourseTable.</param>
        /// <param name="courseHotel">Initial value of CourseHotel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CourseLocationHotel CreateCourseLocationHotel(string dataAreaId, 
                    string courseId, 
                    string courseLocation, 
                    string hotel, 
                    global::Microsoft.Dynamics.DataEntities.CourseTable courseTable, 
                    global::Microsoft.Dynamics.DataEntities.CourseHotel courseHotel)
        {
            CourseLocationHotel courseLocationHotel = new CourseLocationHotel();
            courseLocationHotel.dataAreaId = dataAreaId;
            courseLocationHotel.CourseId = courseId;
            courseLocationHotel.CourseLocation = courseLocation;
            courseLocationHotel.Hotel = hotel;
            if ((courseTable == null))
            {
                throw new global::System.ArgumentNullException("courseTable");
            }
            courseLocationHotel.CourseTable = courseTable;
            if ((courseHotel == null))
            {
                throw new global::System.ArgumentNullException("courseHotel");
            }
            courseLocationHotel.CourseHotel = courseHotel;
            return courseLocationHotel;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "dataAreaId is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CourseId is required.")]
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
        /// There are no comments for Property CourseLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CourseLocation is required.")]
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
        /// There are no comments for Property Hotel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Hotel is required.")]
        public virtual string Hotel
        {
            get
            {
                return this._Hotel;
            }
            set
            {
                this.OnHotelChanging(value);
                this._Hotel = value;
                this.OnHotelChanged();
                this.OnPropertyChanged("Hotel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Hotel;
        partial void OnHotelChanging(string value);
        partial void OnHotelChanged();
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
        /// There are no comments for Property CourseTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CourseTable is required.")]
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
        /// There are no comments for Property CourseHotel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CourseHotel is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.CourseHotel CourseHotel
        {
            get
            {
                return this._CourseHotel;
            }
            set
            {
                this.OnCourseHotelChanging(value);
                this._CourseHotel = value;
                this.OnCourseHotelChanged();
                this.OnPropertyChanged("CourseHotel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CourseHotel _CourseHotel;
        partial void OnCourseHotelChanging(global::Microsoft.Dynamics.DataEntities.CourseHotel value);
        partial void OnCourseHotelChanged();
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
