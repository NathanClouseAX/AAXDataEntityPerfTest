﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:24:13 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for WithholdingGroupSingle in the schema.
    /// </summary>
    public partial class WithholdingGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdingGroup>
    {
        /// <summary>
        /// Initialize a new WithholdingGroupSingle object.
        /// </summary>
        public WithholdingGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WithholdingGroupSingle object.
        /// </summary>
        public WithholdingGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WithholdingGroupSingle object.
        /// </summary>
        public WithholdingGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdingGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WithholdingGroupData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WithholdingGroupData> WithholdingGroupData
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WithholdingGroupData == null))
                {
                    this._WithholdingGroupData = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WithholdingGroupData>(GetPath("WithholdingGroupData"));
                }
                return this._WithholdingGroupData;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WithholdingGroupData> _WithholdingGroupData;
    }
    /// <summary>
    /// There are no comments for WithholdingGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// WithholdingTaxGroupCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WithholdingTaxGroupCode")]
    [global::Microsoft.OData.Client.EntitySet("WithholdingGroups")]
    public partial class WithholdingGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WithholdingGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="withholdingTaxGroupCode">Initial value of WithholdingTaxGroupCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WithholdingGroup CreateWithholdingGroup(string dataAreaId, string withholdingTaxGroupCode)
        {
            WithholdingGroup withholdingGroup = new WithholdingGroup();
            withholdingGroup.dataAreaId = dataAreaId;
            withholdingGroup.WithholdingTaxGroupCode = withholdingTaxGroupCode;
            return withholdingGroup;
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
        /// There are no comments for Property WithholdingTaxGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WithholdingTaxGroupCode
        {
            get
            {
                return this._WithholdingTaxGroupCode;
            }
            set
            {
                this.OnWithholdingTaxGroupCodeChanging(value);
                this._WithholdingTaxGroupCode = value;
                this.OnWithholdingTaxGroupCodeChanged();
                this.OnPropertyChanged("WithholdingTaxGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WithholdingTaxGroupCode;
        partial void OnWithholdingTaxGroupCodeChanging(string value);
        partial void OnWithholdingTaxGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property ExcludeCharges in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ExcludeCharges
        {
            get
            {
                return this._ExcludeCharges;
            }
            set
            {
                this.OnExcludeChargesChanging(value);
                this._ExcludeCharges = value;
                this.OnExcludeChargesChanged();
                this.OnPropertyChanged("ExcludeCharges");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ExcludeCharges;
        partial void OnExcludeChargesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnExcludeChargesChanged();
        /// <summary>
        /// There are no comments for Property TaxType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdCodeType_IN> TaxType
        {
            get
            {
                return this._TaxType;
            }
            set
            {
                this.OnTaxTypeChanging(value);
                this._TaxType = value;
                this.OnTaxTypeChanged();
                this.OnPropertyChanged("TaxType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdCodeType_IN> _TaxType;
        partial void OnTaxTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdCodeType_IN> value);
        partial void OnTaxTypeChanged();
        /// <summary>
        /// There are no comments for Property ApplicableTaxRates in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdTaxApplicability_IN> ApplicableTaxRates
        {
            get
            {
                return this._ApplicableTaxRates;
            }
            set
            {
                this.OnApplicableTaxRatesChanging(value);
                this._ApplicableTaxRates = value;
                this.OnApplicableTaxRatesChanged();
                this.OnPropertyChanged("ApplicableTaxRates");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdTaxApplicability_IN> _ApplicableTaxRates;
        partial void OnApplicableTaxRatesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdTaxApplicability_IN> value);
        partial void OnApplicableTaxRatesChanged();
        /// <summary>
        /// There are no comments for Property Transporter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Transporter
        {
            get
            {
                return this._Transporter;
            }
            set
            {
                this.OnTransporterChanging(value);
                this._Transporter = value;
                this.OnTransporterChanged();
                this.OnPropertyChanged("Transporter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Transporter;
        partial void OnTransporterChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnTransporterChanged();
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
        /// There are no comments for Property WithholdingGroupData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingGroupData> WithholdingGroupData
        {
            get
            {
                return this._WithholdingGroupData;
            }
            set
            {
                this.OnWithholdingGroupDataChanging(value);
                this._WithholdingGroupData = value;
                this.OnWithholdingGroupDataChanged();
                this.OnPropertyChanged("WithholdingGroupData");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingGroupData> _WithholdingGroupData = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingGroupData>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWithholdingGroupDataChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingGroupData> value);
        partial void OnWithholdingGroupDataChanged();
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