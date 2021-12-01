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
    /// There are no comments for AssetMaintenanceWarrantyLineSingle in the schema.
    /// </summary>
    public partial class AssetMaintenanceWarrantyLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWarrantyLine>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceWarrantyLineSingle object.
        /// </summary>
        public AssetMaintenanceWarrantyLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWarrantyLineSingle object.
        /// </summary>
        public AssetMaintenanceWarrantyLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWarrantyLineSingle object.
        /// </summary>
        public AssetMaintenanceWarrantyLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWarrantyLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceWarranty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWarrantySingle AssetMaintenanceWarranty
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWarranty == null))
                {
                    this._AssetMaintenanceWarranty = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWarrantySingle(this.Context, GetPath("AssetMaintenanceWarranty"));
                }
                return this._AssetMaintenanceWarranty;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWarrantySingle _AssetMaintenanceWarranty;
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceWarrantyLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// WarrantyId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WarrantyId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceWarrantyLines")]
    public partial class AssetMaintenanceWarrantyLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceWarrantyLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="warrantyId">Initial value of WarrantyId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="percent">Initial value of Percent.</param>
        /// <param name="interval">Initial value of Interval.</param>
        /// <param name="assetMaintenanceWarranty">Initial value of AssetMaintenanceWarranty.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceWarrantyLine CreateAssetMaintenanceWarrantyLine(string dataAreaId, 
                    string warrantyId, 
                    decimal lineNumber, 
                    decimal percent, 
                    int interval, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWarranty assetMaintenanceWarranty)
        {
            AssetMaintenanceWarrantyLine assetMaintenanceWarrantyLine = new AssetMaintenanceWarrantyLine();
            assetMaintenanceWarrantyLine.dataAreaId = dataAreaId;
            assetMaintenanceWarrantyLine.WarrantyId = warrantyId;
            assetMaintenanceWarrantyLine.LineNumber = lineNumber;
            assetMaintenanceWarrantyLine.Percent = percent;
            assetMaintenanceWarrantyLine.Interval = interval;
            if ((assetMaintenanceWarranty == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceWarranty");
            }
            assetMaintenanceWarrantyLine.AssetMaintenanceWarranty = assetMaintenanceWarranty;
            return assetMaintenanceWarrantyLine;
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
        /// There are no comments for Property WarrantyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WarrantyId is required.")]
        public virtual string WarrantyId
        {
            get
            {
                return this._WarrantyId;
            }
            set
            {
                this.OnWarrantyIdChanging(value);
                this._WarrantyId = value;
                this.OnWarrantyIdChanged();
                this.OnPropertyChanged("WarrantyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WarrantyId;
        partial void OnWarrantyIdChanging(string value);
        partial void OnWarrantyIdChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNumber is required.")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property Percent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Percent is required.")]
        public virtual decimal Percent
        {
            get
            {
                return this._Percent;
            }
            set
            {
                this.OnPercentChanging(value);
                this._Percent = value;
                this.OnPercentChanged();
                this.OnPropertyChanged("Percent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Percent;
        partial void OnPercentChanging(decimal value);
        partial void OnPercentChanged();
        /// <summary>
        /// There are no comments for Property Interval in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Interval is required.")]
        public virtual int Interval
        {
            get
            {
                return this._Interval;
            }
            set
            {
                this.OnIntervalChanging(value);
                this._Interval = value;
                this.OnIntervalChanged();
                this.OnPropertyChanged("Interval");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Interval;
        partial void OnIntervalChanging(int value);
        partial void OnIntervalChanged();
        /// <summary>
        /// There are no comments for Property Period in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DayWeekMonthQuarterYear> Period
        {
            get
            {
                return this._Period;
            }
            set
            {
                this.OnPeriodChanging(value);
                this._Period = value;
                this.OnPeriodChanged();
                this.OnPropertyChanged("Period");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DayWeekMonthQuarterYear> _Period;
        partial void OnPeriodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DayWeekMonthQuarterYear> value);
        partial void OnPeriodChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWarranty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetMaintenanceWarranty is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWarranty AssetMaintenanceWarranty
        {
            get
            {
                return this._AssetMaintenanceWarranty;
            }
            set
            {
                this.OnAssetMaintenanceWarrantyChanging(value);
                this._AssetMaintenanceWarranty = value;
                this.OnAssetMaintenanceWarrantyChanged();
                this.OnPropertyChanged("AssetMaintenanceWarranty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWarranty _AssetMaintenanceWarranty;
        partial void OnAssetMaintenanceWarrantyChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWarranty value);
        partial void OnAssetMaintenanceWarrantyChanged();
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
