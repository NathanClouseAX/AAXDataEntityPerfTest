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
        /// There are no comments for TillLayoutSizeSingle in the schema.
        /// </summary>
    public partial class TillLayoutSizeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TillLayoutSize>
    {
        /// <summary>
        /// Initialize a new TillLayoutSizeSingle object.
        /// </summary>
        public TillLayoutSizeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TillLayoutSizeSingle object.
        /// </summary>
        public TillLayoutSizeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TillLayoutSizeSingle object.
        /// </summary>
        public TillLayoutSizeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TillLayoutSize> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TillLayoutConfiguration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TillLayoutConfiguration> TillLayoutConfiguration
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TillLayoutConfiguration == null))
                {
                    this._TillLayoutConfiguration = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TillLayoutConfiguration>(GetPath("TillLayoutConfiguration"));
                }
                return this._TillLayoutConfiguration;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TillLayoutConfiguration> _TillLayoutConfiguration;
        /// <summary>
        /// There are no comments for RetailTillLayoutImageZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutImageZone> RetailTillLayoutImageZone
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTillLayoutImageZone == null))
                {
                    this._RetailTillLayoutImageZone = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutImageZone>(GetPath("RetailTillLayoutImageZone"));
                }
                return this._RetailTillLayoutImageZone;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutImageZone> _RetailTillLayoutImageZone;
        /// <summary>
        /// There are no comments for RetailTillLayoutButtonGridZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutButtonGridZone> RetailTillLayoutButtonGridZone
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTillLayoutButtonGridZone == null))
                {
                    this._RetailTillLayoutButtonGridZone = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutButtonGridZone>(GetPath("RetailTillLayoutButtonGridZone"));
                }
                return this._RetailTillLayoutButtonGridZone;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutButtonGridZone> _RetailTillLayoutButtonGridZone;
        /// <summary>
        /// There are no comments for RetailTillLayoutReportZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> RetailTillLayoutReportZone
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTillLayoutReportZone == null))
                {
                    this._RetailTillLayoutReportZone = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone>(GetPath("RetailTillLayoutReportZone"));
                }
                return this._RetailTillLayoutReportZone;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> _RetailTillLayoutReportZone;
    }
        /// <summary>
        /// There are no comments for TillLayoutSize in the schema.
        /// </summary>
    /// <KeyProperties>
    /// LayoutSizeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LayoutSizeId")]
    [global::Microsoft.OData.Client.EntitySet("TillLayoutSizes")]
    public partial class TillLayoutSize : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TillLayoutSize object.
        /// </summary>
        /// <param name="layoutSizeId">Initial value of LayoutSizeId.</param>
        /// <param name="height">Initial value of Height.</param>
        /// <param name="width">Initial value of Width.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TillLayoutSize CreateTillLayoutSize(string layoutSizeId, int height, int width)
        {
            TillLayoutSize tillLayoutSize = new TillLayoutSize();
            tillLayoutSize.LayoutSizeId = layoutSizeId;
            tillLayoutSize.Height = height;
            tillLayoutSize.Width = width;
            return tillLayoutSize;
        }
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
        /// There are no comments for Property Height in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Height
        {
            get
            {
                return this._Height;
            }
            set
            {
                this.OnHeightChanging(value);
                this._Height = value;
                this.OnHeightChanged();
                this.OnPropertyChanged("Height");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Height;
        partial void OnHeightChanging(int value);
        partial void OnHeightChanged();
        /// <summary>
        /// There are no comments for Property LayoutType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLayoutType> LayoutType
        {
            get
            {
                return this._LayoutType;
            }
            set
            {
                this.OnLayoutTypeChanging(value);
                this._LayoutType = value;
                this.OnLayoutTypeChanged();
                this.OnPropertyChanged("LayoutType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLayoutType> _LayoutType;
        partial void OnLayoutTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLayoutType> value);
        partial void OnLayoutTypeChanged();
        /// <summary>
        /// There are no comments for Property Width in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Width
        {
            get
            {
                return this._Width;
            }
            set
            {
                this.OnWidthChanging(value);
                this._Width = value;
                this.OnWidthChanged();
                this.OnPropertyChanged("Width");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Width;
        partial void OnWidthChanging(int value);
        partial void OnWidthChanged();
        /// <summary>
        /// There are no comments for Property TillLayoutConfiguration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TillLayoutConfiguration> TillLayoutConfiguration
        {
            get
            {
                return this._TillLayoutConfiguration;
            }
            set
            {
                this.OnTillLayoutConfigurationChanging(value);
                this._TillLayoutConfiguration = value;
                this.OnTillLayoutConfigurationChanged();
                this.OnPropertyChanged("TillLayoutConfiguration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TillLayoutConfiguration> _TillLayoutConfiguration = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TillLayoutConfiguration>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTillLayoutConfigurationChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TillLayoutConfiguration> value);
        partial void OnTillLayoutConfigurationChanged();
        /// <summary>
        /// There are no comments for Property RetailTillLayoutImageZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutImageZone> RetailTillLayoutImageZone
        {
            get
            {
                return this._RetailTillLayoutImageZone;
            }
            set
            {
                this.OnRetailTillLayoutImageZoneChanging(value);
                this._RetailTillLayoutImageZone = value;
                this.OnRetailTillLayoutImageZoneChanged();
                this.OnPropertyChanged("RetailTillLayoutImageZone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutImageZone> _RetailTillLayoutImageZone = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutImageZone>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailTillLayoutImageZoneChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutImageZone> value);
        partial void OnRetailTillLayoutImageZoneChanged();
        /// <summary>
        /// There are no comments for Property RetailTillLayoutButtonGridZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutButtonGridZone> RetailTillLayoutButtonGridZone
        {
            get
            {
                return this._RetailTillLayoutButtonGridZone;
            }
            set
            {
                this.OnRetailTillLayoutButtonGridZoneChanging(value);
                this._RetailTillLayoutButtonGridZone = value;
                this.OnRetailTillLayoutButtonGridZoneChanged();
                this.OnPropertyChanged("RetailTillLayoutButtonGridZone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutButtonGridZone> _RetailTillLayoutButtonGridZone = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutButtonGridZone>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailTillLayoutButtonGridZoneChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutButtonGridZone> value);
        partial void OnRetailTillLayoutButtonGridZoneChanged();
        /// <summary>
        /// There are no comments for Property RetailTillLayoutReportZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> RetailTillLayoutReportZone
        {
            get
            {
                return this._RetailTillLayoutReportZone;
            }
            set
            {
                this.OnRetailTillLayoutReportZoneChanging(value);
                this._RetailTillLayoutReportZone = value;
                this.OnRetailTillLayoutReportZoneChanged();
                this.OnPropertyChanged("RetailTillLayoutReportZone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> _RetailTillLayoutReportZone = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailTillLayoutReportZoneChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> value);
        partial void OnRetailTillLayoutReportZoneChanged();
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
