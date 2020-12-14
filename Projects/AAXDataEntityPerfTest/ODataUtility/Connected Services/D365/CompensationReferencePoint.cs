﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 12/8/2020 7:45:22 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for CompensationReferencePointSingle in the schema.
        /// </summary>
    public partial class CompensationReferencePointSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationReferencePoint>
    {
        /// <summary>
        /// Initialize a new CompensationReferencePointSingle object.
        /// </summary>
        public CompensationReferencePointSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CompensationReferencePointSingle object.
        /// </summary>
        public CompensationReferencePointSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CompensationReferencePointSingle object.
        /// </summary>
        public CompensationReferencePointSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationReferencePoint> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CompensationReferencePointSetupLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSetupLine> CompensationReferencePointSetupLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationReferencePointSetupLine == null))
                {
                    this._CompensationReferencePointSetupLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSetupLine>(GetPath("CompensationReferencePointSetupLine"));
                }
                return this._CompensationReferencePointSetupLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSetupLine> _CompensationReferencePointSetupLine;
        /// <summary>
        /// There are no comments for CompensationGrid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationGrid> CompensationGrid
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationGrid == null))
                {
                    this._CompensationGrid = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompensationGrid>(GetPath("CompensationGrid"));
                }
                return this._CompensationGrid;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationGrid> _CompensationGrid;
    }
        /// <summary>
        /// There are no comments for CompensationReferencePoint in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ReferenceSetup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ReferenceSetup")]
    [global::Microsoft.OData.Client.EntitySet("CompensationReferencePoints")]
    public partial class CompensationReferencePoint : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CompensationReferencePoint object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="referenceSetup">Initial value of ReferenceSetup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CompensationReferencePoint CreateCompensationReferencePoint(string dataAreaId, string referenceSetup)
        {
            CompensationReferencePoint compensationReferencePoint = new CompensationReferencePoint();
            compensationReferencePoint.dataAreaId = dataAreaId;
            compensationReferencePoint.ReferenceSetup = referenceSetup;
            return compensationReferencePoint;
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
        /// There are no comments for Property CompensationReferencePointSetupLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSetupLine> CompensationReferencePointSetupLine
        {
            get
            {
                return this._CompensationReferencePointSetupLine;
            }
            set
            {
                this.OnCompensationReferencePointSetupLineChanging(value);
                this._CompensationReferencePointSetupLine = value;
                this.OnCompensationReferencePointSetupLineChanged();
                this.OnPropertyChanged("CompensationReferencePointSetupLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSetupLine> _CompensationReferencePointSetupLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSetupLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompensationReferencePointSetupLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSetupLine> value);
        partial void OnCompensationReferencePointSetupLineChanged();
        /// <summary>
        /// There are no comments for Property CompensationGrid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationGrid> CompensationGrid
        {
            get
            {
                return this._CompensationGrid;
            }
            set
            {
                this.OnCompensationGridChanging(value);
                this._CompensationGrid = value;
                this.OnCompensationGridChanged();
                this.OnPropertyChanged("CompensationGrid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationGrid> _CompensationGrid = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationGrid>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompensationGridChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationGrid> value);
        partial void OnCompensationGridChanged();
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
