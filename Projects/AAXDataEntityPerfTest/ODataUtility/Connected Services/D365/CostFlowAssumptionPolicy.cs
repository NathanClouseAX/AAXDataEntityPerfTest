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
        /// There are no comments for CostFlowAssumptionPolicySingle in the schema.
        /// </summary>
    public partial class CostFlowAssumptionPolicySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CostFlowAssumptionPolicy>
    {
        /// <summary>
        /// Initialize a new CostFlowAssumptionPolicySingle object.
        /// </summary>
        public CostFlowAssumptionPolicySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CostFlowAssumptionPolicySingle object.
        /// </summary>
        public CostFlowAssumptionPolicySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CostFlowAssumptionPolicySingle object.
        /// </summary>
        public CostFlowAssumptionPolicySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CostFlowAssumptionPolicy> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for InventoryPolicy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.InventoryPolicySingle InventoryPolicy
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._InventoryPolicy == null))
                {
                    this._InventoryPolicy = new global::Microsoft.Dynamics.DataEntities.InventoryPolicySingle(this.Context, GetPath("InventoryPolicy"));
                }
                return this._InventoryPolicy;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.InventoryPolicySingle _InventoryPolicy;
    }
        /// <summary>
        /// There are no comments for CostFlowAssumptionPolicy in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PolicyId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PolicyId")]
    [global::Microsoft.OData.Client.EntitySet("CostFlowAssumptionPolicies")]
    public partial class CostFlowAssumptionPolicy : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CostFlowAssumptionPolicy object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="policyId">Initial value of PolicyId.</param>
        /// <param name="inventoryPolicy">Initial value of InventoryPolicy.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CostFlowAssumptionPolicy CreateCostFlowAssumptionPolicy(string dataAreaId, string policyId, global::Microsoft.Dynamics.DataEntities.InventoryPolicy inventoryPolicy)
        {
            CostFlowAssumptionPolicy costFlowAssumptionPolicy = new CostFlowAssumptionPolicy();
            costFlowAssumptionPolicy.dataAreaId = dataAreaId;
            costFlowAssumptionPolicy.PolicyId = policyId;
            if ((inventoryPolicy == null))
            {
                throw new global::System.ArgumentNullException("inventoryPolicy");
            }
            costFlowAssumptionPolicy.InventoryPolicy = inventoryPolicy;
            return costFlowAssumptionPolicy;
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
        /// There are no comments for Property PolicyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PolicyId
        {
            get
            {
                return this._PolicyId;
            }
            set
            {
                this.OnPolicyIdChanging(value);
                this._PolicyId = value;
                this.OnPolicyIdChanged();
                this.OnPropertyChanged("PolicyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PolicyId;
        partial void OnPolicyIdChanging(string value);
        partial void OnPolicyIdChanged();
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
        /// There are no comments for Property IsFinancialInventoryPosted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsFinancialInventoryPosted
        {
            get
            {
                return this._IsFinancialInventoryPosted;
            }
            set
            {
                this.OnIsFinancialInventoryPostedChanging(value);
                this._IsFinancialInventoryPosted = value;
                this.OnIsFinancialInventoryPostedChanged();
                this.OnPropertyChanged("IsFinancialInventoryPosted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsFinancialInventoryPosted;
        partial void OnIsFinancialInventoryPostedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsFinancialInventoryPostedChanged();
        /// <summary>
        /// There are no comments for Property IsFixedReceiptPriceUsed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsFixedReceiptPriceUsed
        {
            get
            {
                return this._IsFixedReceiptPriceUsed;
            }
            set
            {
                this.OnIsFixedReceiptPriceUsedChanging(value);
                this._IsFixedReceiptPriceUsed = value;
                this.OnIsFixedReceiptPriceUsedChanged();
                this.OnPropertyChanged("IsFixedReceiptPriceUsed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsFixedReceiptPriceUsed;
        partial void OnIsFixedReceiptPriceUsedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsFixedReceiptPriceUsedChanged();
        /// <summary>
        /// There are no comments for Property WillSalesDeliveryProcessPostDeferredRevenue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillSalesDeliveryProcessPostDeferredRevenue
        {
            get
            {
                return this._WillSalesDeliveryProcessPostDeferredRevenue;
            }
            set
            {
                this.OnWillSalesDeliveryProcessPostDeferredRevenueChanging(value);
                this._WillSalesDeliveryProcessPostDeferredRevenue = value;
                this.OnWillSalesDeliveryProcessPostDeferredRevenueChanged();
                this.OnPropertyChanged("WillSalesDeliveryProcessPostDeferredRevenue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillSalesDeliveryProcessPostDeferredRevenue;
        partial void OnWillSalesDeliveryProcessPostDeferredRevenueChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillSalesDeliveryProcessPostDeferredRevenueChanged();
        /// <summary>
        /// There are no comments for Property IsPhysicalInventoryPosted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPhysicalInventoryPosted
        {
            get
            {
                return this._IsPhysicalInventoryPosted;
            }
            set
            {
                this.OnIsPhysicalInventoryPostedChanging(value);
                this._IsPhysicalInventoryPosted = value;
                this.OnIsPhysicalInventoryPostedChanged();
                this.OnPropertyChanged("IsPhysicalInventoryPosted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPhysicalInventoryPosted;
        partial void OnIsPhysicalInventoryPostedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPhysicalInventoryPostedChanged();
        /// <summary>
        /// There are no comments for Property WillProductReceiptProcessingAccrueLiability in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillProductReceiptProcessingAccrueLiability
        {
            get
            {
                return this._WillProductReceiptProcessingAccrueLiability;
            }
            set
            {
                this.OnWillProductReceiptProcessingAccrueLiabilityChanging(value);
                this._WillProductReceiptProcessingAccrueLiability = value;
                this.OnWillProductReceiptProcessingAccrueLiabilityChanged();
                this.OnPropertyChanged("WillProductReceiptProcessingAccrueLiability");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillProductReceiptProcessingAccrueLiability;
        partial void OnWillProductReceiptProcessingAccrueLiabilityChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillProductReceiptProcessingAccrueLiabilityChanged();
        /// <summary>
        /// There are no comments for Property IsUnitCostIncludingPhysicallyUpdatedInventory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsUnitCostIncludingPhysicallyUpdatedInventory
        {
            get
            {
                return this._IsUnitCostIncludingPhysicallyUpdatedInventory;
            }
            set
            {
                this.OnIsUnitCostIncludingPhysicallyUpdatedInventoryChanging(value);
                this._IsUnitCostIncludingPhysicallyUpdatedInventory = value;
                this.OnIsUnitCostIncludingPhysicallyUpdatedInventoryChanged();
                this.OnPropertyChanged("IsUnitCostIncludingPhysicallyUpdatedInventory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsUnitCostIncludingPhysicallyUpdatedInventory;
        partial void OnIsUnitCostIncludingPhysicallyUpdatedInventoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsUnitCostIncludingPhysicallyUpdatedInventoryChanged();
        /// <summary>
        /// There are no comments for Property IsStockedProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsStockedProduct
        {
            get
            {
                return this._IsStockedProduct;
            }
            set
            {
                this.OnIsStockedProductChanging(value);
                this._IsStockedProduct = value;
                this.OnIsStockedProductChanged();
                this.OnPropertyChanged("IsStockedProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsStockedProduct;
        partial void OnIsStockedProductChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsStockedProductChanged();
        /// <summary>
        /// There are no comments for Property InventoryModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventModel> InventoryModel
        {
            get
            {
                return this._InventoryModel;
            }
            set
            {
                this.OnInventoryModelChanging(value);
                this._InventoryModel = value;
                this.OnInventoryModelChanged();
                this.OnPropertyChanged("InventoryModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventModel> _InventoryModel;
        partial void OnInventoryModelChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventModel> value);
        partial void OnInventoryModelChanged();
        /// <summary>
        /// There are no comments for Property InventoryPolicy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.InventoryPolicy InventoryPolicy
        {
            get
            {
                return this._InventoryPolicy;
            }
            set
            {
                this.OnInventoryPolicyChanging(value);
                this._InventoryPolicy = value;
                this.OnInventoryPolicyChanged();
                this.OnPropertyChanged("InventoryPolicy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.InventoryPolicy _InventoryPolicy;
        partial void OnInventoryPolicyChanging(global::Microsoft.Dynamics.DataEntities.InventoryPolicy value);
        partial void OnInventoryPolicyChanged();
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
