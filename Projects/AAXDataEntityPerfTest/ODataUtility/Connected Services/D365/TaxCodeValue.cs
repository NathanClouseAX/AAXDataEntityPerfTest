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
        /// There are no comments for TaxCodeValueSingle in the schema.
        /// </summary>
    public partial class TaxCodeValueSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TaxCodeValue>
    {
        /// <summary>
        /// Initialize a new TaxCodeValueSingle object.
        /// </summary>
        public TaxCodeValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TaxCodeValueSingle object.
        /// </summary>
        public TaxCodeValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TaxCodeValueSingle object.
        /// </summary>
        public TaxCodeValueSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TaxCodeValue> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxCodeSingle TaxCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TaxCode == null))
                {
                    this._TaxCode = new global::Microsoft.Dynamics.DataEntities.TaxCodeSingle(this.Context, GetPath("TaxCode"));
                }
                return this._TaxCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxCodeSingle _TaxCode;
    }
        /// <summary>
        /// There are no comments for TaxCodeValue in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TaxCodeId
    /// FromDate
    /// ToDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TaxCodeId", "FromDate", "ToDate")]
    [global::Microsoft.OData.Client.EntitySet("TaxCodeValues")]
    public partial class TaxCodeValue : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxCodeValue object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="taxCodeId">Initial value of TaxCodeId.</param>
        /// <param name="fromDate">Initial value of FromDate.</param>
        /// <param name="toDate">Initial value of ToDate.</param>
        /// <param name="value">Initial value of Value.</param>
        /// <param name="duty">Initial value of Duty.</param>
        /// <param name="maximumLimit">Initial value of MaximumLimit.</param>
        /// <param name="nonDeductiblePercentage">Initial value of NonDeductiblePercentage.</param>
        /// <param name="minimumLimit">Initial value of MinimumLimit.</param>
        /// <param name="reductionPercentage">Initial value of ReductionPercentage.</param>
        /// <param name="substitutionMarkupPercentage">Initial value of SubstitutionMarkupPercentage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TaxCodeValue CreateTaxCodeValue(string dataAreaId, 
                    string taxCodeId, 
                    global::System.DateTimeOffset fromDate, 
                    global::System.DateTimeOffset toDate, 
                    decimal value, 
                    decimal duty, 
                    decimal maximumLimit, 
                    decimal nonDeductiblePercentage, 
                    decimal minimumLimit, 
                    decimal reductionPercentage, 
                    decimal substitutionMarkupPercentage)
        {
            TaxCodeValue taxCodeValue = new TaxCodeValue();
            taxCodeValue.dataAreaId = dataAreaId;
            taxCodeValue.TaxCodeId = taxCodeId;
            taxCodeValue.FromDate = fromDate;
            taxCodeValue.ToDate = toDate;
            taxCodeValue.Value = value;
            taxCodeValue.Duty = duty;
            taxCodeValue.MaximumLimit = maximumLimit;
            taxCodeValue.NonDeductiblePercentage = nonDeductiblePercentage;
            taxCodeValue.MinimumLimit = minimumLimit;
            taxCodeValue.ReductionPercentage = reductionPercentage;
            taxCodeValue.SubstitutionMarkupPercentage = substitutionMarkupPercentage;
            return taxCodeValue;
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
        /// There are no comments for Property TaxCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxCodeId
        {
            get
            {
                return this._TaxCodeId;
            }
            set
            {
                this.OnTaxCodeIdChanging(value);
                this._TaxCodeId = value;
                this.OnTaxCodeIdChanged();
                this.OnPropertyChanged("TaxCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxCodeId;
        partial void OnTaxCodeIdChanging(string value);
        partial void OnTaxCodeIdChanged();
        /// <summary>
        /// There are no comments for Property FromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset FromDate
        {
            get
            {
                return this._FromDate;
            }
            set
            {
                this.OnFromDateChanging(value);
                this._FromDate = value;
                this.OnFromDateChanged();
                this.OnPropertyChanged("FromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _FromDate;
        partial void OnFromDateChanging(global::System.DateTimeOffset value);
        partial void OnFromDateChanged();
        /// <summary>
        /// There are no comments for Property ToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ToDate
        {
            get
            {
                return this._ToDate;
            }
            set
            {
                this.OnToDateChanging(value);
                this._ToDate = value;
                this.OnToDateChanged();
                this.OnPropertyChanged("ToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ToDate;
        partial void OnToDateChanging(global::System.DateTimeOffset value);
        partial void OnToDateChanged();
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Value;
        partial void OnValueChanging(decimal value);
        partial void OnValueChanged();
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
        /// There are no comments for Property MaximumLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MaximumLimit
        {
            get
            {
                return this._MaximumLimit;
            }
            set
            {
                this.OnMaximumLimitChanging(value);
                this._MaximumLimit = value;
                this.OnMaximumLimitChanged();
                this.OnPropertyChanged("MaximumLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaximumLimit;
        partial void OnMaximumLimitChanging(decimal value);
        partial void OnMaximumLimitChanged();
        /// <summary>
        /// There are no comments for Property NonDeductiblePercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal NonDeductiblePercentage
        {
            get
            {
                return this._NonDeductiblePercentage;
            }
            set
            {
                this.OnNonDeductiblePercentageChanging(value);
                this._NonDeductiblePercentage = value;
                this.OnNonDeductiblePercentageChanged();
                this.OnPropertyChanged("NonDeductiblePercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _NonDeductiblePercentage;
        partial void OnNonDeductiblePercentageChanging(decimal value);
        partial void OnNonDeductiblePercentageChanged();
        /// <summary>
        /// There are no comments for Property MinimumLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MinimumLimit
        {
            get
            {
                return this._MinimumLimit;
            }
            set
            {
                this.OnMinimumLimitChanging(value);
                this._MinimumLimit = value;
                this.OnMinimumLimitChanged();
                this.OnPropertyChanged("MinimumLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MinimumLimit;
        partial void OnMinimumLimitChanging(decimal value);
        partial void OnMinimumLimitChanged();
        /// <summary>
        /// There are no comments for Property ReductionPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReductionPercentage
        {
            get
            {
                return this._ReductionPercentage;
            }
            set
            {
                this.OnReductionPercentageChanging(value);
                this._ReductionPercentage = value;
                this.OnReductionPercentageChanged();
                this.OnPropertyChanged("ReductionPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReductionPercentage;
        partial void OnReductionPercentageChanging(decimal value);
        partial void OnReductionPercentageChanged();
        /// <summary>
        /// There are no comments for Property SubstitutionMarkupPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SubstitutionMarkupPercentage
        {
            get
            {
                return this._SubstitutionMarkupPercentage;
            }
            set
            {
                this.OnSubstitutionMarkupPercentageChanging(value);
                this._SubstitutionMarkupPercentage = value;
                this.OnSubstitutionMarkupPercentageChanged();
                this.OnPropertyChanged("SubstitutionMarkupPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SubstitutionMarkupPercentage;
        partial void OnSubstitutionMarkupPercentageChanging(decimal value);
        partial void OnSubstitutionMarkupPercentageChanged();
        /// <summary>
        /// There are no comments for Property TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxCode TaxCode
        {
            get
            {
                return this._TaxCode;
            }
            set
            {
                this.OnTaxCodeChanging(value);
                this._TaxCode = value;
                this.OnTaxCodeChanged();
                this.OnPropertyChanged("TaxCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxCode _TaxCode;
        partial void OnTaxCodeChanging(global::Microsoft.Dynamics.DataEntities.TaxCode value);
        partial void OnTaxCodeChanged();
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
