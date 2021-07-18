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
        /// There are no comments for VendorPaymentFeeSingle in the schema.
        /// </summary>
    public partial class VendorPaymentFeeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorPaymentFee>
    {
        /// <summary>
        /// Initialize a new VendorPaymentFeeSingle object.
        /// </summary>
        public VendorPaymentFeeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorPaymentFeeSingle object.
        /// </summary>
        public VendorPaymentFeeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorPaymentFeeSingle object.
        /// </summary>
        public VendorPaymentFeeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorPaymentFee> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for VendorPaymentJournalFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> VendorPaymentJournalFee
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendorPaymentJournalFee == null))
                {
                    this._VendorPaymentJournalFee = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee>(GetPath("VendorPaymentJournalFee"));
                }
                return this._VendorPaymentJournalFee;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> _VendorPaymentJournalFee;
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
        /// There are no comments for VendorPaymentFee in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Name")]
    [global::Microsoft.OData.Client.EntitySet("VendorPaymentFees")]
    public partial class VendorPaymentFee : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorPaymentFee object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorPaymentFee CreateVendorPaymentFee(string dataAreaId, string name)
        {
            VendorPaymentFee vendorPaymentFee = new VendorPaymentFee();
            vendorPaymentFee.dataAreaId = dataAreaId;
            vendorPaymentFee.Name = name;
            return vendorPaymentFee;
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
        /// There are no comments for Property FeeLedgerAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FeeLedgerAccountDisplayValue
        {
            get
            {
                return this._FeeLedgerAccountDisplayValue;
            }
            set
            {
                this.OnFeeLedgerAccountDisplayValueChanging(value);
                this._FeeLedgerAccountDisplayValue = value;
                this.OnFeeLedgerAccountDisplayValueChanged();
                this.OnPropertyChanged("FeeLedgerAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FeeLedgerAccountDisplayValue;
        partial void OnFeeLedgerAccountDisplayValueChanging(string value);
        partial void OnFeeLedgerAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property JournalType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalType> JournalType
        {
            get
            {
                return this._JournalType;
            }
            set
            {
                this.OnJournalTypeChanging(value);
                this._JournalType = value;
                this.OnJournalTypeChanged();
                this.OnPropertyChanged("JournalType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalType> _JournalType;
        partial void OnJournalTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalType> value);
        partial void OnJournalTypeChanged();
        /// <summary>
        /// There are no comments for Property VendorCoveredFeeLedgerAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorCoveredFeeLedgerAccountDisplayValue
        {
            get
            {
                return this._VendorCoveredFeeLedgerAccountDisplayValue;
            }
            set
            {
                this.OnVendorCoveredFeeLedgerAccountDisplayValueChanging(value);
                this._VendorCoveredFeeLedgerAccountDisplayValue = value;
                this.OnVendorCoveredFeeLedgerAccountDisplayValueChanged();
                this.OnPropertyChanged("VendorCoveredFeeLedgerAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorCoveredFeeLedgerAccountDisplayValue;
        partial void OnVendorCoveredFeeLedgerAccountDisplayValueChanging(string value);
        partial void OnVendorCoveredFeeLedgerAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TransactionText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TransactionText
        {
            get
            {
                return this._TransactionText;
            }
            set
            {
                this.OnTransactionTextChanging(value);
                this._TransactionText = value;
                this.OnTransactionTextChanged();
                this.OnPropertyChanged("TransactionText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionText;
        partial void OnTransactionTextChanging(string value);
        partial void OnTransactionTextChanged();
        /// <summary>
        /// There are no comments for Property ChargeType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PaymFeePostingVend> ChargeType
        {
            get
            {
                return this._ChargeType;
            }
            set
            {
                this.OnChargeTypeChanging(value);
                this._ChargeType = value;
                this.OnChargeTypeChanged();
                this.OnPropertyChanged("ChargeType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PaymFeePostingVend> _ChargeType;
        partial void OnChargeTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PaymFeePostingVend> value);
        partial void OnChargeTypeChanged();
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
        /// There are no comments for Property MainAccountIdForLedgerFeeTypesDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccountIdForLedgerFeeTypesDisplayValue
        {
            get
            {
                return this._MainAccountIdForLedgerFeeTypesDisplayValue;
            }
            set
            {
                this.OnMainAccountIdForLedgerFeeTypesDisplayValueChanging(value);
                this._MainAccountIdForLedgerFeeTypesDisplayValue = value;
                this.OnMainAccountIdForLedgerFeeTypesDisplayValueChanged();
                this.OnPropertyChanged("MainAccountIdForLedgerFeeTypesDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountIdForLedgerFeeTypesDisplayValue;
        partial void OnMainAccountIdForLedgerFeeTypesDisplayValueChanging(string value);
        partial void OnMainAccountIdForLedgerFeeTypesDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property VendorPaymentJournalFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> VendorPaymentJournalFee
        {
            get
            {
                return this._VendorPaymentJournalFee;
            }
            set
            {
                this.OnVendorPaymentJournalFeeChanging(value);
                this._VendorPaymentJournalFee = value;
                this.OnVendorPaymentJournalFeeChanged();
                this.OnPropertyChanged("VendorPaymentJournalFee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> _VendorPaymentJournalFee = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVendorPaymentJournalFeeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> value);
        partial void OnVendorPaymentJournalFeeChanged();
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
