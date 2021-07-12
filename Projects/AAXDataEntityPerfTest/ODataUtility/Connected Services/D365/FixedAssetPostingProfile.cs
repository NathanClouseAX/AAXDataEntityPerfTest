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
        /// There are no comments for FixedAssetPostingProfileSingle in the schema.
        /// </summary>
    public partial class FixedAssetPostingProfileSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FixedAssetPostingProfile>
    {
        /// <summary>
        /// Initialize a new FixedAssetPostingProfileSingle object.
        /// </summary>
        public FixedAssetPostingProfileSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FixedAssetPostingProfileSingle object.
        /// </summary>
        public FixedAssetPostingProfileSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FixedAssetPostingProfileSingle object.
        /// </summary>
        public FixedAssetPostingProfileSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FixedAssetPostingProfile> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetParameter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetParameterSingle AssetParameter
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetParameter == null))
                {
                    this._AssetParameter = new global::Microsoft.Dynamics.DataEntities.AssetParameterSingle(this.Context, GetPath("AssetParameter"));
                }
                return this._AssetParameter;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetParameterSingle _AssetParameter;
        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
        /// <summary>
        /// There are no comments for AssetPostingProfileAssetGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.FixedAssetGroupSingle AssetPostingProfileAssetGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetPostingProfileAssetGroup == null))
                {
                    this._AssetPostingProfileAssetGroup = new global::Microsoft.Dynamics.DataEntities.FixedAssetGroupSingle(this.Context, GetPath("AssetPostingProfileAssetGroup"));
                }
                return this._AssetPostingProfileAssetGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FixedAssetGroupSingle _AssetPostingProfileAssetGroup;
        /// <summary>
        /// There are no comments for AssetPostingProfileValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ValueModelSetupSingle AssetPostingProfileValueModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetPostingProfileValueModel == null))
                {
                    this._AssetPostingProfileValueModel = new global::Microsoft.Dynamics.DataEntities.ValueModelSetupSingle(this.Context, GetPath("AssetPostingProfileValueModel"));
                }
                return this._AssetPostingProfileValueModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ValueModelSetupSingle _AssetPostingProfileValueModel;
        /// <summary>
        /// There are no comments for AssetPostingProfileAssetNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.FixedAssetSingle AssetPostingProfileAssetNumber
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetPostingProfileAssetNumber == null))
                {
                    this._AssetPostingProfileAssetNumber = new global::Microsoft.Dynamics.DataEntities.FixedAssetSingle(this.Context, GetPath("AssetPostingProfileAssetNumber"));
                }
                return this._AssetPostingProfileAssetNumber;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FixedAssetSingle _AssetPostingProfileAssetNumber;
    }
        /// <summary>
        /// There are no comments for FixedAssetPostingProfile in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PostingProfileId
    /// TransactionType
    /// ValueModelId
    /// AccountGroupings
    /// AccountRelation
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PostingProfileId", "TransactionType", "ValueModelId", "AccountGroupings", "AccountRelation")]
    [global::Microsoft.OData.Client.EntitySet("FixedAssetPostingProfiles")]
    public partial class FixedAssetPostingProfile : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FixedAssetPostingProfile object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="postingProfileId">Initial value of PostingProfileId.</param>
        /// <param name="valueModelId">Initial value of ValueModelId.</param>
        /// <param name="accountRelation">Initial value of AccountRelation.</param>
        /// <param name="assetPostingProfileValueModel">Initial value of AssetPostingProfileValueModel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FixedAssetPostingProfile CreateFixedAssetPostingProfile(string dataAreaId, string postingProfileId, string valueModelId, string accountRelation, global::Microsoft.Dynamics.DataEntities.ValueModelSetup assetPostingProfileValueModel)
        {
            FixedAssetPostingProfile fixedAssetPostingProfile = new FixedAssetPostingProfile();
            fixedAssetPostingProfile.dataAreaId = dataAreaId;
            fixedAssetPostingProfile.PostingProfileId = postingProfileId;
            fixedAssetPostingProfile.ValueModelId = valueModelId;
            fixedAssetPostingProfile.AccountRelation = accountRelation;
            if ((assetPostingProfileValueModel == null))
            {
                throw new global::System.ArgumentNullException("assetPostingProfileValueModel");
            }
            fixedAssetPostingProfile.AssetPostingProfileValueModel = assetPostingProfileValueModel;
            return fixedAssetPostingProfile;
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
        /// There are no comments for Property PostingProfileId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PostingProfileId
        {
            get
            {
                return this._PostingProfileId;
            }
            set
            {
                this.OnPostingProfileIdChanging(value);
                this._PostingProfileId = value;
                this.OnPostingProfileIdChanged();
                this.OnPropertyChanged("PostingProfileId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PostingProfileId;
        partial void OnPostingProfileIdChanging(string value);
        partial void OnPostingProfileIdChanged();
        /// <summary>
        /// There are no comments for Property TransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetTransType> TransactionType
        {
            get
            {
                return this._TransactionType;
            }
            set
            {
                this.OnTransactionTypeChanging(value);
                this._TransactionType = value;
                this.OnTransactionTypeChanged();
                this.OnPropertyChanged("TransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetTransType> _TransactionType;
        partial void OnTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetTransType> value);
        partial void OnTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property ValueModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ValueModelId
        {
            get
            {
                return this._ValueModelId;
            }
            set
            {
                this.OnValueModelIdChanging(value);
                this._ValueModelId = value;
                this.OnValueModelIdChanged();
                this.OnPropertyChanged("ValueModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ValueModelId;
        partial void OnValueModelIdChanging(string value);
        partial void OnValueModelIdChanged();
        /// <summary>
        /// There are no comments for Property AccountGroupings in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TableGroupAll> AccountGroupings
        {
            get
            {
                return this._AccountGroupings;
            }
            set
            {
                this.OnAccountGroupingsChanging(value);
                this._AccountGroupings = value;
                this.OnAccountGroupingsChanged();
                this.OnPropertyChanged("AccountGroupings");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TableGroupAll> _AccountGroupings;
        partial void OnAccountGroupingsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TableGroupAll> value);
        partial void OnAccountGroupingsChanged();
        /// <summary>
        /// There are no comments for Property AccountRelation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountRelation
        {
            get
            {
                return this._AccountRelation;
            }
            set
            {
                this.OnAccountRelationChanging(value);
                this._AccountRelation = value;
                this.OnAccountRelationChanged();
                this.OnPropertyChanged("AccountRelation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountRelation;
        partial void OnAccountRelationChanging(string value);
        partial void OnAccountRelationChanged();
        /// <summary>
        /// There are no comments for Property AllocationRuleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AllocationRuleId
        {
            get
            {
                return this._AllocationRuleId;
            }
            set
            {
                this.OnAllocationRuleIdChanging(value);
                this._AllocationRuleId = value;
                this.OnAllocationRuleIdChanged();
                this.OnPropertyChanged("AllocationRuleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AllocationRuleId;
        partial void OnAllocationRuleIdChanging(string value);
        partial void OnAllocationRuleIdChanged();
        /// <summary>
        /// There are no comments for Property MainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccountIdDisplayValue
        {
            get
            {
                return this._MainAccountIdDisplayValue;
            }
            set
            {
                this.OnMainAccountIdDisplayValueChanging(value);
                this._MainAccountIdDisplayValue = value;
                this.OnMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("MainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountIdDisplayValue;
        partial void OnMainAccountIdDisplayValueChanging(string value);
        partial void OnMainAccountIdDisplayValueChanged();
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
        /// There are no comments for Property OffsetMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OffsetMainAccountIdDisplayValue
        {
            get
            {
                return this._OffsetMainAccountIdDisplayValue;
            }
            set
            {
                this.OnOffsetMainAccountIdDisplayValueChanging(value);
                this._OffsetMainAccountIdDisplayValue = value;
                this.OnOffsetMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("OffsetMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OffsetMainAccountIdDisplayValue;
        partial void OnOffsetMainAccountIdDisplayValueChanging(string value);
        partial void OnOffsetMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property AssetParameter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetParameter AssetParameter
        {
            get
            {
                return this._AssetParameter;
            }
            set
            {
                this.OnAssetParameterChanging(value);
                this._AssetParameter = value;
                this.OnAssetParameterChanged();
                this.OnPropertyChanged("AssetParameter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetParameter _AssetParameter;
        partial void OnAssetParameterChanging(global::Microsoft.Dynamics.DataEntities.AssetParameter value);
        partial void OnAssetParameterChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
        /// <summary>
        /// There are no comments for Property AssetPostingProfileAssetGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.FixedAssetGroup AssetPostingProfileAssetGroup
        {
            get
            {
                return this._AssetPostingProfileAssetGroup;
            }
            set
            {
                this.OnAssetPostingProfileAssetGroupChanging(value);
                this._AssetPostingProfileAssetGroup = value;
                this.OnAssetPostingProfileAssetGroupChanged();
                this.OnPropertyChanged("AssetPostingProfileAssetGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FixedAssetGroup _AssetPostingProfileAssetGroup;
        partial void OnAssetPostingProfileAssetGroupChanging(global::Microsoft.Dynamics.DataEntities.FixedAssetGroup value);
        partial void OnAssetPostingProfileAssetGroupChanged();
        /// <summary>
        /// There are no comments for Property AssetPostingProfileValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ValueModelSetup AssetPostingProfileValueModel
        {
            get
            {
                return this._AssetPostingProfileValueModel;
            }
            set
            {
                this.OnAssetPostingProfileValueModelChanging(value);
                this._AssetPostingProfileValueModel = value;
                this.OnAssetPostingProfileValueModelChanged();
                this.OnPropertyChanged("AssetPostingProfileValueModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ValueModelSetup _AssetPostingProfileValueModel;
        partial void OnAssetPostingProfileValueModelChanging(global::Microsoft.Dynamics.DataEntities.ValueModelSetup value);
        partial void OnAssetPostingProfileValueModelChanged();
        /// <summary>
        /// There are no comments for Property AssetPostingProfileAssetNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.FixedAsset AssetPostingProfileAssetNumber
        {
            get
            {
                return this._AssetPostingProfileAssetNumber;
            }
            set
            {
                this.OnAssetPostingProfileAssetNumberChanging(value);
                this._AssetPostingProfileAssetNumber = value;
                this.OnAssetPostingProfileAssetNumberChanged();
                this.OnPropertyChanged("AssetPostingProfileAssetNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FixedAsset _AssetPostingProfileAssetNumber;
        partial void OnAssetPostingProfileAssetNumberChanging(global::Microsoft.Dynamics.DataEntities.FixedAsset value);
        partial void OnAssetPostingProfileAssetNumberChanged();
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
