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
        /// There are no comments for AssetMaintenanceJobGroupSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceJobGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceJobGroup>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceJobGroupSingle object.
        /// </summary>
        public AssetMaintenanceJobGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceJobGroupSingle object.
        /// </summary>
        public AssetMaintenanceJobGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceJobGroupSingle object.
        /// </summary>
        public AssetMaintenanceJobGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceJobGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceScheduledExecution in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceScheduledExecution> AssetMaintenanceScheduledExecution
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceScheduledExecution == null))
                {
                    this._AssetMaintenanceScheduledExecution = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceScheduledExecution>(GetPath("AssetMaintenanceScheduledExecution"));
                }
                return this._AssetMaintenanceScheduledExecution;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceScheduledExecution> _AssetMaintenanceScheduledExecution;
        /// <summary>
        /// There are no comments for AssetMaintenanceWorkerResponsible in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerResponsible> AssetMaintenanceWorkerResponsible
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorkerResponsible == null))
                {
                    this._AssetMaintenanceWorkerResponsible = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerResponsible>(GetPath("AssetMaintenanceWorkerResponsible"));
                }
                return this._AssetMaintenanceWorkerResponsible;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerResponsible> _AssetMaintenanceWorkerResponsible;
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetCriticality in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCriticality> AssetMaintenanceAssetCriticality
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetCriticality == null))
                {
                    this._AssetMaintenanceAssetCriticality = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCriticality>(GetPath("AssetMaintenanceAssetCriticality"));
                }
                return this._AssetMaintenanceAssetCriticality;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCriticality> _AssetMaintenanceAssetCriticality;
        /// <summary>
        /// There are no comments for AssetMaintenanceJobType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType> AssetMaintenanceJobType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceJobType == null))
                {
                    this._AssetMaintenanceJobType = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType>(GetPath("AssetMaintenanceJobType"));
                }
                return this._AssetMaintenanceJobType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType> _AssetMaintenanceJobType;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceJobGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// JobGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JobGroupId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceJobGroups")]
    public partial class AssetMaintenanceJobGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceJobGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="jobGroupId">Initial value of JobGroupId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceJobGroup CreateAssetMaintenanceJobGroup(string dataAreaId, string jobGroupId)
        {
            AssetMaintenanceJobGroup assetMaintenanceJobGroup = new AssetMaintenanceJobGroup();
            assetMaintenanceJobGroup.dataAreaId = dataAreaId;
            assetMaintenanceJobGroup.JobGroupId = jobGroupId;
            return assetMaintenanceJobGroup;
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
        /// There are no comments for Property JobGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobGroupId
        {
            get
            {
                return this._JobGroupId;
            }
            set
            {
                this.OnJobGroupIdChanging(value);
                this._JobGroupId = value;
                this.OnJobGroupIdChanged();
                this.OnPropertyChanged("JobGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobGroupId;
        partial void OnJobGroupIdChanging(string value);
        partial void OnJobGroupIdChanged();
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
        /// There are no comments for Property AssetMaintenanceScheduledExecution in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceScheduledExecution> AssetMaintenanceScheduledExecution
        {
            get
            {
                return this._AssetMaintenanceScheduledExecution;
            }
            set
            {
                this.OnAssetMaintenanceScheduledExecutionChanging(value);
                this._AssetMaintenanceScheduledExecution = value;
                this.OnAssetMaintenanceScheduledExecutionChanged();
                this.OnPropertyChanged("AssetMaintenanceScheduledExecution");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceScheduledExecution> _AssetMaintenanceScheduledExecution = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceScheduledExecution>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceScheduledExecutionChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceScheduledExecution> value);
        partial void OnAssetMaintenanceScheduledExecutionChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWorkerResponsible in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerResponsible> AssetMaintenanceWorkerResponsible
        {
            get
            {
                return this._AssetMaintenanceWorkerResponsible;
            }
            set
            {
                this.OnAssetMaintenanceWorkerResponsibleChanging(value);
                this._AssetMaintenanceWorkerResponsible = value;
                this.OnAssetMaintenanceWorkerResponsibleChanged();
                this.OnPropertyChanged("AssetMaintenanceWorkerResponsible");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerResponsible> _AssetMaintenanceWorkerResponsible = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerResponsible>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceWorkerResponsibleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerResponsible> value);
        partial void OnAssetMaintenanceWorkerResponsibleChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetCriticality in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCriticality> AssetMaintenanceAssetCriticality
        {
            get
            {
                return this._AssetMaintenanceAssetCriticality;
            }
            set
            {
                this.OnAssetMaintenanceAssetCriticalityChanging(value);
                this._AssetMaintenanceAssetCriticality = value;
                this.OnAssetMaintenanceAssetCriticalityChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetCriticality");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCriticality> _AssetMaintenanceAssetCriticality = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCriticality>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetCriticalityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCriticality> value);
        partial void OnAssetMaintenanceAssetCriticalityChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceJobType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType> AssetMaintenanceJobType
        {
            get
            {
                return this._AssetMaintenanceJobType;
            }
            set
            {
                this.OnAssetMaintenanceJobTypeChanging(value);
                this._AssetMaintenanceJobType = value;
                this.OnAssetMaintenanceJobTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceJobType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType> _AssetMaintenanceJobType = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceJobTypeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType> value);
        partial void OnAssetMaintenanceJobTypeChanged();
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
