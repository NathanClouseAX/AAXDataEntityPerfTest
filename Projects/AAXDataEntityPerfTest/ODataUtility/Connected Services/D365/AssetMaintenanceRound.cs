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
        /// There are no comments for AssetMaintenanceRoundSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceRoundSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceRound>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceRoundSingle object.
        /// </summary>
        public AssetMaintenanceRoundSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceRoundSingle object.
        /// </summary>
        public AssetMaintenanceRoundSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceRoundSingle object.
        /// </summary>
        public AssetMaintenanceRoundSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceRound> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceAssetRound in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetRound> AssetMaintenanceAssetRound
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetRound == null))
                {
                    this._AssetMaintenanceAssetRound = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetRound>(GetPath("AssetMaintenanceAssetRound"));
                }
                return this._AssetMaintenanceAssetRound;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetRound> _AssetMaintenanceAssetRound;
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetCalendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> AssetMaintenanceAssetCalendar
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetCalendar == null))
                {
                    this._AssetMaintenanceAssetCalendar = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar>(GetPath("AssetMaintenanceAssetCalendar"));
                }
                return this._AssetMaintenanceAssetCalendar;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> _AssetMaintenanceAssetCalendar;
        /// <summary>
        /// There are no comments for AssetMaintenanceWorkOrderType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderTypeSingle AssetMaintenanceWorkOrderType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorkOrderType == null))
                {
                    this._AssetMaintenanceWorkOrderType = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderTypeSingle(this.Context, GetPath("AssetMaintenanceWorkOrderType"));
                }
                return this._AssetMaintenanceWorkOrderType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderTypeSingle _AssetMaintenanceWorkOrderType;
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationRound in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationRound> AssetMaintenanceFunctionalLocationRound
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationRound == null))
                {
                    this._AssetMaintenanceFunctionalLocationRound = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationRound>(GetPath("AssetMaintenanceFunctionalLocationRound"));
                }
                return this._AssetMaintenanceFunctionalLocationRound;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationRound> _AssetMaintenanceFunctionalLocationRound;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceRound in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RoundId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RoundId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceRounds")]
    public partial class AssetMaintenanceRound : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceRound object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="roundId">Initial value of RoundId.</param>
        /// <param name="expectedEndDays">Initial value of ExpectedEndDays.</param>
        /// <param name="expectedEndHours">Initial value of ExpectedEndHours.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="serviceLevel">Initial value of ServiceLevel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceRound CreateAssetMaintenanceRound(string dataAreaId, 
                    string roundId, 
                    int expectedEndDays, 
                    decimal expectedEndHours, 
                    global::System.DateTimeOffset startDate, 
                    int serviceLevel)
        {
            AssetMaintenanceRound assetMaintenanceRound = new AssetMaintenanceRound();
            assetMaintenanceRound.dataAreaId = dataAreaId;
            assetMaintenanceRound.RoundId = roundId;
            assetMaintenanceRound.ExpectedEndDays = expectedEndDays;
            assetMaintenanceRound.ExpectedEndHours = expectedEndHours;
            assetMaintenanceRound.StartDate = startDate;
            assetMaintenanceRound.ServiceLevel = serviceLevel;
            return assetMaintenanceRound;
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
        /// There are no comments for Property RoundId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RoundId
        {
            get
            {
                return this._RoundId;
            }
            set
            {
                this.OnRoundIdChanging(value);
                this._RoundId = value;
                this.OnRoundIdChanged();
                this.OnPropertyChanged("RoundId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoundId;
        partial void OnRoundIdChanging(string value);
        partial void OnRoundIdChanged();
        /// <summary>
        /// There are no comments for Property ExpectedEndDays in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int ExpectedEndDays
        {
            get
            {
                return this._ExpectedEndDays;
            }
            set
            {
                this.OnExpectedEndDaysChanging(value);
                this._ExpectedEndDays = value;
                this.OnExpectedEndDaysChanged();
                this.OnPropertyChanged("ExpectedEndDays");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ExpectedEndDays;
        partial void OnExpectedEndDaysChanging(int value);
        partial void OnExpectedEndDaysChanged();
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
        /// There are no comments for Property ExpectedEndHours in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ExpectedEndHours
        {
            get
            {
                return this._ExpectedEndHours;
            }
            set
            {
                this.OnExpectedEndHoursChanging(value);
                this._ExpectedEndHours = value;
                this.OnExpectedEndHoursChanged();
                this.OnPropertyChanged("ExpectedEndHours");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExpectedEndHours;
        partial void OnExpectedEndHoursChanging(decimal value);
        partial void OnExpectedEndHoursChanged();
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
        /// There are no comments for Property AutoCreate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AutoCreate
        {
            get
            {
                return this._AutoCreate;
            }
            set
            {
                this.OnAutoCreateChanging(value);
                this._AutoCreate = value;
                this.OnAutoCreateChanged();
                this.OnPropertyChanged("AutoCreate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AutoCreate;
        partial void OnAutoCreateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAutoCreateChanged();
        /// <summary>
        /// There are no comments for Property WorkOrderTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkOrderTypeId
        {
            get
            {
                return this._WorkOrderTypeId;
            }
            set
            {
                this.OnWorkOrderTypeIdChanging(value);
                this._WorkOrderTypeId = value;
                this.OnWorkOrderTypeIdChanged();
                this.OnPropertyChanged("WorkOrderTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkOrderTypeId;
        partial void OnWorkOrderTypeIdChanging(string value);
        partial void OnWorkOrderTypeIdChanged();
        /// <summary>
        /// There are no comments for Property ServiceLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int ServiceLevel
        {
            get
            {
                return this._ServiceLevel;
            }
            set
            {
                this.OnServiceLevelChanging(value);
                this._ServiceLevel = value;
                this.OnServiceLevelChanged();
                this.OnPropertyChanged("ServiceLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ServiceLevel;
        partial void OnServiceLevelChanging(int value);
        partial void OnServiceLevelChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetRound in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetRound> AssetMaintenanceAssetRound
        {
            get
            {
                return this._AssetMaintenanceAssetRound;
            }
            set
            {
                this.OnAssetMaintenanceAssetRoundChanging(value);
                this._AssetMaintenanceAssetRound = value;
                this.OnAssetMaintenanceAssetRoundChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetRound");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetRound> _AssetMaintenanceAssetRound = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetRound>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetRoundChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetRound> value);
        partial void OnAssetMaintenanceAssetRoundChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetCalendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> AssetMaintenanceAssetCalendar
        {
            get
            {
                return this._AssetMaintenanceAssetCalendar;
            }
            set
            {
                this.OnAssetMaintenanceAssetCalendarChanging(value);
                this._AssetMaintenanceAssetCalendar = value;
                this.OnAssetMaintenanceAssetCalendarChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetCalendar");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> _AssetMaintenanceAssetCalendar = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetCalendarChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> value);
        partial void OnAssetMaintenanceAssetCalendarChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWorkOrderType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderType AssetMaintenanceWorkOrderType
        {
            get
            {
                return this._AssetMaintenanceWorkOrderType;
            }
            set
            {
                this.OnAssetMaintenanceWorkOrderTypeChanging(value);
                this._AssetMaintenanceWorkOrderType = value;
                this.OnAssetMaintenanceWorkOrderTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceWorkOrderType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderType _AssetMaintenanceWorkOrderType;
        partial void OnAssetMaintenanceWorkOrderTypeChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderType value);
        partial void OnAssetMaintenanceWorkOrderTypeChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocationRound in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationRound> AssetMaintenanceFunctionalLocationRound
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationRound;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationRoundChanging(value);
                this._AssetMaintenanceFunctionalLocationRound = value;
                this.OnAssetMaintenanceFunctionalLocationRoundChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationRound");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationRound> _AssetMaintenanceFunctionalLocationRound = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationRound>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceFunctionalLocationRoundChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationRound> value);
        partial void OnAssetMaintenanceFunctionalLocationRoundChanged();
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
