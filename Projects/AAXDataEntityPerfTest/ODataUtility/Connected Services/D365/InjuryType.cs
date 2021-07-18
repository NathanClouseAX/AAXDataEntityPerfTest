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
        /// There are no comments for InjuryTypeSingle in the schema.
        /// </summary>
    public partial class InjuryTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<InjuryType>
    {
        /// <summary>
        /// Initialize a new InjuryTypeSingle object.
        /// </summary>
        public InjuryTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InjuryTypeSingle object.
        /// </summary>
        public InjuryTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InjuryTypeSingle object.
        /// </summary>
        public InjuryTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<InjuryType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for InjuryIncidents in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.InjuryIncident> InjuryIncidents
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._InjuryIncidents == null))
                {
                    this._InjuryIncidents = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.InjuryIncident>(GetPath("InjuryIncidents"));
                }
                return this._InjuryIncidents;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.InjuryIncident> _InjuryIncidents;
    }
        /// <summary>
        /// There are no comments for InjuryType in the schema.
        /// </summary>
    /// <KeyProperties>
    /// InjuryTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("InjuryTypeId")]
    [global::Microsoft.OData.Client.EntitySet("InjuryTypes")]
    public partial class InjuryType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new InjuryType object.
        /// </summary>
        /// <param name="injuryTypeId">Initial value of InjuryTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static InjuryType CreateInjuryType(string injuryTypeId)
        {
            InjuryType injuryType = new InjuryType();
            injuryType.InjuryTypeId = injuryTypeId;
            return injuryType;
        }
        /// <summary>
        /// There are no comments for Property InjuryTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InjuryTypeId
        {
            get
            {
                return this._InjuryTypeId;
            }
            set
            {
                this.OnInjuryTypeIdChanging(value);
                this._InjuryTypeId = value;
                this.OnInjuryTypeIdChanged();
                this.OnPropertyChanged("InjuryTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InjuryTypeId;
        partial void OnInjuryTypeIdChanging(string value);
        partial void OnInjuryTypeIdChanged();
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
        /// There are no comments for Property InjuryIncidents in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InjuryIncident> InjuryIncidents
        {
            get
            {
                return this._InjuryIncidents;
            }
            set
            {
                this.OnInjuryIncidentsChanging(value);
                this._InjuryIncidents = value;
                this.OnInjuryIncidentsChanged();
                this.OnPropertyChanged("InjuryIncidents");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InjuryIncident> _InjuryIncidents = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InjuryIncident>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnInjuryIncidentsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InjuryIncident> value);
        partial void OnInjuryIncidentsChanged();
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
