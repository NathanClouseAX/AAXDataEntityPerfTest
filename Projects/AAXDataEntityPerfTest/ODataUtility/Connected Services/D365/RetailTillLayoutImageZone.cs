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
        /// There are no comments for RetailTillLayoutImageZoneSingle in the schema.
        /// </summary>
    public partial class RetailTillLayoutImageZoneSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTillLayoutImageZone>
    {
        /// <summary>
        /// Initialize a new RetailTillLayoutImageZoneSingle object.
        /// </summary>
        public RetailTillLayoutImageZoneSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTillLayoutImageZoneSingle object.
        /// </summary>
        public RetailTillLayoutImageZoneSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTillLayoutImageZoneSingle object.
        /// </summary>
        public RetailTillLayoutImageZoneSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTillLayoutImageZone> query)
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
        /// There are no comments for RetailImages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailImagesSingle RetailImages
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailImages == null))
                {
                    this._RetailImages = new global::Microsoft.Dynamics.DataEntities.RetailImagesSingle(this.Context, GetPath("RetailImages"));
                }
                return this._RetailImages;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailImagesSingle _RetailImages;
    }
        /// <summary>
        /// There are no comments for RetailTillLayoutImageZone in the schema.
        /// </summary>
    /// <KeyProperties>
    /// LayoutId
    /// DeviceType
    /// ZoneId
    /// PictureId
    /// LayoutSizeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LayoutId", "DeviceType", "ZoneId", "PictureId", "LayoutSizeId")]
    [global::Microsoft.OData.Client.EntitySet("RetailTillLayoutImageZones")]
    public partial class RetailTillLayoutImageZone : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTillLayoutImageZone object.
        /// </summary>
        /// <param name="layoutId">Initial value of LayoutId.</param>
        /// <param name="deviceType">Initial value of DeviceType.</param>
        /// <param name="zoneId">Initial value of ZoneId.</param>
        /// <param name="pictureId">Initial value of PictureId.</param>
        /// <param name="layoutSizeId">Initial value of LayoutSizeId.</param>
        /// <param name="tillLayoutSize">Initial value of TillLayoutSize.</param>
        /// <param name="retailTillLayoutZone">Initial value of RetailTillLayoutZone.</param>
        /// <param name="retailTillLayout">Initial value of RetailTillLayout.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTillLayoutImageZone CreateRetailTillLayoutImageZone(string layoutId, 
                    int deviceType, 
                    string zoneId, 
                    int pictureId, 
                    string layoutSizeId, 
                    global::Microsoft.Dynamics.DataEntities.TillLayoutSize tillLayoutSize, 
                    global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZone retailTillLayoutZone, 
                    global::Microsoft.Dynamics.DataEntities.RetailTillLayout retailTillLayout)
        {
            RetailTillLayoutImageZone retailTillLayoutImageZone = new RetailTillLayoutImageZone();
            retailTillLayoutImageZone.LayoutId = layoutId;
            retailTillLayoutImageZone.DeviceType = deviceType;
            retailTillLayoutImageZone.ZoneId = zoneId;
            retailTillLayoutImageZone.PictureId = pictureId;
            retailTillLayoutImageZone.LayoutSizeId = layoutSizeId;
            if ((tillLayoutSize == null))
            {
                throw new global::System.ArgumentNullException("tillLayoutSize");
            }
            retailTillLayoutImageZone.TillLayoutSize = tillLayoutSize;
            if ((retailTillLayoutZone == null))
            {
                throw new global::System.ArgumentNullException("retailTillLayoutZone");
            }
            retailTillLayoutImageZone.RetailTillLayoutZone = retailTillLayoutZone;
            if ((retailTillLayout == null))
            {
                throw new global::System.ArgumentNullException("retailTillLayout");
            }
            retailTillLayoutImageZone.RetailTillLayout = retailTillLayout;
            return retailTillLayoutImageZone;
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
        /// There are no comments for Property PictureId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int PictureId
        {
            get
            {
                return this._PictureId;
            }
            set
            {
                this.OnPictureIdChanging(value);
                this._PictureId = value;
                this.OnPictureIdChanged();
                this.OnPropertyChanged("PictureId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PictureId;
        partial void OnPictureIdChanging(int value);
        partial void OnPictureIdChanged();
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
        /// There are no comments for Property RetailImages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailImages RetailImages
        {
            get
            {
                return this._RetailImages;
            }
            set
            {
                this.OnRetailImagesChanging(value);
                this._RetailImages = value;
                this.OnRetailImagesChanged();
                this.OnPropertyChanged("RetailImages");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailImages _RetailImages;
        partial void OnRetailImagesChanging(global::Microsoft.Dynamics.DataEntities.RetailImages value);
        partial void OnRetailImagesChanged();
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
