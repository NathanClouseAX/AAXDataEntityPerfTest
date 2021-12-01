﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/28/2021 8:55:09 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for ShippingContainerTableSingle in the schema.
    /// </summary>
    public partial class ShippingContainerTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingContainerTable>
    {
        /// <summary>
        /// Initialize a new ShippingContainerTableSingle object.
        /// </summary>
        public ShippingContainerTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ShippingContainerTableSingle object.
        /// </summary>
        public ShippingContainerTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ShippingContainerTableSingle object.
        /// </summary>
        public ShippingContainerTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingContainerTable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ShippingContainerTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ShippingContainerId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ShippingContainerId")]
    [global::Microsoft.OData.Client.EntitySet("ShippingContainerTables")]
    public partial class ShippingContainerTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ShippingContainerTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="shippingContainerId">Initial value of ShippingContainerId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ShippingContainerTable CreateShippingContainerTable(string dataAreaId, string shippingContainerId)
        {
            ShippingContainerTable shippingContainerTable = new ShippingContainerTable();
            shippingContainerTable.dataAreaId = dataAreaId;
            shippingContainerTable.ShippingContainerId = shippingContainerId;
            return shippingContainerTable;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "dataAreaId is required.")]
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
        /// There are no comments for Property ShippingContainerId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShippingContainerId is required.")]
        public virtual string ShippingContainerId
        {
            get
            {
                return this._ShippingContainerId;
            }
            set
            {
                this.OnShippingContainerIdChanging(value);
                this._ShippingContainerId = value;
                this.OnShippingContainerIdChanged();
                this.OnPropertyChanged("ShippingContainerId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShippingContainerId;
        partial void OnShippingContainerIdChanging(string value);
        partial void OnShippingContainerIdChanged();
        /// <summary>
        /// There are no comments for Property ShippingContainerTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ShippingContainerTypeId
        {
            get
            {
                return this._ShippingContainerTypeId;
            }
            set
            {
                this.OnShippingContainerTypeIdChanging(value);
                this._ShippingContainerTypeId = value;
                this.OnShippingContainerTypeIdChanged();
                this.OnPropertyChanged("ShippingContainerTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShippingContainerTypeId;
        partial void OnShippingContainerTypeIdChanging(string value);
        partial void OnShippingContainerTypeIdChanged();
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
