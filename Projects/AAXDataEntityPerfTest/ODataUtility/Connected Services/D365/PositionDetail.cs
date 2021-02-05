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
        /// There are no comments for PositionDetailSingle in the schema.
        /// </summary>
    public partial class PositionDetailSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PositionDetail>
    {
        /// <summary>
        /// Initialize a new PositionDetailSingle object.
        /// </summary>
        public PositionDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PositionDetailSingle object.
        /// </summary>
        public PositionDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PositionDetailSingle object.
        /// </summary>
        public PositionDetailSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PositionDetail> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Title in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TitleSingle Title
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Title == null))
                {
                    this._Title = new global::Microsoft.Dynamics.DataEntities.TitleSingle(this.Context, GetPath("Title"));
                }
                return this._Title;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TitleSingle _Title;
        /// <summary>
        /// There are no comments for CompensationRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationRegionSingle CompensationRegion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationRegion == null))
                {
                    this._CompensationRegion = new global::Microsoft.Dynamics.DataEntities.CompensationRegionSingle(this.Context, GetPath("CompensationRegion"));
                }
                return this._CompensationRegion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationRegionSingle _CompensationRegion;
        /// <summary>
        /// There are no comments for Position in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2Single Position
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Position == null))
                {
                    this._Position = new global::Microsoft.Dynamics.DataEntities.PositionV2Single(this.Context, GetPath("Position"));
                }
                return this._Position;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2Single _Position;
        /// <summary>
        /// There are no comments for Job in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobSingle Job
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Job == null))
                {
                    this._Job = new global::Microsoft.Dynamics.DataEntities.JobSingle(this.Context, GetPath("Job"));
                }
                return this._Job;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobSingle _Job;
        /// <summary>
        /// There are no comments for Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DepartmentSingle Department
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Department == null))
                {
                    this._Department = new global::Microsoft.Dynamics.DataEntities.DepartmentSingle(this.Context, GetPath("Department"));
                }
                return this._Department;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DepartmentSingle _Department;
        /// <summary>
        /// There are no comments for PositionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionTypeSingle PositionType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PositionType == null))
                {
                    this._PositionType = new global::Microsoft.Dynamics.DataEntities.PositionTypeSingle(this.Context, GetPath("PositionType"));
                }
                return this._PositionType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionTypeSingle _PositionType;
    }
        /// <summary>
        /// There are no comments for PositionDetail in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PositionId
    /// ValidFrom
    /// ValidTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PositionId", "ValidFrom", "ValidTo")]
    [global::Microsoft.OData.Client.EntitySet("PositionDetails")]
    public partial class PositionDetail : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PositionDetail object.
        /// </summary>
        /// <param name="positionId">Initial value of PositionId.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="availableForAssignment">Initial value of AvailableForAssignment.</param>
        /// <param name="fullTimeEquivalent">Initial value of FullTimeEquivalent.</param>
        /// <param name="position">Initial value of Position.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PositionDetail CreatePositionDetail(string positionId, 
                    global::System.DateTimeOffset validFrom, 
                    global::System.DateTimeOffset validTo, 
                    global::System.DateTimeOffset availableForAssignment, 
                    decimal fullTimeEquivalent, 
                    global::Microsoft.Dynamics.DataEntities.PositionV2 position)
        {
            PositionDetail positionDetail = new PositionDetail();
            positionDetail.PositionId = positionId;
            positionDetail.ValidFrom = validFrom;
            positionDetail.ValidTo = validTo;
            positionDetail.AvailableForAssignment = availableForAssignment;
            positionDetail.FullTimeEquivalent = fullTimeEquivalent;
            if ((position == null))
            {
                throw new global::System.ArgumentNullException("position");
            }
            positionDetail.Position = position;
            return positionDetail;
        }
        /// <summary>
        /// There are no comments for Property PositionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PositionId
        {
            get
            {
                return this._PositionId;
            }
            set
            {
                this.OnPositionIdChanging(value);
                this._PositionId = value;
                this.OnPositionIdChanged();
                this.OnPropertyChanged("PositionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PositionId;
        partial void OnPositionIdChanging(string value);
        partial void OnPositionIdChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property PositionTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PositionTypeId
        {
            get
            {
                return this._PositionTypeId;
            }
            set
            {
                this.OnPositionTypeIdChanging(value);
                this._PositionTypeId = value;
                this.OnPositionTypeIdChanged();
                this.OnPropertyChanged("PositionTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PositionTypeId;
        partial void OnPositionTypeIdChanging(string value);
        partial void OnPositionTypeIdChanged();
        /// <summary>
        /// There are no comments for Property TitleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TitleId
        {
            get
            {
                return this._TitleId;
            }
            set
            {
                this.OnTitleIdChanging(value);
                this._TitleId = value;
                this.OnTitleIdChanged();
                this.OnPropertyChanged("TitleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TitleId;
        partial void OnTitleIdChanging(string value);
        partial void OnTitleIdChanged();
        /// <summary>
        /// There are no comments for Property AvailableForAssignment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset AvailableForAssignment
        {
            get
            {
                return this._AvailableForAssignment;
            }
            set
            {
                this.OnAvailableForAssignmentChanging(value);
                this._AvailableForAssignment = value;
                this.OnAvailableForAssignmentChanged();
                this.OnPropertyChanged("AvailableForAssignment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AvailableForAssignment;
        partial void OnAvailableForAssignmentChanging(global::System.DateTimeOffset value);
        partial void OnAvailableForAssignmentChanged();
        /// <summary>
        /// There are no comments for Property JobId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobId
        {
            get
            {
                return this._JobId;
            }
            set
            {
                this.OnJobIdChanging(value);
                this._JobId = value;
                this.OnJobIdChanged();
                this.OnPropertyChanged("JobId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobId;
        partial void OnJobIdChanging(string value);
        partial void OnJobIdChanged();
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
        /// There are no comments for Property DepartmentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DepartmentNumber
        {
            get
            {
                return this._DepartmentNumber;
            }
            set
            {
                this.OnDepartmentNumberChanging(value);
                this._DepartmentNumber = value;
                this.OnDepartmentNumberChanged();
                this.OnPropertyChanged("DepartmentNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepartmentNumber;
        partial void OnDepartmentNumberChanging(string value);
        partial void OnDepartmentNumberChanged();
        /// <summary>
        /// There are no comments for Property FullTimeEquivalent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal FullTimeEquivalent
        {
            get
            {
                return this._FullTimeEquivalent;
            }
            set
            {
                this.OnFullTimeEquivalentChanging(value);
                this._FullTimeEquivalent = value;
                this.OnFullTimeEquivalentChanged();
                this.OnPropertyChanged("FullTimeEquivalent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FullTimeEquivalent;
        partial void OnFullTimeEquivalentChanging(decimal value);
        partial void OnFullTimeEquivalentChanged();
        /// <summary>
        /// There are no comments for Property CompensationRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CompensationRegionId
        {
            get
            {
                return this._CompensationRegionId;
            }
            set
            {
                this.OnCompensationRegionIdChanging(value);
                this._CompensationRegionId = value;
                this.OnCompensationRegionIdChanged();
                this.OnPropertyChanged("CompensationRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CompensationRegionId;
        partial void OnCompensationRegionIdChanging(string value);
        partial void OnCompensationRegionIdChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Title Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Title _Title;
        partial void OnTitleChanging(global::Microsoft.Dynamics.DataEntities.Title value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property CompensationRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationRegion CompensationRegion
        {
            get
            {
                return this._CompensationRegion;
            }
            set
            {
                this.OnCompensationRegionChanging(value);
                this._CompensationRegion = value;
                this.OnCompensationRegionChanged();
                this.OnPropertyChanged("CompensationRegion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationRegion _CompensationRegion;
        partial void OnCompensationRegionChanging(global::Microsoft.Dynamics.DataEntities.CompensationRegion value);
        partial void OnCompensationRegionChanged();
        /// <summary>
        /// There are no comments for Property Position in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2 Position
        {
            get
            {
                return this._Position;
            }
            set
            {
                this.OnPositionChanging(value);
                this._Position = value;
                this.OnPositionChanged();
                this.OnPropertyChanged("Position");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2 _Position;
        partial void OnPositionChanging(global::Microsoft.Dynamics.DataEntities.PositionV2 value);
        partial void OnPositionChanged();
        /// <summary>
        /// There are no comments for Property Job in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Job Job
        {
            get
            {
                return this._Job;
            }
            set
            {
                this.OnJobChanging(value);
                this._Job = value;
                this.OnJobChanged();
                this.OnPropertyChanged("Job");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Job _Job;
        partial void OnJobChanging(global::Microsoft.Dynamics.DataEntities.Job value);
        partial void OnJobChanged();
        /// <summary>
        /// There are no comments for Property Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Department Department
        {
            get
            {
                return this._Department;
            }
            set
            {
                this.OnDepartmentChanging(value);
                this._Department = value;
                this.OnDepartmentChanged();
                this.OnPropertyChanged("Department");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Department _Department;
        partial void OnDepartmentChanging(global::Microsoft.Dynamics.DataEntities.Department value);
        partial void OnDepartmentChanged();
        /// <summary>
        /// There are no comments for Property PositionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionType PositionType
        {
            get
            {
                return this._PositionType;
            }
            set
            {
                this.OnPositionTypeChanging(value);
                this._PositionType = value;
                this.OnPositionTypeChanged();
                this.OnPropertyChanged("PositionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionType _PositionType;
        partial void OnPositionTypeChanging(global::Microsoft.Dynamics.DataEntities.PositionType value);
        partial void OnPositionTypeChanged();
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
