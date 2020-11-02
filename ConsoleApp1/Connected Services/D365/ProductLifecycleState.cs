﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:55:10 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for ProductLifecycleStateSingle in the schema.
    /// </summary>
    public partial class ProductLifecycleStateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductLifecycleState>
    {
        /// <summary>
        /// Initialize a new ProductLifecycleStateSingle object.
        /// </summary>
        public ProductLifecycleStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductLifecycleStateSingle object.
        /// </summary>
        public ProductLifecycleStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductLifecycleStateSingle object.
        /// </summary>
        public ProductLifecycleStateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductLifecycleState> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductsV2 == null))
                {
                    this._ReleasedProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(GetPath("ReleasedProductsV2"));
                }
                return this._ReleasedProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2;
        /// <summary>
        /// There are no comments for ReleasedProductVariantsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantV2> ReleasedProductVariantsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductVariantsV2 == null))
                {
                    this._ReleasedProductVariantsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantV2>(GetPath("ReleasedProductVariantsV2"));
                }
                return this._ReleasedProductVariantsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantV2> _ReleasedProductVariantsV2;
        /// <summary>
        /// There are no comments for ReleasedProductVariants in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariant> ReleasedProductVariants
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductVariants == null))
                {
                    this._ReleasedProductVariants = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariant>(GetPath("ReleasedProductVariants"));
                }
                return this._ReleasedProductVariants;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariant> _ReleasedProductVariants;
    }
    /// <summary>
    /// There are no comments for ProductLifecycleState in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LifecycleStateId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LifecycleStateId")]
    [global::Microsoft.OData.Client.EntitySet("ProductLifecycleStates")]
    public partial class ProductLifecycleState : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductLifecycleState object.
        /// </summary>
        /// <param name="lifecycleStateId">Initial value of LifecycleStateId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductLifecycleState CreateProductLifecycleState(string lifecycleStateId)
        {
            ProductLifecycleState productLifecycleState = new ProductLifecycleState();
            productLifecycleState.LifecycleStateId = lifecycleStateId;
            return productLifecycleState;
        }
        /// <summary>
        /// There are no comments for Property LifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LifecycleStateId
        {
            get
            {
                return this._LifecycleStateId;
            }
            set
            {
                this.OnLifecycleStateIdChanging(value);
                this._LifecycleStateId = value;
                this.OnLifecycleStateIdChanged();
                this.OnPropertyChanged("LifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LifecycleStateId;
        partial void OnLifecycleStateIdChanging(string value);
        partial void OnLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property IsDefaultOnProductRelease in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefaultOnProductRelease
        {
            get
            {
                return this._IsDefaultOnProductRelease;
            }
            set
            {
                this.OnIsDefaultOnProductReleaseChanging(value);
                this._IsDefaultOnProductRelease = value;
                this.OnIsDefaultOnProductReleaseChanged();
                this.OnPropertyChanged("IsDefaultOnProductRelease");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefaultOnProductRelease;
        partial void OnIsDefaultOnProductReleaseChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultOnProductReleaseChanged();
        /// <summary>
        /// There are no comments for Property LifecycleStateDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LifecycleStateDescription
        {
            get
            {
                return this._LifecycleStateDescription;
            }
            set
            {
                this.OnLifecycleStateDescriptionChanging(value);
                this._LifecycleStateDescription = value;
                this.OnLifecycleStateDescriptionChanged();
                this.OnPropertyChanged("LifecycleStateDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LifecycleStateDescription;
        partial void OnLifecycleStateDescriptionChanging(string value);
        partial void OnLifecycleStateDescriptionChanged();
        /// <summary>
        /// There are no comments for Property IsActiveForPlanning in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsActiveForPlanning
        {
            get
            {
                return this._IsActiveForPlanning;
            }
            set
            {
                this.OnIsActiveForPlanningChanging(value);
                this._IsActiveForPlanning = value;
                this.OnIsActiveForPlanningChanged();
                this.OnPropertyChanged("IsActiveForPlanning");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsActiveForPlanning;
        partial void OnIsActiveForPlanningChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsActiveForPlanningChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                return this._ReleasedProductsV2;
            }
            set
            {
                this.OnReleasedProductsV2Changing(value);
                this._ReleasedProductsV2 = value;
                this.OnReleasedProductsV2Changed();
                this.OnPropertyChanged("ReleasedProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> value);
        partial void OnReleasedProductsV2Changed();
        /// <summary>
        /// There are no comments for Property ReleasedProductVariantsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantV2> ReleasedProductVariantsV2
        {
            get
            {
                return this._ReleasedProductVariantsV2;
            }
            set
            {
                this.OnReleasedProductVariantsV2Changing(value);
                this._ReleasedProductVariantsV2 = value;
                this.OnReleasedProductVariantsV2Changed();
                this.OnPropertyChanged("ReleasedProductVariantsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantV2> _ReleasedProductVariantsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductVariantsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantV2> value);
        partial void OnReleasedProductVariantsV2Changed();
        /// <summary>
        /// There are no comments for Property ReleasedProductVariants in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariant> ReleasedProductVariants
        {
            get
            {
                return this._ReleasedProductVariants;
            }
            set
            {
                this.OnReleasedProductVariantsChanging(value);
                this._ReleasedProductVariants = value;
                this.OnReleasedProductVariantsChanged();
                this.OnPropertyChanged("ReleasedProductVariants");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariant> _ReleasedProductVariants = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariant>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductVariantsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariant> value);
        partial void OnReleasedProductVariantsChanged();
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