﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for ExchangeRateCDSEntitySingle in the schema.
        /// </summary>
    public partial class ExchangeRateCDSEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ExchangeRateCDSEntity>
    {
        /// <summary>
        /// Initialize a new ExchangeRateCDSEntitySingle object.
        /// </summary>
        public ExchangeRateCDSEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ExchangeRateCDSEntitySingle object.
        /// </summary>
        public ExchangeRateCDSEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ExchangeRateCDSEntitySingle object.
        /// </summary>
        public ExchangeRateCDSEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ExchangeRateCDSEntity> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CurrencySingle Currency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Currency == null))
                {
                    this._Currency = new global::Microsoft.Dynamics.DataEntities.CurrencySingle(this.Context, GetPath("Currency"));
                }
                return this._Currency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CurrencySingle _Currency;
    }
        /// <summary>
        /// There are no comments for ExchangeRateCDSEntity in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ExchangeRateTypeName
    /// FromCurrencyCode
    /// ToCurrencyCode
    /// ValidFrom
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ExchangeRateTypeName", "FromCurrencyCode", "ToCurrencyCode", "ValidFrom")]
    [global::Microsoft.OData.Client.EntitySet("ExchangeRatesCDSEntity")]
    public partial class ExchangeRateCDSEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ExchangeRateCDSEntity object.
        /// </summary>
        /// <param name="exchangeRateTypeName">Initial value of ExchangeRateTypeName.</param>
        /// <param name="fromCurrencyCode">Initial value of FromCurrencyCode.</param>
        /// <param name="toCurrencyCode">Initial value of ToCurrencyCode.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="rate">Initial value of Rate.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ExchangeRateCDSEntity CreateExchangeRateCDSEntity(string exchangeRateTypeName, 
                    string fromCurrencyCode, 
                    string toCurrencyCode, 
                    global::System.DateTimeOffset validFrom, 
                    decimal rate, 
                    global::System.DateTimeOffset validTo)
        {
            ExchangeRateCDSEntity exchangeRateCDSEntity = new ExchangeRateCDSEntity();
            exchangeRateCDSEntity.ExchangeRateTypeName = exchangeRateTypeName;
            exchangeRateCDSEntity.FromCurrencyCode = fromCurrencyCode;
            exchangeRateCDSEntity.ToCurrencyCode = toCurrencyCode;
            exchangeRateCDSEntity.ValidFrom = validFrom;
            exchangeRateCDSEntity.Rate = rate;
            exchangeRateCDSEntity.ValidTo = validTo;
            return exchangeRateCDSEntity;
        }
        /// <summary>
        /// There are no comments for Property ExchangeRateTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ExchangeRateTypeName
        {
            get
            {
                return this._ExchangeRateTypeName;
            }
            set
            {
                this.OnExchangeRateTypeNameChanging(value);
                this._ExchangeRateTypeName = value;
                this.OnExchangeRateTypeNameChanged();
                this.OnPropertyChanged("ExchangeRateTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExchangeRateTypeName;
        partial void OnExchangeRateTypeNameChanging(string value);
        partial void OnExchangeRateTypeNameChanged();
        /// <summary>
        /// There are no comments for Property FromCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FromCurrencyCode
        {
            get
            {
                return this._FromCurrencyCode;
            }
            set
            {
                this.OnFromCurrencyCodeChanging(value);
                this._FromCurrencyCode = value;
                this.OnFromCurrencyCodeChanged();
                this.OnPropertyChanged("FromCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FromCurrencyCode;
        partial void OnFromCurrencyCodeChanging(string value);
        partial void OnFromCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property ToCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ToCurrencyCode
        {
            get
            {
                return this._ToCurrencyCode;
            }
            set
            {
                this.OnToCurrencyCodeChanging(value);
                this._ToCurrencyCode = value;
                this.OnToCurrencyCodeChanged();
                this.OnPropertyChanged("ToCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ToCurrencyCode;
        partial void OnToCurrencyCodeChanging(string value);
        partial void OnToCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property Rate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Rate
        {
            get
            {
                return this._Rate;
            }
            set
            {
                this.OnRateChanging(value);
                this._Rate = value;
                this.OnRateChanged();
                this.OnPropertyChanged("Rate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Rate;
        partial void OnRateChanging(decimal value);
        partial void OnRateChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Currency Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this.OnCurrencyChanging(value);
                this._Currency = value;
                this.OnCurrencyChanged();
                this.OnPropertyChanged("Currency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Currency _Currency;
        partial void OnCurrencyChanging(global::Microsoft.Dynamics.DataEntities.Currency value);
        partial void OnCurrencyChanged();
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
