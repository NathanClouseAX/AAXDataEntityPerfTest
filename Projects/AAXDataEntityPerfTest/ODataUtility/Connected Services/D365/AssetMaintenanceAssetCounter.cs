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
        /// There are no comments for AssetMaintenanceAssetCounterSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceAssetCounterSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetCounter>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceAssetCounterSingle object.
        /// </summary>
        public AssetMaintenanceAssetCounterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetCounterSingle object.
        /// </summary>
        public AssetMaintenanceAssetCounterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetCounterSingle object.
        /// </summary>
        public AssetMaintenanceAssetCounterSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetCounter> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceAssetTypeCounterAssociation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeCounterAssociation> AssetMaintenanceAssetTypeCounterAssociation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetTypeCounterAssociation == null))
                {
                    this._AssetMaintenanceAssetTypeCounterAssociation = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeCounterAssociation>(GetPath("AssetMaintenanceAssetTypeCounterAssociation"));
                }
                return this._AssetMaintenanceAssetTypeCounterAssociation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeCounterAssociation> _AssetMaintenanceAssetTypeCounterAssociation;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetCounter in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CounterId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CounterId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceAssetCounters")]
    public partial class AssetMaintenanceAssetCounter : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceAssetCounter object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="counterId">Initial value of CounterId.</param>
        /// <param name="valueDeviationOver">Initial value of ValueDeviationOver.</param>
        /// <param name="valueDeviationUnder">Initial value of ValueDeviationUnder.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceAssetCounter CreateAssetMaintenanceAssetCounter(string dataAreaId, string counterId, decimal valueDeviationOver, decimal valueDeviationUnder)
        {
            AssetMaintenanceAssetCounter assetMaintenanceAssetCounter = new AssetMaintenanceAssetCounter();
            assetMaintenanceAssetCounter.dataAreaId = dataAreaId;
            assetMaintenanceAssetCounter.CounterId = counterId;
            assetMaintenanceAssetCounter.ValueDeviationOver = valueDeviationOver;
            assetMaintenanceAssetCounter.ValueDeviationUnder = valueDeviationUnder;
            return assetMaintenanceAssetCounter;
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
        /// There are no comments for Property CounterId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CounterId
        {
            get
            {
                return this._CounterId;
            }
            set
            {
                this.OnCounterIdChanging(value);
                this._CounterId = value;
                this.OnCounterIdChanged();
                this.OnPropertyChanged("CounterId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CounterId;
        partial void OnCounterIdChanging(string value);
        partial void OnCounterIdChanged();
        /// <summary>
        /// There are no comments for Property CounterUpdate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetObjectCounterUpdate> CounterUpdate
        {
            get
            {
                return this._CounterUpdate;
            }
            set
            {
                this.OnCounterUpdateChanging(value);
                this._CounterUpdate = value;
                this.OnCounterUpdateChanged();
                this.OnPropertyChanged("CounterUpdate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetObjectCounterUpdate> _CounterUpdate;
        partial void OnCounterUpdateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetObjectCounterUpdate> value);
        partial void OnCounterUpdateChanged();
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
        /// There are no comments for Property Inherit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Inherit
        {
            get
            {
                return this._Inherit;
            }
            set
            {
                this.OnInheritChanging(value);
                this._Inherit = value;
                this.OnInheritChanged();
                this.OnPropertyChanged("Inherit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Inherit;
        partial void OnInheritChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnInheritChanged();
        /// <summary>
        /// There are no comments for Property ValueDeviationOver in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ValueDeviationOver
        {
            get
            {
                return this._ValueDeviationOver;
            }
            set
            {
                this.OnValueDeviationOverChanging(value);
                this._ValueDeviationOver = value;
                this.OnValueDeviationOverChanged();
                this.OnPropertyChanged("ValueDeviationOver");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ValueDeviationOver;
        partial void OnValueDeviationOverChanging(decimal value);
        partial void OnValueDeviationOverChanged();
        /// <summary>
        /// There are no comments for Property ValueDeviationUnder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ValueDeviationUnder
        {
            get
            {
                return this._ValueDeviationUnder;
            }
            set
            {
                this.OnValueDeviationUnderChanging(value);
                this._ValueDeviationUnder = value;
                this.OnValueDeviationUnderChanged();
                this.OnPropertyChanged("ValueDeviationUnder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ValueDeviationUnder;
        partial void OnValueDeviationUnderChanging(decimal value);
        partial void OnValueDeviationUnderChanged();
        /// <summary>
        /// There are no comments for Property ValueDeviationInfoType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetInfoType> ValueDeviationInfoType
        {
            get
            {
                return this._ValueDeviationInfoType;
            }
            set
            {
                this.OnValueDeviationInfoTypeChanging(value);
                this._ValueDeviationInfoType = value;
                this.OnValueDeviationInfoTypeChanged();
                this.OnPropertyChanged("ValueDeviationInfoType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetInfoType> _ValueDeviationInfoType;
        partial void OnValueDeviationInfoTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetInfoType> value);
        partial void OnValueDeviationInfoTypeChanged();
        /// <summary>
        /// There are no comments for Property CounterAggregate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetCounterAggregate> CounterAggregate
        {
            get
            {
                return this._CounterAggregate;
            }
            set
            {
                this.OnCounterAggregateChanging(value);
                this._CounterAggregate = value;
                this.OnCounterAggregateChanged();
                this.OnPropertyChanged("CounterAggregate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetCounterAggregate> _CounterAggregate;
        partial void OnCounterAggregateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetCounterAggregate> value);
        partial void OnCounterAggregateChanged();
        /// <summary>
        /// There are no comments for Property UnitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UnitId
        {
            get
            {
                return this._UnitId;
            }
            set
            {
                this.OnUnitIdChanging(value);
                this._UnitId = value;
                this.OnUnitIdChanged();
                this.OnPropertyChanged("UnitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitId;
        partial void OnUnitIdChanging(string value);
        partial void OnUnitIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetTypeCounterAssociation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeCounterAssociation> AssetMaintenanceAssetTypeCounterAssociation
        {
            get
            {
                return this._AssetMaintenanceAssetTypeCounterAssociation;
            }
            set
            {
                this.OnAssetMaintenanceAssetTypeCounterAssociationChanging(value);
                this._AssetMaintenanceAssetTypeCounterAssociation = value;
                this.OnAssetMaintenanceAssetTypeCounterAssociationChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetTypeCounterAssociation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeCounterAssociation> _AssetMaintenanceAssetTypeCounterAssociation = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeCounterAssociation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetTypeCounterAssociationChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeCounterAssociation> value);
        partial void OnAssetMaintenanceAssetTypeCounterAssociationChanged();
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
