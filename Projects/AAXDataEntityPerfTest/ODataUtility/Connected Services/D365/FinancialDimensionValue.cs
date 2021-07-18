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
        /// There are no comments for FinancialDimensionValueSingle in the schema.
        /// </summary>
    public partial class FinancialDimensionValueSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FinancialDimensionValue>
    {
        /// <summary>
        /// Initialize a new FinancialDimensionValueSingle object.
        /// </summary>
        public FinancialDimensionValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FinancialDimensionValueSingle object.
        /// </summary>
        public FinancialDimensionValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FinancialDimensionValueSingle object.
        /// </summary>
        public FinancialDimensionValueSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FinancialDimensionValue> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FinancialDimensionValueEntity_RelatedRole_LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OfficeAddinLegalEntitySingle FinancialDimensionValueEntity_RelatedRole_LegalEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FinancialDimensionValueEntity_RelatedRole_LegalEntity == null))
                {
                    this._FinancialDimensionValueEntity_RelatedRole_LegalEntity = new global::Microsoft.Dynamics.DataEntities.OfficeAddinLegalEntitySingle(this.Context, GetPath("FinancialDimensionValueEntity_RelatedRole_LegalEntity"));
                }
                return this._FinancialDimensionValueEntity_RelatedRole_LegalEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OfficeAddinLegalEntitySingle _FinancialDimensionValueEntity_RelatedRole_LegalEntity;
        /// <summary>
        /// There are no comments for FinancialDimensionValueEntity_RelatedRole_FinancialDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionAttributeSingle FinancialDimensionValueEntity_RelatedRole_FinancialDimension
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FinancialDimensionValueEntity_RelatedRole_FinancialDimension == null))
                {
                    this._FinancialDimensionValueEntity_RelatedRole_FinancialDimension = new global::Microsoft.Dynamics.DataEntities.DimensionAttributeSingle(this.Context, GetPath("FinancialDimensionValueEntity_RelatedRole_FinancialDimension"));
                }
                return this._FinancialDimensionValueEntity_RelatedRole_FinancialDimension;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionAttributeSingle _FinancialDimensionValueEntity_RelatedRole_FinancialDimension;
    }
        /// <summary>
        /// There are no comments for FinancialDimensionValue in the schema.
        /// </summary>
    /// <KeyProperties>
    /// FinancialDimension
    /// LegalEntityId
    /// DimensionValue
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("FinancialDimension", "LegalEntityId", "DimensionValue")]
    [global::Microsoft.OData.Client.EntitySet("FinancialDimensionValues")]
    public partial class FinancialDimensionValue : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FinancialDimensionValue object.
        /// </summary>
        /// <param name="financialDimension">Initial value of FinancialDimension.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="dimensionValue">Initial value of DimensionValue.</param>
        /// <param name="activeFrom">Initial value of ActiveFrom.</param>
        /// <param name="activeTo">Initial value of ActiveTo.</param>
        /// <param name="financialDimensionValueEntity_RelatedRole_FinancialDimension">Initial value of FinancialDimensionValueEntity_RelatedRole_FinancialDimension.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FinancialDimensionValue CreateFinancialDimensionValue(string financialDimension, 
                    string legalEntityId, 
                    string dimensionValue, 
                    global::System.DateTimeOffset activeFrom, 
                    global::System.DateTimeOffset activeTo, 
                    global::Microsoft.Dynamics.DataEntities.DimensionAttribute financialDimensionValueEntity_RelatedRole_FinancialDimension)
        {
            FinancialDimensionValue financialDimensionValue = new FinancialDimensionValue();
            financialDimensionValue.FinancialDimension = financialDimension;
            financialDimensionValue.LegalEntityId = legalEntityId;
            financialDimensionValue.DimensionValue = dimensionValue;
            financialDimensionValue.ActiveFrom = activeFrom;
            financialDimensionValue.ActiveTo = activeTo;
            if ((financialDimensionValueEntity_RelatedRole_FinancialDimension == null))
            {
                throw new global::System.ArgumentNullException("financialDimensionValueEntity_RelatedRole_FinancialDimension");
            }
            financialDimensionValue.FinancialDimensionValueEntity_RelatedRole_FinancialDimension = financialDimensionValueEntity_RelatedRole_FinancialDimension;
            return financialDimensionValue;
        }
        /// <summary>
        /// There are no comments for Property FinancialDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FinancialDimension
        {
            get
            {
                return this._FinancialDimension;
            }
            set
            {
                this.OnFinancialDimensionChanging(value);
                this._FinancialDimension = value;
                this.OnFinancialDimensionChanged();
                this.OnPropertyChanged("FinancialDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FinancialDimension;
        partial void OnFinancialDimensionChanging(string value);
        partial void OnFinancialDimensionChanged();
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
        /// There are no comments for Property DimensionValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionValue
        {
            get
            {
                return this._DimensionValue;
            }
            set
            {
                this.OnDimensionValueChanging(value);
                this._DimensionValue = value;
                this.OnDimensionValueChanged();
                this.OnPropertyChanged("DimensionValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionValue;
        partial void OnDimensionValueChanging(string value);
        partial void OnDimensionValueChanged();
        /// <summary>
        /// There are no comments for Property GroupDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupDimension
        {
            get
            {
                return this._GroupDimension;
            }
            set
            {
                this.OnGroupDimensionChanging(value);
                this._GroupDimension = value;
                this.OnGroupDimensionChanged();
                this.OnPropertyChanged("GroupDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupDimension;
        partial void OnGroupDimensionChanging(string value);
        partial void OnGroupDimensionChanged();
        /// <summary>
        /// There are no comments for Property IsSuspended in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsSuspended
        {
            get
            {
                return this._IsSuspended;
            }
            set
            {
                this.OnIsSuspendedChanging(value);
                this._IsSuspended = value;
                this.OnIsSuspendedChanged();
                this.OnPropertyChanged("IsSuspended");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsSuspended;
        partial void OnIsSuspendedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsSuspendedChanged();
        /// <summary>
        /// There are no comments for Property IsBlockedForManualEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsBlockedForManualEntry
        {
            get
            {
                return this._IsBlockedForManualEntry;
            }
            set
            {
                this.OnIsBlockedForManualEntryChanging(value);
                this._IsBlockedForManualEntry = value;
                this.OnIsBlockedForManualEntryChanged();
                this.OnPropertyChanged("IsBlockedForManualEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsBlockedForManualEntry;
        partial void OnIsBlockedForManualEntryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsBlockedForManualEntryChanged();
        /// <summary>
        /// There are no comments for Property IsTotal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsTotal
        {
            get
            {
                return this._IsTotal;
            }
            set
            {
                this.OnIsTotalChanging(value);
                this._IsTotal = value;
                this.OnIsTotalChanged();
                this.OnPropertyChanged("IsTotal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsTotal;
        partial void OnIsTotalChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsTotalChanged();
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
        /// There are no comments for Property ActiveFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ActiveFrom
        {
            get
            {
                return this._ActiveFrom;
            }
            set
            {
                this.OnActiveFromChanging(value);
                this._ActiveFrom = value;
                this.OnActiveFromChanged();
                this.OnPropertyChanged("ActiveFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ActiveFrom;
        partial void OnActiveFromChanging(global::System.DateTimeOffset value);
        partial void OnActiveFromChanged();
        /// <summary>
        /// There are no comments for Property ActiveTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ActiveTo
        {
            get
            {
                return this._ActiveTo;
            }
            set
            {
                this.OnActiveToChanging(value);
                this._ActiveTo = value;
                this.OnActiveToChanged();
                this.OnPropertyChanged("ActiveTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ActiveTo;
        partial void OnActiveToChanging(global::System.DateTimeOffset value);
        partial void OnActiveToChanged();
        /// <summary>
        /// There are no comments for Property Owner in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Owner
        {
            get
            {
                return this._Owner;
            }
            set
            {
                this.OnOwnerChanging(value);
                this._Owner = value;
                this.OnOwnerChanged();
                this.OnPropertyChanged("Owner");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Owner;
        partial void OnOwnerChanging(string value);
        partial void OnOwnerChanged();
        /// <summary>
        /// There are no comments for Property IsBalancing_PSN in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsBalancing_PSN
        {
            get
            {
                return this._IsBalancing_PSN;
            }
            set
            {
                this.OnIsBalancing_PSNChanging(value);
                this._IsBalancing_PSN = value;
                this.OnIsBalancing_PSNChanged();
                this.OnPropertyChanged("IsBalancing_PSN");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsBalancing_PSN;
        partial void OnIsBalancing_PSNChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsBalancing_PSNChanged();
        /// <summary>
        /// There are no comments for Property FinancialDimensionValueEntity_RelatedRole_LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OfficeAddinLegalEntity FinancialDimensionValueEntity_RelatedRole_LegalEntity
        {
            get
            {
                return this._FinancialDimensionValueEntity_RelatedRole_LegalEntity;
            }
            set
            {
                this.OnFinancialDimensionValueEntity_RelatedRole_LegalEntityChanging(value);
                this._FinancialDimensionValueEntity_RelatedRole_LegalEntity = value;
                this.OnFinancialDimensionValueEntity_RelatedRole_LegalEntityChanged();
                this.OnPropertyChanged("FinancialDimensionValueEntity_RelatedRole_LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OfficeAddinLegalEntity _FinancialDimensionValueEntity_RelatedRole_LegalEntity;
        partial void OnFinancialDimensionValueEntity_RelatedRole_LegalEntityChanging(global::Microsoft.Dynamics.DataEntities.OfficeAddinLegalEntity value);
        partial void OnFinancialDimensionValueEntity_RelatedRole_LegalEntityChanged();
        /// <summary>
        /// There are no comments for Property FinancialDimensionValueEntity_RelatedRole_FinancialDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionAttribute FinancialDimensionValueEntity_RelatedRole_FinancialDimension
        {
            get
            {
                return this._FinancialDimensionValueEntity_RelatedRole_FinancialDimension;
            }
            set
            {
                this.OnFinancialDimensionValueEntity_RelatedRole_FinancialDimensionChanging(value);
                this._FinancialDimensionValueEntity_RelatedRole_FinancialDimension = value;
                this.OnFinancialDimensionValueEntity_RelatedRole_FinancialDimensionChanged();
                this.OnPropertyChanged("FinancialDimensionValueEntity_RelatedRole_FinancialDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionAttribute _FinancialDimensionValueEntity_RelatedRole_FinancialDimension;
        partial void OnFinancialDimensionValueEntity_RelatedRole_FinancialDimensionChanging(global::Microsoft.Dynamics.DataEntities.DimensionAttribute value);
        partial void OnFinancialDimensionValueEntity_RelatedRole_FinancialDimensionChanged();
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
