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
        /// There are no comments for PayrollCalculationFrequencySingle in the schema.
        /// </summary>
    public partial class PayrollCalculationFrequencySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollCalculationFrequency>
    {
        /// <summary>
        /// Initialize a new PayrollCalculationFrequencySingle object.
        /// </summary>
        public PayrollCalculationFrequencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PayrollCalculationFrequencySingle object.
        /// </summary>
        public PayrollCalculationFrequencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PayrollCalculationFrequencySingle object.
        /// </summary>
        public PayrollCalculationFrequencySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollCalculationFrequency> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WorkerPositionEarningCodeV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerPositionEarningCodeV2> WorkerPositionEarningCodeV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerPositionEarningCodeV2 == null))
                {
                    this._WorkerPositionEarningCodeV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WorkerPositionEarningCodeV2>(GetPath("WorkerPositionEarningCodeV2"));
                }
                return this._WorkerPositionEarningCodeV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerPositionEarningCodeV2> _WorkerPositionEarningCodeV2;
        /// <summary>
        /// There are no comments for WorkerPositionEarningCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerPositionEarningCode> WorkerPositionEarningCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerPositionEarningCode == null))
                {
                    this._WorkerPositionEarningCode = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WorkerPositionEarningCode>(GetPath("WorkerPositionEarningCode"));
                }
                return this._WorkerPositionEarningCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerPositionEarningCode> _WorkerPositionEarningCode;
        /// <summary>
        /// There are no comments for PremiumEarnings in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PremiumEarningCode> PremiumEarnings
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PremiumEarnings == null))
                {
                    this._PremiumEarnings = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PremiumEarningCode>(GetPath("PremiumEarnings"));
                }
                return this._PremiumEarnings;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PremiumEarningCode> _PremiumEarnings;
    }
        /// <summary>
        /// There are no comments for PayrollCalculationFrequency in the schema.
        /// </summary>
    /// <KeyProperties>
    /// Frequency
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Frequency")]
    [global::Microsoft.OData.Client.EntitySet("PayrollCalculationFrequencies")]
    public partial class PayrollCalculationFrequency : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PayrollCalculationFrequency object.
        /// </summary>
        /// <param name="frequency">Initial value of Frequency.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PayrollCalculationFrequency CreatePayrollCalculationFrequency(string frequency)
        {
            PayrollCalculationFrequency payrollCalculationFrequency = new PayrollCalculationFrequency();
            payrollCalculationFrequency.Frequency = frequency;
            return payrollCalculationFrequency;
        }
        /// <summary>
        /// There are no comments for Property Frequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Frequency
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
        private string _Frequency;
        partial void OnFrequencyChanging(string value);
        partial void OnFrequencyChanged();
        /// <summary>
        /// There are no comments for Property FrequencyControl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollCalculationBasis> FrequencyControl
        {
            get
            {
                return this._FrequencyControl;
            }
            set
            {
                this.OnFrequencyControlChanging(value);
                this._FrequencyControl = value;
                this.OnFrequencyControlChanged();
                this.OnPropertyChanged("FrequencyControl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollCalculationBasis> _FrequencyControl;
        partial void OnFrequencyControlChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollCalculationBasis> value);
        partial void OnFrequencyControlChanged();
        /// <summary>
        /// There are no comments for Property IsImmutable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsImmutable
        {
            get
            {
                return this._IsImmutable;
            }
            set
            {
                this.OnIsImmutableChanging(value);
                this._IsImmutable = value;
                this.OnIsImmutableChanged();
                this.OnPropertyChanged("IsImmutable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsImmutable;
        partial void OnIsImmutableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsImmutableChanged();
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
        /// There are no comments for Property WorkerPositionEarningCodeV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerPositionEarningCodeV2> WorkerPositionEarningCodeV2
        {
            get
            {
                return this._WorkerPositionEarningCodeV2;
            }
            set
            {
                this.OnWorkerPositionEarningCodeV2Changing(value);
                this._WorkerPositionEarningCodeV2 = value;
                this.OnWorkerPositionEarningCodeV2Changed();
                this.OnPropertyChanged("WorkerPositionEarningCodeV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerPositionEarningCodeV2> _WorkerPositionEarningCodeV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerPositionEarningCodeV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWorkerPositionEarningCodeV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerPositionEarningCodeV2> value);
        partial void OnWorkerPositionEarningCodeV2Changed();
        /// <summary>
        /// There are no comments for Property WorkerPositionEarningCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerPositionEarningCode> WorkerPositionEarningCode
        {
            get
            {
                return this._WorkerPositionEarningCode;
            }
            set
            {
                this.OnWorkerPositionEarningCodeChanging(value);
                this._WorkerPositionEarningCode = value;
                this.OnWorkerPositionEarningCodeChanged();
                this.OnPropertyChanged("WorkerPositionEarningCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerPositionEarningCode> _WorkerPositionEarningCode = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerPositionEarningCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWorkerPositionEarningCodeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerPositionEarningCode> value);
        partial void OnWorkerPositionEarningCodeChanged();
        /// <summary>
        /// There are no comments for Property PremiumEarnings in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PremiumEarningCode> PremiumEarnings
        {
            get
            {
                return this._PremiumEarnings;
            }
            set
            {
                this.OnPremiumEarningsChanging(value);
                this._PremiumEarnings = value;
                this.OnPremiumEarningsChanged();
                this.OnPropertyChanged("PremiumEarnings");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PremiumEarningCode> _PremiumEarnings = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PremiumEarningCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPremiumEarningsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PremiumEarningCode> value);
        partial void OnPremiumEarningsChanged();
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
