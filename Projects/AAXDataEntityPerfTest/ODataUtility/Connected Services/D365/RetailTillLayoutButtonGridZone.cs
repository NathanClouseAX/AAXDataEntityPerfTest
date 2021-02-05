﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for RetailTillLayoutButtonGridZoneSingle in the schema.
        /// </summary>
    public partial class RetailTillLayoutButtonGridZoneSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTillLayoutButtonGridZone>
    {
        /// <summary>
        /// Initialize a new RetailTillLayoutButtonGridZoneSingle object.
        /// </summary>
        public RetailTillLayoutButtonGridZoneSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTillLayoutButtonGridZoneSingle object.
        /// </summary>
        public RetailTillLayoutButtonGridZoneSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTillLayoutButtonGridZoneSingle object.
        /// </summary>
        public RetailTillLayoutButtonGridZoneSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTillLayoutButtonGridZone> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TillLayoutSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TillLayoutSizeSingle TillLayoutSize
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TillLayoutSize == null))
                {
                    this._TillLayoutSize = new global::Microsoft.Dynamics.DataEntities.TillLayoutSizeSingle(this.Context, GetPath("TillLayoutSize"));
                }
                return this._TillLayoutSize;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TillLayoutSizeSingle _TillLayoutSize;
        /// <summary>
        /// There are no comments for RetailTillLayoutZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZoneSingle RetailTillLayoutZone
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTillLayoutZone == null))
                {
                    this._RetailTillLayoutZone = new global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZoneSingle(this.Context, GetPath("RetailTillLayoutZone"));
                }
                return this._RetailTillLayoutZone;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZoneSingle _RetailTillLayoutZone;
        /// <summary>
        /// There are no comments for RetailTillLayout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTillLayoutSingle RetailTillLayout
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTillLayout == null))
                {
                    this._RetailTillLayout = new global::Microsoft.Dynamics.DataEntities.RetailTillLayoutSingle(this.Context, GetPath("RetailTillLayout"));
                }
                return this._RetailTillLayout;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTillLayoutSingle _RetailTillLayout;
        /// <summary>
        /// There are no comments for RetailButtonGrid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailButtonGridSingle RetailButtonGrid
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailButtonGrid == null))
                {
                    this._RetailButtonGrid = new global::Microsoft.Dynamics.DataEntities.RetailButtonGridSingle(this.Context, GetPath("RetailButtonGrid"));
                }
                return this._RetailButtonGrid;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailButtonGridSingle _RetailButtonGrid;
    }
        /// <summary>
        /// There are no comments for RetailTillLayoutButtonGridZone in the schema.
        /// </summary>
    /// <KeyProperties>
    /// LayoutId
    /// DeviceType
    /// ZoneId
    /// ButtonGridId
    /// LayoutSizeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LayoutId", "DeviceType", "ZoneId", "ButtonGridId", "LayoutSizeId")]
    [global::Microsoft.OData.Client.EntitySet("RetailTillLayoutButtonGridZones")]
    public partial class RetailTillLayoutButtonGridZone : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTillLayoutButtonGridZone object.
        /// </summary>
        /// <param name="layoutId">Initial value of LayoutId.</param>
        /// <param name="deviceType">Initial value of DeviceType.</param>
        /// <param name="zoneId">Initial value of ZoneId.</param>
        /// <param name="buttonGridId">Initial value of ButtonGridId.</param>
        /// <param name="layoutSizeId">Initial value of LayoutSizeId.</param>
        /// <param name="tillLayoutSize">Initial value of TillLayoutSize.</param>
        /// <param name="retailTillLayoutZone">Initial value of RetailTillLayoutZone.</param>
        /// <param name="retailTillLayout">Initial value of RetailTillLayout.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTillLayoutButtonGridZone CreateRetailTillLayoutButtonGridZone(string layoutId, 
                    int deviceType, 
                    string zoneId, 
                    string buttonGridId, 
                    string layoutSizeId, 
                    global::Microsoft.Dynamics.DataEntities.TillLayoutSize tillLayoutSize, 
                    global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZone retailTillLayoutZone, 
                    global::Microsoft.Dynamics.DataEntities.RetailTillLayout retailTillLayout)
        {
            RetailTillLayoutButtonGridZone retailTillLayoutButtonGridZone = new RetailTillLayoutButtonGridZone();
            retailTillLayoutButtonGridZone.LayoutId = layoutId;
            retailTillLayoutButtonGridZone.DeviceType = deviceType;
            retailTillLayoutButtonGridZone.ZoneId = zoneId;
            retailTillLayoutButtonGridZone.ButtonGridId = buttonGridId;
            retailTillLayoutButtonGridZone.LayoutSizeId = layoutSizeId;
            if ((tillLayoutSize == null))
            {
                throw new global::System.ArgumentNullException("tillLayoutSize");
            }
            retailTillLayoutButtonGridZone.TillLayoutSize = tillLayoutSize;
            if ((retailTillLayoutZone == null))
            {
                throw new global::System.ArgumentNullException("retailTillLayoutZone");
            }
            retailTillLayoutButtonGridZone.RetailTillLayoutZone = retailTillLayoutZone;
            if ((retailTillLayout == null))
            {
                throw new global::System.ArgumentNullException("retailTillLayout");
            }
            retailTillLayoutButtonGridZone.RetailTillLayout = retailTillLayout;
            return retailTillLayoutButtonGridZone;
        }
        /// <summary>
        /// There are no comments for Property LayoutId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LayoutId
        {
            get
            {
                return this._LayoutId;
            }
            set
            {
                this.OnLayoutIdChanging(value);
                this._LayoutId = value;
                this.OnLayoutIdChanged();
                this.OnPropertyChanged("LayoutId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LayoutId;
        partial void OnLayoutIdChanging(string value);
        partial void OnLayoutIdChanged();
        /// <summary>
        /// There are no comments for Property DeviceType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int DeviceType
        {
            get
            {
                return this._DeviceType;
            }
            set
            {
                this.OnDeviceTypeChanging(value);
                this._DeviceType = value;
                this.OnDeviceTypeChanged();
                this.OnPropertyChanged("DeviceType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DeviceType;
        partial void OnDeviceTypeChanging(int value);
        partial void OnDeviceTypeChanged();
        /// <summary>
        /// There are no comments for Property ZoneId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ZoneId
        {
            get
            {
                return this._ZoneId;
            }
            set
            {
                this.OnZoneIdChanging(value);
                this._ZoneId = value;
                this.OnZoneIdChanged();
                this.OnPropertyChanged("ZoneId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ZoneId;
        partial void OnZoneIdChanging(string value);
        partial void OnZoneIdChanged();
        /// <summary>
        /// There are no comments for Property ButtonGridId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ButtonGridId
        {
            get
            {
                return this._ButtonGridId;
            }
            set
            {
                this.OnButtonGridIdChanging(value);
                this._ButtonGridId = value;
                this.OnButtonGridIdChanged();
                this.OnPropertyChanged("ButtonGridId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ButtonGridId;
        partial void OnButtonGridIdChanging(string value);
        partial void OnButtonGridIdChanged();
        /// <summary>
        /// There are no comments for Property LayoutSizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LayoutSizeId
        {
            get
            {
                return this._LayoutSizeId;
            }
            set
            {
                this.OnLayoutSizeIdChanging(value);
                this._LayoutSizeId = value;
                this.OnLayoutSizeIdChanged();
                this.OnPropertyChanged("LayoutSizeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LayoutSizeId;
        partial void OnLayoutSizeIdChanging(string value);
        partial void OnLayoutSizeIdChanged();
        /// <summary>
        /// There are no comments for Property TillLayoutSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TillLayoutSize TillLayoutSize
        {
            get
            {
                return this._TillLayoutSize;
            }
            set
            {
                this.OnTillLayoutSizeChanging(value);
                this._TillLayoutSize = value;
                this.OnTillLayoutSizeChanged();
                this.OnPropertyChanged("TillLayoutSize");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TillLayoutSize _TillLayoutSize;
        partial void OnTillLayoutSizeChanging(global::Microsoft.Dynamics.DataEntities.TillLayoutSize value);
        partial void OnTillLayoutSizeChanged();
        /// <summary>
        /// There are no comments for Property RetailTillLayoutZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZone RetailTillLayoutZone
        {
            get
            {
                return this._RetailTillLayoutZone;
            }
            set
            {
                this.OnRetailTillLayoutZoneChanging(value);
                this._RetailTillLayoutZone = value;
                this.OnRetailTillLayoutZoneChanged();
                this.OnPropertyChanged("RetailTillLayoutZone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZone _RetailTillLayoutZone;
        partial void OnRetailTillLayoutZoneChanging(global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZone value);
        partial void OnRetailTillLayoutZoneChanged();
        /// <summary>
        /// There are no comments for Property RetailTillLayout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTillLayout RetailTillLayout
        {
            get
            {
                return this._RetailTillLayout;
            }
            set
            {
                this.OnRetailTillLayoutChanging(value);
                this._RetailTillLayout = value;
                this.OnRetailTillLayoutChanged();
                this.OnPropertyChanged("RetailTillLayout");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTillLayout _RetailTillLayout;
        partial void OnRetailTillLayoutChanging(global::Microsoft.Dynamics.DataEntities.RetailTillLayout value);
        partial void OnRetailTillLayoutChanged();
        /// <summary>
        /// There are no comments for Property RetailButtonGrid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailButtonGrid RetailButtonGrid
        {
            get
            {
                return this._RetailButtonGrid;
            }
            set
            {
                this.OnRetailButtonGridChanging(value);
                this._RetailButtonGrid = value;
                this.OnRetailButtonGridChanged();
                this.OnPropertyChanged("RetailButtonGrid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailButtonGrid _RetailButtonGrid;
        partial void OnRetailButtonGridChanging(global::Microsoft.Dynamics.DataEntities.RetailButtonGrid value);
        partial void OnRetailButtonGridChanged();
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
