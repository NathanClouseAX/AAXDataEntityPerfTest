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
        /// There are no comments for AcquisitionMethodSingle in the schema.
        /// </summary>
    public partial class AcquisitionMethodSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AcquisitionMethod>
    {
        /// <summary>
        /// Initialize a new AcquisitionMethodSingle object.
        /// </summary>
        public AcquisitionMethodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AcquisitionMethodSingle object.
        /// </summary>
        public AcquisitionMethodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AcquisitionMethodSingle object.
        /// </summary>
        public AcquisitionMethodSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AcquisitionMethod> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetBookV2AcquisitionMethodAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> AssetBookV2AcquisitionMethodAsset
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetBookV2AcquisitionMethodAsset == null))
                {
                    this._AssetBookV2AcquisitionMethodAsset = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2>(GetPath("AssetBookV2AcquisitionMethodAsset"));
                }
                return this._AssetBookV2AcquisitionMethodAsset;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> _AssetBookV2AcquisitionMethodAsset;
        /// <summary>
        /// There are no comments for AcquisitionMethodValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> AcquisitionMethodValueModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AcquisitionMethodValueModel == null))
                {
                    this._AcquisitionMethodValueModel = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel>(GetPath("AcquisitionMethodValueModel"));
                }
                return this._AcquisitionMethodValueModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> _AcquisitionMethodValueModel;
    }
        /// <summary>
        /// There are no comments for AcquisitionMethod in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// AcquisitionMethod
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AcquisitionMethod")]
    [global::Microsoft.OData.Client.EntitySet("AcquisitionMethods")]
    public partial class AcquisitionMethod : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AcquisitionMethod object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="acquisitionMethod1">Initial value of AcquisitionMethod1.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AcquisitionMethod CreateAcquisitionMethod(string dataAreaId, string acquisitionMethod1)
        {
            AcquisitionMethod acquisitionMethod = new AcquisitionMethod();
            acquisitionMethod.dataAreaId = dataAreaId;
            acquisitionMethod.AcquisitionMethod1 = acquisitionMethod1;
            return acquisitionMethod;
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
        /// There are no comments for Property AcquisitionMethod1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AcquisitionMethod")]
        public virtual string AcquisitionMethod1
        {
            get
            {
                return this._AcquisitionMethod1;
            }
            set
            {
                this.OnAcquisitionMethod1Changing(value);
                this._AcquisitionMethod1 = value;
                this.OnAcquisitionMethod1Changed();
                this.OnPropertyChanged("AcquisitionMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AcquisitionMethod1;
        partial void OnAcquisitionMethod1Changing(string value);
        partial void OnAcquisitionMethod1Changed();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property AssetBookV2AcquisitionMethodAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> AssetBookV2AcquisitionMethodAsset
        {
            get
            {
                return this._AssetBookV2AcquisitionMethodAsset;
            }
            set
            {
                this.OnAssetBookV2AcquisitionMethodAssetChanging(value);
                this._AssetBookV2AcquisitionMethodAsset = value;
                this.OnAssetBookV2AcquisitionMethodAssetChanged();
                this.OnPropertyChanged("AssetBookV2AcquisitionMethodAsset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> _AssetBookV2AcquisitionMethodAsset = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetBookV2AcquisitionMethodAssetChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> value);
        partial void OnAssetBookV2AcquisitionMethodAssetChanged();
        /// <summary>
        /// There are no comments for Property AcquisitionMethodValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> AcquisitionMethodValueModel
        {
            get
            {
                return this._AcquisitionMethodValueModel;
            }
            set
            {
                this.OnAcquisitionMethodValueModelChanging(value);
                this._AcquisitionMethodValueModel = value;
                this.OnAcquisitionMethodValueModelChanged();
                this.OnPropertyChanged("AcquisitionMethodValueModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> _AcquisitionMethodValueModel = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAcquisitionMethodValueModelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> value);
        partial void OnAcquisitionMethodValueModelChanged();
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
