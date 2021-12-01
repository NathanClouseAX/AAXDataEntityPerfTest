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
    /// There are no comments for BillingCodeAccountingDistributionSingle in the schema.
    /// </summary>
    public partial class BillingCodeAccountingDistributionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BillingCodeAccountingDistribution>
    {
        /// <summary>
        /// Initialize a new BillingCodeAccountingDistributionSingle object.
        /// </summary>
        public BillingCodeAccountingDistributionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BillingCodeAccountingDistributionSingle object.
        /// </summary>
        public BillingCodeAccountingDistributionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BillingCodeAccountingDistributionSingle object.
        /// </summary>
        public BillingCodeAccountingDistributionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BillingCodeAccountingDistribution> query)
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
    /// There are no comments for BillingCodeAccountingDistribution in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ValidTo
    /// ValidFrom
    /// BillingCode
    /// LedgerAccountDisplayValue
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ValidTo", "ValidFrom", "BillingCode", "LedgerAccountDisplayValue")]
    [global::Microsoft.OData.Client.EntitySet("BillingCodeAccountingDistributions")]
    public partial class BillingCodeAccountingDistribution : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BillingCodeAccountingDistribution object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="billingCode">Initial value of BillingCode.</param>
        /// <param name="ledgerAccountDisplayValue">Initial value of LedgerAccountDisplayValue.</param>
        /// <param name="percent">Initial value of Percent.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BillingCodeAccountingDistribution CreateBillingCodeAccountingDistribution(string dataAreaId, 
                    global::System.DateTimeOffset validTo, 
                    global::System.DateTimeOffset validFrom, 
                    string billingCode, 
                    string ledgerAccountDisplayValue, 
                    decimal percent)
        {
            BillingCodeAccountingDistribution billingCodeAccountingDistribution = new BillingCodeAccountingDistribution();
            billingCodeAccountingDistribution.dataAreaId = dataAreaId;
            billingCodeAccountingDistribution.ValidTo = validTo;
            billingCodeAccountingDistribution.ValidFrom = validFrom;
            billingCodeAccountingDistribution.BillingCode = billingCode;
            billingCodeAccountingDistribution.LedgerAccountDisplayValue = ledgerAccountDisplayValue;
            billingCodeAccountingDistribution.Percent = percent;
            return billingCodeAccountingDistribution;
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
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidTo is required.")]
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
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidFrom is required.")]
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
        /// There are no comments for Property BillingCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BillingCode is required.")]
        public virtual string BillingCode
        {
            get
            {
                return this._BillingCode;
            }
            set
            {
                this.OnBillingCodeChanging(value);
                this._BillingCode = value;
                this.OnBillingCodeChanged();
                this.OnPropertyChanged("BillingCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BillingCode;
        partial void OnBillingCodeChanging(string value);
        partial void OnBillingCodeChanged();
        /// <summary>
        /// There are no comments for Property LedgerAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LedgerAccountDisplayValue is required.")]
        public virtual string LedgerAccountDisplayValue
        {
            get
            {
                return this._LedgerAccountDisplayValue;
            }
            set
            {
                this.OnLedgerAccountDisplayValueChanging(value);
                this._LedgerAccountDisplayValue = value;
                this.OnLedgerAccountDisplayValueChanged();
                this.OnPropertyChanged("LedgerAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerAccountDisplayValue;
        partial void OnLedgerAccountDisplayValueChanging(string value);
        partial void OnLedgerAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property Percent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Percent is required.")]
        public virtual decimal Percent
        {
            get
            {
                return this._Percent;
            }
            set
            {
                this.OnPercentChanging(value);
                this._Percent = value;
                this.OnPercentChanged();
                this.OnPropertyChanged("Percent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Percent;
        partial void OnPercentChanging(decimal value);
        partial void OnPercentChanged();
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
