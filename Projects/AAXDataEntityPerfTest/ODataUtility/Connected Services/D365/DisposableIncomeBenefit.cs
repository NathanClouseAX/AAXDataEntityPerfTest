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
        /// There are no comments for DisposableIncomeBenefitSingle in the schema.
        /// </summary>
    public partial class DisposableIncomeBenefitSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DisposableIncomeBenefit>
    {
        /// <summary>
        /// Initialize a new DisposableIncomeBenefitSingle object.
        /// </summary>
        public DisposableIncomeBenefitSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DisposableIncomeBenefitSingle object.
        /// </summary>
        public DisposableIncomeBenefitSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DisposableIncomeBenefitSingle object.
        /// </summary>
        public DisposableIncomeBenefitSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DisposableIncomeBenefit> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DisposableIncome in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DisposableIncomeSingle DisposableIncome
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DisposableIncome == null))
                {
                    this._DisposableIncome = new global::Microsoft.Dynamics.DataEntities.DisposableIncomeSingle(this.Context, GetPath("DisposableIncome"));
                }
                return this._DisposableIncome;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DisposableIncomeSingle _DisposableIncome;
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
    }
        /// <summary>
        /// There are no comments for DisposableIncomeBenefit in the schema.
        /// </summary>
    /// <KeyProperties>
    /// BenefitId
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BenefitId", "Name")]
    [global::Microsoft.OData.Client.EntitySet("DisposableIncomeBenefits")]
    public partial class DisposableIncomeBenefit : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DisposableIncomeBenefit object.
        /// </summary>
        /// <param name="benefitId">Initial value of BenefitId.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="disposableIncome">Initial value of DisposableIncome.</param>
        /// <param name="benefit">Initial value of Benefit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DisposableIncomeBenefit CreateDisposableIncomeBenefit(string benefitId, string name, global::Microsoft.Dynamics.DataEntities.DisposableIncome disposableIncome, global::Microsoft.Dynamics.DataEntities.Benefit benefit)
        {
            DisposableIncomeBenefit disposableIncomeBenefit = new DisposableIncomeBenefit();
            disposableIncomeBenefit.BenefitId = benefitId;
            disposableIncomeBenefit.Name = name;
            if ((disposableIncome == null))
            {
                throw new global::System.ArgumentNullException("disposableIncome");
            }
            disposableIncomeBenefit.DisposableIncome = disposableIncome;
            if ((benefit == null))
            {
                throw new global::System.ArgumentNullException("benefit");
            }
            disposableIncomeBenefit.Benefit = benefit;
            return disposableIncomeBenefit;
        }
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
        /// There are no comments for Property DisposableIncome in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DisposableIncome DisposableIncome
        {
            get
            {
                return this._DisposableIncome;
            }
            set
            {
                this.OnDisposableIncomeChanging(value);
                this._DisposableIncome = value;
                this.OnDisposableIncomeChanged();
                this.OnPropertyChanged("DisposableIncome");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DisposableIncome _DisposableIncome;
        partial void OnDisposableIncomeChanging(global::Microsoft.Dynamics.DataEntities.DisposableIncome value);
        partial void OnDisposableIncomeChanged();
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
