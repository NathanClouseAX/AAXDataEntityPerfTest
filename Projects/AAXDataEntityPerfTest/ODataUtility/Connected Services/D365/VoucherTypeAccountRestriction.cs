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
        /// There are no comments for VoucherTypeAccountRestrictionSingle in the schema.
        /// </summary>
    public partial class VoucherTypeAccountRestrictionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VoucherTypeAccountRestriction>
    {
        /// <summary>
        /// Initialize a new VoucherTypeAccountRestrictionSingle object.
        /// </summary>
        public VoucherTypeAccountRestrictionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VoucherTypeAccountRestrictionSingle object.
        /// </summary>
        public VoucherTypeAccountRestrictionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VoucherTypeAccountRestrictionSingle object.
        /// </summary>
        public VoucherTypeAccountRestrictionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VoucherTypeAccountRestriction> query)
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
        /// There are no comments for VoucherTypeAccountRestriction in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// VoucherType
    /// RestrictionType
    /// LedgerDimensionDisplayValue
    /// AccountType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "VoucherType", "RestrictionType", "LedgerDimensionDisplayValue", "AccountType")]
    [global::Microsoft.OData.Client.EntitySet("VoucherTypeAccountRestrictions")]
    public partial class VoucherTypeAccountRestriction : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VoucherTypeAccountRestriction object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="voucherType">Initial value of VoucherType.</param>
        /// <param name="ledgerDimensionDisplayValue">Initial value of LedgerDimensionDisplayValue.</param>
        /// <param name="priority">Initial value of Priority.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VoucherTypeAccountRestriction CreateVoucherTypeAccountRestriction(string dataAreaId, string voucherType, string ledgerDimensionDisplayValue, int priority)
        {
            VoucherTypeAccountRestriction voucherTypeAccountRestriction = new VoucherTypeAccountRestriction();
            voucherTypeAccountRestriction.dataAreaId = dataAreaId;
            voucherTypeAccountRestriction.VoucherType = voucherType;
            voucherTypeAccountRestriction.LedgerDimensionDisplayValue = ledgerDimensionDisplayValue;
            voucherTypeAccountRestriction.Priority = priority;
            return voucherTypeAccountRestriction;
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
        /// There are no comments for Property VoucherType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VoucherType
        {
            get
            {
                return this._VoucherType;
            }
            set
            {
                this.OnVoucherTypeChanging(value);
                this._VoucherType = value;
                this.OnVoucherTypeChanged();
                this.OnPropertyChanged("VoucherType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VoucherType;
        partial void OnVoucherTypeChanging(string value);
        partial void OnVoucherTypeChanged();
        /// <summary>
        /// There are no comments for Property RestrictionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerVoucherRestrictionType_CN> RestrictionType
        {
            get
            {
                return this._RestrictionType;
            }
            set
            {
                this.OnRestrictionTypeChanging(value);
                this._RestrictionType = value;
                this.OnRestrictionTypeChanged();
                this.OnPropertyChanged("RestrictionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerVoucherRestrictionType_CN> _RestrictionType;
        partial void OnRestrictionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerVoucherRestrictionType_CN> value);
        partial void OnRestrictionTypeChanged();
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
        /// There are no comments for Property AccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> AccountType
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> _AccountType;
        partial void OnAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> value);
        partial void OnAccountTypeChanged();
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
        /// There are no comments for Property JournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalName
        {
            get
            {
                return this._JournalName;
            }
            set
            {
                this.OnJournalNameChanging(value);
                this._JournalName = value;
                this.OnJournalNameChanged();
                this.OnPropertyChanged("JournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalName;
        partial void OnJournalNameChanging(string value);
        partial void OnJournalNameChanged();
        /// <summary>
        /// There are no comments for Property DefaultApprovedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultApprovedBy
        {
            get
            {
                return this._DefaultApprovedBy;
            }
            set
            {
                this.OnDefaultApprovedByChanging(value);
                this._DefaultApprovedBy = value;
                this.OnDefaultApprovedByChanged();
                this.OnPropertyChanged("DefaultApprovedBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultApprovedBy;
        partial void OnDefaultApprovedByChanging(string value);
        partial void OnDefaultApprovedByChanged();
        /// <summary>
        /// There are no comments for Property VoucherTypeNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VoucherTypeNumber
        {
            get
            {
                return this._VoucherTypeNumber;
            }
            set
            {
                this.OnVoucherTypeNumberChanging(value);
                this._VoucherTypeNumber = value;
                this.OnVoucherTypeNumberChanged();
                this.OnPropertyChanged("VoucherTypeNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VoucherTypeNumber;
        partial void OnVoucherTypeNumberChanging(string value);
        partial void OnVoucherTypeNumberChanged();
        /// <summary>
        /// There are no comments for Property LedgerPrintLayoutGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LedgerPrintLayoutGroup
        {
            get
            {
                return this._LedgerPrintLayoutGroup;
            }
            set
            {
                this.OnLedgerPrintLayoutGroupChanging(value);
                this._LedgerPrintLayoutGroup = value;
                this.OnLedgerPrintLayoutGroupChanged();
                this.OnPropertyChanged("LedgerPrintLayoutGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerPrintLayoutGroup;
        partial void OnLedgerPrintLayoutGroupChanging(string value);
        partial void OnLedgerPrintLayoutGroupChanged();
        /// <summary>
        /// There are no comments for Property DefaultedPreparedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultedPreparedBy
        {
            get
            {
                return this._DefaultedPreparedBy;
            }
            set
            {
                this.OnDefaultedPreparedByChanging(value);
                this._DefaultedPreparedBy = value;
                this.OnDefaultedPreparedByChanged();
                this.OnPropertyChanged("DefaultedPreparedBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultedPreparedBy;
        partial void OnDefaultedPreparedByChanging(string value);
        partial void OnDefaultedPreparedByChanged();
        /// <summary>
        /// There are no comments for Property Priority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Priority
        {
            get
            {
                return this._Priority;
            }
            set
            {
                this.OnPriorityChanging(value);
                this._Priority = value;
                this.OnPriorityChanged();
                this.OnPropertyChanged("Priority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Priority;
        partial void OnPriorityChanging(int value);
        partial void OnPriorityChanged();
        /// <summary>
        /// There are no comments for Property IsDefaultType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefaultType
        {
            get
            {
                return this._IsDefaultType;
            }
            set
            {
                this.OnIsDefaultTypeChanging(value);
                this._IsDefaultType = value;
                this.OnIsDefaultTypeChanged();
                this.OnPropertyChanged("IsDefaultType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefaultType;
        partial void OnIsDefaultTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultTypeChanged();
        /// <summary>
        /// There are no comments for Property NumberSequenceCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string NumberSequenceCode
        {
            get
            {
                return this._NumberSequenceCode;
            }
            set
            {
                this.OnNumberSequenceCodeChanging(value);
                this._NumberSequenceCode = value;
                this.OnNumberSequenceCodeChanged();
                this.OnPropertyChanged("NumberSequenceCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NumberSequenceCode;
        partial void OnNumberSequenceCodeChanging(string value);
        partial void OnNumberSequenceCodeChanged();
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
