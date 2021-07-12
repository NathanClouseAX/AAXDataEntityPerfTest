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
        /// There are no comments for RebateAndDeductionsAgreementDealSingle in the schema.
        /// </summary>
    public partial class RebateAndDeductionsAgreementDealSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RebateAndDeductionsAgreementDeal>
    {
        /// <summary>
        /// Initialize a new RebateAndDeductionsAgreementDealSingle object.
        /// </summary>
        public RebateAndDeductionsAgreementDealSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RebateAndDeductionsAgreementDealSingle object.
        /// </summary>
        public RebateAndDeductionsAgreementDealSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RebateAndDeductionsAgreementDealSingle object.
        /// </summary>
        public RebateAndDeductionsAgreementDealSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RebateAndDeductionsAgreementDeal> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RebateAndDeductionsAgreementHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> RebateAndDeductionsAgreementHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RebateAndDeductionsAgreementHeaders == null))
                {
                    this._RebateAndDeductionsAgreementHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader>(GetPath("RebateAndDeductionsAgreementHeaders"));
                }
                return this._RebateAndDeductionsAgreementHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> _RebateAndDeductionsAgreementHeaders;
        /// <summary>
        /// There are no comments for RebateAndDeductionsStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RebateStatusTableSingle RebateAndDeductionsStatus
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RebateAndDeductionsStatus == null))
                {
                    this._RebateAndDeductionsStatus = new global::Microsoft.Dynamics.DataEntities.RebateStatusTableSingle(this.Context, GetPath("RebateAndDeductionsStatus"));
                }
                return this._RebateAndDeductionsStatus;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RebateStatusTableSingle _RebateAndDeductionsStatus;
        /// <summary>
        /// There are no comments for DealRebateAndDeductionsPostingProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsPostingProfileSingle DealRebateAndDeductionsPostingProfile
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DealRebateAndDeductionsPostingProfile == null))
                {
                    this._DealRebateAndDeductionsPostingProfile = new global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsPostingProfileSingle(this.Context, GetPath("DealRebateAndDeductionsPostingProfile"));
                }
                return this._DealRebateAndDeductionsPostingProfile;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsPostingProfileSingle _DealRebateAndDeductionsPostingProfile;
        /// <summary>
        /// There are no comments for DealGuaranteeRebateAndDeductionsPostingProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsPostingProfileSingle DealGuaranteeRebateAndDeductionsPostingProfile
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DealGuaranteeRebateAndDeductionsPostingProfile == null))
                {
                    this._DealGuaranteeRebateAndDeductionsPostingProfile = new global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsPostingProfileSingle(this.Context, GetPath("DealGuaranteeRebateAndDeductionsPostingProfile"));
                }
                return this._DealGuaranteeRebateAndDeductionsPostingProfile;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsPostingProfileSingle _DealGuaranteeRebateAndDeductionsPostingProfile;
    }
        /// <summary>
        /// There are no comments for RebateAndDeductionsAgreementDeal in the schema.
        /// </summary>
    /// <KeyProperties>
    /// DealNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DealNumber")]
    [global::Microsoft.OData.Client.EntitySet("RebateAndDeductionsAgreementDeals")]
    public partial class RebateAndDeductionsAgreementDeal : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RebateAndDeductionsAgreementDeal object.
        /// </summary>
        /// <param name="dealNumber">Initial value of DealNumber.</param>
        /// <param name="dealValidToDate">Initial value of DealValidToDate.</param>
        /// <param name="dealValidFromDate">Initial value of DealValidFromDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RebateAndDeductionsAgreementDeal CreateRebateAndDeductionsAgreementDeal(string dealNumber, global::System.DateTimeOffset dealValidToDate, global::System.DateTimeOffset dealValidFromDate)
        {
            RebateAndDeductionsAgreementDeal rebateAndDeductionsAgreementDeal = new RebateAndDeductionsAgreementDeal();
            rebateAndDeductionsAgreementDeal.DealNumber = dealNumber;
            rebateAndDeductionsAgreementDeal.DealValidToDate = dealValidToDate;
            rebateAndDeductionsAgreementDeal.DealValidFromDate = dealValidFromDate;
            return rebateAndDeductionsAgreementDeal;
        }
        /// <summary>
        /// There are no comments for Property DealNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DealNumber
        {
            get
            {
                return this._DealNumber;
            }
            set
            {
                this.OnDealNumberChanging(value);
                this._DealNumber = value;
                this.OnDealNumberChanged();
                this.OnPropertyChanged("DealNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DealNumber;
        partial void OnDealNumberChanging(string value);
        partial void OnDealNumberChanged();
        /// <summary>
        /// There are no comments for Property DealDocumentNotes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DealDocumentNotes
        {
            get
            {
                return this._DealDocumentNotes;
            }
            set
            {
                this.OnDealDocumentNotesChanging(value);
                this._DealDocumentNotes = value;
                this.OnDealDocumentNotesChanged();
                this.OnPropertyChanged("DealDocumentNotes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DealDocumentNotes;
        partial void OnDealDocumentNotesChanging(string value);
        partial void OnDealDocumentNotesChanged();
        /// <summary>
        /// There are no comments for Property DealPostingProfileId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DealPostingProfileId
        {
            get
            {
                return this._DealPostingProfileId;
            }
            set
            {
                this.OnDealPostingProfileIdChanging(value);
                this._DealPostingProfileId = value;
                this.OnDealPostingProfileIdChanged();
                this.OnPropertyChanged("DealPostingProfileId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DealPostingProfileId;
        partial void OnDealPostingProfileIdChanging(string value);
        partial void OnDealPostingProfileIdChanged();
        /// <summary>
        /// There are no comments for Property DealType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateType> DealType
        {
            get
            {
                return this._DealType;
            }
            set
            {
                this.OnDealTypeChanging(value);
                this._DealType = value;
                this.OnDealTypeChanged();
                this.OnPropertyChanged("DealType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateType> _DealType;
        partial void OnDealTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateType> value);
        partial void OnDealTypeChanged();
        /// <summary>
        /// There are no comments for Property DealOutputType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateOutputType> DealOutputType
        {
            get
            {
                return this._DealOutputType;
            }
            set
            {
                this.OnDealOutputTypeChanging(value);
                this._DealOutputType = value;
                this.OnDealOutputTypeChanged();
                this.OnPropertyChanged("DealOutputType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateOutputType> _DealOutputType;
        partial void OnDealOutputTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateOutputType> value);
        partial void OnDealOutputTypeChanged();
        /// <summary>
        /// There are no comments for Property DealCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DealCurrencyCode
        {
            get
            {
                return this._DealCurrencyCode;
            }
            set
            {
                this.OnDealCurrencyCodeChanging(value);
                this._DealCurrencyCode = value;
                this.OnDealCurrencyCodeChanged();
                this.OnPropertyChanged("DealCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DealCurrencyCode;
        partial void OnDealCurrencyCodeChanging(string value);
        partial void OnDealCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property GuaranteePostingProfileId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GuaranteePostingProfileId
        {
            get
            {
                return this._GuaranteePostingProfileId;
            }
            set
            {
                this.OnGuaranteePostingProfileIdChanging(value);
                this._GuaranteePostingProfileId = value;
                this.OnGuaranteePostingProfileIdChanged();
                this.OnPropertyChanged("GuaranteePostingProfileId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GuaranteePostingProfileId;
        partial void OnGuaranteePostingProfileIdChanging(string value);
        partial void OnGuaranteePostingProfileIdChanged();
        /// <summary>
        /// There are no comments for Property DealReconciliation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateReconciliation> DealReconciliation
        {
            get
            {
                return this._DealReconciliation;
            }
            set
            {
                this.OnDealReconciliationChanging(value);
                this._DealReconciliation = value;
                this.OnDealReconciliationChanged();
                this.OnPropertyChanged("DealReconciliation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateReconciliation> _DealReconciliation;
        partial void OnDealReconciliationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateReconciliation> value);
        partial void OnDealReconciliationChanged();
        /// <summary>
        /// There are no comments for Property IsDealActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDealActive
        {
            get
            {
                return this._IsDealActive;
            }
            set
            {
                this.OnIsDealActiveChanging(value);
                this._IsDealActive = value;
                this.OnIsDealActiveChanged();
                this.OnPropertyChanged("IsDealActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDealActive;
        partial void OnIsDealActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDealActiveChanged();
        /// <summary>
        /// There are no comments for Property WorkflowState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateDealWorkflowState> WorkflowState
        {
            get
            {
                return this._WorkflowState;
            }
            set
            {
                this.OnWorkflowStateChanging(value);
                this._WorkflowState = value;
                this.OnWorkflowStateChanged();
                this.OnPropertyChanged("WorkflowState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateDealWorkflowState> _WorkflowState;
        partial void OnWorkflowStateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateDealWorkflowState> value);
        partial void OnWorkflowStateChanged();
        /// <summary>
        /// There are no comments for Property DealValidToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DealValidToDate
        {
            get
            {
                return this._DealValidToDate;
            }
            set
            {
                this.OnDealValidToDateChanging(value);
                this._DealValidToDate = value;
                this.OnDealValidToDateChanged();
                this.OnPropertyChanged("DealValidToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DealValidToDate;
        partial void OnDealValidToDateChanging(global::System.DateTimeOffset value);
        partial void OnDealValidToDateChanged();
        /// <summary>
        /// There are no comments for Property DealValidFromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DealValidFromDate
        {
            get
            {
                return this._DealValidFromDate;
            }
            set
            {
                this.OnDealValidFromDateChanging(value);
                this._DealValidFromDate = value;
                this.OnDealValidFromDateChanged();
                this.OnPropertyChanged("DealValidFromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DealValidFromDate;
        partial void OnDealValidFromDateChanging(global::System.DateTimeOffset value);
        partial void OnDealValidFromDateChanged();
        /// <summary>
        /// There are no comments for Property RebateAndDeductionsStatusId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RebateAndDeductionsStatusId
        {
            get
            {
                return this._RebateAndDeductionsStatusId;
            }
            set
            {
                this.OnRebateAndDeductionsStatusIdChanging(value);
                this._RebateAndDeductionsStatusId = value;
                this.OnRebateAndDeductionsStatusIdChanged();
                this.OnPropertyChanged("RebateAndDeductionsStatusId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RebateAndDeductionsStatusId;
        partial void OnRebateAndDeductionsStatusIdChanging(string value);
        partial void OnRebateAndDeductionsStatusIdChanged();
        /// <summary>
        /// There are no comments for Property WillRebateDealProcessingProceedGuaranteeCumulative in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillRebateDealProcessingProceedGuaranteeCumulative
        {
            get
            {
                return this._WillRebateDealProcessingProceedGuaranteeCumulative;
            }
            set
            {
                this.OnWillRebateDealProcessingProceedGuaranteeCumulativeChanging(value);
                this._WillRebateDealProcessingProceedGuaranteeCumulative = value;
                this.OnWillRebateDealProcessingProceedGuaranteeCumulativeChanged();
                this.OnPropertyChanged("WillRebateDealProcessingProceedGuaranteeCumulative");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillRebateDealProcessingProceedGuaranteeCumulative;
        partial void OnWillRebateDealProcessingProceedGuaranteeCumulativeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillRebateDealProcessingProceedGuaranteeCumulativeChanged();
        /// <summary>
        /// There are no comments for Property DealModule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ModuleInventCustVend> DealModule
        {
            get
            {
                return this._DealModule;
            }
            set
            {
                this.OnDealModuleChanging(value);
                this._DealModule = value;
                this.OnDealModuleChanged();
                this.OnPropertyChanged("DealModule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ModuleInventCustVend> _DealModule;
        partial void OnDealModuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ModuleInventCustVend> value);
        partial void OnDealModuleChanged();
        /// <summary>
        /// There are no comments for Property DealDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DealDescription
        {
            get
            {
                return this._DealDescription;
            }
            set
            {
                this.OnDealDescriptionChanging(value);
                this._DealDescription = value;
                this.OnDealDescriptionChanged();
                this.OnPropertyChanged("DealDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DealDescription;
        partial void OnDealDescriptionChanging(string value);
        partial void OnDealDescriptionChanged();
        /// <summary>
        /// There are no comments for Property RebateAndDeductionsAgreementHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> RebateAndDeductionsAgreementHeaders
        {
            get
            {
                return this._RebateAndDeductionsAgreementHeaders;
            }
            set
            {
                this.OnRebateAndDeductionsAgreementHeadersChanging(value);
                this._RebateAndDeductionsAgreementHeaders = value;
                this.OnRebateAndDeductionsAgreementHeadersChanged();
                this.OnPropertyChanged("RebateAndDeductionsAgreementHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> _RebateAndDeductionsAgreementHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRebateAndDeductionsAgreementHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> value);
        partial void OnRebateAndDeductionsAgreementHeadersChanged();
        /// <summary>
        /// There are no comments for Property RebateAndDeductionsStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RebateStatusTable RebateAndDeductionsStatus
        {
            get
            {
                return this._RebateAndDeductionsStatus;
            }
            set
            {
                this.OnRebateAndDeductionsStatusChanging(value);
                this._RebateAndDeductionsStatus = value;
                this.OnRebateAndDeductionsStatusChanged();
                this.OnPropertyChanged("RebateAndDeductionsStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RebateStatusTable _RebateAndDeductionsStatus;
        partial void OnRebateAndDeductionsStatusChanging(global::Microsoft.Dynamics.DataEntities.RebateStatusTable value);
        partial void OnRebateAndDeductionsStatusChanged();
        /// <summary>
        /// There are no comments for Property DealRebateAndDeductionsPostingProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsPostingProfile DealRebateAndDeductionsPostingProfile
        {
            get
            {
                return this._DealRebateAndDeductionsPostingProfile;
            }
            set
            {
                this.OnDealRebateAndDeductionsPostingProfileChanging(value);
                this._DealRebateAndDeductionsPostingProfile = value;
                this.OnDealRebateAndDeductionsPostingProfileChanged();
                this.OnPropertyChanged("DealRebateAndDeductionsPostingProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsPostingProfile _DealRebateAndDeductionsPostingProfile;
        partial void OnDealRebateAndDeductionsPostingProfileChanging(global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsPostingProfile value);
        partial void OnDealRebateAndDeductionsPostingProfileChanged();
        /// <summary>
        /// There are no comments for Property DealGuaranteeRebateAndDeductionsPostingProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsPostingProfile DealGuaranteeRebateAndDeductionsPostingProfile
        {
            get
            {
                return this._DealGuaranteeRebateAndDeductionsPostingProfile;
            }
            set
            {
                this.OnDealGuaranteeRebateAndDeductionsPostingProfileChanging(value);
                this._DealGuaranteeRebateAndDeductionsPostingProfile = value;
                this.OnDealGuaranteeRebateAndDeductionsPostingProfileChanged();
                this.OnPropertyChanged("DealGuaranteeRebateAndDeductionsPostingProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsPostingProfile _DealGuaranteeRebateAndDeductionsPostingProfile;
        partial void OnDealGuaranteeRebateAndDeductionsPostingProfileChanging(global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsPostingProfile value);
        partial void OnDealGuaranteeRebateAndDeductionsPostingProfileChanged();
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
