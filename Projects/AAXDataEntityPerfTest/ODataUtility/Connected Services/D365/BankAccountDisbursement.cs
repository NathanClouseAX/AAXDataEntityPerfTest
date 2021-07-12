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
        /// There are no comments for BankAccountDisbursementSingle in the schema.
        /// </summary>
    public partial class BankAccountDisbursementSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BankAccountDisbursement>
    {
        /// <summary>
        /// Initialize a new BankAccountDisbursementSingle object.
        /// </summary>
        public BankAccountDisbursementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BankAccountDisbursementSingle object.
        /// </summary>
        public BankAccountDisbursementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BankAccountDisbursementSingle object.
        /// </summary>
        public BankAccountDisbursementSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BankAccountDisbursement> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WorkerBankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerBankAccountSingle WorkerBankAccount
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerBankAccount == null))
                {
                    this._WorkerBankAccount = new global::Microsoft.Dynamics.DataEntities.WorkerBankAccountSingle(this.Context, GetPath("WorkerBankAccount"));
                }
                return this._WorkerBankAccount;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerBankAccountSingle _WorkerBankAccount;
        /// <summary>
        /// There are no comments for Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle Worker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Worker == null))
                {
                    this._Worker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("Worker"));
                }
                return this._Worker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _Worker;
    }
        /// <summary>
        /// There are no comments for BankAccountDisbursement in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PersonnelNumber
    /// AccountIdentificationId
    /// Company
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelNumber", "AccountIdentificationId", "Company")]
    [global::Microsoft.OData.Client.EntitySet("BankAccountDisbursements")]
    public partial class BankAccountDisbursement : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BankAccountDisbursement object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="accountIdentificationId">Initial value of AccountIdentificationId.</param>
        /// <param name="company">Initial value of Company.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="workerBankAccount">Initial value of WorkerBankAccount.</param>
        /// <param name="worker">Initial value of Worker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BankAccountDisbursement CreateBankAccountDisbursement(string personnelNumber, 
                    string accountIdentificationId, 
                    string company, 
                    decimal lineNumber, 
                    decimal amount, 
                    global::Microsoft.Dynamics.DataEntities.WorkerBankAccount workerBankAccount, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker)
        {
            BankAccountDisbursement bankAccountDisbursement = new BankAccountDisbursement();
            bankAccountDisbursement.PersonnelNumber = personnelNumber;
            bankAccountDisbursement.AccountIdentificationId = accountIdentificationId;
            bankAccountDisbursement.Company = company;
            bankAccountDisbursement.LineNumber = lineNumber;
            bankAccountDisbursement.Amount = amount;
            if ((workerBankAccount == null))
            {
                throw new global::System.ArgumentNullException("workerBankAccount");
            }
            bankAccountDisbursement.WorkerBankAccount = workerBankAccount;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            bankAccountDisbursement.Worker = worker;
            return bankAccountDisbursement;
        }
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
        /// There are no comments for Property AccountIdentificationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountIdentificationId
        {
            get
            {
                return this._AccountIdentificationId;
            }
            set
            {
                this.OnAccountIdentificationIdChanging(value);
                this._AccountIdentificationId = value;
                this.OnAccountIdentificationIdChanged();
                this.OnPropertyChanged("AccountIdentificationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountIdentificationId;
        partial void OnAccountIdentificationIdChanging(string value);
        partial void OnAccountIdentificationIdChanged();
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
        /// There are no comments for Property Remainder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Remainder
        {
            get
            {
                return this._Remainder;
            }
            set
            {
                this.OnRemainderChanging(value);
                this._Remainder = value;
                this.OnRemainderChanged();
                this.OnPropertyChanged("Remainder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Remainder;
        partial void OnRemainderChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRemainderChanged();
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
        /// There are no comments for Property InPrenoteStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> InPrenoteStatus
        {
            get
            {
                return this._InPrenoteStatus;
            }
            set
            {
                this.OnInPrenoteStatusChanging(value);
                this._InPrenoteStatus = value;
                this.OnInPrenoteStatusChanged();
                this.OnPropertyChanged("InPrenoteStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _InPrenoteStatus;
        partial void OnInPrenoteStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnInPrenoteStatusChanged();
        /// <summary>
        /// There are no comments for Property WorkerBankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerBankAccount WorkerBankAccount
        {
            get
            {
                return this._WorkerBankAccount;
            }
            set
            {
                this.OnWorkerBankAccountChanging(value);
                this._WorkerBankAccount = value;
                this.OnWorkerBankAccountChanged();
                this.OnPropertyChanged("WorkerBankAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerBankAccount _WorkerBankAccount;
        partial void OnWorkerBankAccountChanging(global::Microsoft.Dynamics.DataEntities.WorkerBankAccount value);
        partial void OnWorkerBankAccountChanged();
        /// <summary>
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker Worker
        {
            get
            {
                return this._Worker;
            }
            set
            {
                this.OnWorkerChanging(value);
                this._Worker = value;
                this.OnWorkerChanged();
                this.OnPropertyChanged("Worker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _Worker;
        partial void OnWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnWorkerChanged();
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
