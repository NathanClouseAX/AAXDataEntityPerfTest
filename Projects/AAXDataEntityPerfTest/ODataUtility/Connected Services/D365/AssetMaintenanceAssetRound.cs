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
        /// There are no comments for AssetMaintenanceAssetRoundSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceAssetRoundSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetRound>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceAssetRoundSingle object.
        /// </summary>
        public AssetMaintenanceAssetRoundSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetRoundSingle object.
        /// </summary>
        public AssetMaintenanceAssetRoundSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetRoundSingle object.
        /// </summary>
        public AssetMaintenanceAssetRoundSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetRound> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetSingle AssetMaintenanceAsset
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAsset == null))
                {
                    this._AssetMaintenanceAsset = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetSingle(this.Context, GetPath("AssetMaintenanceAsset"));
                }
                return this._AssetMaintenanceAsset;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetSingle _AssetMaintenanceAsset;
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
        /// There are no comments for AssetMaintenanceJobTrade in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTradeSingle AssetMaintenanceJobTrade
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceJobTrade == null))
                {
                    this._AssetMaintenanceJobTrade = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTradeSingle(this.Context, GetPath("AssetMaintenanceJobTrade"));
                }
                return this._AssetMaintenanceJobTrade;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTradeSingle _AssetMaintenanceJobTrade;
        /// <summary>
        /// There are no comments for AssetMaintenanceRound in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRoundSingle AssetMaintenanceRound
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceRound == null))
                {
                    this._AssetMaintenanceRound = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRoundSingle(this.Context, GetPath("AssetMaintenanceRound"));
                }
                return this._AssetMaintenanceRound;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRoundSingle _AssetMaintenanceRound;
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
        /// There are no comments for AssetMaintenanceAssetRound in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RoundId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RoundId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceAssetRounds")]
    public partial class AssetMaintenanceAssetRound : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceAssetRound object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="roundId">Initial value of RoundId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="periodLength">Initial value of PeriodLength.</param>
        /// <param name="assetMaintenanceAsset">Initial value of AssetMaintenanceAsset.</param>
        /// <param name="assetMaintenanceRound">Initial value of AssetMaintenanceRound.</param>
        /// <param name="assetMaintenanceJobType">Initial value of AssetMaintenanceJobType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceAssetRound CreateAssetMaintenanceAssetRound(string dataAreaId, 
                    string roundId, 
                    long lineNumber, 
                    global::System.DateTimeOffset startDate, 
                    int periodLength, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset assetMaintenanceAsset, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRound assetMaintenanceRound, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType assetMaintenanceJobType)
        {
            AssetMaintenanceAssetRound assetMaintenanceAssetRound = new AssetMaintenanceAssetRound();
            assetMaintenanceAssetRound.dataAreaId = dataAreaId;
            assetMaintenanceAssetRound.RoundId = roundId;
            assetMaintenanceAssetRound.LineNumber = lineNumber;
            assetMaintenanceAssetRound.StartDate = startDate;
            assetMaintenanceAssetRound.PeriodLength = periodLength;
            if ((assetMaintenanceAsset == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceAsset");
            }
            assetMaintenanceAssetRound.AssetMaintenanceAsset = assetMaintenanceAsset;
            if ((assetMaintenanceRound == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceRound");
            }
            assetMaintenanceAssetRound.AssetMaintenanceRound = assetMaintenanceRound;
            if ((assetMaintenanceJobType == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceJobType");
            }
            assetMaintenanceAssetRound.AssetMaintenanceJobType = assetMaintenanceJobType;
            return assetMaintenanceAssetRound;
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
        /// There are no comments for Property RoundId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RoundId
        {
            get
            {
                return this._RoundId;
            }
            set
            {
                this.OnRoundIdChanging(value);
                this._RoundId = value;
                this.OnRoundIdChanged();
                this.OnPropertyChanged("RoundId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoundId;
        partial void OnRoundIdChanging(string value);
        partial void OnRoundIdChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _LineNumber;
        partial void OnLineNumberChanging(long value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceAssetId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MaintenanceAssetId
        {
            get
            {
                return this._MaintenanceAssetId;
            }
            set
            {
                this.OnMaintenanceAssetIdChanging(value);
                this._MaintenanceAssetId = value;
                this.OnMaintenanceAssetIdChanged();
                this.OnPropertyChanged("MaintenanceAssetId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetId;
        partial void OnMaintenanceAssetIdChanging(string value);
        partial void OnMaintenanceAssetIdChanged();
        /// <summary>
        /// There are no comments for Property PeriodType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DayWeekMonthQuarterYear> PeriodType
        {
            get
            {
                return this._PeriodType;
            }
            set
            {
                this.OnPeriodTypeChanging(value);
                this._PeriodType = value;
                this.OnPeriodTypeChanged();
                this.OnPropertyChanged("PeriodType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DayWeekMonthQuarterYear> _PeriodType;
        partial void OnPeriodTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DayWeekMonthQuarterYear> value);
        partial void OnPeriodTypeChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDate;
        partial void OnStartDateChanging(global::System.DateTimeOffset value);
        partial void OnStartDateChanged();
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
        /// There are no comments for Property JobTradeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobTradeId
        {
            get
            {
                return this._JobTradeId;
            }
            set
            {
                this.OnJobTradeIdChanging(value);
                this._JobTradeId = value;
                this.OnJobTradeIdChanged();
                this.OnPropertyChanged("JobTradeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTradeId;
        partial void OnJobTradeIdChanging(string value);
        partial void OnJobTradeIdChanged();
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
        /// There are no comments for Property PeriodLength in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int PeriodLength
        {
            get
            {
                return this._PeriodLength;
            }
            set
            {
                this.OnPeriodLengthChanging(value);
                this._PeriodLength = value;
                this.OnPeriodLengthChanged();
                this.OnPropertyChanged("PeriodLength");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PeriodLength;
        partial void OnPeriodLengthChanging(int value);
        partial void OnPeriodLengthChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset AssetMaintenanceAsset
        {
            get
            {
                return this._AssetMaintenanceAsset;
            }
            set
            {
                this.OnAssetMaintenanceAssetChanging(value);
                this._AssetMaintenanceAsset = value;
                this.OnAssetMaintenanceAssetChanged();
                this.OnPropertyChanged("AssetMaintenanceAsset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset _AssetMaintenanceAsset;
        partial void OnAssetMaintenanceAssetChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset value);
        partial void OnAssetMaintenanceAssetChanged();
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
        /// There are no comments for Property AssetMaintenanceJobTrade in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTrade AssetMaintenanceJobTrade
        {
            get
            {
                return this._AssetMaintenanceJobTrade;
            }
            set
            {
                this.OnAssetMaintenanceJobTradeChanging(value);
                this._AssetMaintenanceJobTrade = value;
                this.OnAssetMaintenanceJobTradeChanged();
                this.OnPropertyChanged("AssetMaintenanceJobTrade");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTrade _AssetMaintenanceJobTrade;
        partial void OnAssetMaintenanceJobTradeChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTrade value);
        partial void OnAssetMaintenanceJobTradeChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceRound in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRound AssetMaintenanceRound
        {
            get
            {
                return this._AssetMaintenanceRound;
            }
            set
            {
                this.OnAssetMaintenanceRoundChanging(value);
                this._AssetMaintenanceRound = value;
                this.OnAssetMaintenanceRoundChanged();
                this.OnPropertyChanged("AssetMaintenanceRound");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRound _AssetMaintenanceRound;
        partial void OnAssetMaintenanceRoundChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRound value);
        partial void OnAssetMaintenanceRoundChanged();
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
