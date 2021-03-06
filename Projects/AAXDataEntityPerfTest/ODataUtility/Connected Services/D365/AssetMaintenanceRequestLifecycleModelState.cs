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
        /// There are no comments for AssetMaintenanceRequestLifecycleModelStateSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceRequestLifecycleModelStateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceRequestLifecycleModelState>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceRequestLifecycleModelStateSingle object.
        /// </summary>
        public AssetMaintenanceRequestLifecycleModelStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceRequestLifecycleModelStateSingle object.
        /// </summary>
        public AssetMaintenanceRequestLifecycleModelStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceRequestLifecycleModelStateSingle object.
        /// </summary>
        public AssetMaintenanceRequestLifecycleModelStateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceRequestLifecycleModelState> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceRequestLifecycleModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModelSingle AssetMaintenanceRequestLifecycleModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceRequestLifecycleModel == null))
                {
                    this._AssetMaintenanceRequestLifecycleModel = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModelSingle(this.Context, GetPath("AssetMaintenanceRequestLifecycleModel"));
                }
                return this._AssetMaintenanceRequestLifecycleModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModelSingle _AssetMaintenanceRequestLifecycleModel;
        /// <summary>
        /// There are no comments for AssetMaintenanceRequestLifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleStateSingle AssetMaintenanceRequestLifecycleState
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceRequestLifecycleState == null))
                {
                    this._AssetMaintenanceRequestLifecycleState = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleStateSingle(this.Context, GetPath("AssetMaintenanceRequestLifecycleState"));
                }
                return this._AssetMaintenanceRequestLifecycleState;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleStateSingle _AssetMaintenanceRequestLifecycleState;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceRequestLifecycleModelState in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LifecycleStateId
    /// LifecycleModelId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LifecycleStateId", "LifecycleModelId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceRequestLifecycleModelStates")]
    public partial class AssetMaintenanceRequestLifecycleModelState : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceRequestLifecycleModelState object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="lifecycleStateId">Initial value of LifecycleStateId.</param>
        /// <param name="lifecycleModelId">Initial value of LifecycleModelId.</param>
        /// <param name="line">Initial value of Line.</param>
        /// <param name="assetMaintenanceRequestLifecycleModel">Initial value of AssetMaintenanceRequestLifecycleModel.</param>
        /// <param name="assetMaintenanceRequestLifecycleState">Initial value of AssetMaintenanceRequestLifecycleState.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceRequestLifecycleModelState CreateAssetMaintenanceRequestLifecycleModelState(string dataAreaId, 
                    string lifecycleStateId, 
                    string lifecycleModelId, 
                    int line, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModel assetMaintenanceRequestLifecycleModel, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleState assetMaintenanceRequestLifecycleState)
        {
            AssetMaintenanceRequestLifecycleModelState assetMaintenanceRequestLifecycleModelState = new AssetMaintenanceRequestLifecycleModelState();
            assetMaintenanceRequestLifecycleModelState.dataAreaId = dataAreaId;
            assetMaintenanceRequestLifecycleModelState.LifecycleStateId = lifecycleStateId;
            assetMaintenanceRequestLifecycleModelState.LifecycleModelId = lifecycleModelId;
            assetMaintenanceRequestLifecycleModelState.Line = line;
            if ((assetMaintenanceRequestLifecycleModel == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceRequestLifecycleModel");
            }
            assetMaintenanceRequestLifecycleModelState.AssetMaintenanceRequestLifecycleModel = assetMaintenanceRequestLifecycleModel;
            if ((assetMaintenanceRequestLifecycleState == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceRequestLifecycleState");
            }
            assetMaintenanceRequestLifecycleModelState.AssetMaintenanceRequestLifecycleState = assetMaintenanceRequestLifecycleState;
            return assetMaintenanceRequestLifecycleModelState;
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
        /// There are no comments for Property LifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LifecycleStateId
        {
            get
            {
                return this._LifecycleStateId;
            }
            set
            {
                this.OnLifecycleStateIdChanging(value);
                this._LifecycleStateId = value;
                this.OnLifecycleStateIdChanged();
                this.OnPropertyChanged("LifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LifecycleStateId;
        partial void OnLifecycleStateIdChanging(string value);
        partial void OnLifecycleStateIdChanged();
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
        /// There are no comments for Property Line in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Line
        {
            get
            {
                return this._Line;
            }
            set
            {
                this.OnLineChanging(value);
                this._Line = value;
                this.OnLineChanged();
                this.OnPropertyChanged("Line");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Line;
        partial void OnLineChanging(int value);
        partial void OnLineChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceRequestLifecycleModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModel AssetMaintenanceRequestLifecycleModel
        {
            get
            {
                return this._AssetMaintenanceRequestLifecycleModel;
            }
            set
            {
                this.OnAssetMaintenanceRequestLifecycleModelChanging(value);
                this._AssetMaintenanceRequestLifecycleModel = value;
                this.OnAssetMaintenanceRequestLifecycleModelChanged();
                this.OnPropertyChanged("AssetMaintenanceRequestLifecycleModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModel _AssetMaintenanceRequestLifecycleModel;
        partial void OnAssetMaintenanceRequestLifecycleModelChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModel value);
        partial void OnAssetMaintenanceRequestLifecycleModelChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceRequestLifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleState AssetMaintenanceRequestLifecycleState
        {
            get
            {
                return this._AssetMaintenanceRequestLifecycleState;
            }
            set
            {
                this.OnAssetMaintenanceRequestLifecycleStateChanging(value);
                this._AssetMaintenanceRequestLifecycleState = value;
                this.OnAssetMaintenanceRequestLifecycleStateChanged();
                this.OnPropertyChanged("AssetMaintenanceRequestLifecycleState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleState _AssetMaintenanceRequestLifecycleState;
        partial void OnAssetMaintenanceRequestLifecycleStateChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleState value);
        partial void OnAssetMaintenanceRequestLifecycleStateChanged();
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
