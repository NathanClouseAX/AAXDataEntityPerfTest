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
        /// There are no comments for AssetProvisionTypeSingle in the schema.
        /// </summary>
    public partial class AssetProvisionTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetProvisionType>
    {
        /// <summary>
        /// Initialize a new AssetProvisionTypeSingle object.
        /// </summary>
        public AssetProvisionTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetProvisionTypeSingle object.
        /// </summary>
        public AssetProvisionTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetProvisionTypeSingle object.
        /// </summary>
        public AssetProvisionTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetProvisionType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FixedAssetValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> FixedAssetValueModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FixedAssetValueModel == null))
                {
                    this._FixedAssetValueModel = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel>(GetPath("FixedAssetValueModel"));
                }
                return this._FixedAssetValueModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> _FixedAssetValueModel;
        /// <summary>
        /// There are no comments for ProvisionTypeValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> ProvisionTypeValueModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProvisionTypeValueModel == null))
                {
                    this._ProvisionTypeValueModel = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel>(GetPath("ProvisionTypeValueModel"));
                }
                return this._ProvisionTypeValueModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> _ProvisionTypeValueModel;
        /// <summary>
        /// There are no comments for AssetBookV2ProvisionTypeAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> AssetBookV2ProvisionTypeAsset
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetBookV2ProvisionTypeAsset == null))
                {
                    this._AssetBookV2ProvisionTypeAsset = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2>(GetPath("AssetBookV2ProvisionTypeAsset"));
                }
                return this._AssetBookV2ProvisionTypeAsset;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> _AssetBookV2ProvisionTypeAsset;
        /// <summary>
        /// There are no comments for FixedAssetBookV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> FixedAssetBookV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FixedAssetBookV2 == null))
                {
                    this._FixedAssetBookV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2>(GetPath("FixedAssetBookV2"));
                }
                return this._FixedAssetBookV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> _FixedAssetBookV2;
    }
        /// <summary>
        /// There are no comments for AssetProvisionType in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TypeId")]
    [global::Microsoft.OData.Client.EntitySet("AssetProvisionTypes")]
    public partial class AssetProvisionType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetProvisionType object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="typeId">Initial value of TypeId.</param>
        /// <param name="lengthOfOwnership">Initial value of LengthOfOwnership.</param>
        /// <param name="months">Initial value of Months.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetProvisionType CreateAssetProvisionType(string dataAreaId, string typeId, int lengthOfOwnership, int months)
        {
            AssetProvisionType assetProvisionType = new AssetProvisionType();
            assetProvisionType.dataAreaId = dataAreaId;
            assetProvisionType.TypeId = typeId;
            assetProvisionType.LengthOfOwnership = lengthOfOwnership;
            assetProvisionType.Months = months;
            return assetProvisionType;
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
        /// There are no comments for Property TypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TypeId
        {
            get
            {
                return this._TypeId;
            }
            set
            {
                this.OnTypeIdChanging(value);
                this._TypeId = value;
                this.OnTypeIdChanged();
                this.OnPropertyChanged("TypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TypeId;
        partial void OnTypeIdChanging(string value);
        partial void OnTypeIdChanged();
        /// <summary>
        /// There are no comments for Property LengthOfOwnership in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int LengthOfOwnership
        {
            get
            {
                return this._LengthOfOwnership;
            }
            set
            {
                this.OnLengthOfOwnershipChanging(value);
                this._LengthOfOwnership = value;
                this.OnLengthOfOwnershipChanged();
                this.OnPropertyChanged("LengthOfOwnership");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _LengthOfOwnership;
        partial void OnLengthOfOwnershipChanging(int value);
        partial void OnLengthOfOwnershipChanged();
        /// <summary>
        /// There are no comments for Property Months in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Months
        {
            get
            {
                return this._Months;
            }
            set
            {
                this.OnMonthsChanging(value);
                this._Months = value;
                this.OnMonthsChanged();
                this.OnPropertyChanged("Months");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Months;
        partial void OnMonthsChanging(int value);
        partial void OnMonthsChanged();
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
        /// There are no comments for Property FixedAssetValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> FixedAssetValueModel
        {
            get
            {
                return this._FixedAssetValueModel;
            }
            set
            {
                this.OnFixedAssetValueModelChanging(value);
                this._FixedAssetValueModel = value;
                this.OnFixedAssetValueModelChanged();
                this.OnPropertyChanged("FixedAssetValueModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> _FixedAssetValueModel = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFixedAssetValueModelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> value);
        partial void OnFixedAssetValueModelChanged();
        /// <summary>
        /// There are no comments for Property ProvisionTypeValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> ProvisionTypeValueModel
        {
            get
            {
                return this._ProvisionTypeValueModel;
            }
            set
            {
                this.OnProvisionTypeValueModelChanging(value);
                this._ProvisionTypeValueModel = value;
                this.OnProvisionTypeValueModelChanged();
                this.OnPropertyChanged("ProvisionTypeValueModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> _ProvisionTypeValueModel = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProvisionTypeValueModelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetValueModel> value);
        partial void OnProvisionTypeValueModelChanged();
        /// <summary>
        /// There are no comments for Property AssetBookV2ProvisionTypeAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> AssetBookV2ProvisionTypeAsset
        {
            get
            {
                return this._AssetBookV2ProvisionTypeAsset;
            }
            set
            {
                this.OnAssetBookV2ProvisionTypeAssetChanging(value);
                this._AssetBookV2ProvisionTypeAsset = value;
                this.OnAssetBookV2ProvisionTypeAssetChanged();
                this.OnPropertyChanged("AssetBookV2ProvisionTypeAsset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> _AssetBookV2ProvisionTypeAsset = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetBookV2ProvisionTypeAssetChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> value);
        partial void OnAssetBookV2ProvisionTypeAssetChanged();
        /// <summary>
        /// There are no comments for Property FixedAssetBookV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> FixedAssetBookV2
        {
            get
            {
                return this._FixedAssetBookV2;
            }
            set
            {
                this.OnFixedAssetBookV2Changing(value);
                this._FixedAssetBookV2 = value;
                this.OnFixedAssetBookV2Changed();
                this.OnPropertyChanged("FixedAssetBookV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> _FixedAssetBookV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFixedAssetBookV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookV2> value);
        partial void OnFixedAssetBookV2Changed();
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
