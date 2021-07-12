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
        /// There are no comments for LeaseIndexRevaluationDetailSingle in the schema.
        /// </summary>
    public partial class LeaseIndexRevaluationDetailSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LeaseIndexRevaluationDetail>
    {
        /// <summary>
        /// Initialize a new LeaseIndexRevaluationDetailSingle object.
        /// </summary>
        public LeaseIndexRevaluationDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeaseIndexRevaluationDetailSingle object.
        /// </summary>
        public LeaseIndexRevaluationDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeaseIndexRevaluationDetailSingle object.
        /// </summary>
        public LeaseIndexRevaluationDetailSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LeaseIndexRevaluationDetail> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LiabilityAccountCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle LiabilityAccountCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LiabilityAccountCombination == null))
                {
                    this._LiabilityAccountCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("LiabilityAccountCombination"));
                }
                return this._LiabilityAccountCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _LiabilityAccountCombination;
        /// <summary>
        /// There are no comments for AssetAccountCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle AssetAccountCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetAccountCombination == null))
                {
                    this._AssetAccountCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("AssetAccountCombination"));
                }
                return this._AssetAccountCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _AssetAccountCombination;
    }
        /// <summary>
        /// There are no comments for LeaseIndexRevaluationDetail in the schema.
        /// </summary>
    /// <KeyProperties>
    /// LeaseId
    /// LegalEntity
    /// ProcessId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LeaseId", "LegalEntity", "ProcessId")]
    [global::Microsoft.OData.Client.EntitySet("LeaseIndexRevaluationDetails")]
    public partial class LeaseIndexRevaluationDetail : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeaseIndexRevaluationDetail object.
        /// </summary>
        /// <param name="leaseId">Initial value of LeaseId.</param>
        /// <param name="legalEntity">Initial value of LegalEntity.</param>
        /// <param name="processId">Initial value of ProcessId.</param>
        /// <param name="newPaymentAmount">Initial value of NewPaymentAmount.</param>
        /// <param name="newIndexRate">Initial value of NewIndexRate.</param>
        /// <param name="indexRateDate">Initial value of IndexRateDate.</param>
        /// <param name="oldIndexRate">Initial value of OldIndexRate.</param>
        /// <param name="assetAdjustment">Initial value of AssetAdjustment.</param>
        /// <param name="liabilityAdjustment">Initial value of LiabilityAdjustment.</param>
        /// <param name="variablePayment">Initial value of VariablePayment.</param>
        /// <param name="revaluationDate">Initial value of RevaluationDate.</param>
        /// <param name="numberOfChangeLines">Initial value of NumberOfChangeLines.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeaseIndexRevaluationDetail CreateLeaseIndexRevaluationDetail(string leaseId, 
                    string legalEntity, 
                    global::System.Guid processId, 
                    decimal newPaymentAmount, 
                    decimal newIndexRate, 
                    global::System.DateTimeOffset indexRateDate, 
                    decimal oldIndexRate, 
                    decimal assetAdjustment, 
                    decimal liabilityAdjustment, 
                    decimal variablePayment, 
                    global::System.DateTimeOffset revaluationDate, 
                    int numberOfChangeLines)
        {
            LeaseIndexRevaluationDetail leaseIndexRevaluationDetail = new LeaseIndexRevaluationDetail();
            leaseIndexRevaluationDetail.LeaseId = leaseId;
            leaseIndexRevaluationDetail.LegalEntity = legalEntity;
            leaseIndexRevaluationDetail.ProcessId = processId;
            leaseIndexRevaluationDetail.NewPaymentAmount = newPaymentAmount;
            leaseIndexRevaluationDetail.NewIndexRate = newIndexRate;
            leaseIndexRevaluationDetail.IndexRateDate = indexRateDate;
            leaseIndexRevaluationDetail.OldIndexRate = oldIndexRate;
            leaseIndexRevaluationDetail.AssetAdjustment = assetAdjustment;
            leaseIndexRevaluationDetail.LiabilityAdjustment = liabilityAdjustment;
            leaseIndexRevaluationDetail.VariablePayment = variablePayment;
            leaseIndexRevaluationDetail.RevaluationDate = revaluationDate;
            leaseIndexRevaluationDetail.NumberOfChangeLines = numberOfChangeLines;
            return leaseIndexRevaluationDetail;
        }
        /// <summary>
        /// There are no comments for Property LeaseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LeaseId
        {
            get
            {
                return this._LeaseId;
            }
            set
            {
                this.OnLeaseIdChanging(value);
                this._LeaseId = value;
                this.OnLeaseIdChanged();
                this.OnPropertyChanged("LeaseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LeaseId;
        partial void OnLeaseIdChanging(string value);
        partial void OnLeaseIdChanged();
        /// <summary>
        /// There are no comments for Property LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntity
        {
            get
            {
                return this._LegalEntity;
            }
            set
            {
                this.OnLegalEntityChanging(value);
                this._LegalEntity = value;
                this.OnLegalEntityChanged();
                this.OnPropertyChanged("LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntity;
        partial void OnLegalEntityChanging(string value);
        partial void OnLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property ProcessId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid ProcessId
        {
            get
            {
                return this._ProcessId;
            }
            set
            {
                this.OnProcessIdChanging(value);
                this._ProcessId = value;
                this.OnProcessIdChanged();
                this.OnPropertyChanged("ProcessId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ProcessId;
        partial void OnProcessIdChanging(global::System.Guid value);
        partial void OnProcessIdChanged();
        /// <summary>
        /// There are no comments for Property NewPaymentAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal NewPaymentAmount
        {
            get
            {
                return this._NewPaymentAmount;
            }
            set
            {
                this.OnNewPaymentAmountChanging(value);
                this._NewPaymentAmount = value;
                this.OnNewPaymentAmountChanged();
                this.OnPropertyChanged("NewPaymentAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _NewPaymentAmount;
        partial void OnNewPaymentAmountChanging(decimal value);
        partial void OnNewPaymentAmountChanged();
        /// <summary>
        /// There are no comments for Property NewIndexRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal NewIndexRate
        {
            get
            {
                return this._NewIndexRate;
            }
            set
            {
                this.OnNewIndexRateChanging(value);
                this._NewIndexRate = value;
                this.OnNewIndexRateChanged();
                this.OnPropertyChanged("NewIndexRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _NewIndexRate;
        partial void OnNewIndexRateChanging(decimal value);
        partial void OnNewIndexRateChanged();
        /// <summary>
        /// There are no comments for Property IndexRateDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset IndexRateDate
        {
            get
            {
                return this._IndexRateDate;
            }
            set
            {
                this.OnIndexRateDateChanging(value);
                this._IndexRateDate = value;
                this.OnIndexRateDateChanged();
                this.OnPropertyChanged("IndexRateDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _IndexRateDate;
        partial void OnIndexRateDateChanging(global::System.DateTimeOffset value);
        partial void OnIndexRateDateChanged();
        /// <summary>
        /// There are no comments for Property OldIndexRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OldIndexRate
        {
            get
            {
                return this._OldIndexRate;
            }
            set
            {
                this.OnOldIndexRateChanging(value);
                this._OldIndexRate = value;
                this.OnOldIndexRateChanged();
                this.OnPropertyChanged("OldIndexRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OldIndexRate;
        partial void OnOldIndexRateChanging(decimal value);
        partial void OnOldIndexRateChanged();
        /// <summary>
        /// There are no comments for Property LeaseType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLeaseType> LeaseType
        {
            get
            {
                return this._LeaseType;
            }
            set
            {
                this.OnLeaseTypeChanging(value);
                this._LeaseType = value;
                this.OnLeaseTypeChanged();
                this.OnPropertyChanged("LeaseType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLeaseType> _LeaseType;
        partial void OnLeaseTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLeaseType> value);
        partial void OnLeaseTypeChanged();
        /// <summary>
        /// There are no comments for Property AssetAdjustment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AssetAdjustment
        {
            get
            {
                return this._AssetAdjustment;
            }
            set
            {
                this.OnAssetAdjustmentChanging(value);
                this._AssetAdjustment = value;
                this.OnAssetAdjustmentChanged();
                this.OnPropertyChanged("AssetAdjustment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AssetAdjustment;
        partial void OnAssetAdjustmentChanging(decimal value);
        partial void OnAssetAdjustmentChanged();
        /// <summary>
        /// There are no comments for Property LiabilityAdjustment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LiabilityAdjustment
        {
            get
            {
                return this._LiabilityAdjustment;
            }
            set
            {
                this.OnLiabilityAdjustmentChanging(value);
                this._LiabilityAdjustment = value;
                this.OnLiabilityAdjustmentChanged();
                this.OnPropertyChanged("LiabilityAdjustment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LiabilityAdjustment;
        partial void OnLiabilityAdjustmentChanging(decimal value);
        partial void OnLiabilityAdjustmentChanged();
        /// <summary>
        /// There are no comments for Property VariablePayment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal VariablePayment
        {
            get
            {
                return this._VariablePayment;
            }
            set
            {
                this.OnVariablePaymentChanging(value);
                this._VariablePayment = value;
                this.OnVariablePaymentChanged();
                this.OnPropertyChanged("VariablePayment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _VariablePayment;
        partial void OnVariablePaymentChanging(decimal value);
        partial void OnVariablePaymentChanged();
        /// <summary>
        /// There are no comments for Property RevaluationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset RevaluationDate
        {
            get
            {
                return this._RevaluationDate;
            }
            set
            {
                this.OnRevaluationDateChanging(value);
                this._RevaluationDate = value;
                this.OnRevaluationDateChanged();
                this.OnPropertyChanged("RevaluationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _RevaluationDate;
        partial void OnRevaluationDateChanging(global::System.DateTimeOffset value);
        partial void OnRevaluationDateChanged();
        /// <summary>
        /// There are no comments for Property Processed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Processed
        {
            get
            {
                return this._Processed;
            }
            set
            {
                this.OnProcessedChanging(value);
                this._Processed = value;
                this.OnProcessedChanged();
                this.OnPropertyChanged("Processed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Processed;
        partial void OnProcessedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnProcessedChanged();
        /// <summary>
        /// There are no comments for Property NumberOfChangeLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int NumberOfChangeLines
        {
            get
            {
                return this._NumberOfChangeLines;
            }
            set
            {
                this.OnNumberOfChangeLinesChanging(value);
                this._NumberOfChangeLines = value;
                this.OnNumberOfChangeLinesChanged();
                this.OnPropertyChanged("NumberOfChangeLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NumberOfChangeLines;
        partial void OnNumberOfChangeLinesChanging(int value);
        partial void OnNumberOfChangeLinesChanged();
        /// <summary>
        /// There are no comments for Property LiabilityAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LiabilityAccountDisplayValue
        {
            get
            {
                return this._LiabilityAccountDisplayValue;
            }
            set
            {
                this.OnLiabilityAccountDisplayValueChanging(value);
                this._LiabilityAccountDisplayValue = value;
                this.OnLiabilityAccountDisplayValueChanged();
                this.OnPropertyChanged("LiabilityAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LiabilityAccountDisplayValue;
        partial void OnLiabilityAccountDisplayValueChanging(string value);
        partial void OnLiabilityAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property AssetAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AssetAccountDisplayValue
        {
            get
            {
                return this._AssetAccountDisplayValue;
            }
            set
            {
                this.OnAssetAccountDisplayValueChanging(value);
                this._AssetAccountDisplayValue = value;
                this.OnAssetAccountDisplayValueChanged();
                this.OnPropertyChanged("AssetAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AssetAccountDisplayValue;
        partial void OnAssetAccountDisplayValueChanging(string value);
        partial void OnAssetAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property LiabilityAccountCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination LiabilityAccountCombination
        {
            get
            {
                return this._LiabilityAccountCombination;
            }
            set
            {
                this.OnLiabilityAccountCombinationChanging(value);
                this._LiabilityAccountCombination = value;
                this.OnLiabilityAccountCombinationChanged();
                this.OnPropertyChanged("LiabilityAccountCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _LiabilityAccountCombination;
        partial void OnLiabilityAccountCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnLiabilityAccountCombinationChanged();
        /// <summary>
        /// There are no comments for Property AssetAccountCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination AssetAccountCombination
        {
            get
            {
                return this._AssetAccountCombination;
            }
            set
            {
                this.OnAssetAccountCombinationChanging(value);
                this._AssetAccountCombination = value;
                this.OnAssetAccountCombinationChanged();
                this.OnPropertyChanged("AssetAccountCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _AssetAccountCombination;
        partial void OnAssetAccountCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnAssetAccountCombinationChanged();
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
