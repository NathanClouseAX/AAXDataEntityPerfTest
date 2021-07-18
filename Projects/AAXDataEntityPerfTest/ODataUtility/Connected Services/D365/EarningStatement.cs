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
        /// There are no comments for EarningStatementSingle in the schema.
        /// </summary>
    public partial class EarningStatementSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EarningStatement>
    {
        /// <summary>
        /// Initialize a new EarningStatementSingle object.
        /// </summary>
        public EarningStatementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EarningStatementSingle object.
        /// </summary>
        public EarningStatementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EarningStatementSingle object.
        /// </summary>
        public EarningStatementSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EarningStatement> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EarningStatementLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EarningStatementLine> EarningStatementLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EarningStatementLine == null))
                {
                    this._EarningStatementLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EarningStatementLine>(GetPath("EarningStatementLine"));
                }
                return this._EarningStatementLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EarningStatementLine> _EarningStatementLine;
        /// <summary>
        /// There are no comments for PayrollEarningStatementLineInquiry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> PayrollEarningStatementLineInquiry
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollEarningStatementLineInquiry == null))
                {
                    this._PayrollEarningStatementLineInquiry = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry>(GetPath("PayrollEarningStatementLineInquiry"));
                }
                return this._PayrollEarningStatementLineInquiry;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> _PayrollEarningStatementLineInquiry;
    }
        /// <summary>
        /// There are no comments for EarningStatement in the schema.
        /// </summary>
    /// <KeyProperties>
    /// Company
    /// EarningsStatementNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Company", "EarningsStatementNumber")]
    [global::Microsoft.OData.Client.EntitySet("EarningStatements")]
    public partial class EarningStatement : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EarningStatement object.
        /// </summary>
        /// <param name="company">Initial value of Company.</param>
        /// <param name="earningsStatementNumber">Initial value of EarningsStatementNumber.</param>
        /// <param name="payPeriodEndDate">Initial value of PayPeriodEndDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EarningStatement CreateEarningStatement(string company, string earningsStatementNumber, global::System.DateTimeOffset payPeriodEndDate)
        {
            EarningStatement earningStatement = new EarningStatement();
            earningStatement.Company = company;
            earningStatement.EarningsStatementNumber = earningsStatementNumber;
            earningStatement.PayPeriodEndDate = payPeriodEndDate;
            return earningStatement;
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
        /// There are no comments for Property PayCycleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PayCycleId
        {
            get
            {
                return this._PayCycleId;
            }
            set
            {
                this.OnPayCycleIdChanging(value);
                this._PayCycleId = value;
                this.OnPayCycleIdChanged();
                this.OnPropertyChanged("PayCycleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PayCycleId;
        partial void OnPayCycleIdChanging(string value);
        partial void OnPayCycleIdChanged();
        /// <summary>
        /// There are no comments for Property PayPeriodEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset PayPeriodEndDate
        {
            get
            {
                return this._PayPeriodEndDate;
            }
            set
            {
                this.OnPayPeriodEndDateChanging(value);
                this._PayPeriodEndDate = value;
                this.OnPayPeriodEndDateChanged();
                this.OnPropertyChanged("PayPeriodEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PayPeriodEndDate;
        partial void OnPayPeriodEndDateChanging(global::System.DateTimeOffset value);
        partial void OnPayPeriodEndDateChanged();
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
        /// There are no comments for Property EarningStatementLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLine> EarningStatementLine
        {
            get
            {
                return this._EarningStatementLine;
            }
            set
            {
                this.OnEarningStatementLineChanging(value);
                this._EarningStatementLine = value;
                this.OnEarningStatementLineChanged();
                this.OnPropertyChanged("EarningStatementLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLine> _EarningStatementLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEarningStatementLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLine> value);
        partial void OnEarningStatementLineChanged();
        /// <summary>
        /// There are no comments for Property PayrollEarningStatementLineInquiry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> PayrollEarningStatementLineInquiry
        {
            get
            {
                return this._PayrollEarningStatementLineInquiry;
            }
            set
            {
                this.OnPayrollEarningStatementLineInquiryChanging(value);
                this._PayrollEarningStatementLineInquiry = value;
                this.OnPayrollEarningStatementLineInquiryChanged();
                this.OnPropertyChanged("PayrollEarningStatementLineInquiry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> _PayrollEarningStatementLineInquiry = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPayrollEarningStatementLineInquiryChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> value);
        partial void OnPayrollEarningStatementLineInquiryChanged();
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
