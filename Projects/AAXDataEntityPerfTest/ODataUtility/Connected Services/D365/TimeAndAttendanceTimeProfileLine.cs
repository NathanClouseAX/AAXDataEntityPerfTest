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
    /// There are no comments for TimeAndAttendanceTimeProfileLineSingle in the schema.
    /// </summary>
    public partial class TimeAndAttendanceTimeProfileLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TimeAndAttendanceTimeProfileLine>
    {
        /// <summary>
        /// Initialize a new TimeAndAttendanceTimeProfileLineSingle object.
        /// </summary>
        public TimeAndAttendanceTimeProfileLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TimeAndAttendanceTimeProfileLineSingle object.
        /// </summary>
        public TimeAndAttendanceTimeProfileLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TimeAndAttendanceTimeProfileLineSingle object.
        /// </summary>
        public TimeAndAttendanceTimeProfileLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TimeAndAttendanceTimeProfileLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TimeAndAttendanceTimeProfileDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TimeAndAttendanceTimeProfileDetailsSingle TimeAndAttendanceTimeProfileDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TimeAndAttendanceTimeProfileDetails == null))
                {
                    this._TimeAndAttendanceTimeProfileDetails = new global::Microsoft.Dynamics.DataEntities.TimeAndAttendanceTimeProfileDetailsSingle(this.Context, GetPath("TimeAndAttendanceTimeProfileDetails"));
                }
                return this._TimeAndAttendanceTimeProfileDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TimeAndAttendanceTimeProfileDetailsSingle _TimeAndAttendanceTimeProfileDetails;
        /// <summary>
        /// There are no comments for TimeAndAttendanceTimeProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TimeAndAttendanceTimeProfileSingle TimeAndAttendanceTimeProfile
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TimeAndAttendanceTimeProfile == null))
                {
                    this._TimeAndAttendanceTimeProfile = new global::Microsoft.Dynamics.DataEntities.TimeAndAttendanceTimeProfileSingle(this.Context, GetPath("TimeAndAttendanceTimeProfile"));
                }
                return this._TimeAndAttendanceTimeProfile;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TimeAndAttendanceTimeProfileSingle _TimeAndAttendanceTimeProfile;
    }
    /// <summary>
    /// There are no comments for TimeAndAttendanceTimeProfileLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RecordId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RecordId")]
    [global::Microsoft.OData.Client.EntitySet("TimeAndAttendanceTimeProfileLines")]
    public partial class TimeAndAttendanceTimeProfileLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TimeAndAttendanceTimeProfileLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="recordId">Initial value of RecordId.</param>
        /// <param name="toleranceBeforeEndMinutes">Initial value of ToleranceBeforeEndMinutes.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="toleranceAfterEndMinutes">Initial value of ToleranceAfterEndMinutes.</param>
        /// <param name="profileLineStartWeekDay">Initial value of ProfileLineStartWeekDay.</param>
        /// <param name="profileLineStartTimeSeconds">Initial value of ProfileLineStartTimeSeconds.</param>
        /// <param name="profileLineEndTimeSeconds">Initial value of ProfileLineEndTimeSeconds.</param>
        /// <param name="secondaryTimeProfileTypeId">Initial value of SecondaryTimeProfileTypeId.</param>
        /// <param name="primaryTimeProfileTypeId">Initial value of PrimaryTimeProfileTypeId.</param>
        /// <param name="toleranceBeforeStartMinutes">Initial value of ToleranceBeforeStartMinutes.</param>
        /// <param name="toleranceAfterStartMinutes">Initial value of ToleranceAfterStartMinutes.</param>
        /// <param name="profileLineEndWeekDay">Initial value of ProfileLineEndWeekDay.</param>
        /// <param name="timeAndAttendanceTimeProfileDetails">Initial value of TimeAndAttendanceTimeProfileDetails.</param>
        /// <param name="timeAndAttendanceTimeProfile">Initial value of TimeAndAttendanceTimeProfile.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TimeAndAttendanceTimeProfileLine CreateTimeAndAttendanceTimeProfileLine(string dataAreaId, 
                    long recordId, 
                    int toleranceBeforeEndMinutes, 
                    decimal lineNumber, 
                    int toleranceAfterEndMinutes, 
                    int profileLineStartWeekDay, 
                    int profileLineStartTimeSeconds, 
                    int profileLineEndTimeSeconds, 
                    long secondaryTimeProfileTypeId, 
                    long primaryTimeProfileTypeId, 
                    int toleranceBeforeStartMinutes, 
                    int toleranceAfterStartMinutes, 
                    int profileLineEndWeekDay, 
                    global::Microsoft.Dynamics.DataEntities.TimeAndAttendanceTimeProfileDetails timeAndAttendanceTimeProfileDetails, 
                    global::Microsoft.Dynamics.DataEntities.TimeAndAttendanceTimeProfile timeAndAttendanceTimeProfile)
        {
            TimeAndAttendanceTimeProfileLine timeAndAttendanceTimeProfileLine = new TimeAndAttendanceTimeProfileLine();
            timeAndAttendanceTimeProfileLine.dataAreaId = dataAreaId;
            timeAndAttendanceTimeProfileLine.RecordId = recordId;
            timeAndAttendanceTimeProfileLine.ToleranceBeforeEndMinutes = toleranceBeforeEndMinutes;
            timeAndAttendanceTimeProfileLine.LineNumber = lineNumber;
            timeAndAttendanceTimeProfileLine.ToleranceAfterEndMinutes = toleranceAfterEndMinutes;
            timeAndAttendanceTimeProfileLine.ProfileLineStartWeekDay = profileLineStartWeekDay;
            timeAndAttendanceTimeProfileLine.ProfileLineStartTimeSeconds = profileLineStartTimeSeconds;
            timeAndAttendanceTimeProfileLine.ProfileLineEndTimeSeconds = profileLineEndTimeSeconds;
            timeAndAttendanceTimeProfileLine.SecondaryTimeProfileTypeId = secondaryTimeProfileTypeId;
            timeAndAttendanceTimeProfileLine.PrimaryTimeProfileTypeId = primaryTimeProfileTypeId;
            timeAndAttendanceTimeProfileLine.ToleranceBeforeStartMinutes = toleranceBeforeStartMinutes;
            timeAndAttendanceTimeProfileLine.ToleranceAfterStartMinutes = toleranceAfterStartMinutes;
            timeAndAttendanceTimeProfileLine.ProfileLineEndWeekDay = profileLineEndWeekDay;
            if ((timeAndAttendanceTimeProfileDetails == null))
            {
                throw new global::System.ArgumentNullException("timeAndAttendanceTimeProfileDetails");
            }
            timeAndAttendanceTimeProfileLine.TimeAndAttendanceTimeProfileDetails = timeAndAttendanceTimeProfileDetails;
            if ((timeAndAttendanceTimeProfile == null))
            {
                throw new global::System.ArgumentNullException("timeAndAttendanceTimeProfile");
            }
            timeAndAttendanceTimeProfileLine.TimeAndAttendanceTimeProfile = timeAndAttendanceTimeProfile;
            return timeAndAttendanceTimeProfileLine;
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
        /// There are no comments for Property RecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecordId is required.")]
        public virtual long RecordId
        {
            get
            {
                return this._RecordId;
            }
            set
            {
                this.OnRecordIdChanging(value);
                this._RecordId = value;
                this.OnRecordIdChanged();
                this.OnPropertyChanged("RecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _RecordId;
        partial void OnRecordIdChanging(long value);
        partial void OnRecordIdChanged();
        /// <summary>
        /// There are no comments for Property TimeAndAttendanceSwitchCodeActivityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TimeAndAttendanceSwitchCodeActivityId
        {
            get
            {
                return this._TimeAndAttendanceSwitchCodeActivityId;
            }
            set
            {
                this.OnTimeAndAttendanceSwitchCodeActivityIdChanging(value);
                this._TimeAndAttendanceSwitchCodeActivityId = value;
                this.OnTimeAndAttendanceSwitchCodeActivityIdChanged();
                this.OnPropertyChanged("TimeAndAttendanceSwitchCodeActivityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TimeAndAttendanceSwitchCodeActivityId;
        partial void OnTimeAndAttendanceSwitchCodeActivityIdChanging(string value);
        partial void OnTimeAndAttendanceSwitchCodeActivityIdChanged();
        /// <summary>
        /// There are no comments for Property ToleranceBeforeEndMinutes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ToleranceBeforeEndMinutes is required.")]
        public virtual int ToleranceBeforeEndMinutes
        {
            get
            {
                return this._ToleranceBeforeEndMinutes;
            }
            set
            {
                this.OnToleranceBeforeEndMinutesChanging(value);
                this._ToleranceBeforeEndMinutes = value;
                this.OnToleranceBeforeEndMinutesChanged();
                this.OnPropertyChanged("ToleranceBeforeEndMinutes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ToleranceBeforeEndMinutes;
        partial void OnToleranceBeforeEndMinutesChanging(int value);
        partial void OnToleranceBeforeEndMinutesChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNumber is required.")]
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
        /// There are no comments for Property ToleranceAfterEndMinutes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ToleranceAfterEndMinutes is required.")]
        public virtual int ToleranceAfterEndMinutes
        {
            get
            {
                return this._ToleranceAfterEndMinutes;
            }
            set
            {
                this.OnToleranceAfterEndMinutesChanging(value);
                this._ToleranceAfterEndMinutes = value;
                this.OnToleranceAfterEndMinutesChanged();
                this.OnPropertyChanged("ToleranceAfterEndMinutes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ToleranceAfterEndMinutes;
        partial void OnToleranceAfterEndMinutesChanging(int value);
        partial void OnToleranceAfterEndMinutesChanged();
        /// <summary>
        /// There are no comments for Property ProfileLineStartWeekDay in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProfileLineStartWeekDay is required.")]
        public virtual int ProfileLineStartWeekDay
        {
            get
            {
                return this._ProfileLineStartWeekDay;
            }
            set
            {
                this.OnProfileLineStartWeekDayChanging(value);
                this._ProfileLineStartWeekDay = value;
                this.OnProfileLineStartWeekDayChanged();
                this.OnPropertyChanged("ProfileLineStartWeekDay");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ProfileLineStartWeekDay;
        partial void OnProfileLineStartWeekDayChanging(int value);
        partial void OnProfileLineStartWeekDayChanged();
        /// <summary>
        /// There are no comments for Property TimeProfileId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TimeProfileId
        {
            get
            {
                return this._TimeProfileId;
            }
            set
            {
                this.OnTimeProfileIdChanging(value);
                this._TimeProfileId = value;
                this.OnTimeProfileIdChanged();
                this.OnPropertyChanged("TimeProfileId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TimeProfileId;
        partial void OnTimeProfileIdChanging(string value);
        partial void OnTimeProfileIdChanged();
        /// <summary>
        /// There are no comments for Property ProfileLineStartTimeSeconds in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProfileLineStartTimeSeconds is required.")]
        public virtual int ProfileLineStartTimeSeconds
        {
            get
            {
                return this._ProfileLineStartTimeSeconds;
            }
            set
            {
                this.OnProfileLineStartTimeSecondsChanging(value);
                this._ProfileLineStartTimeSeconds = value;
                this.OnProfileLineStartTimeSecondsChanged();
                this.OnPropertyChanged("ProfileLineStartTimeSeconds");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ProfileLineStartTimeSeconds;
        partial void OnProfileLineStartTimeSecondsChanging(int value);
        partial void OnProfileLineStartTimeSecondsChanged();
        /// <summary>
        /// There are no comments for Property ProfileLineEndTimeSeconds in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProfileLineEndTimeSeconds is required.")]
        public virtual int ProfileLineEndTimeSeconds
        {
            get
            {
                return this._ProfileLineEndTimeSeconds;
            }
            set
            {
                this.OnProfileLineEndTimeSecondsChanging(value);
                this._ProfileLineEndTimeSeconds = value;
                this.OnProfileLineEndTimeSecondsChanged();
                this.OnPropertyChanged("ProfileLineEndTimeSeconds");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ProfileLineEndTimeSeconds;
        partial void OnProfileLineEndTimeSecondsChanging(int value);
        partial void OnProfileLineEndTimeSecondsChanged();
        /// <summary>
        /// There are no comments for Property SecondaryTimeProfileTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SecondaryTimeProfileTypeId is required.")]
        public virtual long SecondaryTimeProfileTypeId
        {
            get
            {
                return this._SecondaryTimeProfileTypeId;
            }
            set
            {
                this.OnSecondaryTimeProfileTypeIdChanging(value);
                this._SecondaryTimeProfileTypeId = value;
                this.OnSecondaryTimeProfileTypeIdChanged();
                this.OnPropertyChanged("SecondaryTimeProfileTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _SecondaryTimeProfileTypeId;
        partial void OnSecondaryTimeProfileTypeIdChanging(long value);
        partial void OnSecondaryTimeProfileTypeIdChanged();
        /// <summary>
        /// There are no comments for Property PrimaryTimeProfileTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PrimaryTimeProfileTypeId is required.")]
        public virtual long PrimaryTimeProfileTypeId
        {
            get
            {
                return this._PrimaryTimeProfileTypeId;
            }
            set
            {
                this.OnPrimaryTimeProfileTypeIdChanging(value);
                this._PrimaryTimeProfileTypeId = value;
                this.OnPrimaryTimeProfileTypeIdChanged();
                this.OnPropertyChanged("PrimaryTimeProfileTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _PrimaryTimeProfileTypeId;
        partial void OnPrimaryTimeProfileTypeIdChanging(long value);
        partial void OnPrimaryTimeProfileTypeIdChanged();
        /// <summary>
        /// There are no comments for Property ToleranceBeforeStartMinutes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ToleranceBeforeStartMinutes is required.")]
        public virtual int ToleranceBeforeStartMinutes
        {
            get
            {
                return this._ToleranceBeforeStartMinutes;
            }
            set
            {
                this.OnToleranceBeforeStartMinutesChanging(value);
                this._ToleranceBeforeStartMinutes = value;
                this.OnToleranceBeforeStartMinutesChanged();
                this.OnPropertyChanged("ToleranceBeforeStartMinutes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ToleranceBeforeStartMinutes;
        partial void OnToleranceBeforeStartMinutesChanging(int value);
        partial void OnToleranceBeforeStartMinutesChanged();
        /// <summary>
        /// There are no comments for Property ToleranceAfterStartMinutes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ToleranceAfterStartMinutes is required.")]
        public virtual int ToleranceAfterStartMinutes
        {
            get
            {
                return this._ToleranceAfterStartMinutes;
            }
            set
            {
                this.OnToleranceAfterStartMinutesChanging(value);
                this._ToleranceAfterStartMinutes = value;
                this.OnToleranceAfterStartMinutesChanged();
                this.OnPropertyChanged("ToleranceAfterStartMinutes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ToleranceAfterStartMinutes;
        partial void OnToleranceAfterStartMinutesChanging(int value);
        partial void OnToleranceAfterStartMinutesChanged();
        /// <summary>
        /// There are no comments for Property TimeProfileWeekDay in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JmgDayIdEnum> TimeProfileWeekDay
        {
            get
            {
                return this._TimeProfileWeekDay;
            }
            set
            {
                this.OnTimeProfileWeekDayChanging(value);
                this._TimeProfileWeekDay = value;
                this.OnTimeProfileWeekDayChanged();
                this.OnPropertyChanged("TimeProfileWeekDay");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JmgDayIdEnum> _TimeProfileWeekDay;
        partial void OnTimeProfileWeekDayChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JmgDayIdEnum> value);
        partial void OnTimeProfileWeekDayChanged();
        /// <summary>
        /// There are no comments for Property ProfileLineEndWeekDay in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProfileLineEndWeekDay is required.")]
        public virtual int ProfileLineEndWeekDay
        {
            get
            {
                return this._ProfileLineEndWeekDay;
            }
            set
            {
                this.OnProfileLineEndWeekDayChanging(value);
                this._ProfileLineEndWeekDay = value;
                this.OnProfileLineEndWeekDayChanged();
                this.OnPropertyChanged("ProfileLineEndWeekDay");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ProfileLineEndWeekDay;
        partial void OnProfileLineEndWeekDayChanging(int value);
        partial void OnProfileLineEndWeekDayChanged();
        /// <summary>
        /// There are no comments for Property TimeAndAttendanceTimeProfileDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TimeAndAttendanceTimeProfileDetails is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.TimeAndAttendanceTimeProfileDetails TimeAndAttendanceTimeProfileDetails
        {
            get
            {
                return this._TimeAndAttendanceTimeProfileDetails;
            }
            set
            {
                this.OnTimeAndAttendanceTimeProfileDetailsChanging(value);
                this._TimeAndAttendanceTimeProfileDetails = value;
                this.OnTimeAndAttendanceTimeProfileDetailsChanged();
                this.OnPropertyChanged("TimeAndAttendanceTimeProfileDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TimeAndAttendanceTimeProfileDetails _TimeAndAttendanceTimeProfileDetails;
        partial void OnTimeAndAttendanceTimeProfileDetailsChanging(global::Microsoft.Dynamics.DataEntities.TimeAndAttendanceTimeProfileDetails value);
        partial void OnTimeAndAttendanceTimeProfileDetailsChanged();
        /// <summary>
        /// There are no comments for Property TimeAndAttendanceTimeProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TimeAndAttendanceTimeProfile is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.TimeAndAttendanceTimeProfile TimeAndAttendanceTimeProfile
        {
            get
            {
                return this._TimeAndAttendanceTimeProfile;
            }
            set
            {
                this.OnTimeAndAttendanceTimeProfileChanging(value);
                this._TimeAndAttendanceTimeProfile = value;
                this.OnTimeAndAttendanceTimeProfileChanged();
                this.OnPropertyChanged("TimeAndAttendanceTimeProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TimeAndAttendanceTimeProfile _TimeAndAttendanceTimeProfile;
        partial void OnTimeAndAttendanceTimeProfileChanging(global::Microsoft.Dynamics.DataEntities.TimeAndAttendanceTimeProfile value);
        partial void OnTimeAndAttendanceTimeProfileChanged();
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
