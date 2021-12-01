﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/28/2021 8:55:09 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for InventoryCountingJournalHeaderSingle in the schema.
    /// </summary>
    public partial class InventoryCountingJournalHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<InventoryCountingJournalHeader>
    {
        /// <summary>
        /// Initialize a new InventoryCountingJournalHeaderSingle object.
        /// </summary>
        public InventoryCountingJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InventoryCountingJournalHeaderSingle object.
        /// </summary>
        public InventoryCountingJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InventoryCountingJournalHeaderSingle object.
        /// </summary>
        public InventoryCountingJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<InventoryCountingJournalHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle Worker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Worker == null))
                {
                    this._Worker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("Worker"));
                }
                return this._Worker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _Worker;
        /// <summary>
        /// There are no comments for InventoryCountingJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> InventoryCountingJournalLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._InventoryCountingJournalLine == null))
                {
                    this._InventoryCountingJournalLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine>(GetPath("InventoryCountingJournalLine"));
                }
                return this._InventoryCountingJournalLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> _InventoryCountingJournalLine;
    }
    /// <summary>
    /// There are no comments for InventoryCountingJournalHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// JournalNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JournalNumber")]
    [global::Microsoft.OData.Client.EntitySet("InventoryCountingJournalHeaders")]
    public partial class InventoryCountingJournalHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new InventoryCountingJournalHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="journalNumber">Initial value of JournalNumber.</param>
        /// <param name="postedDateTime">Initial value of PostedDateTime.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static InventoryCountingJournalHeader CreateInventoryCountingJournalHeader(string dataAreaId, string journalNumber, global::System.DateTimeOffset postedDateTime)
        {
            InventoryCountingJournalHeader inventoryCountingJournalHeader = new InventoryCountingJournalHeader();
            inventoryCountingJournalHeader.dataAreaId = dataAreaId;
            inventoryCountingJournalHeader.JournalNumber = journalNumber;
            inventoryCountingJournalHeader.PostedDateTime = postedDateTime;
            return inventoryCountingJournalHeader;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "dataAreaId is required.")]
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
        /// There are no comments for Property JournalNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JournalNumber is required.")]
        public virtual string JournalNumber
        {
            get
            {
                return this._JournalNumber;
            }
            set
            {
                this.OnJournalNumberChanging(value);
                this._JournalNumber = value;
                this.OnJournalNumberChanged();
                this.OnPropertyChanged("JournalNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalNumber;
        partial void OnJournalNumberChanging(string value);
        partial void OnJournalNumberChanged();
        /// <summary>
        /// There are no comments for Property IsPosted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPosted
        {
            get
            {
                return this._IsPosted;
            }
            set
            {
                this.OnIsPostedChanging(value);
                this._IsPosted = value;
                this.OnIsPostedChanged();
                this.OnPropertyChanged("IsPosted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPosted;
        partial void OnIsPostedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPostedChanged();
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
        /// There are no comments for Property IsCountingLicensePlateSpecific in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCountingLicensePlateSpecific
        {
            get
            {
                return this._IsCountingLicensePlateSpecific;
            }
            set
            {
                this.OnIsCountingLicensePlateSpecificChanging(value);
                this._IsCountingLicensePlateSpecific = value;
                this.OnIsCountingLicensePlateSpecificChanged();
                this.OnPropertyChanged("IsCountingLicensePlateSpecific");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCountingLicensePlateSpecific;
        partial void OnIsCountingLicensePlateSpecificChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCountingLicensePlateSpecificChanged();
        /// <summary>
        /// There are no comments for Property DefaultWarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string DefaultWarehouseId
        {
            get
            {
                return this._DefaultWarehouseId;
            }
            set
            {
                this.OnDefaultWarehouseIdChanging(value);
                this._DefaultWarehouseId = value;
                this.OnDefaultWarehouseIdChanged();
                this.OnPropertyChanged("DefaultWarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultWarehouseId;
        partial void OnDefaultWarehouseIdChanging(string value);
        partial void OnDefaultWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property IsCountingWarehouseLocationSpecific in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCountingWarehouseLocationSpecific
        {
            get
            {
                return this._IsCountingWarehouseLocationSpecific;
            }
            set
            {
                this.OnIsCountingWarehouseLocationSpecificChanging(value);
                this._IsCountingWarehouseLocationSpecific = value;
                this.OnIsCountingWarehouseLocationSpecificChanged();
                this.OnPropertyChanged("IsCountingWarehouseLocationSpecific");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCountingWarehouseLocationSpecific;
        partial void OnIsCountingWarehouseLocationSpecificChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCountingWarehouseLocationSpecificChanged();
        /// <summary>
        /// There are no comments for Property IsCountingItemBatchSpecific in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCountingItemBatchSpecific
        {
            get
            {
                return this._IsCountingItemBatchSpecific;
            }
            set
            {
                this.OnIsCountingItemBatchSpecificChanging(value);
                this._IsCountingItemBatchSpecific = value;
                this.OnIsCountingItemBatchSpecificChanged();
                this.OnPropertyChanged("IsCountingItemBatchSpecific");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCountingItemBatchSpecific;
        partial void OnIsCountingItemBatchSpecificChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCountingItemBatchSpecificChanged();
        /// <summary>
        /// There are no comments for Property ReservationMode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ItemReservation> ReservationMode
        {
            get
            {
                return this._ReservationMode;
            }
            set
            {
                this.OnReservationModeChanging(value);
                this._ReservationMode = value;
                this.OnReservationModeChanged();
                this.OnPropertyChanged("ReservationMode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ItemReservation> _ReservationMode;
        partial void OnReservationModeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ItemReservation> value);
        partial void OnReservationModeChanged();
        /// <summary>
        /// There are no comments for Property PostingDetailLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> PostingDetailLevel
        {
            get
            {
                return this._PostingDetailLevel;
            }
            set
            {
                this.OnPostingDetailLevelChanging(value);
                this._PostingDetailLevel = value;
                this.OnPostingDetailLevelChanged();
                this.OnPropertyChanged("PostingDetailLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> _PostingDetailLevel;
        partial void OnPostingDetailLevelChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> value);
        partial void OnPostingDetailLevelChanged();
        /// <summary>
        /// There are no comments for Property DefaultInventorySiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string DefaultInventorySiteId
        {
            get
            {
                return this._DefaultInventorySiteId;
            }
            set
            {
                this.OnDefaultInventorySiteIdChanging(value);
                this._DefaultInventorySiteId = value;
                this.OnDefaultInventorySiteIdChanged();
                this.OnPropertyChanged("DefaultInventorySiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultInventorySiteId;
        partial void OnDefaultInventorySiteIdChanging(string value);
        partial void OnDefaultInventorySiteIdChanged();
        /// <summary>
        /// There are no comments for Property JournalNameId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string JournalNameId
        {
            get
            {
                return this._JournalNameId;
            }
            set
            {
                this.OnJournalNameIdChanging(value);
                this._JournalNameId = value;
                this.OnJournalNameIdChanged();
                this.OnPropertyChanged("JournalNameId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalNameId;
        partial void OnJournalNameIdChanging(string value);
        partial void OnJournalNameIdChanged();
        /// <summary>
        /// There are no comments for Property VoucherNumberSelectionRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventJournalVoucherChange> VoucherNumberSelectionRule
        {
            get
            {
                return this._VoucherNumberSelectionRule;
            }
            set
            {
                this.OnVoucherNumberSelectionRuleChanging(value);
                this._VoucherNumberSelectionRule = value;
                this.OnVoucherNumberSelectionRuleChanged();
                this.OnPropertyChanged("VoucherNumberSelectionRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventJournalVoucherChange> _VoucherNumberSelectionRule;
        partial void OnVoucherNumberSelectionRuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventJournalVoucherChange> value);
        partial void OnVoucherNumberSelectionRuleChanged();
        /// <summary>
        /// There are no comments for Property WorkerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string WorkerPersonnelNumber
        {
            get
            {
                return this._WorkerPersonnelNumber;
            }
            set
            {
                this.OnWorkerPersonnelNumberChanging(value);
                this._WorkerPersonnelNumber = value;
                this.OnWorkerPersonnelNumberChanged();
                this.OnPropertyChanged("WorkerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerPersonnelNumber;
        partial void OnWorkerPersonnelNumberChanging(string value);
        partial void OnWorkerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property PostedDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PostedDateTime is required.")]
        public virtual global::System.DateTimeOffset PostedDateTime
        {
            get
            {
                return this._PostedDateTime;
            }
            set
            {
                this.OnPostedDateTimeChanging(value);
                this._PostedDateTime = value;
                this.OnPostedDateTimeChanged();
                this.OnPropertyChanged("PostedDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PostedDateTime;
        partial void OnPostedDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnPostedDateTimeChanged();
        /// <summary>
        /// There are no comments for Property IsCountingItemSerialNumberSpecific in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCountingItemSerialNumberSpecific
        {
            get
            {
                return this._IsCountingItemSerialNumberSpecific;
            }
            set
            {
                this.OnIsCountingItemSerialNumberSpecificChanging(value);
                this._IsCountingItemSerialNumberSpecific = value;
                this.OnIsCountingItemSerialNumberSpecificChanged();
                this.OnPropertyChanged("IsCountingItemSerialNumberSpecific");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCountingItemSerialNumberSpecific;
        partial void OnIsCountingItemSerialNumberSpecificChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCountingItemSerialNumberSpecificChanged();
        /// <summary>
        /// There are no comments for Property VoucherNumberAllocationRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JournalVoucherDraw> VoucherNumberAllocationRule
        {
            get
            {
                return this._VoucherNumberAllocationRule;
            }
            set
            {
                this.OnVoucherNumberAllocationRuleChanging(value);
                this._VoucherNumberAllocationRule = value;
                this.OnVoucherNumberAllocationRuleChanged();
                this.OnPropertyChanged("VoucherNumberAllocationRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JournalVoucherDraw> _VoucherNumberAllocationRule;
        partial void OnVoucherNumberAllocationRuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JournalVoucherDraw> value);
        partial void OnVoucherNumberAllocationRuleChanged();
        /// <summary>
        /// There are no comments for Property VoucherNumberSequenceCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string VoucherNumberSequenceCode
        {
            get
            {
                return this._VoucherNumberSequenceCode;
            }
            set
            {
                this.OnVoucherNumberSequenceCodeChanging(value);
                this._VoucherNumberSequenceCode = value;
                this.OnVoucherNumberSequenceCodeChanged();
                this.OnPropertyChanged("VoucherNumberSequenceCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VoucherNumberSequenceCode;
        partial void OnVoucherNumberSequenceCodeChanging(string value);
        partial void OnVoucherNumberSequenceCodeChanged();
        /// <summary>
        /// There are no comments for Property IsCountingWarehouseSpecific in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCountingWarehouseSpecific
        {
            get
            {
                return this._IsCountingWarehouseSpecific;
            }
            set
            {
                this.OnIsCountingWarehouseSpecificChanging(value);
                this._IsCountingWarehouseSpecific = value;
                this.OnIsCountingWarehouseSpecificChanged();
                this.OnPropertyChanged("IsCountingWarehouseSpecific");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCountingWarehouseSpecific;
        partial void OnIsCountingWarehouseSpecificChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCountingWarehouseSpecificChanged();
        /// <summary>
        /// There are no comments for Property AreLinesDeletedAfterPosting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AreLinesDeletedAfterPosting
        {
            get
            {
                return this._AreLinesDeletedAfterPosting;
            }
            set
            {
                this.OnAreLinesDeletedAfterPostingChanging(value);
                this._AreLinesDeletedAfterPosting = value;
                this.OnAreLinesDeletedAfterPostingChanged();
                this.OnPropertyChanged("AreLinesDeletedAfterPosting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AreLinesDeletedAfterPosting;
        partial void OnAreLinesDeletedAfterPostingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAreLinesDeletedAfterPostingChanged();
        /// <summary>
        /// There are no comments for Property PostedUserId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string PostedUserId
        {
            get
            {
                return this._PostedUserId;
            }
            set
            {
                this.OnPostedUserIdChanging(value);
                this._PostedUserId = value;
                this.OnPostedUserIdChanged();
                this.OnPropertyChanged("PostedUserId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PostedUserId;
        partial void OnPostedUserIdChanging(string value);
        partial void OnPostedUserIdChanged();
        /// <summary>
        /// There are no comments for Property CountingStatusRegistrationPolicy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventCountingStatusRegistrationPolicy> CountingStatusRegistrationPolicy
        {
            get
            {
                return this._CountingStatusRegistrationPolicy;
            }
            set
            {
                this.OnCountingStatusRegistrationPolicyChanging(value);
                this._CountingStatusRegistrationPolicy = value;
                this.OnCountingStatusRegistrationPolicyChanged();
                this.OnPropertyChanged("CountingStatusRegistrationPolicy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventCountingStatusRegistrationPolicy> _CountingStatusRegistrationPolicy;
        partial void OnCountingStatusRegistrationPolicyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventCountingStatusRegistrationPolicy> value);
        partial void OnCountingStatusRegistrationPolicyChanged();
        /// <summary>
        /// There are no comments for Property IsCountingInventoryStatusSpecific in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCountingInventoryStatusSpecific
        {
            get
            {
                return this._IsCountingInventoryStatusSpecific;
            }
            set
            {
                this.OnIsCountingInventoryStatusSpecificChanging(value);
                this._IsCountingInventoryStatusSpecific = value;
                this.OnIsCountingInventoryStatusSpecificChanged();
                this.OnPropertyChanged("IsCountingInventoryStatusSpecific");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCountingInventoryStatusSpecific;
        partial void OnIsCountingInventoryStatusSpecificChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCountingInventoryStatusSpecificChanged();
        /// <summary>
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.Dynamics.DataEntities.Worker Worker
        {
            get
            {
                return this._Worker;
            }
            set
            {
                this.OnWorkerChanging(value);
                this._Worker = value;
                this.OnWorkerChanged();
                this.OnPropertyChanged("Worker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _Worker;
        partial void OnWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnWorkerChanged();
        /// <summary>
        /// There are no comments for Property InventoryCountingJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> InventoryCountingJournalLine
        {
            get
            {
                return this._InventoryCountingJournalLine;
            }
            set
            {
                this.OnInventoryCountingJournalLineChanging(value);
                this._InventoryCountingJournalLine = value;
                this.OnInventoryCountingJournalLineChanged();
                this.OnPropertyChanged("InventoryCountingJournalLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> _InventoryCountingJournalLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnInventoryCountingJournalLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> value);
        partial void OnInventoryCountingJournalLineChanged();
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
