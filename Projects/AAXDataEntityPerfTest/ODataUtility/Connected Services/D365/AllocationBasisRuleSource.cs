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
        /// There are no comments for AllocationBasisRuleSourceSingle in the schema.
        /// </summary>
    public partial class AllocationBasisRuleSourceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AllocationBasisRuleSource>
    {
        /// <summary>
        /// Initialize a new AllocationBasisRuleSourceSingle object.
        /// </summary>
        public AllocationBasisRuleSourceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AllocationBasisRuleSourceSingle object.
        /// </summary>
        public AllocationBasisRuleSourceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AllocationBasisRuleSourceSingle object.
        /// </summary>
        public AllocationBasisRuleSourceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AllocationBasisRuleSource> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AllocationBasisRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AllocationBasisRuleSingle AllocationBasisRule
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AllocationBasisRule == null))
                {
                    this._AllocationBasisRule = new global::Microsoft.Dynamics.DataEntities.AllocationBasisRuleSingle(this.Context, GetPath("AllocationBasisRule"));
                }
                return this._AllocationBasisRule;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AllocationBasisRuleSingle _AllocationBasisRule;
    }
        /// <summary>
        /// There are no comments for AllocationBasisRuleSource in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// BasisId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "BasisId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("AllocationBasisRuleSources")]
    public partial class AllocationBasisRuleSource : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AllocationBasisRuleSource object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="basisId">Initial value of BasisId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="allocationBasisRule">Initial value of AllocationBasisRule.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AllocationBasisRuleSource CreateAllocationBasisRuleSource(string dataAreaId, string basisId, decimal lineNumber, global::Microsoft.Dynamics.DataEntities.AllocationBasisRule allocationBasisRule)
        {
            AllocationBasisRuleSource allocationBasisRuleSource = new AllocationBasisRuleSource();
            allocationBasisRuleSource.dataAreaId = dataAreaId;
            allocationBasisRuleSource.BasisId = basisId;
            allocationBasisRuleSource.LineNumber = lineNumber;
            if ((allocationBasisRule == null))
            {
                throw new global::System.ArgumentNullException("allocationBasisRule");
            }
            allocationBasisRuleSource.AllocationBasisRule = allocationBasisRule;
            return allocationBasisRuleSource;
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
        /// There are no comments for Property BasisId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BasisId
        {
            get
            {
                return this._BasisId;
            }
            set
            {
                this.OnBasisIdChanging(value);
                this._BasisId = value;
                this.OnBasisIdChanged();
                this.OnPropertyChanged("BasisId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BasisId;
        partial void OnBasisIdChanging(string value);
        partial void OnBasisIdChanged();
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
        /// There are no comments for Property BasisCriteria in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BasisCriteria
        {
            get
            {
                return this._BasisCriteria;
            }
            set
            {
                this.OnBasisCriteriaChanging(value);
                this._BasisCriteria = value;
                this.OnBasisCriteriaChanged();
                this.OnPropertyChanged("BasisCriteria");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BasisCriteria;
        partial void OnBasisCriteriaChanging(string value);
        partial void OnBasisCriteriaChanged();
        /// <summary>
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property FieldSetting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationAccountDimension> FieldSetting
        {
            get
            {
                return this._FieldSetting;
            }
            set
            {
                this.OnFieldSettingChanging(value);
                this._FieldSetting = value;
                this.OnFieldSettingChanged();
                this.OnPropertyChanged("FieldSetting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationAccountDimension> _FieldSetting;
        partial void OnFieldSettingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationAccountDimension> value);
        partial void OnFieldSettingChanged();
        /// <summary>
        /// There are no comments for Property BasisDimensionAttributeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BasisDimensionAttributeName
        {
            get
            {
                return this._BasisDimensionAttributeName;
            }
            set
            {
                this.OnBasisDimensionAttributeNameChanging(value);
                this._BasisDimensionAttributeName = value;
                this.OnBasisDimensionAttributeNameChanged();
                this.OnPropertyChanged("BasisDimensionAttributeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BasisDimensionAttributeName;
        partial void OnBasisDimensionAttributeNameChanging(string value);
        partial void OnBasisDimensionAttributeNameChanged();
        /// <summary>
        /// There are no comments for Property AllocationBasisRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AllocationBasisRule AllocationBasisRule
        {
            get
            {
                return this._AllocationBasisRule;
            }
            set
            {
                this.OnAllocationBasisRuleChanging(value);
                this._AllocationBasisRule = value;
                this.OnAllocationBasisRuleChanged();
                this.OnPropertyChanged("AllocationBasisRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AllocationBasisRule _AllocationBasisRule;
        partial void OnAllocationBasisRuleChanging(global::Microsoft.Dynamics.DataEntities.AllocationBasisRule value);
        partial void OnAllocationBasisRuleChanged();
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
