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
        /// There are no comments for PayRateConversionSingle in the schema.
        /// </summary>
    public partial class PayRateConversionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PayRateConversion>
    {
        /// <summary>
        /// Initialize a new PayRateConversionSingle object.
        /// </summary>
        public PayRateConversionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PayRateConversionSingle object.
        /// </summary>
        public PayRateConversionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PayRateConversionSingle object.
        /// </summary>
        public PayRateConversionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PayRateConversion> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CompFixedPlanTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable> CompFixedPlanTable
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompFixedPlanTable == null))
                {
                    this._CompFixedPlanTable = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable>(GetPath("CompFixedPlanTable"));
                }
                return this._CompFixedPlanTable;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable> _CompFixedPlanTable;
    }
        /// <summary>
        /// There are no comments for PayRateConversion in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PayRateConversion
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PayRateConversion")]
    [global::Microsoft.OData.Client.EntitySet("PayRateConversions")]
    public partial class PayRateConversion : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PayRateConversion object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="payRateConversion1">Initial value of PayRateConversion1.</param>
        /// <param name="annualConversionFactor">Initial value of AnnualConversionFactor.</param>
        /// <param name="monthlyConversionFactor">Initial value of MonthlyConversionFactor.</param>
        /// <param name="weeklyConversionFactor">Initial value of WeeklyConversionFactor.</param>
        /// <param name="hourlyConversionFactor">Initial value of HourlyConversionFactor.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PayRateConversion CreatePayRateConversion(string dataAreaId, 
                    string payRateConversion1, 
                    decimal annualConversionFactor, 
                    decimal monthlyConversionFactor, 
                    decimal weeklyConversionFactor, 
                    decimal hourlyConversionFactor)
        {
            PayRateConversion payRateConversion = new PayRateConversion();
            payRateConversion.dataAreaId = dataAreaId;
            payRateConversion.PayRateConversion1 = payRateConversion1;
            payRateConversion.AnnualConversionFactor = annualConversionFactor;
            payRateConversion.MonthlyConversionFactor = monthlyConversionFactor;
            payRateConversion.WeeklyConversionFactor = weeklyConversionFactor;
            payRateConversion.HourlyConversionFactor = hourlyConversionFactor;
            return payRateConversion;
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
        /// There are no comments for Property PayRateConversion1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PayRateConversion")]
        public virtual string PayRateConversion1
        {
            get
            {
                return this._PayRateConversion1;
            }
            set
            {
                this.OnPayRateConversion1Changing(value);
                this._PayRateConversion1 = value;
                this.OnPayRateConversion1Changed();
                this.OnPropertyChanged("PayRateConversion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PayRateConversion1;
        partial void OnPayRateConversion1Changing(string value);
        partial void OnPayRateConversion1Changed();
        /// <summary>
        /// There are no comments for Property AnnualConversionFactor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AnnualConversionFactor
        {
            get
            {
                return this._AnnualConversionFactor;
            }
            set
            {
                this.OnAnnualConversionFactorChanging(value);
                this._AnnualConversionFactor = value;
                this.OnAnnualConversionFactorChanged();
                this.OnPropertyChanged("AnnualConversionFactor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AnnualConversionFactor;
        partial void OnAnnualConversionFactorChanging(decimal value);
        partial void OnAnnualConversionFactorChanged();
        /// <summary>
        /// There are no comments for Property MonthlyConversionFactor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MonthlyConversionFactor
        {
            get
            {
                return this._MonthlyConversionFactor;
            }
            set
            {
                this.OnMonthlyConversionFactorChanging(value);
                this._MonthlyConversionFactor = value;
                this.OnMonthlyConversionFactorChanged();
                this.OnPropertyChanged("MonthlyConversionFactor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MonthlyConversionFactor;
        partial void OnMonthlyConversionFactorChanging(decimal value);
        partial void OnMonthlyConversionFactorChanged();
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
        /// There are no comments for Property WeeklyConversionFactor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal WeeklyConversionFactor
        {
            get
            {
                return this._WeeklyConversionFactor;
            }
            set
            {
                this.OnWeeklyConversionFactorChanging(value);
                this._WeeklyConversionFactor = value;
                this.OnWeeklyConversionFactorChanged();
                this.OnPropertyChanged("WeeklyConversionFactor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _WeeklyConversionFactor;
        partial void OnWeeklyConversionFactorChanging(decimal value);
        partial void OnWeeklyConversionFactorChanged();
        /// <summary>
        /// There are no comments for Property Period in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompPayFrequencyPeriod> Period
        {
            get
            {
                return this._Period;
            }
            set
            {
                this.OnPeriodChanging(value);
                this._Period = value;
                this.OnPeriodChanged();
                this.OnPropertyChanged("Period");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompPayFrequencyPeriod> _Period;
        partial void OnPeriodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompPayFrequencyPeriod> value);
        partial void OnPeriodChanged();
        /// <summary>
        /// There are no comments for Property HourlyConversionFactor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal HourlyConversionFactor
        {
            get
            {
                return this._HourlyConversionFactor;
            }
            set
            {
                this.OnHourlyConversionFactorChanging(value);
                this._HourlyConversionFactor = value;
                this.OnHourlyConversionFactorChanged();
                this.OnPropertyChanged("HourlyConversionFactor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _HourlyConversionFactor;
        partial void OnHourlyConversionFactorChanging(decimal value);
        partial void OnHourlyConversionFactorChanged();
        /// <summary>
        /// There are no comments for Property CompFixedPlanTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable> CompFixedPlanTable
        {
            get
            {
                return this._CompFixedPlanTable;
            }
            set
            {
                this.OnCompFixedPlanTableChanging(value);
                this._CompFixedPlanTable = value;
                this.OnCompFixedPlanTableChanged();
                this.OnPropertyChanged("CompFixedPlanTable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable> _CompFixedPlanTable = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompFixedPlanTableChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable> value);
        partial void OnCompFixedPlanTableChanged();
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
