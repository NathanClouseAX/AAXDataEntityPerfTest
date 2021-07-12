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
        /// There are no comments for PayStatementBenefitLineSingle in the schema.
        /// </summary>
    public partial class PayStatementBenefitLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PayStatementBenefitLine>
    {
        /// <summary>
        /// Initialize a new PayStatementBenefitLineSingle object.
        /// </summary>
        public PayStatementBenefitLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PayStatementBenefitLineSingle object.
        /// </summary>
        public PayStatementBenefitLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PayStatementBenefitLineSingle object.
        /// </summary>
        public PayStatementBenefitLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PayStatementBenefitLine> query)
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
        /// There are no comments for PayStatementBenefitLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PayStatementNumber
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PayStatementNumber", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("PayStatementBenefitLines")]
    public partial class PayStatementBenefitLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PayStatementBenefitLine object.
        /// </summary>
        /// <param name="payStatementNumber">Initial value of PayStatementNumber.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="amountInTransactionCurrency">Initial value of AmountInTransactionCurrency.</param>
        /// <param name="premiumEarningAmount">Initial value of PremiumEarningAmount.</param>
        /// <param name="accountingDate">Initial value of AccountingDate.</param>
        /// <param name="baseEarningAmount">Initial value of BaseEarningAmount.</param>
        /// <param name="premiumEarningHours">Initial value of PremiumEarningHours.</param>
        /// <param name="baseEarningHours">Initial value of BaseEarningHours.</param>
        /// <param name="reversedPayStatementLineNum">Initial value of ReversedPayStatementLineNum.</param>
        /// <param name="benefit">Initial value of Benefit.</param>
        /// <param name="payStatementHeader">Initial value of PayStatementHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PayStatementBenefitLine CreatePayStatementBenefitLine(string payStatementNumber, 
                    decimal lineNumber, 
                    decimal amountInTransactionCurrency, 
                    decimal premiumEarningAmount, 
                    global::System.DateTimeOffset accountingDate, 
                    decimal baseEarningAmount, 
                    decimal premiumEarningHours, 
                    decimal baseEarningHours, 
                    decimal reversedPayStatementLineNum, 
                    global::Microsoft.Dynamics.DataEntities.Benefit benefit, 
                    global::Microsoft.Dynamics.DataEntities.PayStatementHeader payStatementHeader)
        {
            PayStatementBenefitLine payStatementBenefitLine = new PayStatementBenefitLine();
            payStatementBenefitLine.PayStatementNumber = payStatementNumber;
            payStatementBenefitLine.LineNumber = lineNumber;
            payStatementBenefitLine.AmountInTransactionCurrency = amountInTransactionCurrency;
            payStatementBenefitLine.PremiumEarningAmount = premiumEarningAmount;
            payStatementBenefitLine.AccountingDate = accountingDate;
            payStatementBenefitLine.BaseEarningAmount = baseEarningAmount;
            payStatementBenefitLine.PremiumEarningHours = premiumEarningHours;
            payStatementBenefitLine.BaseEarningHours = baseEarningHours;
            payStatementBenefitLine.ReversedPayStatementLineNum = reversedPayStatementLineNum;
            if ((benefit == null))
            {
                throw new global::System.ArgumentNullException("benefit");
            }
            payStatementBenefitLine.Benefit = benefit;
            if ((payStatementHeader == null))
            {
                throw new global::System.ArgumentNullException("payStatementHeader");
            }
            payStatementBenefitLine.PayStatementHeader = payStatementHeader;
            return payStatementBenefitLine;
        }
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
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
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
        /// There are no comments for Property EmployerContribution in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EmployerContribution
        {
            get
            {
                return this._EmployerContribution;
            }
            set
            {
                this.OnEmployerContributionChanging(value);
                this._EmployerContribution = value;
                this.OnEmployerContributionChanged();
                this.OnPropertyChanged("EmployerContribution");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EmployerContribution;
        partial void OnEmployerContributionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEmployerContributionChanged();
        /// <summary>
        /// There are no comments for Property AccountingDistributionLegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountingDistributionLegalEntity
        {
            get
            {
                return this._AccountingDistributionLegalEntity;
            }
            set
            {
                this.OnAccountingDistributionLegalEntityChanging(value);
                this._AccountingDistributionLegalEntity = value;
                this.OnAccountingDistributionLegalEntityChanged();
                this.OnPropertyChanged("AccountingDistributionLegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountingDistributionLegalEntity;
        partial void OnAccountingDistributionLegalEntityChanging(string value);
        partial void OnAccountingDistributionLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property LineLocked in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> LineLocked
        {
            get
            {
                return this._LineLocked;
            }
            set
            {
                this.OnLineLockedChanging(value);
                this._LineLocked = value;
                this.OnLineLockedChanged();
                this.OnPropertyChanged("LineLocked");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _LineLocked;
        partial void OnLineLockedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnLineLockedChanged();
        /// <summary>
        /// There are no comments for Property PositionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PositionId
        {
            get
            {
                return this._PositionId;
            }
            set
            {
                this.OnPositionIdChanging(value);
                this._PositionId = value;
                this.OnPositionIdChanged();
                this.OnPropertyChanged("PositionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PositionId;
        partial void OnPositionIdChanging(string value);
        partial void OnPositionIdChanged();
        /// <summary>
        /// There are no comments for Property PremiumEarningAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PremiumEarningAmount
        {
            get
            {
                return this._PremiumEarningAmount;
            }
            set
            {
                this.OnPremiumEarningAmountChanging(value);
                this._PremiumEarningAmount = value;
                this.OnPremiumEarningAmountChanged();
                this.OnPropertyChanged("PremiumEarningAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PremiumEarningAmount;
        partial void OnPremiumEarningAmountChanging(decimal value);
        partial void OnPremiumEarningAmountChanged();
        /// <summary>
        /// There are no comments for Property LineOverridden in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> LineOverridden
        {
            get
            {
                return this._LineOverridden;
            }
            set
            {
                this.OnLineOverriddenChanging(value);
                this._LineOverridden = value;
                this.OnLineOverriddenChanged();
                this.OnPropertyChanged("LineOverridden");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _LineOverridden;
        partial void OnLineOverriddenChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnLineOverriddenChanged();
        /// <summary>
        /// There are no comments for Property Company in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                this.OnCompanyChanging(value);
                this._Company = value;
                this.OnCompanyChanged();
                this.OnPropertyChanged("Company");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Company;
        partial void OnCompanyChanging(string value);
        partial void OnCompanyChanged();
        /// <summary>
        /// There are no comments for Property AccountingDistributionTemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountingDistributionTemplateId
        {
            get
            {
                return this._AccountingDistributionTemplateId;
            }
            set
            {
                this.OnAccountingDistributionTemplateIdChanging(value);
                this._AccountingDistributionTemplateId = value;
                this.OnAccountingDistributionTemplateIdChanged();
                this.OnPropertyChanged("AccountingDistributionTemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountingDistributionTemplateId;
        partial void OnAccountingDistributionTemplateIdChanging(string value);
        partial void OnAccountingDistributionTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property AccountingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset AccountingDate
        {
            get
            {
                return this._AccountingDate;
            }
            set
            {
                this.OnAccountingDateChanging(value);
                this._AccountingDate = value;
                this.OnAccountingDateChanged();
                this.OnPropertyChanged("AccountingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AccountingDate;
        partial void OnAccountingDateChanging(global::System.DateTimeOffset value);
        partial void OnAccountingDateChanged();
        /// <summary>
        /// There are no comments for Property PayStatementLineSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPayStatementLineSource> PayStatementLineSource
        {
            get
            {
                return this._PayStatementLineSource;
            }
            set
            {
                this.OnPayStatementLineSourceChanging(value);
                this._PayStatementLineSource = value;
                this.OnPayStatementLineSourceChanged();
                this.OnPropertyChanged("PayStatementLineSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPayStatementLineSource> _PayStatementLineSource;
        partial void OnPayStatementLineSourceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPayStatementLineSource> value);
        partial void OnPayStatementLineSourceChanged();
        /// <summary>
        /// There are no comments for Property BaseEarningAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal BaseEarningAmount
        {
            get
            {
                return this._BaseEarningAmount;
            }
            set
            {
                this.OnBaseEarningAmountChanging(value);
                this._BaseEarningAmount = value;
                this.OnBaseEarningAmountChanged();
                this.OnPropertyChanged("BaseEarningAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _BaseEarningAmount;
        partial void OnBaseEarningAmountChanging(decimal value);
        partial void OnBaseEarningAmountChanged();
        /// <summary>
        /// There are no comments for Property ReversedPayStatementNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReversedPayStatementNumber
        {
            get
            {
                return this._ReversedPayStatementNumber;
            }
            set
            {
                this.OnReversedPayStatementNumberChanging(value);
                this._ReversedPayStatementNumber = value;
                this.OnReversedPayStatementNumberChanged();
                this.OnPropertyChanged("ReversedPayStatementNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReversedPayStatementNumber;
        partial void OnReversedPayStatementNumberChanging(string value);
        partial void OnReversedPayStatementNumberChanged();
        /// <summary>
        /// There are no comments for Property LineToRemove in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> LineToRemove
        {
            get
            {
                return this._LineToRemove;
            }
            set
            {
                this.OnLineToRemoveChanging(value);
                this._LineToRemove = value;
                this.OnLineToRemoveChanged();
                this.OnPropertyChanged("LineToRemove");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _LineToRemove;
        partial void OnLineToRemoveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnLineToRemoveChanged();
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
        /// There are no comments for Property PremiumEarningHours in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PremiumEarningHours
        {
            get
            {
                return this._PremiumEarningHours;
            }
            set
            {
                this.OnPremiumEarningHoursChanging(value);
                this._PremiumEarningHours = value;
                this.OnPremiumEarningHoursChanged();
                this.OnPropertyChanged("PremiumEarningHours");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PremiumEarningHours;
        partial void OnPremiumEarningHoursChanging(decimal value);
        partial void OnPremiumEarningHoursChanged();
        /// <summary>
        /// There are no comments for Property BaseEarningHours in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal BaseEarningHours
        {
            get
            {
                return this._BaseEarningHours;
            }
            set
            {
                this.OnBaseEarningHoursChanging(value);
                this._BaseEarningHours = value;
                this.OnBaseEarningHoursChanged();
                this.OnPropertyChanged("BaseEarningHours");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _BaseEarningHours;
        partial void OnBaseEarningHoursChanging(decimal value);
        partial void OnBaseEarningHoursChanged();
        /// <summary>
        /// There are no comments for Property ReversedPayStatementLineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReversedPayStatementLineNum
        {
            get
            {
                return this._ReversedPayStatementLineNum;
            }
            set
            {
                this.OnReversedPayStatementLineNumChanging(value);
                this._ReversedPayStatementLineNum = value;
                this.OnReversedPayStatementLineNumChanged();
                this.OnPropertyChanged("ReversedPayStatementLineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReversedPayStatementLineNum;
        partial void OnReversedPayStatementLineNumChanging(decimal value);
        partial void OnReversedPayStatementLineNumChanged();
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
