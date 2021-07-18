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
        /// There are no comments for TaxGroupDataSingle in the schema.
        /// </summary>
    public partial class TaxGroupDataSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TaxGroupData>
    {
        /// <summary>
        /// Initialize a new TaxGroupDataSingle object.
        /// </summary>
        public TaxGroupDataSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TaxGroupDataSingle object.
        /// </summary>
        public TaxGroupDataSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TaxGroupDataSingle object.
        /// </summary>
        public TaxGroupDataSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TaxGroupData> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TaxExemptCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxExemptCodeSingle TaxExemptCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TaxExemptCode == null))
                {
                    this._TaxExemptCode = new global::Microsoft.Dynamics.DataEntities.TaxExemptCodeSingle(this.Context, GetPath("TaxExemptCode"));
                }
                return this._TaxExemptCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxExemptCodeSingle _TaxExemptCode;
        /// <summary>
        /// There are no comments for TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxCodeSingle TaxCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TaxCode == null))
                {
                    this._TaxCode = new global::Microsoft.Dynamics.DataEntities.TaxCodeSingle(this.Context, GetPath("TaxCode"));
                }
                return this._TaxCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxCodeSingle _TaxCode;
        /// <summary>
        /// There are no comments for TaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxGroupSingle TaxGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TaxGroup == null))
                {
                    this._TaxGroup = new global::Microsoft.Dynamics.DataEntities.TaxGroupSingle(this.Context, GetPath("TaxGroup"));
                }
                return this._TaxGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxGroupSingle _TaxGroup;
    }
        /// <summary>
        /// There are no comments for TaxGroupData in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TaxGroupId
    /// TaxCodeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TaxGroupId", "TaxCodeId")]
    [global::Microsoft.OData.Client.EntitySet("TaxGroupDatas")]
    public partial class TaxGroupData : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxGroupData object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="taxGroupId">Initial value of TaxGroupId.</param>
        /// <param name="taxCodeId">Initial value of TaxCodeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TaxGroupData CreateTaxGroupData(string dataAreaId, string taxGroupId, string taxCodeId)
        {
            TaxGroupData taxGroupData = new TaxGroupData();
            taxGroupData.dataAreaId = dataAreaId;
            taxGroupData.TaxGroupId = taxGroupId;
            taxGroupData.TaxCodeId = taxCodeId;
            return taxGroupData;
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
        /// There are no comments for Property UseTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseTax
        {
            get
            {
                return this._UseTax;
            }
            set
            {
                this.OnUseTaxChanging(value);
                this._UseTax = value;
                this.OnUseTaxChanged();
                this.OnPropertyChanged("UseTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseTax;
        partial void OnUseTaxChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseTaxChanged();
        /// <summary>
        /// There are no comments for Property TaxExemptCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxExemptCodeId
        {
            get
            {
                return this._TaxExemptCodeId;
            }
            set
            {
                this.OnTaxExemptCodeIdChanging(value);
                this._TaxExemptCodeId = value;
                this.OnTaxExemptCodeIdChanged();
                this.OnPropertyChanged("TaxExemptCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxExemptCodeId;
        partial void OnTaxExemptCodeIdChanging(string value);
        partial void OnTaxExemptCodeIdChanged();
        /// <summary>
        /// There are no comments for Property ReverseCharge in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ReverseCharge
        {
            get
            {
                return this._ReverseCharge;
            }
            set
            {
                this.OnReverseChargeChanging(value);
                this._ReverseCharge = value;
                this.OnReverseChargeChanged();
                this.OnPropertyChanged("ReverseCharge");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ReverseCharge;
        partial void OnReverseChargeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnReverseChargeChanged();
        /// <summary>
        /// There are no comments for Property BrazilianTaxationCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BrazilianTaxationCode
        {
            get
            {
                return this._BrazilianTaxationCode;
            }
            set
            {
                this.OnBrazilianTaxationCodeChanging(value);
                this._BrazilianTaxationCode = value;
                this.OnBrazilianTaxationCodeChanged();
                this.OnPropertyChanged("BrazilianTaxationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BrazilianTaxationCode;
        partial void OnBrazilianTaxationCodeChanging(string value);
        partial void OnBrazilianTaxationCodeChanged();
        /// <summary>
        /// There are no comments for Property ExemptTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ExemptTax
        {
            get
            {
                return this._ExemptTax;
            }
            set
            {
                this.OnExemptTaxChanging(value);
                this._ExemptTax = value;
                this.OnExemptTaxChanged();
                this.OnPropertyChanged("ExemptTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ExemptTax;
        partial void OnExemptTaxChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnExemptTaxChanged();
        /// <summary>
        /// There are no comments for Property TaxExemptCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxExemptCode TaxExemptCode
        {
            get
            {
                return this._TaxExemptCode;
            }
            set
            {
                this.OnTaxExemptCodeChanging(value);
                this._TaxExemptCode = value;
                this.OnTaxExemptCodeChanged();
                this.OnPropertyChanged("TaxExemptCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxExemptCode _TaxExemptCode;
        partial void OnTaxExemptCodeChanging(global::Microsoft.Dynamics.DataEntities.TaxExemptCode value);
        partial void OnTaxExemptCodeChanged();
        /// <summary>
        /// There are no comments for Property TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxCode TaxCode
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
        private global::Microsoft.Dynamics.DataEntities.TaxCode _TaxCode;
        partial void OnTaxCodeChanging(global::Microsoft.Dynamics.DataEntities.TaxCode value);
        partial void OnTaxCodeChanged();
        /// <summary>
        /// There are no comments for Property TaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxGroup TaxGroup
        {
            get
            {
                return this._TaxGroup;
            }
            set
            {
                this.OnTaxGroupChanging(value);
                this._TaxGroup = value;
                this.OnTaxGroupChanged();
                this.OnPropertyChanged("TaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxGroup _TaxGroup;
        partial void OnTaxGroupChanging(global::Microsoft.Dynamics.DataEntities.TaxGroup value);
        partial void OnTaxGroupChanged();
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
