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
        /// There are no comments for AllocationForMainAccountSingle in the schema.
        /// </summary>
    public partial class AllocationForMainAccountSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AllocationForMainAccount>
    {
        /// <summary>
        /// Initialize a new AllocationForMainAccountSingle object.
        /// </summary>
        public AllocationForMainAccountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AllocationForMainAccountSingle object.
        /// </summary>
        public AllocationForMainAccountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AllocationForMainAccountSingle object.
        /// </summary>
        public AllocationForMainAccountSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AllocationForMainAccount> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
    }
        /// <summary>
        /// There are no comments for AllocationForMainAccount in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MainAccountId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MainAccountId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("AllocationForMainAccounts")]
    public partial class AllocationForMainAccount : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AllocationForMainAccount object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="mainAccountId">Initial value of MainAccountId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="allocationPercentage">Initial value of AllocationPercentage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AllocationForMainAccount CreateAllocationForMainAccount(string dataAreaId, string mainAccountId, decimal lineNumber, decimal allocationPercentage)
        {
            AllocationForMainAccount allocationForMainAccount = new AllocationForMainAccount();
            allocationForMainAccount.dataAreaId = dataAreaId;
            allocationForMainAccount.MainAccountId = mainAccountId;
            allocationForMainAccount.LineNumber = lineNumber;
            allocationForMainAccount.AllocationPercentage = allocationPercentage;
            return allocationForMainAccount;
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
        /// There are no comments for Property MainAccountId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccountId
        {
            get
            {
                return this._MainAccountId;
            }
            set
            {
                this.OnMainAccountIdChanging(value);
                this._MainAccountId = value;
                this.OnMainAccountIdChanged();
                this.OnPropertyChanged("MainAccountId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountId;
        partial void OnMainAccountIdChanging(string value);
        partial void OnMainAccountIdChanged();
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
        /// There are no comments for Property SourceSelectionCriteriaDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SourceSelectionCriteriaDisplayValue
        {
            get
            {
                return this._SourceSelectionCriteriaDisplayValue;
            }
            set
            {
                this.OnSourceSelectionCriteriaDisplayValueChanging(value);
                this._SourceSelectionCriteriaDisplayValue = value;
                this.OnSourceSelectionCriteriaDisplayValueChanged();
                this.OnPropertyChanged("SourceSelectionCriteriaDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceSelectionCriteriaDisplayValue;
        partial void OnSourceSelectionCriteriaDisplayValueChanging(string value);
        partial void OnSourceSelectionCriteriaDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DestinationKeepSourceDimensionsDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DestinationKeepSourceDimensionsDisplayValue
        {
            get
            {
                return this._DestinationKeepSourceDimensionsDisplayValue;
            }
            set
            {
                this.OnDestinationKeepSourceDimensionsDisplayValueChanging(value);
                this._DestinationKeepSourceDimensionsDisplayValue = value;
                this.OnDestinationKeepSourceDimensionsDisplayValueChanged();
                this.OnPropertyChanged("DestinationKeepSourceDimensionsDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DestinationKeepSourceDimensionsDisplayValue;
        partial void OnDestinationKeepSourceDimensionsDisplayValueChanging(string value);
        partial void OnDestinationKeepSourceDimensionsDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property SourceSelectionCriteriaDimensionsDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SourceSelectionCriteriaDimensionsDisplayValue
        {
            get
            {
                return this._SourceSelectionCriteriaDimensionsDisplayValue;
            }
            set
            {
                this.OnSourceSelectionCriteriaDimensionsDisplayValueChanging(value);
                this._SourceSelectionCriteriaDimensionsDisplayValue = value;
                this.OnSourceSelectionCriteriaDimensionsDisplayValueChanged();
                this.OnPropertyChanged("SourceSelectionCriteriaDimensionsDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceSelectionCriteriaDimensionsDisplayValue;
        partial void OnSourceSelectionCriteriaDimensionsDisplayValueChanging(string value);
        partial void OnSourceSelectionCriteriaDimensionsDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property AllocationPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AllocationPercentage
        {
            get
            {
                return this._AllocationPercentage;
            }
            set
            {
                this.OnAllocationPercentageChanging(value);
                this._AllocationPercentage = value;
                this.OnAllocationPercentageChanged();
                this.OnPropertyChanged("AllocationPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AllocationPercentage;
        partial void OnAllocationPercentageChanging(decimal value);
        partial void OnAllocationPercentageChanged();
        /// <summary>
        /// There are no comments for Property DestinationDimensionsDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DestinationDimensionsDisplayValue
        {
            get
            {
                return this._DestinationDimensionsDisplayValue;
            }
            set
            {
                this.OnDestinationDimensionsDisplayValueChanging(value);
                this._DestinationDimensionsDisplayValue = value;
                this.OnDestinationDimensionsDisplayValueChanged();
                this.OnPropertyChanged("DestinationDimensionsDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DestinationDimensionsDisplayValue;
        partial void OnDestinationDimensionsDisplayValueChanging(string value);
        partial void OnDestinationDimensionsDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DestinationAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DestinationAccountDisplayValue
        {
            get
            {
                return this._DestinationAccountDisplayValue;
            }
            set
            {
                this.OnDestinationAccountDisplayValueChanging(value);
                this._DestinationAccountDisplayValue = value;
                this.OnDestinationAccountDisplayValueChanged();
                this.OnPropertyChanged("DestinationAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DestinationAccountDisplayValue;
        partial void OnDestinationAccountDisplayValueChanging(string value);
        partial void OnDestinationAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
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
