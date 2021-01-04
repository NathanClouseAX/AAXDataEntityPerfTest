﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/3/2021 8:21:45 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for PaymentDaySingle in the schema.
        /// </summary>
    public partial class PaymentDaySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PaymentDay>
    {
        /// <summary>
        /// Initialize a new PaymentDaySingle object.
        /// </summary>
        public PaymentDaySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PaymentDaySingle object.
        /// </summary>
        public PaymentDaySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PaymentDaySingle object.
        /// </summary>
        public PaymentDaySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PaymentDay> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PaymentTerm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PaymentTerm> PaymentTerm
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PaymentTerm == null))
                {
                    this._PaymentTerm = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PaymentTerm>(GetPath("PaymentTerm"));
                }
                return this._PaymentTerm;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PaymentTerm> _PaymentTerm;
    }
        /// <summary>
        /// There are no comments for PaymentDay in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// Name
    /// Frequency
    /// DayOfWeek
    /// DayOfMonth
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Name", "Frequency", "DayOfWeek", "DayOfMonth")]
    [global::Microsoft.OData.Client.EntitySet("PaymentDays")]
    public partial class PaymentDay : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PaymentDay object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="dayOfMonth">Initial value of DayOfMonth.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PaymentDay CreatePaymentDay(string dataAreaId, string name, int dayOfMonth)
        {
            PaymentDay paymentDay = new PaymentDay();
            paymentDay.dataAreaId = dataAreaId;
            paymentDay.Name = name;
            paymentDay.DayOfMonth = dayOfMonth;
            return paymentDay;
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
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Frequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WeekMonth> Frequency
        {
            get
            {
                return this._Frequency;
            }
            set
            {
                this.OnFrequencyChanging(value);
                this._Frequency = value;
                this.OnFrequencyChanged();
                this.OnPropertyChanged("Frequency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WeekMonth> _Frequency;
        partial void OnFrequencyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WeekMonth> value);
        partial void OnFrequencyChanged();
        /// <summary>
        /// There are no comments for Property DayOfWeek in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WeekDays> DayOfWeek
        {
            get
            {
                return this._DayOfWeek;
            }
            set
            {
                this.OnDayOfWeekChanging(value);
                this._DayOfWeek = value;
                this.OnDayOfWeekChanged();
                this.OnPropertyChanged("DayOfWeek");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WeekDays> _DayOfWeek;
        partial void OnDayOfWeekChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WeekDays> value);
        partial void OnDayOfWeekChanged();
        /// <summary>
        /// There are no comments for Property DayOfMonth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int DayOfMonth
        {
            get
            {
                return this._DayOfMonth;
            }
            set
            {
                this.OnDayOfMonthChanging(value);
                this._DayOfMonth = value;
                this.OnDayOfMonthChanged();
                this.OnPropertyChanged("DayOfMonth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DayOfMonth;
        partial void OnDayOfMonthChanging(int value);
        partial void OnDayOfMonthChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property PaymentTerm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentTerm> PaymentTerm
        {
            get
            {
                return this._PaymentTerm;
            }
            set
            {
                this.OnPaymentTermChanging(value);
                this._PaymentTerm = value;
                this.OnPaymentTermChanged();
                this.OnPropertyChanged("PaymentTerm");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentTerm> _PaymentTerm = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentTerm>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPaymentTermChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PaymentTerm> value);
        partial void OnPaymentTermChanged();
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
