﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:24:13 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for SADDocumentLinePurchaseOrderSingle in the schema.
    /// </summary>
    public partial class SADDocumentLinePurchaseOrderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SADDocumentLinePurchaseOrder>
    {
        /// <summary>
        /// Initialize a new SADDocumentLinePurchaseOrderSingle object.
        /// </summary>
        public SADDocumentLinePurchaseOrderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SADDocumentLinePurchaseOrderSingle object.
        /// </summary>
        public SADDocumentLinePurchaseOrderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SADDocumentLinePurchaseOrderSingle object.
        /// </summary>
        public SADDocumentLinePurchaseOrderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SADDocumentLinePurchaseOrder> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
    /// <summary>
    /// There are no comments for SADDocumentLinePurchaseOrder in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// DocumentCode
    /// Position
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DocumentCode", "Position")]
    [global::Microsoft.OData.Client.EntitySet("SADDocumentLinePurchaseOrders")]
    public partial class SADDocumentLinePurchaseOrder : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SADDocumentLinePurchaseOrder object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="documentCode">Initial value of DocumentCode.</param>
        /// <param name="position">Initial value of Position.</param>
        /// <param name="duty">Initial value of Duty.</param>
        /// <param name="baseForSAD">Initial value of BaseForSAD.</param>
        /// <param name="excise">Initial value of Excise.</param>
        /// <param name="salesTaxAmount">Initial value of SalesTaxAmount.</param>
        /// <param name="transport">Initial value of Transport.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SADDocumentLinePurchaseOrder CreateSADDocumentLinePurchaseOrder(string dataAreaId, 
                    string documentCode, 
                    int position, 
                    decimal duty, 
                    decimal baseForSAD, 
                    decimal excise, 
                    decimal salesTaxAmount, 
                    decimal transport)
        {
            SADDocumentLinePurchaseOrder sADDocumentLinePurchaseOrder = new SADDocumentLinePurchaseOrder();
            sADDocumentLinePurchaseOrder.dataAreaId = dataAreaId;
            sADDocumentLinePurchaseOrder.DocumentCode = documentCode;
            sADDocumentLinePurchaseOrder.Position = position;
            sADDocumentLinePurchaseOrder.Duty = duty;
            sADDocumentLinePurchaseOrder.BaseForSAD = baseForSAD;
            sADDocumentLinePurchaseOrder.Excise = excise;
            sADDocumentLinePurchaseOrder.SalesTaxAmount = salesTaxAmount;
            sADDocumentLinePurchaseOrder.Transport = transport;
            return sADDocumentLinePurchaseOrder;
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
        /// There are no comments for Property DocumentCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DocumentCode
        {
            get
            {
                return this._DocumentCode;
            }
            set
            {
                this.OnDocumentCodeChanging(value);
                this._DocumentCode = value;
                this.OnDocumentCodeChanged();
                this.OnPropertyChanged("DocumentCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentCode;
        partial void OnDocumentCodeChanging(string value);
        partial void OnDocumentCodeChanged();
        /// <summary>
        /// There are no comments for Property Position in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Position
        {
            get
            {
                return this._Position;
            }
            set
            {
                this.OnPositionChanging(value);
                this._Position = value;
                this.OnPositionChanged();
                this.OnPropertyChanged("Position");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Position;
        partial void OnPositionChanging(int value);
        partial void OnPositionChanged();
        /// <summary>
        /// There are no comments for Property SADGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SADGroup
        {
            get
            {
                return this._SADGroup;
            }
            set
            {
                this.OnSADGroupChanging(value);
                this._SADGroup = value;
                this.OnSADGroupChanged();
                this.OnPropertyChanged("SADGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SADGroup;
        partial void OnSADGroupChanging(string value);
        partial void OnSADGroupChanged();
        /// <summary>
        /// There are no comments for Property DimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionDisplayValue
        {
            get
            {
                return this._DimensionDisplayValue;
            }
            set
            {
                this.OnDimensionDisplayValueChanging(value);
                this._DimensionDisplayValue = value;
                this.OnDimensionDisplayValueChanged();
                this.OnPropertyChanged("DimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionDisplayValue;
        partial void OnDimensionDisplayValueChanging(string value);
        partial void OnDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property Duty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Duty
        {
            get
            {
                return this._Duty;
            }
            set
            {
                this.OnDutyChanging(value);
                this._Duty = value;
                this.OnDutyChanged();
                this.OnPropertyChanged("Duty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Duty;
        partial void OnDutyChanging(decimal value);
        partial void OnDutyChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesTaxCode
        {
            get
            {
                return this._SalesTaxCode;
            }
            set
            {
                this.OnSalesTaxCodeChanging(value);
                this._SalesTaxCode = value;
                this.OnSalesTaxCodeChanged();
                this.OnPropertyChanged("SalesTaxCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxCode;
        partial void OnSalesTaxCodeChanging(string value);
        partial void OnSalesTaxCodeChanged();
        /// <summary>
        /// There are no comments for Property BaseForSAD in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal BaseForSAD
        {
            get
            {
                return this._BaseForSAD;
            }
            set
            {
                this.OnBaseForSADChanging(value);
                this._BaseForSAD = value;
                this.OnBaseForSADChanged();
                this.OnPropertyChanged("BaseForSAD");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _BaseForSAD;
        partial void OnBaseForSADChanging(decimal value);
        partial void OnBaseForSADChanged();
        /// <summary>
        /// There are no comments for Property Excise in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Excise
        {
            get
            {
                return this._Excise;
            }
            set
            {
                this.OnExciseChanging(value);
                this._Excise = value;
                this.OnExciseChanged();
                this.OnPropertyChanged("Excise");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Excise;
        partial void OnExciseChanging(decimal value);
        partial void OnExciseChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SalesTaxAmount
        {
            get
            {
                return this._SalesTaxAmount;
            }
            set
            {
                this.OnSalesTaxAmountChanging(value);
                this._SalesTaxAmount = value;
                this.OnSalesTaxAmountChanged();
                this.OnPropertyChanged("SalesTaxAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SalesTaxAmount;
        partial void OnSalesTaxAmountChanging(decimal value);
        partial void OnSalesTaxAmountChanged();
        /// <summary>
        /// There are no comments for Property Transport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Transport
        {
            get
            {
                return this._Transport;
            }
            set
            {
                this.OnTransportChanging(value);
                this._Transport = value;
                this.OnTransportChanged();
                this.OnPropertyChanged("Transport");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Transport;
        partial void OnTransportChanging(decimal value);
        partial void OnTransportChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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