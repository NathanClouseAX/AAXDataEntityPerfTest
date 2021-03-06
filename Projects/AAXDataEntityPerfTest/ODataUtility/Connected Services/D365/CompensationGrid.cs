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
        /// There are no comments for CompensationGridSingle in the schema.
        /// </summary>
    public partial class CompensationGridSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationGrid>
    {
        /// <summary>
        /// Initialize a new CompensationGridSingle object.
        /// </summary>
        public CompensationGridSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CompensationGridSingle object.
        /// </summary>
        public CompensationGridSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CompensationGridSingle object.
        /// </summary>
        public CompensationGridSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationGrid> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CompFixedPlanTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable> CompFixedPlanTable
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompFixedPlanTable == null))
                {
                    this._CompFixedPlanTable = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable>(GetPath("CompFixedPlanTable"));
                }
                return this._CompFixedPlanTable;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable> _CompFixedPlanTable;
        /// <summary>
        /// There are no comments for CompensationReferencePoint in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSingle CompensationReferencePoint
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationReferencePoint == null))
                {
                    this._CompensationReferencePoint = new global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSingle(this.Context, GetPath("CompensationReferencePoint"));
                }
                return this._CompensationReferencePoint;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSingle _CompensationReferencePoint;
        /// <summary>
        /// There are no comments for CompensationStructures in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationStructure> CompensationStructures
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationStructures == null))
                {
                    this._CompensationStructures = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompensationStructure>(GetPath("CompensationStructures"));
                }
                return this._CompensationStructures;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationStructure> _CompensationStructures;
    }
        /// <summary>
        /// There are no comments for CompensationGrid in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// GridId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GridId")]
    [global::Microsoft.OData.Client.EntitySet("CompensationGrids")]
    public partial class CompensationGrid : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CompensationGrid object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="gridId">Initial value of GridId.</param>
        /// <param name="expirationDate">Initial value of ExpirationDate.</param>
        /// <param name="effectiveDate">Initial value of EffectiveDate.</param>
        /// <param name="compensationReferencePoint">Initial value of CompensationReferencePoint.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CompensationGrid CreateCompensationGrid(string dataAreaId, string gridId, global::System.DateTimeOffset expirationDate, global::System.DateTimeOffset effectiveDate, global::Microsoft.Dynamics.DataEntities.CompensationReferencePoint compensationReferencePoint)
        {
            CompensationGrid compensationGrid = new CompensationGrid();
            compensationGrid.dataAreaId = dataAreaId;
            compensationGrid.GridId = gridId;
            compensationGrid.ExpirationDate = expirationDate;
            compensationGrid.EffectiveDate = effectiveDate;
            if ((compensationReferencePoint == null))
            {
                throw new global::System.ArgumentNullException("compensationReferencePoint");
            }
            compensationGrid.CompensationReferencePoint = compensationReferencePoint;
            return compensationGrid;
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
        /// There are no comments for Property GridId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GridId
        {
            get
            {
                return this._GridId;
            }
            set
            {
                this.OnGridIdChanging(value);
                this._GridId = value;
                this.OnGridIdChanged();
                this.OnPropertyChanged("GridId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GridId;
        partial void OnGridIdChanging(string value);
        partial void OnGridIdChanged();
        /// <summary>
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this.OnCurrencyChanging(value);
                this._Currency = value;
                this.OnCurrencyChanged();
                this.OnPropertyChanged("Currency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Currency;
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
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
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmCompensationType> Type
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmCompensationType> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmCompensationType> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property ReferenceSetup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReferenceSetup
        {
            get
            {
                return this._ReferenceSetup;
            }
            set
            {
                this.OnReferenceSetupChanging(value);
                this._ReferenceSetup = value;
                this.OnReferenceSetupChanged();
                this.OnPropertyChanged("ReferenceSetup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReferenceSetup;
        partial void OnReferenceSetupChanging(string value);
        partial void OnReferenceSetupChanged();
        /// <summary>
        /// There are no comments for Property ExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ExpirationDate
        {
            get
            {
                return this._ExpirationDate;
            }
            set
            {
                this.OnExpirationDateChanging(value);
                this._ExpirationDate = value;
                this.OnExpirationDateChanged();
                this.OnPropertyChanged("ExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ExpirationDate;
        partial void OnExpirationDateChanging(global::System.DateTimeOffset value);
        partial void OnExpirationDateChanged();
        /// <summary>
        /// There are no comments for Property EffectiveDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EffectiveDate
        {
            get
            {
                return this._EffectiveDate;
            }
            set
            {
                this.OnEffectiveDateChanging(value);
                this._EffectiveDate = value;
                this.OnEffectiveDateChanged();
                this.OnPropertyChanged("EffectiveDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EffectiveDate;
        partial void OnEffectiveDateChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveDateChanged();
        /// <summary>
        /// There are no comments for Property CompFixedPlanTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable> CompFixedPlanTable
        {
            get
            {
                return this._CompFixedPlanTable;
            }
            set
            {
                this.OnCompFixedPlanTableChanging(value);
                this._CompFixedPlanTable = value;
                this.OnCompFixedPlanTableChanged();
                this.OnPropertyChanged("CompFixedPlanTable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable> _CompFixedPlanTable = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompFixedPlanTableChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable> value);
        partial void OnCompFixedPlanTableChanged();
        /// <summary>
        /// There are no comments for Property CompensationReferencePoint in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationReferencePoint CompensationReferencePoint
        {
            get
            {
                return this._CompensationReferencePoint;
            }
            set
            {
                this.OnCompensationReferencePointChanging(value);
                this._CompensationReferencePoint = value;
                this.OnCompensationReferencePointChanged();
                this.OnPropertyChanged("CompensationReferencePoint");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationReferencePoint _CompensationReferencePoint;
        partial void OnCompensationReferencePointChanging(global::Microsoft.Dynamics.DataEntities.CompensationReferencePoint value);
        partial void OnCompensationReferencePointChanged();
        /// <summary>
        /// There are no comments for Property CompensationStructures in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationStructure> CompensationStructures
        {
            get
            {
                return this._CompensationStructures;
            }
            set
            {
                this.OnCompensationStructuresChanging(value);
                this._CompensationStructures = value;
                this.OnCompensationStructuresChanged();
                this.OnPropertyChanged("CompensationStructures");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationStructure> _CompensationStructures = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationStructure>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompensationStructuresChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationStructure> value);
        partial void OnCompensationStructuresChanged();
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
