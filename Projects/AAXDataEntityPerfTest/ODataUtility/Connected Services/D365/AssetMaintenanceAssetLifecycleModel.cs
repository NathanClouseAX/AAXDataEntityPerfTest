﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 7/17/2021 8:49:18 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetLifecycleModelSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceAssetLifecycleModelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetLifecycleModel>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceAssetLifecycleModelSingle object.
        /// </summary>
        public AssetMaintenanceAssetLifecycleModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetLifecycleModelSingle object.
        /// </summary>
        public AssetMaintenanceAssetLifecycleModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetLifecycleModelSingle object.
        /// </summary>
        public AssetMaintenanceAssetLifecycleModelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetLifecycleModel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceAssetLifecycleModelState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelState> AssetMaintenanceAssetLifecycleModelState
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetLifecycleModelState == null))
                {
                    this._AssetMaintenanceAssetLifecycleModelState = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelState>(GetPath("AssetMaintenanceAssetLifecycleModelState"));
                }
                return this._AssetMaintenanceAssetLifecycleModelState;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelState> _AssetMaintenanceAssetLifecycleModelState;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetLifecycleModel in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LifecycleModelId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LifecycleModelId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceAssetLifecycleModels")]
    public partial class AssetMaintenanceAssetLifecycleModel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceAssetLifecycleModel object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="lifecycleModelId">Initial value of LifecycleModelId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceAssetLifecycleModel CreateAssetMaintenanceAssetLifecycleModel(string dataAreaId, string lifecycleModelId)
        {
            AssetMaintenanceAssetLifecycleModel assetMaintenanceAssetLifecycleModel = new AssetMaintenanceAssetLifecycleModel();
            assetMaintenanceAssetLifecycleModel.dataAreaId = dataAreaId;
            assetMaintenanceAssetLifecycleModel.LifecycleModelId = lifecycleModelId;
            return assetMaintenanceAssetLifecycleModel;
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
        /// There are no comments for Property LifecycleModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LifecycleModelId
        {
            get
            {
                return this._LifecycleModelId;
            }
            set
            {
                this.OnLifecycleModelIdChanging(value);
                this._LifecycleModelId = value;
                this.OnLifecycleModelIdChanged();
                this.OnPropertyChanged("LifecycleModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LifecycleModelId;
        partial void OnLifecycleModelIdChanging(string value);
        partial void OnLifecycleModelIdChanged();
        /// <summary>
        /// There are no comments for Property InStorageLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InStorageLifecycleStateId
        {
            get
            {
                return this._InStorageLifecycleStateId;
            }
            set
            {
                this.OnInStorageLifecycleStateIdChanging(value);
                this._InStorageLifecycleStateId = value;
                this.OnInStorageLifecycleStateIdChanged();
                this.OnPropertyChanged("InStorageLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InStorageLifecycleStateId;
        partial void OnInStorageLifecycleStateIdChanging(string value);
        partial void OnInStorageLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property ActiveLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ActiveLifecycleStateId
        {
            get
            {
                return this._ActiveLifecycleStateId;
            }
            set
            {
                this.OnActiveLifecycleStateIdChanging(value);
                this._ActiveLifecycleStateId = value;
                this.OnActiveLifecycleStateIdChanged();
                this.OnPropertyChanged("ActiveLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActiveLifecycleStateId;
        partial void OnActiveLifecycleStateIdChanging(string value);
        partial void OnActiveLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property InboundLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InboundLifecycleStateId
        {
            get
            {
                return this._InboundLifecycleStateId;
            }
            set
            {
                this.OnInboundLifecycleStateIdChanging(value);
                this._InboundLifecycleStateId = value;
                this.OnInboundLifecycleStateIdChanged();
                this.OnPropertyChanged("InboundLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InboundLifecycleStateId;
        partial void OnInboundLifecycleStateIdChanging(string value);
        partial void OnInboundLifecycleStateIdChanged();
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
        /// There are no comments for Property OnLoanLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OnLoanLifecycleStateId
        {
            get
            {
                return this._OnLoanLifecycleStateId;
            }
            set
            {
                this.OnOnLoanLifecycleStateIdChanging(value);
                this._OnLoanLifecycleStateId = value;
                this.OnOnLoanLifecycleStateIdChanged();
                this.OnPropertyChanged("OnLoanLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OnLoanLifecycleStateId;
        partial void OnOnLoanLifecycleStateIdChanging(string value);
        partial void OnOnLoanLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property ReceivedLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReceivedLifecycleStateId
        {
            get
            {
                return this._ReceivedLifecycleStateId;
            }
            set
            {
                this.OnReceivedLifecycleStateIdChanging(value);
                this._ReceivedLifecycleStateId = value;
                this.OnReceivedLifecycleStateIdChanged();
                this.OnPropertyChanged("ReceivedLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReceivedLifecycleStateId;
        partial void OnReceivedLifecycleStateIdChanging(string value);
        partial void OnReceivedLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property OutboundLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OutboundLifecycleStateId
        {
            get
            {
                return this._OutboundLifecycleStateId;
            }
            set
            {
                this.OnOutboundLifecycleStateIdChanging(value);
                this._OutboundLifecycleStateId = value;
                this.OnOutboundLifecycleStateIdChanged();
                this.OnPropertyChanged("OutboundLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OutboundLifecycleStateId;
        partial void OnOutboundLifecycleStateIdChanging(string value);
        partial void OnOutboundLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetLifecycleModelState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelState> AssetMaintenanceAssetLifecycleModelState
        {
            get
            {
                return this._AssetMaintenanceAssetLifecycleModelState;
            }
            set
            {
                this.OnAssetMaintenanceAssetLifecycleModelStateChanging(value);
                this._AssetMaintenanceAssetLifecycleModelState = value;
                this.OnAssetMaintenanceAssetLifecycleModelStateChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetLifecycleModelState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelState> _AssetMaintenanceAssetLifecycleModelState = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelState>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetLifecycleModelStateChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelState> value);
        partial void OnAssetMaintenanceAssetLifecycleModelStateChanged();
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
