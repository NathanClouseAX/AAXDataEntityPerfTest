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
        /// There are no comments for EarningStatementLineSingle in the schema.
        /// </summary>
    public partial class EarningStatementLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EarningStatementLine>
    {
        /// <summary>
        /// Initialize a new EarningStatementLineSingle object.
        /// </summary>
        public EarningStatementLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EarningStatementLineSingle object.
        /// </summary>
        public EarningStatementLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EarningStatementLineSingle object.
        /// </summary>
        public EarningStatementLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EarningStatementLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EarningStatement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EarningStatementSingle EarningStatement
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EarningStatement == null))
                {
                    this._EarningStatement = new global::Microsoft.Dynamics.DataEntities.EarningStatementSingle(this.Context, GetPath("EarningStatement"));
                }
                return this._EarningStatement;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EarningStatementSingle _EarningStatement;
        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
        /// <summary>
        /// There are no comments for EarningStatementLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// Company
    /// EarningsStatementNumber
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Company", "EarningsStatementNumber", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("EarningStatementLines")]
    public partial class EarningStatementLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EarningStatementLine object.
        /// </summary>
        /// <param name="company">Initial value of Company.</param>
        /// <param name="earningsStatementNumber">Initial value of EarningsStatementNumber.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="originalRetroactiveRate">Initial value of OriginalRetroactiveRate.</param>
        /// <param name="earningRate">Initial value of EarningRate.</param>
        /// <param name="accountingDate">Initial value of AccountingDate.</param>
        /// <param name="originatingEarningStatementLineNumber">Initial value of OriginatingEarningStatementLineNumber.</param>
        /// <param name="earningsDate">Initial value of EarningsDate.</param>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="earningStatement">Initial value of EarningStatement.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EarningStatementLine CreateEarningStatementLine(string company, 
                    string earningsStatementNumber, 
                    decimal lineNumber, 
                    decimal originalRetroactiveRate, 
                    decimal earningRate, 
                    global::System.DateTimeOffset accountingDate, 
                    decimal originatingEarningStatementLineNumber, 
                    global::System.DateTimeOffset earningsDate, 
                    decimal amount, 
                    decimal quantity, 
                    global::Microsoft.Dynamics.DataEntities.EarningStatement earningStatement)
        {
            EarningStatementLine earningStatementLine = new EarningStatementLine();
            earningStatementLine.Company = company;
            earningStatementLine.EarningsStatementNumber = earningsStatementNumber;
            earningStatementLine.LineNumber = lineNumber;
            earningStatementLine.OriginalRetroactiveRate = originalRetroactiveRate;
            earningStatementLine.EarningRate = earningRate;
            earningStatementLine.AccountingDate = accountingDate;
            earningStatementLine.OriginatingEarningStatementLineNumber = originatingEarningStatementLineNumber;
            earningStatementLine.EarningsDate = earningsDate;
            earningStatementLine.Amount = amount;
            earningStatementLine.Quantity = quantity;
            if ((earningStatement == null))
            {
                throw new global::System.ArgumentNullException("earningStatement");
            }
            earningStatementLine.EarningStatement = earningStatement;
            return earningStatementLine;
        }
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
        /// There are no comments for Property EarningsStatementNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EarningsStatementNumber
        {
            get
            {
                return this._EarningsStatementNumber;
            }
            set
            {
                this.OnEarningsStatementNumberChanging(value);
                this._EarningsStatementNumber = value;
                this.OnEarningsStatementNumberChanged();
                this.OnPropertyChanged("EarningsStatementNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EarningsStatementNumber;
        partial void OnEarningsStatementNumberChanging(string value);
        partial void OnEarningsStatementNumberChanged();
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
        /// There are no comments for Property OriginalRetroactiveRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OriginalRetroactiveRate
        {
            get
            {
                return this._OriginalRetroactiveRate;
            }
            set
            {
                this.OnOriginalRetroactiveRateChanging(value);
                this._OriginalRetroactiveRate = value;
                this.OnOriginalRetroactiveRateChanged();
                this.OnPropertyChanged("OriginalRetroactiveRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OriginalRetroactiveRate;
        partial void OnOriginalRetroactiveRateChanging(decimal value);
        partial void OnOriginalRetroactiveRateChanged();
        /// <summary>
        /// There are no comments for Property ProjectID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjectID
        {
            get
            {
                return this._ProjectID;
            }
            set
            {
                this.OnProjectIDChanging(value);
                this._ProjectID = value;
                this.OnProjectIDChanged();
                this.OnPropertyChanged("ProjectID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectID;
        partial void OnProjectIDChanging(string value);
        partial void OnProjectIDChanged();
        /// <summary>
        /// There are no comments for Property PaymentStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPaymentProcessingStatus> PaymentStatus
        {
            get
            {
                return this._PaymentStatus;
            }
            set
            {
                this.OnPaymentStatusChanging(value);
                this._PaymentStatus = value;
                this.OnPaymentStatusChanged();
                this.OnPropertyChanged("PaymentStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPaymentProcessingStatus> _PaymentStatus;
        partial void OnPaymentStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPaymentProcessingStatus> value);
        partial void OnPaymentStatusChanged();
        /// <summary>
        /// There are no comments for Property WorkerGeneralLiabilityInsuranceBenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkerGeneralLiabilityInsuranceBenefitId
        {
            get
            {
                return this._WorkerGeneralLiabilityInsuranceBenefitId;
            }
            set
            {
                this.OnWorkerGeneralLiabilityInsuranceBenefitIdChanging(value);
                this._WorkerGeneralLiabilityInsuranceBenefitId = value;
                this.OnWorkerGeneralLiabilityInsuranceBenefitIdChanged();
                this.OnPropertyChanged("WorkerGeneralLiabilityInsuranceBenefitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerGeneralLiabilityInsuranceBenefitId;
        partial void OnWorkerGeneralLiabilityInsuranceBenefitIdChanging(string value);
        partial void OnWorkerGeneralLiabilityInsuranceBenefitIdChanged();
        /// <summary>
        /// There are no comments for Property EarningRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal EarningRate
        {
            get
            {
                return this._EarningRate;
            }
            set
            {
                this.OnEarningRateChanging(value);
                this._EarningRate = value;
                this.OnEarningRateChanged();
                this.OnPropertyChanged("EarningRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _EarningRate;
        partial void OnEarningRateChanging(decimal value);
        partial void OnEarningRateChanged();
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
        /// There are no comments for Property WorkerTaxRegionLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkerTaxRegionLocationId
        {
            get
            {
                return this._WorkerTaxRegionLocationId;
            }
            set
            {
                this.OnWorkerTaxRegionLocationIdChanging(value);
                this._WorkerTaxRegionLocationId = value;
                this.OnWorkerTaxRegionLocationIdChanged();
                this.OnPropertyChanged("WorkerTaxRegionLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerTaxRegionLocationId;
        partial void OnWorkerTaxRegionLocationIdChanging(string value);
        partial void OnWorkerTaxRegionLocationIdChanged();
        /// <summary>
        /// There are no comments for Property ProjectLineProperty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjectLineProperty
        {
            get
            {
                return this._ProjectLineProperty;
            }
            set
            {
                this.OnProjectLinePropertyChanging(value);
                this._ProjectLineProperty = value;
                this.OnProjectLinePropertyChanged();
                this.OnPropertyChanged("ProjectLineProperty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectLineProperty;
        partial void OnProjectLinePropertyChanging(string value);
        partial void OnProjectLinePropertyChanged();
        /// <summary>
        /// There are no comments for Property AccountingDistributionTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountingDistributionTemplate
        {
            get
            {
                return this._AccountingDistributionTemplate;
            }
            set
            {
                this.OnAccountingDistributionTemplateChanging(value);
                this._AccountingDistributionTemplate = value;
                this.OnAccountingDistributionTemplateChanged();
                this.OnPropertyChanged("AccountingDistributionTemplate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountingDistributionTemplate;
        partial void OnAccountingDistributionTemplateChanging(string value);
        partial void OnAccountingDistributionTemplateChanged();
        /// <summary>
        /// There are no comments for Property IsManual in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsManual
        {
            get
            {
                return this._IsManual;
            }
            set
            {
                this.OnIsManualChanging(value);
                this._IsManual = value;
                this.OnIsManualChanged();
                this.OnPropertyChanged("IsManual");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsManual;
        partial void OnIsManualChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsManualChanged();
        /// <summary>
        /// There are no comments for Property EarningCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EarningCodeId
        {
            get
            {
                return this._EarningCodeId;
            }
            set
            {
                this.OnEarningCodeIdChanging(value);
                this._EarningCodeId = value;
                this.OnEarningCodeIdChanged();
                this.OnPropertyChanged("EarningCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EarningCodeId;
        partial void OnEarningCodeIdChanging(string value);
        partial void OnEarningCodeIdChanged();
        /// <summary>
        /// There are no comments for Property ActivityNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ActivityNumber
        {
            get
            {
                return this._ActivityNumber;
            }
            set
            {
                this.OnActivityNumberChanging(value);
                this._ActivityNumber = value;
                this.OnActivityNumberChanged();
                this.OnPropertyChanged("ActivityNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActivityNumber;
        partial void OnActivityNumberChanging(string value);
        partial void OnActivityNumberChanged();
        /// <summary>
        /// There are no comments for Property OriginatingEarningStatementLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OriginatingEarningStatementLineNumber
        {
            get
            {
                return this._OriginatingEarningStatementLineNumber;
            }
            set
            {
                this.OnOriginatingEarningStatementLineNumberChanging(value);
                this._OriginatingEarningStatementLineNumber = value;
                this.OnOriginatingEarningStatementLineNumberChanged();
                this.OnPropertyChanged("OriginatingEarningStatementLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OriginatingEarningStatementLineNumber;
        partial void OnOriginatingEarningStatementLineNumberChanging(decimal value);
        partial void OnOriginatingEarningStatementLineNumberChanged();
        /// <summary>
        /// There are no comments for Property EarningsDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EarningsDate
        {
            get
            {
                return this._EarningsDate;
            }
            set
            {
                this.OnEarningsDateChanging(value);
                this._EarningsDate = value;
                this.OnEarningsDateChanged();
                this.OnPropertyChanged("EarningsDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EarningsDate;
        partial void OnEarningsDateChanging(global::System.DateTimeOffset value);
        partial void OnEarningsDateChanged();
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
        /// There are no comments for Property GenerationSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollGenerationSource> GenerationSource
        {
            get
            {
                return this._GenerationSource;
            }
            set
            {
                this.OnGenerationSourceChanging(value);
                this._GenerationSource = value;
                this.OnGenerationSourceChanged();
                this.OnPropertyChanged("GenerationSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollGenerationSource> _GenerationSource;
        partial void OnGenerationSourceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollGenerationSource> value);
        partial void OnGenerationSourceChanged();
        /// <summary>
        /// There are no comments for Property DimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionDisplayValue
        {
            get
            {
                return this._DimensionDisplayValue;
            }
            set
            {
                this.OnDimensionDisplayValueChanging(value);
                this._DimensionDisplayValue = value;
                this.OnDimensionDisplayValueChanged();
                this.OnPropertyChanged("DimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionDisplayValue;
        partial void OnDimensionDisplayValueChanging(string value);
        partial void OnDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property LineModified in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> LineModified
        {
            get
            {
                return this._LineModified;
            }
            set
            {
                this.OnLineModifiedChanging(value);
                this._LineModified = value;
                this.OnLineModifiedChanged();
                this.OnPropertyChanged("LineModified");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _LineModified;
        partial void OnLineModifiedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnLineModifiedChanged();
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property Note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this.OnNoteChanging(value);
                this._Note = value;
                this.OnNoteChanged();
                this.OnPropertyChanged("Note");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Note;
        partial void OnNoteChanging(string value);
        partial void OnNoteChanged();
        /// <summary>
        /// There are no comments for Property OriginatingEarningStatementNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OriginatingEarningStatementNumber
        {
            get
            {
                return this._OriginatingEarningStatementNumber;
            }
            set
            {
                this.OnOriginatingEarningStatementNumberChanging(value);
                this._OriginatingEarningStatementNumber = value;
                this.OnOriginatingEarningStatementNumberChanged();
                this.OnPropertyChanged("OriginatingEarningStatementNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OriginatingEarningStatementNumber;
        partial void OnOriginatingEarningStatementNumberChanging(string value);
        partial void OnOriginatingEarningStatementNumberChanged();
        /// <summary>
        /// There are no comments for Property ProjectCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjectCategory
        {
            get
            {
                return this._ProjectCategory;
            }
            set
            {
                this.OnProjectCategoryChanging(value);
                this._ProjectCategory = value;
                this.OnProjectCategoryChanged();
                this.OnPropertyChanged("ProjectCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectCategory;
        partial void OnProjectCategoryChanging(string value);
        partial void OnProjectCategoryChanged();
        /// <summary>
        /// There are no comments for Property WorkerCompensationBenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkerCompensationBenefitId
        {
            get
            {
                return this._WorkerCompensationBenefitId;
            }
            set
            {
                this.OnWorkerCompensationBenefitIdChanging(value);
                this._WorkerCompensationBenefitId = value;
                this.OnWorkerCompensationBenefitIdChanged();
                this.OnPropertyChanged("WorkerCompensationBenefitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerCompensationBenefitId;
        partial void OnWorkerCompensationBenefitIdChanging(string value);
        partial void OnWorkerCompensationBenefitIdChanged();
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Amount;
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
        /// <summary>
        /// There are no comments for Property PremiumEarningCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PremiumEarningCode
        {
            get
            {
                return this._PremiumEarningCode;
            }
            set
            {
                this.OnPremiumEarningCodeChanging(value);
                this._PremiumEarningCode = value;
                this.OnPremiumEarningCodeChanged();
                this.OnPropertyChanged("PremiumEarningCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PremiumEarningCode;
        partial void OnPremiumEarningCodeChanging(string value);
        partial void OnPremiumEarningCodeChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Quantity;
        partial void OnQuantityChanging(decimal value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property EarningStatement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EarningStatement EarningStatement
        {
            get
            {
                return this._EarningStatement;
            }
            set
            {
                this.OnEarningStatementChanging(value);
                this._EarningStatement = value;
                this.OnEarningStatementChanged();
                this.OnPropertyChanged("EarningStatement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EarningStatement _EarningStatement;
        partial void OnEarningStatementChanging(global::Microsoft.Dynamics.DataEntities.EarningStatement value);
        partial void OnEarningStatementChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
