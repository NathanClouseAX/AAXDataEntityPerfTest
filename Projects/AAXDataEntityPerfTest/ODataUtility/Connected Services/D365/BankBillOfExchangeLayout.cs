﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for BankBillOfExchangeLayoutSingle in the schema.
        /// </summary>
    public partial class BankBillOfExchangeLayoutSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BankBillOfExchangeLayout>
    {
        /// <summary>
        /// Initialize a new BankBillOfExchangeLayoutSingle object.
        /// </summary>
        public BankBillOfExchangeLayoutSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BankBillOfExchangeLayoutSingle object.
        /// </summary>
        public BankBillOfExchangeLayoutSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BankBillOfExchangeLayoutSingle object.
        /// </summary>
        public BankBillOfExchangeLayoutSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BankBillOfExchangeLayout> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BankAccountSingle BankAccount
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BankAccount == null))
                {
                    this._BankAccount = new global::Microsoft.Dynamics.DataEntities.BankAccountSingle(this.Context, GetPath("BankAccount"));
                }
                return this._BankAccount;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BankAccountSingle _BankAccount;
    }
        /// <summary>
        /// There are no comments for BankBillOfExchangeLayout in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// BankAccountId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "BankAccountId")]
    [global::Microsoft.OData.Client.EntitySet("BankBillOfExchangeLayouts")]
    public partial class BankBillOfExchangeLayout : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BankBillOfExchangeLayout object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="bankAccountId">Initial value of BankAccountId.</param>
        /// <param name="paperLength">Initial value of PaperLength.</param>
        /// <param name="numberOfSlipCopies">Initial value of NumberOfSlipCopies.</param>
        /// <param name="firstSignatureAmountLimit">Initial value of FirstSignatureAmountLimit.</param>
        /// <param name="startPosition">Initial value of StartPosition.</param>
        /// <param name="secondSignatureAmountLimit">Initial value of SecondSignatureAmountLimit.</param>
        /// <param name="bankAccount">Initial value of BankAccount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BankBillOfExchangeLayout CreateBankBillOfExchangeLayout(string dataAreaId, 
                    string bankAccountId, 
                    decimal paperLength, 
                    int numberOfSlipCopies, 
                    decimal firstSignatureAmountLimit, 
                    decimal startPosition, 
                    decimal secondSignatureAmountLimit, 
                    global::Microsoft.Dynamics.DataEntities.BankAccount bankAccount)
        {
            BankBillOfExchangeLayout bankBillOfExchangeLayout = new BankBillOfExchangeLayout();
            bankBillOfExchangeLayout.dataAreaId = dataAreaId;
            bankBillOfExchangeLayout.BankAccountId = bankAccountId;
            bankBillOfExchangeLayout.PaperLength = paperLength;
            bankBillOfExchangeLayout.NumberOfSlipCopies = numberOfSlipCopies;
            bankBillOfExchangeLayout.FirstSignatureAmountLimit = firstSignatureAmountLimit;
            bankBillOfExchangeLayout.StartPosition = startPosition;
            bankBillOfExchangeLayout.SecondSignatureAmountLimit = secondSignatureAmountLimit;
            if ((bankAccount == null))
            {
                throw new global::System.ArgumentNullException("bankAccount");
            }
            bankBillOfExchangeLayout.BankAccount = bankAccount;
            return bankBillOfExchangeLayout;
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
        /// There are no comments for Property BankAccountId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BankAccountId
        {
            get
            {
                return this._BankAccountId;
            }
            set
            {
                this.OnBankAccountIdChanging(value);
                this._BankAccountId = value;
                this.OnBankAccountIdChanged();
                this.OnPropertyChanged("BankAccountId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BankAccountId;
        partial void OnBankAccountIdChanging(string value);
        partial void OnBankAccountIdChanged();
        /// <summary>
        /// There are no comments for Property PrintBankCity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PrintBankCity
        {
            get
            {
                return this._PrintBankCity;
            }
            set
            {
                this.OnPrintBankCityChanging(value);
                this._PrintBankCity = value;
                this.OnPrintBankCityChanged();
                this.OnPropertyChanged("PrintBankCity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PrintBankCity;
        partial void OnPrintBankCityChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPrintBankCityChanged();
        /// <summary>
        /// There are no comments for Property PaperLength in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PaperLength
        {
            get
            {
                return this._PaperLength;
            }
            set
            {
                this.OnPaperLengthChanging(value);
                this._PaperLength = value;
                this.OnPaperLengthChanged();
                this.OnPropertyChanged("PaperLength");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PaperLength;
        partial void OnPaperLengthChanging(decimal value);
        partial void OnPaperLengthChanged();
        /// <summary>
        /// There are no comments for Property NumberOfSlipCopies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int NumberOfSlipCopies
        {
            get
            {
                return this._NumberOfSlipCopies;
            }
            set
            {
                this.OnNumberOfSlipCopiesChanging(value);
                this._NumberOfSlipCopies = value;
                this.OnNumberOfSlipCopiesChanged();
                this.OnPropertyChanged("NumberOfSlipCopies");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NumberOfSlipCopies;
        partial void OnNumberOfSlipCopiesChanging(int value);
        partial void OnNumberOfSlipCopiesChanged();
        /// <summary>
        /// There are no comments for Property PrintBankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PrintBankAccount
        {
            get
            {
                return this._PrintBankAccount;
            }
            set
            {
                this.OnPrintBankAccountChanging(value);
                this._PrintBankAccount = value;
                this.OnPrintBankAccountChanged();
                this.OnPropertyChanged("PrintBankAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PrintBankAccount;
        partial void OnPrintBankAccountChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPrintBankAccountChanged();
        /// <summary>
        /// There are no comments for Property FirstSignatureAmountLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal FirstSignatureAmountLimit
        {
            get
            {
                return this._FirstSignatureAmountLimit;
            }
            set
            {
                this.OnFirstSignatureAmountLimitChanging(value);
                this._FirstSignatureAmountLimit = value;
                this.OnFirstSignatureAmountLimitChanged();
                this.OnPropertyChanged("FirstSignatureAmountLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FirstSignatureAmountLimit;
        partial void OnFirstSignatureAmountLimitChanging(decimal value);
        partial void OnFirstSignatureAmountLimitChanged();
        /// <summary>
        /// There are no comments for Property StartPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal StartPosition
        {
            get
            {
                return this._StartPosition;
            }
            set
            {
                this.OnStartPositionChanging(value);
                this._StartPosition = value;
                this.OnStartPositionChanged();
                this.OnPropertyChanged("StartPosition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _StartPosition;
        partial void OnStartPositionChanging(decimal value);
        partial void OnStartPositionChanged();
        /// <summary>
        /// There are no comments for Property PrintTransactionDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PrintTransactionDate
        {
            get
            {
                return this._PrintTransactionDate;
            }
            set
            {
                this.OnPrintTransactionDateChanging(value);
                this._PrintTransactionDate = value;
                this.OnPrintTransactionDateChanged();
                this.OnPropertyChanged("PrintTransactionDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PrintTransactionDate;
        partial void OnPrintTransactionDateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPrintTransactionDateChanged();
        /// <summary>
        /// There are no comments for Property NumberMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BankBillOfExchangeNumMethod> NumberMethod
        {
            get
            {
                return this._NumberMethod;
            }
            set
            {
                this.OnNumberMethodChanging(value);
                this._NumberMethod = value;
                this.OnNumberMethodChanged();
                this.OnPropertyChanged("NumberMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BankBillOfExchangeNumMethod> _NumberMethod;
        partial void OnNumberMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BankBillOfExchangeNumMethod> value);
        partial void OnNumberMethodChanged();
        /// <summary>
        /// There are no comments for Property PrintBankNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PrintBankNumber
        {
            get
            {
                return this._PrintBankNumber;
            }
            set
            {
                this.OnPrintBankNumberChanging(value);
                this._PrintBankNumber = value;
                this.OnPrintBankNumberChanged();
                this.OnPropertyChanged("PrintBankNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PrintBankNumber;
        partial void OnPrintBankNumberChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPrintBankNumberChanged();
        /// <summary>
        /// There are no comments for Property PaperLengthUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Units> PaperLengthUnit
        {
            get
            {
                return this._PaperLengthUnit;
            }
            set
            {
                this.OnPaperLengthUnitChanging(value);
                this._PaperLengthUnit = value;
                this.OnPaperLengthUnitChanged();
                this.OnPropertyChanged("PaperLengthUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Units> _PaperLengthUnit;
        partial void OnPaperLengthUnitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Units> value);
        partial void OnPaperLengthUnitChanged();
        /// <summary>
        /// There are no comments for Property PrintBankName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PrintBankName
        {
            get
            {
                return this._PrintBankName;
            }
            set
            {
                this.OnPrintBankNameChanging(value);
                this._PrintBankName = value;
                this.OnPrintBankNameChanged();
                this.OnPropertyChanged("PrintBankName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PrintBankName;
        partial void OnPrintBankNameChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPrintBankNameChanged();
        /// <summary>
        /// There are no comments for Property PrintDueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PrintDueDate
        {
            get
            {
                return this._PrintDueDate;
            }
            set
            {
                this.OnPrintDueDateChanging(value);
                this._PrintDueDate = value;
                this.OnPrintDueDateChanged();
                this.OnPropertyChanged("PrintDueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PrintDueDate;
        partial void OnPrintDueDateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPrintDueDateChanged();
        /// <summary>
        /// There are no comments for Property SecondSignatureAmountLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SecondSignatureAmountLimit
        {
            get
            {
                return this._SecondSignatureAmountLimit;
            }
            set
            {
                this.OnSecondSignatureAmountLimitChanging(value);
                this._SecondSignatureAmountLimit = value;
                this.OnSecondSignatureAmountLimitChanged();
                this.OnPropertyChanged("SecondSignatureAmountLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SecondSignatureAmountLimit;
        partial void OnSecondSignatureAmountLimitChanging(decimal value);
        partial void OnSecondSignatureAmountLimitChanged();
        /// <summary>
        /// There are no comments for Property AmountPrefix in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AmountPrefix
        {
            get
            {
                return this._AmountPrefix;
            }
            set
            {
                this.OnAmountPrefixChanging(value);
                this._AmountPrefix = value;
                this.OnAmountPrefixChanged();
                this.OnPropertyChanged("AmountPrefix");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AmountPrefix;
        partial void OnAmountPrefixChanging(string value);
        partial void OnAmountPrefixChanged();
        /// <summary>
        /// There are no comments for Property PrintCompanyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PrintCompanyName
        {
            get
            {
                return this._PrintCompanyName;
            }
            set
            {
                this.OnPrintCompanyNameChanging(value);
                this._PrintCompanyName = value;
                this.OnPrintCompanyNameChanged();
                this.OnPropertyChanged("PrintCompanyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PrintCompanyName;
        partial void OnPrintCompanyNameChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPrintCompanyNameChanged();
        /// <summary>
        /// There are no comments for Property PrintSecondSignature in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PrintSecondSignature
        {
            get
            {
                return this._PrintSecondSignature;
            }
            set
            {
                this.OnPrintSecondSignatureChanging(value);
                this._PrintSecondSignature = value;
                this.OnPrintSecondSignatureChanged();
                this.OnPropertyChanged("PrintSecondSignature");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PrintSecondSignature;
        partial void OnPrintSecondSignatureChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPrintSecondSignatureChanged();
        /// <summary>
        /// There are no comments for Property StartPositionUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Units> StartPositionUnit
        {
            get
            {
                return this._StartPositionUnit;
            }
            set
            {
                this.OnStartPositionUnitChanging(value);
                this._StartPositionUnit = value;
                this.OnStartPositionUnitChanged();
                this.OnPropertyChanged("StartPositionUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Units> _StartPositionUnit;
        partial void OnStartPositionUnitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Units> value);
        partial void OnStartPositionUnitChanged();
        /// <summary>
        /// There are no comments for Property PrintCompanyLogo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PrintCompanyLogo
        {
            get
            {
                return this._PrintCompanyLogo;
            }
            set
            {
                this.OnPrintCompanyLogoChanging(value);
                this._PrintCompanyLogo = value;
                this.OnPrintCompanyLogoChanged();
                this.OnPropertyChanged("PrintCompanyLogo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PrintCompanyLogo;
        partial void OnPrintCompanyLogoChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPrintCompanyLogoChanged();
        /// <summary>
        /// There are no comments for Property FormatType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BankBillOfExchangeFormType> FormatType
        {
            get
            {
                return this._FormatType;
            }
            set
            {
                this.OnFormatTypeChanging(value);
                this._FormatType = value;
                this.OnFormatTypeChanged();
                this.OnPropertyChanged("FormatType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BankBillOfExchangeFormType> _FormatType;
        partial void OnFormatTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BankBillOfExchangeFormType> value);
        partial void OnFormatTypeChanged();
        /// <summary>
        /// There are no comments for Property PrintFirstSignature in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PrintFirstSignature
        {
            get
            {
                return this._PrintFirstSignature;
            }
            set
            {
                this.OnPrintFirstSignatureChanging(value);
                this._PrintFirstSignature = value;
                this.OnPrintFirstSignatureChanged();
                this.OnPropertyChanged("PrintFirstSignature");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PrintFirstSignature;
        partial void OnPrintFirstSignatureChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPrintFirstSignatureChanged();
        /// <summary>
        /// There are no comments for Property BankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BankAccount BankAccount
        {
            get
            {
                return this._BankAccount;
            }
            set
            {
                this.OnBankAccountChanging(value);
                this._BankAccount = value;
                this.OnBankAccountChanged();
                this.OnPropertyChanged("BankAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BankAccount _BankAccount;
        partial void OnBankAccountChanging(global::Microsoft.Dynamics.DataEntities.BankAccount value);
        partial void OnBankAccountChanged();
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
