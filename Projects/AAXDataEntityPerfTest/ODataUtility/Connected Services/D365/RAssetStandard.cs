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
        /// There are no comments for RAssetStandardSingle in the schema.
        /// </summary>
    public partial class RAssetStandardSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RAssetStandard>
    {
        /// <summary>
        /// Initialize a new RAssetStandardSingle object.
        /// </summary>
        public RAssetStandardSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RAssetStandardSingle object.
        /// </summary>
        public RAssetStandardSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RAssetStandardSingle object.
        /// </summary>
        public RAssetStandardSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RAssetStandard> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
        /// <summary>
        /// There are no comments for RAssetStandard in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// FAInventoryNumber
    /// ValueModel
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FAInventoryNumber", "ValueModel")]
    [global::Microsoft.OData.Client.EntitySet("RAssetStandards")]
    public partial class RAssetStandard : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RAssetStandard object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="fAInventoryNumber">Initial value of FAInventoryNumber.</param>
        /// <param name="valueModel">Initial value of ValueModel.</param>
        /// <param name="depreciationStartDate">Initial value of DepreciationStartDate.</param>
        /// <param name="scrapValue">Initial value of ScrapValue.</param>
        /// <param name="puttingIntoOperationAmount">Initial value of PuttingIntoOperationAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RAssetStandard CreateRAssetStandard(string dataAreaId, 
                    string fAInventoryNumber, 
                    string valueModel, 
                    global::System.DateTimeOffset depreciationStartDate, 
                    decimal scrapValue, 
                    decimal puttingIntoOperationAmount)
        {
            RAssetStandard rAssetStandard = new RAssetStandard();
            rAssetStandard.dataAreaId = dataAreaId;
            rAssetStandard.FAInventoryNumber = fAInventoryNumber;
            rAssetStandard.ValueModel = valueModel;
            rAssetStandard.DepreciationStartDate = depreciationStartDate;
            rAssetStandard.ScrapValue = scrapValue;
            rAssetStandard.PuttingIntoOperationAmount = puttingIntoOperationAmount;
            return rAssetStandard;
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
        /// There are no comments for Property FAInventoryNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FAInventoryNumber
        {
            get
            {
                return this._FAInventoryNumber;
            }
            set
            {
                this.OnFAInventoryNumberChanging(value);
                this._FAInventoryNumber = value;
                this.OnFAInventoryNumberChanged();
                this.OnPropertyChanged("FAInventoryNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FAInventoryNumber;
        partial void OnFAInventoryNumberChanging(string value);
        partial void OnFAInventoryNumberChanged();
        /// <summary>
        /// There are no comments for Property ValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ValueModel
        {
            get
            {
                return this._ValueModel;
            }
            set
            {
                this.OnValueModelChanging(value);
                this._ValueModel = value;
                this.OnValueModelChanged();
                this.OnPropertyChanged("ValueModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ValueModel;
        partial void OnValueModelChanging(string value);
        partial void OnValueModelChanged();
        /// <summary>
        /// There are no comments for Property DepreciationStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DepreciationStartDate
        {
            get
            {
                return this._DepreciationStartDate;
            }
            set
            {
                this.OnDepreciationStartDateChanging(value);
                this._DepreciationStartDate = value;
                this.OnDepreciationStartDateChanged();
                this.OnPropertyChanged("DepreciationStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DepreciationStartDate;
        partial void OnDepreciationStartDateChanging(global::System.DateTimeOffset value);
        partial void OnDepreciationStartDateChanged();
        /// <summary>
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this.OnCurrencyChanging(value);
                this._Currency = value;
                this.OnCurrencyChanged();
                this.OnPropertyChanged("Currency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Currency;
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        /// <summary>
        /// There are no comments for Property DimensionOfRentedFADisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionOfRentedFADisplayValue
        {
            get
            {
                return this._DimensionOfRentedFADisplayValue;
            }
            set
            {
                this.OnDimensionOfRentedFADisplayValueChanging(value);
                this._DimensionOfRentedFADisplayValue = value;
                this.OnDimensionOfRentedFADisplayValueChanged();
                this.OnPropertyChanged("DimensionOfRentedFADisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionOfRentedFADisplayValue;
        partial void OnDimensionOfRentedFADisplayValueChanging(string value);
        partial void OnDimensionOfRentedFADisplayValueChanged();
        /// <summary>
        /// There are no comments for Property ScrapValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ScrapValue
        {
            get
            {
                return this._ScrapValue;
            }
            set
            {
                this.OnScrapValueChanging(value);
                this._ScrapValue = value;
                this.OnScrapValueChanged();
                this.OnPropertyChanged("ScrapValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ScrapValue;
        partial void OnScrapValueChanging(decimal value);
        partial void OnScrapValueChanged();
        /// <summary>
        /// There are no comments for Property DepreciationSubgroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DepreciationSubgroup
        {
            get
            {
                return this._DepreciationSubgroup;
            }
            set
            {
                this.OnDepreciationSubgroupChanging(value);
                this._DepreciationSubgroup = value;
                this.OnDepreciationSubgroupChanged();
                this.OnPropertyChanged("DepreciationSubgroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepreciationSubgroup;
        partial void OnDepreciationSubgroupChanging(string value);
        partial void OnDepreciationSubgroupChanged();
        /// <summary>
        /// There are no comments for Property PuttingIntoOperationAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PuttingIntoOperationAmount
        {
            get
            {
                return this._PuttingIntoOperationAmount;
            }
            set
            {
                this.OnPuttingIntoOperationAmountChanging(value);
                this._PuttingIntoOperationAmount = value;
                this.OnPuttingIntoOperationAmountChanged();
                this.OnPropertyChanged("PuttingIntoOperationAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PuttingIntoOperationAmount;
        partial void OnPuttingIntoOperationAmountChanging(decimal value);
        partial void OnPuttingIntoOperationAmountChanged();
        /// <summary>
        /// There are no comments for Property DepreciationGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DepreciationGroup
        {
            get
            {
                return this._DepreciationGroup;
            }
            set
            {
                this.OnDepreciationGroupChanging(value);
                this._DepreciationGroup = value;
                this.OnDepreciationGroupChanged();
                this.OnPropertyChanged("DepreciationGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepreciationGroup;
        partial void OnDepreciationGroupChanging(string value);
        partial void OnDepreciationGroupChanged();
        /// <summary>
        /// There are no comments for Property Depreciation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Depreciation
        {
            get
            {
                return this._Depreciation;
            }
            set
            {
                this.OnDepreciationChanging(value);
                this._Depreciation = value;
                this.OnDepreciationChanged();
                this.OnPropertyChanged("Depreciation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Depreciation;
        partial void OnDepreciationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDepreciationChanged();
        /// <summary>
        /// There are no comments for Property DefaultFinancialDimensionsDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultFinancialDimensionsDisplayValue
        {
            get
            {
                return this._DefaultFinancialDimensionsDisplayValue;
            }
            set
            {
                this.OnDefaultFinancialDimensionsDisplayValueChanging(value);
                this._DefaultFinancialDimensionsDisplayValue = value;
                this.OnDefaultFinancialDimensionsDisplayValueChanged();
                this.OnPropertyChanged("DefaultFinancialDimensionsDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultFinancialDimensionsDisplayValue;
        partial void OnDefaultFinancialDimensionsDisplayValueChanging(string value);
        partial void OnDefaultFinancialDimensionsDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property PostingProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PostingProfile
        {
            get
            {
                return this._PostingProfile;
            }
            set
            {
                this.OnPostingProfileChanging(value);
                this._PostingProfile = value;
                this.OnPostingProfileChanged();
                this.OnPropertyChanged("PostingProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PostingProfile;
        partial void OnPostingProfileChanging(string value);
        partial void OnPostingProfileChanged();
        /// <summary>
        /// There are no comments for Property LendingPostingProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LendingPostingProfile
        {
            get
            {
                return this._LendingPostingProfile;
            }
            set
            {
                this.OnLendingPostingProfileChanging(value);
                this._LendingPostingProfile = value;
                this.OnLendingPostingProfileChanged();
                this.OnPropertyChanged("LendingPostingProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LendingPostingProfile;
        partial void OnLendingPostingProfileChanging(string value);
        partial void OnLendingPostingProfileChanged();
        /// <summary>
        /// There are no comments for Property DepreciationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DepreciationMethod
        {
            get
            {
                return this._DepreciationMethod;
            }
            set
            {
                this.OnDepreciationMethodChanging(value);
                this._DepreciationMethod = value;
                this.OnDepreciationMethodChanged();
                this.OnPropertyChanged("DepreciationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepreciationMethod;
        partial void OnDepreciationMethodChanging(string value);
        partial void OnDepreciationMethodChanged();
        /// <summary>
        /// There are no comments for Property AnalysisCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AnalysisCode
        {
            get
            {
                return this._AnalysisCode;
            }
            set
            {
                this.OnAnalysisCodeChanging(value);
                this._AnalysisCode = value;
                this.OnAnalysisCodeChanged();
                this.OnPropertyChanged("AnalysisCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AnalysisCode;
        partial void OnAnalysisCodeChanging(string value);
        partial void OnAnalysisCodeChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
