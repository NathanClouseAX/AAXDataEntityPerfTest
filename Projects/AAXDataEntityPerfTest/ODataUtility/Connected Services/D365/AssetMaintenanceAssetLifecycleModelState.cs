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
        /// There are no comments for AssetMaintenanceAssetLifecycleModelStateSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceAssetLifecycleModelStateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetLifecycleModelState>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceAssetLifecycleModelStateSingle object.
        /// </summary>
        public AssetMaintenanceAssetLifecycleModelStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetLifecycleModelStateSingle object.
        /// </summary>
        public AssetMaintenanceAssetLifecycleModelStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetLifecycleModelStateSingle object.
        /// </summary>
        public AssetMaintenanceAssetLifecycleModelStateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetLifecycleModelState> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceAssetLifecycleModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelSingle AssetMaintenanceAssetLifecycleModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetLifecycleModel == null))
                {
                    this._AssetMaintenanceAssetLifecycleModel = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelSingle(this.Context, GetPath("AssetMaintenanceAssetLifecycleModel"));
                }
                return this._AssetMaintenanceAssetLifecycleModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelSingle _AssetMaintenanceAssetLifecycleModel;
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetLifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleStateSingle AssetMaintenanceAssetLifecycleState
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetLifecycleState == null))
                {
                    this._AssetMaintenanceAssetLifecycleState = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleStateSingle(this.Context, GetPath("AssetMaintenanceAssetLifecycleState"));
                }
                return this._AssetMaintenanceAssetLifecycleState;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleStateSingle _AssetMaintenanceAssetLifecycleState;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetLifecycleModelState in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LifecycleModelId
    /// LifecycleStateId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LifecycleModelId", "LifecycleStateId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceAssetLifecycleModelStates")]
    public partial class AssetMaintenanceAssetLifecycleModelState : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceAssetLifecycleModelState object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="lifecycleModelId">Initial value of LifecycleModelId.</param>
        /// <param name="lifecycleStateId">Initial value of LifecycleStateId.</param>
        /// <param name="line">Initial value of Line.</param>
        /// <param name="assetMaintenanceAssetLifecycleModel">Initial value of AssetMaintenanceAssetLifecycleModel.</param>
        /// <param name="assetMaintenanceAssetLifecycleState">Initial value of AssetMaintenanceAssetLifecycleState.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceAssetLifecycleModelState CreateAssetMaintenanceAssetLifecycleModelState(string dataAreaId, 
                    string lifecycleModelId, 
                    string lifecycleStateId, 
                    int line, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModel assetMaintenanceAssetLifecycleModel, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleState assetMaintenanceAssetLifecycleState)
        {
            AssetMaintenanceAssetLifecycleModelState assetMaintenanceAssetLifecycleModelState = new AssetMaintenanceAssetLifecycleModelState();
            assetMaintenanceAssetLifecycleModelState.dataAreaId = dataAreaId;
            assetMaintenanceAssetLifecycleModelState.LifecycleModelId = lifecycleModelId;
            assetMaintenanceAssetLifecycleModelState.LifecycleStateId = lifecycleStateId;
            assetMaintenanceAssetLifecycleModelState.Line = line;
            if ((assetMaintenanceAssetLifecycleModel == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceAssetLifecycleModel");
            }
            assetMaintenanceAssetLifecycleModelState.AssetMaintenanceAssetLifecycleModel = assetMaintenanceAssetLifecycleModel;
            if ((assetMaintenanceAssetLifecycleState == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceAssetLifecycleState");
            }
            assetMaintenanceAssetLifecycleModelState.AssetMaintenanceAssetLifecycleState = assetMaintenanceAssetLifecycleState;
            return assetMaintenanceAssetLifecycleModelState;
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
        /// There are no comments for Property AssetMaintenanceAssetLifecycleModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModel AssetMaintenanceAssetLifecycleModel
        {
            get
            {
                return this._AssetMaintenanceAssetLifecycleModel;
            }
            set
            {
                this.OnAssetMaintenanceAssetLifecycleModelChanging(value);
                this._AssetMaintenanceAssetLifecycleModel = value;
                this.OnAssetMaintenanceAssetLifecycleModelChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetLifecycleModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModel _AssetMaintenanceAssetLifecycleModel;
        partial void OnAssetMaintenanceAssetLifecycleModelChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModel value);
        partial void OnAssetMaintenanceAssetLifecycleModelChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetLifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleState AssetMaintenanceAssetLifecycleState
        {
            get
            {
                return this._AssetMaintenanceAssetLifecycleState;
            }
            set
            {
                this.OnAssetMaintenanceAssetLifecycleStateChanging(value);
                this._AssetMaintenanceAssetLifecycleState = value;
                this.OnAssetMaintenanceAssetLifecycleStateChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetLifecycleState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleState _AssetMaintenanceAssetLifecycleState;
        partial void OnAssetMaintenanceAssetLifecycleStateChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleState value);
        partial void OnAssetMaintenanceAssetLifecycleStateChanged();
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
