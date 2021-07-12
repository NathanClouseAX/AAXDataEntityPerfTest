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
        /// There are no comments for AssetMaintenanceRequestLifecycleModelSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceRequestLifecycleModelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceRequestLifecycleModel>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceRequestLifecycleModelSingle object.
        /// </summary>
        public AssetMaintenanceRequestLifecycleModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceRequestLifecycleModelSingle object.
        /// </summary>
        public AssetMaintenanceRequestLifecycleModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceRequestLifecycleModelSingle object.
        /// </summary>
        public AssetMaintenanceRequestLifecycleModelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceRequestLifecycleModel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceRequestType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestType> AssetMaintenanceRequestType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceRequestType == null))
                {
                    this._AssetMaintenanceRequestType = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestType>(GetPath("AssetMaintenanceRequestType"));
                }
                return this._AssetMaintenanceRequestType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestType> _AssetMaintenanceRequestType;
        /// <summary>
        /// There are no comments for AssetMaintenanceRequestLifecycleModelState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModelState> AssetMaintenanceRequestLifecycleModelState
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceRequestLifecycleModelState == null))
                {
                    this._AssetMaintenanceRequestLifecycleModelState = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModelState>(GetPath("AssetMaintenanceRequestLifecycleModelState"));
                }
                return this._AssetMaintenanceRequestLifecycleModelState;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModelState> _AssetMaintenanceRequestLifecycleModelState;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceRequestLifecycleModel in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RequestLifecycleModelId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RequestLifecycleModelId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceRequestLifecycleModels")]
    public partial class AssetMaintenanceRequestLifecycleModel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceRequestLifecycleModel object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="requestLifecycleModelId">Initial value of RequestLifecycleModelId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceRequestLifecycleModel CreateAssetMaintenanceRequestLifecycleModel(string dataAreaId, string requestLifecycleModelId)
        {
            AssetMaintenanceRequestLifecycleModel assetMaintenanceRequestLifecycleModel = new AssetMaintenanceRequestLifecycleModel();
            assetMaintenanceRequestLifecycleModel.dataAreaId = dataAreaId;
            assetMaintenanceRequestLifecycleModel.RequestLifecycleModelId = requestLifecycleModelId;
            return assetMaintenanceRequestLifecycleModel;
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
        /// There are no comments for Property RequestLifecycleModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RequestLifecycleModelId
        {
            get
            {
                return this._RequestLifecycleModelId;
            }
            set
            {
                this.OnRequestLifecycleModelIdChanging(value);
                this._RequestLifecycleModelId = value;
                this.OnRequestLifecycleModelIdChanged();
                this.OnPropertyChanged("RequestLifecycleModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequestLifecycleModelId;
        partial void OnRequestLifecycleModelIdChanging(string value);
        partial void OnRequestLifecycleModelIdChanged();
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
        /// There are no comments for Property ReceivedMaintenanceAssetsLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReceivedMaintenanceAssetsLifecycleStateId
        {
            get
            {
                return this._ReceivedMaintenanceAssetsLifecycleStateId;
            }
            set
            {
                this.OnReceivedMaintenanceAssetsLifecycleStateIdChanging(value);
                this._ReceivedMaintenanceAssetsLifecycleStateId = value;
                this.OnReceivedMaintenanceAssetsLifecycleStateIdChanged();
                this.OnPropertyChanged("ReceivedMaintenanceAssetsLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReceivedMaintenanceAssetsLifecycleStateId;
        partial void OnReceivedMaintenanceAssetsLifecycleStateIdChanging(string value);
        partial void OnReceivedMaintenanceAssetsLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property DeliveredMaintenanceAssetsLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DeliveredMaintenanceAssetsLifecycleStateId
        {
            get
            {
                return this._DeliveredMaintenanceAssetsLifecycleStateId;
            }
            set
            {
                this.OnDeliveredMaintenanceAssetsLifecycleStateIdChanging(value);
                this._DeliveredMaintenanceAssetsLifecycleStateId = value;
                this.OnDeliveredMaintenanceAssetsLifecycleStateIdChanged();
                this.OnPropertyChanged("DeliveredMaintenanceAssetsLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeliveredMaintenanceAssetsLifecycleStateId;
        partial void OnDeliveredMaintenanceAssetsLifecycleStateIdChanging(string value);
        partial void OnDeliveredMaintenanceAssetsLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceRequestType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestType> AssetMaintenanceRequestType
        {
            get
            {
                return this._AssetMaintenanceRequestType;
            }
            set
            {
                this.OnAssetMaintenanceRequestTypeChanging(value);
                this._AssetMaintenanceRequestType = value;
                this.OnAssetMaintenanceRequestTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceRequestType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestType> _AssetMaintenanceRequestType = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestType>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceRequestTypeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestType> value);
        partial void OnAssetMaintenanceRequestTypeChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceRequestLifecycleModelState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModelState> AssetMaintenanceRequestLifecycleModelState
        {
            get
            {
                return this._AssetMaintenanceRequestLifecycleModelState;
            }
            set
            {
                this.OnAssetMaintenanceRequestLifecycleModelStateChanging(value);
                this._AssetMaintenanceRequestLifecycleModelState = value;
                this.OnAssetMaintenanceRequestLifecycleModelStateChanged();
                this.OnPropertyChanged("AssetMaintenanceRequestLifecycleModelState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModelState> _AssetMaintenanceRequestLifecycleModelState = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModelState>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceRequestLifecycleModelStateChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModelState> value);
        partial void OnAssetMaintenanceRequestLifecycleModelStateChanged();
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
