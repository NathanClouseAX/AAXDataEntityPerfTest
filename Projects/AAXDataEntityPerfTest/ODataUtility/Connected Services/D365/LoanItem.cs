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
    /// There are no comments for LoanItemSingle in the schema.
    /// </summary>
    public partial class LoanItemSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LoanItem>
    {
        /// <summary>
        /// Initialize a new LoanItemSingle object.
        /// </summary>
        public LoanItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LoanItemSingle object.
        /// </summary>
        public LoanItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LoanItemSingle object.
        /// </summary>
        public LoanItemSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LoanItem> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LoanedEquipments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LoanedEquipment> LoanedEquipments
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LoanedEquipments == null))
                {
                    this._LoanedEquipments = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LoanedEquipment>(GetPath("LoanedEquipments"));
                }
                return this._LoanedEquipments;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LoanedEquipment> _LoanedEquipments;
    }
    /// <summary>
    /// There are no comments for LoanItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LoanItemId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LoanItemId")]
    [global::Microsoft.OData.Client.EntitySet("LoanItems")]
    public partial class LoanItem : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LoanItem object.
        /// </summary>
        /// <param name="loanItemId">Initial value of LoanItemId.</param>
        /// <param name="gracePeriodDays">Initial value of GracePeriodDays.</param>
        /// <param name="loanDays">Initial value of LoanDays.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LoanItem CreateLoanItem(string loanItemId, int gracePeriodDays, int loanDays)
        {
            LoanItem loanItem = new LoanItem();
            loanItem.LoanItemId = loanItemId;
            loanItem.GracePeriodDays = gracePeriodDays;
            loanItem.LoanDays = loanDays;
            return loanItem;
        }
        /// <summary>
        /// There are no comments for Property LoanItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LoanItemId is required.")]
        public virtual string LoanItemId
        {
            get
            {
                return this._LoanItemId;
            }
            set
            {
                this.OnLoanItemIdChanging(value);
                this._LoanItemId = value;
                this.OnLoanItemIdChanged();
                this.OnPropertyChanged("LoanItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LoanItemId;
        partial void OnLoanItemIdChanging(string value);
        partial void OnLoanItemIdChanged();
        /// <summary>
        /// There are no comments for Property PersonInCharge in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string PersonInCharge
        {
            get
            {
                return this._PersonInCharge;
            }
            set
            {
                this.OnPersonInChargeChanging(value);
                this._PersonInCharge = value;
                this.OnPersonInChargeChanged();
                this.OnPropertyChanged("PersonInCharge");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonInCharge;
        partial void OnPersonInChargeChanging(string value);
        partial void OnPersonInChargeChanged();
        /// <summary>
        /// There are no comments for Property LoanTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string LoanTypeId
        {
            get
            {
                return this._LoanTypeId;
            }
            set
            {
                this.OnLoanTypeIdChanging(value);
                this._LoanTypeId = value;
                this.OnLoanTypeIdChanged();
                this.OnPropertyChanged("LoanTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LoanTypeId;
        partial void OnLoanTypeIdChanging(string value);
        partial void OnLoanTypeIdChanged();
        /// <summary>
        /// There are no comments for Property TaxReporting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmLoanItemTax> TaxReporting
        {
            get
            {
                return this._TaxReporting;
            }
            set
            {
                this.OnTaxReportingChanging(value);
                this._TaxReporting = value;
                this.OnTaxReportingChanged();
                this.OnPropertyChanged("TaxReporting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmLoanItemTax> _TaxReporting;
        partial void OnTaxReportingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmLoanItemTax> value);
        partial void OnTaxReportingChanged();
        /// <summary>
        /// There are no comments for Property GracePeriodDays in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GracePeriodDays is required.")]
        public virtual int GracePeriodDays
        {
            get
            {
                return this._GracePeriodDays;
            }
            set
            {
                this.OnGracePeriodDaysChanging(value);
                this._GracePeriodDays = value;
                this.OnGracePeriodDaysChanged();
                this.OnPropertyChanged("GracePeriodDays");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _GracePeriodDays;
        partial void OnGracePeriodDaysChanging(int value);
        partial void OnGracePeriodDaysChanged();
        /// <summary>
        /// There are no comments for Property SerialNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string SerialNumber
        {
            get
            {
                return this._SerialNumber;
            }
            set
            {
                this.OnSerialNumberChanging(value);
                this._SerialNumber = value;
                this.OnSerialNumberChanged();
                this.OnPropertyChanged("SerialNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SerialNumber;
        partial void OnSerialNumberChanging(string value);
        partial void OnSerialNumberChanged();
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
        /// There are no comments for Property LoanDays in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LoanDays is required.")]
        public virtual int LoanDays
        {
            get
            {
                return this._LoanDays;
            }
            set
            {
                this.OnLoanDaysChanging(value);
                this._LoanDays = value;
                this.OnLoanDaysChanged();
                this.OnPropertyChanged("LoanDays");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _LoanDays;
        partial void OnLoanDaysChanging(int value);
        partial void OnLoanDaysChanged();
        /// <summary>
        /// There are no comments for Property LoanedEquipments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LoanedEquipment> LoanedEquipments
        {
            get
            {
                return this._LoanedEquipments;
            }
            set
            {
                this.OnLoanedEquipmentsChanging(value);
                this._LoanedEquipments = value;
                this.OnLoanedEquipmentsChanged();
                this.OnPropertyChanged("LoanedEquipments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LoanedEquipment> _LoanedEquipments = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LoanedEquipment>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLoanedEquipmentsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LoanedEquipment> value);
        partial void OnLoanedEquipmentsChanged();
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
