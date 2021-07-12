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
        /// There are no comments for DeductionArrearSingle in the schema.
        /// </summary>
    public partial class DeductionArrearSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DeductionArrear>
    {
        /// <summary>
        /// Initialize a new DeductionArrearSingle object.
        /// </summary>
        public DeductionArrearSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DeductionArrearSingle object.
        /// </summary>
        public DeductionArrearSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DeductionArrearSingle object.
        /// </summary>
        public DeductionArrearSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DeductionArrear> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Benefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitSingle Benefit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Benefit == null))
                {
                    this._Benefit = new global::Microsoft.Dynamics.DataEntities.BenefitSingle(this.Context, GetPath("Benefit"));
                }
                return this._Benefit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitSingle _Benefit;
        /// <summary>
        /// There are no comments for PayStatementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayStatementHeaderSingle PayStatementHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayStatementHeader == null))
                {
                    this._PayStatementHeader = new global::Microsoft.Dynamics.DataEntities.PayStatementHeaderSingle(this.Context, GetPath("PayStatementHeader"));
                }
                return this._PayStatementHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayStatementHeaderSingle _PayStatementHeader;
    }
        /// <summary>
        /// There are no comments for DeductionArrear in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PayStatementNumber
    /// BenefitId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PayStatementNumber", "BenefitId")]
    [global::Microsoft.OData.Client.EntitySet("DeductionArrears")]
    public partial class DeductionArrear : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DeductionArrear object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="payStatementNumber">Initial value of PayStatementNumber.</param>
        /// <param name="benefitId">Initial value of BenefitId.</param>
        /// <param name="amountInTransactionCurrency">Initial value of AmountInTransactionCurrency.</param>
        /// <param name="payStatementHeader">Initial value of PayStatementHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DeductionArrear CreateDeductionArrear(string dataAreaId, string payStatementNumber, string benefitId, decimal amountInTransactionCurrency, global::Microsoft.Dynamics.DataEntities.PayStatementHeader payStatementHeader)
        {
            DeductionArrear deductionArrear = new DeductionArrear();
            deductionArrear.dataAreaId = dataAreaId;
            deductionArrear.PayStatementNumber = payStatementNumber;
            deductionArrear.BenefitId = benefitId;
            deductionArrear.AmountInTransactionCurrency = amountInTransactionCurrency;
            if ((payStatementHeader == null))
            {
                throw new global::System.ArgumentNullException("payStatementHeader");
            }
            deductionArrear.PayStatementHeader = payStatementHeader;
            return deductionArrear;
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
        /// There are no comments for Property PayStatementNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PayStatementNumber
        {
            get
            {
                return this._PayStatementNumber;
            }
            set
            {
                this.OnPayStatementNumberChanging(value);
                this._PayStatementNumber = value;
                this.OnPayStatementNumberChanged();
                this.OnPropertyChanged("PayStatementNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PayStatementNumber;
        partial void OnPayStatementNumberChanging(string value);
        partial void OnPayStatementNumberChanged();
        /// <summary>
        /// There are no comments for Property BenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BenefitId
        {
            get
            {
                return this._BenefitId;
            }
            set
            {
                this.OnBenefitIdChanging(value);
                this._BenefitId = value;
                this.OnBenefitIdChanged();
                this.OnPropertyChanged("BenefitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitId;
        partial void OnBenefitIdChanging(string value);
        partial void OnBenefitIdChanged();
        /// <summary>
        /// There are no comments for Property FullyRecovered in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> FullyRecovered
        {
            get
            {
                return this._FullyRecovered;
            }
            set
            {
                this.OnFullyRecoveredChanging(value);
                this._FullyRecovered = value;
                this.OnFullyRecoveredChanged();
                this.OnPropertyChanged("FullyRecovered");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _FullyRecovered;
        partial void OnFullyRecoveredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnFullyRecoveredChanged();
        /// <summary>
        /// There are no comments for Property AmountInTransactionCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AmountInTransactionCurrency
        {
            get
            {
                return this._AmountInTransactionCurrency;
            }
            set
            {
                this.OnAmountInTransactionCurrencyChanging(value);
                this._AmountInTransactionCurrency = value;
                this.OnAmountInTransactionCurrencyChanged();
                this.OnPropertyChanged("AmountInTransactionCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmountInTransactionCurrency;
        partial void OnAmountInTransactionCurrencyChanging(decimal value);
        partial void OnAmountInTransactionCurrencyChanged();
        /// <summary>
        /// There are no comments for Property Benefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Benefit Benefit
        {
            get
            {
                return this._Benefit;
            }
            set
            {
                this.OnBenefitChanging(value);
                this._Benefit = value;
                this.OnBenefitChanged();
                this.OnPropertyChanged("Benefit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Benefit _Benefit;
        partial void OnBenefitChanging(global::Microsoft.Dynamics.DataEntities.Benefit value);
        partial void OnBenefitChanged();
        /// <summary>
        /// There are no comments for Property PayStatementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayStatementHeader PayStatementHeader
        {
            get
            {
                return this._PayStatementHeader;
            }
            set
            {
                this.OnPayStatementHeaderChanging(value);
                this._PayStatementHeader = value;
                this.OnPayStatementHeaderChanged();
                this.OnPropertyChanged("PayStatementHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayStatementHeader _PayStatementHeader;
        partial void OnPayStatementHeaderChanging(global::Microsoft.Dynamics.DataEntities.PayStatementHeader value);
        partial void OnPayStatementHeaderChanged();
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
