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
        /// There are no comments for EngineeringChangeRequestDependencySingle in the schema.
        /// </summary>
    public partial class EngineeringChangeRequestDependencySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeRequestDependency>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeRequestDependencySingle object.
        /// </summary>
        public EngineeringChangeRequestDependencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeRequestDependencySingle object.
        /// </summary>
        public EngineeringChangeRequestDependencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeRequestDependencySingle object.
        /// </summary>
        public EngineeringChangeRequestDependencySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeRequestDependency> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringChangeRequestDependencyActions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependencyAction> EngineeringChangeRequestDependencyActions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeRequestDependencyActions == null))
                {
                    this._EngineeringChangeRequestDependencyActions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependencyAction>(GetPath("EngineeringChangeRequestDependencyActions"));
                }
                return this._EngineeringChangeRequestDependencyActions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependencyAction> _EngineeringChangeRequestDependencyActions;
        /// <summary>
        /// There are no comments for DependentProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductV2Single DependentProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DependentProduct == null))
                {
                    this._DependentProduct = new global::Microsoft.Dynamics.DataEntities.ProductV2Single(this.Context, GetPath("DependentProduct"));
                }
                return this._DependentProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductV2Single _DependentProduct;
        /// <summary>
        /// There are no comments for EngineeringChangeRequestHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestHeaderSingle EngineeringChangeRequestHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeRequestHeader == null))
                {
                    this._EngineeringChangeRequestHeader = new global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestHeaderSingle(this.Context, GetPath("EngineeringChangeRequestHeader"));
                }
                return this._EngineeringChangeRequestHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestHeaderSingle _EngineeringChangeRequestHeader;
    }
        /// <summary>
        /// There are no comments for EngineeringChangeRequestDependency in the schema.
        /// </summary>
    /// <KeyProperties>
    /// DependentProductNumber
    /// DependencyLegalEntityId
    /// DependencyTransactionDescription
    /// EngineeringChangeRequestNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DependentProductNumber", "DependencyLegalEntityId", "DependencyTransactionDescription", "EngineeringChangeRequestNumber")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeRequestDependencies")]
    public partial class EngineeringChangeRequestDependency : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeRequestDependency object.
        /// </summary>
        /// <param name="dependentProductNumber">Initial value of DependentProductNumber.</param>
        /// <param name="dependencyLegalEntityId">Initial value of DependencyLegalEntityId.</param>
        /// <param name="dependencyTransactionDescription">Initial value of DependencyTransactionDescription.</param>
        /// <param name="engineeringChangeRequestNumber">Initial value of EngineeringChangeRequestNumber.</param>
        /// <param name="dependentProduct">Initial value of DependentProduct.</param>
        /// <param name="engineeringChangeRequestHeader">Initial value of EngineeringChangeRequestHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeRequestDependency CreateEngineeringChangeRequestDependency(string dependentProductNumber, 
                    string dependencyLegalEntityId, 
                    string dependencyTransactionDescription, 
                    string engineeringChangeRequestNumber, 
                    global::Microsoft.Dynamics.DataEntities.ProductV2 dependentProduct, 
                    global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestHeader engineeringChangeRequestHeader)
        {
            EngineeringChangeRequestDependency engineeringChangeRequestDependency = new EngineeringChangeRequestDependency();
            engineeringChangeRequestDependency.DependentProductNumber = dependentProductNumber;
            engineeringChangeRequestDependency.DependencyLegalEntityId = dependencyLegalEntityId;
            engineeringChangeRequestDependency.DependencyTransactionDescription = dependencyTransactionDescription;
            engineeringChangeRequestDependency.EngineeringChangeRequestNumber = engineeringChangeRequestNumber;
            if ((dependentProduct == null))
            {
                throw new global::System.ArgumentNullException("dependentProduct");
            }
            engineeringChangeRequestDependency.DependentProduct = dependentProduct;
            if ((engineeringChangeRequestHeader == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangeRequestHeader");
            }
            engineeringChangeRequestDependency.EngineeringChangeRequestHeader = engineeringChangeRequestHeader;
            return engineeringChangeRequestDependency;
        }
        /// <summary>
        /// There are no comments for Property DependentProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DependentProductNumber
        {
            get
            {
                return this._DependentProductNumber;
            }
            set
            {
                this.OnDependentProductNumberChanging(value);
                this._DependentProductNumber = value;
                this.OnDependentProductNumberChanged();
                this.OnPropertyChanged("DependentProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DependentProductNumber;
        partial void OnDependentProductNumberChanging(string value);
        partial void OnDependentProductNumberChanged();
        /// <summary>
        /// There are no comments for Property DependencyLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DependencyLegalEntityId
        {
            get
            {
                return this._DependencyLegalEntityId;
            }
            set
            {
                this.OnDependencyLegalEntityIdChanging(value);
                this._DependencyLegalEntityId = value;
                this.OnDependencyLegalEntityIdChanged();
                this.OnPropertyChanged("DependencyLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DependencyLegalEntityId;
        partial void OnDependencyLegalEntityIdChanging(string value);
        partial void OnDependencyLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property DependencyTransactionDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DependencyTransactionDescription
        {
            get
            {
                return this._DependencyTransactionDescription;
            }
            set
            {
                this.OnDependencyTransactionDescriptionChanging(value);
                this._DependencyTransactionDescription = value;
                this.OnDependencyTransactionDescriptionChanged();
                this.OnPropertyChanged("DependencyTransactionDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DependencyTransactionDescription;
        partial void OnDependencyTransactionDescriptionChanging(string value);
        partial void OnDependencyTransactionDescriptionChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeRequestNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeRequestNumber
        {
            get
            {
                return this._EngineeringChangeRequestNumber;
            }
            set
            {
                this.OnEngineeringChangeRequestNumberChanging(value);
                this._EngineeringChangeRequestNumber = value;
                this.OnEngineeringChangeRequestNumberChanged();
                this.OnPropertyChanged("EngineeringChangeRequestNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeRequestNumber;
        partial void OnEngineeringChangeRequestNumberChanging(string value);
        partial void OnEngineeringChangeRequestNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeRequestDependencyActions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependencyAction> EngineeringChangeRequestDependencyActions
        {
            get
            {
                return this._EngineeringChangeRequestDependencyActions;
            }
            set
            {
                this.OnEngineeringChangeRequestDependencyActionsChanging(value);
                this._EngineeringChangeRequestDependencyActions = value;
                this.OnEngineeringChangeRequestDependencyActionsChanged();
                this.OnPropertyChanged("EngineeringChangeRequestDependencyActions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependencyAction> _EngineeringChangeRequestDependencyActions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependencyAction>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeRequestDependencyActionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestDependencyAction> value);
        partial void OnEngineeringChangeRequestDependencyActionsChanged();
        /// <summary>
        /// There are no comments for Property DependentProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductV2 DependentProduct
        {
            get
            {
                return this._DependentProduct;
            }
            set
            {
                this.OnDependentProductChanging(value);
                this._DependentProduct = value;
                this.OnDependentProductChanged();
                this.OnPropertyChanged("DependentProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductV2 _DependentProduct;
        partial void OnDependentProductChanging(global::Microsoft.Dynamics.DataEntities.ProductV2 value);
        partial void OnDependentProductChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeRequestHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestHeader EngineeringChangeRequestHeader
        {
            get
            {
                return this._EngineeringChangeRequestHeader;
            }
            set
            {
                this.OnEngineeringChangeRequestHeaderChanging(value);
                this._EngineeringChangeRequestHeader = value;
                this.OnEngineeringChangeRequestHeaderChanged();
                this.OnPropertyChanged("EngineeringChangeRequestHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestHeader _EngineeringChangeRequestHeader;
        partial void OnEngineeringChangeRequestHeaderChanging(global::Microsoft.Dynamics.DataEntities.EngineeringChangeRequestHeader value);
        partial void OnEngineeringChangeRequestHeaderChanged();
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
