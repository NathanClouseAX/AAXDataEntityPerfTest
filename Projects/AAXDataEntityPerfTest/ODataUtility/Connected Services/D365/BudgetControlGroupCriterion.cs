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
        /// There are no comments for BudgetControlGroupCriterionSingle in the schema.
        /// </summary>
    public partial class BudgetControlGroupCriterionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlGroupCriterion>
    {
        /// <summary>
        /// Initialize a new BudgetControlGroupCriterionSingle object.
        /// </summary>
        public BudgetControlGroupCriterionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetControlGroupCriterionSingle object.
        /// </summary>
        public BudgetControlGroupCriterionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetControlGroupCriterionSingle object.
        /// </summary>
        public BudgetControlGroupCriterionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlGroupCriterion> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetControlGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlGroupSingle BudgetControlGroups
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlGroups == null))
                {
                    this._BudgetControlGroups = new global::Microsoft.Dynamics.DataEntities.BudgetControlGroupSingle(this.Context, GetPath("BudgetControlGroups"));
                }
                return this._BudgetControlGroups;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlGroupSingle _BudgetControlGroups;
    }
        /// <summary>
        /// There are no comments for BudgetControlGroupCriterion in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LegalEntityId
    /// Status
    /// MemberName
    /// DimensionAttributeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LegalEntityId", "Status", "MemberName", "DimensionAttributeId")]
    [global::Microsoft.OData.Client.EntitySet("BudgetControlGroupCriteria")]
    public partial class BudgetControlGroupCriterion : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetControlGroupCriterion object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="memberName">Initial value of MemberName.</param>
        /// <param name="dimensionAttributeId">Initial value of DimensionAttributeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetControlGroupCriterion CreateBudgetControlGroupCriterion(string dataAreaId, string legalEntityId, string memberName, string dimensionAttributeId)
        {
            BudgetControlGroupCriterion budgetControlGroupCriterion = new BudgetControlGroupCriterion();
            budgetControlGroupCriterion.dataAreaId = dataAreaId;
            budgetControlGroupCriterion.LegalEntityId = legalEntityId;
            budgetControlGroupCriterion.MemberName = memberName;
            budgetControlGroupCriterion.DimensionAttributeId = dimensionAttributeId;
            return budgetControlGroupCriterion;
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
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property MemberName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MemberName
        {
            get
            {
                return this._MemberName;
            }
            set
            {
                this.OnMemberNameChanging(value);
                this._MemberName = value;
                this.OnMemberNameChanged();
                this.OnPropertyChanged("MemberName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MemberName;
        partial void OnMemberNameChanging(string value);
        partial void OnMemberNameChanged();
        /// <summary>
        /// There are no comments for Property DimensionAttributeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionAttributeId
        {
            get
            {
                return this._DimensionAttributeId;
            }
            set
            {
                this.OnDimensionAttributeIdChanging(value);
                this._DimensionAttributeId = value;
                this.OnDimensionAttributeIdChanged();
                this.OnPropertyChanged("DimensionAttributeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionAttributeId;
        partial void OnDimensionAttributeIdChanging(string value);
        partial void OnDimensionAttributeIdChanged();
        /// <summary>
        /// There are no comments for Property Criterion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Criterion
        {
            get
            {
                return this._Criterion;
            }
            set
            {
                this.OnCriterionChanging(value);
                this._Criterion = value;
                this.OnCriterionChanged();
                this.OnPropertyChanged("Criterion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Criterion;
        partial void OnCriterionChanging(string value);
        partial void OnCriterionChanged();
        /// <summary>
        /// There are no comments for Property InUseBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InUseBy
        {
            get
            {
                return this._InUseBy;
            }
            set
            {
                this.OnInUseByChanging(value);
                this._InUseBy = value;
                this.OnInUseByChanged();
                this.OnPropertyChanged("InUseBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InUseBy;
        partial void OnInUseByChanging(string value);
        partial void OnInUseByChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlGroup BudgetControlGroups
        {
            get
            {
                return this._BudgetControlGroups;
            }
            set
            {
                this.OnBudgetControlGroupsChanging(value);
                this._BudgetControlGroups = value;
                this.OnBudgetControlGroupsChanged();
                this.OnPropertyChanged("BudgetControlGroups");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlGroup _BudgetControlGroups;
        partial void OnBudgetControlGroupsChanging(global::Microsoft.Dynamics.DataEntities.BudgetControlGroup value);
        partial void OnBudgetControlGroupsChanged();
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
