﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 12/8/2020 7:45:22 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for RetailStoreTenderTypeCardSingle in the schema.
        /// </summary>
    public partial class RetailStoreTenderTypeCardSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStoreTenderTypeCard>
    {
        /// <summary>
        /// Initialize a new RetailStoreTenderTypeCardSingle object.
        /// </summary>
        public RetailStoreTenderTypeCardSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailStoreTenderTypeCardSingle object.
        /// </summary>
        public RetailStoreTenderTypeCardSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailStoreTenderTypeCardSingle object.
        /// </summary>
        public RetailStoreTenderTypeCardSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStoreTenderTypeCard> query)
            : base(query) {}

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
    }
        /// <summary>
        /// There are no comments for RetailStoreTenderTypeCard in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TenderTypeId
    /// CardTypeId
    /// OMOperatingUnitNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TenderTypeId", "CardTypeId", "OMOperatingUnitNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailStoreTenderTypeCards")]
    public partial class RetailStoreTenderTypeCard : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailStoreTenderTypeCard object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="tenderTypeId">Initial value of TenderTypeId.</param>
        /// <param name="cardTypeId">Initial value of CardTypeId.</param>
        /// <param name="oMOperatingUnitNumber">Initial value of OMOperatingUnitNumber.</param>
        /// <param name="cardFeeMax">Initial value of CardFeeMax.</param>
        /// <param name="cashBackLimit">Initial value of CashBackLimit.</param>
        /// <param name="cardInquiryFee">Initial value of CardInquiryFee.</param>
        /// <param name="maxNormalDifferenceAmount">Initial value of MaxNormalDifferenceAmount.</param>
        /// <param name="cardFee">Initial value of CardFee.</param>
        /// <param name="cardFeeMin">Initial value of CardFeeMin.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailStoreTenderTypeCard CreateRetailStoreTenderTypeCard(string dataAreaId, 
                    string tenderTypeId, 
                    string cardTypeId, 
                    string oMOperatingUnitNumber, 
                    decimal cardFeeMax, 
                    decimal cashBackLimit, 
                    decimal cardInquiryFee, 
                    decimal maxNormalDifferenceAmount, 
                    decimal cardFee, 
                    decimal cardFeeMin)
        {
            RetailStoreTenderTypeCard retailStoreTenderTypeCard = new RetailStoreTenderTypeCard();
            retailStoreTenderTypeCard.dataAreaId = dataAreaId;
            retailStoreTenderTypeCard.TenderTypeId = tenderTypeId;
            retailStoreTenderTypeCard.CardTypeId = cardTypeId;
            retailStoreTenderTypeCard.OMOperatingUnitNumber = oMOperatingUnitNumber;
            retailStoreTenderTypeCard.CardFeeMax = cardFeeMax;
            retailStoreTenderTypeCard.CashBackLimit = cashBackLimit;
            retailStoreTenderTypeCard.CardInquiryFee = cardInquiryFee;
            retailStoreTenderTypeCard.MaxNormalDifferenceAmount = maxNormalDifferenceAmount;
            retailStoreTenderTypeCard.CardFee = cardFee;
            retailStoreTenderTypeCard.CardFeeMin = cardFeeMin;
            return retailStoreTenderTypeCard;
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
        /// There are no comments for Property TenderTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TenderTypeId
        {
            get
            {
                return this._TenderTypeId;
            }
            set
            {
                this.OnTenderTypeIdChanging(value);
                this._TenderTypeId = value;
                this.OnTenderTypeIdChanged();
                this.OnPropertyChanged("TenderTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TenderTypeId;
        partial void OnTenderTypeIdChanging(string value);
        partial void OnTenderTypeIdChanged();
        /// <summary>
        /// There are no comments for Property CardTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CardTypeId
        {
            get
            {
                return this._CardTypeId;
            }
            set
            {
                this.OnCardTypeIdChanging(value);
                this._CardTypeId = value;
                this.OnCardTypeIdChanged();
                this.OnPropertyChanged("CardTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CardTypeId;
        partial void OnCardTypeIdChanging(string value);
        partial void OnCardTypeIdChanged();
        /// <summary>
        /// There are no comments for Property OMOperatingUnitNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OMOperatingUnitNumber
        {
            get
            {
                return this._OMOperatingUnitNumber;
            }
            set
            {
                this.OnOMOperatingUnitNumberChanging(value);
                this._OMOperatingUnitNumber = value;
                this.OnOMOperatingUnitNumberChanged();
                this.OnPropertyChanged("OMOperatingUnitNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OMOperatingUnitNumber;
        partial void OnOMOperatingUnitNumberChanging(string value);
        partial void OnOMOperatingUnitNumberChanged();
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
        /// There are no comments for Property CardFeeOffsetLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CardFeeOffsetLedgerDimensionDisplayValue
        {
            get
            {
                return this._CardFeeOffsetLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnCardFeeOffsetLedgerDimensionDisplayValueChanging(value);
                this._CardFeeOffsetLedgerDimensionDisplayValue = value;
                this.OnCardFeeOffsetLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("CardFeeOffsetLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CardFeeOffsetLedgerDimensionDisplayValue;
        partial void OnCardFeeOffsetLedgerDimensionDisplayValueChanging(string value);
        partial void OnCardFeeOffsetLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property CardFeeMax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CardFeeMax
        {
            get
            {
                return this._CardFeeMax;
            }
            set
            {
                this.OnCardFeeMaxChanging(value);
                this._CardFeeMax = value;
                this.OnCardFeeMaxChanged();
                this.OnPropertyChanged("CardFeeMax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CardFeeMax;
        partial void OnCardFeeMaxChanging(decimal value);
        partial void OnCardFeeMaxChanged();
        /// <summary>
        /// There are no comments for Property CashBackLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CashBackLimit
        {
            get
            {
                return this._CashBackLimit;
            }
            set
            {
                this.OnCashBackLimitChanging(value);
                this._CashBackLimit = value;
                this.OnCashBackLimitChanged();
                this.OnPropertyChanged("CashBackLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CashBackLimit;
        partial void OnCashBackLimitChanging(decimal value);
        partial void OnCashBackLimitChanged();
        /// <summary>
        /// There are no comments for Property CardInquiryFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CardInquiryFee
        {
            get
            {
                return this._CardInquiryFee;
            }
            set
            {
                this.OnCardInquiryFeeChanging(value);
                this._CardInquiryFee = value;
                this.OnCardInquiryFeeChanged();
                this.OnPropertyChanged("CardInquiryFee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CardInquiryFee;
        partial void OnCardInquiryFeeChanging(decimal value);
        partial void OnCardInquiryFeeChanged();
        /// <summary>
        /// There are no comments for Property SameCardAllowed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> SameCardAllowed
        {
            get
            {
                return this._SameCardAllowed;
            }
            set
            {
                this.OnSameCardAllowedChanging(value);
                this._SameCardAllowed = value;
                this.OnSameCardAllowedChanged();
                this.OnPropertyChanged("SameCardAllowed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _SameCardAllowed;
        partial void OnSameCardAllowedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSameCardAllowedChanged();
        /// <summary>
        /// There are no comments for Property IsPinRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPinRequired
        {
            get
            {
                return this._IsPinRequired;
            }
            set
            {
                this.OnIsPinRequiredChanging(value);
                this._IsPinRequired = value;
                this.OnIsPinRequiredChanged();
                this.OnPropertyChanged("IsPinRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPinRequired;
        partial void OnIsPinRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPinRequiredChanged();
        /// <summary>
        /// There are no comments for Property ManualAuthorization in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ManualAuthorization
        {
            get
            {
                return this._ManualAuthorization;
            }
            set
            {
                this.OnManualAuthorizationChanging(value);
                this._ManualAuthorization = value;
                this.OnManualAuthorizationChanged();
                this.OnPropertyChanged("ManualAuthorization");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ManualAuthorization;
        partial void OnManualAuthorizationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnManualAuthorizationChanged();
        /// <summary>
        /// There are no comments for Property BrokerId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BrokerId
        {
            get
            {
                return this._BrokerId;
            }
            set
            {
                this.OnBrokerIdChanging(value);
                this._BrokerId = value;
                this.OnBrokerIdChanged();
                this.OnPropertyChanged("BrokerId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BrokerId;
        partial void OnBrokerIdChanging(string value);
        partial void OnBrokerIdChanged();
        /// <summary>
        /// There are no comments for Property ProcessLocally in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ProcessLocally
        {
            get
            {
                return this._ProcessLocally;
            }
            set
            {
                this.OnProcessLocallyChanging(value);
                this._ProcessLocally = value;
                this.OnProcessLocallyChanged();
                this.OnPropertyChanged("ProcessLocally");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ProcessLocally;
        partial void OnProcessLocallyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnProcessLocallyChanged();
        /// <summary>
        /// There are no comments for Property CardFeeLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CardFeeLedgerDimensionDisplayValue
        {
            get
            {
                return this._CardFeeLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnCardFeeLedgerDimensionDisplayValueChanging(value);
                this._CardFeeLedgerDimensionDisplayValue = value;
                this.OnCardFeeLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("CardFeeLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CardFeeLedgerDimensionDisplayValue;
        partial void OnCardFeeLedgerDimensionDisplayValueChanging(string value);
        partial void OnCardFeeLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property MaxNormalDifferenceAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MaxNormalDifferenceAmount
        {
            get
            {
                return this._MaxNormalDifferenceAmount;
            }
            set
            {
                this.OnMaxNormalDifferenceAmountChanging(value);
                this._MaxNormalDifferenceAmount = value;
                this.OnMaxNormalDifferenceAmountChanged();
                this.OnPropertyChanged("MaxNormalDifferenceAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaxNormalDifferenceAmount;
        partial void OnMaxNormalDifferenceAmountChanging(decimal value);
        partial void OnMaxNormalDifferenceAmountChanged();
        /// <summary>
        /// There are no comments for Property EnterFleetInfo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EnterFleetInfo
        {
            get
            {
                return this._EnterFleetInfo;
            }
            set
            {
                this.OnEnterFleetInfoChanging(value);
                this._EnterFleetInfo = value;
                this.OnEnterFleetInfoChanged();
                this.OnPropertyChanged("EnterFleetInfo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EnterFleetInfo;
        partial void OnEnterFleetInfoChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEnterFleetInfoChanged();
        /// <summary>
        /// There are no comments for Property CheckModulus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CheckModulus
        {
            get
            {
                return this._CheckModulus;
            }
            set
            {
                this.OnCheckModulusChanging(value);
                this._CheckModulus = value;
                this.OnCheckModulusChanged();
                this.OnPropertyChanged("CheckModulus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CheckModulus;
        partial void OnCheckModulusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCheckModulusChanged();
        /// <summary>
        /// There are no comments for Property DifferenceAccLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DifferenceAccLedgerDimensionDisplayValue
        {
            get
            {
                return this._DifferenceAccLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnDifferenceAccLedgerDimensionDisplayValueChanging(value);
                this._DifferenceAccLedgerDimensionDisplayValue = value;
                this.OnDifferenceAccLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("DifferenceAccLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DifferenceAccLedgerDimensionDisplayValue;
        partial void OnDifferenceAccLedgerDimensionDisplayValueChanging(string value);
        partial void OnDifferenceAccLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property IsExpirationDateRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsExpirationDateRequired
        {
            get
            {
                return this._IsExpirationDateRequired;
            }
            set
            {
                this.OnIsExpirationDateRequiredChanging(value);
                this._IsExpirationDateRequired = value;
                this.OnIsExpirationDateRequiredChanged();
                this.OnPropertyChanged("IsExpirationDateRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsExpirationDateRequired;
        partial void OnIsExpirationDateRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsExpirationDateRequiredChanged();
        /// <summary>
        /// There are no comments for Property CardFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CardFee
        {
            get
            {
                return this._CardFee;
            }
            set
            {
                this.OnCardFeeChanging(value);
                this._CardFee = value;
                this.OnCardFeeChanged();
                this.OnPropertyChanged("CardFee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CardFee;
        partial void OnCardFeeChanging(decimal value);
        partial void OnCardFeeChanged();
        /// <summary>
        /// There are no comments for Property CardFeeMin in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CardFeeMin
        {
            get
            {
                return this._CardFeeMin;
            }
            set
            {
                this.OnCardFeeMinChanging(value);
                this._CardFeeMin = value;
                this.OnCardFeeMinChanged();
                this.OnPropertyChanged("CardFeeMin");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CardFeeMin;
        partial void OnCardFeeMinChanging(decimal value);
        partial void OnCardFeeMinChanged();
        /// <summary>
        /// There are no comments for Property CardNumberSwiped in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CardNumberSwiped
        {
            get
            {
                return this._CardNumberSwiped;
            }
            set
            {
                this.OnCardNumberSwipedChanging(value);
                this._CardNumberSwiped = value;
                this.OnCardNumberSwipedChanged();
                this.OnPropertyChanged("CardNumberSwiped");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CardNumberSwiped;
        partial void OnCardNumberSwipedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCardNumberSwipedChanged();
        /// <summary>
        /// There are no comments for Property DiffAccBigDiffLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DiffAccBigDiffLedgerDimensionDisplayValue
        {
            get
            {
                return this._DiffAccBigDiffLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnDiffAccBigDiffLedgerDimensionDisplayValueChanging(value);
                this._DiffAccBigDiffLedgerDimensionDisplayValue = value;
                this.OnDiffAccBigDiffLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("DiffAccBigDiffLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DiffAccBigDiffLedgerDimensionDisplayValue;
        partial void OnDiffAccBigDiffLedgerDimensionDisplayValueChanging(string value);
        partial void OnDiffAccBigDiffLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property AllowManualInput in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowManualInput
        {
            get
            {
                return this._AllowManualInput;
            }
            set
            {
                this.OnAllowManualInputChanging(value);
                this._AllowManualInput = value;
                this.OnAllowManualInputChanged();
                this.OnPropertyChanged("AllowManualInput");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowManualInput;
        partial void OnAllowManualInputChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowManualInputChanged();
        /// <summary>
        /// There are no comments for Property AccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLedgerBank> AccountType
        {
            get
            {
                return this._AccountType;
            }
            set
            {
                this.OnAccountTypeChanging(value);
                this._AccountType = value;
                this.OnAccountTypeChanged();
                this.OnPropertyChanged("AccountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLedgerBank> _AccountType;
        partial void OnAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLedgerBank> value);
        partial void OnAccountTypeChanged();
        /// <summary>
        /// There are no comments for Property LedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LedgerDimensionDisplayValue
        {
            get
            {
                return this._LedgerDimensionDisplayValue;
            }
            set
            {
                this.OnLedgerDimensionDisplayValueChanging(value);
                this._LedgerDimensionDisplayValue = value;
                this.OnLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("LedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerDimensionDisplayValue;
        partial void OnLedgerDimensionDisplayValueChanging(string value);
        partial void OnLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property CountingRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CountingRequired
        {
            get
            {
                return this._CountingRequired;
            }
            set
            {
                this.OnCountingRequiredChanging(value);
                this._CountingRequired = value;
                this.OnCountingRequiredChanged();
                this.OnPropertyChanged("CountingRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CountingRequired;
        partial void OnCountingRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCountingRequiredChanged();
        /// <summary>
        /// There are no comments for Property CheckExpiredDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CheckExpiredDate
        {
            get
            {
                return this._CheckExpiredDate;
            }
            set
            {
                this.OnCheckExpiredDateChanging(value);
                this._CheckExpiredDate = value;
                this.OnCheckExpiredDateChanged();
                this.OnPropertyChanged("CheckExpiredDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CheckExpiredDate;
        partial void OnCheckExpiredDateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCheckExpiredDateChanged();
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
