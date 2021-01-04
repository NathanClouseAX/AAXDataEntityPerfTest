﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/3/2021 8:21:45 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for PhysicalProductDimensionDetailsSingle in the schema.
        /// </summary>
    public partial class PhysicalProductDimensionDetailsSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PhysicalProductDimensionDetails>
    {
        /// <summary>
        /// Initialize a new PhysicalProductDimensionDetailsSingle object.
        /// </summary>
        public PhysicalProductDimensionDetailsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PhysicalProductDimensionDetailsSingle object.
        /// </summary>
        public PhysicalProductDimensionDetailsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PhysicalProductDimensionDetailsSingle object.
        /// </summary>
        public PhysicalProductDimensionDetailsSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PhysicalProductDimensionDetails> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductV2Single ProductV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductV2 == null))
                {
                    this._ProductV2 = new global::Microsoft.Dynamics.DataEntities.ProductV2Single(this.Context, GetPath("ProductV2"));
                }
                return this._ProductV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductV2Single _ProductV2;
        /// <summary>
        /// There are no comments for PhysicalUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle PhysicalUnitOfMeasure
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PhysicalUnitOfMeasure == null))
                {
                    this._PhysicalUnitOfMeasure = new global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle(this.Context, GetPath("PhysicalUnitOfMeasure"));
                }
                return this._PhysicalUnitOfMeasure;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle _PhysicalUnitOfMeasure;
        /// <summary>
        /// There are no comments for VolumeUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle VolumeUnitOfMeasure
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VolumeUnitOfMeasure == null))
                {
                    this._VolumeUnitOfMeasure = new global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle(this.Context, GetPath("VolumeUnitOfMeasure"));
                }
                return this._VolumeUnitOfMeasure;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle _VolumeUnitOfMeasure;
        /// <summary>
        /// There are no comments for MassDefinedUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle MassDefinedUnitOfMeasure
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._MassDefinedUnitOfMeasure == null))
                {
                    this._MassDefinedUnitOfMeasure = new global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle(this.Context, GetPath("MassDefinedUnitOfMeasure"));
                }
                return this._MassDefinedUnitOfMeasure;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle _MassDefinedUnitOfMeasure;
        /// <summary>
        /// There are no comments for LengthUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle LengthUnitOfMeasure
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LengthUnitOfMeasure == null))
                {
                    this._LengthUnitOfMeasure = new global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle(this.Context, GetPath("LengthUnitOfMeasure"));
                }
                return this._LengthUnitOfMeasure;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle _LengthUnitOfMeasure;
    }
        /// <summary>
        /// There are no comments for PhysicalProductDimensionDetails in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ProductNumber
    /// DimensionType
    /// PhysicalUnitSymbol
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductNumber", "DimensionType", "PhysicalUnitSymbol")]
    [global::Microsoft.OData.Client.EntitySet("PhysicalProductDimensionDetails")]
    public partial class PhysicalProductDimensionDetails : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PhysicalProductDimensionDetails object.
        /// </summary>
        /// <param name="productNumber">Initial value of ProductNumber.</param>
        /// <param name="physicalUnitSymbol">Initial value of PhysicalUnitSymbol.</param>
        /// <param name="physicalDepth">Initial value of PhysicalDepth.</param>
        /// <param name="physicalWidth">Initial value of PhysicalWidth.</param>
        /// <param name="physicalWeight">Initial value of PhysicalWeight.</param>
        /// <param name="physicalHeight">Initial value of PhysicalHeight.</param>
        /// <param name="productV2">Initial value of ProductV2.</param>
        /// <param name="physicalUnitOfMeasure">Initial value of PhysicalUnitOfMeasure.</param>
        /// <param name="volumeUnitOfMeasure">Initial value of VolumeUnitOfMeasure.</param>
        /// <param name="massDefinedUnitOfMeasure">Initial value of MassDefinedUnitOfMeasure.</param>
        /// <param name="lengthUnitOfMeasure">Initial value of LengthUnitOfMeasure.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PhysicalProductDimensionDetails CreatePhysicalProductDimensionDetails(string productNumber, 
                    string physicalUnitSymbol, 
                    decimal physicalDepth, 
                    decimal physicalWidth, 
                    decimal physicalWeight, 
                    decimal physicalHeight, 
                    global::Microsoft.Dynamics.DataEntities.ProductV2 productV2, 
                    global::Microsoft.Dynamics.DataEntities.UnitOfMeasure physicalUnitOfMeasure, 
                    global::Microsoft.Dynamics.DataEntities.UnitOfMeasure volumeUnitOfMeasure, 
                    global::Microsoft.Dynamics.DataEntities.UnitOfMeasure massDefinedUnitOfMeasure, 
                    global::Microsoft.Dynamics.DataEntities.UnitOfMeasure lengthUnitOfMeasure)
        {
            PhysicalProductDimensionDetails physicalProductDimensionDetails = new PhysicalProductDimensionDetails();
            physicalProductDimensionDetails.ProductNumber = productNumber;
            physicalProductDimensionDetails.PhysicalUnitSymbol = physicalUnitSymbol;
            physicalProductDimensionDetails.PhysicalDepth = physicalDepth;
            physicalProductDimensionDetails.PhysicalWidth = physicalWidth;
            physicalProductDimensionDetails.PhysicalWeight = physicalWeight;
            physicalProductDimensionDetails.PhysicalHeight = physicalHeight;
            if ((productV2 == null))
            {
                throw new global::System.ArgumentNullException("productV2");
            }
            physicalProductDimensionDetails.ProductV2 = productV2;
            if ((physicalUnitOfMeasure == null))
            {
                throw new global::System.ArgumentNullException("physicalUnitOfMeasure");
            }
            physicalProductDimensionDetails.PhysicalUnitOfMeasure = physicalUnitOfMeasure;
            if ((volumeUnitOfMeasure == null))
            {
                throw new global::System.ArgumentNullException("volumeUnitOfMeasure");
            }
            physicalProductDimensionDetails.VolumeUnitOfMeasure = volumeUnitOfMeasure;
            if ((massDefinedUnitOfMeasure == null))
            {
                throw new global::System.ArgumentNullException("massDefinedUnitOfMeasure");
            }
            physicalProductDimensionDetails.MassDefinedUnitOfMeasure = massDefinedUnitOfMeasure;
            if ((lengthUnitOfMeasure == null))
            {
                throw new global::System.ArgumentNullException("lengthUnitOfMeasure");
            }
            physicalProductDimensionDetails.LengthUnitOfMeasure = lengthUnitOfMeasure;
            return physicalProductDimensionDetails;
        }
        /// <summary>
        /// There are no comments for Property ProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductNumber
        {
            get
            {
                return this._ProductNumber;
            }
            set
            {
                this.OnProductNumberChanging(value);
                this._ProductNumber = value;
                this.OnProductNumberChanged();
                this.OnPropertyChanged("ProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductNumber;
        partial void OnProductNumberChanging(string value);
        partial void OnProductNumberChanged();
        /// <summary>
        /// There are no comments for Property DimensionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResPhysicalDimensionType> DimensionType
        {
            get
            {
                return this._DimensionType;
            }
            set
            {
                this.OnDimensionTypeChanging(value);
                this._DimensionType = value;
                this.OnDimensionTypeChanged();
                this.OnPropertyChanged("DimensionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResPhysicalDimensionType> _DimensionType;
        partial void OnDimensionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResPhysicalDimensionType> value);
        partial void OnDimensionTypeChanged();
        /// <summary>
        /// There are no comments for Property PhysicalUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PhysicalUnitSymbol
        {
            get
            {
                return this._PhysicalUnitSymbol;
            }
            set
            {
                this.OnPhysicalUnitSymbolChanging(value);
                this._PhysicalUnitSymbol = value;
                this.OnPhysicalUnitSymbolChanged();
                this.OnPropertyChanged("PhysicalUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PhysicalUnitSymbol;
        partial void OnPhysicalUnitSymbolChanging(string value);
        partial void OnPhysicalUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property MassUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MassUnitSymbol
        {
            get
            {
                return this._MassUnitSymbol;
            }
            set
            {
                this.OnMassUnitSymbolChanging(value);
                this._MassUnitSymbol = value;
                this.OnMassUnitSymbolChanged();
                this.OnPropertyChanged("MassUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MassUnitSymbol;
        partial void OnMassUnitSymbolChanging(string value);
        partial void OnMassUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property PhysicalDepth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PhysicalDepth
        {
            get
            {
                return this._PhysicalDepth;
            }
            set
            {
                this.OnPhysicalDepthChanging(value);
                this._PhysicalDepth = value;
                this.OnPhysicalDepthChanged();
                this.OnPropertyChanged("PhysicalDepth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PhysicalDepth;
        partial void OnPhysicalDepthChanging(decimal value);
        partial void OnPhysicalDepthChanged();
        /// <summary>
        /// There are no comments for Property VolumeUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VolumeUnitSymbol
        {
            get
            {
                return this._VolumeUnitSymbol;
            }
            set
            {
                this.OnVolumeUnitSymbolChanging(value);
                this._VolumeUnitSymbol = value;
                this.OnVolumeUnitSymbolChanged();
                this.OnPropertyChanged("VolumeUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VolumeUnitSymbol;
        partial void OnVolumeUnitSymbolChanging(string value);
        partial void OnVolumeUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property PhysicalWidth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PhysicalWidth
        {
            get
            {
                return this._PhysicalWidth;
            }
            set
            {
                this.OnPhysicalWidthChanging(value);
                this._PhysicalWidth = value;
                this.OnPhysicalWidthChanged();
                this.OnPropertyChanged("PhysicalWidth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PhysicalWidth;
        partial void OnPhysicalWidthChanging(decimal value);
        partial void OnPhysicalWidthChanged();
        /// <summary>
        /// There are no comments for Property PhysicalWeight in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PhysicalWeight
        {
            get
            {
                return this._PhysicalWeight;
            }
            set
            {
                this.OnPhysicalWeightChanging(value);
                this._PhysicalWeight = value;
                this.OnPhysicalWeightChanged();
                this.OnPropertyChanged("PhysicalWeight");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PhysicalWeight;
        partial void OnPhysicalWeightChanging(decimal value);
        partial void OnPhysicalWeightChanged();
        /// <summary>
        /// There are no comments for Property LengthUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LengthUnitSymbol
        {
            get
            {
                return this._LengthUnitSymbol;
            }
            set
            {
                this.OnLengthUnitSymbolChanging(value);
                this._LengthUnitSymbol = value;
                this.OnLengthUnitSymbolChanged();
                this.OnPropertyChanged("LengthUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LengthUnitSymbol;
        partial void OnLengthUnitSymbolChanging(string value);
        partial void OnLengthUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property PhysicalHeight in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PhysicalHeight
        {
            get
            {
                return this._PhysicalHeight;
            }
            set
            {
                this.OnPhysicalHeightChanging(value);
                this._PhysicalHeight = value;
                this.OnPhysicalHeightChanged();
                this.OnPropertyChanged("PhysicalHeight");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PhysicalHeight;
        partial void OnPhysicalHeightChanging(decimal value);
        partial void OnPhysicalHeightChanged();
        /// <summary>
        /// There are no comments for Property ProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductV2 ProductV2
        {
            get
            {
                return this._ProductV2;
            }
            set
            {
                this.OnProductV2Changing(value);
                this._ProductV2 = value;
                this.OnProductV2Changed();
                this.OnPropertyChanged("ProductV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductV2 _ProductV2;
        partial void OnProductV2Changing(global::Microsoft.Dynamics.DataEntities.ProductV2 value);
        partial void OnProductV2Changed();
        /// <summary>
        /// There are no comments for Property PhysicalUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasure PhysicalUnitOfMeasure
        {
            get
            {
                return this._PhysicalUnitOfMeasure;
            }
            set
            {
                this.OnPhysicalUnitOfMeasureChanging(value);
                this._PhysicalUnitOfMeasure = value;
                this.OnPhysicalUnitOfMeasureChanged();
                this.OnPropertyChanged("PhysicalUnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasure _PhysicalUnitOfMeasure;
        partial void OnPhysicalUnitOfMeasureChanging(global::Microsoft.Dynamics.DataEntities.UnitOfMeasure value);
        partial void OnPhysicalUnitOfMeasureChanged();
        /// <summary>
        /// There are no comments for Property VolumeUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasure VolumeUnitOfMeasure
        {
            get
            {
                return this._VolumeUnitOfMeasure;
            }
            set
            {
                this.OnVolumeUnitOfMeasureChanging(value);
                this._VolumeUnitOfMeasure = value;
                this.OnVolumeUnitOfMeasureChanged();
                this.OnPropertyChanged("VolumeUnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasure _VolumeUnitOfMeasure;
        partial void OnVolumeUnitOfMeasureChanging(global::Microsoft.Dynamics.DataEntities.UnitOfMeasure value);
        partial void OnVolumeUnitOfMeasureChanged();
        /// <summary>
        /// There are no comments for Property MassDefinedUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasure MassDefinedUnitOfMeasure
        {
            get
            {
                return this._MassDefinedUnitOfMeasure;
            }
            set
            {
                this.OnMassDefinedUnitOfMeasureChanging(value);
                this._MassDefinedUnitOfMeasure = value;
                this.OnMassDefinedUnitOfMeasureChanged();
                this.OnPropertyChanged("MassDefinedUnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasure _MassDefinedUnitOfMeasure;
        partial void OnMassDefinedUnitOfMeasureChanging(global::Microsoft.Dynamics.DataEntities.UnitOfMeasure value);
        partial void OnMassDefinedUnitOfMeasureChanged();
        /// <summary>
        /// There are no comments for Property LengthUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasure LengthUnitOfMeasure
        {
            get
            {
                return this._LengthUnitOfMeasure;
            }
            set
            {
                this.OnLengthUnitOfMeasureChanging(value);
                this._LengthUnitOfMeasure = value;
                this.OnLengthUnitOfMeasureChanged();
                this.OnPropertyChanged("LengthUnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasure _LengthUnitOfMeasure;
        partial void OnLengthUnitOfMeasureChanging(global::Microsoft.Dynamics.DataEntities.UnitOfMeasure value);
        partial void OnLengthUnitOfMeasureChanged();
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
