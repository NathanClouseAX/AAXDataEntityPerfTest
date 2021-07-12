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
        /// There are no comments for RoyaltyAgreementLineSingle in the schema.
        /// </summary>
    public partial class RoyaltyAgreementLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RoyaltyAgreementLine>
    {
        /// <summary>
        /// Initialize a new RoyaltyAgreementLineSingle object.
        /// </summary>
        public RoyaltyAgreementLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RoyaltyAgreementLineSingle object.
        /// </summary>
        public RoyaltyAgreementLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RoyaltyAgreementLineSingle object.
        /// </summary>
        public RoyaltyAgreementLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RoyaltyAgreementLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RoyaltyAgreementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderSingle RoyaltyAgreementHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RoyaltyAgreementHeader == null))
                {
                    this._RoyaltyAgreementHeader = new global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderSingle(this.Context, GetPath("RoyaltyAgreementHeader"));
                }
                return this._RoyaltyAgreementHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderSingle _RoyaltyAgreementHeader;
        /// <summary>
        /// There are no comments for RoyaltyAgreementLineProductSelections in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineProductSelection> RoyaltyAgreementLineProductSelections
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RoyaltyAgreementLineProductSelections == null))
                {
                    this._RoyaltyAgreementLineProductSelections = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineProductSelection>(GetPath("RoyaltyAgreementLineProductSelections"));
                }
                return this._RoyaltyAgreementLineProductSelections;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineProductSelection> _RoyaltyAgreementLineProductSelections;
        /// <summary>
        /// There are no comments for RoyaltyAgreementLineAmounts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineAmount> RoyaltyAgreementLineAmounts
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RoyaltyAgreementLineAmounts == null))
                {
                    this._RoyaltyAgreementLineAmounts = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineAmount>(GetPath("RoyaltyAgreementLineAmounts"));
                }
                return this._RoyaltyAgreementLineAmounts;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineAmount> _RoyaltyAgreementLineAmounts;
        /// <summary>
        /// There are no comments for RoyaltyAgreementLineProductSelectionsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineProductSelectionV2> RoyaltyAgreementLineProductSelectionsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RoyaltyAgreementLineProductSelectionsV2 == null))
                {
                    this._RoyaltyAgreementLineProductSelectionsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineProductSelectionV2>(GetPath("RoyaltyAgreementLineProductSelectionsV2"));
                }
                return this._RoyaltyAgreementLineProductSelectionsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineProductSelectionV2> _RoyaltyAgreementLineProductSelectionsV2;
    }
        /// <summary>
        /// There are no comments for RoyaltyAgreementLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RoyaltyAgreementLineId
    /// RoyaltyAgreementId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RoyaltyAgreementLineId", "RoyaltyAgreementId")]
    [global::Microsoft.OData.Client.EntitySet("RoyaltyAgreementLines")]
    public partial class RoyaltyAgreementLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RoyaltyAgreementLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="royaltyAgreementLineId">Initial value of RoyaltyAgreementLineId.</param>
        /// <param name="royaltyAgreementId">Initial value of RoyaltyAgreementId.</param>
        /// <param name="expirationDate">Initial value of ExpirationDate.</param>
        /// <param name="effectiveDate">Initial value of EffectiveDate.</param>
        /// <param name="royaltyAgreementHeader">Initial value of RoyaltyAgreementHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RoyaltyAgreementLine CreateRoyaltyAgreementLine(string dataAreaId, 
                    string royaltyAgreementLineId, 
                    string royaltyAgreementId, 
                    global::System.DateTimeOffset expirationDate, 
                    global::System.DateTimeOffset effectiveDate, 
                    global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeader royaltyAgreementHeader)
        {
            RoyaltyAgreementLine royaltyAgreementLine = new RoyaltyAgreementLine();
            royaltyAgreementLine.dataAreaId = dataAreaId;
            royaltyAgreementLine.RoyaltyAgreementLineId = royaltyAgreementLineId;
            royaltyAgreementLine.RoyaltyAgreementId = royaltyAgreementId;
            royaltyAgreementLine.ExpirationDate = expirationDate;
            royaltyAgreementLine.EffectiveDate = effectiveDate;
            if ((royaltyAgreementHeader == null))
            {
                throw new global::System.ArgumentNullException("royaltyAgreementHeader");
            }
            royaltyAgreementLine.RoyaltyAgreementHeader = royaltyAgreementHeader;
            return royaltyAgreementLine;
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
        /// There are no comments for Property RoyaltyAgreementLineId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RoyaltyAgreementLineId
        {
            get
            {
                return this._RoyaltyAgreementLineId;
            }
            set
            {
                this.OnRoyaltyAgreementLineIdChanging(value);
                this._RoyaltyAgreementLineId = value;
                this.OnRoyaltyAgreementLineIdChanged();
                this.OnPropertyChanged("RoyaltyAgreementLineId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoyaltyAgreementLineId;
        partial void OnRoyaltyAgreementLineIdChanging(string value);
        partial void OnRoyaltyAgreementLineIdChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyAgreementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RoyaltyAgreementId
        {
            get
            {
                return this._RoyaltyAgreementId;
            }
            set
            {
                this.OnRoyaltyAgreementIdChanging(value);
                this._RoyaltyAgreementId = value;
                this.OnRoyaltyAgreementIdChanged();
                this.OnPropertyChanged("RoyaltyAgreementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoyaltyAgreementId;
        partial void OnRoyaltyAgreementIdChanging(string value);
        partial void OnRoyaltyAgreementIdChanged();
        /// <summary>
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this.OnCurrencyCodeChanging(value);
                this._CurrencyCode = value;
                this.OnCurrencyCodeChanged();
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property AgreementLineNotes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AgreementLineNotes
        {
            get
            {
                return this._AgreementLineNotes;
            }
            set
            {
                this.OnAgreementLineNotesChanging(value);
                this._AgreementLineNotes = value;
                this.OnAgreementLineNotesChanged();
                this.OnPropertyChanged("AgreementLineNotes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AgreementLineNotes;
        partial void OnAgreementLineNotesChanging(string value);
        partial void OnAgreementLineNotesChanged();
        /// <summary>
        /// There are no comments for Property AgreementLineDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AgreementLineDescription
        {
            get
            {
                return this._AgreementLineDescription;
            }
            set
            {
                this.OnAgreementLineDescriptionChanging(value);
                this._AgreementLineDescription = value;
                this.OnAgreementLineDescriptionChanged();
                this.OnPropertyChanged("AgreementLineDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AgreementLineDescription;
        partial void OnAgreementLineDescriptionChanging(string value);
        partial void OnAgreementLineDescriptionChanged();
        /// <summary>
        /// There are no comments for Property SalesUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesUnitSymbol
        {
            get
            {
                return this._SalesUnitSymbol;
            }
            set
            {
                this.OnSalesUnitSymbolChanging(value);
                this._SalesUnitSymbol = value;
                this.OnSalesUnitSymbolChanged();
                this.OnPropertyChanged("SalesUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesUnitSymbol;
        partial void OnSalesUnitSymbolChanging(string value);
        partial void OnSalesUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property CalculationSearchDateType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRTradeCustCalcDates> CalculationSearchDateType
        {
            get
            {
                return this._CalculationSearchDateType;
            }
            set
            {
                this.OnCalculationSearchDateTypeChanging(value);
                this._CalculationSearchDateType = value;
                this.OnCalculationSearchDateTypeChanged();
                this.OnPropertyChanged("CalculationSearchDateType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRTradeCustCalcDates> _CalculationSearchDateType;
        partial void OnCalculationSearchDateTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRTradeCustCalcDates> value);
        partial void OnCalculationSearchDateTypeChanged();
        /// <summary>
        /// There are no comments for Property ExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ExpirationDate
        {
            get
            {
                return this._ExpirationDate;
            }
            set
            {
                this.OnExpirationDateChanging(value);
                this._ExpirationDate = value;
                this.OnExpirationDateChanged();
                this.OnPropertyChanged("ExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ExpirationDate;
        partial void OnExpirationDateChanging(global::System.DateTimeOffset value);
        partial void OnExpirationDateChanged();
        /// <summary>
        /// There are no comments for Property VendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorAccountNumber
        {
            get
            {
                return this._VendorAccountNumber;
            }
            set
            {
                this.OnVendorAccountNumberChanging(value);
                this._VendorAccountNumber = value;
                this.OnVendorAccountNumberChanged();
                this.OnPropertyChanged("VendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAccountNumber;
        partial void OnVendorAccountNumberChanging(string value);
        partial void OnVendorAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property EffectiveDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EffectiveDate
        {
            get
            {
                return this._EffectiveDate;
            }
            set
            {
                this.OnEffectiveDateChanging(value);
                this._EffectiveDate = value;
                this.OnEffectiveDateChanged();
                this.OnPropertyChanged("EffectiveDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EffectiveDate;
        partial void OnEffectiveDateChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveDateChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyAgreementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeader RoyaltyAgreementHeader
        {
            get
            {
                return this._RoyaltyAgreementHeader;
            }
            set
            {
                this.OnRoyaltyAgreementHeaderChanging(value);
                this._RoyaltyAgreementHeader = value;
                this.OnRoyaltyAgreementHeaderChanged();
                this.OnPropertyChanged("RoyaltyAgreementHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeader _RoyaltyAgreementHeader;
        partial void OnRoyaltyAgreementHeaderChanging(global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeader value);
        partial void OnRoyaltyAgreementHeaderChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyAgreementLineProductSelections in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineProductSelection> RoyaltyAgreementLineProductSelections
        {
            get
            {
                return this._RoyaltyAgreementLineProductSelections;
            }
            set
            {
                this.OnRoyaltyAgreementLineProductSelectionsChanging(value);
                this._RoyaltyAgreementLineProductSelections = value;
                this.OnRoyaltyAgreementLineProductSelectionsChanged();
                this.OnPropertyChanged("RoyaltyAgreementLineProductSelections");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineProductSelection> _RoyaltyAgreementLineProductSelections = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineProductSelection>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRoyaltyAgreementLineProductSelectionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineProductSelection> value);
        partial void OnRoyaltyAgreementLineProductSelectionsChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyAgreementLineAmounts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineAmount> RoyaltyAgreementLineAmounts
        {
            get
            {
                return this._RoyaltyAgreementLineAmounts;
            }
            set
            {
                this.OnRoyaltyAgreementLineAmountsChanging(value);
                this._RoyaltyAgreementLineAmounts = value;
                this.OnRoyaltyAgreementLineAmountsChanged();
                this.OnPropertyChanged("RoyaltyAgreementLineAmounts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineAmount> _RoyaltyAgreementLineAmounts = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineAmount>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRoyaltyAgreementLineAmountsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineAmount> value);
        partial void OnRoyaltyAgreementLineAmountsChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyAgreementLineProductSelectionsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineProductSelectionV2> RoyaltyAgreementLineProductSelectionsV2
        {
            get
            {
                return this._RoyaltyAgreementLineProductSelectionsV2;
            }
            set
            {
                this.OnRoyaltyAgreementLineProductSelectionsV2Changing(value);
                this._RoyaltyAgreementLineProductSelectionsV2 = value;
                this.OnRoyaltyAgreementLineProductSelectionsV2Changed();
                this.OnPropertyChanged("RoyaltyAgreementLineProductSelectionsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineProductSelectionV2> _RoyaltyAgreementLineProductSelectionsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineProductSelectionV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRoyaltyAgreementLineProductSelectionsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLineProductSelectionV2> value);
        partial void OnRoyaltyAgreementLineProductSelectionsV2Changed();
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
