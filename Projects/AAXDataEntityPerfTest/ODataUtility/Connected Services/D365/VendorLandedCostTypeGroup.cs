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
        /// There are no comments for VendorLandedCostTypeGroupSingle in the schema.
        /// </summary>
    public partial class VendorLandedCostTypeGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorLandedCostTypeGroup>
    {
        /// <summary>
        /// Initialize a new VendorLandedCostTypeGroupSingle object.
        /// </summary>
        public VendorLandedCostTypeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorLandedCostTypeGroupSingle object.
        /// </summary>
        public VendorLandedCostTypeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorLandedCostTypeGroupSingle object.
        /// </summary>
        public VendorLandedCostTypeGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorLandedCostTypeGroup> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for VendorLandedCostTypeGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// GroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GroupId")]
    [global::Microsoft.OData.Client.EntitySet("VendorLandedCostTypeGroups")]
    public partial class VendorLandedCostTypeGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorLandedCostTypeGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="groupId">Initial value of GroupId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorLandedCostTypeGroup CreateVendorLandedCostTypeGroup(string dataAreaId, string groupId)
        {
            VendorLandedCostTypeGroup vendorLandedCostTypeGroup = new VendorLandedCostTypeGroup();
            vendorLandedCostTypeGroup.dataAreaId = dataAreaId;
            vendorLandedCostTypeGroup.GroupId = groupId;
            return vendorLandedCostTypeGroup;
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
        /// There are no comments for Property GroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupId
        {
            get
            {
                return this._GroupId;
            }
            set
            {
                this.OnGroupIdChanging(value);
                this._GroupId = value;
                this.OnGroupIdChanged();
                this.OnPropertyChanged("GroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupId;
        partial void OnGroupIdChanging(string value);
        partial void OnGroupIdChanged();
        /// <summary>
        /// There are no comments for Property GroupDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupDescription
        {
            get
            {
                return this._GroupDescription;
            }
            set
            {
                this.OnGroupDescriptionChanging(value);
                this._GroupDescription = value;
                this.OnGroupDescriptionChanged();
                this.OnPropertyChanged("GroupDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupDescription;
        partial void OnGroupDescriptionChanging(string value);
        partial void OnGroupDescriptionChanged();
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