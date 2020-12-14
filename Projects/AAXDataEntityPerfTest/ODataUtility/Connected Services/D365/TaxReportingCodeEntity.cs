﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 12/8/2020 7:45:22 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for TaxReportingCodeEntitySingle in the schema.
        /// </summary>
    public partial class TaxReportingCodeEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TaxReportingCodeEntity>
    {
        /// <summary>
        /// Initialize a new TaxReportingCodeEntitySingle object.
        /// </summary>
        public TaxReportingCodeEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TaxReportingCodeEntitySingle object.
        /// </summary>
        public TaxReportingCodeEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TaxReportingCodeEntitySingle object.
        /// </summary>
        public TaxReportingCodeEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TaxReportingCodeEntity> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TaxCode> TaxCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TaxCode == null))
                {
                    this._TaxCode = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TaxCode>(GetPath("TaxCode"));
                }
                return this._TaxCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TaxCode> _TaxCode;
    }
        /// <summary>
        /// There are no comments for TaxReportingCodeEntity in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TaxReportingCode
    /// ReportLayout
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TaxReportingCode", "ReportLayout")]
    [global::Microsoft.OData.Client.EntitySet("TaxReportingCodeEntities")]
    public partial class TaxReportingCodeEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxReportingCodeEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="taxReportingCode">Initial value of TaxReportingCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TaxReportingCodeEntity CreateTaxReportingCodeEntity(string dataAreaId, int taxReportingCode)
        {
            TaxReportingCodeEntity taxReportingCodeEntity = new TaxReportingCodeEntity();
            taxReportingCodeEntity.dataAreaId = dataAreaId;
            taxReportingCodeEntity.TaxReportingCode = taxReportingCode;
            return taxReportingCodeEntity;
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
        /// There are no comments for Property TaxReportingCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int TaxReportingCode
        {
            get
            {
                return this._TaxReportingCode;
            }
            set
            {
                this.OnTaxReportingCodeChanging(value);
                this._TaxReportingCode = value;
                this.OnTaxReportingCodeChanged();
                this.OnPropertyChanged("TaxReportingCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _TaxReportingCode;
        partial void OnTaxReportingCodeChanging(int value);
        partial void OnTaxReportingCodeChanged();
        /// <summary>
        /// There are no comments for Property ReportLayout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxReportLayout> ReportLayout
        {
            get
            {
                return this._ReportLayout;
            }
            set
            {
                this.OnReportLayoutChanging(value);
                this._ReportLayout = value;
                this.OnReportLayoutChanged();
                this.OnPropertyChanged("ReportLayout");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxReportLayout> _ReportLayout;
        partial void OnReportLayoutChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxReportLayout> value);
        partial void OnReportLayoutChanged();
        /// <summary>
        /// There are no comments for Property ReportText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReportText
        {
            get
            {
                return this._ReportText;
            }
            set
            {
                this.OnReportTextChanging(value);
                this._ReportText = value;
                this.OnReportTextChanged();
                this.OnPropertyChanged("ReportText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReportText;
        partial void OnReportTextChanging(string value);
        partial void OnReportTextChanged();
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
        /// There are no comments for Property SalesTaxCorrections in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> SalesTaxCorrections
        {
            get
            {
                return this._SalesTaxCorrections;
            }
            set
            {
                this.OnSalesTaxCorrectionsChanging(value);
                this._SalesTaxCorrections = value;
                this.OnSalesTaxCorrectionsChanged();
                this.OnPropertyChanged("SalesTaxCorrections");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _SalesTaxCorrections;
        partial void OnSalesTaxCorrectionsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSalesTaxCorrectionsChanged();
        /// <summary>
        /// There are no comments for Property TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TaxCode> TaxCode
        {
            get
            {
                return this._TaxCode;
            }
            set
            {
                this.OnTaxCodeChanging(value);
                this._TaxCode = value;
                this.OnTaxCodeChanged();
                this.OnPropertyChanged("TaxCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TaxCode> _TaxCode = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TaxCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTaxCodeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TaxCode> value);
        partial void OnTaxCodeChanged();
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
