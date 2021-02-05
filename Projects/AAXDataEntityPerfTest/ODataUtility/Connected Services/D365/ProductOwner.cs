﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for ProductOwnerSingle in the schema.
        /// </summary>
    public partial class ProductOwnerSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductOwner>
    {
        /// <summary>
        /// Initialize a new ProductOwnerSingle object.
        /// </summary>
        public ProductOwnerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductOwnerSingle object.
        /// </summary>
        public ProductOwnerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductOwnerSingle object.
        /// </summary>
        public ProductOwnerSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductOwner> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringChangeOrderProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> EngineeringChangeOrderProducts
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProducts == null))
                {
                    this._EngineeringChangeOrderProducts = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct>(GetPath("EngineeringChangeOrderProducts"));
                }
                return this._EngineeringChangeOrderProducts;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> _EngineeringChangeOrderProducts;
        /// <summary>
        /// There are no comments for ProductOwnerWorkerAssignments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductOwnerWorker> ProductOwnerWorkerAssignments
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductOwnerWorkerAssignments == null))
                {
                    this._ProductOwnerWorkerAssignments = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductOwnerWorker>(GetPath("ProductOwnerWorkerAssignments"));
                }
                return this._ProductOwnerWorkerAssignments;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductOwnerWorker> _ProductOwnerWorkerAssignments;
    }
        /// <summary>
        /// There are no comments for ProductOwner in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ProductOwnerId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductOwnerId")]
    [global::Microsoft.OData.Client.EntitySet("ProductOwners")]
    public partial class ProductOwner : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductOwner object.
        /// </summary>
        /// <param name="productOwnerId">Initial value of ProductOwnerId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductOwner CreateProductOwner(string productOwnerId)
        {
            ProductOwner productOwner = new ProductOwner();
            productOwner.ProductOwnerId = productOwnerId;
            return productOwner;
        }
        /// <summary>
        /// There are no comments for Property ProductOwnerId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductOwnerId
        {
            get
            {
                return this._ProductOwnerId;
            }
            set
            {
                this.OnProductOwnerIdChanging(value);
                this._ProductOwnerId = value;
                this.OnProductOwnerIdChanged();
                this.OnPropertyChanged("ProductOwnerId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductOwnerId;
        partial void OnProductOwnerIdChanging(string value);
        partial void OnProductOwnerIdChanged();
        /// <summary>
        /// There are no comments for Property ProductOwnerName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductOwnerName
        {
            get
            {
                return this._ProductOwnerName;
            }
            set
            {
                this.OnProductOwnerNameChanging(value);
                this._ProductOwnerName = value;
                this.OnProductOwnerNameChanged();
                this.OnPropertyChanged("ProductOwnerName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductOwnerName;
        partial void OnProductOwnerNameChanging(string value);
        partial void OnProductOwnerNameChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> EngineeringChangeOrderProducts
        {
            get
            {
                return this._EngineeringChangeOrderProducts;
            }
            set
            {
                this.OnEngineeringChangeOrderProductsChanging(value);
                this._EngineeringChangeOrderProducts = value;
                this.OnEngineeringChangeOrderProductsChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProducts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> _EngineeringChangeOrderProducts = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeOrderProductsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> value);
        partial void OnEngineeringChangeOrderProductsChanged();
        /// <summary>
        /// There are no comments for Property ProductOwnerWorkerAssignments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductOwnerWorker> ProductOwnerWorkerAssignments
        {
            get
            {
                return this._ProductOwnerWorkerAssignments;
            }
            set
            {
                this.OnProductOwnerWorkerAssignmentsChanging(value);
                this._ProductOwnerWorkerAssignments = value;
                this.OnProductOwnerWorkerAssignmentsChanged();
                this.OnPropertyChanged("ProductOwnerWorkerAssignments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductOwnerWorker> _ProductOwnerWorkerAssignments = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductOwnerWorker>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductOwnerWorkerAssignmentsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductOwnerWorker> value);
        partial void OnProductOwnerWorkerAssignmentsChanged();
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
