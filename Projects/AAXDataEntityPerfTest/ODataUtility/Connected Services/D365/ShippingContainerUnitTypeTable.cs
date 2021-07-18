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
        /// There are no comments for ShippingContainerUnitTypeTableSingle in the schema.
        /// </summary>
    public partial class ShippingContainerUnitTypeTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingContainerUnitTypeTable>
    {
        /// <summary>
        /// Initialize a new ShippingContainerUnitTypeTableSingle object.
        /// </summary>
        public ShippingContainerUnitTypeTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ShippingContainerUnitTypeTableSingle object.
        /// </summary>
        public ShippingContainerUnitTypeTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ShippingContainerUnitTypeTableSingle object.
        /// </summary>
        public ShippingContainerUnitTypeTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingContainerUnitTypeTable> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for ShippingContainerUnitTypeTable in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// UnitTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "UnitTypeId")]
    [global::Microsoft.OData.Client.EntitySet("ShippingContainerUnitTypeTables")]
    public partial class ShippingContainerUnitTypeTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ShippingContainerUnitTypeTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="unitTypeId">Initial value of UnitTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ShippingContainerUnitTypeTable CreateShippingContainerUnitTypeTable(string dataAreaId, string unitTypeId)
        {
            ShippingContainerUnitTypeTable shippingContainerUnitTypeTable = new ShippingContainerUnitTypeTable();
            shippingContainerUnitTypeTable.dataAreaId = dataAreaId;
            shippingContainerUnitTypeTable.UnitTypeId = unitTypeId;
            return shippingContainerUnitTypeTable;
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
        /// There are no comments for Property UnitTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UnitTypeId
        {
            get
            {
                return this._UnitTypeId;
            }
            set
            {
                this.OnUnitTypeIdChanging(value);
                this._UnitTypeId = value;
                this.OnUnitTypeIdChanged();
                this.OnPropertyChanged("UnitTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitTypeId;
        partial void OnUnitTypeIdChanging(string value);
        partial void OnUnitTypeIdChanged();
        /// <summary>
        /// There are no comments for Property UnitTypeDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UnitTypeDescription
        {
            get
            {
                return this._UnitTypeDescription;
            }
            set
            {
                this.OnUnitTypeDescriptionChanging(value);
                this._UnitTypeDescription = value;
                this.OnUnitTypeDescriptionChanged();
                this.OnPropertyChanged("UnitTypeDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitTypeDescription;
        partial void OnUnitTypeDescriptionChanging(string value);
        partial void OnUnitTypeDescriptionChanged();
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
