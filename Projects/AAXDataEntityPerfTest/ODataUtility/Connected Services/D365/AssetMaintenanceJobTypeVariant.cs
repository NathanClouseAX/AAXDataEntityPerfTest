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
        /// There are no comments for AssetMaintenanceJobTypeVariantSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceJobTypeVariantSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceJobTypeVariant>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceJobTypeVariantSingle object.
        /// </summary>
        public AssetMaintenanceJobTypeVariantSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceJobTypeVariantSingle object.
        /// </summary>
        public AssetMaintenanceJobTypeVariantSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceJobTypeVariantSingle object.
        /// </summary>
        public AssetMaintenanceJobTypeVariantSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceJobTypeVariant> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceJobVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariantSingle AssetMaintenanceJobVariant
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceJobVariant == null))
                {
                    this._AssetMaintenanceJobVariant = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariantSingle(this.Context, GetPath("AssetMaintenanceJobVariant"));
                }
                return this._AssetMaintenanceJobVariant;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariantSingle _AssetMaintenanceJobVariant;
        /// <summary>
        /// There are no comments for AssetMaintenanceJobType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeSingle AssetMaintenanceJobType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceJobType == null))
                {
                    this._AssetMaintenanceJobType = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeSingle(this.Context, GetPath("AssetMaintenanceJobType"));
                }
                return this._AssetMaintenanceJobType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeSingle _AssetMaintenanceJobType;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceJobTypeVariant in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// JobTypeId
    /// JobVariantId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JobTypeId", "JobVariantId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceJobTypeVariants")]
    public partial class AssetMaintenanceJobTypeVariant : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceJobTypeVariant object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="jobTypeId">Initial value of JobTypeId.</param>
        /// <param name="jobVariantId">Initial value of JobVariantId.</param>
        /// <param name="numberOfWorkers">Initial value of NumberOfWorkers.</param>
        /// <param name="assetMaintenanceJobVariant">Initial value of AssetMaintenanceJobVariant.</param>
        /// <param name="assetMaintenanceJobType">Initial value of AssetMaintenanceJobType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceJobTypeVariant CreateAssetMaintenanceJobTypeVariant(string dataAreaId, 
                    string jobTypeId, 
                    string jobVariantId, 
                    int numberOfWorkers, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariant assetMaintenanceJobVariant, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType assetMaintenanceJobType)
        {
            AssetMaintenanceJobTypeVariant assetMaintenanceJobTypeVariant = new AssetMaintenanceJobTypeVariant();
            assetMaintenanceJobTypeVariant.dataAreaId = dataAreaId;
            assetMaintenanceJobTypeVariant.JobTypeId = jobTypeId;
            assetMaintenanceJobTypeVariant.JobVariantId = jobVariantId;
            assetMaintenanceJobTypeVariant.NumberOfWorkers = numberOfWorkers;
            if ((assetMaintenanceJobVariant == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceJobVariant");
            }
            assetMaintenanceJobTypeVariant.AssetMaintenanceJobVariant = assetMaintenanceJobVariant;
            if ((assetMaintenanceJobType == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceJobType");
            }
            assetMaintenanceJobTypeVariant.AssetMaintenanceJobType = assetMaintenanceJobType;
            return assetMaintenanceJobTypeVariant;
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
        /// There are no comments for Property JobTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobTypeId
        {
            get
            {
                return this._JobTypeId;
            }
            set
            {
                this.OnJobTypeIdChanging(value);
                this._JobTypeId = value;
                this.OnJobTypeIdChanged();
                this.OnPropertyChanged("JobTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTypeId;
        partial void OnJobTypeIdChanging(string value);
        partial void OnJobTypeIdChanged();
        /// <summary>
        /// There are no comments for Property JobVariantId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobVariantId
        {
            get
            {
                return this._JobVariantId;
            }
            set
            {
                this.OnJobVariantIdChanging(value);
                this._JobVariantId = value;
                this.OnJobVariantIdChanged();
                this.OnPropertyChanged("JobVariantId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobVariantId;
        partial void OnJobVariantIdChanging(string value);
        partial void OnJobVariantIdChanged();
        /// <summary>
        /// There are no comments for Property NumberOfWorkers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int NumberOfWorkers
        {
            get
            {
                return this._NumberOfWorkers;
            }
            set
            {
                this.OnNumberOfWorkersChanging(value);
                this._NumberOfWorkers = value;
                this.OnNumberOfWorkersChanged();
                this.OnPropertyChanged("NumberOfWorkers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NumberOfWorkers;
        partial void OnNumberOfWorkersChanging(int value);
        partial void OnNumberOfWorkersChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceJobVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariant AssetMaintenanceJobVariant
        {
            get
            {
                return this._AssetMaintenanceJobVariant;
            }
            set
            {
                this.OnAssetMaintenanceJobVariantChanging(value);
                this._AssetMaintenanceJobVariant = value;
                this.OnAssetMaintenanceJobVariantChanged();
                this.OnPropertyChanged("AssetMaintenanceJobVariant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariant _AssetMaintenanceJobVariant;
        partial void OnAssetMaintenanceJobVariantChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariant value);
        partial void OnAssetMaintenanceJobVariantChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceJobType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType AssetMaintenanceJobType
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
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType _AssetMaintenanceJobType;
        partial void OnAssetMaintenanceJobTypeChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType value);
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
