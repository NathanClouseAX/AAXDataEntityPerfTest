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
        /// There are no comments for EngineeringChangeOrderDependencySingle in the schema.
        /// </summary>
    public partial class EngineeringChangeOrderDependencySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderDependency>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeOrderDependencySingle object.
        /// </summary>
        public EngineeringChangeOrderDependencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderDependencySingle object.
        /// </summary>
        public EngineeringChangeOrderDependencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderDependencySingle object.
        /// </summary>
        public EngineeringChangeOrderDependencySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderDependency> query)
            : base(query) {}

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
        /// There are no comments for EngineeringChangeOrderHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderHeaderSingle EngineeringChangeOrderHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderHeader == null))
                {
                    this._EngineeringChangeOrderHeader = new global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderHeaderSingle(this.Context, GetPath("EngineeringChangeOrderHeader"));
                }
                return this._EngineeringChangeOrderHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderHeaderSingle _EngineeringChangeOrderHeader;
        /// <summary>
        /// There are no comments for EngineeringChangeOrderDependencyActions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderDependencyAction> EngineeringChangeOrderDependencyActions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderDependencyActions == null))
                {
                    this._EngineeringChangeOrderDependencyActions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderDependencyAction>(GetPath("EngineeringChangeOrderDependencyActions"));
                }
                return this._EngineeringChangeOrderDependencyActions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderDependencyAction> _EngineeringChangeOrderDependencyActions;
    }
        /// <summary>
        /// There are no comments for EngineeringChangeOrderDependency in the schema.
        /// </summary>
    /// <KeyProperties>
    /// DependentProductNumber
    /// DependencyLegalEntityId
    /// DependencyTransactionDescription
    /// EngineeringChangeOrderNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DependentProductNumber", "DependencyLegalEntityId", "DependencyTransactionDescription", "EngineeringChangeOrderNumber")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeOrderDependencies")]
    public partial class EngineeringChangeOrderDependency : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeOrderDependency object.
        /// </summary>
        /// <param name="dependentProductNumber">Initial value of DependentProductNumber.</param>
        /// <param name="dependencyLegalEntityId">Initial value of DependencyLegalEntityId.</param>
        /// <param name="dependencyTransactionDescription">Initial value of DependencyTransactionDescription.</param>
        /// <param name="engineeringChangeOrderNumber">Initial value of EngineeringChangeOrderNumber.</param>
        /// <param name="dependentProduct">Initial value of DependentProduct.</param>
        /// <param name="engineeringChangeOrderHeader">Initial value of EngineeringChangeOrderHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeOrderDependency CreateEngineeringChangeOrderDependency(string dependentProductNumber, 
                    string dependencyLegalEntityId, 
                    string dependencyTransactionDescription, 
                    string engineeringChangeOrderNumber, 
                    global::Microsoft.Dynamics.DataEntities.ProductV2 dependentProduct, 
                    global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderHeader engineeringChangeOrderHeader)
        {
            EngineeringChangeOrderDependency engineeringChangeOrderDependency = new EngineeringChangeOrderDependency();
            engineeringChangeOrderDependency.DependentProductNumber = dependentProductNumber;
            engineeringChangeOrderDependency.DependencyLegalEntityId = dependencyLegalEntityId;
            engineeringChangeOrderDependency.DependencyTransactionDescription = dependencyTransactionDescription;
            engineeringChangeOrderDependency.EngineeringChangeOrderNumber = engineeringChangeOrderNumber;
            if ((dependentProduct == null))
            {
                throw new global::System.ArgumentNullException("dependentProduct");
            }
            engineeringChangeOrderDependency.DependentProduct = dependentProduct;
            if ((engineeringChangeOrderHeader == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangeOrderHeader");
            }
            engineeringChangeOrderDependency.EngineeringChangeOrderHeader = engineeringChangeOrderHeader;
            return engineeringChangeOrderDependency;
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
        /// There are no comments for Property EngineeringChangeOrderHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderHeader EngineeringChangeOrderHeader
        {
            get
            {
                return this._EngineeringChangeOrderHeader;
            }
            set
            {
                this.OnEngineeringChangeOrderHeaderChanging(value);
                this._EngineeringChangeOrderHeader = value;
                this.OnEngineeringChangeOrderHeaderChanged();
                this.OnPropertyChanged("EngineeringChangeOrderHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderHeader _EngineeringChangeOrderHeader;
        partial void OnEngineeringChangeOrderHeaderChanging(global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderHeader value);
        partial void OnEngineeringChangeOrderHeaderChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderDependencyActions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderDependencyAction> EngineeringChangeOrderDependencyActions
        {
            get
            {
                return this._EngineeringChangeOrderDependencyActions;
            }
            set
            {
                this.OnEngineeringChangeOrderDependencyActionsChanging(value);
                this._EngineeringChangeOrderDependencyActions = value;
                this.OnEngineeringChangeOrderDependencyActionsChanged();
                this.OnPropertyChanged("EngineeringChangeOrderDependencyActions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderDependencyAction> _EngineeringChangeOrderDependencyActions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderDependencyAction>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeOrderDependencyActionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderDependencyAction> value);
        partial void OnEngineeringChangeOrderDependencyActionsChanged();
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
