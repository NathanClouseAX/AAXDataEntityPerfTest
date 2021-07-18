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
        /// There are no comments for EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirementSingle in the schema.
        /// </summary>
    public partial class EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirementSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirement>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirementSingle object.
        /// </summary>
        public EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirementSingle object.
        /// </summary>
        public EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirementSingle object.
        /// </summary>
        public EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirementSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirement> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductRouteOperationProperties in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationPropertiesSingle EngineeringChangeOrderProductRouteOperationProperties
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProductRouteOperationProperties == null))
                {
                    this._EngineeringChangeOrderProductRouteOperationProperties = new global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationPropertiesSingle(this.Context, GetPath("EngineeringChangeOrderProductRouteOperationProperties"));
                }
                return this._EngineeringChangeOrderProductRouteOperationProperties;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationPropertiesSingle _EngineeringChangeOrderProductRouteOperationProperties;
    }
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirement in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// EngineeringChangeOrderNumber
    /// EngineeringChangeOrderProductLineNumber
    /// EngineeringChangeOrderProductRouteHeaderProductionSiteId
    /// EngineeringChangeOrderProductRouteOperationId
    /// EngineeringChangeOrderProductRouteOperationNumber
    /// EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId
    /// EngineeringChangeOrderProductRouteOperationPropertiesRouteId
    /// EngineeringChangeOrderProductRouteOperationPropertiesItemNumber
    /// EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId
    /// RouteOperationPropertiesResourceRequirementRecordId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "EngineeringChangeOrderNumber", "EngineeringChangeOrderProductLineNumber", "EngineeringChangeOrderProductRouteHeaderProductionSiteId", "EngineeringChangeOrderProductRouteOperationId", "EngineeringChangeOrderProductRouteOperationNumber", "EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId", "EngineeringChangeOrderProductRouteOperationPropertiesRouteId", "EngineeringChangeOrderProductRouteOperationPropertiesItemNumber", "EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId", "RouteOperationPropertiesResourceRequirementRecordId")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirements")]
    public partial class EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirement : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirement object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="engineeringChangeOrderNumber">Initial value of EngineeringChangeOrderNumber.</param>
        /// <param name="engineeringChangeOrderProductLineNumber">Initial value of EngineeringChangeOrderProductLineNumber.</param>
        /// <param name="engineeringChangeOrderProductRouteHeaderProductionSiteId">Initial value of EngineeringChangeOrderProductRouteHeaderProductionSiteId.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationId">Initial value of EngineeringChangeOrderProductRouteOperationId.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationNumber">Initial value of EngineeringChangeOrderProductRouteOperationNumber.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId">Initial value of EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationPropertiesRouteId">Initial value of EngineeringChangeOrderProductRouteOperationPropertiesRouteId.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationPropertiesItemNumber">Initial value of EngineeringChangeOrderProductRouteOperationPropertiesItemNumber.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationPropertiesProductGroupId">Initial value of EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId.</param>
        /// <param name="routeOperationPropertiesResourceRequirementRecordId">Initial value of RouteOperationPropertiesResourceRequirementRecordId.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationPropertiesRecordId">Initial value of EngineeringChangeOrderProductRouteOperationPropertiesRecordId.</param>
        /// <param name="engineeringChangeOrderProductRouteOperationProperties">Initial value of EngineeringChangeOrderProductRouteOperationProperties.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirement CreateEngineeringChangeOrderProductRouteOperationPropertiesResourceRequirement(string dataAreaId, 
                    string engineeringChangeOrderNumber, 
                    decimal engineeringChangeOrderProductLineNumber, 
                    string engineeringChangeOrderProductRouteHeaderProductionSiteId, 
                    string engineeringChangeOrderProductRouteOperationId, 
                    int engineeringChangeOrderProductRouteOperationNumber, 
                    string engineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId, 
                    string engineeringChangeOrderProductRouteOperationPropertiesRouteId, 
                    string engineeringChangeOrderProductRouteOperationPropertiesItemNumber, 
                    string engineeringChangeOrderProductRouteOperationPropertiesProductGroupId, 
                    long routeOperationPropertiesResourceRequirementRecordId, 
                    long engineeringChangeOrderProductRouteOperationPropertiesRecordId, 
                    global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationProperties engineeringChangeOrderProductRouteOperationProperties)
        {
            EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirement engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement = new EngineeringChangeOrderProductRouteOperationPropertiesResourceRequirement();
            engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement.dataAreaId = dataAreaId;
            engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement.EngineeringChangeOrderNumber = engineeringChangeOrderNumber;
            engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement.EngineeringChangeOrderProductLineNumber = engineeringChangeOrderProductLineNumber;
            engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement.EngineeringChangeOrderProductRouteHeaderProductionSiteId = engineeringChangeOrderProductRouteHeaderProductionSiteId;
            engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement.EngineeringChangeOrderProductRouteOperationId = engineeringChangeOrderProductRouteOperationId;
            engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement.EngineeringChangeOrderProductRouteOperationNumber = engineeringChangeOrderProductRouteOperationNumber;
            engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement.EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId = engineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId;
            engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement.EngineeringChangeOrderProductRouteOperationPropertiesRouteId = engineeringChangeOrderProductRouteOperationPropertiesRouteId;
            engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement.EngineeringChangeOrderProductRouteOperationPropertiesItemNumber = engineeringChangeOrderProductRouteOperationPropertiesItemNumber;
            engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement.EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId = engineeringChangeOrderProductRouteOperationPropertiesProductGroupId;
            engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement.RouteOperationPropertiesResourceRequirementRecordId = routeOperationPropertiesResourceRequirementRecordId;
            engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement.EngineeringChangeOrderProductRouteOperationPropertiesRecordId = engineeringChangeOrderProductRouteOperationPropertiesRecordId;
            if ((engineeringChangeOrderProductRouteOperationProperties == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangeOrderProductRouteOperationProperties");
            }
            engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement.EngineeringChangeOrderProductRouteOperationProperties = engineeringChangeOrderProductRouteOperationProperties;
            return engineeringChangeOrderProductRouteOperationPropertiesResourceRequirement;
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
        /// There are no comments for Property EngineeringChangeOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderNumber
        {
            get
            {
                return this._EngineeringChangeOrderNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderNumberChanging(value);
                this._EngineeringChangeOrderNumber = value;
                this.OnEngineeringChangeOrderNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderNumber;
        partial void OnEngineeringChangeOrderNumberChanging(string value);
        partial void OnEngineeringChangeOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal EngineeringChangeOrderProductLineNumber
        {
            get
            {
                return this._EngineeringChangeOrderProductLineNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderProductLineNumberChanging(value);
                this._EngineeringChangeOrderProductLineNumber = value;
                this.OnEngineeringChangeOrderProductLineNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _EngineeringChangeOrderProductLineNumber;
        partial void OnEngineeringChangeOrderProductLineNumberChanging(decimal value);
        partial void OnEngineeringChangeOrderProductLineNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteHeaderProductionSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderProductRouteHeaderProductionSiteId
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteHeaderProductionSiteId;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteHeaderProductionSiteIdChanging(value);
                this._EngineeringChangeOrderProductRouteHeaderProductionSiteId = value;
                this.OnEngineeringChangeOrderProductRouteHeaderProductionSiteIdChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteHeaderProductionSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderProductRouteHeaderProductionSiteId;
        partial void OnEngineeringChangeOrderProductRouteHeaderProductionSiteIdChanging(string value);
        partial void OnEngineeringChangeOrderProductRouteHeaderProductionSiteIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderProductRouteOperationId
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationId;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationIdChanging(value);
                this._EngineeringChangeOrderProductRouteOperationId = value;
                this.OnEngineeringChangeOrderProductRouteOperationIdChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderProductRouteOperationId;
        partial void OnEngineeringChangeOrderProductRouteOperationIdChanging(string value);
        partial void OnEngineeringChangeOrderProductRouteOperationIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int EngineeringChangeOrderProductRouteOperationNumber
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationNumberChanging(value);
                this._EngineeringChangeOrderProductRouteOperationNumber = value;
                this.OnEngineeringChangeOrderProductRouteOperationNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _EngineeringChangeOrderProductRouteOperationNumber;
        partial void OnEngineeringChangeOrderProductRouteOperationNumberChanging(int value);
        partial void OnEngineeringChangeOrderProductRouteOperationNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationIdChanging(value);
                this._EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId = value;
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationIdChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationId;
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationIdChanging(string value);
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesProductConfigurationIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationPropertiesRouteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderProductRouteOperationPropertiesRouteId
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationPropertiesRouteId;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesRouteIdChanging(value);
                this._EngineeringChangeOrderProductRouteOperationPropertiesRouteId = value;
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesRouteIdChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationPropertiesRouteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderProductRouteOperationPropertiesRouteId;
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesRouteIdChanging(string value);
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesRouteIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationPropertiesItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderProductRouteOperationPropertiesItemNumber
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationPropertiesItemNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesItemNumberChanging(value);
                this._EngineeringChangeOrderProductRouteOperationPropertiesItemNumber = value;
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesItemNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationPropertiesItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderProductRouteOperationPropertiesItemNumber;
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesItemNumberChanging(string value);
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesItemNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesProductGroupIdChanging(value);
                this._EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId = value;
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesProductGroupIdChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderProductRouteOperationPropertiesProductGroupId;
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesProductGroupIdChanging(string value);
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesProductGroupIdChanged();
        /// <summary>
        /// There are no comments for Property RouteOperationPropertiesResourceRequirementRecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long RouteOperationPropertiesResourceRequirementRecordId
        {
            get
            {
                return this._RouteOperationPropertiesResourceRequirementRecordId;
            }
            set
            {
                this.OnRouteOperationPropertiesResourceRequirementRecordIdChanging(value);
                this._RouteOperationPropertiesResourceRequirementRecordId = value;
                this.OnRouteOperationPropertiesResourceRequirementRecordIdChanged();
                this.OnPropertyChanged("RouteOperationPropertiesResourceRequirementRecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _RouteOperationPropertiesResourceRequirementRecordId;
        partial void OnRouteOperationPropertiesResourceRequirementRecordIdChanging(long value);
        partial void OnRouteOperationPropertiesResourceRequirementRecordIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationPropertiesRecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long EngineeringChangeOrderProductRouteOperationPropertiesRecordId
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationPropertiesRecordId;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesRecordIdChanging(value);
                this._EngineeringChangeOrderProductRouteOperationPropertiesRecordId = value;
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesRecordIdChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationPropertiesRecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _EngineeringChangeOrderProductRouteOperationPropertiesRecordId;
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesRecordIdChanging(long value);
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesRecordIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperationProperties in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationProperties EngineeringChangeOrderProductRouteOperationProperties
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperationProperties;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesChanging(value);
                this._EngineeringChangeOrderProductRouteOperationProperties = value;
                this.OnEngineeringChangeOrderProductRouteOperationPropertiesChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperationProperties");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationProperties _EngineeringChangeOrderProductRouteOperationProperties;
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesChanging(global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperationProperties value);
        partial void OnEngineeringChangeOrderProductRouteOperationPropertiesChanged();
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
