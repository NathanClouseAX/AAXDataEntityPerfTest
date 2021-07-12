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
        /// There are no comments for TotalDiscountVendorGroupSingle in the schema.
        /// </summary>
    public partial class TotalDiscountVendorGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TotalDiscountVendorGroup>
    {
        /// <summary>
        /// Initialize a new TotalDiscountVendorGroupSingle object.
        /// </summary>
        public TotalDiscountVendorGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TotalDiscountVendorGroupSingle object.
        /// </summary>
        public TotalDiscountVendorGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TotalDiscountVendorGroupSingle object.
        /// </summary>
        public TotalDiscountVendorGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TotalDiscountVendorGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for OpenPurchaseTotalDiscountJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.OpenPurchaseTotalDiscountJournalLine> OpenPurchaseTotalDiscountJournalLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OpenPurchaseTotalDiscountJournalLine == null))
                {
                    this._OpenPurchaseTotalDiscountJournalLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.OpenPurchaseTotalDiscountJournalLine>(GetPath("OpenPurchaseTotalDiscountJournalLine"));
                }
                return this._OpenPurchaseTotalDiscountJournalLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.OpenPurchaseTotalDiscountJournalLine> _OpenPurchaseTotalDiscountJournalLine;
    }
        /// <summary>
        /// There are no comments for TotalDiscountVendorGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// GroupCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GroupCode")]
    [global::Microsoft.OData.Client.EntitySet("TotalDiscountVendorGroups")]
    public partial class TotalDiscountVendorGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TotalDiscountVendorGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="groupCode">Initial value of GroupCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TotalDiscountVendorGroup CreateTotalDiscountVendorGroup(string dataAreaId, string groupCode)
        {
            TotalDiscountVendorGroup totalDiscountVendorGroup = new TotalDiscountVendorGroup();
            totalDiscountVendorGroup.dataAreaId = dataAreaId;
            totalDiscountVendorGroup.GroupCode = groupCode;
            return totalDiscountVendorGroup;
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
        /// There are no comments for Property GroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupCode
        {
            get
            {
                return this._GroupCode;
            }
            set
            {
                this.OnGroupCodeChanging(value);
                this._GroupCode = value;
                this.OnGroupCodeChanged();
                this.OnPropertyChanged("GroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupCode;
        partial void OnGroupCodeChanging(string value);
        partial void OnGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property GroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupName
        {
            get
            {
                return this._GroupName;
            }
            set
            {
                this.OnGroupNameChanging(value);
                this._GroupName = value;
                this.OnGroupNameChanged();
                this.OnPropertyChanged("GroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupName;
        partial void OnGroupNameChanging(string value);
        partial void OnGroupNameChanged();
        /// <summary>
        /// There are no comments for Property OpenPurchaseTotalDiscountJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenPurchaseTotalDiscountJournalLine> OpenPurchaseTotalDiscountJournalLine
        {
            get
            {
                return this._OpenPurchaseTotalDiscountJournalLine;
            }
            set
            {
                this.OnOpenPurchaseTotalDiscountJournalLineChanging(value);
                this._OpenPurchaseTotalDiscountJournalLine = value;
                this.OnOpenPurchaseTotalDiscountJournalLineChanged();
                this.OnPropertyChanged("OpenPurchaseTotalDiscountJournalLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenPurchaseTotalDiscountJournalLine> _OpenPurchaseTotalDiscountJournalLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenPurchaseTotalDiscountJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnOpenPurchaseTotalDiscountJournalLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenPurchaseTotalDiscountJournalLine> value);
        partial void OnOpenPurchaseTotalDiscountJournalLineChanged();
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
