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
        /// There are no comments for KittingDynPartGroupItemSingle in the schema.
        /// </summary>
    public partial class KittingDynPartGroupItemSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<KittingDynPartGroupItem>
    {
        /// <summary>
        /// Initialize a new KittingDynPartGroupItemSingle object.
        /// </summary>
        public KittingDynPartGroupItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new KittingDynPartGroupItemSingle object.
        /// </summary>
        public KittingDynPartGroupItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new KittingDynPartGroupItemSingle object.
        /// </summary>
        public KittingDynPartGroupItemSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<KittingDynPartGroupItem> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for GroupItems in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Kitting_PartGroupSingle GroupItems
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._GroupItems == null))
                {
                    this._GroupItems = new global::Microsoft.Dynamics.DataEntities.Kitting_PartGroupSingle(this.Context, GetPath("GroupItems"));
                }
                return this._GroupItems;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Kitting_PartGroupSingle _GroupItems;
    }
        /// <summary>
        /// There are no comments for KittingDynPartGroupItem in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// DynamicPartGroup
    /// ItemNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DynamicPartGroup", "ItemNumber")]
    [global::Microsoft.OData.Client.EntitySet("KittingDynPartGroupItems")]
    public partial class KittingDynPartGroupItem : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new KittingDynPartGroupItem object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="dynamicPartGroup">Initial value of DynamicPartGroup.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="groupItems">Initial value of GroupItems.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static KittingDynPartGroupItem CreateKittingDynPartGroupItem(string dataAreaId, string dynamicPartGroup, string itemNumber, global::Microsoft.Dynamics.DataEntities.Kitting_PartGroup groupItems)
        {
            KittingDynPartGroupItem kittingDynPartGroupItem = new KittingDynPartGroupItem();
            kittingDynPartGroupItem.dataAreaId = dataAreaId;
            kittingDynPartGroupItem.DynamicPartGroup = dynamicPartGroup;
            kittingDynPartGroupItem.ItemNumber = itemNumber;
            if ((groupItems == null))
            {
                throw new global::System.ArgumentNullException("groupItems");
            }
            kittingDynPartGroupItem.GroupItems = groupItems;
            return kittingDynPartGroupItem;
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
        /// There are no comments for Property DynamicPartGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DynamicPartGroup
        {
            get
            {
                return this._DynamicPartGroup;
            }
            set
            {
                this.OnDynamicPartGroupChanging(value);
                this._DynamicPartGroup = value;
                this.OnDynamicPartGroupChanged();
                this.OnPropertyChanged("DynamicPartGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DynamicPartGroup;
        partial void OnDynamicPartGroupChanging(string value);
        partial void OnDynamicPartGroupChanged();
        /// <summary>
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemNumber
        {
            get
            {
                return this._ItemNumber;
            }
            set
            {
                this.OnItemNumberChanging(value);
                this._ItemNumber = value;
                this.OnItemNumberChanged();
                this.OnPropertyChanged("ItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumber;
        partial void OnItemNumberChanging(string value);
        partial void OnItemNumberChanged();
        /// <summary>
        /// There are no comments for Property GroupItems in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Kitting_PartGroup GroupItems
        {
            get
            {
                return this._GroupItems;
            }
            set
            {
                this.OnGroupItemsChanging(value);
                this._GroupItems = value;
                this.OnGroupItemsChanged();
                this.OnPropertyChanged("GroupItems");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Kitting_PartGroup _GroupItems;
        partial void OnGroupItemsChanging(global::Microsoft.Dynamics.DataEntities.Kitting_PartGroup value);
        partial void OnGroupItemsChanged();
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