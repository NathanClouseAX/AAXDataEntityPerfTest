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
        /// There are no comments for WarehouseReplenishmentTemplateUnitOfMeasureRestrictionSingle in the schema.
        /// </summary>
    public partial class WarehouseReplenishmentTemplateUnitOfMeasureRestrictionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseReplenishmentTemplateUnitOfMeasureRestriction>
    {
        /// <summary>
        /// Initialize a new WarehouseReplenishmentTemplateUnitOfMeasureRestrictionSingle object.
        /// </summary>
        public WarehouseReplenishmentTemplateUnitOfMeasureRestrictionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WarehouseReplenishmentTemplateUnitOfMeasureRestrictionSingle object.
        /// </summary>
        public WarehouseReplenishmentTemplateUnitOfMeasureRestrictionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WarehouseReplenishmentTemplateUnitOfMeasureRestrictionSingle object.
        /// </summary>
        public WarehouseReplenishmentTemplateUnitOfMeasureRestrictionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseReplenishmentTemplateUnitOfMeasureRestriction> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WarehouseReplenishmentTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WarehouseReplenishmentTemplateSingle WarehouseReplenishmentTemplate
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WarehouseReplenishmentTemplate == null))
                {
                    this._WarehouseReplenishmentTemplate = new global::Microsoft.Dynamics.DataEntities.WarehouseReplenishmentTemplateSingle(this.Context, GetPath("WarehouseReplenishmentTemplate"));
                }
                return this._WarehouseReplenishmentTemplate;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WarehouseReplenishmentTemplateSingle _WarehouseReplenishmentTemplate;
        /// <summary>
        /// There are no comments for UnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle UnitOfMeasure
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._UnitOfMeasure == null))
                {
                    this._UnitOfMeasure = new global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle(this.Context, GetPath("UnitOfMeasure"));
                }
                return this._UnitOfMeasure;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle _UnitOfMeasure;
    }
        /// <summary>
        /// There are no comments for WarehouseReplenishmentTemplateUnitOfMeasureRestriction in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// WarehouseReplenishmentTemplateId
    /// RestrictionUnitSymbol
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WarehouseReplenishmentTemplateId", "RestrictionUnitSymbol")]
    [global::Microsoft.OData.Client.EntitySet("WarehouseReplenishmentTemplateUnitOfMeasureRestrictions")]
    public partial class WarehouseReplenishmentTemplateUnitOfMeasureRestriction : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WarehouseReplenishmentTemplateUnitOfMeasureRestriction object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="warehouseReplenishmentTemplateId">Initial value of WarehouseReplenishmentTemplateId.</param>
        /// <param name="restrictionUnitSymbol">Initial value of RestrictionUnitSymbol.</param>
        /// <param name="warehouseReplenishmentTemplate">Initial value of WarehouseReplenishmentTemplate.</param>
        /// <param name="unitOfMeasure">Initial value of UnitOfMeasure.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WarehouseReplenishmentTemplateUnitOfMeasureRestriction CreateWarehouseReplenishmentTemplateUnitOfMeasureRestriction(string dataAreaId, string warehouseReplenishmentTemplateId, string restrictionUnitSymbol, global::Microsoft.Dynamics.DataEntities.WarehouseReplenishmentTemplate warehouseReplenishmentTemplate, global::Microsoft.Dynamics.DataEntities.UnitOfMeasure unitOfMeasure)
        {
            WarehouseReplenishmentTemplateUnitOfMeasureRestriction warehouseReplenishmentTemplateUnitOfMeasureRestriction = new WarehouseReplenishmentTemplateUnitOfMeasureRestriction();
            warehouseReplenishmentTemplateUnitOfMeasureRestriction.dataAreaId = dataAreaId;
            warehouseReplenishmentTemplateUnitOfMeasureRestriction.WarehouseReplenishmentTemplateId = warehouseReplenishmentTemplateId;
            warehouseReplenishmentTemplateUnitOfMeasureRestriction.RestrictionUnitSymbol = restrictionUnitSymbol;
            if ((warehouseReplenishmentTemplate == null))
            {
                throw new global::System.ArgumentNullException("warehouseReplenishmentTemplate");
            }
            warehouseReplenishmentTemplateUnitOfMeasureRestriction.WarehouseReplenishmentTemplate = warehouseReplenishmentTemplate;
            if ((unitOfMeasure == null))
            {
                throw new global::System.ArgumentNullException("unitOfMeasure");
            }
            warehouseReplenishmentTemplateUnitOfMeasureRestriction.UnitOfMeasure = unitOfMeasure;
            return warehouseReplenishmentTemplateUnitOfMeasureRestriction;
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
        /// There are no comments for Property WarehouseReplenishmentTemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WarehouseReplenishmentTemplateId
        {
            get
            {
                return this._WarehouseReplenishmentTemplateId;
            }
            set
            {
                this.OnWarehouseReplenishmentTemplateIdChanging(value);
                this._WarehouseReplenishmentTemplateId = value;
                this.OnWarehouseReplenishmentTemplateIdChanged();
                this.OnPropertyChanged("WarehouseReplenishmentTemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WarehouseReplenishmentTemplateId;
        partial void OnWarehouseReplenishmentTemplateIdChanging(string value);
        partial void OnWarehouseReplenishmentTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property RestrictionUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RestrictionUnitSymbol
        {
            get
            {
                return this._RestrictionUnitSymbol;
            }
            set
            {
                this.OnRestrictionUnitSymbolChanging(value);
                this._RestrictionUnitSymbol = value;
                this.OnRestrictionUnitSymbolChanged();
                this.OnPropertyChanged("RestrictionUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RestrictionUnitSymbol;
        partial void OnRestrictionUnitSymbolChanging(string value);
        partial void OnRestrictionUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property WarehouseReplenishmentTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WarehouseReplenishmentTemplate WarehouseReplenishmentTemplate
        {
            get
            {
                return this._WarehouseReplenishmentTemplate;
            }
            set
            {
                this.OnWarehouseReplenishmentTemplateChanging(value);
                this._WarehouseReplenishmentTemplate = value;
                this.OnWarehouseReplenishmentTemplateChanged();
                this.OnPropertyChanged("WarehouseReplenishmentTemplate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WarehouseReplenishmentTemplate _WarehouseReplenishmentTemplate;
        partial void OnWarehouseReplenishmentTemplateChanging(global::Microsoft.Dynamics.DataEntities.WarehouseReplenishmentTemplate value);
        partial void OnWarehouseReplenishmentTemplateChanged();
        /// <summary>
        /// There are no comments for Property UnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasure UnitOfMeasure
        {
            get
            {
                return this._UnitOfMeasure;
            }
            set
            {
                this.OnUnitOfMeasureChanging(value);
                this._UnitOfMeasure = value;
                this.OnUnitOfMeasureChanged();
                this.OnPropertyChanged("UnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasure _UnitOfMeasure;
        partial void OnUnitOfMeasureChanging(global::Microsoft.Dynamics.DataEntities.UnitOfMeasure value);
        partial void OnUnitOfMeasureChanged();
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