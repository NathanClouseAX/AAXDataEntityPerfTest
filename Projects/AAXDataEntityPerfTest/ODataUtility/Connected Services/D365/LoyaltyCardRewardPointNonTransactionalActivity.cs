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
    /// There are no comments for LoyaltyCardRewardPointNonTransactionalActivitySingle in the schema.
    /// </summary>
    public partial class LoyaltyCardRewardPointNonTransactionalActivitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LoyaltyCardRewardPointNonTransactionalActivity>
    {
        /// <summary>
        /// Initialize a new LoyaltyCardRewardPointNonTransactionalActivitySingle object.
        /// </summary>
        public LoyaltyCardRewardPointNonTransactionalActivitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LoyaltyCardRewardPointNonTransactionalActivitySingle object.
        /// </summary>
        public LoyaltyCardRewardPointNonTransactionalActivitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LoyaltyCardRewardPointNonTransactionalActivitySingle object.
        /// </summary>
        public LoyaltyCardRewardPointNonTransactionalActivitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LoyaltyCardRewardPointNonTransactionalActivity> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailAffiliation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailAffiliationSingle RetailAffiliation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailAffiliation == null))
                {
                    this._RetailAffiliation = new global::Microsoft.Dynamics.DataEntities.RetailAffiliationSingle(this.Context, GetPath("RetailAffiliation"));
                }
                return this._RetailAffiliation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailAffiliationSingle _RetailAffiliation;
        /// <summary>
        /// There are no comments for OperatingUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle OperatingUnit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OperatingUnit == null))
                {
                    this._OperatingUnit = new global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle(this.Context, GetPath("OperatingUnit"));
                }
                return this._OperatingUnit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle _OperatingUnit;
    }
    /// <summary>
    /// There are no comments for LoyaltyCardRewardPointNonTransactionalActivity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// NonTransactionalActivityId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("NonTransactionalActivityId")]
    [global::Microsoft.OData.Client.EntitySet("LoyaltyCardRewardPointNonTransactionalActivities")]
    public partial class LoyaltyCardRewardPointNonTransactionalActivity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LoyaltyCardRewardPointNonTransactionalActivity object.
        /// </summary>
        /// <param name="nonTransactionalActivityId">Initial value of NonTransactionalActivityId.</param>
        /// <param name="entryTime">Initial value of EntryTime.</param>
        /// <param name="entryDate">Initial value of EntryDate.</param>
        /// <param name="oMOperatingUnitID">Initial value of OMOperatingUnitID.</param>
        /// <param name="retailAffiliationId">Initial value of RetailAffiliationId.</param>
        /// <param name="retailAffiliation">Initial value of RetailAffiliation.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LoyaltyCardRewardPointNonTransactionalActivity CreateLoyaltyCardRewardPointNonTransactionalActivity(string nonTransactionalActivityId, 
                    int entryTime, 
                    global::System.DateTimeOffset entryDate, 
                    long oMOperatingUnitID, 
                    long retailAffiliationId, 
                    global::Microsoft.Dynamics.DataEntities.RetailAffiliation retailAffiliation)
        {
            LoyaltyCardRewardPointNonTransactionalActivity loyaltyCardRewardPointNonTransactionalActivity = new LoyaltyCardRewardPointNonTransactionalActivity();
            loyaltyCardRewardPointNonTransactionalActivity.NonTransactionalActivityId = nonTransactionalActivityId;
            loyaltyCardRewardPointNonTransactionalActivity.EntryTime = entryTime;
            loyaltyCardRewardPointNonTransactionalActivity.EntryDate = entryDate;
            loyaltyCardRewardPointNonTransactionalActivity.OMOperatingUnitID = oMOperatingUnitID;
            loyaltyCardRewardPointNonTransactionalActivity.RetailAffiliationId = retailAffiliationId;
            if ((retailAffiliation == null))
            {
                throw new global::System.ArgumentNullException("retailAffiliation");
            }
            loyaltyCardRewardPointNonTransactionalActivity.RetailAffiliation = retailAffiliation;
            return loyaltyCardRewardPointNonTransactionalActivity;
        }
        /// <summary>
        /// There are no comments for Property NonTransactionalActivityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NonTransactionalActivityId is required.")]
        public virtual string NonTransactionalActivityId
        {
            get
            {
                return this._NonTransactionalActivityId;
            }
            set
            {
                this.OnNonTransactionalActivityIdChanging(value);
                this._NonTransactionalActivityId = value;
                this.OnNonTransactionalActivityIdChanged();
                this.OnPropertyChanged("NonTransactionalActivityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NonTransactionalActivityId;
        partial void OnNonTransactionalActivityIdChanging(string value);
        partial void OnNonTransactionalActivityIdChanged();
        /// <summary>
        /// There are no comments for Property CardNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string CardNumber
        {
            get
            {
                return this._CardNumber;
            }
            set
            {
                this.OnCardNumberChanging(value);
                this._CardNumber = value;
                this.OnCardNumberChanged();
                this.OnPropertyChanged("CardNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CardNumber;
        partial void OnCardNumberChanging(string value);
        partial void OnCardNumberChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyCardRewardPointNonTransactionalActivityStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyCardRewardPointNonTransactionalActivityStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyCardRewardPointNonTransactionalActivityStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property EntryTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EntryTime is required.")]
        public virtual int EntryTime
        {
            get
            {
                return this._EntryTime;
            }
            set
            {
                this.OnEntryTimeChanging(value);
                this._EntryTime = value;
                this.OnEntryTimeChanged();
                this.OnPropertyChanged("EntryTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _EntryTime;
        partial void OnEntryTimeChanging(int value);
        partial void OnEntryTimeChanged();
        /// <summary>
        /// There are no comments for Property LoyaltyOtherActivityTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string LoyaltyOtherActivityTypeId
        {
            get
            {
                return this._LoyaltyOtherActivityTypeId;
            }
            set
            {
                this.OnLoyaltyOtherActivityTypeIdChanging(value);
                this._LoyaltyOtherActivityTypeId = value;
                this.OnLoyaltyOtherActivityTypeIdChanged();
                this.OnPropertyChanged("LoyaltyOtherActivityTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LoyaltyOtherActivityTypeId;
        partial void OnLoyaltyOtherActivityTypeIdChanging(string value);
        partial void OnLoyaltyOtherActivityTypeIdChanged();
        /// <summary>
        /// There are no comments for Property EntryDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EntryDate is required.")]
        public virtual global::System.DateTimeOffset EntryDate
        {
            get
            {
                return this._EntryDate;
            }
            set
            {
                this.OnEntryDateChanging(value);
                this._EntryDate = value;
                this.OnEntryDateChanged();
                this.OnPropertyChanged("EntryDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EntryDate;
        partial void OnEntryDateChanging(global::System.DateTimeOffset value);
        partial void OnEntryDateChanged();
        /// <summary>
        /// There are no comments for Property ErrorLogs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ErrorLogs
        {
            get
            {
                return this._ErrorLogs;
            }
            set
            {
                this.OnErrorLogsChanging(value);
                this._ErrorLogs = value;
                this.OnErrorLogsChanged();
                this.OnPropertyChanged("ErrorLogs");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ErrorLogs;
        partial void OnErrorLogsChanging(string value);
        partial void OnErrorLogsChanged();
        /// <summary>
        /// There are no comments for Property OMOperatingUnitID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OMOperatingUnitID is required.")]
        public virtual long OMOperatingUnitID
        {
            get
            {
                return this._OMOperatingUnitID;
            }
            set
            {
                this.OnOMOperatingUnitIDChanging(value);
                this._OMOperatingUnitID = value;
                this.OnOMOperatingUnitIDChanged();
                this.OnPropertyChanged("OMOperatingUnitID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _OMOperatingUnitID;
        partial void OnOMOperatingUnitIDChanging(long value);
        partial void OnOMOperatingUnitIDChanged();
        /// <summary>
        /// There are no comments for Property RetailAffiliationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailAffiliationId is required.")]
        public virtual long RetailAffiliationId
        {
            get
            {
                return this._RetailAffiliationId;
            }
            set
            {
                this.OnRetailAffiliationIdChanging(value);
                this._RetailAffiliationId = value;
                this.OnRetailAffiliationIdChanged();
                this.OnPropertyChanged("RetailAffiliationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _RetailAffiliationId;
        partial void OnRetailAffiliationIdChanging(long value);
        partial void OnRetailAffiliationIdChanged();
        /// <summary>
        /// There are no comments for Property RetailAffiliation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailAffiliation is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailAffiliation RetailAffiliation
        {
            get
            {
                return this._RetailAffiliation;
            }
            set
            {
                this.OnRetailAffiliationChanging(value);
                this._RetailAffiliation = value;
                this.OnRetailAffiliationChanged();
                this.OnPropertyChanged("RetailAffiliation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailAffiliation _RetailAffiliation;
        partial void OnRetailAffiliationChanging(global::Microsoft.Dynamics.DataEntities.RetailAffiliation value);
        partial void OnRetailAffiliationChanged();
        /// <summary>
        /// There are no comments for Property OperatingUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.Dynamics.DataEntities.OperatingUnit OperatingUnit
        {
            get
            {
                return this._OperatingUnit;
            }
            set
            {
                this.OnOperatingUnitChanging(value);
                this._OperatingUnit = value;
                this.OnOperatingUnitChanged();
                this.OnPropertyChanged("OperatingUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperatingUnit _OperatingUnit;
        partial void OnOperatingUnitChanging(global::Microsoft.Dynamics.DataEntities.OperatingUnit value);
        partial void OnOperatingUnitChanged();
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
