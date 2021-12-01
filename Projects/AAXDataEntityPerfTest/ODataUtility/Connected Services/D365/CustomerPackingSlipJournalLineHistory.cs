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
    /// There are no comments for CustomerPackingSlipJournalLineHistorySingle in the schema.
    /// </summary>
    public partial class CustomerPackingSlipJournalLineHistorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerPackingSlipJournalLineHistory>
    {
        /// <summary>
        /// Initialize a new CustomerPackingSlipJournalLineHistorySingle object.
        /// </summary>
        public CustomerPackingSlipJournalLineHistorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomerPackingSlipJournalLineHistorySingle object.
        /// </summary>
        public CustomerPackingSlipJournalLineHistorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomerPackingSlipJournalLineHistorySingle object.
        /// </summary>
        public CustomerPackingSlipJournalLineHistorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerPackingSlipJournalLineHistory> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CustomerPackingSlipJournalLineHistory in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CPFNum_BR
    /// CRCNum_BR
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CPFNum_BR", "CRCNum_BR")]
    [global::Microsoft.OData.Client.EntitySet("CustomerPackingSlipJournalLineHistories")]
    public partial class CustomerPackingSlipJournalLineHistory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomerPackingSlipJournalLineHistory object.
        /// </summary>
        /// <param name="cPFNum_BR">Initial value of CPFNum_BR.</param>
        /// <param name="cRCNum_BR">Initial value of CRCNum_BR.</param>
        /// <param name="cRCExpirationDate">Initial value of CRCExpirationDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomerPackingSlipJournalLineHistory CreateCustomerPackingSlipJournalLineHistory(string cPFNum_BR, string cRCNum_BR, global::System.DateTimeOffset cRCExpirationDate)
        {
            CustomerPackingSlipJournalLineHistory customerPackingSlipJournalLineHistory = new CustomerPackingSlipJournalLineHistory();
            customerPackingSlipJournalLineHistory.CPFNum_BR = cPFNum_BR;
            customerPackingSlipJournalLineHistory.CRCNum_BR = cRCNum_BR;
            customerPackingSlipJournalLineHistory.CRCExpirationDate = cRCExpirationDate;
            return customerPackingSlipJournalLineHistory;
        }
        /// <summary>
        /// There are no comments for Property CPFNum_BR in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CPFNum_BR is required.")]
        public virtual string CPFNum_BR
        {
            get
            {
                return this._CPFNum_BR;
            }
            set
            {
                this.OnCPFNum_BRChanging(value);
                this._CPFNum_BR = value;
                this.OnCPFNum_BRChanged();
                this.OnPropertyChanged("CPFNum_BR");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CPFNum_BR;
        partial void OnCPFNum_BRChanging(string value);
        partial void OnCPFNum_BRChanged();
        /// <summary>
        /// There are no comments for Property CRCNum_BR in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CRCNum_BR is required.")]
        public virtual string CRCNum_BR
        {
            get
            {
                return this._CRCNum_BR;
            }
            set
            {
                this.OnCRCNum_BRChanging(value);
                this._CRCNum_BR = value;
                this.OnCRCNum_BRChanged();
                this.OnPropertyChanged("CRCNum_BR");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CRCNum_BR;
        partial void OnCRCNum_BRChanging(string value);
        partial void OnCRCNum_BRChanged();
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
        /// There are no comments for Property CRCCountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string CRCCountryRegionId
        {
            get
            {
                return this._CRCCountryRegionId;
            }
            set
            {
                this.OnCRCCountryRegionIdChanging(value);
                this._CRCCountryRegionId = value;
                this.OnCRCCountryRegionIdChanged();
                this.OnPropertyChanged("CRCCountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CRCCountryRegionId;
        partial void OnCRCCountryRegionIdChanging(string value);
        partial void OnCRCCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property CRCExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CRCExpirationDate is required.")]
        public virtual global::System.DateTimeOffset CRCExpirationDate
        {
            get
            {
                return this._CRCExpirationDate;
            }
            set
            {
                this.OnCRCExpirationDateChanging(value);
                this._CRCExpirationDate = value;
                this.OnCRCExpirationDateChanged();
                this.OnPropertyChanged("CRCExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CRCExpirationDate;
        partial void OnCRCExpirationDateChanging(global::System.DateTimeOffset value);
        partial void OnCRCExpirationDateChanged();
        /// <summary>
        /// There are no comments for Property CNPJNum_BR in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string CNPJNum_BR
        {
            get
            {
                return this._CNPJNum_BR;
            }
            set
            {
                this.OnCNPJNum_BRChanging(value);
                this._CNPJNum_BR = value;
                this.OnCNPJNum_BRChanged();
                this.OnPropertyChanged("CNPJNum_BR");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CNPJNum_BR;
        partial void OnCNPJNum_BRChanging(string value);
        partial void OnCNPJNum_BRChanged();
        /// <summary>
        /// There are no comments for Property CRCStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string CRCStateId
        {
            get
            {
                return this._CRCStateId;
            }
            set
            {
                this.OnCRCStateIdChanging(value);
                this._CRCStateId = value;
                this.OnCRCStateIdChanged();
                this.OnPropertyChanged("CRCStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CRCStateId;
        partial void OnCRCStateIdChanging(string value);
        partial void OnCRCStateIdChanged();
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
