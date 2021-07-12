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
        /// There are no comments for PartyEmployeeRelationshipSingle in the schema.
        /// </summary>
    public partial class PartyEmployeeRelationshipSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PartyEmployeeRelationship>
    {
        /// <summary>
        /// Initialize a new PartyEmployeeRelationshipSingle object.
        /// </summary>
        public PartyEmployeeRelationshipSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PartyEmployeeRelationshipSingle object.
        /// </summary>
        public PartyEmployeeRelationshipSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PartyEmployeeRelationshipSingle object.
        /// </summary>
        public PartyEmployeeRelationshipSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PartyEmployeeRelationship> query)
            : base(query) {}

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
        /// There are no comments for PartyEmployeeRelationship in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TrvHcmWorker_PersonnelNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TrvHcmWorker_PersonnelNumber")]
    [global::Microsoft.OData.Client.EntitySet("PartyEmployeeRelationships")]
    public partial class PartyEmployeeRelationship : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PartyEmployeeRelationship object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="trvHcmWorker_PersonnelNumber">Initial value of TrvHcmWorker_PersonnelNumber.</param>
        /// <param name="perDiem">Initial value of PerDiem.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PartyEmployeeRelationship CreatePartyEmployeeRelationship(string dataAreaId, string trvHcmWorker_PersonnelNumber, decimal perDiem)
        {
            PartyEmployeeRelationship partyEmployeeRelationship = new PartyEmployeeRelationship();
            partyEmployeeRelationship.dataAreaId = dataAreaId;
            partyEmployeeRelationship.TrvHcmWorker_PersonnelNumber = trvHcmWorker_PersonnelNumber;
            partyEmployeeRelationship.PerDiem = perDiem;
            return partyEmployeeRelationship;
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
        /// There are no comments for Property TrvHcmWorker_PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TrvHcmWorker_PersonnelNumber
        {
            get
            {
                return this._TrvHcmWorker_PersonnelNumber;
            }
            set
            {
                this.OnTrvHcmWorker_PersonnelNumberChanging(value);
                this._TrvHcmWorker_PersonnelNumber = value;
                this.OnTrvHcmWorker_PersonnelNumberChanged();
                this.OnPropertyChanged("TrvHcmWorker_PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TrvHcmWorker_PersonnelNumber;
        partial void OnTrvHcmWorker_PersonnelNumberChanging(string value);
        partial void OnTrvHcmWorker_PersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property AccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> AccountType
        {
            get
            {
                return this._AccountType;
            }
            set
            {
                this.OnAccountTypeChanging(value);
                this._AccountType = value;
                this.OnAccountTypeChanged();
                this.OnPropertyChanged("AccountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> _AccountType;
        partial void OnAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> value);
        partial void OnAccountTypeChanged();
        /// <summary>
        /// There are no comments for Property PerDiem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PerDiem
        {
            get
            {
                return this._PerDiem;
            }
            set
            {
                this.OnPerDiemChanging(value);
                this._PerDiem = value;
                this.OnPerDiemChanged();
                this.OnPropertyChanged("PerDiem");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PerDiem;
        partial void OnPerDiemChanging(decimal value);
        partial void OnPerDiemChanged();
        /// <summary>
        /// There are no comments for Property AccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountDisplayValue
        {
            get
            {
                return this._AccountDisplayValue;
            }
            set
            {
                this.OnAccountDisplayValueChanging(value);
                this._AccountDisplayValue = value;
                this.OnAccountDisplayValueChanged();
                this.OnPropertyChanged("AccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountDisplayValue;
        partial void OnAccountDisplayValueChanging(string value);
        partial void OnAccountDisplayValueChanged();
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
