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
        /// There are no comments for CatchWeightItemHandlingPolicyV2Single in the schema.
        /// </summary>
    public partial class CatchWeightItemHandlingPolicyV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<CatchWeightItemHandlingPolicyV2>
    {
        /// <summary>
        /// Initialize a new CatchWeightItemHandlingPolicyV2Single object.
        /// </summary>
        public CatchWeightItemHandlingPolicyV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CatchWeightItemHandlingPolicyV2Single object.
        /// </summary>
        public CatchWeightItemHandlingPolicyV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CatchWeightItemHandlingPolicyV2Single object.
        /// </summary>
        public CatchWeightItemHandlingPolicyV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<CatchWeightItemHandlingPolicyV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductsV2 == null))
                {
                    this._ReleasedProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(GetPath("ReleasedProductsV2"));
                }
                return this._ReleasedProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2;
    }
        /// <summary>
        /// There are no comments for CatchWeightItemHandlingPolicyV2 in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PolicyName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PolicyName")]
    [global::Microsoft.OData.Client.EntitySet("CatchWeightItemHandlingPoliciesV2")]
    public partial class CatchWeightItemHandlingPolicyV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CatchWeightItemHandlingPolicyV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="policyName">Initial value of PolicyName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CatchWeightItemHandlingPolicyV2 CreateCatchWeightItemHandlingPolicyV2(string dataAreaId, string policyName)
        {
            CatchWeightItemHandlingPolicyV2 catchWeightItemHandlingPolicyV2 = new CatchWeightItemHandlingPolicyV2();
            catchWeightItemHandlingPolicyV2.dataAreaId = dataAreaId;
            catchWeightItemHandlingPolicyV2.PolicyName = policyName;
            return catchWeightItemHandlingPolicyV2;
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
        /// There are no comments for Property PolicyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PolicyName
        {
            get
            {
                return this._PolicyName;
            }
            set
            {
                this.OnPolicyNameChanging(value);
                this._PolicyName = value;
                this.OnPolicyNameChanged();
                this.OnPropertyChanged("PolicyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PolicyName;
        partial void OnPolicyNameChanging(string value);
        partial void OnPolicyNameChanged();
        /// <summary>
        /// There are no comments for Property InboundCatchWeightTagCapturingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSInboundCatchWeightTagCapturingMethod> InboundCatchWeightTagCapturingMethod
        {
            get
            {
                return this._InboundCatchWeightTagCapturingMethod;
            }
            set
            {
                this.OnInboundCatchWeightTagCapturingMethodChanging(value);
                this._InboundCatchWeightTagCapturingMethod = value;
                this.OnInboundCatchWeightTagCapturingMethodChanged();
                this.OnPropertyChanged("InboundCatchWeightTagCapturingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSInboundCatchWeightTagCapturingMethod> _InboundCatchWeightTagCapturingMethod;
        partial void OnInboundCatchWeightTagCapturingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSInboundCatchWeightTagCapturingMethod> value);
        partial void OnInboundCatchWeightTagCapturingMethodChanged();
        /// <summary>
        /// There are no comments for Property OutboundWeightCapturingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundWeightCapturingMethod> OutboundWeightCapturingMethod
        {
            get
            {
                return this._OutboundWeightCapturingMethod;
            }
            set
            {
                this.OnOutboundWeightCapturingMethodChanging(value);
                this._OutboundWeightCapturingMethod = value;
                this.OnOutboundWeightCapturingMethodChanged();
                this.OnPropertyChanged("OutboundWeightCapturingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundWeightCapturingMethod> _OutboundWeightCapturingMethod;
        partial void OnOutboundWeightCapturingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundWeightCapturingMethod> value);
        partial void OnOutboundWeightCapturingMethodChanged();
        /// <summary>
        /// There are no comments for Property OutboundWeightVarianceMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundWeightVarianceMethod> OutboundWeightVarianceMethod
        {
            get
            {
                return this._OutboundWeightVarianceMethod;
            }
            set
            {
                this.OnOutboundWeightVarianceMethodChanging(value);
                this._OutboundWeightVarianceMethod = value;
                this.OnOutboundWeightVarianceMethodChanged();
                this.OnPropertyChanged("OutboundWeightVarianceMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundWeightVarianceMethod> _OutboundWeightVarianceMethod;
        partial void OnOutboundWeightVarianceMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundWeightVarianceMethod> value);
        partial void OnOutboundWeightVarianceMethodChanged();
        /// <summary>
        /// There are no comments for Property PolicyDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PolicyDescription
        {
            get
            {
                return this._PolicyDescription;
            }
            set
            {
                this.OnPolicyDescriptionChanging(value);
                this._PolicyDescription = value;
                this.OnPolicyDescriptionChanged();
                this.OnPropertyChanged("PolicyDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PolicyDescription;
        partial void OnPolicyDescriptionChanging(string value);
        partial void OnPolicyDescriptionChanged();
        /// <summary>
        /// There are no comments for Property SalesOrderWeightCapturingProcess in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSSalesOrderWeightCapturingProcess> SalesOrderWeightCapturingProcess
        {
            get
            {
                return this._SalesOrderWeightCapturingProcess;
            }
            set
            {
                this.OnSalesOrderWeightCapturingProcessChanging(value);
                this._SalesOrderWeightCapturingProcess = value;
                this.OnSalesOrderWeightCapturingProcessChanged();
                this.OnPropertyChanged("SalesOrderWeightCapturingProcess");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSSalesOrderWeightCapturingProcess> _SalesOrderWeightCapturingProcess;
        partial void OnSalesOrderWeightCapturingProcessChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSSalesOrderWeightCapturingProcess> value);
        partial void OnSalesOrderWeightCapturingProcessChanged();
        /// <summary>
        /// There are no comments for Property OutboundCatchWeightTagCapturingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundCatchWeightTagCapturingMethod> OutboundCatchWeightTagCapturingMethod
        {
            get
            {
                return this._OutboundCatchWeightTagCapturingMethod;
            }
            set
            {
                this.OnOutboundCatchWeightTagCapturingMethodChanging(value);
                this._OutboundCatchWeightTagCapturingMethod = value;
                this.OnOutboundCatchWeightTagCapturingMethodChanged();
                this.OnPropertyChanged("OutboundCatchWeightTagCapturingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundCatchWeightTagCapturingMethod> _OutboundCatchWeightTagCapturingMethod;
        partial void OnOutboundCatchWeightTagCapturingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundCatchWeightTagCapturingMethod> value);
        partial void OnOutboundCatchWeightTagCapturingMethodChanged();
        /// <summary>
        /// There are no comments for Property WarehouseTransferWeightCapturingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSWarehouseTransferWeightCapturingMethod> WarehouseTransferWeightCapturingMethod
        {
            get
            {
                return this._WarehouseTransferWeightCapturingMethod;
            }
            set
            {
                this.OnWarehouseTransferWeightCapturingMethodChanging(value);
                this._WarehouseTransferWeightCapturingMethod = value;
                this.OnWarehouseTransferWeightCapturingMethodChanged();
                this.OnPropertyChanged("WarehouseTransferWeightCapturingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSWarehouseTransferWeightCapturingMethod> _WarehouseTransferWeightCapturingMethod;
        partial void OnWarehouseTransferWeightCapturingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSWarehouseTransferWeightCapturingMethod> value);
        partial void OnWarehouseTransferWeightCapturingMethodChanged();
        /// <summary>
        /// There are no comments for Property CatchWeightTagDimensionTrackingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSCatchWeightTagDimensionTrackingMethod> CatchWeightTagDimensionTrackingMethod
        {
            get
            {
                return this._CatchWeightTagDimensionTrackingMethod;
            }
            set
            {
                this.OnCatchWeightTagDimensionTrackingMethodChanging(value);
                this._CatchWeightTagDimensionTrackingMethod = value;
                this.OnCatchWeightTagDimensionTrackingMethodChanged();
                this.OnPropertyChanged("CatchWeightTagDimensionTrackingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSCatchWeightTagDimensionTrackingMethod> _CatchWeightTagDimensionTrackingMethod;
        partial void OnCatchWeightTagDimensionTrackingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSCatchWeightTagDimensionTrackingMethod> value);
        partial void OnCatchWeightTagDimensionTrackingMethodChanged();
        /// <summary>
        /// There are no comments for Property InboundWeightCapturingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSInboundWeightCapturingMethod> InboundWeightCapturingMethod
        {
            get
            {
                return this._InboundWeightCapturingMethod;
            }
            set
            {
                this.OnInboundWeightCapturingMethodChanging(value);
                this._InboundWeightCapturingMethod = value;
                this.OnInboundWeightCapturingMethodChanged();
                this.OnPropertyChanged("InboundWeightCapturingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSInboundWeightCapturingMethod> _InboundWeightCapturingMethod;
        partial void OnInboundWeightCapturingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSInboundWeightCapturingMethod> value);
        partial void OnInboundWeightCapturingMethodChanged();
        /// <summary>
        /// There are no comments for Property MovementWeightCapturingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSMovementWeightCapturingMethod> MovementWeightCapturingMethod
        {
            get
            {
                return this._MovementWeightCapturingMethod;
            }
            set
            {
                this.OnMovementWeightCapturingMethodChanging(value);
                this._MovementWeightCapturingMethod = value;
                this.OnMovementWeightCapturingMethodChanged();
                this.OnPropertyChanged("MovementWeightCapturingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSMovementWeightCapturingMethod> _MovementWeightCapturingMethod;
        partial void OnMovementWeightCapturingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSMovementWeightCapturingMethod> value);
        partial void OnMovementWeightCapturingMethodChanged();
        /// <summary>
        /// There are no comments for Property CountingWeightCapturingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSCycleCountWeightCapturingMethod> CountingWeightCapturingMethod
        {
            get
            {
                return this._CountingWeightCapturingMethod;
            }
            set
            {
                this.OnCountingWeightCapturingMethodChanging(value);
                this._CountingWeightCapturingMethod = value;
                this.OnCountingWeightCapturingMethodChanged();
                this.OnPropertyChanged("CountingWeightCapturingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSCycleCountWeightCapturingMethod> _CountingWeightCapturingMethod;
        partial void OnCountingWeightCapturingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSCycleCountWeightCapturingMethod> value);
        partial void OnCountingWeightCapturingMethodChanged();
        /// <summary>
        /// There are no comments for Property CorrectionWeightCapturingProcess in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSCountingWeightCapturingMethod> CorrectionWeightCapturingProcess
        {
            get
            {
                return this._CorrectionWeightCapturingProcess;
            }
            set
            {
                this.OnCorrectionWeightCapturingProcessChanging(value);
                this._CorrectionWeightCapturingProcess = value;
                this.OnCorrectionWeightCapturingProcessChanged();
                this.OnPropertyChanged("CorrectionWeightCapturingProcess");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSCountingWeightCapturingMethod> _CorrectionWeightCapturingProcess;
        partial void OnCorrectionWeightCapturingProcessChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSCountingWeightCapturingMethod> value);
        partial void OnCorrectionWeightCapturingProcessChanged();
        /// <summary>
        /// There are no comments for Property TransferIssueWeightCapturingProcess in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSTransferIssueWeightCapturingProcess> TransferIssueWeightCapturingProcess
        {
            get
            {
                return this._TransferIssueWeightCapturingProcess;
            }
            set
            {
                this.OnTransferIssueWeightCapturingProcessChanging(value);
                this._TransferIssueWeightCapturingProcess = value;
                this.OnTransferIssueWeightCapturingProcessChanged();
                this.OnPropertyChanged("TransferIssueWeightCapturingProcess");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSTransferIssueWeightCapturingProcess> _TransferIssueWeightCapturingProcess;
        partial void OnTransferIssueWeightCapturingProcessChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSTransferIssueWeightCapturingProcess> value);
        partial void OnTransferIssueWeightCapturingProcessChanged();
        /// <summary>
        /// There are no comments for Property CatchWeightTagTracking in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CatchWeightTagTracking
        {
            get
            {
                return this._CatchWeightTagTracking;
            }
            set
            {
                this.OnCatchWeightTagTrackingChanging(value);
                this._CatchWeightTagTracking = value;
                this.OnCatchWeightTagTrackingChanged();
                this.OnPropertyChanged("CatchWeightTagTracking");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CatchWeightTagTracking;
        partial void OnCatchWeightTagTrackingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCatchWeightTagTrackingChanged();
        /// <summary>
        /// There are no comments for Property ProductionPickingWeightCapturingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSProductionPickingWeightCapturingMethod> ProductionPickingWeightCapturingMethod
        {
            get
            {
                return this._ProductionPickingWeightCapturingMethod;
            }
            set
            {
                this.OnProductionPickingWeightCapturingMethodChanging(value);
                this._ProductionPickingWeightCapturingMethod = value;
                this.OnProductionPickingWeightCapturingMethodChanged();
                this.OnPropertyChanged("ProductionPickingWeightCapturingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSProductionPickingWeightCapturingMethod> _ProductionPickingWeightCapturingMethod;
        partial void OnProductionPickingWeightCapturingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSProductionPickingWeightCapturingMethod> value);
        partial void OnProductionPickingWeightCapturingMethodChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                return this._ReleasedProductsV2;
            }
            set
            {
                this.OnReleasedProductsV2Changing(value);
                this._ReleasedProductsV2 = value;
                this.OnReleasedProductsV2Changed();
                this.OnPropertyChanged("ReleasedProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> value);
        partial void OnReleasedProductsV2Changed();
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
