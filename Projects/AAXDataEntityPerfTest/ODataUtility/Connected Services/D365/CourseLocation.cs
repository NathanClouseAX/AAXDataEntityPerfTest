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
        /// There are no comments for CourseLocationSingle in the schema.
        /// </summary>
    public partial class CourseLocationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CourseLocation>
    {
        /// <summary>
        /// Initialize a new CourseLocationSingle object.
        /// </summary>
        public CourseLocationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CourseLocationSingle object.
        /// </summary>
        public CourseLocationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CourseLocationSingle object.
        /// </summary>
        public CourseLocationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CourseLocation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CourseRooms in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseRoom> CourseRooms
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseRooms == null))
                {
                    this._CourseRooms = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CourseRoom>(GetPath("CourseRooms"));
                }
                return this._CourseRooms;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseRoom> _CourseRooms;
        /// <summary>
        /// There are no comments for CourseHotel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseHotel> CourseHotel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseHotel == null))
                {
                    this._CourseHotel = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CourseHotel>(GetPath("CourseHotel"));
                }
                return this._CourseHotel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseHotel> _CourseHotel;
        /// <summary>
        /// There are no comments for CourseInstructors in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseInstructor> CourseInstructors
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseInstructors == null))
                {
                    this._CourseInstructors = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CourseInstructor>(GetPath("CourseInstructors"));
                }
                return this._CourseInstructors;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseInstructor> _CourseInstructors;
    }
        /// <summary>
        /// There are no comments for CourseLocation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CourseLocation
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CourseLocation")]
    [global::Microsoft.OData.Client.EntitySet("CourseLocations")]
    public partial class CourseLocation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CourseLocation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="courseLocation1">Initial value of CourseLocation1.</param>
        /// <param name="addressValidTo">Initial value of AddressValidTo.</param>
        /// <param name="addressValidFrom">Initial value of AddressValidFrom.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CourseLocation CreateCourseLocation(string dataAreaId, string courseLocation1, global::System.DateTimeOffset addressValidTo, global::System.DateTimeOffset addressValidFrom)
        {
            CourseLocation courseLocation = new CourseLocation();
            courseLocation.dataAreaId = dataAreaId;
            courseLocation.CourseLocation1 = courseLocation1;
            courseLocation.AddressValidTo = addressValidTo;
            courseLocation.AddressValidFrom = addressValidFrom;
            return courseLocation;
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
        /// There are no comments for Property CourseLocation1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CourseLocation")]
        public virtual string CourseLocation1
        {
            get
            {
                return this._CourseLocation1;
            }
            set
            {
                this.OnCourseLocation1Changing(value);
                this._CourseLocation1 = value;
                this.OnCourseLocation1Changed();
                this.OnPropertyChanged("CourseLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CourseLocation1;
        partial void OnCourseLocation1Changing(string value);
        partial void OnCourseLocation1Changed();
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
        /// There are no comments for Property Extension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Extension
        {
            get
            {
                return this._Extension;
            }
            set
            {
                this.OnExtensionChanging(value);
                this._Extension = value;
                this.OnExtensionChanged();
                this.OnPropertyChanged("Extension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Extension;
        partial void OnExtensionChanging(string value);
        partial void OnExtensionChanged();
        /// <summary>
        /// There are no comments for Property AddressCountryRegionISOCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressCountryRegionISOCode
        {
            get
            {
                return this._AddressCountryRegionISOCode;
            }
            set
            {
                this.OnAddressCountryRegionISOCodeChanging(value);
                this._AddressCountryRegionISOCode = value;
                this.OnAddressCountryRegionISOCodeChanged();
                this.OnPropertyChanged("AddressCountryRegionISOCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressCountryRegionISOCode;
        partial void OnAddressCountryRegionISOCodeChanging(string value);
        partial void OnAddressCountryRegionISOCodeChanged();
        /// <summary>
        /// There are no comments for Property AddressDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressDescription
        {
            get
            {
                return this._AddressDescription;
            }
            set
            {
                this.OnAddressDescriptionChanging(value);
                this._AddressDescription = value;
                this.OnAddressDescriptionChanged();
                this.OnPropertyChanged("AddressDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressDescription;
        partial void OnAddressDescriptionChanging(string value);
        partial void OnAddressDescriptionChanged();
        /// <summary>
        /// There are no comments for Property TelexNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TelexNumber
        {
            get
            {
                return this._TelexNumber;
            }
            set
            {
                this.OnTelexNumberChanging(value);
                this._TelexNumber = value;
                this.OnTelexNumberChanged();
                this.OnPropertyChanged("TelexNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TelexNumber;
        partial void OnTelexNumberChanging(string value);
        partial void OnTelexNumberChanged();
        /// <summary>
        /// There are no comments for Property AddressCity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressCity
        {
            get
            {
                return this._AddressCity;
            }
            set
            {
                this.OnAddressCityChanging(value);
                this._AddressCity = value;
                this.OnAddressCityChanged();
                this.OnPropertyChanged("AddressCity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressCity;
        partial void OnAddressCityChanging(string value);
        partial void OnAddressCityChanged();
        /// <summary>
        /// There are no comments for Property AddressValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset AddressValidTo
        {
            get
            {
                return this._AddressValidTo;
            }
            set
            {
                this.OnAddressValidToChanging(value);
                this._AddressValidTo = value;
                this.OnAddressValidToChanged();
                this.OnPropertyChanged("AddressValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AddressValidTo;
        partial void OnAddressValidToChanging(global::System.DateTimeOffset value);
        partial void OnAddressValidToChanged();
        /// <summary>
        /// There are no comments for Property AddressLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressLocationId
        {
            get
            {
                return this._AddressLocationId;
            }
            set
            {
                this.OnAddressLocationIdChanging(value);
                this._AddressLocationId = value;
                this.OnAddressLocationIdChanged();
                this.OnPropertyChanged("AddressLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressLocationId;
        partial void OnAddressLocationIdChanging(string value);
        partial void OnAddressLocationIdChanged();
        /// <summary>
        /// There are no comments for Property AddressCounty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressCounty
        {
            get
            {
                return this._AddressCounty;
            }
            set
            {
                this.OnAddressCountyChanging(value);
                this._AddressCounty = value;
                this.OnAddressCountyChanged();
                this.OnPropertyChanged("AddressCounty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressCounty;
        partial void OnAddressCountyChanging(string value);
        partial void OnAddressCountyChanged();
        /// <summary>
        /// There are no comments for Property Email in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this.OnEmailChanging(value);
                this._Email = value;
                this.OnEmailChanged();
                this.OnPropertyChanged("Email");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Email;
        partial void OnEmailChanging(string value);
        partial void OnEmailChanged();
        /// <summary>
        /// There are no comments for Property Fax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Fax
        {
            get
            {
                return this._Fax;
            }
            set
            {
                this.OnFaxChanging(value);
                this._Fax = value;
                this.OnFaxChanged();
                this.OnPropertyChanged("Fax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Fax;
        partial void OnFaxChanging(string value);
        partial void OnFaxChanged();
        /// <summary>
        /// There are no comments for Property AddressZipCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressZipCode
        {
            get
            {
                return this._AddressZipCode;
            }
            set
            {
                this.OnAddressZipCodeChanging(value);
                this._AddressZipCode = value;
                this.OnAddressZipCodeChanged();
                this.OnPropertyChanged("AddressZipCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressZipCode;
        partial void OnAddressZipCodeChanging(string value);
        partial void OnAddressZipCodeChanged();
        /// <summary>
        /// There are no comments for Property AddressStreet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressStreet
        {
            get
            {
                return this._AddressStreet;
            }
            set
            {
                this.OnAddressStreetChanging(value);
                this._AddressStreet = value;
                this.OnAddressStreetChanged();
                this.OnPropertyChanged("AddressStreet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressStreet;
        partial void OnAddressStreetChanging(string value);
        partial void OnAddressStreetChanged();
        /// <summary>
        /// There are no comments for Property AddressCountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressCountryRegionId
        {
            get
            {
                return this._AddressCountryRegionId;
            }
            set
            {
                this.OnAddressCountryRegionIdChanging(value);
                this._AddressCountryRegionId = value;
                this.OnAddressCountryRegionIdChanged();
                this.OnPropertyChanged("AddressCountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressCountryRegionId;
        partial void OnAddressCountryRegionIdChanging(string value);
        partial void OnAddressCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property InternetAddress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InternetAddress
        {
            get
            {
                return this._InternetAddress;
            }
            set
            {
                this.OnInternetAddressChanging(value);
                this._InternetAddress = value;
                this.OnInternetAddressChanged();
                this.OnPropertyChanged("InternetAddress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InternetAddress;
        partial void OnInternetAddressChanging(string value);
        partial void OnInternetAddressChanged();
        /// <summary>
        /// There are no comments for Property MobilePhone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MobilePhone
        {
            get
            {
                return this._MobilePhone;
            }
            set
            {
                this.OnMobilePhoneChanging(value);
                this._MobilePhone = value;
                this.OnMobilePhoneChanged();
                this.OnPropertyChanged("MobilePhone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MobilePhone;
        partial void OnMobilePhoneChanging(string value);
        partial void OnMobilePhoneChanged();
        /// <summary>
        /// There are no comments for Property AddressState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressState
        {
            get
            {
                return this._AddressState;
            }
            set
            {
                this.OnAddressStateChanging(value);
                this._AddressState = value;
                this.OnAddressStateChanged();
                this.OnPropertyChanged("AddressState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressState;
        partial void OnAddressStateChanging(string value);
        partial void OnAddressStateChanged();
        /// <summary>
        /// There are no comments for Property Telephone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Telephone
        {
            get
            {
                return this._Telephone;
            }
            set
            {
                this.OnTelephoneChanging(value);
                this._Telephone = value;
                this.OnTelephoneChanged();
                this.OnPropertyChanged("Telephone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Telephone;
        partial void OnTelephoneChanging(string value);
        partial void OnTelephoneChanged();
        /// <summary>
        /// There are no comments for Property AddressValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset AddressValidFrom
        {
            get
            {
                return this._AddressValidFrom;
            }
            set
            {
                this.OnAddressValidFromChanging(value);
                this._AddressValidFrom = value;
                this.OnAddressValidFromChanged();
                this.OnPropertyChanged("AddressValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AddressValidFrom;
        partial void OnAddressValidFromChanging(global::System.DateTimeOffset value);
        partial void OnAddressValidFromChanged();
        /// <summary>
        /// There are no comments for Property VendorAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorAccount
        {
            get
            {
                return this._VendorAccount;
            }
            set
            {
                this.OnVendorAccountChanging(value);
                this._VendorAccount = value;
                this.OnVendorAccountChanged();
                this.OnPropertyChanged("VendorAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAccount;
        partial void OnVendorAccountChanging(string value);
        partial void OnVendorAccountChanged();
        /// <summary>
        /// There are no comments for Property CourseRooms in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseRoom> CourseRooms
        {
            get
            {
                return this._CourseRooms;
            }
            set
            {
                this.OnCourseRoomsChanging(value);
                this._CourseRooms = value;
                this.OnCourseRoomsChanged();
                this.OnPropertyChanged("CourseRooms");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseRoom> _CourseRooms = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseRoom>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCourseRoomsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseRoom> value);
        partial void OnCourseRoomsChanged();
        /// <summary>
        /// There are no comments for Property CourseHotel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseHotel> CourseHotel
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
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseHotel> _CourseHotel = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseHotel>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCourseHotelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseHotel> value);
        partial void OnCourseHotelChanged();
        /// <summary>
        /// There are no comments for Property CourseInstructors in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseInstructor> CourseInstructors
        {
            get
            {
                return this._CourseInstructors;
            }
            set
            {
                this.OnCourseInstructorsChanging(value);
                this._CourseInstructors = value;
                this.OnCourseInstructorsChanged();
                this.OnPropertyChanged("CourseInstructors");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseInstructor> _CourseInstructors = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseInstructor>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCourseInstructorsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseInstructor> value);
        partial void OnCourseInstructorsChanged();
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
