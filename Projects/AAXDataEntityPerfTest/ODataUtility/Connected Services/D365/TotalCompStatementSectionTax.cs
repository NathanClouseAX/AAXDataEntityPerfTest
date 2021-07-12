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
        /// There are no comments for TotalCompStatementSectionTaxSingle in the schema.
        /// </summary>
    public partial class TotalCompStatementSectionTaxSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TotalCompStatementSectionTax>
    {
        /// <summary>
        /// Initialize a new TotalCompStatementSectionTaxSingle object.
        /// </summary>
        public TotalCompStatementSectionTaxSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TotalCompStatementSectionTaxSingle object.
        /// </summary>
        public TotalCompStatementSectionTaxSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TotalCompStatementSectionTaxSingle object.
        /// </summary>
        public TotalCompStatementSectionTaxSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TotalCompStatementSectionTax> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for HcmTotalCompStatementSectionHeaderEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionHeaderSingle HcmTotalCompStatementSectionHeaderEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._HcmTotalCompStatementSectionHeaderEntity == null))
                {
                    this._HcmTotalCompStatementSectionHeaderEntity = new global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionHeaderSingle(this.Context, GetPath("HcmTotalCompStatementSectionHeaderEntity"));
                }
                return this._HcmTotalCompStatementSectionHeaderEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionHeaderSingle _HcmTotalCompStatementSectionHeaderEntity;
    }
        /// <summary>
        /// There are no comments for TotalCompStatementSectionTax in the schema.
        /// </summary>
    /// <KeyProperties>
    /// StatementSectionId
    /// CountryRegionId
    /// TaxGroupId
    /// TaxCodeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("StatementSectionId", "CountryRegionId", "TaxGroupId", "TaxCodeId")]
    [global::Microsoft.OData.Client.EntitySet("TotalCompStatementSectionTaxes")]
    public partial class TotalCompStatementSectionTax : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TotalCompStatementSectionTax object.
        /// </summary>
        /// <param name="statementSectionId">Initial value of StatementSectionId.</param>
        /// <param name="countryRegionId">Initial value of CountryRegionId.</param>
        /// <param name="taxGroupId">Initial value of TaxGroupId.</param>
        /// <param name="taxCodeId">Initial value of TaxCodeId.</param>
        /// <param name="hcmTotalCompStatementSectionHeaderEntity">Initial value of HcmTotalCompStatementSectionHeaderEntity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TotalCompStatementSectionTax CreateTotalCompStatementSectionTax(string statementSectionId, string countryRegionId, string taxGroupId, string taxCodeId, global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionHeader hcmTotalCompStatementSectionHeaderEntity)
        {
            TotalCompStatementSectionTax totalCompStatementSectionTax = new TotalCompStatementSectionTax();
            totalCompStatementSectionTax.StatementSectionId = statementSectionId;
            totalCompStatementSectionTax.CountryRegionId = countryRegionId;
            totalCompStatementSectionTax.TaxGroupId = taxGroupId;
            totalCompStatementSectionTax.TaxCodeId = taxCodeId;
            if ((hcmTotalCompStatementSectionHeaderEntity == null))
            {
                throw new global::System.ArgumentNullException("hcmTotalCompStatementSectionHeaderEntity");
            }
            totalCompStatementSectionTax.HcmTotalCompStatementSectionHeaderEntity = hcmTotalCompStatementSectionHeaderEntity;
            return totalCompStatementSectionTax;
        }
        /// <summary>
        /// There are no comments for Property StatementSectionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string StatementSectionId
        {
            get
            {
                return this._StatementSectionId;
            }
            set
            {
                this.OnStatementSectionIdChanging(value);
                this._StatementSectionId = value;
                this.OnStatementSectionIdChanged();
                this.OnPropertyChanged("StatementSectionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StatementSectionId;
        partial void OnStatementSectionIdChanging(string value);
        partial void OnStatementSectionIdChanged();
        /// <summary>
        /// There are no comments for Property CountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CountryRegionId
        {
            get
            {
                return this._CountryRegionId;
            }
            set
            {
                this.OnCountryRegionIdChanging(value);
                this._CountryRegionId = value;
                this.OnCountryRegionIdChanged();
                this.OnPropertyChanged("CountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionId;
        partial void OnCountryRegionIdChanging(string value);
        partial void OnCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property TaxGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxGroupId
        {
            get
            {
                return this._TaxGroupId;
            }
            set
            {
                this.OnTaxGroupIdChanging(value);
                this._TaxGroupId = value;
                this.OnTaxGroupIdChanged();
                this.OnPropertyChanged("TaxGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxGroupId;
        partial void OnTaxGroupIdChanging(string value);
        partial void OnTaxGroupIdChanged();
        /// <summary>
        /// There are no comments for Property TaxCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxCodeId
        {
            get
            {
                return this._TaxCodeId;
            }
            set
            {
                this.OnTaxCodeIdChanging(value);
                this._TaxCodeId = value;
                this.OnTaxCodeIdChanged();
                this.OnPropertyChanged("TaxCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxCodeId;
        partial void OnTaxCodeIdChanging(string value);
        partial void OnTaxCodeIdChanged();
        /// <summary>
        /// There are no comments for Property TaxCodeGroupType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxCodeTaxGroupType> TaxCodeGroupType
        {
            get
            {
                return this._TaxCodeGroupType;
            }
            set
            {
                this.OnTaxCodeGroupTypeChanging(value);
                this._TaxCodeGroupType = value;
                this.OnTaxCodeGroupTypeChanged();
                this.OnPropertyChanged("TaxCodeGroupType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxCodeTaxGroupType> _TaxCodeGroupType;
        partial void OnTaxCodeGroupTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxCodeTaxGroupType> value);
        partial void OnTaxCodeGroupTypeChanged();
        /// <summary>
        /// There are no comments for Property HcmTotalCompStatementSectionHeaderEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionHeader HcmTotalCompStatementSectionHeaderEntity
        {
            get
            {
                return this._HcmTotalCompStatementSectionHeaderEntity;
            }
            set
            {
                this.OnHcmTotalCompStatementSectionHeaderEntityChanging(value);
                this._HcmTotalCompStatementSectionHeaderEntity = value;
                this.OnHcmTotalCompStatementSectionHeaderEntityChanged();
                this.OnPropertyChanged("HcmTotalCompStatementSectionHeaderEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionHeader _HcmTotalCompStatementSectionHeaderEntity;
        partial void OnHcmTotalCompStatementSectionHeaderEntityChanging(global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionHeader value);
        partial void OnHcmTotalCompStatementSectionHeaderEntityChanged();
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
