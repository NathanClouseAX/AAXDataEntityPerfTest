﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/3/2021 8:21:45 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for InventoryCountingReasonCodeSingle in the schema.
        /// </summary>
    public partial class InventoryCountingReasonCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<InventoryCountingReasonCode>
    {
        /// <summary>
        /// Initialize a new InventoryCountingReasonCodeSingle object.
        /// </summary>
        public InventoryCountingReasonCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InventoryCountingReasonCodeSingle object.
        /// </summary>
        public InventoryCountingReasonCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InventoryCountingReasonCodeSingle object.
        /// </summary>
        public InventoryCountingReasonCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<InventoryCountingReasonCode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for InventoryCountingJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> InventoryCountingJournalLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._InventoryCountingJournalLine == null))
                {
                    this._InventoryCountingJournalLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine>(GetPath("InventoryCountingJournalLine"));
                }
                return this._InventoryCountingJournalLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> _InventoryCountingJournalLine;
    }
        /// <summary>
        /// There are no comments for InventoryCountingReasonCode in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ReasonCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ReasonCode")]
    [global::Microsoft.OData.Client.EntitySet("InventoryCountingReasonCodes")]
    public partial class InventoryCountingReasonCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new InventoryCountingReasonCode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="reasonCode">Initial value of ReasonCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static InventoryCountingReasonCode CreateInventoryCountingReasonCode(string dataAreaId, string reasonCode)
        {
            InventoryCountingReasonCode inventoryCountingReasonCode = new InventoryCountingReasonCode();
            inventoryCountingReasonCode.dataAreaId = dataAreaId;
            inventoryCountingReasonCode.ReasonCode = reasonCode;
            return inventoryCountingReasonCode;
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
        /// There are no comments for Property ReasonCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReasonCode
        {
            get
            {
                return this._ReasonCode;
            }
            set
            {
                this.OnReasonCodeChanging(value);
                this._ReasonCode = value;
                this.OnReasonCodeChanged();
                this.OnPropertyChanged("ReasonCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReasonCode;
        partial void OnReasonCodeChanging(string value);
        partial void OnReasonCodeChanged();
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
        /// There are no comments for Property InventoryCountingJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> InventoryCountingJournalLine
        {
            get
            {
                return this._InventoryCountingJournalLine;
            }
            set
            {
                this.OnInventoryCountingJournalLineChanging(value);
                this._InventoryCountingJournalLine = value;
                this.OnInventoryCountingJournalLineChanged();
                this.OnPropertyChanged("InventoryCountingJournalLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> _InventoryCountingJournalLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnInventoryCountingJournalLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> value);
        partial void OnInventoryCountingJournalLineChanged();
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
