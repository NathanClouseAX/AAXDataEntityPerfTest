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
    /// There are no comments for DeviceTypeSingle in the schema.
    /// </summary>
    public partial class DeviceTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DeviceType>
    {
        /// <summary>
        /// Initialize a new DeviceTypeSingle object.
        /// </summary>
        public DeviceTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DeviceTypeSingle object.
        /// </summary>
        public DeviceTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DeviceTypeSingle object.
        /// </summary>
        public DeviceTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DeviceType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DeviceTypes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZone> DeviceTypes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DeviceTypes == null))
                {
                    this._DeviceTypes = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZone>(GetPath("DeviceTypes"));
                }
                return this._DeviceTypes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZone> _DeviceTypes;
    }
    /// <summary>
    /// There are no comments for DeviceType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Type
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Type")]
    [global::Microsoft.OData.Client.EntitySet("DeviceTypes")]
    public partial class DeviceType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DeviceType object.
        /// </summary>
        /// <param name="type">Initial value of Type.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DeviceType CreateDeviceType(int type)
        {
            DeviceType deviceType = new DeviceType();
            deviceType.Type = type;
            return deviceType;
        }
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Type is required.")]
        public virtual int Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Type;
        partial void OnTypeChanging(int value);
        partial void OnTypeChanged();
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
        /// There are no comments for Property DesignerForm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDesignerFormEnum> DesignerForm
        {
            get
            {
                return this._DesignerForm;
            }
            set
            {
                this.OnDesignerFormChanging(value);
                this._DesignerForm = value;
                this.OnDesignerFormChanged();
                this.OnPropertyChanged("DesignerForm");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDesignerFormEnum> _DesignerForm;
        partial void OnDesignerFormChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDesignerFormEnum> value);
        partial void OnDesignerFormChanged();
        /// <summary>
        /// There are no comments for Property DeviceTypes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZone> DeviceTypes
        {
            get
            {
                return this._DeviceTypes;
            }
            set
            {
                this.OnDeviceTypesChanging(value);
                this._DeviceTypes = value;
                this.OnDeviceTypesChanged();
                this.OnPropertyChanged("DeviceTypes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZone> _DeviceTypes = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZone>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDeviceTypesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZone> value);
        partial void OnDeviceTypesChanged();
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
