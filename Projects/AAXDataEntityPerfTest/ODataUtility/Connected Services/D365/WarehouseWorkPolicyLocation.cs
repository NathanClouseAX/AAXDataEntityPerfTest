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
        /// There are no comments for WarehouseWorkPolicyLocationSingle in the schema.
        /// </summary>
    public partial class WarehouseWorkPolicyLocationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseWorkPolicyLocation>
    {
        /// <summary>
        /// Initialize a new WarehouseWorkPolicyLocationSingle object.
        /// </summary>
        public WarehouseWorkPolicyLocationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WarehouseWorkPolicyLocationSingle object.
        /// </summary>
        public WarehouseWorkPolicyLocationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WarehouseWorkPolicyLocationSingle object.
        /// </summary>
        public WarehouseWorkPolicyLocationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseWorkPolicyLocation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WarehouseLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WarehouseLocationSingle WarehouseLocation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WarehouseLocation == null))
                {
                    this._WarehouseLocation = new global::Microsoft.Dynamics.DataEntities.WarehouseLocationSingle(this.Context, GetPath("WarehouseLocation"));
                }
                return this._WarehouseLocation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WarehouseLocationSingle _WarehouseLocation;
        /// <summary>
        /// There are no comments for WarehouseWorkPolicy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicySingle WarehouseWorkPolicy
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WarehouseWorkPolicy == null))
                {
                    this._WarehouseWorkPolicy = new global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicySingle(this.Context, GetPath("WarehouseWorkPolicy"));
                }
                return this._WarehouseWorkPolicy;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicySingle _WarehouseWorkPolicy;
    }
        /// <summary>
        /// There are no comments for WarehouseWorkPolicyLocation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// WarehouseId
    /// WarehouseLocationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WarehouseId", "WarehouseLocationId")]
    [global::Microsoft.OData.Client.EntitySet("WarehouseWorkPolicyLocations")]
    public partial class WarehouseWorkPolicyLocation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WarehouseWorkPolicyLocation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="warehouseId">Initial value of WarehouseId.</param>
        /// <param name="warehouseLocationId">Initial value of WarehouseLocationId.</param>
        /// <param name="warehouseLocation">Initial value of WarehouseLocation.</param>
        /// <param name="warehouseWorkPolicy">Initial value of WarehouseWorkPolicy.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WarehouseWorkPolicyLocation CreateWarehouseWorkPolicyLocation(string dataAreaId, string warehouseId, string warehouseLocationId, global::Microsoft.Dynamics.DataEntities.WarehouseLocation warehouseLocation, global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicy warehouseWorkPolicy)
        {
            WarehouseWorkPolicyLocation warehouseWorkPolicyLocation = new WarehouseWorkPolicyLocation();
            warehouseWorkPolicyLocation.dataAreaId = dataAreaId;
            warehouseWorkPolicyLocation.WarehouseId = warehouseId;
            warehouseWorkPolicyLocation.WarehouseLocationId = warehouseLocationId;
            if ((warehouseLocation == null))
            {
                throw new global::System.ArgumentNullException("warehouseLocation");
            }
            warehouseWorkPolicyLocation.WarehouseLocation = warehouseLocation;
            if ((warehouseWorkPolicy == null))
            {
                throw new global::System.ArgumentNullException("warehouseWorkPolicy");
            }
            warehouseWorkPolicyLocation.WarehouseWorkPolicy = warehouseWorkPolicy;
            return warehouseWorkPolicyLocation;
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
        /// There are no comments for Property WarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WarehouseId
        {
            get
            {
                return this._WarehouseId;
            }
            set
            {
                this.OnWarehouseIdChanging(value);
                this._WarehouseId = value;
                this.OnWarehouseIdChanged();
                this.OnPropertyChanged("WarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WarehouseId;
        partial void OnWarehouseIdChanging(string value);
        partial void OnWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property WarehouseLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WarehouseLocationId
        {
            get
            {
                return this._WarehouseLocationId;
            }
            set
            {
                this.OnWarehouseLocationIdChanging(value);
                this._WarehouseLocationId = value;
                this.OnWarehouseLocationIdChanged();
                this.OnPropertyChanged("WarehouseLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WarehouseLocationId;
        partial void OnWarehouseLocationIdChanging(string value);
        partial void OnWarehouseLocationIdChanged();
        /// <summary>
        /// There are no comments for Property WorkPolicyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkPolicyName
        {
            get
            {
                return this._WorkPolicyName;
            }
            set
            {
                this.OnWorkPolicyNameChanging(value);
                this._WorkPolicyName = value;
                this.OnWorkPolicyNameChanged();
                this.OnPropertyChanged("WorkPolicyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkPolicyName;
        partial void OnWorkPolicyNameChanging(string value);
        partial void OnWorkPolicyNameChanged();
        /// <summary>
        /// There are no comments for Property WarehouseLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WarehouseLocation WarehouseLocation
        {
            get
            {
                return this._WarehouseLocation;
            }
            set
            {
                this.OnWarehouseLocationChanging(value);
                this._WarehouseLocation = value;
                this.OnWarehouseLocationChanged();
                this.OnPropertyChanged("WarehouseLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WarehouseLocation _WarehouseLocation;
        partial void OnWarehouseLocationChanging(global::Microsoft.Dynamics.DataEntities.WarehouseLocation value);
        partial void OnWarehouseLocationChanged();
        /// <summary>
        /// There are no comments for Property WarehouseWorkPolicy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicy WarehouseWorkPolicy
        {
            get
            {
                return this._WarehouseWorkPolicy;
            }
            set
            {
                this.OnWarehouseWorkPolicyChanging(value);
                this._WarehouseWorkPolicy = value;
                this.OnWarehouseWorkPolicyChanged();
                this.OnPropertyChanged("WarehouseWorkPolicy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicy _WarehouseWorkPolicy;
        partial void OnWarehouseWorkPolicyChanging(global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicy value);
        partial void OnWarehouseWorkPolicyChanged();
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
