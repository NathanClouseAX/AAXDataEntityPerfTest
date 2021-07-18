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
        /// There are no comments for ShipCustomsDescriptionSingle in the schema.
        /// </summary>
    public partial class ShipCustomsDescriptionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ShipCustomsDescription>
    {
        /// <summary>
        /// Initialize a new ShipCustomsDescriptionSingle object.
        /// </summary>
        public ShipCustomsDescriptionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ShipCustomsDescriptionSingle object.
        /// </summary>
        public ShipCustomsDescriptionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ShipCustomsDescriptionSingle object.
        /// </summary>
        public ShipCustomsDescriptionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ShipCustomsDescription> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for ShipCustomsDescription in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CustomsDescription
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CustomsDescription")]
    [global::Microsoft.OData.Client.EntitySet("ShipCustomsDescriptions")]
    public partial class ShipCustomsDescription : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ShipCustomsDescription object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="customsDescription">Initial value of CustomsDescription.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ShipCustomsDescription CreateShipCustomsDescription(string dataAreaId, string customsDescription)
        {
            ShipCustomsDescription shipCustomsDescription = new ShipCustomsDescription();
            shipCustomsDescription.dataAreaId = dataAreaId;
            shipCustomsDescription.CustomsDescription = customsDescription;
            return shipCustomsDescription;
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
        /// There are no comments for Property CustomsDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomsDescription
        {
            get
            {
                return this._CustomsDescription;
            }
            set
            {
                this.OnCustomsDescriptionChanging(value);
                this._CustomsDescription = value;
                this.OnCustomsDescriptionChanged();
                this.OnPropertyChanged("CustomsDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomsDescription;
        partial void OnCustomsDescriptionChanging(string value);
        partial void OnCustomsDescriptionChanged();
        /// <summary>
        /// There are no comments for Property DetailedCustomsDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DetailedCustomsDescription
        {
            get
            {
                return this._DetailedCustomsDescription;
            }
            set
            {
                this.OnDetailedCustomsDescriptionChanging(value);
                this._DetailedCustomsDescription = value;
                this.OnDetailedCustomsDescriptionChanged();
                this.OnPropertyChanged("DetailedCustomsDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DetailedCustomsDescription;
        partial void OnDetailedCustomsDescriptionChanging(string value);
        partial void OnDetailedCustomsDescriptionChanged();
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
