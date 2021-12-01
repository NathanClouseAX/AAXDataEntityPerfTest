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
    /// There are no comments for SADParametersSingle in the schema.
    /// </summary>
    public partial class SADParametersSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SADParameters>
    {
        /// <summary>
        /// Initialize a new SADParametersSingle object.
        /// </summary>
        public SADParametersSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SADParametersSingle object.
        /// </summary>
        public SADParametersSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SADParametersSingle object.
        /// </summary>
        public SADParametersSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SADParameters> query)
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
    /// There are no comments for SADParameters in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId")]
    [global::Microsoft.OData.Client.EntitySet("SADParameters")]
    public partial class SADParameters : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SADParameters object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="vATRounding">Initial value of VATRounding.</param>
        /// <param name="exciseTaxRounding">Initial value of ExciseTaxRounding.</param>
        /// <param name="dutyRounding">Initial value of DutyRounding.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SADParameters CreateSADParameters(string dataAreaId, decimal vATRounding, decimal exciseTaxRounding, decimal dutyRounding)
        {
            SADParameters sADParameters = new SADParameters();
            sADParameters.dataAreaId = dataAreaId;
            sADParameters.VATRounding = vATRounding;
            sADParameters.ExciseTaxRounding = exciseTaxRounding;
            sADParameters.DutyRounding = dutyRounding;
            return sADParameters;
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
        /// There are no comments for Property AdditionalCostsFormInvoice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlSADPostingRule> AdditionalCostsFormInvoice
        {
            get
            {
                return this._AdditionalCostsFormInvoice;
            }
            set
            {
                this.OnAdditionalCostsFormInvoiceChanging(value);
                this._AdditionalCostsFormInvoice = value;
                this.OnAdditionalCostsFormInvoiceChanged();
                this.OnPropertyChanged("AdditionalCostsFormInvoice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlSADPostingRule> _AdditionalCostsFormInvoice;
        partial void OnAdditionalCostsFormInvoiceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlSADPostingRule> value);
        partial void OnAdditionalCostsFormInvoiceChanged();
        /// <summary>
        /// There are no comments for Property InsuranceAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string InsuranceAccountDisplayValue
        {
            get
            {
                return this._InsuranceAccountDisplayValue;
            }
            set
            {
                this.OnInsuranceAccountDisplayValueChanging(value);
                this._InsuranceAccountDisplayValue = value;
                this.OnInsuranceAccountDisplayValueChanged();
                this.OnPropertyChanged("InsuranceAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InsuranceAccountDisplayValue;
        partial void OnInsuranceAccountDisplayValueChanging(string value);
        partial void OnInsuranceAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property VATRounding in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VATRounding is required.")]
        public virtual decimal VATRounding
        {
            get
            {
                return this._VATRounding;
            }
            set
            {
                this.OnVATRoundingChanging(value);
                this._VATRounding = value;
                this.OnVATRoundingChanged();
                this.OnPropertyChanged("VATRounding");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _VATRounding;
        partial void OnVATRoundingChanging(decimal value);
        partial void OnVATRoundingChanged();
        /// <summary>
        /// There are no comments for Property TransportOnSADDocumentAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TransportOnSADDocumentAccountDisplayValue
        {
            get
            {
                return this._TransportOnSADDocumentAccountDisplayValue;
            }
            set
            {
                this.OnTransportOnSADDocumentAccountDisplayValueChanging(value);
                this._TransportOnSADDocumentAccountDisplayValue = value;
                this.OnTransportOnSADDocumentAccountDisplayValueChanged();
                this.OnPropertyChanged("TransportOnSADDocumentAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransportOnSADDocumentAccountDisplayValue;
        partial void OnTransportOnSADDocumentAccountDisplayValueChanging(string value);
        partial void OnTransportOnSADDocumentAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property ExciseTaxRounding in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExciseTaxRounding is required.")]
        public virtual decimal ExciseTaxRounding
        {
            get
            {
                return this._ExciseTaxRounding;
            }
            set
            {
                this.OnExciseTaxRoundingChanging(value);
                this._ExciseTaxRounding = value;
                this.OnExciseTaxRoundingChanged();
                this.OnPropertyChanged("ExciseTaxRounding");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExciseTaxRounding;
        partial void OnExciseTaxRoundingChanging(decimal value);
        partial void OnExciseTaxRoundingChanged();
        /// <summary>
        /// There are no comments for Property MiscPayments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlSADPostingRule> MiscPayments
        {
            get
            {
                return this._MiscPayments;
            }
            set
            {
                this.OnMiscPaymentsChanging(value);
                this._MiscPayments = value;
                this.OnMiscPaymentsChanged();
                this.OnPropertyChanged("MiscPayments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlSADPostingRule> _MiscPayments;
        partial void OnMiscPaymentsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlSADPostingRule> value);
        partial void OnMiscPaymentsChanged();
        /// <summary>
        /// There are no comments for Property DutyRounding in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DutyRounding is required.")]
        public virtual decimal DutyRounding
        {
            get
            {
                return this._DutyRounding;
            }
            set
            {
                this.OnDutyRoundingChanging(value);
                this._DutyRounding = value;
                this.OnDutyRoundingChanged();
                this.OnPropertyChanged("DutyRounding");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DutyRounding;
        partial void OnDutyRoundingChanging(decimal value);
        partial void OnDutyRoundingChanged();
        /// <summary>
        /// There are no comments for Property MiscPaymentsAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string MiscPaymentsAccountDisplayValue
        {
            get
            {
                return this._MiscPaymentsAccountDisplayValue;
            }
            set
            {
                this.OnMiscPaymentsAccountDisplayValueChanging(value);
                this._MiscPaymentsAccountDisplayValue = value;
                this.OnMiscPaymentsAccountDisplayValueChanged();
                this.OnPropertyChanged("MiscPaymentsAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MiscPaymentsAccountDisplayValue;
        partial void OnMiscPaymentsAccountDisplayValueChanging(string value);
        partial void OnMiscPaymentsAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property MiscellaneousChargesFromTheSADDocumentAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string MiscellaneousChargesFromTheSADDocumentAccountDisplayValue
        {
            get
            {
                return this._MiscellaneousChargesFromTheSADDocumentAccountDisplayValue;
            }
            set
            {
                this.OnMiscellaneousChargesFromTheSADDocumentAccountDisplayValueChanging(value);
                this._MiscellaneousChargesFromTheSADDocumentAccountDisplayValue = value;
                this.OnMiscellaneousChargesFromTheSADDocumentAccountDisplayValueChanged();
                this.OnPropertyChanged("MiscellaneousChargesFromTheSADDocumentAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MiscellaneousChargesFromTheSADDocumentAccountDisplayValue;
        partial void OnMiscellaneousChargesFromTheSADDocumentAccountDisplayValueChanging(string value);
        partial void OnMiscellaneousChargesFromTheSADDocumentAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TransportAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TransportAccountDisplayValue
        {
            get
            {
                return this._TransportAccountDisplayValue;
            }
            set
            {
                this.OnTransportAccountDisplayValueChanging(value);
                this._TransportAccountDisplayValue = value;
                this.OnTransportAccountDisplayValueChanged();
                this.OnPropertyChanged("TransportAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransportAccountDisplayValue;
        partial void OnTransportAccountDisplayValueChanging(string value);
        partial void OnTransportAccountDisplayValueChanged();
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
