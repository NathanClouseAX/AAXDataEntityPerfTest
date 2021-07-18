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
        /// There are no comments for SADDocumentLedgerJournalSingle in the schema.
        /// </summary>
    public partial class SADDocumentLedgerJournalSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SADDocumentLedgerJournal>
    {
        /// <summary>
        /// Initialize a new SADDocumentLedgerJournalSingle object.
        /// </summary>
        public SADDocumentLedgerJournalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SADDocumentLedgerJournalSingle object.
        /// </summary>
        public SADDocumentLedgerJournalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SADDocumentLedgerJournalSingle object.
        /// </summary>
        public SADDocumentLedgerJournalSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SADDocumentLedgerJournal> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for SADDocumentLineLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SADDocumentLineLedgerJournal> SADDocumentLineLedgerJournal
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SADDocumentLineLedgerJournal == null))
                {
                    this._SADDocumentLineLedgerJournal = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.SADDocumentLineLedgerJournal>(GetPath("SADDocumentLineLedgerJournal"));
                }
                return this._SADDocumentLineLedgerJournal;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SADDocumentLineLedgerJournal> _SADDocumentLineLedgerJournal;
        /// <summary>
        /// There are no comments for SADDocumentInvoiceLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLedgerJournal> SADDocumentInvoiceLedgerJournal
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SADDocumentInvoiceLedgerJournal == null))
                {
                    this._SADDocumentInvoiceLedgerJournal = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLedgerJournal>(GetPath("SADDocumentInvoiceLedgerJournal"));
                }
                return this._SADDocumentInvoiceLedgerJournal;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLedgerJournal> _SADDocumentInvoiceLedgerJournal;
    }
        /// <summary>
        /// There are no comments for SADDocumentLedgerJournal in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// SADNumber
    /// SADDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SADNumber", "SADDate")]
    [global::Microsoft.OData.Client.EntitySet("SADDocumentLedgerJournals")]
    public partial class SADDocumentLedgerJournal : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SADDocumentLedgerJournal object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="sADNumber">Initial value of SADNumber.</param>
        /// <param name="sADDate">Initial value of SADDate.</param>
        /// <param name="dateOfVATRegister">Initial value of DateOfVATRegister.</param>
        /// <param name="date">Initial value of Date.</param>
        /// <param name="miscPayments">Initial value of MiscPayments.</param>
        /// <param name="exchangeRate">Initial value of ExchangeRate.</param>
        /// <param name="transport">Initial value of Transport.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SADDocumentLedgerJournal CreateSADDocumentLedgerJournal(string dataAreaId, 
                    string sADNumber, 
                    global::System.DateTimeOffset sADDate, 
                    global::System.DateTimeOffset dateOfVATRegister, 
                    global::System.DateTimeOffset date, 
                    decimal miscPayments, 
                    decimal exchangeRate, 
                    decimal transport)
        {
            SADDocumentLedgerJournal sADDocumentLedgerJournal = new SADDocumentLedgerJournal();
            sADDocumentLedgerJournal.dataAreaId = dataAreaId;
            sADDocumentLedgerJournal.SADNumber = sADNumber;
            sADDocumentLedgerJournal.SADDate = sADDate;
            sADDocumentLedgerJournal.DateOfVATRegister = dateOfVATRegister;
            sADDocumentLedgerJournal.Date = date;
            sADDocumentLedgerJournal.MiscPayments = miscPayments;
            sADDocumentLedgerJournal.ExchangeRate = exchangeRate;
            sADDocumentLedgerJournal.Transport = transport;
            return sADDocumentLedgerJournal;
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
        /// There are no comments for Property SADNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SADNumber
        {
            get
            {
                return this._SADNumber;
            }
            set
            {
                this.OnSADNumberChanging(value);
                this._SADNumber = value;
                this.OnSADNumberChanged();
                this.OnPropertyChanged("SADNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SADNumber;
        partial void OnSADNumberChanging(string value);
        partial void OnSADNumberChanged();
        /// <summary>
        /// There are no comments for Property SADDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset SADDate
        {
            get
            {
                return this._SADDate;
            }
            set
            {
                this.OnSADDateChanging(value);
                this._SADDate = value;
                this.OnSADDateChanged();
                this.OnPropertyChanged("SADDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _SADDate;
        partial void OnSADDateChanging(global::System.DateTimeOffset value);
        partial void OnSADDateChanged();
        /// <summary>
        /// There are no comments for Property DateOfVATRegister in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DateOfVATRegister
        {
            get
            {
                return this._DateOfVATRegister;
            }
            set
            {
                this.OnDateOfVATRegisterChanging(value);
                this._DateOfVATRegister = value;
                this.OnDateOfVATRegisterChanged();
                this.OnPropertyChanged("DateOfVATRegister");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateOfVATRegister;
        partial void OnDateOfVATRegisterChanging(global::System.DateTimeOffset value);
        partial void OnDateOfVATRegisterChanged();
        /// <summary>
        /// There are no comments for Property DutyGovernment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DutyGovernment
        {
            get
            {
                return this._DutyGovernment;
            }
            set
            {
                this.OnDutyGovernmentChanging(value);
                this._DutyGovernment = value;
                this.OnDutyGovernmentChanged();
                this.OnPropertyChanged("DutyGovernment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DutyGovernment;
        partial void OnDutyGovernmentChanging(string value);
        partial void OnDutyGovernmentChanged();
        /// <summary>
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Currency
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
        private string _Currency;
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        /// <summary>
        /// There are no comments for Property Date in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                this.OnDateChanging(value);
                this._Date = value;
                this.OnDateChanged();
                this.OnPropertyChanged("Date");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Date;
        partial void OnDateChanging(global::System.DateTimeOffset value);
        partial void OnDateChanged();
        /// <summary>
        /// There are no comments for Property MiscPayments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MiscPayments
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
        private decimal _MiscPayments;
        partial void OnMiscPaymentsChanging(decimal value);
        partial void OnMiscPaymentsChanged();
        /// <summary>
        /// There are no comments for Property ExchangeRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ExchangeRate
        {
            get
            {
                return this._ExchangeRate;
            }
            set
            {
                this.OnExchangeRateChanging(value);
                this._ExchangeRate = value;
                this.OnExchangeRateChanged();
                this.OnPropertyChanged("ExchangeRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExchangeRate;
        partial void OnExchangeRateChanging(decimal value);
        partial void OnExchangeRateChanged();
        /// <summary>
        /// There are no comments for Property Carrier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Carrier
        {
            get
            {
                return this._Carrier;
            }
            set
            {
                this.OnCarrierChanging(value);
                this._Carrier = value;
                this.OnCarrierChanged();
                this.OnPropertyChanged("Carrier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Carrier;
        partial void OnCarrierChanging(string value);
        partial void OnCarrierChanged();
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
        /// There are no comments for Property SADDocumentLineLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentLineLedgerJournal> SADDocumentLineLedgerJournal
        {
            get
            {
                return this._SADDocumentLineLedgerJournal;
            }
            set
            {
                this.OnSADDocumentLineLedgerJournalChanging(value);
                this._SADDocumentLineLedgerJournal = value;
                this.OnSADDocumentLineLedgerJournalChanged();
                this.OnPropertyChanged("SADDocumentLineLedgerJournal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentLineLedgerJournal> _SADDocumentLineLedgerJournal = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentLineLedgerJournal>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSADDocumentLineLedgerJournalChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentLineLedgerJournal> value);
        partial void OnSADDocumentLineLedgerJournalChanged();
        /// <summary>
        /// There are no comments for Property SADDocumentInvoiceLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLedgerJournal> SADDocumentInvoiceLedgerJournal
        {
            get
            {
                return this._SADDocumentInvoiceLedgerJournal;
            }
            set
            {
                this.OnSADDocumentInvoiceLedgerJournalChanging(value);
                this._SADDocumentInvoiceLedgerJournal = value;
                this.OnSADDocumentInvoiceLedgerJournalChanged();
                this.OnPropertyChanged("SADDocumentInvoiceLedgerJournal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLedgerJournal> _SADDocumentInvoiceLedgerJournal = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLedgerJournal>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSADDocumentInvoiceLedgerJournalChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLedgerJournal> value);
        partial void OnSADDocumentInvoiceLedgerJournalChanged();
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
