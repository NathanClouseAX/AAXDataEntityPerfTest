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
        /// There are no comments for PurchaseAgreementLinesFulfillmentSingle in the schema.
        /// </summary>
    public partial class PurchaseAgreementLinesFulfillmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PurchaseAgreementLinesFulfillment>
    {
        /// <summary>
        /// Initialize a new PurchaseAgreementLinesFulfillmentSingle object.
        /// </summary>
        public PurchaseAgreementLinesFulfillmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PurchaseAgreementLinesFulfillmentSingle object.
        /// </summary>
        public PurchaseAgreementLinesFulfillmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PurchaseAgreementLinesFulfillmentSingle object.
        /// </summary>
        public PurchaseAgreementLinesFulfillmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PurchaseAgreementLinesFulfillment> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PurchaseAgreementLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineSingle PurchaseAgreementLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PurchaseAgreementLine == null))
                {
                    this._PurchaseAgreementLine = new global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineSingle(this.Context, GetPath("PurchaseAgreementLine"));
                }
                return this._PurchaseAgreementLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineSingle _PurchaseAgreementLine;
        /// <summary>
        /// There are no comments for PurchPurchaseAgreementLineV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineV2Single PurchPurchaseAgreementLineV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PurchPurchaseAgreementLineV2 == null))
                {
                    this._PurchPurchaseAgreementLineV2 = new global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineV2Single(this.Context, GetPath("PurchPurchaseAgreementLineV2"));
                }
                return this._PurchPurchaseAgreementLineV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineV2Single _PurchPurchaseAgreementLineV2;
    }
        /// <summary>
        /// There are no comments for PurchaseAgreementLinesFulfillment in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PurchaseAgreementId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PurchaseAgreementId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("PurchaseAgreementLineFulfillment")]
    public partial class PurchaseAgreementLinesFulfillment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PurchaseAgreementLinesFulfillment object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="purchaseAgreementId">Initial value of PurchaseAgreementId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="invoicedAmount">Initial value of InvoicedAmount.</param>
        /// <param name="invoicedQuantity">Initial value of InvoicedQuantity.</param>
        /// <param name="remainingAmount">Initial value of RemainingAmount.</param>
        /// <param name="releasedAmount">Initial value of ReleasedAmount.</param>
        /// <param name="remainingCatchWeightQuantity">Initial value of RemainingCatchWeightQuantity.</param>
        /// <param name="committedCatchWeightQuantity">Initial value of CommittedCatchWeightQuantity.</param>
        /// <param name="receivedAmount">Initial value of ReceivedAmount.</param>
        /// <param name="committedAmount">Initial value of CommittedAmount.</param>
        /// <param name="releasedCatchWeightQuantity">Initial value of ReleasedCatchWeightQuantity.</param>
        /// <param name="invoicedCatchWeightQuantity">Initial value of InvoicedCatchWeightQuantity.</param>
        /// <param name="releasedQuantity">Initial value of ReleasedQuantity.</param>
        /// <param name="committedQuantity">Initial value of CommittedQuantity.</param>
        /// <param name="receivedQuantity">Initial value of ReceivedQuantity.</param>
        /// <param name="remainingQuantity">Initial value of RemainingQuantity.</param>
        /// <param name="receivedCatchWeightQuantity">Initial value of ReceivedCatchWeightQuantity.</param>
        /// <param name="purchaseAgreementLine">Initial value of PurchaseAgreementLine.</param>
        /// <param name="purchPurchaseAgreementLineV2">Initial value of PurchPurchaseAgreementLineV2.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PurchaseAgreementLinesFulfillment CreatePurchaseAgreementLinesFulfillment(string dataAreaId, 
                    string purchaseAgreementId, 
                    decimal lineNumber, 
                    decimal invoicedAmount, 
                    decimal invoicedQuantity, 
                    decimal remainingAmount, 
                    decimal releasedAmount, 
                    decimal remainingCatchWeightQuantity, 
                    decimal committedCatchWeightQuantity, 
                    decimal receivedAmount, 
                    decimal committedAmount, 
                    decimal releasedCatchWeightQuantity, 
                    decimal invoicedCatchWeightQuantity, 
                    decimal releasedQuantity, 
                    decimal committedQuantity, 
                    decimal receivedQuantity, 
                    decimal remainingQuantity, 
                    decimal receivedCatchWeightQuantity, 
                    global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLine purchaseAgreementLine, 
                    global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineV2 purchPurchaseAgreementLineV2)
        {
            PurchaseAgreementLinesFulfillment purchaseAgreementLinesFulfillment = new PurchaseAgreementLinesFulfillment();
            purchaseAgreementLinesFulfillment.dataAreaId = dataAreaId;
            purchaseAgreementLinesFulfillment.PurchaseAgreementId = purchaseAgreementId;
            purchaseAgreementLinesFulfillment.LineNumber = lineNumber;
            purchaseAgreementLinesFulfillment.InvoicedAmount = invoicedAmount;
            purchaseAgreementLinesFulfillment.InvoicedQuantity = invoicedQuantity;
            purchaseAgreementLinesFulfillment.RemainingAmount = remainingAmount;
            purchaseAgreementLinesFulfillment.ReleasedAmount = releasedAmount;
            purchaseAgreementLinesFulfillment.RemainingCatchWeightQuantity = remainingCatchWeightQuantity;
            purchaseAgreementLinesFulfillment.CommittedCatchWeightQuantity = committedCatchWeightQuantity;
            purchaseAgreementLinesFulfillment.ReceivedAmount = receivedAmount;
            purchaseAgreementLinesFulfillment.CommittedAmount = committedAmount;
            purchaseAgreementLinesFulfillment.ReleasedCatchWeightQuantity = releasedCatchWeightQuantity;
            purchaseAgreementLinesFulfillment.InvoicedCatchWeightQuantity = invoicedCatchWeightQuantity;
            purchaseAgreementLinesFulfillment.ReleasedQuantity = releasedQuantity;
            purchaseAgreementLinesFulfillment.CommittedQuantity = committedQuantity;
            purchaseAgreementLinesFulfillment.ReceivedQuantity = receivedQuantity;
            purchaseAgreementLinesFulfillment.RemainingQuantity = remainingQuantity;
            purchaseAgreementLinesFulfillment.ReceivedCatchWeightQuantity = receivedCatchWeightQuantity;
            if ((purchaseAgreementLine == null))
            {
                throw new global::System.ArgumentNullException("purchaseAgreementLine");
            }
            purchaseAgreementLinesFulfillment.PurchaseAgreementLine = purchaseAgreementLine;
            if ((purchPurchaseAgreementLineV2 == null))
            {
                throw new global::System.ArgumentNullException("purchPurchaseAgreementLineV2");
            }
            purchaseAgreementLinesFulfillment.PurchPurchaseAgreementLineV2 = purchPurchaseAgreementLineV2;
            return purchaseAgreementLinesFulfillment;
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
        /// There are no comments for Property PurchaseAgreementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PurchaseAgreementId
        {
            get
            {
                return this._PurchaseAgreementId;
            }
            set
            {
                this.OnPurchaseAgreementIdChanging(value);
                this._PurchaseAgreementId = value;
                this.OnPurchaseAgreementIdChanged();
                this.OnPropertyChanged("PurchaseAgreementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseAgreementId;
        partial void OnPurchaseAgreementIdChanging(string value);
        partial void OnPurchaseAgreementIdChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property InvoicedAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal InvoicedAmount
        {
            get
            {
                return this._InvoicedAmount;
            }
            set
            {
                this.OnInvoicedAmountChanging(value);
                this._InvoicedAmount = value;
                this.OnInvoicedAmountChanged();
                this.OnPropertyChanged("InvoicedAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InvoicedAmount;
        partial void OnInvoicedAmountChanging(decimal value);
        partial void OnInvoicedAmountChanged();
        /// <summary>
        /// There are no comments for Property InvoicedQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal InvoicedQuantity
        {
            get
            {
                return this._InvoicedQuantity;
            }
            set
            {
                this.OnInvoicedQuantityChanging(value);
                this._InvoicedQuantity = value;
                this.OnInvoicedQuantityChanged();
                this.OnPropertyChanged("InvoicedQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InvoicedQuantity;
        partial void OnInvoicedQuantityChanging(decimal value);
        partial void OnInvoicedQuantityChanged();
        /// <summary>
        /// There are no comments for Property RemainingAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RemainingAmount
        {
            get
            {
                return this._RemainingAmount;
            }
            set
            {
                this.OnRemainingAmountChanging(value);
                this._RemainingAmount = value;
                this.OnRemainingAmountChanged();
                this.OnPropertyChanged("RemainingAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RemainingAmount;
        partial void OnRemainingAmountChanging(decimal value);
        partial void OnRemainingAmountChanged();
        /// <summary>
        /// There are no comments for Property ReleasedAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReleasedAmount
        {
            get
            {
                return this._ReleasedAmount;
            }
            set
            {
                this.OnReleasedAmountChanging(value);
                this._ReleasedAmount = value;
                this.OnReleasedAmountChanged();
                this.OnPropertyChanged("ReleasedAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReleasedAmount;
        partial void OnReleasedAmountChanging(decimal value);
        partial void OnReleasedAmountChanged();
        /// <summary>
        /// There are no comments for Property RemainingCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RemainingCatchWeightQuantity
        {
            get
            {
                return this._RemainingCatchWeightQuantity;
            }
            set
            {
                this.OnRemainingCatchWeightQuantityChanging(value);
                this._RemainingCatchWeightQuantity = value;
                this.OnRemainingCatchWeightQuantityChanged();
                this.OnPropertyChanged("RemainingCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RemainingCatchWeightQuantity;
        partial void OnRemainingCatchWeightQuantityChanging(decimal value);
        partial void OnRemainingCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property CommittedCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CommittedCatchWeightQuantity
        {
            get
            {
                return this._CommittedCatchWeightQuantity;
            }
            set
            {
                this.OnCommittedCatchWeightQuantityChanging(value);
                this._CommittedCatchWeightQuantity = value;
                this.OnCommittedCatchWeightQuantityChanged();
                this.OnPropertyChanged("CommittedCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CommittedCatchWeightQuantity;
        partial void OnCommittedCatchWeightQuantityChanging(decimal value);
        partial void OnCommittedCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property ReceivedAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReceivedAmount
        {
            get
            {
                return this._ReceivedAmount;
            }
            set
            {
                this.OnReceivedAmountChanging(value);
                this._ReceivedAmount = value;
                this.OnReceivedAmountChanged();
                this.OnPropertyChanged("ReceivedAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReceivedAmount;
        partial void OnReceivedAmountChanging(decimal value);
        partial void OnReceivedAmountChanged();
        /// <summary>
        /// There are no comments for Property CommittedAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CommittedAmount
        {
            get
            {
                return this._CommittedAmount;
            }
            set
            {
                this.OnCommittedAmountChanging(value);
                this._CommittedAmount = value;
                this.OnCommittedAmountChanged();
                this.OnPropertyChanged("CommittedAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CommittedAmount;
        partial void OnCommittedAmountChanging(decimal value);
        partial void OnCommittedAmountChanged();
        /// <summary>
        /// There are no comments for Property ReleasedCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReleasedCatchWeightQuantity
        {
            get
            {
                return this._ReleasedCatchWeightQuantity;
            }
            set
            {
                this.OnReleasedCatchWeightQuantityChanging(value);
                this._ReleasedCatchWeightQuantity = value;
                this.OnReleasedCatchWeightQuantityChanged();
                this.OnPropertyChanged("ReleasedCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReleasedCatchWeightQuantity;
        partial void OnReleasedCatchWeightQuantityChanging(decimal value);
        partial void OnReleasedCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property InvoicedCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal InvoicedCatchWeightQuantity
        {
            get
            {
                return this._InvoicedCatchWeightQuantity;
            }
            set
            {
                this.OnInvoicedCatchWeightQuantityChanging(value);
                this._InvoicedCatchWeightQuantity = value;
                this.OnInvoicedCatchWeightQuantityChanged();
                this.OnPropertyChanged("InvoicedCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InvoicedCatchWeightQuantity;
        partial void OnInvoicedCatchWeightQuantityChanging(decimal value);
        partial void OnInvoicedCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property UnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UnitSymbol
        {
            get
            {
                return this._UnitSymbol;
            }
            set
            {
                this.OnUnitSymbolChanging(value);
                this._UnitSymbol = value;
                this.OnUnitSymbolChanged();
                this.OnPropertyChanged("UnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitSymbol;
        partial void OnUnitSymbolChanging(string value);
        partial void OnUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property ReleasedQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReleasedQuantity
        {
            get
            {
                return this._ReleasedQuantity;
            }
            set
            {
                this.OnReleasedQuantityChanging(value);
                this._ReleasedQuantity = value;
                this.OnReleasedQuantityChanged();
                this.OnPropertyChanged("ReleasedQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReleasedQuantity;
        partial void OnReleasedQuantityChanging(decimal value);
        partial void OnReleasedQuantityChanged();
        /// <summary>
        /// There are no comments for Property PurchaseAgreementLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PurchaseAgreementLegalEntityId
        {
            get
            {
                return this._PurchaseAgreementLegalEntityId;
            }
            set
            {
                this.OnPurchaseAgreementLegalEntityIdChanging(value);
                this._PurchaseAgreementLegalEntityId = value;
                this.OnPurchaseAgreementLegalEntityIdChanged();
                this.OnPropertyChanged("PurchaseAgreementLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseAgreementLegalEntityId;
        partial void OnPurchaseAgreementLegalEntityIdChanging(string value);
        partial void OnPurchaseAgreementLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property CommittedQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CommittedQuantity
        {
            get
            {
                return this._CommittedQuantity;
            }
            set
            {
                this.OnCommittedQuantityChanging(value);
                this._CommittedQuantity = value;
                this.OnCommittedQuantityChanged();
                this.OnPropertyChanged("CommittedQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CommittedQuantity;
        partial void OnCommittedQuantityChanging(decimal value);
        partial void OnCommittedQuantityChanged();
        /// <summary>
        /// There are no comments for Property ReceivedQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReceivedQuantity
        {
            get
            {
                return this._ReceivedQuantity;
            }
            set
            {
                this.OnReceivedQuantityChanging(value);
                this._ReceivedQuantity = value;
                this.OnReceivedQuantityChanged();
                this.OnPropertyChanged("ReceivedQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReceivedQuantity;
        partial void OnReceivedQuantityChanging(decimal value);
        partial void OnReceivedQuantityChanged();
        /// <summary>
        /// There are no comments for Property RemainingQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RemainingQuantity
        {
            get
            {
                return this._RemainingQuantity;
            }
            set
            {
                this.OnRemainingQuantityChanging(value);
                this._RemainingQuantity = value;
                this.OnRemainingQuantityChanged();
                this.OnPropertyChanged("RemainingQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RemainingQuantity;
        partial void OnRemainingQuantityChanging(decimal value);
        partial void OnRemainingQuantityChanged();
        /// <summary>
        /// There are no comments for Property ReceivedCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReceivedCatchWeightQuantity
        {
            get
            {
                return this._ReceivedCatchWeightQuantity;
            }
            set
            {
                this.OnReceivedCatchWeightQuantityChanging(value);
                this._ReceivedCatchWeightQuantity = value;
                this.OnReceivedCatchWeightQuantityChanged();
                this.OnPropertyChanged("ReceivedCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReceivedCatchWeightQuantity;
        partial void OnReceivedCatchWeightQuantityChanging(decimal value);
        partial void OnReceivedCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property PurchaseAgreementLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLine PurchaseAgreementLine
        {
            get
            {
                return this._PurchaseAgreementLine;
            }
            set
            {
                this.OnPurchaseAgreementLineChanging(value);
                this._PurchaseAgreementLine = value;
                this.OnPurchaseAgreementLineChanged();
                this.OnPropertyChanged("PurchaseAgreementLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLine _PurchaseAgreementLine;
        partial void OnPurchaseAgreementLineChanging(global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLine value);
        partial void OnPurchaseAgreementLineChanged();
        /// <summary>
        /// There are no comments for Property PurchPurchaseAgreementLineV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineV2 PurchPurchaseAgreementLineV2
        {
            get
            {
                return this._PurchPurchaseAgreementLineV2;
            }
            set
            {
                this.OnPurchPurchaseAgreementLineV2Changing(value);
                this._PurchPurchaseAgreementLineV2 = value;
                this.OnPurchPurchaseAgreementLineV2Changed();
                this.OnPropertyChanged("PurchPurchaseAgreementLineV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineV2 _PurchPurchaseAgreementLineV2;
        partial void OnPurchPurchaseAgreementLineV2Changing(global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineV2 value);
        partial void OnPurchPurchaseAgreementLineV2Changed();
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
