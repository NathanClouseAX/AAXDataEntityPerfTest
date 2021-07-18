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
        /// There are no comments for CDSPostalAddressLocationSingle in the schema.
        /// </summary>
    public partial class CDSPostalAddressLocationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CDSPostalAddressLocation>
    {
        /// <summary>
        /// Initialize a new CDSPostalAddressLocationSingle object.
        /// </summary>
        public CDSPostalAddressLocationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CDSPostalAddressLocationSingle object.
        /// </summary>
        public CDSPostalAddressLocationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CDSPostalAddressLocationSingle object.
        /// </summary>
        public CDSPostalAddressLocationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CDSPostalAddressLocation> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for CDSPostalAddressLocation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// LocationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LocationId")]
    [global::Microsoft.OData.Client.EntitySet("CDSPostalAddressLocations")]
    public partial class CDSPostalAddressLocation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CDSPostalAddressLocation object.
        /// </summary>
        /// <param name="locationId">Initial value of LocationId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CDSPostalAddressLocation CreateCDSPostalAddressLocation(string locationId)
        {
            CDSPostalAddressLocation cDSPostalAddressLocation = new CDSPostalAddressLocation();
            cDSPostalAddressLocation.LocationId = locationId;
            return cDSPostalAddressLocation;
        }
        /// <summary>
        /// There are no comments for Property LocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LocationId
        {
            get
            {
                return this._LocationId;
            }
            set
            {
                this.OnLocationIdChanging(value);
                this._LocationId = value;
                this.OnLocationIdChanged();
                this.OnPropertyChanged("LocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LocationId;
        partial void OnLocationIdChanging(string value);
        partial void OnLocationIdChanged();
        /// <summary>
        /// There are no comments for Property ParentLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ParentLocationId
        {
            get
            {
                return this._ParentLocationId;
            }
            set
            {
                this.OnParentLocationIdChanging(value);
                this._ParentLocationId = value;
                this.OnParentLocationIdChanged();
                this.OnPropertyChanged("ParentLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentLocationId;
        partial void OnParentLocationIdChanging(string value);
        partial void OnParentLocationIdChanged();
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
