﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/28/2021 8:55:09 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for ProductOwnerWorkerSingle in the schema.
    /// </summary>
    public partial class ProductOwnerWorkerSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductOwnerWorker>
    {
        /// <summary>
        /// Initialize a new ProductOwnerWorkerSingle object.
        /// </summary>
        public ProductOwnerWorkerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductOwnerWorkerSingle object.
        /// </summary>
        public ProductOwnerWorkerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductOwnerWorkerSingle object.
        /// </summary>
        public ProductOwnerWorkerSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductOwnerWorker> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductOwner in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductOwnerSingle ProductOwner
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductOwner == null))
                {
                    this._ProductOwner = new global::Microsoft.Dynamics.DataEntities.ProductOwnerSingle(this.Context, GetPath("ProductOwner"));
                }
                return this._ProductOwner;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductOwnerSingle _ProductOwner;
        /// <summary>
        /// There are no comments for AssignedWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle AssignedWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssignedWorker == null))
                {
                    this._AssignedWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("AssignedWorker"));
                }
                return this._AssignedWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _AssignedWorker;
    }
    /// <summary>
    /// There are no comments for ProductOwnerWorker in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductOwnerId
    /// AssignedPersonnelNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductOwnerId", "AssignedPersonnelNumber")]
    [global::Microsoft.OData.Client.EntitySet("ProductOwnerWorkers")]
    public partial class ProductOwnerWorker : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductOwnerWorker object.
        /// </summary>
        /// <param name="productOwnerId">Initial value of ProductOwnerId.</param>
        /// <param name="assignedPersonnelNumber">Initial value of AssignedPersonnelNumber.</param>
        /// <param name="productOwner">Initial value of ProductOwner.</param>
        /// <param name="assignedWorker">Initial value of AssignedWorker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductOwnerWorker CreateProductOwnerWorker(string productOwnerId, string assignedPersonnelNumber, global::Microsoft.Dynamics.DataEntities.ProductOwner productOwner, global::Microsoft.Dynamics.DataEntities.Worker assignedWorker)
        {
            ProductOwnerWorker productOwnerWorker = new ProductOwnerWorker();
            productOwnerWorker.ProductOwnerId = productOwnerId;
            productOwnerWorker.AssignedPersonnelNumber = assignedPersonnelNumber;
            if ((productOwner == null))
            {
                throw new global::System.ArgumentNullException("productOwner");
            }
            productOwnerWorker.ProductOwner = productOwner;
            if ((assignedWorker == null))
            {
                throw new global::System.ArgumentNullException("assignedWorker");
            }
            productOwnerWorker.AssignedWorker = assignedWorker;
            return productOwnerWorker;
        }
        /// <summary>
        /// There are no comments for Property ProductOwnerId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductOwnerId is required.")]
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
        /// There are no comments for Property AssignedPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssignedPersonnelNumber is required.")]
        public virtual string AssignedPersonnelNumber
        {
            get
            {
                return this._AssignedPersonnelNumber;
            }
            set
            {
                this.OnAssignedPersonnelNumberChanging(value);
                this._AssignedPersonnelNumber = value;
                this.OnAssignedPersonnelNumberChanged();
                this.OnPropertyChanged("AssignedPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AssignedPersonnelNumber;
        partial void OnAssignedPersonnelNumberChanging(string value);
        partial void OnAssignedPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductOwner in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductOwner is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductOwner ProductOwner
        {
            get
            {
                return this._ProductOwner;
            }
            set
            {
                this.OnProductOwnerChanging(value);
                this._ProductOwner = value;
                this.OnProductOwnerChanged();
                this.OnPropertyChanged("ProductOwner");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductOwner _ProductOwner;
        partial void OnProductOwnerChanging(global::Microsoft.Dynamics.DataEntities.ProductOwner value);
        partial void OnProductOwnerChanged();
        /// <summary>
        /// There are no comments for Property AssignedWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssignedWorker is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker AssignedWorker
        {
            get
            {
                return this._AssignedWorker;
            }
            set
            {
                this.OnAssignedWorkerChanging(value);
                this._AssignedWorker = value;
                this.OnAssignedWorkerChanged();
                this.OnPropertyChanged("AssignedWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _AssignedWorker;
        partial void OnAssignedWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnAssignedWorkerChanged();
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
