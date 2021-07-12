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
        /// There are no comments for BudgetSubModelSingle in the schema.
        /// </summary>
    public partial class BudgetSubModelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetSubModel>
    {
        /// <summary>
        /// Initialize a new BudgetSubModelSingle object.
        /// </summary>
        public BudgetSubModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetSubModelSingle object.
        /// </summary>
        public BudgetSubModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetSubModelSingle object.
        /// </summary>
        public BudgetSubModelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetSubModel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetModelSubmodels in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetModelSingle BudgetModelSubmodels
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetModelSubmodels == null))
                {
                    this._BudgetModelSubmodels = new global::Microsoft.Dynamics.DataEntities.BudgetModelSingle(this.Context, GetPath("BudgetModelSubmodels"));
                }
                return this._BudgetModelSubmodels;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetModelSingle _BudgetModelSubmodels;
        /// <summary>
        /// There are no comments for BudgetSubmodelBudgetModels in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetModelSingle BudgetSubmodelBudgetModels
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetSubmodelBudgetModels == null))
                {
                    this._BudgetSubmodelBudgetModels = new global::Microsoft.Dynamics.DataEntities.BudgetModelSingle(this.Context, GetPath("BudgetSubmodelBudgetModels"));
                }
                return this._BudgetSubmodelBudgetModels;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetModelSingle _BudgetSubmodelBudgetModels;
    }
        /// <summary>
        /// There are no comments for BudgetSubModel in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// BudgetModel
    /// Submodel
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "BudgetModel", "Submodel")]
    [global::Microsoft.OData.Client.EntitySet("BudgetSubModels")]
    public partial class BudgetSubModel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetSubModel object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="budgetModel">Initial value of BudgetModel.</param>
        /// <param name="submodel">Initial value of Submodel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetSubModel CreateBudgetSubModel(string dataAreaId, string budgetModel, string submodel)
        {
            BudgetSubModel budgetSubModel = new BudgetSubModel();
            budgetSubModel.dataAreaId = dataAreaId;
            budgetSubModel.BudgetModel = budgetModel;
            budgetSubModel.Submodel = submodel;
            return budgetSubModel;
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
        /// There are no comments for Property BudgetModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BudgetModel
        {
            get
            {
                return this._BudgetModel;
            }
            set
            {
                this.OnBudgetModelChanging(value);
                this._BudgetModel = value;
                this.OnBudgetModelChanged();
                this.OnPropertyChanged("BudgetModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetModel;
        partial void OnBudgetModelChanging(string value);
        partial void OnBudgetModelChanged();
        /// <summary>
        /// There are no comments for Property Submodel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Submodel
        {
            get
            {
                return this._Submodel;
            }
            set
            {
                this.OnSubmodelChanging(value);
                this._Submodel = value;
                this.OnSubmodelChanged();
                this.OnPropertyChanged("Submodel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Submodel;
        partial void OnSubmodelChanging(string value);
        partial void OnSubmodelChanged();
        /// <summary>
        /// There are no comments for Property BudgetModelSubmodels in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetModel BudgetModelSubmodels
        {
            get
            {
                return this._BudgetModelSubmodels;
            }
            set
            {
                this.OnBudgetModelSubmodelsChanging(value);
                this._BudgetModelSubmodels = value;
                this.OnBudgetModelSubmodelsChanged();
                this.OnPropertyChanged("BudgetModelSubmodels");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetModel _BudgetModelSubmodels;
        partial void OnBudgetModelSubmodelsChanging(global::Microsoft.Dynamics.DataEntities.BudgetModel value);
        partial void OnBudgetModelSubmodelsChanged();
        /// <summary>
        /// There are no comments for Property BudgetSubmodelBudgetModels in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetModel BudgetSubmodelBudgetModels
        {
            get
            {
                return this._BudgetSubmodelBudgetModels;
            }
            set
            {
                this.OnBudgetSubmodelBudgetModelsChanging(value);
                this._BudgetSubmodelBudgetModels = value;
                this.OnBudgetSubmodelBudgetModelsChanged();
                this.OnPropertyChanged("BudgetSubmodelBudgetModels");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetModel _BudgetSubmodelBudgetModels;
        partial void OnBudgetSubmodelBudgetModelsChanging(global::Microsoft.Dynamics.DataEntities.BudgetModel value);
        partial void OnBudgetSubmodelBudgetModelsChanged();
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
