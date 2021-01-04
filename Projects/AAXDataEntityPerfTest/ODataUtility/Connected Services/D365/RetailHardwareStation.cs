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
        /// There are no comments for RetailHardwareStationSingle in the schema.
        /// </summary>
    public partial class RetailHardwareStationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailHardwareStation>
    {
        /// <summary>
        /// Initialize a new RetailHardwareStationSingle object.
        /// </summary>
        public RetailHardwareStationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailHardwareStationSingle object.
        /// </summary>
        public RetailHardwareStationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailHardwareStationSingle object.
        /// </summary>
        public RetailHardwareStationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailHardwareStation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailStoreHardwareStation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailStoreHardwareStation> RetailStoreHardwareStation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailStoreHardwareStation == null))
                {
                    this._RetailStoreHardwareStation = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailStoreHardwareStation>(GetPath("RetailStoreHardwareStation"));
                }
                return this._RetailStoreHardwareStation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailStoreHardwareStation> _RetailStoreHardwareStation;
    }
        /// <summary>
        /// There are no comments for RetailHardwareStation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// HardwareStationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("HardwareStationId")]
    [global::Microsoft.OData.Client.EntitySet("RetailHardwareStations")]
    public partial class RetailHardwareStation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailHardwareStation object.
        /// </summary>
        /// <param name="hardwareStationId">Initial value of HardwareStationId.</param>
        /// <param name="mergedSelfServicePackageReference">Initial value of MergedSelfServicePackageReference.</param>
        /// <param name="hardwareStationPortNumber">Initial value of HardwareStationPortNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailHardwareStation CreateRetailHardwareStation(string hardwareStationId, long mergedSelfServicePackageReference, int hardwareStationPortNumber)
        {
            RetailHardwareStation retailHardwareStation = new RetailHardwareStation();
            retailHardwareStation.HardwareStationId = hardwareStationId;
            retailHardwareStation.MergedSelfServicePackageReference = mergedSelfServicePackageReference;
            retailHardwareStation.HardwareStationPortNumber = hardwareStationPortNumber;
            return retailHardwareStation;
        }
        /// <summary>
        /// There are no comments for Property HardwareStationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string HardwareStationId
        {
            get
            {
                return this._HardwareStationId;
            }
            set
            {
                this.OnHardwareStationIdChanging(value);
                this._HardwareStationId = value;
                this.OnHardwareStationIdChanged();
                this.OnPropertyChanged("HardwareStationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HardwareStationId;
        partial void OnHardwareStationIdChanging(string value);
        partial void OnHardwareStationIdChanged();
        /// <summary>
        /// There are no comments for Property HardwareStationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string HardwareStationName
        {
            get
            {
                return this._HardwareStationName;
            }
            set
            {
                this.OnHardwareStationNameChanging(value);
                this._HardwareStationName = value;
                this.OnHardwareStationNameChanged();
                this.OnPropertyChanged("HardwareStationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HardwareStationName;
        partial void OnHardwareStationNameChanging(string value);
        partial void OnHardwareStationNameChanged();
        /// <summary>
        /// There are no comments for Property MergedSelfServicePackageReference in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long MergedSelfServicePackageReference
        {
            get
            {
                return this._MergedSelfServicePackageReference;
            }
            set
            {
                this.OnMergedSelfServicePackageReferenceChanging(value);
                this._MergedSelfServicePackageReference = value;
                this.OnMergedSelfServicePackageReferenceChanged();
                this.OnPropertyChanged("MergedSelfServicePackageReference");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _MergedSelfServicePackageReference;
        partial void OnMergedSelfServicePackageReferenceChanging(long value);
        partial void OnMergedSelfServicePackageReferenceChanged();
        /// <summary>
        /// There are no comments for Property HardwareStationPortNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int HardwareStationPortNumber
        {
            get
            {
                return this._HardwareStationPortNumber;
            }
            set
            {
                this.OnHardwareStationPortNumberChanging(value);
                this._HardwareStationPortNumber = value;
                this.OnHardwareStationPortNumberChanged();
                this.OnPropertyChanged("HardwareStationPortNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _HardwareStationPortNumber;
        partial void OnHardwareStationPortNumberChanging(int value);
        partial void OnHardwareStationPortNumberChanged();
        /// <summary>
        /// There are no comments for Property HardwareProfileId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string HardwareProfileId
        {
            get
            {
                return this._HardwareProfileId;
            }
            set
            {
                this.OnHardwareProfileIdChanging(value);
                this._HardwareProfileId = value;
                this.OnHardwareProfileIdChanged();
                this.OnPropertyChanged("HardwareProfileId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HardwareProfileId;
        partial void OnHardwareProfileIdChanging(string value);
        partial void OnHardwareProfileIdChanged();
        /// <summary>
        /// There are no comments for Property SelfServicePackageName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SelfServicePackageName
        {
            get
            {
                return this._SelfServicePackageName;
            }
            set
            {
                this.OnSelfServicePackageNameChanging(value);
                this._SelfServicePackageName = value;
                this.OnSelfServicePackageNameChanged();
                this.OnPropertyChanged("SelfServicePackageName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SelfServicePackageName;
        partial void OnSelfServicePackageNameChanging(string value);
        partial void OnSelfServicePackageNameChanged();
        /// <summary>
        /// There are no comments for Property RetailStoreHardwareStation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailStoreHardwareStation> RetailStoreHardwareStation
        {
            get
            {
                return this._RetailStoreHardwareStation;
            }
            set
            {
                this.OnRetailStoreHardwareStationChanging(value);
                this._RetailStoreHardwareStation = value;
                this.OnRetailStoreHardwareStationChanged();
                this.OnPropertyChanged("RetailStoreHardwareStation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailStoreHardwareStation> _RetailStoreHardwareStation = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailStoreHardwareStation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailStoreHardwareStationChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailStoreHardwareStation> value);
        partial void OnRetailStoreHardwareStationChanged();
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
