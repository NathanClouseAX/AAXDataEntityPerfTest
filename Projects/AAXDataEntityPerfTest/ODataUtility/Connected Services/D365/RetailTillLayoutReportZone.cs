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
    /// There are no comments for RetailTillLayoutReportZoneSingle in the schema.
    /// </summary>
    public partial class RetailTillLayoutReportZoneSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTillLayoutReportZone>
    {
        /// <summary>
        /// Initialize a new RetailTillLayoutReportZoneSingle object.
        /// </summary>
        public RetailTillLayoutReportZoneSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTillLayoutReportZoneSingle object.
        /// </summary>
        public RetailTillLayoutReportZoneSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTillLayoutReportZoneSingle object.
        /// </summary>
        public RetailTillLayoutReportZoneSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTillLayoutReportZone> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailChannelReport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailChannelReportSingle RetailChannelReport
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailChannelReport == null))
                {
                    this._RetailChannelReport = new global::Microsoft.Dynamics.DataEntities.RetailChannelReportSingle(this.Context, GetPath("RetailChannelReport"));
                }
                return this._RetailChannelReport;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailChannelReportSingle _RetailChannelReport;
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
    }
    /// <summary>
    /// There are no comments for RetailTillLayoutReportZone in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LayoutId
    /// DeviceType
    /// ZoneId
    /// ReportID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LayoutId", "DeviceType", "ZoneId", "ReportID")]
    [global::Microsoft.OData.Client.EntitySet("RetailTillLayoutReportZones")]
    public partial class RetailTillLayoutReportZone : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTillLayoutReportZone object.
        /// </summary>
        /// <param name="layoutId">Initial value of LayoutId.</param>
        /// <param name="deviceType">Initial value of DeviceType.</param>
        /// <param name="zoneId">Initial value of ZoneId.</param>
        /// <param name="reportID">Initial value of ReportID.</param>
        /// <param name="tillLayoutSize">Initial value of TillLayoutSize.</param>
        /// <param name="retailTillLayoutZone">Initial value of RetailTillLayoutZone.</param>
        /// <param name="retailTillLayout">Initial value of RetailTillLayout.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTillLayoutReportZone CreateRetailTillLayoutReportZone(string layoutId, 
                    int deviceType, 
                    string zoneId, 
                    string reportID, 
                    global::Microsoft.Dynamics.DataEntities.TillLayoutSize tillLayoutSize, 
                    global::Microsoft.Dynamics.DataEntities.RetailTillLayoutZone retailTillLayoutZone, 
                    global::Microsoft.Dynamics.DataEntities.RetailTillLayout retailTillLayout)
        {
            RetailTillLayoutReportZone retailTillLayoutReportZone = new RetailTillLayoutReportZone();
            retailTillLayoutReportZone.LayoutId = layoutId;
            retailTillLayoutReportZone.DeviceType = deviceType;
            retailTillLayoutReportZone.ZoneId = zoneId;
            retailTillLayoutReportZone.ReportID = reportID;
            if ((tillLayoutSize == null))
            {
                throw new global::System.ArgumentNullException("tillLayoutSize");
            }
            retailTillLayoutReportZone.TillLayoutSize = tillLayoutSize;
            if ((retailTillLayoutZone == null))
            {
                throw new global::System.ArgumentNullException("retailTillLayoutZone");
            }
            retailTillLayoutReportZone.RetailTillLayoutZone = retailTillLayoutZone;
            if ((retailTillLayout == null))
            {
                throw new global::System.ArgumentNullException("retailTillLayout");
            }
            retailTillLayoutReportZone.RetailTillLayout = retailTillLayout;
            return retailTillLayoutReportZone;
        }
        /// <summary>
        /// There are no comments for Property LayoutId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LayoutId is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeviceType is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ZoneId is required.")]
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
        /// There are no comments for Property ReportID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReportID is required.")]
        public virtual string ReportID
        {
            get
            {
                return this._ReportID;
            }
            set
            {
                this.OnReportIDChanging(value);
                this._ReportID = value;
                this.OnReportIDChanged();
                this.OnPropertyChanged("ReportID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReportID;
        partial void OnReportIDChanging(string value);
        partial void OnReportIDChanged();
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
        /// There are no comments for Property RetailChannelReport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.Dynamics.DataEntities.RetailChannelReport RetailChannelReport
        {
            get
            {
                return this._RetailChannelReport;
            }
            set
            {
                this.OnRetailChannelReportChanging(value);
                this._RetailChannelReport = value;
                this.OnRetailChannelReportChanged();
                this.OnPropertyChanged("RetailChannelReport");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailChannelReport _RetailChannelReport;
        partial void OnRetailChannelReportChanging(global::Microsoft.Dynamics.DataEntities.RetailChannelReport value);
        partial void OnRetailChannelReportChanged();
        /// <summary>
        /// There are no comments for Property TillLayoutSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TillLayoutSize is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailTillLayoutZone is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailTillLayout is required.")]
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
