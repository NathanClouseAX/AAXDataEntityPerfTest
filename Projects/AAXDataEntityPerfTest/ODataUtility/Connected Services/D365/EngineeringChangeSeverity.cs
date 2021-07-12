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
        /// There are no comments for EngineeringChangeSeveritySingle in the schema.
        /// </summary>
    public partial class EngineeringChangeSeveritySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeSeverity>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeSeveritySingle object.
        /// </summary>
        public EngineeringChangeSeveritySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeSeveritySingle object.
        /// </summary>
        public EngineeringChangeSeveritySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeSeveritySingle object.
        /// </summary>
        public EngineeringChangeSeveritySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeSeverity> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringChangeOrderHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderHeader> EngineeringChangeOrderHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderHeaders == null))
                {
                    this._EngineeringChangeOrderHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderHeader>(GetPath("EngineeringChangeOrderHeaders"));
                }
                return this._EngineeringChangeOrderHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderHeader> _EngineeringChangeOrderHeaders;
        /// <summary>
        /// There are no comments for EngineeringChangeSeverityRuleSets in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeSeverityRuleSet> EngineeringChangeSeverityRuleSets
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeSeverityRuleSets == null))
                {
                    this._EngineeringChangeSeverityRuleSets = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeSeverityRuleSet>(GetPath("EngineeringChangeSeverityRuleSets"));
                }
                return this._EngineeringChangeSeverityRuleSets;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeSeverityRuleSet> _EngineeringChangeSeverityRuleSets;
    }
        /// <summary>
        /// There are no comments for EngineeringChangeSeverity in the schema.
        /// </summary>
    /// <KeyProperties>
    /// SeverityName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("SeverityName")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeSeverities")]
    public partial class EngineeringChangeSeverity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeSeverity object.
        /// </summary>
        /// <param name="severityName">Initial value of SeverityName.</param>
        /// <param name="sequenceNumber">Initial value of SequenceNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeSeverity CreateEngineeringChangeSeverity(string severityName, decimal sequenceNumber)
        {
            EngineeringChangeSeverity engineeringChangeSeverity = new EngineeringChangeSeverity();
            engineeringChangeSeverity.SeverityName = severityName;
            engineeringChangeSeverity.SequenceNumber = sequenceNumber;
            return engineeringChangeSeverity;
        }
        /// <summary>
        /// There are no comments for Property SeverityName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SeverityName
        {
            get
            {
                return this._SeverityName;
            }
            set
            {
                this.OnSeverityNameChanging(value);
                this._SeverityName = value;
                this.OnSeverityNameChanged();
                this.OnPropertyChanged("SeverityName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SeverityName;
        partial void OnSeverityNameChanging(string value);
        partial void OnSeverityNameChanged();
        /// <summary>
        /// There are no comments for Property SequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SequenceNumber
        {
            get
            {
                return this._SequenceNumber;
            }
            set
            {
                this.OnSequenceNumberChanging(value);
                this._SequenceNumber = value;
                this.OnSequenceNumberChanged();
                this.OnPropertyChanged("SequenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SequenceNumber;
        partial void OnSequenceNumberChanging(decimal value);
        partial void OnSequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderHeader> EngineeringChangeOrderHeaders
        {
            get
            {
                return this._EngineeringChangeOrderHeaders;
            }
            set
            {
                this.OnEngineeringChangeOrderHeadersChanging(value);
                this._EngineeringChangeOrderHeaders = value;
                this.OnEngineeringChangeOrderHeadersChanged();
                this.OnPropertyChanged("EngineeringChangeOrderHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderHeader> _EngineeringChangeOrderHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeOrderHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderHeader> value);
        partial void OnEngineeringChangeOrderHeadersChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeSeverityRuleSets in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeSeverityRuleSet> EngineeringChangeSeverityRuleSets
        {
            get
            {
                return this._EngineeringChangeSeverityRuleSets;
            }
            set
            {
                this.OnEngineeringChangeSeverityRuleSetsChanging(value);
                this._EngineeringChangeSeverityRuleSets = value;
                this.OnEngineeringChangeSeverityRuleSetsChanged();
                this.OnPropertyChanged("EngineeringChangeSeverityRuleSets");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeSeverityRuleSet> _EngineeringChangeSeverityRuleSets = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeSeverityRuleSet>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeSeverityRuleSetsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeSeverityRuleSet> value);
        partial void OnEngineeringChangeSeverityRuleSetsChanged();
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
